; 2020-01-22 01:43:39:975
; void part63x3(ulong src, NatSpan<N21,byte> dst)
; part63x3_35977388[0x7ff7c85bfba0, 0x7ff7c85bfbfb][91] = {0f 1f 44 00 00 48 b8 ff ff ff ff ff ff ff 7f 48 23 c1 48 8b 0a 49 b8 07 07 07 07 07 07 07 07 c4 42 fb f5 c0 4c 89 01 48 8b 0a 48 83 c1 08 4c 8b c0 49 c1 e8 18 49 b9 07 07 07 07 07 07 07 07 c4 42 bb f5 c1 4c 89 01 48 8b 12 48 83 c2 10 48 c1 e8 30 c4 c2 fb f5 c1 48 89 02 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,7FFFFFFFFFFFFFFFh               ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 ff ff ff ff ff ff ff 7f}
000fh and rax,rcx                             ; AND r64, r/m64 || REX.W 23 /r || encoded[3]{48 23 c1}
0012h mov rcx,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 0a}
0015h mov r8,707070707070707h                 ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 b8 07 07 07 07 07 07 07 07}
001fh pdep r8,rax,r8                          ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 42 fb f5 c0}
0024h mov [rcx],r8                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 01}
0027h mov rcx,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 0a}
002ah add rcx,8                               ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c1 08}
002eh mov r8,rax                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b c0}
0031h shr r8,18h                              ; SHR r/m64, imm8 || REX.W C1 /5 ib || encoded[4]{49 c1 e8 18}
0035h mov r9,707070707070707h                 ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 b9 07 07 07 07 07 07 07 07}
003fh pdep r8,r8,r9                           ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 42 bb f5 c1}
0044h mov [rcx],r8                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 01}
0047h mov rdx,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 12}
004ah add rdx,10h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c2 10}
004eh shr rax,30h                             ; SHR r/m64, imm8 || REX.W C1 /5 ib || encoded[4]{48 c1 e8 30}
0052h pdep rax,rax,r9                         ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 c2 fb f5 c1}
0057h mov [rdx],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 02}
005ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<byte> bitgrid_vector256(BitGrid<byte> src, int block)
; bitgrid_vector256_[0x7ff7c85c10e0, 0x7ff7c85c1101][33] = {c5 f8 77 66 90 48 8b 02 41 c1 e0 05 49 63 d0 48 03 c2 c5 ff f0 00 c5 fd 11 01 48 8b c1 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
0008h shl r8d,5                               ; SHL r/m32, imm8 || o32 C1 /4 ib || encoded[4]{41 c1 e0 05}
000ch movsxd rdx,r8d                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{49 63 d0}
000fh add rax,rdx                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{48 03 c2}
0012h vlddqu ymm0,ymmword ptr [rax]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 00}
0016h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
001ah mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
001dh vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0020h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BitGrid256<N16,N16,ushort> transpose(BitGrid256<N16,N16,ushort> g)
; transpose_0x[0x7ff7c85c1930, 0x7ff7c85c1b9d][621] = {c5 f8 77 66 90 c5 fc 57 c0 c5 fd 10 0a b8 07 00 00 00 c5 f9 6e d0 c5 f5 f3 d2 c5 fd d7 c2 ba 55 55 55 55 c4 e2 7a f5 d2 0f b7 d2 c5 fc 28 d0 c5 e9 c4 d2 00 c4 e3 7d 18 c2 00 ba aa aa aa aa c4 e2 7a f5 c2 0f b7 c0 c4 e3 7d 19 c2 01 c5 e9 c4 d0 00 c4 e3 7d 18 c2 01 b8 06 00 00 00 c5 f9 6e d0 c5 f5 f3 d2 c5 fd d7 c2 ba 55 55 55 55 c4 e2 7a f5 d2 0f b7 d2 c5 fc 28 d0 c5 e9 c4 d2 01 c4 e3 7d 18 c2 00 ba aa aa aa aa c4 e2 7a f5 c2 0f b7 c0 c4 e3 7d 19 c2 01 c5 e9 c4 d0 01 c4 e3 7d 18 c2 01 b8 05 00 00 00 c5 f9 6e d0 c5 f5 f3 d2 c5 fd d7 c2 ba 55 55 55 55 c4 e2 7a f5 d2 0f b7 d2 c5 fc 28 d0 c5 e9 c4 d2 02 c4 e3 7d 18 c2 00 ba aa aa aa aa c4 e2 7a f5 c2 0f b7 c0 c4 e3 7d 19 c2 01 c5 e9 c4 d0 02 c4 e3 7d 18 c2 01 b8 04 00 00 00 c5 f9 6e d0 c5 f5 f3 d2 c5 fd d7 c2 ba 55 55 55 55 c4 e2 7a f5 d2 0f b7 d2 c5 fc 28 d0 c5 e9 c4 d2 03 c4 e3 7d 18 c2 00 ba aa aa aa aa c4 e2 7a f5 c2 0f b7 c0 c4 e3 7d 19 c2 01 c5 e9 c4 d0 03 c4 e3 7d 18 c2 01 b8 03 00 00 00 c5 f9 6e d0 c5 f5 f3 d2 c5 fd d7 c2 ba 55 55 55 55 c4 e2 7a f5 d2 0f b7 d2 c5 fc 28 d0 c5 e9 c4 d2 04 c4 e3 7d 18 c2 00 ba aa aa aa aa c4 e2 7a f5 c2 0f b7 c0 c4 e3 7d 19 c2 01 c5 e9 c4 d0 04 c4 e3 7d 18 c2 01 b8 02 00 00 00 c5 f9 6e d0 c5 f5 f3 d2 c5 fd d7 c2 ba 55 55 55 55 c4 e2 7a f5 d2 0f b7 d2 c5 fc 28 d0 c5 e9 c4 d2 05 c4 e3 7d 18 c2 00 ba aa aa aa aa c4 e2 7a f5 c2 0f b7 c0 c4 e3 7d 19 c2 01 c5 e9 c4 d0 05 c4 e3 7d 18 c2 01 b8 01 00 00 00 c5 f9 6e d0 c5 f5 f3 d2 c5 fd d7 c2 ba 55 55 55 55 c4 e2 7a f5 d2 0f b7 d2 c5 fc 28 d0 c5 e9 c4 d2 06 c4 e3 7d 18 c2 00 ba aa aa aa aa c4 e2 7a f5 c2 0f b7 c0 c4 e3 7d 19 c2 01 c5 e9 c4 d0 06 c4 e3 7d 18 c2 01 33 c0 c5 f9 6e d0 c5 f5 f3 ca c5 fd d7 c1 ba 55 55 55 55 c4 e2 7a f5 d2 0f b7 d2 c5 fc 28 c8 c5 f1 c4 ca 07 c4 e3 7d 18 c1 00 ba aa aa aa aa c4 e2 7a f5 c2 0f b7 c0 c4 e3 7d 19 c1 01 c5 f1 c4 c8 07 c4 e3 7d 18 c1 01 c5 fd 11 01 48 8b c1 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vxorps ymm0,ymm0,ymm0                   ; VXORPS ymm1, ymm2, ymm3/m256 || VEX.256.0F.WIG 57 /r || encoded[4]{c5 fc 57 c0}
0009h vmovupd ymm1,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 0a}
000dh mov eax,7                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 07 00 00 00}
0012h vmovd xmm2,eax                          ; VMOVD xmm1, r/m32 || VEX.128.66.0F.W0 6E /r || encoded[4]{c5 f9 6e d0}
0016h vpsllq ymm2,ymm1,xmm2                   ; VPSLLQ ymm1, ymm2, xmm3/m128 || VEX.256.66.0F.WIG F3 /r || encoded[4]{c5 f5 f3 d2}
001ah vpmovmskb eax,ymm2                      ; VPMOVMSKB r32, ymm1 || VEX.256.66.0F.W0 D7 /r || encoded[4]{c5 fd d7 c2}
001eh mov edx,55555555h                       ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 55 55 55 55}
0023h pext edx,eax,edx                        ; PEXT r32a, r32b, r/m32 || VEX.LZ.F3.0F38.W0 F5 /r || encoded[5]{c4 e2 7a f5 d2}
0028h movzx edx,dx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 d2}
002bh vmovaps ymm2,ymm0                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 d0}
002fh vpinsrw xmm2,xmm2,edx,0                 ; VPINSRW xmm1, xmm2, r32/m16, imm8 || VEX.128.66.0F.W0 C4 /r ib || encoded[5]{c5 e9 c4 d2 00}
0034h vinsertf128 ymm0,ymm0,xmm2,0            ; VINSERTF128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 18 /r ib || encoded[6]{c4 e3 7d 18 c2 00}
003ah mov edx,0AAAAAAAAh                      ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba aa aa aa aa}
003fh pext eax,eax,edx                        ; PEXT r32a, r32b, r/m32 || VEX.LZ.F3.0F38.W0 F5 /r || encoded[5]{c4 e2 7a f5 c2}
0044h movzx eax,ax                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c0}
0047h vextractf128 xmm2,ymm0,1                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c2 01}
004dh vpinsrw xmm2,xmm2,eax,0                 ; VPINSRW xmm1, xmm2, r32/m16, imm8 || VEX.128.66.0F.W0 C4 /r ib || encoded[5]{c5 e9 c4 d0 00}
0052h vinsertf128 ymm0,ymm0,xmm2,1            ; VINSERTF128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 18 /r ib || encoded[6]{c4 e3 7d 18 c2 01}
0058h mov eax,6                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 06 00 00 00}
005dh vmovd xmm2,eax                          ; VMOVD xmm1, r/m32 || VEX.128.66.0F.W0 6E /r || encoded[4]{c5 f9 6e d0}
0061h vpsllq ymm2,ymm1,xmm2                   ; VPSLLQ ymm1, ymm2, xmm3/m128 || VEX.256.66.0F.WIG F3 /r || encoded[4]{c5 f5 f3 d2}
0065h vpmovmskb eax,ymm2                      ; VPMOVMSKB r32, ymm1 || VEX.256.66.0F.W0 D7 /r || encoded[4]{c5 fd d7 c2}
0069h mov edx,55555555h                       ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 55 55 55 55}
006eh pext edx,eax,edx                        ; PEXT r32a, r32b, r/m32 || VEX.LZ.F3.0F38.W0 F5 /r || encoded[5]{c4 e2 7a f5 d2}
0073h movzx edx,dx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 d2}
0076h vmovaps ymm2,ymm0                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 d0}
007ah vpinsrw xmm2,xmm2,edx,1                 ; VPINSRW xmm1, xmm2, r32/m16, imm8 || VEX.128.66.0F.W0 C4 /r ib || encoded[5]{c5 e9 c4 d2 01}
007fh vinsertf128 ymm0,ymm0,xmm2,0            ; VINSERTF128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 18 /r ib || encoded[6]{c4 e3 7d 18 c2 00}
0085h mov edx,0AAAAAAAAh                      ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba aa aa aa aa}
008ah pext eax,eax,edx                        ; PEXT r32a, r32b, r/m32 || VEX.LZ.F3.0F38.W0 F5 /r || encoded[5]{c4 e2 7a f5 c2}
008fh movzx eax,ax                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c0}
0092h vextractf128 xmm2,ymm0,1                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c2 01}
0098h vpinsrw xmm2,xmm2,eax,1                 ; VPINSRW xmm1, xmm2, r32/m16, imm8 || VEX.128.66.0F.W0 C4 /r ib || encoded[5]{c5 e9 c4 d0 01}
009dh vinsertf128 ymm0,ymm0,xmm2,1            ; VINSERTF128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 18 /r ib || encoded[6]{c4 e3 7d 18 c2 01}
00a3h mov eax,5                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 05 00 00 00}
00a8h vmovd xmm2,eax                          ; VMOVD xmm1, r/m32 || VEX.128.66.0F.W0 6E /r || encoded[4]{c5 f9 6e d0}
00ach vpsllq ymm2,ymm1,xmm2                   ; VPSLLQ ymm1, ymm2, xmm3/m128 || VEX.256.66.0F.WIG F3 /r || encoded[4]{c5 f5 f3 d2}
00b0h vpmovmskb eax,ymm2                      ; VPMOVMSKB r32, ymm1 || VEX.256.66.0F.W0 D7 /r || encoded[4]{c5 fd d7 c2}
00b4h mov edx,55555555h                       ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 55 55 55 55}
00b9h pext edx,eax,edx                        ; PEXT r32a, r32b, r/m32 || VEX.LZ.F3.0F38.W0 F5 /r || encoded[5]{c4 e2 7a f5 d2}
00beh movzx edx,dx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 d2}
00c1h vmovaps ymm2,ymm0                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 d0}
00c5h vpinsrw xmm2,xmm2,edx,2                 ; VPINSRW xmm1, xmm2, r32/m16, imm8 || VEX.128.66.0F.W0 C4 /r ib || encoded[5]{c5 e9 c4 d2 02}
00cah vinsertf128 ymm0,ymm0,xmm2,0            ; VINSERTF128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 18 /r ib || encoded[6]{c4 e3 7d 18 c2 00}
00d0h mov edx,0AAAAAAAAh                      ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba aa aa aa aa}
00d5h pext eax,eax,edx                        ; PEXT r32a, r32b, r/m32 || VEX.LZ.F3.0F38.W0 F5 /r || encoded[5]{c4 e2 7a f5 c2}
00dah movzx eax,ax                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c0}
00ddh vextractf128 xmm2,ymm0,1                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c2 01}
00e3h vpinsrw xmm2,xmm2,eax,2                 ; VPINSRW xmm1, xmm2, r32/m16, imm8 || VEX.128.66.0F.W0 C4 /r ib || encoded[5]{c5 e9 c4 d0 02}
00e8h vinsertf128 ymm0,ymm0,xmm2,1            ; VINSERTF128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 18 /r ib || encoded[6]{c4 e3 7d 18 c2 01}
00eeh mov eax,4                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 04 00 00 00}
00f3h vmovd xmm2,eax                          ; VMOVD xmm1, r/m32 || VEX.128.66.0F.W0 6E /r || encoded[4]{c5 f9 6e d0}
00f7h vpsllq ymm2,ymm1,xmm2                   ; VPSLLQ ymm1, ymm2, xmm3/m128 || VEX.256.66.0F.WIG F3 /r || encoded[4]{c5 f5 f3 d2}
00fbh vpmovmskb eax,ymm2                      ; VPMOVMSKB r32, ymm1 || VEX.256.66.0F.W0 D7 /r || encoded[4]{c5 fd d7 c2}
00ffh mov edx,55555555h                       ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 55 55 55 55}
0104h pext edx,eax,edx                        ; PEXT r32a, r32b, r/m32 || VEX.LZ.F3.0F38.W0 F5 /r || encoded[5]{c4 e2 7a f5 d2}
0109h movzx edx,dx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 d2}
010ch vmovaps ymm2,ymm0                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 d0}
0110h vpinsrw xmm2,xmm2,edx,3                 ; VPINSRW xmm1, xmm2, r32/m16, imm8 || VEX.128.66.0F.W0 C4 /r ib || encoded[5]{c5 e9 c4 d2 03}
0115h vinsertf128 ymm0,ymm0,xmm2,0            ; VINSERTF128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 18 /r ib || encoded[6]{c4 e3 7d 18 c2 00}
011bh mov edx,0AAAAAAAAh                      ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba aa aa aa aa}
0120h pext eax,eax,edx                        ; PEXT r32a, r32b, r/m32 || VEX.LZ.F3.0F38.W0 F5 /r || encoded[5]{c4 e2 7a f5 c2}
0125h movzx eax,ax                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c0}
0128h vextractf128 xmm2,ymm0,1                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c2 01}
012eh vpinsrw xmm2,xmm2,eax,3                 ; VPINSRW xmm1, xmm2, r32/m16, imm8 || VEX.128.66.0F.W0 C4 /r ib || encoded[5]{c5 e9 c4 d0 03}
0133h vinsertf128 ymm0,ymm0,xmm2,1            ; VINSERTF128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 18 /r ib || encoded[6]{c4 e3 7d 18 c2 01}
0139h mov eax,3                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 03 00 00 00}
013eh vmovd xmm2,eax                          ; VMOVD xmm1, r/m32 || VEX.128.66.0F.W0 6E /r || encoded[4]{c5 f9 6e d0}
0142h vpsllq ymm2,ymm1,xmm2                   ; VPSLLQ ymm1, ymm2, xmm3/m128 || VEX.256.66.0F.WIG F3 /r || encoded[4]{c5 f5 f3 d2}
0146h vpmovmskb eax,ymm2                      ; VPMOVMSKB r32, ymm1 || VEX.256.66.0F.W0 D7 /r || encoded[4]{c5 fd d7 c2}
014ah mov edx,55555555h                       ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 55 55 55 55}
014fh pext edx,eax,edx                        ; PEXT r32a, r32b, r/m32 || VEX.LZ.F3.0F38.W0 F5 /r || encoded[5]{c4 e2 7a f5 d2}
0154h movzx edx,dx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 d2}
0157h vmovaps ymm2,ymm0                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 d0}
015bh vpinsrw xmm2,xmm2,edx,4                 ; VPINSRW xmm1, xmm2, r32/m16, imm8 || VEX.128.66.0F.W0 C4 /r ib || encoded[5]{c5 e9 c4 d2 04}
0160h vinsertf128 ymm0,ymm0,xmm2,0            ; VINSERTF128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 18 /r ib || encoded[6]{c4 e3 7d 18 c2 00}
0166h mov edx,0AAAAAAAAh                      ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba aa aa aa aa}
016bh pext eax,eax,edx                        ; PEXT r32a, r32b, r/m32 || VEX.LZ.F3.0F38.W0 F5 /r || encoded[5]{c4 e2 7a f5 c2}
0170h movzx eax,ax                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c0}
0173h vextractf128 xmm2,ymm0,1                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c2 01}
0179h vpinsrw xmm2,xmm2,eax,4                 ; VPINSRW xmm1, xmm2, r32/m16, imm8 || VEX.128.66.0F.W0 C4 /r ib || encoded[5]{c5 e9 c4 d0 04}
017eh vinsertf128 ymm0,ymm0,xmm2,1            ; VINSERTF128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 18 /r ib || encoded[6]{c4 e3 7d 18 c2 01}
0184h mov eax,2                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 02 00 00 00}
0189h vmovd xmm2,eax                          ; VMOVD xmm1, r/m32 || VEX.128.66.0F.W0 6E /r || encoded[4]{c5 f9 6e d0}
018dh vpsllq ymm2,ymm1,xmm2                   ; VPSLLQ ymm1, ymm2, xmm3/m128 || VEX.256.66.0F.WIG F3 /r || encoded[4]{c5 f5 f3 d2}
0191h vpmovmskb eax,ymm2                      ; VPMOVMSKB r32, ymm1 || VEX.256.66.0F.W0 D7 /r || encoded[4]{c5 fd d7 c2}
0195h mov edx,55555555h                       ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 55 55 55 55}
019ah pext edx,eax,edx                        ; PEXT r32a, r32b, r/m32 || VEX.LZ.F3.0F38.W0 F5 /r || encoded[5]{c4 e2 7a f5 d2}
019fh movzx edx,dx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 d2}
01a2h vmovaps ymm2,ymm0                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 d0}
01a6h vpinsrw xmm2,xmm2,edx,5                 ; VPINSRW xmm1, xmm2, r32/m16, imm8 || VEX.128.66.0F.W0 C4 /r ib || encoded[5]{c5 e9 c4 d2 05}
01abh vinsertf128 ymm0,ymm0,xmm2,0            ; VINSERTF128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 18 /r ib || encoded[6]{c4 e3 7d 18 c2 00}
01b1h mov edx,0AAAAAAAAh                      ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba aa aa aa aa}
01b6h pext eax,eax,edx                        ; PEXT r32a, r32b, r/m32 || VEX.LZ.F3.0F38.W0 F5 /r || encoded[5]{c4 e2 7a f5 c2}
01bbh movzx eax,ax                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c0}
01beh vextractf128 xmm2,ymm0,1                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c2 01}
01c4h vpinsrw xmm2,xmm2,eax,5                 ; VPINSRW xmm1, xmm2, r32/m16, imm8 || VEX.128.66.0F.W0 C4 /r ib || encoded[5]{c5 e9 c4 d0 05}
01c9h vinsertf128 ymm0,ymm0,xmm2,1            ; VINSERTF128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 18 /r ib || encoded[6]{c4 e3 7d 18 c2 01}
01cfh mov eax,1                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 01 00 00 00}
01d4h vmovd xmm2,eax                          ; VMOVD xmm1, r/m32 || VEX.128.66.0F.W0 6E /r || encoded[4]{c5 f9 6e d0}
01d8h vpsllq ymm2,ymm1,xmm2                   ; VPSLLQ ymm1, ymm2, xmm3/m128 || VEX.256.66.0F.WIG F3 /r || encoded[4]{c5 f5 f3 d2}
01dch vpmovmskb eax,ymm2                      ; VPMOVMSKB r32, ymm1 || VEX.256.66.0F.W0 D7 /r || encoded[4]{c5 fd d7 c2}
01e0h mov edx,55555555h                       ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 55 55 55 55}
01e5h pext edx,eax,edx                        ; PEXT r32a, r32b, r/m32 || VEX.LZ.F3.0F38.W0 F5 /r || encoded[5]{c4 e2 7a f5 d2}
01eah movzx edx,dx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 d2}
01edh vmovaps ymm2,ymm0                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 d0}
01f1h vpinsrw xmm2,xmm2,edx,6                 ; VPINSRW xmm1, xmm2, r32/m16, imm8 || VEX.128.66.0F.W0 C4 /r ib || encoded[5]{c5 e9 c4 d2 06}
01f6h vinsertf128 ymm0,ymm0,xmm2,0            ; VINSERTF128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 18 /r ib || encoded[6]{c4 e3 7d 18 c2 00}
01fch mov edx,0AAAAAAAAh                      ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba aa aa aa aa}
0201h pext eax,eax,edx                        ; PEXT r32a, r32b, r/m32 || VEX.LZ.F3.0F38.W0 F5 /r || encoded[5]{c4 e2 7a f5 c2}
0206h movzx eax,ax                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c0}
0209h vextractf128 xmm2,ymm0,1                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c2 01}
020fh vpinsrw xmm2,xmm2,eax,6                 ; VPINSRW xmm1, xmm2, r32/m16, imm8 || VEX.128.66.0F.W0 C4 /r ib || encoded[5]{c5 e9 c4 d0 06}
0214h vinsertf128 ymm0,ymm0,xmm2,1            ; VINSERTF128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 18 /r ib || encoded[6]{c4 e3 7d 18 c2 01}
021ah xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
021ch vmovd xmm2,eax                          ; VMOVD xmm1, r/m32 || VEX.128.66.0F.W0 6E /r || encoded[4]{c5 f9 6e d0}
0220h vpsllq ymm1,ymm1,xmm2                   ; VPSLLQ ymm1, ymm2, xmm3/m128 || VEX.256.66.0F.WIG F3 /r || encoded[4]{c5 f5 f3 ca}
0224h vpmovmskb eax,ymm1                      ; VPMOVMSKB r32, ymm1 || VEX.256.66.0F.W0 D7 /r || encoded[4]{c5 fd d7 c1}
0228h mov edx,55555555h                       ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 55 55 55 55}
022dh pext edx,eax,edx                        ; PEXT r32a, r32b, r/m32 || VEX.LZ.F3.0F38.W0 F5 /r || encoded[5]{c4 e2 7a f5 d2}
0232h movzx edx,dx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 d2}
0235h vmovaps ymm1,ymm0                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 c8}
0239h vpinsrw xmm1,xmm1,edx,7                 ; VPINSRW xmm1, xmm2, r32/m16, imm8 || VEX.128.66.0F.W0 C4 /r ib || encoded[5]{c5 f1 c4 ca 07}
023eh vinsertf128 ymm0,ymm0,xmm1,0            ; VINSERTF128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 18 /r ib || encoded[6]{c4 e3 7d 18 c1 00}
0244h mov edx,0AAAAAAAAh                      ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba aa aa aa aa}
0249h pext eax,eax,edx                        ; PEXT r32a, r32b, r/m32 || VEX.LZ.F3.0F38.W0 F5 /r || encoded[5]{c4 e2 7a f5 c2}
024eh movzx eax,ax                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c0}
0251h vextractf128 xmm1,ymm0,1                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c1 01}
0257h vpinsrw xmm1,xmm1,eax,7                 ; VPINSRW xmm1, xmm2, r32/m16, imm8 || VEX.128.66.0F.W0 C4 /r ib || encoded[5]{c5 f1 c4 c8 07}
025ch vinsertf128 ymm0,ymm0,xmm1,1            ; VINSERTF128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 18 /r ib || encoded[6]{c4 e3 7d 18 c1 01}
0262h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0266h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0269h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
026ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit read_bit_from_vector(in BitBlock<N23,byte> src)
; read_bit_from_vector_0x[0x7ff7c85c1d10, 0x7ff7c85c1d25][21] = {0f 1f 44 00 00 48 8b 01 0f b6 00 0f b6 c0 c1 e8 03 83 e0 01 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 01}
0008h movzx eax,byte ptr [rax]                ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 00}
000bh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
000eh shr eax,3                               ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[3]{c1 e8 03}
0011h and eax,1                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e0 01}
0014h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; int segments()
; segments_56256135[0x7ff7c85c1d40, 0x7ff7c85c1d70][48] = {48 83 ec 18 90 c6 44 24 10 00 48 8d 44 24 10 c6 00 00 c6 44 24 08 00 48 8d 44 24 08 c6 00 00 b8 01 00 00 00 83 c0 02 33 d2 03 c2 48 83 c4 18 c3}
; Capture completion code, None
0000h sub rsp,18h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 18}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov byte ptr [rsp+10h],0                ; MOV r/m8, imm8 || C6 /0 ib || encoded[5]{c6 44 24 10 00}
000ah lea rax,[rsp+10h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 10}
000fh mov byte ptr [rax],0                    ; MOV r/m8, imm8 || C6 /0 ib || encoded[3]{c6 00 00}
0012h mov byte ptr [rsp+8],0                  ; MOV r/m8, imm8 || C6 /0 ib || encoded[5]{c6 44 24 08 00}
0017h lea rax,[rsp+8]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 08}
001ch mov byte ptr [rax],0                    ; MOV r/m8, imm8 || C6 /0 ib || encoded[3]{c6 00 00}
001fh mov eax,1                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 01 00 00 00}
0024h add eax,2                               ; ADD r/m32, imm8 || o32 83 /0 ib || encoded[3]{83 c0 02}
0027h xor edx,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d2}
0029h add eax,edx                             ; ADD r32, r/m32 || o32 03 /r || encoded[2]{03 c2}
002bh add rsp,18h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 18}
002fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; int count_segs()
; count_segs_36543171[0x7ff7c85c1d90, 0x7ff7c85c1de3][83] = {48 83 ec 18 33 c0 48 89 44 24 10 48 89 44 24 08 48 8d 44 24 10 c6 00 00 48 8d 44 24 08 c6 00 00 33 c0 83 c0 4b 8b d0 c1 fa 1f 83 e2 03 03 d0 c1 fa 02 8b c8 c1 f9 1f 83 e1 03 03 c8 83 e1 fc 2b c1 75 04 33 c0 eb 05 b8 01 00 00 00 03 c2 48 83 c4 18 c3}
; Capture completion code, None
0000h sub rsp,18h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 18}
0004h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0006h mov [rsp+10h],rax                       ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 44 24 10}
000bh mov [rsp+8],rax                         ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 44 24 08}
0010h lea rax,[rsp+10h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 10}
0015h mov byte ptr [rax],0                    ; MOV r/m8, imm8 || C6 /0 ib || encoded[3]{c6 00 00}
0018h lea rax,[rsp+8]                         ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 44 24 08}
001dh mov byte ptr [rax],0                    ; MOV r/m8, imm8 || C6 /0 ib || encoded[3]{c6 00 00}
0020h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0022h add eax,4Bh                             ; ADD r/m32, imm8 || o32 83 /0 ib || encoded[3]{83 c0 4b}
0025h mov edx,eax                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b d0}
0027h sar edx,1Fh                             ; SAR r/m32, imm8 || o32 C1 /7 ib || encoded[3]{c1 fa 1f}
002ah and edx,3                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e2 03}
002dh add edx,eax                             ; ADD r32, r/m32 || o32 03 /r || encoded[2]{03 d0}
002fh sar edx,2                               ; SAR r/m32, imm8 || o32 C1 /7 ib || encoded[3]{c1 fa 02}
0032h mov ecx,eax                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c8}
0034h sar ecx,1Fh                             ; SAR r/m32, imm8 || o32 C1 /7 ib || encoded[3]{c1 f9 1f}
0037h and ecx,3                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e1 03}
003ah add ecx,eax                             ; ADD r32, r/m32 || o32 03 /r || encoded[2]{03 c8}
003ch and ecx,0FFFFFFFCh                      ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e1 fc}
003fh sub eax,ecx                             ; SUB r32, r/m32 || o32 2B /r || encoded[2]{2b c1}
0041h jne short 0047h                         ; JNE rel8 || 75 cb || encoded[2]{75 04}
0043h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0045h jmp short 004ch                         ; JMP rel8 || EB cb || encoded[2]{eb 05}
0047h mov eax,1                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 01 00 00 00}
004ch add eax,edx                             ; ADD r32, r/m32 || o32 03 /r || encoded[2]{03 c2}
004eh add rsp,18h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 18}
0052h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit readbit_row_col_2(int n, ulong src, int row, int col)
; readbit_row_col_2_32i[0x7ff7c85c2200, 0x7ff7c85c2243][67] = {0f 1f 44 00 00 48 89 54 24 10 41 0f af c8 41 03 c9 8b c1 c1 f8 1f 83 e0 3f 03 c1 c1 f8 06 48 8d 54 24 10 48 63 c0 48 8b 04 c2 8b d1 c1 fa 1f 83 e2 3f 03 d1 83 e2 c0 2b ca 0f b6 c9 48 d3 e8 83 e0 01 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov [rsp+10h],rdx                       ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 54 24 10}
000ah imul ecx,r8d                            ; IMUL r32, r/m32 || o32 0F AF /r || encoded[4]{41 0f af c8}
000eh add ecx,r9d                             ; ADD r32, r/m32 || o32 03 /r || encoded[3]{41 03 c9}
0011h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0013h sar eax,1Fh                             ; SAR r/m32, imm8 || o32 C1 /7 ib || encoded[3]{c1 f8 1f}
0016h and eax,3Fh                             ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e0 3f}
0019h add eax,ecx                             ; ADD r32, r/m32 || o32 03 /r || encoded[2]{03 c1}
001bh sar eax,6                               ; SAR r/m32, imm8 || o32 C1 /7 ib || encoded[3]{c1 f8 06}
001eh lea rdx,[rsp+10h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 54 24 10}
0023h movsxd rax,eax                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 c0}
0026h mov rax,[rdx+rax*8]                     ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 04 c2}
002ah mov edx,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b d1}
002ch sar edx,1Fh                             ; SAR r/m32, imm8 || o32 C1 /7 ib || encoded[3]{c1 fa 1f}
002fh and edx,3Fh                             ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e2 3f}
0032h add edx,ecx                             ; ADD r32, r/m32 || o32 03 /r || encoded[2]{03 d1}
0034h and edx,0FFFFFFC0h                      ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e2 c0}
0037h sub ecx,edx                             ; SUB r32, r/m32 || o32 2B /r || encoded[2]{2b ca}
0039h movzx ecx,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c9}
003ch shr rax,cl                              ; SHR r/m64, CL || REX.W D3 /5 || encoded[3]{48 d3 e8}
003fh and eax,1                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e0 01}
0042h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; bit readbit_g_position(in ulong src, int pos)
; readbit_g_position_64u[0x7ff7c85c2260, 0x7ff7c85c2292][50] = {0f 1f 44 00 00 8b c2 c1 f8 1f 83 e0 3f 03 c2 c1 f8 06 48 63 c0 48 8b 04 c1 8b ca c1 f9 1f 83 e1 3f 03 ca 83 e1 c0 2b d1 0f b6 ca 48 d3 e8 83 e0 01 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c2}
0007h sar eax,1Fh                             ; SAR r/m32, imm8 || o32 C1 /7 ib || encoded[3]{c1 f8 1f}
000ah and eax,3Fh                             ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e0 3f}
000dh add eax,edx                             ; ADD r32, r/m32 || o32 03 /r || encoded[2]{03 c2}
000fh sar eax,6                               ; SAR r/m32, imm8 || o32 C1 /7 ib || encoded[3]{c1 f8 06}
0012h movsxd rax,eax                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 c0}
0015h mov rax,[rcx+rax*8]                     ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 04 c1}
0019h mov ecx,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b ca}
001bh sar ecx,1Fh                             ; SAR r/m32, imm8 || o32 C1 /7 ib || encoded[3]{c1 f9 1f}
001eh and ecx,3Fh                             ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e1 3f}
0021h add ecx,edx                             ; ADD r32, r/m32 || o32 03 /r || encoded[2]{03 ca}
0023h and ecx,0FFFFFFC0h                      ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e1 c0}
0026h sub edx,ecx                             ; SUB r32, r/m32 || o32 2B /r || encoded[2]{2b d1}
0028h movzx ecx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 ca}
002bh shr rax,cl                              ; SHR r/m64, CL || REX.W D3 /5 || encoded[3]{48 d3 e8}
002eh and eax,1                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e0 01}
0031h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
