; 2020-01-20 01:59:21:489
; Vector128<byte> vmov_idx3_128x8u(byte src, Vector128<byte> dst)
; static ReadOnlySpan<byte> vmov_idx3_128x8u__128x8uBytes => new byte[27]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x79,0x10,0x00,0x0F,0xB6,0xC2,0xC4,0xE3,0x79,0x20,0xC0,0x03,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c85f96f0, 0x7ff7c85f970b], 27 bytes
; 2020-01-20 01:59:21:490
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 00}
000ah movzx eax,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c2}
000dh vpinsrb xmm0,xmm0,eax,3                 ; VPINSRB xmm1, xmm2, r32/m8, imm8 || VEX.128.66.0F3A.W0 20 /r ib || encoded[6]{c4 e3 79 20 c0 03}
0013h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0017h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
001ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<ushort> vmov_idx4_128x16u(ushort src, Vector128<ushort> dst)
; static ReadOnlySpan<byte> vmov_idx4_128x16u__128x16uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x79,0x10,0x00,0x0F,0xB7,0xC2,0xC5,0xF9,0xC4,0xC0,0x04,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c85f9720, 0x7ff7c85f973a], 26 bytes
; 2020-01-20 01:59:21:490
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 00}
000ah movzx eax,dx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c2}
000dh vpinsrw xmm0,xmm0,eax,4                 ; VPINSRW xmm1, xmm2, r32/m16, imm8 || VEX.128.66.0F.W0 C4 /r ib || encoded[5]{c5 f9 c4 c0 04}
0012h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0016h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0019h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vmov_idx2_128x32u(uint src, Vector128<uint> dst)
; static ReadOnlySpan<byte> vmov_idx2_128x32u__128x32uBytes => new byte[24]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x79,0x10,0x00,0xC4,0xE3,0x79,0x22,0xC2,0x02,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c85f9750, 0x7ff7c85f9768], 24 bytes
; 2020-01-20 01:59:21:490
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 00}
000ah vpinsrd xmm0,xmm0,edx,2                 ; VPINSRD xmm1, xmm2, r/m32, imm8 || VEX.128.66.0F3A.W0 22 /r ib || encoded[6]{c4 e3 79 22 c2 02}
0010h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0014h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0017h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<byte> vmov_idx3_256x8u(byte src, Vector256<byte> dst)
; static ReadOnlySpan<byte> vmov_idx3_256x8u__256x8uBytes => new byte[40]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xFC,0x28,0xC8,0x0F,0xB6,0xC2,0xC4,0xE3,0x71,0x20,0xC8,0x03,0xC4,0xE3,0x7D,0x18,0xC1,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c85f9780, 0x7ff7c85f97a8], 40 bytes
; 2020-01-20 01:59:21:490
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 00}
000ah vmovaps ymm1,ymm0                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 c8}
000eh movzx eax,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c2}
0011h vpinsrb xmm1,xmm1,eax,3                 ; VPINSRB xmm1, xmm2, r32/m8, imm8 || VEX.128.66.0F3A.W0 20 /r ib || encoded[6]{c4 e3 71 20 c8 03}
0017h vinsertf128 ymm0,ymm0,xmm1,0            ; VINSERTF128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 18 /r ib || encoded[6]{c4 e3 7d 18 c1 00}
001dh vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0021h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0024h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0027h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<ushort> vmov_idx4_256x16u(ushort src, Vector256<ushort> dst)
; static ReadOnlySpan<byte> vmov_idx4_256x16u__256x16uBytes => new byte[39]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xFC,0x28,0xC8,0x0F,0xB7,0xC2,0xC5,0xF1,0xC4,0xC8,0x04,0xC4,0xE3,0x7D,0x18,0xC1,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c85f97c0, 0x7ff7c85f97e7], 39 bytes
; 2020-01-20 01:59:21:490
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 00}
000ah vmovaps ymm1,ymm0                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 c8}
000eh movzx eax,dx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c2}
0011h vpinsrw xmm1,xmm1,eax,4                 ; VPINSRW xmm1, xmm2, r32/m16, imm8 || VEX.128.66.0F.W0 C4 /r ib || encoded[5]{c5 f1 c4 c8 04}
0016h vinsertf128 ymm0,ymm0,xmm1,0            ; VINSERTF128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 18 /r ib || encoded[6]{c4 e3 7d 18 c1 00}
001ch vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0020h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0023h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0026h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<uint> vmov_idx2_256x32u(uint src, Vector256<uint> dst)
; static ReadOnlySpan<byte> vmov_idx2_256x32u__256x32uBytes => new byte[37]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x00,0xC5,0xFC,0x28,0xC8,0xC4,0xE3,0x71,0x22,0xCA,0x02,0xC4,0xE3,0x7D,0x18,0xC1,0x00,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c85f9800, 0x7ff7c85f9825], 37 bytes
; 2020-01-20 01:59:21:490
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[r8]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 00}
000ah vmovaps ymm1,ymm0                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 c8}
000eh vpinsrd xmm1,xmm1,edx,2                 ; VPINSRD xmm1, xmm2, r/m32, imm8 || VEX.128.66.0F3A.W0 22 /r ib || encoded[6]{c4 e3 71 22 ca 02}
0014h vinsertf128 ymm0,ymm0,xmm1,0            ; VINSERTF128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 18 /r ib || encoded[6]{c4 e3 7d 18 c1 00}
001ah vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
001eh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0021h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0024h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<uint> vmov_idx4x2_256x32u(uint a, uint b, Vector256<uint> dst)
; static ReadOnlySpan<byte> vmov_idx4x2_256x32u___256x32uBytes => new byte[55]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x01,0xC5,0xFC,0x28,0xC8,0xC4,0xE3,0x71,0x22,0xCA,0x02,0xC4,0xE3,0x7D,0x18,0xC1,0x00,0xC4,0xE3,0x7D,0x19,0xC1,0x01,0xC4,0xC3,0x71,0x22,0xC8,0x00,0xC4,0xE3,0x7D,0x18,0xC1,0x01,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c85f9840, 0x7ff7c85f9877], 55 bytes
; 2020-01-20 01:59:21:490
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd ymm0,[r9]                       ; VMOVUPD ymm1, ymm2/m256 || VEX.256.66.0F.WIG 10 /r || encoded[5]{c4 c1 7d 10 01}
000ah vmovaps ymm1,ymm0                       ; VMOVAPS ymm1, ymm2/m256 || VEX.256.0F.WIG 28 /r || encoded[4]{c5 fc 28 c8}
000eh vpinsrd xmm1,xmm1,edx,2                 ; VPINSRD xmm1, xmm2, r/m32, imm8 || VEX.128.66.0F3A.W0 22 /r ib || encoded[6]{c4 e3 71 22 ca 02}
0014h vinsertf128 ymm0,ymm0,xmm1,0            ; VINSERTF128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 18 /r ib || encoded[6]{c4 e3 7d 18 c1 00}
001ah vextractf128 xmm1,ymm0,1                ; VEXTRACTF128 xmm1/m128, ymm2, imm8 || VEX.256.66.0F3A.W0 19 /r ib || encoded[6]{c4 e3 7d 19 c1 01}
0020h vpinsrd xmm1,xmm1,r8d,0                 ; VPINSRD xmm1, xmm2, r/m32, imm8 || VEX.128.66.0F3A.W0 22 /r ib || encoded[6]{c4 c3 71 22 c8 00}
0026h vinsertf128 ymm0,ymm0,xmm1,1            ; VINSERTF128 ymm1, ymm2, xmm3/m128, imm8 || VEX.256.66.0F3A.W0 18 /r ib || encoded[6]{c4 e3 7d 18 c1 01}
002ch vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0030h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0033h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0036h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<byte> vmov128x8u(byte src)
; static ReadOnlySpan<byte> vmov128x8u_Bytes => new byte[20]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB6,0xC2,0xC5,0xF9,0x6E,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c85f9890, 0x7ff7c85f98a4], 20 bytes
; 2020-01-20 01:59:21:490
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h movzx eax,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c2}
0008h vmovd xmm0,eax                          ; VMOVD xmm1, r/m32 || VEX.128.66.0F.W0 6E /r || encoded[4]{c5 f9 6e c0}
000ch vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0010h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0013h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<ushort> vmov128x16u(ushort src)
; static ReadOnlySpan<byte> vmov128x16u_Bytes => new byte[20]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB7,0xC2,0xC5,0xF9,0x6E,0xC0,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c85f98c0, 0x7ff7c85f98d4], 20 bytes
; 2020-01-20 01:59:21:490
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h movzx eax,dx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c2}
0008h vmovd xmm0,eax                          ; VMOVD xmm1, r/m32 || VEX.128.66.0F.W0 6E /r || encoded[4]{c5 f9 6e c0}
000ch vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0010h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0013h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vmov128x32u(uint src)
; static ReadOnlySpan<byte> vmov128x32u_Bytes => new byte[17]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x6E,0xC2,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c85f98f0, 0x7ff7c85f9901], 17 bytes
; 2020-01-20 01:59:21:490
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovd xmm0,edx                          ; VMOVD xmm1, r/m32 || VEX.128.66.0F.W0 6E /r || encoded[4]{c5 f9 6e c2}
0009h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
000dh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0010h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<ulong> vmov128x64u(ulong src)
; static ReadOnlySpan<byte> vmov128x64u_Bytes => new byte[18]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE1,0xF9,0x6E,0xC2,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c85f9920, 0x7ff7c85f9932], 18 bytes
; 2020-01-20 01:59:21:490
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovq xmm0,rdx                          ; VMOVQ xmm1, r/m64 || VEX.128.66.0F.W1 6E /r || encoded[5]{c4 e1 f9 6e c2}
000ah vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
000eh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0011h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<double> vmov128x64u(double src)
; static ReadOnlySpan<byte> vmov128x64u_Bytes => new byte[13]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x11,0x09,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c85f9d50, 0x7ff7c85f9d5d], 13 bytes
; 2020-01-20 01:59:21:490
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd [rcx],xmm1                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 09}
0009h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
000ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<byte> vmov256x8u(byte src)
; static ReadOnlySpan<byte> vmov256x8u_Bytes => new byte[23]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB6,0xC2,0xC5,0xF9,0x6E,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c85f9d70, 0x7ff7c85f9d87], 23 bytes
; 2020-01-20 01:59:21:490
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h movzx eax,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c2}
0008h vmovd xmm0,eax                          ; VMOVD xmm1, r/m32 || VEX.128.66.0F.W0 6E /r || encoded[4]{c5 f9 6e c0}
000ch vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0010h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0013h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0016h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<ushort> vmov256x16u(ushort src)
; static ReadOnlySpan<byte> vmov256x16u_Bytes => new byte[23]{0xC5,0xF8,0x77,0x66,0x90,0x0F,0xB7,0xC2,0xC5,0xF9,0x6E,0xC0,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c85f9da0, 0x7ff7c85f9db7], 23 bytes
; 2020-01-20 01:59:21:490
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h movzx eax,dx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c2}
0008h vmovd xmm0,eax                          ; VMOVD xmm1, r/m32 || VEX.128.66.0F.W0 6E /r || encoded[4]{c5 f9 6e c0}
000ch vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
0010h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0013h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0016h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<uint> vmov256x32u(uint src)
; static ReadOnlySpan<byte> vmov256x32u_Bytes => new byte[20]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x6E,0xC2,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c85f9dd0, 0x7ff7c85f9de4], 20 bytes
; 2020-01-20 01:59:21:490
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovd xmm0,edx                          ; VMOVD xmm1, r/m32 || VEX.128.66.0F.W0 6E /r || encoded[4]{c5 f9 6e c2}
0009h vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
000dh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0010h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0013h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<ulong> vmov256x64u(ulong src)
; static ReadOnlySpan<byte> vmov256x64u_Bytes => new byte[21]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xE1,0xF9,0x6E,0xC2,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c85f9e00, 0x7ff7c85f9e15], 21 bytes
; 2020-01-20 01:59:21:490
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovq xmm0,rdx                          ; VMOVQ xmm1, r/m64 || VEX.128.66.0F.W1 6E /r || encoded[5]{c4 e1 f9 6e c2}
000ah vmovupd [rcx],ymm0                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 01}
000eh mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0011h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0014h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector256<double> vmov256x64u(double src)
; static ReadOnlySpan<byte> vmov256x64u_Bytes => new byte[16]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x11,0x09,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
; [0x7ff7c85f9e30, 0x7ff7c85f9e40], 16 bytes
; 2020-01-20 01:59:21:490
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd [rcx],ymm1                      ; VMOVUPD ymm2/m256, ymm1 || VEX.256.66.0F.WIG 11 /r || encoded[4]{c5 fd 11 09}
0009h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
000ch vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
000fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
