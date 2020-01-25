; 2020-01-24 20:46:47:518
; uint xor_u32(uint a, uint b)
; xor_u32_32u[7ff7c66b3210h, 7ff7c66b321ah][10] = {0f 1f 44 00 00 33 d1 8b c2 c3}
; Capture completion code, MSDIAG
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h xor edx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d1}
0007h mov eax,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c2}
0009h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vbsrl_128x32u_0(Vector128<uint> x)
; vbsrl_128x32u_0_128x32u[7ff7c66b66f0h, 7ff7c66b6706h][22] = {c5 f8 77 66 90 c5 f9 10 02 c5 f9 73 d8 00 c5 f9 11 01 48 8b c1 c3}
; Capture completion code, MSDIAG
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpsrldq xmm0,xmm0,0                     ; VPSRLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /3 ib || encoded[5]{c5 f9 73 d8 00}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vbsrl_128x32u_2(Vector128<uint> x)
; vbsrl_128x32u_2_128x32u[7ff7c66b6720h, 7ff7c66b6736h][22] = {c5 f8 77 66 90 c5 f9 10 02 c5 f9 73 d8 02 c5 f9 11 01 48 8b c1 c3}
; Capture completion code, MSDIAG
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpsrldq xmm0,xmm0,2                     ; VPSRLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /3 ib || encoded[5]{c5 f9 73 d8 02}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vbsrl_128x32u_3(Vector128<uint> x)
; vbsrl_128x32u_3_128x32u[7ff7c66b6750h, 7ff7c66b6766h][22] = {c5 f8 77 66 90 c5 f9 10 02 c5 f9 73 d8 03 c5 f9 11 01 48 8b c1 c3}
; Capture completion code, MSDIAG
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpsrldq xmm0,xmm0,3                     ; VPSRLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /3 ib || encoded[5]{c5 f9 73 d8 03}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vbsrl_128x32u_4(Vector128<uint> x)
; vbsrl_128x32u_4_128x32u[7ff7c66b6780h, 7ff7c66b6796h][22] = {c5 f8 77 66 90 c5 f9 10 02 c5 f9 73 d8 04 c5 f9 11 01 48 8b c1 c3}
; Capture completion code, MSDIAG
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpsrldq xmm0,xmm0,4                     ; VPSRLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /3 ib || encoded[5]{c5 f9 73 d8 04}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
