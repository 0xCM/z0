; 2020-01-22 01:43:39:188
; long loop_inc(int start, int max, long count)
; loop_inc_32i[0x7ff7c838d2f0, 0x7ff7c838d309][25] = {0f 1f 44 00 00 49 8b c0 3b ca 7d 0c 4c 63 c1 49 03 c0 ff c1 3b ca 7c f4 c3}
; Capture completion code, None
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
; loop_inc_test_neq_32i[0x7ff7c838d320, 0x7ff7c838d339][25] = {0f 1f 44 00 00 49 8b c0 3b ca 74 0c 4c 63 c1 49 03 c0 ff c1 3b ca 75 f4 c3}
; Capture completion code, None
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
; loop_dec_32i[0x7ff7c838d350, 0x7ff7c838d369][25] = {0f 1f 44 00 00 49 8b c0 3b ca 7c 0c 4c 63 c1 49 03 c0 ff c9 3b ca 7d f4 c3}
; Capture completion code, None
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
; loop_inc_step_32i[0x7ff7c838d380, 0x7ff7c838d39a][26] = {0f 1f 44 00 00 49 8b c1 3b ca 7d 0d 4c 63 c9 49 03 c1 41 03 c8 3b ca 7c f3 c3}
; Capture completion code, None
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
; loop_dec_step_32i[0x7ff7c838d3b0, 0x7ff7c838d3ca][26] = {0f 1f 44 00 00 49 8b c1 3b ca 7c 0d 4c 63 c9 49 03 c1 41 2b c8 3b ca 7d f3 c3}
; Capture completion code, None
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
; loop_inc_call_64i[0x7ff7c838d3e0, 0x7ff7c838d3fe][30] = {0f 1f 44 00 00 48 8b c1 ba 66 00 00 00 48 63 ca 48 03 c1 ff c2 81 fa 66 06 00 00 7c f0 c3}
; Capture completion code, None
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
; loop_inc_test_neq_call_64i[0x7ff7c838d410, 0x7ff7c838d42e][30] = {0f 1f 44 00 00 48 8b c1 ba 66 00 00 00 48 63 ca 48 03 c1 ff c2 81 fa 66 06 00 00 75 f0 c3}
; Capture completion code, None
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
; loop_inc_step_call_64i[0x7ff7c838d440, 0x7ff7c838d45f][31] = {0f 1f 44 00 00 48 8b c1 ba 66 00 00 00 48 63 ca 48 03 c1 83 c2 06 81 fa 66 06 00 00 7c ef c3}
; Capture completion code, None
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
; loop_dec_call_64i[0x7ff7c838d470, 0x7ff7c838d48b][27] = {0f 1f 44 00 00 48 8b c1 ba 66 06 00 00 48 63 ca 48 03 c1 ff ca 83 fa 66 7d f3 c3}
; Capture completion code, None
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
; loop_dec_step_call_64i[0x7ff7c838d4a0, 0x7ff7c838d4bc][28] = {0f 1f 44 00 00 48 8b c1 ba 66 06 00 00 48 63 ca 48 03 c1 83 c2 fa 83 fa 66 7d f2 c3}
; Capture completion code, None
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
; FindByte_64u[0x7ff7c838d4d0, 0x7ff7c838d4f8][40] = {0f 1f 44 00 00 48 8b c1 48 f7 d8 48 23 c1 48 c1 e8 08 48 ba 80 03 83 02 82 01 81 00 48 0f af c2 48 c1 e8 37 83 e0 07 c3}
; Capture completion code, None
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
; FindByte_14926099[0x7ff7c838d910, 0x7ff7c838d957][71] = {0f 1f 44 00 00 33 c0 48 8b 11 48 8b ca 4c 63 c0 42 0f b6 0c 01 48 85 c9 75 07 ff c0 83 f8 21 7c e9 48 8b d1 48 f7 da 48 23 d1 48 c1 ea 08 48 b9 80 03 83 02 82 01 81 00 48 0f af d1 48 c1 ea 37 83 e2 07 8d 04 c2 c3}
; Capture completion code, None
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
; downBy2ne_32i[0x7ff7c838d970, 0x7ff7c838d989][25] = {0f 1f 44 00 00 33 c0 ba 09 00 00 00 03 c1 83 c2 fe 83 fa 01 75 f6 03 c2 c3}
; Capture completion code, None
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
; upBy1ne_32i[0x7ff7c838d9a0, 0x7ff7c838d9b8][24] = {0f 1f 44 00 00 33 c0 ba 01 00 00 00 03 c1 ff c2 83 fa 08 75 f7 03 c2 c3}
; Capture completion code, None
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
; downBy1ne_32i[0x7ff7c838d9d0, 0x7ff7c838d9e8][24] = {0f 1f 44 00 00 33 c0 ba 09 00 00 00 03 c1 ff ca 83 fa 02 75 f7 03 c2 c3}
; Capture completion code, None
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
; upBy2ne_32i[0x7ff7c838da00, 0x7ff7c838da19][25] = {0f 1f 44 00 00 33 c0 ba 01 00 00 00 03 c1 83 c2 02 83 fa 09 75 f6 03 c2 c3}
; Capture completion code, None
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
; upBy3neWrap_32i[0x7ff7c838da30, 0x7ff7c838da4d][29] = {0f 1f 44 00 00 33 c0 ba 01 00 00 00 03 c1 83 c2 03 48 0f bf d2 83 fa 08 75 f2 03 c2 c3}
; Capture completion code, None
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
; downBy3neWrap_32i[0x7ff7c838da60, 0x7ff7c838da7d][29] = {0f 1f 44 00 00 33 c0 ba 08 00 00 00 03 c1 83 c2 fd 48 0f bf d2 83 fa 01 75 f2 03 c2 c3}
; Capture completion code, None
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
