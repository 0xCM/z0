; 2020-01-20 01:59:20:659
; Span<uint> msand_32u(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
; static ReadOnlySpan<byte> msand_32u_3663598Bytes => new byte[71]{0x57,0x56,0x0F,0x1F,0x00,0x48,0x8B,0x02,0x49,0x8B,0x10,0x4D,0x8B,0x01,0x45,0x8B,0x49,0x08,0x45,0x33,0xD2,0x45,0x85,0xC9,0x7E,0x20,0x4D,0x63,0xDA,0x4F,0x8D,0x1C,0x98,0x49,0x63,0xF2,0x8B,0x34,0xB0,0x49,0x63,0xFA,0x8B,0x3C,0xBA,0x23,0xF7,0x41,0x89,0x33,0x41,0xFF,0xC2,0x45,0x3B,0xD1,0x7C,0xE0,0x4C,0x89,0x01,0x44,0x89,0x49,0x08,0x48,0x8B,0xC1,0x5E,0x5F,0xC3};
; [0x7ff7c837f8d0, 0x7ff7c837f917], 71 bytes
; 2020-01-20 01:59:20:659
0000h push rdi                                ; PUSH r64 || 50+ro || encoded[1]{57}
0001h push rsi                                ; PUSH r64 || 50+ro || encoded[1]{56}
0002h nop dword ptr [rax]                     ; NOP r/m32 || o32 0F 1F /0 || encoded[3]{0f 1f 00}
0005h mov rax,[rdx]                           ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b 02}
0008h mov rdx,[r8]                            ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{49 8b 10}
000bh mov r8,[r9]                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{4d 8b 01}
000eh mov r9d,[r9+8]                          ; MOV r32, r/m32 || o32 8B /r || encoded[4]{45 8b 49 08}
0012h xor r10d,r10d                           ; XOR r32, r/m32 || o32 33 /r || encoded[3]{45 33 d2}
0015h test r9d,r9d                            ; TEST r/m32, r32 || o32 85 /r || encoded[3]{45 85 c9}
0018h jle short 003ah                         ; JLE rel8 || 7E cb || encoded[2]{7e 20}
001ah movsxd r11,r10d                         ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{4d 63 da}
001dh lea r11,[r8+r11*4]                      ; LEA r64, m || REX.W 8D /r || encoded[4]{4f 8d 1c 98}
0021h movsxd rsi,r10d                         ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{49 63 f2}
0024h mov esi,[rax+rsi*4]                     ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 34 b0}
0027h movsxd rdi,r10d                         ; MOVSXD r64, r/m32 || REX.W 63 /r || encoded[3]{49 63 fa}
002ah mov edi,[rdx+rdi*4]                     ; MOV r32, r/m32 || o32 8B /r || encoded[3]{8b 3c ba}
002dh and esi,edi                             ; AND r32, r/m32 || o32 23 /r || encoded[2]{23 f7}
002fh mov [r11],esi                           ; MOV r/m32, r32 || o32 89 /r || encoded[3]{41 89 33}
0032h inc r10d                                ; INC r/m32 || o32 FF /0 || encoded[3]{41 ff c2}
0035h cmp r10d,r9d                            ; CMP r32, r/m32 || o32 3B /r || encoded[3]{45 3b d1}
0038h jl short 001ah                          ; JL rel8 || 7C cb || encoded[2]{7c e0}
003ah mov [rcx],r8                            ; MOV r/m64, r64 || REX.W 89 /r || encoded[3]{4c 89 01}
003dh mov [rcx+8],r9d                         ; MOV r/m32, r32 || o32 89 /r || encoded[4]{44 89 49 08}
0041h mov rax,rcx                             ; MOV r64, r/m64 || REX.W 8B /r || encoded[3]{48 8b c1}
0044h pop rsi                                 ; POP r64 || 58+ro || encoded[1]{5e}
0045h pop rdi                                 ; POP r64 || 58+ro || encoded[1]{5f}
0046h ret                                     ; RET || C3 || encoded[1]{c3}
----------------------------------------------------------------------------------------------------------------------------------------------------------------
