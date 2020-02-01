------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> InvokeBinaryImmediate_1(Vector128<uint> x, Vector128<uint> y)
; InvokeBinaryImmediate_1_v128x32u_v128x32u[29] = {c5 f8 77 66 90 c4 c1 79 10 00 c4 c1 79 10 09 c4 e3 79 0d c1 04 c5 f9 11 02 48 8b c2 c3}
; TermCode = MSDIAG
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 00}
000ah vmovupd xmm1,[r9]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 09}
000fh vblendpd xmm0,xmm0,xmm1,4               ; VBLENDPD xmm1, xmm2, xmm3/m128, imm8 || VEX.128.66.0F3A.WIG 0D /r ib || encoded[6]{c4 e3 79 0d c1 04}
0015h vmovupd [rdx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 02}
0019h mov rax,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c2}
001ch ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> InvokeBinaryImmediate_2()
; InvokeBinaryImmediate_2[103] = {c5 f8 77 66 90 b8 01 00 00 00 c5 f9 6e c0 b8 02 00 00 00 c4 e3 79 22 c0 01 b8 03 00 00 00 c4 e3 79 22 c0 02 b8 04 00 00 00 c4 e3 79 22 c0 03 b8 01 00 00 00 c5 f9 6e c8 b8 02 00 00 00 c4 e3 71 22 c8 01 b8 03 00 00 00 c4 e3 71 22 c8 02 b8 04 00 00 00 c4 e3 71 22 c8 03 c4 e3 79 0d c1 04 c5 f9 11 02 48 8b c2 c3}
; TermCode = MSDIAG
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h mov eax,1                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 01 00 00 00}
000ah vmovd xmm0,eax                          ; VMOVD xmm1, r/m32 || VEX.128.66.0F.W0 6E /r || encoded[4]{c5 f9 6e c0}
000eh mov eax,2                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 02 00 00 00}
0013h vpinsrd xmm0,xmm0,eax,1                 ; VPINSRD xmm1, xmm2, r/m32, imm8 || VEX.128.66.0F3A.W0 22 /r ib || encoded[6]{c4 e3 79 22 c0 01}
0019h mov eax,3                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 03 00 00 00}
001eh vpinsrd xmm0,xmm0,eax,2                 ; VPINSRD xmm1, xmm2, r/m32, imm8 || VEX.128.66.0F3A.W0 22 /r ib || encoded[6]{c4 e3 79 22 c0 02}
0024h mov eax,4                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 04 00 00 00}
0029h vpinsrd xmm0,xmm0,eax,3                 ; VPINSRD xmm1, xmm2, r/m32, imm8 || VEX.128.66.0F3A.W0 22 /r ib || encoded[6]{c4 e3 79 22 c0 03}
002fh mov eax,1                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 01 00 00 00}
0034h vmovd xmm1,eax                          ; VMOVD xmm1, r/m32 || VEX.128.66.0F.W0 6E /r || encoded[4]{c5 f9 6e c8}
0038h mov eax,2                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 02 00 00 00}
003dh vpinsrd xmm1,xmm1,eax,1                 ; VPINSRD xmm1, xmm2, r/m32, imm8 || VEX.128.66.0F3A.W0 22 /r ib || encoded[6]{c4 e3 71 22 c8 01}
0043h mov eax,3                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 03 00 00 00}
0048h vpinsrd xmm1,xmm1,eax,2                 ; VPINSRD xmm1, xmm2, r/m32, imm8 || VEX.128.66.0F3A.W0 22 /r ib || encoded[6]{c4 e3 71 22 c8 02}
004eh mov eax,4                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 04 00 00 00}
0053h vpinsrd xmm1,xmm1,eax,3                 ; VPINSRD xmm1, xmm2, r/m32, imm8 || VEX.128.66.0F3A.W0 22 /r ib || encoded[6]{c4 e3 71 22 c8 03}
0059h vblendpd xmm0,xmm0,xmm1,4               ; VBLENDPD xmm1, xmm2, xmm3/m128, imm8 || VEX.128.66.0F3A.WIG 0D /r ib || encoded[6]{c4 e3 79 0d c1 04}
005fh vmovupd [rdx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 02}
0063h mov rax,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c2}
0066h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; uint xor_u32(uint a, uint b)
; xor_u32_32u_32u[10] = {0f 1f 44 00 00 33 d1 8b c2 c3}
; TermCode = MSDIAG
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h xor edx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d1}
0007h mov eax,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c2}
0009h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vbsrl_128x32u_0(Vector128<uint> x)
; vbsrl_128x32u_0_v128x32u[22] = {c5 f8 77 66 90 c5 f9 10 02 c5 f9 73 d8 00 c5 f9 11 01 48 8b c1 c3}
; TermCode = MSDIAG
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpsrldq xmm0,xmm0,0                     ; VPSRLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /3 ib || encoded[5]{c5 f9 73 d8 00}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vbsrl_128x32u_2(Vector128<uint> x)
; vbsrl_128x32u_2_v128x32u[22] = {c5 f8 77 66 90 c5 f9 10 02 c5 f9 73 d8 02 c5 f9 11 01 48 8b c1 c3}
; TermCode = MSDIAG
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpsrldq xmm0,xmm0,2                     ; VPSRLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /3 ib || encoded[5]{c5 f9 73 d8 02}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vbsrl_128x32u_3(Vector128<uint> x)
; vbsrl_128x32u_3_v128x32u[22] = {c5 f8 77 66 90 c5 f9 10 02 c5 f9 73 d8 03 c5 f9 11 01 48 8b c1 c3}
; TermCode = MSDIAG
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpsrldq xmm0,xmm0,3                     ; VPSRLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /3 ib || encoded[5]{c5 f9 73 d8 03}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vbsrl_128x32u_7(Vector128<uint> x)
; vbsrl_128x32u_7_v128x32u[22] = {c5 f8 77 66 90 c5 f9 10 02 c5 f9 73 d8 07 c5 f9 11 01 48 8b c1 c3}
; TermCode = MSDIAG
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpsrldq xmm0,xmm0,7                     ; VPSRLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /3 ib || encoded[5]{c5 f9 73 d8 07}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vbsrl_128x32u_9(Vector128<uint> x)
; vbsrl_128x32u_9_v128x32u[22] = {c5 f8 77 66 90 c5 f9 10 02 c5 f9 73 d8 09 c5 f9 11 01 48 8b c1 c3}
; TermCode = MSDIAG
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpsrldq xmm0,xmm0,9                     ; VPSRLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /3 ib || encoded[5]{c5 f9 73 d8 09}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vbsrl_128x32u_23(Vector128<uint> x)
; vbsrl_128x32u_23_v128x32u[22] = {c5 f8 77 66 90 c5 f9 10 02 c5 f9 73 d8 17 c5 f9 11 01 48 8b c1 c3}
; TermCode = MSDIAG
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpsrldq xmm0,xmm0,17h                   ; VPSRLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /3 ib || encoded[5]{c5 f9 73 d8 17}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; uint opA_32u(uint edx, uint r8d, uint r9d, uint rsp28)
; opA_32u_32u_32u_32u_32u[19] = {0f 1f 44 00 00 41 0f af d0 41 33 d1 8b c2 0b 44 24 28 c3}
; TermCode = MSDIAG
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h imul edx,r8d                            ; IMUL r32, r/m32 || o32 0F AF /r || encoded[4]{41 0f af d0}
0009h xor edx,r9d                             ; XOR r32, r/m32 || o32 33 /r || encoded[3]{41 33 d1}
000ch mov eax,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c2}
000eh or eax,[rsp+28h]                        ; OR r32, r/m32 || o32 0B /r || encoded[4]{0b 44 24 28}
0012h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; byte opB_8u(byte dl, byte r8b, byte r9b, byte rsp28, byte rsp30)
; opB_8u_8u_8u_8u_8u_8u[52] = {0f 1f 44 00 00 0f b6 c2 41 0f b6 d0 0f af c2 0f b6 c0 41 0f b6 d1 33 c2 0f b6 c0 8b 54 24 28 0f b6 d2 0b d0 0f b6 c2 8b 54 24 30 0f b6 d2 23 c2 0f b6 c0 c3}
; TermCode = MSDIAG
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
------------------------------------------------------------------------------------------------------------------------
; byte opC_8u(byte dl, byte r8b, byte r9b, byte rsp28, byte rsp30, byte rsp38)
; opC_8u_8u_8u_8u_8u_8u_8u[64] = {0f 1f 44 00 00 0f b6 c2 41 0f b6 d0 0f af c2 0f b6 c0 41 0f b6 d1 33 c2 0f b6 c0 8b 54 24 28 0f b6 d2 0b d0 0f b6 c2 8b 54 24 30 0f b6 d2 23 c2 0f b6 c0 8b 54 24 38 0f b6 d2 33 c2 0f b6 c0 c3}
; TermCode = MSDIAG
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
------------------------------------------------------------------------------------------------------------------------
; void opE_64u(ulong rdx, out ulong r8, out ulong r9)
; opE_64u_64u_64u(out)_64u(out)[23] = {0f 1f 44 00 00 48 8b c2 48 83 f0 05 49 89 00 48 83 ca 07 49 89 11 c3}
; TermCode = MSDIAG
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c2}
0008h xor rax,5                               ; XOR r/m64, imm8 || REX.W 83 /6 ib || encoded[4]{48 83 f0 05}
000ch mov [r8],rax                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 00}
000fh or rdx,7                                ; OR r/m64, imm8 || REX.W 83 /1 ib || encoded[4]{48 83 ca 07}
0013h mov [r9],rdx                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 11}
0016h ret                                     ; RET || C3 || encoded[1]{c3}
