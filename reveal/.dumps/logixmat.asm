; 2020-01-20 01:59:21:136
; ref BitMatrix<ulong> or_and_xor_bm(in BitMatrix<ulong> a, in BitMatrix<ulong> b, ref BitMatrix<ulong> C)
; static ReadOnlySpan<byte> or_and_xor_bm_0xBytes => new byte[243]{0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x58,0xC5,0xF8,0x77,0x48,0x8B,0x01,0x4C,0x8B,0x0A,0x4D,0x8B,0x10,0x45,0x33,0xDB,0x33,0xF6,0x48,0x63,0xFE,0x48,0xC1,0xE7,0x03,0x48,0x8D,0x1C,0x38,0x49,0x8D,0x2C,0x39,0xC5,0xFF,0xF0,0x03,0xC5,0xFF,0xF0,0x4D,0x00,0xC5,0xFD,0xDB,0xC1,0x49,0x03,0xFA,0xC5,0xFE,0x7F,0x07,0x41,0xFF,0xC3,0x83,0xC6,0x04,0x41,0x83,0xFB,0x10,0x7C,0xD1,0x49,0x8B,0xC0,0x48,0x8B,0x09,0x48,0x8B,0x12,0x48,0x8B,0x00,0x45,0x33,0xC9,0x45,0x33,0xD2,0x4D,0x63,0xDA,0x49,0xC1,0xE3,0x03,0x4A,0x8D,0x34,0x19,0x4A,0x8D,0x3C,0x1A,0xC5,0xFF,0xF0,0x06,0xC5,0xFF,0xF0,0x0F,0xC5,0xFD,0xEF,0xC1,0x4C,0x03,0xD8,0xC4,0xC1,0x7E,0x7F,0x03,0x41,0xFF,0xC1,0x41,0x83,0xC2,0x04,0x41,0x83,0xF9,0x10,0x7C,0xD0,0x49,0x8B,0x00,0x33,0xD2,0x33,0xC9,0x4C,0x63,0xC9,0x4E,0x8D,0x0C,0xC8,0x4D,0x8B,0xD1,0x4D,0x8B,0xD9,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x04,0x24,0xC4,0xC1,0x7F,0xF0,0x02,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC4,0xC1,0x7F,0xF0,0x03,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFD,0x10,0x44,0x24,0x20,0xC5,0xFD,0x10,0x0C,0x24,0xC5,0xFD,0xEB,0xC1,0xC4,0xC1,0x7E,0x7F,0x01,0xFF,0xC2,0x83,0xC1,0x04,0x83,0xFA,0x10,0x7C,0xAD,0x49,0x8B,0xC0,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x58,0x5B,0x5D,0x5E,0x5F,0xC3};
; [0x7ff7c83963c0, 0x7ff7c83964b3], 243 bytes
; 2020-01-20 01:59:21:136
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbp                                ; PUSH r64 || 50+ro || encoded[1]{55}
0003h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0004h sub rsp,58h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 58}
0008h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
000bh mov rax,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 01}
000eh mov r9,[rdx]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b 0a}
0011h mov r10,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b 10}
0014h xor r11d,r11d                           ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 db}
0017h xor esi,esi                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 f6}
0019h movsxd rdi,esi                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 fe}
001ch shl rdi,3                               ; SHL r/m64, imm8 || REX.W C1 /4 ib || encoded[4]{48 c1 e7 03}
0020h lea rbx,[rax+rdi]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 1c 38}
0024h lea rbp,[r9+rdi]                        ; LEA r64, m || REX.W 8D /r || encoded[4]{49 8d 2c 39}
0028h vlddqu ymm0,ymmword ptr [rbx]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 03}
002ch vlddqu ymm1,ymmword ptr [rbp]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[5]{c5 ff f0 4d 00}
0031h vpand ymm0,ymm0,ymm1                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 fd db c1}
0035h add rdi,r10                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{49 03 fa}
0038h vmovdqu ymmword ptr [rdi],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 07}
003ch inc r11d                                ; INC r/m32 || o32 FF /0 || encoded[3]{41 ff c3}
003fh add esi,4                               ; ADD r/m32, imm8 || o32 83 /0 ib || encoded[3]{83 c6 04}
0042h cmp r11d,10h                            ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[4]{41 83 fb 10}
0046h jl short 0019h                          ; JL rel8 || 7C cb || encoded[2]{7c d1}
0048h mov rax,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b c0}
004bh mov rcx,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 09}
004eh mov rdx,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 12}
0051h mov rax,[rax]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 00}
0054h xor r9d,r9d                             ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 c9}
0057h xor r10d,r10d                           ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 d2}
005ah movsxd r11,r10d                         ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4d 63 da}
005dh shl r11,3                               ; SHL r/m64, imm8 || REX.W C1 /4 ib || encoded[4]{49 c1 e3 03}
0061h lea rsi,[rcx+r11]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{4a 8d 34 19}
0065h lea rdi,[rdx+r11]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{4a 8d 3c 1a}
0069h vlddqu ymm0,ymmword ptr [rsi]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 06}
006dh vlddqu ymm1,ymmword ptr [rdi]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 0f}
0071h vpxor ymm0,ymm0,ymm1                    ; VPXOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EF /r || encoded[4]{c5 fd ef c1}
0075h add r11,rax                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{4c 03 d8}
0078h vmovdqu ymmword ptr [r11],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[5]{c4 c1 7e 7f 03}
007dh inc r9d                                 ; INC r/m32 || o32 FF /0 || encoded[3]{41 ff c1}
0080h add r10d,4                              ; ADD r/m32, imm8 || o32 83 /0 ib || encoded[4]{41 83 c2 04}
0084h cmp r9d,10h                             ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[4]{41 83 f9 10}
0088h jl short 005ah                          ; JL rel8 || 7C cb || encoded[2]{7c d0}
008ah mov rax,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b 00}
008dh xor edx,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d2}
008fh xor ecx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c9}
0091h movsxd r9,ecx                           ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4c 63 c9}
0094h lea r9,[rax+r9*8]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{4e 8d 0c c8}
0098h mov r10,r9                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b d1}
009bh mov r11,r9                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b d9}
009eh vxorps ymm0,ymm0,ymm0                   ; VXORPS ymm1, ymm2, ymm3/m256 || VEX.256.0F.WIG 57 /r || encoded[4]{c5 fc 57 c0}
00a2h vmovupd [rsp+20h],ymm0                  ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[6]{c5 fd 11 44 24 20}
00a8h vxorps ymm0,ymm0,ymm0                   ; VXORPS ymm1, ymm2, ymm3/m256 || VEX.256.0F.WIG 57 /r || encoded[4]{c5 fc 57 c0}
00ach vmovupd [rsp],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[5]{c5 fd 11 04 24}
00b1h vlddqu ymm0,ymmword ptr [r10]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[5]{c4 c1 7f f0 02}
00b6h vmovupd [rsp+20h],ymm0                  ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[6]{c5 fd 11 44 24 20}
00bch vlddqu ymm0,ymmword ptr [r11]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[5]{c4 c1 7f f0 03}
00c1h vmovupd [rsp],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[5]{c5 fd 11 04 24}
00c6h vmovupd ymm0,[rsp+20h]                  ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[6]{c5 fd 10 44 24 20}
00cch vmovupd ymm1,[rsp]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c5 fd 10 0c 24}
00d1h vpor ymm0,ymm0,ymm1                     ; VPOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EB /r || encoded[4]{c5 fd eb c1}
00d5h vmovdqu ymmword ptr [r9],ymm0           ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[5]{c4 c1 7e 7f 01}
00dah inc edx                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c2}
00dch add ecx,4                               ; ADD r/m32, imm8 || o32 83 /0 ib || encoded[3]{83 c1 04}
00dfh cmp edx,10h                             ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 fa 10}
00e2h jl short 0091h                          ; JL rel8 || 7C cb || encoded[2]{7c ad}
00e4h mov rax,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b c0}
00e7h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
00eah add rsp,58h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 58}
00eeh pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
00efh pop rbp                                 ; POP r64 || 58+ro || encoded[1]{5d}
00f0h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
00f1h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
00f2h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ref BitMatrix<ulong> nand_or_and_xor_bm(in BitMatrix<ulong> A, in BitMatrix<ulong> B, ref BitMatrix<ulong> C)
; static ReadOnlySpan<byte> nand_or_and_xor_bm_0xBytes => new byte[309]{0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x58,0xC5,0xF8,0x77,0x48,0x8B,0x01,0x4C,0x8B,0x0A,0x4D,0x8B,0x10,0x45,0x33,0xDB,0x33,0xF6,0x48,0x63,0xFE,0x48,0xC1,0xE7,0x03,0x48,0x8D,0x1C,0x38,0x49,0x8D,0x2C,0x39,0xC5,0xFF,0xF0,0x03,0xC5,0xFF,0xF0,0x4D,0x00,0xC5,0xFD,0xDB,0xC1,0x49,0x03,0xFA,0xC5,0xFE,0x7F,0x07,0x41,0xFF,0xC3,0x83,0xC6,0x04,0x41,0x83,0xFB,0x10,0x7C,0xD1,0x49,0x8B,0xC0,0x48,0x8B,0x09,0x4C,0x8B,0x0A,0x48,0x8B,0x00,0x45,0x33,0xD2,0x45,0x33,0xDB,0x49,0x63,0xF3,0x48,0xC1,0xE6,0x03,0x48,0x8D,0x3C,0x31,0x49,0x8D,0x1C,0x31,0xC5,0xFF,0xF0,0x07,0xC5,0xFF,0xF0,0x0B,0xC5,0xFD,0xEF,0xC1,0x48,0x03,0xF0,0xC5,0xFE,0x7F,0x06,0x41,0xFF,0xC2,0x41,0x83,0xC3,0x04,0x41,0x83,0xFA,0x10,0x7C,0xD1,0x49,0x8B,0x00,0x33,0xC9,0x45,0x33,0xC9,0x4D,0x63,0xD1,0x4E,0x8D,0x14,0xD0,0x4D,0x8B,0xDA,0x49,0x8B,0xF2,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x04,0x24,0xC4,0xC1,0x7F,0xF0,0x03,0xC5,0xFD,0x11,0x44,0x24,0x20,0xC5,0xFF,0xF0,0x06,0xC5,0xFD,0x11,0x04,0x24,0xC5,0xFD,0x10,0x44,0x24,0x20,0xC5,0xFD,0x10,0x0C,0x24,0xC5,0xFD,0xEB,0xC1,0xC4,0xC1,0x7E,0x7F,0x02,0xFF,0xC1,0x41,0x83,0xC1,0x04,0x83,0xF9,0x10,0x7C,0xAD,0x48,0x8B,0x02,0x49,0x8B,0x10,0x33,0xC9,0x45,0x33,0xC9,0x4D,0x63,0xD1,0x4E,0x8D,0x14,0xD0,0x4D,0x63,0xD9,0x4E,0x8D,0x1C,0xDA,0x49,0x8B,0xF3,0xC4,0xC1,0x7F,0xF0,0x02,0xC5,0xFF,0xF0,0x0E,0xC5,0xFD,0xDB,0xC1,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC4,0xC1,0x7E,0x7F,0x03,0xFF,0xC1,0x41,0x83,0xC1,0x04,0x83,0xF9,0x10,0x7C,0xC9,0x49,0x8B,0xC0,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x58,0x5B,0x5D,0x5E,0x5F,0xC3};
; [0x7ff7c83968f0, 0x7ff7c8396a25], 309 bytes
; 2020-01-20 01:59:21:136
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbp                                ; PUSH r64 || 50+ro || encoded[1]{55}
0003h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0004h sub rsp,58h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 58}
0008h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
000bh mov rax,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 01}
000eh mov r9,[rdx]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b 0a}
0011h mov r10,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b 10}
0014h xor r11d,r11d                           ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 db}
0017h xor esi,esi                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 f6}
0019h movsxd rdi,esi                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 fe}
001ch shl rdi,3                               ; SHL r/m64, imm8 || REX.W C1 /4 ib || encoded[4]{48 c1 e7 03}
0020h lea rbx,[rax+rdi]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 1c 38}
0024h lea rbp,[r9+rdi]                        ; LEA r64, m || REX.W 8D /r || encoded[4]{49 8d 2c 39}
0028h vlddqu ymm0,ymmword ptr [rbx]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 03}
002ch vlddqu ymm1,ymmword ptr [rbp]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[5]{c5 ff f0 4d 00}
0031h vpand ymm0,ymm0,ymm1                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 fd db c1}
0035h add rdi,r10                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{49 03 fa}
0038h vmovdqu ymmword ptr [rdi],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 07}
003ch inc r11d                                ; INC r/m32 || o32 FF /0 || encoded[3]{41 ff c3}
003fh add esi,4                               ; ADD r/m32, imm8 || o32 83 /0 ib || encoded[3]{83 c6 04}
0042h cmp r11d,10h                            ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[4]{41 83 fb 10}
0046h jl short 0019h                          ; JL rel8 || 7C cb || encoded[2]{7c d1}
0048h mov rax,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b c0}
004bh mov rcx,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 09}
004eh mov r9,[rdx]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b 0a}
0051h mov rax,[rax]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 00}
0054h xor r10d,r10d                           ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 d2}
0057h xor r11d,r11d                           ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 db}
005ah movsxd rsi,r11d                         ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{49 63 f3}
005dh shl rsi,3                               ; SHL r/m64, imm8 || REX.W C1 /4 ib || encoded[4]{48 c1 e6 03}
0061h lea rdi,[rcx+rsi]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 3c 31}
0065h lea rbx,[r9+rsi]                        ; LEA r64, m || REX.W 8D /r || encoded[4]{49 8d 1c 31}
0069h vlddqu ymm0,ymmword ptr [rdi]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 07}
006dh vlddqu ymm1,ymmword ptr [rbx]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 0b}
0071h vpxor ymm0,ymm0,ymm1                    ; VPXOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EF /r || encoded[4]{c5 fd ef c1}
0075h add rsi,rax                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{48 03 f0}
0078h vmovdqu ymmword ptr [rsi],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[4]{c5 fe 7f 06}
007ch inc r10d                                ; INC r/m32 || o32 FF /0 || encoded[3]{41 ff c2}
007fh add r11d,4                              ; ADD r/m32, imm8 || o32 83 /0 ib || encoded[4]{41 83 c3 04}
0083h cmp r10d,10h                            ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[4]{41 83 fa 10}
0087h jl short 005ah                          ; JL rel8 || 7C cb || encoded[2]{7c d1}
0089h mov rax,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b 00}
008ch xor ecx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c9}
008eh xor r9d,r9d                             ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 c9}
0091h movsxd r10,r9d                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4d 63 d1}
0094h lea r10,[rax+r10*8]                     ; LEA r64, m || REX.W 8D /r || encoded[4]{4e 8d 14 d0}
0098h mov r11,r10                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b da}
009bh mov rsi,r10                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b f2}
009eh vxorps ymm0,ymm0,ymm0                   ; VXORPS ymm1, ymm2, ymm3/m256 || VEX.256.0F.WIG 57 /r || encoded[4]{c5 fc 57 c0}
00a2h vmovupd [rsp+20h],ymm0                  ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[6]{c5 fd 11 44 24 20}
00a8h vxorps ymm0,ymm0,ymm0                   ; VXORPS ymm1, ymm2, ymm3/m256 || VEX.256.0F.WIG 57 /r || encoded[4]{c5 fc 57 c0}
00ach vmovupd [rsp],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[5]{c5 fd 11 04 24}
00b1h vlddqu ymm0,ymmword ptr [r11]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[5]{c4 c1 7f f0 03}
00b6h vmovupd [rsp+20h],ymm0                  ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[6]{c5 fd 11 44 24 20}
00bch vlddqu ymm0,ymmword ptr [rsi]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 06}
00c0h vmovupd [rsp],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[5]{c5 fd 11 04 24}
00c5h vmovupd ymm0,[rsp+20h]                  ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[6]{c5 fd 10 44 24 20}
00cbh vmovupd ymm1,[rsp]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c5 fd 10 0c 24}
00d0h vpor ymm0,ymm0,ymm1                     ; VPOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EB /r || encoded[4]{c5 fd eb c1}
00d4h vmovdqu ymmword ptr [r10],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[5]{c4 c1 7e 7f 02}
00d9h inc ecx                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c1}
00dbh add r9d,4                               ; ADD r/m32, imm8 || o32 83 /0 ib || encoded[4]{41 83 c1 04}
00dfh cmp ecx,10h                             ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 f9 10}
00e2h jl short 0091h                          ; JL rel8 || 7C cb || encoded[2]{7c ad}
00e4h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
00e7h mov rdx,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b 10}
00eah xor ecx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c9}
00ech xor r9d,r9d                             ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 c9}
00efh movsxd r10,r9d                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4d 63 d1}
00f2h lea r10,[rax+r10*8]                     ; LEA r64, m || REX.W 8D /r || encoded[4]{4e 8d 14 d0}
00f6h movsxd r11,r9d                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4d 63 d9}
00f9h lea r11,[rdx+r11*8]                     ; LEA r64, m || REX.W 8D /r || encoded[4]{4e 8d 1c da}
00fdh mov rsi,r11                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b f3}
0100h vlddqu ymm0,ymmword ptr [r10]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[5]{c4 c1 7f f0 02}
0105h vlddqu ymm1,ymmword ptr [rsi]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 0e}
0109h vpand ymm0,ymm0,ymm1                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 fd db c1}
010dh vpcmpeqq ymm1,ymm0,ymm0                 ; VPCMPEQQ ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 29 /r || encoded[5]{c4 e2 7d 29 c8}
0112h vpxor ymm0,ymm0,ymm1                    ; VPXOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EF /r || encoded[4]{c5 fd ef c1}
0116h vmovdqu ymmword ptr [r11],ymm0          ; VMOVDQU ymm2/m256, ymm1 || VEX.256.F3.0F.WIG 7F /r || encoded[5]{c4 c1 7e 7f 03}
011bh inc ecx                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c1}
011dh add r9d,4                               ; ADD r/m32, imm8 || o32 83 /0 ib || encoded[4]{41 83 c1 04}
0121h cmp ecx,10h                             ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 f9 10}
0124h jl short 00efh                          ; JL rel8 || 7C cb || encoded[2]{7c c9}
0126h mov rax,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b c0}
0129h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
012ch add rsp,58h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 58}
0130h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
0131h pop rbp                                 ; POP r64 || 58+ro || encoded[1]{5d}
0132h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
0133h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
0134h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit comp1_logic(bit a, bit b)
; static ReadOnlySpan<byte> comp1_logic_0xBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0x33,0xD1,0x0B,0xC2,0xC3};
; [0x7ff7c8396a60, 0x7ff7c8396a6e], 14 bytes
; 2020-01-20 01:59:21:136
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h and eax,edx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 c2}
0009h xor edx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d1}
000bh or eax,edx                              ; OR r32, r/m32 || o32 0B /r || encoded[2]{0b c2}
000dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong comp1_scalar(ulong a, ulong b)
; static ReadOnlySpan<byte> comp1_scalar_64uBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x23,0xC2,0x48,0x33,0xD1,0x48,0x0B,0xC2,0xC3};
; [0x7ff7c8396a80, 0x7ff7c8396a92], 18 bytes
; 2020-01-20 01:59:21:136
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0008h and rax,rdx                             ; AND r64, r/m64 || REX.W 23 /r || encoded[3]{48 23 c2}
000bh xor rdx,rcx                             ; XOR r64, r/m64 || REX.W 33 /r || encoded[3]{48 33 d1}
000eh or rax,rdx                              ; OR r64, r/m64 || REX.W 0B /r || encoded[3]{48 0b c2}
0011h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<ulong> comp1_v128(Vector128<ulong> a, Vector128<ulong> b)
; static ReadOnlySpan<byte> comp1_v128_128x64uBytes => new byte[43]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xDB,0xC1,0xC5,0xF9,0x10,0x0A,0xC4,0xC1,0x79,0x10,0x10,0xC5,0xF1,0xEF,0xCA,0xC5,0xF9,0xEB,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c8396ab0, 0x7ff7c8396adb], 43 bytes
; 2020-01-20 01:59:21:136
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh vpand xmm0,xmm0,xmm1                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f9 db c1}
0012h vmovupd xmm1,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 0a}
0016h vmovupd xmm2,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 10}
001bh vpxor xmm1,xmm1,xmm2                    ; VPXOR xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG EF /r || encoded[4]{c5 f1 ef ca}
001fh vpor xmm0,xmm0,xmm1                     ; VPOR xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG EB /r || encoded[4]{c5 f9 eb c1}
0023h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0027h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
002ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<ulong> comp1_v256(Vector256<ulong> a, Vector256<ulong> b)
; static ReadOnlySpan<byte> comp1_v256_256x64uBytes => new byte[46]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0xDB,0xC1,0xC5,0xFD,0x10,0x0A,0xC4,0xC1,0x7D,0x10,0x10,0xC5,0xF5,0xEF,0xCA,0xC5,0xFD,0xEB,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c8396b00, 0x7ff7c8396b2e], 46 bytes
; 2020-01-20 01:59:21:136
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h vmovupd ymm1,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 08}
000eh vpand ymm0,ymm0,ymm1                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 fd db c1}
0012h vmovupd ymm1,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 0a}
0016h vmovupd ymm2,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 10}
001bh vpxor ymm1,ymm1,ymm2                    ; VPXOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EF /r || encoded[4]{c5 f5 ef ca}
001fh vpor ymm0,ymm0,ymm1                     ; VPOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EB /r || encoded[4]{c5 fd eb c1}
0023h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0027h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
002ah vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
002dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit comp2_logic(bit a, bit b)
; static ReadOnlySpan<byte> comp2_logic_0xBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0x33,0xCA,0x0B,0xC1,0x23,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
; [0x7ff7c8396b50, 0x7ff7c8396b65], 21 bytes
; 2020-01-20 01:59:21:136
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h and eax,edx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 c2}
0009h xor ecx,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 ca}
000bh or eax,ecx                              ; OR r32, r/m32 || o32 0B /r || encoded[2]{0b c1}
000dh and eax,edx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 c2}
000fh not eax                                 ; NOT r/m32 || o32 F7 /2 || encoded[2]{f7 d0}
0011h and eax,1                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e0 01}
0014h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong comp2_scalar(ulong a, ulong b)
; static ReadOnlySpan<byte> comp2_scalar_64uBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x23,0xC2,0x48,0x33,0xCA,0x48,0x0B,0xC1,0x48,0x23,0xC2,0x48,0xF7,0xD0,0xC3};
; [0x7ff7c8396f80, 0x7ff7c8396f98], 24 bytes
; 2020-01-20 01:59:21:136
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0008h and rax,rdx                             ; AND r64, r/m64 || REX.W 23 /r || encoded[3]{48 23 c2}
000bh xor rcx,rdx                             ; XOR r64, r/m64 || REX.W 33 /r || encoded[3]{48 33 ca}
000eh or rax,rcx                              ; OR r64, r/m64 || REX.W 0B /r || encoded[3]{48 0b c1}
0011h and rax,rdx                             ; AND r64, r/m64 || REX.W 23 /r || encoded[3]{48 23 c2}
0014h not rax                                 ; NOT r/m64 || REX.W F7 /2 || encoded[3]{48 f7 d0}
0017h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<ulong> comp2_v128(Vector128<ulong> a, Vector128<ulong> b)
; static ReadOnlySpan<byte> comp2_v128_128x64uBytes => new byte[60]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xDB,0xC1,0xC5,0xF9,0x10,0x0A,0xC4,0xC1,0x79,0x10,0x10,0xC5,0xF1,0xEF,0xCA,0xC5,0xF9,0xEB,0xC1,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF1,0xDB,0xC0,0xC5,0xF9,0x76,0xC8,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c8396fb0, 0x7ff7c8396fec], 60 bytes
; 2020-01-20 01:59:21:136
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh vpand xmm0,xmm0,xmm1                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f9 db c1}
0012h vmovupd xmm1,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 0a}
0016h vmovupd xmm2,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 10}
001bh vpxor xmm1,xmm1,xmm2                    ; VPXOR xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG EF /r || encoded[4]{c5 f1 ef ca}
001fh vpor xmm0,xmm0,xmm1                     ; VPOR xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG EB /r || encoded[4]{c5 f9 eb c1}
0023h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
0028h vpand xmm0,xmm1,xmm0                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f1 db c0}
002ch vpcmpeqd xmm1,xmm0,xmm0                 ; VPCMPEQD xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG 76 /r || encoded[4]{c5 f9 76 c8}
0030h vpxor xmm0,xmm0,xmm1                    ; VPXOR xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG EF /r || encoded[4]{c5 f9 ef c1}
0034h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0038h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
003bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<ulong> comp2_v256(Vector256<ulong> a, Vector256<ulong> b)
; static ReadOnlySpan<byte> comp2_v256_256x64uBytes => new byte[64]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0xDB,0xC1,0xC5,0xFD,0x10,0x0A,0xC4,0xC1,0x7D,0x10,0x10,0xC5,0xF5,0xEF,0xCA,0xC5,0xFD,0xEB,0xC1,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xF5,0xDB,0xC0,0xC4,0xE2,0x7D,0x29,0xC8,0xC5,0xFD,0xEF,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c8397010, 0x7ff7c8397050], 64 bytes
; 2020-01-20 01:59:21:136
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h vmovupd ymm1,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 08}
000eh vpand ymm0,ymm0,ymm1                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 fd db c1}
0012h vmovupd ymm1,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 0a}
0016h vmovupd ymm2,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 10}
001bh vpxor ymm1,ymm1,ymm2                    ; VPXOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EF /r || encoded[4]{c5 f5 ef ca}
001fh vpor ymm0,ymm0,ymm1                     ; VPOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EB /r || encoded[4]{c5 fd eb c1}
0023h vmovupd ymm1,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 08}
0028h vpand ymm0,ymm1,ymm0                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 f5 db c0}
002ch vpcmpeqq ymm1,ymm0,ymm0                 ; VPCMPEQQ ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 29 /r || encoded[5]{c4 e2 7d 29 c8}
0031h vpxor ymm0,ymm0,ymm1                    ; VPXOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EF /r || encoded[4]{c5 fd ef c1}
0035h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0039h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
003ch vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
003fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit comp3_logic(bit a, bit b)
; static ReadOnlySpan<byte> comp3_logic_0xBytes => new byte[60]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0x44,0x8B,0xC1,0x44,0x33,0xC2,0x41,0x0B,0xC0,0x23,0xC2,0xF7,0xD0,0x83,0xE0,0x01,0x44,0x8B,0xC1,0x44,0x0B,0xC2,0x41,0xF7,0xD0,0x41,0x83,0xE0,0x01,0x33,0xD1,0xF7,0xD2,0x83,0xE2,0x01,0x41,0x23,0xD0,0x23,0xC1,0xF7,0xD1,0x23,0xD1,0x0B,0xC2,0x83,0xE0,0x01,0xC3};
; [0x7ff7c8397070, 0x7ff7c83970ac], 60 bytes
; 2020-01-20 01:59:21:136
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h and eax,edx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 c2}
0009h mov r8d,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{44 8b c1}
000ch xor r8d,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[3]{44 33 c2}
000fh or eax,r8d                              ; OR r32, r/m32 || o32 0B /r || encoded[3]{41 0b c0}
0012h and eax,edx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 c2}
0014h not eax                                 ; NOT r/m32 || o32 F7 /2 || encoded[2]{f7 d0}
0016h and eax,1                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e0 01}
0019h mov r8d,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{44 8b c1}
001ch or r8d,edx                              ; OR r32, r/m32 || o32 0B /r || encoded[3]{44 0b c2}
001fh not r8d                                 ; NOT r/m32 || o32 F7 /2 || encoded[3]{41 f7 d0}
0022h and r8d,1                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[4]{41 83 e0 01}
0026h xor edx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d1}
0028h not edx                                 ; NOT r/m32 || o32 F7 /2 || encoded[2]{f7 d2}
002ah and edx,1                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e2 01}
002dh and edx,r8d                             ; AND r32, r/m32 || o32 23 /r || encoded[3]{41 23 d0}
0030h and eax,ecx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 c1}
0032h not ecx                                 ; NOT r/m32 || o32 F7 /2 || encoded[2]{f7 d1}
0034h and edx,ecx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 d1}
0036h or eax,edx                              ; OR r32, r/m32 || o32 0B /r || encoded[2]{0b c2}
0038h and eax,1                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e0 01}
003bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong comp3_scalar(ulong a, ulong b)
; static ReadOnlySpan<byte> comp3_scalar_64uBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x23,0xC2,0x4C,0x8B,0xC1,0x4C,0x33,0xC2,0x49,0x0B,0xC0,0x48,0x23,0xC2,0x48,0xF7,0xD0,0x4C,0x8B,0xC1,0x4C,0x0B,0xC2,0x49,0xF7,0xD0,0x48,0x33,0xD1,0xC4,0xC2,0xE8,0xF2,0xD0,0x48,0x23,0xC1,0xC4,0xE2,0xF0,0xF2,0xD2,0x48,0x0B,0xC2,0xC3};
; [0x7ff7c83970c0, 0x7ff7c83970f7], 55 bytes
; 2020-01-20 01:59:21:137
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0008h and rax,rdx                             ; AND r64, r/m64 || REX.W 23 /r || encoded[3]{48 23 c2}
000bh mov r8,rcx                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b c1}
000eh xor r8,rdx                              ; XOR r64, r/m64 || REX.W 33 /r || encoded[3]{4c 33 c2}
0011h or rax,r8                               ; OR r64, r/m64 || REX.W 0B /r || encoded[3]{49 0b c0}
0014h and rax,rdx                             ; AND r64, r/m64 || REX.W 23 /r || encoded[3]{48 23 c2}
0017h not rax                                 ; NOT r/m64 || REX.W F7 /2 || encoded[3]{48 f7 d0}
001ah mov r8,rcx                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b c1}
001dh or r8,rdx                               ; OR r64, r/m64 || REX.W 0B /r || encoded[3]{4c 0b c2}
0020h not r8                                  ; NOT r/m64 || REX.W F7 /2 || encoded[3]{49 f7 d0}
0023h xor rdx,rcx                             ; XOR r64, r/m64 || REX.W 33 /r || encoded[3]{48 33 d1}
0026h andn rdx,rdx,r8                         ; ANDN r64a, r64b, r/m64 || VEX.LZ.0F38.W1 F2 /r || encoded[5]{c4 c2 e8 f2 d0}
002bh and rax,rcx                             ; AND r64, r/m64 || REX.W 23 /r || encoded[3]{48 23 c1}
002eh andn rdx,rcx,rdx                        ; ANDN r64a, r64b, r/m64 || VEX.LZ.0F38.W1 F2 /r || encoded[5]{c4 e2 f0 f2 d2}
0033h or rax,rdx                              ; OR r64, r/m64 || REX.W 0B /r || encoded[3]{48 0b c2}
0036h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<ulong> comp3_v128(Vector128<ulong> a, Vector128<ulong> b)
; static ReadOnlySpan<byte> comp3_v128_128x64uBytes => new byte[114]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF8,0x28,0xC8,0xC4,0xC1,0x79,0x10,0x10,0xC5,0xF8,0x28,0xDA,0xC5,0xF1,0xDB,0xCB,0xC5,0xF8,0x28,0xD8,0xC5,0xF8,0x28,0xE2,0xC5,0xE1,0xEF,0xDC,0xC5,0xF1,0xEB,0xCB,0xC5,0xF8,0x28,0xDA,0xC5,0xE1,0xDB,0xC9,0xC5,0xF1,0x76,0xD9,0xC5,0xF1,0xEF,0xCB,0xC5,0xF8,0x28,0xD8,0xC5,0xF8,0x28,0xE2,0xC5,0xE1,0xEB,0xDC,0xC5,0xE1,0x76,0xE3,0xC5,0xE1,0xEF,0xDC,0xC5,0xF8,0x28,0xE0,0xC5,0xE9,0xEF,0xD4,0xC5,0xE9,0xDF,0xD3,0xC5,0xF8,0x28,0xD8,0xC5,0xE1,0xDB,0xC9,0xC5,0xF9,0xDF,0xC2,0xC5,0xF1,0xEB,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c8397110, 0x7ff7c8397182], 114 bytes
; 2020-01-20 01:59:21:137
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovaps xmm1,xmm0                       ; VMOVAPS xmm1, xmm2/m128 || VEX.128.0F.WIG 28 /r || encoded[4]{c5 f8 28 c8}
000dh vmovupd xmm2,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 10}
0012h vmovaps xmm3,xmm2                       ; VMOVAPS xmm1, xmm2/m128 || VEX.128.0F.WIG 28 /r || encoded[4]{c5 f8 28 da}
0016h vpand xmm1,xmm1,xmm3                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f1 db cb}
001ah vmovaps xmm3,xmm0                       ; VMOVAPS xmm1, xmm2/m128 || VEX.128.0F.WIG 28 /r || encoded[4]{c5 f8 28 d8}
001eh vmovaps xmm4,xmm2                       ; VMOVAPS xmm1, xmm2/m128 || VEX.128.0F.WIG 28 /r || encoded[4]{c5 f8 28 e2}
0022h vpxor xmm3,xmm3,xmm4                    ; VPXOR xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG EF /r || encoded[4]{c5 e1 ef dc}
0026h vpor xmm1,xmm1,xmm3                     ; VPOR xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG EB /r || encoded[4]{c5 f1 eb cb}
002ah vmovaps xmm3,xmm2                       ; VMOVAPS xmm1, xmm2/m128 || VEX.128.0F.WIG 28 /r || encoded[4]{c5 f8 28 da}
002eh vpand xmm1,xmm3,xmm1                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 e1 db c9}
0032h vpcmpeqd xmm3,xmm1,xmm1                 ; VPCMPEQD xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG 76 /r || encoded[4]{c5 f1 76 d9}
0036h vpxor xmm1,xmm1,xmm3                    ; VPXOR xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG EF /r || encoded[4]{c5 f1 ef cb}
003ah vmovaps xmm3,xmm0                       ; VMOVAPS xmm1, xmm2/m128 || VEX.128.0F.WIG 28 /r || encoded[4]{c5 f8 28 d8}
003eh vmovaps xmm4,xmm2                       ; VMOVAPS xmm1, xmm2/m128 || VEX.128.0F.WIG 28 /r || encoded[4]{c5 f8 28 e2}
0042h vpor xmm3,xmm3,xmm4                     ; VPOR xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG EB /r || encoded[4]{c5 e1 eb dc}
0046h vpcmpeqd xmm4,xmm3,xmm3                 ; VPCMPEQD xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG 76 /r || encoded[4]{c5 e1 76 e3}
004ah vpxor xmm3,xmm3,xmm4                    ; VPXOR xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG EF /r || encoded[4]{c5 e1 ef dc}
004eh vmovaps xmm4,xmm0                       ; VMOVAPS xmm1, xmm2/m128 || VEX.128.0F.WIG 28 /r || encoded[4]{c5 f8 28 e0}
0052h vpxor xmm2,xmm2,xmm4                    ; VPXOR xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG EF /r || encoded[4]{c5 e9 ef d4}
0056h vpandn xmm2,xmm2,xmm3                   ; VPANDN xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DF /r || encoded[4]{c5 e9 df d3}
005ah vmovaps xmm3,xmm0                       ; VMOVAPS xmm1, xmm2/m128 || VEX.128.0F.WIG 28 /r || encoded[4]{c5 f8 28 d8}
005eh vpand xmm1,xmm3,xmm1                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 e1 db c9}
0062h vpandn xmm0,xmm0,xmm2                   ; VPANDN xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DF /r || encoded[4]{c5 f9 df c2}
0066h vpor xmm0,xmm1,xmm0                     ; VPOR xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG EB /r || encoded[4]{c5 f1 eb c0}
006ah vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
006eh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0071h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<ulong> comp3_v256(Vector256<ulong> a, Vector256<ulong> b)
; static ReadOnlySpan<byte> comp3_v256_256x64uBytes => new byte[119]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC5,0xFC,0x28,0xC8,0xC4,0xC1,0x7D,0x10,0x10,0xC5,0xFC,0x28,0xDA,0xC5,0xF5,0xDB,0xCB,0xC5,0xFC,0x28,0xD8,0xC5,0xFC,0x28,0xE2,0xC5,0xE5,0xEF,0xDC,0xC5,0xF5,0xEB,0xCB,0xC5,0xFC,0x28,0xDA,0xC5,0xE5,0xDB,0xC9,0xC4,0xE2,0x75,0x29,0xD9,0xC5,0xF5,0xEF,0xCB,0xC5,0xFC,0x28,0xD8,0xC5,0xFC,0x28,0xE2,0xC5,0xE5,0xEB,0xDC,0xC4,0xE2,0x65,0x29,0xE3,0xC5,0xE5,0xEF,0xDC,0xC5,0xFC,0x28,0xE0,0xC5,0xED,0xEF,0xD4,0xC5,0xED,0xDF,0xD3,0xC5,0xFC,0x28,0xD8,0xC5,0xE5,0xDB,0xC9,0xC5,0xFD,0xDF,0xC2,0xC5,0xF5,0xEB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c83971b0, 0x7ff7c8397227], 119 bytes
; 2020-01-20 01:59:21:137
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h vmovaps ymm1,ymm0                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 c8}
000dh vmovupd ymm2,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 10}
0012h vmovaps ymm3,ymm2                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 da}
0016h vpand ymm1,ymm1,ymm3                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 f5 db cb}
001ah vmovaps ymm3,ymm0                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 d8}
001eh vmovaps ymm4,ymm2                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 e2}
0022h vpxor ymm3,ymm3,ymm4                    ; VPXOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EF /r || encoded[4]{c5 e5 ef dc}
0026h vpor ymm1,ymm1,ymm3                     ; VPOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EB /r || encoded[4]{c5 f5 eb cb}
002ah vmovaps ymm3,ymm2                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 da}
002eh vpand ymm1,ymm3,ymm1                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 e5 db c9}
0032h vpcmpeqq ymm3,ymm1,ymm1                 ; VPCMPEQQ ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 29 /r || encoded[5]{c4 e2 75 29 d9}
0037h vpxor ymm1,ymm1,ymm3                    ; VPXOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EF /r || encoded[4]{c5 f5 ef cb}
003bh vmovaps ymm3,ymm0                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 d8}
003fh vmovaps ymm4,ymm2                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 e2}
0043h vpor ymm3,ymm3,ymm4                     ; VPOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EB /r || encoded[4]{c5 e5 eb dc}
0047h vpcmpeqq ymm4,ymm3,ymm3                 ; VPCMPEQQ ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 29 /r || encoded[5]{c4 e2 65 29 e3}
004ch vpxor ymm3,ymm3,ymm4                    ; VPXOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EF /r || encoded[4]{c5 e5 ef dc}
0050h vmovaps ymm4,ymm0                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 e0}
0054h vpxor ymm2,ymm2,ymm4                    ; VPXOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EF /r || encoded[4]{c5 ed ef d4}
0058h vpandn ymm2,ymm2,ymm3                   ; VPANDN ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DF /r || encoded[4]{c5 ed df d3}
005ch vmovaps ymm3,ymm0                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 d8}
0060h vpand ymm1,ymm3,ymm1                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 e5 db c9}
0064h vpandn ymm0,ymm0,ymm2                   ; VPANDN ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DF /r || encoded[4]{c5 fd df c2}
0068h vpor ymm0,ymm1,ymm0                     ; VPOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EB /r || encoded[4]{c5 f5 eb c0}
006ch vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0070h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0073h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0076h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
