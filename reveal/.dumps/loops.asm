; 2020-01-20 01:59:20:939
; long loop_inc(int start, int max, long count)
; static ReadOnlySpan<byte> loop_inc_32iBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x8B,0xC0,0x3B,0xCA,0x7D,0x0C,0x4C,0x63,0xC1,0x49,0x03,0xC0,0xFF,0xC1,0x3B,0xCA,0x7C,0xF4,0xC3};
; [0x7ff7c838eb20, 0x7ff7c838eb39], 25 bytes
; 2020-01-20 01:59:20:939
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b c0}
0008h cmp ecx,edx                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b ca}
000ah jge short 0018h                         ; JGE rel8 || 7D cb || encoded[2]{7d 0c}
000ch movsxd r8,ecx                           ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4c 63 c1}
000fh add rax,r8                              ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{49 03 c0}
0012h inc ecx                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c1}
0014h cmp ecx,edx                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b ca}
0016h jl short 000ch                          ; JL rel8 || 7C cb || encoded[2]{7c f4}
0018h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; long loop_inc_test_neq(int start, int test, long count)
; static ReadOnlySpan<byte> loop_inc_test_neq_32iBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x8B,0xC0,0x3B,0xCA,0x74,0x0C,0x4C,0x63,0xC1,0x49,0x03,0xC0,0xFF,0xC1,0x3B,0xCA,0x75,0xF4,0xC3};
; [0x7ff7c838eb50, 0x7ff7c838eb69], 25 bytes
; 2020-01-20 01:59:20:939
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b c0}
0008h cmp ecx,edx                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b ca}
000ah je short 0018h                          ; JE rel8 || 74 cb || encoded[2]{74 0c}
000ch movsxd r8,ecx                           ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4c 63 c1}
000fh add rax,r8                              ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{49 03 c0}
0012h inc ecx                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c1}
0014h cmp ecx,edx                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b ca}
0016h jne short 000ch                         ; JNE rel8 || 75 cb || encoded[2]{75 f4}
0018h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; long loop_dec(int start, int min, long count)
; static ReadOnlySpan<byte> loop_dec_32iBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x8B,0xC0,0x3B,0xCA,0x7C,0x0C,0x4C,0x63,0xC1,0x49,0x03,0xC0,0xFF,0xC9,0x3B,0xCA,0x7D,0xF4,0xC3};
; [0x7ff7c838eb80, 0x7ff7c838eb99], 25 bytes
; 2020-01-20 01:59:20:940
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b c0}
0008h cmp ecx,edx                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b ca}
000ah jl short 0018h                          ; JL rel8 || 7C cb || encoded[2]{7c 0c}
000ch movsxd r8,ecx                           ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4c 63 c1}
000fh add rax,r8                              ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{49 03 c0}
0012h dec ecx                                 ; DEC r/m32 || o32 FF /1 || encoded[2]{ff c9}
0014h cmp ecx,edx                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b ca}
0016h jge short 000ch                         ; JGE rel8 || 7D cb || encoded[2]{7d f4}
0018h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; long loop_inc_step(int start, int max, int step, long count)
; static ReadOnlySpan<byte> loop_inc_step_32iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x8B,0xC1,0x3B,0xCA,0x7D,0x0D,0x4C,0x63,0xC9,0x49,0x03,0xC1,0x41,0x03,0xC8,0x3B,0xCA,0x7C,0xF3,0xC3};
; [0x7ff7c838ebb0, 0x7ff7c838ebca], 26 bytes
; 2020-01-20 01:59:20:940
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,r9                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b c1}
0008h cmp ecx,edx                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b ca}
000ah jge short 0019h                         ; JGE rel8 || 7D cb || encoded[2]{7d 0d}
000ch movsxd r9,ecx                           ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4c 63 c9}
000fh add rax,r9                              ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{49 03 c1}
0012h add ecx,r8d                             ; ADD r32, r/m32 || o32 03 /r || encoded[3]{41 03 c8}
0015h cmp ecx,edx                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b ca}
0017h jl short 000ch                          ; JL rel8 || 7C cb || encoded[2]{7c f3}
0019h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; long loop_dec_step(int start, int min, int step, long count)
; static ReadOnlySpan<byte> loop_dec_step_32iBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x8B,0xC1,0x3B,0xCA,0x7C,0x0D,0x4C,0x63,0xC9,0x49,0x03,0xC1,0x41,0x2B,0xC8,0x3B,0xCA,0x7D,0xF3,0xC3};
; [0x7ff7c838ebe0, 0x7ff7c838ebfa], 26 bytes
; 2020-01-20 01:59:20:940
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,r9                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b c1}
0008h cmp ecx,edx                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b ca}
000ah jl short 0019h                          ; JL rel8 || 7C cb || encoded[2]{7c 0d}
000ch movsxd r9,ecx                           ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4c 63 c9}
000fh add rax,r9                              ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{49 03 c1}
0012h sub ecx,r8d                             ; SUB r32, r/m32 || o32 2B /r || encoded[3]{41 2b c8}
0015h cmp ecx,edx                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b ca}
0017h jge short 000ch                         ; JGE rel8 || 7D cb || encoded[2]{7d f3}
0019h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; long loop_inc_call(long count)
; static ReadOnlySpan<byte> loop_inc_call_64iBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0xBA,0x66,0x00,0x00,0x00,0x48,0x63,0xCA,0x48,0x03,0xC1,0xFF,0xC2,0x81,0xFA,0x66,0x06,0x00,0x00,0x7C,0xF0,0xC3};
; [0x7ff7c838ec10, 0x7ff7c838ec2e], 30 bytes
; 2020-01-20 01:59:20:940
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0008h mov edx,66h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 66 00 00 00}
000dh movsxd rcx,edx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 ca}
0010h add rax,rcx                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{48 03 c1}
0013h inc edx                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c2}
0015h cmp edx,666h                            ; CMP r/m32, imm32 || o32 81 /7 id || encoded[6]{81 fa 66 06 00 00}
001bh jl short 000dh                          ; JL rel8 || 7C cb || encoded[2]{7c f0}
001dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; long loop_inc_test_neq_call(long count)
; static ReadOnlySpan<byte> loop_inc_test_neq_call_64iBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0xBA,0x66,0x00,0x00,0x00,0x48,0x63,0xCA,0x48,0x03,0xC1,0xFF,0xC2,0x81,0xFA,0x66,0x06,0x00,0x00,0x75,0xF0,0xC3};
; [0x7ff7c838ec40, 0x7ff7c838ec5e], 30 bytes
; 2020-01-20 01:59:20:940
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0008h mov edx,66h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 66 00 00 00}
000dh movsxd rcx,edx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 ca}
0010h add rax,rcx                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{48 03 c1}
0013h inc edx                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c2}
0015h cmp edx,666h                            ; CMP r/m32, imm32 || o32 81 /7 id || encoded[6]{81 fa 66 06 00 00}
001bh jne short 000dh                         ; JNE rel8 || 75 cb || encoded[2]{75 f0}
001dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; long loop_inc_step_call(long count)
; static ReadOnlySpan<byte> loop_inc_step_call_64iBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0xBA,0x66,0x00,0x00,0x00,0x48,0x63,0xCA,0x48,0x03,0xC1,0x83,0xC2,0x06,0x81,0xFA,0x66,0x06,0x00,0x00,0x7C,0xEF,0xC3};
; [0x7ff7c838ec70, 0x7ff7c838ec8f], 31 bytes
; 2020-01-20 01:59:20:940
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0008h mov edx,66h                             ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 66 00 00 00}
000dh movsxd rcx,edx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 ca}
0010h add rax,rcx                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{48 03 c1}
0013h add edx,6                               ; ADD r/m32, imm8 || o32 83 /0 ib || encoded[3]{83 c2 06}
0016h cmp edx,666h                            ; CMP r/m32, imm32 || o32 81 /7 id || encoded[6]{81 fa 66 06 00 00}
001ch jl short 000dh                          ; JL rel8 || 7C cb || encoded[2]{7c ef}
001eh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; long loop_dec_call(long count)
; static ReadOnlySpan<byte> loop_dec_call_64iBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0xBA,0x66,0x06,0x00,0x00,0x48,0x63,0xCA,0x48,0x03,0xC1,0xFF,0xCA,0x83,0xFA,0x66,0x7D,0xF3,0xC3};
; [0x7ff7c838eca0, 0x7ff7c838ecbb], 27 bytes
; 2020-01-20 01:59:20:940
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0008h mov edx,666h                            ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 66 06 00 00}
000dh movsxd rcx,edx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 ca}
0010h add rax,rcx                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{48 03 c1}
0013h dec edx                                 ; DEC r/m32 || o32 FF /1 || encoded[2]{ff ca}
0015h cmp edx,66h                             ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 fa 66}
0018h jge short 000dh                         ; JGE rel8 || 7D cb || encoded[2]{7d f3}
001ah ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; long loop_dec_step_call(long count)
; static ReadOnlySpan<byte> loop_dec_step_call_64iBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0xBA,0x66,0x06,0x00,0x00,0x48,0x63,0xCA,0x48,0x03,0xC1,0x83,0xC2,0xFA,0x83,0xFA,0x66,0x7D,0xF2,0xC3};
; [0x7ff7c838ecd0, 0x7ff7c838ecec], 28 bytes
; 2020-01-20 01:59:20:940
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0008h mov edx,666h                            ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 66 06 00 00}
000dh movsxd rcx,edx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 ca}
0010h add rax,rcx                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{48 03 c1}
0013h add edx,0FFFFFFFAh                      ; ADD r/m32, imm8 || o32 83 /0 ib || encoded[3]{83 c2 fa}
0016h cmp edx,66h                             ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 fa 66}
0019h jge short 000dh                         ; JGE rel8 || 7D cb || encoded[2]{7d f2}
001bh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; int FindByte(ulong src)
; static ReadOnlySpan<byte> FindByte_64uBytes => new byte[40]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD8,0x48,0x23,0xC1,0x48,0xC1,0xE8,0x08,0x48,0xBA,0x80,0x03,0x83,0x02,0x82,0x01,0x81,0x00,0x48,0x0F,0xAF,0xC2,0x48,0xC1,0xE8,0x37,0x83,0xE0,0x07,0xC3};
; [0x7ff7c838ed00, 0x7ff7c838ed28], 40 bytes
; 2020-01-20 01:59:20:940
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0008h neg rax                                 ; NEG r/m64 || REX.W F7 /3 || encoded[3]{48 f7 d8}
000bh and rax,rcx                             ; AND r64, r/m64 || REX.W 23 /r || encoded[3]{48 23 c1}
000eh shr rax,8                               ; SHR r/m64, imm8 || REX.W C1 /5 ib || encoded[4]{48 c1 e8 08}
0012h mov rdx,81018202830380h                 ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 ba 80 03 83 02 82 01 81 00}
001ch imul rax,rdx                            ; IMUL r64, r/m64 || REX.W 0F AF /r || encoded[4]{48 0f af c2}
0020h shr rax,37h                             ; SHR r/m64, imm8 || REX.W C1 /5 ib || encoded[4]{48 c1 e8 37}
0024h and eax,7                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e0 07}
0027h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; int FindByte(in Block256<byte> src)
; static ReadOnlySpan<byte> FindByte_14859795Bytes => new byte[71]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0x48,0x8B,0x11,0x48,0x8B,0xCA,0x4C,0x63,0xC0,0x42,0x0F,0xB6,0x0C,0x01,0x48,0x85,0xC9,0x75,0x07,0xFF,0xC0,0x83,0xF8,0x21,0x7C,0xE9,0x48,0x8B,0xD1,0x48,0xF7,0xDA,0x48,0x23,0xD1,0x48,0xC1,0xEA,0x08,0x48,0xB9,0x80,0x03,0x83,0x02,0x82,0x01,0x81,0x00,0x48,0x0F,0xAF,0xD1,0x48,0xC1,0xEA,0x37,0x83,0xE2,0x07,0x8D,0x04,0xC2,0xC3};
; [0x7ff7c838f140, 0x7ff7c838f187], 71 bytes
; 2020-01-20 01:59:20:940
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0007h mov rdx,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 11}
000ah mov rcx,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b ca}
000dh movsxd r8,eax                           ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4c 63 c0}
0010h movzx ecx,byte ptr [rcx+r8]             ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[5]{42 0f b6 0c 01}
0015h test rcx,rcx                            ; TEST r/m64, r64 || REX.W 85 /r || encoded[3]{48 85 c9}
0018h jne short 0021h                         ; JNE rel8 || 75 cb || encoded[2]{75 07}
001ah inc eax                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c0}
001ch cmp eax,21h                             ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 f8 21}
001fh jl short 000ah                          ; JL rel8 || 7C cb || encoded[2]{7c e9}
0021h mov rdx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d1}
0024h neg rdx                                 ; NEG r/m64 || REX.W F7 /3 || encoded[3]{48 f7 da}
0027h and rdx,rcx                             ; AND r64, r/m64 || REX.W 23 /r || encoded[3]{48 23 d1}
002ah shr rdx,8                               ; SHR r/m64, imm8 || REX.W C1 /5 ib || encoded[4]{48 c1 ea 08}
002eh mov rcx,81018202830380h                 ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 80 03 83 02 82 01 81 00}
0038h imul rdx,rcx                            ; IMUL r64, r/m64 || REX.W 0F AF /r || encoded[4]{48 0f af d1}
003ch shr rdx,37h                             ; SHR r/m64, imm8 || REX.W C1 /5 ib || encoded[4]{48 c1 ea 37}
0040h and edx,7                               ; AND r/m32, imm8 || o32 83 /4 ib || encoded[3]{83 e2 07}
0043h lea eax,[rdx+rax*8]                     ; LEA r32, m || o32 8D /r || encoded[3]{8d 04 c2}
0046h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; int downBy2ne(int amount)
; static ReadOnlySpan<byte> downBy2ne_32iBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xBA,0x09,0x00,0x00,0x00,0x03,0xC1,0x83,0xC2,0xFE,0x83,0xFA,0x01,0x75,0xF6,0x03,0xC2,0xC3};
; [0x7ff7c838f1a0, 0x7ff7c838f1b9], 25 bytes
; 2020-01-20 01:59:20:940
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0007h mov edx,9                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 09 00 00 00}
000ch add eax,ecx                             ; ADD r32, r/m32 || o32 03 /r || encoded[2]{03 c1}
000eh add edx,0FFFFFFFEh                      ; ADD r/m32, imm8 || o32 83 /0 ib || encoded[3]{83 c2 fe}
0011h cmp edx,1                               ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 fa 01}
0014h jne short 000ch                         ; JNE rel8 || 75 cb || encoded[2]{75 f6}
0016h add eax,edx                             ; ADD r32, r/m32 || o32 03 /r || encoded[2]{03 c2}
0018h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; int upBy1ne(int amount)
; static ReadOnlySpan<byte> upBy1ne_32iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xBA,0x01,0x00,0x00,0x00,0x03,0xC1,0xFF,0xC2,0x83,0xFA,0x08,0x75,0xF7,0x03,0xC2,0xC3};
; [0x7ff7c838f1d0, 0x7ff7c838f1e8], 24 bytes
; 2020-01-20 01:59:20:940
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0007h mov edx,1                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 01 00 00 00}
000ch add eax,ecx                             ; ADD r32, r/m32 || o32 03 /r || encoded[2]{03 c1}
000eh inc edx                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c2}
0010h cmp edx,8                               ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 fa 08}
0013h jne short 000ch                         ; JNE rel8 || 75 cb || encoded[2]{75 f7}
0015h add eax,edx                             ; ADD r32, r/m32 || o32 03 /r || encoded[2]{03 c2}
0017h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; int downBy1ne(int amount)
; static ReadOnlySpan<byte> downBy1ne_32iBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xBA,0x09,0x00,0x00,0x00,0x03,0xC1,0xFF,0xCA,0x83,0xFA,0x02,0x75,0xF7,0x03,0xC2,0xC3};
; [0x7ff7c838f200, 0x7ff7c838f218], 24 bytes
; 2020-01-20 01:59:20:940
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0007h mov edx,9                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 09 00 00 00}
000ch add eax,ecx                             ; ADD r32, r/m32 || o32 03 /r || encoded[2]{03 c1}
000eh dec edx                                 ; DEC r/m32 || o32 FF /1 || encoded[2]{ff ca}
0010h cmp edx,2                               ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 fa 02}
0013h jne short 000ch                         ; JNE rel8 || 75 cb || encoded[2]{75 f7}
0015h add eax,edx                             ; ADD r32, r/m32 || o32 03 /r || encoded[2]{03 c2}
0017h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; int upBy2ne(int amount)
; static ReadOnlySpan<byte> upBy2ne_32iBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xBA,0x01,0x00,0x00,0x00,0x03,0xC1,0x83,0xC2,0x02,0x83,0xFA,0x09,0x75,0xF6,0x03,0xC2,0xC3};
; [0x7ff7c838f230, 0x7ff7c838f249], 25 bytes
; 2020-01-20 01:59:20:940
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0007h mov edx,1                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 01 00 00 00}
000ch add eax,ecx                             ; ADD r32, r/m32 || o32 03 /r || encoded[2]{03 c1}
000eh add edx,2                               ; ADD r/m32, imm8 || o32 83 /0 ib || encoded[3]{83 c2 02}
0011h cmp edx,9                               ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 fa 09}
0014h jne short 000ch                         ; JNE rel8 || 75 cb || encoded[2]{75 f6}
0016h add eax,edx                             ; ADD r32, r/m32 || o32 03 /r || encoded[2]{03 c2}
0018h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; int upBy3neWrap(int amount)
; static ReadOnlySpan<byte> upBy3neWrap_32iBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xBA,0x01,0x00,0x00,0x00,0x03,0xC1,0x83,0xC2,0x03,0x48,0x0F,0xBF,0xD2,0x83,0xFA,0x08,0x75,0xF2,0x03,0xC2,0xC3};
; [0x7ff7c838f260, 0x7ff7c838f27d], 29 bytes
; 2020-01-20 01:59:20:940
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0007h mov edx,1                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 01 00 00 00}
000ch add eax,ecx                             ; ADD r32, r/m32 || o32 03 /r || encoded[2]{03 c1}
000eh add edx,3                               ; ADD r/m32, imm8 || o32 83 /0 ib || encoded[3]{83 c2 03}
0011h movsx rdx,dx                            ; MOVSX r64, r/m16 || REX.W 0F BF /r || encoded[4]{48 0f bf d2}
0015h cmp edx,8                               ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 fa 08}
0018h jne short 000ch                         ; JNE rel8 || 75 cb || encoded[2]{75 f2}
001ah add eax,edx                             ; ADD r32, r/m32 || o32 03 /r || encoded[2]{03 c2}
001ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; int downBy3neWrap(int amount)
; static ReadOnlySpan<byte> downBy3neWrap_32iBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xBA,0x08,0x00,0x00,0x00,0x03,0xC1,0x83,0xC2,0xFD,0x48,0x0F,0xBF,0xD2,0x83,0xFA,0x01,0x75,0xF2,0x03,0xC2,0xC3};
; [0x7ff7c838f290, 0x7ff7c838f2ad], 29 bytes
; 2020-01-20 01:59:20:940
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0007h mov edx,8                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 08 00 00 00}
000ch add eax,ecx                             ; ADD r32, r/m32 || o32 03 /r || encoded[2]{03 c1}
000eh add edx,0FFFFFFFDh                      ; ADD r/m32, imm8 || o32 83 /0 ib || encoded[3]{83 c2 fd}
0011h movsx rdx,dx                            ; MOVSX r64, r/m16 || REX.W 0F BF /r || encoded[4]{48 0f bf d2}
0015h cmp edx,1                               ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[3]{83 fa 01}
0018h jne short 000ch                         ; JNE rel8 || 75 cb || encoded[2]{75 f2}
001ah add eax,edx                             ; ADD r32, r/m32 || o32 03 /r || encoded[2]{03 c2}
001ch ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
