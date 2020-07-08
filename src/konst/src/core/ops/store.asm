------------------------------------------------------------------------------------------------------------------------
; IEnumerator<sbyte> enumerator<sbyte>(IEnumerable<sbyte> src), located://konst/sys?enumerator#enumerator_g[8i](IEnumerable[sbyte])
; public static ReadOnlySpan<byte> enumerator_gᐸ8iᐳᐤIEnumerableᐸsbyteᐳᐤ => new byte[35]{0x48,0x83,0xec,0x28,0x90,0x49,0xbb,0x00,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x48,0xb8,0x00,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x39,0x09,0xff,0x10,0x90,0x48,0x83,0xc4,0x28,0xc3};
; Base = 7ff9ac39b640h
; TermCode = CTC_RET_ZED_SBB
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov r11,7ff9aaf61500h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 bb 00 15 f6 aa f9 7f 00 00}
000fh mov rax,7ff9aaf61500h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 00 15 f6 aa f9 7f 00 00}
0019h cmp [rcx],ecx                           ; CMP r/m32, r32 || o32 39 /r || encoded[2]{39 09}
001bh call qword ptr [rax]                    ; CALL r/m64 || FF /2 || encoded[2]{ff 10}
001dh nop                                     ; NOP || o32 90 || encoded[1]{90}
001eh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0022h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; IEnumerator<ushort> enumerator<ushort>(IEnumerable<ushort> src), located://konst/sys?enumerator#enumerator_g[16u](IEnumerable[ushort])
; public static ReadOnlySpan<byte> enumerator_gᐸ16uᐳᐤIEnumerableᐸushortᐳᐤ => new byte[35]{0x48,0x83,0xec,0x28,0x90,0x49,0xbb,0x08,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x48,0xb8,0x08,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x39,0x09,0xff,0x10,0x90,0x48,0x83,0xc4,0x28,0xc3};
; Base = 7ff9ac39b680h
; TermCode = CTC_RET_ZED_SBB
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov r11,7ff9aaf61508h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 bb 08 15 f6 aa f9 7f 00 00}
000fh mov rax,7ff9aaf61508h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 08 15 f6 aa f9 7f 00 00}
0019h cmp [rcx],ecx                           ; CMP r/m32, r32 || o32 39 /r || encoded[2]{39 09}
001bh call qword ptr [rax]                    ; CALL r/m64 || FF /2 || encoded[2]{ff 10}
001dh nop                                     ; NOP || o32 90 || encoded[1]{90}
001eh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0022h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; IEnumerator<short> enumerator<short>(IEnumerable<short> src), located://konst/sys?enumerator#enumerator_g[16i](IEnumerable[short])
; public static ReadOnlySpan<byte> enumerator_gᐸ16iᐳᐤIEnumerableᐸshortᐳᐤ => new byte[35]{0x48,0x83,0xec,0x28,0x90,0x49,0xbb,0x10,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x48,0xb8,0x10,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x39,0x09,0xff,0x10,0x90,0x48,0x83,0xc4,0x28,0xc3};
; Base = 7ff9ac39b6c0h
; TermCode = CTC_RET_ZED_SBB
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov r11,7ff9aaf61510h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 bb 10 15 f6 aa f9 7f 00 00}
000fh mov rax,7ff9aaf61510h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 10 15 f6 aa f9 7f 00 00}
0019h cmp [rcx],ecx                           ; CMP r/m32, r32 || o32 39 /r || encoded[2]{39 09}
001bh call qword ptr [rax]                    ; CALL r/m64 || FF /2 || encoded[2]{ff 10}
001dh nop                                     ; NOP || o32 90 || encoded[1]{90}
001eh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0022h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; IEnumerator<uint> enumerator<uint>(IEnumerable<uint> src), located://konst/sys?enumerator#enumerator_g[32u](IEnumerable[uint])
; public static ReadOnlySpan<byte> enumerator_gᐸ32uᐳᐤIEnumerableᐸuintᐳᐤ => new byte[35]{0x48,0x83,0xec,0x28,0x90,0x49,0xbb,0x18,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x48,0xb8,0x18,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x39,0x09,0xff,0x10,0x90,0x48,0x83,0xc4,0x28,0xc3};
; Base = 7ff9ac39b700h
; TermCode = CTC_RET_ZED_SBB
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov r11,7ff9aaf61518h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 bb 18 15 f6 aa f9 7f 00 00}
000fh mov rax,7ff9aaf61518h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 18 15 f6 aa f9 7f 00 00}
0019h cmp [rcx],ecx                           ; CMP r/m32, r32 || o32 39 /r || encoded[2]{39 09}
001bh call qword ptr [rax]                    ; CALL r/m64 || FF /2 || encoded[2]{ff 10}
001dh nop                                     ; NOP || o32 90 || encoded[1]{90}
001eh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0022h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; IEnumerator<int> enumerator<int>(IEnumerable<int> src), located://konst/sys?enumerator#enumerator_g[32i](IEnumerable[int])
; public static ReadOnlySpan<byte> enumerator_gᐸ32iᐳᐤIEnumerableᐸintᐳᐤ => new byte[35]{0x48,0x83,0xec,0x28,0x90,0x49,0xbb,0x20,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x48,0xb8,0x20,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x39,0x09,0xff,0x10,0x90,0x48,0x83,0xc4,0x28,0xc3};
; Base = 7ff9ac39b740h
; TermCode = CTC_RET_ZED_SBB
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov r11,7ff9aaf61520h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 bb 20 15 f6 aa f9 7f 00 00}
000fh mov rax,7ff9aaf61520h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 20 15 f6 aa f9 7f 00 00}
0019h cmp [rcx],ecx                           ; CMP r/m32, r32 || o32 39 /r || encoded[2]{39 09}
001bh call qword ptr [rax]                    ; CALL r/m64 || FF /2 || encoded[2]{ff 10}
001dh nop                                     ; NOP || o32 90 || encoded[1]{90}
001eh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0022h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; IEnumerator<ulong> enumerator<ulong>(IEnumerable<ulong> src), located://konst/sys?enumerator#enumerator_g[64u](IEnumerable[ulong])
; public static ReadOnlySpan<byte> enumerator_gᐸ64uᐳᐤIEnumerableᐸulongᐳᐤ => new byte[35]{0x48,0x83,0xec,0x28,0x90,0x49,0xbb,0x28,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x48,0xb8,0x28,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x39,0x09,0xff,0x10,0x90,0x48,0x83,0xc4,0x28,0xc3};
; Base = 7ff9ac39b780h
; TermCode = CTC_RET_ZED_SBB
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov r11,7ff9aaf61528h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 bb 28 15 f6 aa f9 7f 00 00}
000fh mov rax,7ff9aaf61528h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 28 15 f6 aa f9 7f 00 00}
0019h cmp [rcx],ecx                           ; CMP r/m32, r32 || o32 39 /r || encoded[2]{39 09}
001bh call qword ptr [rax]                    ; CALL r/m64 || FF /2 || encoded[2]{ff 10}
001dh nop                                     ; NOP || o32 90 || encoded[1]{90}
001eh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0022h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; IEnumerator<long> enumerator<long>(IEnumerable<long> src), located://konst/sys?enumerator#enumerator_g[64i](IEnumerable[long])
; public static ReadOnlySpan<byte> enumerator_gᐸ64iᐳᐤIEnumerableᐸlongᐳᐤ => new byte[35]{0x48,0x83,0xec,0x28,0x90,0x49,0xbb,0x30,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x48,0xb8,0x30,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x39,0x09,0xff,0x10,0x90,0x48,0x83,0xc4,0x28,0xc3};
; Base = 7ff9ac39b7c0h
; TermCode = CTC_RET_ZED_SBB
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov r11,7ff9aaf61530h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 bb 30 15 f6 aa f9 7f 00 00}
000fh mov rax,7ff9aaf61530h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 30 15 f6 aa f9 7f 00 00}
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
; bool next<sbyte>(IEnumerator<sbyte> src), located://konst/sys?next#next_g[8i](IEnumerator[sbyte])
; public static ReadOnlySpan<byte> next_gᐸ8iᐳᐤIEnumeratorᐸsbyteᐳᐤ => new byte[35]{0x48,0x83,0xec,0x28,0x90,0x49,0xbb,0x40,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x48,0xb8,0x40,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x39,0x09,0xff,0x10,0x90,0x48,0x83,0xc4,0x28,0xc3};
; Base = 7ff9ac39b840h
; TermCode = CTC_RET_ZED_SBB
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov r11,7ff9aaf61540h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 bb 40 15 f6 aa f9 7f 00 00}
000fh mov rax,7ff9aaf61540h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 40 15 f6 aa f9 7f 00 00}
0019h cmp [rcx],ecx                           ; CMP r/m32, r32 || o32 39 /r || encoded[2]{39 09}
001bh call qword ptr [rax]                    ; CALL r/m64 || FF /2 || encoded[2]{ff 10}
001dh nop                                     ; NOP || o32 90 || encoded[1]{90}
001eh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0022h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; bool next<ushort>(IEnumerator<ushort> src), located://konst/sys?next#next_g[16u](IEnumerator[ushort])
; public static ReadOnlySpan<byte> next_gᐸ16uᐳᐤIEnumeratorᐸushortᐳᐤ => new byte[35]{0x48,0x83,0xec,0x28,0x90,0x49,0xbb,0x48,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x48,0xb8,0x48,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x39,0x09,0xff,0x10,0x90,0x48,0x83,0xc4,0x28,0xc3};
; Base = 7ff9ac39b880h
; TermCode = CTC_RET_ZED_SBB
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov r11,7ff9aaf61548h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 bb 48 15 f6 aa f9 7f 00 00}
000fh mov rax,7ff9aaf61548h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 48 15 f6 aa f9 7f 00 00}
0019h cmp [rcx],ecx                           ; CMP r/m32, r32 || o32 39 /r || encoded[2]{39 09}
001bh call qword ptr [rax]                    ; CALL r/m64 || FF /2 || encoded[2]{ff 10}
001dh nop                                     ; NOP || o32 90 || encoded[1]{90}
001eh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0022h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; bool next<short>(IEnumerator<short> src), located://konst/sys?next#next_g[16i](IEnumerator[short])
; public static ReadOnlySpan<byte> next_gᐸ16iᐳᐤIEnumeratorᐸshortᐳᐤ => new byte[35]{0x48,0x83,0xec,0x28,0x90,0x49,0xbb,0x50,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x48,0xb8,0x50,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x39,0x09,0xff,0x10,0x90,0x48,0x83,0xc4,0x28,0xc3};
; Base = 7ff9ac39b8c0h
; TermCode = CTC_RET_ZED_SBB
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov r11,7ff9aaf61550h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 bb 50 15 f6 aa f9 7f 00 00}
000fh mov rax,7ff9aaf61550h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 50 15 f6 aa f9 7f 00 00}
0019h cmp [rcx],ecx                           ; CMP r/m32, r32 || o32 39 /r || encoded[2]{39 09}
001bh call qword ptr [rax]                    ; CALL r/m64 || FF /2 || encoded[2]{ff 10}
001dh nop                                     ; NOP || o32 90 || encoded[1]{90}
001eh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0022h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; bool next<uint>(IEnumerator<uint> src), located://konst/sys?next#next_g[32u](IEnumerator[uint])
; public static ReadOnlySpan<byte> next_gᐸ32uᐳᐤIEnumeratorᐸuintᐳᐤ => new byte[35]{0x48,0x83,0xec,0x28,0x90,0x49,0xbb,0x58,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x48,0xb8,0x58,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x39,0x09,0xff,0x10,0x90,0x48,0x83,0xc4,0x28,0xc3};
; Base = 7ff9ac39b900h
; TermCode = CTC_RET_ZED_SBB
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov r11,7ff9aaf61558h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 bb 58 15 f6 aa f9 7f 00 00}
000fh mov rax,7ff9aaf61558h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 58 15 f6 aa f9 7f 00 00}
0019h cmp [rcx],ecx                           ; CMP r/m32, r32 || o32 39 /r || encoded[2]{39 09}
001bh call qword ptr [rax]                    ; CALL r/m64 || FF /2 || encoded[2]{ff 10}
001dh nop                                     ; NOP || o32 90 || encoded[1]{90}
001eh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0022h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; bool next<int>(IEnumerator<int> src), located://konst/sys?next#next_g[32i](IEnumerator[int])
; public static ReadOnlySpan<byte> next_gᐸ32iᐳᐤIEnumeratorᐸintᐳᐤ => new byte[35]{0x48,0x83,0xec,0x28,0x90,0x49,0xbb,0x60,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x48,0xb8,0x60,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x39,0x09,0xff,0x10,0x90,0x48,0x83,0xc4,0x28,0xc3};
; Base = 7ff9ac39b940h
; TermCode = CTC_RET_ZED_SBB
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov r11,7ff9aaf61560h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 bb 60 15 f6 aa f9 7f 00 00}
000fh mov rax,7ff9aaf61560h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 60 15 f6 aa f9 7f 00 00}
0019h cmp [rcx],ecx                           ; CMP r/m32, r32 || o32 39 /r || encoded[2]{39 09}
001bh call qword ptr [rax]                    ; CALL r/m64 || FF /2 || encoded[2]{ff 10}
001dh nop                                     ; NOP || o32 90 || encoded[1]{90}
001eh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0022h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; bool next<ulong>(IEnumerator<ulong> src), located://konst/sys?next#next_g[64u](IEnumerator[ulong])
; public static ReadOnlySpan<byte> next_gᐸ64uᐳᐤIEnumeratorᐸulongᐳᐤ => new byte[35]{0x48,0x83,0xec,0x28,0x90,0x49,0xbb,0x68,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x48,0xb8,0x68,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x39,0x09,0xff,0x10,0x90,0x48,0x83,0xc4,0x28,0xc3};
; Base = 7ff9ac39b980h
; TermCode = CTC_RET_ZED_SBB
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov r11,7ff9aaf61568h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 bb 68 15 f6 aa f9 7f 00 00}
000fh mov rax,7ff9aaf61568h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 68 15 f6 aa f9 7f 00 00}
0019h cmp [rcx],ecx                           ; CMP r/m32, r32 || o32 39 /r || encoded[2]{39 09}
001bh call qword ptr [rax]                    ; CALL r/m64 || FF /2 || encoded[2]{ff 10}
001dh nop                                     ; NOP || o32 90 || encoded[1]{90}
001eh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0022h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; bool next<long>(IEnumerator<long> src), located://konst/sys?next#next_g[64i](IEnumerator[long])
; public static ReadOnlySpan<byte> next_gᐸ64iᐳᐤIEnumeratorᐸlongᐳᐤ => new byte[35]{0x48,0x83,0xec,0x28,0x90,0x49,0xbb,0x70,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x48,0xb8,0x70,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x39,0x09,0xff,0x10,0x90,0x48,0x83,0xc4,0x28,0xc3};
; Base = 7ff9ac39b9c0h
; TermCode = CTC_RET_ZED_SBB
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov r11,7ff9aaf61570h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 bb 70 15 f6 aa f9 7f 00 00}
000fh mov rax,7ff9aaf61570h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 70 15 f6 aa f9 7f 00 00}
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
; sbyte current<sbyte>(IEnumerator<sbyte> src), located://konst/sys?current#current_g[8i](IEnumerator[sbyte])
; public static ReadOnlySpan<byte> current_gᐸ8iᐳᐤIEnumeratorᐸsbyteᐳᐤ => new byte[35]{0x48,0x83,0xec,0x28,0x90,0x49,0xbb,0x80,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x48,0xb8,0x80,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x39,0x09,0xff,0x10,0x90,0x48,0x83,0xc4,0x28,0xc3};
; Base = 7ff9ac39ba40h
; TermCode = CTC_RET_ZED_SBB
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov r11,7ff9aaf61580h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 bb 80 15 f6 aa f9 7f 00 00}
000fh mov rax,7ff9aaf61580h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 80 15 f6 aa f9 7f 00 00}
0019h cmp [rcx],ecx                           ; CMP r/m32, r32 || o32 39 /r || encoded[2]{39 09}
001bh call qword ptr [rax]                    ; CALL r/m64 || FF /2 || encoded[2]{ff 10}
001dh nop                                     ; NOP || o32 90 || encoded[1]{90}
001eh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0022h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; ushort current<ushort>(IEnumerator<ushort> src), located://konst/sys?current#current_g[16u](IEnumerator[ushort])
; public static ReadOnlySpan<byte> current_gᐸ16uᐳᐤIEnumeratorᐸushortᐳᐤ => new byte[35]{0x48,0x83,0xec,0x28,0x90,0x49,0xbb,0x88,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x48,0xb8,0x88,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x39,0x09,0xff,0x10,0x90,0x48,0x83,0xc4,0x28,0xc3};
; Base = 7ff9ac39ba80h
; TermCode = CTC_RET_ZED_SBB
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov r11,7ff9aaf61588h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 bb 88 15 f6 aa f9 7f 00 00}
000fh mov rax,7ff9aaf61588h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 88 15 f6 aa f9 7f 00 00}
0019h cmp [rcx],ecx                           ; CMP r/m32, r32 || o32 39 /r || encoded[2]{39 09}
001bh call qword ptr [rax]                    ; CALL r/m64 || FF /2 || encoded[2]{ff 10}
001dh nop                                     ; NOP || o32 90 || encoded[1]{90}
001eh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0022h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; short current<short>(IEnumerator<short> src), located://konst/sys?current#current_g[16i](IEnumerator[short])
; public static ReadOnlySpan<byte> current_gᐸ16iᐳᐤIEnumeratorᐸshortᐳᐤ => new byte[35]{0x48,0x83,0xec,0x28,0x90,0x49,0xbb,0x90,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x48,0xb8,0x90,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x39,0x09,0xff,0x10,0x90,0x48,0x83,0xc4,0x28,0xc3};
; Base = 7ff9ac39bac0h
; TermCode = CTC_RET_ZED_SBB
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov r11,7ff9aaf61590h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 bb 90 15 f6 aa f9 7f 00 00}
000fh mov rax,7ff9aaf61590h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 90 15 f6 aa f9 7f 00 00}
0019h cmp [rcx],ecx                           ; CMP r/m32, r32 || o32 39 /r || encoded[2]{39 09}
001bh call qword ptr [rax]                    ; CALL r/m64 || FF /2 || encoded[2]{ff 10}
001dh nop                                     ; NOP || o32 90 || encoded[1]{90}
001eh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0022h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; uint current<uint>(IEnumerator<uint> src), located://konst/sys?current#current_g[32u](IEnumerator[uint])
; public static ReadOnlySpan<byte> current_gᐸ32uᐳᐤIEnumeratorᐸuintᐳᐤ => new byte[35]{0x48,0x83,0xec,0x28,0x90,0x49,0xbb,0x98,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x48,0xb8,0x98,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x39,0x09,0xff,0x10,0x90,0x48,0x83,0xc4,0x28,0xc3};
; Base = 7ff9ac39bb00h
; TermCode = CTC_RET_ZED_SBB
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov r11,7ff9aaf61598h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 bb 98 15 f6 aa f9 7f 00 00}
000fh mov rax,7ff9aaf61598h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 98 15 f6 aa f9 7f 00 00}
0019h cmp [rcx],ecx                           ; CMP r/m32, r32 || o32 39 /r || encoded[2]{39 09}
001bh call qword ptr [rax]                    ; CALL r/m64 || FF /2 || encoded[2]{ff 10}
001dh nop                                     ; NOP || o32 90 || encoded[1]{90}
001eh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0022h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; int current<int>(IEnumerator<int> src), located://konst/sys?current#current_g[32i](IEnumerator[int])
; public static ReadOnlySpan<byte> current_gᐸ32iᐳᐤIEnumeratorᐸintᐳᐤ => new byte[35]{0x48,0x83,0xec,0x28,0x90,0x49,0xbb,0xa0,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x48,0xb8,0xa0,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x39,0x09,0xff,0x10,0x90,0x48,0x83,0xc4,0x28,0xc3};
; Base = 7ff9ac39bb40h
; TermCode = CTC_RET_ZED_SBB
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov r11,7ff9aaf615a0h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 bb a0 15 f6 aa f9 7f 00 00}
000fh mov rax,7ff9aaf615a0h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 a0 15 f6 aa f9 7f 00 00}
0019h cmp [rcx],ecx                           ; CMP r/m32, r32 || o32 39 /r || encoded[2]{39 09}
001bh call qword ptr [rax]                    ; CALL r/m64 || FF /2 || encoded[2]{ff 10}
001dh nop                                     ; NOP || o32 90 || encoded[1]{90}
001eh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0022h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; ulong current<ulong>(IEnumerator<ulong> src), located://konst/sys?current#current_g[64u](IEnumerator[ulong])
; public static ReadOnlySpan<byte> current_gᐸ64uᐳᐤIEnumeratorᐸulongᐳᐤ => new byte[35]{0x48,0x83,0xec,0x28,0x90,0x49,0xbb,0xa8,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x48,0xb8,0xa8,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x39,0x09,0xff,0x10,0x90,0x48,0x83,0xc4,0x28,0xc3};
; Base = 7ff9ac39bb80h
; TermCode = CTC_RET_ZED_SBB
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov r11,7ff9aaf615a8h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 bb a8 15 f6 aa f9 7f 00 00}
000fh mov rax,7ff9aaf615a8h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 a8 15 f6 aa f9 7f 00 00}
0019h cmp [rcx],ecx                           ; CMP r/m32, r32 || o32 39 /r || encoded[2]{39 09}
001bh call qword ptr [rax]                    ; CALL r/m64 || FF /2 || encoded[2]{ff 10}
001dh nop                                     ; NOP || o32 90 || encoded[1]{90}
001eh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0022h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; long current<long>(IEnumerator<long> src), located://konst/sys?current#current_g[64i](IEnumerator[long])
; public static ReadOnlySpan<byte> current_gᐸ64iᐳᐤIEnumeratorᐸlongᐳᐤ => new byte[35]{0x48,0x83,0xec,0x28,0x90,0x49,0xbb,0xb0,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x48,0xb8,0xb0,0x15,0xf6,0xaa,0xf9,0x7f,0x00,0x00,0x39,0x09,0xff,0x10,0x90,0x48,0x83,0xc4,0x28,0xc3};
; Base = 7ff9ac39bbc0h
; TermCode = CTC_RET_ZED_SBB
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov r11,7ff9aaf615b0h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 bb b0 15 f6 aa f9 7f 00 00}
000fh mov rax,7ff9aaf615b0h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b8 b0 15 f6 aa f9 7f 00 00}
0019h cmp [rcx],ecx                           ; CMP r/m32, r32 || o32 39 /r || encoded[2]{39 09}
001bh call qword ptr [rax]                    ; CALL r/m64 || FF /2 || encoded[2]{ff 10}
001dh nop                                     ; NOP || o32 90 || encoded[1]{90}
001eh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0022h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; Span<ushort> store<ushort>(IEnumerable<ushort> src, Span<ushort> dst), located://konst/core?store#store_g[16u](IEnumerable[ushort],span16u)
; public static ReadOnlySpan<byte> store_gᐸ16uᐳᐤIEnumerableᐸushortᐳㆍspan16uᐤ => new byte[88]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x20,0x48,0x8b,0xf1,0x49,0x8b,0x38,0x41,0x8b,0x58,0x08,0x48,0x8b,0xca,0xe8,0x1c,0xfd,0xff,0xff,0x48,0x8b,0xe8,0xeb,0x0f,0x4c,0x8b,0xf7,0x48,0x8b,0xcd,0xe8,0x3c,0xfd,0xff,0xff,0x66,0x41,0x89,0x06,0x48,0x8b,0xcd,0xe8,0x10,0xfd,0xff,0xff,0x85,0xc0,0x74,0x08,0x48,0x63,0xcb,0x48,0x85,0xc9,0x7f,0xdd,0x48,0x89,0x3e,0x89,0x5e,0x08,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x20,0x5b,0x5d,0x5e,0x5f,0x41,0x5e,0xc3};
; Base = 7ff9ac3796f0h
; TermCode = CTC_RET_SBB
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
0017h call 7ff9ac379428h                      ; CALL rel32 || E8 cd || encoded[5]{e8 1c fd ff ff}
001ch mov rbp,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b e8}
001fh jmp short 0030h                         ; JMP rel8 || EB cb || encoded[2]{eb 0f}
0021h mov r14,rdi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b f7}
0024h mov rcx,rbp                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b cd}
0027h call 7ff9ac379458h                      ; CALL rel32 || E8 cd || encoded[5]{e8 3c fd ff ff}
002ch mov [r14],ax                            ; MOV r/m16, r16 || o16 89 /r || encoded[4]{66 41 89 06}
0030h mov rcx,rbp                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b cd}
0033h call 7ff9ac379438h                      ; CALL rel32 || E8 cd || encoded[5]{e8 10 fd ff ff}
0038h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
003ah je short 0044h                          ; JE rel8 || 74 cb || encoded[2]{74 08}
003ch movsxd rcx,ebx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 cb}
003fh test rcx,rcx                            ; TEST r/m64, r64 || REX.W 85 /r || encoded[3]{48 85 c9}
0042h jg short 0021h                          ; JG rel8 || 7F cb || encoded[2]{7f dd}
0044h mov [rsi],rdi                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 3e}
0047h mov [rsi+8],ebx                         ; MOV r/m32, r32 || o32 89 /r || encoded[3]{89 5e 08}
004ah mov rax,rsi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c6}
004dh add rsp,20h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 20}
0051h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
0052h pop rbp                                 ; POP r64 || 58+ro || encoded[1]{5d}
0053h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
0054h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
0055h pop r14                                 ; POP r64 || 58+ro || encoded[2]{41 5e}
0057h ret                                     ; RET || C3 || encoded[1]{c3}
------------------------------------------------------------------------------------------------------------------------
; Span<uint> store<uint>(IEnumerable<uint> src, Span<uint> dst), located://konst/core?store#store_g[32u](IEnumerable[uint],span32u)
; public static ReadOnlySpan<byte> store_gᐸ32uᐳᐤIEnumerableᐸuintᐳㆍspan32uᐤ => new byte[87]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x20,0x48,0x8b,0xf1,0x49,0x8b,0x38,0x41,0x8b,0x58,0x08,0x48,0x8b,0xca,0xe8,0x4c,0xfd,0xff,0xff,0x48,0x8b,0xe8,0xeb,0x0e,0x4c,0x8b,0xf7,0x48,0x8b,0xcd,0xe8,0x6c,0xfd,0xff,0xff,0x41,0x89,0x06,0x48,0x8b,0xcd,0xe8,0x41,0xfd,0xff,0xff,0x85,0xc0,0x74,0x08,0x48,0x63,0xcb,0x48,0x85,0xc9,0x7f,0xde,0x48,0x89,0x3e,0x89,0x5e,0x08,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x20,0x5b,0x5d,0x5e,0x5f,0x41,0x5e,0xc3};
; Base = 7ff9ac379770h
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
0017h call 7ff9ac3794d8h                      ; CALL rel32 || E8 cd || encoded[5]{e8 4c fd ff ff}
001ch mov rbp,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b e8}
001fh jmp short 002fh                         ; JMP rel8 || EB cb || encoded[2]{eb 0e}
0021h mov r14,rdi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b f7}
0024h mov rcx,rbp                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b cd}
0027h call 7ff9ac379508h                      ; CALL rel32 || E8 cd || encoded[5]{e8 6c fd ff ff}
002ch mov [r14],eax                           ; MOV r/m32, r32 || o32 89 /r || encoded[3]{41 89 06}
002fh mov rcx,rbp                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b cd}
0032h call 7ff9ac3794e8h                      ; CALL rel32 || E8 cd || encoded[5]{e8 41 fd ff ff}
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
------------------------------------------------------------------------------------------------------------------------
; Span<ulong> store<ulong>(IEnumerable<ulong> src, Span<ulong> dst), located://konst/core?store#store_g[64u](IEnumerable[ulong],span64u)
; public static ReadOnlySpan<byte> store_gᐸ64uᐳᐤIEnumerableᐸulongᐳㆍspan64uᐤ => new byte[87]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x20,0x48,0x8b,0xf1,0x49,0x8b,0x38,0x41,0x8b,0x58,0x08,0x48,0x8b,0xca,0xe8,0x7c,0xf9,0xff,0xff,0x48,0x8b,0xe8,0xeb,0x0e,0x4c,0x8b,0xf7,0x48,0x8b,0xcd,0xe8,0x9c,0xf9,0xff,0xff,0x49,0x89,0x06,0x48,0x8b,0xcd,0xe8,0x71,0xf9,0xff,0xff,0x85,0xc0,0x74,0x08,0x48,0x63,0xcb,0x48,0x85,0xc9,0x7f,0xde,0x48,0x89,0x3e,0x89,0x5e,0x08,0x48,0x8b,0xc6,0x48,0x83,0xc4,0x20,0x5b,0x5d,0x5e,0x5f,0x41,0x5e,0xc3};
; Base = 7ff9ac379bf0h
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
0017h call 7ff9ac379588h                      ; CALL rel32 || E8 cd || encoded[5]{e8 7c f9 ff ff}
001ch mov rbp,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b e8}
001fh jmp short 002fh                         ; JMP rel8 || EB cb || encoded[2]{eb 0e}
0021h mov r14,rdi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b f7}
0024h mov rcx,rbp                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b cd}
0027h call 7ff9ac3795b8h                      ; CALL rel32 || E8 cd || encoded[5]{e8 9c f9 ff ff}
002ch mov [r14],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 06}
002fh mov rcx,rbp                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b cd}
0032h call 7ff9ac379598h                      ; CALL rel32 || E8 cd || encoded[5]{e8 71 f9 ff ff}
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
