# JMP rel8
------------------------------------------------------------------------------------------------------------------------
; JccTest:byte jcc2(byte x, byte y), located://canonical/asm.expr?jcc2#jcc2_(8u,8u)
; public static ReadOnlySpan<byte> jcc2_ᐤ8uㆍ8uᐤ => new byte[45]{0x0f,0x1f,0x44,0x00,0x00,0x33,0xc0,0x0f,0xb6,0xc9,0x0f,0xb6,0xd2,0x3b,0xca,0x7c,0x07,0xb8,0x0d,0x00,0x00,0x00,0xeb,0x14,0x3b,0xca,0x7f,0x07,0xb8,0x0e,0x00,0x00,0x00,0xeb,0x09,0x3b,0xca,0x74,0x05,0xb8,0x05,0x00,0x00,0x00,0xc3};
; Base = 7ff9aeba6180h
; TermCode = CTC_RET_Zx3
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0007h movzx ecx,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c9}
000ah movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
000dh cmp ecx,edx                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b ca}
000fh jl short 0018h                          ; JL rel8 || 7C cb || encoded[2]{7c 07}
0011h mov eax,0dh                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 0d 00 00 00}
0016h jmp short 002ch                         ; JMP rel8 || EB cb || encoded[2]{eb 14}
0018h cmp ecx,edx                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b ca}
001ah jg short 0023h                          ; JG rel8 || 7F cb || encoded[2]{7f 07}
001ch mov eax,0eh                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 0e 00 00 00}
0021h jmp short 002ch                         ; JMP rel8 || EB cb || encoded[2]{eb 09}
0023h cmp ecx,edx                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b ca}
0025h je short 002ch                          ; JE rel8 || 74 cb || encoded[2]{74 05}
0027h mov eax,5                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 05 00 00 00}
002ch ret                                     ; RET || C3 || encoded[1]{c3}

# JMP rel32
------------------------------------------------------------------------------------------------------------------------
; ref byte cell_d(MemStoreIndex n, int i), located://seed/resmodelquery?cell_d#cell_d_(MemStoreIndex,32i)
; public static ReadOnlySpan<byte> cell_d_ᐤMemStoreIndexㆍ32iᐤ => new byte[213]{0x0f,0x1f,0x44,0x00,0x00,0x39,0x09,0x0f,0xb6,0xc2,0x85,0xc0,0x75,0x15,0x49,0x63,0xc0,0x49,0xb8,0x71,0xea,0xf2,0xe8,0x93,0x01,0x00,0x00,0x49,0x03,0xc0,0xe9,0xb1,0x00,0x00,0x00,0x83,0xf8,0x01,0x75,0x15,0x49,0x63,0xc0,0x49,0xb8,0xc1,0xe9,0xf2,0xe8,0x93,0x01,0x00,0x00,0x49,0x03,0xc0,0xe9,0x97,0x00,0x00,0x00,0x83,0xf8,0x02,0x75,0x15,0x49,0x63,0xc0,0x49,0xb8,0x29,0xea,0xf2,0xe8,0x93,0x01,0x00,0x00,0x49,0x03,0xc0,0xe9,0x7d,0x00,0x00,0x00,0x83,0xf8,0x03,0x75,0x12,0x49,0x63,0xc0,0x49,0xb8,0x71,0xe9,0xf2,0xe8,0x93,0x01,0x00,0x00,0x49,0x03,0xc0,0xeb,0x66,0x83,0xf8,0x04,0x75,0x12,0x49,0x63,0xc0,0x49,0xb8,0x69,0xe8,0xf2,0xe8,0x93,0x01,0x00,0x00,0x49,0x03,0xc0,0xeb,0x4f,0x83,0xf8,0x05,0x75,0x12,0x49,0x63,0xc0,0x49,0xb8,0xe9,0xe8,0xf2,0xe8,0x93,0x01,0x00,0x00,0x49,0x03,0xc0,0xeb,0x38,0x83,0xf8,0x06,0x75,0x12,0x49,0x63,0xc0,0x49,0xb8,0x51,0xe7,0xf2,0xe8,0x93,0x01,0x00,0x00,0x49,0x03,0xc0,0xeb,0x21,0x83,0xf8,0x07,0x75,0x12,0x49,0x63,0xc0,0x48,0xba,0x51,0xe7,0xf2,0xe8,0x93,0x01,0x00,0x00,0x48,0x03,0xc2,0xeb,0x0a,0x48,0xb8,0xb1,0xe9,0xf2,0xe8,0x93,0x01,0x00,0x00,0xc3};
; Base = 7ff9af94b430h
; TermCode = CTC_RET_Zx3
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h cmp [rcx],ecx                           ; CMP r/m32, r32 || o32 39 /r || encoded[2]{39 09}
0007h movzx eax,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c2}
000ah test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
000ch jne short 0023h                         ; JNE rel8 || 75 cb || encoded[2]{75 15}
000eh movsxd rax,r8d                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{49 63 c0}
0011h mov r8,193e8f2ea71h                     ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 b8 71 ea f2 e8 93 01 00 00}
001bh add rax,r8                              ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{49 03 c0}
001eh jmp near ptr 00d4h                      ; JMP rel32 || E9 cd || encoded[5]{e9 b1 00 00 00}
0023h cmp eax,1                               ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 f8 01}
0026h jne short 003dh                         ; JNE rel8 || 75 cb || encoded[2]{75 15}
0028h movsxd rax,r8d                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{49 63 c0}
002bh mov r8,193e8f2e9c1h                     ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 b8 c1 e9 f2 e8 93 01 00 00}
0035h add rax,r8                              ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{49 03 c0}
0038h jmp near ptr 00d4h                      ; JMP rel32 || E9 cd || encoded[5]{e9 97 00 00 00}
003dh cmp eax,2                               ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 f8 02}
0040h jne short 0057h                         ; JNE rel8 || 75 cb || encoded[2]{75 15}
0042h movsxd rax,r8d                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{49 63 c0}
0045h mov r8,193e8f2ea29h                     ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 b8 29 ea f2 e8 93 01 00 00}
004fh add rax,r8                              ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{49 03 c0}
0052h jmp near ptr 00d4h                      ; JMP rel32 || E9 cd || encoded[5]{e9 7d 00 00 00}
0057h cmp eax,3                               ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 f8 03}
005ah jne short 006eh                         ; JNE rel8 || 75 cb || encoded[2]{75 12}
005ch movsxd rax,r8d                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{49 63 c0}
005fh mov r8,193e8f2e971h                     ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 b8 71 e9 f2 e8 93 01 00 00}
0069h add rax,r8                              ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{49 03 c0}
006ch jmp short 00d4h                         ; JMP rel8 || EB cb || encoded[2]{eb 66}
006eh cmp eax,4                               ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 f8 04}
0071h jne short 0085h                         ; JNE rel8 || 75 cb || encoded[2]{75 12}
0073h movsxd rax,r8d                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{49 63 c0}
0076h mov r8,193e8f2e869h                     ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 b8 69 e8 f2 e8 93 01 00 00}
0080h add rax,r8                              ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{49 03 c0}
0083h jmp short 00d4h                         ; JMP rel8 || EB cb || encoded[2]{eb 4f}
0085h cmp eax,5                               ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 f8 05}
0088h jne short 009ch                         ; JNE rel8 || 75 cb || encoded[2]{75 12}
008ah movsxd rax,r8d                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{49 63 c0}
008dh mov r8,193e8f2e8e9h                     ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 b8 e9 e8 f2 e8 93 01 00 00}
0097h add rax,r8                              ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{49 03 c0}
009ah jmp short 00d4h                         ; JMP rel8 || EB cb || encoded[2]{eb 38}
009ch cmp eax,6                               ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 f8 06}
009fh jne short 00b3h                         ; JNE rel8 || 75 cb || encoded[2]{75 12}
00a1h movsxd rax,r8d                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{49 63 c0}
00a4h mov r8,193e8f2e751h                     ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 b8 51 e7 f2 e8 93 01 00 00}
00aeh add rax,r8                              ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{49 03 c0}
00b1h jmp short 00d4h                         ; JMP rel8 || EB cb || encoded[2]{eb 21}
00b3h cmp eax,7                               ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 f8 07}
00b6h jne short 00cah                         ; JNE rel8 || 75 cb || encoded[2]{75 12}
00b8h movsxd rax,r8d                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{49 63 c0}
00bbh mov rdx,193e8f2e751h                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 ba 51 e7 f2 e8 93 01 00 00}
00c5h add rax,rdx                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{48 03 c2}
00c8h jmp short 00d4h                         ; JMP rel8 || EB cb || encoded[2]{eb 0a}
00cah mov rax,193e8f2e9b1h                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 b1 e9 f2 e8 93 01 00 00}
00d4h ret                                     ; RET || C3 || encoded[1]{c3}

# JMP r/m64
------------------------------------------------------------------------------------------------------------------------
; void broadcast<short>(short data, in Block16<short> dst), located://blocks/api?broadcast#broadcast_g[16i](16i,b16x16i~in)
; public static ReadOnlySpan<byte> broadcast_gᐸ16iᐳᐤ16iㆍb16x16iᕀinᐤ => new byte[25]{0x48,0x8b,0xc2,0x66,0x90,0x48,0x0f,0xbf,0xd1,0x48,0x8b,0xc8,0x48,0xb8,0x50,0x50,0x3d,0xae,0xf9,0x7f,0x00,0x00,0x48,0xff,0xe0};
; Base = 7ff9aeba2b70h
; TermCode = CTC_JMP_RAX
0000h mov rax,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c2}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h movsx rdx,cx                            ; MOVSX r64, r/m16 || REX.W 0F BF /r || encoded[4]{48 0f bf d1}
0009h mov rcx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c8}
000ch mov rax,7ff9ae3d5050h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 50 50 3d ae f9 7f 00 00}
0016h jmp rax                                 ; JMP r/m64 || FF /4 || encoded[3]{48 ff e0}
