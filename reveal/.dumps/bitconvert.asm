; 2019-12-11 14:36:58:365
; function: void deposit(in ulong src, ref Fixed128 dst)
; location: [7FFDD8E5AB00h, 7FFDD8E5AB0Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovdqu xmm0,xmmword ptr [rcx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> depositBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x6F,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void deposit_4_0(in uint src, ref Fixed128 dst)
; location: [7FFDD8E5AB20h, 7FFDD8E5AB2Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovdqu xmm0,xmmword ptr [rcx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> deposit_4_0Bytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x6F,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void deposit_2_2(in uint src, ref Fixed128 dst)
; location: [7FFDD8E5AB40h, 7FFDD8E5AB4Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
0009h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
000ch mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> deposit_2_2Bytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x83,0xC2,0x08,0x48,0x8B,0x01,0x48,0x89,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> bc_bytes_16u(ushort a)
; location: [7FFDD8E5AB60h, 7FFDD8E5AB9Fh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov [rsp+38h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EDX]          encoding(4 bytes) = 89 54 24 38
0009h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000ch mov rcx,7FFDD873EA10h         ; MOV(Mov_r64_imm64) [RCX,7ffdd873ea10h:imm64]         encoding(10 bytes) = 48 b9 10 ea 73 d8 fd 7f 00 00
0016h mov edx,2                     ; MOV(Mov_r32_imm32) [EDX,2h:imm32]                    encoding(5 bytes) = ba 02 00 00 00
001bh call 7FFE382945E0h            ; CALL(Call_rel32_64) [5F439A80h:jmp64]                encoding(5 bytes) = e8 60 9a 43 5f
0020h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
0024h mov edx,2                     ; MOV(Mov_r32_imm32) [EDX,2h:imm32]                    encoding(5 bytes) = ba 02 00 00 00
0029h movzx ecx,word ptr [rsp+38h]  ; MOVZX(Movzx_r32_rm16) [ECX,mem(16u,RSP:br,:sr)]      encoding(5 bytes) = 0f b7 4c 24 38
002eh mov [rax],cx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,:sr),CX]           encoding(3 bytes) = 66 89 08
0031h mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,:sr),RAX]          encoding(3 bytes) = 48 89 06
0034h mov [rsi+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,:sr),EDX]          encoding(3 bytes) = 89 56 08
0037h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
003ah add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
003eh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
003fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bc_bytes_16uBytes => new byte[64]{0x56,0x48,0x83,0xEC,0x20,0x89,0x54,0x24,0x38,0x48,0x8B,0xF1,0x48,0xB9,0x10,0xEA,0x73,0xD8,0xFD,0x7F,0x00,0x00,0xBA,0x02,0x00,0x00,0x00,0xE8,0x60,0x9A,0x43,0x5F,0x48,0x83,0xC0,0x10,0xBA,0x02,0x00,0x00,0x00,0x0F,0xB7,0x4C,0x24,0x38,0x66,0x89,0x08,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> bc_bytes_fixed1024(Fixed1024 a)
; location: [7FFDD8E5AD20h, 7FFDD8E5AD70h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0003h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0004h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0008h mov rdi,rcx                   ; MOV(Mov_r64_rm64) [RDI,RCX]                          encoding(3 bytes) = 48 8b f9
000bh mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
000eh mov rcx,7FFDD873EA10h         ; MOV(Mov_r64_imm64) [RCX,7ffdd873ea10h:imm64]         encoding(10 bytes) = 48 b9 10 ea 73 d8 fd 7f 00 00
0018h mov edx,80h                   ; MOV(Mov_r32_imm32) [EDX,80h:imm32]                   encoding(5 bytes) = ba 80 00 00 00
001dh call 7FFE382945E0h            ; CALL(Call_rel32_64) [5F4398C0h:jmp64]                encoding(5 bytes) = e8 9e 98 43 5f
0022h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
0026h mov rbx,rax                   ; MOV(Mov_r64_rm64) [RBX,RAX]                          encoding(3 bytes) = 48 8b d8
0029h mov ebp,80h                   ; MOV(Mov_r32_imm32) [EBP,80h:imm32]                   encoding(5 bytes) = bd 80 00 00 00
002eh mov rcx,rbx                   ; MOV(Mov_r64_rm64) [RCX,RBX]                          encoding(3 bytes) = 48 8b cb
0031h mov rdx,rsi                   ; MOV(Mov_r64_rm64) [RDX,RSI]                          encoding(3 bytes) = 48 8b d6
0034h mov r8d,80h                   ; MOV(Mov_r32_imm32) [R8D,80h:imm32]                   encoding(6 bytes) = 41 b8 80 00 00 00
003ah call 7FFE38293850h            ; CALL(Call_rel32_64) [5F438B30h:jmp64]                encoding(5 bytes) = e8 f1 8a 43 5f
003fh mov [rdi],rbx                 ; MOV(Mov_rm64_r64) [mem(64u,RDI:br,:sr),RBX]          encoding(3 bytes) = 48 89 1f
0042h mov [rdi+8],ebp               ; MOV(Mov_rm32_r32) [mem(32u,RDI:br,:sr),EBP]          encoding(3 bytes) = 89 6f 08
0045h mov rax,rdi                   ; MOV(Mov_r64_rm64) [RAX,RDI]                          encoding(3 bytes) = 48 8b c7
0048h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
004ch pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
004dh pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
004eh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
004fh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0050h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bc_bytes_fixed1024Bytes => new byte[81]{0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0x48,0xB9,0x10,0xEA,0x73,0xD8,0xFD,0x7F,0x00,0x00,0xBA,0x80,0x00,0x00,0x00,0xE8,0x9E,0x98,0x43,0x5F,0x48,0x83,0xC0,0x10,0x48,0x8B,0xD8,0xBD,0x80,0x00,0x00,0x00,0x48,0x8B,0xCB,0x48,0x8B,0xD6,0x41,0xB8,0x80,0x00,0x00,0x00,0xE8,0xF1,0x8A,0x43,0x5F,0x48,0x89,0x1F,0x89,0x6F,0x08,0x48,0x8B,0xC7,0x48,0x83,0xC4,0x28,0x5B,0x5D,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> bc_bytes_fixed2048(Fixed2048 a)
; location: [7FFDD8E5AD90h, 7FFDD8E5ADE0h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0003h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0004h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0008h mov rdi,rcx                   ; MOV(Mov_r64_rm64) [RDI,RCX]                          encoding(3 bytes) = 48 8b f9
000bh mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
000eh mov rcx,7FFDD873EA10h         ; MOV(Mov_r64_imm64) [RCX,7ffdd873ea10h:imm64]         encoding(10 bytes) = 48 b9 10 ea 73 d8 fd 7f 00 00
0018h mov edx,100h                  ; MOV(Mov_r32_imm32) [EDX,100h:imm32]                  encoding(5 bytes) = ba 00 01 00 00
001dh call 7FFE382945E0h            ; CALL(Call_rel32_64) [5F439850h:jmp64]                encoding(5 bytes) = e8 2e 98 43 5f
0022h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
0026h mov rbx,rax                   ; MOV(Mov_r64_rm64) [RBX,RAX]                          encoding(3 bytes) = 48 8b d8
0029h mov ebp,100h                  ; MOV(Mov_r32_imm32) [EBP,100h:imm32]                  encoding(5 bytes) = bd 00 01 00 00
002eh mov rcx,rbx                   ; MOV(Mov_r64_rm64) [RCX,RBX]                          encoding(3 bytes) = 48 8b cb
0031h mov rdx,rsi                   ; MOV(Mov_r64_rm64) [RDX,RSI]                          encoding(3 bytes) = 48 8b d6
0034h mov r8d,100h                  ; MOV(Mov_r32_imm32) [R8D,100h:imm32]                  encoding(6 bytes) = 41 b8 00 01 00 00
003ah call 7FFE38293850h            ; CALL(Call_rel32_64) [5F438AC0h:jmp64]                encoding(5 bytes) = e8 81 8a 43 5f
003fh mov [rdi],rbx                 ; MOV(Mov_rm64_r64) [mem(64u,RDI:br,:sr),RBX]          encoding(3 bytes) = 48 89 1f
0042h mov [rdi+8],ebp               ; MOV(Mov_rm32_r32) [mem(32u,RDI:br,:sr),EBP]          encoding(3 bytes) = 89 6f 08
0045h mov rax,rdi                   ; MOV(Mov_r64_rm64) [RAX,RDI]                          encoding(3 bytes) = 48 8b c7
0048h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
004ch pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
004dh pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
004eh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
004fh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0050h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bc_bytes_fixed2048Bytes => new byte[81]{0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0x48,0xB9,0x10,0xEA,0x73,0xD8,0xFD,0x7F,0x00,0x00,0xBA,0x00,0x01,0x00,0x00,0xE8,0x2E,0x98,0x43,0x5F,0x48,0x83,0xC0,0x10,0x48,0x8B,0xD8,0xBD,0x00,0x01,0x00,0x00,0x48,0x8B,0xCB,0x48,0x8B,0xD6,0x41,0xB8,0x00,0x01,0x00,0x00,0xE8,0x81,0x8A,0x43,0x5F,0x48,0x89,0x1F,0x89,0x6F,0x08,0x48,0x8B,0xC7,0x48,0x83,0xC4,0x28,0x5B,0x5D,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> bc_bytes_fixed4096(Fixed4096 a)
; location: [7FFE28E4D1D0h, 7FFE28E4D1E0h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h call qword ptr [7FFE28A6F6C8h]; CALL(Call_rm64) [mem(QwordOffset,RIP:br,:sr)]        encoding(6 bytes) = ff 15 ed 24 c2 ff
000bh nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000ch add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bc_bytes_fixed4096Bytes => new byte[17]{0x48,0x83,0xEC,0x28,0x90,0xFF,0x15,0xED,0x24,0xC2,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
