; 2020-01-20 01:59:21:552
; Func<Vector256<uint>,Vector256<uint>,Vector256<uint>> vand_delgate()
; static ReadOnlySpan<byte> vand_delgate_17016957Bytes => new byte[235]{0x57,0x56,0x53,0x48,0x83,0xEC,0x60,0xC5,0xF8,0x77,0x48,0xB9,0x98,0x27,0xF0,0xC7,0xF7,0x7F,0x00,0x00,0xE8,0xD7,0x3A,0x34,0x5F,0x48,0x8B,0xF0,0x48,0xB9,0x88,0x77,0xEF,0xC7,0xF7,0x7F,0x00,0x00,0xBA,0x02,0x00,0x00,0x00,0xE8,0x10,0xB9,0x39,0x5F,0x48,0x8B,0xF8,0x48,0xB9,0x20,0x65,0x51,0xC8,0xF7,0x7F,0x00,0x00,0xE8,0xAE,0x3A,0x34,0x5F,0x48,0x8B,0xD8,0x4C,0x8B,0xC3,0x48,0x8B,0xCF,0x33,0xD2,0xE8,0xBE,0xA9,0x39,0x5F,0x4C,0x8B,0xC3,0x48,0x8B,0xCF,0xBA,0x01,0x00,0x00,0x00,0xE8,0xAE,0xA9,0x39,0x5F,0xC7,0x44,0x24,0x20,0x03,0x00,0x00,0x00,0x48,0x89,0x7C,0x24,0x28,0x33,0xD2,0x48,0x89,0x54,0x24,0x30,0x48,0xBA,0x28,0x61,0x9D,0x93,0x4C,0x02,0x00,0x00,0x48,0x8B,0x12,0x48,0x8B,0xCE,0x41,0xB8,0x1C,0x00,0x00,0x00,0x45,0x33,0xC9,0xE8,0x1C,0x19,0x7B,0x5D,0x48,0x8B,0xC8,0xC5,0xFC,0x57,0xC0,0xC5,0xFD,0x11,0x44,0x24,0x40,0x48,0x8D,0x54,0x24,0x40,0xE8,0x95,0xF7,0xFF,0xFF,0x48,0x8B,0xF0,0x48,0xB9,0x60,0x28,0x6D,0xC8,0xF7,0x7F,0x00,0x00,0xE8,0x33,0x3A,0x34,0x5F,0x48,0x8B,0xD0,0x48,0x8B,0xCE,0x48,0x8B,0x06,0x48,0x8B,0x40,0x68,0xFF,0x50,0x10,0x48,0x8B,0xD0,0x48,0xB9,0x60,0x28,0x6D,0xC8,0xF7,0x7F,0x00,0x00,0xE8,0x21,0x39,0x2E,0x5F,0x90,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x60,0x5B,0x5E,0x5F,0xC3};
; [0x7ff7c85fb500, 0x7ff7c85fb5eb], 235 bytes
; 2020-01-20 01:59:21:552
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h sub rsp,60h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 60}
0007h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
000ah mov rcx,7FF7C7F02798h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 98 27 f0 c7 f7 7f 00 00}
0014h call 7FF82793EFF0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 d7 3a 34 5f}
0019h mov rsi,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f0}
001ch mov rcx,7FF7C7EF7788h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 88 77 ef c7 f7 7f 00 00}
0026h mov edx,2                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 02 00 00 00}
002bh call 7FF827996E40h                      ; CALL rel32 || E8 cd || encoded[5]{e8 10 b9 39 5f}
0030h mov rdi,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f8}
0033h mov rcx,7FF7C8516520h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 20 65 51 c8 f7 7f 00 00}
003dh call 7FF82793EFF0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 ae 3a 34 5f}
0042h mov rbx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d8}
0045h mov r8,rbx                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b c3}
0048h mov rcx,rdi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b cf}
004bh xor edx,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d2}
004dh call 7FF827995F10h                      ; CALL rel32 || E8 cd || encoded[5]{e8 be a9 39 5f}
0052h mov r8,rbx                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b c3}
0055h mov rcx,rdi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b cf}
0058h mov edx,1                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 01 00 00 00}
005dh call 7FF827995F10h                      ; CALL rel32 || E8 cd || encoded[5]{e8 ae a9 39 5f}
0062h mov dword ptr [rsp+20h],3               ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[8]{c7 44 24 20 03 00 00 00}
006ah mov [rsp+28h],rdi                       ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 7c 24 28}
006fh xor edx,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d2}
0071h mov [rsp+30h],rdx                       ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 54 24 30}
0076h mov rdx,24C939D6128h                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 ba 28 61 9d 93 4c 02 00 00}
0080h mov rdx,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 12}
0083h mov rcx,rsi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b ce}
0086h mov r8d,1Ch                             ; MOV r32, imm32 || o32 B8+rd id || encoded[6]{41 b8 1c 00 00 00}
008ch xor r9d,r9d                             ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 c9}
008fh call 7FF825DACEB0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 1c 19 7b 5d}
0094h mov rcx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c8}
0097h vxorps ymm0,ymm0,ymm0                   ; VXORPS ymm1, ymm2, ymm3/m256 || VEX.256.0F.WIG 57 /r || encoded[4]{c5 fc 57 c0}
009bh vmovupd [rsp+40h],ymm0                  ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[6]{c5 fd 11 44 24 40}
00a1h lea rdx,[rsp+40h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 54 24 40}
00a6h call 7FF7C85FAD40h                      ; CALL rel32 || E8 cd || encoded[5]{e8 95 f7 ff ff}
00abh mov rsi,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f0}
00aeh mov rcx,7FF7C86D2860h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 60 28 6d c8 f7 7f 00 00}
00b8h call 7FF82793EFF0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 33 3a 34 5f}
00bdh mov rdx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d0}
00c0h mov rcx,rsi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b ce}
00c3h mov rax,[rsi]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 06}
00c6h mov rax,[rax+68h]                       ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 40 68}
00cah call qword ptr [rax+10h]                ; CALL r/m64 || FF /2 || encoded[3]{ff 50 10}
00cdh mov rdx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d0}
00d0h mov rcx,7FF7C86D2860h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 60 28 6d c8 f7 7f 00 00}
00dah call 7FF8278DEF00h                      ; CALL rel32 || E8 cd || encoded[5]{e8 21 39 2e 5f}
00dfh nop                                     ; NOP || o32 90 || encoded[1]{90}
00e0h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
00e3h add rsp,60h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 60}
00e7h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
00e8h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
00e9h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
00eah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<uint> vand_dynamic(Vector256<uint> a, Vector256<uint> b)
; static ReadOnlySpan<byte> vand_dynamic_256x32uBytes => new byte[48]{0x57,0x56,0x53,0x48,0x83,0xEC,0x20,0x48,0x8B,0xD9,0x48,0x8B,0xF2,0x49,0x8B,0xF8,0xE8,0xDB,0xFE,0xFF,0xFF,0x48,0x8B,0x48,0x08,0x48,0x8B,0xD3,0x4C,0x8B,0xC6,0x4C,0x8B,0xCF,0xFF,0x50,0x18,0x48,0x8B,0xC3,0x48,0x83,0xC4,0x20,0x5B,0x5E,0x5F,0xC3};
; [0x7ff7c85fb610, 0x7ff7c85fb640], 48 bytes
; 2020-01-20 01:59:21:552
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h sub rsp,20h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 20}
0007h mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
000ah mov rsi,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f2}
000dh mov rdi,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b f8}
0010h call 7FF7C85FB500h                      ; CALL rel32 || E8 cd || encoded[5]{e8 db fe ff ff}
0015h mov rcx,[rax+8]                         ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{48 8b 48 08}
0019h mov rdx,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d3}
001ch mov r8,rsi                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b c6}
001fh mov r9,rdi                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b cf}
0022h call qword ptr [rax+18h]                ; CALL r/m64 || FF /2 || encoded[3]{ff 50 18}
0025h mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
0028h add rsp,20h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 20}
002ch pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
002dh pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
002eh pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
002fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector512<ulong> vperm2x128(Vector512<ulong> src)
; static ReadOnlySpan<byte> vperm2x128_512x64uBytes => new byte[50]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC5,0xFD,0x10,0x4A,0x20,0xC5,0xFC,0x28,0xD0,0xC5,0xFC,0x28,0xD9,0xC4,0xE3,0x6D,0x46,0xD3,0x30,0xC4,0xE3,0x7D,0x46,0xC1,0x21,0xC5,0xFD,0x11,0x11,0xC5,0xFD,0x11,0x41,0x20,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c85fba60, 0x7ff7c85fba92], 50 bytes
; 2020-01-20 01:59:21:552
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h vmovupd ymm1,[rdx+20h]                  ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c5 fd 10 4a 20}
000eh vmovaps ymm2,ymm0                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 d0}
0012h vmovaps ymm3,ymm1                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 d9}
0016h vperm2i128 ymm2,ymm2,ymm3,30h           ; VPERM2I128 ymm1, ymm2, ymm3/m256, imm8 || VEX.256.66.0F3A.W0 46 /r ib || encoded[6]{c4 e3 6d 46 d3 30}
001ch vperm2i128 ymm0,ymm0,ymm1,21h           ; VPERM2I128 ymm1, ymm2, ymm3/m256, imm8 || VEX.256.66.0F3A.W0 46 /r ib || encoded[6]{c4 e3 7d 46 c1 21}
0022h vmovupd [rcx],ymm2                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 11}
0026h vmovupd [rcx+20h],ymm0                  ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[5]{c5 fd 11 41 20}
002bh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
002eh vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0031h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<ushort> vbswap_128x16u(Vector128<ushort> x)
; static ReadOnlySpan<byte> vbswap_128x16u_128x16uBytes => new byte[36]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0x48,0xB8,0x85,0x52,0x27,0x82,0x4C,0x02,0x00,0x00,0xC5,0xFB,0xF0,0x08,0xC4,0xE2,0x79,0x00,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c85fbab0, 0x7ff7c85fbad4], 36 bytes
; 2020-01-20 01:59:21:552
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h mov rax,24C82275285h                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 85 52 27 82 4c 02 00 00}
0013h vlddqu xmm1,xmmword ptr [rax]           ; VLDDQU xmm1, m128 || VEX.128.F2.0F.WIG F0 /r || encoded[4]{c5 fb f0 08}
0017h vpshufb xmm0,xmm0,xmm1                  ; VPSHUFB xmm1, xmm2, xmm3/m128 || VEX.128.66.0F38.WIG 00 /r || encoded[5]{c4 e2 79 00 c1}
001ch vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0020h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0023h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<int> vpermvar8x32_256x32i(Vector256<int> src, Vector256<uint> spec)
; static ReadOnlySpan<byte> vpermvar8x32_256x32i_256x32i_256x32uBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x75,0x36,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c85fbaf0, 0x7ff7c85fbb0e], 30 bytes
; 2020-01-20 01:59:21:552
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h vmovupd ymm1,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 08}
000eh vpermd ymm0,ymm1,ymm0                   ; VPERMD ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.W0 36 /r || encoded[5]{c4 e2 75 36 c0}
0013h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0017h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
001ah vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
001dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<uint> vpermvar8x32_256x32u(Vector256<uint> src, Vector256<uint> spec)
; static ReadOnlySpan<byte> vpermvar8x32_256x32u_256x32uBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x75,0x36,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c85fbb20, 0x7ff7c85fbb3e], 30 bytes
; 2020-01-20 01:59:21:552
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h vmovupd ymm1,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 08}
000eh vpermd ymm0,ymm1,ymm0                   ; VPERMD ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.W0 36 /r || encoded[5]{c4 e2 75 36 c0}
0013h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0017h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
001ah vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
001dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<byte> vpermvar32x8_256x8u(Vector256<byte> a, Vector256<byte> spec)
; static ReadOnlySpan<byte> vpermvar32x8_256x8u_256x8uBytes => new byte[81]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0x48,0xB8,0x35,0x7C,0x1D,0x9C,0x4C,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x10,0xC5,0xF5,0xFC,0xD2,0xC4,0xE2,0x7D,0x00,0xD2,0xC4,0xE3,0x7D,0x46,0xC0,0x03,0x48,0xB8,0x65,0x7A,0x1D,0x9C,0x4C,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x18,0xC5,0xF5,0xFC,0xCB,0xC4,0xE2,0x7D,0x00,0xC1,0xC5,0xED,0xEB,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c85fbb50, 0x7ff7c85fbba1], 81 bytes
; 2020-01-20 01:59:21:552
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h vmovupd ymm1,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 08}
000eh mov rax,24C9C1D7C35h                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 35 7c 1d 9c 4c 02 00 00}
0018h vlddqu ymm2,ymmword ptr [rax]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 10}
001ch vpaddb ymm2,ymm1,ymm2                   ; VPADDB ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG FC /r || encoded[4]{c5 f5 fc d2}
0020h vpshufb ymm2,ymm0,ymm2                  ; VPSHUFB ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 00 /r || encoded[5]{c4 e2 7d 00 d2}
0025h vperm2i128 ymm0,ymm0,ymm0,3             ; VPERM2I128 ymm1, ymm2, ymm3/m256, imm8 || VEX.256.66.0F3A.W0 46 /r ib || encoded[6]{c4 e3 7d 46 c0 03}
002bh mov rax,24C9C1D7A65h                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 65 7a 1d 9c 4c 02 00 00}
0035h vlddqu ymm3,ymmword ptr [rax]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 18}
0039h vpaddb ymm1,ymm1,ymm3                   ; VPADDB ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG FC /r || encoded[4]{c5 f5 fc cb}
003dh vpshufb ymm0,ymm0,ymm1                  ; VPSHUFB ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 00 /r || encoded[5]{c4 e2 7d 00 c1}
0042h vpor ymm0,ymm2,ymm0                     ; VPOR ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG EB /r || encoded[4]{c5 ed eb c0}
0046h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
004ah mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
004dh vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0050h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<byte> vshuffle_128x8u(Vector128<byte> src, Vector128<byte> spec)
; static ReadOnlySpan<byte> vshuffle_128x8u_128x8uBytes => new byte[27]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE2,0x79,0x00,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c85fbbc0, 0x7ff7c85fbbdb], 27 bytes
; 2020-01-20 01:59:21:553
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh vpshufb xmm0,xmm0,xmm1                  ; VPSHUFB xmm1, xmm2, xmm3/m128 || VEX.128.66.0F38.WIG 00 /r || encoded[5]{c4 e2 79 00 c1}
0013h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0017h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
001ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<sbyte> vshuffle_128x8i(Vector128<sbyte> src, Vector128<sbyte> spec)
; static ReadOnlySpan<byte> vshuffle_128x8i_128x8iBytes => new byte[27]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC4,0xE2,0x79,0x00,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c85fbbf0, 0x7ff7c85fbc0b], 27 bytes
; 2020-01-20 01:59:21:553
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh vpshufb xmm0,xmm0,xmm1                  ; VPSHUFB xmm1, xmm2, xmm3/m128 || VEX.128.66.0F38.WIG 00 /r || encoded[5]{c4 e2 79 00 c1}
0013h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0017h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
001ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<byte> vshuffle_256x8u(Vector256<byte> src, Vector256<byte> spec)
; static ReadOnlySpan<byte> vshuffle_256x8u_256x8uBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x7D,0x00,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c85fbc20, 0x7ff7c85fbc3e], 30 bytes
; 2020-01-20 01:59:21:553
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h vmovupd ymm1,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 08}
000eh vpshufb ymm0,ymm0,ymm1                  ; VPSHUFB ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 00 /r || encoded[5]{c4 e2 7d 00 c1}
0013h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0017h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
001ah vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
001dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<sbyte> vshuffle_256x8i(Vector256<sbyte> src, Vector256<sbyte> spec)
; static ReadOnlySpan<byte> vshuffle_256x8i_256x8iBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x7D,0x00,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c85fbc50, 0x7ff7c85fbc6e], 30 bytes
; 2020-01-20 01:59:21:553
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[rdx]                      ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[4]{c5 fd 10 02}
0009h vmovupd ymm1,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 08}
000eh vpshufb ymm0,ymm0,ymm1                  ; VPSHUFB ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 00 /r || encoded[5]{c4 e2 7d 00 c1}
0013h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0017h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
001ah vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
001dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void vtranspose(ref Vector128<uint> row0, ref Vector128<uint> row1, ref Vector128<uint> row2, ref Vector128<uint> row3)
; static ReadOnlySpan<byte> vtranspose_128x0x_128x0x_128x0x_128x0xBytes => new byte[98]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF8,0x28,0xC8,0xC5,0xF9,0x10,0x12,0xC5,0xF8,0x28,0xDA,0xC5,0xF0,0xC6,0xCB,0x44,0xC5,0xF8,0xC6,0xC2,0xEE,0xC4,0xC1,0x79,0x10,0x10,0xC5,0xF8,0x28,0xDA,0xC4,0xC1,0x79,0x10,0x21,0xC5,0xF8,0x28,0xEC,0xC5,0xE0,0xC6,0xDD,0x44,0xC5,0xE8,0xC6,0xD4,0xEE,0xC5,0xF0,0xC6,0xE3,0x88,0xC5,0xF9,0x11,0x21,0xC5,0xF0,0xC6,0xCB,0xDD,0xC5,0xF9,0x11,0x0A,0xC5,0xF8,0xC6,0xCA,0x88,0xC4,0xC1,0x79,0x11,0x08,0xC5,0xF8,0xC6,0xC2,0xDD,0xC4,0xC1,0x79,0x11,0x01,0xC3};
; [0x7ff7c85fbc80, 0x7ff7c85fbce2], 98 bytes
; 2020-01-20 01:59:21:553
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 01}
0009h vmovaps xmm1,xmm0                       ; VMOVAPS xmm1, xmm2/m128 || VEX.128.0F.WIG 28 /r || encoded[4]{c5 f8 28 c8}
000dh vmovupd xmm2,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 12}
0011h vmovaps xmm3,xmm2                       ; VMOVAPS xmm1, xmm2/m128 || VEX.128.0F.WIG 28 /r || encoded[4]{c5 f8 28 da}
0015h vshufps xmm1,xmm1,xmm3,44h              ; VSHUFPS xmm1, xmm2, xmm3/m128, imm8 || VEX.128.0F.WIG C6 /r ib || encoded[5]{c5 f0 c6 cb 44}
001ah vshufps xmm0,xmm0,xmm2,0EEh             ; VSHUFPS xmm1, xmm2, xmm3/m128, imm8 || VEX.128.0F.WIG C6 /r ib || encoded[5]{c5 f8 c6 c2 ee}
001fh vmovupd xmm2,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 10}
0024h vmovaps xmm3,xmm2                       ; VMOVAPS xmm1, xmm2/m128 || VEX.128.0F.WIG 28 /r || encoded[4]{c5 f8 28 da}
0028h vmovupd xmm4,[r9]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 21}
002dh vmovaps xmm5,xmm4                       ; VMOVAPS xmm1, xmm2/m128 || VEX.128.0F.WIG 28 /r || encoded[4]{c5 f8 28 ec}
0031h vshufps xmm3,xmm3,xmm5,44h              ; VSHUFPS xmm1, xmm2, xmm3/m128, imm8 || VEX.128.0F.WIG C6 /r ib || encoded[5]{c5 e0 c6 dd 44}
0036h vshufps xmm2,xmm2,xmm4,0EEh             ; VSHUFPS xmm1, xmm2, xmm3/m128, imm8 || VEX.128.0F.WIG C6 /r ib || encoded[5]{c5 e8 c6 d4 ee}
003bh vshufps xmm4,xmm1,xmm3,88h              ; VSHUFPS xmm1, xmm2, xmm3/m128, imm8 || VEX.128.0F.WIG C6 /r ib || encoded[5]{c5 f0 c6 e3 88}
0040h vmovupd [rcx],xmm4                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 21}
0044h vshufps xmm1,xmm1,xmm3,0DDh             ; VSHUFPS xmm1, xmm2, xmm3/m128, imm8 || VEX.128.0F.WIG C6 /r ib || encoded[5]{c5 f0 c6 cb dd}
0049h vmovupd [rdx],xmm1                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 0a}
004dh vshufps xmm1,xmm0,xmm2,88h              ; VSHUFPS xmm1, xmm2, xmm3/m128, imm8 || VEX.128.0F.WIG C6 /r ib || encoded[5]{c5 f8 c6 ca 88}
0052h vmovupd [r8],xmm1                       ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[5]{c4 c1 79 11 08}
0057h vshufps xmm0,xmm0,xmm2,0DDh             ; VSHUFPS xmm1, xmm2, xmm3/m128, imm8 || VEX.128.0F.WIG C6 /r ib || encoded[5]{c5 f8 c6 c2 dd}
005ch vmovupd [r9],xmm0                       ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[5]{c4 c1 79 11 01}
0061h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
