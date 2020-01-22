; 2020-01-22 01:43:39:212
; ulong nat_add()
; nat_add_42137308[0x7ff7c838e140, 0x7ff7c838e14b][11] = {0f 1f 44 00 00 b8 1c 00 00 00 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,1Ch                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 1c 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong nat_sub()
; nat_sub_57678784[0x7ff7c838f180, 0x7ff7c838f18b][11] = {0f 1f 44 00 00 b8 00 01 00 00 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,100h                            ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 00 01 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong nat_mul()
; nat_mul_49347015[0x7ff7c838f1a0, 0x7ff7c838f1ab][11] = {0f 1f 44 00 00 b8 c0 00 00 00 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,0C0h                            ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 c0 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong nat_div()
; nat_div_41469957[0x7ff7c838f1c0, 0x7ff7c838f1cb][11] = {0f 1f 44 00 00 b8 0a 00 00 00 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,0Ah                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 0a 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong nat_mod()
; nat_mod_37685299[0x7ff7c838f1e0, 0x7ff7c838f1eb][11] = {0f 1f 44 00 00 b8 02 00 00 00 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,2                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 02 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong digits_encode_1_0()
; digits_encode_1_0_3623379[0x7ff7c838f610, 0x7ff7c838f618][8] = {0f 1f 44 00 00 33 c0 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0007h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong digits_encode_1()
; digits_encode_1_32610412[0x7ff7c838f630, 0x7ff7c838f63b][11] = {0f 1f 44 00 00 b8 01 00 00 00 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,1                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 01 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong digits_encode_2()
; digits_encode_2_25058257[0x7ff7c838f650, 0x7ff7c838f65b][11] = {0f 1f 44 00 00 b8 02 00 00 00 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,2                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 02 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong digits_encode_3()
; digits_encode_3_24197721[0x7ff7c838f670, 0x7ff7c838f67b][11] = {0f 1f 44 00 00 b8 03 00 00 00 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,3                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 03 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong digits_encode_10()
; digits_encode_10_16452903[0x7ff7c838f690, 0x7ff7c838f69b][11] = {0f 1f 44 00 00 b8 10 00 00 00 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,10h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 10 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong digits_encode_210()
; digits_encode_210_13858403[0x7ff7c838f6b0, 0x7ff7c838f6bb][11] = {0f 1f 44 00 00 b8 10 02 00 00 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,210h                            ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 10 02 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong digits_encode_3210()
; digits_encode_3210_57616766[0x7ff7c838f6d0, 0x7ff7c838f6db][11] = {0f 1f 44 00 00 b8 10 32 00 00 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,3210h                           ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 10 32 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong digits_encode_43210()
; digits_encode_43210_48788849[0x7ff7c838f6f0, 0x7ff7c838f6fb][11] = {0f 1f 44 00 00 b8 10 32 04 00 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,43210h                          ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 10 32 04 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong digits_encode_76543210()
; digits_encode_76543210_36446461[0x7ff7c838f710, 0x7ff7c838f71b][11] = {0f 1f 44 00 00 b8 10 32 54 76 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,76543210h                       ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 10 32 54 76}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong digit_extract_9()
; digit_extract_9_59582700[0x7ff7c838f730, 0x7ff7c838f73b][11] = {0f 1f 44 00 00 b8 09 00 00 00 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,9                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 09 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong digit_extract_4()
; digit_extract_4_66482253[0x7ff7c838f750, 0x7ff7c838f75b][11] = {0f 1f 44 00 00 b8 04 00 00 00 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,4                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 04 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong digit_extract_8()
; digit_extract_8_61469371[0x7ff7c838f770, 0x7ff7c838f77b][11] = {0f 1f 44 00 00 b8 08 00 00 00 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,8                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 08 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ulong digit_extract_5()
; digit_extract_5_16353430[0x7ff7c838f790, 0x7ff7c838f79b][11] = {0f 1f 44 00 00 b8 05 00 00 00 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,5                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 05 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void digits_extract_5849(out byte d3, out byte d2, out byte d1, out byte d0)
; digits_extract_5849_8u[0x7ff7c838f7b0, 0x7ff7c838f7c4][20] = {0f 1f 44 00 00 c6 01 05 c6 02 08 41 c6 00 04 41 c6 01 09 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov byte ptr [rcx],5                    ; MOV r/m8, imm8 || C6 /0 ib || encoded[3]{c6 01 05}
0008h mov byte ptr [rdx],8                    ; MOV r/m8, imm8 || C6 /0 ib || encoded[3]{c6 02 08}
000bh mov byte ptr [r8],4                     ; MOV r/m8, imm8 || C6 /0 ib || encoded[4]{41 c6 00 04}
000fh mov byte ptr [r9],9                     ; MOV r/m8, imm8 || C6 /0 ib || encoded[4]{41 c6 01 09}
0013h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void digits_extract_5489_ref(ref byte dst)
; digits_extract_5489_ref_8u[0x7ff7c838f7e0, 0x7ff7c838f7fe][30] = {0f 1f 44 00 00 48 8d 41 03 c6 00 05 48 8d 41 02 c6 00 08 48 8d 41 01 c6 00 04 c6 01 09 c3}
; Capture completion code, None
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
; digits_extract_80352178_8u[0x7ff7c838f810, 0x7ff7c838f844][52] = {0f 1f 44 00 00 48 8b 44 24 28 c6 00 02 48 8b 44 24 30 c6 00 01 48 8b 44 24 38 c6 00 07 48 8b 44 24 40 c6 00 08 c6 01 08 c6 02 00 41 c6 00 03 41 c6 01 05 c3}
; Capture completion code, None
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
; chars_5489_49559423[0x7ff7c838f860, 0x7ff7c838f87c][28] = {0f 1f 44 00 00 66 c7 01 35 00 66 c7 02 34 00 66 41 c7 00 38 00 66 41 c7 01 39 00 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov word ptr [rcx],35h                  ; MOV r/m16, imm16 || o16 C7 /0 iw || encoded[5]{66 c7 01 35 00}
000ah mov word ptr [rdx],34h                  ; MOV r/m16, imm16 || o16 C7 /0 iw || encoded[5]{66 c7 02 34 00}
000fh mov word ptr [r8],38h                   ; MOV r/m16, imm16 || o16 C7 /0 iw || encoded[6]{66 41 c7 00 38 00}
0015h mov word ptr [r9],39h                   ; MOV r/m16, imm16 || o16 C7 /0 iw || encoded[6]{66 41 c7 01 39 00}
001bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void chars_80352178(out Char c7, out Char c6, out Char c5, out Char c4, out Char c3, out Char c2, out Char c1, out Char c0)
; chars_80352178_43381623[0x7ff7c838f890, 0x7ff7c838f8d4][68] = {0f 1f 44 00 00 66 c7 01 38 00 66 c7 02 30 00 66 41 c7 00 33 00 66 41 c7 01 35 00 48 8b 44 24 28 66 c7 00 32 00 48 8b 44 24 30 66 c7 00 31 00 48 8b 44 24 38 66 c7 00 37 00 48 8b 44 24 40 66 c7 00 38 00 c3}
; Capture completion code, None
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
; charspan_5489_54890288[0x7ff7c838f8f0, 0x7ff7c838f946][86] = {56 48 83 ec 20 48 8b f1 48 b9 b8 80 10 c8 f7 7f 00 00 ba 04 00 00 00 e8 d4 74 60 5f 48 83 c0 10 ba 04 00 00 00 48 8d 48 06 4c 8d 40 04 4c 8d 48 02 66 c7 01 35 00 66 41 c7 00 34 00 66 41 c7 01 38 00 66 c7 00 39 00 48 89 06 89 56 08 48 8b c6 48 83 c4 20 5e c3}
; Capture completion code, None
0000h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0001h sub rsp,20h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 20}
0005h mov rsi,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f1}
0008h mov rcx,7FF7C81080B8h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 b8 80 10 c8 f7 7f 00 00}
0012h mov edx,4                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 04 00 00 00}
0017h call 7FF827996DE0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 d4 74 60 5f}
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
; digit_decode_0_24250547[0x7ff7c838f960, 0x7ff7c838f96b][11] = {0f 1f 44 00 00 b8 30 00 00 00 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,30h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 30 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Char digit_decode_1()
; digit_decode_1_16928338[0x7ff7c838f980, 0x7ff7c838f98b][11] = {0f 1f 44 00 00 b8 31 00 00 00 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,31h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 31 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Char digit_decode_2()
; digit_decode_2_18137316[0x7ff7c838f9a0, 0x7ff7c838f9ab][11] = {0f 1f 44 00 00 b8 32 00 00 00 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,32h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 32 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Char digit_decode_3()
; digit_decode_3_29018124[0x7ff7c838f9c0, 0x7ff7c838f9cb][11] = {0f 1f 44 00 00 b8 33 00 00 00 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,33h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 33 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Char digit_decode_4()
; digit_decode_4_59836530[0x7ff7c838f9e0, 0x7ff7c838f9eb][11] = {0f 1f 44 00 00 b8 34 00 00 00 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,34h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 34 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Char digit_decode_n4()
; digit_decode_n4_1657863[0x7ff7c838fa00, 0x7ff7c838fa0b][11] = {0f 1f 44 00 00 b8 34 00 00 00 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,34h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 34 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Char digit_decode_5()
; digit_decode_5_14920772[0x7ff7c838fa20, 0x7ff7c838fa2b][11] = {0f 1f 44 00 00 b8 35 00 00 00 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,35h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 35 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; Char digit_decode_n5()
; digit_decode_n5_69227[0x7ff7c838fa40, 0x7ff7c838fa4b][11] = {0f 1f 44 00 00 b8 35 00 00 00 c3}
; Capture completion code, None
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov eax,35h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{b8 35 00 00 00}
000ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
