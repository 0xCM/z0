; 2020-01-20 01:59:20:972
; ulong nat_add()
; static ReadOnlySpan<byte> nat_add_66716254Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x1C,0x00,0x00,0x00,0xC3};
; [0x7ff7c838f8e0, 0x7ff7c838f8eb], 11 bytes
; 2020-01-20 01:59:20:972
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,1Ch                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 1c 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong nat_sub()
; static ReadOnlySpan<byte> nat_sub_35307513Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x01,0x00,0x00,0xC3};
; [0x7ff7c8390920, 0x7ff7c839092b], 11 bytes
; 2020-01-20 01:59:20:972
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,100h                            ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 00 01 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong nat_mul()
; static ReadOnlySpan<byte> nat_mul_49332166Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xC0,0x00,0x00,0x00,0xC3};
; [0x7ff7c8390940, 0x7ff7c839094b], 11 bytes
; 2020-01-20 01:59:20:972
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,0C0h                            ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 c0 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong nat_div()
; static ReadOnlySpan<byte> nat_div_41336317Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x0A,0x00,0x00,0x00,0xC3};
; [0x7ff7c8390960, 0x7ff7c839096b], 11 bytes
; 2020-01-20 01:59:20:972
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,0Ah                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 0a 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong nat_mod()
; static ReadOnlySpan<byte> nat_mod_36482533Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x02,0x00,0x00,0x00,0xC3};
; [0x7ff7c8390980, 0x7ff7c839098b], 11 bytes
; 2020-01-20 01:59:20:972
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,2                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 02 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong digits_encode_1_0()
; static ReadOnlySpan<byte> digits_encode_1_0_59907344Bytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
; [0x7ff7c8390db0, 0x7ff7c8390db8], 8 bytes
; 2020-01-20 01:59:20:972
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0007h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong digits_encode_1()
; static ReadOnlySpan<byte> digits_encode_1_2295192Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
; [0x7ff7c8390dd0, 0x7ff7c8390ddb], 11 bytes
; 2020-01-20 01:59:20:972
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,1                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 01 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong digits_encode_2()
; static ReadOnlySpan<byte> digits_encode_2_20656733Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x02,0x00,0x00,0x00,0xC3};
; [0x7ff7c8390df0, 0x7ff7c8390dfb], 11 bytes
; 2020-01-20 01:59:20:972
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,2                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 02 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong digits_encode_3()
; static ReadOnlySpan<byte> digits_encode_3_51692872Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x03,0x00,0x00,0x00,0xC3};
; [0x7ff7c8390e10, 0x7ff7c8390e1b], 11 bytes
; 2020-01-20 01:59:20:972
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,3                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 03 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong digits_encode_10()
; static ReadOnlySpan<byte> digits_encode_10_62582666Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x10,0x00,0x00,0x00,0xC3};
; [0x7ff7c8390e30, 0x7ff7c8390e3b], 11 bytes
; 2020-01-20 01:59:20:972
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,10h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 10 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong digits_encode_210()
; static ReadOnlySpan<byte> digits_encode_210_26373084Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x10,0x02,0x00,0x00,0xC3};
; [0x7ff7c8390e50, 0x7ff7c8390e5b], 11 bytes
; 2020-01-20 01:59:20:972
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,210h                            ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 10 02 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong digits_encode_3210()
; static ReadOnlySpan<byte> digits_encode_3210_36031167Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x10,0x32,0x00,0x00,0xC3};
; [0x7ff7c8390e70, 0x7ff7c8390e7b], 11 bytes
; 2020-01-20 01:59:20:972
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,3210h                           ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 10 32 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong digits_encode_43210()
; static ReadOnlySpan<byte> digits_encode_43210_55845053Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x10,0x32,0x04,0x00,0xC3};
; [0x7ff7c8390e90, 0x7ff7c8390e9b], 11 bytes
; 2020-01-20 01:59:20:972
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,43210h                          ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 10 32 04 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong digits_encode_76543210()
; static ReadOnlySpan<byte> digits_encode_76543210_32843429Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x10,0x32,0x54,0x76,0xC3};
; [0x7ff7c8390eb0, 0x7ff7c8390ebb], 11 bytes
; 2020-01-20 01:59:20:972
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,76543210h                       ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 10 32 54 76}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong digit_extract_9()
; static ReadOnlySpan<byte> digit_extract_9_27155410Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x09,0x00,0x00,0x00,0xC3};
; [0x7ff7c8390ed0, 0x7ff7c8390edb], 11 bytes
; 2020-01-20 01:59:20:972
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,9                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 09 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong digit_extract_4()
; static ReadOnlySpan<byte> digit_extract_4_43072099Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x04,0x00,0x00,0x00,0xC3};
; [0x7ff7c8390ef0, 0x7ff7c8390efb], 11 bytes
; 2020-01-20 01:59:20:972
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,4                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 04 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong digit_extract_8()
; static ReadOnlySpan<byte> digit_extract_8_52104579Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x08,0x00,0x00,0x00,0xC3};
; [0x7ff7c8390f10, 0x7ff7c8390f1b], 11 bytes
; 2020-01-20 01:59:20:972
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,8                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 08 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong digit_extract_5()
; static ReadOnlySpan<byte> digit_extract_5_66288034Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x05,0x00,0x00,0x00,0xC3};
; [0x7ff7c8390f30, 0x7ff7c8390f3b], 11 bytes
; 2020-01-20 01:59:20:972
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,5                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 05 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void digits_extract_5849(out byte d3, out byte d2, out byte d1, out byte d0)
; static ReadOnlySpan<byte> digits_extract_5849_8uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0xC6,0x01,0x05,0xC6,0x02,0x08,0x41,0xC6,0x00,0x04,0x41,0xC6,0x01,0x09,0xC3};
; [0x7ff7c8390f50, 0x7ff7c8390f64], 20 bytes
; 2020-01-20 01:59:20:972
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov byte ptr [rcx],5                    ; MOV r/m8, imm8 || C6 /0 ib || encoded[3]{c6 01 05}
0008h mov byte ptr [rdx],8                    ; MOV r/m8, imm8 || C6 /0 ib || encoded[3]{c6 02 08}
000bh mov byte ptr [r8],4                     ; MOV r/m8, imm8 || C6 /0 ib || encoded[4]{41 c6 00 04}
000fh mov byte ptr [r9],9                     ; MOV r/m8, imm8 || C6 /0 ib || encoded[4]{41 c6 01 09}
0013h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void digits_extract_5489_ref(ref byte dst)
; static ReadOnlySpan<byte> digits_extract_5489_ref_8uBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0x03,0xC6,0x00,0x05,0x48,0x8D,0x41,0x02,0xC6,0x00,0x08,0x48,0x8D,0x41,0x01,0xC6,0x00,0x04,0xC6,0x01,0x09,0xC3};
; [0x7ff7c8390f80, 0x7ff7c8390f9e], 30 bytes
; 2020-01-20 01:59:20:973
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h lea rax,[rcx+3]                         ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 41 03}
0009h mov byte ptr [rax],5                    ; MOV r/m8, imm8 || C6 /0 ib || encoded[3]{c6 00 05}
000ch lea rax,[rcx+2]                         ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 41 02}
0010h mov byte ptr [rax],8                    ; MOV r/m8, imm8 || C6 /0 ib || encoded[3]{c6 00 08}
0013h lea rax,[rcx+1]                         ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 41 01}
0017h mov byte ptr [rax],4                    ; MOV r/m8, imm8 || C6 /0 ib || encoded[3]{c6 00 04}
001ah mov byte ptr [rcx],9                    ; MOV r/m8, imm8 || C6 /0 ib || encoded[3]{c6 01 09}
001dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void digits_extract_80352178(out byte d7, out byte d6, out byte d5, out byte d4, out byte d3, out byte d2, out byte d1, out byte d0)
; static ReadOnlySpan<byte> digits_extract_80352178_8uBytes => new byte[52]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x44,0x24,0x28,0xC6,0x00,0x02,0x48,0x8B,0x44,0x24,0x30,0xC6,0x00,0x01,0x48,0x8B,0x44,0x24,0x38,0xC6,0x00,0x07,0x48,0x8B,0x44,0x24,0x40,0xC6,0x00,0x08,0xC6,0x01,0x08,0xC6,0x02,0x00,0x41,0xC6,0x00,0x03,0x41,0xC6,0x01,0x05,0xC3};
; [0x7ff7c8390fb0, 0x7ff7c8390fe4], 52 bytes
; 2020-01-20 01:59:20:973
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,[rsp+28h]                       ; MOV r64, r/m64 || REX.W 8B /r || encoded[5]{48 8b 44 24 28}
000ah mov byte ptr [rax],2                    ; MOV r/m8, imm8 || C6 /0 ib || encoded[3]{c6 00 02}
000dh mov rax,[rsp+30h]                       ; MOV r64, r/m64 || REX.W 8B /r || encoded[5]{48 8b 44 24 30}
0012h mov byte ptr [rax],1                    ; MOV r/m8, imm8 || C6 /0 ib || encoded[3]{c6 00 01}
0015h mov rax,[rsp+38h]                       ; MOV r64, r/m64 || REX.W 8B /r || encoded[5]{48 8b 44 24 38}
001ah mov byte ptr [rax],7                    ; MOV r/m8, imm8 || C6 /0 ib || encoded[3]{c6 00 07}
001dh mov rax,[rsp+40h]                       ; MOV r64, r/m64 || REX.W 8B /r || encoded[5]{48 8b 44 24 40}
0022h mov byte ptr [rax],8                    ; MOV r/m8, imm8 || C6 /0 ib || encoded[3]{c6 00 08}
0025h mov byte ptr [rcx],8                    ; MOV r/m8, imm8 || C6 /0 ib || encoded[3]{c6 01 08}
0028h mov byte ptr [rdx],0                    ; MOV r/m8, imm8 || C6 /0 ib || encoded[3]{c6 02 00}
002bh mov byte ptr [r8],3                     ; MOV r/m8, imm8 || C6 /0 ib || encoded[4]{41 c6 00 03}
002fh mov byte ptr [r9],5                     ; MOV r/m8, imm8 || C6 /0 ib || encoded[4]{41 c6 01 05}
0033h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void chars_5489(out Char c3, out Char c2, out Char c1, out Char c0)
; static ReadOnlySpan<byte> chars_5489_621706Bytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x66,0xC7,0x01,0x35,0x00,0x66,0xC7,0x02,0x34,0x00,0x66,0x41,0xC7,0x00,0x38,0x00,0x66,0x41,0xC7,0x01,0x39,0x00,0xC3};
; [0x7ff7c8391000, 0x7ff7c839101c], 28 bytes
; 2020-01-20 01:59:20:973
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov word ptr [rcx],35h                  ; MOV r/m16, imm16 || o16 C7 /0 iw || encoded[5]{66 c7 01 35 00}
000ah mov word ptr [rdx],34h                  ; MOV r/m16, imm16 || o16 C7 /0 iw || encoded[5]{66 c7 02 34 00}
000fh mov word ptr [r8],38h                   ; MOV r/m16, imm16 || o16 C7 /0 iw || encoded[6]{66 41 c7 00 38 00}
0015h mov word ptr [r9],39h                   ; MOV r/m16, imm16 || o16 C7 /0 iw || encoded[6]{66 41 c7 01 39 00}
001bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void chars_80352178(out Char c7, out Char c6, out Char c5, out Char c4, out Char c3, out Char c2, out Char c1, out Char c0)
; static ReadOnlySpan<byte> chars_80352178_5595356Bytes => new byte[68]{0x0F,0x1F,0x44,0x00,0x00,0x66,0xC7,0x01,0x38,0x00,0x66,0xC7,0x02,0x30,0x00,0x66,0x41,0xC7,0x00,0x33,0x00,0x66,0x41,0xC7,0x01,0x35,0x00,0x48,0x8B,0x44,0x24,0x28,0x66,0xC7,0x00,0x32,0x00,0x48,0x8B,0x44,0x24,0x30,0x66,0xC7,0x00,0x31,0x00,0x48,0x8B,0x44,0x24,0x38,0x66,0xC7,0x00,0x37,0x00,0x48,0x8B,0x44,0x24,0x40,0x66,0xC7,0x00,0x38,0x00,0xC3};
; [0x7ff7c8391030, 0x7ff7c8391074], 68 bytes
; 2020-01-20 01:59:20:973
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov word ptr [rcx],38h                  ; MOV r/m16, imm16 || o16 C7 /0 iw || encoded[5]{66 c7 01 38 00}
000ah mov word ptr [rdx],30h                  ; MOV r/m16, imm16 || o16 C7 /0 iw || encoded[5]{66 c7 02 30 00}
000fh mov word ptr [r8],33h                   ; MOV r/m16, imm16 || o16 C7 /0 iw || encoded[6]{66 41 c7 00 33 00}
0015h mov word ptr [r9],35h                   ; MOV r/m16, imm16 || o16 C7 /0 iw || encoded[6]{66 41 c7 01 35 00}
001bh mov rax,[rsp+28h]                       ; MOV r64, r/m64 || REX.W 8B /r || encoded[5]{48 8b 44 24 28}
0020h mov word ptr [rax],32h                  ; MOV r/m16, imm16 || o16 C7 /0 iw || encoded[5]{66 c7 00 32 00}
0025h mov rax,[rsp+30h]                       ; MOV r64, r/m64 || REX.W 8B /r || encoded[5]{48 8b 44 24 30}
002ah mov word ptr [rax],31h                  ; MOV r/m16, imm16 || o16 C7 /0 iw || encoded[5]{66 c7 00 31 00}
002fh mov rax,[rsp+38h]                       ; MOV r64, r/m64 || REX.W 8B /r || encoded[5]{48 8b 44 24 38}
0034h mov word ptr [rax],37h                  ; MOV r/m16, imm16 || o16 C7 /0 iw || encoded[5]{66 c7 00 37 00}
0039h mov rax,[rsp+40h]                       ; MOV r64, r/m64 || REX.W 8B /r || encoded[5]{48 8b 44 24 40}
003eh mov word ptr [rax],38h                  ; MOV r/m16, imm16 || o16 C7 /0 iw || encoded[5]{66 c7 00 38 00}
0043h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ReadOnlySpan<Char> charspan_5489()
; static ReadOnlySpan<byte> charspan_5489_50358210Bytes => new byte[86]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0xB9,0x50,0x6D,0x0F,0xC8,0xF7,0x7F,0x00,0x00,0xBA,0x04,0x00,0x00,0x00,0xE8,0x34,0x5D,0x60,0x5F,0x48,0x83,0xC0,0x10,0xBA,0x04,0x00,0x00,0x00,0x48,0x8D,0x48,0x06,0x4C,0x8D,0x40,0x04,0x4C,0x8D,0x48,0x02,0x66,0xC7,0x01,0x35,0x00,0x66,0x41,0xC7,0x00,0x34,0x00,0x66,0x41,0xC7,0x01,0x38,0x00,0x66,0xC7,0x00,0x39,0x00,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
; [0x7ff7c8391090, 0x7ff7c83910e6], 86 bytes
; 2020-01-20 01:59:20:973
0000h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0001h sub rsp,20h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 20}
0005h mov rsi,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f1}
0008h mov rcx,7FF7C80F6D50h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 50 6d 0f c8 f7 7f 00 00}
0012h mov edx,4                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 04 00 00 00}
0017h call 7FF827996DE0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 34 5d 60 5f}
001ch add rax,10h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c0 10}
0020h mov edx,4                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 04 00 00 00}
0025h lea rcx,[rax+6]                         ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 48 06}
0029h lea r8,[rax+4]                          ; LEA r64, m || REX.W 8D /r || encoded[4]{4c 8d 40 04}
002dh lea r9,[rax+2]                          ; LEA r64, m || REX.W 8D /r || encoded[4]{4c 8d 48 02}
0031h mov word ptr [rcx],35h                  ; MOV r/m16, imm16 || o16 C7 /0 iw || encoded[5]{66 c7 01 35 00}
0036h mov word ptr [r8],34h                   ; MOV r/m16, imm16 || o16 C7 /0 iw || encoded[6]{66 41 c7 00 34 00}
003ch mov word ptr [r9],38h                   ; MOV r/m16, imm16 || o16 C7 /0 iw || encoded[6]{66 41 c7 01 38 00}
0042h mov word ptr [rax],39h                  ; MOV r/m16, imm16 || o16 C7 /0 iw || encoded[5]{66 c7 00 39 00}
0047h mov [rsi],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 06}
004ah mov [rsi+8],edx                         ; MOV r/m32, r32 || o32 89 /r || encoded[3]{89 56 08}
004dh mov rax,rsi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c6}
0050h add rsp,20h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 20}
0054h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
0055h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Char digit_decode_0()
; static ReadOnlySpan<byte> digit_decode_0_50570707Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x30,0x00,0x00,0x00,0xC3};
; [0x7ff7c8391100, 0x7ff7c839110b], 11 bytes
; 2020-01-20 01:59:20:973
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,30h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 30 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Char digit_decode_1()
; static ReadOnlySpan<byte> digit_decode_1_52483186Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x31,0x00,0x00,0x00,0xC3};
; [0x7ff7c8391120, 0x7ff7c839112b], 11 bytes
; 2020-01-20 01:59:20:973
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,31h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 31 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Char digit_decode_2()
; static ReadOnlySpan<byte> digit_decode_2_2586631Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x32,0x00,0x00,0x00,0xC3};
; [0x7ff7c8391140, 0x7ff7c839114b], 11 bytes
; 2020-01-20 01:59:20:973
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,32h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 32 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Char digit_decode_3()
; static ReadOnlySpan<byte> digit_decode_3_23279683Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x33,0x00,0x00,0x00,0xC3};
; [0x7ff7c8391160, 0x7ff7c839116b], 11 bytes
; 2020-01-20 01:59:20:973
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,33h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 33 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Char digit_decode_4()
; static ReadOnlySpan<byte> digit_decode_4_8190559Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x34,0x00,0x00,0x00,0xC3};
; [0x7ff7c8391180, 0x7ff7c839118b], 11 bytes
; 2020-01-20 01:59:20:973
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,34h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 34 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Char digit_decode_n4()
; static ReadOnlySpan<byte> digit_decode_n4_6606172Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x34,0x00,0x00,0x00,0xC3};
; [0x7ff7c83911a0, 0x7ff7c83911ab], 11 bytes
; 2020-01-20 01:59:20:973
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,34h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 34 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Char digit_decode_5()
; static ReadOnlySpan<byte> digit_decode_5_59455556Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x35,0x00,0x00,0x00,0xC3};
; [0x7ff7c83911c0, 0x7ff7c83911cb], 11 bytes
; 2020-01-20 01:59:20:973
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,35h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 35 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Char digit_decode_n5()
; static ReadOnlySpan<byte> digit_decode_n5_65337958Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x35,0x00,0x00,0x00,0xC3};
; [0x7ff7c83911e0, 0x7ff7c83911eb], 11 bytes
; 2020-01-20 01:59:20:973
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,35h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 35 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
