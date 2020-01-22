; 2020-01-22 01:44:40:326
; byte natcompute()
; natcompute_29135036[0x7ff7c81c1690, 0x7ff7c81c169b][11] = {0f 1f 44 00 00 b8 c6 00 00 00 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,0C6h                            ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 c6 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector512<ushort> vblendp_256x16u(Vector256<ushort> x, Vector256<ushort> y, Vector256<ushort> spec)
; vblendp_256x16u_256x16u_256x16u_256x16u[0x7ff7c81c1ac0, 0x7ff7c81c1b03][67] = {c5 f8 77 66 90 c5 fd 10 02 c4 c1 7d 10 08 c4 c1 7d 10 11 c5 fc 28 d8 c5 fc 28 e1 c5 fc 28 ea c4 e3 65 4c dc 50 c5 ed 75 e2 c5 ed ef d4 c4 e3 7d 4c c1 20 c5 fd 11 19 c5 fd 11 41 20 48 8b c1 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h vmovupd ymm1,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 08}
000eh vmovupd ymm2,[r9]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 11}
0013h vmovaps ymm3,ymm0                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 d8}
0017h vmovaps ymm4,ymm1                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 e1}
001bh vmovaps ymm5,ymm2                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 ea}
001fh vpblendvb ymm3,ymm3,ymm4,ymm5           ; VPBLENDVB ymm1, ymm2, ymm3/m256, ymm4 || VEX.256.66.0F3A.W0 4C /r /is4 || encoded[6]{c4 e3 65 4c dc 50}
0025h vpcmpeqw ymm4,ymm2,ymm2                 ; VPCMPEQW ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG 75 /r || encoded[4]{c5 ed 75 e2}
0029h vpxor ymm2,ymm2,ymm4                    ; VPXOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EF /r || encoded[4]{c5 ed ef d4}
002dh vpblendvb ymm0,ymm0,ymm1,ymm2           ; VPBLENDVB ymm1, ymm2, ymm3/m256, ymm4 || VEX.256.66.0F3A.W0 4C /r /is4 || encoded[6]{c4 e3 7d 4c c1 20}
0033h vmovupd [rcx],ymm3                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 19}
0037h vmovupd [rcx+20h],ymm0                  ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[5]{c5 fd 11 41 20}
003ch mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
003fh vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0042h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<ulong> vreverse_128x64u(Vector128<ulong> x)
; vreverse_128x64u_128x64u[0x7ff7c81c1b20, 0x7ff7c81c1b36][22] = {c5 f8 77 66 90 c5 f9 10 02 c5 f9 70 c0 4e c5 f9 11 01 48 8b c1 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpshufd xmm0,xmm0,4Eh                   ; VPSHUFD xmm1, xmm2/m128, imm8 || VEX.128.66.0F.WIG 70 /r ib || encoded[5]{c5 f9 70 c0 4e}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<byte> vreverse_128x8u(Vector128<byte> x)
; vreverse_128x8u_128x8u[0x7ff7c81c2100, 0x7ff7c81c2124][36] = {c5 f8 77 66 90 c5 f9 10 02 48 b8 09 53 1d 36 c2 02 00 00 c5 fb f0 08 c4 e2 79 00 c1 c5 f9 11 01 48 8b c1 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h mov rax,2C2361D5309h                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 09 53 1d 36 c2 02 00 00}
0013h vlddqu xmm1,xmmword ptr [rax]           ; VLDDQU xmm1, m128 || VEX.128.F2.0F.WIG F0 /r || encoded[4]{c5 fb f0 08}
0017h vpshufb xmm0,xmm0,xmm1                  ; VPSHUFB xmm1, xmm2, xmm3/m128 || VEX.128.66.0F38.WIG 00 /r || encoded[5]{c4 e2 79 00 c1}
001ch vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0020h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0023h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<byte> vreverse_256x8u(Vector256<byte> x)
; vreverse_256x8u_256x8u[0x7ff7c81c2330, 0x7ff7c81c238a][90] = {c5 f8 77 66 90 c5 fd 10 02 48 b8 89 54 1d 36 c2 02 00 00 c5 ff f0 08 48 b8 15 7a 96 4e c2 02 00 00 c5 ff f0 10 c5 f5 fc d2 c4 e2 7d 00 d2 c4 e3 7d 46 c0 03 48 b8 45 78 96 4e c2 02 00 00 c5 ff f0 18 c5 f5 fc cb c4 e2 7d 00 c1 c5 ed eb c0 c5 fd 11 01 48 8b c1 c5 f8 77 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h mov rax,2C2361D5489h                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 89 54 1d 36 c2 02 00 00}
0013h vlddqu ymm1,ymmword ptr [rax]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 08}
0017h mov rax,2C24E967A15h                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 15 7a 96 4e c2 02 00 00}
0021h vlddqu ymm2,ymmword ptr [rax]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 10}
0025h vpaddb ymm2,ymm1,ymm2                   ; VPADDB ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG FC /r || encoded[4]{c5 f5 fc d2}
0029h vpshufb ymm2,ymm0,ymm2                  ; VPSHUFB ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 00 /r || encoded[5]{c4 e2 7d 00 d2}
002eh vperm2i128 ymm0,ymm0,ymm0,3             ; VPERM2I128 ymm1, ymm2, ymm3/m256, imm8 || VEX.256.66.0F3A.W0 46 /r ib || encoded[6]{c4 e3 7d 46 c0 03}
0034h mov rax,2C24E967845h                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 45 78 96 4e c2 02 00 00}
003eh vlddqu ymm3,ymmword ptr [rax]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 18}
0042h vpaddb ymm1,ymm1,ymm3                   ; VPADDB ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG FC /r || encoded[4]{c5 f5 fc cb}
0046h vpshufb ymm0,ymm0,ymm1                  ; VPSHUFB ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 00 /r || encoded[5]{c4 e2 7d 00 c1}
004bh vpor ymm0,ymm2,ymm0                     ; VPOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EB /r || encoded[4]{c5 ed eb c0}
004fh vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0053h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0056h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0059h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<Int16> vblend_128x16u_LLLLLLLL(Vector128<Int16> x, Vector128<Int16> y)
; vblend_128x16u_LLLLLLLL_128x16i[0x7ff7c81c23b0, 0x7ff7c81c23cc][28] = {c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c4 e3 79 0e c1 00 c5 f9 11 01 48 8b c1 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh vpblendw xmm0,xmm0,xmm1,0               ; VPBLENDW xmm1, xmm2, xmm3/m128, imm8 || VEX.128.66.0F3A.WIG 0E /r ib || encoded[6]{c4 e3 79 0e c1 00}
0014h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0018h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
001bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<Int16> vblend_128x16u_RRRRRRRR(Vector128<Int16> x, Vector128<Int16> y)
; vblend_128x16u_RRRRRRRR_128x16i[0x7ff7c81c23e0, 0x7ff7c81c23fc][28] = {c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c4 e3 79 0e c1 ff c5 f9 11 01 48 8b c1 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh vpblendw xmm0,xmm0,xmm1,0FFh            ; VPBLENDW xmm1, xmm2, xmm3/m128, imm8 || VEX.128.66.0F3A.WIG 0E /r ib || encoded[6]{c4 e3 79 0e c1 ff}
0014h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0018h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
001bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<Int16> vblend_128x16u_LLLLRRRR(Vector128<Int16> x, Vector128<Int16> y)
; vblend_128x16u_LLLLRRRR_128x16i[0x7ff7c81c2410, 0x7ff7c81c242c][28] = {c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c4 e3 79 0e c1 f0 c5 f9 11 01 48 8b c1 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh vpblendw xmm0,xmm0,xmm1,0F0h            ; VPBLENDW xmm1, xmm2, xmm3/m128, imm8 || VEX.128.66.0F3A.WIG 0E /r ib || encoded[6]{c4 e3 79 0e c1 f0}
0014h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0018h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
001bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<Int16> vblend_128x16u_RRRRLLLL(Vector128<Int16> x, Vector128<Int16> y)
; vblend_128x16u_RRRRLLLL_128x16i[0x7ff7c81c2440, 0x7ff7c81c245c][28] = {c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c4 e3 79 0e c1 0f c5 f9 11 01 48 8b c1 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh vpblendw xmm0,xmm0,xmm1,0Fh             ; VPBLENDW xmm1, xmm2, xmm3/m128, imm8 || VEX.128.66.0F3A.WIG 0E /r ib || encoded[6]{c4 e3 79 0e c1 0f}
0014h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0018h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
001bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<Int16> vblend_128x16u_LRLRLRLR(Vector128<Int16> x, Vector128<Int16> y)
; vblend_128x16u_LRLRLRLR_128x16i[0x7ff7c81c2470, 0x7ff7c81c248c][28] = {c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c4 e3 79 0e c1 aa c5 f9 11 01 48 8b c1 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh vpblendw xmm0,xmm0,xmm1,0AAh            ; VPBLENDW xmm1, xmm2, xmm3/m128, imm8 || VEX.128.66.0F3A.WIG 0E /r ib || encoded[6]{c4 e3 79 0e c1 aa}
0014h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0018h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
001bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<Int16> vblend_128x16u_RLRLRLRL(Vector128<Int16> x, Vector128<Int16> y)
; vblend_128x16u_RLRLRLRL_128x16i[0x7ff7c81c24a0, 0x7ff7c81c24bc][28] = {c5 f8 77 66 90 c5 f9 10 02 c4 c1 79 10 08 c4 e3 79 0e c1 55 c5 f9 11 01 48 8b c1 c3}
; Capture completion code, None
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh vpblendw xmm0,xmm0,xmm1,55h             ; VPBLENDW xmm1, xmm2, xmm3/m128, imm8 || VEX.128.66.0F3A.WIG 0E /r ib || encoded[6]{c4 e3 79 0e c1 55}
0014h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0018h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
001bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
