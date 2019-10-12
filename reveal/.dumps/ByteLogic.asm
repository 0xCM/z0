; 2019-10-12 06:44:40:522
; function: ByteKind:byte and(ByteKind:byte a, ByteKind:byte b)
; location: [7FFDAD7E95A0h, 7FFDAD7E95B0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte or(ByteKind:byte a, ByteKind:byte b)
; location: [7FFDAD7E95D0h, 7FFDAD7E95E0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte xor(ByteKind:byte a, ByteKind:byte b)
; location: [7FFDAD7E9600h, 7FFDAD7E9610h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte not(ByteKind:byte a)
; location: [7FFDAD7E9630h, 7FFDAD7E963Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> notBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte nand(ByteKind:byte a, ByteKind:byte b)
; location: [7FFDAD7E9650h, 7FFDAD7E9662h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nandBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x23,0xC2,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte nor(ByteKind:byte a, ByteKind:byte b)
; location: [7FFDAD7E9680h, 7FFDAD7E9692h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> norBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0B,0xC2,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte xnor(ByteKind:byte a, ByteKind:byte b)
; location: [7FFDAD7E96B0h, 7FFDAD7E96C2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xnorBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte select(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDAD7E96E0h, 7FFDAD7E96FDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh and edx,eax                   ; AND(And_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 23 d0
000dh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0016h and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
0018h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x23,0xD0,0xF7,0xD0,0x0F,0xB6,0xC0,0x41,0x0F,0xB6,0xC8,0x23,0xC1,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f01(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDAD7E9710h, 7FFDAD7E972Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
0014h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0016h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f01Bytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xD1,0x0B,0xC2,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f02(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDAD7E9740h, 7FFDAD7E975Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f02Bytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x0F,0xB6,0xD1,0x0B,0xC2,0xF7,0xD0,0x0F,0xB6,0xC0,0x41,0x0F,0xB6,0xD0,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f03(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDAD7E9770h, 7FFDAD7E9782h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f03Bytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x0F,0xB6,0xD1,0x0B,0xC2,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f04(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDAD7E97A0h, 7FFDAD7E97BBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
000ch or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
000eh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f04Bytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x41,0x0F,0xB6,0xC8,0x0B,0xC1,0xF7,0xD0,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f05(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDAD7E97D0h, 7FFDAD7E97E3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0009h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
000ch or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000eh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f05Bytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD1,0x0B,0xC2,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f06(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDAD7E9800h, 7FFDAD7E981Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0010h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0014h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0016h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0019h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
001bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f06Bytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x41,0x0F,0xB6,0xC8,0x33,0xD1,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f07(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDAD7E9830h, 7FFDAD7E984Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
0014h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0016h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f07Bytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xD1,0x0B,0xC2,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f08(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDAD7E9860h, 7FFDAD7E987Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0010h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0019h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
001bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f08Bytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0x41,0x0F,0xB6,0xD0,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f09(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDAD7E9890h, 7FFDAD7E98ABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
0014h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0016h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f09Bytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x33,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xD1,0x0B,0xC2,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f0A(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDAD7E98C0h, 7FFDAD7E98D6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0011h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0ABytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0x0F,0xB6,0xC0,0x41,0x0F,0xB6,0xD0,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f0B(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDAD7E98F0h, 7FFDAD7E9941h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0007h mov esi,r8d                   ; MOV(Mov_r32_rm32) [ESI,R8D]                          encoding(3 bytes) = 41 8b f0
000ah movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
000dh not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
000fh movzx edi,cl                  ; MOVZX(Movzx_r32_rm8) [EDI,CL]                        encoding(4 bytes) = 40 0f b6 f9
0013h movzx ebx,dl                  ; MOVZX(Movzx_r32_rm8) [EBX,DL]                        encoding(3 bytes) = 0f b6 da
0016h mov rcx,7FFDAD1C8070h         ; MOV(Mov_r64_imm64) [RCX,7ffdad1c8070h:imm64]         encoding(10 bytes) = 48 b9 70 80 1c ad fd 7f 00 00
0020h mov edx,182h                  ; MOV(Mov_r32_imm32) [EDX,182h:imm32]                  encoding(5 bytes) = ba 82 01 00 00
0025h call 7FFE0CC248B0h            ; CALL(Call_rel32_64) [5F43AFC0h:jmp64]                encoding(5 bytes) = e8 96 af 43 5f
002ah mov rax,7FFDAD1C86F0h         ; MOV(Mov_r64_imm64) [RAX,7ffdad1c86f0h:imm64]         encoding(10 bytes) = 48 b8 f0 86 1c ad fd 7f 00 00
0034h movzx eax,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,DS:sr)]      encoding(3 bytes) = 0f b6 00
0037h xor eax,ebx                   ; XOR(Xor_r32_rm32) [EAX,EBX]                          encoding(2 bytes) = 33 c3
0039h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003ch movzx edx,sil                 ; MOVZX(Movzx_r32_rm8) [EDX,SIL]                       encoding(4 bytes) = 40 0f b6 d6
0040h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0042h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0045h or eax,edi                    ; OR(Or_r32_rm32) [EAX,EDI]                            encoding(2 bytes) = 0b c7
0047h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
004ah add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
004eh pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
004fh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0050h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0051h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0BBytes => new byte[82]{0x57,0x56,0x53,0x48,0x83,0xEC,0x20,0x41,0x8B,0xF0,0x0F,0xB6,0xC9,0xF7,0xD1,0x40,0x0F,0xB6,0xF9,0x0F,0xB6,0xDA,0x48,0xB9,0x70,0x80,0x1C,0xAD,0xFD,0x7F,0x00,0x00,0xBA,0x82,0x01,0x00,0x00,0xE8,0x96,0xAF,0x43,0x5F,0x48,0xB8,0xF0,0x86,0x1C,0xAD,0xFD,0x7F,0x00,0x00,0x0F,0xB6,0x00,0x33,0xC3,0x0F,0xB6,0xC0,0x40,0x0F,0xB6,0xD6,0x0B,0xC2,0x0F,0xB6,0xC0,0x0B,0xC7,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x20,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f0C(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDAD7E9960h, 7FFDAD7E9975h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0010h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0CBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f0D(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDAD7E9990h, 7FFDAD7E99E3h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0007h mov esi,edx                   ; MOV(Mov_r32_rm32) [ESI,EDX]                          encoding(2 bytes) = 8b f2
0009h mov edi,r8d                   ; MOV(Mov_r32_rm32) [EDI,R8D]                          encoding(3 bytes) = 41 8b f8
000ch movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
000fh not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
0011h movzx ebx,cl                  ; MOVZX(Movzx_r32_rm8) [EBX,CL]                        encoding(3 bytes) = 0f b6 d9
0014h mov rcx,7FFDAD1C8070h         ; MOV(Mov_r64_imm64) [RCX,7ffdad1c8070h:imm64]         encoding(10 bytes) = 48 b9 70 80 1c ad fd 7f 00 00
001eh mov edx,182h                  ; MOV(Mov_r32_imm32) [EDX,182h:imm32]                  encoding(5 bytes) = ba 82 01 00 00
0023h call 7FFE0CC248B0h            ; CALL(Call_rel32_64) [5F43AF20h:jmp64]                encoding(5 bytes) = e8 f8 ae 43 5f
0028h mov rax,7FFDAD1C86F0h         ; MOV(Mov_r64_imm64) [RAX,7ffdad1c86f0h:imm64]         encoding(10 bytes) = 48 b8 f0 86 1c ad fd 7f 00 00
0032h movzx eax,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,DS:sr)]      encoding(3 bytes) = 0f b6 00
0035h movzx edx,dil                 ; MOVZX(Movzx_r32_rm8) [EDX,DIL]                       encoding(4 bytes) = 40 0f b6 d7
0039h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
003bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003eh movzx edx,sil                 ; MOVZX(Movzx_r32_rm8) [EDX,SIL]                       encoding(4 bytes) = 40 0f b6 d6
0042h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0044h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0047h or eax,ebx                    ; OR(Or_r32_rm32) [EAX,EBX]                            encoding(2 bytes) = 0b c3
0049h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
004ch add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0050h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0051h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0052h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0053h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0DBytes => new byte[84]{0x57,0x56,0x53,0x48,0x83,0xEC,0x20,0x8B,0xF2,0x41,0x8B,0xF8,0x0F,0xB6,0xC9,0xF7,0xD1,0x0F,0xB6,0xD9,0x48,0xB9,0x70,0x80,0x1C,0xAD,0xFD,0x7F,0x00,0x00,0xBA,0x82,0x01,0x00,0x00,0xE8,0xF8,0xAE,0x43,0x5F,0x48,0xB8,0xF0,0x86,0x1C,0xAD,0xFD,0x7F,0x00,0x00,0x0F,0xB6,0x00,0x40,0x0F,0xB6,0xD7,0x33,0xC2,0x0F,0xB6,0xC0,0x40,0x0F,0xB6,0xD6,0x0B,0xC2,0x0F,0xB6,0xC0,0x0B,0xC3,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x20,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f0E(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDAD7E9A00h, 7FFDAD7E9A1Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0010h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0014h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0016h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0019h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
001bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0EBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x41,0x0F,0xB6,0xC8,0x0B,0xD1,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f0F(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDAD7E9A30h, 7FFDAD7E9A3Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0FBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f10(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDAD7E9A50h, 7FFDAD7E9A6Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000eh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f10Bytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x0B,0xC2,0xF7,0xD0,0x0F,0xB6,0xC0,0x0F,0xB6,0xD1,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f11(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDAD7E9A80h, 7FFDAD7E9A93h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0009h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000ch or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000eh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f11Bytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x0B,0xC2,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f12(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDAD7E9AB0h, 7FFDAD7E9ACEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
0010h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0014h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0016h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0019h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
001bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f12Bytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0xF7,0xD0,0x0F,0xB6,0xC0,0x0F,0xB6,0xD1,0x41,0x0F,0xB6,0xC8,0x33,0xD1,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
