; 2020-01-20 01:59:20:998
; int blockalign_64x8u_var(int cellcount)
; static ReadOnlySpan<byte> blockalign_64x8u_var_32iBytes => new byte[40]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC1,0xF8,0x1F,0x83,0xE0,0x07,0x03,0xC1,0xC1,0xF8,0x03,0x8B,0xD1,0xC1,0xFA,0x1F,0x83,0xE2,0x07,0x03,0xD1,0x83,0xE2,0xF8,0x2B,0xCA,0x74,0x04,0xFF,0xC0,0xEB,0x00,0xC3};
; [0x7ff7c8391420, 0x7ff7c8391448], 40 bytes
; 2020-01-20 01:59:20:998
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c1}
0007h sar eax,1Fh                             ; SAR r/m32, imm8 || o32 C1 /7 ib || encoded[3]{c1 f8 1f}
000ah and eax,7                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e0 07}
000dh add eax,ecx                             ; ADD r32, r/m32 || o32 03 /r || encoded[2]{03 c1}
000fh sar eax,3                               ; SAR r/m32, imm8 || o32 C1 /7 ib || encoded[3]{c1 f8 03}
0012h mov edx,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b d1}
0014h sar edx,1Fh                             ; SAR r/m32, imm8 || o32 C1 /7 ib || encoded[3]{c1 fa 1f}
0017h and edx,7                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e2 07}
001ah add edx,ecx                             ; ADD r32, r/m32 || o32 03 /r || encoded[2]{03 d1}
001ch and edx,0FFFFFFF8h                      ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e2 f8}
001fh sub ecx,edx                             ; SUB r32, r/m32 || o32 2B /r || encoded[2]{2b ca}
0021h je short 0027h                          ; JE rel8 || 74 cb || encoded[2]{74 04}
0023h inc eax                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c0}
0025h jmp short 0027h                         ; JMP rel8 || EB cb || encoded[2]{eb 00}
0027h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; int blockalign_64x8u_16()
; static ReadOnlySpan<byte> blockalign_64x8u_16_63695501Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x02,0x00,0x00,0x00,0xC3};
; [0x7ff7c8391460, 0x7ff7c839146b], 11 bytes
; 2020-01-20 01:59:20:998
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,2                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 02 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; int blockalign_64x8u_17()
; static ReadOnlySpan<byte> blockalign_64x8u_17_36388601Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x03,0x00,0x00,0x00,0xC3};
; [0x7ff7c8391480, 0x7ff7c839148b], 11 bytes
; 2020-01-20 01:59:20:998
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,3                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 03 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Char digit_1()
; static ReadOnlySpan<byte> digit_1_59061958Bytes => new byte[46]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x48,0x58,0x9D,0x93,0x4C,0x02,0x00,0x00,0x48,0x8B,0x00,0x48,0x85,0xC0,0x75,0x04,0x33,0xD2,0xEB,0x0E,0x8B,0x10,0x48,0x8B,0xD0,0x39,0x12,0x48,0x83,0xC2,0x0C,0x8B,0x40,0x08,0x0F,0xB7,0x42,0x0A,0xC3};
; [0x7ff7c83918b0, 0x7ff7c83918de], 46 bytes
; 2020-01-20 01:59:20:998
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,24C939D5848h                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 48 58 9d 93 4c 02 00 00}
000fh mov rax,[rax]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 00}
0012h test rax,rax                            ; TEST r/m64, r64 || REX.W 85 /r || encoded[3]{48 85 c0}
0015h jne short 001bh                         ; JNE rel8 || 75 cb || encoded[2]{75 04}
0017h xor edx,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d2}
0019h jmp short 0029h                         ; JMP rel8 || EB cb || encoded[2]{eb 0e}
001bh mov edx,[rax]                           ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b 10}
001dh mov rdx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d0}
0020h cmp [rdx],edx                           ; CMP r/m32, r32 || o32 39 /r || encoded[2]{39 12}
0022h add rdx,0Ch                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c2 0c}
0026h mov eax,[rax+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 40 08}
0029h movzx eax,word ptr [rdx+0Ah]            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[4]{0f b7 42 0a}
002dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Char digit_2()
; static ReadOnlySpan<byte> digit_2_61795582Bytes => new byte[39]{0x48,0x83,0xEC,0x28,0x90,0x48,0xB8,0x48,0x58,0x9D,0x93,0x4C,0x02,0x00,0x00,0x48,0x8B,0x00,0x83,0x78,0x08,0x05,0x76,0x09,0x0F,0xB7,0x40,0x16,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xBA,0xE4,0x72,0x5F,0xCC};
; [0x7ff7c83918f0, 0x7ff7c8391917], 39 bytes
; 2020-01-20 01:59:20:998
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov rax,24C939D5848h                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 48 58 9d 93 4c 02 00 00}
000fh mov rax,[rax]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 00}
0012h cmp dword ptr [rax+8],5                 ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[4]{83 78 08 05}
0016h jbe short 0021h                         ; JBE rel8 || 76 cb || encoded[2]{76 09}
0018h movzx eax,word ptr [rax+16h]            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[4]{0f b7 40 16}
001ch add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0020h ret                                     ; RET || C3 || encoded[1]{c3}
0021h call 7FF827ABFDD0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 ba e4 72 5f}
0026h int 3                                   ; INT3 || CC || encoded[1]{cc}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Char digit(int i)
; static ReadOnlySpan<byte> digit_32iBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC1,0x48,0xBA,0xFD,0x92,0x1B,0x82,0x4C,0x02,0x00,0x00,0x0F,0xB6,0x04,0x10,0xC3};
; [0x7ff7c8391930, 0x7ff7c8391947], 23 bytes
; 2020-01-20 01:59:20:998
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movsxd rax,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 c1}
0008h mov rdx,24C821B92FDh                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 ba fd 92 1b 82 4c 02 00 00}
0012h movzx eax,byte ptr [rax+rdx]            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{0f b6 04 10}
0016h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Char bdigit(bit b)
; static ReadOnlySpan<byte> bdigit_19289328Bytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x83,0xC1,0x30,0x0F,0xB7,0xC1,0xC3};
; [0x7ff7c8391960, 0x7ff7c839196c], 12 bytes
; 2020-01-20 01:59:20:998
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h add ecx,30h                             ; ADD r/m32, imm8 || o32 83 /0 ib || encoded[3]{83 c1 30}
0008h movzx eax,cx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 c1}
000bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
