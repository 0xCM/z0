; 2019-12-23 21:08:18:913
; function: void deposit(in ulong src, ref Fixed128 dst)
; location: [7FF7C7E40B70h, 7FF7C7E40B7Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovdqu xmm0,xmmword ptr [rcx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> depositBytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x6F,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void deposit_4_0(in uint src, ref Fixed128 dst)
; location: [7FF7C7E40B90h, 7FF7C7E40B9Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovdqu xmm0,xmmword ptr [rcx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 01
0009h vmovdqu xmmword ptr [rdx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 02
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> deposit_4_0Bytes => new byte[14]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x6F,0x01,0xC5,0xFA,0x7F,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void deposit_2_2(in uint src, ref Fixed128 dst)
; location: [7FF7C7E40BB0h, 7FF7C7E40BBFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
0009h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
000ch mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> deposit_2_2Bytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x83,0xC2,0x08,0x48,0x8B,0x01,0x48,0x89,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> bc_bytes_16u(ushort a)
; location: [7FF7C7E40FE0h, 7FF7C7E4101Fh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov [rsp+38h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EDX]          encoding(4 bytes) = 89 54 24 38
0009h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000ch mov rcx,7FF7C770EA10h         ; MOV(Mov_r64_imm64) [RCX,7ff7c770ea10h:imm64]         encoding(10 bytes) = 48 b9 10 ea 70 c7 f7 7f 00 00
0016h mov edx,2                     ; MOV(Mov_r32_imm32) [EDX,2h:imm32]                    encoding(5 bytes) = ba 02 00 00 00
001bh call 7FF827266DE0h            ; CALL(Call_rel32_64) [5F425E00h:jmp64]                encoding(5 bytes) = e8 e0 5d 42 5f
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
; static ReadOnlySpan<byte> bc_bytes_16uBytes => new byte[64]{0x56,0x48,0x83,0xEC,0x20,0x89,0x54,0x24,0x38,0x48,0x8B,0xF1,0x48,0xB9,0x10,0xEA,0x70,0xC7,0xF7,0x7F,0x00,0x00,0xBA,0x02,0x00,0x00,0x00,0xE8,0xE0,0x5D,0x42,0x5F,0x48,0x83,0xC0,0x10,0xBA,0x02,0x00,0x00,0x00,0x0F,0xB7,0x4C,0x24,0x38,0x66,0x89,0x08,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> bc_bytes_64u(ulong a)
; location: [7FF7C7E41040h, 7FF7C7E4107Bh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0009h mov rdi,rdx                   ; MOV(Mov_r64_rm64) [RDI,RDX]                          encoding(3 bytes) = 48 8b fa
000ch mov rcx,7FF7C770EA10h         ; MOV(Mov_r64_imm64) [RCX,7ff7c770ea10h:imm64]         encoding(10 bytes) = 48 b9 10 ea 70 c7 f7 7f 00 00
0016h mov edx,8                     ; MOV(Mov_r32_imm32) [EDX,8h:imm32]                    encoding(5 bytes) = ba 08 00 00 00
001bh call 7FF827266DE0h            ; CALL(Call_rel32_64) [5F425DA0h:jmp64]                encoding(5 bytes) = e8 80 5d 42 5f
0020h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
0024h mov edx,8                     ; MOV(Mov_r32_imm32) [EDX,8h:imm32]                    encoding(5 bytes) = ba 08 00 00 00
0029h mov [rax],rdi                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDI]          encoding(3 bytes) = 48 89 38
002ch mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,:sr),RAX]          encoding(3 bytes) = 48 89 06
002fh mov [rsi+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,:sr),EDX]          encoding(3 bytes) = 89 56 08
0032h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0035h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0039h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
003ah pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
003bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bc_bytes_64uBytes => new byte[60]{0x57,0x56,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF1,0x48,0x8B,0xFA,0x48,0xB9,0x10,0xEA,0x70,0xC7,0xF7,0x7F,0x00,0x00,0xBA,0x08,0x00,0x00,0x00,0xE8,0x80,0x5D,0x42,0x5F,0x48,0x83,0xC0,0x10,0xBA,0x08,0x00,0x00,0x00,0x48,0x89,0x38,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> bc_bytes_fixed256(Fixed256 a)
; location: [7FF7C7E410A0h, 7FF7C7E410EDh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0009h mov rdi,rcx                   ; MOV(Mov_r64_rm64) [RDI,RCX]                          encoding(3 bytes) = 48 8b f9
000ch mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
000fh mov rcx,7FF7C770EA10h         ; MOV(Mov_r64_imm64) [RCX,7ff7c770ea10h:imm64]         encoding(10 bytes) = 48 b9 10 ea 70 c7 f7 7f 00 00
0019h mov edx,20h                   ; MOV(Mov_r32_imm32) [EDX,20h:imm32]                   encoding(5 bytes) = ba 20 00 00 00
001eh call 7FF827266DE0h            ; CALL(Call_rel32_64) [5F425D40h:jmp64]                encoding(5 bytes) = e8 1d 5d 42 5f
0023h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
0027h mov edx,20h                   ; MOV(Mov_r32_imm32) [EDX,20h:imm32]                   encoding(5 bytes) = ba 20 00 00 00
002ch vmovdqu xmm0,xmmword ptr [rsi]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSI:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 06
0030h vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
0034h vmovdqu xmm0,xmmword ptr [rsi+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSI:br,:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 46 10
0039h vmovdqu xmmword ptr [rax+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 40 10
003eh mov [rdi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDI:br,:sr),RAX]          encoding(3 bytes) = 48 89 07
0041h mov [rdi+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RDI:br,:sr),EDX]          encoding(3 bytes) = 89 57 08
0044h mov rax,rdi                   ; MOV(Mov_r64_rm64) [RAX,RDI]                          encoding(3 bytes) = 48 8b c7
0047h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
004bh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
004ch pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
004dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bc_bytes_fixed256Bytes => new byte[78]{0x57,0x56,0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0x48,0xB9,0x10,0xEA,0x70,0xC7,0xF7,0x7F,0x00,0x00,0xBA,0x20,0x00,0x00,0x00,0xE8,0x1D,0x5D,0x42,0x5F,0x48,0x83,0xC0,0x10,0xBA,0x20,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x06,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x6F,0x46,0x10,0xC5,0xFA,0x7F,0x40,0x10,0x48,0x89,0x07,0x89,0x57,0x08,0x48,0x8B,0xC7,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> bc_bytes_fixed512(Fixed512 a)
; location: [7FF7C7E41110h, 7FF7C7E41171h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0009h mov rdi,rcx                   ; MOV(Mov_r64_rm64) [RDI,RCX]                          encoding(3 bytes) = 48 8b f9
000ch mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
000fh mov rcx,7FF7C770EA10h         ; MOV(Mov_r64_imm64) [RCX,7ff7c770ea10h:imm64]         encoding(10 bytes) = 48 b9 10 ea 70 c7 f7 7f 00 00
0019h mov edx,40h                   ; MOV(Mov_r32_imm32) [EDX,40h:imm32]                   encoding(5 bytes) = ba 40 00 00 00
001eh call 7FF827266DE0h            ; CALL(Call_rel32_64) [5F425CD0h:jmp64]                encoding(5 bytes) = e8 ad 5c 42 5f
0023h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
0027h mov edx,40h                   ; MOV(Mov_r32_imm32) [EDX,40h:imm32]                   encoding(5 bytes) = ba 40 00 00 00
002ch vmovdqu xmm0,xmmword ptr [rsi]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSI:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 06
0030h vmovdqu xmmword ptr [rax],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 00
0034h vmovdqu xmm0,xmmword ptr [rsi+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSI:br,:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 46 10
0039h vmovdqu xmmword ptr [rax+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 40 10
003eh vmovdqu xmm0,xmmword ptr [rsi+20h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSI:br,:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 46 20
0043h vmovdqu xmmword ptr [rax+20h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 40 20
0048h vmovdqu xmm0,xmmword ptr [rsi+30h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSI:br,:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 46 30
004dh vmovdqu xmmword ptr [rax+30h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RAX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 40 30
0052h mov [rdi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDI:br,:sr),RAX]          encoding(3 bytes) = 48 89 07
0055h mov [rdi+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RDI:br,:sr),EDX]          encoding(3 bytes) = 89 57 08
0058h mov rax,rdi                   ; MOV(Mov_r64_rm64) [RAX,RDI]                          encoding(3 bytes) = 48 8b c7
005bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
005fh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0060h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0061h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bc_bytes_fixed512Bytes => new byte[98]{0x57,0x56,0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0x48,0xB9,0x10,0xEA,0x70,0xC7,0xF7,0x7F,0x00,0x00,0xBA,0x40,0x00,0x00,0x00,0xE8,0xAD,0x5C,0x42,0x5F,0x48,0x83,0xC0,0x10,0xBA,0x40,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x06,0xC5,0xFA,0x7F,0x00,0xC5,0xFA,0x6F,0x46,0x10,0xC5,0xFA,0x7F,0x40,0x10,0xC5,0xFA,0x6F,0x46,0x20,0xC5,0xFA,0x7F,0x40,0x20,0xC5,0xFA,0x6F,0x46,0x30,0xC5,0xFA,0x7F,0x40,0x30,0x48,0x89,0x07,0x89,0x57,0x08,0x48,0x8B,0xC7,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> bc_bytes_fixed1024(Fixed1024 a)
; location: [7FF7C7E411A0h, 7FF7C7E411F0h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0003h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0004h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0008h mov rdi,rcx                   ; MOV(Mov_r64_rm64) [RDI,RCX]                          encoding(3 bytes) = 48 8b f9
000bh mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
000eh mov rcx,7FF7C770EA10h         ; MOV(Mov_r64_imm64) [RCX,7ff7c770ea10h:imm64]         encoding(10 bytes) = 48 b9 10 ea 70 c7 f7 7f 00 00
0018h mov edx,80h                   ; MOV(Mov_r32_imm32) [EDX,80h:imm32]                   encoding(5 bytes) = ba 80 00 00 00
001dh call 7FF827266DE0h            ; CALL(Call_rel32_64) [5F425C40h:jmp64]                encoding(5 bytes) = e8 1e 5c 42 5f
0022h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
0026h mov rbx,rax                   ; MOV(Mov_r64_rm64) [RBX,RAX]                          encoding(3 bytes) = 48 8b d8
0029h mov ebp,80h                   ; MOV(Mov_r32_imm32) [EBP,80h:imm32]                   encoding(5 bytes) = bd 80 00 00 00
002eh mov rcx,rbx                   ; MOV(Mov_r64_rm64) [RCX,RBX]                          encoding(3 bytes) = 48 8b cb
0031h mov rdx,rsi                   ; MOV(Mov_r64_rm64) [RDX,RSI]                          encoding(3 bytes) = 48 8b d6
0034h mov r8d,80h                   ; MOV(Mov_r32_imm32) [R8D,80h:imm32]                   encoding(6 bytes) = 41 b8 80 00 00 00
003ah call 7FF827266050h            ; CALL(Call_rel32_64) [5F424EB0h:jmp64]                encoding(5 bytes) = e8 71 4e 42 5f
003fh mov [rdi],rbx                 ; MOV(Mov_rm64_r64) [mem(64u,RDI:br,:sr),RBX]          encoding(3 bytes) = 48 89 1f
0042h mov [rdi+8],ebp               ; MOV(Mov_rm32_r32) [mem(32u,RDI:br,:sr),EBP]          encoding(3 bytes) = 89 6f 08
0045h mov rax,rdi                   ; MOV(Mov_r64_rm64) [RAX,RDI]                          encoding(3 bytes) = 48 8b c7
0048h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
004ch pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
004dh pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
004eh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
004fh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0050h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bc_bytes_fixed1024Bytes => new byte[81]{0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0x48,0xB9,0x10,0xEA,0x70,0xC7,0xF7,0x7F,0x00,0x00,0xBA,0x80,0x00,0x00,0x00,0xE8,0x1E,0x5C,0x42,0x5F,0x48,0x83,0xC0,0x10,0x48,0x8B,0xD8,0xBD,0x80,0x00,0x00,0x00,0x48,0x8B,0xCB,0x48,0x8B,0xD6,0x41,0xB8,0x80,0x00,0x00,0x00,0xE8,0x71,0x4E,0x42,0x5F,0x48,0x89,0x1F,0x89,0x6F,0x08,0x48,0x8B,0xC7,0x48,0x83,0xC4,0x28,0x5B,0x5D,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> bc_bytes_fixed2048(Fixed2048 a)
; location: [7FF7C7E41210h, 7FF7C7E41260h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0003h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0004h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0008h mov rdi,rcx                   ; MOV(Mov_r64_rm64) [RDI,RCX]                          encoding(3 bytes) = 48 8b f9
000bh mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
000eh mov rcx,7FF7C770EA10h         ; MOV(Mov_r64_imm64) [RCX,7ff7c770ea10h:imm64]         encoding(10 bytes) = 48 b9 10 ea 70 c7 f7 7f 00 00
0018h mov edx,100h                  ; MOV(Mov_r32_imm32) [EDX,100h:imm32]                  encoding(5 bytes) = ba 00 01 00 00
001dh call 7FF827266DE0h            ; CALL(Call_rel32_64) [5F425BD0h:jmp64]                encoding(5 bytes) = e8 ae 5b 42 5f
0022h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
0026h mov rbx,rax                   ; MOV(Mov_r64_rm64) [RBX,RAX]                          encoding(3 bytes) = 48 8b d8
0029h mov ebp,100h                  ; MOV(Mov_r32_imm32) [EBP,100h:imm32]                  encoding(5 bytes) = bd 00 01 00 00
002eh mov rcx,rbx                   ; MOV(Mov_r64_rm64) [RCX,RBX]                          encoding(3 bytes) = 48 8b cb
0031h mov rdx,rsi                   ; MOV(Mov_r64_rm64) [RDX,RSI]                          encoding(3 bytes) = 48 8b d6
0034h mov r8d,100h                  ; MOV(Mov_r32_imm32) [R8D,100h:imm32]                  encoding(6 bytes) = 41 b8 00 01 00 00
003ah call 7FF827266050h            ; CALL(Call_rel32_64) [5F424E40h:jmp64]                encoding(5 bytes) = e8 01 4e 42 5f
003fh mov [rdi],rbx                 ; MOV(Mov_rm64_r64) [mem(64u,RDI:br,:sr),RBX]          encoding(3 bytes) = 48 89 1f
0042h mov [rdi+8],ebp               ; MOV(Mov_rm32_r32) [mem(32u,RDI:br,:sr),EBP]          encoding(3 bytes) = 89 6f 08
0045h mov rax,rdi                   ; MOV(Mov_r64_rm64) [RAX,RDI]                          encoding(3 bytes) = 48 8b c7
0048h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
004ch pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
004dh pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
004eh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
004fh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0050h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bc_bytes_fixed2048Bytes => new byte[81]{0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0x48,0xB9,0x10,0xEA,0x70,0xC7,0xF7,0x7F,0x00,0x00,0xBA,0x00,0x01,0x00,0x00,0xE8,0xAE,0x5B,0x42,0x5F,0x48,0x83,0xC0,0x10,0x48,0x8B,0xD8,0xBD,0x00,0x01,0x00,0x00,0x48,0x8B,0xCB,0x48,0x8B,0xD6,0x41,0xB8,0x00,0x01,0x00,0x00,0xE8,0x01,0x4E,0x42,0x5F,0x48,0x89,0x1F,0x89,0x6F,0x08,0x48,0x8B,0xC7,0x48,0x83,0xC4,0x28,0x5B,0x5D,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> bc_bytes_fixed4096(Fixed4096 a)
; location: [7FF7C7E41280h, 7FF7C7E412D0h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0003h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0004h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0008h mov rdi,rcx                   ; MOV(Mov_r64_rm64) [RDI,RCX]                          encoding(3 bytes) = 48 8b f9
000bh mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
000eh mov rcx,7FF7C770EA10h         ; MOV(Mov_r64_imm64) [RCX,7ff7c770ea10h:imm64]         encoding(10 bytes) = 48 b9 10 ea 70 c7 f7 7f 00 00
0018h mov edx,200h                  ; MOV(Mov_r32_imm32) [EDX,200h:imm32]                  encoding(5 bytes) = ba 00 02 00 00
001dh call 7FF827266DE0h            ; CALL(Call_rel32_64) [5F425B60h:jmp64]                encoding(5 bytes) = e8 3e 5b 42 5f
0022h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
0026h mov rbx,rax                   ; MOV(Mov_r64_rm64) [RBX,RAX]                          encoding(3 bytes) = 48 8b d8
0029h mov ebp,200h                  ; MOV(Mov_r32_imm32) [EBP,200h:imm32]                  encoding(5 bytes) = bd 00 02 00 00
002eh mov rcx,rbx                   ; MOV(Mov_r64_rm64) [RCX,RBX]                          encoding(3 bytes) = 48 8b cb
0031h mov rdx,rsi                   ; MOV(Mov_r64_rm64) [RDX,RSI]                          encoding(3 bytes) = 48 8b d6
0034h mov r8d,200h                  ; MOV(Mov_r32_imm32) [R8D,200h:imm32]                  encoding(6 bytes) = 41 b8 00 02 00 00
003ah call 7FF827266050h            ; CALL(Call_rel32_64) [5F424DD0h:jmp64]                encoding(5 bytes) = e8 91 4d 42 5f
003fh mov [rdi],rbx                 ; MOV(Mov_rm64_r64) [mem(64u,RDI:br,:sr),RBX]          encoding(3 bytes) = 48 89 1f
0042h mov [rdi+8],ebp               ; MOV(Mov_rm32_r32) [mem(32u,RDI:br,:sr),EBP]          encoding(3 bytes) = 89 6f 08
0045h mov rax,rdi                   ; MOV(Mov_r64_rm64) [RAX,RDI]                          encoding(3 bytes) = 48 8b c7
0048h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
004ch pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
004dh pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
004eh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
004fh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0050h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bc_bytes_fixed4096Bytes => new byte[81]{0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0x48,0xB9,0x10,0xEA,0x70,0xC7,0xF7,0x7F,0x00,0x00,0xBA,0x00,0x02,0x00,0x00,0xE8,0x3E,0x5B,0x42,0x5F,0x48,0x83,0xC0,0x10,0x48,0x8B,0xD8,0xBD,0x00,0x02,0x00,0x00,0x48,0x8B,0xCB,0x48,0x8B,0xD6,0x41,0xB8,0x00,0x02,0x00,0x00,0xE8,0x91,0x4D,0x42,0x5F,0x48,0x89,0x1F,0x89,0x6F,0x08,0x48,0x8B,0xC7,0x48,0x83,0xC4,0x28,0x5B,0x5D,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
