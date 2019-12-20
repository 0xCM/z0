; 2019-12-20 15:38:58:033
; function: byte pack_8(ConstBlock64<byte> src)
; location: [7FF7C7EC5510h, 7FF7C7EC552Fh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 00
000bh vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0010h vpsllq xmm0,xmm0,7            ; VPSLLQ(VEX_Vpsllq_xmm_xmm_imm8) [XMM0,XMM0,7h:imm8]  encoding(VEX, 5 bytes) = c5 f9 73 f0 07
0015h vpmovmskb eax,xmm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_xmm) [EAX,XMM0]          encoding(VEX, 4 bytes) = c5 f9 d7 c0
0019h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pack_8Bytes => new byte[32]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x01,0x48,0x8B,0x00,0xC4,0xE1,0xF9,0x6E,0xC0,0xC5,0xF9,0x73,0xF0,0x07,0xC5,0xF9,0xD7,0xC0,0x0F,0xB7,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort pack_16(ConstBlock128<byte> src)
; location: [7FF7C7EC5550h, 7FF7C7EC5568h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h vlddqu xmm0,xmmword ptr [rax] ; VLDDQU(VEX_Vlddqu_xmm_m128) [XMM0,mem(UInt128,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 fb f0 00
000ch vpsllq xmm0,xmm0,7            ; VPSLLQ(VEX_Vpsllq_xmm_xmm_imm8) [XMM0,XMM0,7h:imm8]  encoding(VEX, 5 bytes) = c5 f9 73 f0 07
0011h vpmovmskb eax,xmm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_xmm) [EAX,XMM0]          encoding(VEX, 4 bytes) = c5 f9 d7 c0
0015h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pack_16Bytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x01,0xC5,0xFB,0xF0,0x00,0xC5,0xF9,0x73,0xF0,0x07,0xC5,0xF9,0xD7,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pack_32(ConstBlock256<byte> src)
; location: [7FF7C7EC5580h, 7FF7C7EC5598h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h vlddqu ymm0,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 00
000ch vpsllq ymm0,ymm0,7            ; VPSLLQ(VEX_Vpsllq_ymm_ymm_imm8) [YMM0,YMM0,7h:imm8]  encoding(VEX, 5 bytes) = c5 fd 73 f0 07
0011h vpmovmskb eax,ymm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_ymm) [EAX,YMM0]          encoding(VEX, 4 bytes) = c5 fd d7 c0
0015h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pack_32Bytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x01,0xC5,0xFF,0xF0,0x00,0xC5,0xFD,0x73,0xF0,0x07,0xC5,0xFD,0xD7,0xC0,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pack_64(ConstBlock512<byte> src)
; location: [7FF7C7EC5DC0h, 7FF7C7EC5DFAh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
000bh vlddqu ymm0,ymmword ptr [rdx] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 02
000fh vpsllq ymm0,ymm0,7            ; VPSLLQ(VEX_Vpsllq_ymm_ymm_imm8) [YMM0,YMM0,7h:imm8]  encoding(VEX, 5 bytes) = c5 fd 73 f0 07
0014h vpmovmskb edx,ymm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_ymm) [EDX,YMM0]          encoding(VEX, 4 bytes) = c5 fd d7 d0
0018h mov edx,edx                   ; MOV(Mov_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 8b d2
001ah add rax,20h                   ; ADD(Add_rm64_imm8) [RAX,20h:imm64]                   encoding(4 bytes) = 48 83 c0 20
001eh vlddqu ymm0,ymmword ptr [rax] ; VLDDQU(VEX_Vlddqu_ymm_m256) [YMM0,mem(UInt256,RAX:br,:sr)] encoding(VEX, 4 bytes) = c5 ff f0 00
0022h vpsllq ymm0,ymm0,7            ; VPSLLQ(VEX_Vpsllq_ymm_ymm_imm8) [YMM0,YMM0,7h:imm8]  encoding(VEX, 5 bytes) = c5 fd 73 f0 07
0027h vpmovmskb eax,ymm0            ; VPMOVMSKB(VEX_Vpmovmskb_r32_ymm) [EAX,YMM0]          encoding(VEX, 4 bytes) = c5 fd d7 c0
002bh mov eax,eax                   ; MOV(Mov_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 8b c0
002dh shl rax,20h                   ; SHL(Shl_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e0 20
0031h or rdx,rax                    ; OR(Or_r64_rm64) [RDX,RAX]                            encoding(3 bytes) = 48 0b d0
0034h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0037h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pack_64Bytes => new byte[59]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x01,0x48,0x8B,0xD0,0xC5,0xFF,0xF0,0x02,0xC5,0xFD,0x73,0xF0,0x07,0xC5,0xFD,0xD7,0xD0,0x8B,0xD2,0x48,0x83,0xC0,0x20,0xC5,0xFF,0xF0,0x00,0xC5,0xFD,0x73,0xF0,0x07,0xC5,0xFD,0xD7,0xC0,0x8B,0xC0,0x48,0xC1,0xE0,0x20,0x48,0x0B,0xD0,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong broadcast_8x64(byte pattern)
; location: [7FF7C7EC5E20h, 7FF7C7EC5E41h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov [rsp+4],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),AL]              encoding(4 bytes) = 88 44 24 04
000ch lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0011h vpbroadcastb xmm0,byte ptr [rsp+4]; VPBROADCASTB(VEX_Vpbroadcastb_xmm_xmmm8) [XMM0,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 78 44 24 04
0018h vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
001dh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> broadcast_8x64Bytes => new byte[34]{0x50,0xC5,0xF8,0x77,0x90,0x0F,0xB6,0xC1,0x88,0x44,0x24,0x04,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x78,0x44,0x24,0x04,0xC4,0xE1,0xF9,0x7E,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong broadcast_8x64_const()
; location: [7FF7C7EC5E60h, 7FF7C7EC5E82h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov dword ptr [rsp+4],0CCh    ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),cch:imm32]  encoding(8 bytes) = c7 44 24 04 cc 00 00 00
000dh lea rax,[rsp+4]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 04
0012h vpbroadcastb xmm0,byte ptr [rsp+4]; VPBROADCASTB(VEX_Vpbroadcastb_xmm_xmmm8) [XMM0,mem(8i,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e2 79 78 44 24 04
0019h vmovq rax,xmm0                ; VMOVQ(VEX_Vmovq_rm64_xmm) [RAX,XMM0]                 encoding(VEX, 5 bytes) = c4 e1 f9 7e c0
001eh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> broadcast_8x64_constBytes => new byte[35]{0x50,0xC5,0xF8,0x77,0x90,0xC7,0x44,0x24,0x04,0xCC,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x78,0x44,0x24,0x04,0xC4,0xE1,0xF9,0x7E,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
