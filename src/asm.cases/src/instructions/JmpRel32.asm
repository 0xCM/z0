; ----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Type celltype(VectorKind:uint kind)::located://cpu/vk?celltype#celltype_(VectorKind~32u)
; public static ReadOnlySpan<byte> celltype_ᐤVectorKindᕀ32uᐤ => new byte[291]{0x48,0x83,0xec,0x28,0x90,0xf7,0xc1,0x00,0x00,0x02,0x00,0x74,0x14,0x48,0xb9,0x70,0x6f,0x2e,0x9b,0xfa,0x7f,0x00,0x00,0xe8,0x94,0x36,0x99,0x5a,0xe9,0xfc,0x00,0x00,0x00,0xf7,0xc1,0x00,0x00,0x01,0x00,0x74,0x14,0x48,0xb9,0x60,0x77,0x2e,0x9b,0xfa,0x7f,0x00,0x00,0xe8,0x78,0x36,0x99,0x5a,0xe9,0xe0,0x00,0x00,0x00,0xf7,0xc1,0x00,0x00,0x08,0x00,0x74,0x14,0x48,0xb9,0x50,0x7f,0x2e,0x9b,0xfa,0x7f,0x00,0x00,0xe8,0x5c,0x36,0x99,0x5a,0xe9,0xc4,0x00,0x00,0x00,0xf7,0xc1,0x00,0x00,0x04,0x00,0x74,0x14,0x48,0xb9,0x40,0x87,0x2e,0x9b,0xfa,0x7f,0x00,0x00,0xe8,0x40,0x36,0x99,0x5a,0xe9,0xa8,0x00,0x00,0x00,0xf7,0xc1,0x00,0x00,0x20,0x00,0x74,0x14,0x48,0xb9,0x10,0x8f,0x2e,0x9b,0xfa,0x7f,0x00,0x00,0xe8,0x24,0x36,0x99,0x5a,0xe9,0x8c,0x00,0x00,0x00,0xf7,0xc1,0x00,0x00,0x10,0x00,0x74,0x11,0x48,0xb9,0xe0,0x96,0x2e,0x9b,0xfa,0x7f,0x00,0x00,0xe8,0x08,0x36,0x99,0x5a,0xeb,0x73,0xf7,0xc1,0x00,0x00,0x80,0x00,0x74,0x11,0x48,0xb9,0xb0,0x9e,0x2e,0x9b,0xfa,0x7f,0x00,0x00,0xe8,0xef,0x35,0x99,0x5a,0xeb,0x5a,0xf7,0xc1,0x00,0x00,0x40,0x00,0x74,0x11,0x48,0xb9,0x80,0xa6,0x2e,0x9b,0xfa,0x7f,0x00,0x00,0xe8,0xd6,0x35,0x99,0x5a,0xeb,0x41,0xf7,0xc1,0x00,0x00,0x00,0x02,0x74,0x11,0x48,0xb9,0x60,0xaf,0x2e,0x9b,0xfa,0x7f,0x00,0x00,0xe8,0xbd,0x35,0x99,0x5a,0xeb,0x28,0xf7,0xc1,0x00,0x00,0x00,0x04,0x74,0x11,0x48,0xb9,0x40,0xb8,0x2e,0x9b,0xfa,0x7f,0x00,0x00,0xe8,0xa4,0x35,0x99,0x5a,0xeb,0x0f,0x48,0xb9,0xe0,0x55,0x2e,0x9b,0xfa,0x7f,0x00,0x00,0xe8,0x93,0x35,0x99,0x5a,0x90,0x48,0x83,0xc4,0x28,0xc3};
; BaseAddress = 7ffaa0427f00h
; TermCode = CTC_RET_ZED_SBB
0000h sub rsp,28h                                   ; SUB r/m64, imm8                  | REX.W 83 /5 ib                   | 4   | 48 83 ec 28
0004h nop                                           ; NOP                              | 90                               | 1   | 90
0005h test ecx,20000h                               ; TEST r/m32, imm32                | F7 /0 id                         | 6   | f7 c1 00 00 02 00
000bh je short 0021h                                ; JE rel8                          | 74 cb                            | 2   | 74 14
000dh mov rcx,7ffa9b2e6f70h                         ; MOV r64, imm64                   | REX.W B8 +ro io                  | 10  | 48 b9 70 6f 2e 9b fa 7f 00 00
0017h call 7ffafadbb5b0h                            ; CALL rel32                       | E8 cd                            | 5   | e8 94 36 99 5a
001ch jmp near ptr 011dh                            ; JMP rel32                        | E9 cd                            | 5   | e9 fc 00 00 00
0021h test ecx,10000h                               ; TEST r/m32, imm32                | F7 /0 id                         | 6   | f7 c1 00 00 01 00
0027h je short 003dh                                ; JE rel8                          | 74 cb                            | 2   | 74 14
0029h mov rcx,7ffa9b2e7760h                         ; MOV r64, imm64                   | REX.W B8 +ro io                  | 10  | 48 b9 60 77 2e 9b fa 7f 00 00
0033h call 7ffafadbb5b0h                            ; CALL rel32                       | E8 cd                            | 5   | e8 78 36 99 5a
0038h jmp near ptr 011dh                            ; JMP rel32                        | E9 cd                            | 5   | e9 e0 00 00 00
003dh test ecx,80000h                               ; TEST r/m32, imm32                | F7 /0 id                         | 6   | f7 c1 00 00 08 00
0043h je short 0059h                                ; JE rel8                          | 74 cb                            | 2   | 74 14
0045h mov rcx,7ffa9b2e7f50h                         ; MOV r64, imm64                   | REX.W B8 +ro io                  | 10  | 48 b9 50 7f 2e 9b fa 7f 00 00
004fh call 7ffafadbb5b0h                            ; CALL rel32                       | E8 cd                            | 5   | e8 5c 36 99 5a
0054h jmp near ptr 011dh                            ; JMP rel32                        | E9 cd                            | 5   | e9 c4 00 00 00
0059h test ecx,40000h                               ; TEST r/m32, imm32                | F7 /0 id                         | 6   | f7 c1 00 00 04 00
005fh je short 0075h                                ; JE rel8                          | 74 cb                            | 2   | 74 14
0061h mov rcx,7ffa9b2e8740h                         ; MOV r64, imm64                   | REX.W B8 +ro io                  | 10  | 48 b9 40 87 2e 9b fa 7f 00 00
006bh call 7ffafadbb5b0h                            ; CALL rel32                       | E8 cd                            | 5   | e8 40 36 99 5a
0070h jmp near ptr 011dh                            ; JMP rel32                        | E9 cd                            | 5   | e9 a8 00 00 00
0075h test ecx,200000h                              ; TEST r/m32, imm32                | F7 /0 id                         | 6   | f7 c1 00 00 20 00
007bh je short 0091h                                ; JE rel8                          | 74 cb                            | 2   | 74 14
007dh mov rcx,7ffa9b2e8f10h                         ; MOV r64, imm64                   | REX.W B8 +ro io                  | 10  | 48 b9 10 8f 2e 9b fa 7f 00 00
0087h call 7ffafadbb5b0h                            ; CALL rel32                       | E8 cd                            | 5   | e8 24 36 99 5a
008ch jmp near ptr 011dh                            ; JMP rel32                        | E9 cd                            | 5   | e9 8c 00 00 00
0091h test ecx,100000h                              ; TEST r/m32, imm32                | F7 /0 id                         | 6   | f7 c1 00 00 10 00
0097h je short 00aah                                ; JE rel8                          | 74 cb                            | 2   | 74 11
0099h mov rcx,7ffa9b2e96e0h                         ; MOV r64, imm64                   | REX.W B8 +ro io                  | 10  | 48 b9 e0 96 2e 9b fa 7f 00 00
00a3h call 7ffafadbb5b0h                            ; CALL rel32                       | E8 cd                            | 5   | e8 08 36 99 5a
00a8h jmp short 011dh                               ; JMP rel8                         | EB cb                            | 2   | eb 73
00aah test ecx,800000h                              ; TEST r/m32, imm32                | F7 /0 id                         | 6   | f7 c1 00 00 80 00
00b0h je short 00c3h                                ; JE rel8                          | 74 cb                            | 2   | 74 11
00b2h mov rcx,7ffa9b2e9eb0h                         ; MOV r64, imm64                   | REX.W B8 +ro io                  | 10  | 48 b9 b0 9e 2e 9b fa 7f 00 00
00bch call 7ffafadbb5b0h                            ; CALL rel32                       | E8 cd                            | 5   | e8 ef 35 99 5a
00c1h jmp short 011dh                               ; JMP rel8                         | EB cb                            | 2   | eb 5a
00c3h test ecx,400000h                              ; TEST r/m32, imm32                | F7 /0 id                         | 6   | f7 c1 00 00 40 00
00c9h je short 00dch                                ; JE rel8                          | 74 cb                            | 2   | 74 11
00cbh mov rcx,7ffa9b2ea680h                         ; MOV r64, imm64                   | REX.W B8 +ro io                  | 10  | 48 b9 80 a6 2e 9b fa 7f 00 00
00d5h call 7ffafadbb5b0h                            ; CALL rel32                       | E8 cd                            | 5   | e8 d6 35 99 5a
00dah jmp short 011dh                               ; JMP rel8                         | EB cb                            | 2   | eb 41
00dch test ecx,2000000h                             ; TEST r/m32, imm32                | F7 /0 id                         | 6   | f7 c1 00 00 00 02
00e2h je short 00f5h                                ; JE rel8                          | 74 cb                            | 2   | 74 11
00e4h mov rcx,7ffa9b2eaf60h                         ; MOV r64, imm64                   | REX.W B8 +ro io                  | 10  | 48 b9 60 af 2e 9b fa 7f 00 00
00eeh call 7ffafadbb5b0h                            ; CALL rel32                       | E8 cd                            | 5   | e8 bd 35 99 5a
00f3h jmp short 011dh                               ; JMP rel8                         | EB cb                            | 2   | eb 28
00f5h test ecx,4000000h                             ; TEST r/m32, imm32                | F7 /0 id                         | 6   | f7 c1 00 00 00 04
00fbh je short 010eh                                ; JE rel8                          | 74 cb                            | 2   | 74 11
00fdh mov rcx,7ffa9b2eb840h                         ; MOV r64, imm64                   | REX.W B8 +ro io                  | 10  | 48 b9 40 b8 2e 9b fa 7f 00 00
0107h call 7ffafadbb5b0h                            ; CALL rel32                       | E8 cd                            | 5   | e8 a4 35 99 5a
010ch jmp short 011dh                               ; JMP rel8                         | EB cb                            | 2   | eb 0f
010eh mov rcx,7ffa9b2e55e0h                         ; MOV r64, imm64                   | REX.W B8 +ro io                  | 10  | 48 b9 e0 55 2e 9b fa 7f 00 00
0118h call 7ffafadbb5b0h                            ; CALL rel32                       | E8 cd                            | 5   | e8 93 35 99 5a
011dh nop                                           ; NOP                              | 90                               | 1   | 90
011eh add rsp,28h                                   ; ADD r/m64, imm8                  | REX.W 83 /0 ib                   | 4   | 48 83 c4 28
0122h ret                                           ; RET                              | C3                               | 1   | c3
