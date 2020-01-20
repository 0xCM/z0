; 2020-01-20 01:59:21:084
; int work_ring_buffer()
; static ReadOnlySpan<byte> work_ring_buffer_66694991Bytes => new byte[294]{0x48,0x83,0xEC,0x48,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x38,0x48,0x89,0x44,0x24,0x40,0x48,0x8D,0x4C,0x24,0x28,0xBA,0x40,0x00,0x00,0x00,0xE8,0x47,0xFE,0xFF,0xFF,0x8B,0x44,0x24,0x3C,0x8B,0x54,0x24,0x38,0xFF,0xCA,0x3B,0xC2,0x7E,0x06,0x33,0xC0,0x89,0x44,0x24,0x3C,0x8B,0x44,0x24,0x44,0x3B,0x44,0x24,0x38,0x74,0x0A,0x8B,0x44,0x24,0x44,0xFF,0xC0,0x89,0x44,0x24,0x44,0x48,0x8D,0x44,0x24,0x28,0x48,0x8B,0x00,0x8B,0x54,0x24,0x3C,0x8D,0x4A,0x01,0x89,0x4C,0x24,0x3C,0x48,0x63,0xD2,0xC6,0x04,0x10,0x03,0x8B,0x44,0x24,0x3C,0x8B,0x54,0x24,0x38,0xFF,0xCA,0x3B,0xC2,0x7E,0x06,0x33,0xC0,0x89,0x44,0x24,0x3C,0x8B,0x44,0x24,0x44,0x3B,0x44,0x24,0x38,0x74,0x0A,0x8B,0x44,0x24,0x44,0xFF,0xC0,0x89,0x44,0x24,0x44,0x48,0x8D,0x44,0x24,0x28,0x48,0x8B,0x00,0x8B,0x54,0x24,0x3C,0x8D,0x4A,0x01,0x89,0x4C,0x24,0x3C,0x48,0x63,0xD2,0xC6,0x04,0x10,0x04,0x8B,0x44,0x24,0x40,0x8B,0x54,0x24,0x38,0xFF,0xCA,0x3B,0xC2,0x7E,0x06,0x33,0xC0,0x89,0x44,0x24,0x40,0x8B,0x44,0x24,0x44,0xFF,0xC8,0x89,0x44,0x24,0x44,0x48,0x8D,0x44,0x24,0x28,0x48,0x8B,0x00,0x8B,0x54,0x24,0x40,0x8D,0x4A,0x01,0x89,0x4C,0x24,0x40,0x48,0x63,0xD2,0x0F,0xB6,0x04,0x10,0x8B,0x54,0x24,0x40,0x8B,0x4C,0x24,0x38,0xFF,0xC9,0x3B,0xD1,0x7E,0x06,0x33,0xD2,0x89,0x54,0x24,0x40,0x8B,0x54,0x24,0x44,0xFF,0xCA,0x89,0x54,0x24,0x44,0x48,0x8D,0x54,0x24,0x28,0x48,0x8B,0x12,0x8B,0x4C,0x24,0x40,0x44,0x8D,0x41,0x01,0x44,0x89,0x44,0x24,0x40,0x48,0x63,0xC9,0x0F,0xB6,0x14,0x0A,0x03,0xC2,0x48,0x83,0xC4,0x48,0xC3};
; [0x7ff7c8393170, 0x7ff7c8393296], 294 bytes
; 2020-01-20 01:59:21:084
0000h sub rsp,48h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 48}
0004h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0006h mov [rsp+28h],rax                       ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 44 24 28}
000bh mov [rsp+30h],rax                       ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 44 24 30}
0010h mov [rsp+38h],rax                       ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 44 24 38}
0015h mov [rsp+40h],rax                       ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 44 24 40}
001ah lea rcx,[rsp+28h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 4c 24 28}
001fh mov edx,40h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 40 00 00 00}
0024h call 7FF7C8392FE0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 47 fe ff ff}
0029h mov eax,[rsp+3Ch]                       ; MOV r32, r/m32 || o32 8B /r || encoded[4]{8b 44 24 3c}
002dh mov edx,[rsp+38h]                       ; MOV r32, r/m32 || o32 8B /r || encoded[4]{8b 54 24 38}
0031h dec edx                                 ; DEC r/m32 || o32 FF /1 || encoded[2]{ff ca}
0033h cmp eax,edx                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b c2}
0035h jle short 003dh                         ; JLE rel8 || 7E cb || encoded[2]{7e 06}
0037h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0039h mov [rsp+3Ch],eax                       ; MOV r/m32, r32 || o32 89 /r || encoded[4]{89 44 24 3c}
003dh mov eax,[rsp+44h]                       ; MOV r32, r/m32 || o32 8B /r || encoded[4]{8b 44 24 44}
0041h cmp eax,[rsp+38h]                       ; CMP r32, r/m32 || o32 3B /r || encoded[4]{3b 44 24 38}
0045h je short 0051h                          ; JE rel8 || 74 cb || encoded[2]{74 0a}
0047h mov eax,[rsp+44h]                       ; MOV r32, r/m32 || o32 8B /r || encoded[4]{8b 44 24 44}
004bh inc eax                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c0}
004dh mov [rsp+44h],eax                       ; MOV r/m32, r32 || o32 89 /r || encoded[4]{89 44 24 44}
0051h lea rax,[rsp+28h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 28}
0056h mov rax,[rax]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 00}
0059h mov edx,[rsp+3Ch]                       ; MOV r32, r/m32 || o32 8B /r || encoded[4]{8b 54 24 3c}
005dh lea ecx,[rdx+1]                         ; LEA r32, m || o32 8D /r || encoded[3]{8d 4a 01}
0060h mov [rsp+3Ch],ecx                       ; MOV r/m32, r32 || o32 89 /r || encoded[4]{89 4c 24 3c}
0064h movsxd rdx,edx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 d2}
0067h mov byte ptr [rax+rdx],3                ; MOV r/m8, imm8 || C6 /0 ib || encoded[4]{c6 04 10 03}
006bh mov eax,[rsp+3Ch]                       ; MOV r32, r/m32 || o32 8B /r || encoded[4]{8b 44 24 3c}
006fh mov edx,[rsp+38h]                       ; MOV r32, r/m32 || o32 8B /r || encoded[4]{8b 54 24 38}
0073h dec edx                                 ; DEC r/m32 || o32 FF /1 || encoded[2]{ff ca}
0075h cmp eax,edx                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b c2}
0077h jle short 007fh                         ; JLE rel8 || 7E cb || encoded[2]{7e 06}
0079h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
007bh mov [rsp+3Ch],eax                       ; MOV r/m32, r32 || o32 89 /r || encoded[4]{89 44 24 3c}
007fh mov eax,[rsp+44h]                       ; MOV r32, r/m32 || o32 8B /r || encoded[4]{8b 44 24 44}
0083h cmp eax,[rsp+38h]                       ; CMP r32, r/m32 || o32 3B /r || encoded[4]{3b 44 24 38}
0087h je short 0093h                          ; JE rel8 || 74 cb || encoded[2]{74 0a}
0089h mov eax,[rsp+44h]                       ; MOV r32, r/m32 || o32 8B /r || encoded[4]{8b 44 24 44}
008dh inc eax                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c0}
008fh mov [rsp+44h],eax                       ; MOV r/m32, r32 || o32 89 /r || encoded[4]{89 44 24 44}
0093h lea rax,[rsp+28h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 28}
0098h mov rax,[rax]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 00}
009bh mov edx,[rsp+3Ch]                       ; MOV r32, r/m32 || o32 8B /r || encoded[4]{8b 54 24 3c}
009fh lea ecx,[rdx+1]                         ; LEA r32, m || o32 8D /r || encoded[3]{8d 4a 01}
00a2h mov [rsp+3Ch],ecx                       ; MOV r/m32, r32 || o32 89 /r || encoded[4]{89 4c 24 3c}
00a6h movsxd rdx,edx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 d2}
00a9h mov byte ptr [rax+rdx],4                ; MOV r/m8, imm8 || C6 /0 ib || encoded[4]{c6 04 10 04}
00adh mov eax,[rsp+40h]                       ; MOV r32, r/m32 || o32 8B /r || encoded[4]{8b 44 24 40}
00b1h mov edx,[rsp+38h]                       ; MOV r32, r/m32 || o32 8B /r || encoded[4]{8b 54 24 38}
00b5h dec edx                                 ; DEC r/m32 || o32 FF /1 || encoded[2]{ff ca}
00b7h cmp eax,edx                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b c2}
00b9h jle short 00c1h                         ; JLE rel8 || 7E cb || encoded[2]{7e 06}
00bbh xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
00bdh mov [rsp+40h],eax                       ; MOV r/m32, r32 || o32 89 /r || encoded[4]{89 44 24 40}
00c1h mov eax,[rsp+44h]                       ; MOV r32, r/m32 || o32 8B /r || encoded[4]{8b 44 24 44}
00c5h dec eax                                 ; DEC r/m32 || o32 FF /1 || encoded[2]{ff c8}
00c7h mov [rsp+44h],eax                       ; MOV r/m32, r32 || o32 89 /r || encoded[4]{89 44 24 44}
00cbh lea rax,[rsp+28h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 28}
00d0h mov rax,[rax]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 00}
00d3h mov edx,[rsp+40h]                       ; MOV r32, r/m32 || o32 8B /r || encoded[4]{8b 54 24 40}
00d7h lea ecx,[rdx+1]                         ; LEA r32, m || o32 8D /r || encoded[3]{8d 4a 01}
00dah mov [rsp+40h],ecx                       ; MOV r/m32, r32 || o32 89 /r || encoded[4]{89 4c 24 40}
00deh movsxd rdx,edx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 d2}
00e1h movzx eax,byte ptr [rax+rdx]            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{0f b6 04 10}
00e5h mov edx,[rsp+40h]                       ; MOV r32, r/m32 || o32 8B /r || encoded[4]{8b 54 24 40}
00e9h mov ecx,[rsp+38h]                       ; MOV r32, r/m32 || o32 8B /r || encoded[4]{8b 4c 24 38}
00edh dec ecx                                 ; DEC r/m32 || o32 FF /1 || encoded[2]{ff c9}
00efh cmp edx,ecx                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b d1}
00f1h jle short 00f9h                         ; JLE rel8 || 7E cb || encoded[2]{7e 06}
00f3h xor edx,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d2}
00f5h mov [rsp+40h],edx                       ; MOV r/m32, r32 || o32 89 /r || encoded[4]{89 54 24 40}
00f9h mov edx,[rsp+44h]                       ; MOV r32, r/m32 || o32 8B /r || encoded[4]{8b 54 24 44}
00fdh dec edx                                 ; DEC r/m32 || o32 FF /1 || encoded[2]{ff ca}
00ffh mov [rsp+44h],edx                       ; MOV r/m32, r32 || o32 89 /r || encoded[4]{89 54 24 44}
0103h lea rdx,[rsp+28h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 54 24 28}
0108h mov rdx,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 12}
010bh mov ecx,[rsp+40h]                       ; MOV r32, r/m32 || o32 8B /r || encoded[4]{8b 4c 24 40}
010fh lea r8d,[rcx+1]                         ; LEA r32, m || o32 8D /r || encoded[4]{44 8d 41 01}
0113h mov [rsp+40h],r8d                       ; MOV r/m32, r32 || o32 89 /r || encoded[5]{44 89 44 24 40}
0118h movsxd rcx,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 c9}
011bh movzx edx,byte ptr [rdx+rcx]            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{0f b6 14 0a}
011fh add eax,edx                             ; ADD r32, r/m32 || o32 03 /r || encoded[2]{03 c2}
0121h add rsp,48h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 48}
0125h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ref BitStack push(bit src, ref BitStack dst)
; static ReadOnlySpan<byte> push_33831530Bytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xD1,0x22,0x48,0x8B,0x02,0x8B,0xC9,0x48,0x0B,0xC1,0x48,0x89,0x02,0x48,0x8B,0xC2,0xC3};
; [0x7ff7c83936c0, 0x7ff7c83936d7], 23 bytes
; 2020-01-20 01:59:21:085
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h shl qword ptr [rdx],1                   ; SHL r/m64, 1 || REX.W D1 /4 || encoded[3]{48 d1 22}
0008h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
000bh mov ecx,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c9}
000dh or rax,rcx                              ; OR r64, r/m64 || REX.W 0B /r || encoded[3]{48 0b c1}
0010h mov [rdx],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 02}
0013h mov rax,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c2}
0016h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit pop(ref BitStack src)
; static ReadOnlySpan<byte> pop_0xBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x8B,0xD0,0x48,0x83,0xE2,0x01,0x83,0xE2,0x01,0x48,0xD1,0xE8,0x48,0x89,0x01,0x8B,0xC2,0xC3};
; [0x7ff7c83936f0, 0x7ff7c839370b], 27 bytes
; 2020-01-20 01:59:21:085
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 01}
0008h mov rdx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d0}
000bh and rdx,1                               ; AND r/m64, imm8 || REX.W 83 /4 ib || encoded[4]{48 83 e2 01}
000fh and edx,1                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e2 01}
0012h shr rax,1                               ; SHR r/m64, 1 || REX.W D1 /5 || encoded[3]{48 d1 e8}
0015h mov [rcx],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 01}
0018h mov eax,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c2}
001ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit and_logic(bit a, bit b)
; static ReadOnlySpan<byte> and_logic_0xBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0xC3};
; [0x7ff7c8393b30, 0x7ff7c8393b3a], 10 bytes
; 2020-01-20 01:59:21:085
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h and eax,edx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 c2}
0009h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong and_scalar(ulong a, ulong b)
; static ReadOnlySpan<byte> and_scalar_64uBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x23,0xD1,0x48,0x8B,0xC2,0xC3};
; [0x7ff7c8393f70, 0x7ff7c8393f7c], 12 bytes
; 2020-01-20 01:59:21:085
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h and rdx,rcx                             ; AND r64, r/m64 || REX.W 23 /r || encoded[3]{48 23 d1}
0008h mov rax,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c2}
000bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<ulong> and_v128(Vector128<ulong> a, Vector128<ulong> b)
; static ReadOnlySpan<byte> and_v128_128x64uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xDB,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c83947c0, 0x7ff7c83947da], 26 bytes
; 2020-01-20 01:59:21:085
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh vpand xmm0,xmm0,xmm1                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f9 db c1}
0012h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0016h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0019h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<ulong> and_v256(Vector256<ulong> a, Vector256<ulong> b)
; static ReadOnlySpan<byte> and_v256_256x64uBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0xDB,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c83947f0, 0x7ff7c839480d], 29 bytes
; 2020-01-20 01:59:21:085
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h vmovupd ymm1,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 08}
000eh vpand ymm0,ymm0,ymm1                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 fd db c1}
0012h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0016h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0019h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
001ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit nor_logic(bit a, bit b)
; static ReadOnlySpan<byte> nor_logic_0xBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0B,0xD1,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
; [0x7ff7c8394820, 0x7ff7c839482f], 15 bytes
; 2020-01-20 01:59:21:085
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h or edx,ecx                              ; OR r32, r/m32 || o32 0B /r || encoded[2]{0b d1}
0007h mov eax,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c2}
0009h not eax                                 ; NOT r/m32 || o32 F7 /2 || encoded[2]{f7 d0}
000bh and eax,1                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e0 01}
000eh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong nor_scalar(ulong a, ulong b)
; static ReadOnlySpan<byte> nor_scalar_64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0B,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
; [0x7ff7c8394840, 0x7ff7c839484f], 15 bytes
; 2020-01-20 01:59:21:085
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h or rdx,rcx                              ; OR r64, r/m64 || REX.W 0B /r || encoded[3]{48 0b d1}
0008h mov rax,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c2}
000bh not rax                                 ; NOT r/m64 || REX.W F7 /2 || encoded[3]{48 f7 d0}
000eh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<ulong> nor_v128(Vector128<ulong> a, Vector128<ulong> b)
; static ReadOnlySpan<byte> nor_v128_128x64uBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xEB,0xC1,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c8394860, 0x7ff7c8394882], 34 bytes
; 2020-01-20 01:59:21:085
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh vpor xmm0,xmm0,xmm1                     ; VPOR xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG EB /r || encoded[4]{c5 f9 eb c1}
0012h vpcmpeqd xmm1,xmm0,xmm0                 ; VPCMPEQD xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG 76 /r || encoded[4]{c5 f9 76 c8}
0016h vpxor xmm0,xmm0,xmm1                    ; VPXOR xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG EF /r || encoded[4]{c5 f9 ef c1}
001ah vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
001eh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0021h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<ulong> nor_v256(Vector256<ulong> a, Vector256<ulong> b)
; static ReadOnlySpan<byte> nor_v256_256x64uBytes => new byte[38]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0xEB,0xC1,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c83948a0, 0x7ff7c83948c6], 38 bytes
; 2020-01-20 01:59:21:085
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h vmovupd ymm1,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 08}
000eh vpor ymm0,ymm0,ymm1                     ; VPOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EB /r || encoded[4]{c5 fd eb c1}
0012h vpcmpeqq ymm1,ymm0,ymm0                 ; VPCMPEQQ ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 29 /r || encoded[5]{c4 e2 7d 29 c8}
0017h vpxor ymm0,ymm0,ymm1                    ; VPXOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EF /r || encoded[4]{c5 fd ef c1}
001bh vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
001fh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0022h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0025h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit xnor_logic(bit a, bit b)
; static ReadOnlySpan<byte> xnor_logic_0xBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xD1,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
; [0x7ff7c83948e0, 0x7ff7c83948ef], 15 bytes
; 2020-01-20 01:59:21:085
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h xor edx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d1}
0007h mov eax,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c2}
0009h not eax                                 ; NOT r/m32 || o32 F7 /2 || encoded[2]{f7 d0}
000bh and eax,1                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e0 01}
000eh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong xnor_scalar(ulong a, ulong b)
; static ReadOnlySpan<byte> xnor_scalar_64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x33,0xD1,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0xC3};
; [0x7ff7c8394900, 0x7ff7c839490f], 15 bytes
; 2020-01-20 01:59:21:085
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h xor rdx,rcx                             ; XOR r64, r/m64 || REX.W 33 /r || encoded[3]{48 33 d1}
0008h mov rax,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c2}
000bh not rax                                 ; NOT r/m64 || REX.W F7 /2 || encoded[3]{48 f7 d0}
000eh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<ulong> xnor_v128(Vector128<ulong> a, Vector128<ulong> b)
; static ReadOnlySpan<byte> xnor_v128_128x64uBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c8394920, 0x7ff7c8394942], 34 bytes
; 2020-01-20 01:59:21:085
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh vpxor xmm0,xmm0,xmm1                    ; VPXOR xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG EF /r || encoded[4]{c5 f9 ef c1}
0012h vpcmpeqd xmm1,xmm0,xmm0                 ; VPCMPEQD xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG 76 /r || encoded[4]{c5 f9 76 c8}
0016h vpxor xmm0,xmm0,xmm1                    ; VPXOR xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG EF /r || encoded[4]{c5 f9 ef c1}
001ah vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
001eh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0021h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<ulong> xnor_v256(Vector256<ulong> a, Vector256<ulong> b)
; static ReadOnlySpan<byte> xnor_v256_256x64uBytes => new byte[38]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0xEF,0xC1,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c8394960, 0x7ff7c8394986], 38 bytes
; 2020-01-20 01:59:21:085
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h vmovupd ymm1,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 08}
000eh vpxor ymm0,ymm0,ymm1                    ; VPXOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EF /r || encoded[4]{c5 fd ef c1}
0012h vpcmpeqq ymm1,ymm0,ymm0                 ; VPCMPEQQ ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 29 /r || encoded[5]{c4 e2 7d 29 c8}
0017h vpxor ymm0,ymm0,ymm1                    ; VPXOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EF /r || encoded[4]{c5 fd ef c1}
001bh vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
001fh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0022h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0025h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit imply_logic(bit a, bit b)
; static ReadOnlySpan<byte> imply_logic_0xBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0x0B,0xC1,0xC3};
; [0x7ff7c83949a0, 0x7ff7c83949af], 15 bytes
; 2020-01-20 01:59:21:085
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c2}
0007h not eax                                 ; NOT r/m32 || o32 F7 /2 || encoded[2]{f7 d0}
0009h and eax,1                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e0 01}
000ch or eax,ecx                              ; OR r32, r/m32 || o32 0B /r || encoded[2]{0b c1}
000eh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong imply_scalar(ulong a, ulong b)
; static ReadOnlySpan<byte> imply_scalar_64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x48,0x0B,0xC1,0xC3};
; [0x7ff7c83949c0, 0x7ff7c83949cf], 15 bytes
; 2020-01-20 01:59:21:086
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c2}
0008h not rax                                 ; NOT r/m64 || REX.W F7 /2 || encoded[3]{48 f7 d0}
000bh or rax,rcx                              ; OR r64, r/m64 || REX.W 0B /r || encoded[3]{48 0b c1}
000eh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<ulong> imply_v128(Vector128<ulong> a, Vector128<ulong> b)
; static ReadOnlySpan<byte> imply_v128_128x64uBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF1,0x76,0xD1,0xC5,0xF1,0xEF,0xCA,0xC5,0xF9,0xEB,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c8394df0, 0x7ff7c8394e12], 34 bytes
; 2020-01-20 01:59:21:086
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh vpcmpeqd xmm2,xmm1,xmm1                 ; VPCMPEQD xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG 76 /r || encoded[4]{c5 f1 76 d1}
0012h vpxor xmm1,xmm1,xmm2                    ; VPXOR xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG EF /r || encoded[4]{c5 f1 ef ca}
0016h vpor xmm0,xmm0,xmm1                     ; VPOR xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG EB /r || encoded[4]{c5 f9 eb c1}
001ah vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
001eh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0021h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<ulong> imply_v256(Vector256<ulong> a, Vector256<ulong> b)
; static ReadOnlySpan<byte> imply_v256_256x64uBytes => new byte[38]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x75,0x29,0xD1,0xC5,0xF5,0xEF,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c8394e30, 0x7ff7c8394e56], 38 bytes
; 2020-01-20 01:59:21:086
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h vmovupd ymm1,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 08}
000eh vpcmpeqq ymm2,ymm1,ymm1                 ; VPCMPEQQ ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 29 /r || encoded[5]{c4 e2 75 29 d1}
0013h vpxor ymm1,ymm1,ymm2                    ; VPXOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EF /r || encoded[4]{c5 f5 ef ca}
0017h vpor ymm0,ymm0,ymm1                     ; VPOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EB /r || encoded[4]{c5 fd eb c1}
001bh vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
001fh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0022h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0025h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit notimply_logic(bit a, bit b)
; static ReadOnlySpan<byte> notimply_logic_0xBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0x23,0xC2,0xC3};
; [0x7ff7c8394e70, 0x7ff7c8394e7f], 15 bytes
; 2020-01-20 01:59:21:086
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h not eax                                 ; NOT r/m32 || o32 F7 /2 || encoded[2]{f7 d0}
0009h and eax,1                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e0 01}
000ch and eax,edx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 c2}
000eh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong notimply_scalar(ulong a, ulong b)
; static ReadOnlySpan<byte> notimply_scalar_64uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF0,0xF2,0xC2,0xC3};
; [0x7ff7c8394e90, 0x7ff7c8394e9b], 11 bytes
; 2020-01-20 01:59:21:086
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h andn rax,rcx,rdx                        ; ANDN r64a, r64b, r/m64 || VEX.LZ.0F38.W1 F2 /r || encoded[5]{c4 e2 f0 f2 c2}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<ulong> notimply_v128(Vector128<ulong> a, Vector128<ulong> b)
; static ReadOnlySpan<byte> notimply_v128_128x64uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xDF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c8394eb0, 0x7ff7c8394eca], 26 bytes
; 2020-01-20 01:59:21:086
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh vpandn xmm0,xmm0,xmm1                   ; VPANDN xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DF /r || encoded[4]{c5 f9 df c1}
0012h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0016h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0019h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<ulong> notimply_v256(Vector256<ulong> a, Vector256<ulong> b)
; static ReadOnlySpan<byte> notimply_v256_256x64uBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0xDF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c8394ee0, 0x7ff7c8394efd], 29 bytes
; 2020-01-20 01:59:21:088
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h vmovupd ymm1,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 08}
000eh vpandn ymm0,ymm0,ymm1                   ; VPANDN ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DF /r || encoded[4]{c5 fd df c1}
0012h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0016h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0019h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
001ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit cimply_logic(bit a, bit b)
; static ReadOnlySpan<byte> cimply_logic_0xBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0x83,0xE0,0x01,0x0B,0xC2,0xC3};
; [0x7ff7c8394f10, 0x7ff7c8394f1f], 15 bytes
; 2020-01-20 01:59:21:088
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h not eax                                 ; NOT r/m32 || o32 F7 /2 || encoded[2]{f7 d0}
0009h and eax,1                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e0 01}
000ch or eax,edx                              ; OR r32, r/m32 || o32 0B /r || encoded[2]{0b c2}
000eh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong cimply_scalar(ulong a, ulong b)
; static ReadOnlySpan<byte> cimply_scalar_64uBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0x0B,0xC2,0xC3};
; [0x7ff7c8394f30, 0x7ff7c8394f3f], 15 bytes
; 2020-01-20 01:59:21:088
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0008h not rax                                 ; NOT r/m64 || REX.W F7 /2 || encoded[3]{48 f7 d0}
000bh or rax,rdx                              ; OR r64, r/m64 || REX.W 0B /r || encoded[3]{48 0b c2}
000eh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<ulong> cimply_v128(Vector128<ulong> a, Vector128<ulong> b)
; static ReadOnlySpan<byte> cimply_v128_128x64uBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0x76,0xD0,0xC5,0xF9,0xEF,0xC2,0xC5,0xF9,0xEB,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c8394f50, 0x7ff7c8394f72], 34 bytes
; 2020-01-20 01:59:21:089
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh vpcmpeqd xmm2,xmm0,xmm0                 ; VPCMPEQD xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG 76 /r || encoded[4]{c5 f9 76 d0}
0012h vpxor xmm0,xmm0,xmm2                    ; VPXOR xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG EF /r || encoded[4]{c5 f9 ef c2}
0016h vpor xmm0,xmm0,xmm1                     ; VPOR xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG EB /r || encoded[4]{c5 f9 eb c1}
001ah vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
001eh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0021h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<ulong> cimply_v256(Vector256<ulong> a, Vector256<ulong> b)
; static ReadOnlySpan<byte> cimply_v256_256x64uBytes => new byte[38]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x7D,0x29,0xD0,0xC5,0xFD,0xEF,0xC2,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c8394f90, 0x7ff7c8394fb6], 38 bytes
; 2020-01-20 01:59:21:089
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h vmovupd ymm1,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 08}
000eh vpcmpeqq ymm2,ymm0,ymm0                 ; VPCMPEQQ ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 29 /r || encoded[5]{c4 e2 7d 29 d0}
0013h vpxor ymm0,ymm0,ymm2                    ; VPXOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EF /r || encoded[4]{c5 fd ef c2}
0017h vpor ymm0,ymm0,ymm1                     ; VPOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EB /r || encoded[4]{c5 fd eb c1}
001bh vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
001fh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0022h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0025h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit cnotimply_logic(bit a, bit b)
; static ReadOnlySpan<byte> cnotimply_logic_0xBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0x23,0xC1,0xC3};
; [0x7ff7c8394fd0, 0x7ff7c8394fdf], 15 bytes
; 2020-01-20 01:59:21:089
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c2}
0007h not eax                                 ; NOT r/m32 || o32 F7 /2 || encoded[2]{f7 d0}
0009h and eax,1                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e0 01}
000ch and eax,ecx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 c1}
000eh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong cnotimply_scalar(ulong a, ulong b)
; static ReadOnlySpan<byte> cnotimply_scalar_64uBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xE8,0xF2,0xC1,0xC3};
; [0x7ff7c8394ff0, 0x7ff7c8394ffb], 11 bytes
; 2020-01-20 01:59:21:089
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h andn rax,rdx,rcx                        ; ANDN r64a, r64b, r/m64 || VEX.LZ.0F38.W1 F2 /r || encoded[5]{c4 e2 e8 f2 c1}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<ulong> cnotimply_v128(Vector128<ulong> a, Vector128<ulong> b)
; static ReadOnlySpan<byte> cnotimply_v128_128x64uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF1,0xDF,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c8395420, 0x7ff7c839543a], 26 bytes
; 2020-01-20 01:59:21:089
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh vpandn xmm0,xmm1,xmm0                   ; VPANDN xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DF /r || encoded[4]{c5 f1 df c0}
0012h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0016h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0019h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<ulong> cnotimply_v256(Vector256<ulong> a, Vector256<ulong> b)
; static ReadOnlySpan<byte> cnotimply_v256_256x64uBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xF5,0xDF,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c8395450, 0x7ff7c839546d], 29 bytes
; 2020-01-20 01:59:21:089
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h vmovupd ymm1,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 08}
000eh vpandn ymm0,ymm1,ymm0                   ; VPANDN ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DF /r || encoded[4]{c5 f5 df c0}
0012h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0016h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0019h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
001ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
