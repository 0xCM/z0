; 2019-10-21 17:21:43:383
; function: BitVector8 rotl(BitVector8 x, int offset)
; location: [7FFDD9B55EF0h, 7FFDD9B55F12h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000dh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0010h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0012h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0014h add ecx,8                     ; ADD(Add_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 c1 08
0017h sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
0019h or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE0,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x08,0xD3,0xF8,0x41,0x0B,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 rotl(BitVector16 x, int offset)
; location: [7FFDD9B567F0h, 7FFDD9B5680Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000dh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0010h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0012h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0014h add ecx,10h                   ; ADD(Add_rm32_imm8) [ECX,10h:imm32]                   encoding(3 bytes) = 83 c1 10
0017h sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
0019h or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
001ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE0,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x10,0xD3,0xF8,0x41,0x0B,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 rotl(BitVector32 x, int offset)
; location: [7FFDD9B56CE0h, 7FFDD9B56CEBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h rol eax,cl                    ; ROL(Rol_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 rotl(BitVector64 x, int offset)
; location: [7FFDD9B571C0h, 7FFDD9B571CDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah rol rax,cl                    ; ROL(Rol_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 rotr(BitVector4 x, int offset)
; location: [7FFDD9B57A80h, 7FFDD9B57A9Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000dh sar r8d,cl                    ; SAR(Sar_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 f8
0010h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0012h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0014h add ecx,8                     ; ADD(Add_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 c1 08
0017h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
0019h or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xF8,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x08,0xD3,0xE0,0x41,0x0B,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 rotr(BitVector8 x, int offset)
; location: [7FFDD9B57AB0h, 7FFDD9B57AD2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000dh sar r8d,cl                    ; SAR(Sar_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 f8
0010h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0012h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0014h add ecx,8                     ; ADD(Add_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 c1 08
0017h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
0019h or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xF8,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x08,0xD3,0xE0,0x41,0x0B,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 rotr(BitVector16 x, int offset)
; location: [7FFDD9B57AF0h, 7FFDD9B57B0Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000dh sar r8d,cl                    ; SAR(Sar_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 f8
0010h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0012h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0014h add ecx,10h                   ; ADD(Add_rm32_imm8) [ECX,10h:imm32]                   encoding(3 bytes) = 83 c1 10
0017h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
0019h or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
001ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xF8,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x10,0xD3,0xE0,0x41,0x0B,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 rotr(BitVector32 x, int offset)
; location: [7FFDD9B57B20h, 7FFDD9B57B2Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h ror eax,cl                    ; ROR(Ror_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 rotr(BitVector64 x, int offset)
; location: [7FFDD9B57B40h, 7FFDD9B57B4Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah ror rax,cl                    ; ROR(Ror_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 c8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xC8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 select(BitVector4 x, BitVector4 y)
; location: [7FFDD9B57B60h, 7FFDD9B57B8Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx ecx,al                  ; MOVZX(Movzx_r32_rm8) [ECX,AL]                        encoding(3 bytes) = 0f b6 c8
000eh and ecx,edx                   ; AND(And_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 23 ca
0010h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0013h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
0023h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0026h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0028h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[44]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC8,0x23,0xCA,0x0F,0xB6,0xC9,0xF7,0xD0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xD1,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 select(BitVector8 x, BitVector8 y)
; location: [7FFDD9B57BA0h, 7FFDD9B57BCBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh movzx ecx,al                  ; MOVZX(Movzx_r32_rm8) [ECX,AL]                        encoding(3 bytes) = 0f b6 c8
000eh and ecx,edx                   ; AND(And_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 23 ca
0010h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0013h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
0023h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0026h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0028h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[44]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC8,0x23,0xCA,0x0F,0xB6,0xC9,0xF7,0xD0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xD1,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 select(BitVector16 x, BitVector16 y)
; location: [7FFDD9B57BE0h, 7FFDD9B57C0Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh movzx ecx,ax                  ; MOVZX(Movzx_r32_rm16) [ECX,AX]                       encoding(3 bytes) = 0f b7 c8
000eh and ecx,edx                   ; AND(And_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 23 ca
0010h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0013h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0015h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
001dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0020h movzx edx,cx                  ; MOVZX(Movzx_r32_rm16) [EDX,CX]                       encoding(3 bytes) = 0f b7 d1
0023h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0026h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0028h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
002bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[44]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC8,0x23,0xCA,0x0F,0xB7,0xC9,0xF7,0xD0,0x0F,0xB7,0xC0,0x0F,0xB7,0xC0,0x23,0xC2,0x0F,0xB7,0xC0,0x0F,0xB7,0xD1,0x0F,0xB7,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 select(BitVector32 x, BitVector32 y)
; location: [7FFDD9B57C20h, 7FFDD9B57C2Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0009h not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
000bh and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
000dh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0xF7,0xD1,0x23,0xD1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 select(BitVector64 x, BitVector64 y)
; location: [7FFDD9B58050h, 7FFDD9B58064h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
000bh not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
000eh and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0011h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x23,0xC2,0x48,0xF7,0xD1,0x48,0x23,0xD1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 sll(BitVector4 x, int offset)
; location: [7FFDD9B58080h, 7FFDD9B5808Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xE0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 sll(BitVector8 x, int offset)
; location: [7FFDD9B580A0h, 7FFDD9B580B2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xE0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 sll(BitVector16 x, int offset)
; location: [7FFDD9B580D0h, 7FFDD9B580DFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0xD3,0xE0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 sll(BitVector32 x, int offset)
; location: [7FFDD9B580F0h, 7FFDD9B580FBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 sll(BitVector64 x, int offset)
; location: [7FFDD9B58110h, 7FFDD9B5811Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 srl(BitVector4 x, int offset)
; location: [7FFDD9B58130h, 7FFDD9B5813Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xE8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 srl(BitVector8 x, int offset)
; location: [7FFDD9B58150h, 7FFDD9B5815Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xE8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 srl(BitVector16 x, int offset)
; location: [7FFDD9B58170h, 7FFDD9B5817Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0xD3,0xE8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 srl(BitVector32 x, int offset)
; location: [7FFDD9B58190h, 7FFDD9B5819Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 srl(BitVector64 x, int offset)
; location: [7FFDD9B581B0h, 7FFDD9B581BDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 sub(BitVector4 x, BitVector4 y)
; location: [7FFDD9B581D0h, 7FFDD9B581F0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000dh mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000fh shl rdx,3Ch                   ; SHL(Shl_rm64_imm8) [RDX,3ch:imm8]                    encoding(4 bytes) = 48 c1 e2 3c
0013h mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
0018h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
001dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x2B,0xC2,0x8B,0xD0,0x48,0xC1,0xE2,0x3C,0xB8,0x10,0x00,0x00,0x00,0xC4,0xE2,0xFB,0xF6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 sub(BitVector8 x, BitVector8 y)
; location: [7FFDD9B58210h, 7FFDD9B58223h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x2B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 sub(BitVector16 x, BitVector16 y)
; location: [7FFDD9B58240h, 7FFDD9B58250h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x2B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 sub(BitVector32 x, BitVector32 y)
; location: [7FFDD9B58270h, 7FFDD9B58279h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 sub(BitVector64 x, BitVector64 y)
; location: [7FFDD9B58290h, 7FFDD9B5829Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h sub rax,rdx                   ; SUB(Sub_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 2b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 xnor(BitVector4 x, BitVector4 y)
; location: [7FFDD9B582B0h, 7FFDD9B582C2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xnorBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 xnor(BitVector8 x, BitVector8 y)
; location: [7FFDD9B582E0h, 7FFDD9B582F2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xnorBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 xnor(BitVector16 x, BitVector16 y)
; location: [7FFDD9B58310h, 7FFDD9B58322h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000fh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xnorBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x33,0xC2,0xF7,0xD0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 xnor(BitVector32 x, BitVector32 y)
; location: [7FFDD9B58340h, 7FFDD9B5834Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xnorBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xD1,0x8B,0xC2,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 xnor(BitVector64 x, BitVector64 y)
; location: [7FFDD9B58360h, 7FFDD9B5836Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xnorBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 xor(BitVector4 x, BitVector4 y)
; location: [7FFDD9B58380h, 7FFDD9B58390h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 xor(BitVector8 x, BitVector8 y)
; location: [7FFDD9B583B0h, 7FFDD9B583C3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 xor(BitVector16 x, BitVector16 y)
; location: [7FFDD9B583E0h, 7FFDD9B583F0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x33,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 xor(BitVector32 x, BitVector32 y)
; location: [7FFDD9B58410h, 7FFDD9B58419h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 xor(BitVector64 x, BitVector64 y)
; location: [7FFDD9B58430h, 7FFDD9B5843Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 add(BitVector4 x, BitVector4 y)
; location: [7FFDD9B58450h, 7FFDD9B58471h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh add edx,eax                   ; ADD(Add_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 03 d0
000dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0010h shl rdx,3Ch                   ; SHL(Shl_rm64_imm8) [RDX,3ch:imm8]                    encoding(4 bytes) = 48 c1 e2 3c
0014h mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
0019h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
001eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x03,0xD0,0x0F,0xB6,0xD2,0x48,0xC1,0xE2,0x3C,0xB8,0x10,0x00,0x00,0x00,0xC4,0xE2,0xFB,0xF6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 add(BitVector8 x, BitVector8 y)
; location: [7FFDD9B58490h, 7FFDD9B584A3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x03,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 add(BitVector16 x, BitVector16 y)
; location: [7FFDD9B584C0h, 7FFDD9B584D0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x03,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 add(BitVector32 x, BitVector32 y)
; location: [7FFDD9B584F0h, 7FFDD9B584F8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+rdx]             ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 04 11
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x04,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 add(BitVector64 x, BitVector64 y)
; location: [7FFDD9B58510h, 7FFDD9B58519h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+rdx]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 04 11
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x04,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 and(BitVector4 x, BitVector4 y)
; location: [7FFDD9B58530h, 7FFDD9B58540h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 and(BitVector8 x, BitVector8 y)
; location: [7FFDD9B58560h, 7FFDD9B58573h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 and(BitVector16 x, BitVector16 y)
; location: [7FFDD9B58590h, 7FFDD9B585A0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x23,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 and(in BitVector32 x, in BitVector32 y)
; location: [7FFDD9B585C0h, 7FFDD9B585CBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h mov edx,[rdx]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 8b 12
0009h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x8B,0x12,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 and(BitVector64 x, BitVector64 y)
; location: [7FFDD9B585E0h, 7FFDD9B585EBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 andnot(BitVector4 x, BitVector4 y)
; location: [7FFDD9B58600h, 7FFDD9B58613h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh andn eax,edx,eax              ; ANDN(VEX_Andn_r32_r32_rm32) [EAX,EDX,EAX]            encoding(VEX, 5 bytes) = c4 e2 68 f2 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andnotBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x68,0xF2,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 andnot(BitVector8 x, BitVector8 y)
; location: [7FFDD9B58630h, 7FFDD9B58646h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh andn eax,edx,eax              ; ANDN(VEX_Andn_r32_r32_rm32) [EAX,EDX,EAX]            encoding(VEX, 5 bytes) = c4 e2 68 f2 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andnotBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x68,0xF2,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 andnot(BitVector16 x, BitVector16 y)
; location: [7FFDD9B58660h, 7FFDD9B58673h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh andn eax,edx,eax              ; ANDN(VEX_Andn_r32_r32_rm32) [EAX,EDX,EAX]            encoding(VEX, 5 bytes) = c4 e2 68 f2 c0
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andnotBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC4,0xE2,0x68,0xF2,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 andnot(BitVector32 x, BitVector32 y)
; location: [7FFDD9B58690h, 7FFDD9B5869Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h andn eax,edx,ecx              ; ANDN(VEX_Andn_r32_r32_rm32) [EAX,EDX,ECX]            encoding(VEX, 5 bytes) = c4 e2 68 f2 c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andnotBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x68,0xF2,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 andnot(BitVector64 x, BitVector64 y)
; location: [7FFDD9B586B0h, 7FFDD9B586BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h andn rax,rdx,rcx              ; ANDN(VEX_Andn_r64_r64_rm64) [RAX,RDX,RCX]            encoding(VEX, 5 bytes) = c4 e2 e8 f2 c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andnotBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xE8,0xF2,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 inc(BitVector4 x)
; location: [7FFDD9B586D0h, 7FFDD9B586F3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],rcx               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 08
000ah cmp byte ptr [rsp+8],0Fh      ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),fh:imm8]     encoding(5 bytes) = 80 7c 24 08 0f
000fh jae short 0021h               ; JAE(Jae_rel8_64) [21h:jmp64]                         encoding(2 bytes) = 73 10
0011h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
0016h movzx edx,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RAX:br,DS:sr)]      encoding(3 bytes) = 0f b6 10
0019h lea ecx,[rdx+1]               ; LEA(Lea_r32_m) [ECX,mem(Unknown,RDX:br,DS:sr)]       encoding(3 bytes) = 8d 4a 01
001ch mov [rax],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),CL]            encoding(2 bytes) = 88 08
001eh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0021h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[36]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x89,0x4C,0x24,0x08,0x80,0x7C,0x24,0x08,0x0F,0x73,0x10,0x48,0x8D,0x44,0x24,0x08,0x0F,0xB6,0x10,0x8D,0x4A,0x01,0x88,0x08,0x8B,0xC2,0xC3,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 dec(BitVector4 x)
; location: [7FFDD9B58710h, 7FFDD9B58736h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],rcx               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 08
000ah cmp byte ptr [rsp+8],0        ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 08 00
000fh jbe short 0021h               ; JBE(Jbe_rel8_64) [21h:jmp64]                         encoding(2 bytes) = 76 10
0011h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
0016h movzx edx,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RAX:br,DS:sr)]      encoding(3 bytes) = 0f b6 10
0019h lea ecx,[rdx-1]               ; LEA(Lea_r32_m) [ECX,mem(Unknown,RDX:br,DS:sr)]       encoding(3 bytes) = 8d 4a ff
001ch mov [rax],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),CL]            encoding(2 bytes) = 88 08
001eh mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0021h mov eax,0Fh                   ; MOV(Mov_r32_imm32) [EAX,fh:imm32]                    encoding(5 bytes) = b8 0f 00 00 00
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[39]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x89,0x4C,0x24,0x08,0x80,0x7C,0x24,0x08,0x00,0x76,0x10,0x48,0x8D,0x44,0x24,0x08,0x0F,0xB6,0x10,0x8D,0x4A,0xFF,0x88,0x08,0x8B,0xC2,0xC3,0xB8,0x0F,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 dec(BitVector8 x)
; location: [7FFDD9B58750h, 7FFDD9B58763h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xFF,0xC8,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 dec(BitVector16 x)
; location: [7FFDD9B58780h, 7FFDD9B58790h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xFF,0xC8,0x0F,0xB7,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 dec(BitVector32 x)
; location: [7FFDD9B587B0h, 7FFDD9B587B8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx-1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 ff
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 dec(BitVector64 x)
; location: [7FFDD9B587D0h, 7FFDD9B587D9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx-1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 ff
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint dist(BitVector4 x, BitVector4 y)
; location: [7FFDD9B587F0h, 7FFDD9B58804h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> distBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint dist(BitVector8 x, BitVector8 y)
; location: [7FFDD9B58820h, 7FFDD9B58834h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> distBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint dist(BitVector16 x, BitVector16 y)
; location: [7FFDD9B58850h, 7FFDD9B58864h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> distBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x33,0xC2,0x0F,0xB7,0xC0,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint dist(BitVector32 x, BitVector32 y)
; location: [7FFDD9B58880h, 7FFDD9B5888Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h popcnt eax,edx                ; POPCNT(Popcnt_r32_rm32) [EAX,EDX]                    encoding(4 bytes) = f3 0f b8 c2
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> distBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xD1,0x33,0xC0,0xF3,0x0F,0xB8,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint dist(BitVector64 x, BitVector64 y)
; location: [7FFDD9B588A0h, 7FFDD9B588AFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor rdx,rcx                   ; XOR(Xor_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 33 d1
0008h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000ah popcnt rax,rdx                ; POPCNT(Popcnt_r64_rm64) [RAX,RDX]                    encoding(5 bytes) = f3 48 0f b8 c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> distBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x33,0xC0,0xF3,0x48,0x0F,0xB8,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit dot(BitVector4 x, BitVector4 y)
; location: [7FFDD9B588C0h, 7FFDD9B588F0h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000fh mov [rsp],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(3 bytes) = 89 14 24
0012h lea rdx,[rsp]                 ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 14 24
0016h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
001ah test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
001ch jne short 0022h               ; JNE(Jne_rel8_64) [22h:jmp64]                         encoding(2 bytes) = 75 04
001eh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0020h jmp short 0027h               ; JMP(Jmp_rel8_64) [27h:jmp64]                         encoding(2 bytes) = eb 05
0022h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0027h mov [rdx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),EAX]        encoding(2 bytes) = 89 02
0029h mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
002ch add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0030h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dotBytes => new byte[49]{0x50,0x0F,0x1F,0x40,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x23,0xC2,0x33,0xD2,0x89,0x14,0x24,0x48,0x8D,0x14,0x24,0xF3,0x0F,0xB8,0xC0,0xA8,0x01,0x75,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x89,0x02,0x8B,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit dot(BitVector8 x, BitVector8 y)
; location: [7FFDD9B58910h, 7FFDD9B58940h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000fh mov [rsp],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(3 bytes) = 89 14 24
0012h lea rdx,[rsp]                 ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 14 24
0016h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
001ah test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
001ch jne short 0022h               ; JNE(Jne_rel8_64) [22h:jmp64]                         encoding(2 bytes) = 75 04
001eh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0020h jmp short 0027h               ; JMP(Jmp_rel8_64) [27h:jmp64]                         encoding(2 bytes) = eb 05
0022h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0027h mov [rdx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),EAX]        encoding(2 bytes) = 89 02
0029h mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
002ch add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0030h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dotBytes => new byte[49]{0x50,0x0F,0x1F,0x40,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x23,0xC2,0x33,0xD2,0x89,0x14,0x24,0x48,0x8D,0x14,0x24,0xF3,0x0F,0xB8,0xC0,0xA8,0x01,0x75,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x89,0x02,0x8B,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit dot(BitVector16 x, BitVector16 y)
; location: [7FFDD9B58960h, 7FFDD9B58990h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000fh mov [rsp],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(3 bytes) = 89 14 24
0012h lea rdx,[rsp]                 ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 14 24
0016h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
001ah test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
001ch jne short 0022h               ; JNE(Jne_rel8_64) [22h:jmp64]                         encoding(2 bytes) = 75 04
001eh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0020h jmp short 0027h               ; JMP(Jmp_rel8_64) [27h:jmp64]                         encoding(2 bytes) = eb 05
0022h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0027h mov [rdx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),EAX]        encoding(2 bytes) = 89 02
0029h mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
002ch add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0030h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dotBytes => new byte[49]{0x50,0x0F,0x1F,0x40,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x23,0xC2,0x33,0xD2,0x89,0x14,0x24,0x48,0x8D,0x14,0x24,0xF3,0x0F,0xB8,0xC0,0xA8,0x01,0x75,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x89,0x02,0x8B,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit dot(BitVector32 x, BitVector32 y)
; location: [7FFDD9B589B0h, 7FFDD9B589DBh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
000ch lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 04 24
0010h popcnt edx,edx                ; POPCNT(Popcnt_r32_rm32) [EDX,EDX]                    encoding(4 bytes) = f3 0f b8 d2
0014h test dl,1                     ; TEST(Test_rm8_imm8) [DL,1h:imm8]                     encoding(3 bytes) = f6 c2 01
0017h jne short 001dh               ; JNE(Jne_rel8_64) [1Dh:jmp64]                         encoding(2 bytes) = 75 04
0019h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
001bh jmp short 0022h               ; JMP(Jmp_rel8_64) [22h:jmp64]                         encoding(2 bytes) = eb 05
001dh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0022h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0024h mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0027h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dotBytes => new byte[44]{0x50,0x0F,0x1F,0x40,0x00,0x23,0xD1,0x33,0xC0,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xF3,0x0F,0xB8,0xD2,0xF6,0xC2,0x01,0x75,0x04,0x33,0xD2,0xEB,0x05,0xBA,0x01,0x00,0x00,0x00,0x89,0x10,0x8B,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit dot(BitVector64 x, BitVector64 y)
; location: [7FFDD9B589F0h, 7FFDD9B58A1Dh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000ah mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
000dh lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 04 24
0011h popcnt rdx,rdx                ; POPCNT(Popcnt_r64_rm64) [RDX,RDX]                    encoding(5 bytes) = f3 48 0f b8 d2
0016h test dl,1                     ; TEST(Test_rm8_imm8) [DL,1h:imm8]                     encoding(3 bytes) = f6 c2 01
0019h jne short 001fh               ; JNE(Jne_rel8_64) [1Fh:jmp64]                         encoding(2 bytes) = 75 04
001bh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
001dh jmp short 0024h               ; JMP(Jmp_rel8_64) [24h:jmp64]                         encoding(2 bytes) = eb 05
001fh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0024h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0026h mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0029h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dotBytes => new byte[46]{0x50,0x0F,0x1F,0x40,0x00,0x48,0x23,0xD1,0x33,0xC0,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xF3,0x48,0x0F,0xB8,0xD2,0xF6,0xC2,0x01,0x75,0x04,0x33,0xD2,0xEB,0x05,0xBA,0x01,0x00,0x00,0x00,0x89,0x10,0x8B,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 inc(BitVector8 x)
; location: [7FFDD9B58A40h, 7FFDD9B58A53h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xFF,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 inc(BitVector16 x)
; location: [7FFDD9B58A70h, 7FFDD9B58A80h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xFF,0xC0,0x0F,0xB7,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 inc(BitVector32 x)
; location: [7FFDD9B58AA0h, 7FFDD9B58AA8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 01
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 inc(BitVector64 x)
; location: [7FFDD9B58AC0h, 7FFDD9B58AC9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 01
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 mul(BitVector8 x, BitVector8 y)
; location: [7FFDD9B58AE0h, 7FFDD9B58BBCh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,88h                   ; SUB(Sub_rm64_imm32) [RSP,88h:imm64]                  encoding(7 bytes) = 48 81 ec 88 00 00 00
0009h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ch mov esi,edx                   ; MOV(Mov_r32_rm32) [ESI,EDX]                          encoding(2 bytes) = 8b f2
000eh movzx edi,cl                  ; MOVZX(Movzx_r32_rm8) [EDI,CL]                        encoding(4 bytes) = 40 0f b6 f9
0012h mov rcx,7FFDD95F9610h         ; MOV(Mov_r64_imm64) [RCX,7ffdd95f9610h:imm64]         encoding(10 bytes) = 48 b9 10 96 5f d9 fd 7f 00 00
001ch mov edx,2Fh                   ; MOV(Mov_r32_imm32) [EDX,2fh:imm32]                   encoding(5 bytes) = ba 2f 00 00 00
0021h call 7FFE38FC48B0h            ; CALL(Call_rel32_64) [5F46BDD0h:jmp64]                encoding(5 bytes) = e8 aa bd 46 5f
0026h movzx eax,word ptr [7FFDD95F9778h]; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RIP:br,DS:sr)] encoding(7 bytes) = 0f b7 05 6b 0c aa ff
002dh movzx edx,dil                 ; MOVZX(Movzx_r32_rm8) [EDX,DIL]                       encoding(4 bytes) = 40 0f b6 d7
0031h movzx ecx,sil                 ; MOVZX(Movzx_r32_rm8) [ECX,SIL]                       encoding(4 bytes) = 40 0f b6 ce
0035h vmovq xmm0,rdx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RDX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c2
003ah vmovq xmm1,rcx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RCX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c9
003fh vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
0045h vmovapd [rsp+60h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 60
004bh vmovdqu xmm0,xmmword ptr [rsp+60h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 60
0051h vmovdqu xmmword ptr [rsp+78h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 78
0057h mov rdx,[rsp+78h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 54 24 78
005ch movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
005fh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0061h sar ecx,8                     ; SAR(Sar_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 f9 08
0064h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0067h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
006ah vmovq xmm0,rcx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RCX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c1
006fh vmovq xmm1,r8                 ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,R8]                  encoding(VEX, 5 bytes) = c4 c1 f9 6e c8
0074h vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
007ah vmovapd [rsp+40h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 40
0080h vmovdqu xmm0,xmmword ptr [rsp+40h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 40
0086h vmovdqu xmmword ptr [rsp+50h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 50
008ch mov ecx,[rsp+50h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 50
0090h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0093h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0095h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0098h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
009ah sar ecx,8                     ; SAR(Sar_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 f9 08
009dh movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
00a0h mov eax,eax                   ; MOV(Mov_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 8b c0
00a2h vmovq xmm0,rcx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RCX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c1
00a7h vmovq xmm1,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c8
00ach vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
00b2h vmovapd [rsp+20h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 20
00b8h vmovdqu xmm0,xmmword ptr [rsp+20h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 20
00beh vmovdqu xmmword ptr [rsp+30h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 30
00c4h mov eax,[rsp+30h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 30
00c8h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
00cbh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
00cdh movzx edx,ax                  ; MOVZX(Movzx_r32_rm16) [EDX,AX]                       encoding(3 bytes) = 0f b7 d0
00d0h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
00d3h add rsp,88h                   ; ADD(Add_rm64_imm32) [RSP,88h:imm64]                  encoding(7 bytes) = 48 81 c4 88 00 00 00
00dah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00dbh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00dch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[221]{0x57,0x56,0x48,0x81,0xEC,0x88,0x00,0x00,0x00,0xC5,0xF8,0x77,0x8B,0xF2,0x40,0x0F,0xB6,0xF9,0x48,0xB9,0x10,0x96,0x5F,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x2F,0x00,0x00,0x00,0xE8,0xAA,0xBD,0x46,0x5F,0x0F,0xB7,0x05,0x6B,0x0C,0xAA,0xFF,0x40,0x0F,0xB6,0xD7,0x40,0x0F,0xB6,0xCE,0xC4,0xE1,0xF9,0x6E,0xC2,0xC4,0xE1,0xF9,0x6E,0xC9,0xC4,0xE3,0x79,0x44,0xC1,0x00,0xC5,0xF9,0x29,0x44,0x24,0x60,0xC5,0xFA,0x6F,0x44,0x24,0x60,0xC5,0xFA,0x7F,0x44,0x24,0x78,0x48,0x8B,0x54,0x24,0x78,0x0F,0xB7,0xD2,0x8B,0xCA,0xC1,0xF9,0x08,0x0F,0xB7,0xC9,0x44,0x8B,0xC0,0xC4,0xE1,0xF9,0x6E,0xC1,0xC4,0xC1,0xF9,0x6E,0xC8,0xC4,0xE3,0x79,0x44,0xC1,0x00,0xC5,0xF9,0x29,0x44,0x24,0x40,0xC5,0xFA,0x6F,0x44,0x24,0x40,0xC5,0xFA,0x7F,0x44,0x24,0x50,0x8B,0x4C,0x24,0x50,0x0F,0xB7,0xC9,0x33,0xD1,0x0F,0xB7,0xD2,0x8B,0xCA,0xC1,0xF9,0x08,0x0F,0xB7,0xC9,0x8B,0xC0,0xC4,0xE1,0xF9,0x6E,0xC1,0xC4,0xE1,0xF9,0x6E,0xC8,0xC4,0xE3,0x79,0x44,0xC1,0x00,0xC5,0xF9,0x29,0x44,0x24,0x20,0xC5,0xFA,0x6F,0x44,0x24,0x20,0xC5,0xFA,0x7F,0x44,0x24,0x30,0x8B,0x44,0x24,0x30,0x0F,0xB7,0xC0,0x33,0xC2,0x0F,0xB7,0xD0,0x0F,0xB6,0xC2,0x48,0x81,0xC4,0x88,0x00,0x00,0x00,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector8 mul(ref BitVector8 x, BitVector8 y)
; location: [7FFDD9B58BE0h, 7FFDD9B58CC4h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,80h                   ; SUB(Sub_rm64_imm32) [RSP,80h:imm64]                  encoding(7 bytes) = 48 81 ec 80 00 00 00
000ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000dh mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0010h mov edi,edx                   ; MOV(Mov_r32_rm32) [EDI,EDX]                          encoding(2 bytes) = 8b fa
0012h movzx ebx,byte ptr [rsi]      ; MOVZX(Movzx_r32_rm8) [EBX,mem(8u,RSI:br,DS:sr)]      encoding(3 bytes) = 0f b6 1e
0015h mov rcx,7FFDD95F9610h         ; MOV(Mov_r64_imm64) [RCX,7ffdd95f9610h:imm64]         encoding(10 bytes) = 48 b9 10 96 5f d9 fd 7f 00 00
001fh mov edx,2Fh                   ; MOV(Mov_r32_imm32) [EDX,2fh:imm32]                   encoding(5 bytes) = ba 2f 00 00 00
0024h call 7FFE38FC48B0h            ; CALL(Call_rel32_64) [5F46BCD0h:jmp64]                encoding(5 bytes) = e8 a7 bc 46 5f
0029h movzx eax,word ptr [7FFDD95F9778h]; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RIP:br,DS:sr)] encoding(7 bytes) = 0f b7 05 68 0b aa ff
0030h movzx edx,bl                  ; MOVZX(Movzx_r32_rm8) [EDX,BL]                        encoding(3 bytes) = 0f b6 d3
0033h movzx ecx,dil                 ; MOVZX(Movzx_r32_rm8) [ECX,DIL]                       encoding(4 bytes) = 40 0f b6 cf
0037h vmovq xmm0,rdx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RDX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c2
003ch vmovq xmm1,rcx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RCX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c9
0041h vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
0047h vmovapd [rsp+60h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 60
004dh vmovdqu xmm0,xmmword ptr [rsp+60h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 60
0053h vmovdqu xmmword ptr [rsp+70h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 70
0059h mov rdx,[rsp+70h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 54 24 70
005eh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0061h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0063h sar ecx,8                     ; SAR(Sar_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 f9 08
0066h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0069h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
006ch vmovq xmm0,rcx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RCX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c1
0071h vmovq xmm1,r8                 ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,R8]                  encoding(VEX, 5 bytes) = c4 c1 f9 6e c8
0076h vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
007ch vmovapd [rsp+40h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 40
0082h vmovdqu xmm0,xmmword ptr [rsp+40h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 40
0088h vmovdqu xmmword ptr [rsp+50h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 50
008eh mov ecx,[rsp+50h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 50
0092h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0095h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0097h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
009ah mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
009ch sar ecx,8                     ; SAR(Sar_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 f9 08
009fh movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
00a2h mov eax,eax                   ; MOV(Mov_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 8b c0
00a4h vmovq xmm0,rcx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RCX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c1
00a9h vmovq xmm1,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c8
00aeh vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
00b4h vmovapd [rsp+20h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 20
00bah vmovdqu xmm0,xmmword ptr [rsp+20h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 20
00c0h vmovdqu xmmword ptr [rsp+30h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 30
00c6h mov eax,[rsp+30h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 30
00cah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
00cdh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
00cfh movzx edx,ax                  ; MOVZX(Movzx_r32_rm16) [EDX,AX]                       encoding(3 bytes) = 0f b7 d0
00d2h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
00d5h mov [rsi],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSI:br,DS:sr),AL]            encoding(2 bytes) = 88 06
00d7h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
00dah add rsp,80h                   ; ADD(Add_rm64_imm32) [RSP,80h:imm64]                  encoding(7 bytes) = 48 81 c4 80 00 00 00
00e1h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00e2h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00e3h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00e4h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[229]{0x57,0x56,0x53,0x48,0x81,0xEC,0x80,0x00,0x00,0x00,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0x8B,0xFA,0x0F,0xB6,0x1E,0x48,0xB9,0x10,0x96,0x5F,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x2F,0x00,0x00,0x00,0xE8,0xA7,0xBC,0x46,0x5F,0x0F,0xB7,0x05,0x68,0x0B,0xAA,0xFF,0x0F,0xB6,0xD3,0x40,0x0F,0xB6,0xCF,0xC4,0xE1,0xF9,0x6E,0xC2,0xC4,0xE1,0xF9,0x6E,0xC9,0xC4,0xE3,0x79,0x44,0xC1,0x00,0xC5,0xF9,0x29,0x44,0x24,0x60,0xC5,0xFA,0x6F,0x44,0x24,0x60,0xC5,0xFA,0x7F,0x44,0x24,0x70,0x48,0x8B,0x54,0x24,0x70,0x0F,0xB7,0xD2,0x8B,0xCA,0xC1,0xF9,0x08,0x0F,0xB7,0xC9,0x44,0x8B,0xC0,0xC4,0xE1,0xF9,0x6E,0xC1,0xC4,0xC1,0xF9,0x6E,0xC8,0xC4,0xE3,0x79,0x44,0xC1,0x00,0xC5,0xF9,0x29,0x44,0x24,0x40,0xC5,0xFA,0x6F,0x44,0x24,0x40,0xC5,0xFA,0x7F,0x44,0x24,0x50,0x8B,0x4C,0x24,0x50,0x0F,0xB7,0xC9,0x33,0xD1,0x0F,0xB7,0xD2,0x8B,0xCA,0xC1,0xF9,0x08,0x0F,0xB7,0xC9,0x8B,0xC0,0xC4,0xE1,0xF9,0x6E,0xC1,0xC4,0xE1,0xF9,0x6E,0xC8,0xC4,0xE3,0x79,0x44,0xC1,0x00,0xC5,0xF9,0x29,0x44,0x24,0x20,0xC5,0xFA,0x6F,0x44,0x24,0x20,0xC5,0xFA,0x7F,0x44,0x24,0x30,0x8B,0x44,0x24,0x30,0x0F,0xB7,0xC0,0x33,0xC2,0x0F,0xB7,0xD0,0x0F,0xB6,0xC2,0x88,0x06,0x48,0x8B,0xC6,0x48,0x81,0xC4,0x80,0x00,0x00,0x00,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 nand(BitVector4 x, BitVector4 y)
; location: [7FFDD9B58CF0h, 7FFDD9B58D02h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nandBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x23,0xC2,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 nand(BitVector8 x, BitVector8 y)
; location: [7FFDD9B58D20h, 7FFDD9B58D32h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nandBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x23,0xC2,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 nand(BitVector16 x, BitVector16 y)
; location: [7FFDD9B58D50h, 7FFDD9B58D62h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000fh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nandBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x23,0xC2,0xF7,0xD0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 nand(BitVector32 x, BitVector32 y)
; location: [7FFDD9B58D80h, 7FFDD9B58D8Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nandBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 nand(BitVector64 x, BitVector64 y)
; location: [7FFDD9B58DA0h, 7FFDD9B58DAEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nandBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 negate(BitVector4 x)
; location: [7FFDD9B58DC0h, 7FFDD9B58DD5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB6,0xC0,0x83,0xE0,0x0F,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 negate(BitVector8 x)
; location: [7FFDD9B58DF0h, 7FFDD9B58E02h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 negate(BitVector16 x)
; location: [7FFDD9B58E20h, 7FFDD9B58E2Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 negate(BitVector32 x)
; location: [7FFDD9B58E40h, 7FFDD9B58E4Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 negate(BitVector64 x)
; location: [7FFDD9B58E60h, 7FFDD9B58E6Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xFF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector4 negate(ref BitVector4 x)
; location: [7FFDD9B58E80h, 7FFDD9B58E94h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch mov [rcx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 88 01
000eh and byte ptr [rcx],0Fh        ; AND(And_rm8_imm8) [mem(8u,RCX:br,DS:sr),fh:imm8]     encoding(3 bytes) = 80 21 0f
0011h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0xF7,0xD0,0xFF,0xC0,0x88,0x01,0x80,0x21,0x0F,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector8 negate(ref BitVector8 x)
; location: [7FFDD9B58EB0h, 7FFDD9B58EC1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch mov [rcx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 88 01
000eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0xF7,0xD0,0xFF,0xC0,0x88,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector16 negate(ref BitVector16 x)
; location: [7FFDD9B58EE0h, 7FFDD9B58EF2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,DS:sr)]    encoding(3 bytes) = 0f b7 01
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch mov [rcx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 01
000fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0xF7,0xD0,0xFF,0xC0,0x66,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector32 negate(ref BitVector32 x)
; location: [7FFDD9B58F10h, 7FFDD9B58F20h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
000dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0xF7,0xD0,0xFF,0xC0,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector64 negate(ref BitVector64 x)
; location: [7FFDD9B58F40h, 7FFDD9B58F54h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
000eh mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
0011h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0xF7,0xD0,0x48,0xFF,0xC0,0x48,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 nor(BitVector4 x, BitVector4 y)
; location: [7FFDD9B58F70h, 7FFDD9B58F82h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> norBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0B,0xC2,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 nor(BitVector8 x, BitVector8 y)
; location: [7FFDD9B58FA0h, 7FFDD9B58FB2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> norBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0B,0xC2,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 nor(BitVector16 x, BitVector16 y)
; location: [7FFDD9B58FD0h, 7FFDD9B58FE2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000fh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> norBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0B,0xC2,0xF7,0xD0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 nor(BitVector32 x, BitVector32 y)
; location: [7FFDD9B59000h, 7FFDD9B5900Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> norBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x0B,0xD1,0x8B,0xC2,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 nor(BitVector64 x, BitVector64 y)
; location: [7FFDD9B59020h, 7FFDD9B5902Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0008h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000bh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> norBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 not(BitVector4 src)
; location: [7FFDD9B59040h, 7FFDD9B59059h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh shl eax,4                     ; SHL(Shl_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e0 04
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
0016h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> notBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0x0F,0xB6,0xC0,0xC1,0xE0,0x04,0x0F,0xB6,0xC0,0xC1,0xF8,0x04,0x83,0xE0,0x0F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 not(BitVector8 x)
; location: [7FFDD9B59070h, 7FFDD9B59080h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> notBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 not(BitVector16 x)
; location: [7FFDD9B590A0h, 7FFDD9B590ADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> notBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 not(BitVector32 x)
; location: [7FFDD9B590C0h, 7FFDD9B590C9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> notBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 not(BitVector64 x)
; location: [7FFDD9B590E0h, 7FFDD9B590EBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> notBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte TakeHi(byte src)
; location: [7FFDD9B59100h, 7FFDD9B5910Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
000bh and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> TakeHiBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC1,0xF8,0x04,0x83,0xE0,0x0F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 or(BitVector4 x, BitVector4 y)
; location: [7FFDD9B59120h, 7FFDD9B59130h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 or(BitVector8 x, BitVector8 y)
; location: [7FFDD9B59150h, 7FFDD9B59163h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 or(BitVector16 x, BitVector16 y)
; location: [7FFDD9B59180h, 7FFDD9B59190h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 or(BitVector32 x, BitVector32 y)
; location: [7FFDD9B591B0h, 7FFDD9B591B9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 or(BitVector64 x, BitVector64 y)
; location: [7FFDD9B591D0h, 7FFDD9B591DBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int ord(BitVector8 x)
; location: [7FFDD9B591F0h, 7FFDD9B59357h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,90h                   ; SUB(Sub_rm64_imm32) [RSP,90h:imm64]                  encoding(7 bytes) = 48 81 ec 90 00 00 00
000ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000dh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000fh mov [rsp+88h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(8 bytes) = 48 89 84 24 88 00 00 00
0017h mov esi,ecx                   ; MOV(Mov_r32_rm32) [ESI,ECX]                          encoding(2 bytes) = 8b f1
0019h movzx ecx,sil                 ; MOVZX(Movzx_r32_rm8) [ECX,SIL]                       encoding(4 bytes) = 40 0f b6 ce
001dh mov [rsp+88h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(7 bytes) = 88 8c 24 88 00 00 00
0024h mov edi,2                     ; MOV(Mov_r32_imm32) [EDI,2h:imm32]                    encoding(5 bytes) = bf 02 00 00 00
0029h mov rcx,7FFDD95F9610h         ; MOV(Mov_r64_imm64) [RCX,7ffdd95f9610h:imm64]         encoding(10 bytes) = 48 b9 10 96 5f d9 fd 7f 00 00
0033h mov edx,2Fh                   ; MOV(Mov_r32_imm32) [EDX,2fh:imm32]                   encoding(5 bytes) = ba 2f 00 00 00
0038h call 7FFE38FC48B0h            ; CALL(Call_rel32_64) [5F46B6C0h:jmp64]                encoding(5 bytes) = e8 83 b6 46 5f
003dh movzx ebx,word ptr [7FFDD95F9778h]; MOVZX(Movzx_r32_rm16) [EBX,mem(16u,RIP:br,DS:sr)] encoding(7 bytes) = 0f b7 1d 44 05 aa ff
0044h movzx ecx,sil                 ; MOVZX(Movzx_r32_rm8) [ECX,SIL]                       encoding(4 bytes) = 40 0f b6 ce
0048h mov esi,ecx                   ; MOV(Mov_r32_rm32) [ESI,ECX]                          encoding(2 bytes) = 8b f1
004ah mov rcx,7FFDD95F9610h         ; MOV(Mov_r64_imm64) [RCX,7ffdd95f9610h:imm64]         encoding(10 bytes) = 48 b9 10 96 5f d9 fd 7f 00 00
0054h mov edx,26h                   ; MOV(Mov_r32_imm32) [EDX,26h:imm32]                   encoding(5 bytes) = ba 26 00 00 00
0059h call 7FFE38FC48B0h            ; CALL(Call_rel32_64) [5F46B6C0h:jmp64]                encoding(5 bytes) = e8 62 b6 46 5f
005eh mov rax,1EC10007160h          ; MOV(Mov_r64_imm64) [RAX,1ec10007160h:imm64]          encoding(10 bytes) = 48 b8 60 71 00 10 ec 01 00 00
0068h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
006bh movzx eax,byte ptr [rax+8]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,DS:sr)]      encoding(4 bytes) = 0f b6 40 08
006fh mov edx,[rsp+88h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 94 24 88 00 00 00
0076h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0079h mov ecx,ebx                   ; MOV(Mov_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 8b cb
007bh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
007eh mov r8,rsi                    ; MOV(Mov_r64_rm64) [R8,RSI]                           encoding(3 bytes) = 4c 8b c6
0081h vmovq xmm0,rdx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RDX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c2
0086h vmovq xmm1,r8                 ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,R8]                  encoding(VEX, 5 bytes) = c4 c1 f9 6e c8
008bh vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
0091h vmovapd [rsp+60h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 60
0097h vmovdqu xmm0,xmmword ptr [rsp+60h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 60
009dh vmovdqu xmmword ptr [rsp+78h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 78
00a3h mov rdx,[rsp+78h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 54 24 78
00a8h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
00abh mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
00aeh sar r8d,8                     ; SAR(Sar_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 f8 08
00b2h movzx r8d,r8w                 ; MOVZX(Movzx_r32_rm16) [R8D,R8W]                      encoding(4 bytes) = 45 0f b7 c0
00b6h mov r9d,ecx                   ; MOV(Mov_r32_rm32) [R9D,ECX]                          encoding(3 bytes) = 44 8b c9
00b9h vmovq xmm0,r8                 ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,R8]                  encoding(VEX, 5 bytes) = c4 c1 f9 6e c0
00beh vmovq xmm1,r9                 ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,R9]                  encoding(VEX, 5 bytes) = c4 c1 f9 6e c9
00c3h vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
00c9h vmovapd [rsp+40h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 40
00cfh vmovdqu xmm0,xmmword ptr [rsp+40h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 40
00d5h vmovdqu xmmword ptr [rsp+50h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 50
00dbh mov r8d,[rsp+50h]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,SS:sr)]        encoding(5 bytes) = 44 8b 44 24 50
00e0h movzx r8d,r8w                 ; MOVZX(Movzx_r32_rm16) [R8D,R8W]                      encoding(4 bytes) = 45 0f b7 c0
00e4h xor edx,r8d                   ; XOR(Xor_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 33 d0
00e7h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
00eah mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
00edh sar r8d,8                     ; SAR(Sar_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 f8 08
00f1h movzx r8d,r8w                 ; MOVZX(Movzx_r32_rm16) [R8D,R8W]                      encoding(4 bytes) = 45 0f b7 c0
00f5h mov ecx,ecx                   ; MOV(Mov_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 8b c9
00f7h vmovq xmm0,r8                 ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,R8]                  encoding(VEX, 5 bytes) = c4 c1 f9 6e c0
00fch vmovq xmm1,rcx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RCX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c9
0101h vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
0107h vmovapd [rsp+20h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 20
010dh vmovdqu xmm0,xmmword ptr [rsp+20h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 20
0113h vmovdqu xmmword ptr [rsp+30h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 30
0119h mov ecx,[rsp+30h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 30
011dh movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0120h xor ecx,edx                   ; XOR(Xor_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 33 ca
0122h movzx edx,cx                  ; MOVZX(Movzx_r32_rm16) [EDX,CX]                       encoding(3 bytes) = 0f b7 d1
0125h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0128h mov [rsp+88h],dl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),DL]            encoding(7 bytes) = 88 94 24 88 00 00 00
012fh movzx edx,al                  ; MOVZX(Movzx_r32_rm8) [EDX,AL]                        encoding(3 bytes) = 0f b6 d0
0132h mov ecx,[rsp+88h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 8c 24 88 00 00 00
0139h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
013ch cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
013eh je short 015bh                ; JE(Je_rel8_64) [15Bh:jmp64]                          encoding(2 bytes) = 74 1b
0140h inc edi                       ; INC(Inc_rm32) [EDI]                                  encoding(2 bytes) = ff c7
0142h cmp edi,100h                  ; CMP(Cmp_rm32_imm32) [EDI,100h:imm32]                 encoding(6 bytes) = 81 ff 00 01 00 00
0148h jl near ptr 006fh             ; JL(Jl_rel32_64) [6Fh:jmp64]                          encoding(6 bytes) = 0f 8c 21 ff ff ff
014eh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0150h add rsp,90h                   ; ADD(Add_rm64_imm32) [RSP,90h:imm64]                  encoding(7 bytes) = 48 81 c4 90 00 00 00
0157h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0158h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0159h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
015ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
015bh mov eax,edi                   ; MOV(Mov_r32_rm32) [EAX,EDI]                          encoding(2 bytes) = 8b c7
015dh add rsp,90h                   ; ADD(Add_rm64_imm32) [RSP,90h:imm64]                  encoding(7 bytes) = 48 81 c4 90 00 00 00
0164h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0165h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0166h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0167h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ordBytes => new byte[360]{0x57,0x56,0x53,0x48,0x81,0xEC,0x90,0x00,0x00,0x00,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x84,0x24,0x88,0x00,0x00,0x00,0x8B,0xF1,0x40,0x0F,0xB6,0xCE,0x88,0x8C,0x24,0x88,0x00,0x00,0x00,0xBF,0x02,0x00,0x00,0x00,0x48,0xB9,0x10,0x96,0x5F,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x2F,0x00,0x00,0x00,0xE8,0x83,0xB6,0x46,0x5F,0x0F,0xB7,0x1D,0x44,0x05,0xAA,0xFF,0x40,0x0F,0xB6,0xCE,0x8B,0xF1,0x48,0xB9,0x10,0x96,0x5F,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x26,0x00,0x00,0x00,0xE8,0x62,0xB6,0x46,0x5F,0x48,0xB8,0x60,0x71,0x00,0x10,0xEC,0x01,0x00,0x00,0x48,0x8B,0x00,0x0F,0xB6,0x40,0x08,0x8B,0x94,0x24,0x88,0x00,0x00,0x00,0x0F,0xB6,0xD2,0x8B,0xCB,0x0F,0xB6,0xD2,0x4C,0x8B,0xC6,0xC4,0xE1,0xF9,0x6E,0xC2,0xC4,0xC1,0xF9,0x6E,0xC8,0xC4,0xE3,0x79,0x44,0xC1,0x00,0xC5,0xF9,0x29,0x44,0x24,0x60,0xC5,0xFA,0x6F,0x44,0x24,0x60,0xC5,0xFA,0x7F,0x44,0x24,0x78,0x48,0x8B,0x54,0x24,0x78,0x0F,0xB7,0xD2,0x44,0x8B,0xC2,0x41,0xC1,0xF8,0x08,0x45,0x0F,0xB7,0xC0,0x44,0x8B,0xC9,0xC4,0xC1,0xF9,0x6E,0xC0,0xC4,0xC1,0xF9,0x6E,0xC9,0xC4,0xE3,0x79,0x44,0xC1,0x00,0xC5,0xF9,0x29,0x44,0x24,0x40,0xC5,0xFA,0x6F,0x44,0x24,0x40,0xC5,0xFA,0x7F,0x44,0x24,0x50,0x44,0x8B,0x44,0x24,0x50,0x45,0x0F,0xB7,0xC0,0x41,0x33,0xD0,0x0F,0xB7,0xD2,0x44,0x8B,0xC2,0x41,0xC1,0xF8,0x08,0x45,0x0F,0xB7,0xC0,0x8B,0xC9,0xC4,0xC1,0xF9,0x6E,0xC0,0xC4,0xE1,0xF9,0x6E,0xC9,0xC4,0xE3,0x79,0x44,0xC1,0x00,0xC5,0xF9,0x29,0x44,0x24,0x20,0xC5,0xFA,0x6F,0x44,0x24,0x20,0xC5,0xFA,0x7F,0x44,0x24,0x30,0x8B,0x4C,0x24,0x30,0x0F,0xB7,0xC9,0x33,0xCA,0x0F,0xB7,0xD1,0x0F,0xB6,0xD2,0x88,0x94,0x24,0x88,0x00,0x00,0x00,0x0F,0xB6,0xD0,0x8B,0x8C,0x24,0x88,0x00,0x00,0x00,0x0F,0xB6,0xC9,0x3B,0xCA,0x74,0x1B,0xFF,0xC7,0x81,0xFF,0x00,0x01,0x00,0x00,0x0F,0x8C,0x21,0xFF,0xFF,0xFF,0x33,0xC0,0x48,0x81,0xC4,0x90,0x00,0x00,0x00,0x5B,0x5E,0x5F,0xC3,0x8B,0xC7,0x48,0x81,0xC4,0x90,0x00,0x00,0x00,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit parity(BitVector4 src)
; location: [7FFDD9B59380h, 7FFDD9B59397h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
000ch test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000eh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> parityBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF3,0x0F,0xB8,0xC0,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit parity(BitVector8 src)
; location: [7FFDD9B593B0h, 7FFDD9B593C7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
000ch test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000eh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> parityBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF3,0x0F,0xB8,0xC0,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit parity(BitVector16 src)
; location: [7FFDD9B593E0h, 7FFDD9B593F7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
000ch test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000eh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> parityBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF3,0x0F,0xB8,0xC0,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit parity(BitVector32 src)
; location: [7FFDD9B59410h, 7FFDD9B59426h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt eax,ecx                ; POPCNT(Popcnt_r32_rm32) [EAX,ECX]                    encoding(4 bytes) = f3 0f b8 c1
000bh test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000dh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> parityBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x0F,0xB8,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit parity(BitVector64 src)
; location: [7FFDD9B59440h, 7FFDD9B59457h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt rax,rcx                ; POPCNT(Popcnt_r64_rm64) [RAX,RCX]                    encoding(5 bytes) = f3 48 0f b8 c1
000ch test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000eh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> parityBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xB8,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<BitVector4> partition(BitVector16 src, Span<BitVector4> dst)
; location: [7FFDD9B59870h, 7FFDD9B598BEh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000eh mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
0013h mov rbx,rcx                   ; MOV(Mov_r64_rm64) [RBX,RCX]                          encoding(3 bytes) = 48 8b d9
0016h mov rsi,r8                    ; MOV(Mov_r64_rm64) [RSI,R8]                           encoding(3 bytes) = 49 8b f0
0019h mov rcx,[rsi]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSI:br,DS:sr)]        encoding(3 bytes) = 48 8b 0e
001ch mov eax,[rsi+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSI:br,DS:sr)]        encoding(3 bytes) = 8b 46 08
001fh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0022h lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 20
0027h mov [r8],rcx                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RCX]         encoding(3 bytes) = 49 89 08
002ah mov [r8+8],eax                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(4 bytes) = 41 89 40 08
002eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0030h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 20
0035h call 7FFDD94AD700h            ; CALL(Call_rel32_64) [FFFFFFFFFF953E90h:jmp64]        encoding(5 bytes) = e8 56 3e 95 ff
003ah mov rdi,rbx                   ; MOV(Mov_r64_rm64) [RDI,RBX]                          encoding(3 bytes) = 48 8b fb
003dh call 7FFE38FC3690h            ; CALL(Call_rel32_64) [5F469E20h:jmp64]                encoding(5 bytes) = e8 de 9d 46 5f
0042h movsq                         ; MOVSQ(Movsq_m64_m64) [mem(64u),mem(64u,DS:sr)]       encoding(2 bytes) = 48 a5
0044h mov rax,rbx                   ; MOV(Mov_r64_rm64) [RAX,RBX]                          encoding(3 bytes) = 48 8b c3
0047h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
004bh pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
004ch pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
004dh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
004eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> partitionBytes => new byte[79]{0x57,0x56,0x53,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xD9,0x49,0x8B,0xF0,0x48,0x8B,0x0E,0x8B,0x46,0x08,0x0F,0xB7,0xD2,0x4C,0x8D,0x44,0x24,0x20,0x49,0x89,0x08,0x41,0x89,0x40,0x08,0x8B,0xCA,0x48,0x8D,0x54,0x24,0x20,0xE8,0x56,0x3E,0x95,0xFF,0x48,0x8B,0xFB,0xE8,0xDE,0x9D,0x46,0x5F,0x48,0xA5,0x48,0x8B,0xC3,0x48,0x83,0xC4,0x30,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<BitVector8> partition(BitVector16 src, Span<BitVector8> dst)
; location: [7FFDD9B59CE0h, 7FFDD9B59D2Eh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000eh mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
0013h mov rbx,rcx                   ; MOV(Mov_r64_rm64) [RBX,RCX]                          encoding(3 bytes) = 48 8b d9
0016h mov rsi,r8                    ; MOV(Mov_r64_rm64) [RSI,R8]                           encoding(3 bytes) = 49 8b f0
0019h mov rcx,[rsi]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSI:br,DS:sr)]        encoding(3 bytes) = 48 8b 0e
001ch mov eax,[rsi+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSI:br,DS:sr)]        encoding(3 bytes) = 8b 46 08
001fh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0022h lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 20
0027h mov [r8],rcx                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RCX]         encoding(3 bytes) = 49 89 08
002ah mov [r8+8],eax                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(4 bytes) = 41 89 40 08
002eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0030h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 20
0035h call 7FFDD94AD7C0h            ; CALL(Call_rel32_64) [FFFFFFFFFF953AE0h:jmp64]        encoding(5 bytes) = e8 a6 3a 95 ff
003ah mov rdi,rbx                   ; MOV(Mov_r64_rm64) [RDI,RBX]                          encoding(3 bytes) = 48 8b fb
003dh call 7FFE38FC3690h            ; CALL(Call_rel32_64) [5F4699B0h:jmp64]                encoding(5 bytes) = e8 6e 99 46 5f
0042h movsq                         ; MOVSQ(Movsq_m64_m64) [mem(64u),mem(64u,DS:sr)]       encoding(2 bytes) = 48 a5
0044h mov rax,rbx                   ; MOV(Mov_r64_rm64) [RAX,RBX]                          encoding(3 bytes) = 48 8b c3
0047h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
004bh pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
004ch pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
004dh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
004eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> partitionBytes => new byte[79]{0x57,0x56,0x53,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xD9,0x49,0x8B,0xF0,0x48,0x8B,0x0E,0x8B,0x46,0x08,0x0F,0xB7,0xD2,0x4C,0x8D,0x44,0x24,0x20,0x49,0x89,0x08,0x41,0x89,0x40,0x08,0x8B,0xCA,0x48,0x8D,0x54,0x24,0x20,0xE8,0xA6,0x3A,0x95,0xFF,0x48,0x8B,0xFB,0xE8,0x6E,0x99,0x46,0x5F,0x48,0xA5,0x48,0x8B,0xC3,0x48,0x83,0xC4,0x30,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<BitVector4> partition(BitVector32 src, Span<BitVector4> dst)
; location: [7FFDD9B59D50h, 7FFDD9B59D9Bh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000eh mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
0013h mov rbx,rcx                   ; MOV(Mov_r64_rm64) [RBX,RCX]                          encoding(3 bytes) = 48 8b d9
0016h mov rsi,r8                    ; MOV(Mov_r64_rm64) [RSI,R8]                           encoding(3 bytes) = 49 8b f0
0019h mov rcx,[rsi]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSI:br,DS:sr)]        encoding(3 bytes) = 48 8b 0e
001ch mov eax,[rsi+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSI:br,DS:sr)]        encoding(3 bytes) = 8b 46 08
001fh lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 20
0024h mov [r8],rcx                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RCX]         encoding(3 bytes) = 49 89 08
0027h mov [r8+8],eax                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(4 bytes) = 41 89 40 08
002bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
002dh lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 20
0032h call 7FFDD94AD708h            ; CALL(Call_rel32_64) [FFFFFFFFFF9539B8h:jmp64]        encoding(5 bytes) = e8 81 39 95 ff
0037h mov rdi,rbx                   ; MOV(Mov_r64_rm64) [RDI,RBX]                          encoding(3 bytes) = 48 8b fb
003ah call 7FFE38FC3690h            ; CALL(Call_rel32_64) [5F469940h:jmp64]                encoding(5 bytes) = e8 01 99 46 5f
003fh movsq                         ; MOVSQ(Movsq_m64_m64) [mem(64u),mem(64u,DS:sr)]       encoding(2 bytes) = 48 a5
0041h mov rax,rbx                   ; MOV(Mov_r64_rm64) [RAX,RBX]                          encoding(3 bytes) = 48 8b c3
0044h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0048h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0049h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
004ah pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
004bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> partitionBytes => new byte[76]{0x57,0x56,0x53,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xD9,0x49,0x8B,0xF0,0x48,0x8B,0x0E,0x8B,0x46,0x08,0x4C,0x8D,0x44,0x24,0x20,0x49,0x89,0x08,0x41,0x89,0x40,0x08,0x8B,0xCA,0x48,0x8D,0x54,0x24,0x20,0xE8,0x81,0x39,0x95,0xFF,0x48,0x8B,0xFB,0xE8,0x01,0x99,0x46,0x5F,0x48,0xA5,0x48,0x8B,0xC3,0x48,0x83,0xC4,0x30,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<BitVector8> partition(BitVector32 src, Span<BitVector8> dst)
; location: [7FFDD9B59DC0h, 7FFDD9B59E0Bh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000eh mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
0013h mov rbx,rcx                   ; MOV(Mov_r64_rm64) [RBX,RCX]                          encoding(3 bytes) = 48 8b d9
0016h mov rsi,r8                    ; MOV(Mov_r64_rm64) [RSI,R8]                           encoding(3 bytes) = 49 8b f0
0019h mov rcx,[rsi]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSI:br,DS:sr)]        encoding(3 bytes) = 48 8b 0e
001ch mov eax,[rsi+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSI:br,DS:sr)]        encoding(3 bytes) = 8b 46 08
001fh lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 20
0024h mov [r8],rcx                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RCX]         encoding(3 bytes) = 49 89 08
0027h mov [r8+8],eax                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(4 bytes) = 41 89 40 08
002bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
002dh lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 20
0032h call 7FFDD94AD7C8h            ; CALL(Call_rel32_64) [FFFFFFFFFF953A08h:jmp64]        encoding(5 bytes) = e8 d1 39 95 ff
0037h mov rdi,rbx                   ; MOV(Mov_r64_rm64) [RDI,RBX]                          encoding(3 bytes) = 48 8b fb
003ah call 7FFE38FC3690h            ; CALL(Call_rel32_64) [5F4698D0h:jmp64]                encoding(5 bytes) = e8 91 98 46 5f
003fh movsq                         ; MOVSQ(Movsq_m64_m64) [mem(64u),mem(64u,DS:sr)]       encoding(2 bytes) = 48 a5
0041h mov rax,rbx                   ; MOV(Mov_r64_rm64) [RAX,RBX]                          encoding(3 bytes) = 48 8b c3
0044h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0048h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0049h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
004ah pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
004bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> partitionBytes => new byte[76]{0x57,0x56,0x53,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xD9,0x49,0x8B,0xF0,0x48,0x8B,0x0E,0x8B,0x46,0x08,0x4C,0x8D,0x44,0x24,0x20,0x49,0x89,0x08,0x41,0x89,0x40,0x08,0x8B,0xCA,0x48,0x8D,0x54,0x24,0x20,0xE8,0xD1,0x39,0x95,0xFF,0x48,0x8B,0xFB,0xE8,0x91,0x98,0x46,0x5F,0x48,0xA5,0x48,0x8B,0xC3,0x48,0x83,0xC4,0x30,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<BitVector16> partition(BitVector32 src, Span<BitVector16> dst)
; location: [7FFDD9B59E30h, 7FFDD9B59E78h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0007h mov rbx,rcx                   ; MOV(Mov_r64_rm64) [RBX,RCX]                          encoding(3 bytes) = 48 8b d9
000ah mov rax,[r8]                  ; MOV(Mov_r64_rm64) [RAX,mem(64u,R8:br,DS:sr)]         encoding(3 bytes) = 49 8b 00
000dh mov ecx,[r8+8]                ; MOV(Mov_r32_rm32) [ECX,mem(32u,R8:br,DS:sr)]         encoding(4 bytes) = 41 8b 48 08
0011h cmp ecx,0                     ; CMP(Cmp_rm32_imm8) [ECX,0h:imm32]                    encoding(3 bytes) = 83 f9 00
0014h jbe short 0043h               ; JBE(Jbe_rel8_64) [43h:jmp64]                         encoding(2 bytes) = 76 2d
0016h mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 10
0019h cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
001ch jbe short 0043h               ; JBE(Jbe_rel8_64) [43h:jmp64]                         encoding(2 bytes) = 76 25
001eh shr edx,10h                   ; SHR(Shr_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 ea 10
0021h mov [rax+2],dx                ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(4 bytes) = 66 89 50 02
0025h mov rdi,rbx                   ; MOV(Mov_r64_rm64) [RDI,RBX]                          encoding(3 bytes) = 48 8b fb
0028h mov rsi,r8                    ; MOV(Mov_r64_rm64) [RSI,R8]                           encoding(3 bytes) = 49 8b f0
002bh call 7FFE38FC3690h            ; CALL(Call_rel32_64) [5F469860h:jmp64]                encoding(5 bytes) = e8 30 98 46 5f
0030h movsq                         ; MOVSQ(Movsq_m64_m64) [mem(64u),mem(64u,DS:sr)]       encoding(2 bytes) = 48 a5
0032h mov rax,rbx                   ; MOV(Mov_r64_rm64) [RAX,RBX]                          encoding(3 bytes) = 48 8b c3
0035h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0039h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
003ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
003bh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
003ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003dh call 7FFE390EED50h            ; CALL(Call_rel32_64) [5F594F20h:jmp64]                encoding(5 bytes) = e8 de 4e 59 5f
0042h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
0043h call 7FFE390EEF00h            ; CALL(Call_rel32_64) [5F5950D0h:jmp64]                encoding(5 bytes) = e8 88 50 59 5f
0048h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> partitionBytes => new byte[73]{0x57,0x56,0x53,0x48,0x83,0xEC,0x20,0x48,0x8B,0xD9,0x49,0x8B,0x00,0x41,0x8B,0x48,0x08,0x83,0xF9,0x00,0x76,0x2D,0x66,0x89,0x10,0x83,0xF9,0x01,0x76,0x25,0xC1,0xEA,0x10,0x66,0x89,0x50,0x02,0x48,0x8B,0xFB,0x49,0x8B,0xF0,0xE8,0x30,0x98,0x46,0x5F,0x48,0xA5,0x48,0x8B,0xC3,0x48,0x83,0xC4,0x20,0x5B,0x5E,0x5F,0xC3,0xE8,0xDE,0x4E,0x59,0x5F,0xCC,0xE8,0x88,0x50,0x59,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector16 perm(ref BitVector16 x, in Perm spec)
; location: [7FFDD9B5A350h, 7FFDD9B5A40Eh]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 30
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh movzx ecx,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [ECX,mem(16u,RAX:br,DS:sr)]    encoding(3 bytes) = 0f b7 08
0011h mov [rsp+30h],cx              ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,SS:sr),CX]         encoding(5 bytes) = 66 89 4c 24 30
0016h xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0019h jmp near ptr 00aah            ; JMP(Jmp_rel32_64) [AAh:jmp64]                        encoding(5 bytes) = e9 8c 00 00 00
001eh mov rcx,[rdx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 0a
0021h cmp r8d,[rcx+8]               ; CMP(Cmp_r32_rm32) [R8D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 3b 41 08
0025h jae near ptr 00b9h            ; JAE(Jae_rel32_64) [B9h:jmp64]                        encoding(6 bytes) = 0f 83 8e 00 00 00
002bh movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
002eh lea rcx,[rcx+r9*4+10h]        ; LEA(Lea_r64_m) [RCX,mem(Unknown,RCX:br,DS:sr)]       encoding(5 bytes) = 4a 8d 4c 89 10
0033h mov ecx,[rcx]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 09
0035h cmp ecx,r8d                   ; CMP(Cmp_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 3b c8
0038h je short 00a7h                ; JE(Je_rel8_64) [A7h:jmp64]                           encoding(2 bytes) = 74 6d
003ah movzx r9d,r8b                 ; MOVZX(Movzx_r32_rm8) [R9D,R8L]                       encoding(4 bytes) = 45 0f b6 c8
003eh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0041h mov r10d,[rsp+30h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RSP:br,SS:sr)]       encoding(5 bytes) = 44 8b 54 24 30
0046h movzx r10d,r10w               ; MOVZX(Movzx_r32_rm16) [R10D,R10W]                    encoding(4 bytes) = 45 0f b7 d2
004ah movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
004dh bt r10d,ecx                   ; BT(Bt_rm32_r32) [R10D,ECX]                           encoding(4 bytes) = 41 0f a3 ca
0051h setb cl                       ; SETB(Setb_rm8) [CL]                                  encoding(3 bytes) = 0f 92 c1
0054h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0057h mov [rsp+28h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(4 bytes) = 88 4c 24 28
005bh movzx ecx,byte ptr [rsp+28h]  ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 4c 24 28
0060h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0064h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0066h jne short 006ch               ; JNE(Jne_rel8_64) [6Ch:jmp64]                         encoding(2 bytes) = 75 04
0068h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
006ah jmp short 0071h               ; JMP(Jmp_rel8_64) [71h:jmp64]                         encoding(2 bytes) = eb 05
006ch mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
0071h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0075h cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
0078h jne short 008fh               ; JNE(Jne_rel8_64) [8Fh:jmp64]                         encoding(2 bytes) = 75 15
007ah mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0080h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0083h shl r10d,cl                   ; SHL(Shl_rm32_CL) [R10D,CL]                           encoding(3 bytes) = 41 d3 e2
0086h movzx ecx,r10w                ; MOVZX(Movzx_r32_rm16) [ECX,R10W]                     encoding(4 bytes) = 41 0f b7 ca
008ah or [rax],cx                   ; OR(Or_rm16_r16) [mem(16u,RAX:br,DS:sr),CX]           encoding(3 bytes) = 66 09 08
008dh jmp short 00a7h               ; JMP(Jmp_rel8_64) [A7h:jmp64]                         encoding(2 bytes) = eb 18
008fh mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0095h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0098h shl r10d,cl                   ; SHL(Shl_rm32_CL) [R10D,CL]                           encoding(3 bytes) = 41 d3 e2
009bh movzx ecx,r10w                ; MOVZX(Movzx_r32_rm16) [ECX,R10W]                     encoding(4 bytes) = 41 0f b7 ca
009fh not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
00a1h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
00a4h and [rax],cx                  ; AND(And_rm16_r16) [mem(16u,RAX:br,DS:sr),CX]         encoding(3 bytes) = 66 21 08
00a7h inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
00aah cmp r8d,10h                   ; CMP(Cmp_rm32_imm8) [R8D,10h:imm32]                   encoding(4 bytes) = 41 83 f8 10
00aeh jl near ptr 001eh             ; JL(Jl_rel32_64) [1Eh:jmp64]                          encoding(6 bytes) = 0f 8c 6a ff ff ff
00b4h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
00b8h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00b9h call 7FFE390EEF00h            ; CALL(Call_rel32_64) [5F594BB0h:jmp64]                encoding(5 bytes) = e8 f2 4a 59 5f
00beh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> permBytes => new byte[191]{0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x30,0x48,0x8B,0xC1,0x0F,0xB7,0x08,0x66,0x89,0x4C,0x24,0x30,0x45,0x33,0xC0,0xE9,0x8C,0x00,0x00,0x00,0x48,0x8B,0x0A,0x44,0x3B,0x41,0x08,0x0F,0x83,0x8E,0x00,0x00,0x00,0x4D,0x63,0xC8,0x4A,0x8D,0x4C,0x89,0x10,0x8B,0x09,0x41,0x3B,0xC8,0x74,0x6D,0x45,0x0F,0xB6,0xC8,0x0F,0xB6,0xC9,0x44,0x8B,0x54,0x24,0x30,0x45,0x0F,0xB7,0xD2,0x0F,0xB6,0xC9,0x41,0x0F,0xA3,0xCA,0x0F,0x92,0xC1,0x0F,0xB6,0xC9,0x88,0x4C,0x24,0x28,0x0F,0xB6,0x4C,0x24,0x28,0x45,0x0F,0xB6,0xC9,0x84,0xC9,0x75,0x04,0x33,0xC9,0xEB,0x05,0xB9,0x01,0x00,0x00,0x00,0x45,0x0F,0xB6,0xC9,0x83,0xF9,0x01,0x75,0x15,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x41,0xD3,0xE2,0x41,0x0F,0xB7,0xCA,0x66,0x09,0x08,0xEB,0x18,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x41,0xD3,0xE2,0x41,0x0F,0xB7,0xCA,0xF7,0xD1,0x0F,0xB7,0xC9,0x66,0x21,0x08,0x41,0xFF,0xC0,0x41,0x83,0xF8,0x10,0x0F,0x8C,0x6A,0xFF,0xFF,0xFF,0x48,0x83,0xC4,0x38,0xC3,0xE8,0xF2,0x4A,0x59,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 perm(BitVector16 x, Perm spec)
; location: [7FFDD9B5A430h, 7FFDD9B5A50Dh]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 30
000bh mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
0010h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0013h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0016h mov [rsp+30h],cx              ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,SS:sr),CX]         encoding(5 bytes) = 66 89 4c 24 30
001bh mov ecx,[rsp+30h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 30
001fh movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0022h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0025h mov [rsp+28h],cx              ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,SS:sr),CX]         encoding(5 bytes) = 66 89 4c 24 28
002ah lea rax,[rsp+30h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 30
002fh xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0032h jmp near ptr 00c0h            ; JMP(Jmp_rel32_64) [C0h:jmp64]                        encoding(5 bytes) = e9 89 00 00 00
0037h cmp r8d,[rdx+8]               ; CMP(Cmp_r32_rm32) [R8D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 3b 42 08
003bh jae near ptr 00d8h            ; JAE(Jae_rel32_64) [D8h:jmp64]                        encoding(6 bytes) = 0f 83 97 00 00 00
0041h movsxd rcx,r8d                ; MOVSXD(Movsxd_r64_rm32) [RCX,R8D]                    encoding(3 bytes) = 49 63 c8
0044h lea rcx,[rdx+rcx*4+10h]       ; LEA(Lea_r64_m) [RCX,mem(Unknown,RDX:br,DS:sr)]       encoding(5 bytes) = 48 8d 4c 8a 10
0049h mov ecx,[rcx]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 09
004bh cmp ecx,r8d                   ; CMP(Cmp_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 3b c8
004eh je short 00bdh                ; JE(Je_rel8_64) [BDh:jmp64]                           encoding(2 bytes) = 74 6d
0050h movzx r9d,r8b                 ; MOVZX(Movzx_r32_rm8) [R9D,R8L]                       encoding(4 bytes) = 45 0f b6 c8
0054h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0057h mov r10d,[rsp+28h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RSP:br,SS:sr)]       encoding(5 bytes) = 44 8b 54 24 28
005ch movzx r10d,r10w               ; MOVZX(Movzx_r32_rm16) [R10D,R10W]                    encoding(4 bytes) = 45 0f b7 d2
0060h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0063h bt r10d,ecx                   ; BT(Bt_rm32_r32) [R10D,ECX]                           encoding(4 bytes) = 41 0f a3 ca
0067h setb cl                       ; SETB(Setb_rm8) [CL]                                  encoding(3 bytes) = 0f 92 c1
006ah movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
006dh mov [rsp+20h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(4 bytes) = 88 4c 24 20
0071h movzx ecx,byte ptr [rsp+20h]  ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 4c 24 20
0076h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
007ah test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
007ch jne short 0082h               ; JNE(Jne_rel8_64) [82h:jmp64]                         encoding(2 bytes) = 75 04
007eh xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0080h jmp short 0087h               ; JMP(Jmp_rel8_64) [87h:jmp64]                         encoding(2 bytes) = eb 05
0082h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
0087h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
008bh cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
008eh jne short 00a5h               ; JNE(Jne_rel8_64) [A5h:jmp64]                         encoding(2 bytes) = 75 15
0090h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0096h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0099h shl r10d,cl                   ; SHL(Shl_rm32_CL) [R10D,CL]                           encoding(3 bytes) = 41 d3 e2
009ch movzx ecx,r10w                ; MOVZX(Movzx_r32_rm16) [ECX,R10W]                     encoding(4 bytes) = 41 0f b7 ca
00a0h or [rax],cx                   ; OR(Or_rm16_r16) [mem(16u,RAX:br,DS:sr),CX]           encoding(3 bytes) = 66 09 08
00a3h jmp short 00bdh               ; JMP(Jmp_rel8_64) [BDh:jmp64]                         encoding(2 bytes) = eb 18
00a5h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
00abh mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
00aeh shl r10d,cl                   ; SHL(Shl_rm32_CL) [R10D,CL]                           encoding(3 bytes) = 41 d3 e2
00b1h movzx ecx,r10w                ; MOVZX(Movzx_r32_rm16) [ECX,R10W]                     encoding(4 bytes) = 41 0f b7 ca
00b5h not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
00b7h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
00bah and [rax],cx                  ; AND(And_rm16_r16) [mem(16u,RAX:br,DS:sr),CX]         encoding(3 bytes) = 66 21 08
00bdh inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
00c0h cmp r8d,10h                   ; CMP(Cmp_rm32_imm8) [R8D,10h:imm32]                   encoding(4 bytes) = 41 83 f8 10
00c4h jl near ptr 0037h             ; JL(Jl_rel32_64) [37h:jmp64]                          encoding(6 bytes) = 0f 8c 6d ff ff ff
00cah lea rax,[rsp+30h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 30
00cfh movsx rax,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RAX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 00
00d3h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
00d7h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00d8h call 7FFE390EEF00h            ; CALL(Call_rel32_64) [5F594AD0h:jmp64]                encoding(5 bytes) = e8 f3 49 59 5f
00ddh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> permBytes => new byte[222]{0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x28,0x0F,0xB7,0xC9,0x0F,0xB7,0xC9,0x66,0x89,0x4C,0x24,0x30,0x8B,0x4C,0x24,0x30,0x0F,0xB7,0xC9,0x0F,0xB7,0xC9,0x66,0x89,0x4C,0x24,0x28,0x48,0x8D,0x44,0x24,0x30,0x45,0x33,0xC0,0xE9,0x89,0x00,0x00,0x00,0x44,0x3B,0x42,0x08,0x0F,0x83,0x97,0x00,0x00,0x00,0x49,0x63,0xC8,0x48,0x8D,0x4C,0x8A,0x10,0x8B,0x09,0x41,0x3B,0xC8,0x74,0x6D,0x45,0x0F,0xB6,0xC8,0x0F,0xB6,0xC9,0x44,0x8B,0x54,0x24,0x28,0x45,0x0F,0xB7,0xD2,0x0F,0xB6,0xC9,0x41,0x0F,0xA3,0xCA,0x0F,0x92,0xC1,0x0F,0xB6,0xC9,0x88,0x4C,0x24,0x20,0x0F,0xB6,0x4C,0x24,0x20,0x45,0x0F,0xB6,0xC9,0x84,0xC9,0x75,0x04,0x33,0xC9,0xEB,0x05,0xB9,0x01,0x00,0x00,0x00,0x45,0x0F,0xB6,0xC9,0x83,0xF9,0x01,0x75,0x15,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x41,0xD3,0xE2,0x41,0x0F,0xB7,0xCA,0x66,0x09,0x08,0xEB,0x18,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x41,0xD3,0xE2,0x41,0x0F,0xB7,0xCA,0xF7,0xD1,0x0F,0xB7,0xC9,0x66,0x21,0x08,0x41,0xFF,0xC0,0x41,0x83,0xF8,0x10,0x0F,0x8C,0x6D,0xFF,0xFF,0xFF,0x48,0x8D,0x44,0x24,0x30,0x48,0x0F,0xBF,0x00,0x48,0x83,0xC4,0x38,0xC3,0xE8,0xF3,0x49,0x59,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector32 perm(ref BitVector32 x, in Perm spec)
; location: [7FFDD9B5A530h, 7FFDD9B5A5EEh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0007h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000ah mov rdi,rdx                   ; MOV(Mov_r64_rm64) [RDI,RDX]                          encoding(3 bytes) = 48 8b fa
000dh mov ebx,[rsi]                 ; MOV(Mov_r32_rm32) [EBX,mem(32u,RSI:br,DS:sr)]        encoding(2 bytes) = 8b 1e
000fh mov rcx,7FFDD95F9610h         ; MOV(Mov_r64_imm64) [RCX,7ffdd95f9610h:imm64]         encoding(10 bytes) = 48 b9 10 96 5f d9 fd 7f 00 00
0019h mov edx,22h                   ; MOV(Mov_r32_imm32) [EDX,22h:imm32]                   encoding(5 bytes) = ba 22 00 00 00
001eh call 7FFE38FC48B0h            ; CALL(Call_rel32_64) [5F46A380h:jmp64]                encoding(5 bytes) = e8 5d a3 46 5f
0023h mov rcx,1EC10007018h          ; MOV(Mov_r64_imm64) [RCX,1ec10007018h:imm64]          encoding(10 bytes) = 48 b9 18 70 00 10 ec 01 00 00
002dh mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
0030h mov rax,[rcx+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(4 bytes) = 48 8b 41 08
0034h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0036h jmp short 00aah               ; JMP(Jmp_rel8_64) [AAh:jmp64]                         encoding(2 bytes) = eb 72
0038h mov rcx,[rdi]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RDI:br,DS:sr)]        encoding(3 bytes) = 48 8b 0f
003bh cmp edx,[rcx+8]               ; CMP(Cmp_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 3b 51 08
003eh jae short 00b9h               ; JAE(Jae_rel8_64) [B9h:jmp64]                         encoding(2 bytes) = 73 79
0040h movsxd r8,edx                 ; MOVSXD(Movsxd_r64_rm32) [R8,EDX]                     encoding(3 bytes) = 4c 63 c2
0043h lea rcx,[rcx+r8*4+10h]        ; LEA(Lea_r64_m) [RCX,mem(Unknown,RCX:br,DS:sr)]       encoding(5 bytes) = 4a 8d 4c 81 10
0048h mov ecx,[rcx]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 09
004ah cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
004ch je short 00a8h                ; JE(Je_rel8_64) [A8h:jmp64]                           encoding(2 bytes) = 74 5a
004eh movzx r8d,dl                  ; MOVZX(Movzx_r32_rm8) [R8D,DL]                        encoding(4 bytes) = 44 0f b6 c2
0052h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0055h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0058h bt ebx,ecx                    ; BT(Bt_rm32_r32) [EBX,ECX]                            encoding(3 bytes) = 0f a3 cb
005bh setb cl                       ; SETB(Setb_rm8) [CL]                                  encoding(3 bytes) = 0f 92 c1
005eh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0061h mov [rsp+28h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(4 bytes) = 88 4c 24 28
0065h movzx ecx,byte ptr [rsp+28h]  ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 4c 24 28
006ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
006eh test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0070h jne short 0076h               ; JNE(Jne_rel8_64) [76h:jmp64]                         encoding(2 bytes) = 75 04
0072h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0074h jmp short 007bh               ; JMP(Jmp_rel8_64) [7Bh:jmp64]                         encoding(2 bytes) = eb 05
0076h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
007bh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
007fh cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
0082h jne short 0095h               ; JNE(Jne_rel8_64) [95h:jmp64]                         encoding(2 bytes) = 75 11
0084h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
008ah mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
008dh shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
0090h or [rsi],r9d                  ; OR(Or_rm32_r32) [mem(32u,RSI:br,DS:sr),R9D]          encoding(3 bytes) = 44 09 0e
0093h jmp short 00a8h               ; JMP(Jmp_rel8_64) [A8h:jmp64]                         encoding(2 bytes) = eb 13
0095h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
009bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
009eh shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
00a1h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
00a4h not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
00a6h and [rsi],ecx                 ; AND(And_rm32_r32) [mem(32u,RSI:br,DS:sr),ECX]        encoding(2 bytes) = 21 0e
00a8h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
00aah cmp edx,eax                   ; CMP(Cmp_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 3b d0
00ach jl short 0038h                ; JL(Jl_rel8_64) [38h:jmp64]                           encoding(2 bytes) = 7c 8a
00aeh mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
00b1h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
00b5h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00b6h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00b7h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00b8h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00b9h call 7FFE390EEF00h            ; CALL(Call_rel32_64) [5F5949D0h:jmp64]                encoding(5 bytes) = e8 12 49 59 5f
00beh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> permBytes => new byte[191]{0x57,0x56,0x53,0x48,0x83,0xEC,0x30,0x48,0x8B,0xF1,0x48,0x8B,0xFA,0x8B,0x1E,0x48,0xB9,0x10,0x96,0x5F,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x22,0x00,0x00,0x00,0xE8,0x5D,0xA3,0x46,0x5F,0x48,0xB9,0x18,0x70,0x00,0x10,0xEC,0x01,0x00,0x00,0x48,0x8B,0x09,0x48,0x8B,0x41,0x08,0x33,0xD2,0xEB,0x72,0x48,0x8B,0x0F,0x3B,0x51,0x08,0x73,0x79,0x4C,0x63,0xC2,0x4A,0x8D,0x4C,0x81,0x10,0x8B,0x09,0x3B,0xCA,0x74,0x5A,0x44,0x0F,0xB6,0xC2,0x0F,0xB6,0xC9,0x0F,0xB6,0xC9,0x0F,0xA3,0xCB,0x0F,0x92,0xC1,0x0F,0xB6,0xC9,0x88,0x4C,0x24,0x28,0x0F,0xB6,0x4C,0x24,0x28,0x45,0x0F,0xB6,0xC0,0x84,0xC9,0x75,0x04,0x33,0xC9,0xEB,0x05,0xB9,0x01,0x00,0x00,0x00,0x45,0x0F,0xB6,0xC0,0x83,0xF9,0x01,0x75,0x11,0x41,0xB9,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x41,0xD3,0xE1,0x44,0x09,0x0E,0xEB,0x13,0x41,0xB9,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x41,0xD3,0xE1,0x41,0x8B,0xC9,0xF7,0xD1,0x21,0x0E,0xFF,0xC2,0x3B,0xD0,0x7C,0x8A,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x30,0x5B,0x5E,0x5F,0xC3,0xE8,0x12,0x49,0x59,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 perm(BitVector32 x, Perm spec)
; location: [7FFDD9B5A610h, 7FFDD9B5A6E2h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
000eh mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0011h mov [rsp+28h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 28
0015h mov edi,[rsp+28h]             ; MOV(Mov_r32_rm32) [EDI,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 7c 24 28
0019h lea rbx,[rsp+28h]             ; LEA(Lea_r64_m) [RBX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 5c 24 28
001eh mov rcx,7FFDD95F9610h         ; MOV(Mov_r64_imm64) [RCX,7ffdd95f9610h:imm64]         encoding(10 bytes) = 48 b9 10 96 5f d9 fd 7f 00 00
0028h mov edx,22h                   ; MOV(Mov_r32_imm32) [EDX,22h:imm32]                   encoding(5 bytes) = ba 22 00 00 00
002dh call 7FFE38FC48B0h            ; CALL(Call_rel32_64) [5F46A2A0h:jmp64]                encoding(5 bytes) = e8 6e a2 46 5f
0032h mov rcx,1EC10007018h          ; MOV(Mov_r64_imm64) [RCX,1ec10007018h:imm64]          encoding(10 bytes) = 48 b9 18 70 00 10 ec 01 00 00
003ch mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
003fh mov rax,[rcx+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(4 bytes) = 48 8b 41 08
0043h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0045h jmp short 00bah               ; JMP(Jmp_rel8_64) [BAh:jmp64]                         encoding(2 bytes) = eb 73
0047h cmp edx,[rsi+8]               ; CMP(Cmp_r32_rm32) [EDX,mem(32u,RSI:br,DS:sr)]        encoding(3 bytes) = 3b 56 08
004ah jae near ptr 00cdh            ; JAE(Jae_rel32_64) [CDh:jmp64]                        encoding(6 bytes) = 0f 83 7d 00 00 00
0050h movsxd rcx,edx                ; MOVSXD(Movsxd_r64_rm32) [RCX,EDX]                    encoding(3 bytes) = 48 63 ca
0053h lea rcx,[rsi+rcx*4+10h]       ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(5 bytes) = 48 8d 4c 8e 10
0058h mov ecx,[rcx]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 09
005ah cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
005ch je short 00b8h                ; JE(Je_rel8_64) [B8h:jmp64]                           encoding(2 bytes) = 74 5a
005eh movzx r8d,dl                  ; MOVZX(Movzx_r32_rm8) [R8D,DL]                        encoding(4 bytes) = 44 0f b6 c2
0062h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0065h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0068h bt edi,ecx                    ; BT(Bt_rm32_r32) [EDI,ECX]                            encoding(3 bytes) = 0f a3 cf
006bh setb cl                       ; SETB(Setb_rm8) [CL]                                  encoding(3 bytes) = 0f 92 c1
006eh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0071h mov [rsp+20h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(4 bytes) = 88 4c 24 20
0075h movzx ecx,byte ptr [rsp+20h]  ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 4c 24 20
007ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
007eh test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0080h jne short 0086h               ; JNE(Jne_rel8_64) [86h:jmp64]                         encoding(2 bytes) = 75 04
0082h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0084h jmp short 008bh               ; JMP(Jmp_rel8_64) [8Bh:jmp64]                         encoding(2 bytes) = eb 05
0086h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
008bh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
008fh cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
0092h jne short 00a5h               ; JNE(Jne_rel8_64) [A5h:jmp64]                         encoding(2 bytes) = 75 11
0094h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
009ah mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
009dh shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
00a0h or [rbx],r9d                  ; OR(Or_rm32_r32) [mem(32u,RBX:br,DS:sr),R9D]          encoding(3 bytes) = 44 09 0b
00a3h jmp short 00b8h               ; JMP(Jmp_rel8_64) [B8h:jmp64]                         encoding(2 bytes) = eb 13
00a5h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
00abh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
00aeh shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
00b1h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
00b4h not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
00b6h and [rbx],ecx                 ; AND(And_rm32_r32) [mem(32u,RBX:br,DS:sr),ECX]        encoding(2 bytes) = 21 0b
00b8h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
00bah cmp edx,eax                   ; CMP(Cmp_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 3b d0
00bch jl short 0047h                ; JL(Jl_rel8_64) [47h:jmp64]                           encoding(2 bytes) = 7c 89
00beh lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
00c3h mov eax,[rax]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 00
00c5h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
00c9h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00cah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00cbh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00cch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00cdh call 7FFE390EEF00h            ; CALL(Call_rel32_64) [5F5948F0h:jmp64]                encoding(5 bytes) = e8 1e 48 59 5f
00d2h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> permBytes => new byte[211]{0x57,0x56,0x53,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x89,0x4C,0x24,0x28,0x8B,0x7C,0x24,0x28,0x48,0x8D,0x5C,0x24,0x28,0x48,0xB9,0x10,0x96,0x5F,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x22,0x00,0x00,0x00,0xE8,0x6E,0xA2,0x46,0x5F,0x48,0xB9,0x18,0x70,0x00,0x10,0xEC,0x01,0x00,0x00,0x48,0x8B,0x09,0x48,0x8B,0x41,0x08,0x33,0xD2,0xEB,0x73,0x3B,0x56,0x08,0x0F,0x83,0x7D,0x00,0x00,0x00,0x48,0x63,0xCA,0x48,0x8D,0x4C,0x8E,0x10,0x8B,0x09,0x3B,0xCA,0x74,0x5A,0x44,0x0F,0xB6,0xC2,0x0F,0xB6,0xC9,0x0F,0xB6,0xC9,0x0F,0xA3,0xCF,0x0F,0x92,0xC1,0x0F,0xB6,0xC9,0x88,0x4C,0x24,0x20,0x0F,0xB6,0x4C,0x24,0x20,0x45,0x0F,0xB6,0xC0,0x84,0xC9,0x75,0x04,0x33,0xC9,0xEB,0x05,0xB9,0x01,0x00,0x00,0x00,0x45,0x0F,0xB6,0xC0,0x83,0xF9,0x01,0x75,0x11,0x41,0xB9,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x41,0xD3,0xE1,0x44,0x09,0x0B,0xEB,0x13,0x41,0xB9,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x41,0xD3,0xE1,0x41,0x8B,0xC9,0xF7,0xD1,0x21,0x0B,0xFF,0xC2,0x3B,0xD0,0x7C,0x89,0x48,0x8D,0x44,0x24,0x28,0x8B,0x00,0x48,0x83,0xC4,0x30,0x5B,0x5E,0x5F,0xC3,0xE8,0x1E,0x48,0x59,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector64 perm(ref BitVector64 x, in Perm spec)
; location: [7FFDD9B5A700h, 7FFDD9B5A7C6h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0007h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000ah mov rdi,rdx                   ; MOV(Mov_r64_rm64) [RDI,RDX]                          encoding(3 bytes) = 48 8b fa
000dh mov rbx,[rsi]                 ; MOV(Mov_r64_rm64) [RBX,mem(64u,RSI:br,DS:sr)]        encoding(3 bytes) = 48 8b 1e
0010h mov rcx,7FFDD95F9610h         ; MOV(Mov_r64_imm64) [RCX,7ffdd95f9610h:imm64]         encoding(10 bytes) = 48 b9 10 96 5f d9 fd 7f 00 00
001ah mov edx,25h                   ; MOV(Mov_r32_imm32) [EDX,25h:imm32]                   encoding(5 bytes) = ba 25 00 00 00
001fh call 7FFE38FC48B0h            ; CALL(Call_rel32_64) [5F46A1B0h:jmp64]                encoding(5 bytes) = e8 8c a1 46 5f
0024h mov rcx,1EC10007148h          ; MOV(Mov_r64_imm64) [RCX,1ec10007148h:imm64]          encoding(10 bytes) = 48 b9 48 71 00 10 ec 01 00 00
002eh mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
0031h mov rax,[rcx+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(4 bytes) = 48 8b 41 08
0035h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0037h jmp short 00b2h               ; JMP(Jmp_rel8_64) [B2h:jmp64]                         encoding(2 bytes) = eb 79
0039h mov rcx,[rdi]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RDI:br,DS:sr)]        encoding(3 bytes) = 48 8b 0f
003ch cmp edx,[rcx+8]               ; CMP(Cmp_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 3b 51 08
003fh jae near ptr 00c1h            ; JAE(Jae_rel32_64) [C1h:jmp64]                        encoding(6 bytes) = 0f 83 7c 00 00 00
0045h movsxd r8,edx                 ; MOVSXD(Movsxd_r64_rm32) [R8,EDX]                     encoding(3 bytes) = 4c 63 c2
0048h lea rcx,[rcx+r8*4+10h]        ; LEA(Lea_r64_m) [RCX,mem(Unknown,RCX:br,DS:sr)]       encoding(5 bytes) = 4a 8d 4c 81 10
004dh mov ecx,[rcx]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 09
004fh cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0051h je short 00b0h                ; JE(Je_rel8_64) [B0h:jmp64]                           encoding(2 bytes) = 74 5d
0053h movzx r8d,dl                  ; MOVZX(Movzx_r32_rm8) [R8D,DL]                        encoding(4 bytes) = 44 0f b6 c2
0057h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
005ah movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
005dh bt rbx,rcx                    ; BT(Bt_rm64_r64) [RBX,RCX]                            encoding(4 bytes) = 48 0f a3 cb
0061h setb cl                       ; SETB(Setb_rm8) [CL]                                  encoding(3 bytes) = 0f 92 c1
0064h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0067h mov [rsp+28h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(4 bytes) = 88 4c 24 28
006bh movzx ecx,byte ptr [rsp+28h]  ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 4c 24 28
0070h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0074h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0076h jne short 007ch               ; JNE(Jne_rel8_64) [7Ch:jmp64]                         encoding(2 bytes) = 75 04
0078h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
007ah jmp short 0081h               ; JMP(Jmp_rel8_64) [81h:jmp64]                         encoding(2 bytes) = eb 05
007ch mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
0081h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0085h cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
0088h jne short 009bh               ; JNE(Jne_rel8_64) [9Bh:jmp64]                         encoding(2 bytes) = 75 11
008ah mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
0090h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0093h shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
0096h or [rsi],r9                   ; OR(Or_rm64_r64) [mem(64u,RSI:br,DS:sr),R9]           encoding(3 bytes) = 4c 09 0e
0099h jmp short 00b0h               ; JMP(Jmp_rel8_64) [B0h:jmp64]                         encoding(2 bytes) = eb 15
009bh mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
00a1h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
00a4h shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
00a7h mov rcx,r9                    ; MOV(Mov_r64_rm64) [RCX,R9]                           encoding(3 bytes) = 49 8b c9
00aah not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
00adh and [rsi],rcx                 ; AND(And_rm64_r64) [mem(64u,RSI:br,DS:sr),RCX]        encoding(3 bytes) = 48 21 0e
00b0h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
00b2h cmp edx,eax                   ; CMP(Cmp_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 3b d0
00b4h jl short 0039h                ; JL(Jl_rel8_64) [39h:jmp64]                           encoding(2 bytes) = 7c 83
00b6h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
00b9h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
00bdh pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00beh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00bfh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00c0h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00c1h call 7FFE390EEF00h            ; CALL(Call_rel32_64) [5F594800h:jmp64]                encoding(5 bytes) = e8 3a 47 59 5f
00c6h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> permBytes => new byte[199]{0x57,0x56,0x53,0x48,0x83,0xEC,0x30,0x48,0x8B,0xF1,0x48,0x8B,0xFA,0x48,0x8B,0x1E,0x48,0xB9,0x10,0x96,0x5F,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x25,0x00,0x00,0x00,0xE8,0x8C,0xA1,0x46,0x5F,0x48,0xB9,0x48,0x71,0x00,0x10,0xEC,0x01,0x00,0x00,0x48,0x8B,0x09,0x48,0x8B,0x41,0x08,0x33,0xD2,0xEB,0x79,0x48,0x8B,0x0F,0x3B,0x51,0x08,0x0F,0x83,0x7C,0x00,0x00,0x00,0x4C,0x63,0xC2,0x4A,0x8D,0x4C,0x81,0x10,0x8B,0x09,0x3B,0xCA,0x74,0x5D,0x44,0x0F,0xB6,0xC2,0x0F,0xB6,0xC9,0x0F,0xB6,0xC9,0x48,0x0F,0xA3,0xCB,0x0F,0x92,0xC1,0x0F,0xB6,0xC9,0x88,0x4C,0x24,0x28,0x0F,0xB6,0x4C,0x24,0x28,0x45,0x0F,0xB6,0xC0,0x84,0xC9,0x75,0x04,0x33,0xC9,0xEB,0x05,0xB9,0x01,0x00,0x00,0x00,0x45,0x0F,0xB6,0xC0,0x83,0xF9,0x01,0x75,0x11,0x41,0xB9,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x49,0xD3,0xE1,0x4C,0x09,0x0E,0xEB,0x15,0x41,0xB9,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x49,0xD3,0xE1,0x49,0x8B,0xC9,0x48,0xF7,0xD1,0x48,0x21,0x0E,0xFF,0xC2,0x3B,0xD0,0x7C,0x83,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x30,0x5B,0x5E,0x5F,0xC3,0xE8,0x3A,0x47,0x59,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 perm(BitVector64 x, Perm spec)
; location: [7FFDD9B5A7E0h, 7FFDD9B5A8B8h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
000eh mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0011h mov [rsp+28h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 28
0016h mov rdi,[rsp+28h]             ; MOV(Mov_r64_rm64) [RDI,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 7c 24 28
001bh lea rbx,[rsp+28h]             ; LEA(Lea_r64_m) [RBX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 5c 24 28
0020h mov rcx,7FFDD95F9610h         ; MOV(Mov_r64_imm64) [RCX,7ffdd95f9610h:imm64]         encoding(10 bytes) = 48 b9 10 96 5f d9 fd 7f 00 00
002ah mov edx,25h                   ; MOV(Mov_r32_imm32) [EDX,25h:imm32]                   encoding(5 bytes) = ba 25 00 00 00
002fh call 7FFE38FC48B0h            ; CALL(Call_rel32_64) [5F46A0D0h:jmp64]                encoding(5 bytes) = e8 9c a0 46 5f
0034h mov rcx,1EC10007148h          ; MOV(Mov_r64_imm64) [RCX,1ec10007148h:imm64]          encoding(10 bytes) = 48 b9 48 71 00 10 ec 01 00 00
003eh mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
0041h mov rax,[rcx+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(4 bytes) = 48 8b 41 08
0045h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0047h jmp short 00bfh               ; JMP(Jmp_rel8_64) [BFh:jmp64]                         encoding(2 bytes) = eb 76
0049h cmp edx,[rsi+8]               ; CMP(Cmp_r32_rm32) [EDX,mem(32u,RSI:br,DS:sr)]        encoding(3 bytes) = 3b 56 08
004ch jae near ptr 00d3h            ; JAE(Jae_rel32_64) [D3h:jmp64]                        encoding(6 bytes) = 0f 83 81 00 00 00
0052h movsxd rcx,edx                ; MOVSXD(Movsxd_r64_rm32) [RCX,EDX]                    encoding(3 bytes) = 48 63 ca
0055h lea rcx,[rsi+rcx*4+10h]       ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(5 bytes) = 48 8d 4c 8e 10
005ah mov ecx,[rcx]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 09
005ch cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
005eh je short 00bdh                ; JE(Je_rel8_64) [BDh:jmp64]                           encoding(2 bytes) = 74 5d
0060h movzx r8d,dl                  ; MOVZX(Movzx_r32_rm8) [R8D,DL]                        encoding(4 bytes) = 44 0f b6 c2
0064h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0067h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
006ah bt rdi,rcx                    ; BT(Bt_rm64_r64) [RDI,RCX]                            encoding(4 bytes) = 48 0f a3 cf
006eh setb cl                       ; SETB(Setb_rm8) [CL]                                  encoding(3 bytes) = 0f 92 c1
0071h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0074h mov [rsp+20h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(4 bytes) = 88 4c 24 20
0078h movzx ecx,byte ptr [rsp+20h]  ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 4c 24 20
007dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0081h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0083h jne short 0089h               ; JNE(Jne_rel8_64) [89h:jmp64]                         encoding(2 bytes) = 75 04
0085h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0087h jmp short 008eh               ; JMP(Jmp_rel8_64) [8Eh:jmp64]                         encoding(2 bytes) = eb 05
0089h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
008eh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0092h cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
0095h jne short 00a8h               ; JNE(Jne_rel8_64) [A8h:jmp64]                         encoding(2 bytes) = 75 11
0097h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
009dh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
00a0h shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
00a3h or [rbx],r9                   ; OR(Or_rm64_r64) [mem(64u,RBX:br,DS:sr),R9]           encoding(3 bytes) = 4c 09 0b
00a6h jmp short 00bdh               ; JMP(Jmp_rel8_64) [BDh:jmp64]                         encoding(2 bytes) = eb 15
00a8h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
00aeh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
00b1h shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
00b4h mov rcx,r9                    ; MOV(Mov_r64_rm64) [RCX,R9]                           encoding(3 bytes) = 49 8b c9
00b7h not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
00bah and [rbx],rcx                 ; AND(And_rm64_r64) [mem(64u,RBX:br,DS:sr),RCX]        encoding(3 bytes) = 48 21 0b
00bdh inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
00bfh cmp edx,eax                   ; CMP(Cmp_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 3b d0
00c1h jl short 0049h                ; JL(Jl_rel8_64) [49h:jmp64]                           encoding(2 bytes) = 7c 86
00c3h lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
00c8h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
00cbh add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
00cfh pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00d0h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00d1h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00d2h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00d3h call 7FFE390EEF00h            ; CALL(Call_rel32_64) [5F594720h:jmp64]                encoding(5 bytes) = e8 48 46 59 5f
00d8h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> permBytes => new byte[217]{0x57,0x56,0x53,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x89,0x4C,0x24,0x28,0x48,0x8B,0x7C,0x24,0x28,0x48,0x8D,0x5C,0x24,0x28,0x48,0xB9,0x10,0x96,0x5F,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x25,0x00,0x00,0x00,0xE8,0x9C,0xA0,0x46,0x5F,0x48,0xB9,0x48,0x71,0x00,0x10,0xEC,0x01,0x00,0x00,0x48,0x8B,0x09,0x48,0x8B,0x41,0x08,0x33,0xD2,0xEB,0x76,0x3B,0x56,0x08,0x0F,0x83,0x81,0x00,0x00,0x00,0x48,0x63,0xCA,0x48,0x8D,0x4C,0x8E,0x10,0x8B,0x09,0x3B,0xCA,0x74,0x5D,0x44,0x0F,0xB6,0xC2,0x0F,0xB6,0xC9,0x0F,0xB6,0xC9,0x48,0x0F,0xA3,0xCF,0x0F,0x92,0xC1,0x0F,0xB6,0xC9,0x88,0x4C,0x24,0x20,0x0F,0xB6,0x4C,0x24,0x20,0x45,0x0F,0xB6,0xC0,0x84,0xC9,0x75,0x04,0x33,0xC9,0xEB,0x05,0xB9,0x01,0x00,0x00,0x00,0x45,0x0F,0xB6,0xC0,0x83,0xF9,0x01,0x75,0x11,0x41,0xB9,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x49,0xD3,0xE1,0x4C,0x09,0x0B,0xEB,0x15,0x41,0xB9,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x49,0xD3,0xE1,0x49,0x8B,0xC9,0x48,0xF7,0xD1,0x48,0x21,0x0B,0xFF,0xC2,0x3B,0xD0,0x7C,0x86,0x48,0x8D,0x44,0x24,0x28,0x48,0x8B,0x00,0x48,0x83,0xC4,0x30,0x5B,0x5E,0x5F,0xC3,0xE8,0x48,0x46,0x59,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(BitVector4 x)
; location: [7FFDD9B5A8E0h, 7FFDD9B5A8ECh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(BitVector8 x)
; location: [7FFDD9B5A900h, 7FFDD9B5A90Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(BitVector16 x)
; location: [7FFDD9B5A920h, 7FFDD9B5A92Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(BitVector32 x)
; location: [7FFDD9B5A940h, 7FFDD9B5A94Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt eax,ecx                ; POPCNT(Popcnt_r32_rm32) [EAX,ECX]                    encoding(4 bytes) = f3 0f b8 c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x0F,0xB8,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(BitVector64 x)
; location: [7FFDD9B5A960h, 7FFDD9B5A96Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt rax,rcx                ; POPCNT(Popcnt_r64_rm64) [RAX,RCX]                    encoding(5 bytes) = f3 48 0f b8 c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xB8,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 pow(BitVector8 x, int n)
; location: [7FFDD9B5A980h, 7FFDD9B5AB00h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,90h                   ; SUB(Sub_rm64_imm32) [RSP,90h:imm64]                  encoding(7 bytes) = 48 81 ec 90 00 00 00
000ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000dh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000fh mov [rsp+88h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(8 bytes) = 48 89 84 24 88 00 00 00
0017h mov edi,ecx                   ; MOV(Mov_r32_rm32) [EDI,ECX]                          encoding(2 bytes) = 8b f9
0019h mov esi,edx                   ; MOV(Mov_r32_rm32) [ESI,EDX]                          encoding(2 bytes) = 8b f2
001bh test esi,esi                  ; TEST(Test_rm32_r32) [ESI,ESI]                        encoding(2 bytes) = 85 f6
001dh jne short 0050h               ; JNE(Jne_rel8_64) [50h:jmp64]                         encoding(2 bytes) = 75 31
001fh mov rcx,7FFDD95F9610h         ; MOV(Mov_r64_imm64) [RCX,7ffdd95f9610h:imm64]         encoding(10 bytes) = 48 b9 10 96 5f d9 fd 7f 00 00
0029h mov edx,26h                   ; MOV(Mov_r32_imm32) [EDX,26h:imm32]                   encoding(5 bytes) = ba 26 00 00 00
002eh call 7FFE38FC48B0h            ; CALL(Call_rel32_64) [5F469F30h:jmp64]                encoding(5 bytes) = e8 fd 9e 46 5f
0033h mov rax,1EC10007158h          ; MOV(Mov_r64_imm64) [RAX,1ec10007158h:imm64]          encoding(10 bytes) = 48 b8 58 71 00 10 ec 01 00 00
003dh mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
0040h movsx rax,byte ptr [rax+8]    ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RAX:br,DS:sr)]      encoding(5 bytes) = 48 0f be 40 08
0045h add rsp,90h                   ; ADD(Add_rm64_imm32) [RSP,90h:imm64]                  encoding(7 bytes) = 48 81 c4 90 00 00 00
004ch pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
004dh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
004eh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
004fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0050h cmp esi,1                     ; CMP(Cmp_rm32_imm8) [ESI,1h:imm32]                    encoding(3 bytes) = 83 fe 01
0053h jne short 0064h               ; JNE(Jne_rel8_64) [64h:jmp64]                         encoding(2 bytes) = 75 0f
0055h movzx eax,dil                 ; MOVZX(Movzx_r32_rm8) [EAX,DIL]                       encoding(4 bytes) = 40 0f b6 c7
0059h add rsp,90h                   ; ADD(Add_rm64_imm32) [RSP,90h:imm64]                  encoding(7 bytes) = 48 81 c4 90 00 00 00
0060h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0061h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0062h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0063h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0064h movzx eax,dil                 ; MOVZX(Movzx_r32_rm8) [EAX,DIL]                       encoding(4 bytes) = 40 0f b6 c7
0068h mov [rsp+88h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(7 bytes) = 88 84 24 88 00 00 00
006fh mov ebx,2                     ; MOV(Mov_r32_imm32) [EBX,2h:imm32]                    encoding(5 bytes) = bb 02 00 00 00
0074h cmp esi,2                     ; CMP(Cmp_rm32_imm8) [ESI,2h:imm32]                    encoding(3 bytes) = 83 fe 02
0077h jl near ptr 016ch             ; JL(Jl_rel32_64) [16Ch:jmp64]                         encoding(6 bytes) = 0f 8c ef 00 00 00
007dh mov rcx,7FFDD95F9610h         ; MOV(Mov_r64_imm64) [RCX,7ffdd95f9610h:imm64]         encoding(10 bytes) = 48 b9 10 96 5f d9 fd 7f 00 00
0087h mov edx,2Fh                   ; MOV(Mov_r32_imm32) [EDX,2fh:imm32]                   encoding(5 bytes) = ba 2f 00 00 00
008ch call 7FFE38FC48B0h            ; CALL(Call_rel32_64) [5F469F30h:jmp64]                encoding(5 bytes) = e8 9f 9e 46 5f
0091h movzx eax,word ptr [7FFDD95F9778h]; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RIP:br,DS:sr)] encoding(7 bytes) = 0f b7 05 60 ed a9 ff
0098h movzx edx,dil                 ; MOVZX(Movzx_r32_rm8) [EDX,DIL]                       encoding(4 bytes) = 40 0f b6 d7
009ch mov ecx,[rsp+88h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 8c 24 88 00 00 00
00a3h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
00a6h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
00a9h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
00ach mov r9,rdx                    ; MOV(Mov_r64_rm64) [R9,RDX]                           encoding(3 bytes) = 4c 8b ca
00afh vmovq xmm0,rcx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RCX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c1
00b4h vmovq xmm1,r9                 ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,R9]                  encoding(VEX, 5 bytes) = c4 c1 f9 6e c9
00b9h vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
00bfh vmovapd [rsp+60h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 60
00c5h vmovdqu xmm0,xmmword ptr [rsp+60h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 60
00cbh vmovdqu xmmword ptr [rsp+78h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 78
00d1h mov rcx,[rsp+78h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 4c 24 78
00d6h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
00d9h mov r9d,ecx                   ; MOV(Mov_r32_rm32) [R9D,ECX]                          encoding(3 bytes) = 44 8b c9
00dch sar r9d,8                     ; SAR(Sar_rm32_imm8) [R9D,8h:imm8]                     encoding(4 bytes) = 41 c1 f9 08
00e0h movzx r9d,r9w                 ; MOVZX(Movzx_r32_rm16) [R9D,R9W]                      encoding(4 bytes) = 45 0f b7 c9
00e4h mov r10d,r8d                  ; MOV(Mov_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 8b d0
00e7h vmovq xmm0,r9                 ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,R9]                  encoding(VEX, 5 bytes) = c4 c1 f9 6e c1
00ech vmovq xmm1,r10                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,R10]                 encoding(VEX, 5 bytes) = c4 c1 f9 6e ca
00f1h vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
00f7h vmovapd [rsp+40h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 40
00fdh vmovdqu xmm0,xmmword ptr [rsp+40h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 40
0103h vmovdqu xmmword ptr [rsp+50h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 50
0109h mov r9d,[rsp+50h]             ; MOV(Mov_r32_rm32) [R9D,mem(32u,RSP:br,SS:sr)]        encoding(5 bytes) = 44 8b 4c 24 50
010eh movzx r9d,r9w                 ; MOVZX(Movzx_r32_rm16) [R9D,R9W]                      encoding(4 bytes) = 45 0f b7 c9
0112h xor ecx,r9d                   ; XOR(Xor_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 33 c9
0115h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0118h mov r9d,ecx                   ; MOV(Mov_r32_rm32) [R9D,ECX]                          encoding(3 bytes) = 44 8b c9
011bh sar r9d,8                     ; SAR(Sar_rm32_imm8) [R9D,8h:imm8]                     encoding(4 bytes) = 41 c1 f9 08
011fh movzx r9d,r9w                 ; MOVZX(Movzx_r32_rm16) [R9D,R9W]                      encoding(4 bytes) = 45 0f b7 c9
0123h mov r8d,r8d                   ; MOV(Mov_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 8b c0
0126h vmovq xmm0,r9                 ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,R9]                  encoding(VEX, 5 bytes) = c4 c1 f9 6e c1
012bh vmovq xmm1,r8                 ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,R8]                  encoding(VEX, 5 bytes) = c4 c1 f9 6e c8
0130h vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
0136h vmovapd [rsp+20h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 20
013ch vmovdqu xmm0,xmmword ptr [rsp+20h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 20
0142h vmovdqu xmmword ptr [rsp+30h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 30
0148h mov r8d,[rsp+30h]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,SS:sr)]        encoding(5 bytes) = 44 8b 44 24 30
014dh movzx r8d,r8w                 ; MOVZX(Movzx_r32_rm16) [R8D,R8W]                      encoding(4 bytes) = 45 0f b7 c0
0151h xor r8d,ecx                   ; XOR(Xor_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 33 c1
0154h movzx ecx,r8w                 ; MOVZX(Movzx_r32_rm16) [ECX,R8W]                      encoding(4 bytes) = 41 0f b7 c8
0158h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
015bh mov [rsp+88h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(7 bytes) = 88 8c 24 88 00 00 00
0162h inc ebx                       ; INC(Inc_rm32) [EBX]                                  encoding(2 bytes) = ff c3
0164h cmp ebx,esi                   ; CMP(Cmp_r32_rm32) [EBX,ESI]                          encoding(2 bytes) = 3b de
0166h jle near ptr 009ch            ; JLE(Jle_rel32_64) [9Ch:jmp64]                        encoding(6 bytes) = 0f 8e 30 ff ff ff
016ch mov eax,[rsp+88h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 84 24 88 00 00 00
0173h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0176h add rsp,90h                   ; ADD(Add_rm64_imm32) [RSP,90h:imm64]                  encoding(7 bytes) = 48 81 c4 90 00 00 00
017dh pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
017eh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
017fh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0180h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> powBytes => new byte[385]{0x57,0x56,0x53,0x48,0x81,0xEC,0x90,0x00,0x00,0x00,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x84,0x24,0x88,0x00,0x00,0x00,0x8B,0xF9,0x8B,0xF2,0x85,0xF6,0x75,0x31,0x48,0xB9,0x10,0x96,0x5F,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x26,0x00,0x00,0x00,0xE8,0xFD,0x9E,0x46,0x5F,0x48,0xB8,0x58,0x71,0x00,0x10,0xEC,0x01,0x00,0x00,0x48,0x8B,0x00,0x48,0x0F,0xBE,0x40,0x08,0x48,0x81,0xC4,0x90,0x00,0x00,0x00,0x5B,0x5E,0x5F,0xC3,0x83,0xFE,0x01,0x75,0x0F,0x40,0x0F,0xB6,0xC7,0x48,0x81,0xC4,0x90,0x00,0x00,0x00,0x5B,0x5E,0x5F,0xC3,0x40,0x0F,0xB6,0xC7,0x88,0x84,0x24,0x88,0x00,0x00,0x00,0xBB,0x02,0x00,0x00,0x00,0x83,0xFE,0x02,0x0F,0x8C,0xEF,0x00,0x00,0x00,0x48,0xB9,0x10,0x96,0x5F,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x2F,0x00,0x00,0x00,0xE8,0x9F,0x9E,0x46,0x5F,0x0F,0xB7,0x05,0x60,0xED,0xA9,0xFF,0x40,0x0F,0xB6,0xD7,0x8B,0x8C,0x24,0x88,0x00,0x00,0x00,0x0F,0xB6,0xC9,0x44,0x8B,0xC0,0x0F,0xB6,0xC9,0x4C,0x8B,0xCA,0xC4,0xE1,0xF9,0x6E,0xC1,0xC4,0xC1,0xF9,0x6E,0xC9,0xC4,0xE3,0x79,0x44,0xC1,0x00,0xC5,0xF9,0x29,0x44,0x24,0x60,0xC5,0xFA,0x6F,0x44,0x24,0x60,0xC5,0xFA,0x7F,0x44,0x24,0x78,0x48,0x8B,0x4C,0x24,0x78,0x0F,0xB7,0xC9,0x44,0x8B,0xC9,0x41,0xC1,0xF9,0x08,0x45,0x0F,0xB7,0xC9,0x45,0x8B,0xD0,0xC4,0xC1,0xF9,0x6E,0xC1,0xC4,0xC1,0xF9,0x6E,0xCA,0xC4,0xE3,0x79,0x44,0xC1,0x00,0xC5,0xF9,0x29,0x44,0x24,0x40,0xC5,0xFA,0x6F,0x44,0x24,0x40,0xC5,0xFA,0x7F,0x44,0x24,0x50,0x44,0x8B,0x4C,0x24,0x50,0x45,0x0F,0xB7,0xC9,0x41,0x33,0xC9,0x0F,0xB7,0xC9,0x44,0x8B,0xC9,0x41,0xC1,0xF9,0x08,0x45,0x0F,0xB7,0xC9,0x45,0x8B,0xC0,0xC4,0xC1,0xF9,0x6E,0xC1,0xC4,0xC1,0xF9,0x6E,0xC8,0xC4,0xE3,0x79,0x44,0xC1,0x00,0xC5,0xF9,0x29,0x44,0x24,0x20,0xC5,0xFA,0x6F,0x44,0x24,0x20,0xC5,0xFA,0x7F,0x44,0x24,0x30,0x44,0x8B,0x44,0x24,0x30,0x45,0x0F,0xB7,0xC0,0x44,0x33,0xC1,0x41,0x0F,0xB7,0xC8,0x0F,0xB6,0xC9,0x88,0x8C,0x24,0x88,0x00,0x00,0x00,0xFF,0xC3,0x3B,0xDE,0x0F,0x8E,0x30,0xFF,0xFF,0xFF,0x8B,0x84,0x24,0x88,0x00,0x00,0x00,0x0F,0xB6,0xC0,0x48,0x81,0xC4,0x90,0x00,0x00,0x00,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 rev(BitVector8 x)
; location: [7FFDD9B5AB30h, 7FFDD9B5AB66h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov edx,80200802h             ; MOV(Mov_r32_imm32) [EDX,80200802h:imm32]             encoding(5 bytes) = ba 02 08 20 80
000dh imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
0011h mov rdx,884422110h            ; MOV(Mov_r64_imm64) [RDX,884422110h:imm64]            encoding(10 bytes) = 48 ba 10 21 42 84 08 00 00 00
001bh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
001eh mov rdx,101010101h            ; MOV(Mov_r64_imm64) [RDX,101010101h:imm64]            encoding(10 bytes) = 48 ba 01 01 01 01 01 00 00 00
0028h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
002ch shr rax,20h                   ; SHR(Shr_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e8 20
0030h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0033h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> revBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xBA,0x02,0x08,0x20,0x80,0x48,0x0F,0xAF,0xC2,0x48,0xBA,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x48,0x23,0xC2,0x48,0xBA,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x48,0x0F,0xAF,0xC2,0x48,0xC1,0xE8,0x20,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 rev(BitVector16 x)
; location: [7FFDD9B5AB80h, 7FFDD9B5ABF1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000ah sar edx,8                     ; SAR(Sar_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 fa 08
000dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0010h mov ecx,80200802h             ; MOV(Mov_r32_imm32) [ECX,80200802h:imm32]             encoding(5 bytes) = b9 02 08 20 80
0015h imul rdx,rcx                  ; IMUL(Imul_r64_rm64) [RDX,RCX]                        encoding(4 bytes) = 48 0f af d1
0019h mov rcx,884422110h            ; MOV(Mov_r64_imm64) [RCX,884422110h:imm64]            encoding(10 bytes) = 48 b9 10 21 42 84 08 00 00 00
0023h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0026h mov rcx,101010101h            ; MOV(Mov_r64_imm64) [RCX,101010101h:imm64]            encoding(10 bytes) = 48 b9 01 01 01 01 01 00 00 00
0030h imul rdx,rcx                  ; IMUL(Imul_r64_rm64) [RDX,RCX]                        encoding(4 bytes) = 48 0f af d1
0034h shr rdx,20h                   ; SHR(Shr_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 ea 20
0038h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
003bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003eh mov ecx,80200802h             ; MOV(Mov_r32_imm32) [ECX,80200802h:imm32]             encoding(5 bytes) = b9 02 08 20 80
0043h imul rax,rcx                  ; IMUL(Imul_r64_rm64) [RAX,RCX]                        encoding(4 bytes) = 48 0f af c1
0047h mov rcx,884422110h            ; MOV(Mov_r64_imm64) [RCX,884422110h:imm64]            encoding(10 bytes) = 48 b9 10 21 42 84 08 00 00 00
0051h and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0054h mov rcx,101010101h            ; MOV(Mov_r64_imm64) [RCX,101010101h:imm64]            encoding(10 bytes) = 48 b9 01 01 01 01 01 00 00 00
005eh imul rax,rcx                  ; IMUL(Imul_r64_rm64) [RAX,RCX]                        encoding(4 bytes) = 48 0f af c1
0062h shr rax,20h                   ; SHR(Shr_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e8 20
0066h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0069h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
006ch or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
006eh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0071h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> revBytes => new byte[114]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xD0,0xC1,0xFA,0x08,0x0F,0xB6,0xD2,0xB9,0x02,0x08,0x20,0x80,0x48,0x0F,0xAF,0xD1,0x48,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x48,0x23,0xD1,0x48,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x48,0x0F,0xAF,0xD1,0x48,0xC1,0xEA,0x20,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0xB9,0x02,0x08,0x20,0x80,0x48,0x0F,0xAF,0xC1,0x48,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x48,0x23,0xC1,0x48,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x48,0x0F,0xAF,0xC1,0x48,0xC1,0xE8,0x20,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 rev(BitVector32 x)
; location: [7FFDD9B5AC10h, 7FFDD9B5ACFBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h shr eax,10h                   ; SHR(Shr_rm32_imm8) [EAX,10h:imm8]                    encoding(3 bytes) = c1 e8 10
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000fh sar edx,8                     ; SAR(Sar_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 fa 08
0012h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0015h mov r8d,80200802h             ; MOV(Mov_r32_imm32) [R8D,80200802h:imm32]             encoding(6 bytes) = 41 b8 02 08 20 80
001bh imul rdx,r8                   ; IMUL(Imul_r64_rm64) [RDX,R8]                         encoding(4 bytes) = 49 0f af d0
001fh mov r8,884422110h             ; MOV(Mov_r64_imm64) [R8,884422110h:imm64]             encoding(10 bytes) = 49 b8 10 21 42 84 08 00 00 00
0029h and rdx,r8                    ; AND(And_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 23 d0
002ch mov r8,101010101h             ; MOV(Mov_r64_imm64) [R8,101010101h:imm64]             encoding(10 bytes) = 49 b8 01 01 01 01 01 00 00 00
0036h imul rdx,r8                   ; IMUL(Imul_r64_rm64) [RDX,R8]                         encoding(4 bytes) = 49 0f af d0
003ah shr rdx,20h                   ; SHR(Shr_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 ea 20
003eh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0041h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0044h mov r8d,80200802h             ; MOV(Mov_r32_imm32) [R8D,80200802h:imm32]             encoding(6 bytes) = 41 b8 02 08 20 80
004ah imul rax,r8                   ; IMUL(Imul_r64_rm64) [RAX,R8]                         encoding(4 bytes) = 49 0f af c0
004eh mov r8,884422110h             ; MOV(Mov_r64_imm64) [R8,884422110h:imm64]             encoding(10 bytes) = 49 b8 10 21 42 84 08 00 00 00
0058h and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
005bh mov r8,101010101h             ; MOV(Mov_r64_imm64) [R8,101010101h:imm64]             encoding(10 bytes) = 49 b8 01 01 01 01 01 00 00 00
0065h imul rax,r8                   ; IMUL(Imul_r64_rm64) [RAX,R8]                         encoding(4 bytes) = 49 0f af c0
0069h shr rax,20h                   ; SHR(Shr_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e8 20
006dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0070h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0073h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0075h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0078h movzx edx,cx                  ; MOVZX(Movzx_r32_rm16) [EDX,CX]                       encoding(3 bytes) = 0f b7 d1
007bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
007dh sar ecx,8                     ; SAR(Sar_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 f9 08
0080h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0083h mov r8d,80200802h             ; MOV(Mov_r32_imm32) [R8D,80200802h:imm32]             encoding(6 bytes) = 41 b8 02 08 20 80
0089h imul rcx,r8                   ; IMUL(Imul_r64_rm64) [RCX,R8]                         encoding(4 bytes) = 49 0f af c8
008dh mov r8,884422110h             ; MOV(Mov_r64_imm64) [R8,884422110h:imm64]             encoding(10 bytes) = 49 b8 10 21 42 84 08 00 00 00
0097h and rcx,r8                    ; AND(And_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 23 c8
009ah mov r8,101010101h             ; MOV(Mov_r64_imm64) [R8,101010101h:imm64]             encoding(10 bytes) = 49 b8 01 01 01 01 01 00 00 00
00a4h imul rcx,r8                   ; IMUL(Imul_r64_rm64) [RCX,R8]                         encoding(4 bytes) = 49 0f af c8
00a8h shr rcx,20h                   ; SHR(Shr_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 e9 20
00ach movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
00afh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
00b2h mov r8d,80200802h             ; MOV(Mov_r32_imm32) [R8D,80200802h:imm32]             encoding(6 bytes) = 41 b8 02 08 20 80
00b8h imul rdx,r8                   ; IMUL(Imul_r64_rm64) [RDX,R8]                         encoding(4 bytes) = 49 0f af d0
00bch mov r8,884422110h             ; MOV(Mov_r64_imm64) [R8,884422110h:imm64]             encoding(10 bytes) = 49 b8 10 21 42 84 08 00 00 00
00c6h and rdx,r8                    ; AND(And_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 23 d0
00c9h mov r8,101010101h             ; MOV(Mov_r64_imm64) [R8,101010101h:imm64]             encoding(10 bytes) = 49 b8 01 01 01 01 01 00 00 00
00d3h imul rdx,r8                   ; IMUL(Imul_r64_rm64) [RDX,R8]                         encoding(4 bytes) = 49 0f af d0
00d7h shr rdx,20h                   ; SHR(Shr_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 ea 20
00dbh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
00deh shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
00e1h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
00e3h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
00e6h shl edx,10h                   ; SHL(Shl_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 e2 10
00e9h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
00ebh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> revBytes => new byte[236]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC1,0xE8,0x10,0x0F,0xB7,0xC0,0x8B,0xD0,0xC1,0xFA,0x08,0x0F,0xB6,0xD2,0x41,0xB8,0x02,0x08,0x20,0x80,0x49,0x0F,0xAF,0xD0,0x49,0xB8,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x49,0x23,0xD0,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x49,0x0F,0xAF,0xD0,0x48,0xC1,0xEA,0x20,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x41,0xB8,0x02,0x08,0x20,0x80,0x49,0x0F,0xAF,0xC0,0x49,0xB8,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x49,0x23,0xC0,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x49,0x0F,0xAF,0xC0,0x48,0xC1,0xE8,0x20,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB7,0xD1,0x8B,0xCA,0xC1,0xF9,0x08,0x0F,0xB6,0xC9,0x41,0xB8,0x02,0x08,0x20,0x80,0x49,0x0F,0xAF,0xC8,0x49,0xB8,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x49,0x23,0xC8,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x49,0x0F,0xAF,0xC8,0x48,0xC1,0xE9,0x20,0x0F,0xB6,0xC9,0x0F,0xB6,0xD2,0x41,0xB8,0x02,0x08,0x20,0x80,0x49,0x0F,0xAF,0xD0,0x49,0xB8,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x49,0x23,0xD0,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x49,0x0F,0xAF,0xD0,0x48,0xC1,0xEA,0x20,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xD1,0x0F,0xB7,0xD2,0xC1,0xE2,0x10,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 rev(BitVector64 x)
; location: [7FFDD9B5AD10h, 7FFDD9B5AF07h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h shr rax,20h                   ; SHR(Shr_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e8 20
000ch mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000eh shr edx,10h                   ; SHR(Shr_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 ea 10
0011h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0014h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0017h sar r8d,8                     ; SAR(Sar_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 f8 08
001bh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001fh mov r9d,80200802h             ; MOV(Mov_r32_imm32) [R9D,80200802h:imm32]             encoding(6 bytes) = 41 b9 02 08 20 80
0025h imul r8,r9                    ; IMUL(Imul_r64_rm64) [R8,R9]                          encoding(4 bytes) = 4d 0f af c1
0029h mov r9,884422110h             ; MOV(Mov_r64_imm64) [R9,884422110h:imm64]             encoding(10 bytes) = 49 b9 10 21 42 84 08 00 00 00
0033h and r8,r9                     ; AND(And_r64_rm64) [R8,R9]                            encoding(3 bytes) = 4d 23 c1
0036h mov r9,101010101h             ; MOV(Mov_r64_imm64) [R9,101010101h:imm64]             encoding(10 bytes) = 49 b9 01 01 01 01 01 00 00 00
0040h imul r8,r9                    ; IMUL(Imul_r64_rm64) [R8,R9]                          encoding(4 bytes) = 4d 0f af c1
0044h shr r8,20h                    ; SHR(Shr_rm64_imm8) [R8,20h:imm8]                     encoding(4 bytes) = 49 c1 e8 20
0048h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
004ch movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
004fh mov r9d,80200802h             ; MOV(Mov_r32_imm32) [R9D,80200802h:imm32]             encoding(6 bytes) = 41 b9 02 08 20 80
0055h imul rdx,r9                   ; IMUL(Imul_r64_rm64) [RDX,R9]                         encoding(4 bytes) = 49 0f af d1
0059h mov r9,884422110h             ; MOV(Mov_r64_imm64) [R9,884422110h:imm64]             encoding(10 bytes) = 49 b9 10 21 42 84 08 00 00 00
0063h and rdx,r9                    ; AND(And_r64_rm64) [RDX,R9]                           encoding(3 bytes) = 49 23 d1
0066h mov r9,101010101h             ; MOV(Mov_r64_imm64) [R9,101010101h:imm64]             encoding(10 bytes) = 49 b9 01 01 01 01 01 00 00 00
0070h imul rdx,r9                   ; IMUL(Imul_r64_rm64) [RDX,R9]                         encoding(4 bytes) = 49 0f af d1
0074h shr rdx,20h                   ; SHR(Shr_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 ea 20
0078h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
007bh shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
007eh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0081h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0084h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0087h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
008ah sar r8d,8                     ; SAR(Sar_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 f8 08
008eh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0092h mov r9d,80200802h             ; MOV(Mov_r32_imm32) [R9D,80200802h:imm32]             encoding(6 bytes) = 41 b9 02 08 20 80
0098h imul r8,r9                    ; IMUL(Imul_r64_rm64) [R8,R9]                          encoding(4 bytes) = 4d 0f af c1
009ch mov r9,884422110h             ; MOV(Mov_r64_imm64) [R9,884422110h:imm64]             encoding(10 bytes) = 49 b9 10 21 42 84 08 00 00 00
00a6h and r8,r9                     ; AND(And_r64_rm64) [R8,R9]                            encoding(3 bytes) = 4d 23 c1
00a9h mov r9,101010101h             ; MOV(Mov_r64_imm64) [R9,101010101h:imm64]             encoding(10 bytes) = 49 b9 01 01 01 01 01 00 00 00
00b3h imul r8,r9                    ; IMUL(Imul_r64_rm64) [R8,R9]                          encoding(4 bytes) = 4d 0f af c1
00b7h shr r8,20h                    ; SHR(Shr_rm64_imm8) [R8,20h:imm8]                     encoding(4 bytes) = 49 c1 e8 20
00bbh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
00bfh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00c2h mov r9d,80200802h             ; MOV(Mov_r32_imm32) [R9D,80200802h:imm32]             encoding(6 bytes) = 41 b9 02 08 20 80
00c8h imul rax,r9                   ; IMUL(Imul_r64_rm64) [RAX,R9]                         encoding(4 bytes) = 49 0f af c1
00cch mov r9,884422110h             ; MOV(Mov_r64_imm64) [R9,884422110h:imm64]             encoding(10 bytes) = 49 b9 10 21 42 84 08 00 00 00
00d6h and rax,r9                    ; AND(And_r64_rm64) [RAX,R9]                           encoding(3 bytes) = 49 23 c1
00d9h mov r9,101010101h             ; MOV(Mov_r64_imm64) [R9,101010101h:imm64]             encoding(10 bytes) = 49 b9 01 01 01 01 01 00 00 00
00e3h imul rax,r9                   ; IMUL(Imul_r64_rm64) [RAX,R9]                         encoding(4 bytes) = 49 0f af c1
00e7h shr rax,20h                   ; SHR(Shr_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e8 20
00ebh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00eeh shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
00f1h or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
00f4h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
00f7h shl eax,10h                   ; SHL(Shl_rm32_imm8) [EAX,10h:imm8]                    encoding(3 bytes) = c1 e0 10
00fah or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
00fch mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
00feh shr edx,10h                   ; SHR(Shr_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 ea 10
0101h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0104h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0107h sar r8d,8                     ; SAR(Sar_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 f8 08
010bh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
010fh mov r9d,80200802h             ; MOV(Mov_r32_imm32) [R9D,80200802h:imm32]             encoding(6 bytes) = 41 b9 02 08 20 80
0115h imul r8,r9                    ; IMUL(Imul_r64_rm64) [R8,R9]                          encoding(4 bytes) = 4d 0f af c1
0119h mov r9,884422110h             ; MOV(Mov_r64_imm64) [R9,884422110h:imm64]             encoding(10 bytes) = 49 b9 10 21 42 84 08 00 00 00
0123h and r8,r9                     ; AND(And_r64_rm64) [R8,R9]                            encoding(3 bytes) = 4d 23 c1
0126h mov r9,101010101h             ; MOV(Mov_r64_imm64) [R9,101010101h:imm64]             encoding(10 bytes) = 49 b9 01 01 01 01 01 00 00 00
0130h imul r8,r9                    ; IMUL(Imul_r64_rm64) [R8,R9]                          encoding(4 bytes) = 4d 0f af c1
0134h shr r8,20h                    ; SHR(Shr_rm64_imm8) [R8,20h:imm8]                     encoding(4 bytes) = 49 c1 e8 20
0138h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
013ch movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
013fh mov r9d,80200802h             ; MOV(Mov_r32_imm32) [R9D,80200802h:imm32]             encoding(6 bytes) = 41 b9 02 08 20 80
0145h imul rdx,r9                   ; IMUL(Imul_r64_rm64) [RDX,R9]                         encoding(4 bytes) = 49 0f af d1
0149h mov r9,884422110h             ; MOV(Mov_r64_imm64) [R9,884422110h:imm64]             encoding(10 bytes) = 49 b9 10 21 42 84 08 00 00 00
0153h and rdx,r9                    ; AND(And_r64_rm64) [RDX,R9]                           encoding(3 bytes) = 49 23 d1
0156h mov r9,101010101h             ; MOV(Mov_r64_imm64) [R9,101010101h:imm64]             encoding(10 bytes) = 49 b9 01 01 01 01 01 00 00 00
0160h imul rdx,r9                   ; IMUL(Imul_r64_rm64) [RDX,R9]                         encoding(4 bytes) = 49 0f af d1
0164h shr rdx,20h                   ; SHR(Shr_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 ea 20
0168h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
016bh shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
016eh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0171h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0174h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0177h mov r8d,ecx                   ; MOV(Mov_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 8b c1
017ah sar r8d,8                     ; SAR(Sar_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 f8 08
017eh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0182h mov r9d,80200802h             ; MOV(Mov_r32_imm32) [R9D,80200802h:imm32]             encoding(6 bytes) = 41 b9 02 08 20 80
0188h imul r8,r9                    ; IMUL(Imul_r64_rm64) [R8,R9]                          encoding(4 bytes) = 4d 0f af c1
018ch mov r9,884422110h             ; MOV(Mov_r64_imm64) [R9,884422110h:imm64]             encoding(10 bytes) = 49 b9 10 21 42 84 08 00 00 00
0196h and r8,r9                     ; AND(And_r64_rm64) [R8,R9]                            encoding(3 bytes) = 4d 23 c1
0199h mov r9,101010101h             ; MOV(Mov_r64_imm64) [R9,101010101h:imm64]             encoding(10 bytes) = 49 b9 01 01 01 01 01 00 00 00
01a3h imul r8,r9                    ; IMUL(Imul_r64_rm64) [R8,R9]                          encoding(4 bytes) = 4d 0f af c1
01a7h shr r8,20h                    ; SHR(Shr_rm64_imm8) [R8,20h:imm8]                     encoding(4 bytes) = 49 c1 e8 20
01abh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
01afh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
01b2h mov r9d,80200802h             ; MOV(Mov_r32_imm32) [R9D,80200802h:imm32]             encoding(6 bytes) = 41 b9 02 08 20 80
01b8h imul rcx,r9                   ; IMUL(Imul_r64_rm64) [RCX,R9]                         encoding(4 bytes) = 49 0f af c9
01bch mov r9,884422110h             ; MOV(Mov_r64_imm64) [R9,884422110h:imm64]             encoding(10 bytes) = 49 b9 10 21 42 84 08 00 00 00
01c6h and rcx,r9                    ; AND(And_r64_rm64) [RCX,R9]                           encoding(3 bytes) = 49 23 c9
01c9h mov r9,101010101h             ; MOV(Mov_r64_imm64) [R9,101010101h:imm64]             encoding(10 bytes) = 49 b9 01 01 01 01 01 00 00 00
01d3h imul rcx,r9                   ; IMUL(Imul_r64_rm64) [RCX,R9]                         encoding(4 bytes) = 49 0f af c9
01d7h shr rcx,20h                   ; SHR(Shr_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 e9 20
01dbh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
01deh shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
01e1h or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
01e4h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
01e7h shl ecx,10h                   ; SHL(Shl_rm32_imm8) [ECX,10h:imm8]                    encoding(3 bytes) = c1 e1 10
01eah or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
01ech mov eax,eax                   ; MOV(Mov_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 8b c0
01eeh mov edx,edx                   ; MOV(Mov_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 8b d2
01f0h shl rdx,20h                   ; SHL(Shl_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 e2 20
01f4h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
01f7h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> revBytes => new byte[504]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xC1,0xE8,0x20,0x8B,0xD0,0xC1,0xEA,0x10,0x0F,0xB7,0xD2,0x44,0x8B,0xC2,0x41,0xC1,0xF8,0x08,0x45,0x0F,0xB6,0xC0,0x41,0xB9,0x02,0x08,0x20,0x80,0x4D,0x0F,0xAF,0xC1,0x49,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x4D,0x23,0xC1,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x4D,0x0F,0xAF,0xC1,0x49,0xC1,0xE8,0x20,0x45,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x41,0xB9,0x02,0x08,0x20,0x80,0x49,0x0F,0xAF,0xD1,0x49,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x49,0x23,0xD1,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x49,0x0F,0xAF,0xD1,0x48,0xC1,0xEA,0x20,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x44,0x8B,0xC0,0x41,0xC1,0xF8,0x08,0x45,0x0F,0xB6,0xC0,0x41,0xB9,0x02,0x08,0x20,0x80,0x4D,0x0F,0xAF,0xC1,0x49,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x4D,0x23,0xC1,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x4D,0x0F,0xAF,0xC1,0x49,0xC1,0xE8,0x20,0x45,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x41,0xB9,0x02,0x08,0x20,0x80,0x49,0x0F,0xAF,0xC1,0x49,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x49,0x23,0xC1,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x49,0x0F,0xAF,0xC1,0x48,0xC1,0xE8,0x20,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x41,0x0B,0xC0,0x0F,0xB7,0xC0,0xC1,0xE0,0x10,0x0B,0xC2,0x8B,0xD1,0xC1,0xEA,0x10,0x0F,0xB7,0xD2,0x44,0x8B,0xC2,0x41,0xC1,0xF8,0x08,0x45,0x0F,0xB6,0xC0,0x41,0xB9,0x02,0x08,0x20,0x80,0x4D,0x0F,0xAF,0xC1,0x49,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x4D,0x23,0xC1,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x4D,0x0F,0xAF,0xC1,0x49,0xC1,0xE8,0x20,0x45,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x41,0xB9,0x02,0x08,0x20,0x80,0x49,0x0F,0xAF,0xD1,0x49,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x49,0x23,0xD1,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x49,0x0F,0xAF,0xD1,0x48,0xC1,0xEA,0x20,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0x0F,0xB7,0xC9,0x44,0x8B,0xC1,0x41,0xC1,0xF8,0x08,0x45,0x0F,0xB6,0xC0,0x41,0xB9,0x02,0x08,0x20,0x80,0x4D,0x0F,0xAF,0xC1,0x49,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x4D,0x23,0xC1,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x4D,0x0F,0xAF,0xC1,0x49,0xC1,0xE8,0x20,0x45,0x0F,0xB6,0xC0,0x0F,0xB6,0xC9,0x41,0xB9,0x02,0x08,0x20,0x80,0x49,0x0F,0xAF,0xC9,0x49,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x49,0x23,0xC9,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x49,0x0F,0xAF,0xC9,0x48,0xC1,0xE9,0x20,0x0F,0xB6,0xC9,0xC1,0xE1,0x08,0x41,0x0B,0xC8,0x0F,0xB7,0xC9,0xC1,0xE1,0x10,0x0B,0xD1,0x8B,0xC0,0x8B,0xD2,0x48,0xC1,0xE2,0x20,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 rotl(BitVector4 x, int offset)
; location: [7FFDD9B5AF20h, 7FFDD9B5AF3Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000dh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0010h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0012h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0014h add ecx,8                     ; ADD(Add_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 c1 08
0017h sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
0019h or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE0,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x08,0xD3,0xF8,0x41,0x0B,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
