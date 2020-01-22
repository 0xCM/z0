; 2020-01-22 01:43:39:042
; int cell_count_32x64x8()
; cell_count_32x64x8_59467483[0x7ff7c83830f0, 0x7ff7c8383134][68] = {48 83 ec 28 90 c6 44 24 20 00 48 8d 44 24 20 c6 00 00 c6 44 24 18 00 48 8d 44 24 18 c6 00 00 c6 44 24 08 00 48 8d 44 24 08 c6 00 00 b8 08 00 00 00 c6 04 24 00 48 8d 14 24 c6 02 00 c1 e0 05 48 83 c4 28 c3}
; Capture completion code, None
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov byte ptr [rsp+20h],0                ; MOV r/m8, imm8 || C6 /0 ib || encoded[5]{c6 44 24 20 00}
000ah lea rax,[rsp+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 20}
000fh mov byte ptr [rax],0                    ; MOV r/m8, imm8 || C6 /0 ib || encoded[3]{c6 00 00}
0012h mov byte ptr [rsp+18h],0                ; MOV r/m8, imm8 || C6 /0 ib || encoded[5]{c6 44 24 18 00}
0017h lea rax,[rsp+18h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 18}
001ch mov byte ptr [rax],0                    ; MOV r/m8, imm8 || C6 /0 ib || encoded[3]{c6 00 00}
001fh mov byte ptr [rsp+8],0                  ; MOV r/m8, imm8 || C6 /0 ib || encoded[5]{c6 44 24 08 00}
0024h lea rax,[rsp+8]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 08}
0029h mov byte ptr [rax],0                    ; MOV r/m8, imm8 || C6 /0 ib || encoded[3]{c6 00 00}
002ch mov eax,8                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 08 00 00 00}
0031h mov byte ptr [rsp],0                    ; MOV r/m8, imm8 || C6 /0 ib || encoded[4]{c6 04 24 00}
0035h lea rdx,[rsp]                           ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 14 24}
0039h mov byte ptr [rdx],0                    ; MOV r/m8, imm8 || C6 /0 ib || encoded[3]{c6 02 00}
003ch shl eax,5                               ; SHL r/m32, imm8 || o32 C1 /4 ib || encoded[3]{c1 e0 05}
003fh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0043h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; TableIndex tableindex_32x64x8(int row, int col)
; tableindex_32x64x8_32i[0x7ff7c8383150, 0x7ff7c838323f][239] = {57 56 48 83 ec 58 c5 f8 77 c6 44 24 50 00 48 8d 44 24 50 c6 00 00 c6 44 24 48 00 48 8d 44 24 48 c6 00 00 c6 44 24 38 00 48 8d 44 24 38 c6 00 00 b8 08 00 00 00 89 44 24 34 0f b7 44 24 34 44 8b c8 44 0f af ca 45 8b d0 41 c1 fa 1f 41 83 e2 07 45 03 d0 41 c1 fa 03 4d 63 d2 45 8b d9 4d 03 d3 4c 89 54 24 28 44 0f b7 54 24 28 45 8b d8 41 c1 fb 1f 41 83 e3 07 45 03 d8 41 83 e3 f8 41 8b f0 41 2b f3 89 74 24 24 44 0f b6 5c 24 24 45 8b c9 49 63 f0 4c 03 ce 4c 89 4c 24 18 44 8b 4c 24 18 33 f6 48 8d 3c 24 c5 f8 57 c0 c5 fa 7f 07 89 77 10 45 0f b7 d2 66 44 89 14 24 66 89 44 24 02 41 0f b6 c3 88 44 24 04 89 54 24 0c 44 89 44 24 10 44 89 4c 24 08 c5 fa 6f 04 24 c5 fa 7f 01 8b 44 24 10 89 41 10 48 8b c1 48 83 c4 58 5e 5f c3}
; Capture completion code, None
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h sub rsp,58h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 58}
0006h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0009h mov byte ptr [rsp+50h],0                ; MOV r/m8, imm8 || C6 /0 ib || encoded[5]{c6 44 24 50 00}
000eh lea rax,[rsp+50h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 50}
0013h mov byte ptr [rax],0                    ; MOV r/m8, imm8 || C6 /0 ib || encoded[3]{c6 00 00}
0016h mov byte ptr [rsp+48h],0                ; MOV r/m8, imm8 || C6 /0 ib || encoded[5]{c6 44 24 48 00}
001bh lea rax,[rsp+48h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 48}
0020h mov byte ptr [rax],0                    ; MOV r/m8, imm8 || C6 /0 ib || encoded[3]{c6 00 00}
0023h mov byte ptr [rsp+38h],0                ; MOV r/m8, imm8 || C6 /0 ib || encoded[5]{c6 44 24 38 00}
0028h lea rax,[rsp+38h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 38}
002dh mov byte ptr [rax],0                    ; MOV r/m8, imm8 || C6 /0 ib || encoded[3]{c6 00 00}
0030h mov eax,8                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 08 00 00 00}
0035h mov [rsp+34h],eax                       ; MOV r/m32, r32 || o32 89 /r || encoded[4]{89 44 24 34}
0039h movzx eax,word ptr [rsp+34h]            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[5]{0f b7 44 24 34}
003eh mov r9d,eax                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{44 8b c8}
0041h imul r9d,edx                            ; IMUL r32, r/m32 || o32 0F AF /r || encoded[4]{44 0f af ca}
0045h mov r10d,r8d                            ; MOV r32, r/m32 || o32 8B /r || encoded[3]{45 8b d0}
0048h sar r10d,1Fh                            ; SAR r/m32, imm8 || o32 C1 /7 ib || encoded[4]{41 c1 fa 1f}
004ch and r10d,7                              ; AND r/m32, imm8 || o32 83 /4 ib || encoded[4]{41 83 e2 07}
0050h add r10d,r8d                            ; ADD r32, r/m32 || o32 03 /r || encoded[3]{45 03 d0}
0053h sar r10d,3                              ; SAR r/m32, imm8 || o32 C1 /7 ib || encoded[4]{41 c1 fa 03}
0057h movsxd r10,r10d                         ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4d 63 d2}
005ah mov r11d,r9d                            ; MOV r32, r/m32 || o32 8B /r || encoded[3]{45 8b d9}
005dh add r10,r11                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{4d 03 d3}
0060h mov [rsp+28h],r10                       ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{4c 89 54 24 28}
0065h movzx r10d,word ptr [rsp+28h]           ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[6]{44 0f b7 54 24 28}
006bh mov r11d,r8d                            ; MOV r32, r/m32 || o32 8B /r || encoded[3]{45 8b d8}
006eh sar r11d,1Fh                            ; SAR r/m32, imm8 || o32 C1 /7 ib || encoded[4]{41 c1 fb 1f}
0072h and r11d,7                              ; AND r/m32, imm8 || o32 83 /4 ib || encoded[4]{41 83 e3 07}
0076h add r11d,r8d                            ; ADD r32, r/m32 || o32 03 /r || encoded[3]{45 03 d8}
0079h and r11d,0FFFFFFF8h                     ; AND r/m32, imm8 || o32 83 /4 ib || encoded[4]{41 83 e3 f8}
007dh mov esi,r8d                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b f0}
0080h sub esi,r11d                            ; SUB r32, r/m32 || o32 2B /r || encoded[3]{41 2b f3}
0083h mov [rsp+24h],esi                       ; MOV r/m32, r32 || o32 89 /r || encoded[4]{89 74 24 24}
0087h movzx r11d,byte ptr [rsp+24h]           ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[6]{44 0f b6 5c 24 24}
008dh mov r9d,r9d                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{45 8b c9}
0090h movsxd rsi,r8d                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{49 63 f0}
0093h add r9,rsi                              ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{4c 03 ce}
0096h mov [rsp+18h],r9                        ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{4c 89 4c 24 18}
009bh mov r9d,[rsp+18h]                       ; MOV r32, r/m32 || o32 8B /r || encoded[5]{44 8b 4c 24 18}
00a0h xor esi,esi                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 f6}
00a2h lea rdi,[rsp]                           ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 3c 24}
00a6h vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
00aah vmovdqu xmmword ptr [rdi],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 07}
00aeh mov [rdi+10h],esi                       ; MOV r/m32, r32 || o32 89 /r || encoded[3]{89 77 10}
00b1h movzx r10d,r10w                         ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[4]{45 0f b7 d2}
00b5h mov [rsp],r10w                          ; MOV r/m16, r16 || o16 89 /r || encoded[5]{66 44 89 14 24}
00bah mov [rsp+2],ax                          ; MOV r/m16, r16 || o16 89 /r || encoded[5]{66 89 44 24 02}
00bfh movzx eax,r11b                          ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{41 0f b6 c3}
00c3h mov [rsp+4],al                          ; MOV r/m8, r8 || 88 /r || encoded[4]{88 44 24 04}
00c7h mov [rsp+0Ch],edx                       ; MOV r/m32, r32 || o32 89 /r || encoded[4]{89 54 24 0c}
00cbh mov [rsp+10h],r8d                       ; MOV r/m32, r32 || o32 89 /r || encoded[5]{44 89 44 24 10}
00d0h mov [rsp+8],r9d                         ; MOV r/m32, r32 || o32 89 /r || encoded[5]{44 89 4c 24 08}
00d5h vmovdqu xmm0,xmmword ptr [rsp]          ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[5]{c5 fa 6f 04 24}
00dah vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}
00deh mov eax,[rsp+10h]                       ; MOV r32, r/m32 || o32 8B /r || encoded[4]{8b 44 24 10}
00e2h mov [rcx+10h],eax                       ; MOV r/m32, r32 || o32 89 /r || encoded[3]{89 41 10}
00e5h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
00e8h add rsp,58h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 58}
00ech pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
00edh pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
00eeh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
