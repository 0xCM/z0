; 2020-01-20 01:59:21:261
; bit check_and_1(Vector128<uint> x, Vector128<uint> y)
; static ReadOnlySpan<byte> check_and_1_128x32u_128x32uBytes => new byte[153]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x01,0xC5,0xF8,0x28,0xC8,0xC5,0xF9,0x10,0x12,0xC5,0xF8,0x28,0xDA,0xC5,0xF1,0xDB,0xCB,0xC5,0xF8,0x28,0xD8,0xC5,0xF9,0x7E,0xD8,0xC5,0xF8,0x28,0xDA,0xC5,0xF9,0x7E,0xDA,0x23,0xC2,0xC5,0xF8,0x28,0xD8,0xC4,0xE3,0x79,0x16,0xDA,0x01,0xC5,0xF8,0x28,0xDA,0xC4,0xE3,0x79,0x16,0xD9,0x01,0x23,0xD1,0xC5,0xF8,0x28,0xD8,0xC4,0xE3,0x79,0x16,0xD9,0x02,0xC5,0xF8,0x28,0xDA,0xC4,0xC3,0x79,0x16,0xD8,0x02,0x41,0x23,0xC8,0xC4,0xC3,0x79,0x16,0xC0,0x03,0xC4,0xC3,0x79,0x16,0xD1,0x03,0x45,0x23,0xC1,0xC5,0xF9,0x6E,0xC0,0xC4,0xE3,0x79,0x22,0xC2,0x01,0xC4,0xE3,0x79,0x22,0xC1,0x02,0xC4,0xC3,0x79,0x22,0xC0,0x03,0xC5,0xF1,0x76,0xC0,0xC5,0xF0,0x57,0xC9,0xC5,0xE8,0x57,0xD2,0xC5,0xF1,0x76,0xCA,0xC4,0xE2,0x79,0x17,0xC1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
; [0x7ff7c839e9b0, 0x7ff7c839ea49], 153 bytes
; 2020-01-20 01:59:21:262
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rcx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 01}
0009h vmovaps xmm1,xmm0                       ; VMOVAPS xmm1, xmm2/m128 || VEX.128.0F.WIG 28 /r || encoded[4]{c5 f8 28 c8}
000dh vmovupd xmm2,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 12}
0011h vmovaps xmm3,xmm2                       ; VMOVAPS xmm1, xmm2/m128 || VEX.128.0F.WIG 28 /r || encoded[4]{c5 f8 28 da}
0015h vpand xmm1,xmm1,xmm3                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f1 db cb}
0019h vmovaps xmm3,xmm0                       ; VMOVAPS xmm1, xmm2/m128 || VEX.128.0F.WIG 28 /r || encoded[4]{c5 f8 28 d8}
001dh vmovd eax,xmm3                          ; VMOVD r/m32, xmm1 || VEX.128.66.0F.W0 7E /r || encoded[4]{c5 f9 7e d8}
0021h vmovaps xmm3,xmm2                       ; VMOVAPS xmm1, xmm2/m128 || VEX.128.0F.WIG 28 /r || encoded[4]{c5 f8 28 da}
0025h vmovd edx,xmm3                          ; VMOVD r/m32, xmm1 || VEX.128.66.0F.W0 7E /r || encoded[4]{c5 f9 7e da}
0029h and eax,edx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 c2}
002bh vmovaps xmm3,xmm0                       ; VMOVAPS xmm1, xmm2/m128 || VEX.128.0F.WIG 28 /r || encoded[4]{c5 f8 28 d8}
002fh vpextrd edx,xmm3,1                      ; VPEXTRD r/m32, xmm2, imm8 || VEX.128.66.0F3A.W0 16 /r ib || encoded[6]{c4 e3 79 16 da 01}
0035h vmovaps xmm3,xmm2                       ; VMOVAPS xmm1, xmm2/m128 || VEX.128.0F.WIG 28 /r || encoded[4]{c5 f8 28 da}
0039h vpextrd ecx,xmm3,1                      ; VPEXTRD r/m32, xmm2, imm8 || VEX.128.66.0F3A.W0 16 /r ib || encoded[6]{c4 e3 79 16 d9 01}
003fh and edx,ecx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 d1}
0041h vmovaps xmm3,xmm0                       ; VMOVAPS xmm1, xmm2/m128 || VEX.128.0F.WIG 28 /r || encoded[4]{c5 f8 28 d8}
0045h vpextrd ecx,xmm3,2                      ; VPEXTRD r/m32, xmm2, imm8 || VEX.128.66.0F3A.W0 16 /r ib || encoded[6]{c4 e3 79 16 d9 02}
004bh vmovaps xmm3,xmm2                       ; VMOVAPS xmm1, xmm2/m128 || VEX.128.0F.WIG 28 /r || encoded[4]{c5 f8 28 da}
004fh vpextrd r8d,xmm3,2                      ; VPEXTRD r/m32, xmm2, imm8 || VEX.128.66.0F3A.W0 16 /r ib || encoded[6]{c4 c3 79 16 d8 02}
0055h and ecx,r8d                             ; AND r32, r/m32 || o32 23 /r || encoded[3]{41 23 c8}
0058h vpextrd r8d,xmm0,3                      ; VPEXTRD r/m32, xmm2, imm8 || VEX.128.66.0F3A.W0 16 /r ib || encoded[6]{c4 c3 79 16 c0 03}
005eh vpextrd r9d,xmm2,3                      ; VPEXTRD r/m32, xmm2, imm8 || VEX.128.66.0F3A.W0 16 /r ib || encoded[6]{c4 c3 79 16 d1 03}
0064h and r8d,r9d                             ; AND r32, r/m32 || o32 23 /r || encoded[3]{45 23 c1}
0067h vmovd xmm0,eax                          ; VMOVD xmm1, r/m32 || VEX.128.66.0F.W0 6E /r || encoded[4]{c5 f9 6e c0}
006bh vpinsrd xmm0,xmm0,edx,1                 ; VPINSRD xmm1, xmm2, r/m32, imm8 || VEX.128.66.0F3A.W0 22 /r ib || encoded[6]{c4 e3 79 22 c2 01}
0071h vpinsrd xmm0,xmm0,ecx,2                 ; VPINSRD xmm1, xmm2, r/m32, imm8 || VEX.128.66.0F3A.W0 22 /r ib || encoded[6]{c4 e3 79 22 c1 02}
0077h vpinsrd xmm0,xmm0,r8d,3                 ; VPINSRD xmm1, xmm2, r/m32, imm8 || VEX.128.66.0F3A.W0 22 /r ib || encoded[6]{c4 c3 79 22 c0 03}
007dh vpcmpeqd xmm0,xmm1,xmm0                 ; VPCMPEQD xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG 76 /r || encoded[4]{c5 f1 76 c0}
0081h vxorps xmm1,xmm1,xmm1                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f0 57 c9}
0085h vxorps xmm2,xmm2,xmm2                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 e8 57 d2}
0089h vpcmpeqd xmm1,xmm1,xmm2                 ; VPCMPEQD xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG 76 /r || encoded[4]{c5 f1 76 ca}
008dh vptest xmm0,xmm1                        ; VPTEST xmm1, xmm2/m128 || VEX.128.66.0F38.WIG 17 /r || encoded[5]{c4 e2 79 17 c1}
0092h setb al                                 ; SETB r/m8 || 0F 92 /r || encoded[3]{0f 92 c0}
0095h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0098h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> and_class(Vector128<uint> x, Vector128<uint> y)
; static ReadOnlySpan<byte> and_class_128x32uBytes => new byte[32]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xDB,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3};
; [0x7ff7c839ee80, 0x7ff7c839eea0], 32 bytes
; 2020-01-20 01:59:21:262
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0007h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
000bh vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
0010h vpand xmm0,xmm0,xmm1                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f9 db c1}
0014h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0018h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
001bh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
001fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; uint and_class_scalar(uint x, uint y)
; static ReadOnlySpan<byte> and_class_scalar_32uBytes => new byte[14]{0x48,0x83,0xEC,0x28,0x90,0x23,0xD1,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3};
; [0x7ff7c839eec0, 0x7ff7c839eece], 14 bytes
; 2020-01-20 01:59:21:262
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h and edx,ecx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 d1}
0007h mov eax,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c2}
0009h add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
000dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; uint and_class_scalar(CAnd128<uint> f, uint x, uint y)
; static ReadOnlySpan<byte> and_class_scalar_25228285Bytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x41,0x23,0xD0,0x8B,0xC2,0xC3};
; [0x7ff7c839eef0, 0x7ff7c839eefd], 13 bytes
; 2020-01-20 01:59:21:262
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,[rcx]                           ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b 01}
0007h and edx,r8d                             ; AND r32, r/m32 || o32 23 /r || encoded[3]{41 23 d0}
000ah mov eax,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c2}
000ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Vector128<uint> and_struct(Vector128<uint> x, Vector128<uint> y)
; static ReadOnlySpan<byte> and_struct_128x32uBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xDB,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c839f320, 0x7ff7c839f33a], 26 bytes
; 2020-01-20 01:59:21:262
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0009h vmovupd xmm1,[r8]                       ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[5]{c4 c1 79 10 08}
000eh vpand xmm0,xmm0,xmm1                    ; VPAND xmm1, xmm2, xmm3/m128 || VEX.128.66.0F.WIG DB /r || encoded[4]{c5 f9 db c1}
0012h vmovupd [rcx],xmm0                      ; VMOVUPD xmm2/m128, xmm1 || VEX.128.66.0F.WIG 11 /r || encoded[4]{c5 f9 11 01}
0016h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0019h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; uint and_struct_scalar(uint x, uint y)
; static ReadOnlySpan<byte> and_struct_scalar_32uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xC3};
; [0x7ff7c839f350, 0x7ff7c839f35a], 10 bytes
; 2020-01-20 01:59:21:262
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h and edx,ecx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 d1}
0007h mov eax,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c2}
0009h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void loop_1(ReadOnlySpan<uint> src, Span<uint> dst)
; static ReadOnlySpan<byte> loop_1_25727981Bytes => new byte[50]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x8B,0x0A,0x8B,0x52,0x08,0x45,0x33,0xC0,0x85,0xD2,0x7E,0x1C,0x4D,0x63,0xC8,0x4E,0x8D,0x14,0x89,0x46,0x8B,0x0C,0x88,0x41,0xF7,0xD1,0x41,0xFF,0xC1,0x45,0x89,0x0A,0x41,0xFF,0xC0,0x44,0x3B,0xC2,0x7C,0xE4,0xC3};
; [0x7ff7c839f370, 0x7ff7c839f3a2], 50 bytes
; 2020-01-20 01:59:21:262
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 01}
0008h mov rcx,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 0a}
000bh mov edx,[rdx+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 52 08}
000eh xor r8d,r8d                             ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 c0}
0011h test edx,edx                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 d2}
0013h jle short 0031h                         ; JLE rel8 || 7E cb || encoded[2]{7e 1c}
0015h movsxd r9,r8d                           ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4d 63 c8}
0018h lea r10,[rcx+r9*4]                      ; LEA r64, m || REX.W 8D /r || encoded[4]{4e 8d 14 89}
001ch mov r9d,[rax+r9*4]                      ; MOV r32, r/m32 || o32 8B /r || encoded[4]{46 8b 0c 88}
0020h not r9d                                 ; NOT r/m32 || o32 F7 /2 || encoded[3]{41 f7 d1}
0023h inc r9d                                 ; INC r/m32 || o32 FF /0 || encoded[3]{41 ff c1}
0026h mov [r10],r9d                           ; MOV r/m32, r32 || o32 89 /r || encoded[3]{45 89 0a}
0029h inc r8d                                 ; INC r/m32 || o32 FF /0 || encoded[3]{41 ff c0}
002ch cmp r8d,edx                             ; CMP r32, r/m32 || o32 3B /r || encoded[3]{44 3b c2}
002fh jl short 0015h                          ; JL rel8 || 7C cb || encoded[2]{7c e4}
0031h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void loop_2(ArrayExchange<uint> src, ArrayExchange<uint> dst)
; static ReadOnlySpan<byte> loop_2_3591713Bytes => new byte[80]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x75,0x04,0x33,0xC0,0xEB,0x07,0x48,0x8D,0x41,0x10,0x8B,0x49,0x08,0x48,0x85,0xD2,0x75,0x04,0x33,0xC9,0xEB,0x08,0x48,0x8D,0x4A,0x10,0x44,0x8B,0x42,0x08,0x8B,0x52,0x08,0x45,0x33,0xC0,0x85,0xD2,0x7E,0x1F,0x4D,0x63,0xC8,0x4E,0x8D,0x0C,0x89,0x4D,0x63,0xD0,0x46,0x8B,0x14,0x90,0x41,0xF7,0xD2,0x41,0xFF,0xC2,0x45,0x89,0x11,0x41,0xFF,0xC0,0x44,0x3B,0xC2,0x7C,0xE1,0xC3};
; [0x7ff7c81b32a0, 0x7ff7c81b32f0], 80 bytes
; 2020-01-20 01:59:21:262
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h test rcx,rcx                            ; TEST r/m64, r64 || REX.W 85 /r || encoded[3]{48 85 c9}
0008h jne short 000eh                         ; JNE rel8 || 75 cb || encoded[2]{75 04}
000ah xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
000ch jmp short 0015h                         ; JMP rel8 || EB cb || encoded[2]{eb 07}
000eh lea rax,[rcx+10h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 41 10}
0012h mov ecx,[rcx+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 49 08}
0015h test rdx,rdx                            ; TEST r/m64, r64 || REX.W 85 /r || encoded[3]{48 85 d2}
0018h jne short 001eh                         ; JNE rel8 || 75 cb || encoded[2]{75 04}
001ah xor ecx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c9}
001ch jmp short 0026h                         ; JMP rel8 || EB cb || encoded[2]{eb 08}
001eh lea rcx,[rdx+10h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 4a 10}
0022h mov r8d,[rdx+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[4]{44 8b 42 08}
0026h mov edx,[rdx+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 52 08}
0029h xor r8d,r8d                             ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 c0}
002ch test edx,edx                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 d2}
002eh jle short 004fh                         ; JLE rel8 || 7E cb || encoded[2]{7e 1f}
0030h movsxd r9,r8d                           ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4d 63 c8}
0033h lea r9,[rcx+r9*4]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{4e 8d 0c 89}
0037h movsxd r10,r8d                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4d 63 d0}
003ah mov r10d,[rax+r10*4]                    ; MOV r32, r/m32 || o32 8B /r || encoded[4]{46 8b 14 90}
003eh not r10d                                ; NOT r/m32 || o32 F7 /2 || encoded[3]{41 f7 d2}
0041h inc r10d                                ; INC r/m32 || o32 FF /0 || encoded[3]{41 ff c2}
0044h mov [r9],r10d                           ; MOV r/m32, r32 || o32 89 /r || encoded[3]{45 89 11}
0047h inc r8d                                 ; INC r/m32 || o32 FF /0 || encoded[3]{41 ff c0}
004ah cmp r8d,edx                             ; CMP r32, r/m32 || o32 3B /r || encoded[3]{44 3b c2}
004dh jl short 0030h                          ; JL rel8 || 7C cb || encoded[2]{7c e1}
004fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void pipeline_1(ReadOnlySpan<uint> src, Span<uint> dst)
; static ReadOnlySpan<byte> pipeline_1_32325424Bytes => new byte[56]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x42,0x08,0x45,0x33,0xC0,0x85,0xC0,0x7E,0x28,0x4C,0x8B,0x0A,0x4D,0x63,0xD0,0x4F,0x8D,0x0C,0x91,0x4C,0x8B,0x11,0x4D,0x63,0xD8,0x47,0x8B,0x14,0x9A,0x41,0xF7,0xD2,0x41,0xFF,0xC2,0x41,0xF7,0xD2,0x45,0x89,0x11,0x41,0xFF,0xC0,0x44,0x3B,0xC0,0x7C,0xD8,0xC3};
; [0x7ff7c85f0480, 0x7ff7c85f04b8], 56 bytes
; 2020-01-20 01:59:21:262
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,[rdx+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 42 08}
0008h xor r8d,r8d                             ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 c0}
000bh test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
000dh jle short 0037h                         ; JLE rel8 || 7E cb || encoded[2]{7e 28}
000fh mov r9,[rdx]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b 0a}
0012h movsxd r10,r8d                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4d 63 d0}
0015h lea r9,[r9+r10*4]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{4f 8d 0c 91}
0019h mov r10,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b 11}
001ch movsxd r11,r8d                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4d 63 d8}
001fh mov r10d,[r10+r11*4]                    ; MOV r32, r/m32 || o32 8B /r || encoded[4]{47 8b 14 9a}
0023h not r10d                                ; NOT r/m32 || o32 F7 /2 || encoded[3]{41 f7 d2}
0026h inc r10d                                ; INC r/m32 || o32 FF /0 || encoded[3]{41 ff c2}
0029h not r10d                                ; NOT r/m32 || o32 F7 /2 || encoded[3]{41 f7 d2}
002ch mov [r9],r10d                           ; MOV r/m32, r32 || o32 89 /r || encoded[3]{45 89 11}
002fh inc r8d                                 ; INC r/m32 || o32 FF /0 || encoded[3]{41 ff c0}
0032h cmp r8d,eax                             ; CMP r32, r/m32 || o32 3B /r || encoded[3]{44 3b c0}
0035h jl short 000fh                          ; JL rel8 || 7C cb || encoded[2]{7c d8}
0037h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void pipeline_2(ReadOnlySpan<uint> src, Span<uint> dst)
; static ReadOnlySpan<byte> pipeline_2_22493366Bytes => new byte[59]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x42,0x08,0x45,0x33,0xC0,0x85,0xC0,0x7E,0x2B,0x4C,0x8B,0x0A,0x4D,0x63,0xD0,0x4F,0x8D,0x0C,0x91,0x4C,0x8B,0x11,0x4D,0x63,0xD8,0x47,0x8B,0x14,0x9A,0x45,0x8B,0xDA,0x41,0xF7,0xD3,0x41,0xFF,0xC3,0x45,0x23,0xD3,0x45,0x89,0x11,0x41,0xFF,0xC0,0x44,0x3B,0xC0,0x7C,0xD5,0xC3};
; [0x7ff7c85f04d0, 0x7ff7c85f050b], 59 bytes
; 2020-01-20 01:59:21:262
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,[rdx+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 42 08}
0008h xor r8d,r8d                             ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 c0}
000bh test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
000dh jle short 003ah                         ; JLE rel8 || 7E cb || encoded[2]{7e 2b}
000fh mov r9,[rdx]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b 0a}
0012h movsxd r10,r8d                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4d 63 d0}
0015h lea r9,[r9+r10*4]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{4f 8d 0c 91}
0019h mov r10,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b 11}
001ch movsxd r11,r8d                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4d 63 d8}
001fh mov r10d,[r10+r11*4]                    ; MOV r32, r/m32 || o32 8B /r || encoded[4]{47 8b 14 9a}
0023h mov r11d,r10d                           ; MOV r32, r/m32 || o32 8B /r || encoded[3]{45 8b da}
0026h not r11d                                ; NOT r/m32 || o32 F7 /2 || encoded[3]{41 f7 d3}
0029h inc r11d                                ; INC r/m32 || o32 FF /0 || encoded[3]{41 ff c3}
002ch and r10d,r11d                           ; AND r32, r/m32 || o32 23 /r || encoded[3]{45 23 d3}
002fh mov [r9],r10d                           ; MOV r/m32, r32 || o32 89 /r || encoded[3]{45 89 11}
0032h inc r8d                                 ; INC r/m32 || o32 FF /0 || encoded[3]{41 ff c0}
0035h cmp r8d,eax                             ; CMP r32, r/m32 || o32 3B /r || encoded[3]{44 3b c0}
0038h jl short 000fh                          ; JL rel8 || 7C cb || encoded[2]{7c d5}
003ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; uint and_negate(uint x)
; static ReadOnlySpan<byte> and_negate_32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0x23,0xC1,0xC3};
; [0x7ff7c85f0520, 0x7ff7c85f052e], 14 bytes
; 2020-01-20 01:59:21:262
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h not eax                                 ; NOT r/m32 || o32 F7 /2 || encoded[2]{f7 d0}
0009h inc eax                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c0}
000bh and eax,ecx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 c1}
000dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; uint and_negate_ops(uint x)
; static ReadOnlySpan<byte> and_negate_ops_32uBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0x23,0xC1,0xC3};
; [0x7ff7c85f0540, 0x7ff7c85f054e], 14 bytes
; 2020-01-20 01:59:21:262
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h not eax                                 ; NOT r/m32 || o32 F7 /2 || encoded[2]{f7 d0}
0009h inc eax                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c0}
000bh and eax,ecx                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 c1}
000dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; uint vxor_128x32u_1(Vector128<uint> x, Vector128<uint> y)
; static ReadOnlySpan<byte> vxor_128x32u_1_128x32u_128x32uBytes => new byte[32]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x7E,0xC0,0xC5,0xF9,0x10,0x02,0xC4,0xE3,0x79,0x16,0xC2,0x03,0x33,0xC2,0x48,0x83,0xC4,0x28,0xC3};
; [0x7ff7c85f0970, 0x7ff7c85f0990], 32 bytes
; 2020-01-20 01:59:21:262
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0007h vmovupd xmm0,[rcx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 01}
000bh vmovd eax,xmm0                          ; VMOVD r/m32, xmm1 || VEX.128.66.0F.W0 7E /r || encoded[4]{c5 f9 7e c0}
000fh vmovupd xmm0,[rdx]                      ; VMOVUPD xmm1, xmm2/m128 || VEX.128.66.0F.WIG 10 /r || encoded[4]{c5 f9 10 02}
0013h vpextrd edx,xmm0,3                      ; VPEXTRD r/m32, xmm2, imm8 || VEX.128.66.0F3A.W0 16 /r ib || encoded[6]{c4 e3 79 16 c2 03}
0019h xor eax,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c2}
001bh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
001fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
