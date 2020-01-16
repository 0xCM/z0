; 2020-01-15 19:20:39:012
; function: BitPos<uint> bitpos_u32(int index)
; static ReadOnlySpan<byte> bitpos_u32Bytes => new byte[131]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0x44,0x8B,0xC2,0xC7,0x44,0x24,0x14,0x20,0x00,0x00,0x00,0x44,0x0F,0xB6,0x4C,0x24,0x14,0x41,0x8B,0xC0,0x33,0xD2,0x41,0xF7,0xF1,0x89,0x44,0x24,0x10,0x44,0x0F,0xB7,0x4C,0x24,0x10,0xC7,0x44,0x24,0x0C,0x20,0x00,0x00,0x00,0x44,0x0F,0xB6,0x54,0x24,0x0C,0x41,0x8B,0xC0,0x33,0xD2,0x41,0xF7,0xF2,0x89,0x54,0x24,0x08,0x48,0x8D,0x44,0x24,0x18,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x7F,0x40,0x10,0x0F,0xB6,0x44,0x24,0x08,0x66,0x44,0x89,0x4C,0x24,0x18,0x66,0x89,0x44,0x24,0x1A,0xC5,0xFA,0x6F,0x44,0x24,0x18,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x6F,0x44,0x24,0x28,0xC5,0xFA,0x7F,0x41,0x10,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x38,0xC3};
0000h sub rsp,38h                             ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]         encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h mov r8d,edx                             ; MOV(Mov_r32_rm32) [R8D,EDX]                encoding(3 bytes) = 44 8b c2
000ah mov dword ptr [rsp+14h],20h             ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),20h:imm32] encoding(8 bytes) = c7 44 24 14 20 00 00 00
0012h movzx r9d,byte ptr [rsp+14h]            ; MOVZX(Movzx_r32_rm8) [R9D,mem(8u,RSP:br,:sr)] encoding(6 bytes) = 44 0f b6 4c 24 14
0018h mov eax,r8d                             ; MOV(Mov_r32_rm32) [EAX,R8D]                encoding(3 bytes) = 41 8b c0
001bh xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
001dh div r9d                                 ; DIV(Div_rm32) [R9D]                        encoding(3 bytes) = 41 f7 f1
0020h mov [rsp+10h],eax                       ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX] encoding(4 bytes) = 89 44 24 10
0024h movzx r9d,word ptr [rsp+10h]            ; MOVZX(Movzx_r32_rm16) [R9D,mem(16u,RSP:br,:sr)] encoding(6 bytes) = 44 0f b7 4c 24 10
002ah mov dword ptr [rsp+0Ch],20h             ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),20h:imm32] encoding(8 bytes) = c7 44 24 0c 20 00 00 00
0032h movzx r10d,byte ptr [rsp+0Ch]           ; MOVZX(Movzx_r32_rm8) [R10D,mem(8u,RSP:br,:sr)] encoding(6 bytes) = 44 0f b6 54 24 0c
0038h mov eax,r8d                             ; MOV(Mov_r32_rm32) [EAX,R8D]                encoding(3 bytes) = 41 8b c0
003bh xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
003dh div r10d                                ; DIV(Div_rm32) [R10D]                       encoding(3 bytes) = 41 f7 f2
0040h mov [rsp+8],edx                         ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EDX] encoding(4 bytes) = 89 54 24 08
0044h lea rax,[rsp+18h]                       ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 18
0049h vxorps xmm0,xmm0,xmm0                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f8 57 c0
004dh vmovdqu xmmword ptr [rax],xmm0          ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
0051h vmovdqu xmmword ptr [rax+10h],xmm0      ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 40 10
0056h movzx eax,byte ptr [rsp+8]              ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,:sr)] encoding(5 bytes) = 0f b6 44 24 08
005bh mov [rsp+18h],r9w                       ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,:sr),R9W] encoding(6 bytes) = 66 44 89 4c 24 18
0061h mov [rsp+1Ah],ax                        ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,:sr),AX] encoding(5 bytes) = 66 89 44 24 1a
0066h vmovdqu xmm0,xmmword ptr [rsp+18h]      ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 18
006ch vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
0070h vmovdqu xmm0,xmmword ptr [rsp+28h]      ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 28
0076h vmovdqu xmmword ptr [rcx+10h],xmm0      ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 10
007bh mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
007eh add rsp,38h                             ; ADD(Add_rm64_imm8) [RSP,38h:imm64]         encoding(4 bytes) = 48 83 c4 38
0082h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitPos<uint> bitpos_u32_x(int index)
; static ReadOnlySpan<byte> bitpos_u32_xBytes => new byte[131]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0x44,0x8B,0xC2,0xC7,0x44,0x24,0x14,0x20,0x00,0x00,0x00,0x44,0x0F,0xB6,0x4C,0x24,0x14,0x41,0x8B,0xC0,0x33,0xD2,0x41,0xF7,0xF1,0x89,0x44,0x24,0x10,0x44,0x0F,0xB7,0x4C,0x24,0x10,0xC7,0x44,0x24,0x0C,0x20,0x00,0x00,0x00,0x44,0x0F,0xB6,0x54,0x24,0x0C,0x41,0x8B,0xC0,0x33,0xD2,0x41,0xF7,0xF2,0x89,0x54,0x24,0x08,0x48,0x8D,0x44,0x24,0x18,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x7F,0x40,0x10,0x0F,0xB6,0x44,0x24,0x08,0x66,0x44,0x89,0x4C,0x24,0x18,0x66,0x89,0x44,0x24,0x1A,0xC5,0xFA,0x6F,0x44,0x24,0x18,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x6F,0x44,0x24,0x28,0xC5,0xFA,0x7F,0x41,0x10,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x38,0xC3};
0000h sub rsp,38h                             ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]         encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0007h mov r8d,edx                             ; MOV(Mov_r32_rm32) [R8D,EDX]                encoding(3 bytes) = 44 8b c2
000ah mov dword ptr [rsp+14h],20h             ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),20h:imm32] encoding(8 bytes) = c7 44 24 14 20 00 00 00
0012h movzx r9d,byte ptr [rsp+14h]            ; MOVZX(Movzx_r32_rm8) [R9D,mem(8u,RSP:br,:sr)] encoding(6 bytes) = 44 0f b6 4c 24 14
0018h mov eax,r8d                             ; MOV(Mov_r32_rm32) [EAX,R8D]                encoding(3 bytes) = 41 8b c0
001bh xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
001dh div r9d                                 ; DIV(Div_rm32) [R9D]                        encoding(3 bytes) = 41 f7 f1
0020h mov [rsp+10h],eax                       ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX] encoding(4 bytes) = 89 44 24 10
0024h movzx r9d,word ptr [rsp+10h]            ; MOVZX(Movzx_r32_rm16) [R9D,mem(16u,RSP:br,:sr)] encoding(6 bytes) = 44 0f b7 4c 24 10
002ah mov dword ptr [rsp+0Ch],20h             ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),20h:imm32] encoding(8 bytes) = c7 44 24 0c 20 00 00 00
0032h movzx r10d,byte ptr [rsp+0Ch]           ; MOVZX(Movzx_r32_rm8) [R10D,mem(8u,RSP:br,:sr)] encoding(6 bytes) = 44 0f b6 54 24 0c
0038h mov eax,r8d                             ; MOV(Mov_r32_rm32) [EAX,R8D]                encoding(3 bytes) = 41 8b c0
003bh xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
003dh div r10d                                ; DIV(Div_rm32) [R10D]                       encoding(3 bytes) = 41 f7 f2
0040h mov [rsp+8],edx                         ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EDX] encoding(4 bytes) = 89 54 24 08
0044h lea rax,[rsp+18h]                       ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 18
0049h vxorps xmm0,xmm0,xmm0                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f8 57 c0
004dh vmovdqu xmmword ptr [rax],xmm0          ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
0051h vmovdqu xmmword ptr [rax+10h],xmm0      ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 40 10
0056h movzx eax,byte ptr [rsp+8]              ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,:sr)] encoding(5 bytes) = 0f b6 44 24 08
005bh mov [rsp+18h],r9w                       ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,:sr),R9W] encoding(6 bytes) = 66 44 89 4c 24 18
0061h mov [rsp+1Ah],ax                        ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,:sr),AX] encoding(5 bytes) = 66 89 44 24 1a
0066h vmovdqu xmm0,xmmword ptr [rsp+18h]      ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 18
006ch vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
0070h vmovdqu xmm0,xmmword ptr [rsp+28h]      ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 28
0076h vmovdqu xmmword ptr [rcx+10h],xmm0      ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 10
007bh mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
007eh add rsp,38h                             ; ADD(Add_rm64_imm8) [RSP,38h:imm64]         encoding(4 bytes) = 48 83 c4 38
0082h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit bitmatch_32_32(uint a, byte i, uint b, byte j)
; static ReadOnlySpan<byte> bitmatch_32_32Bytes => new byte[36]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB6,0xCA,0xD3,0xE8,0x83,0xE0,0x01,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE8,0x41,0x83,0xE0,0x01,0x41,0x3B,0xC0,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000ah shr eax,cl                              ; SHR(Shr_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 e8
000ch and eax,1                               ; AND(And_rm32_imm8) [EAX,1h:imm32]          encoding(3 bytes) = 83 e0 01
000fh movzx ecx,r9b                           ; MOVZX(Movzx_r32_rm8) [ECX,R9L]             encoding(4 bytes) = 41 0f b6 c9
0013h shr r8d,cl                              ; SHR(Shr_rm32_CL) [R8D,CL]                  encoding(3 bytes) = 41 d3 e8
0016h and r8d,1                               ; AND(And_rm32_imm8) [R8D,1h:imm32]          encoding(4 bytes) = 41 83 e0 01
001ah cmp eax,r8d                             ; CMP(Cmp_r32_rm32) [EAX,R8D]                encoding(3 bytes) = 41 3b c0
001dh sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0020h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0023h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void bitseg_u32(Span<uint> src, int firstidx, int lastidx)
; static ReadOnlySpan<byte> bitseg_u32Bytes => new byte[746]{0x48,0x81,0xEC,0xA8,0x01,0x00,0x00,0xC5,0xF8,0x77,0x44,0x8B,0xCA,0x48,0x8B,0x09,0xC7,0x84,0x24,0x44,0x01,0x00,0x00,0x20,0x00,0x00,0x00,0x44,0x0F,0xB6,0x94,0x24,0x44,0x01,0x00,0x00,0x41,0x8B,0xC1,0x33,0xD2,0x41,0xF7,0xF2,0x89,0x84,0x24,0x40,0x01,0x00,0x00,0x44,0x0F,0xB7,0x94,0x24,0x40,0x01,0x00,0x00,0xC7,0x84,0x24,0x3C,0x01,0x00,0x00,0x20,0x00,0x00,0x00,0x44,0x0F,0xB6,0x9C,0x24,0x3C,0x01,0x00,0x00,0x41,0x8B,0xC1,0x33,0xD2,0x41,0xF7,0xF3,0x89,0x94,0x24,0x38,0x01,0x00,0x00,0x48,0x8D,0x84,0x24,0x48,0x01,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x7F,0x40,0x10,0x0F,0xB6,0x84,0x24,0x38,0x01,0x00,0x00,0x66,0x44,0x89,0x94,0x24,0x48,0x01,0x00,0x00,0x66,0x89,0x84,0x24,0x4A,0x01,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0x48,0x01,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0x88,0x01,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0x58,0x01,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0x98,0x01,0x00,0x00,0xC7,0x84,0x24,0x14,0x01,0x00,0x00,0x20,0x00,0x00,0x00,0x44,0x0F,0xB6,0x8C,0x24,0x14,0x01,0x00,0x00,0x41,0x8B,0xC0,0x33,0xD2,0x41,0xF7,0xF1,0x89,0x84,0x24,0x10,0x01,0x00,0x00,0x44,0x0F,0xB7,0x8C,0x24,0x10,0x01,0x00,0x00,0xC7,0x84,0x24,0x0C,0x01,0x00,0x00,0x20,0x00,0x00,0x00,0x44,0x0F,0xB6,0x94,0x24,0x0C,0x01,0x00,0x00,0x41,0x8B,0xC0,0x33,0xD2,0x41,0xF7,0xF2,0x89,0x94,0x24,0x08,0x01,0x00,0x00,0x48,0x8D,0x84,0x24,0x18,0x01,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x7F,0x40,0x10,0x0F,0xB6,0x84,0x24,0x08,0x01,0x00,0x00,0x66,0x44,0x89,0x8C,0x24,0x18,0x01,0x00,0x00,0x66,0x89,0x84,0x24,0x1A,0x01,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0x18,0x01,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0x68,0x01,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0x28,0x01,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0x78,0x01,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0x88,0x01,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0xC8,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0x98,0x01,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0xD8,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0x68,0x01,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0xE8,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0x78,0x01,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0xF8,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0xE8,0x00,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0xA8,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0xF8,0x00,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0xB8,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0xC8,0x00,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0x88,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0xD8,0x00,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0x98,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0x88,0x00,0x00,0x00,0xC5,0xFA,0x7F,0x44,0x24,0x68,0xC5,0xFA,0x6F,0x84,0x24,0x98,0x00,0x00,0x00,0xC5,0xFA,0x7F,0x44,0x24,0x78,0x8B,0x84,0x24,0xA8,0x00,0x00,0x00,0x0F,0xB7,0xC0,0xC7,0x44,0x24,0x64,0x20,0x00,0x00,0x00,0x0F,0xB6,0x54,0x24,0x64,0x0F,0xAF,0xC2,0x8B,0x94,0x24,0xAA,0x00,0x00,0x00,0x0F,0xB7,0xD2,0x03,0xC2,0x8B,0x54,0x24,0x68,0x0F,0xB7,0xD2,0xC7,0x44,0x24,0x60,0x20,0x00,0x00,0x00,0x44,0x0F,0xB6,0x44,0x24,0x60,0x41,0x0F,0xAF,0xD0,0x44,0x8B,0x44,0x24,0x6A,0x45,0x0F,0xB7,0xC0,0x41,0x03,0xD0,0x2B,0xC2,0x85,0xC0,0x7D,0x0A,0xF7,0xD8,0x85,0xC0,0x0F,0x8C,0x89,0x00,0x00,0x00,0xFF,0xC0,0x83,0xF8,0x20,0x0F,0x8F,0x76,0x00,0x00,0x00,0x8B,0x84,0x24,0xC8,0x00,0x00,0x00,0x0F,0xB7,0xC0,0x8B,0x94,0x24,0xE8,0x00,0x00,0x00,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC5,0xFA,0x6F,0x84,0x24,0xC8,0x00,0x00,0x00,0xC5,0xFA,0x7F,0x44,0x24,0x40,0xC5,0xFA,0x6F,0x84,0x24,0xD8,0x00,0x00,0x00,0xC5,0xFA,0x7F,0x44,0x24,0x50,0x8B,0x54,0x24,0x40,0x0F,0xB7,0xD2,0x48,0x63,0xD2,0x8B,0x14,0x91,0x85,0xC0,0x75,0x2B,0xC5,0xFA,0x6F,0x84,0x24,0xE8,0x00,0x00,0x00,0xC5,0xFA,0x7F,0x44,0x24,0x20,0xC5,0xFA,0x6F,0x84,0x24,0xF8,0x00,0x00,0x00,0xC5,0xFA,0x7F,0x44,0x24,0x30,0x8B,0x44,0x24,0x20,0x0F,0xB7,0xC0,0x48,0x63,0xC0,0x8B,0x04,0x81,0x48,0x81,0xC4,0xA8,0x01,0x00,0x00,0xC3,0xE8,0xD7,0x25,0xBF,0xFF,0xCC};
0000h sub rsp,1A8h                            ; SUB(Sub_rm64_imm32) [RSP,1a8h:imm64]       encoding(7 bytes) = 48 81 ec a8 01 00 00
0007h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
000ah mov r9d,edx                             ; MOV(Mov_r32_rm32) [R9D,EDX]                encoding(3 bytes) = 44 8b ca
000dh mov rcx,[rcx]                           ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,:sr)] encoding(3 bytes) = 48 8b 09
0010h mov dword ptr [rsp+144h],20h            ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),20h:imm32] encoding(11 bytes) = c7 84 24 44 01 00 00 20 00 00 00
001bh movzx r10d,byte ptr [rsp+144h]          ; MOVZX(Movzx_r32_rm8) [R10D,mem(8u,RSP:br,:sr)] encoding(9 bytes) = 44 0f b6 94 24 44 01 00 00
0024h mov eax,r9d                             ; MOV(Mov_r32_rm32) [EAX,R9D]                encoding(3 bytes) = 41 8b c1
0027h xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
0029h div r10d                                ; DIV(Div_rm32) [R10D]                       encoding(3 bytes) = 41 f7 f2
002ch mov [rsp+140h],eax                      ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX] encoding(7 bytes) = 89 84 24 40 01 00 00
0033h movzx r10d,word ptr [rsp+140h]          ; MOVZX(Movzx_r32_rm16) [R10D,mem(16u,RSP:br,:sr)] encoding(9 bytes) = 44 0f b7 94 24 40 01 00 00
003ch mov dword ptr [rsp+13Ch],20h            ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),20h:imm32] encoding(11 bytes) = c7 84 24 3c 01 00 00 20 00 00 00
0047h movzx r11d,byte ptr [rsp+13Ch]          ; MOVZX(Movzx_r32_rm8) [R11D,mem(8u,RSP:br,:sr)] encoding(9 bytes) = 44 0f b6 9c 24 3c 01 00 00
0050h mov eax,r9d                             ; MOV(Mov_r32_rm32) [EAX,R9D]                encoding(3 bytes) = 41 8b c1
0053h xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
0055h div r11d                                ; DIV(Div_rm32) [R11D]                       encoding(3 bytes) = 41 f7 f3
0058h mov [rsp+138h],edx                      ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EDX] encoding(7 bytes) = 89 94 24 38 01 00 00
005fh lea rax,[rsp+148h]                      ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(8 bytes) = 48 8d 84 24 48 01 00 00
0067h vxorps xmm0,xmm0,xmm0                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f8 57 c0
006bh vmovdqu xmmword ptr [rax],xmm0          ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
006fh vmovdqu xmmword ptr [rax+10h],xmm0      ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 40 10
0074h movzx eax,byte ptr [rsp+138h]           ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,:sr)] encoding(8 bytes) = 0f b6 84 24 38 01 00 00
007ch mov [rsp+148h],r10w                     ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,:sr),R10W] encoding(9 bytes) = 66 44 89 94 24 48 01 00 00
0085h mov [rsp+14Ah],ax                       ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,:sr),AX] encoding(8 bytes) = 66 89 84 24 4a 01 00 00
008dh vmovdqu xmm0,xmmword ptr [rsp+148h]     ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 48 01 00 00
0096h vmovdqu xmmword ptr [rsp+188h],xmm0     ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 88 01 00 00
009fh vmovdqu xmm0,xmmword ptr [rsp+158h]     ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 58 01 00 00
00a8h vmovdqu xmmword ptr [rsp+198h],xmm0     ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 98 01 00 00
00b1h mov dword ptr [rsp+114h],20h            ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),20h:imm32] encoding(11 bytes) = c7 84 24 14 01 00 00 20 00 00 00
00bch movzx r9d,byte ptr [rsp+114h]           ; MOVZX(Movzx_r32_rm8) [R9D,mem(8u,RSP:br,:sr)] encoding(9 bytes) = 44 0f b6 8c 24 14 01 00 00
00c5h mov eax,r8d                             ; MOV(Mov_r32_rm32) [EAX,R8D]                encoding(3 bytes) = 41 8b c0
00c8h xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
00cah div r9d                                 ; DIV(Div_rm32) [R9D]                        encoding(3 bytes) = 41 f7 f1
00cdh mov [rsp+110h],eax                      ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX] encoding(7 bytes) = 89 84 24 10 01 00 00
00d4h movzx r9d,word ptr [rsp+110h]           ; MOVZX(Movzx_r32_rm16) [R9D,mem(16u,RSP:br,:sr)] encoding(9 bytes) = 44 0f b7 8c 24 10 01 00 00
00ddh mov dword ptr [rsp+10Ch],20h            ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),20h:imm32] encoding(11 bytes) = c7 84 24 0c 01 00 00 20 00 00 00
00e8h movzx r10d,byte ptr [rsp+10Ch]          ; MOVZX(Movzx_r32_rm8) [R10D,mem(8u,RSP:br,:sr)] encoding(9 bytes) = 44 0f b6 94 24 0c 01 00 00
00f1h mov eax,r8d                             ; MOV(Mov_r32_rm32) [EAX,R8D]                encoding(3 bytes) = 41 8b c0
00f4h xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
00f6h div r10d                                ; DIV(Div_rm32) [R10D]                       encoding(3 bytes) = 41 f7 f2
00f9h mov [rsp+108h],edx                      ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EDX] encoding(7 bytes) = 89 94 24 08 01 00 00
0100h lea rax,[rsp+118h]                      ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(8 bytes) = 48 8d 84 24 18 01 00 00
0108h vxorps xmm0,xmm0,xmm0                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f8 57 c0
010ch vmovdqu xmmword ptr [rax],xmm0          ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
0110h vmovdqu xmmword ptr [rax+10h],xmm0      ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 40 10
0115h movzx eax,byte ptr [rsp+108h]           ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,:sr)] encoding(8 bytes) = 0f b6 84 24 08 01 00 00
011dh mov [rsp+118h],r9w                      ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,:sr),R9W] encoding(9 bytes) = 66 44 89 8c 24 18 01 00 00
0126h mov [rsp+11Ah],ax                       ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,:sr),AX] encoding(8 bytes) = 66 89 84 24 1a 01 00 00
012eh vmovdqu xmm0,xmmword ptr [rsp+118h]     ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 18 01 00 00
0137h vmovdqu xmmword ptr [rsp+168h],xmm0     ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 68 01 00 00
0140h vmovdqu xmm0,xmmword ptr [rsp+128h]     ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 28 01 00 00
0149h vmovdqu xmmword ptr [rsp+178h],xmm0     ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 78 01 00 00
0152h vmovdqu xmm0,xmmword ptr [rsp+188h]     ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 88 01 00 00
015bh vmovdqu xmmword ptr [rsp+0C8h],xmm0     ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 c8 00 00 00
0164h vmovdqu xmm0,xmmword ptr [rsp+198h]     ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 98 01 00 00
016dh vmovdqu xmmword ptr [rsp+0D8h],xmm0     ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 d8 00 00 00
0176h vmovdqu xmm0,xmmword ptr [rsp+168h]     ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 68 01 00 00
017fh vmovdqu xmmword ptr [rsp+0E8h],xmm0     ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 e8 00 00 00
0188h vmovdqu xmm0,xmmword ptr [rsp+178h]     ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 78 01 00 00
0191h vmovdqu xmmword ptr [rsp+0F8h],xmm0     ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 f8 00 00 00
019ah vmovdqu xmm0,xmmword ptr [rsp+0E8h]     ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 e8 00 00 00
01a3h vmovdqu xmmword ptr [rsp+0A8h],xmm0     ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 a8 00 00 00
01ach vmovdqu xmm0,xmmword ptr [rsp+0F8h]     ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 f8 00 00 00
01b5h vmovdqu xmmword ptr [rsp+0B8h],xmm0     ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 b8 00 00 00
01beh vmovdqu xmm0,xmmword ptr [rsp+0C8h]     ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 c8 00 00 00
01c7h vmovdqu xmmword ptr [rsp+88h],xmm0      ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 88 00 00 00
01d0h vmovdqu xmm0,xmmword ptr [rsp+0D8h]     ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 d8 00 00 00
01d9h vmovdqu xmmword ptr [rsp+98h],xmm0      ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 98 00 00 00
01e2h vmovdqu xmm0,xmmword ptr [rsp+88h]      ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 88 00 00 00
01ebh vmovdqu xmmword ptr [rsp+68h],xmm0      ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 68
01f1h vmovdqu xmm0,xmmword ptr [rsp+98h]      ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 98 00 00 00
01fah vmovdqu xmmword ptr [rsp+78h],xmm0      ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 78
0200h mov eax,[rsp+0A8h]                      ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)] encoding(7 bytes) = 8b 84 24 a8 00 00 00
0207h movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
020ah mov dword ptr [rsp+64h],20h             ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),20h:imm32] encoding(8 bytes) = c7 44 24 64 20 00 00 00
0212h movzx edx,byte ptr [rsp+64h]            ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,:sr)] encoding(5 bytes) = 0f b6 54 24 64
0217h imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
021ah mov edx,[rsp+0AAh]                      ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)] encoding(7 bytes) = 8b 94 24 aa 00 00 00
0221h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
0224h add eax,edx                             ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
0226h mov edx,[rsp+68h]                       ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 8b 54 24 68
022ah movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
022dh mov dword ptr [rsp+60h],20h             ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),20h:imm32] encoding(8 bytes) = c7 44 24 60 20 00 00 00
0235h movzx r8d,byte ptr [rsp+60h]            ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RSP:br,:sr)] encoding(6 bytes) = 44 0f b6 44 24 60
023bh imul edx,r8d                            ; IMUL(Imul_r32_rm32) [EDX,R8D]              encoding(4 bytes) = 41 0f af d0
023fh mov r8d,[rsp+6Ah]                       ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,:sr)] encoding(5 bytes) = 44 8b 44 24 6a
0244h movzx r8d,r8w                           ; MOVZX(Movzx_r32_rm16) [R8D,R8W]            encoding(4 bytes) = 45 0f b7 c0
0248h add edx,r8d                             ; ADD(Add_r32_rm32) [EDX,R8D]                encoding(3 bytes) = 41 03 d0
024bh sub eax,edx                             ; SUB(Sub_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 2b c2
024dh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
024fh jge short 025bh                         ; JGE(Jge_rel8_64) [25Bh:jmp64]              encoding(2 bytes) = 7d 0a
0251h neg eax                                 ; NEG(Neg_rm32) [EAX]                        encoding(2 bytes) = f7 d8
0253h test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
0255h jl near ptr 02e4h                       ; JL(Jl_rel32_64) [2E4h:jmp64]               encoding(6 bytes) = 0f 8c 89 00 00 00
025bh inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
025dh cmp eax,20h                             ; CMP(Cmp_rm32_imm8) [EAX,20h:imm32]         encoding(3 bytes) = 83 f8 20
0260h jg near ptr 02dch                       ; JG(Jg_rel32_64) [2DCh:jmp64]               encoding(6 bytes) = 0f 8f 76 00 00 00
0266h mov eax,[rsp+0C8h]                      ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)] encoding(7 bytes) = 8b 84 24 c8 00 00 00
026dh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
0270h mov edx,[rsp+0E8h]                      ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)] encoding(7 bytes) = 8b 94 24 e8 00 00 00
0277h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
027ah cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
027ch sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
027fh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0282h vmovdqu xmm0,xmmword ptr [rsp+0C8h]     ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 c8 00 00 00
028bh vmovdqu xmmword ptr [rsp+40h],xmm0      ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 40
0291h vmovdqu xmm0,xmmword ptr [rsp+0D8h]     ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 d8 00 00 00
029ah vmovdqu xmmword ptr [rsp+50h],xmm0      ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 50
02a0h mov edx,[rsp+40h]                       ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 8b 54 24 40
02a4h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
02a7h movsxd rdx,edx                          ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]          encoding(3 bytes) = 48 63 d2
02aah mov edx,[rcx+rdx*4]                     ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,:sr)] encoding(3 bytes) = 8b 14 91
02adh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
02afh jne short 02dch                         ; JNE(Jne_rel8_64) [2DCh:jmp64]              encoding(2 bytes) = 75 2b
02b1h vmovdqu xmm0,xmmword ptr [rsp+0E8h]     ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 e8 00 00 00
02bah vmovdqu xmmword ptr [rsp+20h],xmm0      ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 20
02c0h vmovdqu xmm0,xmmword ptr [rsp+0F8h]     ; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 f8 00 00 00
02c9h vmovdqu xmmword ptr [rsp+30h],xmm0      ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 30
02cfh mov eax,[rsp+20h]                       ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 8b 44 24 20
02d3h movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
02d6h movsxd rax,eax                          ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]          encoding(3 bytes) = 48 63 c0
02d9h mov eax,[rcx+rax*4]                     ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,:sr)] encoding(3 bytes) = 8b 04 81
02dch add rsp,1A8h                            ; ADD(Add_rm64_imm32) [RSP,1a8h:imm64]       encoding(7 bytes) = 48 81 c4 a8 01 00 00
02e3h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
02e4h call 7FF7C8148F50h                      ; CALL(Call_rel32_64) [FFFFFFFFFFBF28C0h:jmp64] encoding(5 bytes) = e8 d7 25 bf ff
02e9h int 3                                   ; INT(Int3)                                  encoding(1 byte ) = cc
----------------------------------------------------------------------------------------------------------------------------------------------------------------
