; 2020-01-20 01:59:20:616
; uint xor_u32(uint a, uint b)
; static ReadOnlySpan<byte> xor_u32_32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xD1,0x8B,0xC2,0xC3};
; [0x7ff7c7e7c240, 0x7ff7c7e7c24a], 10 bytes
; 2020-01-20 01:59:20:624
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h xor edx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d1}
0007h mov eax,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c2}
0009h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vbsrl_128x32u_0(Vector128<uint> x)
; static ReadOnlySpan<byte> vbsrl_128x32u_0_128x32uBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x73,0xD8,0x00,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c7e7f720, 0x7ff7c7e7f736], 22 bytes
; 2020-01-20 01:59:20:626
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpsrldq xmm0,xmm0,0                     ; VPSRLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /3 ib || encoded[5]{c5 f9 73 d8 00}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vbsrl_128x32u_2(Vector128<uint> x)
; static ReadOnlySpan<byte> vbsrl_128x32u_2_128x32uBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x73,0xD8,0x02,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c7e7f750, 0x7ff7c7e7f766], 22 bytes
; 2020-01-20 01:59:20:626
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpsrldq xmm0,xmm0,2                     ; VPSRLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /3 ib || encoded[5]{c5 f9 73 d8 02}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vbsrl_128x32u_5(Vector128<uint> x)
; static ReadOnlySpan<byte> vbsrl_128x32u_5_128x32uBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x73,0xD8,0x05,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c7e7f7e0, 0x7ff7c7e7f7f6], 22 bytes
; 2020-01-20 01:59:20:626
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpsrldq xmm0,xmm0,5                     ; VPSRLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /3 ib || encoded[5]{c5 f9 73 d8 05}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vbsrl_128x32u_6(Vector128<uint> x)
; static ReadOnlySpan<byte> vbsrl_128x32u_6_128x32uBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x73,0xD8,0x06,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c7e7f810, 0x7ff7c7e7f826], 22 bytes
; 2020-01-20 01:59:20:626
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpsrldq xmm0,xmm0,6                     ; VPSRLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /3 ib || encoded[5]{c5 f9 73 d8 06}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vbsrl_128x32u_7(Vector128<uint> x)
; static ReadOnlySpan<byte> vbsrl_128x32u_7_128x32uBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x73,0xD8,0x07,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c7e7f840, 0x7ff7c7e7f856], 22 bytes
; 2020-01-20 01:59:20:626
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpsrldq xmm0,xmm0,7                     ; VPSRLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /3 ib || encoded[5]{c5 f9 73 d8 07}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vbsrl_128x32u_11(Vector128<uint> x)
; static ReadOnlySpan<byte> vbsrl_128x32u_11_128x32uBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x73,0xD8,0x0B,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c7e7f8d0, 0x7ff7c7e7f8e6], 22 bytes
; 2020-01-20 01:59:20:626
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpsrldq xmm0,xmm0,0Bh                   ; VPSRLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /3 ib || encoded[5]{c5 f9 73 d8 0b}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vbsrl_128x32u_200(Vector128<uint> x)
; static ReadOnlySpan<byte> vbsrl_128x32u_200_128x32uBytes => new byte[22]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC5,0xF9,0x73,0xD8,0xC8,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c7e7f930, 0x7ff7c7e7f946], 22 bytes
; 2020-01-20 01:59:20:626
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpsrldq xmm0,xmm0,0C8h                  ; VPSRLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /3 ib || encoded[5]{c5 f9 73 d8 c8}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; uint opA_32u(uint edx, uint r8d, uint r9d, uint rsp28)
; static ReadOnlySpan<byte> opA_32u_32uBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xAF,0xD0,0x41,0x33,0xD1,0x8B,0xC2,0x0B,0x44,0x24,0x28,0xC3};
; [0x7ff7c7e7f9e0, 0x7ff7c7e7f9f3], 19 bytes
; 2020-01-20 01:59:20:626
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h imul edx,r8d                            ; IMUL r32, r/m32 || o32 0F AF /r || encoded[4]{41 0f af d0}
0009h xor edx,r9d                             ; XOR r32, r/m32 || o32 33 /r || encoded[3]{41 33 d1}
000ch mov eax,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c2}
000eh or eax,[rsp+28h]                        ; OR r32, r/m32 || o32 0B /r || encoded[4]{0b 44 24 28}
0012h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; byte opC_8u(byte dl, byte r8b, byte r9b, byte rsp28, byte rsp30, byte rsp38)
; static ReadOnlySpan<byte> opC_8u_8uBytes => new byte[64]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0x0F,0xAF,0xC2,0x0F,0xB6,0xC0,0x41,0x0F,0xB6,0xD1,0x33,0xC2,0x0F,0xB6,0xC0,0x8B,0x54,0x24,0x28,0x0F,0xB6,0xD2,0x0B,0xD0,0x0F,0xB6,0xC2,0x8B,0x54,0x24,0x30,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0x8B,0x54,0x24,0x38,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
; [0x7ff7c7e7fa90, 0x7ff7c7e7fad0], 64 bytes
; 2020-01-20 01:59:20:626
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c2}
0008h movzx edx,r8b                           ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{41 0f b6 d0}
000ch imul eax,edx                            ; IMUL r32, r/m32 || o32 0F AF /r || encoded[3]{0f af c2}
000fh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0012h movzx edx,r9b                           ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{41 0f b6 d1}
0016h xor eax,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c2}
0018h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
001bh mov edx,[rsp+28h]                       ; MOV r32, r/m32 || o32 8B /r || encoded[4]{8b 54 24 28}
001fh movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
0022h or edx,eax                              ; OR r32, r/m32 || o32 0B /r || encoded[2]{0b d0}
0024h movzx eax,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c2}
0027h mov edx,[rsp+30h]                       ; MOV r32, r/m32 || o32 8B /r || encoded[4]{8b 54 24 30}
002bh movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
002eh and eax,edx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 c2}
0030h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0033h mov edx,[rsp+38h]                       ; MOV r32, r/m32 || o32 8B /r || encoded[4]{8b 54 24 38}
0037h movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
003ah xor eax,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c2}
003ch movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
003fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void opD_8u(byte dl, byte r8b, out byte r9, out byte rdx)
; static ReadOnlySpan<byte> opD_8u_8uBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x83,0xF0,0x05,0x41,0x88,0x01,0x41,0x0F,0xB6,0xC0,0x83,0xC8,0x07,0x48,0x8B,0x54,0x24,0x28,0x88,0x02,0xC3};
; [0x7ff7c7e7fae0, 0x7ff7c7e7fafd], 29 bytes
; 2020-01-20 01:59:20:626
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c2}
0008h xor eax,5                               ; XOR r/m32, imm8 || o32 83 /6 ib || encoded[3]{83 f0 05}
000bh mov [r9],al                             ; MOV r/m8, r8 || 88 /r || encoded[3]{41 88 01}
000eh movzx eax,r8b                           ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{41 0f b6 c0}
0012h or eax,7                                ; OR r/m32, imm8 || o32 83 /1 ib || encoded[3]{83 c8 07}
0015h mov rdx,[rsp+28h]                       ; MOV r64, r/m64 || REX.W 8B /r || encoded[5]{48 8b 54 24 28}
001ah mov [rdx],al                            ; MOV r/m8, r8 || 88 /r || encoded[2]{88 02}
001ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void opE_64u(ulong rdx, out ulong r8, out ulong r9)
; static ReadOnlySpan<byte> opE_64u_64uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC2,0x48,0x83,0xF0,0x05,0x49,0x89,0x00,0x48,0x83,0xCA,0x07,0x49,0x89,0x11,0xC3};
; [0x7ff7c7e7fb40, 0x7ff7c7e7fb57], 23 bytes
; 2020-01-20 01:59:20:626
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c2}
0008h xor rax,5                               ; XOR r/m64, imm8 || REX.W 83 /6 ib || encoded[4]{48 83 f0 05}
000ch mov [r8],rax                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 00}
000fh or rdx,7                                ; OR r/m64, imm8 || REX.W 83 /1 ib || encoded[4]{48 83 ca 07}
0013h mov [r9],rdx                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 11}
0016h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
