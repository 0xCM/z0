; 2020-01-22 01:44:39:911
; bit testbit_8i(sbyte src, int pos)
; testbit_8i_8i[0x7ff7c8381a00, 0x7ff7c8381a13][19] = {0f 1f 44 00 00 48 0f be c1 0f a3 d0 0f 92 c0 0f b6 c0 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movsx rax,cl                            ; MOVSX r64, r/m8 || REX.W 0F BE /r || encoded[4]{48 0f be c1}
0009h bt eax,edx                              ; BT r/m32, r32 || o32 0F A3 /r || encoded[3]{0f a3 d0}
000ch setb al                                 ; SETB r/m8 || 0F 92 /r || encoded[3]{0f 92 c0}
000fh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0012h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit testbit_d8u(byte src, int pos)
; testbit_d8u_8u[0x7ff7c8381a30, 0x7ff7c8381a40][16] = {0f 1f 44 00 00 0f b6 c1 8b ca d3 e8 83 e0 01 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c1}
0008h mov ecx,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b ca}
000ah shr eax,cl                              ; SHR r/m32, CL || o32 D3 /5 || encoded[2]{d3 e8}
000ch and eax,1                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e0 01}
000fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit testbit_8u(byte src, int pos)
; testbit_8u_8u[0x7ff7c8381a50, 0x7ff7c8381a60][16] = {0f 1f 44 00 00 0f b6 c1 8b ca d3 e8 83 e0 01 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c1}
0008h mov ecx,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b ca}
000ah shr eax,cl                              ; SHR r/m32, CL || o32 D3 /5 || encoded[2]{d3 e8}
000ch and eax,1                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e0 01}
000fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit testbit_16i(Int16 src, int pos)
; testbit_16i_16i[0x7ff7c8381a70, 0x7ff7c8381a83][19] = {0f 1f 44 00 00 48 0f bf c1 0f a3 d0 0f 92 c0 0f b6 c0 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movsx rax,cx                            ; MOVSX r64, r/m16 || REX.W 0F BF /r || encoded[4]{48 0f bf c1}
0009h bt eax,edx                              ; BT r/m32, r32 || o32 0F A3 /r || encoded[3]{0f a3 d0}
000ch setb al                                 ; SETB r/m8 || 0F 92 /r || encoded[3]{0f 92 c0}
000fh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0012h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit testbit_16u(ushort src, int pos)
; testbit_16u_16u[0x7ff7c8381aa0, 0x7ff7c8381ab0][16] = {0f 1f 44 00 00 0f b7 c1 8b ca d3 e8 83 e0 01 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c1}
0008h mov ecx,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b ca}
000ah shr eax,cl                              ; SHR r/m32, CL || o32 D3 /5 || encoded[2]{d3 e8}
000ch and eax,1                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e0 01}
000fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit testbit_32i(int src, int pos)
; testbit_32i_32i[0x7ff7c8381ac0, 0x7ff7c8381acf][15] = {0f 1f 44 00 00 0f a3 d1 0f 92 c0 0f b6 c0 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h bt ecx,edx                              ; BT r/m32, r32 || o32 0F A3 /r || encoded[3]{0f a3 d1}
0008h setb al                                 ; SETB r/m8 || 0F 92 /r || encoded[3]{0f 92 c0}
000bh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
000eh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit testbit_32u(uint src, int pos)
; testbit_32u_32u[0x7ff7c8381ae0, 0x7ff7c8381aef][15] = {0f 1f 44 00 00 8b c1 8b ca d3 e8 83 e0 01 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h mov ecx,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b ca}
0009h shr eax,cl                              ; SHR r/m32, CL || o32 D3 /5 || encoded[2]{d3 e8}
000bh and eax,1                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e0 01}
000eh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit testbit_64i(long src, int pos)
; testbit_64i_64i[0x7ff7c8381b00, 0x7ff7c8381b10][16] = {0f 1f 44 00 00 48 0f a3 d1 0f 92 c0 0f b6 c0 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h bt rcx,rdx                              ; BT r/m64, r64 || REX.W 0F A3 /r || encoded[4]{48 0f a3 d1}
0009h setb al                                 ; SETB r/m8 || 0F 92 /r || encoded[3]{0f 92 c0}
000ch movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
000fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit testbit_64u(ulong src, int pos)
; testbit_64u_64u[0x7ff7c8381b20, 0x7ff7c8381b31][17] = {0f 1f 44 00 00 48 8b c1 8b ca 48 d3 e8 83 e0 01 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0008h mov ecx,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b ca}
000ah shr rax,cl                              ; SHR r/m64, CL || REX.W D3 /5 || encoded[3]{48 d3 e8}
000dh and eax,1                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e0 01}
0010h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
