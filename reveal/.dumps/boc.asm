; 2019-10-12 22:52:02:392
; function: BitVector32 and_bv_32u(BitVector32 x, BitVector32 y)
; location: [7FFDAD7BEA60h, 7FFDAD7BEA69h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_bv_32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 and_bv_g32u(BitVector32 x, BitVector32 y)
; location: [7FFDAD7BFEB0h, 7FFDAD7BFEB9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_bv_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 and_bvop_32u(BitVector32 x, BitVector32 y)
; location: [7FFDAD7BFED0h, 7FFDAD7BFED9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_bvop_32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 and_bv_pg32u(PrimalBits<BitVector32,uint> x, PrimalBits<BitVector32,uint> y)
; location: [7FFDAD7C1960h, 7FFDAD7C1969h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_bv_pg32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 and_bvop_pg32u(PrimalBits<BitVector32,uint> x, PrimalBits<BitVector32,uint> y)
; location: [7FFDAD7C1980h, 7FFDAD7C1989h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_bvop_pg32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 or_bv_32u(BitVector32 x, BitVector32 y)
; location: [7FFDAD7C19A0h, 7FFDAD7C19A9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_bv_32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 or_bv_g32u(BitVector32 x, BitVector32 y)
; location: [7FFDAD7C19C0h, 7FFDAD7C19C9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_bv_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 or_bvop_32u(BitVector32 x, BitVector32 y)
; location: [7FFDAD7C19E0h, 7FFDAD7C19E9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_bvop_32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 or_bv_pg32u(PrimalBits<BitVector32,uint> x, PrimalBits<BitVector32,uint> y)
; location: [7FFDAD7C1B20h, 7FFDAD7C1B29h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_bv_pg32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x0B,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 or_bvop_pg32u(PrimalBits<BitVector32,uint> x, PrimalBits<BitVector32,uint> y)
; location: [7FFDAD7C1B40h, 7FFDAD7C1B49h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_bvop_pg32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x0B,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 xor_bv_32u(BitVector32 x, BitVector32 y)
; location: [7FFDAD7C1B60h, 7FFDAD7C1B69h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_bv_32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 xor_bv_g32u(BitVector32 x, BitVector32 y)
; location: [7FFDAD7C1F90h, 7FFDAD7C1F99h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_bv_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 xor_bvop_32u(BitVector32 x, BitVector32 y)
; location: [7FFDAD7C1FB0h, 7FFDAD7C1FB9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_bvop_32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 xor_bv_pg32u(PrimalBits<BitVector32,uint> x, PrimalBits<BitVector32,uint> y)
; location: [7FFDAD7C1FD0h, 7FFDAD7C1FD9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_bv_pg32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 xor_bvop_pg32u(PrimalBits<BitVector32,uint> x, PrimalBits<BitVector32,uint> y)
; location: [7FFDAD7C1FF0h, 7FFDAD7C1FF9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_bvop_pg32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 sll_bv_32u(BitVector32 x, int offset)
; location: [7FFDAD7C2010h, 7FFDAD7C201Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sll_bv_32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 sll_bv_g32u(BitVector32 x, int offset)
; location: [7FFDAD7C2030h, 7FFDAD7C203Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sll_bv_g32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 sll_bvop_32u(BitVector32 x, int offset)
; location: [7FFDAD7C2050h, 7FFDAD7C205Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sll_bvop_32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 sll_bv_pg32u(PrimalBits<BitVector32,uint> x, int offset)
; location: [7FFDAD7C2070h, 7FFDAD7C207Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sll_bv_pg32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 sll_bvop_pg32u(PrimalBits<BitVector32,uint> x, int offset)
; location: [7FFDAD7C2090h, 7FFDAD7C209Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sll_bvop_pg32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 srl_bv_32u(BitVector32 x, int offset)
; location: [7FFDAD7C20B0h, 7FFDAD7C20BBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_bv_32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 srl_bv_g32u(BitVector32 x, int offset)
; location: [7FFDAD7C20D0h, 7FFDAD7C20DBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_bv_g32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 srl_bvop_32u(BitVector32 x, int offset)
; location: [7FFDAD7C20F0h, 7FFDAD7C20FBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_bvop_32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 srl_bv_pg32u(PrimalBits<BitVector32,uint> x, int offset)
; location: [7FFDAD7C2110h, 7FFDAD7C211Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_bv_pg32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 srl_bvop_pg32u(PrimalBits<BitVector32,uint> x, int offset)
; location: [7FFDAD7C2540h, 7FFDAD7C254Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_bvop_pg32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 rotl_bv_32u(BitVector32 x, int offset)
; location: [7FFDAD7C2560h, 7FFDAD7C256Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h rol eax,cl                    ; ROL(Rol_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_bv_32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 rotl_bv_g32u(BitVector32 x, int offset)
; location: [7FFDAD7C2580h, 7FFDAD7C258Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h rol eax,cl                    ; ROL(Rol_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_bv_g32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 rotl_bv_pg32u(PrimalBits<BitVector32,uint> x, int offset)
; location: [7FFDAD7C25A0h, 7FFDAD7C25ABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h rol eax,cl                    ; ROL(Rol_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_bv_pg32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 rotr_bv_32u(BitVector32 x, int offset)
; location: [7FFDAD7C25C0h, 7FFDAD7C25CBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h ror eax,cl                    ; ROR(Ror_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotr_bv_32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 rotr_bv_g32u(BitVector32 x, int offset)
; location: [7FFDAD7C25E0h, 7FFDAD7C25EBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h ror eax,cl                    ; ROR(Ror_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotr_bv_g32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 rotr_bv_pg32u(PrimalBits<BitVector32,uint> x, int offset)
; location: [7FFDAD7C2600h, 7FFDAD7C260Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h ror eax,cl                    ; ROR(Ror_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotr_bv_pg32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 flip_bv_32u(BitVector32 x)
; location: [7FFDAD7C2620h, 7FFDAD7C2629h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_bv_32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 flip_bv_g32u(BitVector32 x)
; location: [7FFDAD7C2640h, 7FFDAD7C2649h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_bv_g32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 flip_bvop_32u(BitVector32 x)
; location: [7FFDAD7C2660h, 7FFDAD7C2669h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_bvop_32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 flip_bv_pg32u(PrimalBits<BitVector32,uint> x)
; location: [7FFDAD7C2680h, 7FFDAD7C2689h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_bv_pg32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 flip_bvop_pg32u(PrimalBits<BitVector32,uint> x)
; location: [7FFDAD7C26A0h, 7FFDAD7C26A9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_bvop_pg32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 negate_bv_32u(BitVector32 x)
; location: [7FFDAD7C26C0h, 7FFDAD7C26CBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_bv_32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 negate_bv_g32u(BitVector32 x)
; location: [7FFDAD7C2AF0h, 7FFDAD7C2B0Ch]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h mov [rsp],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(3 bytes) = 89 0c 24
0008h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 04 24
000ch mov edx,[rsp]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 14 24
000fh not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
0011h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0013h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0015h mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0018h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_bv_g32uBytes => new byte[29]{0x50,0x0F,0x1F,0x40,0x00,0x89,0x0C,0x24,0x48,0x8D,0x04,0x24,0x8B,0x14,0x24,0xF7,0xD2,0xFF,0xC2,0x89,0x10,0x8B,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 negate_bvop_32u(BitVector32 x)
; location: [7FFDAD7C2B30h, 7FFDAD7C2B3Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_bvop_32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 negate_bv_pg32u(PrimalBits<BitVector32,uint> x)
; location: [7FFDAD7C2B50h, 7FFDAD7C2B5Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_bv_pg32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 negate_bvop_pg32u(PrimalBits<BitVector32,uint> x)
; location: [7FFDAD7C2B70h, 7FFDAD7C2B7Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_bvop_pg32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 inc_bv_32u(BitVector32 x)
; location: [7FFDAD7C2B90h, 7FFDAD7C2B98h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 01
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_bv_32uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 inc_bv_g32u(BitVector32 x)
; location: [7FFDAD7C2BB0h, 7FFDAD7C2BB8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 01
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_bv_g32uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 inc_bvop_32u(BitVector32 x)
; location: [7FFDAD7C2BD0h, 7FFDAD7C2BD8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 01
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_bvop_32uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 inc_bv_pg32u(PrimalBits<BitVector32,uint> x)
; location: [7FFDAD7C2BF0h, 7FFDAD7C2BF9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc ecx                       ; INC(Inc_rm32) [ECX]                                  encoding(2 bytes) = ff c1
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_bv_pg32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC1,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 inc_bvop_pg32u(PrimalBits<BitVector32,uint> x)
; location: [7FFDAD7C2C10h, 7FFDAD7C2C19h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc ecx                       ; INC(Inc_rm32) [ECX]                                  encoding(2 bytes) = ff c1
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_bvop_pg32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC1,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 dec_bv_32u(BitVector32 x)
; location: [7FFDAD7C2C30h, 7FFDAD7C2C38h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx-1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 ff
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_bv_32uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 dec_bv_g32u(BitVector32 x)
; location: [7FFDAD7C2C50h, 7FFDAD7C2C58h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx-1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 ff
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_bv_g32uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 dec_bvop_32u(BitVector32 x)
; location: [7FFDAD7C2C70h, 7FFDAD7C2C78h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx-1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 ff
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_bvop_32uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 dec_bv_pg32u(PrimalBits<BitVector32,uint> x)
; location: [7FFDAD7C2C90h, 7FFDAD7C2C99h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec ecx                       ; DEC(Dec_rm32) [ECX]                                  encoding(2 bytes) = ff c9
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_bv_pg32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC9,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 dec_bvop_pg32u(PrimalBits<BitVector32,uint> x)
; location: [7FFDAD7C30C0h, 7FFDAD7C30C9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec ecx                       ; DEC(Dec_rm32) [ECX]                                  encoding(2 bytes) = ff c9
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_bvop_pg32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC9,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte bitmap_d8i_to_8i(in sbyte src, byte srcOffset, byte len, byte dstOffset, ref sbyte dst)
; location: [7FFDAD7C30E0h, 7FFDAD7C3121h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movsx r11,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [R11,mem(8i,RAX:br,DS:sr)]      encoding(4 bytes) = 4c 0f be 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11b                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R11L]          encoding(3 bytes) = 44 88 18
001bh movsx rcx,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [RCX,mem(8i,RAX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 08
001fh movsx r9,byte ptr [r10]       ; MOVSX(Movsx_r64_rm8) [R9,mem(8i,R10:br,DS:sr)]       encoding(4 bytes) = 4d 0f be 0a
0023h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0026h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002ah shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002eh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0031h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0034h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0039h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
003dh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003fh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmap_d8i_to_8iBytes => new byte[66]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x4C,0x0F,0xBE,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x44,0x88,0x18,0x48,0x0F,0xBE,0x08,0x4D,0x0F,0xBE,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x48,0x0F,0xBE,0xD2,0x0B,0xD1,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte bitmap_g8i_to_8i(in sbyte src, byte srcOffset, byte len, byte dstOffset, ref sbyte dst)
; location: [7FFDAD7C3140h, 7FFDAD7C3181h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movsx r11,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [R11,mem(8i,RAX:br,DS:sr)]      encoding(4 bytes) = 4c 0f be 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11b                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R11L]          encoding(3 bytes) = 44 88 18
001bh movsx rcx,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [RCX,mem(8i,RAX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 08
001fh movsx r9,byte ptr [r10]       ; MOVSX(Movsx_r64_rm8) [R9,mem(8i,R10:br,DS:sr)]       encoding(4 bytes) = 4d 0f be 0a
0023h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0026h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002ah shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002eh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0031h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0034h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0039h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
003dh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003fh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmap_g8i_to_8iBytes => new byte[66]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x4C,0x0F,0xBE,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x44,0x88,0x18,0x48,0x0F,0xBE,0x08,0x4D,0x0F,0xBE,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x48,0x0F,0xBE,0xD2,0x0B,0xD1,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte bitmap_d8u_to_8u(in byte src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
; location: [7FFDAD7C31A0h, 7FFDAD7C31DFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx r11d,byte ptr [rax]     ; MOVZX(Movzx_r32_rm8) [R11D,mem(8u,RAX:br,DS:sr)]     encoding(4 bytes) = 44 0f b6 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11b                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R11L]          encoding(3 bytes) = 44 88 18
001bh movzx ecx,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RAX:br,DS:sr)]      encoding(3 bytes) = 0f b6 08
001eh movzx r9d,byte ptr [r10]      ; MOVZX(Movzx_r32_rm8) [R9D,mem(8u,R10:br,DS:sr)]      encoding(4 bytes) = 45 0f b6 0a
0022h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0025h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0029h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002dh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0030h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0033h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0038h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
003bh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003dh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
003fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmap_d8u_to_8uBytes => new byte[64]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x44,0x0F,0xB6,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x44,0x88,0x18,0x0F,0xB6,0x08,0x45,0x0F,0xB6,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0F,0xB6,0xD2,0x0B,0xD1,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte bitmap_g8u_to_8u(in byte src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
; location: [7FFDAD7C31F0h, 7FFDAD7C322Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx r11d,byte ptr [rax]     ; MOVZX(Movzx_r32_rm8) [R11D,mem(8u,RAX:br,DS:sr)]     encoding(4 bytes) = 44 0f b6 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11b                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R11L]          encoding(3 bytes) = 44 88 18
001bh movzx ecx,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RAX:br,DS:sr)]      encoding(3 bytes) = 0f b6 08
001eh movzx r9d,byte ptr [r10]      ; MOVZX(Movzx_r32_rm8) [R9D,mem(8u,R10:br,DS:sr)]      encoding(4 bytes) = 45 0f b6 0a
0022h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0025h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0029h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002dh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0030h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0033h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0038h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
003bh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003dh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
003fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmap_g8u_to_8uBytes => new byte[64]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x44,0x0F,0xB6,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x44,0x88,0x18,0x0F,0xB6,0x08,0x45,0x0F,0xB6,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0F,0xB6,0xD2,0x0B,0xD1,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short bitmap_d16i_to_16i(in short src, byte srcOffset, byte len, byte dstOffset, ref short dst)
; location: [7FFDAD7C3240h, 7FFDAD7C3283h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movsx r11,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [R11,mem(16i,RAX:br,DS:sr)]    encoding(4 bytes) = 4c 0f bf 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11w                ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R11W]       encoding(4 bytes) = 66 44 89 18
001ch movsx rcx,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [RCX,mem(16i,RAX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 08
0020h movsx r9,word ptr [r10]       ; MOVSX(Movsx_r64_rm16) [R9,mem(16i,R10:br,DS:sr)]     encoding(4 bytes) = 4d 0f bf 0a
0024h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0027h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002bh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002fh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0032h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0035h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
003ah movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
003eh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0040h mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 10
0043h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmap_d16i_to_16iBytes => new byte[68]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x4C,0x0F,0xBF,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x66,0x44,0x89,0x18,0x48,0x0F,0xBF,0x08,0x4D,0x0F,0xBF,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x48,0x0F,0xBF,0xD2,0x0B,0xD1,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short bitmap_g16i_to_16i(in short src, byte srcOffset, byte len, byte dstOffset, ref short dst)
; location: [7FFDAD7C32A0h, 7FFDAD7C32E3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movsx r11,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [R11,mem(16i,RAX:br,DS:sr)]    encoding(4 bytes) = 4c 0f bf 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11w                ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R11W]       encoding(4 bytes) = 66 44 89 18
001ch movsx rcx,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [RCX,mem(16i,RAX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 08
0020h movsx r9,word ptr [r10]       ; MOVSX(Movsx_r64_rm16) [R9,mem(16i,R10:br,DS:sr)]     encoding(4 bytes) = 4d 0f bf 0a
0024h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0027h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002bh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002fh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0032h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0035h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
003ah movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
003eh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0040h mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 10
0043h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmap_g16i_to_16iBytes => new byte[68]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x4C,0x0F,0xBF,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x66,0x44,0x89,0x18,0x48,0x0F,0xBF,0x08,0x4D,0x0F,0xBF,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x48,0x0F,0xBF,0xD2,0x0B,0xD1,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort bitmapd_16u_to_16u(in ushort src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
; location: [7FFDAD7C3300h, 7FFDAD7C3341h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx r11d,word ptr [rax]     ; MOVZX(Movzx_r32_rm16) [R11D,mem(16u,RAX:br,DS:sr)]   encoding(4 bytes) = 44 0f b7 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11w                ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R11W]       encoding(4 bytes) = 66 44 89 18
001ch movzx ecx,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [ECX,mem(16u,RAX:br,DS:sr)]    encoding(3 bytes) = 0f b7 08
001fh movzx r9d,word ptr [r10]      ; MOVZX(Movzx_r32_rm16) [R9D,mem(16u,R10:br,DS:sr)]    encoding(4 bytes) = 45 0f b7 0a
0023h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0026h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002ah shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002eh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0031h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0034h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0039h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
003ch or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003eh mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 10
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapd_16u_to_16uBytes => new byte[66]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x44,0x0F,0xB7,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x66,0x44,0x89,0x18,0x0F,0xB7,0x08,0x45,0x0F,0xB7,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0F,0xB7,0xD2,0x0B,0xD1,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort bitmap_g16u_to_16u(in ushort src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
; location: [7FFDAD7C3360h, 7FFDAD7C33A1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx r11d,word ptr [rax]     ; MOVZX(Movzx_r32_rm16) [R11D,mem(16u,RAX:br,DS:sr)]   encoding(4 bytes) = 44 0f b7 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11w                ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R11W]       encoding(4 bytes) = 66 44 89 18
001ch movzx ecx,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [ECX,mem(16u,RAX:br,DS:sr)]    encoding(3 bytes) = 0f b7 08
001fh movzx r9d,word ptr [r10]      ; MOVZX(Movzx_r32_rm16) [R9D,mem(16u,R10:br,DS:sr)]    encoding(4 bytes) = 45 0f b7 0a
0023h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0026h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002ah shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002eh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0031h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0034h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0039h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
003ch or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003eh mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 10
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmap_g16u_to_16uBytes => new byte[66]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x44,0x0F,0xB7,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x66,0x44,0x89,0x18,0x0F,0xB7,0x08,0x45,0x0F,0xB7,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0F,0xB7,0xD2,0x0B,0xD1,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int bitmap_d32i_to_32i(in int src, byte srcOffset, byte len, byte dstOffset, ref int dst)
; location: [7FFDAD7C33C0h, 7FFDAD7C33F2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,DS:sr),CL]          encoding(2 bytes) = d3 20
0013h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0015h mov r9d,[r10]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,R10:br,DS:sr)]        encoding(3 bytes) = 45 8b 0a
0018h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001bh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001fh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0023h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0026h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0029h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
002eh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0030h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmap_d32i_to_32iBytes => new byte[51]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0xD3,0x20,0x8B,0x08,0x45,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0B,0xD1,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int bitmap_g32i_to_32i(in int src, byte srcOffset, byte len, byte dstOffset, ref int dst)
; location: [7FFDAD7C3410h, 7FFDAD7C3442h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,DS:sr),CL]          encoding(2 bytes) = d3 20
0013h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0015h mov r9d,[r10]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,R10:br,DS:sr)]        encoding(3 bytes) = 45 8b 0a
0018h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001bh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001fh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0023h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0026h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0029h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
002eh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0030h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmap_g32i_to_32iBytes => new byte[51]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0xD3,0x20,0x8B,0x08,0x45,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0B,0xD1,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint bitmap_d32u_to_32u(in uint src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
; location: [7FFDAD7C3460h, 7FFDAD7C3492h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,DS:sr),CL]          encoding(2 bytes) = d3 20
0013h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0015h mov r9d,[r10]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,R10:br,DS:sr)]        encoding(3 bytes) = 45 8b 0a
0018h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001bh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001fh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0023h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0026h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0029h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
002eh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0030h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmap_d32u_to_32uBytes => new byte[51]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0xD3,0x20,0x8B,0x08,0x45,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0B,0xD1,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint bitmap_g32u_to_32u(in uint src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
; location: [7FFDAD7C34B0h, 7FFDAD7C34E2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,DS:sr),CL]          encoding(2 bytes) = d3 20
0013h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0015h mov r9d,[r10]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,R10:br,DS:sr)]        encoding(3 bytes) = 45 8b 0a
0018h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001bh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001fh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0023h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0026h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0029h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
002eh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0030h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmap_g32u_to_32uBytes => new byte[51]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0xD3,0x20,0x8B,0x08,0x45,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0B,0xD1,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long bitmap_d64i_to_64i(in long src, byte srcOffset, byte len, byte dstOffset, ref long dst)
; location: [7FFDAD7C3500h, 7FFDAD7C3536h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 08
0017h mov r9,[r10]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,R10:br,DS:sr)]         encoding(3 bytes) = 4d 8b 0a
001ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0021h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0025h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0028h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002bh bextr rdx,r9,rdx              ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R9,RDX]           encoding(VEX, 5 bytes) = c4 c2 e8 f7 d1
0030h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0033h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmap_d64i_to_64iBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x4D,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD1,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long bitmap_g64i_to_64i(in long src, byte srcOffset, byte len, byte dstOffset, ref long dst)
; location: [7FFDAD7C3550h, 7FFDAD7C3586h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 08
0017h mov r9,[r10]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,R10:br,DS:sr)]         encoding(3 bytes) = 4d 8b 0a
001ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0021h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0025h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0028h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002bh bextr rdx,r9,rdx              ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R9,RDX]           encoding(VEX, 5 bytes) = c4 c2 e8 f7 d1
0030h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0033h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmap_g64i_to_64iBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x4D,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD1,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong bitmap_d64u_to_64u(in ulong src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
; location: [7FFDAD7C35A0h, 7FFDAD7C35D6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 08
0017h mov r9,[r10]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,R10:br,DS:sr)]         encoding(3 bytes) = 4d 8b 0a
001ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0021h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0025h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0028h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002bh bextr rdx,r9,rdx              ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R9,RDX]           encoding(VEX, 5 bytes) = c4 c2 e8 f7 d1
0030h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0033h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmap_d64u_to_64uBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x4D,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD1,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong bitmap_g64u_to_64u(in ulong src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
; location: [7FFDAD7C35F0h, 7FFDAD7C3626h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 08
0017h mov r9,[r10]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,R10:br,DS:sr)]         encoding(3 bytes) = 4d 8b 0a
001ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0021h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0025h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0028h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002bh bextr rdx,r9,rdx              ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R9,RDX]           encoding(VEX, 5 bytes) = c4 c2 e8 f7 d1
0030h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0033h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmap_g64u_to_64uBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x4D,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD1,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float bitmapbit_d32f_to_32f(in float src, byte srcOffset, byte len, byte dstOffset, ref float dst)
; location: [7FFDAD7C3640h, 7FFDAD7C36A8h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rsp+40h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 40
000ch vmovss xmm0,dword ptr [rcx]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 10 01
0010h vmovss dword ptr [rsp+14h],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
0016h mov ecx,[rsp+14h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 14
001ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0021h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0025h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0028h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002bh bextr edx,ecx,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,ECX,EDX]          encoding(VEX, 5 bytes) = c4 e2 68 f7 d1
0030h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0034h shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
0036h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
003ah vcvtsi2ss xmm0,xmm0,edx       ; VCVTSI2SS(VEX_Vcvtsi2ss_xmm_xmm_rm32) [XMM0,XMM0,EDX] encoding(VEX, 4 bytes) = c5 fa 2a c2
003eh vmovss xmm1,dword ptr [rax]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 10 08
0042h vmovss dword ptr [rsp+10h],xmm1; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 11 4c 24 10
0048h mov edx,[rsp+10h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 10
004ch vmovss dword ptr [rsp+0Ch],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 0c
0052h or edx,[rsp+0Ch]              ; OR(Or_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]          encoding(4 bytes) = 0b 54 24 0c
0056h mov [rsp+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 08
005ah vmovss xmm0,dword ptr [rsp+8] ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 08
0060h vmovss dword ptr [rax],xmm0   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RAX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 11 00
0064h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0068h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapbit_d32f_to_32fBytes => new byte[105]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x8B,0x44,0x24,0x40,0xC5,0xFA,0x10,0x01,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x4C,0x24,0x14,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xE2,0x68,0xF7,0xD1,0x41,0x0F,0xB6,0xC9,0xD3,0xE2,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x2A,0xC2,0xC5,0xFA,0x10,0x08,0xC5,0xFA,0x11,0x4C,0x24,0x10,0x8B,0x54,0x24,0x10,0xC5,0xFA,0x11,0x44,0x24,0x0C,0x0B,0x54,0x24,0x0C,0x89,0x54,0x24,0x08,0xC5,0xFA,0x10,0x44,0x24,0x08,0xC5,0xFA,0x11,0x00,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float bitmap_g32f_to_32f(in float src, byte srcOffset, byte len, byte dstOffset, ref float dst)
; location: [7FFDAD7C3AD0h, 7FFDAD7C3B38h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rsp+40h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 40
000ch vmovss xmm0,dword ptr [rcx]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 10 01
0010h vmovss dword ptr [rsp+14h],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
0016h mov ecx,[rsp+14h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 14
001ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0021h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0025h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0028h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002bh bextr edx,ecx,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,ECX,EDX]          encoding(VEX, 5 bytes) = c4 e2 68 f7 d1
0030h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0034h shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
0036h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
003ah vcvtsi2ss xmm0,xmm0,edx       ; VCVTSI2SS(VEX_Vcvtsi2ss_xmm_xmm_rm32) [XMM0,XMM0,EDX] encoding(VEX, 4 bytes) = c5 fa 2a c2
003eh vmovss xmm1,dword ptr [rax]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 10 08
0042h vmovss dword ptr [rsp+10h],xmm1; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 11 4c 24 10
0048h mov edx,[rsp+10h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 10
004ch vmovss dword ptr [rsp+0Ch],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 0c
0052h or edx,[rsp+0Ch]              ; OR(Or_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]          encoding(4 bytes) = 0b 54 24 0c
0056h mov [rsp+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 08
005ah vmovss xmm0,dword ptr [rsp+8] ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 08
0060h vmovss dword ptr [rax],xmm0   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RAX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 11 00
0064h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0068h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmap_g32f_to_32fBytes => new byte[105]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x8B,0x44,0x24,0x40,0xC5,0xFA,0x10,0x01,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x4C,0x24,0x14,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xE2,0x68,0xF7,0xD1,0x41,0x0F,0xB6,0xC9,0xD3,0xE2,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x2A,0xC2,0xC5,0xFA,0x10,0x08,0xC5,0xFA,0x11,0x4C,0x24,0x10,0x8B,0x54,0x24,0x10,0xC5,0xFA,0x11,0x44,0x24,0x0C,0x0B,0x54,0x24,0x0C,0x89,0x54,0x24,0x08,0xC5,0xFA,0x10,0x44,0x24,0x08,0xC5,0xFA,0x11,0x00,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref double bitmapbit_d64f_to_64f(in double src, byte srcOffset, byte len, byte dstOffset, ref double dst)
; location: [7FFDAD7C3B60h, 7FFDAD7C3BCEh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rsp+50h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 50
000ch vmovsd xmm0,qword ptr [rcx]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb 10 01
0010h vmovsd qword ptr [rsp+20h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 20
0016h mov rcx,[rsp+20h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 4c 24 20
001bh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001eh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0022h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0026h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0029h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002ch bextr rdx,rcx,rdx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,RCX,RDX]          encoding(VEX, 5 bytes) = c4 e2 e8 f7 d1
0031h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0035h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0038h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
003ch vcvtsi2sd xmm0,xmm0,rdx       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm64) [XMM0,XMM0,RDX] encoding(VEX, 5 bytes) = c4 e1 fb 2a c2
0041h vmovsd xmm1,qword ptr [rax]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb 10 08
0045h vmovsd qword ptr [rsp+18h],xmm1; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fb 11 4c 24 18
004bh mov rdx,[rsp+18h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 54 24 18
0050h vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
0056h or rdx,[rsp+10h]              ; OR(Or_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]          encoding(5 bytes) = 48 0b 54 24 10
005bh mov [rsp+8],rdx               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(5 bytes) = 48 89 54 24 08
0060h vmovsd xmm0,qword ptr [rsp+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 08
0066h vmovsd qword ptr [rax],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RAX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fb 11 00
006ah add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
006eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapbit_d64f_to_64fBytes => new byte[111]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x48,0x8B,0x44,0x24,0x50,0xC5,0xFB,0x10,0x01,0xC5,0xFB,0x11,0x44,0x24,0x20,0x48,0x8B,0x4C,0x24,0x20,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xE2,0xE8,0xF7,0xD1,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0xE2,0xC5,0xF8,0x57,0xC0,0xC4,0xE1,0xFB,0x2A,0xC2,0xC5,0xFB,0x10,0x08,0xC5,0xFB,0x11,0x4C,0x24,0x18,0x48,0x8B,0x54,0x24,0x18,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x0B,0x54,0x24,0x10,0x48,0x89,0x54,0x24,0x08,0xC5,0xFB,0x10,0x44,0x24,0x08,0xC5,0xFB,0x11,0x00,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref double bitmap_g64f_to_64f(in double src, byte srcOffset, byte len, byte dstOffset, ref double dst)
; location: [7FFDAD7C3BF0h, 7FFDAD7C3C5Eh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rsp+50h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 50
000ch vmovsd xmm0,qword ptr [rcx]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb 10 01
0010h vmovsd qword ptr [rsp+20h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 20
0016h mov rcx,[rsp+20h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 4c 24 20
001bh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001eh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0022h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0026h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0029h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002ch bextr rdx,rcx,rdx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,RCX,RDX]          encoding(VEX, 5 bytes) = c4 e2 e8 f7 d1
0031h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0035h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0038h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
003ch vcvtsi2sd xmm0,xmm0,rdx       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm64) [XMM0,XMM0,RDX] encoding(VEX, 5 bytes) = c4 e1 fb 2a c2
0041h vmovsd xmm1,qword ptr [rax]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb 10 08
0045h vmovsd qword ptr [rsp+18h],xmm1; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fb 11 4c 24 18
004bh mov rdx,[rsp+18h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 54 24 18
0050h vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
0056h or rdx,[rsp+10h]              ; OR(Or_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]          encoding(5 bytes) = 48 0b 54 24 10
005bh mov [rsp+8],rdx               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(5 bytes) = 48 89 54 24 08
0060h vmovsd xmm0,qword ptr [rsp+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 08
0066h vmovsd qword ptr [rax],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RAX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fb 11 00
006ah add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
006eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmap_g64f_to_64fBytes => new byte[111]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x48,0x8B,0x44,0x24,0x50,0xC5,0xFB,0x10,0x01,0xC5,0xFB,0x11,0x44,0x24,0x20,0x48,0x8B,0x4C,0x24,0x20,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xE2,0xE8,0xF7,0xD1,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0xE2,0xC5,0xF8,0x57,0xC0,0xC4,0xE1,0xFB,0x2A,0xC2,0xC5,0xFB,0x10,0x08,0xC5,0xFB,0x11,0x4C,0x24,0x18,0x48,0x8B,0x54,0x24,0x18,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x0B,0x54,0x24,0x10,0x48,0x89,0x54,0x24,0x08,0xC5,0xFB,0x10,0x44,0x24,0x08,0xC5,0xFB,0x11,0x00,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte blsmsk_d8u(byte src)
; location: [7FFDAD7C3C80h, 7FFDAD7C3C90h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h blsmsk eax,eax                ; BLSMSK(VEX_Blsmsk_r32_rm32) [EAX,EAX]                encoding(VEX, 5 bytes) = c4 e2 78 f3 d0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmsk_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x78,0xF3,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte blsmsk_g8u(byte src)
; location: [7FFDAD7C3CB0h, 7FFDAD7C3CC0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h blsmsk eax,eax                ; BLSMSK(VEX_Blsmsk_r32_rm32) [EAX,EAX]                encoding(VEX, 5 bytes) = c4 e2 78 f3 d0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmsk_g8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x78,0xF3,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort blsmsk_d16u(ushort src)
; location: [7FFDAD7C3CE0h, 7FFDAD7C3CF0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h blsmsk eax,eax                ; BLSMSK(VEX_Blsmsk_r32_rm32) [EAX,EAX]                encoding(VEX, 5 bytes) = c4 e2 78 f3 d0
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmsk_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC4,0xE2,0x78,0xF3,0xD0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort blsmsk_g16u(ushort src)
; location: [7FFDAD7C3D10h, 7FFDAD7C3D20h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h blsmsk eax,eax                ; BLSMSK(VEX_Blsmsk_r32_rm32) [EAX,EAX]                encoding(VEX, 5 bytes) = c4 e2 78 f3 d0
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmsk_g16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC4,0xE2,0x78,0xF3,0xD0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint blsmsk_d32u(uint src)
; location: [7FFDAD7C3D40h, 7FFDAD7C3D4Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsmsk eax,ecx                ; BLSMSK(VEX_Blsmsk_r32_rm32) [EAX,ECX]                encoding(VEX, 5 bytes) = c4 e2 78 f3 d1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmsk_d32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x78,0xF3,0xD1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint blsmsk_g32u(uint src)
; location: [7FFDAD7C3D60h, 7FFDAD7C3D6Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsmsk eax,ecx                ; BLSMSK(VEX_Blsmsk_r32_rm32) [EAX,ECX]                encoding(VEX, 5 bytes) = c4 e2 78 f3 d1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmsk_g32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x78,0xF3,0xD1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong blsmsk_g64u(ulong src)
; location: [7FFDAD7C3D80h, 7FFDAD7C3D8Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsmsk rax,rcx                ; BLSMSK(VEX_Blsmsk_r64_rm64) [RAX,RCX]                encoding(VEX, 5 bytes) = c4 e2 f8 f3 d1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmsk_g64uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF8,0xF3,0xD1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong blsmsk_d64u(ulong src)
; location: [7FFDAD7C3DA0h, 7FFDAD7C3DAAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsmsk rax,rcx                ; BLSMSK(VEX_Blsmsk_r64_rm64) [RAX,RCX]                encoding(VEX, 5 bytes) = c4 e2 f8 f3 d1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmsk_d64uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF8,0xF3,0xD1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte bzhi_d8u(byte src, uint index)
; location: [7FFDAD7C3DC0h, 7FFDAD7C3DD0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h bzhi eax,eax,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhi_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x68,0xF5,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte bzhi_g8u(byte src, uint index)
; location: [7FFDAD7C3DF0h, 7FFDAD7C3E00h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h bzhi eax,eax,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhi_g8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x68,0xF5,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte bzhi_g8u_ref(ref byte src, uint index)
; location: [7FFDAD7C3E20h, 7FFDAD7C3E32h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h bzhi eax,eax,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c0
000dh mov [rcx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 88 01
000fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhi_g8u_refBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0xC4,0xE2,0x68,0xF5,0xC0,0x88,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort bzhi_d16u(ushort src, ushort index)
; location: [7FFDAD7C3E50h, 7FFDAD7C3E63h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h movzx edx,cx                  ; MOVZX(Movzx_r32_rm16) [EDX,CX]                       encoding(3 bytes) = 0f b7 d1
000bh bzhi eax,edx,eax              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,EDX,EAX]            encoding(VEX, 5 bytes) = c4 e2 78 f5 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhi_d16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0x0F,0xB7,0xD1,0xC4,0xE2,0x78,0xF5,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort bzhi_g16u(ushort src, ushort index)
; location: [7FFDAD7C3E80h, 7FFDAD7C3E93h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh bzhi eax,eax,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c0
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhi_g16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC4,0xE2,0x68,0xF5,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort bzhi_g16u_ref(ref ushort src, ushort index)
; location: [7FFDAD7C3EB0h, 7FFDAD7C3EC6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h movzx edx,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EDX,mem(16u,RCX:br,DS:sr)]    encoding(3 bytes) = 0f b7 11
000bh bzhi eax,edx,eax              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,EDX,EAX]            encoding(VEX, 5 bytes) = c4 e2 78 f5 c2
0010h mov [rcx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 01
0013h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhi_g16u_refBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0x0F,0xB7,0x11,0xC4,0xE2,0x78,0xF5,0xC2,0x66,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint bzhi_d32u(uint src, uint index)
; location: [7FFDAD7C3EE0h, 7FFDAD7C3EEAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bzhi eax,ecx,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhi_d32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x68,0xF5,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint bzhi_g32u(uint src, uint index)
; location: [7FFDAD7C3F00h, 7FFDAD7C3F0Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bzhi eax,ecx,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhi_g32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x68,0xF5,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint bzhi_g32u_ref(ref uint src, uint index)
; location: [7FFDAD7C3F20h, 7FFDAD7C3F2Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bzhi eax,[rcx],edx            ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,mem(32u,RCX:br,DS:sr),EDX] encoding(VEX, 5 bytes) = c4 e2 68 f5 01
000ah mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
000ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhi_g32u_refBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x68,0xF5,0x01,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong bzhi_d64u(ulong src, uint index)
; location: [7FFDAD7C3F40h, 7FFDAD7C3F4Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h bzhi rax,rcx,rax              ; BZHI(VEX_Bzhi_r64_rm64_r64) [RAX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f8 f5 c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhi_d64uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xC4,0xE2,0xF8,0xF5,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong bzhi_g64u(ulong src, uint index)
; location: [7FFDAD7C3F60h, 7FFDAD7C3F6Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h bzhi rax,rcx,rax              ; BZHI(VEX_Bzhi_r64_rm64_r64) [RAX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f8 f5 c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhi_g64uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xC4,0xE2,0xF8,0xF5,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong bzhi_g64u_ref(ref ulong src, uint index)
; location: [7FFDAD7C3F80h, 7FFDAD7C3F92h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h bzhi rax,[rcx],rax            ; BZHI(VEX_Bzhi_r64_rm64_r64) [RAX,mem(64u,RCX:br,DS:sr),RAX] encoding(VEX, 5 bytes) = c4 e2 f8 f5 01
000ch mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
000fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhi_g64u_refBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xC4,0xE2,0xF8,0xF5,0x01,0x48,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte gather_d8u(byte src, byte mask)
; location: [7FFDAD7C3FB0h, 7FFDAD7C3FC3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gather_d8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte gather_g8u(byte src, byte mask)
; location: [7FFDAD7C3FE0h, 7FFDAD7C3FFFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 10
000dh movzx eax,byte ptr [rsp+8]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 08
0012h movzx edx,byte ptr [rsp+10h]  ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 10
0017h pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gather_g8uBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x89,0x54,0x24,0x10,0x0F,0xB6,0x44,0x24,0x08,0x0F,0xB6,0x54,0x24,0x10,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort gather_d16u(ushort src, ushort mask)
; location: [7FFDAD7C4010h, 7FFDAD7C4023h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gather_d16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort gather_g16u(ushort src, ushort mask)
; location: [7FFDAD7C4040h, 7FFDAD7C405Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],ecx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 08
0009h mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 10
000dh movzx eax,word ptr [rsp+8]    ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RSP:br,SS:sr)]    encoding(5 bytes) = 0f b7 44 24 08
0012h movzx edx,word ptr [rsp+10h]  ; MOVZX(Movzx_r32_rm16) [EDX,mem(16u,RSP:br,SS:sr)]    encoding(5 bytes) = 0f b7 54 24 10
0017h pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
001ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gather_g16uBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x4C,0x24,0x08,0x89,0x54,0x24,0x10,0x0F,0xB7,0x44,0x24,0x08,0x0F,0xB7,0x54,0x24,0x10,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint gather_d32u(uint src, uint mask)
; location: [7FFDAD7C4070h, 7FFDAD7C407Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gather_d32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint gather_g32u(uint src, uint mask)
; location: [7FFDAD7C4090h, 7FFDAD7C409Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gather_g32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong gather_d64u(ulong src, ulong mask)
; location: [7FFDAD7C40B0h, 7FFDAD7C40BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gather_d64uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong gather_g64u(ulong src, ulong mask)
; location: [7FFDAD7C40D0h, 7FFDAD7C40DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gather_g64uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte bitrange_d8i(sbyte src, BitPos i0, BitPos i1)
; location: [7FFDAD7C40F0h, 7FFDAD7C4135h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
000bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000dh jge short 0015h               ; JGE(Jge_rel8_64) [15h:jmp64]                         encoding(2 bytes) = 7d 06
000fh neg edx                       ; NEG(Neg_rm32) [EDX]                                  encoding(2 bytes) = f7 da
0011h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0013h jl short 0040h                ; JL(Jl_rel8_64) [40h:jmp64]                           encoding(2 bytes) = 7c 2b
0015h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0017h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0023h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0025h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0028h movsx rdx,cl                  ; MOVSX(Movsx_r64_rm8) [RDX,CL]                        encoding(4 bytes) = 48 0f be d1
002ch movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
002fh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0034h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0037h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
003bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
003fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0040h call 7FFDAD3DF4B0h            ; CALL(Call_rel32_64) [FFFFFFFFFFC1B3C0h:jmp64]        encoding(5 bytes) = e8 7b b3 c1 ff
0045h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitrange_d8iBytes => new byte[70]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0x41,0x2B,0xD0,0x85,0xD2,0x7D,0x06,0xF7,0xDA,0x85,0xD2,0x7C,0x2B,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBE,0xD1,0x0F,0xB6,0xD2,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB6,0xC0,0x48,0x0F,0xBE,0xC0,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x7B,0xB3,0xC1,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte bitrange_g8i(sbyte src, BitPos i0, BitPos i1)
; location: [7FFDAD7C4150h, 7FFDAD7C419Bh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov [rsp+30h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 30
0009h movsx rax,byte ptr [rsp+30h]  ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RSP:br,SS:sr)]      encoding(6 bytes) = 48 0f be 44 24 30
000fh movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
0012h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
0015h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0017h jge short 001fh               ; JGE(Jge_rel8_64) [1Fh:jmp64]                         encoding(2 bytes) = 7d 06
0019h neg edx                       ; NEG(Neg_rm32) [EDX]                                  encoding(2 bytes) = f7 da
001bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
001dh jl short 0046h                ; JL(Jl_rel8_64) [46h:jmp64]                           encoding(2 bytes) = 7c 27
001fh inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0021h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
0024h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0027h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
002ah shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
002dh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
002fh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0032h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0035h bextr eax,eax,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EAX,EDX]          encoding(VEX, 5 bytes) = c4 e2 68 f7 c0
003ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0041h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0046h call 7FFDAD3DF4B0h            ; CALL(Call_rel32_64) [FFFFFFFFFFC1B360h:jmp64]        encoding(5 bytes) = e8 15 b3 c1 ff
004bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitrange_g8iBytes => new byte[76]{0x48,0x83,0xEC,0x28,0x90,0x89,0x4C,0x24,0x30,0x48,0x0F,0xBE,0x44,0x24,0x30,0x0F,0xB6,0xCA,0x41,0x2B,0xD0,0x85,0xD2,0x7D,0x06,0xF7,0xDA,0x85,0xD2,0x7C,0x27,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xC9,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xD1,0x0F,0xB7,0xD2,0x0F,0xB6,0xC0,0xC4,0xE2,0x68,0xF7,0xC0,0x0F,0xB6,0xC0,0x48,0x0F,0xBE,0xC0,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x15,0xB3,0xC1,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte bitrange_d8u(byte src, BitPos i0, BitPos i1)
; location: [7FFDAD7C41B0h, 7FFDAD7C41EDh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
000bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000dh jge short 0015h               ; JGE(Jge_rel8_64) [15h:jmp64]                         encoding(2 bytes) = 7d 06
000fh neg edx                       ; NEG(Neg_rm32) [EDX]                                  encoding(2 bytes) = f7 da
0011h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0013h jl short 0038h                ; JL(Jl_rel8_64) [38h:jmp64]                           encoding(2 bytes) = 7c 23
0015h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0017h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0023h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0025h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0028h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
002bh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0030h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0033h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0037h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0038h call 7FFDAD3DF4B0h            ; CALL(Call_rel32_64) [FFFFFFFFFFC1B300h:jmp64]        encoding(5 bytes) = e8 c3 b2 c1 ff
003dh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitrange_d8uBytes => new byte[62]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0x41,0x2B,0xD0,0x85,0xD2,0x7D,0x06,0xF7,0xDA,0x85,0xD2,0x7C,0x23,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB6,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xC3,0xB2,0xC1,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte bitrange_g8u(byte src, BitPos i0, BitPos i1)
; location: [7FFDAD7C4610h, 7FFDAD7C4653h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov [rsp+30h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 30
0009h movzx eax,byte ptr [rsp+30h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 30
000eh movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
0011h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
0014h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0016h jge short 001eh               ; JGE(Jge_rel8_64) [1Eh:jmp64]                         encoding(2 bytes) = 7d 06
0018h neg edx                       ; NEG(Neg_rm32) [EDX]                                  encoding(2 bytes) = f7 da
001ah test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
001ch jl short 003eh                ; JL(Jl_rel8_64) [3Eh:jmp64]                           encoding(2 bytes) = 7c 20
001eh inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0020h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
0023h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0026h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0029h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
002ch or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
002eh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0031h bextr eax,eax,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EAX,EDX]          encoding(VEX, 5 bytes) = c4 e2 68 f7 c0
0036h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0039h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
003dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003eh call 7FFDAD3DF4B0h            ; CALL(Call_rel32_64) [FFFFFFFFFFC1AEA0h:jmp64]        encoding(5 bytes) = e8 5d ae c1 ff
0043h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitrange_g8uBytes => new byte[68]{0x48,0x83,0xEC,0x28,0x90,0x89,0x4C,0x24,0x30,0x0F,0xB6,0x44,0x24,0x30,0x0F,0xB6,0xCA,0x41,0x2B,0xD0,0x85,0xD2,0x7D,0x06,0xF7,0xDA,0x85,0xD2,0x7C,0x20,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xC9,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0x68,0xF7,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x5D,0xAE,0xC1,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short bitrange_d16i(short src, BitPos i0, BitPos i1)
; location: [7FFDAD7C4670h, 7FFDAD7C46B5h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
000bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000dh jge short 0015h               ; JGE(Jge_rel8_64) [15h:jmp64]                         encoding(2 bytes) = 7d 06
000fh neg edx                       ; NEG(Neg_rm32) [EDX]                                  encoding(2 bytes) = f7 da
0011h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0013h jl short 0040h                ; JL(Jl_rel8_64) [40h:jmp64]                           encoding(2 bytes) = 7c 2b
0015h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0017h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0023h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0025h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0028h movsx rdx,cx                  ; MOVSX(Movsx_r64_rm16) [RDX,CX]                       encoding(4 bytes) = 48 0f bf d1
002ch movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002fh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0034h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0037h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
003bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
003fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0040h call 7FFDAD3DF4B0h            ; CALL(Call_rel32_64) [FFFFFFFFFFC1AE40h:jmp64]        encoding(5 bytes) = e8 fb ad c1 ff
0045h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitrange_d16iBytes => new byte[70]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0x41,0x2B,0xD0,0x85,0xD2,0x7D,0x06,0xF7,0xDA,0x85,0xD2,0x7C,0x2B,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBF,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBF,0xC0,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xFB,0xAD,0xC1,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short bitrange_g16i(short src, BitPos i0, BitPos i1)
; location: [7FFDAD7C46D0h, 7FFDAD7C471Bh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov [rsp+30h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 30
0009h movsx rax,word ptr [rsp+30h]  ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RSP:br,SS:sr)]    encoding(6 bytes) = 48 0f bf 44 24 30
000fh movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
0012h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
0015h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0017h jge short 001fh               ; JGE(Jge_rel8_64) [1Fh:jmp64]                         encoding(2 bytes) = 7d 06
0019h neg edx                       ; NEG(Neg_rm32) [EDX]                                  encoding(2 bytes) = f7 da
001bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
001dh jl short 0046h                ; JL(Jl_rel8_64) [46h:jmp64]                           encoding(2 bytes) = 7c 27
001fh inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0021h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
0024h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0027h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
002ah shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
002dh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
002fh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0032h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0035h bextr eax,eax,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EAX,EDX]          encoding(VEX, 5 bytes) = c4 e2 68 f7 c0
003ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
003dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0041h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0046h call 7FFDAD3DF4B0h            ; CALL(Call_rel32_64) [FFFFFFFFFFC1ADE0h:jmp64]        encoding(5 bytes) = e8 95 ad c1 ff
004bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitrange_g16iBytes => new byte[76]{0x48,0x83,0xEC,0x28,0x90,0x89,0x4C,0x24,0x30,0x48,0x0F,0xBF,0x44,0x24,0x30,0x0F,0xB6,0xCA,0x41,0x2B,0xD0,0x85,0xD2,0x7D,0x06,0xF7,0xDA,0x85,0xD2,0x7C,0x27,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xC9,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xD1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0xC4,0xE2,0x68,0xF7,0xC0,0x0F,0xB7,0xC0,0x48,0x0F,0xBF,0xC0,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x95,0xAD,0xC1,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort bitrange_d16u(ushort src, BitPos i0, BitPos i1)
; location: [7FFDAD7C4730h, 7FFDAD7C476Dh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
000bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000dh jge short 0015h               ; JGE(Jge_rel8_64) [15h:jmp64]                         encoding(2 bytes) = 7d 06
000fh neg edx                       ; NEG(Neg_rm32) [EDX]                                  encoding(2 bytes) = f7 da
0011h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0013h jl short 0038h                ; JL(Jl_rel8_64) [38h:jmp64]                           encoding(2 bytes) = 7c 23
0015h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0017h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0023h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0025h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0028h movzx edx,cx                  ; MOVZX(Movzx_r32_rm16) [EDX,CX]                       encoding(3 bytes) = 0f b7 d1
002bh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0030h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0033h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0037h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0038h call 7FFDAD3DF4B0h            ; CALL(Call_rel32_64) [FFFFFFFFFFC1AD80h:jmp64]        encoding(5 bytes) = e8 43 ad c1 ff
003dh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitrange_d16uBytes => new byte[62]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0x41,0x2B,0xD0,0x85,0xD2,0x7D,0x06,0xF7,0xDA,0x85,0xD2,0x7C,0x23,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB7,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB7,0xC0,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x43,0xAD,0xC1,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort bitrange_g16u(ushort src, BitPos i0, BitPos i1)
; location: [7FFDAD7C4790h, 7FFDAD7C47D3h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov [rsp+30h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 30
0009h movzx eax,word ptr [rsp+30h]  ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RSP:br,SS:sr)]    encoding(5 bytes) = 0f b7 44 24 30
000eh movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
0011h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
0014h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0016h jge short 001eh               ; JGE(Jge_rel8_64) [1Eh:jmp64]                         encoding(2 bytes) = 7d 06
0018h neg edx                       ; NEG(Neg_rm32) [EDX]                                  encoding(2 bytes) = f7 da
001ah test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
001ch jl short 003eh                ; JL(Jl_rel8_64) [3Eh:jmp64]                           encoding(2 bytes) = 7c 20
001eh inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0020h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
0023h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0026h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0029h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
002ch or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
002eh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0031h bextr eax,eax,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EAX,EDX]          encoding(VEX, 5 bytes) = c4 e2 68 f7 c0
0036h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0039h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
003dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003eh call 7FFDAD3DF4B0h            ; CALL(Call_rel32_64) [FFFFFFFFFFC1AD20h:jmp64]        encoding(5 bytes) = e8 dd ac c1 ff
0043h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitrange_g16uBytes => new byte[68]{0x48,0x83,0xEC,0x28,0x90,0x89,0x4C,0x24,0x30,0x0F,0xB7,0x44,0x24,0x30,0x0F,0xB6,0xCA,0x41,0x2B,0xD0,0x85,0xD2,0x7D,0x06,0xF7,0xDA,0x85,0xD2,0x7C,0x20,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xC9,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0x68,0xF7,0xC0,0x0F,0xB7,0xC0,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xDD,0xAC,0xC1,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int bitrange_d32i(int src, BitPos i0, BitPos i1)
; location: [7FFDAD7C47F0h, 7FFDAD7C4827h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
000bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000dh jge short 0015h               ; JGE(Jge_rel8_64) [15h:jmp64]                         encoding(2 bytes) = 7d 06
000fh neg edx                       ; NEG(Neg_rm32) [EDX]                                  encoding(2 bytes) = f7 da
0011h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0013h jl short 0032h                ; JL(Jl_rel8_64) [32h:jmp64]                           encoding(2 bytes) = 7c 1d
0015h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0017h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0023h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0025h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0028h bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
002dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0031h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0032h call 7FFDAD3DF4B0h            ; CALL(Call_rel32_64) [FFFFFFFFFFC1ACC0h:jmp64]        encoding(5 bytes) = e8 89 ac c1 ff
0037h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitrange_d32iBytes => new byte[56]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0x41,0x2B,0xD0,0x85,0xD2,0x7D,0x06,0xF7,0xDA,0x85,0xD2,0x7C,0x1D,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x89,0xAC,0xC1,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int bitrange_g32i(int src, BitPos i0, BitPos i1)
; location: [7FFDAD7C4840h, 7FFDAD7C4877h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
000bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000dh jge short 0015h               ; JGE(Jge_rel8_64) [15h:jmp64]                         encoding(2 bytes) = 7d 06
000fh neg edx                       ; NEG(Neg_rm32) [EDX]                                  encoding(2 bytes) = f7 da
0011h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0013h jl short 0032h                ; JL(Jl_rel8_64) [32h:jmp64]                           encoding(2 bytes) = 7c 1d
0015h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0017h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0023h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0025h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0028h bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
002dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0031h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0032h call 7FFDAD3DF4B0h            ; CALL(Call_rel32_64) [FFFFFFFFFFC1AC70h:jmp64]        encoding(5 bytes) = e8 39 ac c1 ff
0037h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitrange_g32iBytes => new byte[56]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0x41,0x2B,0xD0,0x85,0xD2,0x7D,0x06,0xF7,0xDA,0x85,0xD2,0x7C,0x1D,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x39,0xAC,0xC1,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint bitrange_d32u(uint src, BitPos i0, BitPos i1)
; location: [7FFDAD7C4890h, 7FFDAD7C48C7h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
000bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000dh jge short 0015h               ; JGE(Jge_rel8_64) [15h:jmp64]                         encoding(2 bytes) = 7d 06
000fh neg edx                       ; NEG(Neg_rm32) [EDX]                                  encoding(2 bytes) = f7 da
0011h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0013h jl short 0032h                ; JL(Jl_rel8_64) [32h:jmp64]                           encoding(2 bytes) = 7c 1d
0015h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0017h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0023h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0025h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0028h bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
002dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0031h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0032h call 7FFDAD3DF4B0h            ; CALL(Call_rel32_64) [FFFFFFFFFFC1AC20h:jmp64]        encoding(5 bytes) = e8 e9 ab c1 ff
0037h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitrange_d32uBytes => new byte[56]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0x41,0x2B,0xD0,0x85,0xD2,0x7D,0x06,0xF7,0xDA,0x85,0xD2,0x7C,0x1D,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xE9,0xAB,0xC1,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint bitrange_g32u(uint src, BitPos i0, BitPos i1)
; location: [7FFDAD7C48E0h, 7FFDAD7C4917h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
000bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000dh jge short 0015h               ; JGE(Jge_rel8_64) [15h:jmp64]                         encoding(2 bytes) = 7d 06
000fh neg edx                       ; NEG(Neg_rm32) [EDX]                                  encoding(2 bytes) = f7 da
0011h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0013h jl short 0032h                ; JL(Jl_rel8_64) [32h:jmp64]                           encoding(2 bytes) = 7c 1d
0015h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0017h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0023h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0025h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0028h bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
002dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0031h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0032h call 7FFDAD3DF4B0h            ; CALL(Call_rel32_64) [FFFFFFFFFFC1ABD0h:jmp64]        encoding(5 bytes) = e8 99 ab c1 ff
0037h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitrange_g32uBytes => new byte[56]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0x41,0x2B,0xD0,0x85,0xD2,0x7D,0x06,0xF7,0xDA,0x85,0xD2,0x7C,0x1D,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x99,0xAB,0xC1,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long bitrange_d64i(long src, BitPos i0, BitPos i1)
; location: [7FFDAD7C4930h, 7FFDAD7C4967h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
000bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000dh jge short 0015h               ; JGE(Jge_rel8_64) [15h:jmp64]                         encoding(2 bytes) = 7d 06
000fh neg edx                       ; NEG(Neg_rm32) [EDX]                                  encoding(2 bytes) = f7 da
0011h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0013h jl short 0032h                ; JL(Jl_rel8_64) [32h:jmp64]                           encoding(2 bytes) = 7c 1d
0015h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0017h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0023h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0025h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0028h bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
002dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0031h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0032h call 7FFDAD3DF4B0h            ; CALL(Call_rel32_64) [FFFFFFFFFFC1AB80h:jmp64]        encoding(5 bytes) = e8 49 ab c1 ff
0037h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitrange_d64iBytes => new byte[56]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0x41,0x2B,0xD0,0x85,0xD2,0x7D,0x06,0xF7,0xDA,0x85,0xD2,0x7C,0x1D,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x49,0xAB,0xC1,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long bitrange_g64i(long src, BitPos i0, BitPos i1)
; location: [7FFDAD7C4980h, 7FFDAD7C49B7h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
000bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000dh jge short 0015h               ; JGE(Jge_rel8_64) [15h:jmp64]                         encoding(2 bytes) = 7d 06
000fh neg edx                       ; NEG(Neg_rm32) [EDX]                                  encoding(2 bytes) = f7 da
0011h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0013h jl short 0032h                ; JL(Jl_rel8_64) [32h:jmp64]                           encoding(2 bytes) = 7c 1d
0015h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0017h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0023h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0025h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0028h bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
002dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0031h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0032h call 7FFDAD3DF4B0h            ; CALL(Call_rel32_64) [FFFFFFFFFFC1AB30h:jmp64]        encoding(5 bytes) = e8 f9 aa c1 ff
0037h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitrange_g64iBytes => new byte[56]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0x41,0x2B,0xD0,0x85,0xD2,0x7D,0x06,0xF7,0xDA,0x85,0xD2,0x7C,0x1D,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xF9,0xAA,0xC1,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong bitrange_d64u(ulong src, BitPos i0, BitPos i1)
; location: [7FFDAD7C49D0h, 7FFDAD7C4A07h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
000bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000dh jge short 0015h               ; JGE(Jge_rel8_64) [15h:jmp64]                         encoding(2 bytes) = 7d 06
000fh neg edx                       ; NEG(Neg_rm32) [EDX]                                  encoding(2 bytes) = f7 da
0011h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0013h jl short 0032h                ; JL(Jl_rel8_64) [32h:jmp64]                           encoding(2 bytes) = 7c 1d
0015h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0017h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0023h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0025h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0028h bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
002dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0031h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0032h call 7FFDAD3DF4B0h            ; CALL(Call_rel32_64) [FFFFFFFFFFC1AAE0h:jmp64]        encoding(5 bytes) = e8 a9 aa c1 ff
0037h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitrange_d64uBytes => new byte[56]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0x41,0x2B,0xD0,0x85,0xD2,0x7D,0x06,0xF7,0xDA,0x85,0xD2,0x7C,0x1D,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xA9,0xAA,0xC1,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong bitrange_g64u(ulong src, BitPos i0, BitPos i1)
; location: [7FFDAD7C4A20h, 7FFDAD7C4A57h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
000bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000dh jge short 0015h               ; JGE(Jge_rel8_64) [15h:jmp64]                         encoding(2 bytes) = 7d 06
000fh neg edx                       ; NEG(Neg_rm32) [EDX]                                  encoding(2 bytes) = f7 da
0011h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0013h jl short 0032h                ; JL(Jl_rel8_64) [32h:jmp64]                           encoding(2 bytes) = 7c 1d
0015h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0017h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0023h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0025h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0028h bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
002dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0031h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0032h call 7FFDAD3DF4B0h            ; CALL(Call_rel32_64) [FFFFFFFFFFC1AA90h:jmp64]        encoding(5 bytes) = e8 59 aa c1 ff
0037h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitrange_g64uBytes => new byte[56]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0x41,0x2B,0xD0,0x85,0xD2,0x7D,0x06,0xF7,0xDA,0x85,0xD2,0x7C,0x1D,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x59,0xAA,0xC1,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float bitrange_g32f(float src, BitPos i0, BitPos i1)
; location: [7FFDAD7C4A70h, 7FFDAD7C4ABDh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovss dword ptr [rsp+24h],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 24
000dh mov eax,[rsp+24h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 24
0011h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
0014h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
0017h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0019h jge short 0021h               ; JGE(Jge_rel8_64) [21h:jmp64]                         encoding(2 bytes) = 7d 06
001bh neg edx                       ; NEG(Neg_rm32) [EDX]                                  encoding(2 bytes) = f7 da
001dh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
001fh jl short 0048h                ; JL(Jl_rel8_64) [48h:jmp64]                           encoding(2 bytes) = 7c 27
0021h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0023h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
0026h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0029h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
002ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
002fh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0031h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0034h bextr eax,eax,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EAX,EDX]          encoding(VEX, 5 bytes) = c4 e2 68 f7 c0
0039h mov [rsp+20h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 20
003dh vmovss xmm0,dword ptr [rsp+20h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 20
0043h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0047h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0048h call 7FFDAD3DF4B0h            ; CALL(Call_rel32_64) [FFFFFFFFFFC1AA40h:jmp64]        encoding(5 bytes) = e8 f3 a9 c1 ff
004dh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitrange_g32fBytes => new byte[78]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xFA,0x11,0x44,0x24,0x24,0x8B,0x44,0x24,0x24,0x0F,0xB6,0xCA,0x41,0x2B,0xD0,0x85,0xD2,0x7D,0x06,0xF7,0xDA,0x85,0xD2,0x7C,0x27,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xC9,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0x68,0xF7,0xC0,0x89,0x44,0x24,0x20,0xC5,0xFA,0x10,0x44,0x24,0x20,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xF3,0xA9,0xC1,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double bitrange_g64f(double src, BitPos i0, BitPos i1)
; location: [7FFDAD7C4AE0h, 7FFDAD7C4B2Fh]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+30h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 30
000dh mov rax,[rsp+30h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 30
0012h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
0015h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
0018h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
001ah jge short 0022h               ; JGE(Jge_rel8_64) [22h:jmp64]                         encoding(2 bytes) = 7d 06
001ch neg edx                       ; NEG(Neg_rm32) [EDX]                                  encoding(2 bytes) = f7 da
001eh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0020h jl short 004ah                ; JL(Jl_rel8_64) [4Ah:jmp64]                           encoding(2 bytes) = 7c 28
0022h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0024h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
0027h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
002ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
002dh shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0030h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0032h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0035h bextr rax,rax,rdx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RAX,RDX]          encoding(VEX, 5 bytes) = c4 e2 e8 f7 c0
003ah mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
003fh vmovsd xmm0,qword ptr [rsp+28h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 28
0045h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
0049h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
004ah call 7FFDAD3DF4B0h            ; CALL(Call_rel32_64) [FFFFFFFFFFC1A9D0h:jmp64]        encoding(5 bytes) = e8 81 a9 c1 ff
004fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> bitrange_g64fBytes => new byte[80]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x30,0x48,0x8B,0x44,0x24,0x30,0x0F,0xB6,0xCA,0x41,0x2B,0xD0,0x85,0xD2,0x7D,0x06,0xF7,0xDA,0x85,0xD2,0x7C,0x28,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xC9,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0xE8,0xF7,0xC0,0x48,0x89,0x44,0x24,0x28,0xC5,0xFB,0x10,0x44,0x24,0x28,0x48,0x83,0xC4,0x38,0xC3,0xE8,0x81,0xA9,0xC1,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
