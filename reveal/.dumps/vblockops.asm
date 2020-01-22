; 2020-01-22 01:44:40:341
; ref uint reftest_1(in uint x, in uint y, ref uint z)
; reftest_1_32u[0x7ff7c81c26b0, 0x7ff7c81c26c0][16] = {0f 1f 44 00 00 8b 01 03 02 41 89 00 49 8b c0 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,[rcx]                           ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b 01}
0007h add eax,[rdx]                           ; ADD r32, r/m32 || o32 03 /r || encoded[2]{03 02}
0009h mov [r8],eax                            ; MOV r/m32, r32 || o32 89 /r || encoded[3]{41 89 00}
000ch mov rax,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b c0}
000fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ref uint reftest_2(in uint x, in uint y, ref uint z)
; reftest_2_32u[0x7ff7c81c26d0, 0x7ff7c81c26e0][16] = {0f 1f 44 00 00 8b 01 03 02 41 89 00 49 8b c0 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,[rcx]                           ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b 01}
0007h add eax,[rdx]                           ; ADD r32, r/m32 || o32 03 /r || encoded[2]{03 02}
0009h mov [r8],eax                            ; MOV r/m32, r32 || o32 89 /r || encoded[3]{41 89 00}
000ch mov rax,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b c0}
000fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ref Block128<uint> vbsll(in Block128<uint> a, in Block128<uint> dst)
; vbsll_0x[0x7ff7c85a26e0, 0x7ff7c85a273e][94] = {c5 f8 77 66 90 44 8b 42 08 45 8b c8 41 c1 f9 1f 41 83 e1 03 45 03 c1 41 c1 f8 02 45 33 c9 45 85 c0 7e 37 48 8b 01 48 8b 0a 4c 8b d0 45 8b d9 41 c1 e3 02 4d 63 db 49 c1 e3 02 4d 03 d3 c4 c1 7b f0 02 c5 f9 73 f8 03 4c 8b d1 4d 03 d3 c4 c1 7a 7f 02 41 ff c1 45 3b c8 7c cf 48 8b c2 c3}
; Capture completion code, None
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
; spanconvert_3475410[0x7ff7c85a2b60, 0x7ff7c85a2b75][21] = {0f 1f 44 00 00 48 8b 02 8b 52 08 48 89 01 89 51 08 48 8b c1 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
0008h mov edx,[rdx+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 52 08}
000bh mov [rcx],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 01}
000eh mov [rcx+8],edx                         ; MOV r/m32, r32 || o32 89 /r || encoded[3]{89 51 08}
0011h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0014h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
