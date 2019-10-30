; 2019-10-30 14:10:38:890
; function: BitVector32 and_bv_32u(BitVector32 x, BitVector32 y)
; location: [7FFDD0497C20h, 7FFDD0497C29h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_bv_32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 and_bv_o32u(BitVector32 x, BitVector32 y)
; location: [7FFDD0497C40h, 7FFDD0497C49h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_bv_o32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 or_bv_32u(BitVector32 x, BitVector32 y)
; location: [7FFE28CFD1D0h, 7FFE28CFD1E0h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h call qword ptr [7FFE2891F6C8h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,DS:sr)]      encoding(6 bytes) = ff 15 ed 24 c2 ff
000bh nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000ch add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_bv_32uBytes => new byte[17]{0x48,0x83,0xEC,0x28,0x90,0xFF,0x15,0xED,0x24,0xC2,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 or_bv_o32u(BitVector32 x, BitVector32 y)
; location: [7FFDD0497C80h, 7FFDD0497C89h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_bv_o32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 xor_bv_32u(BitVector32 x, BitVector32 y)
; location: [7FFDD0497CA0h, 7FFDD0497CA9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_bv_32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 xor_bv_o32u(BitVector32 x, BitVector32 y)
; location: [7FFDD0497CC0h, 7FFDD0497CC9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_bv_o32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 sll_bv_32u(BitVector32 x, int offset)
; location: [7FFDD0497CE0h, 7FFDD0497CEBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sll_bv_32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 sll_bv_o32u(BitVector32 x, int offset)
; location: [7FFDD0497D00h, 7FFDD0497D0Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sll_bv_o32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 srl_bv_32u(BitVector32 x, int offset)
; location: [7FFDD0497D20h, 7FFDD0497D2Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_bv_32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 srl_bv_o32u(BitVector32 x, int offset)
; location: [7FFDD0497D40h, 7FFDD0497D4Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_bv_o32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 flip_bv_32u(BitVector32 x)
; location: [7FFDD0497D60h, 7FFDD0497D69h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_bv_32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 flip_bv_o32u(BitVector32 x)
; location: [7FFDD0497D80h, 7FFDD0497D89h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flip_bv_o32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 negate_bv_32u(BitVector32 x)
; location: [7FFDD0497DA0h, 7FFDD0497DABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_bv_32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 negate_bv_o32u(BitVector32 x)
; location: [7FFDD0497DC0h, 7FFDD0497DCBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_bv_o32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 inc_bv_32u(BitVector32 x)
; location: [7FFDD0497DE0h, 7FFDD0497DE8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 01
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_bv_32uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 inc_bv_o32u(BitVector32 x)
; location: [7FFDD0497E00h, 7FFDD0497E08h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 01
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_bv_o32uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 dec_bv_32u(BitVector32 x)
; location: [7FFDD0497E20h, 7FFDD0497E28h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx-1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 ff
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_bv_32uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 dec_bv_o32u(BitVector32 x)
; location: [7FFDD0497E40h, 7FFDD0497E48h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx-1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 ff
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dec_bv_o32uBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 rotl_bv_32u(BitVector32 x, int offset)
; location: [7FFDD0497E60h, 7FFDD0497E6Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h rol eax,cl                    ; ROL(Rol_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotl_bv_32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 rotr_bv_32u(BitVector32 x, int offset)
; location: [7FFDD0497E80h, 7FFDD0497E8Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h ror eax,cl                    ; ROR(Ror_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotr_bv_32uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte bitmap_d8i_to_8i(in sbyte src, byte srcOffset, byte len, byte dstOffset, ref sbyte dst)
; location: [7FFDD0497EA0h, 7FFDD0497EE1h]
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
; location: [7FFDD0498150h, 7FFDD0498191h]
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
; location: [7FFDD04981B0h, 7FFDD04981EFh]
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
; location: [7FFDD0498200h, 7FFDD049823Fh]
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
; location: [7FFDD0498250h, 7FFDD0498293h]
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
; location: [7FFDD04986B0h, 7FFDD04986F3h]
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
; location: [7FFDD0498710h, 7FFDD0498751h]
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
; location: [7FFDD0498770h, 7FFDD04987B1h]
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
; location: [7FFDD04987D0h, 7FFDD0498802h]
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
; location: [7FFDD0498820h, 7FFDD0498852h]
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
; location: [7FFDD0498870h, 7FFDD04988A2h]
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
; location: [7FFDD04988C0h, 7FFDD04988F2h]
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
; location: [7FFDD0498910h, 7FFDD0498946h]
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
; location: [7FFDD0498960h, 7FFDD0498996h]
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
; location: [7FFDD04989B0h, 7FFDD04989E6h]
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
; location: [7FFDD0498A00h, 7FFDD0498A36h]
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
; location: [7FFDD0498A50h, 7FFDD0498AB8h]
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
; location: [7FFDD0498AE0h, 7FFDD0498B48h]
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
; location: [7FFDD0498B70h, 7FFDD0498BDEh]
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
; location: [7FFDD0498C00h, 7FFDD0498C6Eh]
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
; location: [7FFDD0498C90h, 7FFDD0498CA0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h blsmsk eax,eax                ; BLSMSK(VEX_Blsmsk_r32_rm32) [EAX,EAX]                encoding(VEX, 5 bytes) = c4 e2 78 f3 d0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmsk_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x78,0xF3,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte blsmsk_g8u(byte src)
; location: [7FFDD04990C0h, 7FFDD04990D0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h blsmsk eax,eax                ; BLSMSK(VEX_Blsmsk_r32_rm32) [EAX,EAX]                encoding(VEX, 5 bytes) = c4 e2 78 f3 d0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmsk_g8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x78,0xF3,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort blsmsk_d16u(ushort src)
; location: [7FFDD04990F0h, 7FFDD0499100h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h blsmsk eax,eax                ; BLSMSK(VEX_Blsmsk_r32_rm32) [EAX,EAX]                encoding(VEX, 5 bytes) = c4 e2 78 f3 d0
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmsk_d16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC4,0xE2,0x78,0xF3,0xD0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort blsmsk_g16u(ushort src)
; location: [7FFDD0499120h, 7FFDD0499130h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h blsmsk eax,eax                ; BLSMSK(VEX_Blsmsk_r32_rm32) [EAX,EAX]                encoding(VEX, 5 bytes) = c4 e2 78 f3 d0
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmsk_g16uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC4,0xE2,0x78,0xF3,0xD0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint blsmsk_d32u(uint src)
; location: [7FFDD0499150h, 7FFDD049915Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsmsk eax,ecx                ; BLSMSK(VEX_Blsmsk_r32_rm32) [EAX,ECX]                encoding(VEX, 5 bytes) = c4 e2 78 f3 d1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmsk_d32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x78,0xF3,0xD1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint blsmsk_g32u(uint src)
; location: [7FFDD0499170h, 7FFDD049917Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsmsk eax,ecx                ; BLSMSK(VEX_Blsmsk_r32_rm32) [EAX,ECX]                encoding(VEX, 5 bytes) = c4 e2 78 f3 d1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmsk_g32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x78,0xF3,0xD1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong blsmsk_g64u(ulong src)
; location: [7FFDD0499190h, 7FFDD049919Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsmsk rax,rcx                ; BLSMSK(VEX_Blsmsk_r64_rm64) [RAX,RCX]                encoding(VEX, 5 bytes) = c4 e2 f8 f3 d1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmsk_g64uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF8,0xF3,0xD1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong blsmsk_d64u(ulong src)
; location: [7FFDD04991B0h, 7FFDD04991BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsmsk rax,rcx                ; BLSMSK(VEX_Blsmsk_r64_rm64) [RAX,RCX]                encoding(VEX, 5 bytes) = c4 e2 f8 f3 d1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmsk_d64uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF8,0xF3,0xD1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte bzhi_d8u(byte src, uint index)
; location: [7FFDD04991D0h, 7FFDD04991E0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h bzhi eax,eax,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhi_d8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x68,0xF5,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte bzhi_g8u(byte src, uint index)
; location: [7FFDD0499200h, 7FFDD0499210h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h bzhi eax,eax,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhi_g8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x68,0xF5,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte bzhi_g8u_ref(ref byte src, uint index)
; location: [7FFDD0499230h, 7FFDD0499242h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h bzhi eax,eax,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c0
000dh mov [rcx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 88 01
000fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhi_g8u_refBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0xC4,0xE2,0x68,0xF5,0xC0,0x88,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort bzhi_d16u(ushort src, ushort index)
; location: [7FFDD0499260h, 7FFDD0499273h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h movzx edx,cx                  ; MOVZX(Movzx_r32_rm16) [EDX,CX]                       encoding(3 bytes) = 0f b7 d1
000bh bzhi eax,edx,eax              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,EDX,EAX]            encoding(VEX, 5 bytes) = c4 e2 78 f5 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhi_d16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0x0F,0xB7,0xD1,0xC4,0xE2,0x78,0xF5,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort bzhi_g16u(ushort src, ushort index)
; location: [7FFDD0499290h, 7FFDD04992A3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh bzhi eax,eax,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c0
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhi_g16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC4,0xE2,0x68,0xF5,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort bzhi_g16u_ref(ref ushort src, ushort index)
; location: [7FFDD04992C0h, 7FFDD04992D6h]
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
; location: [7FFDD04992F0h, 7FFDD04992FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bzhi eax,ecx,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhi_d32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x68,0xF5,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint bzhi_g32u(uint src, uint index)
; location: [7FFDD0499310h, 7FFDD049931Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bzhi eax,ecx,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhi_g32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x68,0xF5,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint bzhi_g32u_ref(ref uint src, uint index)
; location: [7FFDD0499330h, 7FFDD049933Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bzhi eax,[rcx],edx            ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,mem(32u,RCX:br,DS:sr),EDX] encoding(VEX, 5 bytes) = c4 e2 68 f5 01
000ah mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
000ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhi_g32u_refBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x68,0xF5,0x01,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong bzhi_d64u(ulong src, uint index)
; location: [7FFDD0499350h, 7FFDD049935Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h bzhi rax,rcx,rax              ; BZHI(VEX_Bzhi_r64_rm64_r64) [RAX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f8 f5 c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhi_d64uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xC4,0xE2,0xF8,0xF5,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong bzhi_g64u(ulong src, uint index)
; location: [7FFDD0499370h, 7FFDD049937Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h bzhi rax,rcx,rax              ; BZHI(VEX_Bzhi_r64_rm64_r64) [RAX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f8 f5 c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhi_g64uBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xC4,0xE2,0xF8,0xF5,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong bzhi_g64u_ref(ref ulong src, uint index)
; location: [7FFDD0499390h, 7FFDD04993A2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h bzhi rax,[rcx],rax            ; BZHI(VEX_Bzhi_r64_rm64_r64) [RAX,mem(64u,RCX:br,DS:sr),RAX] encoding(VEX, 5 bytes) = c4 e2 f8 f5 01
000ch mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
000fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhi_g64u_refBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xC4,0xE2,0xF8,0xF5,0x01,0x48,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte gather_d8u(byte src, byte mask)
; location: [7FFDD04993C0h, 7FFDD04993D3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gather_d8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte gather_g8u(byte src, byte mask)
; location: [7FFDD04993F0h, 7FFDD049940Fh]
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
; location: [7FFDD0499420h, 7FFDD0499433h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gather_d16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort gather_g16u(ushort src, ushort mask)
; location: [7FFDD0499450h, 7FFDD049946Fh]
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
; location: [7FFDD0499480h, 7FFDD049948Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gather_d32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint gather_g32u(uint src, uint mask)
; location: [7FFDD04994A0h, 7FFDD04994AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gather_g32uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong gather_d64u(ulong src, ulong mask)
; location: [7FFDD04994C0h, 7FFDD04994CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gather_d64uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong gather_g64u(ulong src, ulong mask)
; location: [7FFDD04994E0h, 7FFDD04994EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gather_g64uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mask_1x64u(ulong dst, int exp0)
; location: [7FFDD0499500h, 7FFDD0499516h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h or rax,r8                     ; OR(Or_r64_rm64) [RAX,R8]                             encoding(3 bytes) = 49 0b c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mask_1x64uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x49,0x0B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mask_2x64u(ulong dst, int exp0, int exp1)
; location: [7FFDD0499530h, 7FFDD0499568h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],rcx               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 08
000ah mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000fh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0011h shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
0014h or rax,[rsp+8]                ; OR(Or_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]          encoding(5 bytes) = 48 0b 44 24 08
0019h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 08
001eh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0023h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0026h shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
0029h or rax,[rsp+8]                ; OR(Or_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]          encoding(5 bytes) = 48 0b 44 24 08
002eh mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 08
0033h mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
0038h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mask_2x64uBytes => new byte[57]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x89,0x4C,0x24,0x08,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x48,0xD3,0xE0,0x48,0x0B,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x08,0xB8,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE0,0x48,0x0B,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mask_3x64u(ulong dst, int exp0, int exp1, int exp2)
; location: [7FFDD0499580h, 7FFDD04995CDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],rcx               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 08
000ah mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000fh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0011h shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
0014h or rax,[rsp+8]                ; OR(Or_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]          encoding(5 bytes) = 48 0b 44 24 08
0019h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 08
001eh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0023h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0026h shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
0029h or rax,[rsp+8]                ; OR(Or_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]          encoding(5 bytes) = 48 0b 44 24 08
002eh mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 08
0033h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0038h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
003bh shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
003eh or rax,[rsp+8]                ; OR(Or_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]          encoding(5 bytes) = 48 0b 44 24 08
0043h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 08
0048h mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
004dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mask_3x64uBytes => new byte[78]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x89,0x4C,0x24,0x08,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x48,0xD3,0xE0,0x48,0x0B,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x08,0xB8,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE0,0x48,0x0B,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x08,0xB8,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x48,0xD3,0xE0,0x48,0x0B,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mask_4x64u(ulong dst, int exp0, int exp1, int exp2, int exp3)
; location: [7FFDD04995E0h, 7FFDD0499643h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],rcx               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 08
000ah mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000fh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0011h shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
0014h or rax,[rsp+8]                ; OR(Or_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]          encoding(5 bytes) = 48 0b 44 24 08
0019h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 08
001eh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0023h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0026h shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
0029h or rax,[rsp+8]                ; OR(Or_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]          encoding(5 bytes) = 48 0b 44 24 08
002eh mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 08
0033h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0038h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
003bh shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
003eh or rax,[rsp+8]                ; OR(Or_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]          encoding(5 bytes) = 48 0b 44 24 08
0043h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 08
0048h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
004dh mov ecx,[rsp+28h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 28
0051h shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
0054h or rax,[rsp+8]                ; OR(Or_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]          encoding(5 bytes) = 48 0b 44 24 08
0059h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 08
005eh mov rax,[rsp+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 08
0063h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mask_4x64uBytes => new byte[100]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x89,0x4C,0x24,0x08,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x48,0xD3,0xE0,0x48,0x0B,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x08,0xB8,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE0,0x48,0x0B,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x08,0xB8,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x48,0xD3,0xE0,0x48,0x0B,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x08,0xB8,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x28,0x48,0xD3,0xE0,0x48,0x0B,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x08,0x48,0x8B,0x44,0x24,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mask_5x64u(ref ulong dst, int exp0, int exp1, int exp2, int exp3, int exp4)
; location: [7FFDD0499660h, 7FFDD04996B3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0013h or [rax],r10                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),R10]          encoding(3 bytes) = 4c 09 10
0016h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
001eh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0021h or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0024h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0029h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
002ch shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
002fh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0032h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0037h mov ecx,[rsp+28h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 28
003bh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
003eh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0041h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0046h mov ecx,[rsp+30h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 30
004ah shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
004dh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0050h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
0053h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mask_5x64uBytes => new byte[84]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xBA,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE2,0x4C,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x28,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x30,0x48,0xD3,0xE2,0x48,0x09,0x10,0x48,0x8B,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mask_6x64u(ref ulong dst, int exp0, int exp1, int exp2, int exp3, int exp4, int exp5)
; location: [7FFDD04996D0h, 7FFDD0499732h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0013h or [rax],r10                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),R10]          encoding(3 bytes) = 4c 09 10
0016h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
001eh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0021h or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0024h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0029h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
002ch shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
002fh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0032h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0037h mov ecx,[rsp+28h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 28
003bh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
003eh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0041h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0046h mov ecx,[rsp+30h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 30
004ah shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
004dh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0050h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0055h mov ecx,[rsp+38h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 38
0059h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
005ch or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
005fh mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
0062h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mask_6x64uBytes => new byte[99]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xBA,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE2,0x4C,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x28,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x30,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x38,0x48,0xD3,0xE2,0x48,0x09,0x10,0x48,0x8B,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mask_7x64u(ref ulong dst, int exp0, int exp1, int exp2, int exp3, int exp4, int exp5, int exp6)
; location: [7FFDD0499750h, 7FFDD04997C1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0013h or [rax],r10                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),R10]          encoding(3 bytes) = 4c 09 10
0016h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
001eh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0021h or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0024h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0029h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
002ch shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
002fh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0032h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0037h mov ecx,[rsp+28h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 28
003bh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
003eh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0041h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0046h mov ecx,[rsp+30h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 30
004ah shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
004dh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
0050h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0055h mov ecx,[rsp+38h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 38
0059h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
005ch or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
005fh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0064h mov ecx,[rsp+40h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 40
0068h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
006bh or [rax],rdx                  ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 10
006eh mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
0071h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mask_7x64uBytes => new byte[114]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xBA,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE2,0x4C,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x28,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x30,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x38,0x48,0xD3,0xE2,0x48,0x09,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x40,0x48,0xD3,0xE2,0x48,0x09,0x10,0x48,0x8B,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mask_8x64u(ref ulong dst, int exp0, int exp1, int exp2, int exp3, int exp4, int exp5, int exp6, int exp7)
; location: [7FFDD04997E0h, 7FFDD049985Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0013h or r10,[rax]                  ; OR(Or_r64_rm64) [R10,mem(64u,RAX:br,DS:sr)]          encoding(3 bytes) = 4c 0b 10
0016h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
001eh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0021h or rdx,r10                    ; OR(Or_r64_rm64) [RDX,R10]                            encoding(3 bytes) = 49 0b d2
0024h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
002ah mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
002dh shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0030h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0033h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
0039h mov ecx,[rsp+28h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 28
003dh shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0040h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0043h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
0049h mov ecx,[rsp+30h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 30
004dh shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0050h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0053h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
0059h mov ecx,[rsp+40h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 40
005dh shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0060h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0063h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0066h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
006ch mov ecx,[rsp+48h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 48
0070h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0073h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0076h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
0079h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
007ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mask_8x64uBytes => new byte[125]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xBA,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE2,0x4C,0x0B,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE2,0x49,0x0B,0xD2,0x41,0xB8,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x49,0xD3,0xE0,0x49,0x0B,0xD0,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x28,0x49,0xD3,0xE0,0x49,0x0B,0xD0,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x30,0x49,0xD3,0xE0,0x49,0x0B,0xD0,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x40,0x49,0xD3,0xE0,0x49,0x0B,0xD0,0x49,0x0B,0xD0,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x48,0x49,0xD3,0xE0,0x49,0x0B,0xD0,0x48,0x89,0x10,0x48,0x8B,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pack8(Span<bit> src)
; location: [7FFDD0499870h, 7FFDD04998FAh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe short 0085h               ; JBE(Jbe_rel8_64) [85h:jmp64]                         encoding(2 bytes) = 76 75
0010h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0012h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0015h jbe short 0085h               ; JBE(Jbe_rel8_64) [85h:jmp64]                         encoding(2 bytes) = 76 6e
0017h mov r8d,[rax+4]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 04
001bh shl r8d,1                     ; SHL(Shl_rm32_1) [R8D,1h:imm8]                        encoding(3 bytes) = 41 d1 e0
001eh or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0021h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
0024h jbe short 0085h               ; JBE(Jbe_rel8_64) [85h:jmp64]                         encoding(2 bytes) = 76 5f
0026h mov r8d,[rax+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 08
002ah shl r8d,2                     ; SHL(Shl_rm32_imm8) [R8D,2h:imm8]                     encoding(4 bytes) = 41 c1 e0 02
002eh or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0031h cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0034h jbe short 0085h               ; JBE(Jbe_rel8_64) [85h:jmp64]                         encoding(2 bytes) = 76 4f
0036h mov r8d,[rax+0Ch]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 0c
003ah shl r8d,3                     ; SHL(Shl_rm32_imm8) [R8D,3h:imm8]                     encoding(4 bytes) = 41 c1 e0 03
003eh or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0041h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
0044h jbe short 0085h               ; JBE(Jbe_rel8_64) [85h:jmp64]                         encoding(2 bytes) = 76 3f
0046h mov r8d,[rax+10h]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 10
004ah shl r8d,4                     ; SHL(Shl_rm32_imm8) [R8D,4h:imm8]                     encoding(4 bytes) = 41 c1 e0 04
004eh or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0051h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
0054h jbe short 0085h               ; JBE(Jbe_rel8_64) [85h:jmp64]                         encoding(2 bytes) = 76 2f
0056h mov r8d,[rax+14h]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 14
005ah shl r8d,5                     ; SHL(Shl_rm32_imm8) [R8D,5h:imm8]                     encoding(4 bytes) = 41 c1 e0 05
005eh or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0061h cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
0064h jbe short 0085h               ; JBE(Jbe_rel8_64) [85h:jmp64]                         encoding(2 bytes) = 76 1f
0066h mov r8d,[rax+18h]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 18
006ah shl r8d,6                     ; SHL(Shl_rm32_imm8) [R8D,6h:imm8]                     encoding(4 bytes) = 41 c1 e0 06
006eh or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0071h cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
0074h jbe short 0085h               ; JBE(Jbe_rel8_64) [85h:jmp64]                         encoding(2 bytes) = 76 0f
0076h mov eax,[rax+1Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 40 1c
0079h shl eax,7                     ; SHL(Shl_rm32_imm8) [EAX,7h:imm8]                     encoding(3 bytes) = c1 e0 07
007ch or ecx,eax                    ; OR(Or_r32_rm32) [ECX,EAX]                            encoding(2 bytes) = 0b c8
007eh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0080h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0084h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0085h call 7FFE2FA0EF00h            ; CALL(Call_rel32_64) [5F575690h:jmp64]                encoding(5 bytes) = e8 06 56 57 5f
008ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> pack8Bytes => new byte[139]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x8B,0x51,0x08,0x83,0xFA,0x00,0x76,0x75,0x8B,0x08,0x83,0xFA,0x01,0x76,0x6E,0x44,0x8B,0x40,0x04,0x41,0xD1,0xE0,0x41,0x0B,0xC8,0x83,0xFA,0x02,0x76,0x5F,0x44,0x8B,0x40,0x08,0x41,0xC1,0xE0,0x02,0x41,0x0B,0xC8,0x83,0xFA,0x03,0x76,0x4F,0x44,0x8B,0x40,0x0C,0x41,0xC1,0xE0,0x03,0x41,0x0B,0xC8,0x83,0xFA,0x04,0x76,0x3F,0x44,0x8B,0x40,0x10,0x41,0xC1,0xE0,0x04,0x41,0x0B,0xC8,0x83,0xFA,0x05,0x76,0x2F,0x44,0x8B,0x40,0x14,0x41,0xC1,0xE0,0x05,0x41,0x0B,0xC8,0x83,0xFA,0x06,0x76,0x1F,0x44,0x8B,0x40,0x18,0x41,0xC1,0xE0,0x06,0x41,0x0B,0xC8,0x83,0xFA,0x07,0x76,0x0F,0x8B,0x40,0x1C,0xC1,0xE0,0x07,0x0B,0xC8,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x06,0x56,0x57,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector<byte> pack8g(Span<bit> src)
; location: [7FFDD0499DE0h, 7FFDD0499E75h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe near ptr 0090h            ; JBE(Jbe_rel32_64) [90h:jmp64]                        encoding(6 bytes) = 0f 86 7c 00 00 00
0014h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0016h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0019h jbe short 0090h               ; JBE(Jbe_rel8_64) [90h:jmp64]                         encoding(2 bytes) = 76 75
001bh mov r8d,[rax+4]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 04
001fh shl r8d,1                     ; SHL(Shl_rm32_1) [R8D,1h:imm8]                        encoding(3 bytes) = 41 d1 e0
0022h or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0025h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
0028h jbe short 0090h               ; JBE(Jbe_rel8_64) [90h:jmp64]                         encoding(2 bytes) = 76 66
002ah mov r8d,[rax+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 08
002eh shl r8d,2                     ; SHL(Shl_rm32_imm8) [R8D,2h:imm8]                     encoding(4 bytes) = 41 c1 e0 02
0032h or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0035h cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0038h jbe short 0090h               ; JBE(Jbe_rel8_64) [90h:jmp64]                         encoding(2 bytes) = 76 56
003ah mov r8d,[rax+0Ch]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 0c
003eh shl r8d,3                     ; SHL(Shl_rm32_imm8) [R8D,3h:imm8]                     encoding(4 bytes) = 41 c1 e0 03
0042h or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0045h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
0048h jbe short 0090h               ; JBE(Jbe_rel8_64) [90h:jmp64]                         encoding(2 bytes) = 76 46
004ah mov r8d,[rax+10h]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 10
004eh shl r8d,4                     ; SHL(Shl_rm32_imm8) [R8D,4h:imm8]                     encoding(4 bytes) = 41 c1 e0 04
0052h or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0055h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
0058h jbe short 0090h               ; JBE(Jbe_rel8_64) [90h:jmp64]                         encoding(2 bytes) = 76 36
005ah mov r8d,[rax+14h]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 14
005eh shl r8d,5                     ; SHL(Shl_rm32_imm8) [R8D,5h:imm8]                     encoding(4 bytes) = 41 c1 e0 05
0062h or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0065h cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
0068h jbe short 0090h               ; JBE(Jbe_rel8_64) [90h:jmp64]                         encoding(2 bytes) = 76 26
006ah mov r8d,[rax+18h]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 18
006eh shl r8d,6                     ; SHL(Shl_rm32_imm8) [R8D,6h:imm8]                     encoding(4 bytes) = 41 c1 e0 06
0072h or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0075h cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
0078h jbe short 0090h               ; JBE(Jbe_rel8_64) [90h:jmp64]                         encoding(2 bytes) = 76 16
007ah mov eax,[rax+1Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 40 1c
007dh shl eax,7                     ; SHL(Shl_rm32_imm8) [EAX,7h:imm8]                     encoding(3 bytes) = c1 e0 07
0080h or ecx,eax                    ; OR(Or_r32_rm32) [ECX,EAX]                            encoding(2 bytes) = 0b c8
0082h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0084h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0087h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
008bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
008fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0090h call 7FFE2FA0EF00h            ; CALL(Call_rel32_64) [5F575120h:jmp64]                encoding(5 bytes) = e8 8b 50 57 5f
0095h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> pack8gBytes => new byte[150]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x8B,0x51,0x08,0x83,0xFA,0x00,0x0F,0x86,0x7C,0x00,0x00,0x00,0x8B,0x08,0x83,0xFA,0x01,0x76,0x75,0x44,0x8B,0x40,0x04,0x41,0xD1,0xE0,0x41,0x0B,0xC8,0x83,0xFA,0x02,0x76,0x66,0x44,0x8B,0x40,0x08,0x41,0xC1,0xE0,0x02,0x41,0x0B,0xC8,0x83,0xFA,0x03,0x76,0x56,0x44,0x8B,0x40,0x0C,0x41,0xC1,0xE0,0x03,0x41,0x0B,0xC8,0x83,0xFA,0x04,0x76,0x46,0x44,0x8B,0x40,0x10,0x41,0xC1,0xE0,0x04,0x41,0x0B,0xC8,0x83,0xFA,0x05,0x76,0x36,0x44,0x8B,0x40,0x14,0x41,0xC1,0xE0,0x05,0x41,0x0B,0xC8,0x83,0xFA,0x06,0x76,0x26,0x44,0x8B,0x40,0x18,0x41,0xC1,0xE0,0x06,0x41,0x0B,0xC8,0x83,0xFA,0x07,0x76,0x16,0x8B,0x40,0x1C,0xC1,0xE0,0x07,0x0B,0xC8,0x8B,0xC1,0x0F,0xB6,0xC0,0x48,0x0F,0xBE,0xC0,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x8B,0x50,0x57,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pack16(Span<bit> src)
; location: [7FFDD049A2A0h, 7FFDD049A3EBh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe near ptr 0146h            ; JBE(Jbe_rel32_64) [146h:jmp64]                       encoding(6 bytes) = 0f 86 32 01 00 00
0014h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0016h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0019h jbe near ptr 0146h            ; JBE(Jbe_rel32_64) [146h:jmp64]                       encoding(6 bytes) = 0f 86 27 01 00 00
001fh mov r8d,[rax+4]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 04
0023h shl r8d,1                     ; SHL(Shl_rm32_1) [R8D,1h:imm8]                        encoding(3 bytes) = 41 d1 e0
0026h or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0029h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
002ch jbe near ptr 0146h            ; JBE(Jbe_rel32_64) [146h:jmp64]                       encoding(6 bytes) = 0f 86 14 01 00 00
0032h mov r8d,[rax+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 08
0036h shl r8d,2                     ; SHL(Shl_rm32_imm8) [R8D,2h:imm8]                     encoding(4 bytes) = 41 c1 e0 02
003ah or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
003dh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0040h jbe near ptr 0146h            ; JBE(Jbe_rel32_64) [146h:jmp64]                       encoding(6 bytes) = 0f 86 00 01 00 00
0046h mov r8d,[rax+0Ch]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 0c
004ah shl r8d,3                     ; SHL(Shl_rm32_imm8) [R8D,3h:imm8]                     encoding(4 bytes) = 41 c1 e0 03
004eh or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0051h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
0054h jbe near ptr 0146h            ; JBE(Jbe_rel32_64) [146h:jmp64]                       encoding(6 bytes) = 0f 86 ec 00 00 00
005ah mov r8d,[rax+10h]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 10
005eh shl r8d,4                     ; SHL(Shl_rm32_imm8) [R8D,4h:imm8]                     encoding(4 bytes) = 41 c1 e0 04
0062h or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0065h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
0068h jbe near ptr 0146h            ; JBE(Jbe_rel32_64) [146h:jmp64]                       encoding(6 bytes) = 0f 86 d8 00 00 00
006eh mov r8d,[rax+14h]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 14
0072h shl r8d,5                     ; SHL(Shl_rm32_imm8) [R8D,5h:imm8]                     encoding(4 bytes) = 41 c1 e0 05
0076h or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0079h cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
007ch jbe near ptr 0146h            ; JBE(Jbe_rel32_64) [146h:jmp64]                       encoding(6 bytes) = 0f 86 c4 00 00 00
0082h mov r8d,[rax+18h]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 18
0086h shl r8d,6                     ; SHL(Shl_rm32_imm8) [R8D,6h:imm8]                     encoding(4 bytes) = 41 c1 e0 06
008ah or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
008dh cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
0090h jbe near ptr 0146h            ; JBE(Jbe_rel32_64) [146h:jmp64]                       encoding(6 bytes) = 0f 86 b0 00 00 00
0096h mov r8d,[rax+1Ch]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 1c
009ah shl r8d,7                     ; SHL(Shl_rm32_imm8) [R8D,7h:imm8]                     encoding(4 bytes) = 41 c1 e0 07
009eh or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
00a1h cmp edx,8                     ; CMP(Cmp_rm32_imm8) [EDX,8h:imm32]                    encoding(3 bytes) = 83 fa 08
00a4h jb near ptr 0140h             ; JB(Jb_rel32_64) [140h:jmp64]                         encoding(6 bytes) = 0f 82 96 00 00 00
00aah add edx,0FFFFFFF8h            ; ADD(Add_rm32_imm8) [EDX,fffffffffffffff8h:imm32]     encoding(3 bytes) = 83 c2 f8
00adh add rax,20h                   ; ADD(Add_rm64_imm8) [RAX,20h:imm64]                   encoding(4 bytes) = 48 83 c0 20
00b1h cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
00b4h jbe near ptr 0146h            ; JBE(Jbe_rel32_64) [146h:jmp64]                       encoding(6 bytes) = 0f 86 8c 00 00 00
00bah mov r8d,[rax]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 44 8b 00
00bdh cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
00c0h jbe near ptr 0146h            ; JBE(Jbe_rel32_64) [146h:jmp64]                       encoding(6 bytes) = 0f 86 80 00 00 00
00c6h mov r9d,[rax+4]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 04
00cah shl r9d,1                     ; SHL(Shl_rm32_1) [R9D,1h:imm8]                        encoding(3 bytes) = 41 d1 e1
00cdh or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
00d0h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
00d3h jbe short 0146h               ; JBE(Jbe_rel8_64) [146h:jmp64]                        encoding(2 bytes) = 76 71
00d5h mov r9d,[rax+8]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 08
00d9h shl r9d,2                     ; SHL(Shl_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e1 02
00ddh or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
00e0h cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
00e3h jbe short 0146h               ; JBE(Jbe_rel8_64) [146h:jmp64]                        encoding(2 bytes) = 76 61
00e5h mov r9d,[rax+0Ch]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 0c
00e9h shl r9d,3                     ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]                     encoding(4 bytes) = 41 c1 e1 03
00edh or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
00f0h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
00f3h jbe short 0146h               ; JBE(Jbe_rel8_64) [146h:jmp64]                        encoding(2 bytes) = 76 51
00f5h mov r9d,[rax+10h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 10
00f9h shl r9d,4                     ; SHL(Shl_rm32_imm8) [R9D,4h:imm8]                     encoding(4 bytes) = 41 c1 e1 04
00fdh or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
0100h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
0103h jbe short 0146h               ; JBE(Jbe_rel8_64) [146h:jmp64]                        encoding(2 bytes) = 76 41
0105h mov r9d,[rax+14h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 14
0109h shl r9d,5                     ; SHL(Shl_rm32_imm8) [R9D,5h:imm8]                     encoding(4 bytes) = 41 c1 e1 05
010dh or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
0110h cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
0113h jbe short 0146h               ; JBE(Jbe_rel8_64) [146h:jmp64]                        encoding(2 bytes) = 76 31
0115h mov r9d,[rax+18h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 18
0119h shl r9d,6                     ; SHL(Shl_rm32_imm8) [R9D,6h:imm8]                     encoding(4 bytes) = 41 c1 e1 06
011dh or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
0120h cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
0123h jbe short 0146h               ; JBE(Jbe_rel8_64) [146h:jmp64]                        encoding(2 bytes) = 76 21
0125h mov eax,[rax+1Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 40 1c
0128h shl eax,7                     ; SHL(Shl_rm32_imm8) [EAX,7h:imm8]                     encoding(3 bytes) = c1 e0 07
012bh or r8d,eax                    ; OR(Or_r32_rm32) [R8D,EAX]                            encoding(3 bytes) = 44 0b c0
012eh mov eax,r8d                   ; MOV(Mov_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 8b c0
0131h shl rax,8                     ; SHL(Shl_rm64_imm8) [RAX,8h:imm8]                     encoding(4 bytes) = 48 c1 e0 08
0135h or rcx,rax                    ; OR(Or_r64_rm64) [RCX,RAX]                            encoding(3 bytes) = 48 0b c8
0138h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
013bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
013fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0140h call 7FFDCFDE01D8h            ; CALL(Call_rel32_64) [FFFFFFFFFF945F38h:jmp64]        encoding(5 bytes) = e8 f3 5d 94 ff
0145h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0146h call 7FFE2FA0EF00h            ; CALL(Call_rel32_64) [5F574C60h:jmp64]                encoding(5 bytes) = e8 15 4b 57 5f
014bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> pack16Bytes => new byte[332]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x8B,0x51,0x08,0x83,0xFA,0x00,0x0F,0x86,0x32,0x01,0x00,0x00,0x8B,0x08,0x83,0xFA,0x01,0x0F,0x86,0x27,0x01,0x00,0x00,0x44,0x8B,0x40,0x04,0x41,0xD1,0xE0,0x41,0x0B,0xC8,0x83,0xFA,0x02,0x0F,0x86,0x14,0x01,0x00,0x00,0x44,0x8B,0x40,0x08,0x41,0xC1,0xE0,0x02,0x41,0x0B,0xC8,0x83,0xFA,0x03,0x0F,0x86,0x00,0x01,0x00,0x00,0x44,0x8B,0x40,0x0C,0x41,0xC1,0xE0,0x03,0x41,0x0B,0xC8,0x83,0xFA,0x04,0x0F,0x86,0xEC,0x00,0x00,0x00,0x44,0x8B,0x40,0x10,0x41,0xC1,0xE0,0x04,0x41,0x0B,0xC8,0x83,0xFA,0x05,0x0F,0x86,0xD8,0x00,0x00,0x00,0x44,0x8B,0x40,0x14,0x41,0xC1,0xE0,0x05,0x41,0x0B,0xC8,0x83,0xFA,0x06,0x0F,0x86,0xC4,0x00,0x00,0x00,0x44,0x8B,0x40,0x18,0x41,0xC1,0xE0,0x06,0x41,0x0B,0xC8,0x83,0xFA,0x07,0x0F,0x86,0xB0,0x00,0x00,0x00,0x44,0x8B,0x40,0x1C,0x41,0xC1,0xE0,0x07,0x41,0x0B,0xC8,0x83,0xFA,0x08,0x0F,0x82,0x96,0x00,0x00,0x00,0x83,0xC2,0xF8,0x48,0x83,0xC0,0x20,0x83,0xFA,0x00,0x0F,0x86,0x8C,0x00,0x00,0x00,0x44,0x8B,0x00,0x83,0xFA,0x01,0x0F,0x86,0x80,0x00,0x00,0x00,0x44,0x8B,0x48,0x04,0x41,0xD1,0xE1,0x45,0x0B,0xC1,0x83,0xFA,0x02,0x76,0x71,0x44,0x8B,0x48,0x08,0x41,0xC1,0xE1,0x02,0x45,0x0B,0xC1,0x83,0xFA,0x03,0x76,0x61,0x44,0x8B,0x48,0x0C,0x41,0xC1,0xE1,0x03,0x45,0x0B,0xC1,0x83,0xFA,0x04,0x76,0x51,0x44,0x8B,0x48,0x10,0x41,0xC1,0xE1,0x04,0x45,0x0B,0xC1,0x83,0xFA,0x05,0x76,0x41,0x44,0x8B,0x48,0x14,0x41,0xC1,0xE1,0x05,0x45,0x0B,0xC1,0x83,0xFA,0x06,0x76,0x31,0x44,0x8B,0x48,0x18,0x41,0xC1,0xE1,0x06,0x45,0x0B,0xC1,0x83,0xFA,0x07,0x76,0x21,0x8B,0x40,0x1C,0xC1,0xE0,0x07,0x44,0x0B,0xC0,0x41,0x8B,0xC0,0x48,0xC1,0xE0,0x08,0x48,0x0B,0xC8,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xF3,0x5D,0x94,0xFF,0xCC,0xE8,0x15,0x4B,0x57,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector<ushort> pack16g(Span<bit> src)
; location: [7FFDD049A400h, 7FFDD049A54Fh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
000eh jbe near ptr 014ah            ; JBE(Jbe_rel32_64) [14Ah:jmp64]                       encoding(6 bytes) = 0f 86 36 01 00 00
0014h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0016h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0019h jbe near ptr 014ah            ; JBE(Jbe_rel32_64) [14Ah:jmp64]                       encoding(6 bytes) = 0f 86 2b 01 00 00
001fh mov r8d,[rax+4]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 04
0023h shl r8d,1                     ; SHL(Shl_rm32_1) [R8D,1h:imm8]                        encoding(3 bytes) = 41 d1 e0
0026h or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0029h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
002ch jbe near ptr 014ah            ; JBE(Jbe_rel32_64) [14Ah:jmp64]                       encoding(6 bytes) = 0f 86 18 01 00 00
0032h mov r8d,[rax+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 08
0036h shl r8d,2                     ; SHL(Shl_rm32_imm8) [R8D,2h:imm8]                     encoding(4 bytes) = 41 c1 e0 02
003ah or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
003dh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0040h jbe near ptr 014ah            ; JBE(Jbe_rel32_64) [14Ah:jmp64]                       encoding(6 bytes) = 0f 86 04 01 00 00
0046h mov r8d,[rax+0Ch]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 0c
004ah shl r8d,3                     ; SHL(Shl_rm32_imm8) [R8D,3h:imm8]                     encoding(4 bytes) = 41 c1 e0 03
004eh or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0051h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
0054h jbe near ptr 014ah            ; JBE(Jbe_rel32_64) [14Ah:jmp64]                       encoding(6 bytes) = 0f 86 f0 00 00 00
005ah mov r8d,[rax+10h]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 10
005eh shl r8d,4                     ; SHL(Shl_rm32_imm8) [R8D,4h:imm8]                     encoding(4 bytes) = 41 c1 e0 04
0062h or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0065h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
0068h jbe near ptr 014ah            ; JBE(Jbe_rel32_64) [14Ah:jmp64]                       encoding(6 bytes) = 0f 86 dc 00 00 00
006eh mov r8d,[rax+14h]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 14
0072h shl r8d,5                     ; SHL(Shl_rm32_imm8) [R8D,5h:imm8]                     encoding(4 bytes) = 41 c1 e0 05
0076h or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
0079h cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
007ch jbe near ptr 014ah            ; JBE(Jbe_rel32_64) [14Ah:jmp64]                       encoding(6 bytes) = 0f 86 c8 00 00 00
0082h mov r8d,[rax+18h]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 18
0086h shl r8d,6                     ; SHL(Shl_rm32_imm8) [R8D,6h:imm8]                     encoding(4 bytes) = 41 c1 e0 06
008ah or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
008dh cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
0090h jbe near ptr 014ah            ; JBE(Jbe_rel32_64) [14Ah:jmp64]                       encoding(6 bytes) = 0f 86 b4 00 00 00
0096h mov r8d,[rax+1Ch]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 1c
009ah shl r8d,7                     ; SHL(Shl_rm32_imm8) [R8D,7h:imm8]                     encoding(4 bytes) = 41 c1 e0 07
009eh or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
00a1h cmp edx,8                     ; CMP(Cmp_rm32_imm8) [EDX,8h:imm32]                    encoding(3 bytes) = 83 fa 08
00a4h jb near ptr 0144h             ; JB(Jb_rel32_64) [144h:jmp64]                         encoding(6 bytes) = 0f 82 9a 00 00 00
00aah add edx,0FFFFFFF8h            ; ADD(Add_rm32_imm8) [EDX,fffffffffffffff8h:imm32]     encoding(3 bytes) = 83 c2 f8
00adh add rax,20h                   ; ADD(Add_rm64_imm8) [RAX,20h:imm64]                   encoding(4 bytes) = 48 83 c0 20
00b1h cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
00b4h jbe near ptr 014ah            ; JBE(Jbe_rel32_64) [14Ah:jmp64]                       encoding(6 bytes) = 0f 86 90 00 00 00
00bah mov r8d,[rax]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 44 8b 00
00bdh cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
00c0h jbe near ptr 014ah            ; JBE(Jbe_rel32_64) [14Ah:jmp64]                       encoding(6 bytes) = 0f 86 84 00 00 00
00c6h mov r9d,[rax+4]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 04
00cah shl r9d,1                     ; SHL(Shl_rm32_1) [R9D,1h:imm8]                        encoding(3 bytes) = 41 d1 e1
00cdh or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
00d0h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
00d3h jbe short 014ah               ; JBE(Jbe_rel8_64) [14Ah:jmp64]                        encoding(2 bytes) = 76 75
00d5h mov r9d,[rax+8]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 08
00d9h shl r9d,2                     ; SHL(Shl_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e1 02
00ddh or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
00e0h cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
00e3h jbe short 014ah               ; JBE(Jbe_rel8_64) [14Ah:jmp64]                        encoding(2 bytes) = 76 65
00e5h mov r9d,[rax+0Ch]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 0c
00e9h shl r9d,3                     ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]                     encoding(4 bytes) = 41 c1 e1 03
00edh or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
00f0h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
00f3h jbe short 014ah               ; JBE(Jbe_rel8_64) [14Ah:jmp64]                        encoding(2 bytes) = 76 55
00f5h mov r9d,[rax+10h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 10
00f9h shl r9d,4                     ; SHL(Shl_rm32_imm8) [R9D,4h:imm8]                     encoding(4 bytes) = 41 c1 e1 04
00fdh or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
0100h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
0103h jbe short 014ah               ; JBE(Jbe_rel8_64) [14Ah:jmp64]                        encoding(2 bytes) = 76 45
0105h mov r9d,[rax+14h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 14
0109h shl r9d,5                     ; SHL(Shl_rm32_imm8) [R9D,5h:imm8]                     encoding(4 bytes) = 41 c1 e1 05
010dh or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
0110h cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
0113h jbe short 014ah               ; JBE(Jbe_rel8_64) [14Ah:jmp64]                        encoding(2 bytes) = 76 35
0115h mov r9d,[rax+18h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 18
0119h shl r9d,6                     ; SHL(Shl_rm32_imm8) [R9D,6h:imm8]                     encoding(4 bytes) = 41 c1 e1 06
011dh or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
0120h cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
0123h jbe short 014ah               ; JBE(Jbe_rel8_64) [14Ah:jmp64]                        encoding(2 bytes) = 76 25
0125h mov eax,[rax+1Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 40 1c
0128h shl eax,7                     ; SHL(Shl_rm32_imm8) [EAX,7h:imm8]                     encoding(3 bytes) = c1 e0 07
012bh or r8d,eax                    ; OR(Or_r32_rm32) [R8D,EAX]                            encoding(3 bytes) = 44 0b c0
012eh mov eax,r8d                   ; MOV(Mov_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 8b c0
0131h shl rax,8                     ; SHL(Shl_rm64_imm8) [RAX,8h:imm8]                     encoding(4 bytes) = 48 c1 e0 08
0135h or rcx,rax                    ; OR(Or_r64_rm64) [RCX,RAX]                            encoding(3 bytes) = 48 0b c8
0138h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
013bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
013fh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0143h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0144h call 7FFDCFDE01D8h            ; CALL(Call_rel32_64) [FFFFFFFFFF945DD8h:jmp64]        encoding(5 bytes) = e8 8f 5c 94 ff
0149h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
014ah call 7FFE2FA0EF00h            ; CALL(Call_rel32_64) [5F574B00h:jmp64]                encoding(5 bytes) = e8 b1 49 57 5f
014fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> pack16gBytes => new byte[336]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x8B,0x51,0x08,0x83,0xFA,0x00,0x0F,0x86,0x36,0x01,0x00,0x00,0x8B,0x08,0x83,0xFA,0x01,0x0F,0x86,0x2B,0x01,0x00,0x00,0x44,0x8B,0x40,0x04,0x41,0xD1,0xE0,0x41,0x0B,0xC8,0x83,0xFA,0x02,0x0F,0x86,0x18,0x01,0x00,0x00,0x44,0x8B,0x40,0x08,0x41,0xC1,0xE0,0x02,0x41,0x0B,0xC8,0x83,0xFA,0x03,0x0F,0x86,0x04,0x01,0x00,0x00,0x44,0x8B,0x40,0x0C,0x41,0xC1,0xE0,0x03,0x41,0x0B,0xC8,0x83,0xFA,0x04,0x0F,0x86,0xF0,0x00,0x00,0x00,0x44,0x8B,0x40,0x10,0x41,0xC1,0xE0,0x04,0x41,0x0B,0xC8,0x83,0xFA,0x05,0x0F,0x86,0xDC,0x00,0x00,0x00,0x44,0x8B,0x40,0x14,0x41,0xC1,0xE0,0x05,0x41,0x0B,0xC8,0x83,0xFA,0x06,0x0F,0x86,0xC8,0x00,0x00,0x00,0x44,0x8B,0x40,0x18,0x41,0xC1,0xE0,0x06,0x41,0x0B,0xC8,0x83,0xFA,0x07,0x0F,0x86,0xB4,0x00,0x00,0x00,0x44,0x8B,0x40,0x1C,0x41,0xC1,0xE0,0x07,0x41,0x0B,0xC8,0x83,0xFA,0x08,0x0F,0x82,0x9A,0x00,0x00,0x00,0x83,0xC2,0xF8,0x48,0x83,0xC0,0x20,0x83,0xFA,0x00,0x0F,0x86,0x90,0x00,0x00,0x00,0x44,0x8B,0x00,0x83,0xFA,0x01,0x0F,0x86,0x84,0x00,0x00,0x00,0x44,0x8B,0x48,0x04,0x41,0xD1,0xE1,0x45,0x0B,0xC1,0x83,0xFA,0x02,0x76,0x75,0x44,0x8B,0x48,0x08,0x41,0xC1,0xE1,0x02,0x45,0x0B,0xC1,0x83,0xFA,0x03,0x76,0x65,0x44,0x8B,0x48,0x0C,0x41,0xC1,0xE1,0x03,0x45,0x0B,0xC1,0x83,0xFA,0x04,0x76,0x55,0x44,0x8B,0x48,0x10,0x41,0xC1,0xE1,0x04,0x45,0x0B,0xC1,0x83,0xFA,0x05,0x76,0x45,0x44,0x8B,0x48,0x14,0x41,0xC1,0xE1,0x05,0x45,0x0B,0xC1,0x83,0xFA,0x06,0x76,0x35,0x44,0x8B,0x48,0x18,0x41,0xC1,0xE1,0x06,0x45,0x0B,0xC1,0x83,0xFA,0x07,0x76,0x25,0x8B,0x40,0x1C,0xC1,0xE0,0x07,0x44,0x0B,0xC0,0x41,0x8B,0xC0,0x48,0xC1,0xE0,0x08,0x48,0x0B,0xC8,0x0F,0xB7,0xC1,0x48,0x0F,0xBF,0xC0,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x8F,0x5C,0x94,0xFF,0xCC,0xE8,0xB1,0x49,0x57,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pack32(Span<bit> src)
; location: [7FFDD049A570h, 7FFDD049A846h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000bh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
000eh mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0011h cmp r8d,0                     ; CMP(Cmp_rm32_imm8) [R8D,0h:imm32]                    encoding(4 bytes) = 41 83 f8 00
0015h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 b6 02 00 00
001bh mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 44 8b 09
001eh cmp r8d,1                     ; CMP(Cmp_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 f8 01
0022h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 a9 02 00 00
0028h mov r10d,[rcx+4]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 04
002ch shl r10d,1                    ; SHL(Shl_rm32_1) [R10D,1h:imm8]                       encoding(3 bytes) = 41 d1 e2
002fh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0032h cmp r8d,2                     ; CMP(Cmp_rm32_imm8) [R8D,2h:imm32]                    encoding(4 bytes) = 41 83 f8 02
0036h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 95 02 00 00
003ch mov r10d,[rcx+8]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 08
0040h shl r10d,2                    ; SHL(Shl_rm32_imm8) [R10D,2h:imm8]                    encoding(4 bytes) = 41 c1 e2 02
0044h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0047h cmp r8d,3                     ; CMP(Cmp_rm32_imm8) [R8D,3h:imm32]                    encoding(4 bytes) = 41 83 f8 03
004bh jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 80 02 00 00
0051h mov r10d,[rcx+0Ch]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 0c
0055h shl r10d,3                    ; SHL(Shl_rm32_imm8) [R10D,3h:imm8]                    encoding(4 bytes) = 41 c1 e2 03
0059h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
005ch cmp r8d,4                     ; CMP(Cmp_rm32_imm8) [R8D,4h:imm32]                    encoding(4 bytes) = 41 83 f8 04
0060h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 6b 02 00 00
0066h mov r10d,[rcx+10h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 10
006ah shl r10d,4                    ; SHL(Shl_rm32_imm8) [R10D,4h:imm8]                    encoding(4 bytes) = 41 c1 e2 04
006eh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0071h cmp r8d,5                     ; CMP(Cmp_rm32_imm8) [R8D,5h:imm32]                    encoding(4 bytes) = 41 83 f8 05
0075h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 56 02 00 00
007bh mov r10d,[rcx+14h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 14
007fh shl r10d,5                    ; SHL(Shl_rm32_imm8) [R10D,5h:imm8]                    encoding(4 bytes) = 41 c1 e2 05
0083h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0086h cmp r8d,6                     ; CMP(Cmp_rm32_imm8) [R8D,6h:imm32]                    encoding(4 bytes) = 41 83 f8 06
008ah jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 41 02 00 00
0090h mov r10d,[rcx+18h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 18
0094h shl r10d,6                    ; SHL(Shl_rm32_imm8) [R10D,6h:imm8]                    encoding(4 bytes) = 41 c1 e2 06
0098h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
009bh cmp r8d,7                     ; CMP(Cmp_rm32_imm8) [R8D,7h:imm32]                    encoding(4 bytes) = 41 83 f8 07
009fh jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 2c 02 00 00
00a5h mov ecx,[rcx+1Ch]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 1c
00a8h shl ecx,7                     ; SHL(Shl_rm32_imm8) [ECX,7h:imm8]                     encoding(3 bytes) = c1 e1 07
00abh or r9d,ecx                    ; OR(Or_r32_rm32) [R9D,ECX]                            encoding(3 bytes) = 44 0b c9
00aeh mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
00b1h cmp edx,8                     ; CMP(Cmp_rm32_imm8) [EDX,8h:imm32]                    encoding(3 bytes) = 83 fa 08
00b4h jb near ptr 02bfh             ; JB(Jb_rel32_64) [2BFh:jmp64]                         encoding(6 bytes) = 0f 82 05 02 00 00
00bah lea r8d,[rdx-8]               ; LEA(Lea_r32_m) [R8D,mem(Unknown,RDX:br,DS:sr)]       encoding(4 bytes) = 44 8d 42 f8
00beh lea r9,[rax+20h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 48 20
00c2h cmp r8d,0                     ; CMP(Cmp_rm32_imm8) [R8D,0h:imm32]                    encoding(4 bytes) = 41 83 f8 00
00c6h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 05 02 00 00
00cch mov r10d,[r9]                 ; MOV(Mov_r32_rm32) [R10D,mem(32u,R9:br,DS:sr)]        encoding(3 bytes) = 45 8b 11
00cfh cmp r8d,1                     ; CMP(Cmp_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 f8 01
00d3h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 f8 01 00 00
00d9h mov r11d,[r9+4]               ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 04
00ddh shl r11d,1                    ; SHL(Shl_rm32_1) [R11D,1h:imm8]                       encoding(3 bytes) = 41 d1 e3
00e0h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
00e3h cmp r8d,2                     ; CMP(Cmp_rm32_imm8) [R8D,2h:imm32]                    encoding(4 bytes) = 41 83 f8 02
00e7h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 e4 01 00 00
00edh mov r11d,[r9+8]               ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 08
00f1h shl r11d,2                    ; SHL(Shl_rm32_imm8) [R11D,2h:imm8]                    encoding(4 bytes) = 41 c1 e3 02
00f5h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
00f8h cmp r8d,3                     ; CMP(Cmp_rm32_imm8) [R8D,3h:imm32]                    encoding(4 bytes) = 41 83 f8 03
00fch jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 cf 01 00 00
0102h mov r11d,[r9+0Ch]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 0c
0106h shl r11d,3                    ; SHL(Shl_rm32_imm8) [R11D,3h:imm8]                    encoding(4 bytes) = 41 c1 e3 03
010ah or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
010dh cmp r8d,4                     ; CMP(Cmp_rm32_imm8) [R8D,4h:imm32]                    encoding(4 bytes) = 41 83 f8 04
0111h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 ba 01 00 00
0117h mov r11d,[r9+10h]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 10
011bh shl r11d,4                    ; SHL(Shl_rm32_imm8) [R11D,4h:imm8]                    encoding(4 bytes) = 41 c1 e3 04
011fh or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0122h cmp r8d,5                     ; CMP(Cmp_rm32_imm8) [R8D,5h:imm32]                    encoding(4 bytes) = 41 83 f8 05
0126h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 a5 01 00 00
012ch mov r11d,[r9+14h]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 14
0130h shl r11d,5                    ; SHL(Shl_rm32_imm8) [R11D,5h:imm8]                    encoding(4 bytes) = 41 c1 e3 05
0134h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0137h cmp r8d,6                     ; CMP(Cmp_rm32_imm8) [R8D,6h:imm32]                    encoding(4 bytes) = 41 83 f8 06
013bh jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 90 01 00 00
0141h mov r11d,[r9+18h]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 18
0145h shl r11d,6                    ; SHL(Shl_rm32_imm8) [R11D,6h:imm8]                    encoding(4 bytes) = 41 c1 e3 06
0149h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
014ch cmp r8d,7                     ; CMP(Cmp_rm32_imm8) [R8D,7h:imm32]                    encoding(4 bytes) = 41 83 f8 07
0150h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 7b 01 00 00
0156h mov r8d,[r9+1Ch]              ; MOV(Mov_r32_rm32) [R8D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 41 1c
015ah shl r8d,7                     ; SHL(Shl_rm32_imm8) [R8D,7h:imm8]                     encoding(4 bytes) = 41 c1 e0 07
015eh or r10d,r8d                   ; OR(Or_r32_rm32) [R10D,R8D]                           encoding(3 bytes) = 45 0b d0
0161h mov r8d,r10d                  ; MOV(Mov_r32_rm32) [R8D,R10D]                         encoding(3 bytes) = 45 8b c2
0164h shl r8,8                      ; SHL(Shl_rm64_imm8) [R8,8h:imm8]                      encoding(4 bytes) = 49 c1 e0 08
0168h or rcx,r8                     ; OR(Or_r64_rm64) [RCX,R8]                             encoding(3 bytes) = 49 0b c8
016bh cmp edx,10h                   ; CMP(Cmp_rm32_imm8) [EDX,10h:imm32]                   encoding(3 bytes) = 83 fa 10
016eh jb near ptr 02c5h             ; JB(Jb_rel32_64) [2C5h:jmp64]                         encoding(6 bytes) = 0f 82 51 01 00 00
0174h add edx,0FFFFFFF0h            ; ADD(Add_rm32_imm8) [EDX,fffffffffffffff0h:imm32]     encoding(3 bytes) = 83 c2 f0
0177h add rax,40h                   ; ADD(Add_rm64_imm8) [RAX,40h:imm64]                   encoding(4 bytes) = 48 83 c0 40
017bh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
017eh jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 4d 01 00 00
0184h mov r8d,[rax]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 44 8b 00
0187h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
018ah jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 41 01 00 00
0190h mov r9d,[rax+4]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 04
0194h shl r9d,1                     ; SHL(Shl_rm32_1) [R9D,1h:imm8]                        encoding(3 bytes) = 41 d1 e1
0197h or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
019ah cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
019dh jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 2e 01 00 00
01a3h mov r9d,[rax+8]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 08
01a7h shl r9d,2                     ; SHL(Shl_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e1 02
01abh or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
01aeh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
01b1h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 1a 01 00 00
01b7h mov r9d,[rax+0Ch]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 0c
01bbh shl r9d,3                     ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]                     encoding(4 bytes) = 41 c1 e1 03
01bfh or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
01c2h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
01c5h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 06 01 00 00
01cbh mov r9d,[rax+10h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 10
01cfh shl r9d,4                     ; SHL(Shl_rm32_imm8) [R9D,4h:imm8]                     encoding(4 bytes) = 41 c1 e1 04
01d3h or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
01d6h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
01d9h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 f2 00 00 00
01dfh mov r9d,[rax+14h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 14
01e3h shl r9d,5                     ; SHL(Shl_rm32_imm8) [R9D,5h:imm8]                     encoding(4 bytes) = 41 c1 e1 05
01e7h or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
01eah cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
01edh jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 de 00 00 00
01f3h mov r9d,[rax+18h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 18
01f7h shl r9d,6                     ; SHL(Shl_rm32_imm8) [R9D,6h:imm8]                     encoding(4 bytes) = 41 c1 e1 06
01fbh or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
01feh cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
0201h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 ca 00 00 00
0207h mov r9d,[rax+1Ch]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 1c
020bh shl r9d,7                     ; SHL(Shl_rm32_imm8) [R9D,7h:imm8]                     encoding(4 bytes) = 41 c1 e1 07
020fh or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
0212h cmp edx,8                     ; CMP(Cmp_rm32_imm8) [EDX,8h:imm32]                    encoding(3 bytes) = 83 fa 08
0215h jb near ptr 02cbh             ; JB(Jb_rel32_64) [2CBh:jmp64]                         encoding(6 bytes) = 0f 82 b0 00 00 00
021bh add edx,0FFFFFFF8h            ; ADD(Add_rm32_imm8) [EDX,fffffffffffffff8h:imm32]     encoding(3 bytes) = 83 c2 f8
021eh add rax,20h                   ; ADD(Add_rm64_imm8) [RAX,20h:imm64]                   encoding(4 bytes) = 48 83 c0 20
0222h cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
0225h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 a6 00 00 00
022bh mov r9d,[rax]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 44 8b 08
022eh cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0231h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 9a 00 00 00
0237h mov r10d,[rax+4]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 04
023bh shl r10d,1                    ; SHL(Shl_rm32_1) [R10D,1h:imm8]                       encoding(3 bytes) = 41 d1 e2
023eh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0241h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
0244h jbe near ptr 02d1h            ; JBE(Jbe_rel32_64) [2D1h:jmp64]                       encoding(6 bytes) = 0f 86 87 00 00 00
024ah mov r10d,[rax+8]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 08
024eh shl r10d,2                    ; SHL(Shl_rm32_imm8) [R10D,2h:imm8]                    encoding(4 bytes) = 41 c1 e2 02
0252h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0255h cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0258h jbe short 02d1h               ; JBE(Jbe_rel8_64) [2D1h:jmp64]                        encoding(2 bytes) = 76 77
025ah mov r10d,[rax+0Ch]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 0c
025eh shl r10d,3                    ; SHL(Shl_rm32_imm8) [R10D,3h:imm8]                    encoding(4 bytes) = 41 c1 e2 03
0262h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0265h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
0268h jbe short 02d1h               ; JBE(Jbe_rel8_64) [2D1h:jmp64]                        encoding(2 bytes) = 76 67
026ah mov r10d,[rax+10h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 10
026eh shl r10d,4                    ; SHL(Shl_rm32_imm8) [R10D,4h:imm8]                    encoding(4 bytes) = 41 c1 e2 04
0272h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0275h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
0278h jbe short 02d1h               ; JBE(Jbe_rel8_64) [2D1h:jmp64]                        encoding(2 bytes) = 76 57
027ah mov r10d,[rax+14h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 14
027eh shl r10d,5                    ; SHL(Shl_rm32_imm8) [R10D,5h:imm8]                    encoding(4 bytes) = 41 c1 e2 05
0282h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0285h cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
0288h jbe short 02d1h               ; JBE(Jbe_rel8_64) [2D1h:jmp64]                        encoding(2 bytes) = 76 47
028ah mov r10d,[rax+18h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 18
028eh shl r10d,6                    ; SHL(Shl_rm32_imm8) [R10D,6h:imm8]                    encoding(4 bytes) = 41 c1 e2 06
0292h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0295h cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
0298h jbe short 02d1h               ; JBE(Jbe_rel8_64) [2D1h:jmp64]                        encoding(2 bytes) = 76 37
029ah mov eax,[rax+1Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 40 1c
029dh shl eax,7                     ; SHL(Shl_rm32_imm8) [EAX,7h:imm8]                     encoding(3 bytes) = c1 e0 07
02a0h or r9d,eax                    ; OR(Or_r32_rm32) [R9D,EAX]                            encoding(3 bytes) = 44 0b c8
02a3h mov eax,r9d                   ; MOV(Mov_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 8b c1
02a6h shl rax,8                     ; SHL(Shl_rm64_imm8) [RAX,8h:imm8]                     encoding(4 bytes) = 48 c1 e0 08
02aah or r8,rax                     ; OR(Or_r64_rm64) [R8,RAX]                             encoding(3 bytes) = 4c 0b c0
02adh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
02b0h shl rax,10h                   ; SHL(Shl_rm64_imm8) [RAX,10h:imm8]                    encoding(4 bytes) = 48 c1 e0 10
02b4h or rcx,rax                    ; OR(Or_r64_rm64) [RCX,RAX]                            encoding(3 bytes) = 48 0b c8
02b7h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
02bah add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
02beh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
02bfh call 7FFDCFDE01D8h            ; CALL(Call_rel32_64) [FFFFFFFFFF945C68h:jmp64]        encoding(5 bytes) = e8 a4 59 94 ff
02c4h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
02c5h call 7FFDCFDE01D8h            ; CALL(Call_rel32_64) [FFFFFFFFFF945C68h:jmp64]        encoding(5 bytes) = e8 9e 59 94 ff
02cah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
02cbh call 7FFDCFDE01D8h            ; CALL(Call_rel32_64) [FFFFFFFFFF945C68h:jmp64]        encoding(5 bytes) = e8 98 59 94 ff
02d0h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
02d1h call 7FFE2FA0EF00h            ; CALL(Call_rel32_64) [5F574990h:jmp64]                encoding(5 bytes) = e8 ba 46 57 5f
02d6h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> pack32Bytes => new byte[727]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x8B,0x51,0x08,0x48,0x8B,0xC8,0x44,0x8B,0xC2,0x41,0x83,0xF8,0x00,0x0F,0x86,0xB6,0x02,0x00,0x00,0x44,0x8B,0x09,0x41,0x83,0xF8,0x01,0x0F,0x86,0xA9,0x02,0x00,0x00,0x44,0x8B,0x51,0x04,0x41,0xD1,0xE2,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x02,0x0F,0x86,0x95,0x02,0x00,0x00,0x44,0x8B,0x51,0x08,0x41,0xC1,0xE2,0x02,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x03,0x0F,0x86,0x80,0x02,0x00,0x00,0x44,0x8B,0x51,0x0C,0x41,0xC1,0xE2,0x03,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x04,0x0F,0x86,0x6B,0x02,0x00,0x00,0x44,0x8B,0x51,0x10,0x41,0xC1,0xE2,0x04,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x05,0x0F,0x86,0x56,0x02,0x00,0x00,0x44,0x8B,0x51,0x14,0x41,0xC1,0xE2,0x05,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x06,0x0F,0x86,0x41,0x02,0x00,0x00,0x44,0x8B,0x51,0x18,0x41,0xC1,0xE2,0x06,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x07,0x0F,0x86,0x2C,0x02,0x00,0x00,0x8B,0x49,0x1C,0xC1,0xE1,0x07,0x44,0x0B,0xC9,0x41,0x8B,0xC9,0x83,0xFA,0x08,0x0F,0x82,0x05,0x02,0x00,0x00,0x44,0x8D,0x42,0xF8,0x4C,0x8D,0x48,0x20,0x41,0x83,0xF8,0x00,0x0F,0x86,0x05,0x02,0x00,0x00,0x45,0x8B,0x11,0x41,0x83,0xF8,0x01,0x0F,0x86,0xF8,0x01,0x00,0x00,0x45,0x8B,0x59,0x04,0x41,0xD1,0xE3,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x02,0x0F,0x86,0xE4,0x01,0x00,0x00,0x45,0x8B,0x59,0x08,0x41,0xC1,0xE3,0x02,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x03,0x0F,0x86,0xCF,0x01,0x00,0x00,0x45,0x8B,0x59,0x0C,0x41,0xC1,0xE3,0x03,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x04,0x0F,0x86,0xBA,0x01,0x00,0x00,0x45,0x8B,0x59,0x10,0x41,0xC1,0xE3,0x04,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x05,0x0F,0x86,0xA5,0x01,0x00,0x00,0x45,0x8B,0x59,0x14,0x41,0xC1,0xE3,0x05,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x06,0x0F,0x86,0x90,0x01,0x00,0x00,0x45,0x8B,0x59,0x18,0x41,0xC1,0xE3,0x06,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x07,0x0F,0x86,0x7B,0x01,0x00,0x00,0x45,0x8B,0x41,0x1C,0x41,0xC1,0xE0,0x07,0x45,0x0B,0xD0,0x45,0x8B,0xC2,0x49,0xC1,0xE0,0x08,0x49,0x0B,0xC8,0x83,0xFA,0x10,0x0F,0x82,0x51,0x01,0x00,0x00,0x83,0xC2,0xF0,0x48,0x83,0xC0,0x40,0x83,0xFA,0x00,0x0F,0x86,0x4D,0x01,0x00,0x00,0x44,0x8B,0x00,0x83,0xFA,0x01,0x0F,0x86,0x41,0x01,0x00,0x00,0x44,0x8B,0x48,0x04,0x41,0xD1,0xE1,0x45,0x0B,0xC1,0x83,0xFA,0x02,0x0F,0x86,0x2E,0x01,0x00,0x00,0x44,0x8B,0x48,0x08,0x41,0xC1,0xE1,0x02,0x45,0x0B,0xC1,0x83,0xFA,0x03,0x0F,0x86,0x1A,0x01,0x00,0x00,0x44,0x8B,0x48,0x0C,0x41,0xC1,0xE1,0x03,0x45,0x0B,0xC1,0x83,0xFA,0x04,0x0F,0x86,0x06,0x01,0x00,0x00,0x44,0x8B,0x48,0x10,0x41,0xC1,0xE1,0x04,0x45,0x0B,0xC1,0x83,0xFA,0x05,0x0F,0x86,0xF2,0x00,0x00,0x00,0x44,0x8B,0x48,0x14,0x41,0xC1,0xE1,0x05,0x45,0x0B,0xC1,0x83,0xFA,0x06,0x0F,0x86,0xDE,0x00,0x00,0x00,0x44,0x8B,0x48,0x18,0x41,0xC1,0xE1,0x06,0x45,0x0B,0xC1,0x83,0xFA,0x07,0x0F,0x86,0xCA,0x00,0x00,0x00,0x44,0x8B,0x48,0x1C,0x41,0xC1,0xE1,0x07,0x45,0x0B,0xC1,0x83,0xFA,0x08,0x0F,0x82,0xB0,0x00,0x00,0x00,0x83,0xC2,0xF8,0x48,0x83,0xC0,0x20,0x83,0xFA,0x00,0x0F,0x86,0xA6,0x00,0x00,0x00,0x44,0x8B,0x08,0x83,0xFA,0x01,0x0F,0x86,0x9A,0x00,0x00,0x00,0x44,0x8B,0x50,0x04,0x41,0xD1,0xE2,0x45,0x0B,0xCA,0x83,0xFA,0x02,0x0F,0x86,0x87,0x00,0x00,0x00,0x44,0x8B,0x50,0x08,0x41,0xC1,0xE2,0x02,0x45,0x0B,0xCA,0x83,0xFA,0x03,0x76,0x77,0x44,0x8B,0x50,0x0C,0x41,0xC1,0xE2,0x03,0x45,0x0B,0xCA,0x83,0xFA,0x04,0x76,0x67,0x44,0x8B,0x50,0x10,0x41,0xC1,0xE2,0x04,0x45,0x0B,0xCA,0x83,0xFA,0x05,0x76,0x57,0x44,0x8B,0x50,0x14,0x41,0xC1,0xE2,0x05,0x45,0x0B,0xCA,0x83,0xFA,0x06,0x76,0x47,0x44,0x8B,0x50,0x18,0x41,0xC1,0xE2,0x06,0x45,0x0B,0xCA,0x83,0xFA,0x07,0x76,0x37,0x8B,0x40,0x1C,0xC1,0xE0,0x07,0x44,0x0B,0xC8,0x41,0x8B,0xC1,0x48,0xC1,0xE0,0x08,0x4C,0x0B,0xC0,0x49,0x8B,0xC0,0x48,0xC1,0xE0,0x10,0x48,0x0B,0xC8,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xA4,0x59,0x94,0xFF,0xCC,0xE8,0x9E,0x59,0x94,0xFF,0xCC,0xE8,0x98,0x59,0x94,0xFF,0xCC,0xE8,0xBA,0x46,0x57,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector<uint> pack32g(Span<bit> src)
; location: [7FFDD049AE00h, 7FFDD049B0D3h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000bh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
000eh mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0011h cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
0014h jbe near ptr 02ceh            ; JBE(Jbe_rel32_64) [2CEh:jmp64]                       encoding(6 bytes) = 0f 86 b4 02 00 00
001ah mov r9d,[rax]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 44 8b 08
001dh cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0020h jbe near ptr 02ceh            ; JBE(Jbe_rel32_64) [2CEh:jmp64]                       encoding(6 bytes) = 0f 86 a8 02 00 00
0026h mov r10d,[rax+4]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 04
002ah shl r10d,1                    ; SHL(Shl_rm32_1) [R10D,1h:imm8]                       encoding(3 bytes) = 41 d1 e2
002dh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0030h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
0033h jbe near ptr 02ceh            ; JBE(Jbe_rel32_64) [2CEh:jmp64]                       encoding(6 bytes) = 0f 86 95 02 00 00
0039h mov r10d,[rax+8]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 08
003dh shl r10d,2                    ; SHL(Shl_rm32_imm8) [R10D,2h:imm8]                    encoding(4 bytes) = 41 c1 e2 02
0041h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0044h cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0047h jbe near ptr 02ceh            ; JBE(Jbe_rel32_64) [2CEh:jmp64]                       encoding(6 bytes) = 0f 86 81 02 00 00
004dh mov r10d,[rax+0Ch]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 0c
0051h shl r10d,3                    ; SHL(Shl_rm32_imm8) [R10D,3h:imm8]                    encoding(4 bytes) = 41 c1 e2 03
0055h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0058h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
005bh jbe near ptr 02ceh            ; JBE(Jbe_rel32_64) [2CEh:jmp64]                       encoding(6 bytes) = 0f 86 6d 02 00 00
0061h mov r10d,[rax+10h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 10
0065h shl r10d,4                    ; SHL(Shl_rm32_imm8) [R10D,4h:imm8]                    encoding(4 bytes) = 41 c1 e2 04
0069h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
006ch cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
006fh jbe near ptr 02ceh            ; JBE(Jbe_rel32_64) [2CEh:jmp64]                       encoding(6 bytes) = 0f 86 59 02 00 00
0075h mov r10d,[rax+14h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 14
0079h shl r10d,5                    ; SHL(Shl_rm32_imm8) [R10D,5h:imm8]                    encoding(4 bytes) = 41 c1 e2 05
007dh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0080h cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
0083h jbe near ptr 02ceh            ; JBE(Jbe_rel32_64) [2CEh:jmp64]                       encoding(6 bytes) = 0f 86 45 02 00 00
0089h mov r10d,[rax+18h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 18
008dh shl r10d,6                    ; SHL(Shl_rm32_imm8) [R10D,6h:imm8]                    encoding(4 bytes) = 41 c1 e2 06
0091h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0094h cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
0097h jbe near ptr 02ceh            ; JBE(Jbe_rel32_64) [2CEh:jmp64]                       encoding(6 bytes) = 0f 86 31 02 00 00
009dh mov eax,[rax+1Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 40 1c
00a0h shl eax,7                     ; SHL(Shl_rm32_imm8) [EAX,7h:imm8]                     encoding(3 bytes) = c1 e0 07
00a3h or r9d,eax                    ; OR(Or_r32_rm32) [R9D,EAX]                            encoding(3 bytes) = 44 0b c8
00a6h mov eax,r9d                   ; MOV(Mov_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 8b c1
00a9h cmp r8d,8                     ; CMP(Cmp_rm32_imm8) [R8D,8h:imm32]                    encoding(4 bytes) = 41 83 f8 08
00adh jb near ptr 02bch             ; JB(Jb_rel32_64) [2BCh:jmp64]                         encoding(6 bytes) = 0f 82 09 02 00 00
00b3h lea edx,[r8-8]                ; LEA(Lea_r32_m) [EDX,mem(Unknown,R8:br,DS:sr)]        encoding(4 bytes) = 41 8d 50 f8
00b7h lea r9,[rcx+20h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RCX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 49 20
00bbh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
00beh jbe near ptr 02ceh            ; JBE(Jbe_rel32_64) [2CEh:jmp64]                       encoding(6 bytes) = 0f 86 0a 02 00 00
00c4h mov r10d,[r9]                 ; MOV(Mov_r32_rm32) [R10D,mem(32u,R9:br,DS:sr)]        encoding(3 bytes) = 45 8b 11
00c7h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
00cah jbe near ptr 02ceh            ; JBE(Jbe_rel32_64) [2CEh:jmp64]                       encoding(6 bytes) = 0f 86 fe 01 00 00
00d0h mov r11d,[r9+4]               ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 04
00d4h shl r11d,1                    ; SHL(Shl_rm32_1) [R11D,1h:imm8]                       encoding(3 bytes) = 41 d1 e3
00d7h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
00dah cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
00ddh jbe near ptr 02ceh            ; JBE(Jbe_rel32_64) [2CEh:jmp64]                       encoding(6 bytes) = 0f 86 eb 01 00 00
00e3h mov r11d,[r9+8]               ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 08
00e7h shl r11d,2                    ; SHL(Shl_rm32_imm8) [R11D,2h:imm8]                    encoding(4 bytes) = 41 c1 e3 02
00ebh or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
00eeh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
00f1h jbe near ptr 02ceh            ; JBE(Jbe_rel32_64) [2CEh:jmp64]                       encoding(6 bytes) = 0f 86 d7 01 00 00
00f7h mov r11d,[r9+0Ch]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 0c
00fbh shl r11d,3                    ; SHL(Shl_rm32_imm8) [R11D,3h:imm8]                    encoding(4 bytes) = 41 c1 e3 03
00ffh or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0102h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
0105h jbe near ptr 02ceh            ; JBE(Jbe_rel32_64) [2CEh:jmp64]                       encoding(6 bytes) = 0f 86 c3 01 00 00
010bh mov r11d,[r9+10h]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 10
010fh shl r11d,4                    ; SHL(Shl_rm32_imm8) [R11D,4h:imm8]                    encoding(4 bytes) = 41 c1 e3 04
0113h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0116h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
0119h jbe near ptr 02ceh            ; JBE(Jbe_rel32_64) [2CEh:jmp64]                       encoding(6 bytes) = 0f 86 af 01 00 00
011fh mov r11d,[r9+14h]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 14
0123h shl r11d,5                    ; SHL(Shl_rm32_imm8) [R11D,5h:imm8]                    encoding(4 bytes) = 41 c1 e3 05
0127h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
012ah cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
012dh jbe near ptr 02ceh            ; JBE(Jbe_rel32_64) [2CEh:jmp64]                       encoding(6 bytes) = 0f 86 9b 01 00 00
0133h mov r11d,[r9+18h]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 18
0137h shl r11d,6                    ; SHL(Shl_rm32_imm8) [R11D,6h:imm8]                    encoding(4 bytes) = 41 c1 e3 06
013bh or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
013eh cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
0141h jbe near ptr 02ceh            ; JBE(Jbe_rel32_64) [2CEh:jmp64]                       encoding(6 bytes) = 0f 86 87 01 00 00
0147h mov edx,[r9+1Ch]              ; MOV(Mov_r32_rm32) [EDX,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 41 8b 51 1c
014bh shl edx,7                     ; SHL(Shl_rm32_imm8) [EDX,7h:imm8]                     encoding(3 bytes) = c1 e2 07
014eh or r10d,edx                   ; OR(Or_r32_rm32) [R10D,EDX]                           encoding(3 bytes) = 44 0b d2
0151h mov edx,r10d                  ; MOV(Mov_r32_rm32) [EDX,R10D]                         encoding(3 bytes) = 41 8b d2
0154h shl rdx,8                     ; SHL(Shl_rm64_imm8) [RDX,8h:imm8]                     encoding(4 bytes) = 48 c1 e2 08
0158h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
015bh cmp r8d,10h                   ; CMP(Cmp_rm32_imm8) [R8D,10h:imm32]                   encoding(4 bytes) = 41 83 f8 10
015fh jb near ptr 02c2h             ; JB(Jb_rel32_64) [2C2h:jmp64]                         encoding(6 bytes) = 0f 82 5d 01 00 00
0165h add r8d,0FFFFFFF0h            ; ADD(Add_rm32_imm8) [R8D,fffffffffffffff0h:imm32]     encoding(4 bytes) = 41 83 c0 f0
0169h add rcx,40h                   ; ADD(Add_rm64_imm8) [RCX,40h:imm64]                   encoding(4 bytes) = 48 83 c1 40
016dh cmp r8d,0                     ; CMP(Cmp_rm32_imm8) [R8D,0h:imm32]                    encoding(4 bytes) = 41 83 f8 00
0171h jbe near ptr 02ceh            ; JBE(Jbe_rel32_64) [2CEh:jmp64]                       encoding(6 bytes) = 0f 86 57 01 00 00
0177h mov edx,[rcx]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 11
0179h cmp r8d,1                     ; CMP(Cmp_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 f8 01
017dh jbe near ptr 02ceh            ; JBE(Jbe_rel32_64) [2CEh:jmp64]                       encoding(6 bytes) = 0f 86 4b 01 00 00
0183h mov r9d,[rcx+4]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 8b 49 04
0187h shl r9d,1                     ; SHL(Shl_rm32_1) [R9D,1h:imm8]                        encoding(3 bytes) = 41 d1 e1
018ah or edx,r9d                    ; OR(Or_r32_rm32) [EDX,R9D]                            encoding(3 bytes) = 41 0b d1
018dh cmp r8d,2                     ; CMP(Cmp_rm32_imm8) [R8D,2h:imm32]                    encoding(4 bytes) = 41 83 f8 02
0191h jbe near ptr 02ceh            ; JBE(Jbe_rel32_64) [2CEh:jmp64]                       encoding(6 bytes) = 0f 86 37 01 00 00
0197h mov r9d,[rcx+8]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 8b 49 08
019bh shl r9d,2                     ; SHL(Shl_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e1 02
019fh or edx,r9d                    ; OR(Or_r32_rm32) [EDX,R9D]                            encoding(3 bytes) = 41 0b d1
01a2h cmp r8d,3                     ; CMP(Cmp_rm32_imm8) [R8D,3h:imm32]                    encoding(4 bytes) = 41 83 f8 03
01a6h jbe near ptr 02ceh            ; JBE(Jbe_rel32_64) [2CEh:jmp64]                       encoding(6 bytes) = 0f 86 22 01 00 00
01ach mov r9d,[rcx+0Ch]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 8b 49 0c
01b0h shl r9d,3                     ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]                     encoding(4 bytes) = 41 c1 e1 03
01b4h or edx,r9d                    ; OR(Or_r32_rm32) [EDX,R9D]                            encoding(3 bytes) = 41 0b d1
01b7h cmp r8d,4                     ; CMP(Cmp_rm32_imm8) [R8D,4h:imm32]                    encoding(4 bytes) = 41 83 f8 04
01bbh jbe near ptr 02ceh            ; JBE(Jbe_rel32_64) [2CEh:jmp64]                       encoding(6 bytes) = 0f 86 0d 01 00 00
01c1h mov r9d,[rcx+10h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 8b 49 10
01c5h shl r9d,4                     ; SHL(Shl_rm32_imm8) [R9D,4h:imm8]                     encoding(4 bytes) = 41 c1 e1 04
01c9h or edx,r9d                    ; OR(Or_r32_rm32) [EDX,R9D]                            encoding(3 bytes) = 41 0b d1
01cch cmp r8d,5                     ; CMP(Cmp_rm32_imm8) [R8D,5h:imm32]                    encoding(4 bytes) = 41 83 f8 05
01d0h jbe near ptr 02ceh            ; JBE(Jbe_rel32_64) [2CEh:jmp64]                       encoding(6 bytes) = 0f 86 f8 00 00 00
01d6h mov r9d,[rcx+14h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 8b 49 14
01dah shl r9d,5                     ; SHL(Shl_rm32_imm8) [R9D,5h:imm8]                     encoding(4 bytes) = 41 c1 e1 05
01deh or edx,r9d                    ; OR(Or_r32_rm32) [EDX,R9D]                            encoding(3 bytes) = 41 0b d1
01e1h cmp r8d,6                     ; CMP(Cmp_rm32_imm8) [R8D,6h:imm32]                    encoding(4 bytes) = 41 83 f8 06
01e5h jbe near ptr 02ceh            ; JBE(Jbe_rel32_64) [2CEh:jmp64]                       encoding(6 bytes) = 0f 86 e3 00 00 00
01ebh mov r9d,[rcx+18h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 8b 49 18
01efh shl r9d,6                     ; SHL(Shl_rm32_imm8) [R9D,6h:imm8]                     encoding(4 bytes) = 41 c1 e1 06
01f3h or edx,r9d                    ; OR(Or_r32_rm32) [EDX,R9D]                            encoding(3 bytes) = 41 0b d1
01f6h cmp r8d,7                     ; CMP(Cmp_rm32_imm8) [R8D,7h:imm32]                    encoding(4 bytes) = 41 83 f8 07
01fah jbe near ptr 02ceh            ; JBE(Jbe_rel32_64) [2CEh:jmp64]                       encoding(6 bytes) = 0f 86 ce 00 00 00
0200h mov r9d,[rcx+1Ch]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 8b 49 1c
0204h shl r9d,7                     ; SHL(Shl_rm32_imm8) [R9D,7h:imm8]                     encoding(4 bytes) = 41 c1 e1 07
0208h or edx,r9d                    ; OR(Or_r32_rm32) [EDX,R9D]                            encoding(3 bytes) = 41 0b d1
020bh cmp r8d,8                     ; CMP(Cmp_rm32_imm8) [R8D,8h:imm32]                    encoding(4 bytes) = 41 83 f8 08
020fh jb near ptr 02c8h             ; JB(Jb_rel32_64) [2C8h:jmp64]                         encoding(6 bytes) = 0f 82 b3 00 00 00
0215h add r8d,0FFFFFFF8h            ; ADD(Add_rm32_imm8) [R8D,fffffffffffffff8h:imm32]     encoding(4 bytes) = 41 83 c0 f8
0219h add rcx,20h                   ; ADD(Add_rm64_imm8) [RCX,20h:imm64]                   encoding(4 bytes) = 48 83 c1 20
021dh cmp r8d,0                     ; CMP(Cmp_rm32_imm8) [R8D,0h:imm32]                    encoding(4 bytes) = 41 83 f8 00
0221h jbe near ptr 02ceh            ; JBE(Jbe_rel32_64) [2CEh:jmp64]                       encoding(6 bytes) = 0f 86 a7 00 00 00
0227h mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 44 8b 09
022ah cmp r8d,1                     ; CMP(Cmp_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 f8 01
022eh jbe near ptr 02ceh            ; JBE(Jbe_rel32_64) [2CEh:jmp64]                       encoding(6 bytes) = 0f 86 9a 00 00 00
0234h mov r10d,[rcx+4]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 04
0238h shl r10d,1                    ; SHL(Shl_rm32_1) [R10D,1h:imm8]                       encoding(3 bytes) = 41 d1 e2
023bh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
023eh cmp r8d,2                     ; CMP(Cmp_rm32_imm8) [R8D,2h:imm32]                    encoding(4 bytes) = 41 83 f8 02
0242h jbe near ptr 02ceh            ; JBE(Jbe_rel32_64) [2CEh:jmp64]                       encoding(6 bytes) = 0f 86 86 00 00 00
0248h mov r10d,[rcx+8]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 08
024ch shl r10d,2                    ; SHL(Shl_rm32_imm8) [R10D,2h:imm8]                    encoding(4 bytes) = 41 c1 e2 02
0250h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0253h cmp r8d,3                     ; CMP(Cmp_rm32_imm8) [R8D,3h:imm32]                    encoding(4 bytes) = 41 83 f8 03
0257h jbe short 02ceh               ; JBE(Jbe_rel8_64) [2CEh:jmp64]                        encoding(2 bytes) = 76 75
0259h mov r10d,[rcx+0Ch]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 0c
025dh shl r10d,3                    ; SHL(Shl_rm32_imm8) [R10D,3h:imm8]                    encoding(4 bytes) = 41 c1 e2 03
0261h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0264h cmp r8d,4                     ; CMP(Cmp_rm32_imm8) [R8D,4h:imm32]                    encoding(4 bytes) = 41 83 f8 04
0268h jbe short 02ceh               ; JBE(Jbe_rel8_64) [2CEh:jmp64]                        encoding(2 bytes) = 76 64
026ah mov r10d,[rcx+10h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 10
026eh shl r10d,4                    ; SHL(Shl_rm32_imm8) [R10D,4h:imm8]                    encoding(4 bytes) = 41 c1 e2 04
0272h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0275h cmp r8d,5                     ; CMP(Cmp_rm32_imm8) [R8D,5h:imm32]                    encoding(4 bytes) = 41 83 f8 05
0279h jbe short 02ceh               ; JBE(Jbe_rel8_64) [2CEh:jmp64]                        encoding(2 bytes) = 76 53
027bh mov r10d,[rcx+14h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 14
027fh shl r10d,5                    ; SHL(Shl_rm32_imm8) [R10D,5h:imm8]                    encoding(4 bytes) = 41 c1 e2 05
0283h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0286h cmp r8d,6                     ; CMP(Cmp_rm32_imm8) [R8D,6h:imm32]                    encoding(4 bytes) = 41 83 f8 06
028ah jbe short 02ceh               ; JBE(Jbe_rel8_64) [2CEh:jmp64]                        encoding(2 bytes) = 76 42
028ch mov r10d,[rcx+18h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 18
0290h shl r10d,6                    ; SHL(Shl_rm32_imm8) [R10D,6h:imm8]                    encoding(4 bytes) = 41 c1 e2 06
0294h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0297h cmp r8d,7                     ; CMP(Cmp_rm32_imm8) [R8D,7h:imm32]                    encoding(4 bytes) = 41 83 f8 07
029bh jbe short 02ceh               ; JBE(Jbe_rel8_64) [2CEh:jmp64]                        encoding(2 bytes) = 76 31
029dh mov ecx,[rcx+1Ch]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 1c
02a0h shl ecx,7                     ; SHL(Shl_rm32_imm8) [ECX,7h:imm8]                     encoding(3 bytes) = c1 e1 07
02a3h or r9d,ecx                    ; OR(Or_r32_rm32) [R9D,ECX]                            encoding(3 bytes) = 44 0b c9
02a6h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
02a9h shl rcx,8                     ; SHL(Shl_rm64_imm8) [RCX,8h:imm8]                     encoding(4 bytes) = 48 c1 e1 08
02adh or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
02b0h shl rdx,10h                   ; SHL(Shl_rm64_imm8) [RDX,10h:imm8]                    encoding(4 bytes) = 48 c1 e2 10
02b4h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
02b7h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
02bbh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
02bch call 7FFDCFDE01D8h            ; CALL(Call_rel32_64) [FFFFFFFFFF9453D8h:jmp64]        encoding(5 bytes) = e8 17 51 94 ff
02c1h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
02c2h call 7FFDCFDE01D8h            ; CALL(Call_rel32_64) [FFFFFFFFFF9453D8h:jmp64]        encoding(5 bytes) = e8 11 51 94 ff
02c7h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
02c8h call 7FFDCFDE01D8h            ; CALL(Call_rel32_64) [FFFFFFFFFF9453D8h:jmp64]        encoding(5 bytes) = e8 0b 51 94 ff
02cdh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
02ceh call 7FFE2FA0EF00h            ; CALL(Call_rel32_64) [5F574100h:jmp64]                encoding(5 bytes) = e8 2d 3e 57 5f
02d3h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> pack32gBytes => new byte[724]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x8B,0x51,0x08,0x48,0x8B,0xC8,0x44,0x8B,0xC2,0x83,0xFA,0x00,0x0F,0x86,0xB4,0x02,0x00,0x00,0x44,0x8B,0x08,0x83,0xFA,0x01,0x0F,0x86,0xA8,0x02,0x00,0x00,0x44,0x8B,0x50,0x04,0x41,0xD1,0xE2,0x45,0x0B,0xCA,0x83,0xFA,0x02,0x0F,0x86,0x95,0x02,0x00,0x00,0x44,0x8B,0x50,0x08,0x41,0xC1,0xE2,0x02,0x45,0x0B,0xCA,0x83,0xFA,0x03,0x0F,0x86,0x81,0x02,0x00,0x00,0x44,0x8B,0x50,0x0C,0x41,0xC1,0xE2,0x03,0x45,0x0B,0xCA,0x83,0xFA,0x04,0x0F,0x86,0x6D,0x02,0x00,0x00,0x44,0x8B,0x50,0x10,0x41,0xC1,0xE2,0x04,0x45,0x0B,0xCA,0x83,0xFA,0x05,0x0F,0x86,0x59,0x02,0x00,0x00,0x44,0x8B,0x50,0x14,0x41,0xC1,0xE2,0x05,0x45,0x0B,0xCA,0x83,0xFA,0x06,0x0F,0x86,0x45,0x02,0x00,0x00,0x44,0x8B,0x50,0x18,0x41,0xC1,0xE2,0x06,0x45,0x0B,0xCA,0x83,0xFA,0x07,0x0F,0x86,0x31,0x02,0x00,0x00,0x8B,0x40,0x1C,0xC1,0xE0,0x07,0x44,0x0B,0xC8,0x41,0x8B,0xC1,0x41,0x83,0xF8,0x08,0x0F,0x82,0x09,0x02,0x00,0x00,0x41,0x8D,0x50,0xF8,0x4C,0x8D,0x49,0x20,0x83,0xFA,0x00,0x0F,0x86,0x0A,0x02,0x00,0x00,0x45,0x8B,0x11,0x83,0xFA,0x01,0x0F,0x86,0xFE,0x01,0x00,0x00,0x45,0x8B,0x59,0x04,0x41,0xD1,0xE3,0x45,0x0B,0xD3,0x83,0xFA,0x02,0x0F,0x86,0xEB,0x01,0x00,0x00,0x45,0x8B,0x59,0x08,0x41,0xC1,0xE3,0x02,0x45,0x0B,0xD3,0x83,0xFA,0x03,0x0F,0x86,0xD7,0x01,0x00,0x00,0x45,0x8B,0x59,0x0C,0x41,0xC1,0xE3,0x03,0x45,0x0B,0xD3,0x83,0xFA,0x04,0x0F,0x86,0xC3,0x01,0x00,0x00,0x45,0x8B,0x59,0x10,0x41,0xC1,0xE3,0x04,0x45,0x0B,0xD3,0x83,0xFA,0x05,0x0F,0x86,0xAF,0x01,0x00,0x00,0x45,0x8B,0x59,0x14,0x41,0xC1,0xE3,0x05,0x45,0x0B,0xD3,0x83,0xFA,0x06,0x0F,0x86,0x9B,0x01,0x00,0x00,0x45,0x8B,0x59,0x18,0x41,0xC1,0xE3,0x06,0x45,0x0B,0xD3,0x83,0xFA,0x07,0x0F,0x86,0x87,0x01,0x00,0x00,0x41,0x8B,0x51,0x1C,0xC1,0xE2,0x07,0x44,0x0B,0xD2,0x41,0x8B,0xD2,0x48,0xC1,0xE2,0x08,0x48,0x0B,0xC2,0x41,0x83,0xF8,0x10,0x0F,0x82,0x5D,0x01,0x00,0x00,0x41,0x83,0xC0,0xF0,0x48,0x83,0xC1,0x40,0x41,0x83,0xF8,0x00,0x0F,0x86,0x57,0x01,0x00,0x00,0x8B,0x11,0x41,0x83,0xF8,0x01,0x0F,0x86,0x4B,0x01,0x00,0x00,0x44,0x8B,0x49,0x04,0x41,0xD1,0xE1,0x41,0x0B,0xD1,0x41,0x83,0xF8,0x02,0x0F,0x86,0x37,0x01,0x00,0x00,0x44,0x8B,0x49,0x08,0x41,0xC1,0xE1,0x02,0x41,0x0B,0xD1,0x41,0x83,0xF8,0x03,0x0F,0x86,0x22,0x01,0x00,0x00,0x44,0x8B,0x49,0x0C,0x41,0xC1,0xE1,0x03,0x41,0x0B,0xD1,0x41,0x83,0xF8,0x04,0x0F,0x86,0x0D,0x01,0x00,0x00,0x44,0x8B,0x49,0x10,0x41,0xC1,0xE1,0x04,0x41,0x0B,0xD1,0x41,0x83,0xF8,0x05,0x0F,0x86,0xF8,0x00,0x00,0x00,0x44,0x8B,0x49,0x14,0x41,0xC1,0xE1,0x05,0x41,0x0B,0xD1,0x41,0x83,0xF8,0x06,0x0F,0x86,0xE3,0x00,0x00,0x00,0x44,0x8B,0x49,0x18,0x41,0xC1,0xE1,0x06,0x41,0x0B,0xD1,0x41,0x83,0xF8,0x07,0x0F,0x86,0xCE,0x00,0x00,0x00,0x44,0x8B,0x49,0x1C,0x41,0xC1,0xE1,0x07,0x41,0x0B,0xD1,0x41,0x83,0xF8,0x08,0x0F,0x82,0xB3,0x00,0x00,0x00,0x41,0x83,0xC0,0xF8,0x48,0x83,0xC1,0x20,0x41,0x83,0xF8,0x00,0x0F,0x86,0xA7,0x00,0x00,0x00,0x44,0x8B,0x09,0x41,0x83,0xF8,0x01,0x0F,0x86,0x9A,0x00,0x00,0x00,0x44,0x8B,0x51,0x04,0x41,0xD1,0xE2,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x02,0x0F,0x86,0x86,0x00,0x00,0x00,0x44,0x8B,0x51,0x08,0x41,0xC1,0xE2,0x02,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x03,0x76,0x75,0x44,0x8B,0x51,0x0C,0x41,0xC1,0xE2,0x03,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x04,0x76,0x64,0x44,0x8B,0x51,0x10,0x41,0xC1,0xE2,0x04,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x05,0x76,0x53,0x44,0x8B,0x51,0x14,0x41,0xC1,0xE2,0x05,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x06,0x76,0x42,0x44,0x8B,0x51,0x18,0x41,0xC1,0xE2,0x06,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x07,0x76,0x31,0x8B,0x49,0x1C,0xC1,0xE1,0x07,0x44,0x0B,0xC9,0x41,0x8B,0xC9,0x48,0xC1,0xE1,0x08,0x48,0x0B,0xD1,0x48,0xC1,0xE2,0x10,0x48,0x0B,0xC2,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x17,0x51,0x94,0xFF,0xCC,0xE8,0x11,0x51,0x94,0xFF,0xCC,0xE8,0x0B,0x51,0x94,0xFF,0xCC,0xE8,0x2D,0x3E,0x57,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector<ulong> pack64g(Span<bit> src)
; location: [7FFDD049B0F0h, 7FFDD049B6B3h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000bh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
000eh mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0011h cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
0014h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 a4 05 00 00
001ah mov r9d,[rax]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 44 8b 08
001dh cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0020h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 98 05 00 00
0026h mov r10d,[rax+4]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 04
002ah shl r10d,1                    ; SHL(Shl_rm32_1) [R10D,1h:imm8]                       encoding(3 bytes) = 41 d1 e2
002dh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0030h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
0033h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 85 05 00 00
0039h mov r10d,[rax+8]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 08
003dh shl r10d,2                    ; SHL(Shl_rm32_imm8) [R10D,2h:imm8]                    encoding(4 bytes) = 41 c1 e2 02
0041h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0044h cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0047h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 71 05 00 00
004dh mov r10d,[rax+0Ch]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 0c
0051h shl r10d,3                    ; SHL(Shl_rm32_imm8) [R10D,3h:imm8]                    encoding(4 bytes) = 41 c1 e2 03
0055h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0058h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
005bh jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 5d 05 00 00
0061h mov r10d,[rax+10h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 10
0065h shl r10d,4                    ; SHL(Shl_rm32_imm8) [R10D,4h:imm8]                    encoding(4 bytes) = 41 c1 e2 04
0069h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
006ch cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
006fh jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 49 05 00 00
0075h mov r10d,[rax+14h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 14
0079h shl r10d,5                    ; SHL(Shl_rm32_imm8) [R10D,5h:imm8]                    encoding(4 bytes) = 41 c1 e2 05
007dh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0080h cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
0083h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 35 05 00 00
0089h mov eax,[rax+18h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 40 18
008ch shl eax,6                     ; SHL(Shl_rm32_imm8) [EAX,6h:imm8]                     encoding(3 bytes) = c1 e0 06
008fh or r9d,eax                    ; OR(Or_r32_rm32) [R9D,EAX]                            encoding(3 bytes) = 44 0b c8
0092h cmp r8d,7                     ; CMP(Cmp_rm32_imm8) [R8D,7h:imm32]                    encoding(4 bytes) = 41 83 f8 07
0096h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 22 05 00 00
009ch mov eax,[rcx+1Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 41 1c
009fh shl eax,7                     ; SHL(Shl_rm32_imm8) [EAX,7h:imm8]                     encoding(3 bytes) = c1 e0 07
00a2h or r9d,eax                    ; OR(Or_r32_rm32) [R9D,EAX]                            encoding(3 bytes) = 44 0b c8
00a5h mov eax,r9d                   ; MOV(Mov_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 8b c1
00a8h cmp r8d,8                     ; CMP(Cmp_rm32_imm8) [R8D,8h:imm32]                    encoding(4 bytes) = 41 83 f8 08
00ach jb near ptr 0594h             ; JB(Jb_rel32_64) [594h:jmp64]                         encoding(6 bytes) = 0f 82 e2 04 00 00
00b2h lea edx,[r8-8]                ; LEA(Lea_r32_m) [EDX,mem(Unknown,R8:br,DS:sr)]        encoding(4 bytes) = 41 8d 50 f8
00b6h lea r9,[rcx+20h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RCX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 49 20
00bah cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
00bdh jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 fb 04 00 00
00c3h mov r10d,[r9]                 ; MOV(Mov_r32_rm32) [R10D,mem(32u,R9:br,DS:sr)]        encoding(3 bytes) = 45 8b 11
00c6h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
00c9h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 ef 04 00 00
00cfh mov r11d,[r9+4]               ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 04
00d3h shl r11d,1                    ; SHL(Shl_rm32_1) [R11D,1h:imm8]                       encoding(3 bytes) = 41 d1 e3
00d6h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
00d9h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
00dch jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 dc 04 00 00
00e2h mov r11d,[r9+8]               ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 08
00e6h shl r11d,2                    ; SHL(Shl_rm32_imm8) [R11D,2h:imm8]                    encoding(4 bytes) = 41 c1 e3 02
00eah or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
00edh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
00f0h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 c8 04 00 00
00f6h mov r11d,[r9+0Ch]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 0c
00fah shl r11d,3                    ; SHL(Shl_rm32_imm8) [R11D,3h:imm8]                    encoding(4 bytes) = 41 c1 e3 03
00feh or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0101h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
0104h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 b4 04 00 00
010ah mov r11d,[r9+10h]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 10
010eh shl r11d,4                    ; SHL(Shl_rm32_imm8) [R11D,4h:imm8]                    encoding(4 bytes) = 41 c1 e3 04
0112h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0115h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
0118h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 a0 04 00 00
011eh mov r11d,[r9+14h]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 14
0122h shl r11d,5                    ; SHL(Shl_rm32_imm8) [R11D,5h:imm8]                    encoding(4 bytes) = 41 c1 e3 05
0126h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0129h cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
012ch jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 8c 04 00 00
0132h mov r11d,[r9+18h]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 18
0136h shl r11d,6                    ; SHL(Shl_rm32_imm8) [R11D,6h:imm8]                    encoding(4 bytes) = 41 c1 e3 06
013ah or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
013dh cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
0140h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 78 04 00 00
0146h mov edx,[r9+1Ch]              ; MOV(Mov_r32_rm32) [EDX,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 41 8b 51 1c
014ah shl edx,7                     ; SHL(Shl_rm32_imm8) [EDX,7h:imm8]                     encoding(3 bytes) = c1 e2 07
014dh or r10d,edx                   ; OR(Or_r32_rm32) [R10D,EDX]                           encoding(3 bytes) = 44 0b d2
0150h mov edx,r10d                  ; MOV(Mov_r32_rm32) [EDX,R10D]                         encoding(3 bytes) = 41 8b d2
0153h shl rdx,8                     ; SHL(Shl_rm64_imm8) [RDX,8h:imm8]                     encoding(4 bytes) = 48 c1 e2 08
0157h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
015ah cmp r8d,10h                   ; CMP(Cmp_rm32_imm8) [R8D,10h:imm32]                   encoding(4 bytes) = 41 83 f8 10
015eh jb near ptr 059ah             ; JB(Jb_rel32_64) [59Ah:jmp64]                         encoding(6 bytes) = 0f 82 36 04 00 00
0164h lea edx,[r8-10h]              ; LEA(Lea_r32_m) [EDX,mem(Unknown,R8:br,DS:sr)]        encoding(4 bytes) = 41 8d 50 f0
0168h lea r9,[rcx+40h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RCX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 49 40
016ch cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
016fh jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 49 04 00 00
0175h mov r10d,[r9]                 ; MOV(Mov_r32_rm32) [R10D,mem(32u,R9:br,DS:sr)]        encoding(3 bytes) = 45 8b 11
0178h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
017bh jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 3d 04 00 00
0181h mov r11d,[r9+4]               ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 04
0185h shl r11d,1                    ; SHL(Shl_rm32_1) [R11D,1h:imm8]                       encoding(3 bytes) = 41 d1 e3
0188h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
018bh cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
018eh jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 2a 04 00 00
0194h mov r11d,[r9+8]               ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 08
0198h shl r11d,2                    ; SHL(Shl_rm32_imm8) [R11D,2h:imm8]                    encoding(4 bytes) = 41 c1 e3 02
019ch or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
019fh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
01a2h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 16 04 00 00
01a8h mov r11d,[r9+0Ch]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 0c
01ach shl r11d,3                    ; SHL(Shl_rm32_imm8) [R11D,3h:imm8]                    encoding(4 bytes) = 41 c1 e3 03
01b0h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
01b3h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
01b6h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 02 04 00 00
01bch mov r11d,[r9+10h]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 10
01c0h shl r11d,4                    ; SHL(Shl_rm32_imm8) [R11D,4h:imm8]                    encoding(4 bytes) = 41 c1 e3 04
01c4h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
01c7h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
01cah jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 ee 03 00 00
01d0h mov r11d,[r9+14h]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 14
01d4h shl r11d,5                    ; SHL(Shl_rm32_imm8) [R11D,5h:imm8]                    encoding(4 bytes) = 41 c1 e3 05
01d8h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
01dbh cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
01deh jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 da 03 00 00
01e4h mov r11d,[r9+18h]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 18
01e8h shl r11d,6                    ; SHL(Shl_rm32_imm8) [R11D,6h:imm8]                    encoding(4 bytes) = 41 c1 e3 06
01ech or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
01efh cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
01f2h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 c6 03 00 00
01f8h mov r11d,[r9+1Ch]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 1c
01fch shl r11d,7                    ; SHL(Shl_rm32_imm8) [R11D,7h:imm8]                    encoding(4 bytes) = 41 c1 e3 07
0200h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0203h cmp edx,8                     ; CMP(Cmp_rm32_imm8) [EDX,8h:imm32]                    encoding(3 bytes) = 83 fa 08
0206h jb near ptr 05a0h             ; JB(Jb_rel32_64) [5A0h:jmp64]                         encoding(6 bytes) = 0f 82 94 03 00 00
020ch add edx,0FFFFFFF8h            ; ADD(Add_rm32_imm8) [EDX,fffffffffffffff8h:imm32]     encoding(3 bytes) = 83 c2 f8
020fh add r9,20h                    ; ADD(Add_rm64_imm8) [R9,20h:imm64]                    encoding(4 bytes) = 49 83 c1 20
0213h cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
0216h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 a2 03 00 00
021ch mov r11d,[r9]                 ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(3 bytes) = 45 8b 19
021fh cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0222h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 96 03 00 00
0228h mov esi,[r9+4]                ; MOV(Mov_r32_rm32) [ESI,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 41 8b 71 04
022ch shl esi,1                     ; SHL(Shl_rm32_1) [ESI,1h:imm8]                        encoding(2 bytes) = d1 e6
022eh or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
0231h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
0234h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 84 03 00 00
023ah mov esi,[r9+8]                ; MOV(Mov_r32_rm32) [ESI,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 41 8b 71 08
023eh shl esi,2                     ; SHL(Shl_rm32_imm8) [ESI,2h:imm8]                     encoding(3 bytes) = c1 e6 02
0241h or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
0244h cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0247h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 71 03 00 00
024dh mov esi,[r9+0Ch]              ; MOV(Mov_r32_rm32) [ESI,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 41 8b 71 0c
0251h shl esi,3                     ; SHL(Shl_rm32_imm8) [ESI,3h:imm8]                     encoding(3 bytes) = c1 e6 03
0254h or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
0257h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
025ah jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 5e 03 00 00
0260h mov esi,[r9+10h]              ; MOV(Mov_r32_rm32) [ESI,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 41 8b 71 10
0264h shl esi,4                     ; SHL(Shl_rm32_imm8) [ESI,4h:imm8]                     encoding(3 bytes) = c1 e6 04
0267h or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
026ah cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
026dh jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 4b 03 00 00
0273h mov esi,[r9+14h]              ; MOV(Mov_r32_rm32) [ESI,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 41 8b 71 14
0277h shl esi,5                     ; SHL(Shl_rm32_imm8) [ESI,5h:imm8]                     encoding(3 bytes) = c1 e6 05
027ah or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
027dh cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
0280h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 38 03 00 00
0286h mov esi,[r9+18h]              ; MOV(Mov_r32_rm32) [ESI,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 41 8b 71 18
028ah shl esi,6                     ; SHL(Shl_rm32_imm8) [ESI,6h:imm8]                     encoding(3 bytes) = c1 e6 06
028dh or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
0290h cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
0293h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 25 03 00 00
0299h mov edx,[r9+1Ch]              ; MOV(Mov_r32_rm32) [EDX,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 41 8b 51 1c
029dh shl edx,7                     ; SHL(Shl_rm32_imm8) [EDX,7h:imm8]                     encoding(3 bytes) = c1 e2 07
02a0h or r11d,edx                   ; OR(Or_r32_rm32) [R11D,EDX]                           encoding(3 bytes) = 44 0b da
02a3h mov edx,r11d                  ; MOV(Mov_r32_rm32) [EDX,R11D]                         encoding(3 bytes) = 41 8b d3
02a6h shl rdx,8                     ; SHL(Shl_rm64_imm8) [RDX,8h:imm8]                     encoding(4 bytes) = 48 c1 e2 08
02aah or r10,rdx                    ; OR(Or_r64_rm64) [R10,RDX]                            encoding(3 bytes) = 4c 0b d2
02adh mov rdx,r10                   ; MOV(Mov_r64_rm64) [RDX,R10]                          encoding(3 bytes) = 49 8b d2
02b0h shl rdx,10h                   ; SHL(Shl_rm64_imm8) [RDX,10h:imm8]                    encoding(4 bytes) = 48 c1 e2 10
02b4h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
02b7h cmp r8d,20h                   ; CMP(Cmp_rm32_imm8) [R8D,20h:imm32]                   encoding(4 bytes) = 41 83 f8 20
02bbh jb near ptr 05a6h             ; JB(Jb_rel32_64) [5A6h:jmp64]                         encoding(6 bytes) = 0f 82 e5 02 00 00
02c1h add r8d,0FFFFFFE0h            ; ADD(Add_rm32_imm8) [R8D,ffffffffffffffe0h:imm32]     encoding(4 bytes) = 41 83 c0 e0
02c5h add rcx,80h                   ; ADD(Add_rm64_imm32) [RCX,80h:imm64]                  encoding(7 bytes) = 48 81 c1 80 00 00 00
02cch cmp r8d,0                     ; CMP(Cmp_rm32_imm8) [R8D,0h:imm32]                    encoding(4 bytes) = 41 83 f8 00
02d0h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 e8 02 00 00
02d6h mov edx,[rcx]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 11
02d8h cmp r8d,1                     ; CMP(Cmp_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 f8 01
02dch jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 dc 02 00 00
02e2h mov r9d,[rcx+4]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 8b 49 04
02e6h shl r9d,1                     ; SHL(Shl_rm32_1) [R9D,1h:imm8]                        encoding(3 bytes) = 41 d1 e1
02e9h or edx,r9d                    ; OR(Or_r32_rm32) [EDX,R9D]                            encoding(3 bytes) = 41 0b d1
02ech cmp r8d,2                     ; CMP(Cmp_rm32_imm8) [R8D,2h:imm32]                    encoding(4 bytes) = 41 83 f8 02
02f0h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 c8 02 00 00
02f6h mov r9d,[rcx+8]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 8b 49 08
02fah shl r9d,2                     ; SHL(Shl_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e1 02
02feh or edx,r9d                    ; OR(Or_r32_rm32) [EDX,R9D]                            encoding(3 bytes) = 41 0b d1
0301h cmp r8d,3                     ; CMP(Cmp_rm32_imm8) [R8D,3h:imm32]                    encoding(4 bytes) = 41 83 f8 03
0305h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 b3 02 00 00
030bh mov r9d,[rcx+0Ch]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 8b 49 0c
030fh shl r9d,3                     ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]                     encoding(4 bytes) = 41 c1 e1 03
0313h or edx,r9d                    ; OR(Or_r32_rm32) [EDX,R9D]                            encoding(3 bytes) = 41 0b d1
0316h cmp r8d,4                     ; CMP(Cmp_rm32_imm8) [R8D,4h:imm32]                    encoding(4 bytes) = 41 83 f8 04
031ah jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 9e 02 00 00
0320h mov r9d,[rcx+10h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 8b 49 10
0324h shl r9d,4                     ; SHL(Shl_rm32_imm8) [R9D,4h:imm8]                     encoding(4 bytes) = 41 c1 e1 04
0328h or edx,r9d                    ; OR(Or_r32_rm32) [EDX,R9D]                            encoding(3 bytes) = 41 0b d1
032bh cmp r8d,5                     ; CMP(Cmp_rm32_imm8) [R8D,5h:imm32]                    encoding(4 bytes) = 41 83 f8 05
032fh jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 89 02 00 00
0335h mov r9d,[rcx+14h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 8b 49 14
0339h shl r9d,5                     ; SHL(Shl_rm32_imm8) [R9D,5h:imm8]                     encoding(4 bytes) = 41 c1 e1 05
033dh or edx,r9d                    ; OR(Or_r32_rm32) [EDX,R9D]                            encoding(3 bytes) = 41 0b d1
0340h cmp r8d,6                     ; CMP(Cmp_rm32_imm8) [R8D,6h:imm32]                    encoding(4 bytes) = 41 83 f8 06
0344h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 74 02 00 00
034ah mov r9d,[rcx+18h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 8b 49 18
034eh shl r9d,6                     ; SHL(Shl_rm32_imm8) [R9D,6h:imm8]                     encoding(4 bytes) = 41 c1 e1 06
0352h or edx,r9d                    ; OR(Or_r32_rm32) [EDX,R9D]                            encoding(3 bytes) = 41 0b d1
0355h cmp r8d,7                     ; CMP(Cmp_rm32_imm8) [R8D,7h:imm32]                    encoding(4 bytes) = 41 83 f8 07
0359h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 5f 02 00 00
035fh mov r9d,[rcx+1Ch]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 8b 49 1c
0363h shl r9d,7                     ; SHL(Shl_rm32_imm8) [R9D,7h:imm8]                     encoding(4 bytes) = 41 c1 e1 07
0367h or edx,r9d                    ; OR(Or_r32_rm32) [EDX,R9D]                            encoding(3 bytes) = 41 0b d1
036ah cmp r8d,8                     ; CMP(Cmp_rm32_imm8) [R8D,8h:imm32]                    encoding(4 bytes) = 41 83 f8 08
036eh jb near ptr 05ach             ; JB(Jb_rel32_64) [5ACh:jmp64]                         encoding(6 bytes) = 0f 82 38 02 00 00
0374h lea r9d,[r8-8]                ; LEA(Lea_r32_m) [R9D,mem(Unknown,R8:br,DS:sr)]        encoding(4 bytes) = 45 8d 48 f8
0378h lea r10,[rcx+20h]             ; LEA(Lea_r64_m) [R10,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 4c 8d 51 20
037ch cmp r9d,0                     ; CMP(Cmp_rm32_imm8) [R9D,0h:imm32]                    encoding(4 bytes) = 41 83 f9 00
0380h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 38 02 00 00
0386h mov r11d,[r10]                ; MOV(Mov_r32_rm32) [R11D,mem(32u,R10:br,DS:sr)]       encoding(3 bytes) = 45 8b 1a
0389h cmp r9d,1                     ; CMP(Cmp_rm32_imm8) [R9D,1h:imm32]                    encoding(4 bytes) = 41 83 f9 01
038dh jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 2b 02 00 00
0393h mov esi,[r10+4]               ; MOV(Mov_r32_rm32) [ESI,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 41 8b 72 04
0397h shl esi,1                     ; SHL(Shl_rm32_1) [ESI,1h:imm8]                        encoding(2 bytes) = d1 e6
0399h or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
039ch cmp r9d,2                     ; CMP(Cmp_rm32_imm8) [R9D,2h:imm32]                    encoding(4 bytes) = 41 83 f9 02
03a0h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 18 02 00 00
03a6h mov esi,[r10+8]               ; MOV(Mov_r32_rm32) [ESI,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 41 8b 72 08
03aah shl esi,2                     ; SHL(Shl_rm32_imm8) [ESI,2h:imm8]                     encoding(3 bytes) = c1 e6 02
03adh or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
03b0h cmp r9d,3                     ; CMP(Cmp_rm32_imm8) [R9D,3h:imm32]                    encoding(4 bytes) = 41 83 f9 03
03b4h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 04 02 00 00
03bah mov esi,[r10+0Ch]             ; MOV(Mov_r32_rm32) [ESI,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 41 8b 72 0c
03beh shl esi,3                     ; SHL(Shl_rm32_imm8) [ESI,3h:imm8]                     encoding(3 bytes) = c1 e6 03
03c1h or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
03c4h cmp r9d,4                     ; CMP(Cmp_rm32_imm8) [R9D,4h:imm32]                    encoding(4 bytes) = 41 83 f9 04
03c8h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 f0 01 00 00
03ceh mov esi,[r10+10h]             ; MOV(Mov_r32_rm32) [ESI,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 41 8b 72 10
03d2h shl esi,4                     ; SHL(Shl_rm32_imm8) [ESI,4h:imm8]                     encoding(3 bytes) = c1 e6 04
03d5h or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
03d8h cmp r9d,5                     ; CMP(Cmp_rm32_imm8) [R9D,5h:imm32]                    encoding(4 bytes) = 41 83 f9 05
03dch jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 dc 01 00 00
03e2h mov esi,[r10+14h]             ; MOV(Mov_r32_rm32) [ESI,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 41 8b 72 14
03e6h shl esi,5                     ; SHL(Shl_rm32_imm8) [ESI,5h:imm8]                     encoding(3 bytes) = c1 e6 05
03e9h or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
03ech cmp r9d,6                     ; CMP(Cmp_rm32_imm8) [R9D,6h:imm32]                    encoding(4 bytes) = 41 83 f9 06
03f0h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 c8 01 00 00
03f6h mov esi,[r10+18h]             ; MOV(Mov_r32_rm32) [ESI,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 41 8b 72 18
03fah shl esi,6                     ; SHL(Shl_rm32_imm8) [ESI,6h:imm8]                     encoding(3 bytes) = c1 e6 06
03fdh or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
0400h cmp r9d,7                     ; CMP(Cmp_rm32_imm8) [R9D,7h:imm32]                    encoding(4 bytes) = 41 83 f9 07
0404h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 b4 01 00 00
040ah mov r9d,[r10+1Ch]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 45 8b 4a 1c
040eh shl r9d,7                     ; SHL(Shl_rm32_imm8) [R9D,7h:imm8]                     encoding(4 bytes) = 41 c1 e1 07
0412h or r11d,r9d                   ; OR(Or_r32_rm32) [R11D,R9D]                           encoding(3 bytes) = 45 0b d9
0415h mov r9d,r11d                  ; MOV(Mov_r32_rm32) [R9D,R11D]                         encoding(3 bytes) = 45 8b cb
0418h shl r9,8                      ; SHL(Shl_rm64_imm8) [R9,8h:imm8]                      encoding(4 bytes) = 49 c1 e1 08
041ch or rdx,r9                     ; OR(Or_r64_rm64) [RDX,R9]                             encoding(3 bytes) = 49 0b d1
041fh cmp r8d,10h                   ; CMP(Cmp_rm32_imm8) [R8D,10h:imm32]                   encoding(4 bytes) = 41 83 f8 10
0423h jb near ptr 05b2h             ; JB(Jb_rel32_64) [5B2h:jmp64]                         encoding(6 bytes) = 0f 82 89 01 00 00
0429h add r8d,0FFFFFFF0h            ; ADD(Add_rm32_imm8) [R8D,fffffffffffffff0h:imm32]     encoding(4 bytes) = 41 83 c0 f0
042dh add rcx,40h                   ; ADD(Add_rm64_imm8) [RCX,40h:imm64]                   encoding(4 bytes) = 48 83 c1 40
0431h cmp r8d,0                     ; CMP(Cmp_rm32_imm8) [R8D,0h:imm32]                    encoding(4 bytes) = 41 83 f8 00
0435h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 83 01 00 00
043bh mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 44 8b 09
043eh cmp r8d,1                     ; CMP(Cmp_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 f8 01
0442h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 76 01 00 00
0448h mov r10d,[rcx+4]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 04
044ch shl r10d,1                    ; SHL(Shl_rm32_1) [R10D,1h:imm8]                       encoding(3 bytes) = 41 d1 e2
044fh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0452h cmp r8d,2                     ; CMP(Cmp_rm32_imm8) [R8D,2h:imm32]                    encoding(4 bytes) = 41 83 f8 02
0456h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 62 01 00 00
045ch mov r10d,[rcx+8]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 08
0460h shl r10d,2                    ; SHL(Shl_rm32_imm8) [R10D,2h:imm8]                    encoding(4 bytes) = 41 c1 e2 02
0464h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0467h cmp r8d,3                     ; CMP(Cmp_rm32_imm8) [R8D,3h:imm32]                    encoding(4 bytes) = 41 83 f8 03
046bh jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 4d 01 00 00
0471h mov r10d,[rcx+0Ch]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 0c
0475h shl r10d,3                    ; SHL(Shl_rm32_imm8) [R10D,3h:imm8]                    encoding(4 bytes) = 41 c1 e2 03
0479h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
047ch cmp r8d,4                     ; CMP(Cmp_rm32_imm8) [R8D,4h:imm32]                    encoding(4 bytes) = 41 83 f8 04
0480h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 38 01 00 00
0486h mov r10d,[rcx+10h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 10
048ah shl r10d,4                    ; SHL(Shl_rm32_imm8) [R10D,4h:imm8]                    encoding(4 bytes) = 41 c1 e2 04
048eh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0491h cmp r8d,5                     ; CMP(Cmp_rm32_imm8) [R8D,5h:imm32]                    encoding(4 bytes) = 41 83 f8 05
0495h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 23 01 00 00
049bh mov r10d,[rcx+14h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 14
049fh shl r10d,5                    ; SHL(Shl_rm32_imm8) [R10D,5h:imm8]                    encoding(4 bytes) = 41 c1 e2 05
04a3h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
04a6h cmp r8d,6                     ; CMP(Cmp_rm32_imm8) [R8D,6h:imm32]                    encoding(4 bytes) = 41 83 f8 06
04aah jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 0e 01 00 00
04b0h mov r10d,[rcx+18h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 18
04b4h shl r10d,6                    ; SHL(Shl_rm32_imm8) [R10D,6h:imm8]                    encoding(4 bytes) = 41 c1 e2 06
04b8h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
04bbh cmp r8d,7                     ; CMP(Cmp_rm32_imm8) [R8D,7h:imm32]                    encoding(4 bytes) = 41 83 f8 07
04bfh jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 f9 00 00 00
04c5h mov r10d,[rcx+1Ch]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 1c
04c9h shl r10d,7                    ; SHL(Shl_rm32_imm8) [R10D,7h:imm8]                    encoding(4 bytes) = 41 c1 e2 07
04cdh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
04d0h cmp r8d,8                     ; CMP(Cmp_rm32_imm8) [R8D,8h:imm32]                    encoding(4 bytes) = 41 83 f8 08
04d4h jb near ptr 05b8h             ; JB(Jb_rel32_64) [5B8h:jmp64]                         encoding(6 bytes) = 0f 82 de 00 00 00
04dah add r8d,0FFFFFFF8h            ; ADD(Add_rm32_imm8) [R8D,fffffffffffffff8h:imm32]     encoding(4 bytes) = 41 83 c0 f8
04deh add rcx,20h                   ; ADD(Add_rm64_imm8) [RCX,20h:imm64]                   encoding(4 bytes) = 48 83 c1 20
04e2h cmp r8d,0                     ; CMP(Cmp_rm32_imm8) [R8D,0h:imm32]                    encoding(4 bytes) = 41 83 f8 00
04e6h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 d2 00 00 00
04ech mov r10d,[rcx]                ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(3 bytes) = 44 8b 11
04efh cmp r8d,1                     ; CMP(Cmp_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 f8 01
04f3h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 c5 00 00 00
04f9h mov r11d,[rcx+4]              ; MOV(Mov_r32_rm32) [R11D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 59 04
04fdh shl r11d,1                    ; SHL(Shl_rm32_1) [R11D,1h:imm8]                       encoding(3 bytes) = 41 d1 e3
0500h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0503h cmp r8d,2                     ; CMP(Cmp_rm32_imm8) [R8D,2h:imm32]                    encoding(4 bytes) = 41 83 f8 02
0507h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 b1 00 00 00
050dh mov r11d,[rcx+8]              ; MOV(Mov_r32_rm32) [R11D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 59 08
0511h shl r11d,2                    ; SHL(Shl_rm32_imm8) [R11D,2h:imm8]                    encoding(4 bytes) = 41 c1 e3 02
0515h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0518h cmp r8d,3                     ; CMP(Cmp_rm32_imm8) [R8D,3h:imm32]                    encoding(4 bytes) = 41 83 f8 03
051ch jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 9c 00 00 00
0522h mov r11d,[rcx+0Ch]            ; MOV(Mov_r32_rm32) [R11D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 59 0c
0526h shl r11d,3                    ; SHL(Shl_rm32_imm8) [R11D,3h:imm8]                    encoding(4 bytes) = 41 c1 e3 03
052ah or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
052dh cmp r8d,4                     ; CMP(Cmp_rm32_imm8) [R8D,4h:imm32]                    encoding(4 bytes) = 41 83 f8 04
0531h jbe near ptr 05beh            ; JBE(Jbe_rel32_64) [5BEh:jmp64]                       encoding(6 bytes) = 0f 86 87 00 00 00
0537h mov r11d,[rcx+10h]            ; MOV(Mov_r32_rm32) [R11D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 59 10
053bh shl r11d,4                    ; SHL(Shl_rm32_imm8) [R11D,4h:imm8]                    encoding(4 bytes) = 41 c1 e3 04
053fh or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0542h cmp r8d,5                     ; CMP(Cmp_rm32_imm8) [R8D,5h:imm32]                    encoding(4 bytes) = 41 83 f8 05
0546h jbe short 05beh               ; JBE(Jbe_rel8_64) [5BEh:jmp64]                        encoding(2 bytes) = 76 76
0548h mov r11d,[rcx+14h]            ; MOV(Mov_r32_rm32) [R11D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 59 14
054ch shl r11d,5                    ; SHL(Shl_rm32_imm8) [R11D,5h:imm8]                    encoding(4 bytes) = 41 c1 e3 05
0550h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0553h cmp r8d,6                     ; CMP(Cmp_rm32_imm8) [R8D,6h:imm32]                    encoding(4 bytes) = 41 83 f8 06
0557h jbe short 05beh               ; JBE(Jbe_rel8_64) [5BEh:jmp64]                        encoding(2 bytes) = 76 65
0559h mov r11d,[rcx+18h]            ; MOV(Mov_r32_rm32) [R11D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 59 18
055dh shl r11d,6                    ; SHL(Shl_rm32_imm8) [R11D,6h:imm8]                    encoding(4 bytes) = 41 c1 e3 06
0561h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0564h cmp r8d,7                     ; CMP(Cmp_rm32_imm8) [R8D,7h:imm32]                    encoding(4 bytes) = 41 83 f8 07
0568h jbe short 05beh               ; JBE(Jbe_rel8_64) [5BEh:jmp64]                        encoding(2 bytes) = 76 54
056ah mov ecx,[rcx+1Ch]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 1c
056dh shl ecx,7                     ; SHL(Shl_rm32_imm8) [ECX,7h:imm8]                     encoding(3 bytes) = c1 e1 07
0570h or r10d,ecx                   ; OR(Or_r32_rm32) [R10D,ECX]                           encoding(3 bytes) = 44 0b d1
0573h mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
0576h shl rcx,8                     ; SHL(Shl_rm64_imm8) [RCX,8h:imm8]                     encoding(4 bytes) = 48 c1 e1 08
057ah or r9,rcx                     ; OR(Or_r64_rm64) [R9,RCX]                             encoding(3 bytes) = 4c 0b c9
057dh mov rcx,r9                    ; MOV(Mov_r64_rm64) [RCX,R9]                           encoding(3 bytes) = 49 8b c9
0580h shl rcx,10h                   ; SHL(Shl_rm64_imm8) [RCX,10h:imm8]                    encoding(4 bytes) = 48 c1 e1 10
0584h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0587h shl rdx,20h                   ; SHL(Shl_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 e2 20
058bh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
058eh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0592h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0593h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0594h call 7FFDCFDE01D8h            ; CALL(Call_rel32_64) [FFFFFFFFFF9450E8h:jmp64]        encoding(5 bytes) = e8 4f 4b 94 ff
0599h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
059ah call 7FFDCFDE01D8h            ; CALL(Call_rel32_64) [FFFFFFFFFF9450E8h:jmp64]        encoding(5 bytes) = e8 49 4b 94 ff
059fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
05a0h call 7FFDCFDE01D8h            ; CALL(Call_rel32_64) [FFFFFFFFFF9450E8h:jmp64]        encoding(5 bytes) = e8 43 4b 94 ff
05a5h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
05a6h call 7FFDCFDE01D8h            ; CALL(Call_rel32_64) [FFFFFFFFFF9450E8h:jmp64]        encoding(5 bytes) = e8 3d 4b 94 ff
05abh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
05ach call 7FFDCFDE01D8h            ; CALL(Call_rel32_64) [FFFFFFFFFF9450E8h:jmp64]        encoding(5 bytes) = e8 37 4b 94 ff
05b1h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
05b2h call 7FFDCFDE01D8h            ; CALL(Call_rel32_64) [FFFFFFFFFF9450E8h:jmp64]        encoding(5 bytes) = e8 31 4b 94 ff
05b7h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
05b8h call 7FFDCFDE01D8h            ; CALL(Call_rel32_64) [FFFFFFFFFF9450E8h:jmp64]        encoding(5 bytes) = e8 2b 4b 94 ff
05bdh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
05beh call 7FFE2FA0EF00h            ; CALL(Call_rel32_64) [5F573E10h:jmp64]                encoding(5 bytes) = e8 4d 38 57 5f
05c3h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> pack64gBytes => new byte[1476]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0x01,0x8B,0x51,0x08,0x48,0x8B,0xC8,0x44,0x8B,0xC2,0x83,0xFA,0x00,0x0F,0x86,0xA4,0x05,0x00,0x00,0x44,0x8B,0x08,0x83,0xFA,0x01,0x0F,0x86,0x98,0x05,0x00,0x00,0x44,0x8B,0x50,0x04,0x41,0xD1,0xE2,0x45,0x0B,0xCA,0x83,0xFA,0x02,0x0F,0x86,0x85,0x05,0x00,0x00,0x44,0x8B,0x50,0x08,0x41,0xC1,0xE2,0x02,0x45,0x0B,0xCA,0x83,0xFA,0x03,0x0F,0x86,0x71,0x05,0x00,0x00,0x44,0x8B,0x50,0x0C,0x41,0xC1,0xE2,0x03,0x45,0x0B,0xCA,0x83,0xFA,0x04,0x0F,0x86,0x5D,0x05,0x00,0x00,0x44,0x8B,0x50,0x10,0x41,0xC1,0xE2,0x04,0x45,0x0B,0xCA,0x83,0xFA,0x05,0x0F,0x86,0x49,0x05,0x00,0x00,0x44,0x8B,0x50,0x14,0x41,0xC1,0xE2,0x05,0x45,0x0B,0xCA,0x83,0xFA,0x06,0x0F,0x86,0x35,0x05,0x00,0x00,0x8B,0x40,0x18,0xC1,0xE0,0x06,0x44,0x0B,0xC8,0x41,0x83,0xF8,0x07,0x0F,0x86,0x22,0x05,0x00,0x00,0x8B,0x41,0x1C,0xC1,0xE0,0x07,0x44,0x0B,0xC8,0x41,0x8B,0xC1,0x41,0x83,0xF8,0x08,0x0F,0x82,0xE2,0x04,0x00,0x00,0x41,0x8D,0x50,0xF8,0x4C,0x8D,0x49,0x20,0x83,0xFA,0x00,0x0F,0x86,0xFB,0x04,0x00,0x00,0x45,0x8B,0x11,0x83,0xFA,0x01,0x0F,0x86,0xEF,0x04,0x00,0x00,0x45,0x8B,0x59,0x04,0x41,0xD1,0xE3,0x45,0x0B,0xD3,0x83,0xFA,0x02,0x0F,0x86,0xDC,0x04,0x00,0x00,0x45,0x8B,0x59,0x08,0x41,0xC1,0xE3,0x02,0x45,0x0B,0xD3,0x83,0xFA,0x03,0x0F,0x86,0xC8,0x04,0x00,0x00,0x45,0x8B,0x59,0x0C,0x41,0xC1,0xE3,0x03,0x45,0x0B,0xD3,0x83,0xFA,0x04,0x0F,0x86,0xB4,0x04,0x00,0x00,0x45,0x8B,0x59,0x10,0x41,0xC1,0xE3,0x04,0x45,0x0B,0xD3,0x83,0xFA,0x05,0x0F,0x86,0xA0,0x04,0x00,0x00,0x45,0x8B,0x59,0x14,0x41,0xC1,0xE3,0x05,0x45,0x0B,0xD3,0x83,0xFA,0x06,0x0F,0x86,0x8C,0x04,0x00,0x00,0x45,0x8B,0x59,0x18,0x41,0xC1,0xE3,0x06,0x45,0x0B,0xD3,0x83,0xFA,0x07,0x0F,0x86,0x78,0x04,0x00,0x00,0x41,0x8B,0x51,0x1C,0xC1,0xE2,0x07,0x44,0x0B,0xD2,0x41,0x8B,0xD2,0x48,0xC1,0xE2,0x08,0x48,0x0B,0xC2,0x41,0x83,0xF8,0x10,0x0F,0x82,0x36,0x04,0x00,0x00,0x41,0x8D,0x50,0xF0,0x4C,0x8D,0x49,0x40,0x83,0xFA,0x00,0x0F,0x86,0x49,0x04,0x00,0x00,0x45,0x8B,0x11,0x83,0xFA,0x01,0x0F,0x86,0x3D,0x04,0x00,0x00,0x45,0x8B,0x59,0x04,0x41,0xD1,0xE3,0x45,0x0B,0xD3,0x83,0xFA,0x02,0x0F,0x86,0x2A,0x04,0x00,0x00,0x45,0x8B,0x59,0x08,0x41,0xC1,0xE3,0x02,0x45,0x0B,0xD3,0x83,0xFA,0x03,0x0F,0x86,0x16,0x04,0x00,0x00,0x45,0x8B,0x59,0x0C,0x41,0xC1,0xE3,0x03,0x45,0x0B,0xD3,0x83,0xFA,0x04,0x0F,0x86,0x02,0x04,0x00,0x00,0x45,0x8B,0x59,0x10,0x41,0xC1,0xE3,0x04,0x45,0x0B,0xD3,0x83,0xFA,0x05,0x0F,0x86,0xEE,0x03,0x00,0x00,0x45,0x8B,0x59,0x14,0x41,0xC1,0xE3,0x05,0x45,0x0B,0xD3,0x83,0xFA,0x06,0x0F,0x86,0xDA,0x03,0x00,0x00,0x45,0x8B,0x59,0x18,0x41,0xC1,0xE3,0x06,0x45,0x0B,0xD3,0x83,0xFA,0x07,0x0F,0x86,0xC6,0x03,0x00,0x00,0x45,0x8B,0x59,0x1C,0x41,0xC1,0xE3,0x07,0x45,0x0B,0xD3,0x83,0xFA,0x08,0x0F,0x82,0x94,0x03,0x00,0x00,0x83,0xC2,0xF8,0x49,0x83,0xC1,0x20,0x83,0xFA,0x00,0x0F,0x86,0xA2,0x03,0x00,0x00,0x45,0x8B,0x19,0x83,0xFA,0x01,0x0F,0x86,0x96,0x03,0x00,0x00,0x41,0x8B,0x71,0x04,0xD1,0xE6,0x44,0x0B,0xDE,0x83,0xFA,0x02,0x0F,0x86,0x84,0x03,0x00,0x00,0x41,0x8B,0x71,0x08,0xC1,0xE6,0x02,0x44,0x0B,0xDE,0x83,0xFA,0x03,0x0F,0x86,0x71,0x03,0x00,0x00,0x41,0x8B,0x71,0x0C,0xC1,0xE6,0x03,0x44,0x0B,0xDE,0x83,0xFA,0x04,0x0F,0x86,0x5E,0x03,0x00,0x00,0x41,0x8B,0x71,0x10,0xC1,0xE6,0x04,0x44,0x0B,0xDE,0x83,0xFA,0x05,0x0F,0x86,0x4B,0x03,0x00,0x00,0x41,0x8B,0x71,0x14,0xC1,0xE6,0x05,0x44,0x0B,0xDE,0x83,0xFA,0x06,0x0F,0x86,0x38,0x03,0x00,0x00,0x41,0x8B,0x71,0x18,0xC1,0xE6,0x06,0x44,0x0B,0xDE,0x83,0xFA,0x07,0x0F,0x86,0x25,0x03,0x00,0x00,0x41,0x8B,0x51,0x1C,0xC1,0xE2,0x07,0x44,0x0B,0xDA,0x41,0x8B,0xD3,0x48,0xC1,0xE2,0x08,0x4C,0x0B,0xD2,0x49,0x8B,0xD2,0x48,0xC1,0xE2,0x10,0x48,0x0B,0xC2,0x41,0x83,0xF8,0x20,0x0F,0x82,0xE5,0x02,0x00,0x00,0x41,0x83,0xC0,0xE0,0x48,0x81,0xC1,0x80,0x00,0x00,0x00,0x41,0x83,0xF8,0x00,0x0F,0x86,0xE8,0x02,0x00,0x00,0x8B,0x11,0x41,0x83,0xF8,0x01,0x0F,0x86,0xDC,0x02,0x00,0x00,0x44,0x8B,0x49,0x04,0x41,0xD1,0xE1,0x41,0x0B,0xD1,0x41,0x83,0xF8,0x02,0x0F,0x86,0xC8,0x02,0x00,0x00,0x44,0x8B,0x49,0x08,0x41,0xC1,0xE1,0x02,0x41,0x0B,0xD1,0x41,0x83,0xF8,0x03,0x0F,0x86,0xB3,0x02,0x00,0x00,0x44,0x8B,0x49,0x0C,0x41,0xC1,0xE1,0x03,0x41,0x0B,0xD1,0x41,0x83,0xF8,0x04,0x0F,0x86,0x9E,0x02,0x00,0x00,0x44,0x8B,0x49,0x10,0x41,0xC1,0xE1,0x04,0x41,0x0B,0xD1,0x41,0x83,0xF8,0x05,0x0F,0x86,0x89,0x02,0x00,0x00,0x44,0x8B,0x49,0x14,0x41,0xC1,0xE1,0x05,0x41,0x0B,0xD1,0x41,0x83,0xF8,0x06,0x0F,0x86,0x74,0x02,0x00,0x00,0x44,0x8B,0x49,0x18,0x41,0xC1,0xE1,0x06,0x41,0x0B,0xD1,0x41,0x83,0xF8,0x07,0x0F,0x86,0x5F,0x02,0x00,0x00,0x44,0x8B,0x49,0x1C,0x41,0xC1,0xE1,0x07,0x41,0x0B,0xD1,0x41,0x83,0xF8,0x08,0x0F,0x82,0x38,0x02,0x00,0x00,0x45,0x8D,0x48,0xF8,0x4C,0x8D,0x51,0x20,0x41,0x83,0xF9,0x00,0x0F,0x86,0x38,0x02,0x00,0x00,0x45,0x8B,0x1A,0x41,0x83,0xF9,0x01,0x0F,0x86,0x2B,0x02,0x00,0x00,0x41,0x8B,0x72,0x04,0xD1,0xE6,0x44,0x0B,0xDE,0x41,0x83,0xF9,0x02,0x0F,0x86,0x18,0x02,0x00,0x00,0x41,0x8B,0x72,0x08,0xC1,0xE6,0x02,0x44,0x0B,0xDE,0x41,0x83,0xF9,0x03,0x0F,0x86,0x04,0x02,0x00,0x00,0x41,0x8B,0x72,0x0C,0xC1,0xE6,0x03,0x44,0x0B,0xDE,0x41,0x83,0xF9,0x04,0x0F,0x86,0xF0,0x01,0x00,0x00,0x41,0x8B,0x72,0x10,0xC1,0xE6,0x04,0x44,0x0B,0xDE,0x41,0x83,0xF9,0x05,0x0F,0x86,0xDC,0x01,0x00,0x00,0x41,0x8B,0x72,0x14,0xC1,0xE6,0x05,0x44,0x0B,0xDE,0x41,0x83,0xF9,0x06,0x0F,0x86,0xC8,0x01,0x00,0x00,0x41,0x8B,0x72,0x18,0xC1,0xE6,0x06,0x44,0x0B,0xDE,0x41,0x83,0xF9,0x07,0x0F,0x86,0xB4,0x01,0x00,0x00,0x45,0x8B,0x4A,0x1C,0x41,0xC1,0xE1,0x07,0x45,0x0B,0xD9,0x45,0x8B,0xCB,0x49,0xC1,0xE1,0x08,0x49,0x0B,0xD1,0x41,0x83,0xF8,0x10,0x0F,0x82,0x89,0x01,0x00,0x00,0x41,0x83,0xC0,0xF0,0x48,0x83,0xC1,0x40,0x41,0x83,0xF8,0x00,0x0F,0x86,0x83,0x01,0x00,0x00,0x44,0x8B,0x09,0x41,0x83,0xF8,0x01,0x0F,0x86,0x76,0x01,0x00,0x00,0x44,0x8B,0x51,0x04,0x41,0xD1,0xE2,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x02,0x0F,0x86,0x62,0x01,0x00,0x00,0x44,0x8B,0x51,0x08,0x41,0xC1,0xE2,0x02,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x03,0x0F,0x86,0x4D,0x01,0x00,0x00,0x44,0x8B,0x51,0x0C,0x41,0xC1,0xE2,0x03,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x04,0x0F,0x86,0x38,0x01,0x00,0x00,0x44,0x8B,0x51,0x10,0x41,0xC1,0xE2,0x04,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x05,0x0F,0x86,0x23,0x01,0x00,0x00,0x44,0x8B,0x51,0x14,0x41,0xC1,0xE2,0x05,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x06,0x0F,0x86,0x0E,0x01,0x00,0x00,0x44,0x8B,0x51,0x18,0x41,0xC1,0xE2,0x06,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x07,0x0F,0x86,0xF9,0x00,0x00,0x00,0x44,0x8B,0x51,0x1C,0x41,0xC1,0xE2,0x07,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x08,0x0F,0x82,0xDE,0x00,0x00,0x00,0x41,0x83,0xC0,0xF8,0x48,0x83,0xC1,0x20,0x41,0x83,0xF8,0x00,0x0F,0x86,0xD2,0x00,0x00,0x00,0x44,0x8B,0x11,0x41,0x83,0xF8,0x01,0x0F,0x86,0xC5,0x00,0x00,0x00,0x44,0x8B,0x59,0x04,0x41,0xD1,0xE3,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x02,0x0F,0x86,0xB1,0x00,0x00,0x00,0x44,0x8B,0x59,0x08,0x41,0xC1,0xE3,0x02,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x03,0x0F,0x86,0x9C,0x00,0x00,0x00,0x44,0x8B,0x59,0x0C,0x41,0xC1,0xE3,0x03,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x04,0x0F,0x86,0x87,0x00,0x00,0x00,0x44,0x8B,0x59,0x10,0x41,0xC1,0xE3,0x04,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x05,0x76,0x76,0x44,0x8B,0x59,0x14,0x41,0xC1,0xE3,0x05,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x06,0x76,0x65,0x44,0x8B,0x59,0x18,0x41,0xC1,0xE3,0x06,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x07,0x76,0x54,0x8B,0x49,0x1C,0xC1,0xE1,0x07,0x44,0x0B,0xD1,0x41,0x8B,0xCA,0x48,0xC1,0xE1,0x08,0x4C,0x0B,0xC9,0x49,0x8B,0xC9,0x48,0xC1,0xE1,0x10,0x48,0x0B,0xD1,0x48,0xC1,0xE2,0x20,0x48,0x0B,0xC2,0x48,0x83,0xC4,0x20,0x5E,0xC3,0xE8,0x4F,0x4B,0x94,0xFF,0xCC,0xE8,0x49,0x4B,0x94,0xFF,0xCC,0xE8,0x43,0x4B,0x94,0xFF,0xCC,0xE8,0x3D,0x4B,0x94,0xFF,0xCC,0xE8,0x37,0x4B,0x94,0xFF,0xCC,0xE8,0x31,0x4B,0x94,0xFF,0xCC,0xE8,0x2B,0x4B,0x94,0xFF,0xCC,0xE8,0x4D,0x38,0x57,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pack64(Span<bit> src)
; location: [7FFDD049B6D0h, 7FFDD049BC9Dh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov edx,[rcx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 51 08
000bh mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
000eh mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0011h cmp r8d,0                     ; CMP(Cmp_rm32_imm8) [R8D,0h:imm32]                    encoding(4 bytes) = 41 83 f8 00
0015h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 ad 05 00 00
001bh mov r9d,[rcx]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 44 8b 09
001eh cmp r8d,1                     ; CMP(Cmp_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 f8 01
0022h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 a0 05 00 00
0028h mov r10d,[rcx+4]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 04
002ch shl r10d,1                    ; SHL(Shl_rm32_1) [R10D,1h:imm8]                       encoding(3 bytes) = 41 d1 e2
002fh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0032h cmp r8d,2                     ; CMP(Cmp_rm32_imm8) [R8D,2h:imm32]                    encoding(4 bytes) = 41 83 f8 02
0036h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 8c 05 00 00
003ch mov r10d,[rcx+8]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 08
0040h shl r10d,2                    ; SHL(Shl_rm32_imm8) [R10D,2h:imm8]                    encoding(4 bytes) = 41 c1 e2 02
0044h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0047h cmp r8d,3                     ; CMP(Cmp_rm32_imm8) [R8D,3h:imm32]                    encoding(4 bytes) = 41 83 f8 03
004bh jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 77 05 00 00
0051h mov r10d,[rcx+0Ch]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 0c
0055h shl r10d,3                    ; SHL(Shl_rm32_imm8) [R10D,3h:imm8]                    encoding(4 bytes) = 41 c1 e2 03
0059h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
005ch cmp r8d,4                     ; CMP(Cmp_rm32_imm8) [R8D,4h:imm32]                    encoding(4 bytes) = 41 83 f8 04
0060h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 62 05 00 00
0066h mov r10d,[rcx+10h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 10
006ah shl r10d,4                    ; SHL(Shl_rm32_imm8) [R10D,4h:imm8]                    encoding(4 bytes) = 41 c1 e2 04
006eh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0071h cmp r8d,5                     ; CMP(Cmp_rm32_imm8) [R8D,5h:imm32]                    encoding(4 bytes) = 41 83 f8 05
0075h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 4d 05 00 00
007bh mov r10d,[rcx+14h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 14
007fh shl r10d,5                    ; SHL(Shl_rm32_imm8) [R10D,5h:imm8]                    encoding(4 bytes) = 41 c1 e2 05
0083h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0086h cmp r8d,6                     ; CMP(Cmp_rm32_imm8) [R8D,6h:imm32]                    encoding(4 bytes) = 41 83 f8 06
008ah jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 38 05 00 00
0090h mov r10d,[rcx+18h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RCX:br,DS:sr)]       encoding(4 bytes) = 44 8b 51 18
0094h shl r10d,6                    ; SHL(Shl_rm32_imm8) [R10D,6h:imm8]                    encoding(4 bytes) = 41 c1 e2 06
0098h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
009bh cmp r8d,7                     ; CMP(Cmp_rm32_imm8) [R8D,7h:imm32]                    encoding(4 bytes) = 41 83 f8 07
009fh jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 23 05 00 00
00a5h mov ecx,[rcx+1Ch]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 49 1c
00a8h shl ecx,7                     ; SHL(Shl_rm32_imm8) [ECX,7h:imm8]                     encoding(3 bytes) = c1 e1 07
00abh or r9d,ecx                    ; OR(Or_r32_rm32) [R9D,ECX]                            encoding(3 bytes) = 44 0b c9
00aeh mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
00b1h cmp edx,8                     ; CMP(Cmp_rm32_imm8) [EDX,8h:imm32]                    encoding(3 bytes) = 83 fa 08
00b4h jb near ptr 059eh             ; JB(Jb_rel32_64) [59Eh:jmp64]                         encoding(6 bytes) = 0f 82 e4 04 00 00
00bah lea r8d,[rdx-8]               ; LEA(Lea_r32_m) [R8D,mem(Unknown,RDX:br,DS:sr)]       encoding(4 bytes) = 44 8d 42 f8
00beh lea r9,[rax+20h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 48 20
00c2h cmp r8d,0                     ; CMP(Cmp_rm32_imm8) [R8D,0h:imm32]                    encoding(4 bytes) = 41 83 f8 00
00c6h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 fc 04 00 00
00cch mov r10d,[r9]                 ; MOV(Mov_r32_rm32) [R10D,mem(32u,R9:br,DS:sr)]        encoding(3 bytes) = 45 8b 11
00cfh cmp r8d,1                     ; CMP(Cmp_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 f8 01
00d3h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 ef 04 00 00
00d9h mov r11d,[r9+4]               ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 04
00ddh shl r11d,1                    ; SHL(Shl_rm32_1) [R11D,1h:imm8]                       encoding(3 bytes) = 41 d1 e3
00e0h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
00e3h cmp r8d,2                     ; CMP(Cmp_rm32_imm8) [R8D,2h:imm32]                    encoding(4 bytes) = 41 83 f8 02
00e7h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 db 04 00 00
00edh mov r11d,[r9+8]               ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 08
00f1h shl r11d,2                    ; SHL(Shl_rm32_imm8) [R11D,2h:imm8]                    encoding(4 bytes) = 41 c1 e3 02
00f5h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
00f8h cmp r8d,3                     ; CMP(Cmp_rm32_imm8) [R8D,3h:imm32]                    encoding(4 bytes) = 41 83 f8 03
00fch jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 c6 04 00 00
0102h mov r11d,[r9+0Ch]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 0c
0106h shl r11d,3                    ; SHL(Shl_rm32_imm8) [R11D,3h:imm8]                    encoding(4 bytes) = 41 c1 e3 03
010ah or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
010dh cmp r8d,4                     ; CMP(Cmp_rm32_imm8) [R8D,4h:imm32]                    encoding(4 bytes) = 41 83 f8 04
0111h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 b1 04 00 00
0117h mov r11d,[r9+10h]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 10
011bh shl r11d,4                    ; SHL(Shl_rm32_imm8) [R11D,4h:imm8]                    encoding(4 bytes) = 41 c1 e3 04
011fh or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0122h cmp r8d,5                     ; CMP(Cmp_rm32_imm8) [R8D,5h:imm32]                    encoding(4 bytes) = 41 83 f8 05
0126h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 9c 04 00 00
012ch mov r11d,[r9+14h]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 14
0130h shl r11d,5                    ; SHL(Shl_rm32_imm8) [R11D,5h:imm8]                    encoding(4 bytes) = 41 c1 e3 05
0134h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0137h cmp r8d,6                     ; CMP(Cmp_rm32_imm8) [R8D,6h:imm32]                    encoding(4 bytes) = 41 83 f8 06
013bh jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 87 04 00 00
0141h mov r11d,[r9+18h]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 18
0145h shl r11d,6                    ; SHL(Shl_rm32_imm8) [R11D,6h:imm8]                    encoding(4 bytes) = 41 c1 e3 06
0149h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
014ch cmp r8d,7                     ; CMP(Cmp_rm32_imm8) [R8D,7h:imm32]                    encoding(4 bytes) = 41 83 f8 07
0150h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 72 04 00 00
0156h mov r8d,[r9+1Ch]              ; MOV(Mov_r32_rm32) [R8D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 41 1c
015ah shl r8d,7                     ; SHL(Shl_rm32_imm8) [R8D,7h:imm8]                     encoding(4 bytes) = 41 c1 e0 07
015eh or r10d,r8d                   ; OR(Or_r32_rm32) [R10D,R8D]                           encoding(3 bytes) = 45 0b d0
0161h mov r8d,r10d                  ; MOV(Mov_r32_rm32) [R8D,R10D]                         encoding(3 bytes) = 45 8b c2
0164h shl r8,8                      ; SHL(Shl_rm64_imm8) [R8,8h:imm8]                      encoding(4 bytes) = 49 c1 e0 08
0168h or rcx,r8                     ; OR(Or_r64_rm64) [RCX,R8]                             encoding(3 bytes) = 49 0b c8
016bh cmp edx,10h                   ; CMP(Cmp_rm32_imm8) [EDX,10h:imm32]                   encoding(3 bytes) = 83 fa 10
016eh jb near ptr 05a4h             ; JB(Jb_rel32_64) [5A4h:jmp64]                         encoding(6 bytes) = 0f 82 30 04 00 00
0174h lea r8d,[rdx-10h]             ; LEA(Lea_r32_m) [R8D,mem(Unknown,RDX:br,DS:sr)]       encoding(4 bytes) = 44 8d 42 f0
0178h lea r9,[rax+40h]              ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,DS:sr)]        encoding(4 bytes) = 4c 8d 48 40
017ch cmp r8d,0                     ; CMP(Cmp_rm32_imm8) [R8D,0h:imm32]                    encoding(4 bytes) = 41 83 f8 00
0180h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 42 04 00 00
0186h mov r10d,[r9]                 ; MOV(Mov_r32_rm32) [R10D,mem(32u,R9:br,DS:sr)]        encoding(3 bytes) = 45 8b 11
0189h cmp r8d,1                     ; CMP(Cmp_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 f8 01
018dh jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 35 04 00 00
0193h mov r11d,[r9+4]               ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 04
0197h shl r11d,1                    ; SHL(Shl_rm32_1) [R11D,1h:imm8]                       encoding(3 bytes) = 41 d1 e3
019ah or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
019dh cmp r8d,2                     ; CMP(Cmp_rm32_imm8) [R8D,2h:imm32]                    encoding(4 bytes) = 41 83 f8 02
01a1h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 21 04 00 00
01a7h mov r11d,[r9+8]               ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 08
01abh shl r11d,2                    ; SHL(Shl_rm32_imm8) [R11D,2h:imm8]                    encoding(4 bytes) = 41 c1 e3 02
01afh or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
01b2h cmp r8d,3                     ; CMP(Cmp_rm32_imm8) [R8D,3h:imm32]                    encoding(4 bytes) = 41 83 f8 03
01b6h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 0c 04 00 00
01bch mov r11d,[r9+0Ch]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 0c
01c0h shl r11d,3                    ; SHL(Shl_rm32_imm8) [R11D,3h:imm8]                    encoding(4 bytes) = 41 c1 e3 03
01c4h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
01c7h cmp r8d,4                     ; CMP(Cmp_rm32_imm8) [R8D,4h:imm32]                    encoding(4 bytes) = 41 83 f8 04
01cbh jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 f7 03 00 00
01d1h mov r11d,[r9+10h]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 10
01d5h shl r11d,4                    ; SHL(Shl_rm32_imm8) [R11D,4h:imm8]                    encoding(4 bytes) = 41 c1 e3 04
01d9h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
01dch cmp r8d,5                     ; CMP(Cmp_rm32_imm8) [R8D,5h:imm32]                    encoding(4 bytes) = 41 83 f8 05
01e0h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 e2 03 00 00
01e6h mov r11d,[r9+14h]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 14
01eah shl r11d,5                    ; SHL(Shl_rm32_imm8) [R11D,5h:imm8]                    encoding(4 bytes) = 41 c1 e3 05
01eeh or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
01f1h cmp r8d,6                     ; CMP(Cmp_rm32_imm8) [R8D,6h:imm32]                    encoding(4 bytes) = 41 83 f8 06
01f5h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 cd 03 00 00
01fbh mov r11d,[r9+18h]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 18
01ffh shl r11d,6                    ; SHL(Shl_rm32_imm8) [R11D,6h:imm8]                    encoding(4 bytes) = 41 c1 e3 06
0203h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0206h cmp r8d,7                     ; CMP(Cmp_rm32_imm8) [R8D,7h:imm32]                    encoding(4 bytes) = 41 83 f8 07
020ah jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 b8 03 00 00
0210h mov r11d,[r9+1Ch]             ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(4 bytes) = 45 8b 59 1c
0214h shl r11d,7                    ; SHL(Shl_rm32_imm8) [R11D,7h:imm8]                    encoding(4 bytes) = 41 c1 e3 07
0218h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
021bh cmp r8d,8                     ; CMP(Cmp_rm32_imm8) [R8D,8h:imm32]                    encoding(4 bytes) = 41 83 f8 08
021fh jb near ptr 05aah             ; JB(Jb_rel32_64) [5AAh:jmp64]                         encoding(6 bytes) = 0f 82 85 03 00 00
0225h add r8d,0FFFFFFF8h            ; ADD(Add_rm32_imm8) [R8D,fffffffffffffff8h:imm32]     encoding(4 bytes) = 41 83 c0 f8
0229h add r9,20h                    ; ADD(Add_rm64_imm8) [R9,20h:imm64]                    encoding(4 bytes) = 49 83 c1 20
022dh cmp r8d,0                     ; CMP(Cmp_rm32_imm8) [R8D,0h:imm32]                    encoding(4 bytes) = 41 83 f8 00
0231h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 91 03 00 00
0237h mov r11d,[r9]                 ; MOV(Mov_r32_rm32) [R11D,mem(32u,R9:br,DS:sr)]        encoding(3 bytes) = 45 8b 19
023ah cmp r8d,1                     ; CMP(Cmp_rm32_imm8) [R8D,1h:imm32]                    encoding(4 bytes) = 41 83 f8 01
023eh jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 84 03 00 00
0244h mov esi,[r9+4]                ; MOV(Mov_r32_rm32) [ESI,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 41 8b 71 04
0248h shl esi,1                     ; SHL(Shl_rm32_1) [ESI,1h:imm8]                        encoding(2 bytes) = d1 e6
024ah or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
024dh cmp r8d,2                     ; CMP(Cmp_rm32_imm8) [R8D,2h:imm32]                    encoding(4 bytes) = 41 83 f8 02
0251h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 71 03 00 00
0257h mov esi,[r9+8]                ; MOV(Mov_r32_rm32) [ESI,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 41 8b 71 08
025bh shl esi,2                     ; SHL(Shl_rm32_imm8) [ESI,2h:imm8]                     encoding(3 bytes) = c1 e6 02
025eh or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
0261h cmp r8d,3                     ; CMP(Cmp_rm32_imm8) [R8D,3h:imm32]                    encoding(4 bytes) = 41 83 f8 03
0265h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 5d 03 00 00
026bh mov esi,[r9+0Ch]              ; MOV(Mov_r32_rm32) [ESI,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 41 8b 71 0c
026fh shl esi,3                     ; SHL(Shl_rm32_imm8) [ESI,3h:imm8]                     encoding(3 bytes) = c1 e6 03
0272h or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
0275h cmp r8d,4                     ; CMP(Cmp_rm32_imm8) [R8D,4h:imm32]                    encoding(4 bytes) = 41 83 f8 04
0279h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 49 03 00 00
027fh mov esi,[r9+10h]              ; MOV(Mov_r32_rm32) [ESI,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 41 8b 71 10
0283h shl esi,4                     ; SHL(Shl_rm32_imm8) [ESI,4h:imm8]                     encoding(3 bytes) = c1 e6 04
0286h or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
0289h cmp r8d,5                     ; CMP(Cmp_rm32_imm8) [R8D,5h:imm32]                    encoding(4 bytes) = 41 83 f8 05
028dh jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 35 03 00 00
0293h mov esi,[r9+14h]              ; MOV(Mov_r32_rm32) [ESI,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 41 8b 71 14
0297h shl esi,5                     ; SHL(Shl_rm32_imm8) [ESI,5h:imm8]                     encoding(3 bytes) = c1 e6 05
029ah or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
029dh cmp r8d,6                     ; CMP(Cmp_rm32_imm8) [R8D,6h:imm32]                    encoding(4 bytes) = 41 83 f8 06
02a1h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 21 03 00 00
02a7h mov esi,[r9+18h]              ; MOV(Mov_r32_rm32) [ESI,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 41 8b 71 18
02abh shl esi,6                     ; SHL(Shl_rm32_imm8) [ESI,6h:imm8]                     encoding(3 bytes) = c1 e6 06
02aeh or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
02b1h cmp r8d,7                     ; CMP(Cmp_rm32_imm8) [R8D,7h:imm32]                    encoding(4 bytes) = 41 83 f8 07
02b5h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 0d 03 00 00
02bbh mov r8d,[r9+1Ch]              ; MOV(Mov_r32_rm32) [R8D,mem(32u,R9:br,DS:sr)]         encoding(4 bytes) = 45 8b 41 1c
02bfh shl r8d,7                     ; SHL(Shl_rm32_imm8) [R8D,7h:imm8]                     encoding(4 bytes) = 41 c1 e0 07
02c3h or r11d,r8d                   ; OR(Or_r32_rm32) [R11D,R8D]                           encoding(3 bytes) = 45 0b d8
02c6h mov r8d,r11d                  ; MOV(Mov_r32_rm32) [R8D,R11D]                         encoding(3 bytes) = 45 8b c3
02c9h shl r8,8                      ; SHL(Shl_rm64_imm8) [R8,8h:imm8]                      encoding(4 bytes) = 49 c1 e0 08
02cdh or r10,r8                     ; OR(Or_r64_rm64) [R10,R8]                             encoding(3 bytes) = 4d 0b d0
02d0h mov r8,r10                    ; MOV(Mov_r64_rm64) [R8,R10]                           encoding(3 bytes) = 4d 8b c2
02d3h shl r8,10h                    ; SHL(Shl_rm64_imm8) [R8,10h:imm8]                     encoding(4 bytes) = 49 c1 e0 10
02d7h or rcx,r8                     ; OR(Or_r64_rm64) [RCX,R8]                             encoding(3 bytes) = 49 0b c8
02dah cmp edx,20h                   ; CMP(Cmp_rm32_imm8) [EDX,20h:imm32]                   encoding(3 bytes) = 83 fa 20
02ddh jb near ptr 05b0h             ; JB(Jb_rel32_64) [5B0h:jmp64]                         encoding(6 bytes) = 0f 82 cd 02 00 00
02e3h add edx,0FFFFFFE0h            ; ADD(Add_rm32_imm8) [EDX,ffffffffffffffe0h:imm32]     encoding(3 bytes) = 83 c2 e0
02e6h add rax,80h                   ; ADD(Add_RAX_imm32) [RAX,80h:imm64]                   encoding(6 bytes) = 48 05 80 00 00 00
02ech cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
02efh jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 d3 02 00 00
02f5h mov r8d,[rax]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 44 8b 00
02f8h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
02fbh jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 c7 02 00 00
0301h mov r9d,[rax+4]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 04
0305h shl r9d,1                     ; SHL(Shl_rm32_1) [R9D,1h:imm8]                        encoding(3 bytes) = 41 d1 e1
0308h or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
030bh cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
030eh jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 b4 02 00 00
0314h mov r9d,[rax+8]               ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 08
0318h shl r9d,2                     ; SHL(Shl_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e1 02
031ch or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
031fh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0322h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 a0 02 00 00
0328h mov r9d,[rax+0Ch]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 0c
032ch shl r9d,3                     ; SHL(Shl_rm32_imm8) [R9D,3h:imm8]                     encoding(4 bytes) = 41 c1 e1 03
0330h or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
0333h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
0336h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 8c 02 00 00
033ch mov r9d,[rax+10h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 10
0340h shl r9d,4                     ; SHL(Shl_rm32_imm8) [R9D,4h:imm8]                     encoding(4 bytes) = 41 c1 e1 04
0344h or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
0347h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
034ah jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 78 02 00 00
0350h mov r9d,[rax+14h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 14
0354h shl r9d,5                     ; SHL(Shl_rm32_imm8) [R9D,5h:imm8]                     encoding(4 bytes) = 41 c1 e1 05
0358h or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
035bh cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
035eh jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 64 02 00 00
0364h mov r9d,[rax+18h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 18
0368h shl r9d,6                     ; SHL(Shl_rm32_imm8) [R9D,6h:imm8]                     encoding(4 bytes) = 41 c1 e1 06
036ch or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
036fh cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
0372h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 50 02 00 00
0378h mov r9d,[rax+1Ch]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 48 1c
037ch shl r9d,7                     ; SHL(Shl_rm32_imm8) [R9D,7h:imm8]                     encoding(4 bytes) = 41 c1 e1 07
0380h or r8d,r9d                    ; OR(Or_r32_rm32) [R8D,R9D]                            encoding(3 bytes) = 45 0b c1
0383h cmp edx,8                     ; CMP(Cmp_rm32_imm8) [EDX,8h:imm32]                    encoding(3 bytes) = 83 fa 08
0386h jb near ptr 05b6h             ; JB(Jb_rel32_64) [5B6h:jmp64]                         encoding(6 bytes) = 0f 82 2a 02 00 00
038ch lea r9d,[rdx-8]               ; LEA(Lea_r32_m) [R9D,mem(Unknown,RDX:br,DS:sr)]       encoding(4 bytes) = 44 8d 4a f8
0390h lea r10,[rax+20h]             ; LEA(Lea_r64_m) [R10,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 4c 8d 50 20
0394h cmp r9d,0                     ; CMP(Cmp_rm32_imm8) [R9D,0h:imm32]                    encoding(4 bytes) = 41 83 f9 00
0398h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 2a 02 00 00
039eh mov r11d,[r10]                ; MOV(Mov_r32_rm32) [R11D,mem(32u,R10:br,DS:sr)]       encoding(3 bytes) = 45 8b 1a
03a1h cmp r9d,1                     ; CMP(Cmp_rm32_imm8) [R9D,1h:imm32]                    encoding(4 bytes) = 41 83 f9 01
03a5h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 1d 02 00 00
03abh mov esi,[r10+4]               ; MOV(Mov_r32_rm32) [ESI,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 41 8b 72 04
03afh shl esi,1                     ; SHL(Shl_rm32_1) [ESI,1h:imm8]                        encoding(2 bytes) = d1 e6
03b1h or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
03b4h cmp r9d,2                     ; CMP(Cmp_rm32_imm8) [R9D,2h:imm32]                    encoding(4 bytes) = 41 83 f9 02
03b8h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 0a 02 00 00
03beh mov esi,[r10+8]               ; MOV(Mov_r32_rm32) [ESI,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 41 8b 72 08
03c2h shl esi,2                     ; SHL(Shl_rm32_imm8) [ESI,2h:imm8]                     encoding(3 bytes) = c1 e6 02
03c5h or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
03c8h cmp r9d,3                     ; CMP(Cmp_rm32_imm8) [R9D,3h:imm32]                    encoding(4 bytes) = 41 83 f9 03
03cch jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 f6 01 00 00
03d2h mov esi,[r10+0Ch]             ; MOV(Mov_r32_rm32) [ESI,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 41 8b 72 0c
03d6h shl esi,3                     ; SHL(Shl_rm32_imm8) [ESI,3h:imm8]                     encoding(3 bytes) = c1 e6 03
03d9h or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
03dch cmp r9d,4                     ; CMP(Cmp_rm32_imm8) [R9D,4h:imm32]                    encoding(4 bytes) = 41 83 f9 04
03e0h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 e2 01 00 00
03e6h mov esi,[r10+10h]             ; MOV(Mov_r32_rm32) [ESI,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 41 8b 72 10
03eah shl esi,4                     ; SHL(Shl_rm32_imm8) [ESI,4h:imm8]                     encoding(3 bytes) = c1 e6 04
03edh or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
03f0h cmp r9d,5                     ; CMP(Cmp_rm32_imm8) [R9D,5h:imm32]                    encoding(4 bytes) = 41 83 f9 05
03f4h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 ce 01 00 00
03fah mov esi,[r10+14h]             ; MOV(Mov_r32_rm32) [ESI,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 41 8b 72 14
03feh shl esi,5                     ; SHL(Shl_rm32_imm8) [ESI,5h:imm8]                     encoding(3 bytes) = c1 e6 05
0401h or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
0404h cmp r9d,6                     ; CMP(Cmp_rm32_imm8) [R9D,6h:imm32]                    encoding(4 bytes) = 41 83 f9 06
0408h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 ba 01 00 00
040eh mov esi,[r10+18h]             ; MOV(Mov_r32_rm32) [ESI,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 41 8b 72 18
0412h shl esi,6                     ; SHL(Shl_rm32_imm8) [ESI,6h:imm8]                     encoding(3 bytes) = c1 e6 06
0415h or r11d,esi                   ; OR(Or_r32_rm32) [R11D,ESI]                           encoding(3 bytes) = 44 0b de
0418h cmp r9d,7                     ; CMP(Cmp_rm32_imm8) [R9D,7h:imm32]                    encoding(4 bytes) = 41 83 f9 07
041ch jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 a6 01 00 00
0422h mov r9d,[r10+1Ch]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,R10:br,DS:sr)]        encoding(4 bytes) = 45 8b 4a 1c
0426h shl r9d,7                     ; SHL(Shl_rm32_imm8) [R9D,7h:imm8]                     encoding(4 bytes) = 41 c1 e1 07
042ah or r11d,r9d                   ; OR(Or_r32_rm32) [R11D,R9D]                           encoding(3 bytes) = 45 0b d9
042dh mov r9d,r11d                  ; MOV(Mov_r32_rm32) [R9D,R11D]                         encoding(3 bytes) = 45 8b cb
0430h shl r9,8                      ; SHL(Shl_rm64_imm8) [R9,8h:imm8]                      encoding(4 bytes) = 49 c1 e1 08
0434h or r8,r9                      ; OR(Or_r64_rm64) [R8,R9]                              encoding(3 bytes) = 4d 0b c1
0437h cmp edx,10h                   ; CMP(Cmp_rm32_imm8) [EDX,10h:imm32]                   encoding(3 bytes) = 83 fa 10
043ah jb near ptr 05bch             ; JB(Jb_rel32_64) [5BCh:jmp64]                         encoding(6 bytes) = 0f 82 7c 01 00 00
0440h add edx,0FFFFFFF0h            ; ADD(Add_rm32_imm8) [EDX,fffffffffffffff0h:imm32]     encoding(3 bytes) = 83 c2 f0
0443h add rax,40h                   ; ADD(Add_rm64_imm8) [RAX,40h:imm64]                   encoding(4 bytes) = 48 83 c0 40
0447h cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
044ah jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 78 01 00 00
0450h mov r9d,[rax]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 44 8b 08
0453h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0456h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 6c 01 00 00
045ch mov r10d,[rax+4]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 04
0460h shl r10d,1                    ; SHL(Shl_rm32_1) [R10D,1h:imm8]                       encoding(3 bytes) = 41 d1 e2
0463h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
0466h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
0469h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 59 01 00 00
046fh mov r10d,[rax+8]              ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 08
0473h shl r10d,2                    ; SHL(Shl_rm32_imm8) [R10D,2h:imm8]                    encoding(4 bytes) = 41 c1 e2 02
0477h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
047ah cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
047dh jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 45 01 00 00
0483h mov r10d,[rax+0Ch]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 0c
0487h shl r10d,3                    ; SHL(Shl_rm32_imm8) [R10D,3h:imm8]                    encoding(4 bytes) = 41 c1 e2 03
048bh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
048eh cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
0491h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 31 01 00 00
0497h mov r10d,[rax+10h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 10
049bh shl r10d,4                    ; SHL(Shl_rm32_imm8) [R10D,4h:imm8]                    encoding(4 bytes) = 41 c1 e2 04
049fh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
04a2h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
04a5h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 1d 01 00 00
04abh mov r10d,[rax+14h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 14
04afh shl r10d,5                    ; SHL(Shl_rm32_imm8) [R10D,5h:imm8]                    encoding(4 bytes) = 41 c1 e2 05
04b3h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
04b6h cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
04b9h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 09 01 00 00
04bfh mov r10d,[rax+18h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 18
04c3h shl r10d,6                    ; SHL(Shl_rm32_imm8) [R10D,6h:imm8]                    encoding(4 bytes) = 41 c1 e2 06
04c7h or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
04cah cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
04cdh jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 f5 00 00 00
04d3h mov r10d,[rax+1Ch]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 50 1c
04d7h shl r10d,7                    ; SHL(Shl_rm32_imm8) [R10D,7h:imm8]                    encoding(4 bytes) = 41 c1 e2 07
04dbh or r9d,r10d                   ; OR(Or_r32_rm32) [R9D,R10D]                           encoding(3 bytes) = 45 0b ca
04deh cmp edx,8                     ; CMP(Cmp_rm32_imm8) [EDX,8h:imm32]                    encoding(3 bytes) = 83 fa 08
04e1h jb near ptr 05c2h             ; JB(Jb_rel32_64) [5C2h:jmp64]                         encoding(6 bytes) = 0f 82 db 00 00 00
04e7h add edx,0FFFFFFF8h            ; ADD(Add_rm32_imm8) [EDX,fffffffffffffff8h:imm32]     encoding(3 bytes) = 83 c2 f8
04eah add rax,20h                   ; ADD(Add_rm64_imm8) [RAX,20h:imm64]                   encoding(4 bytes) = 48 83 c0 20
04eeh cmp edx,0                     ; CMP(Cmp_rm32_imm8) [EDX,0h:imm32]                    encoding(3 bytes) = 83 fa 00
04f1h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 d1 00 00 00
04f7h mov r10d,[rax]                ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,DS:sr)]       encoding(3 bytes) = 44 8b 10
04fah cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
04fdh jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 c5 00 00 00
0503h mov r11d,[rax+4]              ; MOV(Mov_r32_rm32) [R11D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 58 04
0507h shl r11d,1                    ; SHL(Shl_rm32_1) [R11D,1h:imm8]                       encoding(3 bytes) = 41 d1 e3
050ah or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
050dh cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
0510h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 b2 00 00 00
0516h mov r11d,[rax+8]              ; MOV(Mov_r32_rm32) [R11D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 58 08
051ah shl r11d,2                    ; SHL(Shl_rm32_imm8) [R11D,2h:imm8]                    encoding(4 bytes) = 41 c1 e3 02
051eh or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0521h cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0524h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 9e 00 00 00
052ah mov r11d,[rax+0Ch]            ; MOV(Mov_r32_rm32) [R11D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 58 0c
052eh shl r11d,3                    ; SHL(Shl_rm32_imm8) [R11D,3h:imm8]                    encoding(4 bytes) = 41 c1 e3 03
0532h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0535h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
0538h jbe near ptr 05c8h            ; JBE(Jbe_rel32_64) [5C8h:jmp64]                       encoding(6 bytes) = 0f 86 8a 00 00 00
053eh mov r11d,[rax+10h]            ; MOV(Mov_r32_rm32) [R11D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 58 10
0542h shl r11d,4                    ; SHL(Shl_rm32_imm8) [R11D,4h:imm8]                    encoding(4 bytes) = 41 c1 e3 04
0546h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0549h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
054ch jbe short 05c8h               ; JBE(Jbe_rel8_64) [5C8h:jmp64]                        encoding(2 bytes) = 76 7a
054eh mov r11d,[rax+14h]            ; MOV(Mov_r32_rm32) [R11D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 58 14
0552h shl r11d,5                    ; SHL(Shl_rm32_imm8) [R11D,5h:imm8]                    encoding(4 bytes) = 41 c1 e3 05
0556h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0559h cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
055ch jbe short 05c8h               ; JBE(Jbe_rel8_64) [5C8h:jmp64]                        encoding(2 bytes) = 76 6a
055eh mov r11d,[rax+18h]            ; MOV(Mov_r32_rm32) [R11D,mem(32u,RAX:br,DS:sr)]       encoding(4 bytes) = 44 8b 58 18
0562h shl r11d,6                    ; SHL(Shl_rm32_imm8) [R11D,6h:imm8]                    encoding(4 bytes) = 41 c1 e3 06
0566h or r10d,r11d                  ; OR(Or_r32_rm32) [R10D,R11D]                          encoding(3 bytes) = 45 0b d3
0569h cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
056ch jbe short 05c8h               ; JBE(Jbe_rel8_64) [5C8h:jmp64]                        encoding(2 bytes) = 76 5a
056eh mov eax,[rax+1Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 40 1c
0571h shl eax,7                     ; SHL(Shl_rm32_imm8) [EAX,7h:imm8]                     encoding(3 bytes) = c1 e0 07
0574h or r10d,eax                   ; OR(Or_r32_rm32) [R10D,EAX]                           encoding(3 bytes) = 44 0b d0
0577h mov eax,r10d                  ; MOV(Mov_r32_rm32) [EAX,R10D]                         encoding(3 bytes) = 41 8b c2
057ah shl rax,8                     ; SHL(Shl_rm64_imm8) [RAX,8h:imm8]                     encoding(4 bytes) = 48 c1 e0 08
057eh or r9,rax                     ; OR(Or_r64_rm64) [R9,RAX]                             encoding(3 bytes) = 4c 0b c8
0581h mov rax,r9                    ; MOV(Mov_r64_rm64) [RAX,R9]                           encoding(3 bytes) = 49 8b c1
0584h shl rax,10h                   ; SHL(Shl_rm64_imm8) [RAX,10h:imm8]                    encoding(4 bytes) = 48 c1 e0 10
0588h or r8,rax                     ; OR(Or_r64_rm64) [R8,RAX]                             encoding(3 bytes) = 4c 0b c0
058bh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
058eh shl rax,20h                   ; SHL(Shl_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e0 20
0592h or rcx,rax                    ; OR(Or_r64_rm64) [RCX,RAX]                            encoding(3 bytes) = 48 0b c8
0595h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0598h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
059ch pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
059dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
059eh call 7FFDCFDE01D8h            ; CALL(Call_rel32_64) [FFFFFFFFFF944B08h:jmp64]        encoding(5 bytes) = e8 65 45 94 ff
05a3h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
05a4h call 7FFDCFDE01D8h            ; CALL(Call_rel32_64) [FFFFFFFFFF944B08h:jmp64]        encoding(5 bytes) = e8 5f 45 94 ff
05a9h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
05aah call 7FFDCFDE01D8h            ; CALL(Call_rel32_64) [FFFFFFFFFF944B08h:jmp64]        encoding(5 bytes) = e8 59 45 94 ff
05afh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
05b0h call 7FFDCFDE01D8h            ; CALL(Call_rel32_64) [FFFFFFFFFF944B08h:jmp64]        encoding(5 bytes) = e8 53 45 94 ff
05b5h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
05b6h call 7FFDCFDE01D8h            ; CALL(Call_rel32_64) [FFFFFFFFFF944B08h:jmp64]        encoding(5 bytes) = e8 4d 45 94 ff
05bbh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
05bch call 7FFDCFDE01D8h            ; CALL(Call_rel32_64) [FFFFFFFFFF944B08h:jmp64]        encoding(5 bytes) = e8 47 45 94 ff
05c1h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
05c2h call 7FFDCFDE01D8h            ; CALL(Call_rel32_64) [FFFFFFFFFF944B08h:jmp64]        encoding(5 bytes) = e8 41 45 94 ff
05c7h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
05c8h call 7FFE2FA0EF00h            ; CALL(Call_rel32_64) [5F573830h:jmp64]                encoding(5 bytes) = e8 63 32 57 5f
05cdh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> pack64Bytes => new byte[1486]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0x01,0x8B,0x51,0x08,0x48,0x8B,0xC8,0x44,0x8B,0xC2,0x41,0x83,0xF8,0x00,0x0F,0x86,0xAD,0x05,0x00,0x00,0x44,0x8B,0x09,0x41,0x83,0xF8,0x01,0x0F,0x86,0xA0,0x05,0x00,0x00,0x44,0x8B,0x51,0x04,0x41,0xD1,0xE2,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x02,0x0F,0x86,0x8C,0x05,0x00,0x00,0x44,0x8B,0x51,0x08,0x41,0xC1,0xE2,0x02,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x03,0x0F,0x86,0x77,0x05,0x00,0x00,0x44,0x8B,0x51,0x0C,0x41,0xC1,0xE2,0x03,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x04,0x0F,0x86,0x62,0x05,0x00,0x00,0x44,0x8B,0x51,0x10,0x41,0xC1,0xE2,0x04,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x05,0x0F,0x86,0x4D,0x05,0x00,0x00,0x44,0x8B,0x51,0x14,0x41,0xC1,0xE2,0x05,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x06,0x0F,0x86,0x38,0x05,0x00,0x00,0x44,0x8B,0x51,0x18,0x41,0xC1,0xE2,0x06,0x45,0x0B,0xCA,0x41,0x83,0xF8,0x07,0x0F,0x86,0x23,0x05,0x00,0x00,0x8B,0x49,0x1C,0xC1,0xE1,0x07,0x44,0x0B,0xC9,0x41,0x8B,0xC9,0x83,0xFA,0x08,0x0F,0x82,0xE4,0x04,0x00,0x00,0x44,0x8D,0x42,0xF8,0x4C,0x8D,0x48,0x20,0x41,0x83,0xF8,0x00,0x0F,0x86,0xFC,0x04,0x00,0x00,0x45,0x8B,0x11,0x41,0x83,0xF8,0x01,0x0F,0x86,0xEF,0x04,0x00,0x00,0x45,0x8B,0x59,0x04,0x41,0xD1,0xE3,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x02,0x0F,0x86,0xDB,0x04,0x00,0x00,0x45,0x8B,0x59,0x08,0x41,0xC1,0xE3,0x02,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x03,0x0F,0x86,0xC6,0x04,0x00,0x00,0x45,0x8B,0x59,0x0C,0x41,0xC1,0xE3,0x03,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x04,0x0F,0x86,0xB1,0x04,0x00,0x00,0x45,0x8B,0x59,0x10,0x41,0xC1,0xE3,0x04,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x05,0x0F,0x86,0x9C,0x04,0x00,0x00,0x45,0x8B,0x59,0x14,0x41,0xC1,0xE3,0x05,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x06,0x0F,0x86,0x87,0x04,0x00,0x00,0x45,0x8B,0x59,0x18,0x41,0xC1,0xE3,0x06,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x07,0x0F,0x86,0x72,0x04,0x00,0x00,0x45,0x8B,0x41,0x1C,0x41,0xC1,0xE0,0x07,0x45,0x0B,0xD0,0x45,0x8B,0xC2,0x49,0xC1,0xE0,0x08,0x49,0x0B,0xC8,0x83,0xFA,0x10,0x0F,0x82,0x30,0x04,0x00,0x00,0x44,0x8D,0x42,0xF0,0x4C,0x8D,0x48,0x40,0x41,0x83,0xF8,0x00,0x0F,0x86,0x42,0x04,0x00,0x00,0x45,0x8B,0x11,0x41,0x83,0xF8,0x01,0x0F,0x86,0x35,0x04,0x00,0x00,0x45,0x8B,0x59,0x04,0x41,0xD1,0xE3,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x02,0x0F,0x86,0x21,0x04,0x00,0x00,0x45,0x8B,0x59,0x08,0x41,0xC1,0xE3,0x02,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x03,0x0F,0x86,0x0C,0x04,0x00,0x00,0x45,0x8B,0x59,0x0C,0x41,0xC1,0xE3,0x03,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x04,0x0F,0x86,0xF7,0x03,0x00,0x00,0x45,0x8B,0x59,0x10,0x41,0xC1,0xE3,0x04,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x05,0x0F,0x86,0xE2,0x03,0x00,0x00,0x45,0x8B,0x59,0x14,0x41,0xC1,0xE3,0x05,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x06,0x0F,0x86,0xCD,0x03,0x00,0x00,0x45,0x8B,0x59,0x18,0x41,0xC1,0xE3,0x06,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x07,0x0F,0x86,0xB8,0x03,0x00,0x00,0x45,0x8B,0x59,0x1C,0x41,0xC1,0xE3,0x07,0x45,0x0B,0xD3,0x41,0x83,0xF8,0x08,0x0F,0x82,0x85,0x03,0x00,0x00,0x41,0x83,0xC0,0xF8,0x49,0x83,0xC1,0x20,0x41,0x83,0xF8,0x00,0x0F,0x86,0x91,0x03,0x00,0x00,0x45,0x8B,0x19,0x41,0x83,0xF8,0x01,0x0F,0x86,0x84,0x03,0x00,0x00,0x41,0x8B,0x71,0x04,0xD1,0xE6,0x44,0x0B,0xDE,0x41,0x83,0xF8,0x02,0x0F,0x86,0x71,0x03,0x00,0x00,0x41,0x8B,0x71,0x08,0xC1,0xE6,0x02,0x44,0x0B,0xDE,0x41,0x83,0xF8,0x03,0x0F,0x86,0x5D,0x03,0x00,0x00,0x41,0x8B,0x71,0x0C,0xC1,0xE6,0x03,0x44,0x0B,0xDE,0x41,0x83,0xF8,0x04,0x0F,0x86,0x49,0x03,0x00,0x00,0x41,0x8B,0x71,0x10,0xC1,0xE6,0x04,0x44,0x0B,0xDE,0x41,0x83,0xF8,0x05,0x0F,0x86,0x35,0x03,0x00,0x00,0x41,0x8B,0x71,0x14,0xC1,0xE6,0x05,0x44,0x0B,0xDE,0x41,0x83,0xF8,0x06,0x0F,0x86,0x21,0x03,0x00,0x00,0x41,0x8B,0x71,0x18,0xC1,0xE6,0x06,0x44,0x0B,0xDE,0x41,0x83,0xF8,0x07,0x0F,0x86,0x0D,0x03,0x00,0x00,0x45,0x8B,0x41,0x1C,0x41,0xC1,0xE0,0x07,0x45,0x0B,0xD8,0x45,0x8B,0xC3,0x49,0xC1,0xE0,0x08,0x4D,0x0B,0xD0,0x4D,0x8B,0xC2,0x49,0xC1,0xE0,0x10,0x49,0x0B,0xC8,0x83,0xFA,0x20,0x0F,0x82,0xCD,0x02,0x00,0x00,0x83,0xC2,0xE0,0x48,0x05,0x80,0x00,0x00,0x00,0x83,0xFA,0x00,0x0F,0x86,0xD3,0x02,0x00,0x00,0x44,0x8B,0x00,0x83,0xFA,0x01,0x0F,0x86,0xC7,0x02,0x00,0x00,0x44,0x8B,0x48,0x04,0x41,0xD1,0xE1,0x45,0x0B,0xC1,0x83,0xFA,0x02,0x0F,0x86,0xB4,0x02,0x00,0x00,0x44,0x8B,0x48,0x08,0x41,0xC1,0xE1,0x02,0x45,0x0B,0xC1,0x83,0xFA,0x03,0x0F,0x86,0xA0,0x02,0x00,0x00,0x44,0x8B,0x48,0x0C,0x41,0xC1,0xE1,0x03,0x45,0x0B,0xC1,0x83,0xFA,0x04,0x0F,0x86,0x8C,0x02,0x00,0x00,0x44,0x8B,0x48,0x10,0x41,0xC1,0xE1,0x04,0x45,0x0B,0xC1,0x83,0xFA,0x05,0x0F,0x86,0x78,0x02,0x00,0x00,0x44,0x8B,0x48,0x14,0x41,0xC1,0xE1,0x05,0x45,0x0B,0xC1,0x83,0xFA,0x06,0x0F,0x86,0x64,0x02,0x00,0x00,0x44,0x8B,0x48,0x18,0x41,0xC1,0xE1,0x06,0x45,0x0B,0xC1,0x83,0xFA,0x07,0x0F,0x86,0x50,0x02,0x00,0x00,0x44,0x8B,0x48,0x1C,0x41,0xC1,0xE1,0x07,0x45,0x0B,0xC1,0x83,0xFA,0x08,0x0F,0x82,0x2A,0x02,0x00,0x00,0x44,0x8D,0x4A,0xF8,0x4C,0x8D,0x50,0x20,0x41,0x83,0xF9,0x00,0x0F,0x86,0x2A,0x02,0x00,0x00,0x45,0x8B,0x1A,0x41,0x83,0xF9,0x01,0x0F,0x86,0x1D,0x02,0x00,0x00,0x41,0x8B,0x72,0x04,0xD1,0xE6,0x44,0x0B,0xDE,0x41,0x83,0xF9,0x02,0x0F,0x86,0x0A,0x02,0x00,0x00,0x41,0x8B,0x72,0x08,0xC1,0xE6,0x02,0x44,0x0B,0xDE,0x41,0x83,0xF9,0x03,0x0F,0x86,0xF6,0x01,0x00,0x00,0x41,0x8B,0x72,0x0C,0xC1,0xE6,0x03,0x44,0x0B,0xDE,0x41,0x83,0xF9,0x04,0x0F,0x86,0xE2,0x01,0x00,0x00,0x41,0x8B,0x72,0x10,0xC1,0xE6,0x04,0x44,0x0B,0xDE,0x41,0x83,0xF9,0x05,0x0F,0x86,0xCE,0x01,0x00,0x00,0x41,0x8B,0x72,0x14,0xC1,0xE6,0x05,0x44,0x0B,0xDE,0x41,0x83,0xF9,0x06,0x0F,0x86,0xBA,0x01,0x00,0x00,0x41,0x8B,0x72,0x18,0xC1,0xE6,0x06,0x44,0x0B,0xDE,0x41,0x83,0xF9,0x07,0x0F,0x86,0xA6,0x01,0x00,0x00,0x45,0x8B,0x4A,0x1C,0x41,0xC1,0xE1,0x07,0x45,0x0B,0xD9,0x45,0x8B,0xCB,0x49,0xC1,0xE1,0x08,0x4D,0x0B,0xC1,0x83,0xFA,0x10,0x0F,0x82,0x7C,0x01,0x00,0x00,0x83,0xC2,0xF0,0x48,0x83,0xC0,0x40,0x83,0xFA,0x00,0x0F,0x86,0x78,0x01,0x00,0x00,0x44,0x8B,0x08,0x83,0xFA,0x01,0x0F,0x86,0x6C,0x01,0x00,0x00,0x44,0x8B,0x50,0x04,0x41,0xD1,0xE2,0x45,0x0B,0xCA,0x83,0xFA,0x02,0x0F,0x86,0x59,0x01,0x00,0x00,0x44,0x8B,0x50,0x08,0x41,0xC1,0xE2,0x02,0x45,0x0B,0xCA,0x83,0xFA,0x03,0x0F,0x86,0x45,0x01,0x00,0x00,0x44,0x8B,0x50,0x0C,0x41,0xC1,0xE2,0x03,0x45,0x0B,0xCA,0x83,0xFA,0x04,0x0F,0x86,0x31,0x01,0x00,0x00,0x44,0x8B,0x50,0x10,0x41,0xC1,0xE2,0x04,0x45,0x0B,0xCA,0x83,0xFA,0x05,0x0F,0x86,0x1D,0x01,0x00,0x00,0x44,0x8B,0x50,0x14,0x41,0xC1,0xE2,0x05,0x45,0x0B,0xCA,0x83,0xFA,0x06,0x0F,0x86,0x09,0x01,0x00,0x00,0x44,0x8B,0x50,0x18,0x41,0xC1,0xE2,0x06,0x45,0x0B,0xCA,0x83,0xFA,0x07,0x0F,0x86,0xF5,0x00,0x00,0x00,0x44,0x8B,0x50,0x1C,0x41,0xC1,0xE2,0x07,0x45,0x0B,0xCA,0x83,0xFA,0x08,0x0F,0x82,0xDB,0x00,0x00,0x00,0x83,0xC2,0xF8,0x48,0x83,0xC0,0x20,0x83,0xFA,0x00,0x0F,0x86,0xD1,0x00,0x00,0x00,0x44,0x8B,0x10,0x83,0xFA,0x01,0x0F,0x86,0xC5,0x00,0x00,0x00,0x44,0x8B,0x58,0x04,0x41,0xD1,0xE3,0x45,0x0B,0xD3,0x83,0xFA,0x02,0x0F,0x86,0xB2,0x00,0x00,0x00,0x44,0x8B,0x58,0x08,0x41,0xC1,0xE3,0x02,0x45,0x0B,0xD3,0x83,0xFA,0x03,0x0F,0x86,0x9E,0x00,0x00,0x00,0x44,0x8B,0x58,0x0C,0x41,0xC1,0xE3,0x03,0x45,0x0B,0xD3,0x83,0xFA,0x04,0x0F,0x86,0x8A,0x00,0x00,0x00,0x44,0x8B,0x58,0x10,0x41,0xC1,0xE3,0x04,0x45,0x0B,0xD3,0x83,0xFA,0x05,0x76,0x7A,0x44,0x8B,0x58,0x14,0x41,0xC1,0xE3,0x05,0x45,0x0B,0xD3,0x83,0xFA,0x06,0x76,0x6A,0x44,0x8B,0x58,0x18,0x41,0xC1,0xE3,0x06,0x45,0x0B,0xD3,0x83,0xFA,0x07,0x76,0x5A,0x8B,0x40,0x1C,0xC1,0xE0,0x07,0x44,0x0B,0xD0,0x41,0x8B,0xC2,0x48,0xC1,0xE0,0x08,0x4C,0x0B,0xC8,0x49,0x8B,0xC1,0x48,0xC1,0xE0,0x10,0x4C,0x0B,0xC0,0x49,0x8B,0xC0,0x48,0xC1,0xE0,0x20,0x48,0x0B,0xC8,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x20,0x5E,0xC3,0xE8,0x65,0x45,0x94,0xFF,0xCC,0xE8,0x5F,0x45,0x94,0xFF,0xCC,0xE8,0x59,0x45,0x94,0xFF,0xCC,0xE8,0x53,0x45,0x94,0xFF,0xCC,0xE8,0x4D,0x45,0x94,0xFF,0xCC,0xE8,0x47,0x45,0x94,0xFF,0xCC,0xE8,0x41,0x45,0x94,0xFF,0xCC,0xE8,0x63,0x32,0x57,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop_4x64(ulong x0, ulong x1, ulong x2, ulong x3)
; location: [7FFDD049BCC0h, 7FFDD049BCE5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt rax,rcx                ; POPCNT(Popcnt_r64_rm64) [RAX,RCX]                    encoding(5 bytes) = f3 48 0f b8 c1
000ch popcnt rdx,rdx                ; POPCNT(Popcnt_r64_rm64) [RDX,RDX]                    encoding(5 bytes) = f3 48 0f b8 d2
0011h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0013h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0015h popcnt rdx,r8                 ; POPCNT(Popcnt_r64_rm64) [RDX,R8]                     encoding(5 bytes) = f3 49 0f b8 d0
001ah add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
001ch xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
001eh popcnt rdx,r9                 ; POPCNT(Popcnt_r64_rm64) [RDX,R9]                     encoding(5 bytes) = f3 49 0f b8 d1
0023h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pop_4x64Bytes => new byte[38]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xB8,0xC1,0xF3,0x48,0x0F,0xB8,0xD2,0x03,0xC2,0x33,0xD2,0xF3,0x49,0x0F,0xB8,0xD0,0x03,0xC2,0x33,0xD2,0xF3,0x49,0x0F,0xB8,0xD1,0x03,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop_8x64(ulong x0, ulong x1, ulong x2, ulong x3, ulong x4, ulong x5, ulong x6, ulong x7)
; location: [7FFDD049BD00h, 7FFDD049BD5Ah]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h mov rax,[rsp+30h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 30
000ah mov r10,[rsp+38h]             ; MOV(Mov_r64_rm64) [R10,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8b 54 24 38
000fh mov r11,[rsp+40h]             ; MOV(Mov_r64_rm64) [R11,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8b 5c 24 40
0014h mov rsi,[rsp+48h]             ; MOV(Mov_r64_rm64) [RSI,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 74 24 48
0019h popcnt rcx,rcx                ; POPCNT(Popcnt_r64_rm64) [RCX,RCX]                    encoding(5 bytes) = f3 48 0f b8 c9
001eh popcnt rdx,rdx                ; POPCNT(Popcnt_r64_rm64) [RDX,RDX]                    encoding(5 bytes) = f3 48 0f b8 d2
0023h add edx,ecx                   ; ADD(Add_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 03 d1
0025h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0027h popcnt rcx,r8                 ; POPCNT(Popcnt_r64_rm64) [RCX,R8]                     encoding(5 bytes) = f3 49 0f b8 c8
002ch add edx,ecx                   ; ADD(Add_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 03 d1
002eh xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0030h popcnt rcx,r9                 ; POPCNT(Popcnt_r64_rm64) [RCX,R9]                     encoding(5 bytes) = f3 49 0f b8 c9
0035h add edx,ecx                   ; ADD(Add_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 03 d1
0037h popcnt rax,rax                ; POPCNT(Popcnt_r64_rm64) [RAX,RAX]                    encoding(5 bytes) = f3 48 0f b8 c0
003ch add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
003eh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0040h popcnt rdx,r10                ; POPCNT(Popcnt_r64_rm64) [RDX,R10]                    encoding(5 bytes) = f3 49 0f b8 d2
0045h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0047h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0049h popcnt rdx,r11                ; POPCNT(Popcnt_r64_rm64) [RDX,R11]                    encoding(5 bytes) = f3 49 0f b8 d3
004eh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0050h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0052h popcnt rdx,rsi                ; POPCNT(Popcnt_r64_rm64) [RDX,RSI]                    encoding(5 bytes) = f3 48 0f b8 d6
0057h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0059h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
005ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pop_8x64Bytes => new byte[91]{0x56,0x0F,0x1F,0x40,0x00,0x48,0x8B,0x44,0x24,0x30,0x4C,0x8B,0x54,0x24,0x38,0x4C,0x8B,0x5C,0x24,0x40,0x48,0x8B,0x74,0x24,0x48,0xF3,0x48,0x0F,0xB8,0xC9,0xF3,0x48,0x0F,0xB8,0xD2,0x03,0xD1,0x33,0xC9,0xF3,0x49,0x0F,0xB8,0xC8,0x03,0xD1,0x33,0xC9,0xF3,0x49,0x0F,0xB8,0xC9,0x03,0xD1,0xF3,0x48,0x0F,0xB8,0xC0,0x03,0xC2,0x33,0xD2,0xF3,0x49,0x0F,0xB8,0xD2,0x03,0xC2,0x33,0xD2,0xF3,0x49,0x0F,0xB8,0xD3,0x03,0xC2,0x33,0xD2,0xF3,0x48,0x0F,0xB8,0xD6,0x03,0xC2,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
