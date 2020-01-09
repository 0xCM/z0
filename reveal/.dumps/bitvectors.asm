; 2020-01-08 22:54:02:220
; function: BitVector<byte> bvand_8(BitVector<byte> x, BitVector<byte> y)
; static ReadOnlySpan<byte> bvand_8Bytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x23,0xC2,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh and eax,edx                             ; AND(And_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 23 c2
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 bvand_d8(BitVector8 x, BitVector8 y)
; static ReadOnlySpan<byte> bvand_d8Bytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh and eax,edx                             ; AND(And_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 23 c2
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector<uint> bvand_32(BitVector<uint> x, BitVector<uint> y)
; static ReadOnlySpan<byte> bvand_32Bytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                             ; AND(And_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 23 d1
0007h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 bvand_d32(BitVector32 x, BitVector32 y)
; static ReadOnlySpan<byte> bvand_d32Bytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                             ; AND(And_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 23 d1
0007h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector<ulong> bvand_64(BitVector<ulong> x, BitVector<ulong> y)
; static ReadOnlySpan<byte> bvand_64Bytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                             ; AND(And_r64_rm64) [RDX,RCX]                encoding(3 bytes) = 48 23 d1
0008h mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 bvand_d64(BitVector64 x, BitVector64 y)
; static ReadOnlySpan<byte> bvand_d64Bytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                             ; AND(And_r64_rm64) [RDX,RCX]                encoding(3 bytes) = 48 23 d1
0008h mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector<byte> bvxor_8(BitVector<byte> x, BitVector<byte> y)
; static ReadOnlySpan<byte> bvxor_8Bytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector<byte> bvxor_g8(BitVector<byte> x, BitVector<byte> y)
; static ReadOnlySpan<byte> bvxor_g8Bytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
000eh xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 bvxor_d8(BitVector8 x, BitVector8 y)
; static ReadOnlySpan<byte> bvxor_d8Bytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte xor_d8(byte x, byte y)
; static ReadOnlySpan<byte> xor_d8Bytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte xor_g8(byte x, byte y)
; static ReadOnlySpan<byte> xor_g8Bytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte xor_d82(byte x, byte y)
; static ReadOnlySpan<byte> xor_d82Bytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                            ; MOVZX(Movzx_r32_rm8) [EAX,CL]              encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                            ; MOVZX(Movzx_r32_rm8) [EDX,DL]              encoding(3 bytes) = 0f b6 d2
000bh xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
000dh movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 sll_bv_32u(BitVector32 x, byte offset)
; static ReadOnlySpan<byte> sll_bv_32uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB6,0xCA,0xD3,0xE0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000ah shl eax,cl                              ; SHL(Shl_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 e0
000ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 sll_bv_o32u(BitVector32 x, byte offset)
; static ReadOnlySpan<byte> sll_bv_o32uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB6,0xCA,0xD3,0xE0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000ah shl eax,cl                              ; SHL(Shl_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 e0
000ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 srl_bv_32u(BitVector32 x, byte offset)
; static ReadOnlySpan<byte> srl_bv_32uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB6,0xCA,0xD3,0xE8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000ah shr eax,cl                              ; SHR(Shr_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 e8
000ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 srl_bv_o32u(BitVector32 x, byte offset)
; static ReadOnlySpan<byte> srl_bv_o32uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB6,0xCA,0xD3,0xE8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000ah shr eax,cl                              ; SHR(Shr_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 e8
000ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 flip_bv_32u(BitVector32 x)
; static ReadOnlySpan<byte> flip_bv_32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 flip_bv_o32u(BitVector32 x)
; static ReadOnlySpan<byte> flip_bv_o32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 negate_bv_32u(BitVector32 x)
; static ReadOnlySpan<byte> negate_bv_32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
0009h inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 negate_bv_o32u(BitVector32 x)
; static ReadOnlySpan<byte> negate_bv_o32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
0009h inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 inc_bv_32u(BitVector32 x)
; static ReadOnlySpan<byte> inc_bv_32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC1,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h inc ecx                                 ; INC(Inc_rm32) [ECX]                        encoding(2 bytes) = ff c1
0007h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 inc_bv_o32u(BitVector32 x)
; static ReadOnlySpan<byte> inc_bv_o32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC1,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h inc ecx                                 ; INC(Inc_rm32) [ECX]                        encoding(2 bytes) = ff c1
0007h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 dec_bv_32u(BitVector32 x)
; static ReadOnlySpan<byte> dec_bv_32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC9,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h dec ecx                                 ; DEC(Dec_rm32) [ECX]                        encoding(2 bytes) = ff c9
0007h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 dec_bv_o32u(BitVector32 x)
; static ReadOnlySpan<byte> dec_bv_o32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC9,0x8B,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h dec ecx                                 ; DEC(Dec_rm32) [ECX]                        encoding(2 bytes) = ff c9
0007h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 rotl_bv_32u(BitVector32 x, byte offset)
; static ReadOnlySpan<byte> rotl_bv_32uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB6,0xCA,0xD3,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000ah rol eax,cl                              ; ROL(Rol_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 c0
000ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 rotr_bv_32u(BitVector32 x, byte offset)
; static ReadOnlySpan<byte> rotr_bv_32uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB6,0xCA,0xD3,0xC8,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
000ah ror eax,cl                              ; ROR(Ror_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 c8
000ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 alt_32()
; static ReadOnlySpan<byte> alt_32Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xAA,0xAA,0xAA,0xAA,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0AAAAAAAAh                      ; MOV(Mov_r32_imm32) [EAX,aaaaaaaah:imm32]   encoding(5 bytes) = b8 aa aa aa aa
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector<uint> alt_32g()
; static ReadOnlySpan<byte> alt_32gBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xAA,0xAA,0xAA,0xAA,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0AAAAAAAAh                      ; MOV(Mov_r32_imm32) [EAX,aaaaaaaah:imm32]   encoding(5 bytes) = b8 aa aa aa aa
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit dot_32g(BitVector<uint> x, BitVector<uint> y)
; static ReadOnlySpan<byte> dot_32gBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x33,0xC0,0xF3,0x0F,0xB8,0xC2,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                             ; AND(And_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 23 d1
0007h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0009h popcnt eax,edx                          ; POPCNT(Popcnt_r32_rm32) [EAX,EDX]          encoding(4 bytes) = f3 0f b8 c2
000dh test al,1                               ; TEST(Test_AL_imm8) [AL,1h:imm8]            encoding(2 bytes) = a8 01
000fh setne al                                ; SETNE(Setne_rm8) [AL]                      encoding(3 bytes) = 0f 95 c0
0012h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0015h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitMatrix<uint> oprod_1(BitVector32 x, BitVector32 y)
; static ReadOnlySpan<byte> oprod_1Bytes => new byte[125]{0x57,0x56,0x53,0x48,0x83,0xEC,0x30,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xD9,0x8B,0xF2,0x41,0x8B,0xF8,0x48,0x8D,0x4C,0x24,0x20,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0x48,0x8D,0x4C,0x24,0x20,0xE8,0x38,0xF6,0xFF,0xFF,0x48,0x8D,0x4C,0x24,0x20,0x48,0x8B,0x01,0x33,0xD2,0x48,0x63,0xCA,0x4C,0x8D,0x04,0x88,0x0F,0xB6,0xCA,0x44,0x8B,0xCE,0x41,0xD3,0xE9,0x41,0x83,0xE1,0x01,0x45,0x85,0xC9,0x75,0x04,0x33,0xC9,0xEB,0x02,0x8B,0xCF,0x41,0x89,0x08,0xFF,0xC2,0x83,0xFA,0x20,0x7C,0xD7,0x48,0x8D,0x74,0x24,0x20,0x48,0x8B,0xFB,0xE8,0x10,0xC9,0x40,0x5F,0x48,0xA5,0x48,0x8B,0xC3,0x48,0x83,0xC4,0x30,0x5B,0x5E,0x5F,0xC3};
0000h push rdi                                ; PUSH(Push_r64) [RDI]                       encoding(1 byte ) = 57
0001h push rsi                                ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0002h push rbx                                ; PUSH(Push_r64) [RBX]                       encoding(1 byte ) = 53
0003h sub rsp,30h                             ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]         encoding(4 bytes) = 48 83 ec 30
0007h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
000ah xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
000ch mov [rsp+20h],rax                       ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(5 bytes) = 48 89 44 24 20
0011h mov rbx,rcx                             ; MOV(Mov_r64_rm64) [RBX,RCX]                encoding(3 bytes) = 48 8b d9
0014h mov esi,edx                             ; MOV(Mov_r32_rm32) [ESI,EDX]                encoding(2 bytes) = 8b f2
0016h mov edi,r8d                             ; MOV(Mov_r32_rm32) [EDI,R8D]                encoding(3 bytes) = 41 8b f8
0019h lea rcx,[rsp+20h]                       ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 4c 24 20
001eh vxorps xmm0,xmm0,xmm0                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f8 57 c0
0022h vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
0026h lea rcx,[rsp+20h]                       ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 4c 24 20
002bh call 7FF7B6808B78h                      ; CALL(Call_rel32_64) [FFFFFFFFFFFFF668h:jmp64] encoding(5 bytes) = e8 38 f6 ff ff
0030h lea rcx,[rsp+20h]                       ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 4c 24 20
0035h mov rax,[rcx]                           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)] encoding(3 bytes) = 48 8b 01
0038h xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
003ah movsxd rcx,edx                          ; MOVSXD(Movsxd_r64_rm32) [RCX,EDX]          encoding(3 bytes) = 48 63 ca
003dh lea r8,[rax+rcx*4]                      ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)] encoding(4 bytes) = 4c 8d 04 88
0041h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
0044h mov r9d,esi                             ; MOV(Mov_r32_rm32) [R9D,ESI]                encoding(3 bytes) = 44 8b ce
0047h shr r9d,cl                              ; SHR(Shr_rm32_CL) [R9D,CL]                  encoding(3 bytes) = 41 d3 e9
004ah and r9d,1                               ; AND(And_rm32_imm8) [R9D,1h:imm32]          encoding(4 bytes) = 41 83 e1 01
004eh test r9d,r9d                            ; TEST(Test_rm32_r32) [R9D,R9D]              encoding(3 bytes) = 45 85 c9
0051h jne short 0057h                         ; JNE(Jne_rel8_64) [57h:jmp64]               encoding(2 bytes) = 75 04
0053h xor ecx,ecx                             ; XOR(Xor_r32_rm32) [ECX,ECX]                encoding(2 bytes) = 33 c9
0055h jmp short 0059h                         ; JMP(Jmp_rel8_64) [59h:jmp64]               encoding(2 bytes) = eb 02
0057h mov ecx,edi                             ; MOV(Mov_r32_rm32) [ECX,EDI]                encoding(2 bytes) = 8b cf
0059h mov [r8],ecx                            ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),ECX] encoding(3 bytes) = 41 89 08
005ch inc edx                                 ; INC(Inc_rm32) [EDX]                        encoding(2 bytes) = ff c2
005eh cmp edx,20h                             ; CMP(Cmp_rm32_imm8) [EDX,20h:imm32]         encoding(3 bytes) = 83 fa 20
0061h jl short 003ah                          ; JL(Jl_rel8_64) [3Ah:jmp64]                 encoding(2 bytes) = 7c d7
0063h lea rsi,[rsp+20h]                       ; LEA(Lea_r64_m) [RSI,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 74 24 20
0068h mov rdi,rbx                             ; MOV(Mov_r64_rm64) [RDI,RBX]                encoding(3 bytes) = 48 8b fb
006bh call 7FF815C15E90h                      ; CALL(Call_rel32_64) [5F40C980h:jmp64]      encoding(5 bytes) = e8 10 c9 40 5f
0070h movsq                                   ; MOVSQ(Movsq_m64_m64) [mem(64u),mem(64u,:sr)] encoding(2 bytes) = 48 a5
0072h mov rax,rbx                             ; MOV(Mov_r64_rm64) [RAX,RBX]                encoding(3 bytes) = 48 8b c3
0075h add rsp,30h                             ; ADD(Add_rm64_imm8) [RSP,30h:imm64]         encoding(4 bytes) = 48 83 c4 30
0079h pop rbx                                 ; POP(Pop_r64) [RBX]                         encoding(1 byte ) = 5b
007ah pop rsi                                 ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
007bh pop rdi                                 ; POP(Pop_r64) [RDI]                         encoding(1 byte ) = 5f
007ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitMatrix<uint> oprod_2(BitVector<uint> x, BitVector<uint> y)
; static ReadOnlySpan<byte> oprod_2Bytes => new byte[125]{0x57,0x56,0x53,0x48,0x83,0xEC,0x30,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xD9,0x8B,0xF2,0x41,0x8B,0xF8,0x48,0x8D,0x4C,0x24,0x20,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0x48,0x8D,0x4C,0x24,0x20,0xE8,0x98,0xF5,0xFF,0xFF,0x48,0x8D,0x4C,0x24,0x20,0x48,0x8B,0x01,0x33,0xD2,0x48,0x63,0xCA,0x4C,0x8D,0x04,0x88,0x0F,0xB6,0xCA,0x44,0x8B,0xCE,0x41,0xD3,0xE9,0x41,0x83,0xE1,0x01,0x45,0x85,0xC9,0x75,0x04,0x33,0xC9,0xEB,0x02,0x8B,0xCF,0x41,0x89,0x08,0xFF,0xC2,0x83,0xFA,0x20,0x7C,0xD7,0x48,0x8D,0x74,0x24,0x20,0x48,0x8B,0xFB,0xE8,0x70,0xC8,0x40,0x5F,0x48,0xA5,0x48,0x8B,0xC3,0x48,0x83,0xC4,0x30,0x5B,0x5E,0x5F,0xC3};
0000h push rdi                                ; PUSH(Push_r64) [RDI]                       encoding(1 byte ) = 57
0001h push rsi                                ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0002h push rbx                                ; PUSH(Push_r64) [RBX]                       encoding(1 byte ) = 53
0003h sub rsp,30h                             ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]         encoding(4 bytes) = 48 83 ec 30
0007h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
000ah xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
000ch mov [rsp+20h],rax                       ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(5 bytes) = 48 89 44 24 20
0011h mov rbx,rcx                             ; MOV(Mov_r64_rm64) [RBX,RCX]                encoding(3 bytes) = 48 8b d9
0014h mov esi,edx                             ; MOV(Mov_r32_rm32) [ESI,EDX]                encoding(2 bytes) = 8b f2
0016h mov edi,r8d                             ; MOV(Mov_r32_rm32) [EDI,R8D]                encoding(3 bytes) = 41 8b f8
0019h lea rcx,[rsp+20h]                       ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 4c 24 20
001eh vxorps xmm0,xmm0,xmm0                   ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0] encoding(VEX, 4 bytes) = c5 f8 57 c0
0022h vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
0026h lea rcx,[rsp+20h]                       ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 4c 24 20
002bh call 7FF7B6808B78h                      ; CALL(Call_rel32_64) [FFFFFFFFFFFFF5C8h:jmp64] encoding(5 bytes) = e8 98 f5 ff ff
0030h lea rcx,[rsp+20h]                       ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 4c 24 20
0035h mov rax,[rcx]                           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)] encoding(3 bytes) = 48 8b 01
0038h xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
003ah movsxd rcx,edx                          ; MOVSXD(Movsxd_r64_rm32) [RCX,EDX]          encoding(3 bytes) = 48 63 ca
003dh lea r8,[rax+rcx*4]                      ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)] encoding(4 bytes) = 4c 8d 04 88
0041h movzx ecx,dl                            ; MOVZX(Movzx_r32_rm8) [ECX,DL]              encoding(3 bytes) = 0f b6 ca
0044h mov r9d,esi                             ; MOV(Mov_r32_rm32) [R9D,ESI]                encoding(3 bytes) = 44 8b ce
0047h shr r9d,cl                              ; SHR(Shr_rm32_CL) [R9D,CL]                  encoding(3 bytes) = 41 d3 e9
004ah and r9d,1                               ; AND(And_rm32_imm8) [R9D,1h:imm32]          encoding(4 bytes) = 41 83 e1 01
004eh test r9d,r9d                            ; TEST(Test_rm32_r32) [R9D,R9D]              encoding(3 bytes) = 45 85 c9
0051h jne short 0057h                         ; JNE(Jne_rel8_64) [57h:jmp64]               encoding(2 bytes) = 75 04
0053h xor ecx,ecx                             ; XOR(Xor_r32_rm32) [ECX,ECX]                encoding(2 bytes) = 33 c9
0055h jmp short 0059h                         ; JMP(Jmp_rel8_64) [59h:jmp64]               encoding(2 bytes) = eb 02
0057h mov ecx,edi                             ; MOV(Mov_r32_rm32) [ECX,EDI]                encoding(2 bytes) = 8b cf
0059h mov [r8],ecx                            ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),ECX] encoding(3 bytes) = 41 89 08
005ch inc edx                                 ; INC(Inc_rm32) [EDX]                        encoding(2 bytes) = ff c2
005eh cmp edx,20h                             ; CMP(Cmp_rm32_imm8) [EDX,20h:imm32]         encoding(3 bytes) = 83 fa 20
0061h jl short 003ah                          ; JL(Jl_rel8_64) [3Ah:jmp64]                 encoding(2 bytes) = 7c d7
0063h lea rsi,[rsp+20h]                       ; LEA(Lea_r64_m) [RSI,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 74 24 20
0068h mov rdi,rbx                             ; MOV(Mov_r64_rm64) [RDI,RBX]                encoding(3 bytes) = 48 8b fb
006bh call 7FF815C15E90h                      ; CALL(Call_rel32_64) [5F40C8E0h:jmp64]      encoding(5 bytes) = e8 70 c8 40 5f
0070h movsq                                   ; MOVSQ(Movsq_m64_m64) [mem(64u),mem(64u,:sr)] encoding(2 bytes) = 48 a5
0072h mov rax,rbx                             ; MOV(Mov_r64_rm64) [RAX,RBX]                encoding(3 bytes) = 48 8b c3
0075h add rsp,30h                             ; ADD(Add_rm64_imm8) [RSP,30h:imm64]         encoding(4 bytes) = 48 83 c4 30
0079h pop rbx                                 ; POP(Pop_r64) [RBX]                         encoding(1 byte ) = 5b
007ah pop rsi                                 ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
007bh pop rdi                                 ; POP(Pop_r64) [RDI]                         encoding(1 byte ) = 5f
007ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitMatrix<uint> oprod_3(BitVector<uint> x, BitVector<uint> y, ref BitMatrix<uint> z)
; static ReadOnlySpan<byte> oprod_3Bytes => new byte[58]{0x56,0x0F,0x1F,0x40,0x00,0x8B,0xC1,0x4D,0x8B,0x08,0x45,0x33,0xD2,0x49,0x63,0xCA,0x4D,0x8D,0x1C,0x89,0x41,0x0F,0xB6,0xCA,0x8B,0xF0,0xD3,0xEE,0x83,0xE6,0x01,0x85,0xF6,0x75,0x04,0x33,0xC9,0xEB,0x02,0x8B,0xCA,0x41,0x89,0x0B,0x41,0xFF,0xC2,0x41,0x83,0xFA,0x20,0x7C,0xD8,0x49,0x8B,0xC0,0x5E,0xC3};
0000h push rsi                                ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0001h nop dword ptr [rax]                     ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(4 bytes) = 0f 1f 40 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h mov r9,[r8]                             ; MOV(Mov_r64_rm64) [R9,mem(64u,R8:br,:sr)]  encoding(3 bytes) = 4d 8b 08
000ah xor r10d,r10d                           ; XOR(Xor_r32_rm32) [R10D,R10D]              encoding(3 bytes) = 45 33 d2
000dh movsxd rcx,r10d                         ; MOVSXD(Movsxd_r64_rm32) [RCX,R10D]         encoding(3 bytes) = 49 63 ca
0010h lea r11,[r9+rcx*4]                      ; LEA(Lea_r64_m) [R11,mem(Unknown,R9:br,:sr)] encoding(4 bytes) = 4d 8d 1c 89
0014h movzx ecx,r10b                          ; MOVZX(Movzx_r32_rm8) [ECX,R10L]            encoding(4 bytes) = 41 0f b6 ca
0018h mov esi,eax                             ; MOV(Mov_r32_rm32) [ESI,EAX]                encoding(2 bytes) = 8b f0
001ah shr esi,cl                              ; SHR(Shr_rm32_CL) [ESI,CL]                  encoding(2 bytes) = d3 ee
001ch and esi,1                               ; AND(And_rm32_imm8) [ESI,1h:imm32]          encoding(3 bytes) = 83 e6 01
001fh test esi,esi                            ; TEST(Test_rm32_r32) [ESI,ESI]              encoding(2 bytes) = 85 f6
0021h jne short 0027h                         ; JNE(Jne_rel8_64) [27h:jmp64]               encoding(2 bytes) = 75 04
0023h xor ecx,ecx                             ; XOR(Xor_r32_rm32) [ECX,ECX]                encoding(2 bytes) = 33 c9
0025h jmp short 0029h                         ; JMP(Jmp_rel8_64) [29h:jmp64]               encoding(2 bytes) = eb 02
0027h mov ecx,edx                             ; MOV(Mov_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 8b ca
0029h mov [r11],ecx                           ; MOV(Mov_rm32_r32) [mem(32u,R11:br,:sr),ECX] encoding(3 bytes) = 41 89 0b
002ch inc r10d                                ; INC(Inc_rm32) [R10D]                       encoding(3 bytes) = 41 ff c2
002fh cmp r10d,20h                            ; CMP(Cmp_rm32_imm8) [R10D,20h:imm32]        encoding(4 bytes) = 41 83 fa 20
0033h jl short 000dh                          ; JL(Jl_rel8_64) [Dh:jmp64]                  encoding(2 bytes) = 7c d8
0035h mov rax,r8                              ; MOV(Mov_r64_rm64) [RAX,R8]                 encoding(3 bytes) = 49 8b c0
0038h pop rsi                                 ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
0039h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitMatrix<ulong> oprod_4(BitVector<ulong> x, BitVector<ulong> y, ref BitMatrix<ulong> z)
; static ReadOnlySpan<byte> oprod_4Bytes => new byte[64]{0x56,0x0F,0x1F,0x40,0x00,0x48,0x8B,0xC1,0x4D,0x8B,0x08,0x45,0x33,0xD2,0x49,0x63,0xCA,0x4D,0x8D,0x1C,0xC9,0x41,0x0F,0xB6,0xCA,0x48,0x8B,0xF0,0x48,0xD3,0xEE,0x8B,0xCE,0x83,0xE1,0x01,0x85,0xC9,0x75,0x04,0x33,0xC9,0xEB,0x03,0x48,0x8B,0xCA,0x49,0x89,0x0B,0x41,0xFF,0xC2,0x41,0x83,0xFA,0x40,0x7C,0xD3,0x49,0x8B,0xC0,0x5E,0xC3};
0000h push rsi                                ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0001h nop dword ptr [rax]                     ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(4 bytes) = 0f 1f 40 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h mov r9,[r8]                             ; MOV(Mov_r64_rm64) [R9,mem(64u,R8:br,:sr)]  encoding(3 bytes) = 4d 8b 08
000bh xor r10d,r10d                           ; XOR(Xor_r32_rm32) [R10D,R10D]              encoding(3 bytes) = 45 33 d2
000eh movsxd rcx,r10d                         ; MOVSXD(Movsxd_r64_rm32) [RCX,R10D]         encoding(3 bytes) = 49 63 ca
0011h lea r11,[r9+rcx*8]                      ; LEA(Lea_r64_m) [R11,mem(Unknown,R9:br,:sr)] encoding(4 bytes) = 4d 8d 1c c9
0015h movzx ecx,r10b                          ; MOVZX(Movzx_r32_rm8) [ECX,R10L]            encoding(4 bytes) = 41 0f b6 ca
0019h mov rsi,rax                             ; MOV(Mov_r64_rm64) [RSI,RAX]                encoding(3 bytes) = 48 8b f0
001ch shr rsi,cl                              ; SHR(Shr_rm64_CL) [RSI,CL]                  encoding(3 bytes) = 48 d3 ee
001fh mov ecx,esi                             ; MOV(Mov_r32_rm32) [ECX,ESI]                encoding(2 bytes) = 8b ce
0021h and ecx,1                               ; AND(And_rm32_imm8) [ECX,1h:imm32]          encoding(3 bytes) = 83 e1 01
0024h test ecx,ecx                            ; TEST(Test_rm32_r32) [ECX,ECX]              encoding(2 bytes) = 85 c9
0026h jne short 002ch                         ; JNE(Jne_rel8_64) [2Ch:jmp64]               encoding(2 bytes) = 75 04
0028h xor ecx,ecx                             ; XOR(Xor_r32_rm32) [ECX,ECX]                encoding(2 bytes) = 33 c9
002ah jmp short 002fh                         ; JMP(Jmp_rel8_64) [2Fh:jmp64]               encoding(2 bytes) = eb 03
002ch mov rcx,rdx                             ; MOV(Mov_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 8b ca
002fh mov [r11],rcx                           ; MOV(Mov_rm64_r64) [mem(64u,R11:br,:sr),RCX] encoding(3 bytes) = 49 89 0b
0032h inc r10d                                ; INC(Inc_rm32) [R10D]                       encoding(3 bytes) = 41 ff c2
0035h cmp r10d,40h                            ; CMP(Cmp_rm32_imm8) [R10D,40h:imm32]        encoding(4 bytes) = 41 83 fa 40
0039h jl short 000eh                          ; JL(Jl_rel8_64) [Eh:jmp64]                  encoding(2 bytes) = 7c d3
003bh mov rax,r8                              ; MOV(Mov_r64_rm64) [RAX,R8]                 encoding(3 bytes) = 49 8b c0
003eh pop rsi                                 ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
003fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
