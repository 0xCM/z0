# JA rel8
------------------------------------------------------------------------------------------------------------------------
; uint clamp<uint>(uint a, uint b), located://gmath/api?clamp#clamp_g[32u](32u,32u)
; public static ReadOnlySpan<byte> clamp_gᐸ32uᐳᐤ32uㆍ32uᐤ => new byte[16]{0x0f,0x1f,0x44,0x00,0x00,0x3b,0xca,0x77,0x04,0x8b,0xc1,0xeb,0x02,0x8b,0xc2,0xc3};
; Base = 7ff9af227ea0h
; TermCode = CTC_RET_SBB
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h cmp ecx,edx                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b ca}
0007h ja short 000dh                          ; JA rel8 || 77 cb || encoded[2]{77 04}
0009h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
000bh jmp short 000fh                         ; JMP rel8 || EB cb || encoded[2]{eb 02}
000dh mov eax,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c2}
000fh ret                                     ; RET || C3 || encoded[1]{c3}

# JA rel32
------------------------------------------------------------------------------------------------------------------------
; bool fcmp(double x, double y, FpCmpMode:byte mode), located://math/fmath?fcmp#fcmp_(64f,64f,FpCmpMode~8u)
; public static ReadOnlySpan<byte> fcmp_ᐤ64fㆍ64fㆍFpCmpModeᕀ8uᐤ => new byte[453]{0x56,0x48,0x83,0xec,0x20,0xc5,0xf8,0x77,0x41,0x0f,0xb6,0xc0,0x83,0xf8,0x1e,0x0f,0x87,0x8e,0x01,0x00,0x00,0x8b,0xc0,0x48,0x8d,0x0d,0xc2,0x01,0x00,0x00,0x8b,0x0c,0x81,0x48,0x8d,0x15,0xe0,0xff,0xff,0xff,0x48,0x03,0xca,0xff,0xe1,0xc5,0xf9,0x2e,0xc1,0x0f,0x9b,0xc0,0x7a,0x03,0x0f,0x94,0xc0,0x0f,0xb6,0xc0,0xe9,0x5c,0x01,0x00,0x00,0xc5,0xf9,0x2e,0xc1,0x0f,0x9b,0xc0,0x7a,0x03,0x0f,0x94,0xc0,0x0f,0xb6,0xc0,0xe9,0x48,0x01,0x00,0x00,0xc5,0xf9,0x2e,0xc1,0x0f,0x9b,0xc0,0x7a,0x03,0x0f,0x94,0xc0,0x0f,0xb6,0xc0,0xe9,0x34,0x01,0x00,0x00,0xc5,0xf9,0x2e,0xc1,0x0f,0x9b,0xc0,0x7a,0x03,0x0f,0x94,0xc0,0x0f,0xb6,0xc0,0xe9,0x20,0x01,0x00,0x00,0xc5,0xf9,0x2e,0xc1,0x0f,0x9a,0xc0,0x7a,0x03,0x0f,0x95,0xc0,0x0f,0xb6,0xc0,0xe9,0x0c,0x01,0x00,0x00,0xc5,0xf9,0x2e,0xc1,0x0f,0x9a,0xc0,0x7a,0x03,0x0f,0x95,0xc0,0x0f,0xb6,0xc0,0xe9,0xf8,0x00,0x00,0x00,0xc5,0xf9,0x2e,0xc1,0x0f,0x9a,0xc0,0x7a,0x03,0x0f,0x95,0xc0,0x0f,0xb6,0xc0,0xe9,0xe4,0x00,0x00,0x00,0xc5,0xf9,0x2e,0xc1,0x0f,0x9a,0xc0,0x7a,0x03,0x0f,0x95,0xc0,0x0f,0xb6,0xc0,0xe9,0xd0,0x00,0x00,0x00,0xc5,0xf9,0x2e,0xc8,0x0f,0x97,0xc0,0x0f,0xb6,0xc0,0xe9,0xc1,0x00,0x00,0x00,0xc5,0xf9,0x2e,0xc8,0x0f,0x97,0xc0,0x0f,0xb6,0xc0,0xe9,0xb2,0x00,0x00,0x00,0xc5,0xf9,0x2e,0xc1,0x0f,0x97,0xc0,0x0f,0xb6,0xc0,0xe9,0xa3,0x00,0x00,0x00,0xc5,0xf9,0x2e,0xc1,0x0f,0x97,0xc0,0x0f,0xb6,0xc0,0xe9,0x94,0x00,0x00,0x00,0xc5,0xf9,0x2e,0xc8,0x0f,0x93,0xc0,0x0f,0xb6,0xc0,0xe9,0x85,0x00,0x00,0x00,0xc5,0xf9,0x2e,0xc8,0x0f,0x93,0xc0,0x0f,0xb6,0xc0,0xe9,0x76,0x00,0x00,0x00,0xc5,0xf9,0x2e,0xc1,0x0f,0x93,0xc0,0x0f,0xb6,0xc0,0xeb,0x6a,0xc5,0xf9,0x2e,0xc1,0x0f,0x93,0xc0,0x0f,0xb6,0xc0,0xeb,0x5e,0xc5,0xf9,0x2e,0xc1,0x0f,0x92,0xc0,0x0f,0xb6,0xc0,0xeb,0x52,0xc5,0xf9,0x2e,0xc1,0x0f,0x92,0xc0,0x0f,0xb6,0xc0,0xeb,0x46,0xc5,0xf9,0x2e,0xc1,0x0f,0x96,0xc0,0x0f,0xb6,0xc0,0xeb,0x3a,0xc5,0xf9,0x2e,0xc1,0x0f,0x96,0xc0,0x0f,0xb6,0xc0,0xeb,0x2e,0xc5,0xf9,0x2e,0xc8,0x0f,0x92,0xc0,0x0f,0xb6,0xc0,0xeb,0x22,0xc5,0xf9,0x2e,0xc8,0x0f,0x92,0xc0,0x0f,0xb6,0xc0,0xeb,0x16,0xc5,0xf9,0x2e,0xc8,0x0f,0x96,0xc0,0x0f,0xb6,0xc0,0xeb,0x0a,0xc5,0xf9,0x2e,0xc8,0x0f,0x96,0xc0,0x0f,0xb6,0xc0,0x48,0x83,0xc4,0x20,0x5e,0xc3,0x48,0xb9,0x18,0x71,0x2b,0xad,0xf9,0x7f,0x00,0x00,0xe8,0xde,0x86,0x93,0x5d,0x48,0x8b,0xf0,0x48,0x8b,0xce,0xe8,0x03,0x79,0xe2,0xfd,0x48,0x8b,0xce,0xe8,0x5b,0xc3,0x8f,0x5d};
; Base = 7ff9af2fee80h
; TermCode = CTC_INTRx2
0000h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0001h sub rsp,20h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 20}
0005h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0008h movzx eax,r8b                           ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{41 0f b6 c0}
000ch cmp eax,1eh                             ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 f8 1e}
000fh ja near ptr 01a3h                       ; JA rel32 || 0F 87 cd || encoded[6]{0f 87 8e 01 00 00}
0015h mov eax,eax                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c0}
0017h lea rcx,[rip+1c2h]                      ; LEA r64, m || REX.W 8D /r || encoded[7]{48 8d 0d c2 01 00 00}
001eh mov ecx,[rcx+rax*4]                     ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 0c 81}
0021h lea rdx,[rip-20h]                       ; LEA r64, m || REX.W 8D /r || encoded[7]{48 8d 15 e0 ff ff ff}
0028h add rcx,rdx                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{48 03 ca}
002bh jmp rcx                                 ; JMP r/m64 || FF /4 || encoded[2]{ff e1}
002dh vucomisd xmm0,xmm1                      ; VUCOMISD xmm1, xmm2/m64 || VEX.LIG.66.0F.WIG 2E /r || encoded[4]{c5 f9 2e c1}
0031h setnp al                                ; SETNP r/m8 || 0F 9B /r || encoded[3]{0f 9b c0}
0034h jp short 0039h                          ; JP rel8 || 7A cb || encoded[2]{7a 03}
0036h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0039h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
003ch jmp near ptr 019dh                      ; JMP rel32 || E9 cd || encoded[5]{e9 5c 01 00 00}
0041h vucomisd xmm0,xmm1                      ; VUCOMISD xmm1, xmm2/m64 || VEX.LIG.66.0F.WIG 2E /r || encoded[4]{c5 f9 2e c1}
0045h setnp al                                ; SETNP r/m8 || 0F 9B /r || encoded[3]{0f 9b c0}
0048h jp short 004dh                          ; JP rel8 || 7A cb || encoded[2]{7a 03}
004ah sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
004dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0050h jmp near ptr 019dh                      ; JMP rel32 || E9 cd || encoded[5]{e9 48 01 00 00}
0055h vucomisd xmm0,xmm1                      ; VUCOMISD xmm1, xmm2/m64 || VEX.LIG.66.0F.WIG 2E /r || encoded[4]{c5 f9 2e c1}
0059h setnp al                                ; SETNP r/m8 || 0F 9B /r || encoded[3]{0f 9b c0}
005ch jp short 0061h                          ; JP rel8 || 7A cb || encoded[2]{7a 03}
005eh sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0061h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0064h jmp near ptr 019dh                      ; JMP rel32 || E9 cd || encoded[5]{e9 34 01 00 00}
0069h vucomisd xmm0,xmm1                      ; VUCOMISD xmm1, xmm2/m64 || VEX.LIG.66.0F.WIG 2E /r || encoded[4]{c5 f9 2e c1}
006dh setnp al                                ; SETNP r/m8 || 0F 9B /r || encoded[3]{0f 9b c0}
0070h jp short 0075h                          ; JP rel8 || 7A cb || encoded[2]{7a 03}
0072h sete al                                 ; SETE r/m8 || 0F 94 /r || encoded[3]{0f 94 c0}
0075h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0078h jmp near ptr 019dh                      ; JMP rel32 || E9 cd || encoded[5]{e9 20 01 00 00}
007dh vucomisd xmm0,xmm1                      ; VUCOMISD xmm1, xmm2/m64 || VEX.LIG.66.0F.WIG 2E /r || encoded[4]{c5 f9 2e c1}
0081h setp al                                 ; SETP r/m8 || 0F 9A /r || encoded[3]{0f 9a c0}
0084h jp short 0089h                          ; JP rel8 || 7A cb || encoded[2]{7a 03}
0086h setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
0089h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
008ch jmp near ptr 019dh                      ; JMP rel32 || E9 cd || encoded[5]{e9 0c 01 00 00}
0091h vucomisd xmm0,xmm1                      ; VUCOMISD xmm1, xmm2/m64 || VEX.LIG.66.0F.WIG 2E /r || encoded[4]{c5 f9 2e c1}
0095h setp al                                 ; SETP r/m8 || 0F 9A /r || encoded[3]{0f 9a c0}
0098h jp short 009dh                          ; JP rel8 || 7A cb || encoded[2]{7a 03}
009ah setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
009dh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
00a0h jmp near ptr 019dh                      ; JMP rel32 || E9 cd || encoded[5]{e9 f8 00 00 00}
00a5h vucomisd xmm0,xmm1                      ; VUCOMISD xmm1, xmm2/m64 || VEX.LIG.66.0F.WIG 2E /r || encoded[4]{c5 f9 2e c1}
00a9h setp al                                 ; SETP r/m8 || 0F 9A /r || encoded[3]{0f 9a c0}
00ach jp short 00b1h                          ; JP rel8 || 7A cb || encoded[2]{7a 03}
00aeh setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
00b1h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
00b4h jmp near ptr 019dh                      ; JMP rel32 || E9 cd || encoded[5]{e9 e4 00 00 00}
00b9h vucomisd xmm0,xmm1                      ; VUCOMISD xmm1, xmm2/m64 || VEX.LIG.66.0F.WIG 2E /r || encoded[4]{c5 f9 2e c1}
00bdh setp al                                 ; SETP r/m8 || 0F 9A /r || encoded[3]{0f 9a c0}
00c0h jp short 00c5h                          ; JP rel8 || 7A cb || encoded[2]{7a 03}
00c2h setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
00c5h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
00c8h jmp near ptr 019dh                      ; JMP rel32 || E9 cd || encoded[5]{e9 d0 00 00 00}
00cdh vucomisd xmm1,xmm0                      ; VUCOMISD xmm1, xmm2/m64 || VEX.LIG.66.0F.WIG 2E /r || encoded[4]{c5 f9 2e c8}
00d1h seta al                                 ; SETA r/m8 || 0F 97 /r || encoded[3]{0f 97 c0}
00d4h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
00d7h jmp near ptr 019dh                      ; JMP rel32 || E9 cd || encoded[5]{e9 c1 00 00 00}
00dch vucomisd xmm1,xmm0                      ; VUCOMISD xmm1, xmm2/m64 || VEX.LIG.66.0F.WIG 2E /r || encoded[4]{c5 f9 2e c8}
00e0h seta al                                 ; SETA r/m8 || 0F 97 /r || encoded[3]{0f 97 c0}
00e3h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
00e6h jmp near ptr 019dh                      ; JMP rel32 || E9 cd || encoded[5]{e9 b2 00 00 00}
00ebh vucomisd xmm0,xmm1                      ; VUCOMISD xmm1, xmm2/m64 || VEX.LIG.66.0F.WIG 2E /r || encoded[4]{c5 f9 2e c1}
00efh seta al                                 ; SETA r/m8 || 0F 97 /r || encoded[3]{0f 97 c0}
00f2h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
00f5h jmp near ptr 019dh                      ; JMP rel32 || E9 cd || encoded[5]{e9 a3 00 00 00}
00fah vucomisd xmm0,xmm1                      ; VUCOMISD xmm1, xmm2/m64 || VEX.LIG.66.0F.WIG 2E /r || encoded[4]{c5 f9 2e c1}
00feh seta al                                 ; SETA r/m8 || 0F 97 /r || encoded[3]{0f 97 c0}
0101h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0104h jmp near ptr 019dh                      ; JMP rel32 || E9 cd || encoded[5]{e9 94 00 00 00}
0109h vucomisd xmm1,xmm0                      ; VUCOMISD xmm1, xmm2/m64 || VEX.LIG.66.0F.WIG 2E /r || encoded[4]{c5 f9 2e c8}
010dh setae al                                ; SETAE r/m8 || 0F 93 /r || encoded[3]{0f 93 c0}
0110h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0113h jmp near ptr 019dh                      ; JMP rel32 || E9 cd || encoded[5]{e9 85 00 00 00}
0118h vucomisd xmm1,xmm0                      ; VUCOMISD xmm1, xmm2/m64 || VEX.LIG.66.0F.WIG 2E /r || encoded[4]{c5 f9 2e c8}
011ch setae al                                ; SETAE r/m8 || 0F 93 /r || encoded[3]{0f 93 c0}
011fh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0122h jmp near ptr 019dh                      ; JMP rel32 || E9 cd || encoded[5]{e9 76 00 00 00}
0127h vucomisd xmm0,xmm1                      ; VUCOMISD xmm1, xmm2/m64 || VEX.LIG.66.0F.WIG 2E /r || encoded[4]{c5 f9 2e c1}
012bh setae al                                ; SETAE r/m8 || 0F 93 /r || encoded[3]{0f 93 c0}
012eh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0131h jmp short 019dh                         ; JMP rel8 || EB cb || encoded[2]{eb 6a}
0133h vucomisd xmm0,xmm1                      ; VUCOMISD xmm1, xmm2/m64 || VEX.LIG.66.0F.WIG 2E /r || encoded[4]{c5 f9 2e c1}
0137h setae al                                ; SETAE r/m8 || 0F 93 /r || encoded[3]{0f 93 c0}
013ah movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
013dh jmp short 019dh                         ; JMP rel8 || EB cb || encoded[2]{eb 5e}
013fh vucomisd xmm0,xmm1                      ; VUCOMISD xmm1, xmm2/m64 || VEX.LIG.66.0F.WIG 2E /r || encoded[4]{c5 f9 2e c1}
0143h setb al                                 ; SETB r/m8 || 0F 92 /r || encoded[3]{0f 92 c0}
0146h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0149h jmp short 019dh                         ; JMP rel8 || EB cb || encoded[2]{eb 52}
014bh vucomisd xmm0,xmm1                      ; VUCOMISD xmm1, xmm2/m64 || VEX.LIG.66.0F.WIG 2E /r || encoded[4]{c5 f9 2e c1}
014fh setb al                                 ; SETB r/m8 || 0F 92 /r || encoded[3]{0f 92 c0}
0152h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0155h jmp short 019dh                         ; JMP rel8 || EB cb || encoded[2]{eb 46}
0157h vucomisd xmm0,xmm1                      ; VUCOMISD xmm1, xmm2/m64 || VEX.LIG.66.0F.WIG 2E /r || encoded[4]{c5 f9 2e c1}
015bh setbe al                                ; SETBE r/m8 || 0F 96 /r || encoded[3]{0f 96 c0}
015eh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0161h jmp short 019dh                         ; JMP rel8 || EB cb || encoded[2]{eb 3a}
0163h vucomisd xmm0,xmm1                      ; VUCOMISD xmm1, xmm2/m64 || VEX.LIG.66.0F.WIG 2E /r || encoded[4]{c5 f9 2e c1}
0167h setbe al                                ; SETBE r/m8 || 0F 96 /r || encoded[3]{0f 96 c0}
016ah movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
016dh jmp short 019dh                         ; JMP rel8 || EB cb || encoded[2]{eb 2e}
016fh vucomisd xmm1,xmm0                      ; VUCOMISD xmm1, xmm2/m64 || VEX.LIG.66.0F.WIG 2E /r || encoded[4]{c5 f9 2e c8}
0173h setb al                                 ; SETB r/m8 || 0F 92 /r || encoded[3]{0f 92 c0}
0176h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0179h jmp short 019dh                         ; JMP rel8 || EB cb || encoded[2]{eb 22}
017bh vucomisd xmm1,xmm0                      ; VUCOMISD xmm1, xmm2/m64 || VEX.LIG.66.0F.WIG 2E /r || encoded[4]{c5 f9 2e c8}
017fh setb al                                 ; SETB r/m8 || 0F 92 /r || encoded[3]{0f 92 c0}
0182h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0185h jmp short 019dh                         ; JMP rel8 || EB cb || encoded[2]{eb 16}
0187h vucomisd xmm1,xmm0                      ; VUCOMISD xmm1, xmm2/m64 || VEX.LIG.66.0F.WIG 2E /r || encoded[4]{c5 f9 2e c8}
018bh setbe al                                ; SETBE r/m8 || 0F 96 /r || encoded[3]{0f 96 c0}
018eh movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0191h jmp short 019dh                         ; JMP rel8 || EB cb || encoded[2]{eb 0a}
0193h vucomisd xmm1,xmm0                      ; VUCOMISD xmm1, xmm2/m64 || VEX.LIG.66.0F.WIG 2E /r || encoded[4]{c5 f9 2e c8}
0197h setbe al                                ; SETBE r/m8 || 0F 96 /r || encoded[3]{0f 96 c0}
019ah movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
019dh add rsp,20h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 20}
01a1h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
01a2h ret                                     ; RET || C3 || encoded[1]{c3}
01a3h mov rcx,7ff9ad2b7118h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 18 71 2b ad f9 7f 00 00}
01adh call 7ffa0cc37710h                      ; CALL rel32 || E8 cd || encoded[5]{e8 de 86 93 5d}
01b2h mov rsi,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f0}
01b5h mov rcx,rsi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b ce}
01b8h call 7ff9ad126940h                      ; CALL rel32 || E8 cd || encoded[5]{e8 03 79 e2 fd}
01bdh mov rcx,rsi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b ce}
01c0h call 7ffa0cbfb3a0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 5b c3 8f 5d}

# JAE rel8
------------------------------------------------------------------------------------------------------------------------
; bit within<byte>(byte a, byte b, byte delta), located://gmath/api?within#within_g[8u](8u,8u,8u)
; public static ReadOnlySpan<byte> within_gᐸ8uᐳᐤ8uㆍ8uㆍ8uᐤ => new byte[43]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x0f,0xb6,0xd2,0x41,0x0f,0xb6,0xc8,0x3b,0xc2,0x73,0x07,0x2b,0xd0,0x44,0x8b,0xc2,0xeb,0x05,0x2b,0xc2,0x44,0x8b,0xc0,0x8b,0xc1,0x4c,0x3b,0xc0,0x0f,0x96,0xc0,0x0f,0xb6,0xc0,0xc3};
; Base = 7ff9af21cf00h
; TermCode = CTC_RET_ZED_SBB
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c1}
0008h movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
000bh movzx ecx,r8b                           ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{41 0f b6 c8}
000fh cmp eax,edx                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b c2}
0011h jae short 001ah                         ; JAE rel8 || 73 cb || encoded[2]{73 07}
0013h sub edx,eax                             ; SUB r32, r/m32 || o32 2B /r || encoded[2]{2b d0}
0015h mov r8d,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{44 8b c2}
0018h jmp short 001fh                         ; JMP rel8 || EB cb || encoded[2]{eb 05}
001ah sub eax,edx                             ; SUB r32, r/m32 || o32 2B /r || encoded[2]{2b c2}
001ch mov r8d,eax                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{44 8b c0}
001fh mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0021h cmp r8,rax                              ; CMP r64, r/m64 || REX.W 3B /r || encoded[3]{4c 3b c0}
0024h setbe al                                ; SETBE r/m8 || 0F 96 /r || encoded[3]{0f 96 c0}
0027h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
002ah ret                                     ; RET || C3 || encoded[1]{c3}

# JO rel8
------------------------------------------------------------------------------------------------------------------------
; ReadOnlySpan<byte> s8u<ushort>(ReadOnlySpan<ushort> src), located://seed/spans?s8u#s8u_g[16u](uspan16u)
; public static ReadOnlySpan<byte> s8u_gᐸ16uᐳᐤuspan16uᐤ => new byte[29]{0x48,0x83,0xec,0x28,0x90,0x48,0x8b,0x02,0x8b,0x52,0x08,0x6b,0xd2,0x02,0x70,0x0e,0x48,0x89,0x01,0x89,0x51,0x08,0x48,0x8b,0xc1,0x48,0x83,0xc4,0x28};
; Base = 7ff9af9490e0h
; TermCode = CTC_Zx7
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
0008h mov edx,[rdx+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 52 08}
000bh imul edx,2                              ; IMUL r32, r/m32, imm8 || o32 6B /r ib || encoded[3]{6b d2 02}
000eh jo short 001eh                          ; JO rel8 || 70 cb || encoded[2]{70 0e}
0010h mov [rcx],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 01}
0013h mov [rcx+8],edx                         ; MOV r/m32, r32 || o32 89 /r || encoded[3]{89 51 08}
0016h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0019h add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}

# JE rel8
------------------------------------------------------------------------------------------------------------------------
; byte ntz<byte>(in BitVector<byte> x), located://bitvectors/api?ntz#ntz_g[8u](BitVector[byte]~in)
; public static ReadOnlySpan<byte> ntz_gᐸ8uᐳᐤBitVectorᐸbyteᐳᕀinᐤ => new byte[37]{0x50,0x0f,0x1f,0x40,0x00,0x0f,0xb6,0x01,0x85,0xc0,0x74,0x06,0xf3,0x0f,0xbc,0xc0,0xeb,0x05,0xb8,0x08,0x00,0x00,0x00,0x89,0x44,0x24,0x04,0x0f,0xb6,0x44,0x24,0x04,0x48,0x83,0xc4,0x08,0xc3};
; Base = 7ff9aeb6d6c0h
; TermCode = CTC_RET_Zx3
0000h push rax                                ; PUSH r64 || 50+ro || encoded[1]{50}
0001h nop dword ptr [rax]                     ; NOP r/m32 || o32 0F 1F /0 || encoded[4]{0f 1f 40 00}
0005h movzx eax,byte ptr [rcx]                ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 01}
0008h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
000ah je short 0012h                          ; JE rel8 || 74 cb || encoded[2]{74 06}
000ch tzcnt eax,eax                           ; TZCNT r32, r/m32 || o32 F3 0F BC /r || encoded[4]{f3 0f bc c0}
0010h jmp short 0017h                         ; JMP rel8 || EB cb || encoded[2]{eb 05}
0012h mov eax,8                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 08 00 00 00}
0017h mov [rsp+4],eax                         ; MOV r/m32, r32 || o32 89 /r || encoded[4]{89 44 24 04}
001bh movzx eax,byte ptr [rsp+4]              ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[5]{0f b6 44 24 04}
0020h add rsp,8                               ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 08}
0024h ret                                     ; RET || C3 || encoded[1]{c3}

# JNE rel8
------------------------------------------------------------------------------------------------------------------------
; byte jcc_no_switch(byte x), located://canonical/asm.expr?jcc_no_switch#jcc_no_switch_(8u)
; public static ReadOnlySpan<byte> jcc_no_switch_ᐤ8uᐤ => new byte[105]{0x0f,0x1f,0x44,0x00,0x00,0x33,0xc0,0x0f,0xb6,0xd1,0x83,0xfa,0x0b,0x75,0x07,0xb8,0xe0,0x00,0x00,0x00,0xeb,0x52,0x83,0xfa,0x02,0x75,0x07,0xb8,0x70,0x00,0x00,0x00,0xeb,0x46,0x83,0xfa,0x0d,0x75,0x07,0xb8,0x1c,0x00,0x00,0x00,0xeb,0x3a,0x83,0xfa,0x07,0x75,0x07,0xb8,0x0e,0x00,0x00,0x00,0xeb,0x2e,0x83,0xfa,0x09,0x75,0x07,0xb8,0x06,0x00,0x00,0x00,0xeb,0x22,0x83,0xfa,0x06,0x75,0x07,0xb8,0x0c,0x00,0x00,0x00,0xeb,0x16,0x83,0xfa,0x15,0x75,0x07,0xb8,0x18,0x00,0x00,0x00,0xeb,0x0a,0x83,0xfa,0x6f,0x75,0x05,0xb8,0x30,0x00,0x00,0x00,0xc3};
; Base = 7ff9aebb4b30h
; TermCode = CTC_RET_Zx3
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0007h movzx edx,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d1}
000ah cmp edx,0bh                             ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 fa 0b}
000dh jne short 0016h                         ; JNE rel8 || 75 cb || encoded[2]{75 07}
000fh mov eax,0e0h                            ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 e0 00 00 00}
0014h jmp short 0068h                         ; JMP rel8 || EB cb || encoded[2]{eb 52}
0016h cmp edx,2                               ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 fa 02}
0019h jne short 0022h                         ; JNE rel8 || 75 cb || encoded[2]{75 07}
001bh mov eax,70h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 70 00 00 00}
0020h jmp short 0068h                         ; JMP rel8 || EB cb || encoded[2]{eb 46}
0022h cmp edx,0dh                             ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 fa 0d}
0025h jne short 002eh                         ; JNE rel8 || 75 cb || encoded[2]{75 07}
0027h mov eax,1ch                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 1c 00 00 00}
002ch jmp short 0068h                         ; JMP rel8 || EB cb || encoded[2]{eb 3a}
002eh cmp edx,7                               ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 fa 07}
0031h jne short 003ah                         ; JNE rel8 || 75 cb || encoded[2]{75 07}
0033h mov eax,0eh                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 0e 00 00 00}
0038h jmp short 0068h                         ; JMP rel8 || EB cb || encoded[2]{eb 2e}
003ah cmp edx,9                               ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 fa 09}
003dh jne short 0046h                         ; JNE rel8 || 75 cb || encoded[2]{75 07}
003fh mov eax,6                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 06 00 00 00}
0044h jmp short 0068h                         ; JMP rel8 || EB cb || encoded[2]{eb 22}
0046h cmp edx,6                               ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 fa 06}
0049h jne short 0052h                         ; JNE rel8 || 75 cb || encoded[2]{75 07}
004bh mov eax,0ch                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 0c 00 00 00}
0050h jmp short 0068h                         ; JMP rel8 || EB cb || encoded[2]{eb 16}
0052h cmp edx,15h                             ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 fa 15}
0055h jne short 005eh                         ; JNE rel8 || 75 cb || encoded[2]{75 07}
0057h mov eax,18h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 18 00 00 00}
005ch jmp short 0068h                         ; JMP rel8 || EB cb || encoded[2]{eb 0a}
005eh cmp edx,6fh                             ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 fa 6f}
0061h jne short 0068h                         ; JNE rel8 || 75 cb || encoded[2]{75 05}
0063h mov eax,30h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 30 00 00 00}
0068h ret                                     ; RET || C3 || encoded[1]{c3}

# JP rel8 
------------------------------------------------------------------------------------------------------------------------
; bit neq(double a, double b), located://math/fmath?neq#neq_(64f,64f)
; public static ReadOnlySpan<byte> neq_ᐤ64fㆍ64fᐤ => new byte[21]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x2e,0xc1,0x0f,0x9a,0xc0,0x7a,0x03,0x0f,0x95,0xc0,0x0f,0xb6,0xc0,0xc3};
; Base = 7ff9af2fe720h
; TermCode = CTC_RET_INTR
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h vucomisd xmm0,xmm1                      ; VUCOMISD xmm1, xmm2/m64 || VEX.LIG.66.0F.WIG 2E /r || encoded[4]{c5 f9 2e c1}
0009h setp al                                 ; SETP r/m8 || 0F 9A /r || encoded[3]{0f 9a c0}
000ch jp short 0011h                          ; JP rel8 || 7A cb || encoded[2]{7a 03}
000eh setne al                                ; SETNE r/m8 || 0F 95 /r || encoded[3]{0f 95 c0}
0011h movzx eax,al                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c0}
0014h ret                                     ; RET || C3 || encoded[1]{c3}

# JG rel8
------------------------------------------------------------------------------------------------------------------------
; byte effsize(ushort src), located://bitcore/scalar?effsize#effsize_(16u)
; public static ReadOnlySpan<byte> effsize_ᐤ16uᐤ => new byte[27]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x3d,0xff,0x00,0x00,0x00,0x7f,0x06,0xb8,0x01,0x00,0x00,0x00,0xc3,0xb8,0x02,0x00,0x00,0x00,0xc3};
; Base = 7ff9aeaf0940h
; TermCode = CTC_RET_ZED_SBB
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,cx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c1}
0008h cmp eax,0ffh                            ; CMP EAX, imm32 || o32 3D id || encoded[5]{3d ff 00 00 00}
000dh jg short 0015h                          ; JG rel8 || 7F cb || encoded[2]{7f 06}
000fh mov eax,1                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 01 00 00 00}
0014h ret                                     ; RET || C3 || encoded[1]{c3}
0015h mov eax,2                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 02 00 00 00}
001ah ret                                     ; RET || C3 || encoded[1]{c3}

# JL rel8
------------------------------------------------------------------------------------------------------------------------
; JccTest:byte jcc2(byte x, byte y), located://canonical/asm.expr?jcc2#jcc2_(8u,8u)
; public static ReadOnlySpan<byte> jcc2_ᐤ8uㆍ8uᐤ => new byte[45]{0x0f,0x1f,0x44,0x00,0x00,0x33,0xc0,0x0f,0xb6,0xc9,0x0f,0xb6,0xd2,0x3b,0xca,0x7c,0x07,0xb8,0x0d,0x00,0x00,0x00,0xeb,0x14,0x3b,0xca,0x7f,0x07,0xb8,0x0e,0x00,0x00,0x00,0xeb,0x09,0x3b,0xca,0x74,0x05,0xb8,0x05,0x00,0x00,0x00,0xc3};
; Base = 7ff9aebb4af0h
; TermCode = CTC_RET_Zx3
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0007h movzx ecx,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c9}
000ah movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
000dh cmp ecx,edx                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b ca}
000fh jl short 0018h                          ; JL rel8 || 7C cb || encoded[2]{7c 07}
0011h mov eax,0dh                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 0d 00 00 00}
0016h jmp short 002ch                         ; JMP rel8 || EB cb || encoded[2]{eb 14}
0018h cmp ecx,edx                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b ca}
001ah jg short 0023h                          ; JG rel8 || 7F cb || encoded[2]{7f 07}
001ch mov eax,0eh                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 0e 00 00 00}
0021h jmp short 002ch                         ; JMP rel8 || EB cb || encoded[2]{eb 09}
0023h cmp ecx,edx                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b ca}
0025h je short 002ch                          ; JE rel8 || 74 cb || encoded[2]{74 05}
0027h mov eax,5                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 05 00 00 00}
002ch ret                                     ; RET || C3 || encoded[1]{c3}
