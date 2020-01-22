; 2020-01-22 01:43:39:368
; BitPos<uint> bitpos_u32(int index)
; bitpos_u32_32i[0x7ff7c8399430, 0x7ff7c83994b3][131] = {48 83 ec 38 c5 f8 77 44 8b c2 c7 44 24 14 20 00 00 00 44 0f b6 4c 24 14 41 8b c0 33 d2 41 f7 f1 89 44 24 10 44 0f b7 4c 24 10 c7 44 24 0c 20 00 00 00 44 0f b6 54 24 0c 41 8b c0 33 d2 41 f7 f2 89 54 24 08 48 8d 44 24 18 c5 f8 57 c0 c5 fa 7f 00 c5 fa 7f 40 10 0f b6 44 24 08 66 44 89 4c 24 18 66 89 44 24 1a c5 fa 6f 44 24 18 c5 fa 7f 01 c5 fa 6f 44 24 28 c5 fa 7f 41 10 48 8b c1 48 83 c4 38 c3}
; Capture completion code, None
0000h sub rsp,38h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 38}
0004h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0007h mov r8d,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{44 8b c2}
000ah mov dword ptr [rsp+14h],20h             ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 14 20 00 00 00}
0012h movzx r9d,byte ptr [rsp+14h]            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[6]{44 0f b6 4c 24 14}
0018h mov eax,r8d                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b c0}
001bh xor edx,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d2}
001dh div r9d                                 ; DIV r/m32 || o32 F7 /6 || encoded[3]{41 f7 f1}
0020h mov [rsp+10h],eax                       ; MOV r/m32, r32 || o32 89 /r || encoded[4]{89 44 24 10}
0024h movzx r9d,word ptr [rsp+10h]            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[6]{44 0f b7 4c 24 10}
002ah mov dword ptr [rsp+0Ch],20h             ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 0c 20 00 00 00}
0032h movzx r10d,byte ptr [rsp+0Ch]           ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[6]{44 0f b6 54 24 0c}
0038h mov eax,r8d                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b c0}
003bh xor edx,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d2}
003dh div r10d                                ; DIV r/m32 || o32 F7 /6 || encoded[3]{41 f7 f2}
0040h mov [rsp+8],edx                         ; MOV r/m32, r32 || o32 89 /r || encoded[4]{89 54 24 08}
0044h lea rax,[rsp+18h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 18}
0049h vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
004dh vmovdqu xmmword ptr [rax],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 00}
0051h vmovdqu xmmword ptr [rax+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 10}
0056h movzx eax,byte ptr [rsp+8]              ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[5]{0f b6 44 24 08}
005bh mov [rsp+18h],r9w                       ; MOV r/m16, r16 || o16 89 /r || encoded[6]{66 44 89 4c 24 18}
0061h mov [rsp+1Ah],ax                        ; MOV r/m16, r16 || o16 89 /r || encoded[5]{66 89 44 24 1a}
0066h vmovdqu xmm0,xmmword ptr [rsp+18h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[6]{c5 fa 6f 44 24 18}
006ch vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}
0070h vmovdqu xmm0,xmmword ptr [rsp+28h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[6]{c5 fa 6f 44 24 28}
0076h vmovdqu xmmword ptr [rcx+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 10}
007bh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
007eh add rsp,38h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 38}
0082h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitPos<uint> bitpos_u32_x(int index)
; bitpos_u32_x_32i[0x7ff7c83994d0, 0x7ff7c8399553][131] = {48 83 ec 38 c5 f8 77 44 8b c2 c7 44 24 14 20 00 00 00 44 0f b6 4c 24 14 41 8b c0 33 d2 41 f7 f1 89 44 24 10 44 0f b7 4c 24 10 c7 44 24 0c 20 00 00 00 44 0f b6 54 24 0c 41 8b c0 33 d2 41 f7 f2 89 54 24 08 48 8d 44 24 18 c5 f8 57 c0 c5 fa 7f 00 c5 fa 7f 40 10 0f b6 44 24 08 66 44 89 4c 24 18 66 89 44 24 1a c5 fa 6f 44 24 18 c5 fa 7f 01 c5 fa 6f 44 24 28 c5 fa 7f 41 10 48 8b c1 48 83 c4 38 c3}
; Capture completion code, None
0000h sub rsp,38h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 38}
0004h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0007h mov r8d,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{44 8b c2}
000ah mov dword ptr [rsp+14h],20h             ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 14 20 00 00 00}
0012h movzx r9d,byte ptr [rsp+14h]            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[6]{44 0f b6 4c 24 14}
0018h mov eax,r8d                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b c0}
001bh xor edx,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d2}
001dh div r9d                                 ; DIV r/m32 || o32 F7 /6 || encoded[3]{41 f7 f1}
0020h mov [rsp+10h],eax                       ; MOV r/m32, r32 || o32 89 /r || encoded[4]{89 44 24 10}
0024h movzx r9d,word ptr [rsp+10h]            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[6]{44 0f b7 4c 24 10}
002ah mov dword ptr [rsp+0Ch],20h             ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 0c 20 00 00 00}
0032h movzx r10d,byte ptr [rsp+0Ch]           ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[6]{44 0f b6 54 24 0c}
0038h mov eax,r8d                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b c0}
003bh xor edx,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d2}
003dh div r10d                                ; DIV r/m32 || o32 F7 /6 || encoded[3]{41 f7 f2}
0040h mov [rsp+8],edx                         ; MOV r/m32, r32 || o32 89 /r || encoded[4]{89 54 24 08}
0044h lea rax,[rsp+18h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 18}
0049h vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
004dh vmovdqu xmmword ptr [rax],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 00}
0051h vmovdqu xmmword ptr [rax+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 10}
0056h movzx eax,byte ptr [rsp+8]              ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[5]{0f b6 44 24 08}
005bh mov [rsp+18h],r9w                       ; MOV r/m16, r16 || o16 89 /r || encoded[6]{66 44 89 4c 24 18}
0061h mov [rsp+1Ah],ax                        ; MOV r/m16, r16 || o16 89 /r || encoded[5]{66 89 44 24 1a}
0066h vmovdqu xmm0,xmmword ptr [rsp+18h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[6]{c5 fa 6f 44 24 18}
006ch vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}
0070h vmovdqu xmm0,xmmword ptr [rsp+28h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[6]{c5 fa 6f 44 24 28}
0076h vmovdqu xmmword ptr [rcx+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 10}
007bh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
007eh add rsp,38h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 38}
0082h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit bitmatch_32_32(uint a, byte i, uint b, byte j)
; bitmatch_32_32_32u[0x7ff7c8399980, 0x7ff7c83999a4][36] = {0f 1f 44 00 00 8b c1 0f b6 ca d3 e8 83 e0 01 41 0f b6 c9 41 d3 e8 41 83 e0 01 41 3b c0 0f 94 c0 0f b6 c0 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h movzx ecx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 ca}
000ah shr eax,cl                              ; SHR r/m32, CL || o32 D3 /5 || encoded[2]{d3 e8}
000ch and eax,1                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e0 01}
000fh movzx ecx,r9b                           ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{41 0f b6 c9}
0013h shr r8d,cl                              ; SHR r/m32, CL || o32 D3 /5 || encoded[3]{41 d3 e8}
0016h and r8d,1                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[4]{41 83 e0 01}
001ah cmp eax,r8d                             ; CMP r32, r/m32 || o32 3B /r || encoded[3]{41 3b c0}
001dh sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0020h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0023h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void bitseg_u32(Span<uint> src, int firstidx, int lastidx)
; bitseg_u32_60384317[0x7ff7c8399dc0, 0x7ff7c839a0aa][746] = {48 81 ec a8 01 00 00 c5 f8 77 44 8b ca 48 8b 09 c7 84 24 44 01 00 00 20 00 00 00 44 0f b6 94 24 44 01 00 00 41 8b c1 33 d2 41 f7 f2 89 84 24 40 01 00 00 44 0f b7 94 24 40 01 00 00 c7 84 24 3c 01 00 00 20 00 00 00 44 0f b6 9c 24 3c 01 00 00 41 8b c1 33 d2 41 f7 f3 89 94 24 38 01 00 00 48 8d 84 24 48 01 00 00 c5 f8 57 c0 c5 fa 7f 00 c5 fa 7f 40 10 0f b6 84 24 38 01 00 00 66 44 89 94 24 48 01 00 00 66 89 84 24 4a 01 00 00 c5 fa 6f 84 24 48 01 00 00 c5 fa 7f 84 24 88 01 00 00 c5 fa 6f 84 24 58 01 00 00 c5 fa 7f 84 24 98 01 00 00 c7 84 24 14 01 00 00 20 00 00 00 44 0f b6 8c 24 14 01 00 00 41 8b c0 33 d2 41 f7 f1 89 84 24 10 01 00 00 44 0f b7 8c 24 10 01 00 00 c7 84 24 0c 01 00 00 20 00 00 00 44 0f b6 94 24 0c 01 00 00 41 8b c0 33 d2 41 f7 f2 89 94 24 08 01 00 00 48 8d 84 24 18 01 00 00 c5 f8 57 c0 c5 fa 7f 00 c5 fa 7f 40 10 0f b6 84 24 08 01 00 00 66 44 89 8c 24 18 01 00 00 66 89 84 24 1a 01 00 00 c5 fa 6f 84 24 18 01 00 00 c5 fa 7f 84 24 68 01 00 00 c5 fa 6f 84 24 28 01 00 00 c5 fa 7f 84 24 78 01 00 00 c5 fa 6f 84 24 88 01 00 00 c5 fa 7f 84 24 c8 00 00 00 c5 fa 6f 84 24 98 01 00 00 c5 fa 7f 84 24 d8 00 00 00 c5 fa 6f 84 24 68 01 00 00 c5 fa 7f 84 24 e8 00 00 00 c5 fa 6f 84 24 78 01 00 00 c5 fa 7f 84 24 f8 00 00 00 c5 fa 6f 84 24 e8 00 00 00 c5 fa 7f 84 24 a8 00 00 00 c5 fa 6f 84 24 f8 00 00 00 c5 fa 7f 84 24 b8 00 00 00 c5 fa 6f 84 24 c8 00 00 00 c5 fa 7f 84 24 88 00 00 00 c5 fa 6f 84 24 d8 00 00 00 c5 fa 7f 84 24 98 00 00 00 c5 fa 6f 84 24 88 00 00 00 c5 fa 7f 44 24 68 c5 fa 6f 84 24 98 00 00 00 c5 fa 7f 44 24 78 8b 84 24 a8 00 00 00 0f b7 c0 c7 44 24 64 20 00 00 00 0f b6 54 24 64 0f af c2 8b 94 24 aa 00 00 00 0f b7 d2 03 c2 8b 54 24 68 0f b7 d2 c7 44 24 60 20 00 00 00 44 0f b6 44 24 60 41 0f af d0 44 8b 44 24 6a 45 0f b7 c0 41 03 d0 2b c2 85 c0 7d 0a f7 d8 85 c0 0f 8c 89 00 00 00 ff c0 83 f8 20 0f 8f 76 00 00 00 8b 84 24 c8 00 00 00 0f b7 c0 8b 94 24 e8 00 00 00 0f b7 d2 3b c2 0f 94 c0 0f b6 c0 c5 fa 6f 84 24 c8 00 00 00 c5 fa 7f 44 24 40 c5 fa 6f 84 24 d8 00 00 00 c5 fa 7f 44 24 50 8b 54 24 40 0f b7 d2 48 63 d2 8b 14 91 85 c0 75 2b c5 fa 6f 84 24 e8 00 00 00 c5 fa 7f 44 24 20 c5 fa 6f 84 24 f8 00 00 00 c5 fa 7f 44 24 30 8b 44 24 20 0f b7 c0 48 63 c0 8b 04 81 48 81 c4 a8 01 00 00 c3 e8 3f 19 de ff cc}
; Capture completion code, None
0000h sub rsp,1A8h                            ; SUB r/m64, imm32 || REX.W 81 /5 id || encoded[7]{48 81 ec a8 01 00 00}
0007h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
000ah mov r9d,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{44 8b ca}
000dh mov rcx,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 09}
0010h mov dword ptr [rsp+144h],20h            ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[11]{c7 84 24 44 01 00 00 20 00 00 00}
001bh movzx r10d,byte ptr [rsp+144h]          ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[9]{44 0f b6 94 24 44 01 00 00}
0024h mov eax,r9d                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b c1}
0027h xor edx,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d2}
0029h div r10d                                ; DIV r/m32 || o32 F7 /6 || encoded[3]{41 f7 f2}
002ch mov [rsp+140h],eax                      ; MOV r/m32, r32 || o32 89 /r || encoded[7]{89 84 24 40 01 00 00}
0033h movzx r10d,word ptr [rsp+140h]          ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[9]{44 0f b7 94 24 40 01 00 00}
003ch mov dword ptr [rsp+13Ch],20h            ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[11]{c7 84 24 3c 01 00 00 20 00 00 00}
0047h movzx r11d,byte ptr [rsp+13Ch]          ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[9]{44 0f b6 9c 24 3c 01 00 00}
0050h mov eax,r9d                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b c1}
0053h xor edx,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d2}
0055h div r11d                                ; DIV r/m32 || o32 F7 /6 || encoded[3]{41 f7 f3}
0058h mov [rsp+138h],edx                      ; MOV r/m32, r32 || o32 89 /r || encoded[7]{89 94 24 38 01 00 00}
005fh lea rax,[rsp+148h]                      ; LEA r64, m || REX.W 8D /r || encoded[8]{48 8d 84 24 48 01 00 00}
0067h vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
006bh vmovdqu xmmword ptr [rax],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 00}
006fh vmovdqu xmmword ptr [rax+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 10}
0074h movzx eax,byte ptr [rsp+138h]           ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[8]{0f b6 84 24 38 01 00 00}
007ch mov [rsp+148h],r10w                     ; MOV r/m16, r16 || o16 89 /r || encoded[9]{66 44 89 94 24 48 01 00 00}
0085h mov [rsp+14Ah],ax                       ; MOV r/m16, r16 || o16 89 /r || encoded[8]{66 89 84 24 4a 01 00 00}
008dh vmovdqu xmm0,xmmword ptr [rsp+148h]     ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[9]{c5 fa 6f 84 24 48 01 00 00}
0096h vmovdqu xmmword ptr [rsp+188h],xmm0     ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[9]{c5 fa 7f 84 24 88 01 00 00}
009fh vmovdqu xmm0,xmmword ptr [rsp+158h]     ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[9]{c5 fa 6f 84 24 58 01 00 00}
00a8h vmovdqu xmmword ptr [rsp+198h],xmm0     ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[9]{c5 fa 7f 84 24 98 01 00 00}
00b1h mov dword ptr [rsp+114h],20h            ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[11]{c7 84 24 14 01 00 00 20 00 00 00}
00bch movzx r9d,byte ptr [rsp+114h]           ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[9]{44 0f b6 8c 24 14 01 00 00}
00c5h mov eax,r8d                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b c0}
00c8h xor edx,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d2}
00cah div r9d                                 ; DIV r/m32 || o32 F7 /6 || encoded[3]{41 f7 f1}
00cdh mov [rsp+110h],eax                      ; MOV r/m32, r32 || o32 89 /r || encoded[7]{89 84 24 10 01 00 00}
00d4h movzx r9d,word ptr [rsp+110h]           ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[9]{44 0f b7 8c 24 10 01 00 00}
00ddh mov dword ptr [rsp+10Ch],20h            ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[11]{c7 84 24 0c 01 00 00 20 00 00 00}
00e8h movzx r10d,byte ptr [rsp+10Ch]          ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[9]{44 0f b6 94 24 0c 01 00 00}
00f1h mov eax,r8d                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b c0}
00f4h xor edx,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d2}
00f6h div r10d                                ; DIV r/m32 || o32 F7 /6 || encoded[3]{41 f7 f2}
00f9h mov [rsp+108h],edx                      ; MOV r/m32, r32 || o32 89 /r || encoded[7]{89 94 24 08 01 00 00}
0100h lea rax,[rsp+118h]                      ; LEA r64, m || REX.W 8D /r || encoded[8]{48 8d 84 24 18 01 00 00}
0108h vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
010ch vmovdqu xmmword ptr [rax],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 00}
0110h vmovdqu xmmword ptr [rax+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 10}
0115h movzx eax,byte ptr [rsp+108h]           ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[8]{0f b6 84 24 08 01 00 00}
011dh mov [rsp+118h],r9w                      ; MOV r/m16, r16 || o16 89 /r || encoded[9]{66 44 89 8c 24 18 01 00 00}
0126h mov [rsp+11Ah],ax                       ; MOV r/m16, r16 || o16 89 /r || encoded[8]{66 89 84 24 1a 01 00 00}
012eh vmovdqu xmm0,xmmword ptr [rsp+118h]     ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[9]{c5 fa 6f 84 24 18 01 00 00}
0137h vmovdqu xmmword ptr [rsp+168h],xmm0     ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[9]{c5 fa 7f 84 24 68 01 00 00}
0140h vmovdqu xmm0,xmmword ptr [rsp+128h]     ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[9]{c5 fa 6f 84 24 28 01 00 00}
0149h vmovdqu xmmword ptr [rsp+178h],xmm0     ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[9]{c5 fa 7f 84 24 78 01 00 00}
0152h vmovdqu xmm0,xmmword ptr [rsp+188h]     ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[9]{c5 fa 6f 84 24 88 01 00 00}
015bh vmovdqu xmmword ptr [rsp+0C8h],xmm0     ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[9]{c5 fa 7f 84 24 c8 00 00 00}
0164h vmovdqu xmm0,xmmword ptr [rsp+198h]     ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[9]{c5 fa 6f 84 24 98 01 00 00}
016dh vmovdqu xmmword ptr [rsp+0D8h],xmm0     ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[9]{c5 fa 7f 84 24 d8 00 00 00}
0176h vmovdqu xmm0,xmmword ptr [rsp+168h]     ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[9]{c5 fa 6f 84 24 68 01 00 00}
017fh vmovdqu xmmword ptr [rsp+0E8h],xmm0     ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[9]{c5 fa 7f 84 24 e8 00 00 00}
0188h vmovdqu xmm0,xmmword ptr [rsp+178h]     ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[9]{c5 fa 6f 84 24 78 01 00 00}
0191h vmovdqu xmmword ptr [rsp+0F8h],xmm0     ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[9]{c5 fa 7f 84 24 f8 00 00 00}
019ah vmovdqu xmm0,xmmword ptr [rsp+0E8h]     ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[9]{c5 fa 6f 84 24 e8 00 00 00}
01a3h vmovdqu xmmword ptr [rsp+0A8h],xmm0     ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[9]{c5 fa 7f 84 24 a8 00 00 00}
01ach vmovdqu xmm0,xmmword ptr [rsp+0F8h]     ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[9]{c5 fa 6f 84 24 f8 00 00 00}
01b5h vmovdqu xmmword ptr [rsp+0B8h],xmm0     ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[9]{c5 fa 7f 84 24 b8 00 00 00}
01beh vmovdqu xmm0,xmmword ptr [rsp+0C8h]     ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[9]{c5 fa 6f 84 24 c8 00 00 00}
01c7h vmovdqu xmmword ptr [rsp+88h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[9]{c5 fa 7f 84 24 88 00 00 00}
01d0h vmovdqu xmm0,xmmword ptr [rsp+0D8h]     ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[9]{c5 fa 6f 84 24 d8 00 00 00}
01d9h vmovdqu xmmword ptr [rsp+98h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[9]{c5 fa 7f 84 24 98 00 00 00}
01e2h vmovdqu xmm0,xmmword ptr [rsp+88h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[9]{c5 fa 6f 84 24 88 00 00 00}
01ebh vmovdqu xmmword ptr [rsp+68h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[6]{c5 fa 7f 44 24 68}
01f1h vmovdqu xmm0,xmmword ptr [rsp+98h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[9]{c5 fa 6f 84 24 98 00 00 00}
01fah vmovdqu xmmword ptr [rsp+78h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[6]{c5 fa 7f 44 24 78}
0200h mov eax,[rsp+0A8h]                      ; MOV r32, r/m32 || o32 8B /r || encoded[7]{8b 84 24 a8 00 00 00}
0207h movzx eax,ax                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c0}
020ah mov dword ptr [rsp+64h],20h             ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 64 20 00 00 00}
0212h movzx edx,byte ptr [rsp+64h]            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[5]{0f b6 54 24 64}
0217h imul eax,edx                            ; IMUL r32, r/m32 || o32 0F AF /r || encoded[3]{0f af c2}
021ah mov edx,[rsp+0AAh]                      ; MOV r32, r/m32 || o32 8B /r || encoded[7]{8b 94 24 aa 00 00 00}
0221h movzx edx,dx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 d2}
0224h add eax,edx                             ; ADD r32, r/m32 || o32 03 /r || encoded[2]{03 c2}
0226h mov edx,[rsp+68h]                       ; MOV r32, r/m32 || o32 8B /r || encoded[4]{8b 54 24 68}
022ah movzx edx,dx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 d2}
022dh mov dword ptr [rsp+60h],20h             ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 60 20 00 00 00}
0235h movzx r8d,byte ptr [rsp+60h]            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[6]{44 0f b6 44 24 60}
023bh imul edx,r8d                            ; IMUL r32, r/m32 || o32 0F AF /r || encoded[4]{41 0f af d0}
023fh mov r8d,[rsp+6Ah]                       ; MOV r32, r/m32 || o32 8B /r || encoded[5]{44 8b 44 24 6a}
0244h movzx r8d,r8w                           ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[4]{45 0f b7 c0}
0248h add edx,r8d                             ; ADD r32, r/m32 || o32 03 /r || encoded[3]{41 03 d0}
024bh sub eax,edx                             ; SUB r32, r/m32 || o32 2B /r || encoded[2]{2b c2}
024dh test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
024fh jge short 025bh                         ; JGE rel8 || 7D cb || encoded[2]{7d 0a}
0251h neg eax                                 ; NEG r/m32 || o32 F7 /3 || encoded[2]{f7 d8}
0253h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
0255h jl near ptr 02e4h                       ; JL rel32 || 0F 8C cd || encoded[6]{0f 8c 89 00 00 00}
025bh inc eax                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c0}
025dh cmp eax,20h                             ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 f8 20}
0260h jg near ptr 02dch                       ; JG rel32 || 0F 8F cd || encoded[6]{0f 8f 76 00 00 00}
0266h mov eax,[rsp+0C8h]                      ; MOV r32, r/m32 || o32 8B /r || encoded[7]{8b 84 24 c8 00 00 00}
026dh movzx eax,ax                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c0}
0270h mov edx,[rsp+0E8h]                      ; MOV r32, r/m32 || o32 8B /r || encoded[7]{8b 94 24 e8 00 00 00}
0277h movzx edx,dx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 d2}
027ah cmp eax,edx                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b c2}
027ch sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
027fh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0282h vmovdqu xmm0,xmmword ptr [rsp+0C8h]     ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[9]{c5 fa 6f 84 24 c8 00 00 00}
028bh vmovdqu xmmword ptr [rsp+40h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[6]{c5 fa 7f 44 24 40}
0291h vmovdqu xmm0,xmmword ptr [rsp+0D8h]     ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[9]{c5 fa 6f 84 24 d8 00 00 00}
029ah vmovdqu xmmword ptr [rsp+50h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[6]{c5 fa 7f 44 24 50}
02a0h mov edx,[rsp+40h]                       ; MOV r32, r/m32 || o32 8B /r || encoded[4]{8b 54 24 40}
02a4h movzx edx,dx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 d2}
02a7h movsxd rdx,edx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 d2}
02aah mov edx,[rcx+rdx*4]                     ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 14 91}
02adh test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
02afh jne short 02dch                         ; JNE rel8 || 75 cb || encoded[2]{75 2b}
02b1h vmovdqu xmm0,xmmword ptr [rsp+0E8h]     ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[9]{c5 fa 6f 84 24 e8 00 00 00}
02bah vmovdqu xmmword ptr [rsp+20h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[6]{c5 fa 7f 44 24 20}
02c0h vmovdqu xmm0,xmmword ptr [rsp+0F8h]     ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[9]{c5 fa 6f 84 24 f8 00 00 00}
02c9h vmovdqu xmmword ptr [rsp+30h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[6]{c5 fa 7f 44 24 30}
02cfh mov eax,[rsp+20h]                       ; MOV r32, r/m32 || o32 8B /r || encoded[4]{8b 44 24 20}
02d3h movzx eax,ax                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c0}
02d6h movsxd rax,eax                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 c0}
02d9h mov eax,[rcx+rax*4]                     ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 04 81}
02dch add rsp,1A8h                            ; ADD r/m64, imm32 || REX.W 81 /0 id || encoded[7]{48 81 c4 a8 01 00 00}
02e3h ret                                     ; RET || C3 || encoded[1]{c3}
02e4h call 7FF7C817B9E8h                      ; CALL rel32 || E8 cd || encoded[5]{e8 3f 19 de ff}
02e9h int 3                                   ; INT3 || CC || encoded[1]{cc}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
