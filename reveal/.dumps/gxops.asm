; 2020-01-15 03:58:00:290
; function: Span<uint> and_32u_span(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
; static ReadOnlySpan<byte> and_32u_spanBytes => new byte[68]{0x57,0x56,0x0F,0x1F,0x00,0x48,0x8B,0x02,0x49,0x8B,0x10,0x4D,0x8B,0x01,0x45,0x8B,0x49,0x08,0x45,0x33,0xD2,0x45,0x85,0xC9,0x7E,0x1D,0x4D,0x63,0xDA,0x4B,0x8D,0x34,0x98,0x42,0x8B,0x3C,0x98,0x46,0x8B,0x1C,0x9A,0x44,0x23,0xDF,0x44,0x89,0x1E,0x41,0xFF,0xC2,0x45,0x3B,0xD1,0x7C,0xE3,0x4C,0x89,0x01,0x44,0x89,0x49,0x08,0x48,0x8B,0xC1,0x5E,0x5F,0xC3};
0000h push rdi                                ; PUSH(Push_r64) [RDI]                       encoding(1 byte ) = 57
0001h push rsi                                ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0002h nop dword ptr [rax]                     ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(3 bytes) = 0f 1f 00
0005h mov rax,[rdx]                           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)] encoding(3 bytes) = 48 8b 02
0008h mov rdx,[r8]                            ; MOV(Mov_r64_rm64) [RDX,mem(64u,R8:br,:sr)] encoding(3 bytes) = 49 8b 10
000bh mov r8,[r9]                             ; MOV(Mov_r64_rm64) [R8,mem(64u,R9:br,:sr)]  encoding(3 bytes) = 4d 8b 01
000eh mov r9d,[r9+8]                          ; MOV(Mov_r32_rm32) [R9D,mem(32u,R9:br,:sr)] encoding(4 bytes) = 45 8b 49 08
0012h xor r10d,r10d                           ; XOR(Xor_r32_rm32) [R10D,R10D]              encoding(3 bytes) = 45 33 d2
0015h test r9d,r9d                            ; TEST(Test_rm32_r32) [R9D,R9D]              encoding(3 bytes) = 45 85 c9
0018h jle short 0037h                         ; JLE(Jle_rel8_64) [37h:jmp64]               encoding(2 bytes) = 7e 1d
001ah movsxd r11,r10d                         ; MOVSXD(Movsxd_r64_rm32) [R11,R10D]         encoding(3 bytes) = 4d 63 da
001dh lea rsi,[r8+r11*4]                      ; LEA(Lea_r64_m) [RSI,mem(Unknown,R8:br,:sr)] encoding(4 bytes) = 4b 8d 34 98
0021h mov edi,[rax+r11*4]                     ; MOV(Mov_r32_rm32) [EDI,mem(32u,RAX:br,:sr)] encoding(4 bytes) = 42 8b 3c 98
0025h mov r11d,[rdx+r11*4]                    ; MOV(Mov_r32_rm32) [R11D,mem(32u,RDX:br,:sr)] encoding(4 bytes) = 46 8b 1c 9a
0029h and r11d,edi                            ; AND(And_r32_rm32) [R11D,EDI]               encoding(3 bytes) = 44 23 df
002ch mov [rsi],r11d                          ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,:sr),R11D] encoding(3 bytes) = 44 89 1e
002fh inc r10d                                ; INC(Inc_rm32) [R10D]                       encoding(3 bytes) = 41 ff c2
0032h cmp r10d,r9d                            ; CMP(Cmp_r32_rm32) [R10D,R9D]               encoding(3 bytes) = 45 3b d1
0035h jl short 001ah                          ; JL(Jl_rel8_64) [1Ah:jmp64]                 encoding(2 bytes) = 7c e3
0037h mov [rcx],r8                            ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),R8] encoding(3 bytes) = 4c 89 01
003ah mov [rcx+8],r9d                         ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),R9D] encoding(4 bytes) = 44 89 49 08
003eh mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0041h pop rsi                                 ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
0042h pop rdi                                 ; POP(Pop_r64) [RDI]                         encoding(1 byte ) = 5f
0043h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<uint> nand_32u_span(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
; static ReadOnlySpan<byte> nand_32u_spanBytes => new byte[71]{0x57,0x56,0x0F,0x1F,0x00,0x48,0x8B,0x02,0x49,0x8B,0x10,0x4D,0x8B,0x01,0x45,0x8B,0x49,0x08,0x45,0x33,0xD2,0x45,0x85,0xC9,0x7E,0x20,0x4D,0x63,0xDA,0x4B,0x8D,0x34,0x98,0x42,0x8B,0x3C,0x98,0x46,0x8B,0x1C,0x9A,0x44,0x23,0xDF,0x41,0xF7,0xD3,0x44,0x89,0x1E,0x41,0xFF,0xC2,0x45,0x3B,0xD1,0x7C,0xE0,0x4C,0x89,0x01,0x44,0x89,0x49,0x08,0x48,0x8B,0xC1,0x5E,0x5F,0xC3};
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
001dh lea rsi,[r8+r11*4]                      ; LEA(Lea_r64_m) [RSI,mem(Unknown,R8:br,:sr)] encoding(4 bytes) = 4b 8d 34 98
0021h mov edi,[rax+r11*4]                     ; MOV(Mov_r32_rm32) [EDI,mem(32u,RAX:br,:sr)] encoding(4 bytes) = 42 8b 3c 98
0025h mov r11d,[rdx+r11*4]                    ; MOV(Mov_r32_rm32) [R11D,mem(32u,RDX:br,:sr)] encoding(4 bytes) = 46 8b 1c 9a
0029h and r11d,edi                            ; AND(And_r32_rm32) [R11D,EDI]               encoding(3 bytes) = 44 23 df
002ch not r11d                                ; NOT(Not_rm32) [R11D]                       encoding(3 bytes) = 41 f7 d3
002fh mov [rsi],r11d                          ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,:sr),R11D] encoding(3 bytes) = 44 89 1e
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
; function: Span<ulong> select_64u_span(ReadOnlySpan<ulong> a, ReadOnlySpan<ulong> b, ReadOnlySpan<ulong> c, Span<ulong> dst)
; static ReadOnlySpan<byte> select_64u_spanBytes => new byte[95]{0x57,0x56,0x55,0x53,0x48,0x8B,0x44,0x24,0x48,0x48,0x8B,0x12,0x4D,0x8B,0x00,0x4D,0x8B,0x09,0x4C,0x8B,0x10,0x8B,0x40,0x08,0x45,0x33,0xDB,0x85,0xC0,0x7E,0x32,0x49,0x63,0xF3,0x49,0x8D,0x34,0xF2,0x49,0x63,0xFB,0x48,0x8B,0x3C,0xFA,0x49,0x63,0xDB,0x49,0x8B,0x1C,0xD8,0x49,0x63,0xEB,0x49,0x8B,0x2C,0xE9,0x48,0x23,0xDF,0xC4,0xE2,0xC0,0xF2,0xFD,0x48,0x0B,0xFB,0x48,0x89,0x3E,0x41,0xFF,0xC3,0x44,0x3B,0xD8,0x7C,0xCE,0x4C,0x89,0x11,0x89,0x41,0x08,0x48,0x8B,0xC1,0x5B,0x5D,0x5E,0x5F,0xC3};
0000h push rdi                                ; PUSH(Push_r64) [RDI]                       encoding(1 byte ) = 57
0001h push rsi                                ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0002h push rbp                                ; PUSH(Push_r64) [RBP]                       encoding(1 byte ) = 55
0003h push rbx                                ; PUSH(Push_r64) [RBX]                       encoding(1 byte ) = 53
0004h mov rax,[rsp+48h]                       ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)] encoding(5 bytes) = 48 8b 44 24 48
0009h mov rdx,[rdx]                           ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)] encoding(3 bytes) = 48 8b 12
000ch mov r8,[r8]                             ; MOV(Mov_r64_rm64) [R8,mem(64u,R8:br,:sr)]  encoding(3 bytes) = 4d 8b 00
000fh mov r9,[r9]                             ; MOV(Mov_r64_rm64) [R9,mem(64u,R9:br,:sr)]  encoding(3 bytes) = 4d 8b 09
0012h mov r10,[rax]                           ; MOV(Mov_r64_rm64) [R10,mem(64u,RAX:br,:sr)] encoding(3 bytes) = 4c 8b 10
0015h mov eax,[rax+8]                         ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,:sr)] encoding(3 bytes) = 8b 40 08
0018h xor r11d,r11d                           ; XOR(Xor_r32_rm32) [R11D,R11D]              encoding(3 bytes) = 45 33 db
001bh test eax,eax                            ; TEST(Test_rm32_r32) [EAX,EAX]              encoding(2 bytes) = 85 c0
001dh jle short 0051h                         ; JLE(Jle_rel8_64) [51h:jmp64]               encoding(2 bytes) = 7e 32
001fh movsxd rsi,r11d                         ; MOVSXD(Movsxd_r64_rm32) [RSI,R11D]         encoding(3 bytes) = 49 63 f3
0022h lea rsi,[r10+rsi*8]                     ; LEA(Lea_r64_m) [RSI,mem(Unknown,R10:br,:sr)] encoding(4 bytes) = 49 8d 34 f2
0026h movsxd rdi,r11d                         ; MOVSXD(Movsxd_r64_rm32) [RDI,R11D]         encoding(3 bytes) = 49 63 fb
0029h mov rdi,[rdx+rdi*8]                     ; MOV(Mov_r64_rm64) [RDI,mem(64u,RDX:br,:sr)] encoding(4 bytes) = 48 8b 3c fa
002dh movsxd rbx,r11d                         ; MOVSXD(Movsxd_r64_rm32) [RBX,R11D]         encoding(3 bytes) = 49 63 db
0030h mov rbx,[r8+rbx*8]                      ; MOV(Mov_r64_rm64) [RBX,mem(64u,R8:br,:sr)] encoding(4 bytes) = 49 8b 1c d8
0034h movsxd rbp,r11d                         ; MOVSXD(Movsxd_r64_rm32) [RBP,R11D]         encoding(3 bytes) = 49 63 eb
0037h mov rbp,[r9+rbp*8]                      ; MOV(Mov_r64_rm64) [RBP,mem(64u,R9:br,:sr)] encoding(4 bytes) = 49 8b 2c e9
003bh and rbx,rdi                             ; AND(And_r64_rm64) [RBX,RDI]                encoding(3 bytes) = 48 23 df
003eh andn rdi,rdi,rbp                        ; ANDN(VEX_Andn_r64_r64_rm64) [RDI,RDI,RBP]  encoding(VEX, 5 bytes) = c4 e2 c0 f2 fd
0043h or rdi,rbx                              ; OR(Or_r64_rm64) [RDI,RBX]                  encoding(3 bytes) = 48 0b fb
0046h mov [rsi],rdi                           ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,:sr),RDI] encoding(3 bytes) = 48 89 3e
0049h inc r11d                                ; INC(Inc_rm32) [R11D]                       encoding(3 bytes) = 41 ff c3
004ch cmp r11d,eax                            ; CMP(Cmp_r32_rm32) [R11D,EAX]               encoding(3 bytes) = 44 3b d8
004fh jl short 001fh                          ; JL(Jl_rel8_64) [1Fh:jmp64]                 encoding(2 bytes) = 7c ce
0051h mov [rcx],r10                           ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),R10] encoding(3 bytes) = 4c 89 11
0054h mov [rcx+8],eax                         ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EAX] encoding(3 bytes) = 89 41 08
0057h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
005ah pop rbx                                 ; POP(Pop_r64) [RBX]                         encoding(1 byte ) = 5b
005bh pop rbp                                 ; POP(Pop_r64) [RBP]                         encoding(1 byte ) = 5d
005ch pop rsi                                 ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
005dh pop rdi                                 ; POP(Pop_r64) [RDI]                         encoding(1 byte ) = 5f
005eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint bl_and32(uint a, uint b)
; static ReadOnlySpan<byte> bl_and32Bytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                             ; AND(And_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 23 d1
0007h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint logic_machine(uint a, uint b)
; static ReadOnlySpan<byte> logic_machineBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xCA,0x33,0xD1,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h and ecx,edx                             ; AND(And_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 23 ca
0007h xor edx,ecx                             ; XOR(Xor_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 33 d1
0009h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> vlogic_machine(Vector128<uint> a, Vector128<uint> b)
; static ReadOnlySpan<byte> vlogic_machineBytes => new byte[34]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF8,0x28,0xD1,0xC5,0xF9,0xDB,0xC2,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]                      ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]                       ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vmovaps xmm2,xmm1                       ; VMOVAPS(VEX_Vmovaps_xmm_xmmm128) [XMM2,XMM1] encoding(VEX, 4 bytes) = c5 f8 28 d1
0012h vpand xmm0,xmm0,xmm2                    ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM2] encoding(VEX, 4 bytes) = c5 f9 db c2
0016h vpxor xmm0,xmm0,xmm1                    ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 ef c1
001ah vmovupd [rcx],xmm0                      ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
001eh mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0021h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_d16u(ushort a, ushort b)
; static ReadOnlySpan<byte> eq_d16uBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
000dh sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0010h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0013h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_g16u(ushort a, ushort b)
; static ReadOnlySpan<byte> eq_g16uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
000eh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
0010h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0016h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit eq_o16u(ushort a, ushort b)
; static ReadOnlySpan<byte> eq_o16uBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x3B,0xC2,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                            ; MOVZX(Movzx_r32_rm16) [EAX,CX]             encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                            ; MOVZX(Movzx_r32_rm16) [EDX,DX]             encoding(3 bytes) = 0f b7 d2
000bh movzx eax,ax                            ; MOVZX(Movzx_r32_rm16) [EAX,AX]             encoding(3 bytes) = 0f b7 c0
000eh cmp eax,edx                             ; CMP(Cmp_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 3b c2
0010h sete al                                 ; SETE(Sete_rm8) [AL]                        encoding(3 bytes) = 0f 94 c0
0013h movzx eax,al                            ; MOVZX(Movzx_r32_rm8) [EAX,AL]              encoding(3 bytes) = 0f b6 c0
0016h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: string eq_moniker()
; static ReadOnlySpan<byte> eq_monikerBytes => new byte[47]{0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x28,0xC6,0x44,0x24,0x28,0x00,0x48,0x0F,0xBE,0x4C,0x24,0x28,0x88,0x4C,0x24,0x30,0x48,0x8D,0x4C,0x24,0x30,0xE8,0x0F,0xFA,0xFF,0xFF,0x90,0x48,0x83,0xC4,0x38,0xC3};
0000h sub rsp,38h                             ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]         encoding(4 bytes) = 48 83 ec 38
0004h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0006h mov [rsp+30h],rax                       ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(5 bytes) = 48 89 44 24 30
000bh mov [rsp+28h],rax                       ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(5 bytes) = 48 89 44 24 28
0010h mov byte ptr [rsp+28h],0                ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,:sr),0h:imm8] encoding(5 bytes) = c6 44 24 28 00
0015h movsx rcx,byte ptr [rsp+28h]            ; MOVSX(Movsx_r64_rm8) [RCX,mem(8i,RSP:br,:sr)] encoding(6 bytes) = 48 0f be 4c 24 28
001bh mov [rsp+30h],cl                        ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,:sr),CL]    encoding(4 bytes) = 88 4c 24 30
001fh lea rcx,[rsp+30h]                       ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 4c 24 30
0024h call 7FF7C85A6A08h                      ; CALL(Call_rel32_64) [FFFFFFFFFFFFFA38h:jmp64] encoding(5 bytes) = e8 0f fa ff ff
0029h nop                                     ; NOP(Nopd)                                  encoding(1 byte ) = 90
002ah add rsp,38h                             ; ADD(Add_rm64_imm8) [RSP,38h:imm64]         encoding(4 bytes) = 48 83 c4 38
002eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: string the_name()
; static ReadOnlySpan<byte> the_nameBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x28,0xA2,0x01,0x90,0x49,0x02,0x00,0x00,0x48,0x8B,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,2499001A228h                    ; MOV(Mov_r64_imm64) [RAX,2499001a228h:imm64] encoding(10 bytes) = 48 b8 28 a2 01 90 49 02 00 00
000fh mov rax,[rax]                           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)] encoding(3 bytes) = 48 8b 00
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
