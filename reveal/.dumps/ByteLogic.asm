; 2019-10-15 01:38:29:262
; function: ByteKind:byte and(ByteKind:byte a, ByteKind:byte b)
; location: [7FFDDBEBD800h, 7FFDDBEBD810h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte or(ByteKind:byte a, ByteKind:byte b)
; location: [7FFDDBEBD830h, 7FFDDBEBD840h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte xor(ByteKind:byte a, ByteKind:byte b)
; location: [7FFDDBEBD860h, 7FFDDBEBD870h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte not(ByteKind:byte a)
; location: [7FFDDBEBD890h, 7FFDDBEBD89Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> notBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte nand(ByteKind:byte a, ByteKind:byte b)
; location: [7FFDDBEBD8B0h, 7FFDDBEBD8C2h]
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
; location: [7FFDDBEBD8E0h, 7FFDDBEBD8F2h]
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
; location: [7FFDDBEBD910h, 7FFDDBEBD922h]
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
; location: [7FFDDBEBD940h, 7FFDDBEBD95Dh]
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
; location: [7FFDDBEBD970h, 7FFDDBEBD98Bh]
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
; location: [7FFDDBEBD9A0h, 7FFDDBEBD9BBh]
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
; location: [7FFDDBEBD9D0h, 7FFDDBEBD9E2h]
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
; location: [7FFDDBEBDA00h, 7FFDDBEBDA1Bh]
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
; location: [7FFDDBEBDA30h, 7FFDDBEBDA43h]
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
; location: [7FFDDBEBDA60h, 7FFDDBEBDA7Eh]
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
; location: [7FFDDBEBDA90h, 7FFDDBEBDAABh]
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
; location: [7FFDDBEBDAC0h, 7FFDDBEBDADEh]
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
; location: [7FFDDBEBDAF0h, 7FFDDBEBDB0Bh]
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
; location: [7FFDDBEBDB20h, 7FFDDBEBDB36h]
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
; location: [7FFDDBEBDB50h, 7FFDDBEBDBA1h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0007h mov esi,r8d                   ; MOV(Mov_r32_rm32) [ESI,R8D]                          encoding(3 bytes) = 41 8b f0
000ah movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
000dh not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
000fh movzx edi,cl                  ; MOVZX(Movzx_r32_rm8) [EDI,CL]                        encoding(4 bytes) = 40 0f b6 f9
0013h movzx ebx,dl                  ; MOVZX(Movzx_r32_rm8) [EBX,DL]                        encoding(3 bytes) = 0f b6 da
0016h mov rcx,7FFDDB7584F0h         ; MOV(Mov_r64_imm64) [RCX,7ffddb7584f0h:imm64]         encoding(10 bytes) = 48 b9 f0 84 75 db fd 7f 00 00
0020h mov edx,37h                   ; MOV(Mov_r32_imm32) [EDX,37h:imm32]                   encoding(5 bytes) = ba 37 00 00 00
0025h call 7FFE3B1048B0h            ; CALL(Call_rel32_64) [5F246D60h:jmp64]                encoding(5 bytes) = e8 36 6d 24 5f
002ah mov rax,7FFDDB758720h         ; MOV(Mov_r64_imm64) [RAX,7ffddb758720h:imm64]         encoding(10 bytes) = 48 b8 20 87 75 db fd 7f 00 00
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
; static ReadOnlySpan<byte> f0BBytes => new byte[82]{0x57,0x56,0x53,0x48,0x83,0xEC,0x20,0x41,0x8B,0xF0,0x0F,0xB6,0xC9,0xF7,0xD1,0x40,0x0F,0xB6,0xF9,0x0F,0xB6,0xDA,0x48,0xB9,0xF0,0x84,0x75,0xDB,0xFD,0x7F,0x00,0x00,0xBA,0x37,0x00,0x00,0x00,0xE8,0x36,0x6D,0x24,0x5F,0x48,0xB8,0x20,0x87,0x75,0xDB,0xFD,0x7F,0x00,0x00,0x0F,0xB6,0x00,0x33,0xC3,0x0F,0xB6,0xC0,0x40,0x0F,0xB6,0xD6,0x0B,0xC2,0x0F,0xB6,0xC0,0x0B,0xC7,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x20,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f0C(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDDBEBDBC0h, 7FFDDBEBDBD5h]
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
; location: [7FFDDBEBDBF0h, 7FFDDBEBDC43h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0007h mov esi,edx                   ; MOV(Mov_r32_rm32) [ESI,EDX]                          encoding(2 bytes) = 8b f2
0009h mov edi,r8d                   ; MOV(Mov_r32_rm32) [EDI,R8D]                          encoding(3 bytes) = 41 8b f8
000ch movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
000fh not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
0011h movzx ebx,cl                  ; MOVZX(Movzx_r32_rm8) [EBX,CL]                        encoding(3 bytes) = 0f b6 d9
0014h mov rcx,7FFDDB7584F0h         ; MOV(Mov_r64_imm64) [RCX,7ffddb7584f0h:imm64]         encoding(10 bytes) = 48 b9 f0 84 75 db fd 7f 00 00
001eh mov edx,37h                   ; MOV(Mov_r32_imm32) [EDX,37h:imm32]                   encoding(5 bytes) = ba 37 00 00 00
0023h call 7FFE3B1048B0h            ; CALL(Call_rel32_64) [5F246CC0h:jmp64]                encoding(5 bytes) = e8 98 6c 24 5f
0028h mov rax,7FFDDB758720h         ; MOV(Mov_r64_imm64) [RAX,7ffddb758720h:imm64]         encoding(10 bytes) = 48 b8 20 87 75 db fd 7f 00 00
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
; static ReadOnlySpan<byte> f0DBytes => new byte[84]{0x57,0x56,0x53,0x48,0x83,0xEC,0x20,0x8B,0xF2,0x41,0x8B,0xF8,0x0F,0xB6,0xC9,0xF7,0xD1,0x0F,0xB6,0xD9,0x48,0xB9,0xF0,0x84,0x75,0xDB,0xFD,0x7F,0x00,0x00,0xBA,0x37,0x00,0x00,0x00,0xE8,0x98,0x6C,0x24,0x5F,0x48,0xB8,0x20,0x87,0x75,0xDB,0xFD,0x7F,0x00,0x00,0x0F,0xB6,0x00,0x40,0x0F,0xB6,0xD7,0x33,0xC2,0x0F,0xB6,0xC0,0x40,0x0F,0xB6,0xD6,0x0B,0xC2,0x0F,0xB6,0xC0,0x0B,0xC3,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x20,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f0E(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDDBEBDC60h, 7FFDDBEBDC7Eh]
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
; location: [7FFDDBEBDC90h, 7FFDDBEBDC9Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f0FBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f10(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDDBEBDCB0h, 7FFDDBEBDCCBh]
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
; location: [7FFDDBEBDCE0h, 7FFDDBEBDCF3h]
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
; location: [7FFDDBEBDD10h, 7FFDDBEBDD2Eh]
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
; function: ByteKind:byte f13(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDDBEBDD40h, 7FFDDBEBDD5Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
000ch or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0014h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0016h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f13Bytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x41,0x0F,0xB6,0xC8,0x0B,0xC1,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x0B,0xC2,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f14(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDDBEBDD70h, 7FFDDBEBDD8Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0011h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0014h xor edx,ecx                   ; XOR(Xor_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 33 d1
0016h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0019h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
001bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f14Bytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xB6,0xC0,0xF7,0xD0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC9,0x0F,0xB6,0xD2,0x33,0xD1,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f15(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDDBEBDDA0h, 7FFDDBEBDDBBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0014h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0016h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f15Bytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0x41,0x0F,0xB6,0xD0,0x0B,0xC2,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f16(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDDBEBDDD0h, 7FFDDBEBDE06h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000fh or r8d,edx                    ; OR(Or_r32_rm32) [R8D,EDX]                            encoding(3 bytes) = 44 0b c2
0012h not r8d                       ; NOT(Not_rm32) [R8D]                                  encoding(3 bytes) = 41 f7 d0
0015h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0019h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
001ch mov r9d,ecx                   ; MOV(Mov_r32_rm32) [R9D,ECX]                          encoding(3 bytes) = 44 8b c9
001fh not r9d                       ; NOT(Not_rm32) [R9D]                                  encoding(3 bytes) = 41 f7 d1
0022h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0026h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0028h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002bh and eax,r9d                   ; AND(And_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 23 c1
002eh and ecx,r8d                   ; AND(And_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 23 c8
0031h or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
0033h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f16Bytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x44,0x8B,0xC0,0x44,0x0B,0xC2,0x41,0xF7,0xD0,0x45,0x0F,0xB6,0xC0,0x0F,0xB6,0xC9,0x44,0x8B,0xC9,0x41,0xF7,0xD1,0x45,0x0F,0xB6,0xC9,0x33,0xC2,0x0F,0xB6,0xC0,0x41,0x23,0xC1,0x41,0x23,0xC8,0x0B,0xC1,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f17(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDDBEBDE20h, 7FFDDBEBDE4Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0013h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0016h mov r8d,ecx                   ; MOV(Mov_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 8b c1
0019h not r8d                       ; NOT(Not_rm32) [R8D]                                  encoding(3 bytes) = 41 f7 d0
001ch movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0020h and eax,r8d                   ; AND(And_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 23 c0
0023h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0025h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0027h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002ah not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
002ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f17Bytes => new byte[48]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x0B,0xC2,0x0F,0xB6,0xC0,0x8B,0xD0,0x0F,0xB6,0xC9,0x44,0x8B,0xC1,0x41,0xF7,0xD0,0x45,0x0F,0xB6,0xC0,0x41,0x23,0xC0,0x23,0xD1,0x0B,0xC2,0x0F,0xB6,0xC0,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f18(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDDBEBDE60h, 7FFDDBEBDE7Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh xor edx,eax                   ; XOR(Xor_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 33 d0
000dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0010h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0014h xor eax,ecx                   ; XOR(Xor_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 33 c1
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
001bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f18Bytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xD0,0x0F,0xB6,0xD2,0x41,0x0F,0xB6,0xC8,0x33,0xC1,0x0F,0xB6,0xC0,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f19(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDDBEBDE90h, 7FFDDBEBDEB9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000fh xor r8d,edx                   ; XOR(Xor_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 33 c2
0012h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
001eh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0020h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0023h xor eax,r8d                   ; XOR(Xor_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 33 c0
0026h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f19Bytes => new byte[42]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x44,0x8B,0xC0,0x44,0x33,0xC2,0x45,0x0F,0xB6,0xC0,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xD1,0x0B,0xC2,0x0F,0xB6,0xC0,0x41,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f1a(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDDBEBDED0h, 7FFDDBEBDEF3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh or edx,eax                    ; OR(Or_r32_rm32) [EDX,EAX]                            encoding(2 bytes) = 0b d0
000dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0010h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0014h xor eax,ecx                   ; XOR(Xor_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 33 c1
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
001bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001eh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0020h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1aBytes => new byte[36]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0B,0xD0,0x0F,0xB6,0xD2,0x41,0x0F,0xB6,0xC8,0x33,0xC1,0x0F,0xB6,0xC0,0x0B,0xC2,0x0F,0xB6,0xC0,0xF7,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ByteKind:byte f1b(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
; location: [7FFDDBEBDF10h, 7FFDDBEBDF3Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0011h mov r8d,ecx                   ; MOV(Mov_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 8b c1
0014h not r8d                       ; NOT(Not_rm32) [R8D]                                  encoding(3 bytes) = 41 f7 d0
0017h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001bh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001eh not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
0020h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0023h and edx,r8d                   ; AND(And_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 23 d0
0026h and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
0028h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
002ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> f1bBytes => new byte[46]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0x0F,0xB6,0xC0,0x41,0x0F,0xB6,0xC8,0x44,0x8B,0xC1,0x41,0xF7,0xD0,0x45,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0xF7,0xD2,0x0F,0xB6,0xD2,0x41,0x23,0xD0,0x23,0xC1,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
