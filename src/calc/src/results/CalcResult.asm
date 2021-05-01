; ----------------------------------------------------------------------------------------------------------------------------------------------------------------
; CalcResult<Cell256,Cell256,Cell256> from(ApiKey api, Cell256 a0, Cell256 a1, Cell256 value)::located://calc/calcresults?from#from_(ApiKey,Cell256,Cell256,Cell256)
; public static ReadOnlySpan<byte> from_ᐤApiKeyㆍCell256ㆍCell256ㆍCell256ᐤ => new byte[302]{0x57,0x56,0x48,0x81,0xec,0xf8,0x00,0x00,0x00,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x78,0xb9,0x20,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xf1,0x48,0x8b,0x8c,0x24,0x30,0x01,0x00,0x00,0x48,0x8d,0x44,0x24,0x78,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x00,0xc5,0xfa,0x7f,0x40,0x10,0xc5,0xfa,0x7f,0x40,0x20,0xc5,0xfa,0x7f,0x40,0x30,0xc5,0xfa,0x7f,0x40,0x40,0xc5,0xfa,0x7f,0x40,0x50,0xc5,0xfa,0x7f,0x40,0x60,0xc5,0xfa,0x7f,0x40,0x70,0xc5,0xfa,0x6f,0x02,0xc5,0xfa,0x7f,0x44,0x24,0x68,0xc4,0xc1,0x7a,0x6f,0x00,0xc5,0xfa,0x7f,0x44,0x24,0x48,0xc4,0xc1,0x7a,0x6f,0x40,0x10,0xc5,0xfa,0x7f,0x44,0x24,0x58,0xc4,0xc1,0x7a,0x6f,0x01,0xc5,0xfa,0x7f,0x44,0x24,0x28,0xc4,0xc1,0x7a,0x6f,0x41,0x10,0xc5,0xfa,0x7f,0x44,0x24,0x38,0xc5,0xfa,0x6f,0x01,0xc5,0xfa,0x7f,0x44,0x24,0x08,0xc5,0xfa,0x6f,0x41,0x10,0xc5,0xfa,0x7f,0x44,0x24,0x18,0xc5,0xfa,0x6f,0x44,0x24,0x68,0xc5,0xfa,0x7f,0x44,0x24,0x78,0xc5,0xfa,0x6f,0x44,0x24,0x48,0xc5,0xfa,0x7f,0x84,0x24,0x98,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x44,0x24,0x58,0xc5,0xfa,0x7f,0x84,0x24,0xa8,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x44,0x24,0x28,0xc5,0xfa,0x7f,0x84,0x24,0xb8,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x44,0x24,0x38,0xc5,0xfa,0x7f,0x84,0x24,0xc8,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x44,0x24,0x08,0xc5,0xfa,0x7f,0x84,0x24,0xd8,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x44,0x24,0x18,0xc5,0xfa,0x7f,0x84,0x24,0xe8,0x00,0x00,0x00,0x48,0x8b,0xce,0x48,0x8d,0x54,0x24,0x78,0x41,0xb8,0x80,0x00,0x00,0x00,0xe8,0x9f,0x1f,0xc7,0x5e,0x48,0x8b,0xc6,0x48,0x81,0xc4,0xf8,0x00,0x00,0x00,0x5e,0x5f,0xc3};
; BaseAddress = 7ffa9bf54b70h
; TermCode = CTC_RET_INTR
0000h push rdi                                      ; PUSH r64                         | 50 +ro                           | 1   | 57
0001h push rsi                                      ; PUSH r64                         | 50 +ro                           | 1   | 56
0002h sub rsp,0f8h                                  ; SUB r/m64, imm32                 | REX.W 81 /5 id                   | 7   | 48 81 ec f8 00 00 00
0009h vzeroupper                                    ; VZEROUPPER                       | VEX.128.0F.WIG 77                | 3   | c5 f8 77
000ch mov rsi,rcx                                   ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b f1
000fh lea rdi,[rsp+78h]                             ; LEA r64, m                       | REX.W 8D /r                      | 5   | 48 8d 7c 24 78
0014h mov ecx,20h                                   ; MOV r32, imm32                   | B8 +rd id                        | 5   | b9 20 00 00 00
0019h xor eax,eax                                   ; XOR r32, r/m32                   | 33 /r                            | 2   | 33 c0
001bh rep stosd                                     ; STOSD                            | AB                               | 2   | f3 ab
001dh mov rcx,rsi                                   ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b ce
0020h mov rsi,rcx                                   ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b f1
0023h mov rcx,[rsp+130h]                            ; MOV r64, r/m64                   | REX.W 8B /r                      | 8   | 48 8b 8c 24 30 01 00 00
002bh lea rax,[rsp+78h]                             ; LEA r64, m                       | REX.W 8D /r                      | 5   | 48 8d 44 24 78
0030h vxorps xmm0,xmm0,xmm0                         ; VXORPS xmm1, xmm2, xmm3/m128     | VEX.128.0F.WIG 57 /r             | 4   | c5 f8 57 c0
0034h vmovdqu xmmword ptr [rax],xmm0                ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 4   | c5 fa 7f 00
0038h vmovdqu xmmword ptr [rax+10h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 5   | c5 fa 7f 40 10
003dh vmovdqu xmmword ptr [rax+20h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 5   | c5 fa 7f 40 20
0042h vmovdqu xmmword ptr [rax+30h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 5   | c5 fa 7f 40 30
0047h vmovdqu xmmword ptr [rax+40h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 5   | c5 fa 7f 40 40
004ch vmovdqu xmmword ptr [rax+50h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 5   | c5 fa 7f 40 50
0051h vmovdqu xmmword ptr [rax+60h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 5   | c5 fa 7f 40 60
0056h vmovdqu xmmword ptr [rax+70h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 5   | c5 fa 7f 40 70
005bh vmovdqu xmm0,xmmword ptr [rdx]                ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 4   | c5 fa 6f 02
005fh vmovdqu xmmword ptr [rsp+68h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 6   | c5 fa 7f 44 24 68
0065h vmovdqu xmm0,xmmword ptr [r8]                 ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 5   | c4 c1 7a 6f 00
006ah vmovdqu xmmword ptr [rsp+48h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 6   | c5 fa 7f 44 24 48
0070h vmovdqu xmm0,xmmword ptr [r8+10h]             ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 6   | c4 c1 7a 6f 40 10
0076h vmovdqu xmmword ptr [rsp+58h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 6   | c5 fa 7f 44 24 58
007ch vmovdqu xmm0,xmmword ptr [r9]                 ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 5   | c4 c1 7a 6f 01
0081h vmovdqu xmmword ptr [rsp+28h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 6   | c5 fa 7f 44 24 28
0087h vmovdqu xmm0,xmmword ptr [r9+10h]             ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 6   | c4 c1 7a 6f 41 10
008dh vmovdqu xmmword ptr [rsp+38h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 6   | c5 fa 7f 44 24 38
0093h vmovdqu xmm0,xmmword ptr [rcx]                ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 4   | c5 fa 6f 01
0097h vmovdqu xmmword ptr [rsp+8],xmm0              ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 6   | c5 fa 7f 44 24 08
009dh vmovdqu xmm0,xmmword ptr [rcx+10h]            ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 5   | c5 fa 6f 41 10
00a2h vmovdqu xmmword ptr [rsp+18h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 6   | c5 fa 7f 44 24 18
00a8h vmovdqu xmm0,xmmword ptr [rsp+68h]            ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 6   | c5 fa 6f 44 24 68
00aeh vmovdqu xmmword ptr [rsp+78h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 6   | c5 fa 7f 44 24 78
00b4h vmovdqu xmm0,xmmword ptr [rsp+48h]            ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 6   | c5 fa 6f 44 24 48
00bah vmovdqu xmmword ptr [rsp+98h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 9   | c5 fa 7f 84 24 98 00 00 00
00c3h vmovdqu xmm0,xmmword ptr [rsp+58h]            ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 6   | c5 fa 6f 44 24 58
00c9h vmovdqu xmmword ptr [rsp+0a8h],xmm0           ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 9   | c5 fa 7f 84 24 a8 00 00 00
00d2h vmovdqu xmm0,xmmword ptr [rsp+28h]            ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 6   | c5 fa 6f 44 24 28
00d8h vmovdqu xmmword ptr [rsp+0b8h],xmm0           ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 9   | c5 fa 7f 84 24 b8 00 00 00
00e1h vmovdqu xmm0,xmmword ptr [rsp+38h]            ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 6   | c5 fa 6f 44 24 38
00e7h vmovdqu xmmword ptr [rsp+0c8h],xmm0           ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 9   | c5 fa 7f 84 24 c8 00 00 00
00f0h vmovdqu xmm0,xmmword ptr [rsp+8]              ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 6   | c5 fa 6f 44 24 08
00f6h vmovdqu xmmword ptr [rsp+0d8h],xmm0           ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 9   | c5 fa 7f 84 24 d8 00 00 00
00ffh vmovdqu xmm0,xmmword ptr [rsp+18h]            ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 6   | c5 fa 6f 44 24 18
0105h vmovdqu xmmword ptr [rsp+0e8h],xmm0           ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 9   | c5 fa 7f 84 24 e8 00 00 00
010eh mov rcx,rsi                                   ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b ce
0111h lea rdx,[rsp+78h]                             ; LEA r64, m                       | REX.W 8D /r                      | 5   | 48 8d 54 24 78
0116h mov r8d,80h                                   ; MOV r32, imm32                   | B8 +rd id                        | 6   | 41 b8 80 00 00 00
011ch call 7ffafabc6c30h                            ; CALL rel32                       | E8 cd                            | 5   | e8 9f 1f c7 5e
0121h mov rax,rsi                                   ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b c6
0124h add rsp,0f8h                                  ; ADD r/m64, imm32                 | REX.W 81 /0 id                   | 7   | 48 81 c4 f8 00 00 00
012bh pop rsi                                       ; POP r64                          | 58 +ro                           | 1   | 5e
012ch pop rdi                                       ; POP r64                          | 58 +ro                           | 1   | 5f
012dh ret                                           ; RET                              | C3                               | 1   | c3

; ----------------------------------------------------------------------------------------------------------------------------------------------------------------
; CalcResult<Cell256,Cell256,Cell256> from(ApiKey api, in Cell256 a0, in Cell256 a1, in Cell256 value)::located://calc/calcresults?from#from_(ApiKey,Cell256~in,Cell256~in,Cell256~in)
; public static ReadOnlySpan<byte> from_ᐤApiKeyㆍCell256ᕀinㆍCell256ᕀinㆍCell256ᕀinᐤ => new byte[245]{0x57,0x56,0x48,0x81,0xec,0xb8,0x00,0x00,0x00,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x38,0xb9,0x20,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xf1,0x48,0x8d,0x4c,0x24,0x38,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0xc5,0xfa,0x7f,0x41,0x10,0xc5,0xfa,0x7f,0x41,0x20,0xc5,0xfa,0x7f,0x41,0x30,0xc5,0xfa,0x7f,0x41,0x40,0xc5,0xfa,0x7f,0x41,0x50,0xc5,0xfa,0x7f,0x41,0x60,0xc5,0xfa,0x7f,0x41,0x70,0xc5,0xfa,0x6f,0x02,0xc5,0xfa,0x7f,0x44,0x24,0x28,0xc5,0xfa,0x6f,0x44,0x24,0x28,0xc5,0xfa,0x7f,0x44,0x24,0x38,0xc4,0xc1,0x7a,0x6f,0x00,0xc5,0xfa,0x7f,0x44,0x24,0x58,0xc4,0xc1,0x7a,0x6f,0x40,0x10,0xc5,0xfa,0x7f,0x44,0x24,0x68,0xc4,0xc1,0x7a,0x6f,0x01,0xc5,0xfa,0x7f,0x44,0x24,0x78,0xc4,0xc1,0x7a,0x6f,0x41,0x10,0xc5,0xfa,0x7f,0x84,0x24,0x88,0x00,0x00,0x00,0x48,0x8b,0x94,0x24,0xf0,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x02,0xc5,0xfa,0x7f,0x44,0x24,0x08,0xc5,0xfa,0x6f,0x42,0x10,0xc5,0xfa,0x7f,0x44,0x24,0x18,0xc5,0xfa,0x6f,0x44,0x24,0x08,0xc5,0xfa,0x7f,0x84,0x24,0x98,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x44,0x24,0x18,0xc5,0xfa,0x7f,0x84,0x24,0xa8,0x00,0x00,0x00,0x48,0x8b,0xce,0x48,0x8d,0x54,0x24,0x38,0x41,0xb8,0x80,0x00,0x00,0x00,0xe8,0xd8,0x1f,0xca,0x5e,0x48,0x8b,0xc6,0x48,0x81,0xc4,0xb8,0x00,0x00,0x00,0x5e,0x5f,0xc3};
; BaseAddress = 7ffa9bf24b70h
; TermCode = CTC_RET_INTR
0000h push rdi                                      ; PUSH r64                         | 50 +ro                           | 1   | 57
0001h push rsi                                      ; PUSH r64                         | 50 +ro                           | 1   | 56
0002h sub rsp,0b8h                                  ; SUB r/m64, imm32                 | REX.W 81 /5 id                   | 7   | 48 81 ec b8 00 00 00
0009h vzeroupper                                    ; VZEROUPPER                       | VEX.128.0F.WIG 77                | 3   | c5 f8 77
000ch mov rsi,rcx                                   ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b f1
000fh lea rdi,[rsp+38h]                             ; LEA r64, m                       | REX.W 8D /r                      | 5   | 48 8d 7c 24 38
0014h mov ecx,20h                                   ; MOV r32, imm32                   | B8 +rd id                        | 5   | b9 20 00 00 00
0019h xor eax,eax                                   ; XOR r32, r/m32                   | 33 /r                            | 2   | 33 c0
001bh rep stosd                                     ; STOSD                            | AB                               | 2   | f3 ab
001dh mov rcx,rsi                                   ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b ce
0020h mov rsi,rcx                                   ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b f1
0023h lea rcx,[rsp+38h]                             ; LEA r64, m                       | REX.W 8D /r                      | 5   | 48 8d 4c 24 38
0028h vxorps xmm0,xmm0,xmm0                         ; VXORPS xmm1, xmm2, xmm3/m128     | VEX.128.0F.WIG 57 /r             | 4   | c5 f8 57 c0
002ch vmovdqu xmmword ptr [rcx],xmm0                ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 4   | c5 fa 7f 01
0030h vmovdqu xmmword ptr [rcx+10h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 5   | c5 fa 7f 41 10
0035h vmovdqu xmmword ptr [rcx+20h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 5   | c5 fa 7f 41 20
003ah vmovdqu xmmword ptr [rcx+30h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 5   | c5 fa 7f 41 30
003fh vmovdqu xmmword ptr [rcx+40h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 5   | c5 fa 7f 41 40
0044h vmovdqu xmmword ptr [rcx+50h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 5   | c5 fa 7f 41 50
0049h vmovdqu xmmword ptr [rcx+60h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 5   | c5 fa 7f 41 60
004eh vmovdqu xmmword ptr [rcx+70h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 5   | c5 fa 7f 41 70
0053h vmovdqu xmm0,xmmword ptr [rdx]                ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 4   | c5 fa 6f 02
0057h vmovdqu xmmword ptr [rsp+28h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 6   | c5 fa 7f 44 24 28
005dh vmovdqu xmm0,xmmword ptr [rsp+28h]            ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 6   | c5 fa 6f 44 24 28
0063h vmovdqu xmmword ptr [rsp+38h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 6   | c5 fa 7f 44 24 38
0069h vmovdqu xmm0,xmmword ptr [r8]                 ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 5   | c4 c1 7a 6f 00
006eh vmovdqu xmmword ptr [rsp+58h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 6   | c5 fa 7f 44 24 58
0074h vmovdqu xmm0,xmmword ptr [r8+10h]             ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 6   | c4 c1 7a 6f 40 10
007ah vmovdqu xmmword ptr [rsp+68h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 6   | c5 fa 7f 44 24 68
0080h vmovdqu xmm0,xmmword ptr [r9]                 ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 5   | c4 c1 7a 6f 01
0085h vmovdqu xmmword ptr [rsp+78h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 6   | c5 fa 7f 44 24 78
008bh vmovdqu xmm0,xmmword ptr [r9+10h]             ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 6   | c4 c1 7a 6f 41 10
0091h vmovdqu xmmword ptr [rsp+88h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 9   | c5 fa 7f 84 24 88 00 00 00
009ah mov rdx,[rsp+0f0h]                            ; MOV r64, r/m64                   | REX.W 8B /r                      | 8   | 48 8b 94 24 f0 00 00 00
00a2h vmovdqu xmm0,xmmword ptr [rdx]                ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 4   | c5 fa 6f 02
00a6h vmovdqu xmmword ptr [rsp+8],xmm0              ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 6   | c5 fa 7f 44 24 08
00ach vmovdqu xmm0,xmmword ptr [rdx+10h]            ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 5   | c5 fa 6f 42 10
00b1h vmovdqu xmmword ptr [rsp+18h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 6   | c5 fa 7f 44 24 18
00b7h vmovdqu xmm0,xmmword ptr [rsp+8]              ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 6   | c5 fa 6f 44 24 08
00bdh vmovdqu xmmword ptr [rsp+98h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 9   | c5 fa 7f 84 24 98 00 00 00
00c6h vmovdqu xmm0,xmmword ptr [rsp+18h]            ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 6   | c5 fa 6f 44 24 18
00cch vmovdqu xmmword ptr [rsp+0a8h],xmm0           ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 9   | c5 fa 7f 84 24 a8 00 00 00
00d5h mov rcx,rsi                                   ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b ce
00d8h lea rdx,[rsp+38h]                             ; LEA r64, m                       | REX.W 8D /r                      | 5   | 48 8d 54 24 38
00ddh mov r8d,80h                                   ; MOV r32, imm32                   | B8 +rd id                        | 6   | 41 b8 80 00 00 00
00e3h call 7ffafabc6c30h                            ; CALL rel32                       | E8 cd                            | 5   | e8 d8 1f ca 5e
00e8h mov rax,rsi                                   ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b c6
00ebh add rsp,0b8h                                  ; ADD r/m64, imm32                 | REX.W 81 /0 id                   | 7   | 48 81 c4 b8 00 00 00
00f2h pop rsi                                       ; POP r64                          | 58 +ro                           | 1   | 5e
00f3h pop rdi                                       ; POP r64                          | 58 +ro                           | 1   | 5f
00f4h ret                                           ; RET                              | C3                               | 1   | c3
; ----------------------------------------------------------------------------------------------------------------------------------------------------------------
; CalcResult<Cell256,Cell256,Cell256> from(ApiKey api, in Triple<Cell256> src)::located://calc/calcresults?from#from_(ApiKey,Triple[Cell256]~in)
; public static ReadOnlySpan<byte> from_ᐤApiKeyㆍTripleᐸCell256ᐳᕀinᐤ => new byte[246]{0x57,0x56,0x48,0x81,0xec,0xb8,0x00,0x00,0x00,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x38,0xb9,0x20,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0x48,0x8b,0xf1,0x48,0x8d,0x4c,0x24,0x38,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0xc5,0xfa,0x7f,0x41,0x10,0xc5,0xfa,0x7f,0x41,0x20,0xc5,0xfa,0x7f,0x41,0x30,0xc5,0xfa,0x7f,0x41,0x40,0xc5,0xfa,0x7f,0x41,0x50,0xc5,0xfa,0x7f,0x41,0x60,0xc5,0xfa,0x7f,0x41,0x70,0xc5,0xfa,0x6f,0x02,0xc5,0xfa,0x7f,0x44,0x24,0x28,0x45,0x39,0x00,0x49,0x8d,0x50,0x20,0x49,0x8d,0x48,0x40,0xc5,0xfa,0x6f,0x44,0x24,0x28,0xc5,0xfa,0x7f,0x44,0x24,0x38,0xc4,0xc1,0x7a,0x6f,0x00,0xc5,0xfa,0x7f,0x44,0x24,0x58,0xc4,0xc1,0x7a,0x6f,0x40,0x10,0xc5,0xfa,0x7f,0x44,0x24,0x68,0xc5,0xfa,0x6f,0x02,0xc5,0xfa,0x7f,0x44,0x24,0x78,0xc5,0xfa,0x6f,0x42,0x10,0xc5,0xfa,0x7f,0x84,0x24,0x88,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x01,0xc5,0xfa,0x7f,0x44,0x24,0x08,0xc5,0xfa,0x6f,0x41,0x10,0xc5,0xfa,0x7f,0x44,0x24,0x18,0xc5,0xfa,0x6f,0x44,0x24,0x08,0xc5,0xfa,0x7f,0x84,0x24,0x98,0x00,0x00,0x00,0xc5,0xfa,0x6f,0x44,0x24,0x18,0xc5,0xfa,0x7f,0x84,0x24,0xa8,0x00,0x00,0x00,0x48,0x8b,0xce,0x48,0x8d,0x54,0x24,0x38,0x41,0xb8,0x80,0x00,0x00,0x00,0xe8,0xd7,0x1f,0xc9,0x5e,0x48,0x8b,0xc6,0x48,0x81,0xc4,0xb8,0x00,0x00,0x00,0x5e,0x5f,0xc3};
; BaseAddress = 7ffa9bf34b70h
; TermCode = CTC_RET_INTR
0000h push rdi                                      ; PUSH r64                         | 50 +ro                           | 1   | 57
0001h push rsi                                      ; PUSH r64                         | 50 +ro                           | 1   | 56
0002h sub rsp,0b8h                                  ; SUB r/m64, imm32                 | REX.W 81 /5 id                   | 7   | 48 81 ec b8 00 00 00
0009h vzeroupper                                    ; VZEROUPPER                       | VEX.128.0F.WIG 77                | 3   | c5 f8 77
000ch mov rsi,rcx                                   ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b f1
000fh lea rdi,[rsp+38h]                             ; LEA r64, m                       | REX.W 8D /r                      | 5   | 48 8d 7c 24 38
0014h mov ecx,20h                                   ; MOV r32, imm32                   | B8 +rd id                        | 5   | b9 20 00 00 00
0019h xor eax,eax                                   ; XOR r32, r/m32                   | 33 /r                            | 2   | 33 c0
001bh rep stosd                                     ; STOSD                            | AB                               | 2   | f3 ab
001dh mov rcx,rsi                                   ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b ce
0020h mov rsi,rcx                                   ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b f1
0023h lea rcx,[rsp+38h]                             ; LEA r64, m                       | REX.W 8D /r                      | 5   | 48 8d 4c 24 38
0028h vxorps xmm0,xmm0,xmm0                         ; VXORPS xmm1, xmm2, xmm3/m128     | VEX.128.0F.WIG 57 /r             | 4   | c5 f8 57 c0
002ch vmovdqu xmmword ptr [rcx],xmm0                ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 4   | c5 fa 7f 01
0030h vmovdqu xmmword ptr [rcx+10h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 5   | c5 fa 7f 41 10
0035h vmovdqu xmmword ptr [rcx+20h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 5   | c5 fa 7f 41 20
003ah vmovdqu xmmword ptr [rcx+30h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 5   | c5 fa 7f 41 30
003fh vmovdqu xmmword ptr [rcx+40h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 5   | c5 fa 7f 41 40
0044h vmovdqu xmmword ptr [rcx+50h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 5   | c5 fa 7f 41 50
0049h vmovdqu xmmword ptr [rcx+60h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 5   | c5 fa 7f 41 60
004eh vmovdqu xmmword ptr [rcx+70h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 5   | c5 fa 7f 41 70
0053h vmovdqu xmm0,xmmword ptr [rdx]                ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 4   | c5 fa 6f 02
0057h vmovdqu xmmword ptr [rsp+28h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 6   | c5 fa 7f 44 24 28
005dh cmp [r8],r8d                                  ; CMP r/m32, r32                   | 39 /r                            | 3   | 45 39 00
0060h lea rdx,[r8+20h]                              ; LEA r64, m                       | REX.W 8D /r                      | 4   | 49 8d 50 20
0064h lea rcx,[r8+40h]                              ; LEA r64, m                       | REX.W 8D /r                      | 4   | 49 8d 48 40
0068h vmovdqu xmm0,xmmword ptr [rsp+28h]            ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 6   | c5 fa 6f 44 24 28
006eh vmovdqu xmmword ptr [rsp+38h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 6   | c5 fa 7f 44 24 38
0074h vmovdqu xmm0,xmmword ptr [r8]                 ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 5   | c4 c1 7a 6f 00
0079h vmovdqu xmmword ptr [rsp+58h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 6   | c5 fa 7f 44 24 58
007fh vmovdqu xmm0,xmmword ptr [r8+10h]             ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 6   | c4 c1 7a 6f 40 10
0085h vmovdqu xmmword ptr [rsp+68h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 6   | c5 fa 7f 44 24 68
008bh vmovdqu xmm0,xmmword ptr [rdx]                ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 4   | c5 fa 6f 02
008fh vmovdqu xmmword ptr [rsp+78h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 6   | c5 fa 7f 44 24 78
0095h vmovdqu xmm0,xmmword ptr [rdx+10h]            ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 5   | c5 fa 6f 42 10
009ah vmovdqu xmmword ptr [rsp+88h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 9   | c5 fa 7f 84 24 88 00 00 00
00a3h vmovdqu xmm0,xmmword ptr [rcx]                ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 4   | c5 fa 6f 01
00a7h vmovdqu xmmword ptr [rsp+8],xmm0              ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 6   | c5 fa 7f 44 24 08
00adh vmovdqu xmm0,xmmword ptr [rcx+10h]            ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 5   | c5 fa 6f 41 10
00b2h vmovdqu xmmword ptr [rsp+18h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 6   | c5 fa 7f 44 24 18
00b8h vmovdqu xmm0,xmmword ptr [rsp+8]              ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 6   | c5 fa 6f 44 24 08
00beh vmovdqu xmmword ptr [rsp+98h],xmm0            ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 9   | c5 fa 7f 84 24 98 00 00 00
00c7h vmovdqu xmm0,xmmword ptr [rsp+18h]            ; VMOVDQU xmm1, xmm2/m128          | VEX.128.F3.0F.WIG 6F /r          | 6   | c5 fa 6f 44 24 18
00cdh vmovdqu xmmword ptr [rsp+0a8h],xmm0           ; VMOVDQU xmm2/m128, xmm1          | VEX.128.F3.0F.WIG 7F /r          | 9   | c5 fa 7f 84 24 a8 00 00 00
00d6h mov rcx,rsi                                   ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b ce
00d9h lea rdx,[rsp+38h]                             ; LEA r64, m                       | REX.W 8D /r                      | 5   | 48 8d 54 24 38
00deh mov r8d,80h                                   ; MOV r32, imm32                   | B8 +rd id                        | 6   | 41 b8 80 00 00 00
00e4h call 7ffafabc6c30h                            ; CALL rel32                       | E8 cd                            | 5   | e8 d7 1f c9 5e
00e9h mov rax,rsi                                   ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b c6
00ech add rsp,0b8h                                  ; ADD r/m64, imm32                 | REX.W 81 /0 id                   | 7   | 48 81 c4 b8 00 00 00
00f3h pop rsi                                       ; POP r64                          | 58 +ro                           | 1   | 5e
00f4h pop rdi                                       ; POP r64                          | 58 +ro                           | 1   | 5f
00f5h ret                                           ; RET                              | C3                               | 1   | c3
