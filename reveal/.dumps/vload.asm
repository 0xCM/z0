; 2020-01-20 01:59:21:468
; Vector128<byte> vgather_128x8u(Span<byte> src, Vector128<byte> vix)
; static ReadOnlySpan<byte> vgather_128x8u__128x8uBytes => new byte[152]{0x50,0xC5,0xF8,0x77,0x90,0x48,0x8B,0x02,0xC4,0xC1,0x79,0x10,0x00,0xC4,0xE2,0x7D,0x31,0xC8,0xC4,0xE3,0xF9,0x16,0xC2,0x01,0xC4,0xE1,0xF9,0x6E,0xC2,0xC4,0xE2,0x7D,0x31,0xC0,0x48,0x8B,0xD0,0xC5,0xED,0x76,0xD2,0xC4,0xE2,0x6D,0x90,0x1C,0x0A,0xC5,0xF5,0x76,0xC9,0xC4,0xE2,0x75,0x90,0x14,0x00,0xC7,0x44,0x24,0x04,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x7D,0x58,0x44,0x24,0x04,0xC5,0xE5,0xDB,0xC8,0xC5,0xED,0xDB,0xC0,0xC4,0xE2,0x75,0x2B,0xC0,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC4,0xE3,0x7D,0x19,0xC1,0x00,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC7,0x04,0x24,0xFF,0x00,0x00,0x00,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x79,0x14,0x24,0xC5,0xF1,0xDB,0xCA,0xC5,0xF9,0xDB,0xC2,0xC5,0xF1,0x67,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
; [0x7ff7c85f8c50, 0x7ff7c85f8ce8], 152 bytes
; 2020-01-20 01:59:21:468
0000h push rax                                ; PUSH r64 || 50+ro || encoded[1]{50}
0001h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
0008h vmovupd xmm0,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 00}
000dh vpmovzxbd ymm1,xmm0                     ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 c8}
0012h vpextrq rdx,xmm0,1                      ; VPEXTRQ r/m64, xmm2, imm8 || VEX.128.66.0F3A.W1 16 /r ib || encoded[6]{c4 e3 f9 16 c2 01}
0018h vmovq xmm0,rdx                          ; VMOVQ xmm1, r/m64 || VEX.128.66.0F.W1 6E /r || encoded[5]{c4 e1 f9 6e c2}
001dh vpmovzxbd ymm0,xmm0                     ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 c0}
0022h mov rdx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d0}
0025h vpcmpeqd ymm2,ymm2,ymm2                 ; VPCMPEQD ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG 76 /r || encoded[4]{c5 ed 76 d2}
0029h vpgatherdd ymm3,[rdx+ymm1],ymm2         ; VPGATHERDD ymm1, vm32y, ymm2 || VEX.256.66.0F38.W0 90 /r || encoded[6]{c4 e2 6d 90 1c 0a}
002fh vpcmpeqd ymm1,ymm1,ymm1                 ; VPCMPEQD ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG 76 /r || encoded[4]{c5 f5 76 c9}
0033h vpgatherdd ymm2,[rax+ymm0],ymm1         ; VPGATHERDD ymm1, vm32y, ymm2 || VEX.256.66.0F38.W0 90 /r || encoded[6]{c4 e2 75 90 14 00}
0039h mov dword ptr [rsp+4],0FFFFh            ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 04 ff ff 00 00}
0041h lea rax,[rsp+4]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 04}
0046h vpbroadcastd ymm0,dword ptr [rsp+4]     ; VPBROADCASTD ymm1, xmm2/m32 || VEX.256.66.0F38.W0 58 /r || encoded[7]{c4 e2 7d 58 44 24 04}
004dh vpand ymm1,ymm3,ymm0                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 e5 db c8}
0051h vpand ymm0,ymm2,ymm0                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 ed db c0}
0055h vpackusdw ymm0,ymm1,ymm0                ; VPACKUSDW ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 2B /r || encoded[5]{c4 e2 75 2b c0}
005ah vpermq ymm0,ymm0,0D8h                   ; VPERMQ ymm1, ymm2/m256, imm8 || VEX.256.66.0F3A.W1 00 /r ib || encoded[6]{c4 e3 fd 00 c0 d8}
0060h vextractf128 xmm1,ymm0,0                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c1 00}
0066h vextractf128 xmm0,ymm0,1                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c0 01}
006ch mov dword ptr [rsp],0FFh                ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[7]{c7 04 24 ff 00 00 00}
0073h lea rax,[rsp]                           ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 04 24}
0077h vpbroadcastw xmm2,word ptr [rsp]        ; VPBROADCASTW xmm1, xmm2/m16 || VEX.128.66.0F38.W0 79 /r || encoded[6]{c4 e2 79 79 14 24}
007dh vpand xmm1,xmm1,xmm2                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f1 db ca}
0081h vpand xmm0,xmm0,xmm2                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f9 db c2}
0085h vpackuswb xmm0,xmm1,xmm0                ; VPACKUSWB xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG 67 /r || encoded[4]{c5 f1 67 c0}
0089h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
008dh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0090h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0093h add rsp,8                               ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 08}
0097h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<ushort> vgather_128x16u(Span<ushort> src, Vector128<ushort> vix)
; static ReadOnlySpan<byte> vgather_128x16u__128x16uBytes => new byte[88]{0x50,0xC5,0xF8,0x77,0x90,0x48,0x8B,0x02,0xC4,0xC1,0x79,0x10,0x00,0xC4,0xE2,0x7D,0x33,0xC0,0xC5,0xF5,0x76,0xC9,0xC4,0xE2,0x75,0x90,0x14,0x40,0xC4,0xE3,0x7D,0x19,0xD0,0x00,0xC4,0xE3,0x7D,0x19,0xD1,0x01,0xC7,0x44,0x24,0x04,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x54,0x24,0x04,0xC5,0xF9,0xDB,0xC2,0xC5,0xF1,0xDB,0xCA,0xC4,0xE2,0x79,0x2B,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
; [0x7ff7c85f8d10, 0x7ff7c85f8d68], 88 bytes
; 2020-01-20 01:59:21:468
0000h push rax                                ; PUSH r64 || 50+ro || encoded[1]{50}
0001h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
0008h vmovupd xmm0,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 00}
000dh vpmovzxwd ymm0,xmm0                     ; VPMOVZXWD ymm1, xmm2/m128 || VEX.256.66.0F38.WIG 33 /r || encoded[5]{c4 e2 7d 33 c0}
0012h vpcmpeqd ymm1,ymm1,ymm1                 ; VPCMPEQD ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG 76 /r || encoded[4]{c5 f5 76 c9}
0016h vpgatherdd ymm2,[rax+ymm0*2],ymm1       ; VPGATHERDD ymm1, vm32y, ymm2 || VEX.256.66.0F38.W0 90 /r || encoded[6]{c4 e2 75 90 14 40}
001ch vextractf128 xmm0,ymm2,0                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 d0 00}
0022h vextractf128 xmm1,ymm2,1                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 d1 01}
0028h mov dword ptr [rsp+4],0FFFFh            ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 04 ff ff 00 00}
0030h lea rax,[rsp+4]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 04}
0035h vpbroadcastd xmm2,dword ptr [rsp+4]     ; VPBROADCASTD xmm1, xmm2/m32 || VEX.128.66.0F38.W0 58 /r || encoded[7]{c4 e2 79 58 54 24 04}
003ch vpand xmm0,xmm0,xmm2                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f9 db c2}
0040h vpand xmm1,xmm1,xmm2                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f1 db ca}
0044h vpackusdw xmm0,xmm0,xmm1                ; VPACKUSDW xmm1, xmm2, xmm3/m128 || VEX.128.66.0F38.WIG 2B /r || encoded[5]{c4 e2 79 2b c1}
0049h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
004dh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0050h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0053h add rsp,8                               ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 08}
0057h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<byte> vgather_256x8u(Span<byte> src, Vector256<byte> vix)
; static ReadOnlySpan<byte> vgather_256x8u__256x8uBytes => new byte[319]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x8B,0x02,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xFC,0x28,0xC8,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0xC4,0xE2,0x7D,0x31,0xD0,0xC4,0xE3,0xF9,0x16,0xC2,0x01,0xC4,0xE1,0xF9,0x6E,0xC2,0xC4,0xE2,0x7D,0x31,0xC0,0x48,0x8B,0xD0,0xC5,0xE5,0x76,0xDB,0xC4,0xE2,0x65,0x90,0x24,0x12,0x48,0x8B,0xD0,0xC5,0xED,0x76,0xD2,0xC4,0xE2,0x6D,0x90,0x1C,0x02,0xC7,0x44,0x24,0x14,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x54,0x24,0x14,0xC4,0xE2,0x7D,0x58,0x44,0x24,0x14,0xC5,0xDD,0xDB,0xD0,0xC5,0xE5,0xDB,0xC0,0xC4,0xE2,0x6D,0x2B,0xC0,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC4,0xE3,0x7D,0x19,0xC2,0x00,0xC4,0xE3,0x7D,0x19,0xC0,0x01,0xC7,0x44,0x24,0x10,0xFF,0x00,0x00,0x00,0x48,0x8D,0x54,0x24,0x10,0xC4,0xE2,0x79,0x79,0x5C,0x24,0x10,0xC5,0xE9,0xDB,0xD3,0xC5,0xF9,0xDB,0xC3,0xC5,0xE9,0x67,0xC0,0xC4,0xE3,0x7D,0x19,0xC9,0x01,0xC4,0xE2,0x7D,0x31,0xD1,0xC4,0xE3,0xF9,0x16,0xCA,0x01,0xC4,0xE1,0xF9,0x6E,0xCA,0xC4,0xE2,0x7D,0x31,0xC9,0x48,0x8B,0xD0,0xC5,0xE5,0x76,0xDB,0xC4,0xE2,0x65,0x90,0x24,0x12,0xC5,0xED,0x76,0xD2,0xC4,0xE2,0x6D,0x90,0x1C,0x08,0xC7,0x44,0x24,0x0C,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x0C,0xC4,0xE2,0x7D,0x58,0x4C,0x24,0x0C,0xC5,0xDD,0xDB,0xD1,0xC5,0xE5,0xDB,0xC9,0xC4,0xE2,0x6D,0x2B,0xC9,0xC4,0xE3,0xFD,0x00,0xC9,0xD8,0xC4,0xE3,0x7D,0x19,0xCA,0x00,0xC4,0xE3,0x7D,0x19,0xC9,0x01,0xC7,0x44,0x24,0x08,0xFF,0x00,0x00,0x00,0x48,0x8D,0x44,0x24,0x08,0xC4,0xE2,0x79,0x79,0x5C,0x24,0x08,0xC5,0xE9,0xDB,0xD3,0xC5,0xF1,0xDB,0xCB,0xC5,0xE9,0x67,0xC9,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC4,0xE3,0x7D,0x38,0xC1,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x18,0xC3};
; [0x7ff7c85f8d90, 0x7ff7c85f8ecf], 319 bytes
; 2020-01-20 01:59:21:468
0000h sub rsp,18h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 18}
0004h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0007h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
000ah vmovupd ymm0,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 00}
000fh vmovaps ymm1,ymm0                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 c8}
0013h vextractf128 xmm0,ymm0,0                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c0 00}
0019h vpmovzxbd ymm2,xmm0                     ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 d0}
001eh vpextrq rdx,xmm0,1                      ; VPEXTRQ r/m64, xmm2, imm8 || VEX.128.66.0F3A.W1 16 /r ib || encoded[6]{c4 e3 f9 16 c2 01}
0024h vmovq xmm0,rdx                          ; VMOVQ xmm1, r/m64 || VEX.128.66.0F.W1 6E /r || encoded[5]{c4 e1 f9 6e c2}
0029h vpmovzxbd ymm0,xmm0                     ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 c0}
002eh mov rdx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d0}
0031h vpcmpeqd ymm3,ymm3,ymm3                 ; VPCMPEQD ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG 76 /r || encoded[4]{c5 e5 76 db}
0035h vpgatherdd ymm4,[rdx+ymm2],ymm3         ; VPGATHERDD ymm1, vm32y, ymm2 || VEX.256.66.0F38.W0 90 /r || encoded[6]{c4 e2 65 90 24 12}
003bh mov rdx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d0}
003eh vpcmpeqd ymm2,ymm2,ymm2                 ; VPCMPEQD ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG 76 /r || encoded[4]{c5 ed 76 d2}
0042h vpgatherdd ymm3,[rdx+ymm0],ymm2         ; VPGATHERDD ymm1, vm32y, ymm2 || VEX.256.66.0F38.W0 90 /r || encoded[6]{c4 e2 6d 90 1c 02}
0048h mov dword ptr [rsp+14h],0FFFFh          ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 14 ff ff 00 00}
0050h lea rdx,[rsp+14h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 54 24 14}
0055h vpbroadcastd ymm0,dword ptr [rsp+14h]   ; VPBROADCASTD ymm1, xmm2/m32 || VEX.256.66.0F38.W0 58 /r || encoded[7]{c4 e2 7d 58 44 24 14}
005ch vpand ymm2,ymm4,ymm0                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 dd db d0}
0060h vpand ymm0,ymm3,ymm0                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 e5 db c0}
0064h vpackusdw ymm0,ymm2,ymm0                ; VPACKUSDW ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 2B /r || encoded[5]{c4 e2 6d 2b c0}
0069h vpermq ymm0,ymm0,0D8h                   ; VPERMQ ymm1, ymm2/m256, imm8 || VEX.256.66.0F3A.W1 00 /r ib || encoded[6]{c4 e3 fd 00 c0 d8}
006fh vextractf128 xmm2,ymm0,0                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c2 00}
0075h vextractf128 xmm0,ymm0,1                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c0 01}
007bh mov dword ptr [rsp+10h],0FFh            ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 10 ff 00 00 00}
0083h lea rdx,[rsp+10h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 54 24 10}
0088h vpbroadcastw xmm3,word ptr [rsp+10h]    ; VPBROADCASTW xmm1, xmm2/m16 || VEX.128.66.0F38.W0 79 /r || encoded[7]{c4 e2 79 79 5c 24 10}
008fh vpand xmm2,xmm2,xmm3                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 e9 db d3}
0093h vpand xmm0,xmm0,xmm3                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f9 db c3}
0097h vpackuswb xmm0,xmm2,xmm0                ; VPACKUSWB xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG 67 /r || encoded[4]{c5 e9 67 c0}
009bh vextractf128 xmm1,ymm1,1                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c9 01}
00a1h vpmovzxbd ymm2,xmm1                     ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 d1}
00a6h vpextrq rdx,xmm1,1                      ; VPEXTRQ r/m64, xmm2, imm8 || VEX.128.66.0F3A.W1 16 /r ib || encoded[6]{c4 e3 f9 16 ca 01}
00ach vmovq xmm1,rdx                          ; VMOVQ xmm1, r/m64 || VEX.128.66.0F.W1 6E /r || encoded[5]{c4 e1 f9 6e ca}
00b1h vpmovzxbd ymm1,xmm1                     ; VPMOVZXBD ymm1, xmm2/m64 || VEX.256.66.0F38.WIG 31 /r || encoded[5]{c4 e2 7d 31 c9}
00b6h mov rdx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d0}
00b9h vpcmpeqd ymm3,ymm3,ymm3                 ; VPCMPEQD ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG 76 /r || encoded[4]{c5 e5 76 db}
00bdh vpgatherdd ymm4,[rdx+ymm2],ymm3         ; VPGATHERDD ymm1, vm32y, ymm2 || VEX.256.66.0F38.W0 90 /r || encoded[6]{c4 e2 65 90 24 12}
00c3h vpcmpeqd ymm2,ymm2,ymm2                 ; VPCMPEQD ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG 76 /r || encoded[4]{c5 ed 76 d2}
00c7h vpgatherdd ymm3,[rax+ymm1],ymm2         ; VPGATHERDD ymm1, vm32y, ymm2 || VEX.256.66.0F38.W0 90 /r || encoded[6]{c4 e2 6d 90 1c 08}
00cdh mov dword ptr [rsp+0Ch],0FFFFh          ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 0c ff ff 00 00}
00d5h lea rax,[rsp+0Ch]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 0c}
00dah vpbroadcastd ymm1,dword ptr [rsp+0Ch]   ; VPBROADCASTD ymm1, xmm2/m32 || VEX.256.66.0F38.W0 58 /r || encoded[7]{c4 e2 7d 58 4c 24 0c}
00e1h vpand ymm2,ymm4,ymm1                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 dd db d1}
00e5h vpand ymm1,ymm3,ymm1                    ; VPAND ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG DB /r || encoded[4]{c5 e5 db c9}
00e9h vpackusdw ymm1,ymm2,ymm1                ; VPACKUSDW ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 2B /r || encoded[5]{c4 e2 6d 2b c9}
00eeh vpermq ymm1,ymm1,0D8h                   ; VPERMQ ymm1, ymm2/m256, imm8 || VEX.256.66.0F3A.W1 00 /r ib || encoded[6]{c4 e3 fd 00 c9 d8}
00f4h vextractf128 xmm2,ymm1,0                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 ca 00}
00fah vextractf128 xmm1,ymm1,1                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c9 01}
0100h mov dword ptr [rsp+8],0FFh              ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 08 ff 00 00 00}
0108h lea rax,[rsp+8]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 08}
010dh vpbroadcastw xmm3,word ptr [rsp+8]      ; VPBROADCASTW xmm1, xmm2/m16 || VEX.128.66.0F38.W0 79 /r || encoded[7]{c4 e2 79 79 5c 24 08}
0114h vpand xmm2,xmm2,xmm3                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 e9 db d3}
0118h vpand xmm1,xmm1,xmm3                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f1 db cb}
011ch vpackuswb xmm1,xmm2,xmm1                ; VPACKUSWB xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG 67 /r || encoded[4]{c5 e9 67 c9}
0120h vxorps ymm2,ymm2,ymm2                   ; VXORPS ymm1, ymm2, ymm3/m256 || VEX.256.0F.WIG 57 /r || encoded[4]{c5 ec 57 d2}
0124h vinserti128 ymm0,ymm2,xmm0,0            ; VINSERTI128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 38 /r ib || encoded[6]{c4 e3 6d 38 c0 00}
012ah vinserti128 ymm0,ymm0,xmm1,1            ; VINSERTI128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 38 /r ib || encoded[6]{c4 e3 7d 38 c1 01}
0130h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0134h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0137h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
013ah add rsp,18h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 18}
013eh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<Int16> vgather_256x16i(Span<Int16> src, Vector256<Int16> vix)
; static ReadOnlySpan<byte> vgather_256x16i__256x16iBytes => new byte[180]{0x50,0xC5,0xF8,0x77,0x90,0x48,0x8B,0x02,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xFC,0x28,0xC8,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0x48,0x8B,0xD0,0xC4,0xE2,0x7D,0x33,0xC0,0xC5,0xED,0x76,0xD2,0xC4,0xE2,0x6D,0x90,0x1C,0x42,0xC4,0xE3,0x7D,0x19,0xD8,0x00,0xC4,0xE3,0x7D,0x19,0xDA,0x01,0xC7,0x44,0x24,0x04,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x54,0x24,0x04,0xC4,0xE2,0x79,0x58,0x5C,0x24,0x04,0xC5,0xF9,0xDB,0xC3,0xC5,0xE9,0xDB,0xD3,0xC4,0xE2,0x79,0x2B,0xC2,0xC4,0xE3,0x7D,0x19,0xC9,0x01,0xC4,0xE2,0x7D,0x33,0xC9,0xC5,0xED,0x76,0xD2,0xC4,0xE2,0x6D,0x90,0x1C,0x48,0xC4,0xE3,0x7D,0x19,0xD9,0x00,0xC4,0xE3,0x7D,0x19,0xDA,0x01,0xC7,0x04,0x24,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x58,0x1C,0x24,0xC5,0xF1,0xDB,0xCB,0xC5,0xE9,0xDB,0xD3,0xC4,0xE2,0x71,0x2B,0xCA,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC4,0xE3,0x7D,0x38,0xC1,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
; [0x7ff7c85f8f00, 0x7ff7c85f8fb4], 180 bytes
; 2020-01-20 01:59:21:468
0000h push rax                                ; PUSH r64 || 50+ro || encoded[1]{50}
0001h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
0008h vmovupd ymm0,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 00}
000dh vmovaps ymm1,ymm0                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 c8}
0011h vextractf128 xmm0,ymm0,0                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c0 00}
0017h mov rdx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d0}
001ah vpmovzxwd ymm0,xmm0                     ; VPMOVZXWD ymm1, xmm2/m128 || VEX.256.66.0F38.WIG 33 /r || encoded[5]{c4 e2 7d 33 c0}
001fh vpcmpeqd ymm2,ymm2,ymm2                 ; VPCMPEQD ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG 76 /r || encoded[4]{c5 ed 76 d2}
0023h vpgatherdd ymm3,[rdx+ymm0*2],ymm2       ; VPGATHERDD ymm1, vm32y, ymm2 || VEX.256.66.0F38.W0 90 /r || encoded[6]{c4 e2 6d 90 1c 42}
0029h vextractf128 xmm0,ymm3,0                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 d8 00}
002fh vextractf128 xmm2,ymm3,1                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 da 01}
0035h mov dword ptr [rsp+4],0FFFFh            ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 04 ff ff 00 00}
003dh lea rdx,[rsp+4]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 54 24 04}
0042h vpbroadcastd xmm3,dword ptr [rsp+4]     ; VPBROADCASTD xmm1, xmm2/m32 || VEX.128.66.0F38.W0 58 /r || encoded[7]{c4 e2 79 58 5c 24 04}
0049h vpand xmm0,xmm0,xmm3                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f9 db c3}
004dh vpand xmm2,xmm2,xmm3                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 e9 db d3}
0051h vpackusdw xmm0,xmm0,xmm2                ; VPACKUSDW xmm1, xmm2, xmm3/m128 || VEX.128.66.0F38.WIG 2B /r || encoded[5]{c4 e2 79 2b c2}
0056h vextractf128 xmm1,ymm1,1                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c9 01}
005ch vpmovzxwd ymm1,xmm1                     ; VPMOVZXWD ymm1, xmm2/m128 || VEX.256.66.0F38.WIG 33 /r || encoded[5]{c4 e2 7d 33 c9}
0061h vpcmpeqd ymm2,ymm2,ymm2                 ; VPCMPEQD ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG 76 /r || encoded[4]{c5 ed 76 d2}
0065h vpgatherdd ymm3,[rax+ymm1*2],ymm2       ; VPGATHERDD ymm1, vm32y, ymm2 || VEX.256.66.0F38.W0 90 /r || encoded[6]{c4 e2 6d 90 1c 48}
006bh vextractf128 xmm1,ymm3,0                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 d9 00}
0071h vextractf128 xmm2,ymm3,1                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 da 01}
0077h mov dword ptr [rsp],0FFFFh              ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[7]{c7 04 24 ff ff 00 00}
007eh lea rax,[rsp]                           ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 04 24}
0082h vpbroadcastd xmm3,dword ptr [rsp]       ; VPBROADCASTD xmm1, xmm2/m32 || VEX.128.66.0F38.W0 58 /r || encoded[6]{c4 e2 79 58 1c 24}
0088h vpand xmm1,xmm1,xmm3                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f1 db cb}
008ch vpand xmm2,xmm2,xmm3                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 e9 db d3}
0090h vpackusdw xmm1,xmm1,xmm2                ; VPACKUSDW xmm1, xmm2, xmm3/m128 || VEX.128.66.0F38.WIG 2B /r || encoded[5]{c4 e2 71 2b ca}
0095h vxorps ymm2,ymm2,ymm2                   ; VXORPS ymm1, ymm2, ymm3/m256 || VEX.256.0F.WIG 57 /r || encoded[4]{c5 ec 57 d2}
0099h vinserti128 ymm0,ymm2,xmm0,0            ; VINSERTI128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 38 /r ib || encoded[6]{c4 e3 6d 38 c0 00}
009fh vinserti128 ymm0,ymm0,xmm1,1            ; VINSERTI128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 38 /r ib || encoded[6]{c4 e3 7d 38 c1 01}
00a5h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
00a9h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
00ach vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
00afh add rsp,8                               ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 08}
00b3h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<ushort> vgather_256x16u(Span<ushort> src, Vector256<ushort> vix)
; static ReadOnlySpan<byte> vgather_256x16u__256x16uBytes => new byte[180]{0x50,0xC5,0xF8,0x77,0x90,0x48,0x8B,0x02,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xFC,0x28,0xC8,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0x48,0x8B,0xD0,0xC4,0xE2,0x7D,0x33,0xC0,0xC5,0xED,0x76,0xD2,0xC4,0xE2,0x6D,0x90,0x1C,0x42,0xC4,0xE3,0x7D,0x19,0xD8,0x00,0xC4,0xE3,0x7D,0x19,0xDA,0x01,0xC7,0x44,0x24,0x04,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x54,0x24,0x04,0xC4,0xE2,0x79,0x58,0x5C,0x24,0x04,0xC5,0xF9,0xDB,0xC3,0xC5,0xE9,0xDB,0xD3,0xC4,0xE2,0x79,0x2B,0xC2,0xC4,0xE3,0x7D,0x19,0xC9,0x01,0xC4,0xE2,0x7D,0x33,0xC9,0xC5,0xED,0x76,0xD2,0xC4,0xE2,0x6D,0x90,0x1C,0x48,0xC4,0xE3,0x7D,0x19,0xD9,0x00,0xC4,0xE3,0x7D,0x19,0xDA,0x01,0xC7,0x04,0x24,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x04,0x24,0xC4,0xE2,0x79,0x58,0x1C,0x24,0xC5,0xF1,0xDB,0xCB,0xC5,0xE9,0xDB,0xD3,0xC4,0xE2,0x71,0x2B,0xCA,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC4,0xE3,0x7D,0x38,0xC1,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x08,0xC3};
; [0x7ff7c85f8fe0, 0x7ff7c85f9094], 180 bytes
; 2020-01-20 01:59:21:468
0000h push rax                                ; PUSH r64 || 50+ro || encoded[1]{50}
0001h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
0008h vmovupd ymm0,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 00}
000dh vmovaps ymm1,ymm0                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 c8}
0011h vextractf128 xmm0,ymm0,0                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c0 00}
0017h mov rdx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d0}
001ah vpmovzxwd ymm0,xmm0                     ; VPMOVZXWD ymm1, xmm2/m128 || VEX.256.66.0F38.WIG 33 /r || encoded[5]{c4 e2 7d 33 c0}
001fh vpcmpeqd ymm2,ymm2,ymm2                 ; VPCMPEQD ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG 76 /r || encoded[4]{c5 ed 76 d2}
0023h vpgatherdd ymm3,[rdx+ymm0*2],ymm2       ; VPGATHERDD ymm1, vm32y, ymm2 || VEX.256.66.0F38.W0 90 /r || encoded[6]{c4 e2 6d 90 1c 42}
0029h vextractf128 xmm0,ymm3,0                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 d8 00}
002fh vextractf128 xmm2,ymm3,1                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 da 01}
0035h mov dword ptr [rsp+4],0FFFFh            ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 04 ff ff 00 00}
003dh lea rdx,[rsp+4]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 54 24 04}
0042h vpbroadcastd xmm3,dword ptr [rsp+4]     ; VPBROADCASTD xmm1, xmm2/m32 || VEX.128.66.0F38.W0 58 /r || encoded[7]{c4 e2 79 58 5c 24 04}
0049h vpand xmm0,xmm0,xmm3                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f9 db c3}
004dh vpand xmm2,xmm2,xmm3                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 e9 db d3}
0051h vpackusdw xmm0,xmm0,xmm2                ; VPACKUSDW xmm1, xmm2, xmm3/m128 || VEX.128.66.0F38.WIG 2B /r || encoded[5]{c4 e2 79 2b c2}
0056h vextractf128 xmm1,ymm1,1                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c9 01}
005ch vpmovzxwd ymm1,xmm1                     ; VPMOVZXWD ymm1, xmm2/m128 || VEX.256.66.0F38.WIG 33 /r || encoded[5]{c4 e2 7d 33 c9}
0061h vpcmpeqd ymm2,ymm2,ymm2                 ; VPCMPEQD ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG 76 /r || encoded[4]{c5 ed 76 d2}
0065h vpgatherdd ymm3,[rax+ymm1*2],ymm2       ; VPGATHERDD ymm1, vm32y, ymm2 || VEX.256.66.0F38.W0 90 /r || encoded[6]{c4 e2 6d 90 1c 48}
006bh vextractf128 xmm1,ymm3,0                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 d9 00}
0071h vextractf128 xmm2,ymm3,1                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 da 01}
0077h mov dword ptr [rsp],0FFFFh              ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[7]{c7 04 24 ff ff 00 00}
007eh lea rax,[rsp]                           ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 04 24}
0082h vpbroadcastd xmm3,dword ptr [rsp]       ; VPBROADCASTD xmm1, xmm2/m32 || VEX.128.66.0F38.W0 58 /r || encoded[6]{c4 e2 79 58 1c 24}
0088h vpand xmm1,xmm1,xmm3                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f1 db cb}
008ch vpand xmm2,xmm2,xmm3                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 e9 db d3}
0090h vpackusdw xmm1,xmm1,xmm2                ; VPACKUSDW xmm1, xmm2, xmm3/m128 || VEX.128.66.0F38.WIG 2B /r || encoded[5]{c4 e2 71 2b ca}
0095h vxorps ymm2,ymm2,ymm2                   ; VXORPS ymm1, ymm2, ymm3/m256 || VEX.256.0F.WIG 57 /r || encoded[4]{c5 ec 57 d2}
0099h vinserti128 ymm0,ymm2,xmm0,0            ; VINSERTI128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 38 /r ib || encoded[6]{c4 e3 6d 38 c0 00}
009fh vinserti128 ymm0,ymm0,xmm1,1            ; VINSERTI128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 38 /r ib || encoded[6]{c4 e3 7d 38 c1 01}
00a5h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
00a9h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
00ach vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
00afh add rsp,8                               ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 08}
00b3h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<int> vgather_256x32i(Span<int> src, Vector256<int> vix)
; static ReadOnlySpan<byte> vgather_256x32i__256x32iBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x02,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xF5,0x76,0xC9,0xC4,0xE2,0x75,0x90,0x14,0x80,0xC5,0xFD,0x11,0x11,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c85f94c0, 0x7ff7c85f94e2], 34 bytes
; 2020-01-20 01:59:21:468
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
0008h vmovupd ymm0,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 00}
000dh vpcmpeqd ymm1,ymm1,ymm1                 ; VPCMPEQD ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG 76 /r || encoded[4]{c5 f5 76 c9}
0011h vpgatherdd ymm2,[rax+ymm0*4],ymm1       ; VPGATHERDD ymm1, vm32y, ymm2 || VEX.256.66.0F38.W0 90 /r || encoded[6]{c4 e2 75 90 14 80}
0017h vmovupd [rcx],ymm2                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 11}
001bh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
001eh vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0021h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<ushort> vpackus_2x128x32(Vector128<uint> x, Vector128<uint> y)
; static ReadOnlySpan<byte> vpackus_2x128x32_128x32u_128x32uBytes => new byte[59]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC7,0x44,0x24,0x04,0xFF,0xFF,0x00,0x00,0x48,0x8D,0x44,0x24,0x04,0xC4,0xE2,0x79,0x58,0x54,0x24,0x04,0xC5,0xF9,0xDB,0xC2,0xC5,0xF1,0xDB,0xCA,0xC4,0xE2,0x79,0x2B,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
; [0x7ff7c85f9500, 0x7ff7c85f953b], 59 bytes
; 2020-01-20 01:59:21:468
0000h push rax                                ; PUSH r64 || 50+ro || encoded[1]{50}
0001h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh mov dword ptr [rsp+4],0FFFFh            ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 04 ff ff 00 00}
0016h lea rax,[rsp+4]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 04}
001bh vpbroadcastd xmm2,dword ptr [rsp+4]     ; VPBROADCASTD xmm1, xmm2/m32 || VEX.128.66.0F38.W0 58 /r || encoded[7]{c4 e2 79 58 54 24 04}
0022h vpand xmm0,xmm0,xmm2                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f9 db c2}
0026h vpand xmm1,xmm1,xmm2                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f1 db ca}
002ah vpackusdw xmm0,xmm0,xmm1                ; VPACKUSDW xmm1, xmm2, xmm3/m128 || VEX.128.66.0F38.WIG 2B /r || encoded[5]{c4 e2 79 2b c1}
002fh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0033h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0036h add rsp,8                               ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 08}
003ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<ushort> vlo_256x16u(Vector256<ushort> x)
; static ReadOnlySpan<byte> vlo_256x16u_256x16uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xE3,0x7D,0x19,0xC0,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c85f9560, 0x7ff7c85f957a], 26 bytes
; 2020-01-20 01:59:21:468
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h vextractf128 xmm0,ymm0,0                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c0 00}
000fh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0013h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0016h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0019h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<uint> vconvert_128x16u_256x32u(Vector128<ushort> src)
; static ReadOnlySpan<byte> vconvert_128x16u_256x32u_128x16uBytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xE2,0x7D,0x33,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c85f9590, 0x7ff7c85f95a9], 25 bytes
; 2020-01-20 01:59:21:468
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpmovzxwd ymm0,xmm0                     ; VPMOVZXWD ymm1, xmm2/m128 || VEX.256.66.0F38.WIG 33 /r || encoded[5]{c4 e2 7d 33 c0}
000eh vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0018h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
