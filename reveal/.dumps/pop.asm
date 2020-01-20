; 2020-01-20 01:59:21:044
; void part64x1_byte(ulong src, Span<byte> dst)
; static ReadOnlySpan<byte> part64x1_byte_8199418Bytes => new byte[177]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x48,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xF3,0xF5,0xD2,0x48,0x89,0x10,0x48,0x8D,0x50,0x08,0x4C,0x8B,0xC1,0x49,0xC1,0xE8,0x08,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x10,0x4C,0x8B,0xC1,0x49,0xC1,0xE8,0x10,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x18,0x4C,0x8B,0xC1,0x49,0xC1,0xE8,0x18,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x20,0x4C,0x8B,0xC1,0x49,0xC1,0xE8,0x20,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x28,0x4C,0x8B,0xC1,0x49,0xC1,0xE8,0x28,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x30,0x4C,0x8B,0xC1,0x49,0xC1,0xE8,0x30,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x83,0xC0,0x38,0x48,0xC1,0xE9,0x38,0xC4,0xC2,0xF3,0xF5,0xD1,0x48,0x89,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x40,0xCB,0x72,0x5F,0xCC};
; [0x7ff7c8393030, 0x7ff7c83930e1], 177 bytes
; 2020-01-20 01:59:21:044
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
0008h mov rdx,101010101010101h                ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 ba 01 01 01 01 01 01 01 01}
0012h pdep rdx,rcx,rdx                        ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 e2 f3 f5 d2}
0017h mov [rax],rdx                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 10}
001ah lea rdx,[rax+8]                         ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 50 08}
001eh mov r8,rcx                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b c1}
0021h shr r8,8                                ; SHR r/m64, imm8 || REX.W C1 /5 ib || encoded[4]{49 c1 e8 08}
0025h mov r9,101010101010101h                 ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 b9 01 01 01 01 01 01 01 01}
002fh pdep r8,r8,r9                           ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 42 bb f5 c1}
0034h mov [rdx],r8                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 02}
0037h lea rdx,[rax+10h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 50 10}
003bh mov r8,rcx                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b c1}
003eh shr r8,10h                              ; SHR r/m64, imm8 || REX.W C1 /5 ib || encoded[4]{49 c1 e8 10}
0042h pdep r8,r8,r9                           ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 42 bb f5 c1}
0047h mov [rdx],r8                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 02}
004ah lea rdx,[rax+18h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 50 18}
004eh mov r8,rcx                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b c1}
0051h shr r8,18h                              ; SHR r/m64, imm8 || REX.W C1 /5 ib || encoded[4]{49 c1 e8 18}
0055h pdep r8,r8,r9                           ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 42 bb f5 c1}
005ah mov [rdx],r8                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 02}
005dh lea rdx,[rax+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 50 20}
0061h mov r8,rcx                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b c1}
0064h shr r8,20h                              ; SHR r/m64, imm8 || REX.W C1 /5 ib || encoded[4]{49 c1 e8 20}
0068h pdep r8,r8,r9                           ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 42 bb f5 c1}
006dh mov [rdx],r8                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 02}
0070h lea rdx,[rax+28h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 50 28}
0074h mov r8,rcx                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b c1}
0077h shr r8,28h                              ; SHR r/m64, imm8 || REX.W C1 /5 ib || encoded[4]{49 c1 e8 28}
007bh pdep r8,r8,r9                           ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 42 bb f5 c1}
0080h mov [rdx],r8                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 02}
0083h lea rdx,[rax+30h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 50 30}
0087h mov r8,rcx                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b c1}
008ah shr r8,30h                              ; SHR r/m64, imm8 || REX.W C1 /5 ib || encoded[4]{49 c1 e8 30}
008eh pdep r8,r8,r9                           ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 42 bb f5 c1}
0093h mov [rdx],r8                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 02}
0096h add rax,38h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c0 38}
009ah shr rcx,38h                             ; SHR r/m64, imm8 || REX.W C1 /5 ib || encoded[4]{48 c1 e9 38}
009eh pdep rdx,rcx,r9                         ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 c2 f3 f5 d1}
00a3h mov [rax],rdx                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 10}
00a6h add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
00aah ret                                     ; RET || C3 || encoded[1]{c3}
00abh call 7FF827ABFC20h                      ; CALL rel32 || E8 cd || encoded[5]{e8 40 cb 72 5f}
00b0h int 3                                   ; INT3 || CC || encoded[1]{cc}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void part64x1_bit(ulong src, Span<bit> dst)
; static ReadOnlySpan<byte> part64x1_bit_4687385Bytes => new byte[83]{0x48,0x83,0xEC,0x28,0x48,0x8B,0xC1,0x4C,0x8B,0x02,0x8B,0x4A,0x08,0x48,0xC1,0xE1,0x02,0x48,0xC1,0xE9,0x03,0x48,0x81,0xF9,0xFF,0xFF,0xFF,0x7F,0x77,0x2F,0x33,0xD2,0x48,0x63,0xCA,0x4D,0x8D,0x0C,0xC8,0x8B,0xCA,0x4C,0x8B,0xD0,0x49,0xD3,0xEA,0x48,0xB9,0x01,0x00,0x00,0x00,0x01,0x00,0x00,0x00,0xC4,0xE2,0xAB,0xF5,0xC9,0x49,0x89,0x09,0xFF,0xC2,0x83,0xFA,0x20,0x7C,0xD8,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xCE,0xCA,0x72,0x5F,0xCC};
; [0x7ff7c8393100, 0x7ff7c8393153], 83 bytes
; 2020-01-20 01:59:21:044
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0007h mov r8,[rdx]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b 02}
000ah mov ecx,[rdx+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 4a 08}
000dh shl rcx,2                               ; SHL r/m64, imm8 || REX.W C1 /4 ib || encoded[4]{48 c1 e1 02}
0011h shr rcx,3                               ; SHR r/m64, imm8 || REX.W C1 /5 ib || encoded[4]{48 c1 e9 03}
0015h cmp rcx,7FFFFFFFh                       ; CMP r/m64, imm32 || REX.W 81 /7 id || encoded[7]{48 81 f9 ff ff ff 7f}
001ch ja short 004dh                          ; JA rel8 || 77 cb || encoded[2]{77 2f}
001eh xor edx,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d2}
0020h movsxd rcx,edx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 ca}
0023h lea r9,[r8+rcx*8]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{4d 8d 0c c8}
0027h mov ecx,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b ca}
0029h mov r10,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b d0}
002ch shr r10,cl                              ; SHR r/m64, CL || REX.W D3 /5 || encoded[3]{49 d3 ea}
002fh mov rcx,100000001h                      ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 01 00 00 00 01 00 00 00}
0039h pdep rcx,r10,rcx                        ; PDEP r64a, r64b, r/m64 || VEX.LZ.F2.0F38.W1 F5 /r || encoded[5]{c4 e2 ab f5 c9}
003eh mov [r9],rcx                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 09}
0041h inc edx                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c2}
0043h cmp edx,20h                             ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 fa 20}
0046h jl short 0020h                          ; JL rel8 || 7C cb || encoded[2]{7c d8}
0048h add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
004ch ret                                     ; RET || C3 || encoded[1]{c3}
004dh call 7FF827ABFC20h                      ; CALL rel32 || E8 cd || encoded[5]{e8 ce ca 72 5f}
0052h int 3                                   ; INT3 || CC || encoded[1]{cc}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
