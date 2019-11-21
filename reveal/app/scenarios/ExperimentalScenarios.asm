; 2019-11-21 12:21:37:955
; function: Span<byte> GetBytes(in int src)
; location: [7FFDD983E9C0h, 7FFDD983E9D2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
0008h mov dword ptr [rdx+8],4       ; MOV(Mov_rm32_imm32) [mem(32u,RDX:br,:sr),4h:imm32]   encoding(7 bytes) = c7 42 08 04 00 00 00
000fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> GetBytesBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x89,0x02,0xC7,0x42,0x08,0x04,0x00,0x00,0x00,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> GetBytes(in ulong src)
; location: [7FFDD983E9F0h, 7FFDD983EA02h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
0008h mov dword ptr [rdx+8],8       ; MOV(Mov_rm32_imm32) [mem(32u,RDX:br,:sr),8h:imm32]   encoding(7 bytes) = c7 42 08 08 00 00 00
000fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> GetBytesBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x89,0x02,0xC7,0x42,0x08,0x08,0x00,0x00,0x00,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> GetBytes(in double src)
; location: [7FFDD983EA20h, 7FFDD983EA32h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
0008h mov dword ptr [rdx+8],8       ; MOV(Mov_rm32_imm32) [mem(32u,RDX:br,:sr),8h:imm32]   encoding(7 bytes) = c7 42 08 08 00 00 00
000fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> GetBytesBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x89,0x02,0xC7,0x42,0x08,0x08,0x00,0x00,0x00,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: N3 nat3()
; location: [7FFDD983EE50h, 7FFDD983EE62h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(4 bytes) = 0f 1f 40 00
0005h mov byte ptr [rsp],0          ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,:sr),0h:imm8]       encoding(4 bytes) = c6 04 24 00
0009h movsx rax,byte ptr [rsp]      ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RSP:br,:sr)]        encoding(5 bytes) = 48 0f be 04 24
000eh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nat3Bytes => new byte[19]{0x50,0x0F,0x1F,0x40,0x00,0xC6,0x04,0x24,0x00,0x48,0x0F,0xBE,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong nat3val()
; location: [7FFDD983EE80h, 7FFDD983EE8Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,3                     ; MOV(Mov_r32_imm32) [EAX,3h:imm32]                    encoding(5 bytes) = b8 03 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nat3valBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int natval()
; location: [7FFDD983F2B0h, 7FFDD983F2CDh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 20
000bh lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 20
0010h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0013h call 7FFDD983F1D8h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFF28h:jmp64]        encoding(5 bytes) = e8 10 ff ff ff
0018h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0019h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> natvalBytes => new byte[30]{0x48,0x83,0xEC,0x28,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8D,0x44,0x24,0x20,0xC6,0x00,0x00,0xE8,0x10,0xFF,0xFF,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int natseq2()
; location: [7FFDD983F6F0h, 7FFDD983F6FFh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h call 7FFDD983F250h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFB60h:jmp64]        encoding(5 bytes) = e8 56 fb ff ff
000ah nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> natseq2Bytes => new byte[16]{0x48,0x83,0xEC,0x28,0x90,0xE8,0x56,0xFB,0xFF,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int natseq3()
; location: [7FFDD983FB20h, 7FFDD983FB2Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,173h                  ; MOV(Mov_r32_imm32) [EAX,173h:imm32]                  encoding(5 bytes) = b8 73 01 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> natseq3Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x73,0x01,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int natseq4()
; location: [7FFDD983FB40h, 7FFDD983FB4Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,400h                  ; MOV(Mov_r32_imm32) [EAX,400h:imm32]                  encoding(5 bytes) = b8 00 04 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> natseq4Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x04,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int add()
; location: [7FFDD983FF70h, 7FFDD983FF9Fh]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 30
000bh mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 28
0010h lea rax,[rsp+30h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 30
0015h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0018h call 7FFDD983FB68h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFBF8h:jmp64]        encoding(5 bytes) = e8 db fb ff ff
001dh lea rdx,[rsp+28h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 28
0022h mov byte ptr [rdx],0          ; MOV(Mov_rm8_imm8) [mem(8u,RDX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 02 00
0025h add eax,4                     ; ADD(Add_rm32_imm8) [EAX,4h:imm32]                    encoding(3 bytes) = 83 c0 04
0028h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
002bh add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[48]{0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x28,0x48,0x8D,0x44,0x24,0x30,0xC6,0x00,0x00,0xE8,0xDB,0xFB,0xFF,0xFF,0x48,0x8D,0x54,0x24,0x28,0xC6,0x02,0x00,0x83,0xC0,0x04,0x48,0x63,0xC0,0x48,0x83,0xC4,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sub()
; location: [7FFDD983FFC0h, 7FFDD983FFE9h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 10
000bh mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 08
0010h lea rax,[rsp+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 10
0015h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0018h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
001dh mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0020h mov eax,600h                  ; MOV(Mov_r32_imm32) [EAX,600h:imm32]                  encoding(5 bytes) = b8 00 06 00 00
0025h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[42]{0x48,0x83,0xEC,0x18,0x33,0xC0,0x48,0x89,0x44,0x24,0x10,0x48,0x89,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x10,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x08,0xC6,0x00,0x00,0xB8,0x00,0x06,0x00,0x00,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int mul()
; location: [7FFDD9840000h, 7FFDD9840039h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 28
000ch mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 20
0011h lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 28
0016h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0019h call 7FFDD983FB68h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFB68h:jmp64]        encoding(5 bytes) = e8 4a fb ff ff
001eh mov rsi,rax                   ; MOV(Mov_r64_rm64) [RSI,RAX]                          encoding(3 bytes) = 48 8b f0
0021h lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 20
0026h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0029h call 7FFDD983FB68h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFB68h:jmp64]        encoding(5 bytes) = e8 3a fb ff ff
002eh imul eax,esi                  ; IMUL(Imul_r32_rm32) [EAX,ESI]                        encoding(3 bytes) = 0f af c6
0031h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
0034h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0038h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0039h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[58]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x20,0x48,0x8D,0x44,0x24,0x28,0xC6,0x00,0x00,0xE8,0x4A,0xFB,0xFF,0xFF,0x48,0x8B,0xF0,0x48,0x8D,0x44,0x24,0x20,0xC6,0x00,0x00,0xE8,0x3A,0xFB,0xFF,0xFF,0x0F,0xAF,0xC6,0x48,0x63,0xC0,0x48,0x83,0xC4,0x30,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int div()
; location: [7FFDD9840050h, 7FFDD9840089h]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 30
000bh mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 28
0010h lea rax,[rsp+30h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 30
0015h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0018h call 7FFDD983FB68h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFB18h:jmp64]        encoding(5 bytes) = e8 fb fa ff ff
001dh lea rdx,[rsp+28h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 28
0022h mov byte ptr [rdx],0          ; MOV(Mov_rm8_imm8) [mem(8u,RDX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 02 00
0025h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0027h sar edx,1Fh                   ; SAR(Sar_rm32_imm8) [EDX,1fh:imm8]                    encoding(3 bytes) = c1 fa 1f
002ah and edx,3                     ; AND(And_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 e2 03
002dh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
002fh sar eax,2                     ; SAR(Sar_rm32_imm8) [EAX,2h:imm8]                     encoding(3 bytes) = c1 f8 02
0032h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
0035h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
0039h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divBytes => new byte[58]{0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x28,0x48,0x8D,0x44,0x24,0x30,0xC6,0x00,0x00,0xE8,0xFB,0xFA,0xFF,0xFF,0x48,0x8D,0x54,0x24,0x28,0xC6,0x02,0x00,0x8B,0xD0,0xC1,0xFA,0x1F,0x83,0xE2,0x03,0x03,0xC2,0xC1,0xF8,0x02,0x48,0x63,0xC0,0x48,0x83,0xC4,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int mod()
; location: [7FFDD98404B0h, 7FFDD98404EBh]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 30
000bh mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 28
0010h lea rax,[rsp+30h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 30
0015h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0018h call 7FFDD983FB68h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF6B8h:jmp64]        encoding(5 bytes) = e8 9b f6 ff ff
001dh lea rdx,[rsp+28h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 28
0022h mov byte ptr [rdx],0          ; MOV(Mov_rm8_imm8) [mem(8u,RDX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 02 00
0025h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0027h sar edx,1Fh                   ; SAR(Sar_rm32_imm8) [EDX,1fh:imm8]                    encoding(3 bytes) = c1 fa 1f
002ah and edx,3                     ; AND(And_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 e2 03
002dh add edx,eax                   ; ADD(Add_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 03 d0
002fh and edx,0FFFFFFFCh            ; AND(And_rm32_imm8) [EDX,fffffffffffffffch:imm32]     encoding(3 bytes) = 83 e2 fc
0032h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
0034h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
0037h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
003bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> modBytes => new byte[60]{0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x28,0x48,0x8D,0x44,0x24,0x30,0xC6,0x00,0x00,0xE8,0x9B,0xF6,0xFF,0xFF,0x48,0x8D,0x54,0x24,0x28,0xC6,0x02,0x00,0x8B,0xD0,0xC1,0xFA,0x1F,0x83,0xE2,0x03,0x03,0xD0,0x83,0xE2,0xFC,0x2B,0xC2,0x48,0x63,0xC0,0x48,0x83,0xC4,0x38,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2()
; location: [7FFDD9840500h, 7FFDD9840529h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 20
000bh lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 20
0010h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0013h call 7FFDD98400F8h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFBF8h:jmp64]        encoding(5 bytes) = e8 e0 fb ff ff
0018h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001dh mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
001fh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0022h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0025h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2Bytes => new byte[42]{0x48,0x83,0xEC,0x28,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x8D,0x44,0x24,0x20,0xC6,0x00,0x00,0xE8,0xE0,0xFB,0xFF,0xFF,0xBA,0x01,0x00,0x00,0x00,0x8B,0xC8,0x48,0xD3,0xE2,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sll()
; location: [7FFDD9840540h, 7FFDD984057Ah]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 28
000ch mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 20
0011h lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 28
0016h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0019h call 7FFDD983FB68h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF628h:jmp64]        encoding(5 bytes) = e8 0a f6 ff ff
001eh mov rsi,rax                   ; MOV(Mov_r64_rm64) [RSI,RAX]                          encoding(3 bytes) = 48 8b f0
0021h lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 20
0026h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0029h call 7FFDD983FB68h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF628h:jmp64]        encoding(5 bytes) = e8 fa f5 ff ff
002eh mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0030h shl esi,cl                    ; SHL(Shl_rm32_CL) [ESI,CL]                            encoding(2 bytes) = d3 e6
0032h movsxd rax,esi                ; MOVSXD(Movsxd_r64_rm32) [RAX,ESI]                    encoding(3 bytes) = 48 63 c6
0035h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0039h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[59]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x20,0x48,0x8D,0x44,0x24,0x28,0xC6,0x00,0x00,0xE8,0x0A,0xF6,0xFF,0xFF,0x48,0x8B,0xF0,0x48,0x8D,0x44,0x24,0x20,0xC6,0x00,0x00,0xE8,0xFA,0xF5,0xFF,0xFF,0x8B,0xC8,0xD3,0xE6,0x48,0x63,0xC6,0x48,0x83,0xC4,0x30,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong srl()
; location: [7FFDD9840590h, 7FFDD98405B9h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 10
000bh mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 08
0010h lea rax,[rsp+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 10
0015h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0018h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
001dh mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0020h mov eax,40000h                ; MOV(Mov_r32_imm32) [EAX,40000h:imm32]                encoding(5 bytes) = b8 00 00 04 00
0025h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[42]{0x48,0x83,0xEC,0x18,0x33,0xC0,0x48,0x89,0x44,0x24,0x10,0x48,0x89,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x10,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x08,0xC6,0x00,0x00,0xB8,0x00,0x00,0x04,0x00,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong rotr64u()
; location: [7FFDD98405D0h, 7FFDD984062Fh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,48h                   ; SUB(Sub_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 ec 48
0006h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0009h lea rdi,[rsp+20h]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 7c 24 20
000eh mov ecx,0Ah                   ; MOV(Mov_r32_imm32) [ECX,ah:imm32]                    encoding(5 bytes) = b9 0a 00 00 00
0013h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0015h rep stosd                     ; STOSD(Stosd_m32_EAX) [mem(32u),EAX]                  encoding(2 bytes) = f3 ab
0017h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
001ah lea rax,[rsp+40h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 40
001fh mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0022h lea rax,[rsp+38h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 38
0027h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
002ah lea rax,[rsp+30h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 30
002fh mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0032h lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 28
0037h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
003ah call 7FFDD9840280h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFCB0h:jmp64]        encoding(5 bytes) = e8 71 fc ff ff
003fh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 4c 24 20
0044h mov byte ptr [rcx],0          ; MOV(Mov_rm8_imm8) [mem(8u,RCX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 01 00
0047h add eax,8                     ; ADD(Add_rm32_imm8) [EAX,8h:imm32]                    encoding(3 bytes) = 83 c0 08
004ah movsxd rcx,eax                ; MOVSXD(Movsxd_r64_rm32) [RCX,EAX]                    encoding(3 bytes) = 48 63 c8
004dh mov eax,400h                  ; MOV(Mov_r32_imm32) [EAX,400h:imm32]                  encoding(5 bytes) = b8 00 04 00 00
0052h shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
0055h or rax,4                      ; OR(Or_rm64_imm8) [RAX,4h:imm64]                      encoding(4 bytes) = 48 83 c8 04
0059h add rsp,48h                   ; ADD(Add_rm64_imm8) [RSP,48h:imm64]                   encoding(4 bytes) = 48 83 c4 48
005dh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
005eh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
005fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotr64uBytes => new byte[96]{0x57,0x56,0x48,0x83,0xEC,0x48,0x48,0x8B,0xF1,0x48,0x8D,0x7C,0x24,0x20,0xB9,0x0A,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0x48,0x8D,0x44,0x24,0x40,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x38,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x30,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x28,0xC6,0x00,0x00,0xE8,0x71,0xFC,0xFF,0xFF,0x48,0x8D,0x4C,0x24,0x20,0xC6,0x01,0x00,0x83,0xC0,0x08,0x48,0x63,0xC8,0xB8,0x00,0x04,0x00,0x00,0x48,0xD3,0xE0,0x48,0x83,0xC8,0x04,0x48,0x83,0xC4,0x48,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte rotr8u_1()
; location: [7FFDD9840650h, 7FFDD984069Bh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0009h lea rdi,[rsp]                 ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 3c 24
000dh mov ecx,0Ah                   ; MOV(Mov_r32_imm32) [ECX,ah:imm32]                    encoding(5 bytes) = b9 0a 00 00 00
0012h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0014h rep stosd                     ; STOSD(Stosd_m32_EAX) [mem(32u),EAX]                  encoding(2 bytes) = f3 ab
0016h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0019h lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 20
001eh mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0021h lea rax,[rsp+18h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 18
0026h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0029h lea rax,[rsp+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 10
002eh mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0031h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
0036h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0039h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
003dh mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0040h mov eax,40h                   ; MOV(Mov_r32_imm32) [EAX,40h:imm32]                   encoding(5 bytes) = b8 40 00 00 00
0045h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0049h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
004ah pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
004bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotr8u_1Bytes => new byte[76]{0x57,0x56,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF1,0x48,0x8D,0x3C,0x24,0xB9,0x0A,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0x48,0x8D,0x44,0x24,0x20,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x18,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x10,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x08,0xC6,0x00,0x00,0x48,0x8D,0x04,0x24,0xC6,0x00,0x00,0xB8,0x40,0x00,0x00,0x00,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte rotr8u_2()
; location: [7FFDD98406C0h, 7FFDD984070Bh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0009h lea rdi,[rsp]                 ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 3c 24
000dh mov ecx,0Ah                   ; MOV(Mov_r32_imm32) [ECX,ah:imm32]                    encoding(5 bytes) = b9 0a 00 00 00
0012h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0014h rep stosd                     ; STOSD(Stosd_m32_EAX) [mem(32u),EAX]                  encoding(2 bytes) = f3 ab
0016h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0019h lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 20
001eh mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0021h lea rax,[rsp+18h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 18
0026h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0029h lea rax,[rsp+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 10
002eh mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0031h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
0036h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0039h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
003dh mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0040h mov eax,20h                   ; MOV(Mov_r32_imm32) [EAX,20h:imm32]                   encoding(5 bytes) = b8 20 00 00 00
0045h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0049h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
004ah pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
004bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotr8u_2Bytes => new byte[76]{0x57,0x56,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF1,0x48,0x8D,0x3C,0x24,0xB9,0x0A,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0x48,0x8D,0x44,0x24,0x20,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x18,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x10,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x08,0xC6,0x00,0x00,0x48,0x8D,0x04,0x24,0xC6,0x00,0x00,0xB8,0x20,0x00,0x00,0x00,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte rotr8u_3()
; location: [7FFDD9840730h, 7FFDD984077Bh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0009h lea rdi,[rsp]                 ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 3c 24
000dh mov ecx,0Ah                   ; MOV(Mov_r32_imm32) [ECX,ah:imm32]                    encoding(5 bytes) = b9 0a 00 00 00
0012h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0014h rep stosd                     ; STOSD(Stosd_m32_EAX) [mem(32u),EAX]                  encoding(2 bytes) = f3 ab
0016h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0019h lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 20
001eh mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0021h lea rax,[rsp+18h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 18
0026h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0029h lea rax,[rsp+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 10
002eh mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0031h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
0036h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0039h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
003dh mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0040h mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
0045h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0049h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
004ah pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
004bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotr8u_3Bytes => new byte[76]{0x57,0x56,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF1,0x48,0x8D,0x3C,0x24,0xB9,0x0A,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0x48,0x8D,0x44,0x24,0x20,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x18,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x10,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x08,0xC6,0x00,0x00,0x48,0x8D,0x04,0x24,0xC6,0x00,0x00,0xB8,0x10,0x00,0x00,0x00,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> perm4x64_256x64(Vec256<ulong> src)
; location: [7FFDD9843330h, 7FFDD9843368h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000ah vpermq ymm0,ymm0,0E4h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,e4h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 e4
0010h vpermq ymm0,ymm0,0B4h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,b4h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 b4
0016h vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
001ch vpermq ymm0,ymm0,78h          ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,78h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 78
0022h vpermq ymm0,ymm0,9Ch          ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,9ch:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 9c
0028h vpermq ymm0,ymm0,6Ch          ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,6ch:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 6c
002eh vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0032h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0035h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0038h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> perm4x64_256x64Bytes => new byte[57]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x00,0xC4,0xE3,0xFD,0x00,0xC0,0xE4,0xC4,0xE3,0xFD,0x00,0xC0,0xB4,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC4,0xE3,0xFD,0x00,0xC0,0x78,0xC4,0xE3,0xFD,0x00,0xC0,0x9C,0xC4,0xE3,0xFD,0x00,0xC0,0x6C,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ulong> perm4x64_256x64(ulong a, ulong b, ulong c, ulong d)
; location: [7FFDD9843790h, 7FFDD98437E3h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovq xmm0,r8                 ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,R8]                  encoding(VEX, 5 bytes) = c4 c1 f9 6e c0
000ah vpinsrq xmm0,xmm0,r9,1        ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,R9,1h:imm8] encoding(VEX, 6 bytes) = c4 c3 f9 22 c1 01
0010h vmovq xmm1,qword ptr [rsp+28h]; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,mem(64u,RSP:br,:sr)] encoding(VEX, 7 bytes) = c4 e1 f9 6e 4c 24 28
0017h vpinsrq xmm1,xmm1,qword ptr [rsp+30h],1; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM1,XMM1,mem(64u,RSP:br,:sr),1h:imm8] encoding(VEX, 8 bytes) = c4 e3 f1 22 4c 24 30 01
001fh vinserti128 ymm0,ymm0,xmm1,1  ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 38 c1 01
0025h vpermq ymm0,ymm0,0E4h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,e4h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 e4
002bh vpermq ymm0,ymm0,0B4h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,b4h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 b4
0031h vpermq ymm0,ymm0,0D8h         ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,d8h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 d8
0037h vpermq ymm0,ymm0,78h          ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,78h:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 78
003dh vpermq ymm0,ymm0,9Ch          ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,9ch:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 9c
0043h vpermq ymm0,ymm0,6Ch          ; VPERMQ(VEX_Vpermq_ymm_ymmm256_imm8) [YMM0,YMM0,6ch:imm8] encoding(VEX, 6 bytes) = c4 e3 fd 00 c0 6c
0049h vmovupd [rdx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
004dh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0050h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0053h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> perm4x64_256x64Bytes => new byte[84]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0xF9,0x6E,0xC0,0xC4,0xC3,0xF9,0x22,0xC1,0x01,0xC4,0xE1,0xF9,0x6E,0x4C,0x24,0x28,0xC4,0xE3,0xF1,0x22,0x4C,0x24,0x30,0x01,0xC4,0xE3,0x7D,0x38,0xC1,0x01,0xC4,0xE3,0xFD,0x00,0xC0,0xE4,0xC4,0xE3,0xFD,0x00,0xC0,0xB4,0xC4,0xE3,0xFD,0x00,0xC0,0xD8,0xC4,0xE3,0xFD,0x00,0xC0,0x78,0xC4,0xE3,0xFD,0x00,0xC0,0x9C,0xC4,0xE3,0xFD,0x00,0xC0,0x6C,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int Switch14(int x)
; location: [7FFDD9843800h, 7FFDD98438D0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h lea ecx,[rdx-1]               ; LEA(Lea_r32_m) [ECX,mem(Unknown,RDX:br,:sr)]         encoding(3 bytes) = 8d 4a ff
0008h cmp ecx,0Dh                   ; CMP(Cmp_rm32_imm8) [ECX,dh:imm32]                    encoding(3 bytes) = 83 f9 0d
000bh ja short 0025h                ; JA(Ja_rel8_64) [25h:jmp64]                           encoding(2 bytes) = 77 18
000dh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000fh lea rdx,[7FFDD98438D8h]       ; LEA(Lea_r64_m) [RDX,mem(Unknown,RIP:br,:sr)]         encoding(7 bytes) = 48 8d 15 c2 00 00 00
0016h mov edx,[rdx+rax*4]           ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 14 82
0019h lea rcx,[7FFDD9843805h]       ; LEA(Lea_r64_m) [RCX,mem(Unknown,RIP:br,:sr)]         encoding(7 bytes) = 48 8d 0d e5 ff ff ff
0020h add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
0023h jmp rdx                       ; JMP(Jmp_rm64) [RDX]                                  encoding(2 bytes) = ff e2
0025h add edx,0FFFFE4A8h            ; ADD(Add_rm32_imm32) [EDX,ffffe4a8h:imm32]            encoding(6 bytes) = 81 c2 a8 e4 ff ff
002bh cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
002eh ja near ptr 00ceh             ; JA(Ja_rel32_64) [CEh:jmp64]                          encoding(6 bytes) = 0f 87 9a 00 00 00
0034h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0036h lea rdx,[7FFDD9843910h]       ; LEA(Lea_r64_m) [RDX,mem(Unknown,RIP:br,:sr)]         encoding(7 bytes) = 48 8d 15 d3 00 00 00
003dh mov edx,[rdx+rax*4]           ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 14 82
0040h lea rcx,[7FFDD9843805h]       ; LEA(Lea_r64_m) [RCX,mem(Unknown,RIP:br,:sr)]         encoding(7 bytes) = 48 8d 0d be ff ff ff
0047h add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
004ah jmp rdx                       ; JMP(Jmp_rm64) [RDX]                                  encoding(2 bytes) = ff e2
004ch mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0051h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0052h mov eax,4                     ; MOV(Mov_r32_imm32) [EAX,4h:imm32]                    encoding(5 bytes) = b8 04 00 00 00
0057h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0058h mov eax,8                     ; MOV(Mov_r32_imm32) [EAX,8h:imm32]                    encoding(5 bytes) = b8 08 00 00 00
005dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
005eh mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
0063h jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 6b
0065h mov eax,20h                   ; MOV(Mov_r32_imm32) [EAX,20h:imm32]                   encoding(5 bytes) = b8 20 00 00 00
006ah jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 64
006ch mov eax,40h                   ; MOV(Mov_r32_imm32) [EAX,40h:imm32]                   encoding(5 bytes) = b8 40 00 00 00
0071h jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 5d
0073h mov eax,80h                   ; MOV(Mov_r32_imm32) [EAX,80h:imm32]                   encoding(5 bytes) = b8 80 00 00 00
0078h jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 56
007ah mov eax,100h                  ; MOV(Mov_r32_imm32) [EAX,100h:imm32]                  encoding(5 bytes) = b8 00 01 00 00
007fh jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 4f
0081h mov eax,200h                  ; MOV(Mov_r32_imm32) [EAX,200h:imm32]                  encoding(5 bytes) = b8 00 02 00 00
0086h jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 48
0088h mov eax,400h                  ; MOV(Mov_r32_imm32) [EAX,400h:imm32]                  encoding(5 bytes) = b8 00 04 00 00
008dh jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 41
008fh mov eax,7ECh                  ; MOV(Mov_r32_imm32) [EAX,7ech:imm32]                  encoding(5 bytes) = b8 ec 07 00 00
0094h jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 3a
0096h mov eax,0Ah                   ; MOV(Mov_r32_imm32) [EAX,ah:imm32]                    encoding(5 bytes) = b8 0a 00 00 00
009bh jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 33
009dh mov eax,14h                   ; MOV(Mov_r32_imm32) [EAX,14h:imm32]                   encoding(5 bytes) = b8 14 00 00 00
00a2h jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 2c
00a4h mov eax,1Eh                   ; MOV(Mov_r32_imm32) [EAX,1eh:imm32]                   encoding(5 bytes) = b8 1e 00 00 00
00a9h jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 25
00abh mov eax,400h                  ; MOV(Mov_r32_imm32) [EAX,400h:imm32]                  encoding(5 bytes) = b8 00 04 00 00
00b0h jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 1e
00b2h mov eax,7ECh                  ; MOV(Mov_r32_imm32) [EAX,7ech:imm32]                  encoding(5 bytes) = b8 ec 07 00 00
00b7h jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 17
00b9h mov eax,0Ah                   ; MOV(Mov_r32_imm32) [EAX,ah:imm32]                    encoding(5 bytes) = b8 0a 00 00 00
00beh jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 10
00c0h mov eax,14h                   ; MOV(Mov_r32_imm32) [EAX,14h:imm32]                   encoding(5 bytes) = b8 14 00 00 00
00c5h jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 09
00c7h mov eax,1Eh                   ; MOV(Mov_r32_imm32) [EAX,1eh:imm32]                   encoding(5 bytes) = b8 1e 00 00 00
00cch jmp short 00d0h               ; JMP(Jmp_rel8_64) [D0h:jmp64]                         encoding(2 bytes) = eb 02
00ceh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
00d0h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> Switch14Bytes => new byte[209]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x4A,0xFF,0x83,0xF9,0x0D,0x77,0x18,0x8B,0xC1,0x48,0x8D,0x15,0xC2,0x00,0x00,0x00,0x8B,0x14,0x82,0x48,0x8D,0x0D,0xE5,0xFF,0xFF,0xFF,0x48,0x03,0xD1,0xFF,0xE2,0x81,0xC2,0xA8,0xE4,0xFF,0xFF,0x83,0xFA,0x04,0x0F,0x87,0x9A,0x00,0x00,0x00,0x8B,0xC2,0x48,0x8D,0x15,0xD3,0x00,0x00,0x00,0x8B,0x14,0x82,0x48,0x8D,0x0D,0xBE,0xFF,0xFF,0xFF,0x48,0x03,0xD1,0xFF,0xE2,0xB8,0x01,0x00,0x00,0x00,0xC3,0xB8,0x04,0x00,0x00,0x00,0xC3,0xB8,0x08,0x00,0x00,0x00,0xC3,0xB8,0x10,0x00,0x00,0x00,0xEB,0x6B,0xB8,0x20,0x00,0x00,0x00,0xEB,0x64,0xB8,0x40,0x00,0x00,0x00,0xEB,0x5D,0xB8,0x80,0x00,0x00,0x00,0xEB,0x56,0xB8,0x00,0x01,0x00,0x00,0xEB,0x4F,0xB8,0x00,0x02,0x00,0x00,0xEB,0x48,0xB8,0x00,0x04,0x00,0x00,0xEB,0x41,0xB8,0xEC,0x07,0x00,0x00,0xEB,0x3A,0xB8,0x0A,0x00,0x00,0x00,0xEB,0x33,0xB8,0x14,0x00,0x00,0x00,0xEB,0x2C,0xB8,0x1E,0x00,0x00,0x00,0xEB,0x25,0xB8,0x00,0x04,0x00,0x00,0xEB,0x1E,0xB8,0xEC,0x07,0x00,0x00,0xEB,0x17,0xB8,0x0A,0x00,0x00,0x00,0xEB,0x10,0xB8,0x14,0x00,0x00,0x00,0xEB,0x09,0xB8,0x1E,0x00,0x00,0x00,0xEB,0x02,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int IfElse10(int x)
; location: [7FFDD9843940h, 7FFDD98439BCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0008h jne short 0010h               ; JNE(Jne_rel8_64) [10h:jmp64]                         encoding(2 bytes) = 75 06
000ah mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0010h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
0013h jne short 001bh               ; JNE(Jne_rel8_64) [1Bh:jmp64]                         encoding(2 bytes) = 75 06
0015h mov eax,4                     ; MOV(Mov_r32_imm32) [EAX,4h:imm32]                    encoding(5 bytes) = b8 04 00 00 00
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
001bh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
001eh jne short 0026h               ; JNE(Jne_rel8_64) [26h:jmp64]                         encoding(2 bytes) = 75 06
0020h mov eax,8                     ; MOV(Mov_r32_imm32) [EAX,8h:imm32]                    encoding(5 bytes) = b8 08 00 00 00
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0026h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
0029h jne short 0032h               ; JNE(Jne_rel8_64) [32h:jmp64]                         encoding(2 bytes) = 75 07
002bh mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
0030h jmp short 007ch               ; JMP(Jmp_rel8_64) [7Ch:jmp64]                         encoding(2 bytes) = eb 4a
0032h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
0035h jne short 003eh               ; JNE(Jne_rel8_64) [3Eh:jmp64]                         encoding(2 bytes) = 75 07
0037h mov eax,20h                   ; MOV(Mov_r32_imm32) [EAX,20h:imm32]                   encoding(5 bytes) = b8 20 00 00 00
003ch jmp short 007ch               ; JMP(Jmp_rel8_64) [7Ch:jmp64]                         encoding(2 bytes) = eb 3e
003eh cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
0041h jne short 004ah               ; JNE(Jne_rel8_64) [4Ah:jmp64]                         encoding(2 bytes) = 75 07
0043h mov eax,40h                   ; MOV(Mov_r32_imm32) [EAX,40h:imm32]                   encoding(5 bytes) = b8 40 00 00 00
0048h jmp short 007ch               ; JMP(Jmp_rel8_64) [7Ch:jmp64]                         encoding(2 bytes) = eb 32
004ah cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
004dh jne short 0056h               ; JNE(Jne_rel8_64) [56h:jmp64]                         encoding(2 bytes) = 75 07
004fh mov eax,80h                   ; MOV(Mov_r32_imm32) [EAX,80h:imm32]                   encoding(5 bytes) = b8 80 00 00 00
0054h jmp short 007ch               ; JMP(Jmp_rel8_64) [7Ch:jmp64]                         encoding(2 bytes) = eb 26
0056h cmp edx,8                     ; CMP(Cmp_rm32_imm8) [EDX,8h:imm32]                    encoding(3 bytes) = 83 fa 08
0059h jne short 0062h               ; JNE(Jne_rel8_64) [62h:jmp64]                         encoding(2 bytes) = 75 07
005bh mov eax,100h                  ; MOV(Mov_r32_imm32) [EAX,100h:imm32]                  encoding(5 bytes) = b8 00 01 00 00
0060h jmp short 007ch               ; JMP(Jmp_rel8_64) [7Ch:jmp64]                         encoding(2 bytes) = eb 1a
0062h cmp edx,9                     ; CMP(Cmp_rm32_imm8) [EDX,9h:imm32]                    encoding(3 bytes) = 83 fa 09
0065h jne short 006eh               ; JNE(Jne_rel8_64) [6Eh:jmp64]                         encoding(2 bytes) = 75 07
0067h mov eax,200h                  ; MOV(Mov_r32_imm32) [EAX,200h:imm32]                  encoding(5 bytes) = b8 00 02 00 00
006ch jmp short 007ch               ; JMP(Jmp_rel8_64) [7Ch:jmp64]                         encoding(2 bytes) = eb 0e
006eh cmp edx,0Ah                   ; CMP(Cmp_rm32_imm8) [EDX,ah:imm32]                    encoding(3 bytes) = 83 fa 0a
0071h jne short 007ah               ; JNE(Jne_rel8_64) [7Ah:jmp64]                         encoding(2 bytes) = 75 07
0073h mov eax,400h                  ; MOV(Mov_r32_imm32) [EAX,400h:imm32]                  encoding(5 bytes) = b8 00 04 00 00
0078h jmp short 007ch               ; JMP(Jmp_rel8_64) [7Ch:jmp64]                         encoding(2 bytes) = eb 02
007ah xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
007ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> IfElse10Bytes => new byte[125]{0x0F,0x1F,0x44,0x00,0x00,0x83,0xFA,0x01,0x75,0x06,0xB8,0x01,0x00,0x00,0x00,0xC3,0x83,0xFA,0x02,0x75,0x06,0xB8,0x04,0x00,0x00,0x00,0xC3,0x83,0xFA,0x03,0x75,0x06,0xB8,0x08,0x00,0x00,0x00,0xC3,0x83,0xFA,0x04,0x75,0x07,0xB8,0x10,0x00,0x00,0x00,0xEB,0x4A,0x83,0xFA,0x05,0x75,0x07,0xB8,0x20,0x00,0x00,0x00,0xEB,0x3E,0x83,0xFA,0x06,0x75,0x07,0xB8,0x40,0x00,0x00,0x00,0xEB,0x32,0x83,0xFA,0x07,0x75,0x07,0xB8,0x80,0x00,0x00,0x00,0xEB,0x26,0x83,0xFA,0x08,0x75,0x07,0xB8,0x00,0x01,0x00,0x00,0xEB,0x1A,0x83,0xFA,0x09,0x75,0x07,0xB8,0x00,0x02,0x00,0x00,0xEB,0x0E,0x83,0xFA,0x0A,0x75,0x07,0xB8,0x00,0x04,0x00,0x00,0xEB,0x02,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> get_U8Data()
; location: [7FFDD98439D0h, 7FFDD98439ECh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,2A853BC96E5h          ; MOV(Mov_r64_imm64) [RAX,2a853bc96e5h:imm64]          encoding(10 bytes) = 48 b8 e5 96 bc 53 a8 02 00 00
000fh mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
0012h mov dword ptr [rcx+8],40h     ; MOV(Mov_rm32_imm32) [mem(32u,RCX:br,:sr),40h:imm32]  encoding(7 bytes) = c7 41 08 40 00 00 00
0019h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> get_U8DataBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xE5,0x96,0xBC,0x53,0xA8,0x02,0x00,0x00,0x48,0x89,0x01,0xC7,0x41,0x08,0x40,0x00,0x00,0x00,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<uint> get_U32Data()
; location: [7FFDD9843A00h, 7FFDD9843A6Ah]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000bh mov rcx,7FFDD9A38EB0h         ; MOV(Mov_r64_imm64) [RCX,7ffdd9a38eb0h:imm64]         encoding(10 bytes) = 48 b9 b0 8e a3 d9 fd 7f 00 00
0015h mov edx,10h                   ; MOV(Mov_r32_imm32) [EDX,10h:imm32]                   encoding(5 bytes) = ba 10 00 00 00
001ah call 7FFE393645E0h            ; CALL(Call_rel32_64) [5FB20BE0h:jmp64]                encoding(5 bytes) = e8 c1 0b b2 5f
001fh mov rdx,2A853BC96A5h          ; MOV(Mov_r64_imm64) [RDX,2a853bc96a5h:imm64]          encoding(10 bytes) = 48 ba a5 96 bc 53 a8 02 00 00
0029h lea rcx,[rax+10h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 48 10
002dh vmovdqu xmm0,xmmword ptr [rdx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 02
0031h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
0035h vmovdqu xmm0,xmmword ptr [rdx+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 42 10
003ah vmovdqu xmmword ptr [rcx+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 10
003fh vmovdqu xmm0,xmmword ptr [rdx+20h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 42 20
0044h vmovdqu xmmword ptr [rcx+20h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 20
0049h vmovdqu xmm0,xmmword ptr [rdx+30h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 42 30
004eh vmovdqu xmmword ptr [rcx+30h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 30
0053h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
0057h mov edx,10h                   ; MOV(Mov_r32_imm32) [EDX,10h:imm32]                   encoding(5 bytes) = ba 10 00 00 00
005ch mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,:sr),RAX]          encoding(3 bytes) = 48 89 06
005fh mov [rsi+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,:sr),EDX]          encoding(3 bytes) = 89 56 08
0062h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0065h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0069h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
006ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> get_U32DataBytes => new byte[107]{0x56,0x48,0x83,0xEC,0x20,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0x48,0xB9,0xB0,0x8E,0xA3,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x10,0x00,0x00,0x00,0xE8,0xC1,0x0B,0xB2,0x5F,0x48,0xBA,0xA5,0x96,0xBC,0x53,0xA8,0x02,0x00,0x00,0x48,0x8D,0x48,0x10,0xC5,0xFA,0x6F,0x02,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x6F,0x42,0x10,0xC5,0xFA,0x7F,0x41,0x10,0xC5,0xFA,0x6F,0x42,0x20,0xC5,0xFA,0x7F,0x41,0x20,0xC5,0xFA,0x6F,0x42,0x30,0xC5,0xFA,0x7F,0x41,0x30,0x48,0x83,0xC0,0x10,0xBA,0x10,0x00,0x00,0x00,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint Or8Inline(uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7)
; location: [7FFDD9843A90h, 7FFDD9843AAFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0007h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
000ah or edx,r9d                    ; OR(Or_r32_rm32) [EDX,R9D]                            encoding(3 bytes) = 41 0b d1
000dh or edx,[rsp+28h]              ; OR(Or_r32_rm32) [EDX,mem(32u,RSP:br,:sr)]            encoding(4 bytes) = 0b 54 24 28
0011h or edx,[rsp+30h]              ; OR(Or_r32_rm32) [EDX,mem(32u,RSP:br,:sr)]            encoding(4 bytes) = 0b 54 24 30
0015h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0017h or eax,[rsp+38h]              ; OR(Or_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]            encoding(4 bytes) = 0b 44 24 38
001bh or eax,[rsp+40h]              ; OR(Or_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]            encoding(4 bytes) = 0b 44 24 40
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> Or8InlineBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0B,0xD1,0x41,0x0B,0xD0,0x41,0x0B,0xD1,0x0B,0x54,0x24,0x28,0x0B,0x54,0x24,0x30,0x8B,0xC2,0x0B,0x44,0x24,0x38,0x0B,0x44,0x24,0x40,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint RotLU32Inline(uint x, int offset)
; location: [7FFDD9843AC0h, 7FFDD9843ACBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h rol eax,cl                    ; ROL(Rol_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> RotLU32InlineBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int ChoiceIfElse5Inline(int x)
; location: [7FFDD9843AE0h, 7FFDD9843B20h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0008h jne short 0010h               ; JNE(Jne_rel8_64) [10h:jmp64]                         encoding(2 bytes) = 75 06
000ah mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0010h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
0013h jne short 001bh               ; JNE(Jne_rel8_64) [1Bh:jmp64]                         encoding(2 bytes) = 75 06
0015h mov eax,4                     ; MOV(Mov_r32_imm32) [EAX,4h:imm32]                    encoding(5 bytes) = b8 04 00 00 00
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
001bh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
001eh jne short 0026h               ; JNE(Jne_rel8_64) [26h:jmp64]                         encoding(2 bytes) = 75 06
0020h mov eax,8                     ; MOV(Mov_r32_imm32) [EAX,8h:imm32]                    encoding(5 bytes) = b8 08 00 00 00
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0026h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
0029h jne short 0032h               ; JNE(Jne_rel8_64) [32h:jmp64]                         encoding(2 bytes) = 75 07
002bh mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
0030h jmp short 0040h               ; JMP(Jmp_rel8_64) [40h:jmp64]                         encoding(2 bytes) = eb 0e
0032h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
0035h jne short 003eh               ; JNE(Jne_rel8_64) [3Eh:jmp64]                         encoding(2 bytes) = 75 07
0037h mov eax,20h                   ; MOV(Mov_r32_imm32) [EAX,20h:imm32]                   encoding(5 bytes) = b8 20 00 00 00
003ch jmp short 0040h               ; JMP(Jmp_rel8_64) [40h:jmp64]                         encoding(2 bytes) = eb 02
003eh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0040h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ChoiceIfElse5InlineBytes => new byte[65]{0x0F,0x1F,0x44,0x00,0x00,0x83,0xFA,0x01,0x75,0x06,0xB8,0x01,0x00,0x00,0x00,0xC3,0x83,0xFA,0x02,0x75,0x06,0xB8,0x04,0x00,0x00,0x00,0xC3,0x83,0xFA,0x03,0x75,0x06,0xB8,0x08,0x00,0x00,0x00,0xC3,0x83,0xFA,0x04,0x75,0x07,0xB8,0x10,0x00,0x00,0x00,0xEB,0x0E,0x83,0xFA,0x05,0x75,0x07,0xB8,0x20,0x00,0x00,0x00,0xEB,0x02,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int CheckMatches()
; location: [7FFDD9844350h, 7FFDD984435Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,3FFh                  ; MOV(Mov_r32_imm32) [EAX,3ffh:imm32]                  encoding(5 bytes) = b8 ff 03 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> CheckMatchesBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0x03,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> ReadU8Data(int count)
; location: [7FFDD9844370h, 7FFDD984438Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,2A853BC96E5h          ; MOV(Mov_r64_imm64) [RAX,2a853bc96e5h:imm64]          encoding(10 bytes) = 48 b8 e5 96 bc 53 a8 02 00 00
000fh mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
0012h mov dword ptr [rdx+8],40h     ; MOV(Mov_rm32_imm32) [mem(32u,RDX:br,:sr),40h:imm32]  encoding(7 bytes) = c7 42 08 40 00 00 00
0019h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ReadU8DataBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xE5,0x96,0xBC,0x53,0xA8,0x02,0x00,0x00,0x48,0x89,0x02,0xC7,0x42,0x08,0x40,0x00,0x00,0x00,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<uint> ReadU32Data(int count)
; location: [7FFDD98443A0h, 7FFDD98443B2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
0008h mov rax,7FFDD9843A00h         ; MOV(Mov_r64_imm64) [RAX,7ffdd9843a00h:imm64]         encoding(10 bytes) = 48 b8 00 3a 84 d9 fd 7f 00 00
0012h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> ReadU32DataBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xCA,0x48,0xB8,0x00,0x3A,0x84,0xD9,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void VoidReturn()
; location: [7FFDD9844740h, 7FFDD984475Ch]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rcx,2A863C33060h          ; MOV(Mov_r64_imm64) [RCX,2a863c33060h:imm64]          encoding(10 bytes) = 48 b9 60 30 c3 63 a8 02 00 00
000fh mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 09
0012h call 7FFDD9844710h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFFD0h:jmp64]        encoding(5 bytes) = e8 b9 ff ff ff
0017h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0018h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> VoidReturnBytes => new byte[29]{0x48,0x83,0xEC,0x28,0x90,0x48,0xB9,0x60,0x30,0xC3,0x63,0xA8,0x02,0x00,0x00,0x48,0x8B,0x09,0xE8,0xB9,0xFF,0xFF,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int SizeTest()
; location: [7FFDD9844780h, 7FFDD984478Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,7                     ; MOV(Mov_r32_imm32) [EAX,7h:imm32]                    encoding(5 bytes) = b8 07 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> SizeTestBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x07,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void VoidCalls1()
; location: [7FFDD98447A0h, 7FFDD98447AFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FFDD9844740h         ; MOV(Mov_r64_imm64) [RAX,7ffdd9844740h:imm64]         encoding(10 bytes) = 48 b8 40 47 84 d9 fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> VoidCalls1Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x40,0x47,0x84,0xD9,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void VoidCalls2()
; location: [7FFDD98447D0h, 7FFDD98447F2h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
000bh call 7FFDD9844740h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFF70h:jmp64]        encoding(5 bytes) = e8 60 ff ff ff
0010h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0013h mov rax,7FFDD9844740h         ; MOV(Mov_r64_imm64) [RAX,7ffdd9844740h:imm64]         encoding(10 bytes) = 48 b8 40 47 84 d9 fd 7f 00 00
001dh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0021h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0022h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> VoidCalls2Bytes => new byte[37]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0xCE,0xE8,0x60,0xFF,0xFF,0xFF,0x48,0x8B,0xCE,0x48,0xB8,0x40,0x47,0x84,0xD9,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x20,0x5E,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void VoidCalls3()
; location: [7FFDD9844810h, 7FFDD984483Ah]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
000bh call 7FFDD9844740h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFF30h:jmp64]        encoding(5 bytes) = e8 20 ff ff ff
0010h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0013h call 7FFDD9844740h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFF30h:jmp64]        encoding(5 bytes) = e8 18 ff ff ff
0018h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
001bh mov rax,7FFDD9844740h         ; MOV(Mov_r64_imm64) [RAX,7ffdd9844740h:imm64]         encoding(10 bytes) = 48 b8 40 47 84 d9 fd 7f 00 00
0025h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0029h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
002ah jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> VoidCalls3Bytes => new byte[45]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0xCE,0xE8,0x20,0xFF,0xFF,0xFF,0x48,0x8B,0xCE,0xE8,0x18,0xFF,0xFF,0xFF,0x48,0x8B,0xCE,0x48,0xB8,0x40,0x47,0x84,0xD9,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x20,0x5E,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void VoidCalls4()
; location: [7FFDD9844860h, 7FFDD9844892h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
000bh call 7FFDD9844740h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFEE0h:jmp64]        encoding(5 bytes) = e8 d0 fe ff ff
0010h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0013h call 7FFDD9844740h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFEE0h:jmp64]        encoding(5 bytes) = e8 c8 fe ff ff
0018h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
001bh call 7FFDD9844740h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFEE0h:jmp64]        encoding(5 bytes) = e8 c0 fe ff ff
0020h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0023h mov rax,7FFDD9844740h         ; MOV(Mov_r64_imm64) [RAX,7ffdd9844740h:imm64]         encoding(10 bytes) = 48 b8 40 47 84 d9 fd 7f 00 00
002dh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0031h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0032h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> VoidCalls4Bytes => new byte[53]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0xCE,0xE8,0xD0,0xFE,0xFF,0xFF,0x48,0x8B,0xCE,0xE8,0xC8,0xFE,0xFF,0xFF,0x48,0x8B,0xCE,0xE8,0xC0,0xFE,0xFF,0xFF,0x48,0x8B,0xCE,0x48,0xB8,0x40,0x47,0x84,0xD9,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x20,0x5E,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int InvokeBinOp(Func<int,int,int> f, int x, int y)
; location: [7FFDD98448B0h, 7FFDD98448CFh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(4 bytes) = 0f 1f 40 00
0005h mov [rsp],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RDX]          encoding(4 bytes) = 48 89 14 24
0009h mov rcx,[rdx+8]               ; MOV(Mov_r64_rm64) [RCX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 8b 4a 08
000dh mov edx,r8d                   ; MOV(Mov_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 8b d0
0010h mov r8d,r9d                   ; MOV(Mov_r32_rm32) [R8D,R9D]                          encoding(3 bytes) = 45 8b c1
0013h mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(4 bytes) = 48 8b 04 24
0017h mov rax,[rax+18h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(4 bytes) = 48 8b 40 18
001bh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
001fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> InvokeBinOpBytes => new byte[34]{0x50,0x0F,0x1F,0x40,0x00,0x48,0x89,0x14,0x24,0x48,0x8B,0x4A,0x08,0x41,0x8B,0xD0,0x45,0x8B,0xC1,0x48,0x8B,0x04,0x24,0x48,0x8B,0x40,0x18,0x48,0x83,0xC4,0x08,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int AddMulInline(int x, int y)
; location: [7FFDD98448F0h, 7FFDD9844900h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+rdx]             ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,:sr)]         encoding(3 bytes) = 8d 04 11
0008h imul ecx,eax                  ; IMUL(Imul_r32_rm32) [ECX,EAX]                        encoding(3 bytes) = 0f af c8
000bh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000eh add eax,ecx                   ; ADD(Add_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 03 c1
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> AddMulInlineBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x04,0x11,0x0F,0xAF,0xC8,0x0F,0xAF,0xC2,0x03,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int CallInvokeBinOp(int x, int y)
; location: [7FFDD9844920h, 7FFDD9844988h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0003h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0004h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000bh mov edi,edx                   ; MOV(Mov_r32_rm32) [EDI,EDX]                          encoding(2 bytes) = 8b fa
000dh mov ebx,r8d                   ; MOV(Mov_r32_rm32) [EBX,R8D]                          encoding(3 bytes) = 41 8b d8
0010h mov rcx,7FFDD9A3D3A8h         ; MOV(Mov_r64_imm64) [RCX,7ffdd9a3d3a8h:imm64]         encoding(10 bytes) = 48 b9 a8 d3 a3 d9 fd 7f 00 00
001ah call 7FFE393644B0h            ; CALL(Call_rel32_64) [5FB1FB90h:jmp64]                encoding(5 bytes) = e8 71 fb b1 5f
001fh mov rbp,rax                   ; MOV(Mov_r64_rm64) [RBP,RAX]                          encoding(3 bytes) = 48 8b e8
0022h lea rcx,[rbp+8]               ; LEA(Lea_r64_m) [RCX,mem(Unknown,RBP:br,:sr)]         encoding(4 bytes) = 48 8d 4d 08
0026h mov rdx,rbp                   ; MOV(Mov_r64_rm64) [RDX,RBP]                          encoding(3 bytes) = 48 8b d5
0029h call 7FFE393635F0h            ; CALL(Call_rel32_64) [5FB1ECD0h:jmp64]                encoding(5 bytes) = e8 a2 ec b1 5f
002eh mov rcx,7FFDD96FD0A0h         ; MOV(Mov_r64_imm64) [RCX,7ffdd96fd0a0h:imm64]         encoding(10 bytes) = 48 b9 a0 d0 6f d9 fd 7f 00 00
0038h mov [rbp+18h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RBP:br,:sr),RCX]          encoding(4 bytes) = 48 89 4d 18
003ch mov rcx,7FFDD98448F0h         ; MOV(Mov_r64_imm64) [RCX,7ffdd98448f0h:imm64]         encoding(10 bytes) = 48 b9 f0 48 84 d9 fd 7f 00 00
0046h mov [rbp+20h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RBP:br,:sr),RCX]          encoding(4 bytes) = 48 89 4d 20
004ah mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
004dh mov rdx,rbp                   ; MOV(Mov_r64_rm64) [RDX,RBP]                          encoding(3 bytes) = 48 8b d5
0050h mov r8d,edi                   ; MOV(Mov_r32_rm32) [R8D,EDI]                          encoding(3 bytes) = 44 8b c7
0053h mov r9d,ebx                   ; MOV(Mov_r32_rm32) [R9D,EBX]                          encoding(3 bytes) = 44 8b cb
0056h mov rax,7FFDD98448B0h         ; MOV(Mov_r64_imm64) [RAX,7ffdd98448b0h:imm64]         encoding(10 bytes) = 48 b8 b0 48 84 d9 fd 7f 00 00
0060h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0064h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0065h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
0066h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0067h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0068h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> CallInvokeBinOpBytes => new byte[107]{0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF1,0x8B,0xFA,0x41,0x8B,0xD8,0x48,0xB9,0xA8,0xD3,0xA3,0xD9,0xFD,0x7F,0x00,0x00,0xE8,0x71,0xFB,0xB1,0x5F,0x48,0x8B,0xE8,0x48,0x8D,0x4D,0x08,0x48,0x8B,0xD5,0xE8,0xA2,0xEC,0xB1,0x5F,0x48,0xB9,0xA0,0xD0,0x6F,0xD9,0xFD,0x7F,0x00,0x00,0x48,0x89,0x4D,0x18,0x48,0xB9,0xF0,0x48,0x84,0xD9,0xFD,0x7F,0x00,0x00,0x48,0x89,0x4D,0x20,0x48,0x8B,0xCE,0x48,0x8B,0xD5,0x44,0x8B,0xC7,0x44,0x8B,0xCB,0x48,0xB8,0xB0,0x48,0x84,0xD9,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x28,0x5B,0x5D,0x5E,0x5F,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int And(int a, int b)
; location: [7FFDD98449B0h, 7FFDD98449B9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> AndBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int Or(int a, int b)
; location: [7FFDD98449D0h, 7FFDD98449D9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> OrBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int Xor(int a, int b)
; location: [7FFDD98449F0h, 7FFDD98449F9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> XorBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int Nand(int a, int b)
; location: [7FFDD9844A10h, 7FFDD9844A1Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> NandBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int Jump(int target, int a, int b)
; location: [7FFDD9844A30h, 7FFDD9844A5Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
0008h je short 0028h                ; JE(Je_rel8_64) [28h:jmp64]                           encoding(2 bytes) = 74 1e
000ah cmp ecx,2                     ; CMP(Cmp_rm32_imm8) [ECX,2h:imm32]                    encoding(3 bytes) = 83 f9 02
000dh je short 0022h                ; JE(Je_rel8_64) [22h:jmp64]                           encoding(2 bytes) = 74 13
000fh cmp ecx,3                     ; CMP(Cmp_rm32_imm8) [ECX,3h:imm32]                    encoding(3 bytes) = 83 f9 03
0012h je short 001ch                ; JE(Je_rel8_64) [1Ch:jmp64]                           encoding(2 bytes) = 74 08
0014h and edx,r8d                   ; AND(And_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 23 d0
0017h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0019h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
001ch mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
001eh xor eax,r8d                   ; XOR(Xor_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 33 c0
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0022h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0024h or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0028h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
002ah and eax,r8d                   ; AND(And_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 23 c0
002dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> JumpBytes => new byte[46]{0x0F,0x1F,0x44,0x00,0x00,0x83,0xF9,0x01,0x74,0x1E,0x83,0xF9,0x02,0x74,0x13,0x83,0xF9,0x03,0x74,0x08,0x41,0x23,0xD0,0x8B,0xC2,0xF7,0xD0,0xC3,0x8B,0xC2,0x41,0x33,0xC0,0xC3,0x8B,0xC2,0x41,0x0B,0xC0,0xC3,0x8B,0xC2,0x41,0x23,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int Jump()
; location: [7FFDD9844A70h, 7FFDD9844A7Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,7                     ; MOV(Mov_r32_imm32) [EAX,7h:imm32]                    encoding(5 bytes) = b8 07 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> JumpBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x07,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int Mul(int a, int b)
; location: [7FFDD9846600h, 7FFDD9846635h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h mov esi,ecx                   ; MOV(Mov_r32_rm32) [ESI,ECX]                          encoding(2 bytes) = 8b f1
0008h mov edi,edx                   ; MOV(Mov_r32_rm32) [EDI,EDX]                          encoding(2 bytes) = 8b fa
000ah mov rcx,7FFDD98C6B38h         ; MOV(Mov_r64_imm64) [RCX,7ffdd98c6b38h:imm64]         encoding(10 bytes) = 48 b9 38 6b 8c d9 fd 7f 00 00
0014h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0016h call 7FFE3932F3E0h            ; CALL(Call_rel32_64) [5FAE8DE0h:jmp64]                encoding(5 bytes) = e8 c5 8d ae 5f
001bh mov rax,2A863C32D38h          ; MOV(Mov_r64_imm64) [RAX,2a863c32d38h:imm64]          encoding(10 bytes) = 48 b8 38 2d c3 63 a8 02 00 00
0025h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 00
0028h mov eax,[rax]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 00
002ah imul esi,edi                  ; IMUL(Imul_r32_rm32) [ESI,EDI]                        encoding(3 bytes) = 0f af f7
002dh mov eax,esi                   ; MOV(Mov_r32_rm32) [EAX,ESI]                          encoding(2 bytes) = 8b c6
002fh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0033h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0034h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0035h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> MulBytes => new byte[54]{0x57,0x56,0x48,0x83,0xEC,0x28,0x8B,0xF1,0x8B,0xFA,0x48,0xB9,0x38,0x6B,0x8C,0xD9,0xFD,0x7F,0x00,0x00,0x33,0xD2,0xE8,0xC5,0x8D,0xAE,0x5F,0x48,0xB8,0x38,0x2D,0xC3,0x63,0xA8,0x02,0x00,0x00,0x48,0x8B,0x00,0x8B,0x00,0x0F,0xAF,0xF7,0x8B,0xC6,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
