; 2019-12-24 12:34:01:327
; function: Span<byte> GetBytes(in int src)
; location: [7FF7C774D1F0h, 7FF7C774D202h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
0008h mov dword ptr [rdx+8],4       ; MOV(Mov_rm32_imm32) [mem(32u,RDX:br,:sr),4h:imm32]   encoding(7 bytes) = c7 42 08 04 00 00 00
000fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> GetBytesBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x89,0x02,0xC7,0x42,0x08,0x04,0x00,0x00,0x00,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> GetBytes(in ulong src)
; location: [7FF7C774D220h, 7FF7C774D232h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
0008h mov dword ptr [rdx+8],8       ; MOV(Mov_rm32_imm32) [mem(32u,RDX:br,:sr),8h:imm32]   encoding(7 bytes) = c7 42 08 08 00 00 00
000fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> GetBytesBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x89,0x02,0xC7,0x42,0x08,0x08,0x00,0x00,0x00,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> GetBytes(in double src)
; location: [7FF7C774D250h, 7FF7C774D262h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
0008h mov dword ptr [rdx+8],8       ; MOV(Mov_rm32_imm32) [mem(32u,RDX:br,:sr),8h:imm32]   encoding(7 bytes) = c7 42 08 08 00 00 00
000fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> GetBytesBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x89,0x02,0xC7,0x42,0x08,0x08,0x00,0x00,0x00,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: N3 nat3()
; location: [7FF7C774D680h, 7FF7C774D692h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(4 bytes) = 0f 1f 40 00
0005h mov byte ptr [rsp],0          ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,:sr),0h:imm8]       encoding(4 bytes) = c6 04 24 00
0009h movsx rax,byte ptr [rsp]      ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RSP:br,:sr)]        encoding(5 bytes) = 48 0f be 04 24
000eh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nat3Bytes => new byte[19]{0x50,0x0F,0x1F,0x40,0x00,0xC6,0x04,0x24,0x00,0x48,0x0F,0xBE,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong nat3val()
; location: [7FF7C774D6B0h, 7FF7C774D6BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,3                     ; MOV(Mov_r32_imm32) [EAX,3h:imm32]                    encoding(5 bytes) = b8 03 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nat3valBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int natval()
; location: [7FF7C774DC60h, 7FF7C774DC77h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0003h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0007h lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
000bh mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
000eh mov eax,1Eh                   ; MOV(Mov_r32_imm32) [EAX,1eh:imm32]                   encoding(5 bytes) = b8 1e 00 00 00
0013h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> natvalBytes => new byte[24]{0x50,0x33,0xC0,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC6,0x00,0x00,0xB8,0x1E,0x00,0x00,0x00,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int natseq2()
; location: [7FF7C774E0A0h, 7FF7C774E0AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,25h                   ; MOV(Mov_r32_imm32) [EAX,25h:imm32]                   encoding(5 bytes) = b8 25 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> natseq2Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x25,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int natseq3()
; location: [7FF7C774E0C0h, 7FF7C774E0CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,173h                  ; MOV(Mov_r32_imm32) [EAX,173h:imm32]                  encoding(5 bytes) = b8 73 01 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> natseq3Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x73,0x01,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int natseq4()
; location: [7FF7C774E4F0h, 7FF7C774E4FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,400h                  ; MOV(Mov_r32_imm32) [EAX,400h:imm32]                  encoding(5 bytes) = b8 00 04 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> natseq4Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x04,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int add()
; location: [7FF7C774E510h, 7FF7C774E539h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 10
000bh mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 08
0010h lea rax,[rsp+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 10
0015h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0018h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
001dh mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0020h mov eax,24h                   ; MOV(Mov_r32_imm32) [EAX,24h:imm32]                   encoding(5 bytes) = b8 24 00 00 00
0025h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[42]{0x48,0x83,0xEC,0x18,0x33,0xC0,0x48,0x89,0x44,0x24,0x10,0x48,0x89,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x10,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x08,0xC6,0x00,0x00,0xB8,0x24,0x00,0x00,0x00,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sub()
; location: [7FF7C774E960h, 7FF7C774E989h]
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
; location: [7FF7C774E9A0h, 7FF7C774E9C9h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 10
000bh mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 08
0010h lea rax,[rsp+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 10
0015h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0018h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
001dh mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0020h mov eax,400h                  ; MOV(Mov_r32_imm32) [EAX,400h:imm32]                  encoding(5 bytes) = b8 00 04 00 00
0025h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[42]{0x48,0x83,0xEC,0x18,0x33,0xC0,0x48,0x89,0x44,0x24,0x10,0x48,0x89,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x10,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x08,0xC6,0x00,0x00,0xB8,0x00,0x04,0x00,0x00,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int div()
; location: [7FF7C774E9E0h, 7FF7C774EA09h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 10
000bh mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 08
0010h lea rax,[rsp+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 10
0015h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0018h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
001dh mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0020h mov eax,8                     ; MOV(Mov_r32_imm32) [EAX,8h:imm32]                    encoding(5 bytes) = b8 08 00 00 00
0025h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divBytes => new byte[42]{0x48,0x83,0xEC,0x18,0x33,0xC0,0x48,0x89,0x44,0x24,0x10,0x48,0x89,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x10,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x08,0xC6,0x00,0x00,0xB8,0x08,0x00,0x00,0x00,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int mod()
; location: [7FF7C774EA20h, 7FF7C774EA46h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 10
000bh mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 08
0010h lea rax,[rsp+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 10
0015h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0018h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
001dh mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0020h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0022h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> modBytes => new byte[39]{0x48,0x83,0xEC,0x18,0x33,0xC0,0x48,0x89,0x44,0x24,0x10,0x48,0x89,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x10,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x08,0xC6,0x00,0x00,0x33,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2()
; location: [7FF7C774EA60h, 7FF7C774EA6Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,10000h                ; MOV(Mov_r32_imm32) [EAX,10000h:imm32]                encoding(5 bytes) = b8 00 00 01 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pow2Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x00,0x01,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sll()
; location: [7FF7C774EA80h, 7FF7C774EAA9h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 10
000bh mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 08
0010h lea rax,[rsp+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 10
0015h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0018h lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 44 24 08
001dh mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 00 00
0020h mov eax,20h                   ; MOV(Mov_r32_imm32) [EAX,20h:imm32]                   encoding(5 bytes) = b8 20 00 00 00
0025h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[42]{0x48,0x83,0xEC,0x18,0x33,0xC0,0x48,0x89,0x44,0x24,0x10,0x48,0x89,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x10,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x08,0xC6,0x00,0x00,0xB8,0x20,0x00,0x00,0x00,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong srl()
; location: [7FF7C774EAC0h, 7FF7C774EAE9h]
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
; location: [7FF7C774EB00h, 7FF7C774EB4Bh]
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
0040h mov eax,40004h                ; MOV(Mov_r32_imm32) [EAX,40004h:imm32]                encoding(5 bytes) = b8 04 00 04 00
0045h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0049h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
004ah pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
004bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotr64uBytes => new byte[76]{0x57,0x56,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF1,0x48,0x8D,0x3C,0x24,0xB9,0x0A,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0x48,0x8D,0x44,0x24,0x20,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x18,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x10,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x08,0xC6,0x00,0x00,0x48,0x8D,0x04,0x24,0xC6,0x00,0x00,0xB8,0x04,0x00,0x04,0x00,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte rotr8u_1()
; location: [7FF7C774EF70h, 7FF7C774EFBBh]
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
; location: [7FF7C774EFE0h, 7FF7C774F02Bh]
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
; location: [7FF7C774F050h, 7FF7C774F09Bh]
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
; function: Vector256<uint> ShuffleWithDelegate(Vector256<uint> x)
; location: [7FF7C774F0C0h, 7FF7C774F12Ch]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0007h mov rdi,rdx                   ; MOV(Mov_r64_rm64) [RDI,RDX]                          encoding(3 bytes) = 48 8b fa
000ah mov rsi,r8                    ; MOV(Mov_r64_rm64) [RSI,R8]                           encoding(3 bytes) = 49 8b f0
000dh mov rcx,7FF7C78FCF60h         ; MOV(Mov_r64_imm64) [RCX,7ff7c78fcf60h:imm64]         encoding(10 bytes) = 48 b9 60 cf 8f c7 f7 7f 00 00
0017h call 7FF827266CB0h            ; CALL(Call_rel32_64) [5FB17BF0h:jmp64]                encoding(5 bytes) = e8 d4 7b b1 5f
001ch mov rbx,rax                   ; MOV(Mov_r64_rm64) [RBX,RAX]                          encoding(3 bytes) = 48 8b d8
001fh lea rcx,[rbx+8]               ; LEA(Lea_r64_m) [RCX,mem(Unknown,RBX:br,:sr)]         encoding(4 bytes) = 48 8d 4b 08
0023h mov rdx,rbx                   ; MOV(Mov_r64_rm64) [RDX,RBX]                          encoding(3 bytes) = 48 8b d3
0026h call 7FF827265DF0h            ; CALL(Call_rel32_64) [5FB16D30h:jmp64]                encoding(5 bytes) = e8 05 6d b1 5f
002bh mov rcx,7FF7C760D0A0h         ; MOV(Mov_r64_imm64) [RCX,7ff7c760d0a0h:imm64]         encoding(10 bytes) = 48 b9 a0 d0 60 c7 f7 7f 00 00
0035h mov [rbx+18h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RBX:br,:sr),RCX]          encoding(4 bytes) = 48 89 4b 18
0039h mov rcx,7FF7C773A358h         ; MOV(Mov_r64_imm64) [RCX,7ff7c773a358h:imm64]         encoding(10 bytes) = 48 b9 58 a3 73 c7 f7 7f 00 00
0043h mov [rbx+20h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RBX:br,:sr),RCX]          encoding(4 bytes) = 48 89 4b 20
0047h mov rcx,rbx                   ; MOV(Mov_r64_rm64) [RCX,RBX]                          encoding(3 bytes) = 48 8b cb
004ah call 7FF7C7745EC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFF6E00h:jmp64]        encoding(5 bytes) = e8 b1 6d ff ff
004fh mov rcx,[rbx+8]               ; MOV(Mov_r64_rm64) [RCX,mem(64u,RBX:br,:sr)]          encoding(4 bytes) = 48 8b 4b 08
0053h mov rdx,rdi                   ; MOV(Mov_r64_rm64) [RDX,RDI]                          encoding(3 bytes) = 48 8b d7
0056h mov r8,rsi                    ; MOV(Mov_r64_rm64) [R8,RSI]                           encoding(3 bytes) = 4c 8b c6
0059h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
005fh call qword ptr [rbx+18h]      ; CALL(Call_rm64) [mem(QwordOffset,RBX:br,:sr)]        encoding(3 bytes) = ff 53 18
0062h mov rax,rdi                   ; MOV(Mov_r64_rm64) [RAX,RDI]                          encoding(3 bytes) = 48 8b c7
0065h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0069h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
006ah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
006bh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
006ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ShuffleWithDelegateBytes => new byte[109]{0x57,0x56,0x53,0x48,0x83,0xEC,0x20,0x48,0x8B,0xFA,0x49,0x8B,0xF0,0x48,0xB9,0x60,0xCF,0x8F,0xC7,0xF7,0x7F,0x00,0x00,0xE8,0xD4,0x7B,0xB1,0x5F,0x48,0x8B,0xD8,0x48,0x8D,0x4B,0x08,0x48,0x8B,0xD3,0xE8,0x05,0x6D,0xB1,0x5F,0x48,0xB9,0xA0,0xD0,0x60,0xC7,0xF7,0x7F,0x00,0x00,0x48,0x89,0x4B,0x18,0x48,0xB9,0x58,0xA3,0x73,0xC7,0xF7,0x7F,0x00,0x00,0x48,0x89,0x4B,0x20,0x48,0x8B,0xCB,0xE8,0xB1,0x6D,0xFF,0xFF,0x48,0x8B,0x4B,0x08,0x48,0x8B,0xD7,0x4C,0x8B,0xC6,0x41,0xB9,0x01,0x00,0x00,0x00,0xFF,0x53,0x18,0x48,0x8B,0xC7,0x48,0x83,0xC4,0x20,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> ShuffleWithReflection()
; location: [7FF7C774F550h, 7FF7C774F73Ah]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0003h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0004h sub rsp,68h                   ; SUB(Sub_rm64_imm8) [RSP,68h:imm64]                   encoding(4 bytes) = 48 83 ec 68
0008h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000bh mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000eh lea rdi,[rsp+40h]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 7c 24 40
0013h mov ecx,0Ah                   ; MOV(Mov_r32_imm32) [ECX,ah:imm32]                    encoding(5 bytes) = b9 0a 00 00 00
0018h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
001ah rep stosd                     ; STOSD(Stosd_m32_EAX) [mem(32u),EAX]                  encoding(2 bytes) = f3 ab
001ch mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
001fh mov rax,3D70F822530Ah         ; MOV(Mov_r64_imm64) [RAX,3d70f822530ah:imm64]         encoding(10 bytes) = 48 b8 0a 53 22 f8 70 3d 00 00
0029h mov [rsp+60h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(5 bytes) = 48 89 44 24 60
002eh mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0031h lea rdi,[rsp+40h]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 7c 24 40
0036h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0038h mov [rdi],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RDI:br,:sr),ECX]          encoding(2 bytes) = 89 0f
003ah mov dword ptr [rdi+4],1       ; MOV(Mov_rm32_imm32) [mem(32u,RDI:br,:sr),1h:imm32]   encoding(7 bytes) = c7 47 04 01 00 00 00
0041h mov dword ptr [rdi+8],2       ; MOV(Mov_rm32_imm32) [mem(32u,RDI:br,:sr),2h:imm32]   encoding(7 bytes) = c7 47 08 02 00 00 00
0048h mov dword ptr [rdi+0Ch],3     ; MOV(Mov_rm32_imm32) [mem(32u,RDI:br,:sr),3h:imm32]   encoding(7 bytes) = c7 47 0c 03 00 00 00
004fh mov dword ptr [rdi+10h],4     ; MOV(Mov_rm32_imm32) [mem(32u,RDI:br,:sr),4h:imm32]   encoding(7 bytes) = c7 47 10 04 00 00 00
0056h mov dword ptr [rdi+14h],5     ; MOV(Mov_rm32_imm32) [mem(32u,RDI:br,:sr),5h:imm32]   encoding(7 bytes) = c7 47 14 05 00 00 00
005dh mov dword ptr [rdi+18h],6     ; MOV(Mov_rm32_imm32) [mem(32u,RDI:br,:sr),6h:imm32]   encoding(7 bytes) = c7 47 18 06 00 00 00
0064h mov dword ptr [rdi+1Ch],7     ; MOV(Mov_rm32_imm32) [mem(32u,RDI:br,:sr),7h:imm32]   encoding(7 bytes) = c7 47 1c 07 00 00 00
006bh mov ecx,8                     ; MOV(Mov_r32_imm32) [ECX,8h:imm32]                    encoding(5 bytes) = b9 08 00 00 00
0070h cmp ecx,0                     ; CMP(Cmp_rm32_imm8) [ECX,0h:imm32]                    encoding(3 bytes) = 83 f9 00
0073h jbe near ptr 01e5h            ; JBE(Jbe_rel32_64) [1E5h:jmp64]                       encoding(6 bytes) = 0f 86 6c 01 00 00
0079h mov rcx,7FF7C77D2798h         ; MOV(Mov_r64_imm64) [RCX,7ff7c77d2798h:imm64]         encoding(10 bytes) = 48 b9 98 27 7d c7 f7 7f 00 00
0083h call 7FF82720EFF0h            ; CALL(Call_rel32_64) [5FABFAA0h:jmp64]                encoding(5 bytes) = e8 18 fa ab 5f
0088h mov rbx,rax                   ; MOV(Mov_r64_rm64) [RBX,RAX]                          encoding(3 bytes) = 48 8b d8
008bh mov rcx,7FF7C77C7788h         ; MOV(Mov_r64_imm64) [RCX,7ff7c77c7788h:imm64]         encoding(10 bytes) = 48 b9 88 77 7c c7 f7 7f 00 00
0095h mov edx,2                     ; MOV(Mov_r32_imm32) [EDX,2h:imm32]                    encoding(5 bytes) = ba 02 00 00 00
009ah call 7FF827266E40h            ; CALL(Call_rel32_64) [5FB178F0h:jmp64]                encoding(5 bytes) = e8 51 78 b1 5f
009fh mov rbp,rax                   ; MOV(Mov_r64_rm64) [RBP,RAX]                          encoding(3 bytes) = 48 8b e8
00a2h mov rcx,7FF7C78FCB80h         ; MOV(Mov_r64_imm64) [RCX,7ff7c78fcb80h:imm64]         encoding(10 bytes) = 48 b9 80 cb 8f c7 f7 7f 00 00
00ach call 7FF82720EFF0h            ; CALL(Call_rel32_64) [5FABFAA0h:jmp64]                encoding(5 bytes) = e8 ef f9 ab 5f
00b1h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
00b4h mov rcx,rbp                   ; MOV(Mov_r64_rm64) [RCX,RBP]                          encoding(3 bytes) = 48 8b cd
00b7h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
00b9h call 7FF827265F10h            ; CALL(Call_rel32_64) [5FB169C0h:jmp64]                encoding(5 bytes) = e8 02 69 b1 5f
00beh mov rcx,7FF7C7707758h         ; MOV(Mov_r64_imm64) [RCX,7ff7c7707758h:imm64]         encoding(10 bytes) = 48 b9 58 77 70 c7 f7 7f 00 00
00c8h call 7FF82720EFF0h            ; CALL(Call_rel32_64) [5FABFAA0h:jmp64]                encoding(5 bytes) = e8 d3 f9 ab 5f
00cdh mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
00d0h mov rcx,rbp                   ; MOV(Mov_r64_rm64) [RCX,RBP]                          encoding(3 bytes) = 48 8b cd
00d3h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
00d8h call 7FF827265F10h            ; CALL(Call_rel32_64) [5FB169C0h:jmp64]                encoding(5 bytes) = e8 e3 68 b1 5f
00ddh mov dword ptr [rsp+20h],3     ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3h:imm32]   encoding(8 bytes) = c7 44 24 20 03 00 00 00
00e5h mov [rsp+28h],rbp             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RBP]          encoding(5 bytes) = 48 89 6c 24 28
00eah xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
00ech mov [rsp+30h],rdx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RDX]          encoding(5 bytes) = 48 89 54 24 30
00f1h mov rdx,221426430D0h          ; MOV(Mov_r64_imm64) [RDX,221426430d0h:imm64]          encoding(10 bytes) = 48 ba d0 30 64 42 21 02 00 00
00fbh mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 12
00feh mov rcx,rbx                   ; MOV(Mov_r64_rm64) [RCX,RBX]                          encoding(3 bytes) = 48 8b cb
0101h mov r8d,1Ch                   ; MOV(Mov_r32_imm32) [R8D,1ch:imm32]                   encoding(6 bytes) = 41 b8 1c 00 00 00
0107h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
010ah call 7FF7C7730E78h            ; CALL(Call_rel32_64) [FFFFFFFFFFFE1928h:jmp64]        encoding(5 bytes) = e8 19 18 fe ff
010fh mov rbx,rax                   ; MOV(Mov_r64_rm64) [RBX,RAX]                          encoding(3 bytes) = 48 8b d8
0112h mov rcx,7FF7C77052C0h         ; MOV(Mov_r64_imm64) [RCX,7ff7c77052c0h:imm64]         encoding(10 bytes) = 48 b9 c0 52 70 c7 f7 7f 00 00
011ch mov edx,2                     ; MOV(Mov_r32_imm32) [EDX,2h:imm32]                    encoding(5 bytes) = ba 02 00 00 00
0121h call 7FF827266E40h            ; CALL(Call_rel32_64) [5FB178F0h:jmp64]                encoding(5 bytes) = e8 ca 77 b1 5f
0126h mov rbp,rax                   ; MOV(Mov_r64_rm64) [RBP,RAX]                          encoding(3 bytes) = 48 8b e8
0129h mov rcx,7FF7C78FCB80h         ; MOV(Mov_r64_imm64) [RCX,7ff7c78fcb80h:imm64]         encoding(10 bytes) = 48 b9 80 cb 8f c7 f7 7f 00 00
0133h call 7FF827266CB0h            ; CALL(Call_rel32_64) [5FB17760h:jmp64]                encoding(5 bytes) = e8 28 76 b1 5f
0138h vmovdqu ymm0,ymmword ptr [rdi]; VMOVDQU(VEX_Vmovdqu_ymm_ymmm256) [YMM0,mem(Packed256_Int32,RDI:br,:sr)] encoding(VEX, 4 bytes) = c5 fe 6f 07
013ch vmovupd [rax+8],ymm0          ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RAX:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 40 08
0141h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0144h mov rcx,rbp                   ; MOV(Mov_r64_rm64) [RCX,RBP]                          encoding(3 bytes) = 48 8b cd
0147h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0149h call 7FF827265F10h            ; CALL(Call_rel32_64) [5FB169C0h:jmp64]                encoding(5 bytes) = e8 72 68 b1 5f
014eh mov rcx,7FF7C7707758h         ; MOV(Mov_r64_imm64) [RCX,7ff7c7707758h:imm64]         encoding(10 bytes) = 48 b9 58 77 70 c7 f7 7f 00 00
0158h call 7FF827266CB0h            ; CALL(Call_rel32_64) [5FB17760h:jmp64]                encoding(5 bytes) = e8 03 76 b1 5f
015dh mov byte ptr [rax+8],1        ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),1h:imm8]       encoding(4 bytes) = c6 40 08 01
0161h mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
0164h mov rcx,rbp                   ; MOV(Mov_r64_rm64) [RCX,RBP]                          encoding(3 bytes) = 48 8b cd
0167h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
016ch call 7FF827265F10h            ; CALL(Call_rel32_64) [5FB169C0h:jmp64]                encoding(5 bytes) = e8 4f 68 b1 5f
0171h mov [rsp+20h],rbp             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RBP]          encoding(5 bytes) = 48 89 6c 24 20
0176h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0178h mov [rsp+28h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RCX]          encoding(5 bytes) = 48 89 4c 24 28
017dh mov rcx,rbx                   ; MOV(Mov_r64_rm64) [RCX,RBX]                          encoding(3 bytes) = 48 8b cb
0180h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0182h xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0185h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
0188h mov rax,[rbx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RBX:br,:sr)]          encoding(3 bytes) = 48 8b 03
018bh mov rax,[rax+58h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(4 bytes) = 48 8b 40 58
018fh call qword ptr [rax+38h]      ; CALL(Call_rm64) [mem(QwordOffset,RAX:br,:sr)]        encoding(3 bytes) = ff 50 38
0192h mov rdi,rax                   ; MOV(Mov_r64_rm64) [RDI,RAX]                          encoding(3 bytes) = 48 8b f8
0195h mov rdx,7FF7C78FCB80h         ; MOV(Mov_r64_imm64) [RDX,7ff7c78fcb80h:imm64]         encoding(10 bytes) = 48 ba 80 cb 8f c7 f7 7f 00 00
019fh cmp [rdi],rdx                 ; CMP(Cmp_rm64_r64) [mem(64u,RDI:br,:sr),RDX]          encoding(3 bytes) = 48 39 17
01a2h je short 01b6h                ; JE(Je_rel8_64) [1B6h:jmp64]                          encoding(2 bytes) = 74 12
01a4h mov rdx,rdi                   ; MOV(Mov_r64_rm64) [RDX,RDI]                          encoding(3 bytes) = 48 8b d7
01a7h mov rcx,7FF7C78FCB80h         ; MOV(Mov_r64_imm64) [RCX,7ff7c78fcb80h:imm64]         encoding(10 bytes) = 48 b9 80 cb 8f c7 f7 7f 00 00
01b1h call 7FF827233360h            ; CALL(Call_rel32_64) [5FAE3E10h:jmp64]                encoding(5 bytes) = e8 5a 3c ae 5f
01b6h vmovupd ymm0,[rdi+8]          ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDI:br,:sr)] encoding(VEX, 5 bytes) = c5 fd 10 47 08
01bbh vmovupd [rsi],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSI:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 06
01bfh mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
01c2h mov rcx,3D70F822530Ah         ; MOV(Mov_r64_imm64) [RCX,3d70f822530ah:imm64]         encoding(10 bytes) = 48 b9 0a 53 22 f8 70 3d 00 00
01cch cmp [rsp+60h],rcx             ; CMP(Cmp_rm64_r64) [mem(64u,RSP:br,:sr),RCX]          encoding(5 bytes) = 48 39 4c 24 60
01d1h je short 01d8h                ; JE(Je_rel8_64) [1D8h:jmp64]                          encoding(2 bytes) = 74 05
01d3h call 7FF827391650h            ; CALL(Call_rel32_64) [5FC42100h:jmp64]                encoding(5 bytes) = e8 28 1f c4 5f
01d8h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
01d9h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
01dch add rsp,68h                   ; ADD(Add_rm64_imm8) [RSP,68h:imm64]                   encoding(4 bytes) = 48 83 c4 68
01e0h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
01e1h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
01e2h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
01e3h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
01e4h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
01e5h call 7FF82738FDD0h            ; CALL(Call_rel32_64) [5FC40880h:jmp64]                encoding(5 bytes) = e8 96 06 c4 5f
01eah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> ShuffleWithReflectionBytes => new byte[491]{0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x68,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0x48,0x8D,0x7C,0x24,0x40,0xB9,0x0A,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0x48,0xB8,0x0A,0x53,0x22,0xF8,0x70,0x3D,0x00,0x00,0x48,0x89,0x44,0x24,0x60,0x48,0x8B,0xF2,0x48,0x8D,0x7C,0x24,0x40,0x33,0xC9,0x89,0x0F,0xC7,0x47,0x04,0x01,0x00,0x00,0x00,0xC7,0x47,0x08,0x02,0x00,0x00,0x00,0xC7,0x47,0x0C,0x03,0x00,0x00,0x00,0xC7,0x47,0x10,0x04,0x00,0x00,0x00,0xC7,0x47,0x14,0x05,0x00,0x00,0x00,0xC7,0x47,0x18,0x06,0x00,0x00,0x00,0xC7,0x47,0x1C,0x07,0x00,0x00,0x00,0xB9,0x08,0x00,0x00,0x00,0x83,0xF9,0x00,0x0F,0x86,0x6C,0x01,0x00,0x00,0x48,0xB9,0x98,0x27,0x7D,0xC7,0xF7,0x7F,0x00,0x00,0xE8,0x18,0xFA,0xAB,0x5F,0x48,0x8B,0xD8,0x48,0xB9,0x88,0x77,0x7C,0xC7,0xF7,0x7F,0x00,0x00,0xBA,0x02,0x00,0x00,0x00,0xE8,0x51,0x78,0xB1,0x5F,0x48,0x8B,0xE8,0x48,0xB9,0x80,0xCB,0x8F,0xC7,0xF7,0x7F,0x00,0x00,0xE8,0xEF,0xF9,0xAB,0x5F,0x4C,0x8B,0xC0,0x48,0x8B,0xCD,0x33,0xD2,0xE8,0x02,0x69,0xB1,0x5F,0x48,0xB9,0x58,0x77,0x70,0xC7,0xF7,0x7F,0x00,0x00,0xE8,0xD3,0xF9,0xAB,0x5F,0x4C,0x8B,0xC0,0x48,0x8B,0xCD,0xBA,0x01,0x00,0x00,0x00,0xE8,0xE3,0x68,0xB1,0x5F,0xC7,0x44,0x24,0x20,0x03,0x00,0x00,0x00,0x48,0x89,0x6C,0x24,0x28,0x33,0xD2,0x48,0x89,0x54,0x24,0x30,0x48,0xBA,0xD0,0x30,0x64,0x42,0x21,0x02,0x00,0x00,0x48,0x8B,0x12,0x48,0x8B,0xCB,0x41,0xB8,0x1C,0x00,0x00,0x00,0x45,0x33,0xC9,0xE8,0x19,0x18,0xFE,0xFF,0x48,0x8B,0xD8,0x48,0xB9,0xC0,0x52,0x70,0xC7,0xF7,0x7F,0x00,0x00,0xBA,0x02,0x00,0x00,0x00,0xE8,0xCA,0x77,0xB1,0x5F,0x48,0x8B,0xE8,0x48,0xB9,0x80,0xCB,0x8F,0xC7,0xF7,0x7F,0x00,0x00,0xE8,0x28,0x76,0xB1,0x5F,0xC5,0xFE,0x6F,0x07,0xC5,0xFD,0x11,0x40,0x08,0x4C,0x8B,0xC0,0x48,0x8B,0xCD,0x33,0xD2,0xE8,0x72,0x68,0xB1,0x5F,0x48,0xB9,0x58,0x77,0x70,0xC7,0xF7,0x7F,0x00,0x00,0xE8,0x03,0x76,0xB1,0x5F,0xC6,0x40,0x08,0x01,0x4C,0x8B,0xC0,0x48,0x8B,0xCD,0xBA,0x01,0x00,0x00,0x00,0xE8,0x4F,0x68,0xB1,0x5F,0x48,0x89,0x6C,0x24,0x20,0x33,0xC9,0x48,0x89,0x4C,0x24,0x28,0x48,0x8B,0xCB,0x33,0xD2,0x45,0x33,0xC0,0x45,0x33,0xC9,0x48,0x8B,0x03,0x48,0x8B,0x40,0x58,0xFF,0x50,0x38,0x48,0x8B,0xF8,0x48,0xBA,0x80,0xCB,0x8F,0xC7,0xF7,0x7F,0x00,0x00,0x48,0x39,0x17,0x74,0x12,0x48,0x8B,0xD7,0x48,0xB9,0x80,0xCB,0x8F,0xC7,0xF7,0x7F,0x00,0x00,0xE8,0x5A,0x3C,0xAE,0x5F,0xC5,0xFD,0x10,0x47,0x08,0xC5,0xFD,0x11,0x06,0x48,0x8B,0xC6,0x48,0xB9,0x0A,0x53,0x22,0xF8,0x70,0x3D,0x00,0x00,0x48,0x39,0x4C,0x24,0x60,0x74,0x05,0xE8,0x28,0x1F,0xC4,0x5F,0x90,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x68,0x5B,0x5D,0x5E,0x5F,0xC3,0xE8,0x96,0x06,0xC4,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int Switch14(int x)
; location: [7FF7C774F760h, 7FF7C774F830h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h lea ecx,[rdx-1]               ; LEA(Lea_r32_m) [ECX,mem(Unknown,RDX:br,:sr)]         encoding(3 bytes) = 8d 4a ff
0008h cmp ecx,0Dh                   ; CMP(Cmp_rm32_imm8) [ECX,dh:imm32]                    encoding(3 bytes) = 83 f9 0d
000bh ja short 0025h                ; JA(Ja_rel8_64) [25h:jmp64]                           encoding(2 bytes) = 77 18
000dh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000fh lea rdx,[7FF7C774F838h]       ; LEA(Lea_r64_m) [RDX,mem(Unknown,RIP:br,:sr)]         encoding(7 bytes) = 48 8d 15 c2 00 00 00
0016h mov edx,[rdx+rax*4]           ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 14 82
0019h lea rcx,[7FF7C774F765h]       ; LEA(Lea_r64_m) [RCX,mem(Unknown,RIP:br,:sr)]         encoding(7 bytes) = 48 8d 0d e5 ff ff ff
0020h add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
0023h jmp rdx                       ; JMP(Jmp_rm64) [RDX]                                  encoding(2 bytes) = ff e2
0025h add edx,0FFFFE4A8h            ; ADD(Add_rm32_imm32) [EDX,ffffe4a8h:imm32]            encoding(6 bytes) = 81 c2 a8 e4 ff ff
002bh cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
002eh ja near ptr 00ceh             ; JA(Ja_rel32_64) [CEh:jmp64]                          encoding(6 bytes) = 0f 87 9a 00 00 00
0034h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0036h lea rdx,[7FF7C774F870h]       ; LEA(Lea_r64_m) [RDX,mem(Unknown,RIP:br,:sr)]         encoding(7 bytes) = 48 8d 15 d3 00 00 00
003dh mov edx,[rdx+rax*4]           ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 14 82
0040h lea rcx,[7FF7C774F765h]       ; LEA(Lea_r64_m) [RCX,mem(Unknown,RIP:br,:sr)]         encoding(7 bytes) = 48 8d 0d be ff ff ff
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
; location: [7FF7C774F8A0h, 7FF7C774F91Ch]
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
; location: [7FF7C774F930h, 7FF7C774F94Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,2213249C1A5h          ; MOV(Mov_r64_imm64) [RAX,2213249c1a5h:imm64]          encoding(10 bytes) = 48 b8 a5 c1 49 32 21 02 00 00
000fh mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
0012h mov dword ptr [rcx+8],40h     ; MOV(Mov_rm32_imm32) [mem(32u,RCX:br,:sr),40h:imm32]  encoding(7 bytes) = c7 41 08 40 00 00 00
0019h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> get_U8DataBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xA5,0xC1,0x49,0x32,0x21,0x02,0x00,0x00,0x48,0x89,0x01,0xC7,0x41,0x08,0x40,0x00,0x00,0x00,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<uint> get_U32Data()
; location: [7FF7C774FD70h, 7FF7C774FDDAh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000bh mov rcx,7FF7C78FF288h         ; MOV(Mov_r64_imm64) [RCX,7ff7c78ff288h:imm64]         encoding(10 bytes) = 48 b9 88 f2 8f c7 f7 7f 00 00
0015h mov edx,10h                   ; MOV(Mov_r32_imm32) [EDX,10h:imm32]                   encoding(5 bytes) = ba 10 00 00 00
001ah call 7FF827266DE0h            ; CALL(Call_rel32_64) [5FB17070h:jmp64]                encoding(5 bytes) = e8 51 70 b1 5f
001fh mov rdx,2213249C1E5h          ; MOV(Mov_r64_imm64) [RDX,2213249c1e5h:imm64]          encoding(10 bytes) = 48 ba e5 c1 49 32 21 02 00 00
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
; static ReadOnlySpan<byte> get_U32DataBytes => new byte[107]{0x56,0x48,0x83,0xEC,0x20,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0x48,0xB9,0x88,0xF2,0x8F,0xC7,0xF7,0x7F,0x00,0x00,0xBA,0x10,0x00,0x00,0x00,0xE8,0x51,0x70,0xB1,0x5F,0x48,0xBA,0xE5,0xC1,0x49,0x32,0x21,0x02,0x00,0x00,0x48,0x8D,0x48,0x10,0xC5,0xFA,0x6F,0x02,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x6F,0x42,0x10,0xC5,0xFA,0x7F,0x41,0x10,0xC5,0xFA,0x6F,0x42,0x20,0xC5,0xFA,0x7F,0x41,0x20,0xC5,0xFA,0x6F,0x42,0x30,0xC5,0xFA,0x7F,0x41,0x30,0x48,0x83,0xC0,0x10,0xBA,0x10,0x00,0x00,0x00,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint Or8Inline(uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7)
; location: [7FF7C774FE00h, 7FF7C774FE1Fh]
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
; location: [7FF7C774FE30h, 7FF7C774FE3Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h rol eax,cl                    ; ROL(Rol_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> RotLU32InlineBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int ChoiceIfElse5Inline(int x)
; location: [7FF7C774FE50h, 7FF7C774FE90h]
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
; location: [7FF7C77502B0h, 7FF7C77502BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,3FFh                  ; MOV(Mov_r32_imm32) [EAX,3ffh:imm32]                  encoding(5 bytes) = b8 ff 03 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> CheckMatchesBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0x03,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> ReadU8Data(int count)
; location: [7FF7C77502D0h, 7FF7C77502ECh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,2213249C1A5h          ; MOV(Mov_r64_imm64) [RAX,2213249c1a5h:imm64]          encoding(10 bytes) = 48 b8 a5 c1 49 32 21 02 00 00
000fh mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
0012h mov dword ptr [rdx+8],40h     ; MOV(Mov_rm32_imm32) [mem(32u,RDX:br,:sr),40h:imm32]  encoding(7 bytes) = c7 42 08 40 00 00 00
0019h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ReadU8DataBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xA5,0xC1,0x49,0x32,0x21,0x02,0x00,0x00,0x48,0x89,0x02,0xC7,0x42,0x08,0x40,0x00,0x00,0x00,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<uint> ReadU32Data(int count)
; location: [7FF7C7750300h, 7FF7C7750312h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
0008h mov rax,7FF7C774FD70h         ; MOV(Mov_r64_imm64) [RAX,7ff7c774fd70h:imm64]         encoding(10 bytes) = 48 b8 70 fd 74 c7 f7 7f 00 00
0012h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> ReadU32DataBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xCA,0x48,0xB8,0x70,0xFD,0x74,0xC7,0xF7,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void VoidReturn()
; location: [7FF7C77506A0h, 7FF7C77506BCh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rcx,22142643060h          ; MOV(Mov_r64_imm64) [RCX,22142643060h:imm64]          encoding(10 bytes) = 48 b9 60 30 64 42 21 02 00 00
000fh mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 09
0012h call 7FF7C7750670h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFFD0h:jmp64]        encoding(5 bytes) = e8 b9 ff ff ff
0017h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0018h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> VoidReturnBytes => new byte[29]{0x48,0x83,0xEC,0x28,0x90,0x48,0xB9,0x60,0x30,0x64,0x42,0x21,0x02,0x00,0x00,0x48,0x8B,0x09,0xE8,0xB9,0xFF,0xFF,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int SizeTest()
; location: [7FF7C77506E0h, 7FF7C77506EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,7                     ; MOV(Mov_r32_imm32) [EAX,7h:imm32]                    encoding(5 bytes) = b8 07 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> SizeTestBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x07,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void VoidCalls1()
; location: [7FF7C7750700h, 7FF7C775070Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FF7C77506A0h         ; MOV(Mov_r64_imm64) [RAX,7ff7c77506a0h:imm64]         encoding(10 bytes) = 48 b8 a0 06 75 c7 f7 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> VoidCalls1Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xA0,0x06,0x75,0xC7,0xF7,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void VoidCalls2()
; location: [7FF7C7750730h, 7FF7C7750752h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
000bh call 7FF7C77506A0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFF70h:jmp64]        encoding(5 bytes) = e8 60 ff ff ff
0010h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0013h mov rax,7FF7C77506A0h         ; MOV(Mov_r64_imm64) [RAX,7ff7c77506a0h:imm64]         encoding(10 bytes) = 48 b8 a0 06 75 c7 f7 7f 00 00
001dh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0021h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0022h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> VoidCalls2Bytes => new byte[37]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0xCE,0xE8,0x60,0xFF,0xFF,0xFF,0x48,0x8B,0xCE,0x48,0xB8,0xA0,0x06,0x75,0xC7,0xF7,0x7F,0x00,0x00,0x48,0x83,0xC4,0x20,0x5E,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void VoidCalls3()
; location: [7FF7C7750770h, 7FF7C775079Ah]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
000bh call 7FF7C77506A0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFF30h:jmp64]        encoding(5 bytes) = e8 20 ff ff ff
0010h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0013h call 7FF7C77506A0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFF30h:jmp64]        encoding(5 bytes) = e8 18 ff ff ff
0018h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
001bh mov rax,7FF7C77506A0h         ; MOV(Mov_r64_imm64) [RAX,7ff7c77506a0h:imm64]         encoding(10 bytes) = 48 b8 a0 06 75 c7 f7 7f 00 00
0025h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0029h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
002ah jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> VoidCalls3Bytes => new byte[45]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0xCE,0xE8,0x20,0xFF,0xFF,0xFF,0x48,0x8B,0xCE,0xE8,0x18,0xFF,0xFF,0xFF,0x48,0x8B,0xCE,0x48,0xB8,0xA0,0x06,0x75,0xC7,0xF7,0x7F,0x00,0x00,0x48,0x83,0xC4,0x20,0x5E,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void VoidCalls4()
; location: [7FF7C77507C0h, 7FF7C77507F2h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
000bh call 7FF7C77506A0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFEE0h:jmp64]        encoding(5 bytes) = e8 d0 fe ff ff
0010h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0013h call 7FF7C77506A0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFEE0h:jmp64]        encoding(5 bytes) = e8 c8 fe ff ff
0018h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
001bh call 7FF7C77506A0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFEE0h:jmp64]        encoding(5 bytes) = e8 c0 fe ff ff
0020h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0023h mov rax,7FF7C77506A0h         ; MOV(Mov_r64_imm64) [RAX,7ff7c77506a0h:imm64]         encoding(10 bytes) = 48 b8 a0 06 75 c7 f7 7f 00 00
002dh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0031h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0032h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> VoidCalls4Bytes => new byte[53]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0xCE,0xE8,0xD0,0xFE,0xFF,0xFF,0x48,0x8B,0xCE,0xE8,0xC8,0xFE,0xFF,0xFF,0x48,0x8B,0xCE,0xE8,0xC0,0xFE,0xFF,0xFF,0x48,0x8B,0xCE,0x48,0xB8,0xA0,0x06,0x75,0xC7,0xF7,0x7F,0x00,0x00,0x48,0x83,0xC4,0x20,0x5E,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int InvokeBinOp(Func<int,int,int> f, int x, int y)
; location: [7FF7C7750810h, 7FF7C775082Fh]
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
; location: [7FF7C7750850h, 7FF7C7750860h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+rdx]             ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,:sr)]         encoding(3 bytes) = 8d 04 11
0008h imul ecx,eax                  ; IMUL(Imul_r32_rm32) [ECX,EAX]                        encoding(3 bytes) = 0f af c8
000bh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000eh add eax,ecx                   ; ADD(Add_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 03 c1
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> AddMulInlineBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x04,0x11,0x0F,0xAF,0xC8,0x0F,0xAF,0xC2,0x03,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int CallInvokeBinOp(int x, int y)
; location: [7FF7C7750880h, 7FF7C77508E8h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0003h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0004h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000bh mov edi,edx                   ; MOV(Mov_r32_rm32) [EDI,EDX]                          encoding(2 bytes) = 8b fa
000dh mov ebx,r8d                   ; MOV(Mov_r32_rm32) [EBX,R8D]                          encoding(3 bytes) = 41 8b d8
0010h mov rcx,7FF7C79135D8h         ; MOV(Mov_r64_imm64) [RCX,7ff7c79135d8h:imm64]         encoding(10 bytes) = 48 b9 d8 35 91 c7 f7 7f 00 00
001ah call 7FF827266CB0h            ; CALL(Call_rel32_64) [5FB16430h:jmp64]                encoding(5 bytes) = e8 11 64 b1 5f
001fh mov rbp,rax                   ; MOV(Mov_r64_rm64) [RBP,RAX]                          encoding(3 bytes) = 48 8b e8
0022h lea rcx,[rbp+8]               ; LEA(Lea_r64_m) [RCX,mem(Unknown,RBP:br,:sr)]         encoding(4 bytes) = 48 8d 4d 08
0026h mov rdx,rbp                   ; MOV(Mov_r64_rm64) [RDX,RBP]                          encoding(3 bytes) = 48 8b d5
0029h call 7FF827265DF0h            ; CALL(Call_rel32_64) [5FB15570h:jmp64]                encoding(5 bytes) = e8 42 55 b1 5f
002eh mov rcx,7FF7C760D0E0h         ; MOV(Mov_r64_imm64) [RCX,7ff7c760d0e0h:imm64]         encoding(10 bytes) = 48 b9 e0 d0 60 c7 f7 7f 00 00
0038h mov [rbp+18h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RBP:br,:sr),RCX]          encoding(4 bytes) = 48 89 4d 18
003ch mov rcx,7FF7C7750850h         ; MOV(Mov_r64_imm64) [RCX,7ff7c7750850h:imm64]         encoding(10 bytes) = 48 b9 50 08 75 c7 f7 7f 00 00
0046h mov [rbp+20h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RBP:br,:sr),RCX]          encoding(4 bytes) = 48 89 4d 20
004ah mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
004dh mov rdx,rbp                   ; MOV(Mov_r64_rm64) [RDX,RBP]                          encoding(3 bytes) = 48 8b d5
0050h mov r8d,edi                   ; MOV(Mov_r32_rm32) [R8D,EDI]                          encoding(3 bytes) = 44 8b c7
0053h mov r9d,ebx                   ; MOV(Mov_r32_rm32) [R9D,EBX]                          encoding(3 bytes) = 44 8b cb
0056h mov rax,7FF7C7750810h         ; MOV(Mov_r64_imm64) [RAX,7ff7c7750810h:imm64]         encoding(10 bytes) = 48 b8 10 08 75 c7 f7 7f 00 00
0060h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0064h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0065h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
0066h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0067h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0068h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> CallInvokeBinOpBytes => new byte[107]{0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF1,0x8B,0xFA,0x41,0x8B,0xD8,0x48,0xB9,0xD8,0x35,0x91,0xC7,0xF7,0x7F,0x00,0x00,0xE8,0x11,0x64,0xB1,0x5F,0x48,0x8B,0xE8,0x48,0x8D,0x4D,0x08,0x48,0x8B,0xD5,0xE8,0x42,0x55,0xB1,0x5F,0x48,0xB9,0xE0,0xD0,0x60,0xC7,0xF7,0x7F,0x00,0x00,0x48,0x89,0x4D,0x18,0x48,0xB9,0x50,0x08,0x75,0xC7,0xF7,0x7F,0x00,0x00,0x48,0x89,0x4D,0x20,0x48,0x8B,0xCE,0x48,0x8B,0xD5,0x44,0x8B,0xC7,0x44,0x8B,0xCB,0x48,0xB8,0x10,0x08,0x75,0xC7,0xF7,0x7F,0x00,0x00,0x48,0x83,0xC4,0x28,0x5B,0x5D,0x5E,0x5F,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int And(int a, int b)
; location: [7FF7C7750910h, 7FF7C7750919h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> AndBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int Or(int a, int b)
; location: [7FF7C7750930h, 7FF7C7750939h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> OrBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int Xor(int a, int b)
; location: [7FF7C7750950h, 7FF7C7750959h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> XorBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int Nand(int a, int b)
; location: [7FF7C7750970h, 7FF7C775097Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> NandBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int Jump(int target, int a, int b)
; location: [7FF7C7750990h, 7FF7C77509BDh]
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
; location: [7FF7C77509D0h, 7FF7C77509DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,7                     ; MOV(Mov_r32_imm32) [EAX,7h:imm32]                    encoding(5 bytes) = b8 07 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> JumpBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x07,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int Mul(int a, int b)
; location: [7FF7C77527E0h, 7FF7C7752815h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h mov esi,ecx                   ; MOV(Mov_r32_rm32) [ESI,ECX]                          encoding(2 bytes) = 8b f1
0008h mov edi,edx                   ; MOV(Mov_r32_rm32) [EDI,EDX]                          encoding(2 bytes) = 8b fa
000ah mov rcx,7FF7C77D6C20h         ; MOV(Mov_r64_imm64) [RCX,7ff7c77d6c20h:imm64]         encoding(10 bytes) = 48 b9 20 6c 7d c7 f7 7f 00 00
0014h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0016h call 7FF827231BA0h            ; CALL(Call_rel32_64) [5FADF3C0h:jmp64]                encoding(5 bytes) = e8 a5 f3 ad 5f
001bh mov rax,22142642D38h          ; MOV(Mov_r64_imm64) [RAX,22142642d38h:imm64]          encoding(10 bytes) = 48 b8 38 2d 64 42 21 02 00 00
0025h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 00
0028h mov eax,[rax]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,:sr)]          encoding(2 bytes) = 8b 00
002ah imul esi,edi                  ; IMUL(Imul_r32_rm32) [ESI,EDI]                        encoding(3 bytes) = 0f af f7
002dh mov eax,esi                   ; MOV(Mov_r32_rm32) [EAX,ESI]                          encoding(2 bytes) = 8b c6
002fh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0033h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0034h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0035h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> MulBytes => new byte[54]{0x57,0x56,0x48,0x83,0xEC,0x28,0x8B,0xF1,0x8B,0xFA,0x48,0xB9,0x20,0x6C,0x7D,0xC7,0xF7,0x7F,0x00,0x00,0x33,0xD2,0xE8,0xA5,0xF3,0xAD,0x5F,0x48,0xB8,0x38,0x2D,0x64,0x42,0x21,0x02,0x00,0x00,0x48,0x8B,0x00,0x8B,0x00,0x0F,0xAF,0xF7,0x8B,0xC6,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
