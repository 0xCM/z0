; 2020-01-18 18:18:33:446
; uint xor_u32(uint a, uint b)
; static ReadOnlySpan<byte> xor_u32Bytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xD1,0x8B,0xC2,0xC3};
; 2020-01-18 18:18:33:453
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor edx,ecx                             ; XOR(Xor_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 33 d1
0007h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; byte opB_8u(byte dl, byte r8b, byte r9b, byte rsp28, byte rsp30)
; static ReadOnlySpan<byte> opB_8uBytes => new byte[52]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x0F,0xAF,0xC2,0x0F,0xB6,0xC0,0x41,0x0F,0xB6,0xD1,0x33,0xC2,0x0F,0xB6,0xC0,0x8B,0x54,0x24,0x28,0x0F,0xB6,0xD2,0x0B,0xD0,0x0F,0xB6,0xC2,0x8B,0x54,0x24,0x30,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0xC3};
; 2020-01-18 18:18:33:461
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                            ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                           ; MOVZX(Movzx_r32_rm8) [EDX,R8L]             encoding(4 bytes) = 41 0f b6 d0
000ch imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
000fh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0012h movzx edx,r9b                           ; MOVZX(Movzx_r32_rm8) [EDX,R9L]             encoding(4 bytes) = 41 0f b6 d1
0016h xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
0018h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
001bh mov edx,[rsp+28h]                       ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 8b 54 24 28
001fh movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
0022h or edx,eax                              ; OR(Or_r32_rm32) [EDX,EAX]                  encoding(2 bytes) = 0b d0
0024h movzx eax,dl                            ; MOVZX(Movzx_r32_rm8) [EAX,DL]              encoding(3 bytes) = 0f b6 c2
0027h mov edx,[rsp+30h]                       ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,:sr)] encoding(4 bytes) = 8b 54 24 30
002bh movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
002eh and eax,edx                             ; AND(And_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 23 c2
0030h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0033h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
