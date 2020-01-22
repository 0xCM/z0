; 2020-01-22 01:43:39:955
; BitVector<byte> bvand_8(BitVector<byte> x, BitVector<byte> y)
; bvand_8_0x[0x7ff7c85bdc90, 0x7ff7c85bdca4][20] = {0f 1f 44 00 00 0f b6 c1 0f b6 d2 0f b6 c0 23 c2 0f b6 c0 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c1}
0008h movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
000bh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
000eh and eax,edx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 c2}
0010h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0013h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector8 bvand_d8(BitVector8 x, BitVector8 y)
; bvand_d8_0x[0x7ff7c85bdcc0, 0x7ff7c85bdcd1][17] = {0f 1f 44 00 00 0f b6 c1 0f b6 d2 23 c2 0f b6 c0 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c1}
0008h movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
000bh and eax,edx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 c2}
000dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0010h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector<uint> bvand_32(BitVector<uint> x, BitVector<uint> y)
; bvand_32_0x[0x7ff7c85bdcf0, 0x7ff7c85bdcfa][10] = {0f 1f 44 00 00 23 d1 8b c2 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h and edx,ecx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 d1}
0007h mov eax,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c2}
0009h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 bvand_d32(BitVector32 x, BitVector32 y)
; bvand_d32_0x[0x7ff7c85bdd10, 0x7ff7c85bdd1a][10] = {0f 1f 44 00 00 23 d1 8b c2 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h and edx,ecx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 d1}
0007h mov eax,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c2}
0009h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector<ulong> bvand_64(BitVector<ulong> x, BitVector<ulong> y)
; bvand_64_0x[0x7ff7c85be140, 0x7ff7c85be14c][12] = {0f 1f 44 00 00 48 23 d1 48 8b c2 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h and rdx,rcx                             ; AND r64, r/m64 || REX.W 23 /r || encoded[3]{48 23 d1}
0008h mov rax,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c2}
000bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector64 bvand_d64(BitVector64 x, BitVector64 y)
; bvand_d64_0x[0x7ff7c85be160, 0x7ff7c85be16c][12] = {0f 1f 44 00 00 48 23 d1 48 8b c2 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h and rdx,rcx                             ; AND r64, r/m64 || REX.W 23 /r || encoded[3]{48 23 d1}
0008h mov rax,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c2}
000bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector<byte> bvxor_8(BitVector<byte> x, BitVector<byte> y)
; bvxor_8_0x[0x7ff7c85be590, 0x7ff7c85be5a4][20] = {0f 1f 44 00 00 0f b6 c1 0f b6 d2 0f b6 c0 33 c2 0f b6 c0 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c1}
0008h movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
000bh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
000eh xor eax,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c2}
0010h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0013h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector<byte> bvxor_g8(BitVector<byte> x, BitVector<byte> y)
; bvxor_g8_0x[0x7ff7c85be5c0, 0x7ff7c85be5d4][20] = {0f 1f 44 00 00 0f b6 c1 0f b6 d2 0f b6 c0 33 c2 0f b6 c0 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c1}
0008h movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
000bh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
000eh xor eax,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c2}
0010h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0013h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector8 bvxor_d8(BitVector8 x, BitVector8 y)
; bvxor_d8_0x[0x7ff7c85be5f0, 0x7ff7c85be601][17] = {0f 1f 44 00 00 0f b6 c1 0f b6 d2 33 c2 0f b6 c0 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c1}
0008h movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
000bh xor eax,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c2}
000dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0010h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; byte xor_d8(byte x, byte y)
; xor_d8_8u[0x7ff7c85be620, 0x7ff7c85be631][17] = {0f 1f 44 00 00 0f b6 c1 0f b6 d2 33 c2 0f b6 c0 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c1}
0008h movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
000bh xor eax,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c2}
000dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0010h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; byte xor_g8(byte x, byte y)
; xor_g8_8u[0x7ff7c85be650, 0x7ff7c85be661][17] = {0f 1f 44 00 00 0f b6 c1 0f b6 d2 33 c2 0f b6 c0 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c1}
0008h movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
000bh xor eax,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c2}
000dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0010h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; byte xor_d82(byte x, byte y)
; xor_d82_8u[0x7ff7c85be680, 0x7ff7c85be691][17] = {0f 1f 44 00 00 0f b6 c1 0f b6 d2 33 c2 0f b6 c0 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c1}
0008h movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
000bh xor eax,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c2}
000dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0010h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 sll_bv_32u(BitVector32 x, byte offset)
; sll_bv_32u_0x[0x7ff7c85be6b0, 0x7ff7c85be6bd][13] = {0f 1f 44 00 00 8b c1 0f b6 ca d3 e0 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h movzx ecx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 ca}
000ah shl eax,cl                              ; SHL r/m32, CL || o32 D3 /4 || encoded[2]{d3 e0}
000ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 sll_bv_o32u(BitVector32 x, byte offset)
; sll_bv_o32u_0x[0x7ff7c85be6d0, 0x7ff7c85be6dd][13] = {0f 1f 44 00 00 8b c1 0f b6 ca d3 e0 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h movzx ecx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 ca}
000ah shl eax,cl                              ; SHL r/m32, CL || o32 D3 /4 || encoded[2]{d3 e0}
000ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 srl_bv_32u(BitVector32 x, byte offset)
; srl_bv_32u_0x[0x7ff7c85be6f0, 0x7ff7c85be6fd][13] = {0f 1f 44 00 00 8b c1 0f b6 ca d3 e8 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h movzx ecx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 ca}
000ah shr eax,cl                              ; SHR r/m32, CL || o32 D3 /5 || encoded[2]{d3 e8}
000ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 srl_bv_o32u(BitVector32 x, byte offset)
; srl_bv_o32u_0x[0x7ff7c85be710, 0x7ff7c85be71d][13] = {0f 1f 44 00 00 8b c1 0f b6 ca d3 e8 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h movzx ecx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 ca}
000ah shr eax,cl                              ; SHR r/m32, CL || o32 D3 /5 || encoded[2]{d3 e8}
000ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 flip_bv_32u(BitVector32 x)
; flip_bv_32u_0x[0x7ff7c85be730, 0x7ff7c85be73a][10] = {0f 1f 44 00 00 8b c1 f7 d0 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h not eax                                 ; NOT r/m32 || o32 F7 /2 || encoded[2]{f7 d0}
0009h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 flip_bv_o32u(BitVector32 x)
; flip_bv_o32u_0x[0x7ff7c85be750, 0x7ff7c85be75a][10] = {0f 1f 44 00 00 8b c1 f7 d0 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h not eax                                 ; NOT r/m32 || o32 F7 /2 || encoded[2]{f7 d0}
0009h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 negate_bv_32u(BitVector32 x)
; negate_bv_32u_0x[0x7ff7c85be770, 0x7ff7c85be77c][12] = {0f 1f 44 00 00 8b c1 f7 d0 ff c0 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h not eax                                 ; NOT r/m32 || o32 F7 /2 || encoded[2]{f7 d0}
0009h inc eax                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c0}
000bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 negate_bv_o32u(BitVector32 x)
; negate_bv_o32u_0x[0x7ff7c85be790, 0x7ff7c85be79c][12] = {0f 1f 44 00 00 8b c1 f7 d0 ff c0 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h not eax                                 ; NOT r/m32 || o32 F7 /2 || encoded[2]{f7 d0}
0009h inc eax                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c0}
000bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 inc_bv_32u(BitVector32 x)
; inc_bv_32u_0x[0x7ff7c85be7b0, 0x7ff7c85be7ba][10] = {0f 1f 44 00 00 ff c1 8b c1 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h inc ecx                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c1}
0007h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0009h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 inc_bv_o32u(BitVector32 x)
; inc_bv_o32u_0x[0x7ff7c85be7d0, 0x7ff7c85be7da][10] = {0f 1f 44 00 00 ff c1 8b c1 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h inc ecx                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c1}
0007h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0009h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 dec_bv_32u(BitVector32 x)
; dec_bv_32u_0x[0x7ff7c85be7f0, 0x7ff7c85be7fa][10] = {0f 1f 44 00 00 ff c9 8b c1 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h dec ecx                                 ; DEC r/m32 || o32 FF /1 || encoded[2]{ff c9}
0007h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0009h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 dec_bv_o32u(BitVector32 x)
; dec_bv_o32u_0x[0x7ff7c85be810, 0x7ff7c85be81a][10] = {0f 1f 44 00 00 ff c9 8b c1 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h dec ecx                                 ; DEC r/m32 || o32 FF /1 || encoded[2]{ff c9}
0007h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0009h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 rotl_bv_32u(BitVector32 x, byte offset)
; rotl_bv_32u_0x[0x7ff7c85be830, 0x7ff7c85be83d][13] = {0f 1f 44 00 00 8b c1 0f b6 ca d3 c0 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h movzx ecx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 ca}
000ah rol eax,cl                              ; ROL r/m32, CL || o32 D3 /0 || encoded[2]{d3 c0}
000ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 rotr_bv_32u(BitVector32 x, byte offset)
; rotr_bv_32u_0x[0x7ff7c85be850, 0x7ff7c85be85d][13] = {0f 1f 44 00 00 8b c1 0f b6 ca d3 c8 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h movzx ecx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 ca}
000ah ror eax,cl                              ; ROR r/m32, CL || o32 D3 /1 || encoded[2]{d3 c8}
000ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector32 alt_32()
; alt_32_26087949[0x7ff7c85be870, 0x7ff7c85be87b][11] = {0f 1f 44 00 00 b8 aa aa aa aa c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,0AAAAAAAAh                      ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 aa aa aa aa}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitVector<uint> alt_32g()
; alt_32g_33464950[0x7ff7c85be890, 0x7ff7c85be89b][11] = {0f 1f 44 00 00 b8 aa aa aa aa c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,0AAAAAAAAh                      ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 aa aa aa aa}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit dot_32g(BitVector<uint> x, BitVector<uint> y)
; dot_32g_0x[0x7ff7c85becc0, 0x7ff7c85becd6][22] = {0f 1f 44 00 00 23 d1 33 c0 f3 0f b8 c2 a8 01 0f 95 c0 0f b6 c0 c3}
; Capture completion code, None
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
; oprod_1_32749101[0x7ff7c85bf420, 0x7ff7c85bf49d][125] = {57 56 53 48 83 ec 30 c5 f8 77 33 c0 48 89 44 24 20 48 8b d9 8b f2 41 8b f8 48 8d 4c 24 20 c5 f8 57 c0 c5 fa 7f 01 48 8d 4c 24 20 e8 b0 f6 ff ff 48 8d 4c 24 20 48 8b 01 33 d2 48 63 ca 4c 8d 04 88 0f b6 ca 44 8b ce 41 d3 e9 41 83 e1 01 45 85 c9 75 04 33 c9 eb 02 8b cf 41 89 08 ff c2 83 fa 20 7c d7 48 8d 74 24 20 48 8b fb e8 00 6a 3d 5f 48 a5 48 8b c3 48 83 c4 30 5b 5e 5f c3}
; Capture completion code, None
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
002bh call 7FF7C85BEB00h                      ; CALL rel32 || E8 cd || encoded[5]{e8 b0 f6 ff ff}
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
006bh call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 00 6a 3d 5f}
0070h movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
0072h mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
0075h add rsp,30h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 30}
0079h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
007ah pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
007bh pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
007ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitMatrix<uint> oprod_2(BitVector<uint> x, BitVector<uint> y)
; oprod_2_35431534[0x7ff7c85bf4c0, 0x7ff7c85bf53d][125] = {57 56 53 48 83 ec 30 c5 f8 77 33 c0 48 89 44 24 20 48 8b d9 8b f2 41 8b f8 48 8d 4c 24 20 c5 f8 57 c0 c5 fa 7f 01 48 8d 4c 24 20 e8 10 f6 ff ff 48 8d 4c 24 20 48 8b 01 33 d2 48 63 ca 4c 8d 04 88 0f b6 ca 44 8b ce 41 d3 e9 41 83 e1 01 45 85 c9 75 04 33 c9 eb 02 8b cf 41 89 08 ff c2 83 fa 20 7c d7 48 8d 74 24 20 48 8b fb e8 60 69 3d 5f 48 a5 48 8b c3 48 83 c4 30 5b 5e 5f c3}
; Capture completion code, None
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
002bh call 7FF7C85BEB00h                      ; CALL rel32 || E8 cd || encoded[5]{e8 10 f6 ff ff}
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
006bh call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 60 69 3d 5f}
0070h movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
0072h mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
0075h add rsp,30h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 30}
0079h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
007ah pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
007bh pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
007ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ref BitMatrix<uint> oprod_3(BitVector<uint> x, BitVector<uint> y, ref BitMatrix<uint> z)
; oprod_3_51382007[0x7ff7c85bf560, 0x7ff7c85bf59a][58] = {56 0f 1f 40 00 8b c1 4d 8b 08 45 33 d2 49 63 ca 4d 8d 1c 89 41 0f b6 ca 8b f0 d3 ee 83 e6 01 85 f6 75 04 33 c9 eb 02 8b ca 41 89 0b 41 ff c2 41 83 fa 20 7c d8 49 8b c0 5e c3}
; Capture completion code, None
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
; oprod_4_59784887[0x7ff7c85bf5b0, 0x7ff7c85bf5f0][64] = {56 0f 1f 40 00 48 8b c1 4d 8b 08 45 33 d2 49 63 ca 4d 8d 1c c9 41 0f b6 ca 48 8b f0 48 d3 ee 8b ce 83 e1 01 85 c9 75 04 33 c9 eb 03 48 8b ca 49 89 0b 41 ff c2 41 83 fa 40 7c d3 49 8b c0 5e c3}
; Capture completion code, None
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
