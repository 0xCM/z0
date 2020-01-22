; 2020-01-22 01:44:40:239
; RowBits<byte> and_8u(RowBits<byte> x, RowBits<byte> y, RowBits<byte> dst)
; and_8u_0x[0x7ff7c8397150, 0x7ff7c83971a6][86] = {57 56 53 48 8b d9 8b 42 08 33 c9 85 c0 7e 33 4d 8b 11 4c 63 d9 4d 03 d3 4c 8b 1a 48 63 f1 45 0f b6 1c 33 49 8b 30 48 63 f9 40 0f b6 34 3e 45 0f b6 db 44 23 de 45 0f b6 db 45 88 1a ff c1 3b c8 7c cd 48 8b fb 49 8b f1 e8 f3 ec 5f 5f 48 a5 48 8b c3 5b 5e 5f c3}
; Capture completion code, None
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
0006h mov eax,[rdx+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 42 08}
0009h xor ecx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c9}
000bh test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
000dh jle short 0042h                         ; JLE rel8 || 7E cb || encoded[2]{7e 33}
000fh mov r10,[r9]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b 11}
0012h movsxd r11,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4c 63 d9}
0015h add r10,r11                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{4d 03 d3}
0018h mov r11,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b 1a}
001bh movsxd rsi,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 f1}
001eh movzx r11d,byte ptr [r11+rsi]           ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[5]{45 0f b6 1c 33}
0023h mov rsi,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b 30}
0026h movsxd rdi,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 f9}
0029h movzx esi,byte ptr [rsi+rdi]            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[5]{40 0f b6 34 3e}
002eh movzx r11d,r11b                         ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{45 0f b6 db}
0032h and r11d,esi                            ; AND r32, r/m32 || o32 23 /r || encoded[3]{44 23 de}
0035h movzx r11d,r11b                         ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{45 0f b6 db}
0039h mov [r10],r11b                          ; MOV r/m8, r8 || 88 /r || encoded[3]{45 88 1a}
003ch inc ecx                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c1}
003eh cmp ecx,eax                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b c8}
0040h jl short 000fh                          ; JL rel8 || 7C cb || encoded[2]{7c cd}
0042h mov rdi,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fb}
0045h mov rsi,r9                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b f1}
0048h call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 f3 ec 5f 5f}
004dh movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
004fh mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
0052h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
0053h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
0054h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
0055h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; RowBits<ushort> and_16u(RowBits<ushort> x, RowBits<ushort> y, RowBits<ushort> dst)
; and_16u_0x[0x7ff7c83975d0, 0x7ff7c8397627][87] = {57 56 53 48 8b d9 8b 42 08 33 c9 85 c0 7e 34 4d 8b 11 4c 63 d9 4f 8d 14 5a 4c 8b 1a 48 63 f1 45 0f b7 1c 73 49 8b 30 48 63 f9 0f b7 34 7e 45 0f b7 db 44 23 de 45 0f b7 db 66 45 89 1a ff c1 3b c8 7c cc 48 8b fb 49 8b f1 e8 72 e8 5f 5f 48 a5 48 8b c3 5b 5e 5f c3}
; Capture completion code, None
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
0006h mov eax,[rdx+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 42 08}
0009h xor ecx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c9}
000bh test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
000dh jle short 0043h                         ; JLE rel8 || 7E cb || encoded[2]{7e 34}
000fh mov r10,[r9]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b 11}
0012h movsxd r11,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4c 63 d9}
0015h lea r10,[r10+r11*2]                     ; LEA r64, m || REX.W 8D /r || encoded[4]{4f 8d 14 5a}
0019h mov r11,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b 1a}
001ch movsxd rsi,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 f1}
001fh movzx r11d,word ptr [r11+rsi*2]         ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[5]{45 0f b7 1c 73}
0024h mov rsi,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b 30}
0027h movsxd rdi,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 f9}
002ah movzx esi,word ptr [rsi+rdi*2]          ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[4]{0f b7 34 7e}
002eh movzx r11d,r11w                         ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[4]{45 0f b7 db}
0032h and r11d,esi                            ; AND r32, r/m32 || o32 23 /r || encoded[3]{44 23 de}
0035h movzx r11d,r11w                         ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[4]{45 0f b7 db}
0039h mov [r10],r11w                          ; MOV r/m16, r16 || o16 89 /r || encoded[4]{66 45 89 1a}
003dh inc ecx                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c1}
003fh cmp ecx,eax                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b c8}
0041h jl short 000fh                          ; JL rel8 || 7C cb || encoded[2]{7c cc}
0043h mov rdi,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fb}
0046h mov rsi,r9                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b f1}
0049h call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 72 e8 5f 5f}
004eh movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
0050h mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
0053h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
0054h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
0055h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
0056h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; RowBits<uint> and_32u(RowBits<uint> x, RowBits<uint> y, RowBits<uint> dst)
; and_32u_0x[0x7ff7c8397640, 0x7ff7c8397687][71] = {57 56 53 48 8b d9 8b 42 08 33 c9 85 c0 7e 24 4d 8b 11 4c 63 d9 4f 8d 14 9a 48 8b 32 42 8b 34 9e 49 8b 38 46 8b 1c 9f 44 23 de 45 89 1a ff c1 3b c8 7c dc 48 8b fb 49 8b f1 e8 12 e8 5f 5f 48 a5 48 8b c3 5b 5e 5f c3}
; Capture completion code, None
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
0006h mov eax,[rdx+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 42 08}
0009h xor ecx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c9}
000bh test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
000dh jle short 0033h                         ; JLE rel8 || 7E cb || encoded[2]{7e 24}
000fh mov r10,[r9]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b 11}
0012h movsxd r11,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4c 63 d9}
0015h lea r10,[r10+r11*4]                     ; LEA r64, m || REX.W 8D /r || encoded[4]{4f 8d 14 9a}
0019h mov rsi,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 32}
001ch mov esi,[rsi+r11*4]                     ; MOV r32, r/m32 || o32 8B /r || encoded[4]{42 8b 34 9e}
0020h mov rdi,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b 38}
0023h mov r11d,[rdi+r11*4]                    ; MOV r32, r/m32 || o32 8B /r || encoded[4]{46 8b 1c 9f}
0027h and r11d,esi                            ; AND r32, r/m32 || o32 23 /r || encoded[3]{44 23 de}
002ah mov [r10],r11d                          ; MOV r/m32, r32 || o32 89 /r || encoded[3]{45 89 1a}
002dh inc ecx                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c1}
002fh cmp ecx,eax                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b c8}
0031h jl short 000fh                          ; JL rel8 || 7C cb || encoded[2]{7c dc}
0033h mov rdi,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fb}
0036h mov rsi,r9                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b f1}
0039h call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 12 e8 5f 5f}
003eh movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
0040h mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
0043h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
0044h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
0045h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
0046h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; RowBits<ulong> and_64u(RowBits<ulong> x, RowBits<ulong> y, RowBits<ulong> dst)
; and_64u_0x[0x7ff7c83977f0, 0x7ff7c8397837][71] = {57 56 53 48 8b d9 8b 42 08 33 c9 85 c0 7e 24 4d 8b 11 4c 63 d9 4f 8d 14 da 48 8b 32 4a 8b 34 de 49 8b 38 4e 8b 1c df 4c 23 de 4d 89 1a ff c1 3b c8 7c dc 48 8b fb 49 8b f1 e8 62 e6 5f 5f 48 a5 48 8b c3 5b 5e 5f c3}
; Capture completion code, None
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
0006h mov eax,[rdx+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 42 08}
0009h xor ecx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c9}
000bh test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
000dh jle short 0033h                         ; JLE rel8 || 7E cb || encoded[2]{7e 24}
000fh mov r10,[r9]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b 11}
0012h movsxd r11,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4c 63 d9}
0015h lea r10,[r10+r11*8]                     ; LEA r64, m || REX.W 8D /r || encoded[4]{4f 8d 14 da}
0019h mov rsi,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 32}
001ch mov rsi,[rsi+r11*8]                     ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{4a 8b 34 de}
0020h mov rdi,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b 38}
0023h mov r11,[rdi+r11*8]                     ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{4e 8b 1c df}
0027h and r11,rsi                             ; AND r64, r/m64 || REX.W 23 /r || encoded[3]{4c 23 de}
002ah mov [r10],r11                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4d 89 1a}
002dh inc ecx                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c1}
002fh cmp ecx,eax                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b c8}
0031h jl short 000fh                          ; JL rel8 || 7C cb || encoded[2]{7c dc}
0033h mov rdi,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fb}
0036h mov rsi,r9                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b f1}
0039h call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 62 e6 5f 5f}
003eh movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
0040h mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
0043h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
0044h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
0045h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
0046h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; RowBits<ulong> and_64u_op(RowBits<ulong> x, RowBits<ulong> y)
; and_64u_op_0x[0x7ff7c8397c60, 0x7ff7c8397ce0][128] = {57 56 53 48 83 ec 30 c5 f8 77 33 c0 48 89 44 24 20 48 8b d9 48 8b f2 49 8b f8 48 8d 54 24 20 c5 f8 57 c0 c5 fa 7f 02 8b 56 08 48 8d 4c 24 20 e8 04 f9 ff ff 8b 46 08 33 d2 85 c0 7e 29 48 8d 4c 24 20 48 8b 09 4c 63 c2 4a 8d 0c c1 4c 8b 0e 4f 8b 0c c1 4c 8b 17 4f 8b 04 c2 4d 23 c1 4c 89 01 ff c2 3b d0 7c d7 48 8b fb 48 8d 74 24 20 e8 bd e1 5f 5f 48 a5 48 8b c3 48 83 c4 30 5b 5e 5f c3}
; Capture completion code, None
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h sub rsp,30h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 30}
0007h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
000ah xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
000ch mov [rsp+20h],rax                       ; MOV r/m64, r64 || REX.W 89 /r || encoded[5]{48 89 44 24 20}
0011h mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
0014h mov rsi,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f2}
0017h mov rdi,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b f8}
001ah lea rdx,[rsp+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 54 24 20}
001fh vxorps xmm0,xmm0,xmm0                   ; VXORPS xmm1, xmm2, xmm3/m128 || VEX.128.0F.WIG 57 /r || encoded[4]{c5 f8 57 c0}
0023h vmovdqu xmmword ptr [rdx],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 02}
0027h mov edx,[rsi+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 56 08}
002ah lea rcx,[rsp+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 4c 24 20}
002fh call 7FF7C8397598h                      ; CALL rel32 || E8 cd || encoded[5]{e8 04 f9 ff ff}
0034h mov eax,[rsi+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 46 08}
0037h xor edx,edx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 d2}
0039h test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
003bh jle short 0066h                         ; JLE rel8 || 7E cb || encoded[2]{7e 29}
003dh lea rcx,[rsp+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 4c 24 20}
0042h mov rcx,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 09}
0045h movsxd r8,edx                           ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4c 63 c2}
0048h lea rcx,[rcx+r8*8]                      ; LEA r64, m || REX.W 8D /r || encoded[4]{4a 8d 0c c1}
004ch mov r9,[rsi]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b 0e}
004fh mov r9,[r9+r8*8]                        ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{4f 8b 0c c1}
0053h mov r10,[rdi]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b 17}
0056h mov r8,[r10+r8*8]                       ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{4f 8b 04 c2}
005ah and r8,r9                               ; AND r64, r/m64 || REX.W 23 /r || encoded[3]{4d 23 c1}
005dh mov [rcx],r8                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 01}
0060h inc edx                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c2}
0062h cmp edx,eax                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b d0}
0064h jl short 003dh                          ; JL rel8 || 7C cb || encoded[2]{7c d7}
0066h mov rdi,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fb}
0069h lea rsi,[rsp+20h]                       ; LEA r64, m || REX.W 8D /r || encoded[5]{48 8d 74 24 20}
006eh call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 bd e1 5f 5f}
0073h movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
0075h mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
0078h add rsp,30h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 30}
007ch pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
007dh pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
007eh pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
007fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; RowBits<byte> xor_8u(RowBits<byte> x, RowBits<byte> y, RowBits<byte> dst)
; xor_8u_0x[0x7ff7c8398110, 0x7ff7c8398166][86] = {57 56 53 48 8b d9 8b 42 08 33 c9 85 c0 7e 33 4d 8b 11 4c 63 d9 4d 03 d3 4c 8b 1a 48 63 f1 45 0f b6 1c 33 49 8b 30 48 63 f9 40 0f b6 34 3e 45 0f b6 db 44 33 de 45 0f b6 db 45 88 1a ff c1 3b c8 7c cd 48 8b fb 49 8b f1 e8 33 dd 5f 5f 48 a5 48 8b c3 5b 5e 5f c3}
; Capture completion code, None
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
0006h mov eax,[rdx+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 42 08}
0009h xor ecx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c9}
000bh test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
000dh jle short 0042h                         ; JLE rel8 || 7E cb || encoded[2]{7e 33}
000fh mov r10,[r9]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b 11}
0012h movsxd r11,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4c 63 d9}
0015h add r10,r11                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{4d 03 d3}
0018h mov r11,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b 1a}
001bh movsxd rsi,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 f1}
001eh movzx r11d,byte ptr [r11+rsi]           ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[5]{45 0f b6 1c 33}
0023h mov rsi,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b 30}
0026h movsxd rdi,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 f9}
0029h movzx esi,byte ptr [rsi+rdi]            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[5]{40 0f b6 34 3e}
002eh movzx r11d,r11b                         ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{45 0f b6 db}
0032h xor r11d,esi                            ; XOR r32, r/m32 || o32 33 /r || encoded[3]{44 33 de}
0035h movzx r11d,r11b                         ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{45 0f b6 db}
0039h mov [r10],r11b                          ; MOV r/m8, r8 || 88 /r || encoded[3]{45 88 1a}
003ch inc ecx                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c1}
003eh cmp ecx,eax                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b c8}
0040h jl short 000fh                          ; JL rel8 || 7C cb || encoded[2]{7c cd}
0042h mov rdi,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fb}
0045h mov rsi,r9                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b f1}
0048h call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 33 dd 5f 5f}
004dh movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
004fh mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
0052h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
0053h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
0054h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
0055h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; RowBits<ushort> xor_16u(RowBits<ushort> x, RowBits<ushort> y, RowBits<ushort> dst)
; xor_16u_0x[0x7ff7c8398180, 0x7ff7c83981d7][87] = {57 56 53 48 8b d9 8b 42 08 33 c9 85 c0 7e 34 4d 8b 11 4c 63 d9 4f 8d 14 5a 4c 8b 1a 48 63 f1 45 0f b7 1c 73 49 8b 30 48 63 f9 0f b7 34 7e 45 0f b7 db 44 33 de 45 0f b7 db 66 45 89 1a ff c1 3b c8 7c cc 48 8b fb 49 8b f1 e8 c2 dc 5f 5f 48 a5 48 8b c3 5b 5e 5f c3}
; Capture completion code, None
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
0006h mov eax,[rdx+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 42 08}
0009h xor ecx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c9}
000bh test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
000dh jle short 0043h                         ; JLE rel8 || 7E cb || encoded[2]{7e 34}
000fh mov r10,[r9]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b 11}
0012h movsxd r11,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4c 63 d9}
0015h lea r10,[r10+r11*2]                     ; LEA r64, m || REX.W 8D /r || encoded[4]{4f 8d 14 5a}
0019h mov r11,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b 1a}
001ch movsxd rsi,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 f1}
001fh movzx r11d,word ptr [r11+rsi*2]         ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[5]{45 0f b7 1c 73}
0024h mov rsi,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b 30}
0027h movsxd rdi,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 f9}
002ah movzx esi,word ptr [rsi+rdi*2]          ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[4]{0f b7 34 7e}
002eh movzx r11d,r11w                         ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[4]{45 0f b7 db}
0032h xor r11d,esi                            ; XOR r32, r/m32 || o32 33 /r || encoded[3]{44 33 de}
0035h movzx r11d,r11w                         ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[4]{45 0f b7 db}
0039h mov [r10],r11w                          ; MOV r/m16, r16 || o16 89 /r || encoded[4]{66 45 89 1a}
003dh inc ecx                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c1}
003fh cmp ecx,eax                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b c8}
0041h jl short 000fh                          ; JL rel8 || 7C cb || encoded[2]{7c cc}
0043h mov rdi,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fb}
0046h mov rsi,r9                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b f1}
0049h call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 c2 dc 5f 5f}
004eh movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
0050h mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
0053h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
0054h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
0055h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
0056h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; RowBits<uint> xor_32u(RowBits<uint> x, RowBits<uint> y, RowBits<uint> dst)
; xor_32u_0x[0x7ff7c83981f0, 0x7ff7c8398237][71] = {57 56 53 48 8b d9 8b 42 08 33 c9 85 c0 7e 24 4d 8b 11 4c 63 d9 4f 8d 14 9a 48 8b 32 42 8b 34 9e 49 8b 38 46 8b 1c 9f 44 33 de 45 89 1a ff c1 3b c8 7c dc 48 8b fb 49 8b f1 e8 62 dc 5f 5f 48 a5 48 8b c3 5b 5e 5f c3}
; Capture completion code, None
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
0006h mov eax,[rdx+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 42 08}
0009h xor ecx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c9}
000bh test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
000dh jle short 0033h                         ; JLE rel8 || 7E cb || encoded[2]{7e 24}
000fh mov r10,[r9]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b 11}
0012h movsxd r11,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4c 63 d9}
0015h lea r10,[r10+r11*4]                     ; LEA r64, m || REX.W 8D /r || encoded[4]{4f 8d 14 9a}
0019h mov rsi,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 32}
001ch mov esi,[rsi+r11*4]                     ; MOV r32, r/m32 || o32 8B /r || encoded[4]{42 8b 34 9e}
0020h mov rdi,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b 38}
0023h mov r11d,[rdi+r11*4]                    ; MOV r32, r/m32 || o32 8B /r || encoded[4]{46 8b 1c 9f}
0027h xor r11d,esi                            ; XOR r32, r/m32 || o32 33 /r || encoded[3]{44 33 de}
002ah mov [r10],r11d                          ; MOV r/m32, r32 || o32 89 /r || encoded[3]{45 89 1a}
002dh inc ecx                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c1}
002fh cmp ecx,eax                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b c8}
0031h jl short 000fh                          ; JL rel8 || 7C cb || encoded[2]{7c dc}
0033h mov rdi,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fb}
0036h mov rsi,r9                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b f1}
0039h call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 62 dc 5f 5f}
003eh movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
0040h mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
0043h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
0044h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
0045h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
0046h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; RowBits<ulong> xor_64u(RowBits<ulong> x, RowBits<ulong> y, RowBits<ulong> dst)
; xor_64u_0x[0x7ff7c8398250, 0x7ff7c8398297][71] = {57 56 53 48 8b d9 8b 42 08 33 c9 85 c0 7e 24 4d 8b 11 4c 63 d9 4f 8d 14 da 48 8b 32 4a 8b 34 de 49 8b 38 4e 8b 1c df 4c 33 de 4d 89 1a ff c1 3b c8 7c dc 48 8b fb 49 8b f1 e8 02 dc 5f 5f 48 a5 48 8b c3 5b 5e 5f c3}
; Capture completion code, None
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
0006h mov eax,[rdx+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 42 08}
0009h xor ecx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c9}
000bh test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
000dh jle short 0033h                         ; JLE rel8 || 7E cb || encoded[2]{7e 24}
000fh mov r10,[r9]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b 11}
0012h movsxd r11,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4c 63 d9}
0015h lea r10,[r10+r11*8]                     ; LEA r64, m || REX.W 8D /r || encoded[4]{4f 8d 14 da}
0019h mov rsi,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 32}
001ch mov rsi,[rsi+r11*8]                     ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{4a 8b 34 de}
0020h mov rdi,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b 38}
0023h mov r11,[rdi+r11*8]                     ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{4e 8b 1c df}
0027h xor r11,rsi                             ; XOR r64, r/m64 || REX.W 33 /r || encoded[3]{4c 33 de}
002ah mov [r10],r11                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4d 89 1a}
002dh inc ecx                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c1}
002fh cmp ecx,eax                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b c8}
0031h jl short 000fh                          ; JL rel8 || 7C cb || encoded[2]{7c dc}
0033h mov rdi,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fb}
0036h mov rsi,r9                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b f1}
0039h call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 02 dc 5f 5f}
003eh movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
0040h mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
0043h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
0044h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
0045h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
0046h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; RowBits<byte> xnor_8u(RowBits<byte> x, RowBits<byte> y, RowBits<byte> dst)
; xnor_8u_0x[0x7ff7c83986c0, 0x7ff7c8398719][89] = {57 56 53 48 8b d9 8b 42 08 33 c9 85 c0 7e 36 4d 8b 11 4c 63 d9 4d 03 d3 4c 8b 1a 48 63 f1 45 0f b6 1c 33 49 8b 30 48 63 f9 40 0f b6 34 3e 45 0f b6 db 44 33 de 41 f7 d3 45 0f b6 db 45 88 1a ff c1 3b c8 7c ca 48 8b fb 49 8b f1 e8 80 d7 5f 5f 48 a5 48 8b c3 5b 5e 5f c3}
; Capture completion code, None
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
0006h mov eax,[rdx+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 42 08}
0009h xor ecx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c9}
000bh test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
000dh jle short 0045h                         ; JLE rel8 || 7E cb || encoded[2]{7e 36}
000fh mov r10,[r9]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b 11}
0012h movsxd r11,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4c 63 d9}
0015h add r10,r11                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{4d 03 d3}
0018h mov r11,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b 1a}
001bh movsxd rsi,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 f1}
001eh movzx r11d,byte ptr [r11+rsi]           ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[5]{45 0f b6 1c 33}
0023h mov rsi,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b 30}
0026h movsxd rdi,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 f9}
0029h movzx esi,byte ptr [rsi+rdi]            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[5]{40 0f b6 34 3e}
002eh movzx r11d,r11b                         ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{45 0f b6 db}
0032h xor r11d,esi                            ; XOR r32, r/m32 || o32 33 /r || encoded[3]{44 33 de}
0035h not r11d                                ; NOT r/m32 || o32 F7 /2 || encoded[3]{41 f7 d3}
0038h movzx r11d,r11b                         ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{45 0f b6 db}
003ch mov [r10],r11b                          ; MOV r/m8, r8 || 88 /r || encoded[3]{45 88 1a}
003fh inc ecx                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c1}
0041h cmp ecx,eax                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b c8}
0043h jl short 000fh                          ; JL rel8 || 7C cb || encoded[2]{7c ca}
0045h mov rdi,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fb}
0048h mov rsi,r9                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b f1}
004bh call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 80 d7 5f 5f}
0050h movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
0052h mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
0055h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
0056h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
0057h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
0058h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; RowBits<ushort> xnor_16u(RowBits<ushort> x, RowBits<ushort> y, RowBits<ushort> dst)
; xnor_16u_0x[0x7ff7c8398740, 0x7ff7c839879a][90] = {57 56 53 48 8b d9 8b 42 08 33 c9 85 c0 7e 37 4d 8b 11 4c 63 d9 4f 8d 14 5a 4c 8b 1a 48 63 f1 45 0f b7 1c 73 49 8b 30 48 63 f9 0f b7 34 7e 45 0f b7 db 44 33 de 41 f7 d3 45 0f b7 db 66 45 89 1a ff c1 3b c8 7c c9 48 8b fb 49 8b f1 e8 ff d6 5f 5f 48 a5 48 8b c3 5b 5e 5f c3}
; Capture completion code, None
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
0006h mov eax,[rdx+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 42 08}
0009h xor ecx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c9}
000bh test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
000dh jle short 0046h                         ; JLE rel8 || 7E cb || encoded[2]{7e 37}
000fh mov r10,[r9]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b 11}
0012h movsxd r11,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4c 63 d9}
0015h lea r10,[r10+r11*2]                     ; LEA r64, m || REX.W 8D /r || encoded[4]{4f 8d 14 5a}
0019h mov r11,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b 1a}
001ch movsxd rsi,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 f1}
001fh movzx r11d,word ptr [r11+rsi*2]         ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[5]{45 0f b7 1c 73}
0024h mov rsi,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b 30}
0027h movsxd rdi,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 f9}
002ah movzx esi,word ptr [rsi+rdi*2]          ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[4]{0f b7 34 7e}
002eh movzx r11d,r11w                         ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[4]{45 0f b7 db}
0032h xor r11d,esi                            ; XOR r32, r/m32 || o32 33 /r || encoded[3]{44 33 de}
0035h not r11d                                ; NOT r/m32 || o32 F7 /2 || encoded[3]{41 f7 d3}
0038h movzx r11d,r11w                         ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[4]{45 0f b7 db}
003ch mov [r10],r11w                          ; MOV r/m16, r16 || o16 89 /r || encoded[4]{66 45 89 1a}
0040h inc ecx                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c1}
0042h cmp ecx,eax                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b c8}
0044h jl short 000fh                          ; JL rel8 || 7C cb || encoded[2]{7c c9}
0046h mov rdi,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fb}
0049h mov rsi,r9                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b f1}
004ch call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 ff d6 5f 5f}
0051h movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
0053h mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
0056h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
0057h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
0058h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
0059h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; RowBits<uint> xnor_32u(RowBits<uint> x, RowBits<uint> y, RowBits<uint> dst)
; xnor_32u_0x[0x7ff7c83987c0, 0x7ff7c839880a][74] = {57 56 53 48 8b d9 8b 42 08 33 c9 85 c0 7e 27 4d 8b 11 4c 63 d9 4f 8d 14 9a 48 8b 32 42 8b 34 9e 49 8b 38 46 8b 1c 9f 44 33 de 41 f7 d3 45 89 1a ff c1 3b c8 7c d9 48 8b fb 49 8b f1 e8 8f d6 5f 5f 48 a5 48 8b c3 5b 5e 5f c3}
; Capture completion code, None
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
0006h mov eax,[rdx+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 42 08}
0009h xor ecx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c9}
000bh test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
000dh jle short 0036h                         ; JLE rel8 || 7E cb || encoded[2]{7e 27}
000fh mov r10,[r9]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b 11}
0012h movsxd r11,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4c 63 d9}
0015h lea r10,[r10+r11*4]                     ; LEA r64, m || REX.W 8D /r || encoded[4]{4f 8d 14 9a}
0019h mov rsi,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 32}
001ch mov esi,[rsi+r11*4]                     ; MOV r32, r/m32 || o32 8B /r || encoded[4]{42 8b 34 9e}
0020h mov rdi,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b 38}
0023h mov r11d,[rdi+r11*4]                    ; MOV r32, r/m32 || o32 8B /r || encoded[4]{46 8b 1c 9f}
0027h xor r11d,esi                            ; XOR r32, r/m32 || o32 33 /r || encoded[3]{44 33 de}
002ah not r11d                                ; NOT r/m32 || o32 F7 /2 || encoded[3]{41 f7 d3}
002dh mov [r10],r11d                          ; MOV r/m32, r32 || o32 89 /r || encoded[3]{45 89 1a}
0030h inc ecx                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c1}
0032h cmp ecx,eax                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b c8}
0034h jl short 000fh                          ; JL rel8 || 7C cb || encoded[2]{7c d9}
0036h mov rdi,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fb}
0039h mov rsi,r9                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b f1}
003ch call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 8f d6 5f 5f}
0041h movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
0043h mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
0046h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
0047h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
0048h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
0049h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; RowBits<ulong> xnor_64u(RowBits<ulong> x, RowBits<ulong> y, RowBits<ulong> dst)
; xnor_64u_0x[0x7ff7c8398830, 0x7ff7c839887a][74] = {57 56 53 48 8b d9 8b 42 08 33 c9 85 c0 7e 27 4d 8b 11 4c 63 d9 4f 8d 14 da 48 8b 32 4a 8b 34 de 49 8b 38 4e 8b 1c df 4c 33 de 49 f7 d3 4d 89 1a ff c1 3b c8 7c d9 48 8b fb 49 8b f1 e8 1f d6 5f 5f 48 a5 48 8b c3 5b 5e 5f c3}
; Capture completion code, None
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
0006h mov eax,[rdx+8]                         ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 42 08}
0009h xor ecx,ecx                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c9}
000bh test eax,eax                            ; TEST r/m32, r32 || o32 85 /r || encoded[2]{85 c0}
000dh jle short 0036h                         ; JLE rel8 || 7E cb || encoded[2]{7e 27}
000fh mov r10,[r9]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b 11}
0012h movsxd r11,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4c 63 d9}
0015h lea r10,[r10+r11*8]                     ; LEA r64, m || REX.W 8D /r || encoded[4]{4f 8d 14 da}
0019h mov rsi,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 32}
001ch mov rsi,[rsi+r11*8]                     ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{4a 8b 34 de}
0020h mov rdi,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b 38}
0023h mov r11,[rdi+r11*8]                     ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{4e 8b 1c df}
0027h xor r11,rsi                             ; XOR r64, r/m64 || REX.W 33 /r || encoded[3]{4c 33 de}
002ah not r11                                 ; NOT r/m64 || REX.W F7 /2 || encoded[3]{49 f7 d3}
002dh mov [r10],r11                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4d 89 1a}
0030h inc ecx                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c1}
0032h cmp ecx,eax                             ; CMP r32, r/m32 || o32 3B /r || encoded[2]{3b c8}
0034h jl short 000fh                          ; JL rel8 || 7C cb || encoded[2]{7c d9}
0036h mov rdi,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fb}
0039h mov rsi,r9                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b f1}
003ch call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 1f d6 5f 5f}
0041h movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
0043h mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
0046h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
0047h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
0048h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
0049h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; RowBits<byte> not_8u(RowBits<byte> x, RowBits<byte> dst)
; not_8u_0x[0x7ff7c8398ca0, 0x7ff7c8398ce4][68] = {57 56 53 48 8b d9 33 c0 83 7a 08 00 7e 22 49 8b 08 4c 63 c8 49 03 c9 4c 8b 12 47 0f b6 0c 0a 41 f7 d1 45 0f b6 c9 44 88 09 ff c0 3b 42 08 7c de 48 8b fb 49 8b f0 e8 b5 d1 5f 5f 48 a5 48 8b c3 5b 5e 5f c3}
; Capture completion code, None
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
0006h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0008h cmp dword ptr [rdx+8],0                 ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[4]{83 7a 08 00}
000ch jle short 0030h                         ; JLE rel8 || 7E cb || encoded[2]{7e 22}
000eh mov rcx,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b 08}
0011h movsxd r9,eax                           ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4c 63 c8}
0014h add rcx,r9                              ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{49 03 c9}
0017h mov r10,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b 12}
001ah movzx r9d,byte ptr [r10+r9]             ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[5]{47 0f b6 0c 0a}
001fh not r9d                                 ; NOT r/m32 || o32 F7 /2 || encoded[3]{41 f7 d1}
0022h movzx r9d,r9b                           ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{45 0f b6 c9}
0026h mov [rcx],r9b                           ; MOV r/m8, r8 || 88 /r || encoded[3]{44 88 09}
0029h inc eax                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c0}
002bh cmp eax,[rdx+8]                         ; CMP r32, r/m32 || o32 3B /r || encoded[3]{3b 42 08}
002eh jl short 000eh                          ; JL rel8 || 7C cb || encoded[2]{7c de}
0030h mov rdi,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fb}
0033h mov rsi,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b f0}
0036h call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 b5 d1 5f 5f}
003bh movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
003dh mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
0040h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
0041h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
0042h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
0043h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; RowBits<ushort> not_16u(RowBits<ushort> x, RowBits<ushort> dst)
; not_16u_0x[0x7ff7c8398d00, 0x7ff7c8398d46][70] = {57 56 53 48 8b d9 33 c0 83 7a 08 00 7e 24 49 8b 08 4c 63 c8 4a 8d 0c 49 4c 8b 12 47 0f b7 0c 4a 41 f7 d1 45 0f b7 c9 66 44 89 09 ff c0 3b 42 08 7c dc 48 8b fb 49 8b f0 e8 53 d1 5f 5f 48 a5 48 8b c3 5b 5e 5f c3}
; Capture completion code, None
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
0006h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0008h cmp dword ptr [rdx+8],0                 ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[4]{83 7a 08 00}
000ch jle short 0032h                         ; JLE rel8 || 7E cb || encoded[2]{7e 24}
000eh mov rcx,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b 08}
0011h movsxd r9,eax                           ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4c 63 c8}
0014h lea rcx,[rcx+r9*2]                      ; LEA r64, m || REX.W 8D /r || encoded[4]{4a 8d 0c 49}
0018h mov r10,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b 12}
001bh movzx r9d,word ptr [r10+r9*2]           ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[5]{47 0f b7 0c 4a}
0020h not r9d                                 ; NOT r/m32 || o32 F7 /2 || encoded[3]{41 f7 d1}
0023h movzx r9d,r9w                           ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[4]{45 0f b7 c9}
0027h mov [rcx],r9w                           ; MOV r/m16, r16 || o16 89 /r || encoded[4]{66 44 89 09}
002bh inc eax                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c0}
002dh cmp eax,[rdx+8]                         ; CMP r32, r/m32 || o32 3B /r || encoded[3]{3b 42 08}
0030h jl short 000eh                          ; JL rel8 || 7C cb || encoded[2]{7c dc}
0032h mov rdi,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fb}
0035h mov rsi,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b f0}
0038h call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 53 d1 5f 5f}
003dh movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
003fh mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
0042h pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
0043h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
0044h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
0045h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; RowBits<uint> not_32u(RowBits<uint> x, RowBits<uint> dst)
; not_32u_0x[0x7ff7c8398d60, 0x7ff7c8398da0][64] = {57 56 53 48 8b d9 33 c0 83 7a 08 00 7e 1e 49 8b 08 4c 63 c8 4a 8d 0c 89 4c 8b 12 47 8b 0c 8a 41 f7 d1 44 89 09 ff c0 3b 42 08 7c e2 48 8b fb 49 8b f0 e8 f9 d0 5f 5f 48 a5 48 8b c3 5b 5e 5f c3}
; Capture completion code, None
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
0006h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0008h cmp dword ptr [rdx+8],0                 ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[4]{83 7a 08 00}
000ch jle short 002ch                         ; JLE rel8 || 7E cb || encoded[2]{7e 1e}
000eh mov rcx,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b 08}
0011h movsxd r9,eax                           ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4c 63 c8}
0014h lea rcx,[rcx+r9*4]                      ; LEA r64, m || REX.W 8D /r || encoded[4]{4a 8d 0c 89}
0018h mov r10,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b 12}
001bh mov r9d,[r10+r9*4]                      ; MOV r32, r/m32 || o32 8B /r || encoded[4]{47 8b 0c 8a}
001fh not r9d                                 ; NOT r/m32 || o32 F7 /2 || encoded[3]{41 f7 d1}
0022h mov [rcx],r9d                           ; MOV r/m32, r32 || o32 89 /r || encoded[3]{44 89 09}
0025h inc eax                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c0}
0027h cmp eax,[rdx+8]                         ; CMP r32, r/m32 || o32 3B /r || encoded[3]{3b 42 08}
002ah jl short 000eh                          ; JL rel8 || 7C cb || encoded[2]{7c e2}
002ch mov rdi,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fb}
002fh mov rsi,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b f0}
0032h call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 f9 d0 5f 5f}
0037h movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
0039h mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
003ch pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
003dh pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
003eh pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
003fh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; RowBits<ulong> not_64u(RowBits<ulong> x, RowBits<ulong> dst)
; not_64u_0x[0x7ff7c8398dc0, 0x7ff7c8398e03][67] = {57 56 53 48 8b d9 33 c0 83 7a 08 00 7e 21 49 8b 08 4c 63 c8 4a 8d 0c c9 4c 8b 0a 4c 63 d0 4f 8b 0c d1 49 f7 d1 4c 89 09 ff c0 3b 42 08 7c df 48 8b fb 49 8b f0 e8 96 d0 5f 5f 48 a5 48 8b c3 5b 5e 5f c3}
; Capture completion code, None
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h push rbx                                ; PUSH r64 || 50+ro || encoded[1]{53}
0003h mov rbx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d9}
0006h xor eax,eax                             ; XOR r32, r/m32 || o32 33 /r || encoded[2]{33 c0}
0008h cmp dword ptr [rdx+8],0                 ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[4]{83 7a 08 00}
000ch jle short 002fh                         ; JLE rel8 || 7E cb || encoded[2]{7e 21}
000eh mov rcx,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b 08}
0011h movsxd r9,eax                           ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4c 63 c8}
0014h lea rcx,[rcx+r9*8]                      ; LEA r64, m || REX.W 8D /r || encoded[4]{4a 8d 0c c9}
0018h mov r9,[rdx]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b 0a}
001bh movsxd r10,eax                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4c 63 d0}
001eh mov r9,[r9+r10*8]                       ; MOV r64, r/m64 || REX.W 8B /r || encoded[4]{4f 8b 0c d1}
0022h not r9                                  ; NOT r/m64 || REX.W F7 /2 || encoded[3]{49 f7 d1}
0025h mov [rcx],r9                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 09}
0028h inc eax                                 ; INC r/m32 || o32 FF /0 || encoded[2]{ff c0}
002ah cmp eax,[rdx+8]                         ; CMP r32, r/m32 || o32 3B /r || encoded[3]{3b 42 08}
002dh jl short 000eh                          ; JL rel8 || 7C cb || encoded[2]{7c df}
002fh mov rdi,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b fb}
0032h mov rsi,r8                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b f0}
0035h call 7FF827995E90h                      ; CALL rel32 || E8 cd || encoded[5]{e8 96 d0 5f 5f}
003ah movsq                                   ; MOVSQ || REX.W A5 || encoded[2]{48 a5}
003ch mov rax,rbx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c3}
003fh pop rbx                                 ; POP r64 || 58+ro || encoded[1]{5b}
0040h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
0041h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
0042h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
