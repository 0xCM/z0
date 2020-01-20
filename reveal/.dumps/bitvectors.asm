; 2020-01-20 01:59:22:090
; BitVector<byte> bvand_8(BitVector<byte> x, BitVector<byte> y)
; static ReadOnlySpan<byte> bvand_8_0xBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x23,0xC2,0x0F,0xB6,0xC0,0xC3};
; [0x7ff7c860d360, 0x7ff7c860d374], 20 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c1}
0008h movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
000bh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
000eh and eax,edx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 c2}
0010h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0013h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector8 bvand_d8(BitVector8 x, BitVector8 y)
; static ReadOnlySpan<byte> bvand_d8_0xBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0xC3};
; [0x7ff7c860d540, 0x7ff7c860d551], 17 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c1}
0008h movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
000bh and eax,edx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 c2}
000dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0010h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector<uint> bvand_32(BitVector<uint> x, BitVector<uint> y)
; static ReadOnlySpan<byte> bvand_32_0xBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xC3};
; [0x7ff7c860d570, 0x7ff7c860d57a], 10 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h and edx,ecx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 d1}
0007h mov eax,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c2}
0009h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 bvand_d32(BitVector32 x, BitVector32 y)
; static ReadOnlySpan<byte> bvand_d32_0xBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xC3};
; [0x7ff7c860d740, 0x7ff7c860d74a], 10 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h and edx,ecx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 d1}
0007h mov eax,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c2}
0009h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector<ulong> bvand_64(BitVector<ulong> x, BitVector<ulong> y)
; static ReadOnlySpan<byte> bvand_64_0xBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC2,0xC3};
; [0x7ff7c860d760, 0x7ff7c860d76c], 12 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h and rdx,rcx                             ; AND r64, r/m64 || REX.W 23 /r || encoded[3]{48 23 d1}
0008h mov rax,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c2}
000bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector64 bvand_d64(BitVector64 x, BitVector64 y)
; static ReadOnlySpan<byte> bvand_d64_0xBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC2,0xC3};
; [0x7ff7c860d950, 0x7ff7c860d95c], 12 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h and rdx,rcx                             ; AND r64, r/m64 || REX.W 23 /r || encoded[3]{48 23 d1}
0008h mov rax,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c2}
000bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector<byte> bvxor_8(BitVector<byte> x, BitVector<byte> y)
; static ReadOnlySpan<byte> bvxor_8_0xBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
; [0x7ff7c860ded0, 0x7ff7c860dee4], 20 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c1}
0008h movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
000bh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
000eh xor eax,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c2}
0010h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0013h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector<byte> bvxor_g8(BitVector<byte> x, BitVector<byte> y)
; static ReadOnlySpan<byte> bvxor_g8_0xBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
; [0x7ff7c860df00, 0x7ff7c860df14], 20 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c1}
0008h movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
000bh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
000eh xor eax,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c2}
0010h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0013h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector8 bvxor_d8(BitVector8 x, BitVector8 y)
; static ReadOnlySpan<byte> bvxor_d8_0xBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
; [0x7ff7c860df30, 0x7ff7c860df41], 17 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c1}
0008h movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
000bh xor eax,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c2}
000dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0010h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; byte xor_d8(byte x, byte y)
; static ReadOnlySpan<byte> xor_d8_8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
; [0x7ff7c860df60, 0x7ff7c860df71], 17 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c1}
0008h movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
000bh xor eax,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c2}
000dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0010h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; byte xor_g8(byte x, byte y)
; static ReadOnlySpan<byte> xor_g8_8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
; [0x7ff7c860df90, 0x7ff7c860dfa1], 17 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c1}
0008h movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
000bh xor eax,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c2}
000dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0010h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; byte xor_d82(byte x, byte y)
; static ReadOnlySpan<byte> xor_d82_8uBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
; [0x7ff7c860dfc0, 0x7ff7c860dfd1], 17 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c1}
0008h movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
000bh xor eax,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c2}
000dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0010h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 sll_bv_32u(BitVector32 x, byte offset)
; static ReadOnlySpan<byte> sll_bv_32u_0xBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB6,0xCA,0xD3,0xE0,0xC3};
; [0x7ff7c860dff0, 0x7ff7c860dffd], 13 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h movzx ecx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 ca}
000ah shl eax,cl                              ; SHL r/m32, CL || o32 D3 /4 || encoded[2]{d3 e0}
000ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 sll_bv_o32u(BitVector32 x, byte offset)
; static ReadOnlySpan<byte> sll_bv_o32u_0xBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB6,0xCA,0xD3,0xE0,0xC3};
; [0x7ff7c860e010, 0x7ff7c860e01d], 13 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h movzx ecx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 ca}
000ah shl eax,cl                              ; SHL r/m32, CL || o32 D3 /4 || encoded[2]{d3 e0}
000ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 srl_bv_32u(BitVector32 x, byte offset)
; static ReadOnlySpan<byte> srl_bv_32u_0xBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB6,0xCA,0xD3,0xE8,0xC3};
; [0x7ff7c860e030, 0x7ff7c860e03d], 13 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h movzx ecx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 ca}
000ah shr eax,cl                              ; SHR r/m32, CL || o32 D3 /5 || encoded[2]{d3 e8}
000ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 srl_bv_o32u(BitVector32 x, byte offset)
; static ReadOnlySpan<byte> srl_bv_o32u_0xBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB6,0xCA,0xD3,0xE8,0xC3};
; [0x7ff7c860e050, 0x7ff7c860e05d], 13 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h movzx ecx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 ca}
000ah shr eax,cl                              ; SHR r/m32, CL || o32 D3 /5 || encoded[2]{d3 e8}
000ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 flip_bv_32u(BitVector32 x)
; static ReadOnlySpan<byte> flip_bv_32u_0xBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
; [0x7ff7c860e070, 0x7ff7c860e07a], 10 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h not eax                                 ; NOT r/m32 || o32 F7 /2 || encoded[2]{f7 d0}
0009h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 flip_bv_o32u(BitVector32 x)
; static ReadOnlySpan<byte> flip_bv_o32u_0xBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
; [0x7ff7c860e090, 0x7ff7c860e09a], 10 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h not eax                                 ; NOT r/m32 || o32 F7 /2 || encoded[2]{f7 d0}
0009h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 negate_bv_32u(BitVector32 x)
; static ReadOnlySpan<byte> negate_bv_32u_0xBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC3};
; [0x7ff7c860e0b0, 0x7ff7c860e0bc], 12 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h not eax                                 ; NOT r/m32 || o32 F7 /2 || encoded[2]{f7 d0}
0009h inc eax                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c0}
000bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 negate_bv_o32u(BitVector32 x)
; static ReadOnlySpan<byte> negate_bv_o32u_0xBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC3};
; [0x7ff7c860e0d0, 0x7ff7c860e0dc], 12 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h not eax                                 ; NOT r/m32 || o32 F7 /2 || encoded[2]{f7 d0}
0009h inc eax                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c0}
000bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 inc_bv_32u(BitVector32 x)
; static ReadOnlySpan<byte> inc_bv_32u_0xBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC1,0x8B,0xC1,0xC3};
; [0x7ff7c860e0f0, 0x7ff7c860e0fa], 10 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h inc ecx                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c1}
0007h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0009h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 inc_bv_o32u(BitVector32 x)
; static ReadOnlySpan<byte> inc_bv_o32u_0xBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC1,0x8B,0xC1,0xC3};
; [0x7ff7c860e110, 0x7ff7c860e11a], 10 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h inc ecx                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c1}
0007h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0009h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 dec_bv_32u(BitVector32 x)
; static ReadOnlySpan<byte> dec_bv_32u_0xBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC9,0x8B,0xC1,0xC3};
; [0x7ff7c860e130, 0x7ff7c860e13a], 10 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h dec ecx                                 ; DEC r/m32 || o32 FF /1 || encoded[2]{ff c9}
0007h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0009h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 dec_bv_o32u(BitVector32 x)
; static ReadOnlySpan<byte> dec_bv_o32u_0xBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xC9,0x8B,0xC1,0xC3};
; [0x7ff7c860e150, 0x7ff7c860e15a], 10 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h dec ecx                                 ; DEC r/m32 || o32 FF /1 || encoded[2]{ff c9}
0007h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0009h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 rotl_bv_32u(BitVector32 x, byte offset)
; static ReadOnlySpan<byte> rotl_bv_32u_0xBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB6,0xCA,0xD3,0xC0,0xC3};
; [0x7ff7c860e170, 0x7ff7c860e17d], 13 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h movzx ecx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 ca}
000ah rol eax,cl                              ; ROL r/m32, CL || o32 D3 /0 || encoded[2]{d3 c0}
000ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 rotr_bv_32u(BitVector32 x, byte offset)
; static ReadOnlySpan<byte> rotr_bv_32u_0xBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0F,0xB6,0xCA,0xD3,0xC8,0xC3};
; [0x7ff7c860e190, 0x7ff7c860e19d], 13 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h movzx ecx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 ca}
000ah ror eax,cl                              ; ROR r/m32, CL || o32 D3 /1 || encoded[2]{d3 c8}
000ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 alt_32()
; static ReadOnlySpan<byte> alt_32_11012038Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xAA,0xAA,0xAA,0xAA,0xC3};
; [0x7ff7c860e1b0, 0x7ff7c860e1bb], 11 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,0AAAAAAAAh                      ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 aa aa aa aa}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector<uint> alt_32g()
; static ReadOnlySpan<byte> alt_32g_31999479Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xAA,0xAA,0xAA,0xAA,0xC3};
; [0x7ff7c860e5e0, 0x7ff7c860e5eb], 11 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,0AAAAAAAAh                      ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 aa aa aa aa}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit dot_32g(BitVector<uint> x, BitVector<uint> y)
; static ReadOnlySpan<byte> dot_32g_0xBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x33,0xC0,0xF3,0x0F,0xB8,0xC2,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
; [0x7ff7c860e600, 0x7ff7c860e616], 22 bytes
; 2020-01-20 01:59:22:090
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h and edx,ecx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 d1}
0007h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0009h popcnt eax,edx                          ; POPCNT r32, r/m32 || o32 F3 0F B8 /r || encoded[4]{f3 0f b8 c2}
000dh test al,1                               ; TEST AL, imm8 || A8 ib || encoded[2]{a8 01}
000fh setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
0012h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitMatrix<uint> oprod_1(BitVector32 x, BitVector32 y)
; static ReadOnlySpan<byte> oprod_1_19559856Bytes => new byte[125]{0x57,0x56,0x53,0x48,0x83,0xEC,0x30,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xD9,0x8B,0xF2,0x41,0x8B,0xF8,0x48,0x8D,0x4C,0x24,0x20,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0x48,0x8D,0x4C,0x24,0x20,0xE8,0x70,0xF5,0xFF,0xFF,0x48,0x8D,0x4C,0x24,0x20,0x48,0x8B,0x01,0x33,0xD2,0x48,0x63,0xCA,0x4C,0x8D,0x04,0x88,0x0F,0xB6,0xCA,0x44,0x8B,0xCE,0x41,0xD3,0xE9,0x41,0x83,0xE1,0x01,0x45,0x85,0xC9,0x75,0x04,0x33,0xC9,0xEB,0x02,0x8B,0xCF,0x41,0x89,0x08,0xFF,0xC2,0x83,0xFA,0x20,0x7C,0xD7,0x48,0x8D,0x74,0x24,0x20,0x48,0x8B,0xFB,0xE8,0x70,0x6F,0x38,0x5F,0x48,0xA5,0x48,0x8B,0xC3,0x48,0x83,0xC4,0x30,0x5B,0x5E,0x5F,0xC3};
; [0x7ff7c860eeb0, 0x7ff7c860ef2d], 125 bytes
; 2020-01-20 01:59:22:090
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h sub rsp,30h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 30}
0007h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
000ah xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
000ch mov [rsp+20h],rax                       ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 44 24 20}
0011h mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
0014h mov esi,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b f2}
0016h mov edi,r8d                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b f8}
0019h lea rcx,[rsp+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 4c 24 20}
001eh vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
0022h vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}
0026h lea rcx,[rsp+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 4c 24 20}
002bh call 7FF7C860E450h                      ; CALL rel32 || E8 cd || encoded[5]{e8 70 f5 ff ff}
0030h lea rcx,[rsp+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 4c 24 20}
0035h mov rax,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 01}
0038h xor edx,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d2}
003ah movsxd rcx,edx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 ca}
003dh lea r8,[rax+rcx*4]                      ; LEA r64, m || REX.W 8D /r || encoded[4]{4c 8d 04 88}
0041h movzx ecx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 ca}
0044h mov r9d,esi                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{44 8b ce}
0047h shr r9d,cl                              ; SHR r/m32, CL || o32 D3 /5 || encoded[3]{41 d3 e9}
004ah and r9d,1                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[4]{41 83 e1 01}
004eh test r9d,r9d                            ; TEST r/m32, r32 || o32 85 /r || encoded[3]{45 85 c9}
0051h jne short 0057h                         ; JNE rel8 || 75 cb || encoded[2]{75 04}
0053h xor ecx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c9}
0055h jmp short 0059h                         ; JMP rel8 || EB cb || encoded[2]{eb 02}
0057h mov ecx,edi                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b cf}
0059h mov [r8],ecx                            ; MOV r/m32, r32 || o32 89 /r || encoded[3]{41 89 08}
005ch inc edx                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c2}
005eh cmp edx,20h                             ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 fa 20}
0061h jl short 003ah                          ; JL rel8 || 7C cb || encoded[2]{7c d7}
0063h lea rsi,[rsp+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 74 24 20}
0068h mov rdi,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fb}
006bh call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 70 6f 38 5f}
0070h movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
0072h mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
0075h add rsp,30h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 30}
0079h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
007ah pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
007bh pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
007ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitMatrix<uint> oprod_2(BitVector<uint> x, BitVector<uint> y)
; static ReadOnlySpan<byte> oprod_2_40844486Bytes => new byte[125]{0x57,0x56,0x53,0x48,0x83,0xEC,0x30,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8B,0xD9,0x8B,0xF2,0x41,0x8B,0xF8,0x48,0x8D,0x4C,0x24,0x20,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0x48,0x8D,0x4C,0x24,0x20,0xE8,0xD0,0xF4,0xFF,0xFF,0x48,0x8D,0x4C,0x24,0x20,0x48,0x8B,0x01,0x33,0xD2,0x48,0x63,0xCA,0x4C,0x8D,0x04,0x88,0x0F,0xB6,0xCA,0x44,0x8B,0xCE,0x41,0xD3,0xE9,0x41,0x83,0xE1,0x01,0x45,0x85,0xC9,0x75,0x04,0x33,0xC9,0xEB,0x02,0x8B,0xCF,0x41,0x89,0x08,0xFF,0xC2,0x83,0xFA,0x20,0x7C,0xD7,0x48,0x8D,0x74,0x24,0x20,0x48,0x8B,0xFB,0xE8,0xD0,0x6E,0x38,0x5F,0x48,0xA5,0x48,0x8B,0xC3,0x48,0x83,0xC4,0x30,0x5B,0x5E,0x5F,0xC3};
; [0x7ff7c860ef50, 0x7ff7c860efcd], 125 bytes
; 2020-01-20 01:59:22:090
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h sub rsp,30h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 30}
0007h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
000ah xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
000ch mov [rsp+20h],rax                       ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 44 24 20}
0011h mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
0014h mov esi,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b f2}
0016h mov edi,r8d                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b f8}
0019h lea rcx,[rsp+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 4c 24 20}
001eh vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
0022h vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}
0026h lea rcx,[rsp+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 4c 24 20}
002bh call 7FF7C860E450h                      ; CALL rel32 || E8 cd || encoded[5]{e8 d0 f4 ff ff}
0030h lea rcx,[rsp+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 4c 24 20}
0035h mov rax,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 01}
0038h xor edx,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d2}
003ah movsxd rcx,edx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 ca}
003dh lea r8,[rax+rcx*4]                      ; LEA r64, m || REX.W 8D /r || encoded[4]{4c 8d 04 88}
0041h movzx ecx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 ca}
0044h mov r9d,esi                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{44 8b ce}
0047h shr r9d,cl                              ; SHR r/m32, CL || o32 D3 /5 || encoded[3]{41 d3 e9}
004ah and r9d,1                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[4]{41 83 e1 01}
004eh test r9d,r9d                            ; TEST r/m32, r32 || o32 85 /r || encoded[3]{45 85 c9}
0051h jne short 0057h                         ; JNE rel8 || 75 cb || encoded[2]{75 04}
0053h xor ecx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c9}
0055h jmp short 0059h                         ; JMP rel8 || EB cb || encoded[2]{eb 02}
0057h mov ecx,edi                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b cf}
0059h mov [r8],ecx                            ; MOV r/m32, r32 || o32 89 /r || encoded[3]{41 89 08}
005ch inc edx                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c2}
005eh cmp edx,20h                             ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 fa 20}
0061h jl short 003ah                          ; JL rel8 || 7C cb || encoded[2]{7c d7}
0063h lea rsi,[rsp+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 74 24 20}
0068h mov rdi,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fb}
006bh call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 d0 6e 38 5f}
0070h movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
0072h mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
0075h add rsp,30h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 30}
0079h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
007ah pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
007bh pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
007ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ref BitMatrix<uint> oprod_3(BitVector<uint> x, BitVector<uint> y, ref BitMatrix<uint> z)
; static ReadOnlySpan<byte> oprod_3_20069106Bytes => new byte[58]{0x56,0x0F,0x1F,0x40,0x00,0x8B,0xC1,0x4D,0x8B,0x08,0x45,0x33,0xD2,0x49,0x63,0xCA,0x4D,0x8D,0x1C,0x89,0x41,0x0F,0xB6,0xCA,0x8B,0xF0,0xD3,0xEE,0x83,0xE6,0x01,0x85,0xF6,0x75,0x04,0x33,0xC9,0xEB,0x02,0x8B,0xCA,0x41,0x89,0x0B,0x41,0xFF,0xC2,0x41,0x83,0xFA,0x20,0x7C,0xD8,0x49,0x8B,0xC0,0x5E,0xC3};
; [0x7ff7c860eff0, 0x7ff7c860f02a], 58 bytes
; 2020-01-20 01:59:22:091
0000h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0001h nop dword ptr [rax]                     ; NOP r/m32 || o32 0F 1F /0 || encoded[4]{0f 1f 40 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h mov r9,[r8]                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b 08}
000ah xor r10d,r10d                           ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 d2}
000dh movsxd rcx,r10d                         ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{49 63 ca}
0010h lea r11,[r9+rcx*4]                      ; LEA r64, m || REX.W 8D /r || encoded[4]{4d 8d 1c 89}
0014h movzx ecx,r10b                          ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{41 0f b6 ca}
0018h mov esi,eax                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b f0}
001ah shr esi,cl                              ; SHR r/m32, CL || o32 D3 /5 || encoded[2]{d3 ee}
001ch and esi,1                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e6 01}
001fh test esi,esi                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 f6}
0021h jne short 0027h                         ; JNE rel8 || 75 cb || encoded[2]{75 04}
0023h xor ecx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c9}
0025h jmp short 0029h                         ; JMP rel8 || EB cb || encoded[2]{eb 02}
0027h mov ecx,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b ca}
0029h mov [r11],ecx                           ; MOV r/m32, r32 || o32 89 /r || encoded[3]{41 89 0b}
002ch inc r10d                                ; INC r/m32 || o32 FF /0 || encoded[3]{41 ff c2}
002fh cmp r10d,20h                            ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[4]{41 83 fa 20}
0033h jl short 000dh                          ; JL rel8 || 7C cb || encoded[2]{7c d8}
0035h mov rax,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b c0}
0038h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
0039h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ref BitMatrix<ulong> oprod_4(BitVector<ulong> x, BitVector<ulong> y, ref BitMatrix<ulong> z)
; static ReadOnlySpan<byte> oprod_4_46404226Bytes => new byte[64]{0x56,0x0F,0x1F,0x40,0x00,0x48,0x8B,0xC1,0x4D,0x8B,0x08,0x45,0x33,0xD2,0x49,0x63,0xCA,0x4D,0x8D,0x1C,0xC9,0x41,0x0F,0xB6,0xCA,0x48,0x8B,0xF0,0x48,0xD3,0xEE,0x8B,0xCE,0x83,0xE1,0x01,0x85,0xC9,0x75,0x04,0x33,0xC9,0xEB,0x03,0x48,0x8B,0xCA,0x49,0x89,0x0B,0x41,0xFF,0xC2,0x41,0x83,0xFA,0x40,0x7C,0xD3,0x49,0x8B,0xC0,0x5E,0xC3};
; [0x7ff7c860f040, 0x7ff7c860f080], 64 bytes
; 2020-01-20 01:59:22:091
0000h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0001h nop dword ptr [rax]                     ; NOP r/m32 || o32 0F 1F /0 || encoded[4]{0f 1f 40 00}
0005h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0008h mov r9,[r8]                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b 08}
000bh xor r10d,r10d                           ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 d2}
000eh movsxd rcx,r10d                         ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{49 63 ca}
0011h lea r11,[r9+rcx*8]                      ; LEA r64, m || REX.W 8D /r || encoded[4]{4d 8d 1c c9}
0015h movzx ecx,r10b                          ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{41 0f b6 ca}
0019h mov rsi,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f0}
001ch shr rsi,cl                              ; SHR r/m64, CL || REX.W D3 /5 || encoded[3]{48 d3 ee}
001fh mov ecx,esi                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b ce}
0021h and ecx,1                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e1 01}
0024h test ecx,ecx                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c9}
0026h jne short 002ch                         ; JNE rel8 || 75 cb || encoded[2]{75 04}
0028h xor ecx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c9}
002ah jmp short 002fh                         ; JMP rel8 || EB cb || encoded[2]{eb 03}
002ch mov rcx,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b ca}
002fh mov [r11],rcx                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 0b}
0032h inc r10d                                ; INC r/m32 || o32 FF /0 || encoded[3]{41 ff c2}
0035h cmp r10d,40h                            ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[4]{41 83 fa 40}
0039h jl short 000eh                          ; JL rel8 || 7C cb || encoded[2]{7c d3}
003bh mov rax,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b c0}
003eh pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
003fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
