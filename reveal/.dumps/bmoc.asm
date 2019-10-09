; 2019-10-09 00:23:42:641
; function: BitMatrix64 bm_from_natspan_64x64x64u(in Span<N64,ulong> src)
; location: [7FFDDBF4CD60h, 7FFDDBF4CDA5h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000ch mov [rsp+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 10
0011h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
0015h mov rbx,rcx                   ; MOV(Mov_r64_rm64) [RBX,RCX]                          encoding(3 bytes) = 48 8b d9
0018h vmovdqu xmm0,xmmword ptr [rdx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 02
001ch vmovdqu xmmword ptr [rsp],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 04 24
0021h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0026h vmovdqu xmmword ptr [rsp+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 10
002ch mov rdi,rbx                   ; MOV(Mov_r64_rm64) [RDI,RBX]                          encoding(3 bytes) = 48 8b fb
002fh lea rsi,[rsp+10h]             ; LEA(Lea_r64_m) [RSI,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 74 24 10
0034h call 7FFE3B3C3690h            ; CALL(Call_rel32_64) [5F476930h:jmp64]                encoding(5 bytes) = e8 f7 68 47 5f
0039h movsq                         ; MOVSQ(Movsq_m64_m64) [mem(64u),mem(64u,DS:sr)]       encoding(2 bytes) = 48 a5
003bh mov rax,rbx                   ; MOV(Mov_r64_rm64) [RAX,RBX]                          encoding(3 bytes) = 48 8b c3
003eh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0042h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0043h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0044h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bm_from_natspan_64x64x64uBytes => new byte[70]{0x57,0x56,0x53,0x48,0x83,0xEC,0x20,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x10,0x48,0x89,0x04,0x24,0x48,0x8B,0xD9,0xC5,0xFA,0x6F,0x02,0xC5,0xFA,0x7F,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x44,0x24,0x10,0x48,0x8B,0xFB,0x48,0x8D,0x74,0x24,0x10,0xE8,0xF7,0x68,0x47,0x5F,0x48,0xA5,0x48,0x8B,0xC3,0x48,0x83,0xC4,0x20,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
