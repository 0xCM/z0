; 2020-01-20 01:59:21:329
; ref uint reftest_1(in uint x, in uint y, ref uint z)
; static ReadOnlySpan<byte> reftest_1_32uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x03,0x02,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
; [0x7ff7c85f2830, 0x7ff7c85f2840], 16 bytes
; 2020-01-20 01:59:21:329
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,[rcx]                           ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b 01}
0007h add eax,[rdx]                           ; ADD r32, r/m32 || o32 03 /r || encoded[2]{03 02}
0009h mov [r8],eax                            ; MOV r/m32, r32 || o32 89 /r || encoded[3]{41 89 00}
000ch mov rax,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b c0}
000fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ref uint reftest_2(in uint x, in uint y, ref uint z)
; static ReadOnlySpan<byte> reftest_2_32uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x03,0x02,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
; [0x7ff7c85f2850, 0x7ff7c85f2860], 16 bytes
; 2020-01-20 01:59:21:329
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,[rcx]                           ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b 01}
0007h add eax,[rdx]                           ; ADD r32, r/m32 || o32 03 /r || encoded[2]{03 02}
0009h mov [r8],eax                            ; MOV r/m32, r32 || o32 89 /r || encoded[3]{41 89 00}
000ch mov rax,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b c0}
000fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ref Block128<uint> vbsll(in Block128<uint> a, in Block128<uint> dst)
; static ReadOnlySpan<byte> vbsll_0xBytes => new byte[94]{0xC5,0xF8,0x77,0x66,0x90,0x44,0x8B,0x42,0x08,0x45,0x8B,0xC8,0x41,0xC1,0xF9,0x1F,0x41,0x83,0xE1,0x03,0x45,0x03,0xC1,0x41,0xC1,0xF8,0x02,0x45,0x33,0xC9,0x45,0x85,0xC0,0x7E,0x37,0x48,0x8B,0x01,0x48,0x8B,0x0A,0x4C,0x8B,0xD0,0x45,0x8B,0xD9,0x41,0xC1,0xE3,0x02,0x4D,0x63,0xDB,0x49,0xC1,0xE3,0x02,0x4D,0x03,0xD3,0xC4,0xC1,0x7B,0xF0,0x02,0xC5,0xF9,0x73,0xF8,0x03,0x4C,0x8B,0xD1,0x4D,0x03,0xD3,0xC4,0xC1,0x7A,0x7F,0x02,0x41,0xFF,0xC1,0x45,0x3B,0xC8,0x7C,0xCF,0x48,0x8B,0xC2,0xC3};
; [0x7ff7c85f52e0, 0x7ff7c85f533e], 94 bytes
; 2020-01-20 01:59:21:329
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h mov r8d,[rdx+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[4]{44 8b 42 08}
0009h mov r9d,r8d                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{45 8b c8}
000ch sar r9d,1Fh                             ; SAR r/m32, imm8 || o32 C1 /7 ib || encoded[4]{41 c1 f9 1f}
0010h and r9d,3                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[4]{41 83 e1 03}
0014h add r8d,r9d                             ; ADD r32, r/m32 || o32 03 /r || encoded[3]{45 03 c1}
0017h sar r8d,2                               ; SAR r/m32, imm8 || o32 C1 /7 ib || encoded[4]{41 c1 f8 02}
001bh xor r9d,r9d                             ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 c9}
001eh test r8d,r8d                            ; TEST r/m32, r32 || o32 85 /r || encoded[3]{45 85 c0}
0021h jle short 005ah                         ; JLE rel8 || 7E cb || encoded[2]{7e 37}
0023h mov rax,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 01}
0026h mov rcx,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 0a}
0029h mov r10,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b d0}
002ch mov r11d,r9d                            ; MOV r32, r/m32 || o32 8B /r || encoded[3]{45 8b d9}
002fh shl r11d,2                              ; SHL r/m32, imm8 || o32 C1 /4 ib || encoded[4]{41 c1 e3 02}
0033h movsxd r11,r11d                         ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4d 63 db}
0036h shl r11,2                               ; SHL r/m64, imm8 || REX.W C1 /4 ib || encoded[4]{49 c1 e3 02}
003ah add r10,r11                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{4d 03 d3}
003dh vlddqu xmm0,xmmword ptr [r10]           ; VLDDQU xmm1, m128 || VEX.128.F2.0F.WIG F0 /r || encoded[5]{c4 c1 7b f0 02}
0042h vpslldq xmm0,xmm0,3                     ; VPSLLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /7 ib || encoded[5]{c5 f9 73 f8 03}
0047h mov r10,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b d1}
004ah add r10,r11                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{4d 03 d3}
004dh vmovdqu xmmword ptr [r10],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c4 c1 7a 7f 02}
0052h inc r9d                                 ; INC r/m32 || o32 FF /0 || encoded[3]{41 ff c1}
0055h cmp r9d,r8d                             ; CMP r32, r/m32 || o32 3B /r || encoded[3]{45 3b c8}
0058h jl short 0029h                          ; JL rel8 || 7C cb || encoded[2]{7c cf}
005ah mov rax,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c2}
005dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ReadOnlySpan<Int16> spanconvert(Span<Int16> src)
; static ReadOnlySpan<byte> spanconvert_25079723Bytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x8B,0x52,0x08,0x48,0x89,0x01,0x89,0x51,0x08,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c85f5350, 0x7ff7c85f5365], 21 bytes
; 2020-01-20 01:59:21:329
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
0008h mov edx,[rdx+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 52 08}
000bh mov [rcx],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 01}
000eh mov [rcx+8],edx                         ; MOV r/m32, r32 || o32 89 /r || encoded[3]{89 51 08}
0011h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0014h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
