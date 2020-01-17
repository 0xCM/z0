; 2020-01-16 19:14:09:598
; function: Span<uint> msand_32u(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
; static ReadOnlySpan<byte> msand_32uBytes => new byte[71]{0x57,0x56,0x0F,0x1F,0x00,0x48,0x8B,0x02,0x49,0x8B,0x10,0x4D,0x8B,0x01,0x45,0x8B,0x49,0x08,0x45,0x33,0xD2,0x45,0x85,0xC9,0x7E,0x20,0x4D,0x63,0xDA,0x4F,0x8D,0x1C,0x98,0x49,0x63,0xF2,0x8B,0x34,0xB0,0x49,0x63,0xFA,0x8B,0x3C,0xBA,0x23,0xF7,0x41,0x89,0x33,0x41,0xFF,0xC2,0x45,0x3B,0xD1,0x7C,0xE0,0x4C,0x89,0x01,0x44,0x89,0x49,0x08,0x48,0x8B,0xC1,0x5E,0x5F,0xC3};
0000h push rdi                                ; PUSH(Push_r64) [RDI]                       encoding(1 byte ) = 57
0001h push rsi                                ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0002h nop dword ptr [rax]                     ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(3 bytes) = 0f 1f 00
0005h mov rax,[rdx]                           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)] encoding(3 bytes) = 48 8b 02
0008h mov rdx,[r8]                            ; MOV(Mov_r64_rm64) [RDX,mem(64u,R8:br,:sr)] encoding(3 bytes) = 49 8b 10
000bh mov r8,[r9]                             ; MOV(Mov_r64_rm64) [R8,mem(64u,R9:br,:sr)]  encoding(3 bytes) = 4d 8b 01
000eh mov r9d,[r9+8]                          ; MOV(Mov_r32_rm32) [R9D,mem(32u,R9:br,:sr)] encoding(4 bytes) = 45 8b 49 08
0012h xor r10d,r10d                           ; XOR(Xor_r32_rm32) [R10D,R10D]              encoding(3 bytes) = 45 33 d2
0015h test r9d,r9d                            ; TEST(Test_rm32_r32) [R9D,R9D]              encoding(3 bytes) = 45 85 c9
0018h jle short 003ah                         ; JLE(Jle_rel8_64) [3Ah:jmp64]               encoding(2 bytes) = 7e 20
001ah movsxd r11,r10d                         ; MOVSXD(Movsxd_r64_rm32) [R11,R10D]         encoding(3 bytes) = 4d 63 da
001dh lea r11,[r8+r11*4]                      ; LEA(Lea_r64_m) [R11,mem(Unknown,R8:br,:sr)] encoding(4 bytes) = 4f 8d 1c 98
0021h movsxd rsi,r10d                         ; MOVSXD(Movsxd_r64_rm32) [RSI,R10D]         encoding(3 bytes) = 49 63 f2
0024h mov esi,[rax+rsi*4]                     ; MOV(Mov_r32_rm32) [ESI,mem(32u,RAX:br,:sr)] encoding(3 bytes) = 8b 34 b0
0027h movsxd rdi,r10d                         ; MOVSXD(Movsxd_r64_rm32) [RDI,R10D]         encoding(3 bytes) = 49 63 fa
002ah mov edi,[rdx+rdi*4]                     ; MOV(Mov_r32_rm32) [EDI,mem(32u,RDX:br,:sr)] encoding(3 bytes) = 8b 3c ba
002dh and esi,edi                             ; AND(And_r32_rm32) [ESI,EDI]                encoding(2 bytes) = 23 f7
002fh mov [r11],esi                           ; MOV(Mov_rm32_r32) [mem(32u,R11:br,:sr),ESI] encoding(3 bytes) = 41 89 33
0032h inc r10d                                ; INC(Inc_rm32) [R10D]                       encoding(3 bytes) = 41 ff c2
0035h cmp r10d,r9d                            ; CMP(Cmp_r32_rm32) [R10D,R9D]               encoding(3 bytes) = 45 3b d1
0038h jl short 001ah                          ; JL(Jl_rel8_64) [1Ah:jmp64]                 encoding(2 bytes) = 7c e0
003ah mov [rcx],r8                            ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),R8] encoding(3 bytes) = 4c 89 01
003dh mov [rcx+8],r9d                         ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),R9D] encoding(4 bytes) = 44 89 49 08
0041h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0044h pop rsi                                 ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
0045h pop rdi                                 ; POP(Pop_r64) [RDI]                         encoding(1 byte ) = 5f
0046h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
