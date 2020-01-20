; 2020-01-20 01:59:21:522
; VectorKind:uint vkind_128x32u()
; static ReadOnlySpan<byte> vkind_128x32u_4074007Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x80,0x00,0x10,0x20,0xC3};
; [0x7ff7c85fa260, 0x7ff7c85fa26b], 11 bytes
; 2020-01-20 01:59:21:522
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,20100080h                       ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 80 00 10 20}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; VectorKind:uint vkind_256x32u()
; static ReadOnlySpan<byte> vkind_256x32u_61559149Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x01,0x10,0x20,0xC3};
; [0x7ff7c85fa280, 0x7ff7c85fa28b], 11 bytes
; 2020-01-20 01:59:21:522
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,20100100h                       ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 00 01 10 20}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; BlockKind:uint bkind_256x32u()
; static ReadOnlySpan<byte> bkind_256x32u_17161430Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x01,0x10,0x20,0xC3};
; [0x7ff7c85fa2a0, 0x7ff7c85fa2ab], 11 bytes
; 2020-01-20 01:59:21:522
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,20100100h                       ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 00 01 10 20}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; PrimalKind:uint pkind_8u()
; static ReadOnlySpan<byte> pkind_8u_20235143Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x08,0x00,0x01,0x20,0xC3};
; [0x7ff7c85fa2c0, 0x7ff7c85fa2cb], 11 bytes
; 2020-01-20 01:59:21:522
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,20010008h                       ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 08 00 01 20}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; PrimalKind:uint pkind_32u()
; static ReadOnlySpan<byte> pkind_32u_47898561Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x20,0x00,0x10,0x20,0xC3};
; [0x7ff7c85fa2e0, 0x7ff7c85fa2eb], 11 bytes
; 2020-01-20 01:59:21:522
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,20100020h                       ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 20 00 10 20}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; PrimalKind:uint pkind_32i()
; static ReadOnlySpan<byte> pkind_32i_28433869Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x20,0x00,0x20,0x80,0xC3};
; [0x7ff7c85fa300, 0x7ff7c85fa30b], 11 bytes
; 2020-01-20 01:59:21:522
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,80200020h                       ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 20 00 20 80}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<byte> ones_128x8u()
; static ReadOnlySpan<byte> ones_128x8u_Bytes => new byte[25]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xF0,0x57,0xC9,0xC5,0xF9,0x74,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c85fa320, 0x7ff7c85fa339], 25 bytes
; 2020-01-20 01:59:21:522
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
0009h vxorps xmm1,xmm1,xmm1                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f0 57 c9}
000dh vpcmpeqb xmm0,xmm0,xmm1                 ; VPCMPEQB xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG 74 /r || encoded[4]{c5 f9 74 c1}
0011h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0015h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0018h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<ulong> ones_128x64u()
; static ReadOnlySpan<byte> ones_128x64u_Bytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF8,0x57,0xC0,0xC5,0xF0,0x57,0xC9,0xC4,0xE2,0x79,0x29,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c85fa350, 0x7ff7c85fa36a], 26 bytes
; 2020-01-20 01:59:21:522
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
0009h vxorps xmm1,xmm1,xmm1                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f0 57 c9}
000dh vpcmpeqq xmm0,xmm0,xmm1                 ; VPCMPEQQ xmm1, xmm2, xmm3/m128 || VEX.128.66.0F38.WIG 29 /r || encoded[5]{c4 e2 79 29 c1}
0012h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0016h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0019h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<byte> ones_256x8u()
; static ReadOnlySpan<byte> ones_256x8u_Bytes => new byte[28]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFC,0x57,0xC0,0xC5,0xF4,0x57,0xC9,0xC5,0xFD,0x74,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c85fa380, 0x7ff7c85fa39c], 28 bytes
; 2020-01-20 01:59:21:522
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vxorps ymm0,ymm0,ymm0                   ; VXORPS ymm1, ymm2, ymm3/m256 || VEX.256.0F.WIG 57 /r || encoded[4]{c5 fc 57 c0}
0009h vxorps ymm1,ymm1,ymm1                   ; VXORPS ymm1, ymm2, ymm3/m256 || VEX.256.0F.WIG 57 /r || encoded[4]{c5 f4 57 c9}
000dh vpcmpeqb ymm0,ymm0,ymm1                 ; VPCMPEQB ymm1, ymm2, ymm3/m256 || VEX.256.66.0F.WIG 74 /r || encoded[4]{c5 fd 74 c1}
0011h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0015h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0018h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
001bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<ulong> ones_256x64u()
; static ReadOnlySpan<byte> ones_256x64u_Bytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFC,0x57,0xC0,0xC5,0xF4,0x57,0xC9,0xC4,0xE2,0x7D,0x29,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c85fa3b0, 0x7ff7c85fa3cd], 29 bytes
; 2020-01-20 01:59:21:522
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vxorps ymm0,ymm0,ymm0                   ; VXORPS ymm1, ymm2, ymm3/m256 || VEX.256.0F.WIG 57 /r || encoded[4]{c5 fc 57 c0}
0009h vxorps ymm1,ymm1,ymm1                   ; VXORPS ymm1, ymm2, ymm3/m256 || VEX.256.0F.WIG 57 /r || encoded[4]{c5 f4 57 c9}
000dh vpcmpeqq ymm0,ymm0,ymm1                 ; VPCMPEQQ ymm1, ymm2, ymm3/m256 || VEX.256.66.0F38.WIG 29 /r || encoded[5]{c4 e2 7d 29 c1}
0012h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0016h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0019h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
001ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<double> ones_256x64f()
; static ReadOnlySpan<byte> ones_256x64f_Bytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFC,0x57,0xC0,0xC5,0xF4,0x57,0xC9,0xC5,0xFD,0xC2,0xC1,0x08,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c85fac00, 0x7ff7c85fac1d], 29 bytes
; 2020-01-20 01:59:21:522
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vxorps ymm0,ymm0,ymm0                   ; VXORPS ymm1, ymm2, ymm3/m256 || VEX.256.0F.WIG 57 /r || encoded[4]{c5 fc 57 c0}
0009h vxorps ymm1,ymm1,ymm1                   ; VXORPS ymm1, ymm2, ymm3/m256 || VEX.256.0F.WIG 57 /r || encoded[4]{c5 f4 57 c9}
000dh vcmpeq_uqpd ymm0,ymm0,ymm1              ; VCMPPD ymm1, ymm2, ymm3/m256, imm8 || VEX.256.66.0F.WIG C2 /r ib || encoded[5]{c5 fd c2 c1 08}
0012h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0016h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0019h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
001ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<byte> pattern_lanemerge_256x8u()
; static ReadOnlySpan<byte> pattern_lanemerge_256x8u_Bytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0x48,0xB8,0x55,0x7B,0x1D,0x9C,0x4C,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c85fb040, 0x7ff7c85fb05e], 30 bytes
; 2020-01-20 01:59:21:522
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h mov rax,24C9C1D7B55h                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 55 7b 1d 9c 4c 02 00 00}
000fh vlddqu ymm0,ymmword ptr [rax]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 00}
0013h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0017h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
001ah vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
001dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<ushort> pattern_lanemerge_256x16u()
; static ReadOnlySpan<byte> pattern_lanemerge_256x16u_Bytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0x48,0xB8,0xD5,0x7B,0x1D,0x9C,0x4C,0x02,0x00,0x00,0xC5,0xFF,0xF0,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c85fb070, 0x7ff7c85fb08e], 30 bytes
; 2020-01-20 01:59:21:522
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h mov rax,24C9C1D7BD5h                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 d5 7b 1d 9c 4c 02 00 00}
000fh vlddqu ymm0,ymmword ptr [rax]           ; VLDDQU ymm1, m256 || VEX.256.F2.0F.WIG F0 /r || encoded[4]{c5 ff f0 00}
0013h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0017h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
001ah vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
001dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<byte> makemask_d128x8u(ushort src)
; static ReadOnlySpan<byte> makemask_d128x8u_Bytes => new byte[56]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB7,0xC2,0x0F,0xB6,0xD0,0x49,0xB8,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0xC4,0xC2,0xEB,0xF5,0xD0,0xC4,0xE1,0xF9,0x6E,0xC2,0xC1,0xE8,0x08,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC0,0xC4,0xE3,0xF9,0x22,0xC0,0x01,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c85fb0a0, 0x7ff7c85fb0d8], 56 bytes
; 2020-01-20 01:59:21:522
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h movzx eax,dx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c2}
0008h movzx edx,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d0}
000bh mov r8,8080808080808080h                ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 b8 80 80 80 80 80 80 80 80}
0015h pdep rdx,rdx,r8                         ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 c2 eb f5 d0}
001ah vmovq xmm0,rdx                          ; VMOVQ xmm1, r/m64 || VEX.128.66.0F.W1 6E /r || encoded[5]{c4 e1 f9 6e c2}
001fh shr eax,8                               ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[3]{c1 e8 08}
0022h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0025h pdep rax,rax,r8                         ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 c2 fb f5 c0}
002ah vpinsrq xmm0,xmm0,rax,1                 ; VPINSRQ xmm1, xmm2, r/m64, imm8 || VEX.128.66.0F3A.W1 22 /r ib || encoded[6]{c4 e3 f9 22 c0 01}
0030h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0034h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0037h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<byte> makemask_d256x8u(uint src)
; static ReadOnlySpan<byte> makemask_d256x8u_Bytes => new byte[112]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB7,0xC2,0x44,0x0F,0xB6,0xC0,0x49,0xB9,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0xC4,0x42,0xBB,0xF5,0xC1,0xC4,0xC1,0xF9,0x6E,0xC0,0xC1,0xE8,0x08,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC1,0xC4,0xE3,0xF9,0x22,0xC0,0x01,0xC1,0xEA,0x10,0x0F,0xB7,0xC2,0x0F,0xB6,0xD0,0xC4,0xC2,0xEB,0xF5,0xD1,0xC4,0xE1,0xF9,0x6E,0xCA,0xC1,0xE8,0x08,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC1,0xC4,0xE3,0xF1,0x22,0xC8,0x01,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC4,0xE3,0x7D,0x38,0xC1,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c85fb0f0, 0x7ff7c85fb160], 112 bytes
; 2020-01-20 01:59:21:522
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h movzx eax,dx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c2}
0008h movzx r8d,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{44 0f b6 c0}
000ch mov r9,8080808080808080h                ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 b9 80 80 80 80 80 80 80 80}
0016h pdep r8,r8,r9                           ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 42 bb f5 c1}
001bh vmovq xmm0,r8                           ; VMOVQ xmm1, r/m64 || VEX.128.66.0F.W1 6E /r || encoded[5]{c4 c1 f9 6e c0}
0020h shr eax,8                               ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[3]{c1 e8 08}
0023h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0026h pdep rax,rax,r9                         ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 c2 fb f5 c1}
002bh vpinsrq xmm0,xmm0,rax,1                 ; VPINSRQ xmm1, xmm2, r/m64, imm8 || VEX.128.66.0F3A.W1 22 /r ib || encoded[6]{c4 e3 f9 22 c0 01}
0031h shr edx,10h                             ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[3]{c1 ea 10}
0034h movzx eax,dx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c2}
0037h movzx edx,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d0}
003ah pdep rdx,rdx,r9                         ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 c2 eb f5 d1}
003fh vmovq xmm1,rdx                          ; VMOVQ xmm1, r/m64 || VEX.128.66.0F.W1 6E /r || encoded[5]{c4 e1 f9 6e ca}
0044h shr eax,8                               ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[3]{c1 e8 08}
0047h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
004ah pdep rax,rax,r9                         ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 c2 fb f5 c1}
004fh vpinsrq xmm1,xmm1,rax,1                 ; VPINSRQ xmm1, xmm2, r/m64, imm8 || VEX.128.66.0F3A.W1 22 /r ib || encoded[6]{c4 e3 f1 22 c8 01}
0055h vxorps ymm2,ymm2,ymm2                   ; VXORPS ymm1, ymm2, ymm3/m256 || VEX.256.0F.WIG 57 /r || encoded[4]{c5 ec 57 d2}
0059h vinserti128 ymm0,ymm2,xmm0,0            ; VINSERTI128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 38 /r ib || encoded[6]{c4 e3 6d 38 c0 00}
005fh vinserti128 ymm0,ymm0,xmm1,1            ; VINSERTI128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 38 /r ib || encoded[6]{c4 e3 7d 38 c1 01}
0065h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0069h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
006ch vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
006fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<byte> maskmask_d128x8u_index4(ushort src)
; static ReadOnlySpan<byte> maskmask_d128x8u_index4_Bytes => new byte[56]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB7,0xC2,0x0F,0xB6,0xD0,0x49,0xB8,0x10,0x10,0x10,0x10,0x10,0x10,0x10,0x10,0xC4,0xC2,0xEB,0xF5,0xD0,0xC4,0xE1,0xF9,0x6E,0xC2,0xC1,0xE8,0x08,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC0,0xC4,0xE3,0xF9,0x22,0xC0,0x01,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c85fb180, 0x7ff7c85fb1b8], 56 bytes
; 2020-01-20 01:59:21:522
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h movzx eax,dx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c2}
0008h movzx edx,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d0}
000bh mov r8,1010101010101010h                ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 b8 10 10 10 10 10 10 10 10}
0015h pdep rdx,rdx,r8                         ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 c2 eb f5 d0}
001ah vmovq xmm0,rdx                          ; VMOVQ xmm1, r/m64 || VEX.128.66.0F.W1 6E /r || encoded[5]{c4 e1 f9 6e c2}
001fh shr eax,8                               ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[3]{c1 e8 08}
0022h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0025h pdep rax,rax,r8                         ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 c2 fb f5 c0}
002ah vpinsrq xmm0,xmm0,rax,1                 ; VPINSRQ xmm1, xmm2, r/m64, imm8 || VEX.128.66.0F3A.W1 22 /r ib || encoded[6]{c4 e3 f9 22 c0 01}
0030h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0034h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0037h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<byte> maskmask_d256x8u_index3(uint src)
; static ReadOnlySpan<byte> maskmask_d256x8u_index3_Bytes => new byte[109]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB6,0xC2,0x49,0xB8,0x08,0x08,0x08,0x08,0x08,0x08,0x08,0x08,0xC4,0xC2,0xFB,0xF5,0xC0,0xC4,0xE1,0xF9,0x6E,0xC0,0x8B,0xC2,0xC1,0xE8,0x08,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC0,0xC4,0xE3,0xF9,0x22,0xC0,0x01,0x8B,0xC2,0xC1,0xE8,0x10,0x0F,0xB6,0xC0,0xC4,0xC2,0xFB,0xF5,0xC0,0xC4,0xE1,0xF9,0x6E,0xC8,0xC1,0xEA,0x18,0x0F,0xB6,0xC2,0xC4,0xC2,0xFB,0xF5,0xC0,0xC4,0xE3,0xF1,0x22,0xC8,0x01,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC4,0xE3,0x7D,0x38,0xC1,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c85fb1d0, 0x7ff7c85fb23d], 109 bytes
; 2020-01-20 01:59:21:522
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h movzx eax,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c2}
0008h mov r8,808080808080808h                 ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 b8 08 08 08 08 08 08 08 08}
0012h pdep rax,rax,r8                         ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 c2 fb f5 c0}
0017h vmovq xmm0,rax                          ; VMOVQ xmm1, r/m64 || VEX.128.66.0F.W1 6E /r || encoded[5]{c4 e1 f9 6e c0}
001ch mov eax,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c2}
001eh shr eax,8                               ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[3]{c1 e8 08}
0021h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0024h pdep rax,rax,r8                         ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 c2 fb f5 c0}
0029h vpinsrq xmm0,xmm0,rax,1                 ; VPINSRQ xmm1, xmm2, r/m64, imm8 || VEX.128.66.0F3A.W1 22 /r ib || encoded[6]{c4 e3 f9 22 c0 01}
002fh mov eax,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c2}
0031h shr eax,10h                             ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[3]{c1 e8 10}
0034h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0037h pdep rax,rax,r8                         ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 c2 fb f5 c0}
003ch vmovq xmm1,rax                          ; VMOVQ xmm1, r/m64 || VEX.128.66.0F.W1 6E /r || encoded[5]{c4 e1 f9 6e c8}
0041h shr edx,18h                             ; SHR r/m32, imm8 || o32 C1 /5 ib || encoded[3]{c1 ea 18}
0044h movzx eax,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c2}
0047h pdep rax,rax,r8                         ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 c2 fb f5 c0}
004ch vpinsrq xmm1,xmm1,rax,1                 ; VPINSRQ xmm1, xmm2, r/m64, imm8 || VEX.128.66.0F3A.W1 22 /r ib || encoded[6]{c4 e3 f1 22 c8 01}
0052h vxorps ymm2,ymm2,ymm2                   ; VXORPS ymm1, ymm2, ymm3/m256 || VEX.256.0F.WIG 57 /r || encoded[4]{c5 ec 57 d2}
0056h vinserti128 ymm0,ymm2,xmm0,0            ; VINSERTI128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 38 /r ib || encoded[6]{c4 e3 6d 38 c0 00}
005ch vinserti128 ymm0,ymm0,xmm1,1            ; VINSERTI128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 38 /r ib || encoded[6]{c4 e3 7d 38 c1 01}
0062h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0066h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0069h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
006ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<byte> makemask_d128x8u_FCFC()
; static ReadOnlySpan<byte> makemask_d128x8u_FCFC_Bytes => new byte[54]{0xC5,0xF8,0x77,0x66,0x90,0xB8,0xFC,0x00,0x00,0x00,0x48,0xBA,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0xC4,0xE2,0xFB,0xF5,0xC2,0xC4,0xE1,0xF9,0x6E,0xC0,0xB8,0xFC,0x00,0x00,0x00,0xC4,0xE2,0xFB,0xF5,0xC2,0xC4,0xE3,0xF9,0x22,0xC0,0x01,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c85fb250, 0x7ff7c85fb286], 54 bytes
; 2020-01-20 01:59:21:522
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h mov eax,0FCh                            ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 fc 00 00 00}
000ah mov rdx,8080808080808080h               ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 ba 80 80 80 80 80 80 80 80}
0014h pdep rax,rax,rdx                        ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 e2 fb f5 c2}
0019h vmovq xmm0,rax                          ; VMOVQ xmm1, r/m64 || VEX.128.66.0F.W1 6E /r || encoded[5]{c4 e1 f9 6e c0}
001eh mov eax,0FCh                            ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 fc 00 00 00}
0023h pdep rax,rax,rdx                        ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 e2 fb f5 c2}
0028h vpinsrq xmm0,xmm0,rax,1                 ; VPINSRQ xmm1, xmm2, r/m64, imm8 || VEX.128.66.0F3A.W1 22 /r ib || encoded[6]{c4 e3 f9 22 c0 01}
002eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0032h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0035h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<byte> makemask_d256x8u_FAFAFAFA()
; static ReadOnlySpan<byte> makemask_d256x8u_FAFAFAFA_Bytes => new byte[104]{0xC5,0xF8,0x77,0x66,0x90,0xB8,0xFA,0x00,0x00,0x00,0x48,0xBA,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0x80,0xC4,0xE2,0xFB,0xF5,0xC2,0xC4,0xE1,0xF9,0x6E,0xC0,0xB8,0xFA,0x00,0x00,0x00,0xC4,0xE2,0xFB,0xF5,0xC2,0xC4,0xE3,0xF9,0x22,0xC0,0x01,0xB8,0xFA,0x00,0x00,0x00,0xC4,0xE2,0xFB,0xF5,0xC2,0xC4,0xE1,0xF9,0x6E,0xC8,0xB8,0xFA,0x00,0x00,0x00,0xC4,0xE2,0xFB,0xF5,0xC2,0xC4,0xE3,0xF1,0x22,0xC8,0x01,0xC5,0xEC,0x57,0xD2,0xC4,0xE3,0x6D,0x38,0xC0,0x00,0xC4,0xE3,0x7D,0x38,0xC1,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c85fb2a0, 0x7ff7c85fb308], 104 bytes
; 2020-01-20 01:59:21:522
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h mov eax,0FAh                            ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 fa 00 00 00}
000ah mov rdx,8080808080808080h               ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 ba 80 80 80 80 80 80 80 80}
0014h pdep rax,rax,rdx                        ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 e2 fb f5 c2}
0019h vmovq xmm0,rax                          ; VMOVQ xmm1, r/m64 || VEX.128.66.0F.W1 6E /r || encoded[5]{c4 e1 f9 6e c0}
001eh mov eax,0FAh                            ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 fa 00 00 00}
0023h pdep rax,rax,rdx                        ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 e2 fb f5 c2}
0028h vpinsrq xmm0,xmm0,rax,1                 ; VPINSRQ xmm1, xmm2, r/m64, imm8 || VEX.128.66.0F3A.W1 22 /r ib || encoded[6]{c4 e3 f9 22 c0 01}
002eh mov eax,0FAh                            ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 fa 00 00 00}
0033h pdep rax,rax,rdx                        ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 e2 fb f5 c2}
0038h vmovq xmm1,rax                          ; VMOVQ xmm1, r/m64 || VEX.128.66.0F.W1 6E /r || encoded[5]{c4 e1 f9 6e c8}
003dh mov eax,0FAh                            ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 fa 00 00 00}
0042h pdep rax,rax,rdx                        ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 e2 fb f5 c2}
0047h vpinsrq xmm1,xmm1,rax,1                 ; VPINSRQ xmm1, xmm2, r/m64, imm8 || VEX.128.66.0F3A.W1 22 /r ib || encoded[6]{c4 e3 f1 22 c8 01}
004dh vxorps ymm2,ymm2,ymm2                   ; VXORPS ymm1, ymm2, ymm3/m256 || VEX.256.0F.WIG 57 /r || encoded[4]{c5 ec 57 d2}
0051h vinserti128 ymm0,ymm2,xmm0,0            ; VINSERTI128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 38 /r ib || encoded[6]{c4 e3 6d 38 c0 00}
0057h vinserti128 ymm0,ymm0,xmm1,1            ; VINSERTI128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 38 /r ib || encoded[6]{c4 e3 7d 38 c1 01}
005dh vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0061h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0064h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0067h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
