; 2020-01-20 01:59:20:758
; ReadOnlySpan<byte> bitseq(byte value)
; static ReadOnlySpan<byte> bitseq_8uBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0xC1,0xE0,0x03,0x48,0x63,0xC0,0x48,0xBA,0x4D,0xA1,0x03,0x9C,0x4C,0x02,0x00,0x00,0x48,0x03,0xC2,0x48,0x89,0x01,0xC7,0x41,0x08,0x08,0x00,0x00,0x00,0x48,0x8B,0xC1,0xC3};
; [0x7ff7c83855e0, 0x7ff7c8385609], 41 bytes
; 2020-01-20 01:59:20:758
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h movzx eax,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c2}
0008h shl eax,3                               ; SHL r/m32, imm8 || o32 C1 /4 ib || encoded[3]{c1 e0 03}
000bh movsxd rax,eax                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 c0}
000eh mov rdx,24C9C03A14Dh                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 ba 4d a1 03 9c 4c 02 00 00}
0018h add rax,rdx                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{48 03 c2}
001bh mov [rcx],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 01}
001eh mov dword ptr [rcx+8],8                 ; MOV r/m32, imm32 || o32 C7 /0 id || encoded[7]{c7 41 08 08 00 00 00}
0025h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0028h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void bitseq_8u(byte value, Span<byte> dst)
; static ReadOnlySpan<byte> bitseq_8u_28649262Bytes => new byte[37]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x0F,0xB6,0xD1,0xC1,0xE2,0x03,0x48,0x63,0xD2,0x48,0xB9,0x4D,0xA1,0x03,0x9C,0x4C,0x02,0x00,0x00,0x48,0x03,0xD1,0x48,0x8B,0x12,0x48,0x89,0x10,0xC3};
; [0x7ff7c8385a30, 0x7ff7c8385a55], 37 bytes
; 2020-01-20 01:59:20:758
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
0008h movzx edx,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d1}
000bh shl edx,3                               ; SHL r/m32, imm8 || o32 C1 /4 ib || encoded[3]{c1 e2 03}
000eh movsxd rdx,edx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 d2}
0011h mov rcx,24C9C03A14Dh                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 4d a1 03 9c 4c 02 00 00}
001bh add rdx,rcx                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{48 03 d1}
001eh mov rdx,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 12}
0021h mov [rax],rdx                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 10}
0024h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void bitseq_16u(ushort value, Span<byte> dst)
; static ReadOnlySpan<byte> bitseq_16u_56516768Bytes => new byte[70]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x0F,0xB7,0xD1,0x48,0x8B,0xC8,0x44,0x0F,0xB6,0xC2,0x41,0xC1,0xE0,0x03,0x4D,0x63,0xC0,0x49,0xB9,0x4D,0xA1,0x03,0x9C,0x4C,0x02,0x00,0x00,0x4D,0x03,0xC1,0x4D,0x8B,0x00,0x4C,0x89,0x01,0x48,0x83,0xC0,0x08,0xC1,0xFA,0x08,0x0F,0xB6,0xD2,0xC1,0xE2,0x03,0x48,0x63,0xD2,0x49,0x03,0xD1,0x48,0x8B,0x12,0x48,0x89,0x10,0xC3};
; [0x7ff7c8385a70, 0x7ff7c8385ab6], 70 bytes
; 2020-01-20 01:59:20:758
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
0008h movzx edx,cx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 d1}
000bh mov rcx,rax                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c8}
000eh movzx r8d,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{44 0f b6 c2}
0012h shl r8d,3                               ; SHL r/m32, imm8 || o32 C1 /4 ib || encoded[4]{41 c1 e0 03}
0016h movsxd r8,r8d                           ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4d 63 c0}
0019h mov r9,24C9C03A14Dh                     ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 b9 4d a1 03 9c 4c 02 00 00}
0023h add r8,r9                               ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{4d 03 c1}
0026h mov r8,[r8]                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b 00}
0029h mov [rcx],r8                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 01}
002ch add rax,8                               ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c0 08}
0030h sar edx,8                               ; SAR r/m32, imm8 || o32 C1 /7 ib || encoded[3]{c1 fa 08}
0033h movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
0036h shl edx,3                               ; SHL r/m32, imm8 || o32 C1 /4 ib || encoded[3]{c1 e2 03}
0039h movsxd rdx,edx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 d2}
003ch add rdx,r9                              ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{49 03 d1}
003fh mov rdx,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 12}
0042h mov [rax],rdx                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 10}
0045h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void bitseq_32u(uint value, Span<byte> dst)
; static ReadOnlySpan<byte> bitseq_32u_38888871Bytes => new byte[70]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x8B,0xD1,0x45,0x33,0xC0,0x41,0x8B,0xC8,0xC1,0xE1,0x03,0x4C,0x63,0xC9,0x4C,0x03,0xC8,0x44,0x8B,0xD2,0x41,0xD3,0xEA,0x41,0x0F,0xB6,0xCA,0xC1,0xE1,0x03,0x48,0x63,0xC9,0x49,0xBA,0x4D,0xA1,0x03,0x9C,0x4C,0x02,0x00,0x00,0x49,0x03,0xCA,0x48,0x8B,0x09,0x49,0x89,0x09,0x41,0xFF,0xC0,0x41,0x83,0xF8,0x04,0x7C,0xC8,0xC3};
; [0x7ff7c8385ad0, 0x7ff7c8385b16], 70 bytes
; 2020-01-20 01:59:20:758
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
0008h mov edx,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b d1}
000ah xor r8d,r8d                             ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 c0}
000dh mov ecx,r8d                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b c8}
0010h shl ecx,3                               ; SHL r/m32, imm8 || o32 C1 /4 ib || encoded[3]{c1 e1 03}
0013h movsxd r9,ecx                           ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4c 63 c9}
0016h add r9,rax                              ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{4c 03 c8}
0019h mov r10d,edx                            ; MOV r32, r/m32 || o32 8B /r || encoded[3]{44 8b d2}
001ch shr r10d,cl                             ; SHR r/m32, CL || o32 D3 /5 || encoded[3]{41 d3 ea}
001fh movzx ecx,r10b                          ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{41 0f b6 ca}
0023h shl ecx,3                               ; SHL r/m32, imm8 || o32 C1 /4 ib || encoded[3]{c1 e1 03}
0026h movsxd rcx,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 c9}
0029h mov r10,24C9C03A14Dh                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 ba 4d a1 03 9c 4c 02 00 00}
0033h add rcx,r10                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{49 03 ca}
0036h mov rcx,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 09}
0039h mov [r9],rcx                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 09}
003ch inc r8d                                 ; INC r/m32 || o32 FF /0 || encoded[3]{41 ff c0}
003fh cmp r8d,4                               ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[4]{41 83 f8 04}
0043h jl short 000dh                          ; JL rel8 || 7C cb || encoded[2]{7c c8}
0045h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void bitseq_64u(ulong value, Span<byte> dst)
; static ReadOnlySpan<byte> bitseq_64u_14455523Bytes => new byte[71]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x48,0x8B,0xD1,0x45,0x33,0xC0,0x41,0x8B,0xC8,0xC1,0xE1,0x03,0x4C,0x63,0xC9,0x4C,0x03,0xC8,0x4C,0x8B,0xD2,0x49,0xD3,0xEA,0x41,0x0F,0xB6,0xCA,0xC1,0xE1,0x03,0x48,0x63,0xC9,0x49,0xBA,0x4D,0xA1,0x03,0x9C,0x4C,0x02,0x00,0x00,0x49,0x03,0xCA,0x48,0x8B,0x09,0x49,0x89,0x09,0x41,0xFF,0xC0,0x41,0x83,0xF8,0x08,0x7C,0xC8,0xC3};
; [0x7ff7c8385b30, 0x7ff7c8385b77], 71 bytes
; 2020-01-20 01:59:20:758
0000h nop dword ptr [rax+rax]                 ; NOP r/m32 || o32 0F 1F /0 || encoded[5]{0f 1f 44 00 00}
0005h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
0008h mov rdx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d1}
000bh xor r8d,r8d                             ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 c0}
000eh mov ecx,r8d                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b c8}
0011h shl ecx,3                               ; SHL r/m32, imm8 || o32 C1 /4 ib || encoded[3]{c1 e1 03}
0014h movsxd r9,ecx                           ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4c 63 c9}
0017h add r9,rax                              ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{4c 03 c8}
001ah mov r10,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b d2}
001dh shr r10,cl                              ; SHR r/m64, CL || REX.W D3 /5 || encoded[3]{49 d3 ea}
0020h movzx ecx,r10b                          ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{41 0f b6 ca}
0024h shl ecx,3                               ; SHL r/m32, imm8 || o32 C1 /4 ib || encoded[3]{c1 e1 03}
0027h movsxd rcx,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 c9}
002ah mov r10,24C9C03A14Dh                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 ba 4d a1 03 9c 4c 02 00 00}
0034h add rcx,r10                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{49 03 ca}
0037h mov rcx,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 09}
003ah mov [r9],rcx                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{49 89 09}
003dh inc r8d                                 ; INC r/m32 || o32 FF /0 || encoded[3]{41 ff c0}
0040h cmp r8d,8                               ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[4]{41 83 f8 08}
0044h jl short 000eh                          ; JL rel8 || 7C cb || encoded[2]{7c c8}
0046h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ReadOnlySpan<byte> bitseq(int offset, int count)
; static ReadOnlySpan<byte> bitseq_32iBytes => new byte[58]{0x48,0x83,0xEC,0x28,0x90,0x8B,0xC2,0x45,0x8B,0xC8,0x49,0x03,0xC1,0x48,0x3D,0x00,0x08,0x00,0x00,0x77,0x1F,0x48,0x63,0xC2,0x48,0xBA,0x4D,0xA1,0x03,0x9C,0x4C,0x02,0x00,0x00,0x48,0x03,0xC2,0x48,0x89,0x01,0x44,0x89,0x41,0x08,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xA7,0x30,0xB0,0xFF,0xCC};
; [0x7ff7c8385b90, 0x7ff7c8385bca], 58 bytes
; 2020-01-20 01:59:20:758
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h mov eax,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b c2}
0007h mov r9d,r8d                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{45 8b c8}
000ah add rax,r9                              ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{49 03 c1}
000dh cmp rax,800h                            ; CMP RAX, imm32 || REX.W 3D id || encoded[6]{48 3d 00 08 00 00}
0013h ja short 0034h                          ; JA rel8 || 77 cb || encoded[2]{77 1f}
0015h movsxd rax,edx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 c2}
0018h mov rdx,24C9C03A14Dh                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 ba 4d a1 03 9c 4c 02 00 00}
0022h add rax,rdx                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{48 03 c2}
0025h mov [rcx],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 01}
0028h mov [rcx+8],r8d                         ; MOV r/m32, r32 || o32 89 /r || encoded[4]{44 89 41 08}
002ch mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
002fh add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0033h ret                                     ; RET || C3 || encoded[1]{c3}
0034h call 7FF7C7E88C70h                      ; CALL rel32 || E8 cd || encoded[5]{e8 a7 30 b0 ff}
0039h int 3                                   ; INT3 || CC || encoded[1]{cc}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ReadOnlySpan<byte> bitseq8u(byte src)
; static ReadOnlySpan<byte> bitseq8u_8uBytes => new byte[89]{0x57,0x56,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF1,0x8B,0xFA,0x48,0xB9,0x10,0xEA,0xE3,0xC7,0xF7,0x7F,0x00,0x00,0xBA,0x08,0x00,0x00,0x00,0xE8,0xE1,0x11,0x61,0x5F,0x48,0x8D,0x50,0x10,0x40,0x0F,0xB6,0xCF,0xC1,0xE1,0x03,0x48,0x63,0xC9,0x49,0xB8,0x4D,0xA1,0x03,0x9C,0x4C,0x02,0x00,0x00,0x49,0x03,0xC8,0x48,0x8B,0x09,0x48,0x89,0x0A,0x48,0x83,0xC0,0x10,0xBA,0x08,0x00,0x00,0x00,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
; [0x7ff7c8385be0, 0x7ff7c8385c39], 89 bytes
; 2020-01-20 01:59:20:758
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0006h mov rsi,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b f1}
0009h mov edi,edx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b fa}
000bh mov rcx,7FF7C7E3EA10h                   ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 10 ea e3 c7 f7 7f 00 00}
0015h mov edx,8                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 08 00 00 00}
001ah call 7FF827996DE0h                      ; CALL rel32 || E8 cd || encoded[5]{e8 e1 11 61 5f}
001fh lea rdx,[rax+10h]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{48 8d 50 10}
0023h movzx ecx,dil                           ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{40 0f b6 cf}
0027h shl ecx,3                               ; SHL r/m32, imm8 || o32 C1 /4 ib || encoded[3]{c1 e1 03}
002ah movsxd rcx,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 c9}
002dh mov r8,24C9C03A14Dh                     ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 b8 4d a1 03 9c 4c 02 00 00}
0037h add rcx,r8                              ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{49 03 c8}
003ah mov rcx,[rcx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 09}
003dh mov [rdx],rcx                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 0a}
0040h add rax,10h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c0 10}
0044h mov edx,8                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 08 00 00 00}
0049h mov [rsi],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 06}
004ch mov [rsi+8],edx                         ; MOV r/m32, r32 || o32 89 /r || encoded[3]{89 56 08}
004fh mov rax,rsi                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c6}
0052h add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
0056h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
0057h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
0058h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; ReadOnlySpan<Char> bitchars_8u(byte value)
; static ReadOnlySpan<byte> bitchars_8u_8uBytes => new byte[52]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0xC1,0xE0,0x04,0x48,0x63,0xC0,0x48,0xBA,0x55,0xAB,0x03,0x9C,0x4C,0x02,0x00,0x00,0x48,0x03,0xC2,0xBA,0x08,0x00,0x00,0x00,0x48,0x89,0x01,0x89,0x51,0x08,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x8D,0x9B,0x73,0x5F,0xCC};
; [0x7ff7c8386060, 0x7ff7c8386094], 52 bytes
; 2020-01-20 01:59:20:758
0000h sub rsp,28h                             ; SUB r/m64, imm8 || REX.W 83 /5 ib || encoded[4]{48 83 ec 28}
0004h nop                                     ; NOP || o32 90 || encoded[1]{90}
0005h movzx eax,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 c2}
0008h shl eax,4                               ; SHL r/m32, imm8 || o32 C1 /4 ib || encoded[3]{c1 e0 04}
000bh movsxd rax,eax                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 c0}
000eh mov rdx,24C9C03AB55h                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 ba 55 ab 03 9c 4c 02 00 00}
0018h add rax,rdx                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{48 03 c2}
001bh mov edx,8                               ; MOV r32, imm32 || o32 B8+rd id || encoded[5]{ba 08 00 00 00}
0020h mov [rcx],rax                           ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{48 89 01}
0023h mov [rcx+8],edx                         ; MOV r/m32, r32 || o32 89 /r || encoded[3]{89 51 08}
0026h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0029h add rsp,28h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c4 28}
002dh ret                                     ; RET || C3 || encoded[1]{c3}
002eh call 7FF827ABFC20h                      ; CALL rel32 || E8 cd || encoded[5]{e8 8d 9b 73 5f}
0033h int 3                                   ; INT3 || CC || encoded[1]{cc}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void bitchars_8u(byte value, Span<Char> dst)
; static ReadOnlySpan<byte> bitchars_8u_17863121Bytes => new byte[39]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x02,0x0F,0xB6,0xD1,0xC1,0xE2,0x04,0x48,0x63,0xD2,0x48,0xB9,0x55,0xAB,0x03,0x9C,0x4C,0x02,0x00,0x00,0x48,0x03,0xD1,0xC5,0xFA,0x6F,0x02,0xC5,0xFA,0x7F,0x00,0xC3};
; [0x7ff7c83860b0, 0x7ff7c83860d7], 39 bytes
; 2020-01-20 01:59:20:758
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
0008h movzx edx,cl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d1}
000bh shl edx,4                               ; SHL r/m32, imm8 || o32 C1 /4 ib || encoded[3]{c1 e2 04}
000eh movsxd rdx,edx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 d2}
0011h mov rcx,24C9C03AB55h                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 55 ab 03 9c 4c 02 00 00}
001bh add rdx,rcx                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{48 03 d1}
001eh vmovdqu xmm0,xmmword ptr [rdx]          ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[4]{c5 fa 6f 02}
0022h vmovdqu xmmword ptr [rax],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 00}
0026h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void bitchars_16u(ushort value, Span<Char> dst)
; static ReadOnlySpan<byte> bitchars_16u_26550365Bytes => new byte[83]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x02,0x0F,0xB7,0xD1,0x0F,0xB6,0xCA,0xC1,0xE1,0x04,0x48,0x63,0xC9,0x49,0xB8,0x55,0xAB,0x03,0x9C,0x4C,0x02,0x00,0x00,0x49,0x03,0xC8,0x4C,0x8B,0xC0,0xC5,0xFA,0x6F,0x01,0xC4,0xC1,0x7A,0x7F,0x00,0xC1,0xFA,0x08,0x0F,0xB6,0xD2,0xC1,0xE2,0x04,0x48,0x63,0xD2,0x48,0xB9,0x55,0xAB,0x03,0x9C,0x4C,0x02,0x00,0x00,0x48,0x03,0xD1,0x48,0x83,0xC0,0x10,0xC5,0xFA,0x6F,0x02,0xC5,0xFA,0x7F,0x00,0xC3};
; [0x7ff7c83860f0, 0x7ff7c8386143], 83 bytes
; 2020-01-20 01:59:20:758
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
0008h movzx edx,cx                            ; MOVZX r32, r/m16 || o32 0F B7 /r || encoded[3]{0f b7 d1}
000bh movzx ecx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 ca}
000eh shl ecx,4                               ; SHL r/m32, imm8 || o32 C1 /4 ib || encoded[3]{c1 e1 04}
0011h movsxd rcx,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 c9}
0014h mov r8,24C9C03AB55h                     ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 b8 55 ab 03 9c 4c 02 00 00}
001eh add rcx,r8                              ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{49 03 c8}
0021h mov r8,rax                              ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b c0}
0024h vmovdqu xmm0,xmmword ptr [rcx]          ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[4]{c5 fa 6f 01}
0028h vmovdqu xmmword ptr [r8],xmm0           ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c4 c1 7a 7f 00}
002dh sar edx,8                               ; SAR r/m32, imm8 || o32 C1 /7 ib || encoded[3]{c1 fa 08}
0030h movzx edx,dl                            ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[3]{0f b6 d2}
0033h shl edx,4                               ; SHL r/m32, imm8 || o32 C1 /4 ib || encoded[3]{c1 e2 04}
0036h movsxd rdx,edx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 d2}
0039h mov rcx,24C9C03AB55h                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{48 b9 55 ab 03 9c 4c 02 00 00}
0043h add rdx,rcx                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{48 03 d1}
0046h add rax,10h                             ; ADD r/m64, imm8 || REX.W 83 /0 ib || encoded[4]{48 83 c0 10}
004ah vmovdqu xmm0,xmmword ptr [rdx]          ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[4]{c5 fa 6f 02}
004eh vmovdqu xmmword ptr [rax],xmm0          ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 00}
0052h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void bitchars_32u(uint value, Span<Char> dst)
; static ReadOnlySpan<byte> bitchars_32u_37626701Bytes => new byte[78]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x02,0x8B,0xD1,0x45,0x33,0xC0,0x45,0x8B,0xC8,0x41,0xC1,0xE1,0x03,0x41,0x8B,0xC9,0x44,0x8B,0xD2,0x41,0xD3,0xEA,0x41,0x0F,0xB6,0xCA,0xC1,0xE1,0x04,0x48,0x63,0xC9,0x49,0xBA,0x55,0xAB,0x03,0x9C,0x4C,0x02,0x00,0x00,0x49,0x03,0xCA,0x4D,0x63,0xC9,0x4E,0x8D,0x0C,0x48,0xC5,0xFA,0x6F,0x01,0xC4,0xC1,0x7A,0x7F,0x01,0x41,0xFF,0xC0,0x41,0x83,0xF8,0x04,0x7C,0xC0,0xC3};
; [0x7ff7c8386160, 0x7ff7c83861ae], 78 bytes
; 2020-01-20 01:59:20:758
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
0008h mov edx,ecx                             ; MOV r32, r/m32 || o32 8B /r || encoded[2]{8b d1}
000ah xor r8d,r8d                             ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 c0}
000dh mov r9d,r8d                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{45 8b c8}
0010h shl r9d,3                               ; SHL r/m32, imm8 || o32 C1 /4 ib || encoded[4]{41 c1 e1 03}
0014h mov ecx,r9d                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b c9}
0017h mov r10d,edx                            ; MOV r32, r/m32 || o32 8B /r || encoded[3]{44 8b d2}
001ah shr r10d,cl                             ; SHR r/m32, CL || o32 D3 /5 || encoded[3]{41 d3 ea}
001dh movzx ecx,r10b                          ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{41 0f b6 ca}
0021h shl ecx,4                               ; SHL r/m32, imm8 || o32 C1 /4 ib || encoded[3]{c1 e1 04}
0024h movsxd rcx,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 c9}
0027h mov r10,24C9C03AB55h                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 ba 55 ab 03 9c 4c 02 00 00}
0031h add rcx,r10                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{49 03 ca}
0034h movsxd r9,r9d                           ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4d 63 c9}
0037h lea r9,[rax+r9*2]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{4e 8d 0c 48}
003bh vmovdqu xmm0,xmmword ptr [rcx]          ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[4]{c5 fa 6f 01}
003fh vmovdqu xmmword ptr [r9],xmm0           ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c4 c1 7a 7f 01}
0044h inc r8d                                 ; INC r/m32 || o32 FF /0 || encoded[3]{41 ff c0}
0047h cmp r8d,4                               ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[4]{41 83 f8 04}
004bh jl short 000dh                          ; JL rel8 || 7C cb || encoded[2]{7c c0}
004dh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; void bitchars_64u(ulong value, Span<Char> dst)
; static ReadOnlySpan<byte> bitchars_64u_3095993Bytes => new byte[79]{0xC5,0xF8,0x77,0x66,0x90,0x48,0x8B,0x02,0x48,0x8B,0xD1,0x45,0x33,0xC0,0x45,0x8B,0xC8,0x41,0xC1,0xE1,0x03,0x41,0x8B,0xC9,0x4C,0x8B,0xD2,0x49,0xD3,0xEA,0x41,0x0F,0xB6,0xCA,0xC1,0xE1,0x04,0x48,0x63,0xC9,0x49,0xBA,0x55,0xAB,0x03,0x9C,0x4C,0x02,0x00,0x00,0x49,0x03,0xCA,0x4D,0x63,0xC9,0x4E,0x8D,0x0C,0x48,0xC5,0xFA,0x6F,0x01,0xC4,0xC1,0x7A,0x7F,0x01,0x41,0xFF,0xC0,0x41,0x83,0xF8,0x08,0x7C,0xC0,0xC3};
; [0x7ff7c83861c0, 0x7ff7c838620f], 79 bytes
; 2020-01-20 01:59:20:758
0000h vzeroupper                              ; VZEROUPPER || VEX.128.0F.WIG 77 || encoded[3]{c5 f8 77}
0003h xchg ax,ax                              ; NOP || o16 90 || encoded[2]{66 90}
0005h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
0008h mov rdx,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b d1}
000bh xor r8d,r8d                             ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 c0}
000eh mov r9d,r8d                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{45 8b c8}
0011h shl r9d,3                               ; SHL r/m32, imm8 || o32 C1 /4 ib || encoded[4]{41 c1 e1 03}
0015h mov ecx,r9d                             ; MOV r32, r/m32 || o32 8B /r || encoded[3]{41 8b c9}
0018h mov r10,rdx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4c 8b d2}
001bh shr r10,cl                              ; SHR r/m64, CL || REX.W D3 /5 || encoded[3]{49 d3 ea}
001eh movzx ecx,r10b                          ; MOVZX r32, r/m8 || o32 0F B6 /r || encoded[4]{41 0f b6 ca}
0022h shl ecx,4                               ; SHL r/m32, imm8 || o32 C1 /4 ib || encoded[3]{c1 e1 04}
0025h movsxd rcx,ecx                          ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{48 63 c9}
0028h mov r10,24C9C03AB55h                    ; MOV r64, imm64 || REX.W B8+ro io || encoded[10]{49 ba 55 ab 03 9c 4c 02 00 00}
0032h add rcx,r10                             ; ADD r64, r/m64 || REX.W 03 /r || encoded[3]{49 03 ca}
0035h movsxd r9,r9d                           ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4d 63 c9}
0038h lea r9,[rax+r9*2]                       ; LEA r64, m || REX.W 8D /r || encoded[4]{4e 8d 0c 48}
003ch vmovdqu xmm0,xmmword ptr [rcx]          ; VMOVDQU xmm1, xmm2/m128 || VEX.128.F3.0F.WIG 6F /r || encoded[4]{c5 fa 6f 01}
0040h vmovdqu xmmword ptr [r9],xmm0           ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[5]{c4 c1 7a 7f 01}
0045h inc r8d                                 ; INC r/m32 || o32 FF /0 || encoded[3]{41 ff c0}
0048h cmp r8d,8                               ; CMP r/m32, imm8 || o32 83 /7 ib || encoded[4]{41 83 f8 08}
004ch jl short 000eh                          ; JL rel8 || 7C cb || encoded[2]{7c c0}
004eh ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
