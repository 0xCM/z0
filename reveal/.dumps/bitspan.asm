; 2020-01-20 01:59:20:855
; BitSpan load_scalar_8(byte src)
; static ReadOnlySpan<byte> load_scalar_8_8uBytes => new byte[224]{0x57,0x56,0x53,0x48,0x81,0xEC,0x80,0x00,0x00,0x00,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0x48,0x8D,0x7C,0x24,0x28,0xB9,0x16,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0x48,0x8B,0xD9,0x0F,0xB6,0xC2,0x33,0xD2,0x48,0x89,0x54,0x24,0x58,0x48,0x8D,0x54,0x24,0x38,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x02,0xC5,0xFA,0x7F,0x42,0x10,0x33,0xD2,0x48,0x89,0x54,0x24,0x58,0x48,0x8D,0x54,0x24,0x58,0x48,0x8D,0x4C,0x24,0x38,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x7F,0x41,0x10,0x48,0x8D,0x4C,0x24,0x38,0x8B,0xC0,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xC2,0xFB,0xF5,0xC0,0x48,0x89,0x02,0xC4,0xE2,0x7D,0x31,0x02,0xC5,0xFE,0x7F,0x01,0x48,0x8D,0x44,0x24,0x38,0xBA,0x08,0x00,0x00,0x00,0x48,0x8D,0x4C,0x24,0x28,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0x48,0x8D,0x4C,0x24,0x28,0x48,0x89,0x01,0x89,0x51,0x08,0xC5,0xFA,0x6F,0x44,0x24,0x28,0xC5,0xFA,0x7F,0x44,0x24,0x60,0xC5,0xFA,0x6F,0x44,0x24,0x60,0xC5,0xFA,0x7F,0x44,0x24,0x70,0x48,0x8B,0xFB,0x48,0x8D,0x74,0x24,0x70,0xE8,0xF9,0xBB,0x60,0x5F,0x48,0xA5,0x48,0x8B,0xC3,0xC5,0xF8,0x77,0x48,0x81,0xC4,0x80,0x00,0x00,0x00,0x5B,0x5E,0x5F,0xC3,0xE8,0x71,0x59,0x73,0x5F,0xCC};
; [0x7ff7c838a1d0, 0x7ff7c838a2b0], 224 bytes
; 2020-01-20 01:59:20:855
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h sub rsp,80h                             ; SUB r/m64, imm32 || REX.W 81 /5 id || encoded[7]{48 81 ec 80 00 00 00}
000ah vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
000dh mov rsi,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f1}
0010h lea rdi,[rsp+28h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 7c 24 28}
0015h mov ecx,16h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b9 16 00 00 00}
001ah xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
001ch rep stosd                               ; STOSD || o32 AB || encoded[2]{f3 ab}
001eh mov rcx,rsi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b ce}
0021h mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
0024h movzx eax,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c2}
0027h xor edx,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d2}
0029h mov [rsp+58h],rdx                       ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 54 24 58}
002eh lea rdx,[rsp+38h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 54 24 38}
0033h vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
0037h vmovdqu xmmword ptr [rdx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 02}
003bh vmovdqu xmmword ptr [rdx+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 42 10}
0040h xor edx,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d2}
0042h mov [rsp+58h],rdx                       ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 54 24 58}
0047h lea rdx,[rsp+58h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 54 24 58}
004ch lea rcx,[rsp+38h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 4c 24 38}
0051h vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
0055h vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}
0059h vmovdqu xmmword ptr [rcx+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 10}
005eh lea rcx,[rsp+38h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 4c 24 38}
0063h mov eax,eax                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c0}
0065h mov r8,101010101010101h                 ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 b8 01 01 01 01 01 01 01 01}
006fh pdep rax,rax,r8                         ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 c2 fb f5 c0}
0074h mov [rdx],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 02}
0077h vpmovzxbd ymm0,qword ptr [rdx]          ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 02}
007ch vmovdqu ymmword ptr [rcx],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 01}
0080h lea rax,[rsp+38h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 38}
0085h mov edx,8                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 08 00 00 00}
008ah lea rcx,[rsp+28h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 4c 24 28}
008fh vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
0093h vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}
0097h lea rcx,[rsp+28h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 4c 24 28}
009ch mov [rcx],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 01}
009fh mov [rcx+8],edx                         ; MOV r/m32, r32 || o32 89 /r || encoded[3]{89 51 08}
00a2h vmovdqu xmm0,xmmword ptr [rsp+28h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[6]{c5 fa 6f 44 24 28}
00a8h vmovdqu xmmword ptr [rsp+60h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[6]{c5 fa 7f 44 24 60}
00aeh vmovdqu xmm0,xmmword ptr [rsp+60h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[6]{c5 fa 6f 44 24 60}
00b4h vmovdqu xmmword ptr [rsp+70h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[6]{c5 fa 7f 44 24 70}
00bah mov rdi,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fb}
00bdh lea rsi,[rsp+70h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 74 24 70}
00c2h call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 f9 bb 60 5f}
00c7h movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
00c9h mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
00cch vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
00cfh add rsp,80h                             ; ADD r/m64, imm32 || REX.W 81 /0 id || encoded[7]{48 81 c4 80 00 00 00}
00d6h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
00d7h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
00d8h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
00d9h ret                                     ; RET || C3 || encoded[1]{c3}
00dah call 7FF827ABFC20h                      ; CALL rel32 || E8 cd || encoded[5]{e8 71 59 73 5f}
00dfh int 3                                   ; INT3 || CC || encoded[1]{cc}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitSpan load_scalar_8_fill(byte src, in BitSpan dst)
; static ReadOnlySpan<byte> load_scalar_8_fill_20228817Bytes => new byte[92]{0x57,0x56,0x53,0x48,0x83,0xEC,0x10,0xC5,0xF8,0x77,0x48,0x8B,0xD9,0x0F,0xB6,0xC2,0x33,0xD2,0x48,0x89,0x54,0x24,0x08,0x48,0x89,0x54,0x24,0x08,0x48,0x8D,0x54,0x24,0x08,0x49,0x8B,0x08,0x8B,0xC0,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xC2,0xFB,0xF5,0xC1,0x48,0x89,0x02,0xC4,0xE2,0x7D,0x31,0x02,0xC5,0xFE,0x7F,0x01,0x48,0x8B,0xFB,0x49,0x8B,0xF0,0xE8,0x64,0xBB,0x60,0x5F,0x48,0xA5,0x48,0x8B,0xC3,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x10,0x5B,0x5E,0x5F,0xC3};
; [0x7ff7c838a2e0, 0x7ff7c838a33c], 92 bytes
; 2020-01-20 01:59:20:856
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h sub rsp,10h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 10}
0007h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
000ah mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
000dh movzx eax,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c2}
0010h xor edx,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d2}
0012h mov [rsp+8],rdx                         ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 54 24 08}
0017h mov [rsp+8],rdx                         ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 54 24 08}
001ch lea rdx,[rsp+8]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 54 24 08}
0021h mov rcx,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b 08}
0024h mov eax,eax                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c0}
0026h mov r9,101010101010101h                 ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 b9 01 01 01 01 01 01 01 01}
0030h pdep rax,rax,r9                         ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 c2 fb f5 c1}
0035h mov [rdx],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 02}
0038h vpmovzxbd ymm0,qword ptr [rdx]          ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 02}
003dh vmovdqu ymmword ptr [rcx],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 01}
0041h mov rdi,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fb}
0044h mov rsi,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b f0}
0047h call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 64 bb 60 5f}
004ch movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
004eh mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
0051h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0054h add rsp,10h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 10}
0058h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
0059h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
005ah pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
005bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitSpan load_scalar_16(ushort src)
; static ReadOnlySpan<byte> load_scalar_16_16uBytes => new byte[309]{0x57,0x56,0x53,0x48,0x81,0xEC,0xA0,0x00,0x00,0x00,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0x48,0x8D,0x7C,0x24,0x20,0xB9,0x20,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0x48,0x8B,0xD9,0x0F,0xB7,0xC2,0x33,0xD2,0x48,0x89,0x54,0x24,0x70,0x48,0x89,0x54,0x24,0x78,0x48,0x8D,0x54,0x24,0x30,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x02,0xC5,0xFA,0x7F,0x42,0x10,0xC5,0xFA,0x7F,0x42,0x20,0xC5,0xFA,0x7F,0x42,0x30,0x33,0xD2,0x48,0x89,0x54,0x24,0x70,0x48,0x89,0x54,0x24,0x78,0x48,0x8D,0x54,0x24,0x70,0x48,0x8D,0x4C,0x24,0x30,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x7F,0x41,0x10,0xC5,0xFA,0x7F,0x41,0x20,0xC5,0xFA,0x7F,0x41,0x30,0x48,0x8D,0x4C,0x24,0x30,0x44,0x0F,0xB6,0xC0,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x4C,0x8D,0x42,0x08,0xC1,0xF8,0x08,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC1,0x49,0x89,0x00,0x48,0x8B,0xC2,0xC4,0xE2,0x7D,0x31,0x00,0x48,0x8B,0xC1,0xC5,0xFE,0x7F,0x00,0x48,0x83,0xC2,0x08,0xC4,0xE2,0x7D,0x31,0x02,0x48,0x83,0xC1,0x20,0xC5,0xFE,0x7F,0x01,0x48,0x8D,0x44,0x24,0x30,0xBA,0x10,0x00,0x00,0x00,0x48,0x8D,0x4C,0x24,0x20,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x01,0x89,0x51,0x08,0xC5,0xFA,0x6F,0x44,0x24,0x20,0xC5,0xFA,0x7F,0x84,0x24,0x80,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0x80,0x00,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0x90,0x00,0x00,0x00,0x48,0x8B,0xFB,0x48,0x8D,0xB4,0x24,0x90,0x00,0x00,0x00,0xE8,0x14,0xB6,0x60,0x5F,0x48,0xA5,0x48,0x8B,0xC3,0xC5,0xF8,0x77,0x48,0x81,0xC4,0xA0,0x00,0x00,0x00,0x5B,0x5E,0x5F,0xC3,0xE8,0x8C,0x53,0x73,0x5F,0xCC};
; [0x7ff7c838a760, 0x7ff7c838a895], 309 bytes
; 2020-01-20 01:59:20:859
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h sub rsp,0A0h                            ; SUB r/m64, imm32 || REX.W 81 /5 id || encoded[7]{48 81 ec a0 00 00 00}
000ah vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
000dh mov rsi,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f1}
0010h lea rdi,[rsp+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 7c 24 20}
0015h mov ecx,20h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b9 20 00 00 00}
001ah xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
001ch rep stosd                               ; STOSD || o32 AB || encoded[2]{f3 ab}
001eh mov rcx,rsi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b ce}
0021h mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
0024h movzx eax,dx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c2}
0027h xor edx,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d2}
0029h mov [rsp+70h],rdx                       ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 54 24 70}
002eh mov [rsp+78h],rdx                       ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 54 24 78}
0033h lea rdx,[rsp+30h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 54 24 30}
0038h vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
003ch vmovdqu xmmword ptr [rdx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 02}
0040h vmovdqu xmmword ptr [rdx+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 42 10}
0045h vmovdqu xmmword ptr [rdx+20h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 42 20}
004ah vmovdqu xmmword ptr [rdx+30h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 42 30}
004fh xor edx,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d2}
0051h mov [rsp+70h],rdx                       ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 54 24 70}
0056h mov [rsp+78h],rdx                       ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 54 24 78}
005bh lea rdx,[rsp+70h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 54 24 70}
0060h lea rcx,[rsp+30h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 4c 24 30}
0065h vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
0069h vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}
006dh vmovdqu xmmword ptr [rcx+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 10}
0072h vmovdqu xmmword ptr [rcx+20h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 20}
0077h vmovdqu xmmword ptr [rcx+30h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 30}
007ch lea rcx,[rsp+30h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 4c 24 30}
0081h movzx r8d,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{44 0f b6 c0}
0085h mov r9,101010101010101h                 ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 b9 01 01 01 01 01 01 01 01}
008fh pdep r8,r8,r9                           ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 42 bb f5 c1}
0094h mov [rdx],r8                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 02}
0097h lea r8,[rdx+8]                          ; LEA r64, m || REX.W 8D /r || encoded[4]{4c 8d 42 08}
009bh sar eax,8                               ; SAR r/m32, imm8 || o32 C1 /7 ib || encoded[3]{c1 f8 08}
009eh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
00a1h pdep rax,rax,r9                         ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 c2 fb f5 c1}
00a6h mov [r8],rax                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 00}
00a9h mov rax,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c2}
00ach vpmovzxbd ymm0,qword ptr [rax]          ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 00}
00b1h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
00b4h vmovdqu ymmword ptr [rax],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 00}
00b8h add rdx,8                               ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c2 08}
00bch vpmovzxbd ymm0,qword ptr [rdx]          ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 02}
00c1h add rcx,20h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c1 20}
00c5h vmovdqu ymmword ptr [rcx],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 01}
00c9h lea rax,[rsp+30h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 30}
00ceh mov edx,10h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 10 00 00 00}
00d3h lea rcx,[rsp+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 4c 24 20}
00d8h vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
00dch vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}
00e0h lea rcx,[rsp+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 4c 24 20}
00e5h mov [rcx],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 01}
00e8h mov [rcx+8],edx                         ; MOV r/m32, r32 || o32 89 /r || encoded[3]{89 51 08}
00ebh vmovdqu xmm0,xmmword ptr [rsp+20h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[6]{c5 fa 6f 44 24 20}
00f1h vmovdqu xmmword ptr [rsp+80h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[9]{c5 fa 7f 84 24 80 00 00 00}
00fah vmovdqu xmm0,xmmword ptr [rsp+80h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[9]{c5 fa 6f 84 24 80 00 00 00}
0103h vmovdqu xmmword ptr [rsp+90h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[9]{c5 fa 7f 84 24 90 00 00 00}
010ch mov rdi,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fb}
010fh lea rsi,[rsp+90h]                       ; LEA r64, m || REX.W 8D /r || encoded[8]{48 8d b4 24 90 00 00 00}
0117h call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 14 b6 60 5f}
011ch movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
011eh mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
0121h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0124h add rsp,0A0h                            ; ADD r/m64, imm32 || REX.W 81 /0 id || encoded[7]{48 81 c4 a0 00 00 00}
012bh pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
012ch pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
012dh pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
012eh ret                                     ; RET || C3 || encoded[1]{c3}
012fh call 7FF827ABFC20h                      ; CALL rel32 || E8 cd || encoded[5]{e8 8c 53 73 5f}
0134h int 3                                   ; INT3 || CC || encoded[1]{cc}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitSpan load_scalar_16_fill(ushort src, in BitSpan dst)
; static ReadOnlySpan<byte> load_scalar_16_fill_47841633Bytes => new byte[142]{0x57,0x56,0x53,0x48,0x83,0xEC,0x10,0xC5,0xF8,0x77,0x48,0x8B,0xD9,0x0F,0xB7,0xC2,0x33,0xD2,0x48,0x89,0x14,0x24,0x48,0x89,0x54,0x24,0x08,0x48,0x89,0x14,0x24,0x48,0x89,0x54,0x24,0x08,0x48,0x8D,0x14,0x24,0x49,0x8B,0x08,0x44,0x0F,0xB6,0xC8,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB3,0xF5,0xCA,0x4C,0x89,0x0A,0x4C,0x8D,0x4A,0x08,0xC1,0xF8,0x08,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC2,0x49,0x89,0x01,0x48,0x8B,0xC2,0xC4,0xE2,0x7D,0x31,0x00,0x48,0x8B,0xC1,0xC5,0xFE,0x7F,0x00,0x48,0x83,0xC2,0x08,0xC4,0xE2,0x7D,0x31,0x02,0x48,0x83,0xC1,0x20,0xC5,0xFE,0x7F,0x01,0x48,0x8B,0xFB,0x49,0x8B,0xF0,0xE8,0x42,0xB5,0x60,0x5F,0x48,0xA5,0x48,0x8B,0xC3,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x10,0x5B,0x5E,0x5F,0xC3};
; [0x7ff7c838a8d0, 0x7ff7c838a95e], 142 bytes
; 2020-01-20 01:59:20:859
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h sub rsp,10h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 10}
0007h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
000ah mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
000dh movzx eax,dx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c2}
0010h xor edx,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d2}
0012h mov [rsp],rdx                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[4]{48 89 14 24}
0016h mov [rsp+8],rdx                         ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 54 24 08}
001bh mov [rsp],rdx                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[4]{48 89 14 24}
001fh mov [rsp+8],rdx                         ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 54 24 08}
0024h lea rdx,[rsp]                           ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 14 24}
0028h mov rcx,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b 08}
002bh movzx r9d,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{44 0f b6 c8}
002fh mov r10,101010101010101h                ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 ba 01 01 01 01 01 01 01 01}
0039h pdep r9,r9,r10                          ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 42 b3 f5 ca}
003eh mov [rdx],r9                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 0a}
0041h lea r9,[rdx+8]                          ; LEA r64, m || REX.W 8D /r || encoded[4]{4c 8d 4a 08}
0045h sar eax,8                               ; SAR r/m32, imm8 || o32 C1 /7 ib || encoded[3]{c1 f8 08}
0048h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
004bh pdep rax,rax,r10                        ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 c2 fb f5 c2}
0050h mov [r9],rax                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 01}
0053h mov rax,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c2}
0056h vpmovzxbd ymm0,qword ptr [rax]          ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 00}
005bh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
005eh vmovdqu ymmword ptr [rax],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 00}
0062h add rdx,8                               ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c2 08}
0066h vpmovzxbd ymm0,qword ptr [rdx]          ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 02}
006bh add rcx,20h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c1 20}
006fh vmovdqu ymmword ptr [rcx],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 01}
0073h mov rdi,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fb}
0076h mov rsi,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b f0}
0079h call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 42 b5 60 5f}
007eh movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
0080h mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
0083h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0086h add rsp,10h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 10}
008ah pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
008bh pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
008ch pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
008dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitSpan load_scalar_32(uint src)
; static ReadOnlySpan<byte> load_scalar_32_32uBytes => new byte[457]{0x57,0x56,0x53,0x48,0x81,0xEC,0xF0,0x00,0x00,0x00,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0x48,0x8D,0x7C,0x24,0x20,0xB9,0x34,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0x48,0x8B,0xD9,0x48,0x8D,0x84,0x24,0xB0,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x7F,0x40,0x10,0x48,0x8D,0x44,0x24,0x30,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x7F,0x40,0x10,0xC5,0xFA,0x7F,0x40,0x20,0xC5,0xFA,0x7F,0x40,0x30,0xC5,0xFA,0x7F,0x40,0x40,0xC5,0xFA,0x7F,0x40,0x50,0xC5,0xFA,0x7F,0x40,0x60,0xC5,0xFA,0x7F,0x40,0x70,0x48,0x8D,0x84,0x24,0xB0,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x7F,0x40,0x10,0x48,0x8D,0x84,0x24,0xB0,0x00,0x00,0x00,0x48,0x8D,0x4C,0x24,0x30,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x7F,0x41,0x10,0xC5,0xFA,0x7F,0x41,0x20,0xC5,0xFA,0x7F,0x41,0x30,0xC5,0xFA,0x7F,0x41,0x40,0xC5,0xFA,0x7F,0x41,0x50,0xC5,0xFA,0x7F,0x41,0x60,0xC5,0xFA,0x7F,0x41,0x70,0x48,0x8D,0x4C,0x24,0x30,0x44,0x0F,0xB6,0xC2,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x00,0x4C,0x8D,0x40,0x08,0x44,0x8B,0xCA,0x41,0xC1,0xE9,0x08,0x45,0x0F,0xB6,0xC9,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB3,0xF5,0xCA,0x4D,0x89,0x08,0x4C,0x8D,0x40,0x10,0x44,0x8B,0xCA,0x41,0xC1,0xE9,0x10,0x45,0x0F,0xB6,0xC9,0xC4,0x42,0xB3,0xF5,0xCA,0x4D,0x89,0x08,0x4C,0x8D,0x40,0x18,0xC1,0xEA,0x18,0x0F,0xB6,0xD2,0xC4,0xC2,0xEB,0xF5,0xD2,0x49,0x89,0x10,0x48,0x8B,0xD0,0xC4,0xE2,0x7D,0x31,0x02,0x48,0x8B,0xD1,0xC5,0xFE,0x7F,0x02,0x48,0x8D,0x50,0x08,0xC4,0xE2,0x7D,0x31,0x02,0x48,0x8D,0x51,0x20,0xC5,0xFE,0x7F,0x02,0x48,0x8D,0x50,0x10,0xC4,0xE2,0x7D,0x31,0x02,0x48,0x8D,0x51,0x40,0xC5,0xFE,0x7F,0x02,0x48,0x83,0xC0,0x18,0xC4,0xE2,0x7D,0x31,0x00,0x48,0x83,0xC1,0x60,0xC5,0xFE,0x7F,0x01,0x48,0x8D,0x44,0x24,0x30,0xBA,0x20,0x00,0x00,0x00,0x48,0x8D,0x4C,0x24,0x20,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x01,0x89,0x51,0x08,0xC5,0xFA,0x6F,0x44,0x24,0x20,0xC5,0xFA,0x7F,0x84,0x24,0xD0,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0xD0,0x00,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0xE0,0x00,0x00,0x00,0x48,0x8B,0xFB,0x48,0x8D,0xB4,0x24,0xE0,0x00,0x00,0x00,0xE8,0x60,0xB3,0x60,0x5F,0x48,0xA5,0x48,0x8B,0xC3,0xC5,0xF8,0x77,0x48,0x81,0xC4,0xF0,0x00,0x00,0x00,0x5B,0x5E,0x5F,0xC3,0xE8,0xD8,0x50,0x73,0x5F,0xCC};
; [0x7ff7c838a980, 0x7ff7c838ab49], 457 bytes
; 2020-01-20 01:59:20:859
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h sub rsp,0F0h                            ; SUB r/m64, imm32 || REX.W 81 /5 id || encoded[7]{48 81 ec f0 00 00 00}
000ah vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
000dh mov rsi,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f1}
0010h lea rdi,[rsp+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 7c 24 20}
0015h mov ecx,34h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b9 34 00 00 00}
001ah xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
001ch rep stosd                               ; STOSD || o32 AB || encoded[2]{f3 ab}
001eh mov rcx,rsi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b ce}
0021h mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
0024h lea rax,[rsp+0B0h]                      ; LEA r64, m || REX.W 8D /r || encoded[8]{48 8d 84 24 b0 00 00 00}
002ch vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
0030h vmovdqu xmmword ptr [rax],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 00}
0034h vmovdqu xmmword ptr [rax+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 10}
0039h lea rax,[rsp+30h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 30}
003eh vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
0042h vmovdqu xmmword ptr [rax],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 00}
0046h vmovdqu xmmword ptr [rax+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 10}
004bh vmovdqu xmmword ptr [rax+20h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 20}
0050h vmovdqu xmmword ptr [rax+30h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 30}
0055h vmovdqu xmmword ptr [rax+40h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 40}
005ah vmovdqu xmmword ptr [rax+50h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 50}
005fh vmovdqu xmmword ptr [rax+60h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 60}
0064h vmovdqu xmmword ptr [rax+70h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 70}
0069h lea rax,[rsp+0B0h]                      ; LEA r64, m || REX.W 8D /r || encoded[8]{48 8d 84 24 b0 00 00 00}
0071h vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
0075h vmovdqu xmmword ptr [rax],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 00}
0079h vmovdqu xmmword ptr [rax+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 40 10}
007eh lea rax,[rsp+0B0h]                      ; LEA r64, m || REX.W 8D /r || encoded[8]{48 8d 84 24 b0 00 00 00}
0086h lea rcx,[rsp+30h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 4c 24 30}
008bh vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
008fh vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}
0093h vmovdqu xmmword ptr [rcx+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 10}
0098h vmovdqu xmmword ptr [rcx+20h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 20}
009dh vmovdqu xmmword ptr [rcx+30h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 30}
00a2h vmovdqu xmmword ptr [rcx+40h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 40}
00a7h vmovdqu xmmword ptr [rcx+50h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 50}
00ach vmovdqu xmmword ptr [rcx+60h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 60}
00b1h vmovdqu xmmword ptr [rcx+70h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 70}
00b6h lea rcx,[rsp+30h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 4c 24 30}
00bbh movzx r8d,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{44 0f b6 c2}
00bfh mov r9,101010101010101h                 ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 b9 01 01 01 01 01 01 01 01}
00c9h pdep r8,r8,r9                           ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 42 bb f5 c1}
00ceh mov [rax],r8                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 00}
00d1h lea r8,[rax+8]                          ; LEA r64, m || REX.W 8D /r || encoded[4]{4c 8d 40 08}
00d5h mov r9d,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{44 8b ca}
00d8h shr r9d,8                               ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[4]{41 c1 e9 08}
00dch movzx r9d,r9b                           ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{45 0f b6 c9}
00e0h mov r10,101010101010101h                ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 ba 01 01 01 01 01 01 01 01}
00eah pdep r9,r9,r10                          ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 42 b3 f5 ca}
00efh mov [r8],r9                             ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4d 89 08}
00f2h lea r8,[rax+10h]                        ; LEA r64, m || REX.W 8D /r || encoded[4]{4c 8d 40 10}
00f6h mov r9d,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{44 8b ca}
00f9h shr r9d,10h                             ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[4]{41 c1 e9 10}
00fdh movzx r9d,r9b                           ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{45 0f b6 c9}
0101h pdep r9,r9,r10                          ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 42 b3 f5 ca}
0106h mov [r8],r9                             ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4d 89 08}
0109h lea r8,[rax+18h]                        ; LEA r64, m || REX.W 8D /r || encoded[4]{4c 8d 40 18}
010dh shr edx,18h                             ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[3]{c1 ea 18}
0110h movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
0113h pdep rdx,rdx,r10                        ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 c2 eb f5 d2}
0118h mov [r8],rdx                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 10}
011bh mov rdx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d0}
011eh vpmovzxbd ymm0,qword ptr [rdx]          ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 02}
0123h mov rdx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d1}
0126h vmovdqu ymmword ptr [rdx],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 02}
012ah lea rdx,[rax+8]                         ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 50 08}
012eh vpmovzxbd ymm0,qword ptr [rdx]          ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 02}
0133h lea rdx,[rcx+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 51 20}
0137h vmovdqu ymmword ptr [rdx],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 02}
013bh lea rdx,[rax+10h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 50 10}
013fh vpmovzxbd ymm0,qword ptr [rdx]          ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 02}
0144h lea rdx,[rcx+40h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 51 40}
0148h vmovdqu ymmword ptr [rdx],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 02}
014ch add rax,18h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c0 18}
0150h vpmovzxbd ymm0,qword ptr [rax]          ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 00}
0155h add rcx,60h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c1 60}
0159h vmovdqu ymmword ptr [rcx],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 01}
015dh lea rax,[rsp+30h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 30}
0162h mov edx,20h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 20 00 00 00}
0167h lea rcx,[rsp+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 4c 24 20}
016ch vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
0170h vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}
0174h lea rcx,[rsp+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 4c 24 20}
0179h mov [rcx],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 01}
017ch mov [rcx+8],edx                         ; MOV r/m32, r32 || o32 89 /r || encoded[3]{89 51 08}
017fh vmovdqu xmm0,xmmword ptr [rsp+20h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[6]{c5 fa 6f 44 24 20}
0185h vmovdqu xmmword ptr [rsp+0D0h],xmm0     ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[9]{c5 fa 7f 84 24 d0 00 00 00}
018eh vmovdqu xmm0,xmmword ptr [rsp+0D0h]     ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[9]{c5 fa 6f 84 24 d0 00 00 00}
0197h vmovdqu xmmword ptr [rsp+0E0h],xmm0     ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[9]{c5 fa 7f 84 24 e0 00 00 00}
01a0h mov rdi,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fb}
01a3h lea rsi,[rsp+0E0h]                      ; LEA r64, m || REX.W 8D /r || encoded[8]{48 8d b4 24 e0 00 00 00}
01abh call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 60 b3 60 5f}
01b0h movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
01b2h mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
01b5h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
01b8h add rsp,0F0h                            ; ADD r/m64, imm32 || REX.W 81 /0 id || encoded[7]{48 81 c4 f0 00 00 00}
01bfh pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
01c0h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
01c1h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
01c2h ret                                     ; RET || C3 || encoded[1]{c3}
01c3h call 7FF827ABFC20h                      ; CALL rel32 || E8 cd || encoded[5]{e8 d8 50 73 5f}
01c8h int 3                                   ; INT3 || CC || encoded[1]{cc}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitSpan load_scalar_32_fill(uint src, in BitSpan dst)
; static ReadOnlySpan<byte> load_scalar_32_fill_27921517Bytes => new byte[237]{0x57,0x56,0x53,0x48,0x83,0xEC,0x20,0xC5,0xF8,0x77,0x48,0x8B,0xD9,0x49,0x8B,0x00,0x41,0x8B,0x48,0x08,0x48,0x83,0xF9,0x20,0x0F,0x82,0xC9,0x00,0x00,0x00,0x48,0x83,0xC0,0x60,0x49,0x8B,0x08,0x44,0x0F,0xB6,0xCA,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB3,0xF5,0xCA,0x4C,0x89,0x08,0x4C,0x8D,0x48,0x08,0x44,0x8B,0xD2,0x41,0xC1,0xEA,0x08,0x45,0x0F,0xB6,0xD2,0x49,0xBB,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xAB,0xF5,0xD3,0x4D,0x89,0x11,0x4C,0x8D,0x48,0x10,0x44,0x8B,0xD2,0x41,0xC1,0xEA,0x10,0x45,0x0F,0xB6,0xD2,0xC4,0x42,0xAB,0xF5,0xD3,0x4D,0x89,0x11,0x4C,0x8D,0x48,0x18,0xC1,0xEA,0x18,0x0F,0xB6,0xD2,0xC4,0xC2,0xEB,0xF5,0xD3,0x49,0x89,0x11,0x48,0x8B,0xD0,0xC4,0xE2,0x7D,0x31,0x02,0x48,0x8B,0xD1,0xC5,0xFE,0x7F,0x02,0x48,0x8D,0x50,0x08,0xC4,0xE2,0x7D,0x31,0x02,0x48,0x8D,0x51,0x20,0xC5,0xFE,0x7F,0x02,0x48,0x8D,0x50,0x10,0xC4,0xE2,0x7D,0x31,0x02,0x48,0x8D,0x51,0x40,0xC5,0xFE,0x7F,0x02,0x48,0x83,0xC0,0x18,0xC4,0xE2,0x7D,0x31,0x00,0x48,0x83,0xC1,0x60,0xC5,0xFE,0x7F,0x01,0x48,0x8B,0xFB,0x49,0x8B,0xF0,0xE8,0x2E,0xB2,0x60,0x5F,0x48,0xA5,0x48,0x8B,0xC3,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x20,0x5B,0x5E,0x5F,0xC3,0xE8,0xA9,0x4F,0x73,0x5F,0xE8,0xF4,0xDF,0xAF,0xFF,0xCC};
; [0x7ff7c838ab90, 0x7ff7c838ac7d], 237 bytes
; 2020-01-20 01:59:20:859
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h sub rsp,20h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 20}
0007h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
000ah mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
000dh mov rax,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b 00}
0010h mov ecx,[r8+8]                          ; MOV r32, r/m32 || o32 8B /r || encoded[4]{41 8b 48 08}
0014h cmp rcx,20h                             ; CMP r/m64, imm8 || REX.W 83 /7 ib || encoded[4]{48 83 f9 20}
0018h jb near ptr 00e7h                       ; JB rel32 || 0F 82 cd || encoded[6]{0f 82 c9 00 00 00}
001eh add rax,60h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c0 60}
0022h mov rcx,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b 08}
0025h movzx r9d,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{44 0f b6 ca}
0029h mov r10,101010101010101h                ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 ba 01 01 01 01 01 01 01 01}
0033h pdep r9,r9,r10                          ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 42 b3 f5 ca}
0038h mov [rax],r9                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 08}
003bh lea r9,[rax+8]                          ; LEA r64, m || REX.W 8D /r || encoded[4]{4c 8d 48 08}
003fh mov r10d,edx                            ; MOV r32, r/m32 || o32 8B /r || encoded[3]{44 8b d2}
0042h shr r10d,8                              ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[4]{41 c1 ea 08}
0046h movzx r10d,r10b                         ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{45 0f b6 d2}
004ah mov r11,101010101010101h                ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 bb 01 01 01 01 01 01 01 01}
0054h pdep r10,r10,r11                        ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 42 ab f5 d3}
0059h mov [r9],r10                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4d 89 11}
005ch lea r9,[rax+10h]                        ; LEA r64, m || REX.W 8D /r || encoded[4]{4c 8d 48 10}
0060h mov r10d,edx                            ; MOV r32, r/m32 || o32 8B /r || encoded[3]{44 8b d2}
0063h shr r10d,10h                            ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[4]{41 c1 ea 10}
0067h movzx r10d,r10b                         ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{45 0f b6 d2}
006bh pdep r10,r10,r11                        ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 42 ab f5 d3}
0070h mov [r9],r10                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4d 89 11}
0073h lea r9,[rax+18h]                        ; LEA r64, m || REX.W 8D /r || encoded[4]{4c 8d 48 18}
0077h shr edx,18h                             ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[3]{c1 ea 18}
007ah movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
007dh pdep rdx,rdx,r11                        ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 c2 eb f5 d3}
0082h mov [r9],rdx                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 11}
0085h mov rdx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d0}
0088h vpmovzxbd ymm0,qword ptr [rdx]          ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 02}
008dh mov rdx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d1}
0090h vmovdqu ymmword ptr [rdx],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 02}
0094h lea rdx,[rax+8]                         ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 50 08}
0098h vpmovzxbd ymm0,qword ptr [rdx]          ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 02}
009dh lea rdx,[rcx+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 51 20}
00a1h vmovdqu ymmword ptr [rdx],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 02}
00a5h lea rdx,[rax+10h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 50 10}
00a9h vpmovzxbd ymm0,qword ptr [rdx]          ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 02}
00aeh lea rdx,[rcx+40h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 51 40}
00b2h vmovdqu ymmword ptr [rdx],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 02}
00b6h add rax,18h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c0 18}
00bah vpmovzxbd ymm0,qword ptr [rax]          ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 00}
00bfh add rcx,60h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c1 60}
00c3h vmovdqu ymmword ptr [rcx],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 01}
00c7h mov rdi,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fb}
00cah mov rsi,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b f0}
00cdh call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 2e b2 60 5f}
00d2h movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
00d4h mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
00d7h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
00dah add rsp,20h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 20}
00deh pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
00dfh pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
00e0h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
00e1h ret                                     ; RET || C3 || encoded[1]{c3}
00e2h call 7FF827ABFC20h                      ; CALL rel32 || E8 cd || encoded[5]{e8 a9 4f 73 5f}
00e7h call 7FF7C7E88C70h                      ; CALL rel32 || E8 cd || encoded[5]{e8 f4 df af ff}
00ech int 3                                   ; INT3 || CC || encoded[1]{cc}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitSpan load_scalar_64(ulong src)
; static ReadOnlySpan<byte> load_scalar_64_64uBytes => new byte[561]{0x57,0x56,0x53,0x48,0x81,0xEC,0x90,0x00,0x00,0x00,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0x48,0x8D,0x7C,0x24,0x20,0xB9,0x1C,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0x48,0x8B,0xD9,0x48,0x8B,0xF2,0x48,0x8D,0x4C,0x24,0x30,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x7F,0x41,0x10,0xC5,0xFA,0x7F,0x41,0x20,0xC5,0xFA,0x7F,0x41,0x30,0x48,0x8D,0x4C,0x24,0x30,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x7F,0x41,0x10,0xC5,0xFA,0x7F,0x41,0x20,0xC5,0xFA,0x7F,0x41,0x30,0x48,0x8D,0x7C,0x24,0x30,0x48,0xB9,0x20,0x8E,0x23,0xC8,0xF7,0x7F,0x00,0x00,0xBA,0x40,0x00,0x00,0x00,0xE8,0xC8,0xC0,0x60,0x5F,0x48,0x83,0xC0,0x10,0xBA,0x40,0x00,0x00,0x00,0x8B,0xCE,0x44,0x0F,0xB6,0xC1,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x07,0x4C,0x8D,0x47,0x08,0x44,0x8B,0xC9,0x41,0xC1,0xE9,0x08,0x45,0x0F,0xB6,0xC9,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB3,0xF5,0xCA,0x4D,0x89,0x08,0x4C,0x8D,0x47,0x10,0x44,0x8B,0xC9,0x41,0xC1,0xE9,0x10,0x45,0x0F,0xB6,0xC9,0xC4,0x42,0xB3,0xF5,0xCA,0x4D,0x89,0x08,0x4C,0x8D,0x47,0x18,0xC1,0xE9,0x18,0x0F,0xB6,0xC9,0xC4,0xC2,0xF3,0xF5,0xCA,0x49,0x89,0x08,0x48,0xC1,0xEE,0x20,0x8B,0xCE,0x4C,0x8D,0x47,0x20,0x44,0x0F,0xB6,0xC9,0xC4,0x42,0xB3,0xF5,0xCA,0x4D,0x89,0x08,0x4D,0x8D,0x48,0x08,0x44,0x8B,0xD1,0x41,0xC1,0xEA,0x08,0x45,0x0F,0xB6,0xD2,0x49,0xBB,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xAB,0xF5,0xD3,0x4D,0x89,0x11,0x4D,0x8D,0x48,0x10,0x44,0x8B,0xD1,0x41,0xC1,0xEA,0x10,0x45,0x0F,0xB6,0xD2,0xC4,0x42,0xAB,0xF5,0xD3,0x4D,0x89,0x11,0x49,0x83,0xC0,0x18,0xC1,0xE9,0x18,0x0F,0xB6,0xC9,0xC4,0xC2,0xF3,0xF5,0xCB,0x49,0x89,0x08,0x48,0x8B,0xCF,0xC4,0xE2,0x7D,0x31,0x01,0x48,0x8B,0xC8,0xC5,0xFE,0x7F,0x01,0x48,0x8D,0x4F,0x08,0xC4,0xE2,0x7D,0x31,0x01,0x48,0x8D,0x48,0x20,0xC5,0xFE,0x7F,0x01,0x48,0x8D,0x4F,0x10,0xC4,0xE2,0x7D,0x31,0x01,0x48,0x8D,0x48,0x40,0xC5,0xFE,0x7F,0x01,0x48,0x8D,0x4F,0x18,0xC4,0xE2,0x7D,0x31,0x01,0x48,0x8D,0x48,0x60,0xC5,0xFE,0x7F,0x01,0x48,0x8D,0x4F,0x20,0xC4,0xE2,0x7D,0x31,0x01,0x48,0x8D,0x88,0x80,0x00,0x00,0x00,0xC5,0xFE,0x7F,0x01,0x48,0x8D,0x4F,0x28,0xC4,0xE2,0x7D,0x31,0x01,0x48,0x8D,0x88,0xA0,0x00,0x00,0x00,0xC5,0xFE,0x7F,0x01,0x48,0x8D,0x4F,0x30,0xC4,0xE2,0x7D,0x31,0x01,0x48,0x8D,0x88,0xC0,0x00,0x00,0x00,0xC5,0xFE,0x7F,0x01,0x48,0x83,0xC7,0x38,0xC4,0xE2,0x7D,0x31,0x07,0x48,0x8D,0x88,0xE0,0x00,0x00,0x00,0xC5,0xFE,0x7F,0x01,0x48,0x8D,0x4C,0x24,0x20,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x01,0x48,0x8D,0x4C,0x24,0x20,0x48,0x89,0x01,0x89,0x51,0x08,0xC5,0xFA,0x6F,0x44,0x24,0x20,0xC5,0xFA,0x7F,0x44,0x24,0x70,0xC5,0xFA,0x6F,0x44,0x24,0x70,0xC5,0xFA,0x7F,0x84,0x24,0x80,0x00,0x00,0x00,0x48,0x8B,0xFB,0x48,0x8D,0xB4,0x24,0x80,0x00,0x00,0x00,0xE8,0xD8,0xAF,0x60,0x5F,0x48,0xA5,0x48,0x8B,0xC3,0xC5,0xF8,0x77,0x48,0x81,0xC4,0x90,0x00,0x00,0x00,0x5B,0x5E,0x5F,0xC3,0xE8,0x50,0x4D,0x73,0x5F,0xCC};
; [0x7ff7c838aca0, 0x7ff7c838aed1], 561 bytes
; 2020-01-20 01:59:20:860
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h sub rsp,90h                             ; SUB r/m64, imm32 || REX.W 81 /5 id || encoded[7]{48 81 ec 90 00 00 00}
000ah vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
000dh mov rsi,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f1}
0010h lea rdi,[rsp+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 7c 24 20}
0015h mov ecx,1Ch                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b9 1c 00 00 00}
001ah xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
001ch rep stosd                               ; STOSD || o32 AB || encoded[2]{f3 ab}
001eh mov rcx,rsi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b ce}
0021h mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
0024h mov rsi,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f2}
0027h lea rcx,[rsp+30h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 4c 24 30}
002ch vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
0030h vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}
0034h vmovdqu xmmword ptr [rcx+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 10}
0039h vmovdqu xmmword ptr [rcx+20h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 20}
003eh vmovdqu xmmword ptr [rcx+30h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 30}
0043h lea rcx,[rsp+30h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 4c 24 30}
0048h vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
004ch vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}
0050h vmovdqu xmmword ptr [rcx+10h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 10}
0055h vmovdqu xmmword ptr [rcx+20h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 20}
005ah vmovdqu xmmword ptr [rcx+30h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c5 fa 7f 41 30}
005fh lea rdi,[rsp+30h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 7c 24 30}
0064h mov rcx,7FF7C8238E20h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 20 8e 23 c8 f7 7f 00 00}
006eh mov edx,40h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 40 00 00 00}
0073h call 7FF827996DE0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 c8 c0 60 5f}
0078h add rax,10h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c0 10}
007ch mov edx,40h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 40 00 00 00}
0081h mov ecx,esi                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b ce}
0083h movzx r8d,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{44 0f b6 c1}
0087h mov r9,101010101010101h                 ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 b9 01 01 01 01 01 01 01 01}
0091h pdep r8,r8,r9                           ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 42 bb f5 c1}
0096h mov [rdi],r8                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 07}
0099h lea r8,[rdi+8]                          ; LEA r64, m || REX.W 8D /r || encoded[4]{4c 8d 47 08}
009dh mov r9d,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{44 8b c9}
00a0h shr r9d,8                               ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[4]{41 c1 e9 08}
00a4h movzx r9d,r9b                           ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{45 0f b6 c9}
00a8h mov r10,101010101010101h                ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 ba 01 01 01 01 01 01 01 01}
00b2h pdep r9,r9,r10                          ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 42 b3 f5 ca}
00b7h mov [r8],r9                             ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4d 89 08}
00bah lea r8,[rdi+10h]                        ; LEA r64, m || REX.W 8D /r || encoded[4]{4c 8d 47 10}
00beh mov r9d,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{44 8b c9}
00c1h shr r9d,10h                             ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[4]{41 c1 e9 10}
00c5h movzx r9d,r9b                           ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{45 0f b6 c9}
00c9h pdep r9,r9,r10                          ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 42 b3 f5 ca}
00ceh mov [r8],r9                             ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4d 89 08}
00d1h lea r8,[rdi+18h]                        ; LEA r64, m || REX.W 8D /r || encoded[4]{4c 8d 47 18}
00d5h shr ecx,18h                             ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[3]{c1 e9 18}
00d8h movzx ecx,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c9}
00dbh pdep rcx,rcx,r10                        ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 c2 f3 f5 ca}
00e0h mov [r8],rcx                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 08}
00e3h shr rsi,20h                             ; SHR r/m64, imm8 || REX.W C1 /5 ib || encoded[4]{48 c1 ee 20}
00e7h mov ecx,esi                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b ce}
00e9h lea r8,[rdi+20h]                        ; LEA r64, m || REX.W 8D /r || encoded[4]{4c 8d 47 20}
00edh movzx r9d,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{44 0f b6 c9}
00f1h pdep r9,r9,r10                          ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 42 b3 f5 ca}
00f6h mov [r8],r9                             ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4d 89 08}
00f9h lea r9,[r8+8]                           ; LEA r64, m || REX.W 8D /r || encoded[4]{4d 8d 48 08}
00fdh mov r10d,ecx                            ; MOV r32, r/m32 || o32 8B /r || encoded[3]{44 8b d1}
0100h shr r10d,8                              ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[4]{41 c1 ea 08}
0104h movzx r10d,r10b                         ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{45 0f b6 d2}
0108h mov r11,101010101010101h                ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 bb 01 01 01 01 01 01 01 01}
0112h pdep r10,r10,r11                        ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 42 ab f5 d3}
0117h mov [r9],r10                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4d 89 11}
011ah lea r9,[r8+10h]                         ; LEA r64, m || REX.W 8D /r || encoded[4]{4d 8d 48 10}
011eh mov r10d,ecx                            ; MOV r32, r/m32 || o32 8B /r || encoded[3]{44 8b d1}
0121h shr r10d,10h                            ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[4]{41 c1 ea 10}
0125h movzx r10d,r10b                         ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{45 0f b6 d2}
0129h pdep r10,r10,r11                        ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 42 ab f5 d3}
012eh mov [r9],r10                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4d 89 11}
0131h add r8,18h                              ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{49 83 c0 18}
0135h shr ecx,18h                             ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[3]{c1 e9 18}
0138h movzx ecx,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c9}
013bh pdep rcx,rcx,r11                        ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 c2 f3 f5 cb}
0140h mov [r8],rcx                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 08}
0143h mov rcx,rdi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b cf}
0146h vpmovzxbd ymm0,qword ptr [rcx]          ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 01}
014bh mov rcx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c8}
014eh vmovdqu ymmword ptr [rcx],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 01}
0152h lea rcx,[rdi+8]                         ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 4f 08}
0156h vpmovzxbd ymm0,qword ptr [rcx]          ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 01}
015bh lea rcx,[rax+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 48 20}
015fh vmovdqu ymmword ptr [rcx],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 01}
0163h lea rcx,[rdi+10h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 4f 10}
0167h vpmovzxbd ymm0,qword ptr [rcx]          ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 01}
016ch lea rcx,[rax+40h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 48 40}
0170h vmovdqu ymmword ptr [rcx],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 01}
0174h lea rcx,[rdi+18h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 4f 18}
0178h vpmovzxbd ymm0,qword ptr [rcx]          ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 01}
017dh lea rcx,[rax+60h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 48 60}
0181h vmovdqu ymmword ptr [rcx],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 01}
0185h lea rcx,[rdi+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 4f 20}
0189h vpmovzxbd ymm0,qword ptr [rcx]          ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 01}
018eh lea rcx,[rax+80h]                       ; LEA r64, m || REX.W 8D /r || encoded[7]{48 8d 88 80 00 00 00}
0195h vmovdqu ymmword ptr [rcx],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 01}
0199h lea rcx,[rdi+28h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 4f 28}
019dh vpmovzxbd ymm0,qword ptr [rcx]          ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 01}
01a2h lea rcx,[rax+0A0h]                      ; LEA r64, m || REX.W 8D /r || encoded[7]{48 8d 88 a0 00 00 00}
01a9h vmovdqu ymmword ptr [rcx],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 01}
01adh lea rcx,[rdi+30h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 4f 30}
01b1h vpmovzxbd ymm0,qword ptr [rcx]          ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 01}
01b6h lea rcx,[rax+0C0h]                      ; LEA r64, m || REX.W 8D /r || encoded[7]{48 8d 88 c0 00 00 00}
01bdh vmovdqu ymmword ptr [rcx],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 01}
01c1h add rdi,38h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c7 38}
01c5h vpmovzxbd ymm0,qword ptr [rdi]          ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 07}
01cah lea rcx,[rax+0E0h]                      ; LEA r64, m || REX.W 8D /r || encoded[7]{48 8d 88 e0 00 00 00}
01d1h vmovdqu ymmword ptr [rcx],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 01}
01d5h lea rcx,[rsp+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 4c 24 20}
01dah vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
01deh vmovdqu xmmword ptr [rcx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}
01e2h lea rcx,[rsp+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 4c 24 20}
01e7h mov [rcx],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 01}
01eah mov [rcx+8],edx                         ; MOV r/m32, r32 || o32 89 /r || encoded[3]{89 51 08}
01edh vmovdqu xmm0,xmmword ptr [rsp+20h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[6]{c5 fa 6f 44 24 20}
01f3h vmovdqu xmmword ptr [rsp+70h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[6]{c5 fa 7f 44 24 70}
01f9h vmovdqu xmm0,xmmword ptr [rsp+70h]      ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[6]{c5 fa 6f 44 24 70}
01ffh vmovdqu xmmword ptr [rsp+80h],xmm0      ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[9]{c5 fa 7f 84 24 80 00 00 00}
0208h mov rdi,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fb}
020bh lea rsi,[rsp+80h]                       ; LEA r64, m || REX.W 8D /r || encoded[8]{48 8d b4 24 80 00 00 00}
0213h call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 d8 af 60 5f}
0218h movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
021ah mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
021dh vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0220h add rsp,90h                             ; ADD r/m64, imm32 || REX.W 81 /0 id || encoded[7]{48 81 c4 90 00 00 00}
0227h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
0228h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
0229h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
022ah ret                                     ; RET || C3 || encoded[1]{c3}
022bh call 7FF827ABFC20h                      ; CALL rel32 || E8 cd || encoded[5]{e8 50 4d 73 5f}
0230h int 3                                   ; INT3 || CC || encoded[1]{cc}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitSpan load_scalar_64_fill(ulong src, in BitSpan dst)
; static ReadOnlySpan<byte> load_scalar_64_fill_49967061Bytes => new byte[401]{0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x48,0x8B,0xD9,0x49,0x8B,0x00,0x41,0x8B,0x48,0x08,0x48,0x83,0xF9,0x40,0x0F,0x82,0x6C,0x01,0x00,0x00,0x48,0x05,0xE0,0x00,0x00,0x00,0x49,0x8B,0x08,0x44,0x8B,0xCA,0x45,0x0F,0xB6,0xD1,0x49,0xBB,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xAB,0xF5,0xD3,0x4C,0x89,0x10,0x4C,0x8D,0x50,0x08,0x4D,0x8B,0xDA,0x41,0x8B,0xF1,0xC1,0xEE,0x08,0x40,0x0F,0xB6,0xF6,0x48,0xBF,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xCB,0xF5,0xF7,0x49,0x89,0x33,0x4C,0x8D,0x58,0x10,0x49,0x8B,0xF3,0x41,0x8B,0xF9,0xC1,0xEF,0x10,0x40,0x0F,0xB6,0xFF,0x48,0xBD,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xC3,0xF5,0xFD,0x48,0x89,0x3E,0x48,0x8D,0x70,0x18,0x48,0x8B,0xFE,0x41,0xC1,0xE9,0x18,0x45,0x0F,0xB6,0xC9,0xC4,0x62,0xB3,0xF5,0xCD,0x4C,0x89,0x0F,0x4C,0x8B,0xC8,0xC4,0xC2,0x7D,0x31,0x01,0x4C,0x8B,0xC9,0xC4,0xC1,0x7E,0x7F,0x01,0x4D,0x8B,0xCA,0xC4,0xC2,0x7D,0x31,0x01,0x4C,0x8D,0x49,0x20,0xC4,0xC1,0x7E,0x7F,0x01,0x4D,0x8B,0xCB,0xC4,0xC2,0x7D,0x31,0x01,0x4C,0x8D,0x49,0x40,0xC4,0xC1,0x7E,0x7F,0x01,0x4C,0x8B,0xCE,0xC4,0xC2,0x7D,0x31,0x01,0x4C,0x8D,0x49,0x60,0xC4,0xC1,0x7E,0x7F,0x01,0x48,0xC1,0xEA,0x20,0x44,0x0F,0xB6,0xCA,0xC4,0x62,0xB3,0xF5,0xCD,0x4C,0x89,0x08,0x4D,0x8B,0xCA,0x8B,0xFA,0xC1,0xEF,0x08,0x40,0x0F,0xB6,0xFF,0xC4,0xE2,0xC3,0xF5,0xFD,0x49,0x89,0x39,0x4D,0x8B,0xCB,0x8B,0xFA,0xC1,0xEF,0x10,0x40,0x0F,0xB6,0xFF,0xC4,0xE2,0xC3,0xF5,0xFD,0x49,0x89,0x39,0x4C,0x8B,0xCE,0xC1,0xEA,0x18,0x0F,0xB6,0xD2,0xC4,0xE2,0xEB,0xF5,0xD5,0x49,0x89,0x11,0xC4,0xE2,0x7D,0x31,0x00,0x48,0x8D,0x81,0x80,0x00,0x00,0x00,0xC5,0xFE,0x7F,0x00,0xC4,0xC2,0x7D,0x31,0x02,0x48,0x8D,0x81,0xA0,0x00,0x00,0x00,0xC5,0xFE,0x7F,0x00,0xC4,0xC2,0x7D,0x31,0x03,0x48,0x8D,0x81,0xC0,0x00,0x00,0x00,0xC5,0xFE,0x7F,0x00,0xC4,0xE2,0x7D,0x31,0x06,0x48,0x81,0xC1,0xE0,0x00,0x00,0x00,0xC5,0xFE,0x7F,0x01,0x48,0x8B,0xFB,0x49,0x8B,0xF0,0xE8,0x0B,0xAE,0x60,0x5F,0x48,0xA5,0x48,0x8B,0xC3,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x28,0x5B,0x5D,0x5E,0x5F,0xC3,0xE8,0x85,0x4B,0x73,0x5F,0xE8,0xD0,0xDB,0xAF,0xFF,0xCC};
; [0x7ff7c838af10, 0x7ff7c838b0a1], 401 bytes
; 2020-01-20 01:59:20:860
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbp                                ; PUSH r64 || 50+ro || encoded[1]{55}
0003h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0004h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0008h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
000bh mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
000eh mov rax,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b 00}
0011h mov ecx,[r8+8]                          ; MOV r32, r/m32 || o32 8B /r || encoded[4]{41 8b 48 08}
0015h cmp rcx,40h                             ; CMP r/m64, imm8 || REX.W 83 /7 ib || encoded[4]{48 83 f9 40}
0019h jb near ptr 018bh                       ; JB rel32 || 0F 82 cd || encoded[6]{0f 82 6c 01 00 00}
001fh add rax,0E0h                            ; ADD RAX, imm32 || REX.W 05 id || encoded[6]{48 05 e0 00 00 00}
0025h mov rcx,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b 08}
0028h mov r9d,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{44 8b ca}
002bh movzx r10d,r9b                          ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{45 0f b6 d1}
002fh mov r11,101010101010101h                ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 bb 01 01 01 01 01 01 01 01}
0039h pdep r10,r10,r11                        ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 42 ab f5 d3}
003eh mov [rax],r10                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 10}
0041h lea r10,[rax+8]                         ; LEA r64, m || REX.W 8D /r || encoded[4]{4c 8d 50 08}
0045h mov r11,r10                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b da}
0048h mov esi,r9d                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b f1}
004bh shr esi,8                               ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[3]{c1 ee 08}
004eh movzx esi,sil                           ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{40 0f b6 f6}
0052h mov rdi,101010101010101h                ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 bf 01 01 01 01 01 01 01 01}
005ch pdep rsi,rsi,rdi                        ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 e2 cb f5 f7}
0061h mov [r11],rsi                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 33}
0064h lea r11,[rax+10h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{4c 8d 58 10}
0068h mov rsi,r11                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b f3}
006bh mov edi,r9d                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b f9}
006eh shr edi,10h                             ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[3]{c1 ef 10}
0071h movzx edi,dil                           ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{40 0f b6 ff}
0075h mov rbp,101010101010101h                ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 bd 01 01 01 01 01 01 01 01}
007fh pdep rdi,rdi,rbp                        ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 e2 c3 f5 fd}
0084h mov [rsi],rdi                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 3e}
0087h lea rsi,[rax+18h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 70 18}
008bh mov rdi,rsi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fe}
008eh shr r9d,18h                             ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[4]{41 c1 e9 18}
0092h movzx r9d,r9b                           ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{45 0f b6 c9}
0096h pdep r9,r9,rbp                          ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 62 b3 f5 cd}
009bh mov [rdi],r9                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 0f}
009eh mov r9,rax                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b c8}
00a1h vpmovzxbd ymm0,qword ptr [r9]           ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 c2 7d 31 01}
00a6h mov r9,rcx                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b c9}
00a9h vmovdqu ymmword ptr [r9],ymm0           ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[5]{c4 c1 7e 7f 01}
00aeh mov r9,r10                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b ca}
00b1h vpmovzxbd ymm0,qword ptr [r9]           ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 c2 7d 31 01}
00b6h lea r9,[rcx+20h]                        ; LEA r64, m || REX.W 8D /r || encoded[4]{4c 8d 49 20}
00bah vmovdqu ymmword ptr [r9],ymm0           ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[5]{c4 c1 7e 7f 01}
00bfh mov r9,r11                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b cb}
00c2h vpmovzxbd ymm0,qword ptr [r9]           ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 c2 7d 31 01}
00c7h lea r9,[rcx+40h]                        ; LEA r64, m || REX.W 8D /r || encoded[4]{4c 8d 49 40}
00cbh vmovdqu ymmword ptr [r9],ymm0           ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[5]{c4 c1 7e 7f 01}
00d0h mov r9,rsi                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b ce}
00d3h vpmovzxbd ymm0,qword ptr [r9]           ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 c2 7d 31 01}
00d8h lea r9,[rcx+60h]                        ; LEA r64, m || REX.W 8D /r || encoded[4]{4c 8d 49 60}
00dch vmovdqu ymmword ptr [r9],ymm0           ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[5]{c4 c1 7e 7f 01}
00e1h shr rdx,20h                             ; SHR r/m64, imm8 || REX.W C1 /5 ib || encoded[4]{48 c1 ea 20}
00e5h movzx r9d,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{44 0f b6 ca}
00e9h pdep r9,r9,rbp                          ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 62 b3 f5 cd}
00eeh mov [rax],r9                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 08}
00f1h mov r9,r10                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b ca}
00f4h mov edi,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b fa}
00f6h shr edi,8                               ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[3]{c1 ef 08}
00f9h movzx edi,dil                           ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{40 0f b6 ff}
00fdh pdep rdi,rdi,rbp                        ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 e2 c3 f5 fd}
0102h mov [r9],rdi                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 39}
0105h mov r9,r11                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b cb}
0108h mov edi,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b fa}
010ah shr edi,10h                             ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[3]{c1 ef 10}
010dh movzx edi,dil                           ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{40 0f b6 ff}
0111h pdep rdi,rdi,rbp                        ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 e2 c3 f5 fd}
0116h mov [r9],rdi                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 39}
0119h mov r9,rsi                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b ce}
011ch shr edx,18h                             ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[3]{c1 ea 18}
011fh movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
0122h pdep rdx,rdx,rbp                        ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 e2 eb f5 d5}
0127h mov [r9],rdx                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 11}
012ah vpmovzxbd ymm0,qword ptr [rax]          ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 00}
012fh lea rax,[rcx+80h]                       ; LEA r64, m || REX.W 8D /r || encoded[7]{48 8d 81 80 00 00 00}
0136h vmovdqu ymmword ptr [rax],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 00}
013ah vpmovzxbd ymm0,qword ptr [r10]          ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 c2 7d 31 02}
013fh lea rax,[rcx+0A0h]                      ; LEA r64, m || REX.W 8D /r || encoded[7]{48 8d 81 a0 00 00 00}
0146h vmovdqu ymmword ptr [rax],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 00}
014ah vpmovzxbd ymm0,qword ptr [r11]          ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 c2 7d 31 03}
014fh lea rax,[rcx+0C0h]                      ; LEA r64, m || REX.W 8D /r || encoded[7]{48 8d 81 c0 00 00 00}
0156h vmovdqu ymmword ptr [rax],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 00}
015ah vpmovzxbd ymm0,qword ptr [rsi]          ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 06}
015fh add rcx,0E0h                            ; ADD r/m64, imm32 || REX.W 81 /0 id || encoded[7]{48 81 c1 e0 00 00 00}
0166h vmovdqu ymmword ptr [rcx],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 01}
016ah mov rdi,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fb}
016dh mov rsi,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b f0}
0170h call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 0b ae 60 5f}
0175h movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
0177h mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
017ah vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
017dh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0181h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
0182h pop rbp                                 ; POP r64 || 58+ro || encoded[1]{5d}
0183h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
0184h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
0185h ret                                     ; RET || C3 || encoded[1]{c3}
0186h call 7FF827ABFC20h                      ; CALL rel32 || E8 cd || encoded[5]{e8 85 4b 73 5f}
018bh call 7FF7C7E88C70h                      ; CALL rel32 || E8 cd || encoded[5]{e8 d0 db af ff}
0190h int 3                                   ; INT3 || CC || encoded[1]{cc}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; byte scalar_8(BitSpan src)
; static ReadOnlySpan<byte> scalar_8_47050372Bytes => new byte[150]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x48,0x8B,0x01,0x8B,0x51,0x08,0x48,0x83,0xFA,0x08,0x0F,0x82,0x79,0x00,0x00,0x00,0xC5,0xFF,0xF0,0x00,0xC4,0xE3,0x7D,0x19,0xC1,0x00,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC7,0x44,0x24,0x24,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x24,0xC4,0xE2,0x79,0x58,0x54,0x24,0x24,0xC5,0xF1,0xDB,0xCA,0xC5,0xF9,0xDB,0xC2,0xC4,0xE2,0x71,0x2B,0xC0,0xC5,0xF0,0x57,0xC9,0xC7,0x44,0x24,0x20,0xFF,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x20,0xC4,0xE2,0x79,0x79,0x54,0x24,0x20,0xC5,0xF9,0xDB,0xC2,0xC5,0xF1,0xDB,0xCA,0xC5,0xF9,0x67,0xC1,0xB8,0x07,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xC8,0xC5,0xF9,0xF3,0xC1,0xC5,0xF9,0xD7,0xC0,0x0F,0xB7,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xC0,0x46,0x73,0x5F,0xE8,0x0B,0xD7,0xAF,0xFF,0xCC};
; [0x7ff7c838b4d0, 0x7ff7c838b566], 150 bytes
; 2020-01-20 01:59:20:860
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0007h mov rax,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 01}
000ah mov edx,[rcx+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 51 08}
000dh cmp rdx,8                               ; CMP r/m64, imm8 || REX.W 83 /7 ib || encoded[4]{48 83 fa 08}
0011h jb near ptr 0090h                       ; JB rel32 || 0F 82 cd || encoded[6]{0f 82 79 00 00 00}
0017h vlddqu ymm0,ymmword ptr [rax]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 00}
001bh vextractf128 xmm1,ymm0,0                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c1 00}
0021h vextractf128 xmm0,ymm0,1                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c0 01}
0027h mov dword ptr [rsp+24h],0FFFFh          ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 24 ff ff 00 00}
002fh lea rax,[rsp+24h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 24}
0034h vpbroadcastd xmm2,dword ptr [rsp+24h]   ; VPBROADCASTD xmm1, xmm2/m32 || VEX.128.66.0F38.W0 58 /r || encoded[7]{c4 e2 79 58 54 24 24}
003bh vpand xmm1,xmm1,xmm2                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f1 db ca}
003fh vpand xmm0,xmm0,xmm2                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f9 db c2}
0043h vpackusdw xmm0,xmm1,xmm0                ; VPACKUSDW xmm1, xmm2, xmm3/m128 || VEX.128.66.0F38.WIG 2B /r || encoded[5]{c4 e2 71 2b c0}
0048h vxorps xmm1,xmm1,xmm1                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f0 57 c9}
004ch mov dword ptr [rsp+20h],0FFh            ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 20 ff 00 00 00}
0054h lea rax,[rsp+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 20}
0059h vpbroadcastw xmm2,word ptr [rsp+20h]    ; VPBROADCASTW xmm1, xmm2/m16 || VEX.128.66.0F38.W0 79 /r || encoded[7]{c4 e2 79 79 54 24 20}
0060h vpand xmm0,xmm0,xmm2                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f9 db c2}
0064h vpand xmm1,xmm1,xmm2                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f1 db ca}
0068h vpackuswb xmm0,xmm0,xmm1                ; VPACKUSWB xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG 67 /r || encoded[4]{c5 f9 67 c1}
006ch mov eax,7                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 07 00 00 00}
0071h vmovd xmm1,eax                          ; VMOVD xmm1, r/m32 || VEX.128.66.0F.W0 6E /r || encoded[4]{c5 f9 6e c8}
0075h vpsllq xmm0,xmm0,xmm1                   ; VPSLLQ xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG F3 /r || encoded[4]{c5 f9 f3 c1}
0079h vpmovmskb eax,xmm0                      ; VPMOVMSKB r32, xmm1 || VEX.128.66.0F.W0 D7 /r || encoded[4]{c5 f9 d7 c0}
007dh movzx eax,ax                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c0}
0080h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0083h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0086h add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
008ah ret                                     ; RET || C3 || encoded[1]{c3}
008bh call 7FF827ABFC20h                      ; CALL rel32 || E8 cd || encoded[5]{e8 c0 46 73 5f}
0090h call 7FF7C7E88C70h                      ; CALL rel32 || E8 cd || encoded[5]{e8 0b d7 af ff}
0095h int 3                                   ; INT3 || CC || encoded[1]{cc}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ushort extract_16(BitSpan src)
; static ReadOnlySpan<byte> extract_16_20800170Bytes => new byte[160]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x48,0x8B,0x01,0x8B,0x51,0x08,0x48,0x83,0xFA,0x10,0x0F,0x82,0x83,0x00,0x00,0x00,0x48,0x8B,0xD0,0xC5,0xFF,0xF0,0x02,0x48,0x83,0xC0,0x20,0xC5,0xFF,0xF0,0x08,0xC7,0x44,0x24,0x24,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x24,0xC4,0xE2,0x7D,0x58,0x54,0x24,0x24,0xC5,0xFD,0xDB,0xC2,0xC5,0xF5,0xDB,0xCA,0xC4,0xE2,0x7D,0x2B,0xC1,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC4,0xE3,0x7D,0x19,0xC1,0x00,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC7,0x44,0x24,0x20,0xFF,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x20,0xC4,0xE2,0x79,0x79,0x54,0x24,0x20,0xC5,0xF1,0xDB,0xCA,0xC5,0xF9,0xDB,0xC2,0xC5,0xF1,0x67,0xC0,0xB8,0x07,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xC8,0xC5,0xF9,0xF3,0xC1,0xC5,0xF9,0xD7,0xC0,0x0F,0xB7,0xC0,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xF6,0x41,0x73,0x5F,0xE8,0x41,0xD2,0xAF,0xFF,0xCC};
; [0x7ff7c838b990, 0x7ff7c838ba30], 160 bytes
; 2020-01-20 01:59:20:860
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0007h mov rax,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 01}
000ah mov edx,[rcx+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 51 08}
000dh cmp rdx,10h                             ; CMP r/m64, imm8 || REX.W 83 /7 ib || encoded[4]{48 83 fa 10}
0011h jb near ptr 009ah                       ; JB rel32 || 0F 82 cd || encoded[6]{0f 82 83 00 00 00}
0017h mov rdx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d0}
001ah vlddqu ymm0,ymmword ptr [rdx]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 02}
001eh add rax,20h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c0 20}
0022h vlddqu ymm1,ymmword ptr [rax]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 08}
0026h mov dword ptr [rsp+24h],0FFFFh          ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 24 ff ff 00 00}
002eh lea rax,[rsp+24h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 24}
0033h vpbroadcastd ymm2,dword ptr [rsp+24h]   ; VPBROADCASTD ymm1, xmm2/m32 || VEX.256.66.0F38.W0 58 /r || encoded[7]{c4 e2 7d 58 54 24 24}
003ah vpand ymm0,ymm0,ymm2                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 fd db c2}
003eh vpand ymm1,ymm1,ymm2                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 f5 db ca}
0042h vpackusdw ymm0,ymm0,ymm1                ; VPACKUSDW ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 2B /r || encoded[5]{c4 e2 7d 2b c1}
0047h vpermq ymm0,ymm0,0D8h                   ; VPERMQ ymm1, ymm2/m256, imm8 || VEX.256.66.0F3A.W1 00 /r ib || encoded[6]{c4 e3 fd 00 c0 d8}
004dh vextractf128 xmm1,ymm0,0                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c1 00}
0053h vextractf128 xmm0,ymm0,1                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c0 01}
0059h mov dword ptr [rsp+20h],0FFh            ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 20 ff 00 00 00}
0061h lea rax,[rsp+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 20}
0066h vpbroadcastw xmm2,word ptr [rsp+20h]    ; VPBROADCASTW xmm1, xmm2/m16 || VEX.128.66.0F38.W0 79 /r || encoded[7]{c4 e2 79 79 54 24 20}
006dh vpand xmm1,xmm1,xmm2                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f1 db ca}
0071h vpand xmm0,xmm0,xmm2                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f9 db c2}
0075h vpackuswb xmm0,xmm1,xmm0                ; VPACKUSWB xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG 67 /r || encoded[4]{c5 f1 67 c0}
0079h mov eax,7                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 07 00 00 00}
007eh vmovd xmm1,eax                          ; VMOVD xmm1, r/m32 || VEX.128.66.0F.W0 6E /r || encoded[4]{c5 f9 6e c8}
0082h vpsllq xmm0,xmm0,xmm1                   ; VPSLLQ xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG F3 /r || encoded[4]{c5 f9 f3 c1}
0086h vpmovmskb eax,xmm0                      ; VPMOVMSKB r32, xmm1 || VEX.128.66.0F.W0 D7 /r || encoded[4]{c5 f9 d7 c0}
008ah movzx eax,ax                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c0}
008dh vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0090h add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0094h ret                                     ; RET || C3 || encoded[1]{c3}
0095h call 7FF827ABFC20h                      ; CALL rel32 || E8 cd || encoded[5]{e8 f6 41 73 5f}
009ah call 7FF7C7E88C70h                      ; CALL rel32 || E8 cd || encoded[5]{e8 41 d2 af ff}
009fh int 3                                   ; INT3 || CC || encoded[1]{cc}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; uint extract_32(BitSpan src)
; static ReadOnlySpan<byte> extract_32_52983808Bytes => new byte[206]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0x48,0x8B,0x01,0x8B,0x51,0x08,0x48,0x83,0xFA,0x20,0x0F,0x82,0xB1,0x00,0x00,0x00,0x48,0x8B,0xD0,0xC5,0xFF,0xF0,0x02,0x48,0x8D,0x50,0x20,0xC5,0xFF,0xF0,0x0A,0xC7,0x44,0x24,0x34,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x54,0x24,0x34,0xC4,0xE2,0x7D,0x58,0x54,0x24,0x34,0xC5,0xFD,0xDB,0xC2,0xC5,0xF5,0xDB,0xCA,0xC4,0xE2,0x7D,0x2B,0xC1,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0x48,0x8D,0x50,0x40,0xC5,0xFF,0xF0,0x0A,0x48,0x83,0xC0,0x60,0xC5,0xFF,0xF0,0x10,0xC7,0x44,0x24,0x30,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x30,0xC4,0xE2,0x7D,0x58,0x5C,0x24,0x30,0xC5,0xF5,0xDB,0xCB,0xC5,0xED,0xDB,0xD3,0xC4,0xE2,0x75,0x2B,0xCA,0xC4,0xE3,0xFD,0x00,0xC9,0xD8,0xC7,0x44,0x24,0x2C,0xFF,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x2C,0xC4,0xE2,0x7D,0x79,0x54,0x24,0x2C,0xC5,0xFD,0xDB,0xC2,0xC5,0xF5,0xDB,0xCA,0xC5,0xFD,0x67,0xC1,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xB8,0x07,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xC8,0xC5,0xFD,0xF3,0xC1,0xC5,0xFD,0xD7,0xC0,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x38,0xC3,0xE8,0x08,0x41,0x73,0x5F,0xE8,0x53,0xD1,0xAF,0xFF,0xCC};
; [0x7ff7c838ba50, 0x7ff7c838bb1e], 206 bytes
; 2020-01-20 01:59:20:860
0000h sub rsp,38h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 38}
0004h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0007h mov rax,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 01}
000ah mov edx,[rcx+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 51 08}
000dh cmp rdx,20h                             ; CMP r/m64, imm8 || REX.W 83 /7 ib || encoded[4]{48 83 fa 20}
0011h jb near ptr 00c8h                       ; JB rel32 || 0F 82 cd || encoded[6]{0f 82 b1 00 00 00}
0017h mov rdx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d0}
001ah vlddqu ymm0,ymmword ptr [rdx]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 02}
001eh lea rdx,[rax+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 50 20}
0022h vlddqu ymm1,ymmword ptr [rdx]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 0a}
0026h mov dword ptr [rsp+34h],0FFFFh          ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 34 ff ff 00 00}
002eh lea rdx,[rsp+34h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 54 24 34}
0033h vpbroadcastd ymm2,dword ptr [rsp+34h]   ; VPBROADCASTD ymm1, xmm2/m32 || VEX.256.66.0F38.W0 58 /r || encoded[7]{c4 e2 7d 58 54 24 34}
003ah vpand ymm0,ymm0,ymm2                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 fd db c2}
003eh vpand ymm1,ymm1,ymm2                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 f5 db ca}
0042h vpackusdw ymm0,ymm0,ymm1                ; VPACKUSDW ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 2B /r || encoded[5]{c4 e2 7d 2b c1}
0047h vpermq ymm0,ymm0,0D8h                   ; VPERMQ ymm1, ymm2/m256, imm8 || VEX.256.66.0F3A.W1 00 /r ib || encoded[6]{c4 e3 fd 00 c0 d8}
004dh lea rdx,[rax+40h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 50 40}
0051h vlddqu ymm1,ymmword ptr [rdx]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 0a}
0055h add rax,60h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c0 60}
0059h vlddqu ymm2,ymmword ptr [rax]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 10}
005dh mov dword ptr [rsp+30h],0FFFFh          ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 30 ff ff 00 00}
0065h lea rax,[rsp+30h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 30}
006ah vpbroadcastd ymm3,dword ptr [rsp+30h]   ; VPBROADCASTD ymm1, xmm2/m32 || VEX.256.66.0F38.W0 58 /r || encoded[7]{c4 e2 7d 58 5c 24 30}
0071h vpand ymm1,ymm1,ymm3                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 f5 db cb}
0075h vpand ymm2,ymm2,ymm3                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 ed db d3}
0079h vpackusdw ymm1,ymm1,ymm2                ; VPACKUSDW ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 2B /r || encoded[5]{c4 e2 75 2b ca}
007eh vpermq ymm1,ymm1,0D8h                   ; VPERMQ ymm1, ymm2/m256, imm8 || VEX.256.66.0F3A.W1 00 /r ib || encoded[6]{c4 e3 fd 00 c9 d8}
0084h mov dword ptr [rsp+2Ch],0FFh            ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 2c ff 00 00 00}
008ch lea rax,[rsp+2Ch]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 2c}
0091h vpbroadcastw ymm2,word ptr [rsp+2Ch]    ; VPBROADCASTW ymm1, xmm2/m16 || VEX.256.66.0F38.W0 79 /r || encoded[7]{c4 e2 7d 79 54 24 2c}
0098h vpand ymm0,ymm0,ymm2                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 fd db c2}
009ch vpand ymm1,ymm1,ymm2                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 f5 db ca}
00a0h vpackuswb ymm0,ymm0,ymm1                ; VPACKUSWB ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG 67 /r || encoded[4]{c5 fd 67 c1}
00a4h vpermq ymm0,ymm0,0D8h                   ; VPERMQ ymm1, ymm2/m256, imm8 || VEX.256.66.0F3A.W1 00 /r ib || encoded[6]{c4 e3 fd 00 c0 d8}
00aah mov eax,7                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 07 00 00 00}
00afh vmovd xmm1,eax                          ; VMOVD xmm1, r/m32 || VEX.128.66.0F.W0 6E /r || encoded[4]{c5 f9 6e c8}
00b3h vpsllq ymm0,ymm0,xmm1                   ; VPSLLQ ymm1, ymm2, xmm3/m128 || VEX.256.66.0F.WIG F3 /r || encoded[4]{c5 fd f3 c1}
00b7h vpmovmskb eax,ymm0                      ; VPMOVMSKB r32, ymm1 || VEX.256.66.0F.W0 D7 /r || encoded[4]{c5 fd d7 c0}
00bbh vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
00beh add rsp,38h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 38}
00c2h ret                                     ; RET || C3 || encoded[1]{c3}
00c3h call 7FF827ABFC20h                      ; CALL rel32 || E8 cd || encoded[5]{e8 08 41 73 5f}
00c8h call 7FF7C7E88C70h                      ; CALL rel32 || E8 cd || encoded[5]{e8 53 d1 af ff}
00cdh int 3                                   ; INT3 || CC || encoded[1]{cc}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong extract_64(BitSpan src)
; static ReadOnlySpan<byte> extract_64_7092232Bytes => new byte[396]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0x48,0x8B,0x01,0x8B,0x51,0x08,0x48,0x83,0xFA,0x40,0x0F,0x82,0x6F,0x01,0x00,0x00,0x48,0x8B,0xD0,0xC5,0xFF,0xF0,0x02,0x48,0x8D,0x50,0x20,0xC5,0xFF,0xF0,0x0A,0xC7,0x44,0x24,0x34,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x54,0x24,0x34,0xC4,0xE2,0x7D,0x58,0x54,0x24,0x34,0xC5,0xFD,0xDB,0xC2,0xC5,0xF5,0xDB,0xCA,0xC4,0xE2,0x7D,0x2B,0xC1,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0x48,0x8D,0x50,0x40,0xC5,0xFF,0xF0,0x0A,0x48,0x8D,0x50,0x60,0xC5,0xFF,0xF0,0x12,0xC7,0x44,0x24,0x30,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x54,0x24,0x30,0xC4,0xE2,0x7D,0x58,0x5C,0x24,0x30,0xC5,0xF5,0xDB,0xCB,0xC5,0xED,0xDB,0xD3,0xC4,0xE2,0x75,0x2B,0xCA,0xC4,0xE3,0xFD,0x00,0xC9,0xD8,0xC7,0x44,0x24,0x2C,0xFF,0x00,0x00,0x00,0x48,0x8D,0x54,0x24,0x2C,0xC4,0xE2,0x7D,0x79,0x54,0x24,0x2C,0xC5,0xFD,0xDB,0xC2,0xC5,0xF5,0xDB,0xCA,0xC5,0xFD,0x67,0xC1,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xBA,0x07,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xCA,0xC5,0xFD,0xF3,0xC1,0xC5,0xFD,0xD7,0xD0,0x8B,0xD2,0x48,0x8D,0x88,0x80,0x00,0x00,0x00,0xC5,0xFF,0xF0,0x09,0x48,0x8D,0x88,0xA0,0x00,0x00,0x00,0xC5,0xFF,0xF0,0x11,0xC7,0x44,0x24,0x28,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x4C,0x24,0x28,0xC4,0xE2,0x7D,0x58,0x44,0x24,0x28,0xC5,0xF5,0xDB,0xC8,0xC5,0xED,0xDB,0xC0,0xC4,0xE2,0x75,0x2B,0xC0,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0x48,0x8D,0x88,0xC0,0x00,0x00,0x00,0xC5,0xFF,0xF0,0x09,0x48,0x05,0xE0,0x00,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC7,0x44,0x24,0x24,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x24,0xC4,0xE2,0x7D,0x58,0x5C,0x24,0x24,0xC5,0xF5,0xDB,0xCB,0xC5,0xED,0xDB,0xD3,0xC4,0xE2,0x75,0x2B,0xCA,0xC4,0xE3,0xFD,0x00,0xC9,0xD8,0xC7,0x44,0x24,0x20,0xFF,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x20,0xC4,0xE2,0x7D,0x79,0x54,0x24,0x20,0xC5,0xFD,0xDB,0xC2,0xC5,0xF5,0xDB,0xCA,0xC5,0xFD,0x67,0xC1,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xB8,0x07,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xC8,0xC5,0xFD,0xF3,0xC1,0xC5,0xFD,0xD7,0xC0,0x8B,0xC0,0x48,0xC1,0xE0,0x20,0x48,0x0B,0xD0,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x38,0xC3,0xE8,0x5A,0x3F,0x73,0x5F,0xE8,0xA5,0xCF,0xAF,0xFF,0xCC};
; [0x7ff7c838bb40, 0x7ff7c838bccc], 396 bytes
; 2020-01-20 01:59:20:860
0000h sub rsp,38h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 38}
0004h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0007h mov rax,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 01}
000ah mov edx,[rcx+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 51 08}
000dh cmp rdx,40h                             ; CMP r/m64, imm8 || REX.W 83 /7 ib || encoded[4]{48 83 fa 40}
0011h jb near ptr 0186h                       ; JB rel32 || 0F 82 cd || encoded[6]{0f 82 6f 01 00 00}
0017h mov rdx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d0}
001ah vlddqu ymm0,ymmword ptr [rdx]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 02}
001eh lea rdx,[rax+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 50 20}
0022h vlddqu ymm1,ymmword ptr [rdx]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 0a}
0026h mov dword ptr [rsp+34h],0FFFFh          ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 34 ff ff 00 00}
002eh lea rdx,[rsp+34h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 54 24 34}
0033h vpbroadcastd ymm2,dword ptr [rsp+34h]   ; VPBROADCASTD ymm1, xmm2/m32 || VEX.256.66.0F38.W0 58 /r || encoded[7]{c4 e2 7d 58 54 24 34}
003ah vpand ymm0,ymm0,ymm2                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 fd db c2}
003eh vpand ymm1,ymm1,ymm2                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 f5 db ca}
0042h vpackusdw ymm0,ymm0,ymm1                ; VPACKUSDW ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 2B /r || encoded[5]{c4 e2 7d 2b c1}
0047h vpermq ymm0,ymm0,0D8h                   ; VPERMQ ymm1, ymm2/m256, imm8 || VEX.256.66.0F3A.W1 00 /r ib || encoded[6]{c4 e3 fd 00 c0 d8}
004dh lea rdx,[rax+40h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 50 40}
0051h vlddqu ymm1,ymmword ptr [rdx]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 0a}
0055h lea rdx,[rax+60h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 50 60}
0059h vlddqu ymm2,ymmword ptr [rdx]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 12}
005dh mov dword ptr [rsp+30h],0FFFFh          ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 30 ff ff 00 00}
0065h lea rdx,[rsp+30h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 54 24 30}
006ah vpbroadcastd ymm3,dword ptr [rsp+30h]   ; VPBROADCASTD ymm1, xmm2/m32 || VEX.256.66.0F38.W0 58 /r || encoded[7]{c4 e2 7d 58 5c 24 30}
0071h vpand ymm1,ymm1,ymm3                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 f5 db cb}
0075h vpand ymm2,ymm2,ymm3                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 ed db d3}
0079h vpackusdw ymm1,ymm1,ymm2                ; VPACKUSDW ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 2B /r || encoded[5]{c4 e2 75 2b ca}
007eh vpermq ymm1,ymm1,0D8h                   ; VPERMQ ymm1, ymm2/m256, imm8 || VEX.256.66.0F3A.W1 00 /r ib || encoded[6]{c4 e3 fd 00 c9 d8}
0084h mov dword ptr [rsp+2Ch],0FFh            ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 2c ff 00 00 00}
008ch lea rdx,[rsp+2Ch]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 54 24 2c}
0091h vpbroadcastw ymm2,word ptr [rsp+2Ch]    ; VPBROADCASTW ymm1, xmm2/m16 || VEX.256.66.0F38.W0 79 /r || encoded[7]{c4 e2 7d 79 54 24 2c}
0098h vpand ymm0,ymm0,ymm2                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 fd db c2}
009ch vpand ymm1,ymm1,ymm2                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 f5 db ca}
00a0h vpackuswb ymm0,ymm0,ymm1                ; VPACKUSWB ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG 67 /r || encoded[4]{c5 fd 67 c1}
00a4h vpermq ymm0,ymm0,0D8h                   ; VPERMQ ymm1, ymm2/m256, imm8 || VEX.256.66.0F3A.W1 00 /r ib || encoded[6]{c4 e3 fd 00 c0 d8}
00aah mov edx,7                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 07 00 00 00}
00afh vmovd xmm1,edx                          ; VMOVD xmm1, r/m32 || VEX.128.66.0F.W0 6E /r || encoded[4]{c5 f9 6e ca}
00b3h vpsllq ymm0,ymm0,xmm1                   ; VPSLLQ ymm1, ymm2, xmm3/m128 || VEX.256.66.0F.WIG F3 /r || encoded[4]{c5 fd f3 c1}
00b7h vpmovmskb edx,ymm0                      ; VPMOVMSKB r32, ymm1 || VEX.256.66.0F.W0 D7 /r || encoded[4]{c5 fd d7 d0}
00bbh mov edx,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b d2}
00bdh lea rcx,[rax+80h]                       ; LEA r64, m || REX.W 8D /r || encoded[7]{48 8d 88 80 00 00 00}
00c4h vlddqu ymm1,ymmword ptr [rcx]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 09}
00c8h lea rcx,[rax+0A0h]                      ; LEA r64, m || REX.W 8D /r || encoded[7]{48 8d 88 a0 00 00 00}
00cfh vlddqu ymm2,ymmword ptr [rcx]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 11}
00d3h mov dword ptr [rsp+28h],0FFFFh          ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 28 ff ff 00 00}
00dbh lea rcx,[rsp+28h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 4c 24 28}
00e0h vpbroadcastd ymm0,dword ptr [rsp+28h]   ; VPBROADCASTD ymm1, xmm2/m32 || VEX.256.66.0F38.W0 58 /r || encoded[7]{c4 e2 7d 58 44 24 28}
00e7h vpand ymm1,ymm1,ymm0                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 f5 db c8}
00ebh vpand ymm0,ymm2,ymm0                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 ed db c0}
00efh vpackusdw ymm0,ymm1,ymm0                ; VPACKUSDW ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 2B /r || encoded[5]{c4 e2 75 2b c0}
00f4h vpermq ymm0,ymm0,0D8h                   ; VPERMQ ymm1, ymm2/m256, imm8 || VEX.256.66.0F3A.W1 00 /r ib || encoded[6]{c4 e3 fd 00 c0 d8}
00fah lea rcx,[rax+0C0h]                      ; LEA r64, m || REX.W 8D /r || encoded[7]{48 8d 88 c0 00 00 00}
0101h vlddqu ymm1,ymmword ptr [rcx]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 09}
0105h add rax,0E0h                            ; ADD RAX, imm32 || REX.W 05 id || encoded[6]{48 05 e0 00 00 00}
010bh vlddqu ymm2,ymmword ptr [rax]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 10}
010fh mov dword ptr [rsp+24h],0FFFFh          ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 24 ff ff 00 00}
0117h lea rax,[rsp+24h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 24}
011ch vpbroadcastd ymm3,dword ptr [rsp+24h]   ; VPBROADCASTD ymm1, xmm2/m32 || VEX.256.66.0F38.W0 58 /r || encoded[7]{c4 e2 7d 58 5c 24 24}
0123h vpand ymm1,ymm1,ymm3                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 f5 db cb}
0127h vpand ymm2,ymm2,ymm3                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 ed db d3}
012bh vpackusdw ymm1,ymm1,ymm2                ; VPACKUSDW ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 2B /r || encoded[5]{c4 e2 75 2b ca}
0130h vpermq ymm1,ymm1,0D8h                   ; VPERMQ ymm1, ymm2/m256, imm8 || VEX.256.66.0F3A.W1 00 /r ib || encoded[6]{c4 e3 fd 00 c9 d8}
0136h mov dword ptr [rsp+20h],0FFh            ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 20 ff 00 00 00}
013eh lea rax,[rsp+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 20}
0143h vpbroadcastw ymm2,word ptr [rsp+20h]    ; VPBROADCASTW ymm1, xmm2/m16 || VEX.256.66.0F38.W0 79 /r || encoded[7]{c4 e2 7d 79 54 24 20}
014ah vpand ymm0,ymm0,ymm2                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 fd db c2}
014eh vpand ymm1,ymm1,ymm2                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 f5 db ca}
0152h vpackuswb ymm0,ymm0,ymm1                ; VPACKUSWB ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG 67 /r || encoded[4]{c5 fd 67 c1}
0156h vpermq ymm0,ymm0,0D8h                   ; VPERMQ ymm1, ymm2/m256, imm8 || VEX.256.66.0F3A.W1 00 /r ib || encoded[6]{c4 e3 fd 00 c0 d8}
015ch mov eax,7                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 07 00 00 00}
0161h vmovd xmm1,eax                          ; VMOVD xmm1, r/m32 || VEX.128.66.0F.W0 6E /r || encoded[4]{c5 f9 6e c8}
0165h vpsllq ymm0,ymm0,xmm1                   ; VPSLLQ ymm1, ymm2, xmm3/m128 || VEX.256.66.0F.WIG F3 /r || encoded[4]{c5 fd f3 c1}
0169h vpmovmskb eax,ymm0                      ; VPMOVMSKB r32, ymm1 || VEX.256.66.0F.W0 D7 /r || encoded[4]{c5 fd d7 c0}
016dh mov eax,eax                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c0}
016fh shl rax,20h                             ; SHL r/m64, imm8 || REX.W C1 /4 ib || encoded[4]{48 c1 e0 20}
0173h or rdx,rax                              ; OR r64, r/m64 || REX.W 0B /r || encoded[3]{48 0b d0}
0176h mov rax,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c2}
0179h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
017ch add rsp,38h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 38}
0180h ret                                     ; RET || C3 || encoded[1]{c3}
0181h call 7FF827ABFC20h                      ; CALL rel32 || E8 cd || encoded[5]{e8 5a 3f 73 5f}
0186h call 7FF7C7E88C70h                      ; CALL rel32 || E8 cd || encoded[5]{e8 a5 cf af ff}
018bh int 3                                   ; INT3 || CC || encoded[1]{cc}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; byte bitslice_8(BitSpan src, int offset, int count)
; static ReadOnlySpan<byte> bitslice_8_63830089Bytes => new byte[240]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x30,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0x8B,0xFA,0x41,0x8B,0xD8,0x48,0xB9,0x68,0x48,0x53,0xC8,0xF7,0x7F,0x00,0x00,0xBA,0x08,0x00,0x00,0x00,0xE8,0xA7,0xAC,0x60,0x5F,0x48,0x83,0xC0,0x10,0x48,0x8B,0xE8,0x41,0xBE,0x08,0x00,0x00,0x00,0x44,0x8B,0x46,0x08,0x44,0x2B,0xC7,0x41,0x3B,0xD8,0x7C,0x02,0xEB,0x03,0x44,0x8B,0xC3,0x48,0x8B,0x16,0x48,0x63,0xCF,0x48,0x8D,0x14,0x8A,0x41,0xC1,0xE0,0x02,0x48,0x8B,0xCD,0xE8,0xE3,0x9E,0x60,0x5F,0x41,0x8B,0xC6,0x48,0x83,0xF8,0x08,0x0F,0x82,0x80,0x00,0x00,0x00,0xC5,0xFF,0xF0,0x45,0x00,0xC4,0xE3,0x7D,0x19,0xC1,0x00,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC7,0x44,0x24,0x2C,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x2C,0xC4,0xE2,0x79,0x58,0x54,0x24,0x2C,0xC5,0xF1,0xDB,0xCA,0xC5,0xF9,0xDB,0xC2,0xC4,0xE2,0x71,0x2B,0xC0,0xC5,0xF0,0x57,0xC9,0xC7,0x44,0x24,0x28,0xFF,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x28,0xC4,0xE2,0x79,0x79,0x54,0x24,0x28,0xC5,0xF9,0xDB,0xC2,0xC5,0xF1,0xDB,0xCA,0xC5,0xF9,0x67,0xC1,0xB8,0x07,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xC8,0xC5,0xF9,0xF3,0xC1,0xC5,0xF9,0xD7,0xC0,0x0F,0xB7,0xC0,0x0F,0xB6,0xC0,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x30,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0xC3,0xE8,0x26,0x3A,0x73,0x5F,0xE8,0x71,0xCA,0xAF,0xFF,0xCC};
; [0x7ff7c838c110, 0x7ff7c838c200], 240 bytes
; 2020-01-20 01:59:20:861
0000h push r14                                ; PUSH r64 || 50+ro || encoded[2]{41 56}
0002h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0003h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0004h push rbp                                ; PUSH r64 || 50+ro || encoded[1]{55}
0005h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0006h sub rsp,30h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 30}
000ah vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
000dh mov rsi,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f1}
0010h mov edi,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b fa}
0012h mov ebx,r8d                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b d8}
0015h mov rcx,7FF7C8534868h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 68 48 53 c8 f7 7f 00 00}
001fh mov edx,8                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 08 00 00 00}
0024h call 7FF827996DE0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 a7 ac 60 5f}
0029h add rax,10h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c0 10}
002dh mov rbp,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b e8}
0030h mov r14d,8                              ; MOV r32, imm32 || o32 B8+rd id || encoded[6]{41 be 08 00 00 00}
0036h mov r8d,[rsi+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[4]{44 8b 46 08}
003ah sub r8d,edi                             ; SUB r32, r/m32 || o32 2B /r || encoded[3]{44 2b c7}
003dh cmp ebx,r8d                             ; CMP r32, r/m32 || o32 3B /r || encoded[3]{41 3b d8}
0040h jl short 0044h                          ; JL rel8 || 7C cb || encoded[2]{7c 02}
0042h jmp short 0047h                         ; JMP rel8 || EB cb || encoded[2]{eb 03}
0044h mov r8d,ebx                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{44 8b c3}
0047h mov rdx,[rsi]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 16}
004ah movsxd rcx,edi                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 cf}
004dh lea rdx,[rdx+rcx*4]                     ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 14 8a}
0051h shl r8d,2                               ; SHL r/m32, imm8 || o32 C1 /4 ib || encoded[4]{41 c1 e0 02}
0055h mov rcx,rbp                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b cd}
0058h call 7FF827996050h                      ; CALL rel32 || E8 cd || encoded[5]{e8 e3 9e 60 5f}
005dh mov eax,r14d                            ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b c6}
0060h cmp rax,8                               ; CMP r/m64, imm8 || REX.W 83 /7 ib || encoded[4]{48 83 f8 08}
0064h jb near ptr 00eah                       ; JB rel32 || 0F 82 cd || encoded[6]{0f 82 80 00 00 00}
006ah vlddqu ymm0,ymmword ptr [rbp]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[5]{c5 ff f0 45 00}
006fh vextractf128 xmm1,ymm0,0                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c1 00}
0075h vextractf128 xmm0,ymm0,1                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c0 01}
007bh mov dword ptr [rsp+2Ch],0FFFFh          ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 2c ff ff 00 00}
0083h lea rax,[rsp+2Ch]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 2c}
0088h vpbroadcastd xmm2,dword ptr [rsp+2Ch]   ; VPBROADCASTD xmm1, xmm2/m32 || VEX.128.66.0F38.W0 58 /r || encoded[7]{c4 e2 79 58 54 24 2c}
008fh vpand xmm1,xmm1,xmm2                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f1 db ca}
0093h vpand xmm0,xmm0,xmm2                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f9 db c2}
0097h vpackusdw xmm0,xmm1,xmm0                ; VPACKUSDW xmm1, xmm2, xmm3/m128 || VEX.128.66.0F38.WIG 2B /r || encoded[5]{c4 e2 71 2b c0}
009ch vxorps xmm1,xmm1,xmm1                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f0 57 c9}
00a0h mov dword ptr [rsp+28h],0FFh            ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 28 ff 00 00 00}
00a8h lea rax,[rsp+28h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 28}
00adh vpbroadcastw xmm2,word ptr [rsp+28h]    ; VPBROADCASTW xmm1, xmm2/m16 || VEX.128.66.0F38.W0 79 /r || encoded[7]{c4 e2 79 79 54 24 28}
00b4h vpand xmm0,xmm0,xmm2                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f9 db c2}
00b8h vpand xmm1,xmm1,xmm2                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f1 db ca}
00bch vpackuswb xmm0,xmm0,xmm1                ; VPACKUSWB xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG 67 /r || encoded[4]{c5 f9 67 c1}
00c0h mov eax,7                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 07 00 00 00}
00c5h vmovd xmm1,eax                          ; VMOVD xmm1, r/m32 || VEX.128.66.0F.W0 6E /r || encoded[4]{c5 f9 6e c8}
00c9h vpsllq xmm0,xmm0,xmm1                   ; VPSLLQ xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG F3 /r || encoded[4]{c5 f9 f3 c1}
00cdh vpmovmskb eax,xmm0                      ; VPMOVMSKB r32, xmm1 || VEX.128.66.0F.W0 D7 /r || encoded[4]{c5 f9 d7 c0}
00d1h movzx eax,ax                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c0}
00d4h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
00d7h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
00dah add rsp,30h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 30}
00deh pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
00dfh pop rbp                                 ; POP r64 || 58+ro || encoded[1]{5d}
00e0h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
00e1h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
00e2h pop r14                                 ; POP r64 || 58+ro || encoded[2]{41 5e}
00e4h ret                                     ; RET || C3 || encoded[1]{c3}
00e5h call 7FF827ABFC20h                      ; CALL rel32 || E8 cd || encoded[5]{e8 26 3a 73 5f}
00eah call 7FF7C7E88C70h                      ; CALL rel32 || E8 cd || encoded[5]{e8 71 ca af ff}
00efh int 3                                   ; INT3 || CC || encoded[1]{cc}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ushort bitslice_16(BitSpan src, int offset, int count)
; static ReadOnlySpan<byte> bitslice_16_37599894Bytes => new byte[250]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x30,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0x8B,0xFA,0x41,0x8B,0xD8,0x48,0xB9,0x68,0x48,0x53,0xC8,0xF7,0x7F,0x00,0x00,0xBA,0x10,0x00,0x00,0x00,0xE8,0x87,0xAB,0x60,0x5F,0x48,0x83,0xC0,0x10,0x48,0x8B,0xE8,0x41,0xBE,0x10,0x00,0x00,0x00,0x44,0x8B,0x46,0x08,0x44,0x2B,0xC7,0x41,0x3B,0xD8,0x7C,0x02,0xEB,0x03,0x44,0x8B,0xC3,0x48,0x8B,0x16,0x48,0x63,0xCF,0x48,0x8D,0x14,0x8A,0x41,0xC1,0xE0,0x02,0x48,0x8B,0xCD,0xE8,0xC3,0x9D,0x60,0x5F,0x41,0x8B,0xC6,0x48,0x83,0xF8,0x10,0x0F,0x82,0x8A,0x00,0x00,0x00,0x48,0x8B,0xC5,0xC5,0xFF,0xF0,0x00,0x48,0x83,0xC5,0x20,0xC5,0xFF,0xF0,0x4D,0x00,0xC7,0x44,0x24,0x2C,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x2C,0xC4,0xE2,0x7D,0x58,0x54,0x24,0x2C,0xC5,0xFD,0xDB,0xC2,0xC5,0xF5,0xDB,0xCA,0xC4,0xE2,0x7D,0x2B,0xC1,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC4,0xE3,0x7D,0x19,0xC1,0x00,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC7,0x44,0x24,0x28,0xFF,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x28,0xC4,0xE2,0x79,0x79,0x54,0x24,0x28,0xC5,0xF1,0xDB,0xCA,0xC5,0xF9,0xDB,0xC2,0xC5,0xF1,0x67,0xC0,0xB8,0x07,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xC8,0xC5,0xF9,0xF3,0xC1,0xC5,0xF9,0xD7,0xC0,0x0F,0xB7,0xC0,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x30,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0xC3,0xE8,0xFC,0x38,0x73,0x5F,0xE8,0x47,0xC9,0xAF,0xFF,0xCC};
; [0x7ff7c838c230, 0x7ff7c838c32a], 250 bytes
; 2020-01-20 01:59:20:861
0000h push r14                                ; PUSH r64 || 50+ro || encoded[2]{41 56}
0002h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0003h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0004h push rbp                                ; PUSH r64 || 50+ro || encoded[1]{55}
0005h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0006h sub rsp,30h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 30}
000ah vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
000dh mov rsi,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f1}
0010h mov edi,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b fa}
0012h mov ebx,r8d                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b d8}
0015h mov rcx,7FF7C8534868h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 68 48 53 c8 f7 7f 00 00}
001fh mov edx,10h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 10 00 00 00}
0024h call 7FF827996DE0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 87 ab 60 5f}
0029h add rax,10h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c0 10}
002dh mov rbp,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b e8}
0030h mov r14d,10h                            ; MOV r32, imm32 || o32 B8+rd id || encoded[6]{41 be 10 00 00 00}
0036h mov r8d,[rsi+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[4]{44 8b 46 08}
003ah sub r8d,edi                             ; SUB r32, r/m32 || o32 2B /r || encoded[3]{44 2b c7}
003dh cmp ebx,r8d                             ; CMP r32, r/m32 || o32 3B /r || encoded[3]{41 3b d8}
0040h jl short 0044h                          ; JL rel8 || 7C cb || encoded[2]{7c 02}
0042h jmp short 0047h                         ; JMP rel8 || EB cb || encoded[2]{eb 03}
0044h mov r8d,ebx                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{44 8b c3}
0047h mov rdx,[rsi]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 16}
004ah movsxd rcx,edi                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 cf}
004dh lea rdx,[rdx+rcx*4]                     ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 14 8a}
0051h shl r8d,2                               ; SHL r/m32, imm8 || o32 C1 /4 ib || encoded[4]{41 c1 e0 02}
0055h mov rcx,rbp                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b cd}
0058h call 7FF827996050h                      ; CALL rel32 || E8 cd || encoded[5]{e8 c3 9d 60 5f}
005dh mov eax,r14d                            ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b c6}
0060h cmp rax,10h                             ; CMP r/m64, imm8 || REX.W 83 /7 ib || encoded[4]{48 83 f8 10}
0064h jb near ptr 00f4h                       ; JB rel32 || 0F 82 cd || encoded[6]{0f 82 8a 00 00 00}
006ah mov rax,rbp                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c5}
006dh vlddqu ymm0,ymmword ptr [rax]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 00}
0071h add rbp,20h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c5 20}
0075h vlddqu ymm1,ymmword ptr [rbp]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[5]{c5 ff f0 4d 00}
007ah mov dword ptr [rsp+2Ch],0FFFFh          ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 2c ff ff 00 00}
0082h lea rax,[rsp+2Ch]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 2c}
0087h vpbroadcastd ymm2,dword ptr [rsp+2Ch]   ; VPBROADCASTD ymm1, xmm2/m32 || VEX.256.66.0F38.W0 58 /r || encoded[7]{c4 e2 7d 58 54 24 2c}
008eh vpand ymm0,ymm0,ymm2                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 fd db c2}
0092h vpand ymm1,ymm1,ymm2                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 f5 db ca}
0096h vpackusdw ymm0,ymm0,ymm1                ; VPACKUSDW ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 2B /r || encoded[5]{c4 e2 7d 2b c1}
009bh vpermq ymm0,ymm0,0D8h                   ; VPERMQ ymm1, ymm2/m256, imm8 || VEX.256.66.0F3A.W1 00 /r ib || encoded[6]{c4 e3 fd 00 c0 d8}
00a1h vextractf128 xmm1,ymm0,0                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c1 00}
00a7h vextractf128 xmm0,ymm0,1                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c0 01}
00adh mov dword ptr [rsp+28h],0FFh            ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 28 ff 00 00 00}
00b5h lea rax,[rsp+28h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 28}
00bah vpbroadcastw xmm2,word ptr [rsp+28h]    ; VPBROADCASTW xmm1, xmm2/m16 || VEX.128.66.0F38.W0 79 /r || encoded[7]{c4 e2 79 79 54 24 28}
00c1h vpand xmm1,xmm1,xmm2                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f1 db ca}
00c5h vpand xmm0,xmm0,xmm2                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f9 db c2}
00c9h vpackuswb xmm0,xmm1,xmm0                ; VPACKUSWB xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG 67 /r || encoded[4]{c5 f1 67 c0}
00cdh mov eax,7                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 07 00 00 00}
00d2h vmovd xmm1,eax                          ; VMOVD xmm1, r/m32 || VEX.128.66.0F.W0 6E /r || encoded[4]{c5 f9 6e c8}
00d6h vpsllq xmm0,xmm0,xmm1                   ; VPSLLQ xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG F3 /r || encoded[4]{c5 f9 f3 c1}
00dah vpmovmskb eax,xmm0                      ; VPMOVMSKB r32, xmm1 || VEX.128.66.0F.W0 D7 /r || encoded[4]{c5 f9 d7 c0}
00deh movzx eax,ax                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c0}
00e1h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
00e4h add rsp,30h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 30}
00e8h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
00e9h pop rbp                                 ; POP r64 || 58+ro || encoded[1]{5d}
00eah pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
00ebh pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
00ech pop r14                                 ; POP r64 || 58+ro || encoded[2]{41 5e}
00eeh ret                                     ; RET || C3 || encoded[1]{c3}
00efh call 7FF827ABFC20h                      ; CALL rel32 || E8 cd || encoded[5]{e8 fc 38 73 5f}
00f4h call 7FF7C7E88C70h                      ; CALL rel32 || E8 cd || encoded[5]{e8 47 c9 af ff}
00f9h int 3                                   ; INT3 || CC || encoded[1]{cc}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; uint bitslice_32(BitSpan src, int offset, int count)
; static ReadOnlySpan<byte> bitslice_32_2854726Bytes => new byte[296]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x30,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0x8B,0xFA,0x41,0x8B,0xD8,0x48,0xB9,0x68,0x48,0x53,0xC8,0xF7,0x7F,0x00,0x00,0xBA,0x20,0x00,0x00,0x00,0xE8,0x67,0xAA,0x60,0x5F,0x48,0x83,0xC0,0x10,0x48,0x8B,0xE8,0x41,0xBE,0x20,0x00,0x00,0x00,0x44,0x8B,0x46,0x08,0x44,0x2B,0xC7,0x41,0x3B,0xD8,0x7C,0x02,0xEB,0x03,0x44,0x8B,0xC3,0x48,0x8B,0x16,0x48,0x63,0xCF,0x48,0x8D,0x14,0x8A,0x41,0xC1,0xE0,0x02,0x48,0x8B,0xCD,0xE8,0xA3,0x9C,0x60,0x5F,0x41,0x8B,0xC6,0x48,0x83,0xF8,0x20,0x0F,0x82,0xB8,0x00,0x00,0x00,0x48,0x8B,0xC5,0xC5,0xFF,0xF0,0x00,0x48,0x8D,0x45,0x20,0xC5,0xFF,0xF0,0x08,0xC7,0x44,0x24,0x2C,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x2C,0xC4,0xE2,0x7D,0x58,0x54,0x24,0x2C,0xC5,0xFD,0xDB,0xC2,0xC5,0xF5,0xDB,0xCA,0xC4,0xE2,0x7D,0x2B,0xC1,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0x48,0x8D,0x45,0x40,0xC5,0xFF,0xF0,0x08,0x48,0x83,0xC5,0x60,0xC5,0xFF,0xF0,0x55,0x00,0xC7,0x44,0x24,0x28,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x28,0xC4,0xE2,0x7D,0x58,0x5C,0x24,0x28,0xC5,0xF5,0xDB,0xCB,0xC5,0xED,0xDB,0xD3,0xC4,0xE2,0x75,0x2B,0xCA,0xC4,0xE3,0xFD,0x00,0xC9,0xD8,0xC7,0x44,0x24,0x24,0xFF,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x24,0xC4,0xE2,0x7D,0x79,0x54,0x24,0x24,0xC5,0xFD,0xDB,0xC2,0xC5,0xF5,0xDB,0xCA,0xC5,0xFD,0x67,0xC1,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xB8,0x07,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xC8,0xC5,0xFD,0xF3,0xC1,0xC5,0xFD,0xD7,0xC0,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x30,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0xC3,0xE8,0xAE,0x37,0x73,0x5F,0xE8,0xF9,0xC7,0xAF,0xFF,0xCC};
; [0x7ff7c838c350, 0x7ff7c838c478], 296 bytes
; 2020-01-20 01:59:20:861
0000h push r14                                ; PUSH r64 || 50+ro || encoded[2]{41 56}
0002h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0003h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0004h push rbp                                ; PUSH r64 || 50+ro || encoded[1]{55}
0005h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0006h sub rsp,30h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 30}
000ah vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
000dh mov rsi,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f1}
0010h mov edi,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b fa}
0012h mov ebx,r8d                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b d8}
0015h mov rcx,7FF7C8534868h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 68 48 53 c8 f7 7f 00 00}
001fh mov edx,20h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 20 00 00 00}
0024h call 7FF827996DE0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 67 aa 60 5f}
0029h add rax,10h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c0 10}
002dh mov rbp,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b e8}
0030h mov r14d,20h                            ; MOV r32, imm32 || o32 B8+rd id || encoded[6]{41 be 20 00 00 00}
0036h mov r8d,[rsi+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[4]{44 8b 46 08}
003ah sub r8d,edi                             ; SUB r32, r/m32 || o32 2B /r || encoded[3]{44 2b c7}
003dh cmp ebx,r8d                             ; CMP r32, r/m32 || o32 3B /r || encoded[3]{41 3b d8}
0040h jl short 0044h                          ; JL rel8 || 7C cb || encoded[2]{7c 02}
0042h jmp short 0047h                         ; JMP rel8 || EB cb || encoded[2]{eb 03}
0044h mov r8d,ebx                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{44 8b c3}
0047h mov rdx,[rsi]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 16}
004ah movsxd rcx,edi                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 cf}
004dh lea rdx,[rdx+rcx*4]                     ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 14 8a}
0051h shl r8d,2                               ; SHL r/m32, imm8 || o32 C1 /4 ib || encoded[4]{41 c1 e0 02}
0055h mov rcx,rbp                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b cd}
0058h call 7FF827996050h                      ; CALL rel32 || E8 cd || encoded[5]{e8 a3 9c 60 5f}
005dh mov eax,r14d                            ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b c6}
0060h cmp rax,20h                             ; CMP r/m64, imm8 || REX.W 83 /7 ib || encoded[4]{48 83 f8 20}
0064h jb near ptr 0122h                       ; JB rel32 || 0F 82 cd || encoded[6]{0f 82 b8 00 00 00}
006ah mov rax,rbp                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c5}
006dh vlddqu ymm0,ymmword ptr [rax]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 00}
0071h lea rax,[rbp+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 45 20}
0075h vlddqu ymm1,ymmword ptr [rax]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 08}
0079h mov dword ptr [rsp+2Ch],0FFFFh          ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 2c ff ff 00 00}
0081h lea rax,[rsp+2Ch]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 2c}
0086h vpbroadcastd ymm2,dword ptr [rsp+2Ch]   ; VPBROADCASTD ymm1, xmm2/m32 || VEX.256.66.0F38.W0 58 /r || encoded[7]{c4 e2 7d 58 54 24 2c}
008dh vpand ymm0,ymm0,ymm2                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 fd db c2}
0091h vpand ymm1,ymm1,ymm2                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 f5 db ca}
0095h vpackusdw ymm0,ymm0,ymm1                ; VPACKUSDW ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 2B /r || encoded[5]{c4 e2 7d 2b c1}
009ah vpermq ymm0,ymm0,0D8h                   ; VPERMQ ymm1, ymm2/m256, imm8 || VEX.256.66.0F3A.W1 00 /r ib || encoded[6]{c4 e3 fd 00 c0 d8}
00a0h lea rax,[rbp+40h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 45 40}
00a4h vlddqu ymm1,ymmword ptr [rax]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 08}
00a8h add rbp,60h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c5 60}
00ach vlddqu ymm2,ymmword ptr [rbp]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[5]{c5 ff f0 55 00}
00b1h mov dword ptr [rsp+28h],0FFFFh          ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 28 ff ff 00 00}
00b9h lea rax,[rsp+28h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 28}
00beh vpbroadcastd ymm3,dword ptr [rsp+28h]   ; VPBROADCASTD ymm1, xmm2/m32 || VEX.256.66.0F38.W0 58 /r || encoded[7]{c4 e2 7d 58 5c 24 28}
00c5h vpand ymm1,ymm1,ymm3                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 f5 db cb}
00c9h vpand ymm2,ymm2,ymm3                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 ed db d3}
00cdh vpackusdw ymm1,ymm1,ymm2                ; VPACKUSDW ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 2B /r || encoded[5]{c4 e2 75 2b ca}
00d2h vpermq ymm1,ymm1,0D8h                   ; VPERMQ ymm1, ymm2/m256, imm8 || VEX.256.66.0F3A.W1 00 /r ib || encoded[6]{c4 e3 fd 00 c9 d8}
00d8h mov dword ptr [rsp+24h],0FFh            ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 24 ff 00 00 00}
00e0h lea rax,[rsp+24h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 24}
00e5h vpbroadcastw ymm2,word ptr [rsp+24h]    ; VPBROADCASTW ymm1, xmm2/m16 || VEX.256.66.0F38.W0 79 /r || encoded[7]{c4 e2 7d 79 54 24 24}
00ech vpand ymm0,ymm0,ymm2                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 fd db c2}
00f0h vpand ymm1,ymm1,ymm2                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 f5 db ca}
00f4h vpackuswb ymm0,ymm0,ymm1                ; VPACKUSWB ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG 67 /r || encoded[4]{c5 fd 67 c1}
00f8h vpermq ymm0,ymm0,0D8h                   ; VPERMQ ymm1, ymm2/m256, imm8 || VEX.256.66.0F3A.W1 00 /r ib || encoded[6]{c4 e3 fd 00 c0 d8}
00feh mov eax,7                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 07 00 00 00}
0103h vmovd xmm1,eax                          ; VMOVD xmm1, r/m32 || VEX.128.66.0F.W0 6E /r || encoded[4]{c5 f9 6e c8}
0107h vpsllq ymm0,ymm0,xmm1                   ; VPSLLQ ymm1, ymm2, xmm3/m128 || VEX.256.66.0F.WIG F3 /r || encoded[4]{c5 fd f3 c1}
010bh vpmovmskb eax,ymm0                      ; VPMOVMSKB r32, ymm1 || VEX.256.66.0F.W0 D7 /r || encoded[4]{c5 fd d7 c0}
010fh vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0112h add rsp,30h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 30}
0116h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
0117h pop rbp                                 ; POP r64 || 58+ro || encoded[1]{5d}
0118h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
0119h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
011ah pop r14                                 ; POP r64 || 58+ro || encoded[2]{41 5e}
011ch ret                                     ; RET || C3 || encoded[1]{c3}
011dh call 7FF827ABFC20h                      ; CALL rel32 || E8 cd || encoded[5]{e8 ae 37 73 5f}
0122h call 7FF7C7E88C70h                      ; CALL rel32 || E8 cd || encoded[5]{e8 f9 c7 af ff}
0127h int 3                                   ; INT3 || CC || encoded[1]{cc}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong bitslice_64(BitSpan src, int offset, int count)
; static ReadOnlySpan<byte> bitslice_64_25692540Bytes => new byte[484]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0x8B,0xFA,0x41,0x8B,0xD8,0x48,0xB9,0x68,0x48,0x53,0xC8,0xF7,0x7F,0x00,0x00,0xBA,0x40,0x00,0x00,0x00,0xE8,0x07,0xA9,0x60,0x5F,0x48,0x83,0xC0,0x10,0x48,0x8B,0xE8,0x41,0xBE,0x40,0x00,0x00,0x00,0x44,0x8B,0x46,0x08,0x44,0x2B,0xC7,0x41,0x3B,0xD8,0x7C,0x02,0xEB,0x03,0x44,0x8B,0xC3,0x48,0x8B,0x16,0x48,0x63,0xCF,0x48,0x8D,0x14,0x8A,0x41,0xC1,0xE0,0x02,0x48,0x8B,0xCD,0xE8,0x43,0x9B,0x60,0x5F,0x41,0x8B,0xC6,0x48,0x83,0xF8,0x40,0x0F,0x82,0x74,0x01,0x00,0x00,0x48,0x8B,0xC5,0xC5,0xFF,0xF0,0x00,0x48,0x8D,0x45,0x20,0xC5,0xFF,0xF0,0x08,0xC7,0x44,0x24,0x3C,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x3C,0xC4,0xE2,0x7D,0x58,0x54,0x24,0x3C,0xC5,0xFD,0xDB,0xC2,0xC5,0xF5,0xDB,0xCA,0xC4,0xE2,0x7D,0x2B,0xC1,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0x48,0x8D,0x45,0x40,0xC5,0xFF,0xF0,0x08,0x48,0x8D,0x45,0x60,0xC5,0xFF,0xF0,0x10,0xC7,0x44,0x24,0x38,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x38,0xC4,0xE2,0x7D,0x58,0x5C,0x24,0x38,0xC5,0xF5,0xDB,0xCB,0xC5,0xED,0xDB,0xD3,0xC4,0xE2,0x75,0x2B,0xCA,0xC4,0xE3,0xFD,0x00,0xC9,0xD8,0xC7,0x44,0x24,0x34,0xFF,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x34,0xC4,0xE2,0x7D,0x79,0x54,0x24,0x34,0xC5,0xFD,0xDB,0xC2,0xC5,0xF5,0xDB,0xCA,0xC5,0xFD,0x67,0xC1,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xB8,0x07,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xC8,0xC5,0xFD,0xF3,0xC1,0xC5,0xFD,0xD7,0xC0,0x8B,0xC0,0x48,0x8D,0x95,0x80,0x00,0x00,0x00,0xC5,0xFF,0xF0,0x0A,0x48,0x8D,0x95,0xA0,0x00,0x00,0x00,0xC5,0xFF,0xF0,0x12,0xC7,0x44,0x24,0x30,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x54,0x24,0x30,0xC4,0xE2,0x7D,0x58,0x44,0x24,0x30,0xC5,0xF5,0xDB,0xC8,0xC5,0xED,0xDB,0xC0,0xC4,0xE2,0x75,0x2B,0xC0,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0x48,0x8D,0x95,0xC0,0x00,0x00,0x00,0xC5,0xFF,0xF0,0x0A,0x48,0x81,0xC5,0xE0,0x00,0x00,0x00,0xC5,0xFF,0xF0,0x55,0x00,0xC7,0x44,0x24,0x2C,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x54,0x24,0x2C,0xC4,0xE2,0x7D,0x58,0x5C,0x24,0x2C,0xC5,0xF5,0xDB,0xCB,0xC5,0xED,0xDB,0xD3,0xC4,0xE2,0x75,0x2B,0xCA,0xC4,0xE3,0xFD,0x00,0xC9,0xD8,0xC7,0x44,0x24,0x28,0xFF,0x00,0x00,0x00,0x48,0x8D,0x54,0x24,0x28,0xC4,0xE2,0x7D,0x79,0x54,0x24,0x28,0xC5,0xFD,0xDB,0xC2,0xC5,0xF5,0xDB,0xCA,0xC5,0xFD,0x67,0xC1,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xBA,0x07,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xCA,0xC5,0xFD,0xF3,0xC1,0xC5,0xFD,0xD7,0xD0,0x8B,0xD2,0x48,0xC1,0xE2,0x20,0x48,0x0B,0xC2,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x40,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0xC3,0xE8,0x92,0x35,0x73,0x5F,0xE8,0xDD,0xC5,0xAF,0xFF,0xCC};
; [0x7ff7c838c4b0, 0x7ff7c838c694], 484 bytes
; 2020-01-20 01:59:20:861
0000h push r14                                ; PUSH r64 || 50+ro || encoded[2]{41 56}
0002h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0003h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0004h push rbp                                ; PUSH r64 || 50+ro || encoded[1]{55}
0005h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0006h sub rsp,40h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 40}
000ah vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
000dh mov rsi,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f1}
0010h mov edi,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b fa}
0012h mov ebx,r8d                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b d8}
0015h mov rcx,7FF7C8534868h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 68 48 53 c8 f7 7f 00 00}
001fh mov edx,40h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 40 00 00 00}
0024h call 7FF827996DE0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 07 a9 60 5f}
0029h add rax,10h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c0 10}
002dh mov rbp,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b e8}
0030h mov r14d,40h                            ; MOV r32, imm32 || o32 B8+rd id || encoded[6]{41 be 40 00 00 00}
0036h mov r8d,[rsi+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[4]{44 8b 46 08}
003ah sub r8d,edi                             ; SUB r32, r/m32 || o32 2B /r || encoded[3]{44 2b c7}
003dh cmp ebx,r8d                             ; CMP r32, r/m32 || o32 3B /r || encoded[3]{41 3b d8}
0040h jl short 0044h                          ; JL rel8 || 7C cb || encoded[2]{7c 02}
0042h jmp short 0047h                         ; JMP rel8 || EB cb || encoded[2]{eb 03}
0044h mov r8d,ebx                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{44 8b c3}
0047h mov rdx,[rsi]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 16}
004ah movsxd rcx,edi                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 cf}
004dh lea rdx,[rdx+rcx*4]                     ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 14 8a}
0051h shl r8d,2                               ; SHL r/m32, imm8 || o32 C1 /4 ib || encoded[4]{41 c1 e0 02}
0055h mov rcx,rbp                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b cd}
0058h call 7FF827996050h                      ; CALL rel32 || E8 cd || encoded[5]{e8 43 9b 60 5f}
005dh mov eax,r14d                            ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b c6}
0060h cmp rax,40h                             ; CMP r/m64, imm8 || REX.W 83 /7 ib || encoded[4]{48 83 f8 40}
0064h jb near ptr 01deh                       ; JB rel32 || 0F 82 cd || encoded[6]{0f 82 74 01 00 00}
006ah mov rax,rbp                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c5}
006dh vlddqu ymm0,ymmword ptr [rax]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 00}
0071h lea rax,[rbp+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 45 20}
0075h vlddqu ymm1,ymmword ptr [rax]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 08}
0079h mov dword ptr [rsp+3Ch],0FFFFh          ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 3c ff ff 00 00}
0081h lea rax,[rsp+3Ch]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 3c}
0086h vpbroadcastd ymm2,dword ptr [rsp+3Ch]   ; VPBROADCASTD ymm1, xmm2/m32 || VEX.256.66.0F38.W0 58 /r || encoded[7]{c4 e2 7d 58 54 24 3c}
008dh vpand ymm0,ymm0,ymm2                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 fd db c2}
0091h vpand ymm1,ymm1,ymm2                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 f5 db ca}
0095h vpackusdw ymm0,ymm0,ymm1                ; VPACKUSDW ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 2B /r || encoded[5]{c4 e2 7d 2b c1}
009ah vpermq ymm0,ymm0,0D8h                   ; VPERMQ ymm1, ymm2/m256, imm8 || VEX.256.66.0F3A.W1 00 /r ib || encoded[6]{c4 e3 fd 00 c0 d8}
00a0h lea rax,[rbp+40h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 45 40}
00a4h vlddqu ymm1,ymmword ptr [rax]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 08}
00a8h lea rax,[rbp+60h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 45 60}
00ach vlddqu ymm2,ymmword ptr [rax]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 10}
00b0h mov dword ptr [rsp+38h],0FFFFh          ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 38 ff ff 00 00}
00b8h lea rax,[rsp+38h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 38}
00bdh vpbroadcastd ymm3,dword ptr [rsp+38h]   ; VPBROADCASTD ymm1, xmm2/m32 || VEX.256.66.0F38.W0 58 /r || encoded[7]{c4 e2 7d 58 5c 24 38}
00c4h vpand ymm1,ymm1,ymm3                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 f5 db cb}
00c8h vpand ymm2,ymm2,ymm3                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 ed db d3}
00cch vpackusdw ymm1,ymm1,ymm2                ; VPACKUSDW ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 2B /r || encoded[5]{c4 e2 75 2b ca}
00d1h vpermq ymm1,ymm1,0D8h                   ; VPERMQ ymm1, ymm2/m256, imm8 || VEX.256.66.0F3A.W1 00 /r ib || encoded[6]{c4 e3 fd 00 c9 d8}
00d7h mov dword ptr [rsp+34h],0FFh            ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 34 ff 00 00 00}
00dfh lea rax,[rsp+34h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 34}
00e4h vpbroadcastw ymm2,word ptr [rsp+34h]    ; VPBROADCASTW ymm1, xmm2/m16 || VEX.256.66.0F38.W0 79 /r || encoded[7]{c4 e2 7d 79 54 24 34}
00ebh vpand ymm0,ymm0,ymm2                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 fd db c2}
00efh vpand ymm1,ymm1,ymm2                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 f5 db ca}
00f3h vpackuswb ymm0,ymm0,ymm1                ; VPACKUSWB ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG 67 /r || encoded[4]{c5 fd 67 c1}
00f7h vpermq ymm0,ymm0,0D8h                   ; VPERMQ ymm1, ymm2/m256, imm8 || VEX.256.66.0F3A.W1 00 /r ib || encoded[6]{c4 e3 fd 00 c0 d8}
00fdh mov eax,7                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 07 00 00 00}
0102h vmovd xmm1,eax                          ; VMOVD xmm1, r/m32 || VEX.128.66.0F.W0 6E /r || encoded[4]{c5 f9 6e c8}
0106h vpsllq ymm0,ymm0,xmm1                   ; VPSLLQ ymm1, ymm2, xmm3/m128 || VEX.256.66.0F.WIG F3 /r || encoded[4]{c5 fd f3 c1}
010ah vpmovmskb eax,ymm0                      ; VPMOVMSKB r32, ymm1 || VEX.256.66.0F.W0 D7 /r || encoded[4]{c5 fd d7 c0}
010eh mov eax,eax                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c0}
0110h lea rdx,[rbp+80h]                       ; LEA r64, m || REX.W 8D /r || encoded[7]{48 8d 95 80 00 00 00}
0117h vlddqu ymm1,ymmword ptr [rdx]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 0a}
011bh lea rdx,[rbp+0A0h]                      ; LEA r64, m || REX.W 8D /r || encoded[7]{48 8d 95 a0 00 00 00}
0122h vlddqu ymm2,ymmword ptr [rdx]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 12}
0126h mov dword ptr [rsp+30h],0FFFFh          ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 30 ff ff 00 00}
012eh lea rdx,[rsp+30h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 54 24 30}
0133h vpbroadcastd ymm0,dword ptr [rsp+30h]   ; VPBROADCASTD ymm1, xmm2/m32 || VEX.256.66.0F38.W0 58 /r || encoded[7]{c4 e2 7d 58 44 24 30}
013ah vpand ymm1,ymm1,ymm0                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 f5 db c8}
013eh vpand ymm0,ymm2,ymm0                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 ed db c0}
0142h vpackusdw ymm0,ymm1,ymm0                ; VPACKUSDW ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 2B /r || encoded[5]{c4 e2 75 2b c0}
0147h vpermq ymm0,ymm0,0D8h                   ; VPERMQ ymm1, ymm2/m256, imm8 || VEX.256.66.0F3A.W1 00 /r ib || encoded[6]{c4 e3 fd 00 c0 d8}
014dh lea rdx,[rbp+0C0h]                      ; LEA r64, m || REX.W 8D /r || encoded[7]{48 8d 95 c0 00 00 00}
0154h vlddqu ymm1,ymmword ptr [rdx]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 0a}
0158h add rbp,0E0h                            ; ADD r/m64, imm32 || REX.W 81 /0 id || encoded[7]{48 81 c5 e0 00 00 00}
015fh vlddqu ymm2,ymmword ptr [rbp]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[5]{c5 ff f0 55 00}
0164h mov dword ptr [rsp+2Ch],0FFFFh          ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 2c ff ff 00 00}
016ch lea rdx,[rsp+2Ch]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 54 24 2c}
0171h vpbroadcastd ymm3,dword ptr [rsp+2Ch]   ; VPBROADCASTD ymm1, xmm2/m32 || VEX.256.66.0F38.W0 58 /r || encoded[7]{c4 e2 7d 58 5c 24 2c}
0178h vpand ymm1,ymm1,ymm3                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 f5 db cb}
017ch vpand ymm2,ymm2,ymm3                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 ed db d3}
0180h vpackusdw ymm1,ymm1,ymm2                ; VPACKUSDW ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 2B /r || encoded[5]{c4 e2 75 2b ca}
0185h vpermq ymm1,ymm1,0D8h                   ; VPERMQ ymm1, ymm2/m256, imm8 || VEX.256.66.0F3A.W1 00 /r ib || encoded[6]{c4 e3 fd 00 c9 d8}
018bh mov dword ptr [rsp+28h],0FFh            ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 28 ff 00 00 00}
0193h lea rdx,[rsp+28h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 54 24 28}
0198h vpbroadcastw ymm2,word ptr [rsp+28h]    ; VPBROADCASTW ymm1, xmm2/m16 || VEX.256.66.0F38.W0 79 /r || encoded[7]{c4 e2 7d 79 54 24 28}
019fh vpand ymm0,ymm0,ymm2                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 fd db c2}
01a3h vpand ymm1,ymm1,ymm2                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 f5 db ca}
01a7h vpackuswb ymm0,ymm0,ymm1                ; VPACKUSWB ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG 67 /r || encoded[4]{c5 fd 67 c1}
01abh vpermq ymm0,ymm0,0D8h                   ; VPERMQ ymm1, ymm2/m256, imm8 || VEX.256.66.0F3A.W1 00 /r ib || encoded[6]{c4 e3 fd 00 c0 d8}
01b1h mov edx,7                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 07 00 00 00}
01b6h vmovd xmm1,edx                          ; VMOVD xmm1, r/m32 || VEX.128.66.0F.W0 6E /r || encoded[4]{c5 f9 6e ca}
01bah vpsllq ymm0,ymm0,xmm1                   ; VPSLLQ ymm1, ymm2, xmm3/m128 || VEX.256.66.0F.WIG F3 /r || encoded[4]{c5 fd f3 c1}
01beh vpmovmskb edx,ymm0                      ; VPMOVMSKB r32, ymm1 || VEX.256.66.0F.W0 D7 /r || encoded[4]{c5 fd d7 d0}
01c2h mov edx,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b d2}
01c4h shl rdx,20h                             ; SHL r/m64, imm8 || REX.W C1 /4 ib || encoded[4]{48 c1 e2 20}
01c8h or rax,rdx                              ; OR r64, r/m64 || REX.W 0B /r || encoded[3]{48 0b c2}
01cbh vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
01ceh add rsp,40h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 40}
01d2h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
01d3h pop rbp                                 ; POP r64 || 58+ro || encoded[1]{5d}
01d4h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
01d5h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
01d6h pop r14                                 ; POP r64 || 58+ro || encoded[2]{41 5e}
01d8h ret                                     ; RET || C3 || encoded[1]{c3}
01d9h call 7FF827ABFC20h                      ; CALL rel32 || E8 cd || encoded[5]{e8 92 35 73 5f}
01deh call 7FF7C7E88C70h                      ; CALL rel32 || E8 cd || encoded[5]{e8 dd c5 af ff}
01e3h int 3                                   ; INT3 || CC || encoded[1]{cc}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ref BitSpan and(in BitSpan x, in BitSpan y, in BitSpan z)
; static ReadOnlySpan<byte> and_0xBytes => new byte[60]{0x57,0x56,0x0F,0x1F,0x00,0x41,0x8B,0x40,0x08,0x45,0x33,0xC9,0x85,0xC0,0x7E,0x26,0x4D,0x8B,0x10,0x4D,0x63,0xD9,0x4F,0x8D,0x14,0x9A,0x48,0x8B,0x31,0x42,0x8B,0x34,0x9E,0x48,0x8B,0x3A,0x46,0x8B,0x1C,0x9F,0x44,0x23,0xDE,0x45,0x89,0x1A,0x41,0xFF,0xC1,0x44,0x3B,0xC8,0x7C,0xDA,0x49,0x8B,0xC0,0x5E,0x5F,0xC3};
; [0x7ff7c838c6d0, 0x7ff7c838c70c], 60 bytes
; 2020-01-20 01:59:20:861
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h nop dword ptr [rax]                     ; NOP r/m32 || o32 0F 1F /0 || encoded[3]{0f 1f 00}
0005h mov eax,[r8+8]                          ; MOV r32, r/m32 || o32 8B /r || encoded[4]{41 8b 40 08}
0009h xor r9d,r9d                             ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 c9}
000ch test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
000eh jle short 0036h                         ; JLE rel8 || 7E cb || encoded[2]{7e 26}
0010h mov r10,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b 10}
0013h movsxd r11,r9d                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4d 63 d9}
0016h lea r10,[r10+r11*4]                     ; LEA r64, m || REX.W 8D /r || encoded[4]{4f 8d 14 9a}
001ah mov rsi,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 31}
001dh mov esi,[rsi+r11*4]                     ; MOV r32, r/m32 || o32 8B /r || encoded[4]{42 8b 34 9e}
0021h mov rdi,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 3a}
0024h mov r11d,[rdi+r11*4]                    ; MOV r32, r/m32 || o32 8B /r || encoded[4]{46 8b 1c 9f}
0028h and r11d,esi                            ; AND r32, r/m32 || o32 23 /r || encoded[3]{44 23 de}
002bh mov [r10],r11d                          ; MOV r/m32, r32 || o32 89 /r || encoded[3]{45 89 1a}
002eh inc r9d                                 ; INC r/m32 || o32 FF /0 || encoded[3]{41 ff c1}
0031h cmp r9d,eax                             ; CMP r32, r/m32 || o32 3B /r || encoded[3]{44 3b c8}
0034h jl short 0010h                          ; JL rel8 || 7C cb || encoded[2]{7c da}
0036h mov rax,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b c0}
0039h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
003ah pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
003bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ref BitSpan xor(in BitSpan x, in BitSpan y, in BitSpan z)
; static ReadOnlySpan<byte> xor_0xBytes => new byte[60]{0x57,0x56,0x0F,0x1F,0x00,0x41,0x8B,0x40,0x08,0x45,0x33,0xC9,0x85,0xC0,0x7E,0x26,0x4D,0x8B,0x10,0x4D,0x63,0xD9,0x4F,0x8D,0x14,0x9A,0x48,0x8B,0x31,0x42,0x8B,0x34,0x9E,0x48,0x8B,0x3A,0x46,0x8B,0x1C,0x9F,0x44,0x33,0xDE,0x45,0x89,0x1A,0x41,0xFF,0xC1,0x44,0x3B,0xC8,0x7C,0xDA,0x49,0x8B,0xC0,0x5E,0x5F,0xC3};
; [0x7ff7c838c720, 0x7ff7c838c75c], 60 bytes
; 2020-01-20 01:59:20:861
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h nop dword ptr [rax]                     ; NOP r/m32 || o32 0F 1F /0 || encoded[3]{0f 1f 00}
0005h mov eax,[r8+8]                          ; MOV r32, r/m32 || o32 8B /r || encoded[4]{41 8b 40 08}
0009h xor r9d,r9d                             ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 c9}
000ch test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
000eh jle short 0036h                         ; JLE rel8 || 7E cb || encoded[2]{7e 26}
0010h mov r10,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b 10}
0013h movsxd r11,r9d                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4d 63 d9}
0016h lea r10,[r10+r11*4]                     ; LEA r64, m || REX.W 8D /r || encoded[4]{4f 8d 14 9a}
001ah mov rsi,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 31}
001dh mov esi,[rsi+r11*4]                     ; MOV r32, r/m32 || o32 8B /r || encoded[4]{42 8b 34 9e}
0021h mov rdi,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 3a}
0024h mov r11d,[rdi+r11*4]                    ; MOV r32, r/m32 || o32 8B /r || encoded[4]{46 8b 1c 9f}
0028h xor r11d,esi                            ; XOR r32, r/m32 || o32 33 /r || encoded[3]{44 33 de}
002bh mov [r10],r11d                          ; MOV r/m32, r32 || o32 89 /r || encoded[3]{45 89 1a}
002eh inc r9d                                 ; INC r/m32 || o32 FF /0 || encoded[3]{41 ff c1}
0031h cmp r9d,eax                             ; CMP r32, r/m32 || o32 3B /r || encoded[3]{44 3b c8}
0034h jl short 0010h                          ; JL rel8 || 7C cb || encoded[2]{7c da}
0036h mov rax,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b c0}
0039h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
003ah pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
003bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
