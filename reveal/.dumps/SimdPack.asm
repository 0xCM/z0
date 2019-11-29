; 2019-11-28 20:16:39:893
; function: Vector128<uint> pack(NatSpan<N128,bit> src)
; location: [7FFDDB020230h, 7FFDDB0202C5h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,68h                   ; SUB(Sub_rm64_imm8) [RSP,68h:imm64]                   encoding(4 bytes) = 48 83 ec 68
0006h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0009h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000ch lea rdi,[rsp+28h]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 7c 24 28
0011h mov ecx,10h                   ; MOV(Mov_r32_imm32) [ECX,10h:imm32]                   encoding(5 bytes) = b9 10 00 00 00
0016h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0018h rep stosd                     ; STOSD(Stosd_m32_EAX) [mem(32u),EAX]                  encoding(2 bytes) = f3 ab
001ah mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
001dh mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0020h mov byte ptr [rsp+40h],0      ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,:sr),0h:imm8]       encoding(5 bytes) = c6 44 24 40 00
0025h movsx rcx,byte ptr [rsp+40h]  ; MOVSX(Movsx_r64_rm8) [RCX,mem(8i,RSP:br,:sr)]        encoding(6 bytes) = 48 0f be 4c 24 40
002bh mov [rsp+50h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),CL]              encoding(4 bytes) = 88 4c 24 50
002fh mov byte ptr [rsp+38h],0      ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,:sr),0h:imm8]       encoding(5 bytes) = c6 44 24 38 00
0034h movsx rcx,byte ptr [rsp+38h]  ; MOVSX(Movsx_r64_rm8) [RCX,mem(8i,RSP:br,:sr)]        encoding(6 bytes) = 48 0f be 4c 24 38
003ah mov [rsp+48h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),CL]              encoding(4 bytes) = 88 4c 24 48
003eh mov rcx,[rdx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 0a
0041h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 52 08
0044h lea r8,[rsp+28h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,:sr)]          encoding(5 bytes) = 4c 8d 44 24 28
0049h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
004dh vmovdqu xmmword ptr [r8],xmm0 ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R8:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 00
0052h lea r8,[rsp+28h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,:sr)]          encoding(5 bytes) = 4c 8d 44 24 28
0057h mov [r8],rcx                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RCX]           encoding(3 bytes) = 49 89 08
005ah mov [r8+8],edx                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),EDX]           encoding(4 bytes) = 41 89 50 08
005eh vmovdqu xmm0,xmmword ptr [rsp+28h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 28
0064h vmovdqu xmmword ptr [rsp+58h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 58
006ah lea rcx,[rsp+58h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 58
006fh mov r9,[rcx]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,RCX:br,:sr)]           encoding(3 bytes) = 4c 8b 09
0072h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0075h movsx rdx,byte ptr [rsp+50h]  ; MOVSX(Movsx_r64_rm8) [RDX,mem(8i,RSP:br,:sr)]        encoding(6 bytes) = 48 0f be 54 24 50
007bh movsx r8,byte ptr [rsp+48h]   ; MOVSX(Movsx_r64_rm8) [R8,mem(8i,RSP:br,:sr)]         encoding(6 bytes) = 4c 0f be 44 24 48
0081h call 7FFDDA9247A8h            ; CALL(Call_rel32_64) [FFFFFFFFFF904578h:jmp64]        encoding(5 bytes) = e8 f2 44 90 ff
0086h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0089h add rsp,68h                   ; ADD(Add_rm64_imm8) [RSP,68h:imm64]                   encoding(4 bytes) = 48 83 c4 68
008dh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
008eh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
008fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0090h call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F52EB20h:jmp64]                encoding(5 bytes) = e8 8b ea 52 5f
0095h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packBytes => new byte[150]{0x57,0x56,0x48,0x83,0xEC,0x68,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0x48,0x8D,0x7C,0x24,0x28,0xB9,0x10,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0x48,0x8B,0xF1,0xC6,0x44,0x24,0x40,0x00,0x48,0x0F,0xBE,0x4C,0x24,0x40,0x88,0x4C,0x24,0x50,0xC6,0x44,0x24,0x38,0x00,0x48,0x0F,0xBE,0x4C,0x24,0x38,0x88,0x4C,0x24,0x48,0x48,0x8B,0x0A,0x8B,0x52,0x08,0x4C,0x8D,0x44,0x24,0x28,0xC5,0xF8,0x57,0xC0,0xC4,0xC1,0x7A,0x7F,0x00,0x4C,0x8D,0x44,0x24,0x28,0x49,0x89,0x08,0x41,0x89,0x50,0x08,0xC5,0xFA,0x6F,0x44,0x24,0x28,0xC5,0xFA,0x7F,0x44,0x24,0x58,0x48,0x8D,0x4C,0x24,0x58,0x4C,0x8B,0x09,0x48,0x8B,0xCE,0x48,0x0F,0xBE,0x54,0x24,0x50,0x4C,0x0F,0xBE,0x44,0x24,0x48,0xE8,0xF2,0x44,0x90,0xFF,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x68,0x5E,0x5F,0xC3,0xE8,0x8B,0xEA,0x52,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> pack(N1 width, NatSpan<N128,uint> src)
; location: [7FFDDB0202F0h, 7FFDDB02032Bh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h mov [rsp+48h],rdx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RDX]          encoding(5 bytes) = 48 89 54 24 48
000ah mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000dh mov byte ptr [rsp+20h],0      ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,:sr),0h:imm8]       encoding(5 bytes) = c6 44 24 20 00
0012h movsx rcx,byte ptr [rsp+20h]  ; MOVSX(Movsx_r64_rm8) [RCX,mem(8i,RSP:br,:sr)]        encoding(6 bytes) = 48 0f be 4c 24 20
0018h mov [rsp+28h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),CL]              encoding(4 bytes) = 88 4c 24 28
001ch mov r9,[r8]                   ; MOV(Mov_r64_rm64) [R9,mem(64u,R8:br,:sr)]            encoding(3 bytes) = 4d 8b 08
001fh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0022h movsx rdx,byte ptr [rsp+48h]  ; MOVSX(Movsx_r64_rm8) [RDX,mem(8i,RSP:br,:sr)]        encoding(6 bytes) = 48 0f be 54 24 48
0028h movsx r8,byte ptr [rsp+28h]   ; MOVSX(Movsx_r64_rm8) [R8,mem(8i,RSP:br,:sr)]         encoding(6 bytes) = 4c 0f be 44 24 28
002eh call 7FFDDA9247A8h            ; CALL(Call_rel32_64) [FFFFFFFFFF9044B8h:jmp64]        encoding(5 bytes) = e8 85 44 90 ff
0033h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0036h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
003ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
003bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[60]{0x56,0x48,0x83,0xEC,0x30,0x48,0x89,0x54,0x24,0x48,0x48,0x8B,0xF1,0xC6,0x44,0x24,0x20,0x00,0x48,0x0F,0xBE,0x4C,0x24,0x20,0x88,0x4C,0x24,0x28,0x4D,0x8B,0x08,0x48,0x8B,0xCE,0x48,0x0F,0xBE,0x54,0x24,0x48,0x4C,0x0F,0xBE,0x44,0x24,0x28,0xE8,0x85,0x44,0x90,0xFF,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x30,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void pack1(ref Vector128<uint> xmm0, ref Vector128<uint> xmm1, in uint src, byte step, int offset)
; location: [7FFDDB020340h, 7FFDDB020374h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
0009h vmovupd xmm1,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 0a
000dh movzx eax,r9b                 ; MOVZX(Movzx_r32_rm8) [EAX,R9L]                       encoding(4 bytes) = 41 0f b6 c1
0011h vmovd xmm2,eax                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EAX]                 encoding(VEX, 4 bytes) = c5 f9 6e d0
0015h vpslld xmm1,xmm1,xmm2         ; VPSLLD(VEX_Vpslld_xmm_xmm_xmmm128) [XMM1,XMM1,XMM2]  encoding(VEX, 4 bytes) = c5 f1 f2 ca
0019h vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
001dh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0021h mov eax,[rsp+28h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 28
0025h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
0028h lea rax,[r8+rax*4]            ; LEA(Lea_r64_m) [RAX,mem(Unknown,R8:br,:sr)]          encoding(4 bytes) = 49 8d 04 80
002ch vlddqu xmm0,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 00
0030h vmovupd [rdx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RDX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 02
0034h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pack1Bytes => new byte[53]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x10,0x0A,0x41,0x0F,0xB6,0xC1,0xC5,0xF9,0x6E,0xD0,0xC5,0xF1,0xF2,0xCA,0xC5,0xF9,0xEB,0xC1,0xC5,0xF9,0x11,0x01,0x8B,0x44,0x24,0x28,0x48,0x63,0xC0,0x49,0x8D,0x04,0x80,0xC5,0xFB,0xF0,0x00,0xC5,0xF9,0x11,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> pack(N1 width, N32 n, in uint src)
; location: [7FFDDB020390h, 7FFDDB020606h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,r9                    ; MOV(Mov_r64_rm64) [RAX,R9]                           encoding(3 bytes) = 49 8b c1
0008h vlddqu xmm0,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 00
000ch lea rax,[r9+10h]              ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(4 bytes) = 49 8d 41 10
0010h vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
0014h vpslld xmm1,xmm1,1            ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,1h:imm8]  encoding(VEX, 5 bytes) = c5 f1 72 f1 01
0019h vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
001dh lea rax,[r9+20h]              ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(4 bytes) = 49 8d 41 20
0021h vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
0025h vpslld xmm1,xmm1,2            ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,2h:imm8]  encoding(VEX, 5 bytes) = c5 f1 72 f1 02
002ah vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
002eh lea rax,[r9+30h]              ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(4 bytes) = 49 8d 41 30
0032h vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
0036h vpslld xmm1,xmm1,3            ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,3h:imm8]  encoding(VEX, 5 bytes) = c5 f1 72 f1 03
003bh vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
003fh lea rax,[r9+40h]              ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(4 bytes) = 49 8d 41 40
0043h vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
0047h vpslld xmm1,xmm1,4            ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,4h:imm8]  encoding(VEX, 5 bytes) = c5 f1 72 f1 04
004ch vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
0050h lea rax,[r9+50h]              ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(4 bytes) = 49 8d 41 50
0054h vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
0058h vpslld xmm1,xmm1,5            ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,5h:imm8]  encoding(VEX, 5 bytes) = c5 f1 72 f1 05
005dh vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
0061h lea rax,[r9+60h]              ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(4 bytes) = 49 8d 41 60
0065h vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
0069h vpslld xmm1,xmm1,6            ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,6h:imm8]  encoding(VEX, 5 bytes) = c5 f1 72 f1 06
006eh vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
0072h lea rax,[r9+70h]              ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(4 bytes) = 49 8d 41 70
0076h vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
007ah vpslld xmm1,xmm1,7            ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,7h:imm8]  encoding(VEX, 5 bytes) = c5 f1 72 f1 07
007fh vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
0083h lea rax,[r9+80h]              ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(7 bytes) = 49 8d 81 80 00 00 00
008ah vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
008eh vpslld xmm1,xmm1,8            ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,8h:imm8]  encoding(VEX, 5 bytes) = c5 f1 72 f1 08
0093h vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
0097h lea rax,[r9+90h]              ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(7 bytes) = 49 8d 81 90 00 00 00
009eh vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
00a2h vpslld xmm1,xmm1,9            ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,9h:imm8]  encoding(VEX, 5 bytes) = c5 f1 72 f1 09
00a7h vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
00abh lea rax,[r9+0A0h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(7 bytes) = 49 8d 81 a0 00 00 00
00b2h vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
00b6h vpslld xmm1,xmm1,0Ah          ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,ah:imm8]  encoding(VEX, 5 bytes) = c5 f1 72 f1 0a
00bbh vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
00bfh lea rax,[r9+0B0h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(7 bytes) = 49 8d 81 b0 00 00 00
00c6h vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
00cah vpslld xmm1,xmm1,0Bh          ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,bh:imm8]  encoding(VEX, 5 bytes) = c5 f1 72 f1 0b
00cfh vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
00d3h lea rax,[r9+0C0h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(7 bytes) = 49 8d 81 c0 00 00 00
00dah vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
00deh vpslld xmm1,xmm1,0Ch          ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,ch:imm8]  encoding(VEX, 5 bytes) = c5 f1 72 f1 0c
00e3h vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
00e7h lea rax,[r9+0D0h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(7 bytes) = 49 8d 81 d0 00 00 00
00eeh vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
00f2h vpslld xmm1,xmm1,0Dh          ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,dh:imm8]  encoding(VEX, 5 bytes) = c5 f1 72 f1 0d
00f7h vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
00fbh lea rax,[r9+0E0h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(7 bytes) = 49 8d 81 e0 00 00 00
0102h vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
0106h vpslld xmm1,xmm1,0Eh          ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,eh:imm8]  encoding(VEX, 5 bytes) = c5 f1 72 f1 0e
010bh vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
010fh lea rax,[r9+0F0h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(7 bytes) = 49 8d 81 f0 00 00 00
0116h vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
011ah vpslld xmm1,xmm1,0Fh          ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,fh:imm8]  encoding(VEX, 5 bytes) = c5 f1 72 f1 0f
011fh vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
0123h lea rax,[r9+100h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(7 bytes) = 49 8d 81 00 01 00 00
012ah vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
012eh vpslld xmm1,xmm1,10h          ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,10h:imm8] encoding(VEX, 5 bytes) = c5 f1 72 f1 10
0133h vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
0137h lea rax,[r9+110h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(7 bytes) = 49 8d 81 10 01 00 00
013eh vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
0142h vpslld xmm1,xmm1,11h          ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,11h:imm8] encoding(VEX, 5 bytes) = c5 f1 72 f1 11
0147h vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
014bh lea rax,[r9+120h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(7 bytes) = 49 8d 81 20 01 00 00
0152h vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
0156h vpslld xmm1,xmm1,12h          ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,12h:imm8] encoding(VEX, 5 bytes) = c5 f1 72 f1 12
015bh vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
015fh lea rax,[r9+130h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(7 bytes) = 49 8d 81 30 01 00 00
0166h vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
016ah vpslld xmm1,xmm1,13h          ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,13h:imm8] encoding(VEX, 5 bytes) = c5 f1 72 f1 13
016fh vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
0173h lea rax,[r9+140h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(7 bytes) = 49 8d 81 40 01 00 00
017ah vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
017eh vpslld xmm1,xmm1,14h          ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,14h:imm8] encoding(VEX, 5 bytes) = c5 f1 72 f1 14
0183h vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
0187h lea rax,[r9+150h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(7 bytes) = 49 8d 81 50 01 00 00
018eh vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
0192h vpslld xmm1,xmm1,15h          ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,15h:imm8] encoding(VEX, 5 bytes) = c5 f1 72 f1 15
0197h vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
019bh lea rax,[r9+160h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(7 bytes) = 49 8d 81 60 01 00 00
01a2h vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
01a6h vpslld xmm1,xmm1,16h          ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,16h:imm8] encoding(VEX, 5 bytes) = c5 f1 72 f1 16
01abh vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
01afh lea rax,[r9+170h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(7 bytes) = 49 8d 81 70 01 00 00
01b6h vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
01bah vpslld xmm1,xmm1,17h          ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,17h:imm8] encoding(VEX, 5 bytes) = c5 f1 72 f1 17
01bfh vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
01c3h lea rax,[r9+180h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(7 bytes) = 49 8d 81 80 01 00 00
01cah vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
01ceh vpslld xmm1,xmm1,18h          ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,18h:imm8] encoding(VEX, 5 bytes) = c5 f1 72 f1 18
01d3h vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
01d7h lea rax,[r9+190h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(7 bytes) = 49 8d 81 90 01 00 00
01deh vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
01e2h vpslld xmm1,xmm1,19h          ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,19h:imm8] encoding(VEX, 5 bytes) = c5 f1 72 f1 19
01e7h vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
01ebh lea rax,[r9+1A0h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(7 bytes) = 49 8d 81 a0 01 00 00
01f2h vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
01f6h vpslld xmm1,xmm1,1Ah          ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,1ah:imm8] encoding(VEX, 5 bytes) = c5 f1 72 f1 1a
01fbh vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
01ffh lea rax,[r9+1B0h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(7 bytes) = 49 8d 81 b0 01 00 00
0206h vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
020ah vpslld xmm1,xmm1,1Bh          ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,1bh:imm8] encoding(VEX, 5 bytes) = c5 f1 72 f1 1b
020fh vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
0213h lea rax,[r9+1C0h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(7 bytes) = 49 8d 81 c0 01 00 00
021ah vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
021eh vpslld xmm1,xmm1,1Ch          ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,1ch:imm8] encoding(VEX, 5 bytes) = c5 f1 72 f1 1c
0223h vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
0227h lea rax,[r9+1D0h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(7 bytes) = 49 8d 81 d0 01 00 00
022eh vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
0232h vpslld xmm1,xmm1,1Dh          ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,1dh:imm8] encoding(VEX, 5 bytes) = c5 f1 72 f1 1d
0237h vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
023bh lea rax,[r9+1E0h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(7 bytes) = 49 8d 81 e0 01 00 00
0242h vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
0246h vpslld xmm1,xmm1,1Eh          ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,1eh:imm8] encoding(VEX, 5 bytes) = c5 f1 72 f1 1e
024bh vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
024fh lea rax,[r9+1F0h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,R9:br,:sr)]          encoding(7 bytes) = 49 8d 81 f0 01 00 00
0256h vlddqu xmm1,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 08
025ah vpslld xmm1,xmm1,1Fh          ; VPSLLD(VEX_Vpslld_xmm_xmm_imm8) [XMM1,XMM1,1fh:imm8] encoding(VEX, 5 bytes) = c5 f1 72 f1 1f
025fh vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
0263h add r9,200h                   ; ADD(Add_rm64_imm32) [R9,200h:imm64]                  encoding(7 bytes) = 49 81 c1 00 02 00 00
026ah vlddqu xmm1,xmmword ptr [r9]  ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM1,mem(UInt128,R9:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7b f0 09
026fh vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0273h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0276h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[631]{0xC5,0xF8,0x77,0x66,0x90,0x49,0x8B,0xC1,0xC5,0xFB,0xF0,0x00,0x49,0x8D,0x41,0x10,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x01,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x41,0x20,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x02,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x41,0x30,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x03,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x41,0x40,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x04,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x41,0x50,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x05,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x41,0x60,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x06,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x41,0x70,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x07,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x81,0x80,0x00,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x08,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x81,0x90,0x00,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x09,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x81,0xA0,0x00,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x0A,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x81,0xB0,0x00,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x0B,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x81,0xC0,0x00,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x0C,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x81,0xD0,0x00,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x0D,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x81,0xE0,0x00,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x0E,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x81,0xF0,0x00,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x0F,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x81,0x00,0x01,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x10,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x81,0x10,0x01,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x11,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x81,0x20,0x01,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x12,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x81,0x30,0x01,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x13,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x81,0x40,0x01,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x14,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x81,0x50,0x01,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x15,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x81,0x60,0x01,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x16,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x81,0x70,0x01,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x17,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x81,0x80,0x01,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x18,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x81,0x90,0x01,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x19,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x81,0xA0,0x01,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x1A,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x81,0xB0,0x01,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x1B,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x81,0xC0,0x01,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x1C,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x81,0xD0,0x01,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x1D,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x81,0xE0,0x01,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x1E,0xC5,0xF9,0xEB,0xC1,0x49,0x8D,0x81,0xF0,0x01,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC5,0xF1,0x72,0xF1,0x1F,0xC5,0xF9,0xEB,0xC1,0x49,0x81,0xC1,0x00,0x02,0x00,0x00,0xC4,0xC1,0x7B,0xF0,0x09,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
