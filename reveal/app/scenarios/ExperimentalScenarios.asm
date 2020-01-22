; 2020-01-22 01:44:39:841
; uint xor_u32(uint a, uint b)
; xor_u32_32u[0x7ff7c7e7c580, 0x7ff7c7e7c58a][10] = {0f 1f 44 00 00 33 d1 8b c2 c3}
; Capture completion code, None
; 2020-01-22 01:44:39:849
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h xor edx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d1}
0007h mov eax,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c2}
0009h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vbsrl_128x32u_0(Vector128<uint> x)
; vbsrl_128x32u_0_128x32u[0x7ff7c7e7fa60, 0x7ff7c7e7fa76][22] = {c5 f8 77 66 90 c5 f9 10 02 c5 f9 73 d8 00 c5 f9 11 01 48 8b c1 c3}
; Capture completion code, None
; 2020-01-22 01:44:39:851
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpsrldq xmm0,xmm0,0                     ; VPSRLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /3 ib || encoded[5]{c5 f9 73 d8 00}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vbsrl_128x32u_2(Vector128<uint> x)
; vbsrl_128x32u_2_128x32u[0x7ff7c7e7fa90, 0x7ff7c7e7faa6][22] = {c5 f8 77 66 90 c5 f9 10 02 c5 f9 73 d8 02 c5 f9 11 01 48 8b c1 c3}
; Capture completion code, None
; 2020-01-22 01:44:39:851
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpsrldq xmm0,xmm0,2                     ; VPSRLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /3 ib || encoded[5]{c5 f9 73 d8 02}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vbsrl_128x32u_3(Vector128<uint> x)
; vbsrl_128x32u_3_128x32u[0x7ff7c7e7fac0, 0x7ff7c7e7fad6][22] = {c5 f8 77 66 90 c5 f9 10 02 c5 f9 73 d8 03 c5 f9 11 01 48 8b c1 c3}
; Capture completion code, None
; 2020-01-22 01:44:39:851
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpsrldq xmm0,xmm0,3                     ; VPSRLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /3 ib || encoded[5]{c5 f9 73 d8 03}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vbsrl_128x32u_5(Vector128<uint> x)
; vbsrl_128x32u_5_128x32u[0x7ff7c7e7fb20, 0x7ff7c7e7fb36][22] = {c5 f8 77 66 90 c5 f9 10 02 c5 f9 73 d8 05 c5 f9 11 01 48 8b c1 c3}
; Capture completion code, None
; 2020-01-22 01:44:39:851
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpsrldq xmm0,xmm0,5                     ; VPSRLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /3 ib || encoded[5]{c5 f9 73 d8 05}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vbsrl_128x32u_6(Vector128<uint> x)
; vbsrl_128x32u_6_128x32u[0x7ff7c7e7fb50, 0x7ff7c7e7fb66][22] = {c5 f8 77 66 90 c5 f9 10 02 c5 f9 73 d8 06 c5 f9 11 01 48 8b c1 c3}
; Capture completion code, None
; 2020-01-22 01:44:39:851
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpsrldq xmm0,xmm0,6                     ; VPSRLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /3 ib || encoded[5]{c5 f9 73 d8 06}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vbsrl_128x32u_7(Vector128<uint> x)
; vbsrl_128x32u_7_128x32u[0x7ff7c7e7fb80, 0x7ff7c7e7fb96][22] = {c5 f8 77 66 90 c5 f9 10 02 c5 f9 73 d8 07 c5 f9 11 01 48 8b c1 c3}
; Capture completion code, None
; 2020-01-22 01:44:39:851
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpsrldq xmm0,xmm0,7                     ; VPSRLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /3 ib || encoded[5]{c5 f9 73 d8 07}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vbsrl_128x32u_8(Vector128<uint> x)
; vbsrl_128x32u_8_128x32u[0x7ff7c7e7fbb0, 0x7ff7c7e7fbc6][22] = {c5 f8 77 66 90 c5 f9 10 02 c5 f9 73 d8 08 c5 f9 11 01 48 8b c1 c3}
; Capture completion code, None
; 2020-01-22 01:44:39:851
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpsrldq xmm0,xmm0,8                     ; VPSRLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /3 ib || encoded[5]{c5 f9 73 d8 08}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vbsrl_128x32u_11(Vector128<uint> x)
; vbsrl_128x32u_11_128x32u[0x7ff7c7e7fc10, 0x7ff7c7e7fc26][22] = {c5 f8 77 66 90 c5 f9 10 02 c5 f9 73 d8 0b c5 f9 11 01 48 8b c1 c3}
; Capture completion code, None
; 2020-01-22 01:44:39:851
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpsrldq xmm0,xmm0,0Bh                   ; VPSRLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /3 ib || encoded[5]{c5 f9 73 d8 0b}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vbsrl_128x32u_23(Vector128<uint> x)
; vbsrl_128x32u_23_128x32u[0x7ff7c7e7fc40, 0x7ff7c7e7fc56][22] = {c5 f8 77 66 90 c5 f9 10 02 c5 f9 73 d8 17 c5 f9 11 01 48 8b c1 c3}
; Capture completion code, None
; 2020-01-22 01:44:39:851
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpsrldq xmm0,xmm0,17h                   ; VPSRLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /3 ib || encoded[5]{c5 f9 73 d8 17}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; byte opA_8u(byte dl, byte r8b, byte r9b, byte rsp28)
; opA_8u_8u[0x7ff7c7e7fca0, 0x7ff7c7e7fcc8][40] = {0f 1f 44 00 00 0f b6 c2 41 0f b6 d0 0f af c2 0f b6 c0 41 0f b6 d1 33 c2 0f b6 c0 8b 54 24 28 0f b6 d2 0b d0 0f b6 c2 c3}
; Capture completion code, None
; 2020-01-22 01:44:39:851
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
0027h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ushort opA_16u(ushort dx, ushort r8w, ushort r9w, ushort rsp28)
; opA_16u_16u[0x7ff7c7e7fce0, 0x7ff7c7e7fd08][40] = {0f 1f 44 00 00 0f b7 c2 41 0f b7 d0 0f af c2 0f b7 c0 41 0f b7 d1 33 c2 0f b7 c0 8b 54 24 28 0f b7 d2 0b c2 0f b7 c0 c3}
; Capture completion code, None
; 2020-01-22 01:44:39:852
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,dx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c2}
0008h movzx edx,r8w                           ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[4]{41 0f b7 d0}
000ch imul eax,edx                            ; IMUL r32, r/m32 || o32 0F AF /r || encoded[3]{0f af c2}
000fh movzx eax,ax                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c0}
0012h movzx edx,r9w                           ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[4]{41 0f b7 d1}
0016h xor eax,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c2}
0018h movzx eax,ax                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c0}
001bh mov edx,[rsp+28h]                       ; MOV r32, r/m32 || o32 8B /r || encoded[4]{8b 54 24 28}
001fh movzx edx,dx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 d2}
0022h or eax,edx                              ; OR r32, r/m32 || o32 0B /r || encoded[2]{0b c2}
0024h movzx eax,ax                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c0}
0027h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong opA_64u(ulong rdx, ulong r8, ulong r9, ulong rsp28)
; opA_64u_64u[0x7ff7c7e7fd50, 0x7ff7c7e7fd65][21] = {0f 1f 44 00 00 49 0f af d0 49 33 d1 48 8b c2 48 0b 44 24 28 c3}
; Capture completion code, None
; 2020-01-22 01:44:39:852
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h imul rdx,r8                             ; IMUL r64, r/m64 || REX.W 0F AF /r || encoded[4]{49 0f af d0}
0009h xor rdx,r9                              ; XOR r64, r/m64 || REX.W 33 /r || encoded[3]{49 33 d1}
000ch mov rax,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c2}
000fh or rax,[rsp+28h]                        ; OR r64, r/m64 || REX.W 0B /r || encoded[5]{48 0b 44 24 28}
0014h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; byte opB_8u(byte dl, byte r8b, byte r9b, byte rsp28, byte rsp30)
; opB_8u_8u[0x7ff7c7e7fd80, 0x7ff7c7e7fdb4][52] = {0f 1f 44 00 00 0f b6 c2 41 0f b6 d0 0f af c2 0f b6 c0 41 0f b6 d1 33 c2 0f b6 c0 8b 54 24 28 0f b6 d2 0b d0 0f b6 c2 8b 54 24 30 0f b6 d2 23 c2 0f b6 c0 c3}
; Capture completion code, None
; 2020-01-22 01:44:39:852
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
0033h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void opD_8u(byte dl, byte r8b, out byte r9, out byte rdx)
; opD_8u_8u[0x7ff7c7e7fe20, 0x7ff7c7e7fe3d][29] = {0f 1f 44 00 00 0f b6 c2 83 f0 05 41 88 01 41 0f b6 c0 83 c8 07 48 8b 54 24 28 88 02 c3}
; Capture completion code, None
; 2020-01-22 01:44:39:852
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
; void opD_64u(ulong rdx, ulong r8, out ulong r9, out ulong rax)
; opD_64u_64u[0x7ff7c7e7fe50, 0x7ff7c7e7fe69][25] = {0f 1f 44 00 00 48 83 f2 05 49 89 11 49 83 c8 07 48 8b 44 24 28 4c 89 00 c3}
; Capture completion code, None
; 2020-01-22 01:44:39:852
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h xor rdx,5                               ; XOR r/m64, imm8 || REX.W 83 /6 ib || encoded[4]{48 83 f2 05}
0009h mov [r9],rdx                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 11}
000ch or r8,7                                 ; OR r/m64, imm8 || REX.W 83 /1 ib || encoded[4]{49 83 c8 07}
0010h mov rax,[rsp+28h]                       ; MOV r64, r/m64 || REX.W 8B /r || encoded[5]{48 8b 44 24 28}
0015h mov [rax],r8                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 00}
0018h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void opE_64u(ulong rdx, out ulong r8, out ulong r9)
; opE_64u_64u[0x7ff7c7e7fe80, 0x7ff7c7e7fe97][23] = {0f 1f 44 00 00 48 8b c2 48 83 f0 05 49 89 00 48 83 ca 07 49 89 11 c3}
; Capture completion code, None
; 2020-01-22 01:44:39:852
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c2}
0008h xor rax,5                               ; XOR r/m64, imm8 || REX.W 83 /6 ib || encoded[4]{48 83 f0 05}
000ch mov [r8],rax                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 00}
000fh or rdx,7                                ; OR r/m64, imm8 || REX.W 83 /1 ib || encoded[4]{48 83 ca 07}
0013h mov [r9],rdx                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 11}
0016h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void opF_64u(ulong rdx, out ulong r8, out ulong r9, out ulong rax)
; opF_64u_64u[0x7ff7c7e7feb0, 0x7ff7c7e7fed6][38] = {0f 1f 44 00 00 48 8b c2 48 83 f0 05 49 89 00 48 8b c2 48 83 c8 07 49 89 01 48 83 e2 0d 48 8b 44 24 28 48 89 10 c3}
; Capture completion code, None
; 2020-01-22 01:44:39:852
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c2}
0008h xor rax,5                               ; XOR r/m64, imm8 || REX.W 83 /6 ib || encoded[4]{48 83 f0 05}
000ch mov [r8],rax                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 00}
000fh mov rax,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c2}
0012h or rax,7                                ; OR r/m64, imm8 || REX.W 83 /1 ib || encoded[4]{48 83 c8 07}
0016h mov [r9],rax                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 01}
0019h and rdx,0Dh                             ; AND r/m64, imm8 || REX.W 83 /4 ib || encoded[4]{48 83 e2 0d}
001dh mov rax,[rsp+28h]                       ; MOV r64, r/m64 || REX.W 8B /r || encoded[5]{48 8b 44 24 28}
0022h mov [rax],rdx                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 10}
0025h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
