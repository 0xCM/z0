; 2020-01-22 01:43:38:936
; uint xor_u32(uint a, uint b)
; xor_u32_32u[0x7ff7c7e7c580, 0x7ff7c7e7c58a][10] = {0f 1f 44 00 00 33 d1 8b c2 c3}
; Capture completion code, None
; 2020-01-22 01:43:38:946
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h xor edx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d1}
0007h mov eax,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c2}
0009h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vbsrl_128x32u_3(Vector128<uint> x)
; vbsrl_128x32u_3_128x32u[0x7ff7c7e7fac0, 0x7ff7c7e7fad6][22] = {c5 f8 77 66 90 c5 f9 10 02 c5 f9 73 d8 03 c5 f9 11 01 48 8b c1 c3}
; Capture completion code, None
; 2020-01-22 01:43:38:948
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpsrldq xmm0,xmm0,3                     ; VPSRLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /3 ib || encoded[5]{c5 f9 73 d8 03}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> vbsrl_128x32u_200(Vector128<uint> x)
; vbsrl_128x32u_200_128x32u[0x7ff7c7e7fc70, 0x7ff7c7e7fc86][22] = {c5 f8 77 66 90 c5 f9 10 02 c5 f9 73 d8 c8 c5 f9 11 01 48 8b c1 c3}
; Capture completion code, None
; 2020-01-22 01:43:38:949
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vpsrldq xmm0,xmm0,0C8h                  ; VPSRLDQ xmm1, xmm2, imm8 || VEX.128.66.0F.WIG 73 /3 ib || encoded[5]{c5 f9 73 d8 c8}
000eh vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0012h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0015h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; byte opA_8u(byte dl, byte r8b, byte r9b, byte rsp28)
; opA_8u_8u[0x7ff7c7e7fca0, 0x7ff7c7e7fcc8][40] = {0f 1f 44 00 00 0f b6 c2 41 0f b6 d0 0f af c2 0f b6 c0 41 0f b6 d1 33 c2 0f b6 c0 8b 54 24 28 0f b6 d2 0b d0 0f b6 c2 c3}
; Capture completion code, None
; 2020-01-22 01:43:38:949
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
; ulong opA_64u(ulong rdx, ulong r8, ulong r9, ulong rsp28)
; opA_64u_64u[0x7ff7c7e7fd50, 0x7ff7c7e7fd65][21] = {0f 1f 44 00 00 49 0f af d0 49 33 d1 48 8b c2 48 0b 44 24 28 c3}
; Capture completion code, None
; 2020-01-22 01:43:38:949
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h imul rdx,r8                             ; IMUL r64, r/m64 || REX.W 0F AF /r || encoded[4]{49 0f af d0}
0009h xor rdx,r9                              ; XOR r64, r/m64 || REX.W 33 /r || encoded[3]{49 33 d1}
000ch mov rax,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c2}
000fh or rax,[rsp+28h]                        ; OR r64, r/m64 || REX.W 0B /r || encoded[5]{48 0b 44 24 28}
0014h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void opD_64u(ulong rdx, ulong r8, out ulong r9, out ulong rax)
; opD_64u_64u[0x7ff7c7e7fe50, 0x7ff7c7e7fe69][25] = {0f 1f 44 00 00 48 83 f2 05 49 89 11 49 83 c8 07 48 8b 44 24 28 4c 89 00 c3}
; Capture completion code, None
; 2020-01-22 01:43:38:949
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h xor rdx,5                               ; XOR r/m64, imm8 || REX.W 83 /6 ib || encoded[4]{48 83 f2 05}
0009h mov [r9],rdx                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 11}
000ch or r8,7                                 ; OR r/m64, imm8 || REX.W 83 /1 ib || encoded[4]{49 83 c8 07}
0010h mov rax,[rsp+28h]                       ; MOV r64, r/m64 || REX.W 8B /r || encoded[5]{48 8b 44 24 28}
0015h mov [rax],r8                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 00}
0018h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
