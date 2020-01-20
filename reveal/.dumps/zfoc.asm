; 2020-01-20 01:59:22:052
; byte hexcode_parse(Char c)
; static ReadOnlySpan<byte> hexcode_parse_19620867Bytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC9,0x48,0xB8,0xD0,0xBF,0x60,0xC8,0xF7,0x7F,0x00,0x00,0x48,0xFF,0xE0};
; [0x7ff7c860c360, 0x7ff7c860c375], 21 bytes
; 2020-01-20 01:59:22:052
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx ecx,cx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c9}
0008h mov rax,7FF7C860BFD0h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 d0 bf 60 c8 f7 7f 00 00}
0012h jmp rax                                 ; JMP r/m64 || FF /4 || encoded[3]{48 ff e0}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Pair<ulong> sub_128u_a(Pair<ulong> a, Pair<ulong> b)
; static ReadOnlySpan<byte> sub_128u_a_0xBytes => new byte[47]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x48,0x8B,0x52,0x08,0x4C,0x8B,0xC8,0x4D,0x2B,0x08,0x49,0x3B,0xC1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x49,0x2B,0x50,0x08,0x8B,0xC0,0x48,0x2B,0xD0,0x4C,0x89,0x09,0x48,0x89,0x51,0x08,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c860c790, 0x7ff7c860c7bf], 47 bytes
; 2020-01-20 01:59:22:052
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
0008h mov rdx,[rdx+8]                         ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 52 08}
000ch mov r9,rax                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b c8}
000fh sub r9,[r8]                             ; SUB r64, r/m64 || REX.W 2B /r || encoded[3]{4d 2b 08}
0012h cmp rax,r9                              ; CMP r64, r/m64 || REX.W 3B /r || encoded[3]{49 3b c1}
0015h setb al                                 ; SETB r/m8 || 0F 92 /r || encoded[3]{0f 92 c0}
0018h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
001bh sub rdx,[r8+8]                          ; SUB r64, r/m64 || REX.W 2B /r || encoded[4]{49 2b 50 08}
001fh mov eax,eax                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c0}
0021h sub rdx,rax                             ; SUB r64, r/m64 || REX.W 2B /r || encoded[3]{48 2b d0}
0024h mov [rcx],r9                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 09}
0027h mov [rcx+8],rdx                         ; MOV r/m64, r64 || REX.W 89 /r || encoded[4]{48 89 51 08}
002bh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
002eh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void sub_128u_b(in ulong a, in ulong b, ref ulong c)
; static ReadOnlySpan<byte> sub_128u_b_64uBytes => new byte[47]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x2B,0x02,0x49,0x89,0x00,0x48,0x8B,0x01,0x49,0x3B,0x00,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x49,0x83,0xC0,0x08,0x48,0x8B,0x49,0x08,0x48,0x2B,0x4A,0x08,0x8B,0xC0,0x48,0x2B,0xC8,0x49,0x89,0x08,0xC3};
; [0x7ff7c860c7d0, 0x7ff7c860c7ff], 47 bytes
; 2020-01-20 01:59:22:052
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 01}
0008h sub rax,[rdx]                           ; SUB r64, r/m64 || REX.W 2B /r || encoded[3]{48 2b 02}
000bh mov [r8],rax                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 00}
000eh mov rax,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 01}
0011h cmp rax,[r8]                            ; CMP r64, r/m64 || REX.W 3B /r || encoded[3]{49 3b 00}
0014h setb al                                 ; SETB r/m8 || 0F 92 /r || encoded[3]{0f 92 c0}
0017h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
001ah add r8,8                                ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{49 83 c0 08}
001eh mov rcx,[rcx+8]                         ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 49 08}
0022h sub rcx,[rdx+8]                         ; SUB r64, r/m64 || REX.W 2B /r || encoded[4]{48 2b 4a 08}
0026h mov eax,eax                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c0}
0028h sub rcx,rax                             ; SUB r64, r/m64 || REX.W 2B /r || encoded[3]{48 2b c8}
002bh mov [r8],rcx                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 08}
002eh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void mul_128u(Pair<ulong> src, ref Pair<ulong> dst)
; static ReadOnlySpan<byte> mul_128u_45786357Bytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x8B,0x49,0x08,0x48,0x89,0x54,0x24,0x10,0x4C,0x8B,0xC2,0x48,0x8B,0xD0,0xC4,0xE2,0xB3,0xF6,0xC1,0x4D,0x89,0x08,0x48,0x8B,0x54,0x24,0x10,0x48,0x89,0x42,0x08,0xC3};
; [0x7ff7c860c810, 0x7ff7c860c839], 41 bytes
; 2020-01-20 01:59:22:052
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 01}
0008h mov rcx,[rcx+8]                         ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 49 08}
000ch mov [rsp+10h],rdx                       ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 54 24 10}
0011h mov r8,rdx                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b c2}
0014h mov rdx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d0}
0017h mulx rax,r9,rcx                         ; MULX r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F6 /r || encoded[5]{c4 e2 b3 f6 c1}
001ch mov [r8],r9                             ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4d 89 08}
001fh mov rdx,[rsp+10h]                       ; MOV r64, r/m64 || REX.W 8B /r || encoded[5]{48 8b 54 24 10}
0024h mov [rdx+8],rax                         ; MOV r/m64, r64 || REX.W 89 /r || encoded[4]{48 89 42 08}
0028h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Pair<ulong> add_128u(Pair<ulong> a, Pair<ulong> b)
; static ReadOnlySpan<byte> add_128u_0xBytes => new byte[47]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x48,0x8B,0x52,0x08,0x4C,0x8B,0xC8,0x4D,0x03,0x08,0x49,0x3B,0xC1,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0x49,0x03,0x50,0x08,0x8B,0xC0,0x48,0x03,0xC2,0x4C,0x89,0x09,0x48,0x89,0x41,0x08,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c860c850, 0x7ff7c860c87f], 47 bytes
; 2020-01-20 01:59:22:052
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
0008h mov rdx,[rdx+8]                         ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 52 08}
000ch mov r9,rax                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b c8}
000fh add r9,[r8]                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{4d 03 08}
0012h cmp rax,r9                              ; CMP r64, r/m64 || REX.W 3B /r || encoded[3]{49 3b c1}
0015h seta al                                 ; SETA r/m8 || 0F 97 /r || encoded[3]{0f 97 c0}
0018h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
001bh add rdx,[r8+8]                          ; ADD r64, r/m64 || REX.W 03 /r || encoded[4]{49 03 50 08}
001fh mov eax,eax                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c0}
0021h add rax,rdx                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{48 03 c2}
0024h mov [rcx],r9                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 09}
0027h mov [rcx+8],rax                         ; MOV r/m64, r64 || REX.W 89 /r || encoded[4]{48 89 41 08}
002bh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
002eh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Pair<ulong> xor_128u(Pair<ulong> a, Pair<ulong> b)
; static ReadOnlySpan<byte> xor_128u_0xBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x49,0x33,0x00,0x48,0x8B,0x52,0x08,0x49,0x33,0x50,0x08,0x48,0x89,0x01,0x48,0x89,0x51,0x08,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c860c890, 0x7ff7c860c8ae], 30 bytes
; 2020-01-20 01:59:22:052
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
0008h xor rax,[r8]                            ; XOR r64, r/m64 || REX.W 33 /r || encoded[3]{49 33 00}
000bh mov rdx,[rdx+8]                         ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 52 08}
000fh xor rdx,[r8+8]                          ; XOR r64, r/m64 || REX.W 33 /r || encoded[4]{49 33 50 08}
0013h mov [rcx],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 01}
0016h mov [rcx+8],rdx                         ; MOV r/m64, r64 || REX.W 89 /r || encoded[4]{48 89 51 08}
001ah mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
001dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Pair<ulong> xnor_128u(Pair<ulong> a, Pair<ulong> b)
; static ReadOnlySpan<byte> xnor_128u_0xBytes => new byte[36]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x49,0x33,0x00,0x48,0x8B,0x52,0x08,0x49,0x33,0x50,0x08,0x48,0xF7,0xD0,0x48,0xF7,0xD2,0x48,0x89,0x01,0x48,0x89,0x51,0x08,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c860c8c0, 0x7ff7c860c8e4], 36 bytes
; 2020-01-20 01:59:22:052
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
0008h xor rax,[r8]                            ; XOR r64, r/m64 || REX.W 33 /r || encoded[3]{49 33 00}
000bh mov rdx,[rdx+8]                         ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 52 08}
000fh xor rdx,[r8+8]                          ; XOR r64, r/m64 || REX.W 33 /r || encoded[4]{49 33 50 08}
0013h not rax                                 ; NOT r/m64 || REX.W F7 /2 || encoded[3]{48 f7 d0}
0016h not rdx                                 ; NOT r/m64 || REX.W F7 /2 || encoded[3]{48 f7 d2}
0019h mov [rcx],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 01}
001ch mov [rcx+8],rdx                         ; MOV r/m64, r64 || REX.W 89 /r || encoded[4]{48 89 51 08}
0020h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0023h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Pair<ulong> negate_128u(Pair<ulong> a)
; static ReadOnlySpan<byte> negate_128u_0xBytes => new byte[45]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x48,0x8B,0x52,0x08,0x48,0xF7,0xD0,0x48,0xF7,0xD2,0x4C,0x8D,0x40,0x01,0x49,0x3B,0xC0,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0x48,0x03,0xC2,0x4C,0x89,0x01,0x48,0x89,0x41,0x08,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c860c900, 0x7ff7c860c92d], 45 bytes
; 2020-01-20 01:59:22:052
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
0008h mov rdx,[rdx+8]                         ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 52 08}
000ch not rax                                 ; NOT r/m64 || REX.W F7 /2 || encoded[3]{48 f7 d0}
000fh not rdx                                 ; NOT r/m64 || REX.W F7 /2 || encoded[3]{48 f7 d2}
0012h lea r8,[rax+1]                          ; LEA r64, m || REX.W 8D /r || encoded[4]{4c 8d 40 01}
0016h cmp rax,r8                              ; CMP r64, r/m64 || REX.W 3B /r || encoded[3]{49 3b c0}
0019h seta al                                 ; SETA r/m8 || 0F 97 /r || encoded[3]{0f 97 c0}
001ch movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
001fh add rax,rdx                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{48 03 c2}
0022h mov [rcx],r8                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 01}
0025h mov [rcx+8],rax                         ; MOV r/m64, r64 || REX.W 89 /r || encoded[4]{48 89 41 08}
0029h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
002ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ref Pair<ulong> inc_128u(ref Pair<ulong> a)
; static ReadOnlySpan<byte> inc_128u_0xBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x8D,0x50,0x01,0x48,0x3B,0xC2,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0x4C,0x8B,0x41,0x08,0x8B,0xC0,0x49,0x03,0xC0,0x48,0x89,0x11,0x48,0x89,0x41,0x08,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c860c940, 0x7ff7c860c969], 41 bytes
; 2020-01-20 01:59:22:052
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 01}
0008h lea rdx,[rax+1]                         ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 50 01}
000ch cmp rax,rdx                             ; CMP r64, r/m64 || REX.W 3B /r || encoded[3]{48 3b c2}
000fh seta al                                 ; SETA r/m8 || 0F 97 /r || encoded[3]{0f 97 c0}
0012h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0015h mov r8,[rcx+8]                          ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{4c 8b 41 08}
0019h mov eax,eax                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c0}
001bh add rax,r8                              ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{49 03 c0}
001eh mov [rcx],rdx                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 11}
0021h mov [rcx+8],rax                         ; MOV r/m64, r64 || REX.W 89 /r || encoded[4]{48 89 41 08}
0025h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0028h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Pair<ulong> srl_128u(Pair<ulong> a, int offset)
; static ReadOnlySpan<byte> srl_128u_9424035Bytes => new byte[106]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x8B,0x0A,0x48,0x8B,0x52,0x08,0x41,0x83,0xF8,0x40,0x7C,0x20,0x41,0x81,0xF8,0x80,0x00,0x00,0x00,0x7C,0x08,0x45,0x33,0xD2,0x45,0x33,0xDB,0xEB,0x3C,0x41,0x8D,0x48,0xC0,0x49,0xD3,0xE9,0x4D,0x8B,0xD9,0x45,0x33,0xD2,0xEB,0x2D,0x45,0x8B,0xD0,0x41,0x83,0xE2,0x3F,0x41,0x8B,0xCA,0x4C,0x8B,0xDA,0x49,0xD3,0xEB,0x41,0x8B,0xCA,0x49,0xD3,0xE9,0x41,0x8B,0xC8,0xF7,0xD9,0x83,0xC1,0x3F,0x48,0xD1,0xE2,0x48,0xD3,0xE2,0x49,0x0B,0xD1,0x4D,0x8B,0xD3,0x4C,0x8B,0xDA,0x4C,0x89,0x10,0x4C,0x89,0x58,0x08,0xC3};
; [0x7ff7c860c980, 0x7ff7c860c9ea], 106 bytes
; 2020-01-20 01:59:22:053
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0008h mov r9,[rdx]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b 0a}
000bh mov rdx,[rdx+8]                         ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 52 08}
000fh cmp r8d,40h                             ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[4]{41 83 f8 40}
0013h jl short 0035h                          ; JL rel8 || 7C cb || encoded[2]{7c 20}
0015h cmp r8d,80h                             ; CMP r/m32, imm32 || o32 81 /7 id || encoded[7]{41 81 f8 80 00 00 00}
001ch jl short 0026h                          ; JL rel8 || 7C cb || encoded[2]{7c 08}
001eh xor r10d,r10d                           ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 d2}
0021h xor r11d,r11d                           ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 db}
0024h jmp short 0062h                         ; JMP rel8 || EB cb || encoded[2]{eb 3c}
0026h lea ecx,[r8-40h]                        ; LEA r32, m || o32 8D /r || encoded[4]{41 8d 48 c0}
002ah shr r9,cl                               ; SHR r/m64, CL || REX.W D3 /5 || encoded[3]{49 d3 e9}
002dh mov r11,r9                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b d9}
0030h xor r10d,r10d                           ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 d2}
0033h jmp short 0062h                         ; JMP rel8 || EB cb || encoded[2]{eb 2d}
0035h mov r10d,r8d                            ; MOV r32, r/m32 || o32 8B /r || encoded[3]{45 8b d0}
0038h and r10d,3Fh                            ; AND r/m32, imm8 || o32 83 /4 ib || encoded[4]{41 83 e2 3f}
003ch mov ecx,r10d                            ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b ca}
003fh mov r11,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b da}
0042h shr r11,cl                              ; SHR r/m64, CL || REX.W D3 /5 || encoded[3]{49 d3 eb}
0045h mov ecx,r10d                            ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b ca}
0048h shr r9,cl                               ; SHR r/m64, CL || REX.W D3 /5 || encoded[3]{49 d3 e9}
004bh mov ecx,r8d                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b c8}
004eh neg ecx                                 ; NEG r/m32 || o32 F7 /3 || encoded[2]{f7 d9}
0050h add ecx,3Fh                             ; ADD r/m32, imm8 || o32 83 /0 ib || encoded[3]{83 c1 3f}
0053h shl rdx,1                               ; SHL r/m64, 1 || REX.W D1 /4 || encoded[3]{48 d1 e2}
0056h shl rdx,cl                              ; SHL r/m64, CL || REX.W D3 /4 || encoded[3]{48 d3 e2}
0059h or rdx,r9                               ; OR r64, r/m64 || REX.W 0B /r || encoded[3]{49 0b d1}
005ch mov r10,r11                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b d3}
005fh mov r11,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b da}
0062h mov [rax],r10                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 10}
0065h mov [rax+8],r11                         ; MOV r/m64, r64 || REX.W 89 /r || encoded[4]{4c 89 58 08}
0069h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Pair<ulong> sll_128u(Pair<ulong> a, int offset)
; static ReadOnlySpan<byte> sll_128u_17707452Bytes => new byte[106]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x8B,0x0A,0x48,0x8B,0x52,0x08,0x41,0x83,0xF8,0x40,0x7C,0x20,0x41,0x81,0xF8,0x80,0x00,0x00,0x00,0x7C,0x08,0x45,0x33,0xD2,0x45,0x33,0xDB,0xEB,0x3C,0x41,0x8D,0x48,0xC0,0x49,0xD3,0xE1,0x4D,0x8B,0xD1,0x45,0x33,0xDB,0xEB,0x2D,0x45,0x8B,0xD0,0x41,0x83,0xE2,0x3F,0x41,0x8B,0xCA,0x48,0xD3,0xE2,0x41,0x8B,0xC8,0xF7,0xD9,0x83,0xC1,0x3F,0x4D,0x8B,0xD9,0x49,0xD1,0xEB,0x49,0xD3,0xEB,0x49,0x0B,0xD3,0x41,0x8B,0xCA,0x4D,0x8B,0xD9,0x49,0xD3,0xE3,0x4C,0x8B,0xD2,0x4C,0x89,0x10,0x4C,0x89,0x58,0x08,0xC3};
; [0x7ff7c860ca00, 0x7ff7c860ca6a], 106 bytes
; 2020-01-20 01:59:22:053
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0008h mov r9,[rdx]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b 0a}
000bh mov rdx,[rdx+8]                         ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 52 08}
000fh cmp r8d,40h                             ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[4]{41 83 f8 40}
0013h jl short 0035h                          ; JL rel8 || 7C cb || encoded[2]{7c 20}
0015h cmp r8d,80h                             ; CMP r/m32, imm32 || o32 81 /7 id || encoded[7]{41 81 f8 80 00 00 00}
001ch jl short 0026h                          ; JL rel8 || 7C cb || encoded[2]{7c 08}
001eh xor r10d,r10d                           ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 d2}
0021h xor r11d,r11d                           ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 db}
0024h jmp short 0062h                         ; JMP rel8 || EB cb || encoded[2]{eb 3c}
0026h lea ecx,[r8-40h]                        ; LEA r32, m || o32 8D /r || encoded[4]{41 8d 48 c0}
002ah shl r9,cl                               ; SHL r/m64, CL || REX.W D3 /4 || encoded[3]{49 d3 e1}
002dh mov r10,r9                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b d1}
0030h xor r11d,r11d                           ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 db}
0033h jmp short 0062h                         ; JMP rel8 || EB cb || encoded[2]{eb 2d}
0035h mov r10d,r8d                            ; MOV r32, r/m32 || o32 8B /r || encoded[3]{45 8b d0}
0038h and r10d,3Fh                            ; AND r/m32, imm8 || o32 83 /4 ib || encoded[4]{41 83 e2 3f}
003ch mov ecx,r10d                            ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b ca}
003fh shl rdx,cl                              ; SHL r/m64, CL || REX.W D3 /4 || encoded[3]{48 d3 e2}
0042h mov ecx,r8d                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b c8}
0045h neg ecx                                 ; NEG r/m32 || o32 F7 /3 || encoded[2]{f7 d9}
0047h add ecx,3Fh                             ; ADD r/m32, imm8 || o32 83 /0 ib || encoded[3]{83 c1 3f}
004ah mov r11,r9                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b d9}
004dh shr r11,1                               ; SHR r/m64, 1 || REX.W D1 /5 || encoded[3]{49 d1 eb}
0050h shr r11,cl                              ; SHR r/m64, CL || REX.W D3 /5 || encoded[3]{49 d3 eb}
0053h or rdx,r11                              ; OR r64, r/m64 || REX.W 0B /r || encoded[3]{49 0b d3}
0056h mov ecx,r10d                            ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b ca}
0059h mov r11,r9                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b d9}
005ch shl r11,cl                              ; SHL r/m64, CL || REX.W D3 /4 || encoded[3]{49 d3 e3}
005fh mov r10,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b d2}
0062h mov [rax],r10                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 10}
0065h mov [rax+8],r11                         ; MOV r/m64, r64 || REX.W 89 /r || encoded[4]{4c 89 58 08}
0069h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit same_128u(Pair<ulong> a, Pair<ulong> b)
; static ReadOnlySpan<byte> same_128u_0xBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x3B,0x02,0x75,0x10,0x48,0x8B,0x41,0x08,0x48,0x3B,0x42,0x08,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
; [0x7ff7c860ca80, 0x7ff7c860caa3], 35 bytes
; 2020-01-20 01:59:22:053
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 01}
0008h cmp rax,[rdx]                           ; CMP r64, r/m64 || REX.W 3B /r || encoded[3]{48 3b 02}
000bh jne short 001dh                         ; JNE rel8 || 75 cb || encoded[2]{75 10}
000dh mov rax,[rcx+8]                         ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 41 08}
0011h cmp rax,[rdx+8]                         ; CMP r64, r/m64 || REX.W 3B /r || encoded[4]{48 3b 42 08}
0015h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0018h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
001bh jmp short 001fh                         ; JMP rel8 || EB cb || encoded[2]{eb 02}
001dh xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
001fh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0022h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit lt_128u(Pair<ulong> a, Pair<ulong> b)
; static ReadOnlySpan<byte> lt_128u_0xBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x48,0x8B,0x52,0x08,0x4C,0x8B,0x01,0x48,0x8B,0x49,0x08,0x48,0x3B,0xCA,0x41,0x0F,0x92,0xC1,0x45,0x0F,0xB6,0xC9,0x48,0x3B,0xCA,0x75,0x0B,0x4C,0x3B,0xC0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x41,0x0B,0xC1,0x0F,0xB6,0xC0,0xC3};
; [0x7ff7c860cac0, 0x7ff7c860caf7], 55 bytes
; 2020-01-20 01:59:22:053
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
0008h mov rdx,[rdx+8]                         ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 52 08}
000ch mov r8,[rcx]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b 01}
000fh mov rcx,[rcx+8]                         ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 49 08}
0013h cmp rcx,rdx                             ; CMP r64, r/m64 || REX.W 3B /r || encoded[3]{48 3b ca}
0016h setb r9b                                ; SETB r/m8 || 0F 92 /r || encoded[4]{41 0f 92 c1}
001ah movzx r9d,r9b                           ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{45 0f b6 c9}
001eh cmp rcx,rdx                             ; CMP r64, r/m64 || REX.W 3B /r || encoded[3]{48 3b ca}
0021h jne short 002eh                         ; JNE rel8 || 75 cb || encoded[2]{75 0b}
0023h cmp r8,rax                              ; CMP r64, r/m64 || REX.W 3B /r || encoded[3]{4c 3b c0}
0026h setb al                                 ; SETB r/m8 || 0F 92 /r || encoded[3]{0f 92 c0}
0029h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
002ch jmp short 0030h                         ; JMP rel8 || EB cb || encoded[2]{eb 02}
002eh xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0030h or eax,r9d                              ; OR r32, r/m32 || o32 0B /r || encoded[3]{41 0b c1}
0033h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0036h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit gteq_128u(Pair<ulong> a, Pair<ulong> b)
; static ReadOnlySpan<byte> gteq_128u_0xBytes => new byte[60]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x48,0x8B,0x52,0x08,0x4C,0x8B,0x01,0x48,0x8B,0x49,0x08,0x48,0x3B,0xCA,0x41,0x0F,0x92,0xC1,0x45,0x0F,0xB6,0xC9,0x48,0x3B,0xCA,0x75,0x0B,0x4C,0x3B,0xC0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x41,0x0B,0xC1,0x0F,0xB6,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
; [0x7ff7c860cb10, 0x7ff7c860cb4c], 60 bytes
; 2020-01-20 01:59:22:053
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
0008h mov rdx,[rdx+8]                         ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 52 08}
000ch mov r8,[rcx]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b 01}
000fh mov rcx,[rcx+8]                         ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 49 08}
0013h cmp rcx,rdx                             ; CMP r64, r/m64 || REX.W 3B /r || encoded[3]{48 3b ca}
0016h setb r9b                                ; SETB r/m8 || 0F 92 /r || encoded[4]{41 0f 92 c1}
001ah movzx r9d,r9b                           ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{45 0f b6 c9}
001eh cmp rcx,rdx                             ; CMP r64, r/m64 || REX.W 3B /r || encoded[3]{48 3b ca}
0021h jne short 002eh                         ; JNE rel8 || 75 cb || encoded[2]{75 0b}
0023h cmp r8,rax                              ; CMP r64, r/m64 || REX.W 3B /r || encoded[3]{4c 3b c0}
0026h setb al                                 ; SETB r/m8 || 0F 92 /r || encoded[3]{0f 92 c0}
0029h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
002ch jmp short 0030h                         ; JMP rel8 || EB cb || encoded[2]{eb 02}
002eh xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0030h or eax,r9d                              ; OR r32, r/m32 || o32 0B /r || encoded[3]{41 0b c1}
0033h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0036h not eax                                 ; NOT r/m32 || o32 F7 /2 || encoded[2]{f7 d0}
0038h and eax,1                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e0 01}
003bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void mul_32u(Pair<uint> src, ref Pair<uint> dst)
; static ReadOnlySpan<byte> mul_32u_23831236Bytes => new byte[45]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x89,0x4C,0x24,0x08,0x8B,0x44,0x24,0x08,0x8B,0x4C,0x24,0x0C,0x48,0x89,0x54,0x24,0x10,0x4C,0x8B,0xC2,0x8B,0xD0,0xC4,0xE2,0x33,0xF6,0xC1,0x45,0x89,0x08,0x48,0x8B,0x54,0x24,0x10,0x89,0x42,0x04,0xC3};
; [0x7ff7c860cb60, 0x7ff7c860cb8d], 45 bytes
; 2020-01-20 01:59:22:053
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov [rsp+8],rcx                         ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 4c 24 08}
000ah mov eax,[rsp+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[4]{8b 44 24 08}
000eh mov ecx,[rsp+0Ch]                       ; MOV r32, r/m32 || o32 8B /r || encoded[4]{8b 4c 24 0c}
0012h mov [rsp+10h],rdx                       ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 54 24 10}
0017h mov r8,rdx                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b c2}
001ah mov edx,eax                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b d0}
001ch mulx eax,r9d,ecx                        ; MULX r32a, r32b, r/m32 || VEX.LZ.F2.0F38.W0 F6 /r || encoded[5]{c4 e2 33 f6 c1}
0021h mov [r8],r9d                            ; MOV r/m32, r32 || o32 89 /r || encoded[3]{45 89 08}
0024h mov rdx,[rsp+10h]                       ; MOV r64, r/m64 || REX.W 8B /r || encoded[5]{48 8b 54 24 10}
0029h mov [rdx+4],eax                         ; MOV r/m32, r32 || o32 89 /r || encoded[3]{89 42 04}
002ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; uint mod_const_16(uint a)
; static ReadOnlySpan<byte> mod_const_16_32uBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xD1,0x48,0xC1,0xE2,0x3C,0xB8,0x10,0x00,0x00,0x00,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
; [0x7ff7c860cba0, 0x7ff7c860cbb6], 22 bytes
; 2020-01-20 01:59:22:056
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov edx,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b d1}
0007h shl rdx,3Ch                             ; SHL r/m64, imm8 || REX.W C1 /4 ib || encoded[4]{48 c1 e2 3c}
000bh mov eax,10h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 10 00 00 00}
0010h mulx rax,rax,rax                        ; MULX r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F6 /r || encoded[5]{c4 e2 fb f6 c0}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; uint div_const_16(uint a)
; static ReadOnlySpan<byte> div_const_16_32uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x48,0xBA,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x10,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
; [0x7ff7c860cbd0, 0x7ff7c860cbe7], 23 bytes
; 2020-01-20 01:59:22:056
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h mov rdx,1000000000000000h               ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 ba 00 00 00 00 00 00 00 10}
0011h mulx rax,rax,rax                        ; MULX r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F6 /r || encoded[5]{c4 e2 fb f6 c0}
0016h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; uint mod_const_25(uint a)
; static ReadOnlySpan<byte> mod_const_25_32uBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xD1,0x48,0xB8,0x71,0x3D,0x0A,0xD7,0xA3,0x70,0x3D,0x0A,0x48,0x0F,0xAF,0xD0,0xB8,0x19,0x00,0x00,0x00,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
; [0x7ff7c860cc00, 0x7ff7c860cc20], 32 bytes
; 2020-01-20 01:59:22:056
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov edx,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b d1}
0007h mov rax,0A3D70A3D70A3D71h               ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 71 3d 0a d7 a3 70 3d 0a}
0011h imul rdx,rax                            ; IMUL r64, r/m64 || REX.W 0F AF /r || encoded[4]{48 0f af d0}
0015h mov eax,19h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 19 00 00 00}
001ah mulx rax,rax,rax                        ; MULX r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F6 /r || encoded[5]{c4 e2 fb f6 c0}
001fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; uint div_const_25(uint a)
; static ReadOnlySpan<byte> div_const_25_32uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x48,0xBA,0x71,0x3D,0x0A,0xD7,0xA3,0x70,0x3D,0x0A,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
; [0x7ff7c860cc30, 0x7ff7c860cc47], 23 bytes
; 2020-01-20 01:59:22:056
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h mov rdx,0A3D70A3D70A3D71h               ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 ba 71 3d 0a d7 a3 70 3d 0a}
0011h mulx rax,rax,rax                        ; MULX r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F6 /r || encoded[5]{c4 e2 fb f6 c0}
0016h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; uint mod_const_32(uint a)
; static ReadOnlySpan<byte> mod_const_32_32uBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xD1,0x48,0xC1,0xE2,0x3B,0xB8,0x20,0x00,0x00,0x00,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
; [0x7ff7c860cc60, 0x7ff7c860cc76], 22 bytes
; 2020-01-20 01:59:22:056
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov edx,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b d1}
0007h shl rdx,3Bh                             ; SHL r/m64, imm8 || REX.W C1 /4 ib || encoded[4]{48 c1 e2 3b}
000bh mov eax,20h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 20 00 00 00}
0010h mulx rax,rax,rax                        ; MULX r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F6 /r || encoded[5]{c4 e2 fb f6 c0}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; uint div_const_32(uint a)
; static ReadOnlySpan<byte> div_const_32_32uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x48,0xBA,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x08,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
; [0x7ff7c860cc90, 0x7ff7c860cca7], 23 bytes
; 2020-01-20 01:59:22:056
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h mov rdx,800000000000000h                ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 ba 00 00 00 00 00 00 00 08}
0011h mulx rax,rax,rax                        ; MULX r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F6 /r || encoded[5]{c4 e2 fb f6 c0}
0016h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
