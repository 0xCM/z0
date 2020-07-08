------------------------------------------------------------------------------------------------------------------------
; IEnumerator<byte> enumerator<byte>(IEnumerable<byte> src), located://konst/sys?enumerator#enumerator_g[8u](IEnumerable[byte])
; public static ReadOnlySpan<byte> enumerator_gᐸ8uᐳᐤIEnumerableᐸbyteᐳᐤ => new byte[35]{0x48,0x83,0xec,0x28,0x90,0x49,0xbb,0xf8,0x14,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x48,0xb8,0xf8,0x14,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x39,0x09,0xff,0x10,0x90,0x48,0x83,0xc4,0x28,0xc3};
; Base = 7ff9ac39b600h
; TermCode = CTC_RET_ZED_SBB
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov r11,7ff9aaf614f8h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 bb f8 14 f6 aa f9 7f 00 00}
000fh mov rax,7ff9aaf614f8h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 f8 14 f6 aa f9 7f 00 00}
0019h cmp [rcx],ecx                           ; CMP r/m32, r32 || o32 39 /r || encoded[2]{39 09}
001bh call qword ptr [rax]                    ; CALL r/m64 || FF /2 || encoded[2]{ff 10}
001dh nop                                     ; NOP || o32 90 || encoded[1]{90}
001eh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0022h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; bool next<byte>(IEnumerator<byte> src), located://konst/sys?next#next_g[8u](IEnumerator[byte])
; public static ReadOnlySpan<byte> next_gᐸ8uᐳᐤIEnumeratorᐸbyteᐳᐤ => new byte[35]{0x48,0x83,0xec,0x28,0x90,0x49,0xbb,0x38,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x48,0xb8,0x38,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x39,0x09,0xff,0x10,0x90,0x48,0x83,0xc4,0x28,0xc3};
; Base = 7ff9ac39b800h
; TermCode = CTC_RET_ZED_SBB
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov r11,7ff9aaf61538h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 bb 38 15 f6 aa f9 7f 00 00}
000fh mov rax,7ff9aaf61538h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 38 15 f6 aa f9 7f 00 00}
0019h cmp [rcx],ecx                           ; CMP r/m32, r32 || o32 39 /r || encoded[2]{39 09}
001bh call qword ptr [rax]                    ; CALL r/m64 || FF /2 || encoded[2]{ff 10}
001dh nop                                     ; NOP || o32 90 || encoded[1]{90}
001eh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0022h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; byte current<byte>(IEnumerator<byte> src), located://konst/sys?current#current_g[8u](IEnumerator[byte])
; public static ReadOnlySpan<byte> current_gᐸ8uᐳᐤIEnumeratorᐸbyteᐳᐤ => new byte[35]{0x48,0x83,0xec,0x28,0x90,0x49,0xbb,0x78,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x48,0xb8,0x78,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x39,0x09,0xff,0x10,0x90,0x48,0x83,0xc4,0x28,0xc3};
; Base = 7ff9ac39ba00h
; TermCode = CTC_RET_ZED_SBB
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov r11,7ff9aaf61578h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 bb 78 15 f6 aa f9 7f 00 00}
000fh mov rax,7ff9aaf61578h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 78 15 f6 aa f9 7f 00 00}
0019h cmp [rcx],ecx                           ; CMP r/m32, r32 || o32 39 /r || encoded[2]{39 09}
001bh call qword ptr [rax]                    ; CALL r/m64 || FF /2 || encoded[2]{ff 10}
001dh nop                                     ; NOP || o32 90 || encoded[1]{90}
001eh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0022h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; Span<byte> store<byte>(IEnumerable<byte> src, Span<byte> dst), located://konst/core?store#store_g[8u](IEnumerable[byte],span8u)
; public static ReadOnlySpan<byte> store_gᐸ8uᐳᐤIEnumerableᐸbyteᐳㆍspan8uᐤ => new byte[87]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x20,0x48,0x8b,0xf1,0x49,0x8b,0x38,0x41,0x8b,0x58,0x08,0x48,0x8b,0xca,0xe8,0x0c,0xfd,0xff,0xff,0x48,0x8b,0xe8,0xeb,0x0e,0x4c,0x8b,0xf7,0x48,0x8b,0xcd,0xe8,0x4c,0xfd,0xff,0xff,0x41,0x88,0x06,0x48,0x8b,0xcd,0xe8,0x11,0xfd,0xff,0xff,0x85,0xc0,0x74,0x08,0x48,0x63,0xcb,0x48,0x85,0xc9,0x7f,0xde,0x48,0x89,0x3e,0x89,0x5e,0x08,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x20,0x5b,0x5d,0x5e,0x5f,0x41,0x5e,0xc3};
; Base = 7ff9ac379670h
; TermCode = CTC_RET_ZED_SBB
0000h push r14                                ; PUSH r64 || 50+ro || encoded[2]{41 56}
0002h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0003h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0004h push rbp                                ; PUSH r64 || 50+ro || encoded[1]{55}
0005h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0006h sub rsp,20h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 20}
000ah mov rsi,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f1}
000dh mov rdi,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b 38}
0010h mov ebx,[r8+8]                          ; MOV r32, r/m32 || o32 8B /r || encoded[4]{41 8b 58 08}
0014h mov rcx,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b ca}
0017h call 7ff9ac379398h (enumerator:7ff9ac39b600h)      ; CALL rel32 || E8 cd || encoded[5]{e8 0c fd ff ff}
001ch mov rbp,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b e8}
001fh jmp short 002fh                         ; JMP rel8 || EB cb || encoded[2]{eb 0e}
0021h mov r14,rdi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b f7}
0024h mov rcx,rbp                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b cd}
0027h call 7ff9ac3793e8h  (current:7ff9ac39ba00h)     ; CALL rel32 || E8 cd || encoded[5]{e8 4c fd ff ff}
002ch mov [r14],al                            ; MOV r/m8, r8 || 88 /r || encoded[3]{41 88 06}
002fh mov rcx,rbp                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b cd}
0032h call 7ff9ac3793b8h (next:7ff9ac39b800h)      ; CALL rel32 || E8 cd || encoded[5]{e8 11 fd ff ff}
0037h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
0039h je short 0043h                          ; JE rel8 || 74 cb || encoded[2]{74 08}
003bh movsxd rcx,ebx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 cb}
003eh test rcx,rcx                            ; TEST r/m64, r64 || REX.W 85 /r || encoded[3]{48 85 c9}
0041h jg short 0021h                          ; JG rel8 || 7F cb || encoded[2]{7f de}
0043h mov [rsi],rdi                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 3e}
0046h mov [rsi+8],ebx                         ; MOV r/m32, r32 || o32 89 /r || encoded[3]{89 5e 08}
0049h mov rax,rsi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c6}
004ch add rsp,20h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 20}
0050h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
0051h pop rbp                                 ; POP r64 || 58+ro || encoded[1]{5d}
0052h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
0053h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
0054h pop r14                                 ; POP r64 || 58+ro || encoded[2]{41 5e}
0056h ret                                     ; RET || C3 || encoded[1]{c3}
