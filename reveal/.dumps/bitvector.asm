; 2019-10-05 19:16:27:244
; function: ref BitVector8 srl(ref BitVector8 x, int offset)
; location: [7FFDD9EE36D0h, 7FFDD9EE36E4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movzx r8d,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,DS:sr)]      encoding(4 bytes) = 44 0f b6 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh shr r8d,cl                    ; SHR(Shr_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e8
0011h mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x0F,0xB6,0x00,0x8B,0xCA,0x41,0xD3,0xE8,0x44,0x88,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector16 srl(ref BitVector16 x, int offset)
; location: [7FFDD9EE3B60h, 7FFDD9EE3B75h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movzx r8d,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [R8D,mem(16u,RAX:br,DS:sr)]    encoding(4 bytes) = 44 0f b7 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh shr r8d,cl                    ; SHR(Shr_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e8
0011h mov [rax],r8w                 ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R8W]        encoding(4 bytes) = 66 44 89 00
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x0F,0xB7,0x00,0x8B,0xCA,0x41,0xD3,0xE8,0x66,0x44,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector32 srl(ref BitVector32 x, int offset)
; location: [7FFDD9EE4430h, 7FFDD9EE4443h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,[rax]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 44 8b 00
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh shr r8d,cl                    ; SHR(Shr_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e8
0010h mov [rax],r8d                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),R8D]        encoding(3 bytes) = 44 89 00
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x8B,0x00,0x8B,0xCA,0x41,0xD3,0xE8,0x44,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector64 srl(ref BitVector64 x, int offset)
; location: [7FFDD9EE48E0h, 7FFDD9EE48F3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8,[rax]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RAX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 00
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh shr r8,cl                     ; SHR(Shr_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e8
0010h mov [rax],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 00
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x8B,0x00,0x8B,0xCA,0x49,0xD3,0xE8,0x4C,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 sub(BitVector4 x, BitVector4 y)
; location: [7FFDD9EE51E0h, 7FFDD9EE5264h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0008h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000dh movzx esi,cl                  ; MOVZX(Movzx_r32_rm8) [ESI,CL]                        encoding(4 bytes) = 40 0f b6 f1
0011h movzx edi,dl                  ; MOVZX(Movzx_r32_rm8) [EDI,DL]                        encoding(4 bytes) = 40 0f b6 fa
0015h mov rcx,7FFDD98F7E40h         ; MOV(Mov_r64_imm64) [RCX,7ffdd98f7e40h:imm64]         encoding(10 bytes) = 48 b9 40 7e 8f d9 fd 7f 00 00
001fh mov edx,9                     ; MOV(Mov_r32_imm32) [EDX,9h:imm32]                    encoding(5 bytes) = ba 09 00 00 00
0024h call 7FFE3932F3E0h            ; CALL(Call_rel32_64) [5F44A200h:jmp64]                encoding(5 bytes) = e8 d7 a1 44 5f
0029h mov rdx,18720059208h          ; MOV(Mov_r64_imm64) [RDX,18720059208h:imm64]          encoding(10 bytes) = 48 ba 08 92 05 20 87 01 00 00
0033h mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 12
0036h add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
003ah mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
003dh mov ecx,[rdx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 4a 08
0040h mov r8d,[rdx+0Ch]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 8b 42 0c
0044h mov edx,[rdx+10h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 10
0047h sub esi,edi                   ; SUB(Sub_r32_rm32) [ESI,EDI]                          encoding(2 bytes) = 2b f7
0049h movzx edx,sil                 ; MOVZX(Movzx_r32_rm8) [EDX,SIL]                       encoding(4 bytes) = 40 0f b6 d6
004dh imul rdx,rax                  ; IMUL(Imul_r64_rm64) [RDX,RAX]                        encoding(4 bytes) = 48 0f af d0
0051h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0053h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0055h mov [rsp+20h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 20
005ah mov [rsp+20h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 20
005fh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0064h mulx rax,r8,rax               ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,R8,RAX]             encoding(VEX, 5 bytes) = c4 e2 bb f6 c0
0069h mov [rcx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 01
006ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
006fh shl eax,4                     ; SHL(Shl_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e0 04
0072h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0075h sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
0078h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
007bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
007eh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0082h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0083h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0084h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[133]{0x57,0x56,0x48,0x83,0xEC,0x28,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x40,0x0F,0xB6,0xF1,0x40,0x0F,0xB6,0xFA,0x48,0xB9,0x40,0x7E,0x8F,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x09,0x00,0x00,0x00,0xE8,0xD7,0xA1,0x44,0x5F,0x48,0xBA,0x08,0x92,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x12,0x48,0x83,0xC2,0x08,0x48,0x8B,0x02,0x8B,0x4A,0x08,0x44,0x8B,0x42,0x0C,0x8B,0x52,0x10,0x2B,0xF7,0x40,0x0F,0xB6,0xD6,0x48,0x0F,0xAF,0xD0,0x8B,0xC1,0x33,0xC9,0x48,0x89,0x4C,0x24,0x20,0x48,0x89,0x4C,0x24,0x20,0x48,0x8D,0x4C,0x24,0x20,0xC4,0xE2,0xBB,0xF6,0xC0,0x4C,0x89,0x01,0x0F,0xB6,0xC0,0xC1,0xE0,0x04,0x0F,0xB6,0xC0,0xC1,0xF8,0x04,0x83,0xE0,0x0F,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 sub(BitVector8 x, BitVector8 y)
; location: [7FFDD9EE5280h, 7FFDD9EE5293h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x2B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector8 sub(ref BitVector8 x, in BitVector8 y)
; location: [7FFDD9EE52B0h, 7FFDD9EE52BDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rdx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RDX:br,DS:sr)]      encoding(3 bytes) = 0f b6 02
0008h sub [rcx],al                  ; SUB(Sub_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 28 01
000ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x02,0x28,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 sub(BitVector16 x, BitVector16 y)
; location: [7FFDD9EE52D0h, 7FFDD9EE52E0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x2B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector16 sub(ref BitVector16 x, in BitVector16 y)
; location: [7FFDD9EE5300h, 7FFDD9EE530Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rdx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RDX:br,DS:sr)]    encoding(3 bytes) = 0f b7 02
0008h sub [rcx],ax                  ; SUB(Sub_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 29 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x02,0x66,0x29,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 sub(BitVector32 x, BitVector32 y)
; location: [7FFDD9EE5320h, 7FFDD9EE5329h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector32 sub(ref BitVector32 x, in BitVector32 y)
; location: [7FFDD9EE5340h, 7FFDD9EE534Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rdx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 8b 02
0007h sub [rcx],eax                 ; SUB(Sub_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 29 01
0009h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x02,0x29,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 sub(BitVector64 x, BitVector64 y)
; location: [7FFDD9EE5360h, 7FFDD9EE536Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h sub rax,rdx                   ; SUB(Sub_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 2b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x2B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector64 sub(ref BitVector64 x, in BitVector64 y)
; location: [7FFDD9EE5380h, 7FFDD9EE538Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0008h sub [rcx],rax                 ; SUB(Sub_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 29 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> subBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x48,0x29,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 xor(BitVector4 x, BitVector4 y)
; location: [7FFDD9EE53A0h, 7FFDD9EE53BFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h shl eax,4                     ; SHL(Shl_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e0 04
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
0019h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0xC1,0xE0,0x04,0x0F,0xB6,0xC0,0xC1,0xF8,0x04,0x83,0xE0,0x0F,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 xor(BitVector8 x, BitVector8 y)
; location: [7FFDD9EE53D0h, 7FFDD9EE53E3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x33,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 xor(BitVector16 x, BitVector16 y)
; location: [7FFDD9EE5400h, 7FFDD9EE5410h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x33,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 xor(in BitVector32 x, in BitVector32 y)
; location: [7FFDD9EE5430h, 7FFDD9EE543Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h mov edx,[rdx]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 8b 12
0009h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x8B,0x12,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 xor(BitVector64 x, BitVector64 y)
; location: [7FFDD9EE5450h, 7FFDD9EE545Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h xor rax,rdx                   ; XOR(Xor_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 33 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x33,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 add(BitVector4 x, BitVector4 y)
; location: [7FFDD9EE5470h, 7FFDD9EE54F4h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0008h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000dh movzx esi,cl                  ; MOVZX(Movzx_r32_rm8) [ESI,CL]                        encoding(4 bytes) = 40 0f b6 f1
0011h movzx edi,dl                  ; MOVZX(Movzx_r32_rm8) [EDI,DL]                        encoding(4 bytes) = 40 0f b6 fa
0015h mov rcx,7FFDD98F7E40h         ; MOV(Mov_r64_imm64) [RCX,7ffdd98f7e40h:imm64]         encoding(10 bytes) = 48 b9 40 7e 8f d9 fd 7f 00 00
001fh mov edx,9                     ; MOV(Mov_r32_imm32) [EDX,9h:imm32]                    encoding(5 bytes) = ba 09 00 00 00
0024h call 7FFE3932F3E0h            ; CALL(Call_rel32_64) [5F449F70h:jmp64]                encoding(5 bytes) = e8 47 9f 44 5f
0029h mov rdx,18720059208h          ; MOV(Mov_r64_imm64) [RDX,18720059208h:imm64]          encoding(10 bytes) = 48 ba 08 92 05 20 87 01 00 00
0033h mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 12
0036h add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
003ah mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
003dh mov ecx,[rdx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 4a 08
0040h mov r8d,[rdx+0Ch]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 8b 42 0c
0044h mov edx,[rdx+10h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 10
0047h add esi,edi                   ; ADD(Add_r32_rm32) [ESI,EDI]                          encoding(2 bytes) = 03 f7
0049h movzx edx,sil                 ; MOVZX(Movzx_r32_rm8) [EDX,SIL]                       encoding(4 bytes) = 40 0f b6 d6
004dh imul rdx,rax                  ; IMUL(Imul_r64_rm64) [RDX,RAX]                        encoding(4 bytes) = 48 0f af d0
0051h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0053h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0055h mov [rsp+20h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 20
005ah mov [rsp+20h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 20
005fh lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0064h mulx rax,r8,rax               ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,R8,RAX]             encoding(VEX, 5 bytes) = c4 e2 bb f6 c0
0069h mov [rcx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 01
006ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
006fh shl eax,4                     ; SHL(Shl_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e0 04
0072h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0075h sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
0078h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
007bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
007eh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0082h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0083h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0084h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[133]{0x57,0x56,0x48,0x83,0xEC,0x28,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x40,0x0F,0xB6,0xF1,0x40,0x0F,0xB6,0xFA,0x48,0xB9,0x40,0x7E,0x8F,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x09,0x00,0x00,0x00,0xE8,0x47,0x9F,0x44,0x5F,0x48,0xBA,0x08,0x92,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x12,0x48,0x83,0xC2,0x08,0x48,0x8B,0x02,0x8B,0x4A,0x08,0x44,0x8B,0x42,0x0C,0x8B,0x52,0x10,0x03,0xF7,0x40,0x0F,0xB6,0xD6,0x48,0x0F,0xAF,0xD0,0x8B,0xC1,0x33,0xC9,0x48,0x89,0x4C,0x24,0x20,0x48,0x89,0x4C,0x24,0x20,0x48,0x8D,0x4C,0x24,0x20,0xC4,0xE2,0xBB,0xF6,0xC0,0x4C,0x89,0x01,0x0F,0xB6,0xC0,0xC1,0xE0,0x04,0x0F,0xB6,0xC0,0xC1,0xF8,0x04,0x83,0xE0,0x0F,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 add(BitVector8 x, BitVector8 y)
; location: [7FFDD9EE5510h, 7FFDD9EE5523h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x03,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 add(BitVector16 x, BitVector16 y)
; location: [7FFDD9EE5540h, 7FFDD9EE5550h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x03,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 add(BitVector32 x, BitVector32 y)
; location: [7FFDD9EE5570h, 7FFDD9EE5578h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+rdx]             ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 04 11
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x04,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 add(BitVector64 x, BitVector64 y)
; location: [7FFDD9EE5590h, 7FFDD9EE5599h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+rdx]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 04 11
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> addBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x04,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt4 and(UInt4 x, UInt4 y)
; location: [7FFDD9EE55B0h, 7FFDD9EE5625h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h mov esi,ecx                   ; MOV(Mov_r32_rm32) [ESI,ECX]                          encoding(2 bytes) = 8b f1
0008h mov edi,edx                   ; MOV(Mov_r32_rm32) [EDI,EDX]                          encoding(2 bytes) = 8b fa
000ah mov rcx,7FFDD98F7E40h         ; MOV(Mov_r64_imm64) [RCX,7ffdd98f7e40h:imm64]         encoding(10 bytes) = 48 b9 40 7e 8f d9 fd 7f 00 00
0014h mov edx,9                     ; MOV(Mov_r32_imm32) [EDX,9h:imm32]                    encoding(5 bytes) = ba 09 00 00 00
0019h call 7FFE3932F3E0h            ; CALL(Call_rel32_64) [5F449E30h:jmp64]                encoding(5 bytes) = e8 12 9e 44 5f
001eh mov rdx,18720059208h          ; MOV(Mov_r64_imm64) [RDX,18720059208h:imm64]          encoding(10 bytes) = 48 ba 08 92 05 20 87 01 00 00
0028h mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 12
002bh add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
002fh mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
0032h mov ecx,[rdx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 4a 08
0035h mov r8d,[rdx+0Ch]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 8b 42 0c
0039h mov edx,[rdx+10h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 10
003ch movzx edx,sil                 ; MOVZX(Movzx_r32_rm8) [EDX,SIL]                       encoding(4 bytes) = 40 0f b6 d6
0040h movzx r8d,dil                 ; MOVZX(Movzx_r32_rm8) [R8D,DIL]                       encoding(4 bytes) = 44 0f b6 c7
0044h and edx,r8d                   ; AND(And_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 23 d0
0047h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
004ah imul rdx,rax                  ; IMUL(Imul_r64_rm64) [RDX,RAX]                        encoding(4 bytes) = 48 0f af d0
004eh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0050h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0052h mov [rsp+20h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 20
0057h mov [rsp+20h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 20
005ch lea rcx,[rsp+20h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 20
0061h mulx rax,r8,rax               ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,R8,RAX]             encoding(VEX, 5 bytes) = c4 e2 bb f6 c0
0066h mov [rcx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 01
0069h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
006ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
006fh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0073h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0074h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0075h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[118]{0x57,0x56,0x48,0x83,0xEC,0x28,0x8B,0xF1,0x8B,0xFA,0x48,0xB9,0x40,0x7E,0x8F,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x09,0x00,0x00,0x00,0xE8,0x12,0x9E,0x44,0x5F,0x48,0xBA,0x08,0x92,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x12,0x48,0x83,0xC2,0x08,0x48,0x8B,0x02,0x8B,0x4A,0x08,0x44,0x8B,0x42,0x0C,0x8B,0x52,0x10,0x40,0x0F,0xB6,0xD6,0x44,0x0F,0xB6,0xC7,0x41,0x23,0xD0,0x0F,0xB6,0xD2,0x48,0x0F,0xAF,0xD0,0x8B,0xC1,0x33,0xC9,0x48,0x89,0x4C,0x24,0x20,0x48,0x89,0x4C,0x24,0x20,0x48,0x8D,0x4C,0x24,0x20,0xC4,0xE2,0xBB,0xF6,0xC0,0x4C,0x89,0x01,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 and(BitVector4 x, BitVector4 y)
; location: [7FFDD9EE5640h, 7FFDD9EE565Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h shl eax,4                     ; SHL(Shl_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e0 04
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
0019h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0xC1,0xE0,0x04,0x0F,0xB6,0xC0,0xC1,0xF8,0x04,0x83,0xE0,0x0F,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 and(BitVector8 x, BitVector8 y)
; location: [7FFDD9EE5670h, 7FFDD9EE5683h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 and(BitVector16 x, BitVector16 y)
; location: [7FFDD9EE56A0h, 7FFDD9EE56B0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x23,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 and(in BitVector32 x, in BitVector32 y)
; location: [7FFDD9EE56D0h, 7FFDD9EE56DBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h mov edx,[rdx]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 8b 12
0009h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x8B,0x12,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 and(BitVector64 x, BitVector64 y)
; location: [7FFDD9EE56F0h, 7FFDD9EE56FBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x23,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector4 and(ref BitVector4 x, BitVector4 y)
; location: [7FFDD9EE5710h, 7FFDD9EE5731h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h shl eax,4                     ; SHL(Shl_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e0 04
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
0019h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
001ch mov [rcx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 88 01
001eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0xC1,0xE0,0x04,0x0F,0xB6,0xC0,0xC1,0xF8,0x04,0x83,0xE0,0x0F,0x88,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector8 and(ref BitVector8 x, BitVector8 y)
; location: [7FFDD9EE5750h, 7FFDD9EE5765h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h mov [rcx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 88 01
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0x0F,0xB6,0xD2,0x23,0xC2,0x0F,0xB6,0xC0,0x88,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector16 and(ref BitVector16 x, BitVector16 y)
; location: [7FFDD9EE5780h, 7FFDD9EE5796h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,DS:sr)]    encoding(3 bytes) = 0f b7 01
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h mov [rcx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 01
0013h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0x0F,0xB7,0xD2,0x23,0xC2,0x0F,0xB7,0xC0,0x66,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector32 and(ref BitVector32 x, BitVector32 y)
; location: [7FFDD9EE57B0h, 7FFDD9EE57BEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
0009h mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x23,0xC2,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector64 and(ref BitVector64 x, BitVector64 y)
; location: [7FFDD9EE57D0h, 7FFDD9EE57E1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
000bh mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
000eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x23,0xC2,0x48,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 andn(BitVector4 x, BitVector4 y)
; location: [7FFDD9EE6EB0h, 7FFDD9EE6EDCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],rcx               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 08
000ah lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
000fh movzx eax,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,DS:sr)]      encoding(3 bytes) = 0f b6 00
0012h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0015h andn eax,eax,edx              ; ANDN(VEX_Andn_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 78 f2 c2
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh shl eax,4                     ; SHL(Shl_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e0 04
0020h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0023h sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
0026h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
0029h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andnBytes => new byte[45]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x89,0x4C,0x24,0x08,0x48,0x8D,0x44,0x24,0x08,0x0F,0xB6,0x00,0x0F,0xB6,0xD2,0xC4,0xE2,0x78,0xF2,0xC2,0x0F,0xB6,0xC0,0xC1,0xE0,0x04,0x0F,0xB6,0xC0,0xC1,0xF8,0x04,0x83,0xE0,0x0F,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 andn(BitVector8 x, BitVector8 y)
; location: [7FFDD9EE6EF0h, 7FFDD9EE6F0Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],rcx               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 08
000ah lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
000fh movzx eax,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,DS:sr)]      encoding(3 bytes) = 0f b6 00
0012h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0015h andn eax,eax,edx              ; ANDN(VEX_Andn_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 78 f2 c2
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andnBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x89,0x4C,0x24,0x08,0x48,0x8D,0x44,0x24,0x08,0x0F,0xB6,0x00,0x0F,0xB6,0xD2,0xC4,0xE2,0x78,0xF2,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 andn(BitVector16 x, BitVector16 y)
; location: [7FFDD9EE7330h, 7FFDD9EE735Ah]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov [rsp+20h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 20
000ah mov [rsp+28h],rdx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(5 bytes) = 48 89 54 24 28
000fh lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 20
0014h movzx eax,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RAX:br,DS:sr)]    encoding(3 bytes) = 0f b7 00
0017h mov edx,[rsp+28h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 28
001bh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
001eh andn eax,eax,edx              ; ANDN(VEX_Andn_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 78 f2 c2
0023h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0026h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andnBytes => new byte[43]{0x48,0x83,0xEC,0x18,0x90,0x48,0x89,0x4C,0x24,0x20,0x48,0x89,0x54,0x24,0x28,0x48,0x8D,0x44,0x24,0x20,0x0F,0xB7,0x00,0x8B,0x54,0x24,0x28,0x0F,0xB7,0xD2,0xC4,0xE2,0x78,0xF2,0xC2,0x0F,0xB7,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 andn(BitVector32 x, BitVector32 y)
; location: [7FFDD9EE7370h, 7FFDD9EE7391h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov [rsp+20h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 20
000ah mov [rsp+28h],rdx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(5 bytes) = 48 89 54 24 28
000fh lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 20
0014h mov eax,[rax]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 00
0016h andn eax,eax,[rsp+28h]        ; ANDN(VEX_Andn_r32_r32_rm32) [EAX,EAX,mem(32u,RSP:br,SS:sr)] encoding(VEX, 7 bytes) = c4 e2 78 f2 44 24 28
001dh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andnBytes => new byte[34]{0x48,0x83,0xEC,0x18,0x90,0x48,0x89,0x4C,0x24,0x20,0x48,0x89,0x54,0x24,0x28,0x48,0x8D,0x44,0x24,0x20,0x8B,0x00,0xC4,0xE2,0x78,0xF2,0x44,0x24,0x28,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 andn(BitVector64 x, BitVector64 y)
; location: [7FFDD9EE73B0h, 7FFDD9EE73D2h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov [rsp+30h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 30
000ah mov [rsp+38h],rdx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(5 bytes) = 48 89 54 24 38
000fh lea rax,[rsp+30h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 30
0014h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
0017h andn rax,rax,[rsp+38h]        ; ANDN(VEX_Andn_r64_r64_rm64) [RAX,RAX,mem(64u,RSP:br,SS:sr)] encoding(VEX, 7 bytes) = c4 e2 f8 f2 44 24 38
001eh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andnBytes => new byte[35]{0x48,0x83,0xEC,0x28,0x90,0x48,0x89,0x4C,0x24,0x30,0x48,0x89,0x54,0x24,0x38,0x48,0x8D,0x44,0x24,0x30,0x48,0x8B,0x00,0xC4,0xE2,0xF8,0xF2,0x44,0x24,0x38,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector8 dec(ref BitVector8 x)
; location: [7FFDD9EE73F0h, 7FFDD9EE73FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec byte ptr [rcx]            ; DEC(Dec_rm8) [mem(8u,RCX:br,DS:sr)]                  encoding(2 bytes) = fe 09
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xFE,0x09,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 dec(BitVector8 x)
; location: [7FFDD9EE7410h, 7FFDD9EE7420h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xFF,0xC8,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector16 dec(ref BitVector16 x)
; location: [7FFDD9EE7440h, 7FFDD9EE744Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec word ptr [rcx]            ; DEC(Dec_rm16) [mem(16u,RCX:br,DS:sr)]                encoding(3 bytes) = 66 ff 09
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x66,0xFF,0x09,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 dec(BitVector16 x)
; location: [7FFDD9EE7460h, 7FFDD9EE746Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xFF,0xC8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector32 dec(ref BitVector32 x)
; location: [7FFDD9EE7480h, 7FFDD9EE748Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec dword ptr [rcx]           ; DEC(Dec_rm32) [mem(32u,RCX:br,DS:sr)]                encoding(2 bytes) = ff 09
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0x09,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 dec(BitVector32 x)
; location: [7FFDD9EE74A0h, 7FFDD9EE74A8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx-1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 ff
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector64 dec(ref BitVector64 x)
; location: [7FFDD9EE74C0h, 7FFDD9EE74CBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec qword ptr [rcx]           ; DEC(Dec_rm64) [mem(64u,RCX:br,DS:sr)]                encoding(3 bytes) = 48 ff 09
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xFF,0x09,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 dec(BitVector64 x)
; location: [7FFDD9EE74E0h, 7FFDD9EE74E9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx-1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 ff
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> decBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0xFF,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit dot(BitVector4 lhs, BitVector4 rhs)
; location: [7FFDD9EE7630h, 7FFDD9EE76EFh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h movzx esi,cl                  ; MOVZX(Movzx_r32_rm8) [ESI,CL]                        encoding(4 bytes) = 40 0f b6 f1
000ah movzx edi,dl                  ; MOVZX(Movzx_r32_rm8) [EDI,DL]                        encoding(4 bytes) = 40 0f b6 fa
000eh and esi,edi                   ; AND(And_r32_rm32) [ESI,EDI]                          encoding(2 bytes) = 23 f7
0010h mov rcx,7FFDD98F7E40h         ; MOV(Mov_r64_imm64) [RCX,7ffdd98f7e40h:imm64]         encoding(10 bytes) = 48 b9 40 7e 8f d9 fd 7f 00 00
001ah mov edx,0Ah                   ; MOV(Mov_r32_imm32) [EDX,ah:imm32]                    encoding(5 bytes) = ba 0a 00 00 00
001fh call 7FFE3932F3E0h            ; CALL(Call_rel32_64) [5F447DB0h:jmp64]                encoding(5 bytes) = e8 8c 7d 44 5f
0024h mov rdx,18720059218h          ; MOV(Mov_r64_imm64) [RDX,18720059218h:imm64]          encoding(10 bytes) = 48 ba 18 92 05 20 87 01 00 00
002eh mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 12
0031h add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
0035h mov rcx,[rdx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 0a
0038h mov eax,[rdx+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 42 08
003bh mov r8d,[rdx+0Ch]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 8b 42 0c
003fh mov edx,[rdx+10h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 10
0042h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0044h popcnt edx,esi                ; POPCNT(Popcnt_r32_rm32) [EDX,ESI]                    encoding(4 bytes) = f3 0f b8 d6
0048h imul rdx,rcx                  ; IMUL(Imul_r64_rm64) [RDX,RCX]                        encoding(4 bytes) = 48 0f af d1
004ch mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
004eh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0050h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
0055h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
005ah lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 20
005fh mulx rcx,r8,rcx               ; MULX(VEX_Mulx_r64_r64_rm64) [RCX,R8,RCX]             encoding(VEX, 5 bytes) = c4 e2 bb f6 c9
0064h mov [rax],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 00
0067h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0069h je short 0093h                ; JE(Je_rel8_64) [93h:jmp64]                           encoding(2 bytes) = 74 28
006bh mov rcx,7FFDD99940C8h         ; MOV(Mov_r64_imm64) [RCX,7ffdd99940c8h:imm64]         encoding(10 bytes) = 48 b9 c8 40 99 d9 fd 7f 00 00
0075h mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
007ah call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47D280h:jmp64]                encoding(5 bytes) = e8 01 d2 47 5f
007fh mov rcx,18720056C28h          ; MOV(Mov_r64_imm64) [RCX,18720056c28h:imm64]          encoding(10 bytes) = 48 b9 28 6c 05 20 87 01 00 00
0089h mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
008ch movsx rax,byte ptr [rcx+8]    ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RCX:br,DS:sr)]      encoding(5 bytes) = 48 0f be 41 08
0091h jmp short 00b9h               ; JMP(Jmp_rel8_64) [B9h:jmp64]                         encoding(2 bytes) = eb 26
0093h mov rcx,7FFDD99940C8h         ; MOV(Mov_r64_imm64) [RCX,7ffdd99940c8h:imm64]         encoding(10 bytes) = 48 b9 c8 40 99 d9 fd 7f 00 00
009dh mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
00a2h call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47D280h:jmp64]                encoding(5 bytes) = e8 d9 d1 47 5f
00a7h mov rax,18720056C20h          ; MOV(Mov_r64_imm64) [RAX,18720056c20h:imm64]          encoding(10 bytes) = 48 b8 20 6c 05 20 87 01 00 00
00b1h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
00b4h movsx rax,byte ptr [rax+8]    ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RAX:br,DS:sr)]      encoding(5 bytes) = 48 0f be 40 08
00b9h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
00bdh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00beh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00bfh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dotBytes => new byte[192]{0x57,0x56,0x48,0x83,0xEC,0x28,0x40,0x0F,0xB6,0xF1,0x40,0x0F,0xB6,0xFA,0x23,0xF7,0x48,0xB9,0x40,0x7E,0x8F,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x0A,0x00,0x00,0x00,0xE8,0x8C,0x7D,0x44,0x5F,0x48,0xBA,0x18,0x92,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x12,0x48,0x83,0xC2,0x08,0x48,0x8B,0x0A,0x8B,0x42,0x08,0x44,0x8B,0x42,0x0C,0x8B,0x52,0x10,0x33,0xD2,0xF3,0x0F,0xB8,0xD6,0x48,0x0F,0xAF,0xD1,0x8B,0xC8,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x20,0x48,0x8D,0x44,0x24,0x20,0xC4,0xE2,0xBB,0xF6,0xC9,0x4C,0x89,0x00,0x85,0xC9,0x74,0x28,0x48,0xB9,0xC8,0x40,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x05,0x00,0x00,0x00,0xE8,0x01,0xD2,0x47,0x5F,0x48,0xB9,0x28,0x6C,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x09,0x48,0x0F,0xBE,0x41,0x08,0xEB,0x26,0x48,0xB9,0xC8,0x40,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x05,0x00,0x00,0x00,0xE8,0xD9,0xD1,0x47,0x5F,0x48,0xB8,0x20,0x6C,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x00,0x48,0x0F,0xBE,0x40,0x08,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit dot(BitVector8 lhs, BitVector8 rhs)
; location: [7FFDD9EE7830h, 7FFDD9EE78F6h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0008h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000dh movzx esi,cl                  ; MOVZX(Movzx_r32_rm8) [ESI,CL]                        encoding(4 bytes) = 40 0f b6 f1
0011h movzx edi,dl                  ; MOVZX(Movzx_r32_rm8) [EDI,DL]                        encoding(4 bytes) = 40 0f b6 fa
0015h and esi,edi                   ; AND(And_r32_rm32) [ESI,EDI]                          encoding(2 bytes) = 23 f7
0017h mov rcx,7FFDD98F7E40h         ; MOV(Mov_r64_imm64) [RCX,7ffdd98f7e40h:imm64]         encoding(10 bytes) = 48 b9 40 7e 8f d9 fd 7f 00 00
0021h mov edx,0Ah                   ; MOV(Mov_r32_imm32) [EDX,ah:imm32]                    encoding(5 bytes) = ba 0a 00 00 00
0026h call 7FFE3932F3E0h            ; CALL(Call_rel32_64) [5F447BB0h:jmp64]                encoding(5 bytes) = e8 85 7b 44 5f
002bh mov rdx,18720059218h          ; MOV(Mov_r64_imm64) [RDX,18720059218h:imm64]          encoding(10 bytes) = 48 ba 18 92 05 20 87 01 00 00
0035h mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 12
0038h add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
003ch mov rcx,[rdx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 0a
003fh mov eax,[rdx+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 42 08
0042h mov r8d,[rdx+0Ch]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 8b 42 0c
0046h mov edx,[rdx+10h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 10
0049h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
004bh popcnt edx,esi                ; POPCNT(Popcnt_r32_rm32) [EDX,ESI]                    encoding(4 bytes) = f3 0f b8 d6
004fh imul rdx,rcx                  ; IMUL(Imul_r64_rm64) [RDX,RCX]                        encoding(4 bytes) = 48 0f af d1
0053h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0055h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0057h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
005ch mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
0061h lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 20
0066h mulx rcx,r8,rcx               ; MULX(VEX_Mulx_r64_r64_rm64) [RCX,R8,RCX]             encoding(VEX, 5 bytes) = c4 e2 bb f6 c9
006bh mov [rax],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 00
006eh test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0070h je short 009ah                ; JE(Je_rel8_64) [9Ah:jmp64]                           encoding(2 bytes) = 74 28
0072h mov rcx,7FFDD99940C8h         ; MOV(Mov_r64_imm64) [RCX,7ffdd99940c8h:imm64]         encoding(10 bytes) = 48 b9 c8 40 99 d9 fd 7f 00 00
007ch mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
0081h call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47D080h:jmp64]                encoding(5 bytes) = e8 fa cf 47 5f
0086h mov rcx,18720056C28h          ; MOV(Mov_r64_imm64) [RCX,18720056c28h:imm64]          encoding(10 bytes) = 48 b9 28 6c 05 20 87 01 00 00
0090h mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
0093h movsx rax,byte ptr [rcx+8]    ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RCX:br,DS:sr)]      encoding(5 bytes) = 48 0f be 41 08
0098h jmp short 00c0h               ; JMP(Jmp_rel8_64) [C0h:jmp64]                         encoding(2 bytes) = eb 26
009ah mov rcx,7FFDD99940C8h         ; MOV(Mov_r64_imm64) [RCX,7ffdd99940c8h:imm64]         encoding(10 bytes) = 48 b9 c8 40 99 d9 fd 7f 00 00
00a4h mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
00a9h call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47D080h:jmp64]                encoding(5 bytes) = e8 d2 cf 47 5f
00aeh mov rax,18720056C20h          ; MOV(Mov_r64_imm64) [RAX,18720056c20h:imm64]          encoding(10 bytes) = 48 b8 20 6c 05 20 87 01 00 00
00b8h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
00bbh movsx rax,byte ptr [rax+8]    ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RAX:br,DS:sr)]      encoding(5 bytes) = 48 0f be 40 08
00c0h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
00c4h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00c5h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00c6h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dotBytes => new byte[199]{0x57,0x56,0x48,0x83,0xEC,0x28,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x40,0x0F,0xB6,0xF1,0x40,0x0F,0xB6,0xFA,0x23,0xF7,0x48,0xB9,0x40,0x7E,0x8F,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x0A,0x00,0x00,0x00,0xE8,0x85,0x7B,0x44,0x5F,0x48,0xBA,0x18,0x92,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x12,0x48,0x83,0xC2,0x08,0x48,0x8B,0x0A,0x8B,0x42,0x08,0x44,0x8B,0x42,0x0C,0x8B,0x52,0x10,0x33,0xD2,0xF3,0x0F,0xB8,0xD6,0x48,0x0F,0xAF,0xD1,0x8B,0xC8,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x20,0x48,0x8D,0x44,0x24,0x20,0xC4,0xE2,0xBB,0xF6,0xC9,0x4C,0x89,0x00,0x85,0xC9,0x74,0x28,0x48,0xB9,0xC8,0x40,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x05,0x00,0x00,0x00,0xE8,0xFA,0xCF,0x47,0x5F,0x48,0xB9,0x28,0x6C,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x09,0x48,0x0F,0xBE,0x41,0x08,0xEB,0x26,0x48,0xB9,0xC8,0x40,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x05,0x00,0x00,0x00,0xE8,0xD2,0xCF,0x47,0x5F,0x48,0xB8,0x20,0x6C,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x00,0x48,0x0F,0xBE,0x40,0x08,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit dot(BitVector16 lhs, BitVector16 rhs)
; location: [7FFDD9EE7910h, 7FFDD9EE79D4h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0008h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000dh movzx esi,cx                  ; MOVZX(Movzx_r32_rm16) [ESI,CX]                       encoding(3 bytes) = 0f b7 f1
0010h movzx edi,dx                  ; MOVZX(Movzx_r32_rm16) [EDI,DX]                       encoding(3 bytes) = 0f b7 fa
0013h and esi,edi                   ; AND(And_r32_rm32) [ESI,EDI]                          encoding(2 bytes) = 23 f7
0015h mov rcx,7FFDD98F7E40h         ; MOV(Mov_r64_imm64) [RCX,7ffdd98f7e40h:imm64]         encoding(10 bytes) = 48 b9 40 7e 8f d9 fd 7f 00 00
001fh mov edx,0Ah                   ; MOV(Mov_r32_imm32) [EDX,ah:imm32]                    encoding(5 bytes) = ba 0a 00 00 00
0024h call 7FFE3932F3E0h            ; CALL(Call_rel32_64) [5F447AD0h:jmp64]                encoding(5 bytes) = e8 a7 7a 44 5f
0029h mov rdx,18720059218h          ; MOV(Mov_r64_imm64) [RDX,18720059218h:imm64]          encoding(10 bytes) = 48 ba 18 92 05 20 87 01 00 00
0033h mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 12
0036h add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
003ah mov rcx,[rdx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 0a
003dh mov eax,[rdx+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 42 08
0040h mov r8d,[rdx+0Ch]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 8b 42 0c
0044h mov edx,[rdx+10h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 10
0047h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0049h popcnt edx,esi                ; POPCNT(Popcnt_r32_rm32) [EDX,ESI]                    encoding(4 bytes) = f3 0f b8 d6
004dh imul rdx,rcx                  ; IMUL(Imul_r64_rm64) [RDX,RCX]                        encoding(4 bytes) = 48 0f af d1
0051h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0053h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0055h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
005ah mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
005fh lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 20
0064h mulx rcx,r8,rcx               ; MULX(VEX_Mulx_r64_r64_rm64) [RCX,R8,RCX]             encoding(VEX, 5 bytes) = c4 e2 bb f6 c9
0069h mov [rax],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 00
006ch test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
006eh je short 0098h                ; JE(Je_rel8_64) [98h:jmp64]                           encoding(2 bytes) = 74 28
0070h mov rcx,7FFDD99940C8h         ; MOV(Mov_r64_imm64) [RCX,7ffdd99940c8h:imm64]         encoding(10 bytes) = 48 b9 c8 40 99 d9 fd 7f 00 00
007ah mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
007fh call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47CFA0h:jmp64]                encoding(5 bytes) = e8 1c cf 47 5f
0084h mov rcx,18720056C28h          ; MOV(Mov_r64_imm64) [RCX,18720056c28h:imm64]          encoding(10 bytes) = 48 b9 28 6c 05 20 87 01 00 00
008eh mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
0091h movsx rax,byte ptr [rcx+8]    ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RCX:br,DS:sr)]      encoding(5 bytes) = 48 0f be 41 08
0096h jmp short 00beh               ; JMP(Jmp_rel8_64) [BEh:jmp64]                         encoding(2 bytes) = eb 26
0098h mov rcx,7FFDD99940C8h         ; MOV(Mov_r64_imm64) [RCX,7ffdd99940c8h:imm64]         encoding(10 bytes) = 48 b9 c8 40 99 d9 fd 7f 00 00
00a2h mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
00a7h call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47CFA0h:jmp64]                encoding(5 bytes) = e8 f4 ce 47 5f
00ach mov rax,18720056C20h          ; MOV(Mov_r64_imm64) [RAX,18720056c20h:imm64]          encoding(10 bytes) = 48 b8 20 6c 05 20 87 01 00 00
00b6h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
00b9h movsx rax,byte ptr [rax+8]    ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RAX:br,DS:sr)]      encoding(5 bytes) = 48 0f be 40 08
00beh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
00c2h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00c3h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00c4h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dotBytes => new byte[197]{0x57,0x56,0x48,0x83,0xEC,0x28,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x0F,0xB7,0xF1,0x0F,0xB7,0xFA,0x23,0xF7,0x48,0xB9,0x40,0x7E,0x8F,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x0A,0x00,0x00,0x00,0xE8,0xA7,0x7A,0x44,0x5F,0x48,0xBA,0x18,0x92,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x12,0x48,0x83,0xC2,0x08,0x48,0x8B,0x0A,0x8B,0x42,0x08,0x44,0x8B,0x42,0x0C,0x8B,0x52,0x10,0x33,0xD2,0xF3,0x0F,0xB8,0xD6,0x48,0x0F,0xAF,0xD1,0x8B,0xC8,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x20,0x48,0x8D,0x44,0x24,0x20,0xC4,0xE2,0xBB,0xF6,0xC9,0x4C,0x89,0x00,0x85,0xC9,0x74,0x28,0x48,0xB9,0xC8,0x40,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x05,0x00,0x00,0x00,0xE8,0x1C,0xCF,0x47,0x5F,0x48,0xB9,0x28,0x6C,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x09,0x48,0x0F,0xBE,0x41,0x08,0xEB,0x26,0x48,0xB9,0xC8,0x40,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x05,0x00,0x00,0x00,0xE8,0xF4,0xCE,0x47,0x5F,0x48,0xB8,0x20,0x6C,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x00,0x48,0x0F,0xBE,0x40,0x08,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit dot(BitVector32 lhs, BitVector32 rhs)
; location: [7FFDD9EE79F0h, 7FFDD9EE7AAEh]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
000ch mov esi,ecx                   ; MOV(Mov_r32_rm32) [ESI,ECX]                          encoding(2 bytes) = 8b f1
000eh and esi,edx                   ; AND(And_r32_rm32) [ESI,EDX]                          encoding(2 bytes) = 23 f2
0010h mov rcx,7FFDD98F7E40h         ; MOV(Mov_r64_imm64) [RCX,7ffdd98f7e40h:imm64]         encoding(10 bytes) = 48 b9 40 7e 8f d9 fd 7f 00 00
001ah mov edx,0Ah                   ; MOV(Mov_r32_imm32) [EDX,ah:imm32]                    encoding(5 bytes) = ba 0a 00 00 00
001fh call 7FFE3932F3E0h            ; CALL(Call_rel32_64) [5F4479F0h:jmp64]                encoding(5 bytes) = e8 cc 79 44 5f
0024h mov rdx,18720059218h          ; MOV(Mov_r64_imm64) [RDX,18720059218h:imm64]          encoding(10 bytes) = 48 ba 18 92 05 20 87 01 00 00
002eh mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 12
0031h add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
0035h mov rcx,[rdx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 0a
0038h mov eax,[rdx+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 42 08
003bh mov r8d,[rdx+0Ch]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 8b 42 0c
003fh mov edx,[rdx+10h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 10
0042h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0044h popcnt edx,esi                ; POPCNT(Popcnt_r32_rm32) [EDX,ESI]                    encoding(4 bytes) = f3 0f b8 d6
0048h imul rdx,rcx                  ; IMUL(Imul_r64_rm64) [RDX,RCX]                        encoding(4 bytes) = 48 0f af d1
004ch mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
004eh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0050h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
0055h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
005ah lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
005fh mulx rcx,r8,rcx               ; MULX(VEX_Mulx_r64_r64_rm64) [RCX,R8,RCX]             encoding(VEX, 5 bytes) = c4 e2 bb f6 c9
0064h mov [rax],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 00
0067h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0069h je short 0093h                ; JE(Je_rel8_64) [93h:jmp64]                           encoding(2 bytes) = 74 28
006bh mov rcx,7FFDD99940C8h         ; MOV(Mov_r64_imm64) [RCX,7ffdd99940c8h:imm64]         encoding(10 bytes) = 48 b9 c8 40 99 d9 fd 7f 00 00
0075h mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
007ah call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47CEC0h:jmp64]                encoding(5 bytes) = e8 41 ce 47 5f
007fh mov rcx,18720056C28h          ; MOV(Mov_r64_imm64) [RCX,18720056c28h:imm64]          encoding(10 bytes) = 48 b9 28 6c 05 20 87 01 00 00
0089h mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
008ch movsx rax,byte ptr [rcx+8]    ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RCX:br,DS:sr)]      encoding(5 bytes) = 48 0f be 41 08
0091h jmp short 00b9h               ; JMP(Jmp_rel8_64) [B9h:jmp64]                         encoding(2 bytes) = eb 26
0093h mov rcx,7FFDD99940C8h         ; MOV(Mov_r64_imm64) [RCX,7ffdd99940c8h:imm64]         encoding(10 bytes) = 48 b9 c8 40 99 d9 fd 7f 00 00
009dh mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
00a2h call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47CEC0h:jmp64]                encoding(5 bytes) = e8 19 ce 47 5f
00a7h mov rax,18720056C20h          ; MOV(Mov_r64_imm64) [RAX,18720056c20h:imm64]          encoding(10 bytes) = 48 b8 20 6c 05 20 87 01 00 00
00b1h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
00b4h movsx rax,byte ptr [rax+8]    ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RAX:br,DS:sr)]      encoding(5 bytes) = 48 0f be 40 08
00b9h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
00bdh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00beh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dotBytes => new byte[191]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x8B,0xF1,0x23,0xF2,0x48,0xB9,0x40,0x7E,0x8F,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x0A,0x00,0x00,0x00,0xE8,0xCC,0x79,0x44,0x5F,0x48,0xBA,0x18,0x92,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x12,0x48,0x83,0xC2,0x08,0x48,0x8B,0x0A,0x8B,0x42,0x08,0x44,0x8B,0x42,0x0C,0x8B,0x52,0x10,0x33,0xD2,0xF3,0x0F,0xB8,0xD6,0x48,0x0F,0xAF,0xD1,0x8B,0xC8,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x28,0x48,0x8D,0x44,0x24,0x28,0xC4,0xE2,0xBB,0xF6,0xC9,0x4C,0x89,0x00,0x85,0xC9,0x74,0x28,0x48,0xB9,0xC8,0x40,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x05,0x00,0x00,0x00,0xE8,0x41,0xCE,0x47,0x5F,0x48,0xB9,0x28,0x6C,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x09,0x48,0x0F,0xBE,0x41,0x08,0xEB,0x26,0x48,0xB9,0xC8,0x40,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x05,0x00,0x00,0x00,0xE8,0x19,0xCE,0x47,0x5F,0x48,0xB8,0x20,0x6C,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x00,0x48,0x0F,0xBE,0x40,0x08,0x48,0x83,0xC4,0x30,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit dot(BitVector64 lhs, BitVector64 rhs)
; location: [7FFDD9EE7AD0h, 7FFDD9EE7B93h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
000ch mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000fh and rsi,rdx                   ; AND(And_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 23 f2
0012h mov rcx,7FFDD98F7E40h         ; MOV(Mov_r64_imm64) [RCX,7ffdd98f7e40h:imm64]         encoding(10 bytes) = 48 b9 40 7e 8f d9 fd 7f 00 00
001ch mov edx,0Ah                   ; MOV(Mov_r32_imm32) [EDX,ah:imm32]                    encoding(5 bytes) = ba 0a 00 00 00
0021h call 7FFE3932F3E0h            ; CALL(Call_rel32_64) [5F447910h:jmp64]                encoding(5 bytes) = e8 ea 78 44 5f
0026h mov rdx,18720059218h          ; MOV(Mov_r64_imm64) [RDX,18720059218h:imm64]          encoding(10 bytes) = 48 ba 18 92 05 20 87 01 00 00
0030h mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 12
0033h add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
0037h mov rcx,[rdx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 0a
003ah mov eax,[rdx+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 42 08
003dh mov r8d,[rdx+0Ch]             ; MOV(Mov_r32_rm32) [R8D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 8b 42 0c
0041h mov edx,[rdx+10h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 10
0044h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0046h popcnt rdx,rsi                ; POPCNT(Popcnt_r64_rm64) [RDX,RSI]                    encoding(5 bytes) = f3 48 0f b8 d6
004bh mov edx,edx                   ; MOV(Mov_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 8b d2
004dh imul rdx,rcx                  ; IMUL(Imul_r64_rm64) [RDX,RCX]                        encoding(4 bytes) = 48 0f af d1
0051h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0053h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0055h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
005ah mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
005fh lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
0064h mulx rcx,r8,rcx               ; MULX(VEX_Mulx_r64_r64_rm64) [RCX,R8,RCX]             encoding(VEX, 5 bytes) = c4 e2 bb f6 c9
0069h mov [rax],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 00
006ch test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
006eh je short 0098h                ; JE(Je_rel8_64) [98h:jmp64]                           encoding(2 bytes) = 74 28
0070h mov rcx,7FFDD99940C8h         ; MOV(Mov_r64_imm64) [RCX,7ffdd99940c8h:imm64]         encoding(10 bytes) = 48 b9 c8 40 99 d9 fd 7f 00 00
007ah mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
007fh call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47CDE0h:jmp64]                encoding(5 bytes) = e8 5c cd 47 5f
0084h mov rcx,18720056C28h          ; MOV(Mov_r64_imm64) [RCX,18720056c28h:imm64]          encoding(10 bytes) = 48 b9 28 6c 05 20 87 01 00 00
008eh mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
0091h movsx rax,byte ptr [rcx+8]    ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RCX:br,DS:sr)]      encoding(5 bytes) = 48 0f be 41 08
0096h jmp short 00beh               ; JMP(Jmp_rel8_64) [BEh:jmp64]                         encoding(2 bytes) = eb 26
0098h mov rcx,7FFDD99940C8h         ; MOV(Mov_r64_imm64) [RCX,7ffdd99940c8h:imm64]         encoding(10 bytes) = 48 b9 c8 40 99 d9 fd 7f 00 00
00a2h mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
00a7h call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47CDE0h:jmp64]                encoding(5 bytes) = e8 34 cd 47 5f
00ach mov rax,18720056C20h          ; MOV(Mov_r64_imm64) [RAX,18720056c20h:imm64]          encoding(10 bytes) = 48 b8 20 6c 05 20 87 01 00 00
00b6h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
00b9h movsx rax,byte ptr [rax+8]    ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RAX:br,DS:sr)]      encoding(5 bytes) = 48 0f be 40 08
00beh add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
00c2h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00c3h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> dotBytes => new byte[196]{0x56,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF1,0x48,0x23,0xF2,0x48,0xB9,0x40,0x7E,0x8F,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x0A,0x00,0x00,0x00,0xE8,0xEA,0x78,0x44,0x5F,0x48,0xBA,0x18,0x92,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x12,0x48,0x83,0xC2,0x08,0x48,0x8B,0x0A,0x8B,0x42,0x08,0x44,0x8B,0x42,0x0C,0x8B,0x52,0x10,0x33,0xD2,0xF3,0x48,0x0F,0xB8,0xD6,0x8B,0xD2,0x48,0x0F,0xAF,0xD1,0x8B,0xC8,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x28,0x48,0x8D,0x44,0x24,0x28,0xC4,0xE2,0xBB,0xF6,0xC9,0x4C,0x89,0x00,0x85,0xC9,0x74,0x28,0x48,0xB9,0xC8,0x40,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x05,0x00,0x00,0x00,0xE8,0x5C,0xCD,0x47,0x5F,0x48,0xB9,0x28,0x6C,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x09,0x48,0x0F,0xBE,0x41,0x08,0xEB,0x26,0x48,0xB9,0xC8,0x40,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x05,0x00,0x00,0x00,0xE8,0x34,0xCD,0x47,0x5F,0x48,0xB8,0x20,0x6C,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x00,0x48,0x0F,0xBE,0x40,0x08,0x48,0x83,0xC4,0x30,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 flip(BitVector4 src)
; location: [7FFDD9EE7BB0h, 7FFDD9EE7BD8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh shl eax,4                     ; SHL(Shl_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e0 04
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
0016h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
0019h shl eax,4                     ; SHL(Shl_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e0 04
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
0022h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
0025h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0x0F,0xB6,0xC0,0xC1,0xE0,0x04,0x0F,0xB6,0xC0,0xC1,0xF8,0x04,0x83,0xE0,0x0F,0xC1,0xE0,0x04,0x0F,0xB6,0xC0,0xC1,0xF8,0x04,0x83,0xE0,0x0F,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte TakeHi(byte src)
; location: [7FFDD9EE7BF0h, 7FFDD9EE7BFEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
000bh and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> TakeHiBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC1,0xF8,0x04,0x83,0xE0,0x0F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 flip(BitVector8 x)
; location: [7FFDD9EE7C10h, 7FFDD9EE7C20h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 flip(BitVector16 x)
; location: [7FFDD9EE7C40h, 7FFDD9EE7C4Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 flip(BitVector32 x)
; location: [7FFDD9EE7C60h, 7FFDD9EE7C69h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 flip(BitVector64 x)
; location: [7FFDD9EE7C80h, 7FFDD9EE7C8Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector8 flip(BitVector8 x, ref BitVector8 z)
; location: [7FFDD9EE7CA0h, 7FFDD9EE7CAFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),AL]            encoding(2 bytes) = 88 02
000ch mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0x88,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector16 flip(BitVector16 x, ref BitVector16 z)
; location: [7FFDD9EE7CC0h, 7FFDD9EE7CD0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah mov [rdx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RDX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 02
000dh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0x66,0x89,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector32 flip(BitVector32 x, ref BitVector32 z)
; location: [7FFDD9EE7CF0h, 7FFDD9EE7CFEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h mov [rdx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),EAX]        encoding(2 bytes) = 89 02
000bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0x89,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector64 flip(BitVector64 x, ref BitVector64 z)
; location: [7FFDD9EE7D10h, 7FFDD9EE7D21h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 02
000eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0x89,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector8 flip(ref BitVector8 x)
; location: [7FFDD9EE7D40h, 7FFDD9EE7D4Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h not byte ptr [rcx]            ; NOT(Not_rm8) [mem(8u,RCX:br,DS:sr)]                  encoding(2 bytes) = f6 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xF6,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector16 flip(ref BitVector16 x)
; location: [7FFDD9EE7D60h, 7FFDD9EE7D6Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h not word ptr [rcx]            ; NOT(Not_rm16) [mem(16u,RCX:br,DS:sr)]                encoding(3 bytes) = 66 f7 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x66,0xF7,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector32 flip(ref BitVector32 x)
; location: [7FFDD9EE7D80h, 7FFDD9EE7D8Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h not dword ptr [rcx]           ; NOT(Not_rm32) [mem(32u,RCX:br,DS:sr)]                encoding(2 bytes) = f7 11
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xF7,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector64 flip(ref BitVector64 x)
; location: [7FFDD9EE7DA0h, 7FFDD9EE7DABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h not qword ptr [rcx]           ; NOT(Not_rm64) [mem(64u,RCX:br,DS:sr)]                encoding(3 bytes) = 48 f7 11
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> flipBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xF7,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 from(sbyte src)
; location: [7FFDD9EE7DC0h, 7FFDD9EE7DCFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fromBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 from(byte src)
; location: [7FFDD9EE7DE0h, 7FFDD9EE7DEBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fromBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 from(short src)
; location: [7FFDD9EE7E00h, 7FFDD9EE7E0Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fromBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 from(ushort src)
; location: [7FFDD9EE7E20h, 7FFDD9EE7E28h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fromBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 from(int src)
; location: [7FFDD9EE7E40h, 7FFDD9EE7E47h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fromBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 from(uint src)
; location: [7FFDD9EE7E60h, 7FFDD9EE7E67h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fromBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 from(long src)
; location: [7FFDD9EE7E80h, 7FFDD9EE7E88h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fromBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 from(ulong src)
; location: [7FFDD9EE7EA0h, 7FFDD9EE7EA8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fromBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 from(float src)
; location: [7FFDD9EE7EC0h, 7FFDD9EE7ED3h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
000bh mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 04
000fh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fromBytes => new byte[20]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFA,0x11,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 from(double src)
; location: [7FFDD9EE7EF0h, 7FFDD9EE7F02h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovsd qword ptr [rsp],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 04 24
000ah mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 04 24
000eh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> fromBytes => new byte[19]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFB,0x11,0x04,0x24,0x48,0x8B,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector8 inc(ref BitVector8 x)
; location: [7FFDD9EE7F20h, 7FFDD9EE7F2Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc byte ptr [rcx]            ; INC(Inc_rm8) [mem(8u,RCX:br,DS:sr)]                  encoding(2 bytes) = fe 01
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xFE,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 inc(BitVector8 x)
; location: [7FFDD9EE7F40h, 7FFDD9EE7F53h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xFF,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector16 inc(ref BitVector16 x)
; location: [7FFDD9EE7F70h, 7FFDD9EE7F7Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc word ptr [rcx]            ; INC(Inc_rm16) [mem(16u,RCX:br,DS:sr)]                encoding(3 bytes) = 66 ff 01
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x66,0xFF,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 inc(BitVector16 x)
; location: [7FFDD9EE7F90h, 7FFDD9EE7FA0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xFF,0xC0,0x0F,0xB7,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector32 inc(ref BitVector32 x)
; location: [7FFDD9EE7FC0h, 7FFDD9EE7FCAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc dword ptr [rcx]           ; INC(Inc_rm32) [mem(32u,RCX:br,DS:sr)]                encoding(2 bytes) = ff 01
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 inc(BitVector32 x)
; location: [7FFDD9EE7FE0h, 7FFDD9EE7FE8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 41 01
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector64 inc(ref BitVector64 x)
; location: [7FFDD9EE8000h, 7FFDD9EE800Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h inc qword ptr [rcx]           ; INC(Inc_rm64) [mem(64u,RCX:br,DS:sr)]                encoding(3 bytes) = 48 ff 01
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xFF,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 inc(BitVector64 x)
; location: [7FFDD9EE8020h, 7FFDD9EE8029h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 41 01
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> incBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 mask(Perm spec, out BitVector4 mask)
; location: [7FFDD9EE81A0h, 7FFDD9EE8299h]
0000h push r15                      ; PUSH(Push_r64) [R15]                                 encoding(2 bytes) = 41 57
0002h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0004h push r12                      ; PUSH(Push_r64) [R12]                                 encoding(2 bytes) = 41 54
0006h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0007h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0008h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0009h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
000ah sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
000eh mov rdi,rcx                   ; MOV(Mov_r64_rm64) [RDI,RCX]                          encoding(3 bytes) = 48 8b f9
0011h mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0014h mov byte ptr [rsi],0          ; MOV(Mov_rm8_imm8) [mem(8u,RSI:br,DS:sr),0h:imm8]     encoding(3 bytes) = c6 06 00
0017h mov ebx,[rdi+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,RDI:br,DS:sr)]        encoding(3 bytes) = 8b 5f 08
001ah mov ebp,ebx                   ; MOV(Mov_r32_rm32) [EBP,EBX]                          encoding(2 bytes) = 8b eb
001ch cmp ebp,4                     ; CMP(Cmp_rm32_imm8) [EBP,4h:imm32]                    encoding(3 bytes) = 83 fd 04
001fh jl short 0029h                ; JL(Jl_rel8_64) [29h:jmp64]                           encoding(2 bytes) = 7c 08
0021h mov r14d,4                    ; MOV(Mov_r32_imm32) [R14D,4h:imm32]                   encoding(6 bytes) = 41 be 04 00 00 00
0027h jmp short 002ch               ; JMP(Jmp_rel8_64) [2Ch:jmp64]                         encoding(2 bytes) = eb 03
0029h mov r14d,ebp                  ; MOV(Mov_r32_rm32) [R14D,EBP]                         encoding(3 bytes) = 44 8b f5
002ch xor ebp,ebp                   ; XOR(Xor_r32_rm32) [EBP,EBP]                          encoding(2 bytes) = 33 ed
002eh test r14d,r14d                ; TEST(Test_rm32_r32) [R14D,R14D]                      encoding(3 bytes) = 45 85 f6
0031h jle near ptr 00e1h            ; JLE(Jle_rel32_64) [E1h:jmp64]                        encoding(6 bytes) = 0f 8e aa 00 00 00
0037h cmp ebp,ebx                   ; CMP(Cmp_r32_rm32) [EBP,EBX]                          encoding(2 bytes) = 3b eb
0039h jae near ptr 00f4h            ; JAE(Jae_rel32_64) [F4h:jmp64]                        encoding(6 bytes) = 0f 83 b5 00 00 00
003fh movsxd rcx,ebp                ; MOVSXD(Movsxd_r64_rm32) [RCX,EBP]                    encoding(3 bytes) = 48 63 cd
0042h mov ecx,[rdi+rcx*4+10h]       ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDI:br,DS:sr)]        encoding(4 bytes) = 8b 4c 8f 10
0046h movzx r15d,cl                 ; MOVZX(Movzx_r32_rm8) [R15D,CL]                       encoding(4 bytes) = 44 0f b6 f9
004ah test ebp,ebp                  ; TEST(Test_rm32_r32) [EBP,EBP]                        encoding(2 bytes) = 85 ed
004ch je short 0076h                ; JE(Je_rel8_64) [76h:jmp64]                           encoding(2 bytes) = 74 28
004eh mov rcx,7FFDD99940C8h         ; MOV(Mov_r64_imm64) [RCX,7ffdd99940c8h:imm64]         encoding(10 bytes) = 48 b9 c8 40 99 d9 fd 7f 00 00
0058h mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
005dh call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47C710h:jmp64]                encoding(5 bytes) = e8 ae c6 47 5f
0062h mov rcx,18720056C28h          ; MOV(Mov_r64_imm64) [RCX,18720056c28h:imm64]          encoding(10 bytes) = 48 b9 28 6c 05 20 87 01 00 00
006ch mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
006fh movsx r12,byte ptr [rcx+8]    ; MOVSX(Movsx_r64_rm8) [R12,mem(8i,RCX:br,DS:sr)]      encoding(5 bytes) = 4c 0f be 61 08
0074h jmp short 009ch               ; JMP(Jmp_rel8_64) [9Ch:jmp64]                         encoding(2 bytes) = eb 26
0076h mov rcx,7FFDD99940C8h         ; MOV(Mov_r64_imm64) [RCX,7ffdd99940c8h:imm64]         encoding(10 bytes) = 48 b9 c8 40 99 d9 fd 7f 00 00
0080h mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
0085h call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47C710h:jmp64]                encoding(5 bytes) = e8 86 c6 47 5f
008ah mov rcx,18720056C20h          ; MOV(Mov_r64_imm64) [RCX,18720056c20h:imm64]          encoding(10 bytes) = 48 b9 20 6c 05 20 87 01 00 00
0094h mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
0097h movsx r12,byte ptr [rcx+8]    ; MOVSX(Movsx_r64_rm8) [R12,mem(8i,RCX:br,DS:sr)]      encoding(5 bytes) = 4c 0f be 61 08
009ch mov [rsp+28h],r12b            ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),R12L]          encoding(5 bytes) = 44 88 64 24 28
00a1h mov ecx,r15d                  ; MOV(Mov_r32_rm32) [ECX,R15D]                         encoding(3 bytes) = 41 8b cf
00a4h movzx eax,byte ptr [rsp+28h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 28
00a9h test al,al                    ; TEST(Test_rm8_r8) [AL,AL]                            encoding(2 bytes) = 84 c0
00abh je short 00c0h                ; JE(Je_rel8_64) [C0h:jmp64]                           encoding(2 bytes) = 74 13
00adh movzx eax,byte ptr [rsi]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSI:br,DS:sr)]      encoding(3 bytes) = 0f b6 06
00b0h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
00b5h shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
00b7h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
00bah or ecx,eax                    ; OR(Or_r32_rm32) [ECX,EAX]                            encoding(2 bytes) = 0b c8
00bch mov [rsi],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RSI:br,DS:sr),CL]            encoding(2 bytes) = 88 0e
00beh jmp short 00d6h               ; JMP(Jmp_rel8_64) [D6h:jmp64]                         encoding(2 bytes) = eb 16
00c0h movzx eax,byte ptr [rsi]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSI:br,DS:sr)]      encoding(3 bytes) = 0f b6 06
00c3h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
00c8h shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
00cah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
00cdh not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
00cfh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
00d2h and eax,edx                   ; AND(And_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 23 c2
00d4h mov [rsi],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSI:br,DS:sr),AL]            encoding(2 bytes) = 88 06
00d6h inc ebp                       ; INC(Inc_rm32) [EBP]                                  encoding(2 bytes) = ff c5
00d8h cmp ebp,r14d                  ; CMP(Cmp_r32_rm32) [EBP,R14D]                         encoding(3 bytes) = 41 3b ee
00dbh jl near ptr 0037h             ; JL(Jl_rel32_64) [37h:jmp64]                          encoding(6 bytes) = 0f 8c 56 ff ff ff
00e1h movsx rax,byte ptr [rsi]      ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RSI:br,DS:sr)]      encoding(4 bytes) = 48 0f be 06
00e5h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
00e9h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00eah pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
00ebh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00ech pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00edh pop r12                       ; POP(Pop_r64) [R12]                                   encoding(2 bytes) = 41 5c
00efh pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
00f1h pop r15                       ; POP(Pop_r64) [R15]                                   encoding(2 bytes) = 41 5f
00f3h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00f4h call 7FFE3948EF00h            ; CALL(Call_rel32_64) [5F5A6D60h:jmp64]                encoding(5 bytes) = e8 67 6c 5a 5f
00f9h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> maskBytes => new byte[250]{0x41,0x57,0x41,0x56,0x41,0x54,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x30,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0xC6,0x06,0x00,0x8B,0x5F,0x08,0x8B,0xEB,0x83,0xFD,0x04,0x7C,0x08,0x41,0xBE,0x04,0x00,0x00,0x00,0xEB,0x03,0x44,0x8B,0xF5,0x33,0xED,0x45,0x85,0xF6,0x0F,0x8E,0xAA,0x00,0x00,0x00,0x3B,0xEB,0x0F,0x83,0xB5,0x00,0x00,0x00,0x48,0x63,0xCD,0x8B,0x4C,0x8F,0x10,0x44,0x0F,0xB6,0xF9,0x85,0xED,0x74,0x28,0x48,0xB9,0xC8,0x40,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x05,0x00,0x00,0x00,0xE8,0xAE,0xC6,0x47,0x5F,0x48,0xB9,0x28,0x6C,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x09,0x4C,0x0F,0xBE,0x61,0x08,0xEB,0x26,0x48,0xB9,0xC8,0x40,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x05,0x00,0x00,0x00,0xE8,0x86,0xC6,0x47,0x5F,0x48,0xB9,0x20,0x6C,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x09,0x4C,0x0F,0xBE,0x61,0x08,0x44,0x88,0x64,0x24,0x28,0x41,0x8B,0xCF,0x0F,0xB6,0x44,0x24,0x28,0x84,0xC0,0x74,0x13,0x0F,0xB6,0x06,0xBA,0x01,0x00,0x00,0x00,0xD3,0xE2,0x0F,0xB6,0xCA,0x0B,0xC8,0x88,0x0E,0xEB,0x16,0x0F,0xB6,0x06,0xBA,0x01,0x00,0x00,0x00,0xD3,0xE2,0x0F,0xB6,0xD2,0xF7,0xD2,0x0F,0xB6,0xD2,0x23,0xC2,0x88,0x06,0xFF,0xC5,0x41,0x3B,0xEE,0x0F,0x8C,0x56,0xFF,0xFF,0xFF,0x48,0x0F,0xBE,0x06,0x48,0x83,0xC4,0x30,0x5B,0x5D,0x5E,0x5F,0x41,0x5C,0x41,0x5E,0x41,0x5F,0xC3,0xE8,0x67,0x6C,0x5A,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector8 mask(Perm spec, out BitVector8 mask)
; location: [7FFDD9EE85E0h, 7FFDD9EE86D3h]
0000h push r15                      ; PUSH(Push_r64) [R15]                                 encoding(2 bytes) = 41 57
0002h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0004h push r12                      ; PUSH(Push_r64) [R12]                                 encoding(2 bytes) = 41 54
0006h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0007h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0008h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0009h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
000ah sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
000eh mov rdi,rcx                   ; MOV(Mov_r64_rm64) [RDI,RCX]                          encoding(3 bytes) = 48 8b f9
0011h mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0014h mov byte ptr [rsi],0          ; MOV(Mov_rm8_imm8) [mem(8u,RSI:br,DS:sr),0h:imm8]     encoding(3 bytes) = c6 06 00
0017h mov ebx,[rdi+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,RDI:br,DS:sr)]        encoding(3 bytes) = 8b 5f 08
001ah mov ebp,ebx                   ; MOV(Mov_r32_rm32) [EBP,EBX]                          encoding(2 bytes) = 8b eb
001ch cmp ebp,8                     ; CMP(Cmp_rm32_imm8) [EBP,8h:imm32]                    encoding(3 bytes) = 83 fd 08
001fh jl short 0029h                ; JL(Jl_rel8_64) [29h:jmp64]                           encoding(2 bytes) = 7c 08
0021h mov r14d,8                    ; MOV(Mov_r32_imm32) [R14D,8h:imm32]                   encoding(6 bytes) = 41 be 08 00 00 00
0027h jmp short 002ch               ; JMP(Jmp_rel8_64) [2Ch:jmp64]                         encoding(2 bytes) = eb 03
0029h mov r14d,ebp                  ; MOV(Mov_r32_rm32) [R14D,EBP]                         encoding(3 bytes) = 44 8b f5
002ch xor ebp,ebp                   ; XOR(Xor_r32_rm32) [EBP,EBP]                          encoding(2 bytes) = 33 ed
002eh test r14d,r14d                ; TEST(Test_rm32_r32) [R14D,R14D]                      encoding(3 bytes) = 45 85 f6
0031h jle near ptr 00dch            ; JLE(Jle_rel32_64) [DCh:jmp64]                        encoding(6 bytes) = 0f 8e a5 00 00 00
0037h cmp ebp,ebx                   ; CMP(Cmp_r32_rm32) [EBP,EBX]                          encoding(2 bytes) = 3b eb
0039h jae near ptr 00eeh            ; JAE(Jae_rel32_64) [EEh:jmp64]                        encoding(6 bytes) = 0f 83 af 00 00 00
003fh movsxd rcx,ebp                ; MOVSXD(Movsxd_r64_rm32) [RCX,EBP]                    encoding(3 bytes) = 48 63 cd
0042h mov ecx,[rdi+rcx*4+10h]       ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDI:br,DS:sr)]        encoding(4 bytes) = 8b 4c 8f 10
0046h movzx r15d,cl                 ; MOVZX(Movzx_r32_rm8) [R15D,CL]                       encoding(4 bytes) = 44 0f b6 f9
004ah test ebp,ebp                  ; TEST(Test_rm32_r32) [EBP,EBP]                        encoding(2 bytes) = 85 ed
004ch je short 0076h                ; JE(Je_rel8_64) [76h:jmp64]                           encoding(2 bytes) = 74 28
004eh mov rcx,7FFDD99940C8h         ; MOV(Mov_r64_imm64) [RCX,7ffdd99940c8h:imm64]         encoding(10 bytes) = 48 b9 c8 40 99 d9 fd 7f 00 00
0058h mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
005dh call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47C2D0h:jmp64]                encoding(5 bytes) = e8 6e c2 47 5f
0062h mov rcx,18720056C28h          ; MOV(Mov_r64_imm64) [RCX,18720056c28h:imm64]          encoding(10 bytes) = 48 b9 28 6c 05 20 87 01 00 00
006ch mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
006fh movsx r12,byte ptr [rcx+8]    ; MOVSX(Movsx_r64_rm8) [R12,mem(8i,RCX:br,DS:sr)]      encoding(5 bytes) = 4c 0f be 61 08
0074h jmp short 009ch               ; JMP(Jmp_rel8_64) [9Ch:jmp64]                         encoding(2 bytes) = eb 26
0076h mov rcx,7FFDD99940C8h         ; MOV(Mov_r64_imm64) [RCX,7ffdd99940c8h:imm64]         encoding(10 bytes) = 48 b9 c8 40 99 d9 fd 7f 00 00
0080h mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
0085h call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47C2D0h:jmp64]                encoding(5 bytes) = e8 46 c2 47 5f
008ah mov rcx,18720056C20h          ; MOV(Mov_r64_imm64) [RCX,18720056c20h:imm64]          encoding(10 bytes) = 48 b9 20 6c 05 20 87 01 00 00
0094h mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
0097h movsx r12,byte ptr [rcx+8]    ; MOVSX(Movsx_r64_rm8) [R12,mem(8i,RCX:br,DS:sr)]      encoding(5 bytes) = 4c 0f be 61 08
009ch mov [rsp+28h],r12b            ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),R12L]          encoding(5 bytes) = 44 88 64 24 28
00a1h movzx ecx,byte ptr [rsp+28h]  ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 4c 24 28
00a6h movzx eax,r15b                ; MOVZX(Movzx_r32_rm8) [EAX,R15L]                      encoding(4 bytes) = 41 0f b6 c7
00aah test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
00ach je short 00beh                ; JE(Je_rel8_64) [BEh:jmp64]                           encoding(2 bytes) = 74 10
00aeh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
00b3h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
00b5h shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
00b7h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
00bah or [rsi],al                   ; OR(Or_rm8_r8) [mem(8u,RSI:br,DS:sr),AL]              encoding(2 bytes) = 08 06
00bch jmp short 00d1h               ; JMP(Jmp_rel8_64) [D1h:jmp64]                         encoding(2 bytes) = eb 13
00beh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
00c3h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
00c5h shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
00c7h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
00cah not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
00cch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00cfh and [rsi],al                  ; AND(And_rm8_r8) [mem(8u,RSI:br,DS:sr),AL]            encoding(2 bytes) = 20 06
00d1h inc ebp                       ; INC(Inc_rm32) [EBP]                                  encoding(2 bytes) = ff c5
00d3h cmp ebp,r14d                  ; CMP(Cmp_r32_rm32) [EBP,R14D]                         encoding(3 bytes) = 41 3b ee
00d6h jl near ptr 0037h             ; JL(Jl_rel32_64) [37h:jmp64]                          encoding(6 bytes) = 0f 8c 5b ff ff ff
00dch mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
00dfh add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
00e3h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00e4h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
00e5h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00e6h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00e7h pop r12                       ; POP(Pop_r64) [R12]                                   encoding(2 bytes) = 41 5c
00e9h pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
00ebh pop r15                       ; POP(Pop_r64) [R15]                                   encoding(2 bytes) = 41 5f
00edh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00eeh call 7FFE3948EF00h            ; CALL(Call_rel32_64) [5F5A6920h:jmp64]                encoding(5 bytes) = e8 2d 68 5a 5f
00f3h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> maskBytes => new byte[244]{0x41,0x57,0x41,0x56,0x41,0x54,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x30,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0xC6,0x06,0x00,0x8B,0x5F,0x08,0x8B,0xEB,0x83,0xFD,0x08,0x7C,0x08,0x41,0xBE,0x08,0x00,0x00,0x00,0xEB,0x03,0x44,0x8B,0xF5,0x33,0xED,0x45,0x85,0xF6,0x0F,0x8E,0xA5,0x00,0x00,0x00,0x3B,0xEB,0x0F,0x83,0xAF,0x00,0x00,0x00,0x48,0x63,0xCD,0x8B,0x4C,0x8F,0x10,0x44,0x0F,0xB6,0xF9,0x85,0xED,0x74,0x28,0x48,0xB9,0xC8,0x40,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x05,0x00,0x00,0x00,0xE8,0x6E,0xC2,0x47,0x5F,0x48,0xB9,0x28,0x6C,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x09,0x4C,0x0F,0xBE,0x61,0x08,0xEB,0x26,0x48,0xB9,0xC8,0x40,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x05,0x00,0x00,0x00,0xE8,0x46,0xC2,0x47,0x5F,0x48,0xB9,0x20,0x6C,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x09,0x4C,0x0F,0xBE,0x61,0x08,0x44,0x88,0x64,0x24,0x28,0x0F,0xB6,0x4C,0x24,0x28,0x41,0x0F,0xB6,0xC7,0x84,0xC9,0x74,0x10,0xBA,0x01,0x00,0x00,0x00,0x8B,0xC8,0xD3,0xE2,0x0F,0xB6,0xC2,0x08,0x06,0xEB,0x13,0xBA,0x01,0x00,0x00,0x00,0x8B,0xC8,0xD3,0xE2,0x0F,0xB6,0xC2,0xF7,0xD0,0x0F,0xB6,0xC0,0x20,0x06,0xFF,0xC5,0x41,0x3B,0xEE,0x0F,0x8C,0x5B,0xFF,0xFF,0xFF,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x30,0x5B,0x5D,0x5E,0x5F,0x41,0x5C,0x41,0x5E,0x41,0x5F,0xC3,0xE8,0x2D,0x68,0x5A,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector16 mask(Perm spec, out BitVector16 mask)
; location: [7FFDD9EE8700h, 7FFDD9EE87F7h]
0000h push r15                      ; PUSH(Push_r64) [R15]                                 encoding(2 bytes) = 41 57
0002h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0004h push r12                      ; PUSH(Push_r64) [R12]                                 encoding(2 bytes) = 41 54
0006h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0007h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0008h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0009h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
000ah sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
000eh mov rdi,rcx                   ; MOV(Mov_r64_rm64) [RDI,RCX]                          encoding(3 bytes) = 48 8b f9
0011h mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0014h mov word ptr [rsi],0          ; MOV(Mov_rm16_imm16) [mem(16u,RSI:br,DS:sr),0h:imm16] encoding(5 bytes) = 66 c7 06 00 00
0019h mov ebx,[rdi+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,RDI:br,DS:sr)]        encoding(3 bytes) = 8b 5f 08
001ch mov ebp,ebx                   ; MOV(Mov_r32_rm32) [EBP,EBX]                          encoding(2 bytes) = 8b eb
001eh cmp ebp,10h                   ; CMP(Cmp_rm32_imm8) [EBP,10h:imm32]                   encoding(3 bytes) = 83 fd 10
0021h jl short 002bh                ; JL(Jl_rel8_64) [2Bh:jmp64]                           encoding(2 bytes) = 7c 08
0023h mov r14d,10h                  ; MOV(Mov_r32_imm32) [R14D,10h:imm32]                  encoding(6 bytes) = 41 be 10 00 00 00
0029h jmp short 002eh               ; JMP(Jmp_rel8_64) [2Eh:jmp64]                         encoding(2 bytes) = eb 03
002bh mov r14d,ebp                  ; MOV(Mov_r32_rm32) [R14D,EBP]                         encoding(3 bytes) = 44 8b f5
002eh xor ebp,ebp                   ; XOR(Xor_r32_rm32) [EBP,EBP]                          encoding(2 bytes) = 33 ed
0030h test r14d,r14d                ; TEST(Test_rm32_r32) [R14D,R14D]                      encoding(3 bytes) = 45 85 f6
0033h jle near ptr 00e0h            ; JLE(Jle_rel32_64) [E0h:jmp64]                        encoding(6 bytes) = 0f 8e a7 00 00 00
0039h cmp ebp,ebx                   ; CMP(Cmp_r32_rm32) [EBP,EBX]                          encoding(2 bytes) = 3b eb
003bh jae near ptr 00f2h            ; JAE(Jae_rel32_64) [F2h:jmp64]                        encoding(6 bytes) = 0f 83 b1 00 00 00
0041h movsxd rcx,ebp                ; MOVSXD(Movsxd_r64_rm32) [RCX,EBP]                    encoding(3 bytes) = 48 63 cd
0044h mov ecx,[rdi+rcx*4+10h]       ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDI:br,DS:sr)]        encoding(4 bytes) = 8b 4c 8f 10
0048h movzx r15d,cl                 ; MOVZX(Movzx_r32_rm8) [R15D,CL]                       encoding(4 bytes) = 44 0f b6 f9
004ch test ebp,ebp                  ; TEST(Test_rm32_r32) [EBP,EBP]                        encoding(2 bytes) = 85 ed
004eh je short 0078h                ; JE(Je_rel8_64) [78h:jmp64]                           encoding(2 bytes) = 74 28
0050h mov rcx,7FFDD99940C8h         ; MOV(Mov_r64_imm64) [RCX,7ffdd99940c8h:imm64]         encoding(10 bytes) = 48 b9 c8 40 99 d9 fd 7f 00 00
005ah mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
005fh call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47C1B0h:jmp64]                encoding(5 bytes) = e8 4c c1 47 5f
0064h mov rcx,18720056C28h          ; MOV(Mov_r64_imm64) [RCX,18720056c28h:imm64]          encoding(10 bytes) = 48 b9 28 6c 05 20 87 01 00 00
006eh mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
0071h movsx r12,byte ptr [rcx+8]    ; MOVSX(Movsx_r64_rm8) [R12,mem(8i,RCX:br,DS:sr)]      encoding(5 bytes) = 4c 0f be 61 08
0076h jmp short 009eh               ; JMP(Jmp_rel8_64) [9Eh:jmp64]                         encoding(2 bytes) = eb 26
0078h mov rcx,7FFDD99940C8h         ; MOV(Mov_r64_imm64) [RCX,7ffdd99940c8h:imm64]         encoding(10 bytes) = 48 b9 c8 40 99 d9 fd 7f 00 00
0082h mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
0087h call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47C1B0h:jmp64]                encoding(5 bytes) = e8 24 c1 47 5f
008ch mov rcx,18720056C20h          ; MOV(Mov_r64_imm64) [RCX,18720056c20h:imm64]          encoding(10 bytes) = 48 b9 20 6c 05 20 87 01 00 00
0096h mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
0099h movsx r12,byte ptr [rcx+8]    ; MOVSX(Movsx_r64_rm8) [R12,mem(8i,RCX:br,DS:sr)]      encoding(5 bytes) = 4c 0f be 61 08
009eh mov [rsp+28h],r12b            ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),R12L]          encoding(5 bytes) = 44 88 64 24 28
00a3h movzx ecx,byte ptr [rsp+28h]  ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 4c 24 28
00a8h movzx eax,r15b                ; MOVZX(Movzx_r32_rm8) [EAX,R15L]                      encoding(4 bytes) = 41 0f b6 c7
00ach test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
00aeh je short 00c1h                ; JE(Je_rel8_64) [C1h:jmp64]                           encoding(2 bytes) = 74 11
00b0h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
00b5h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
00b7h shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
00b9h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
00bch or [rsi],ax                   ; OR(Or_rm16_r16) [mem(16u,RSI:br,DS:sr),AX]           encoding(3 bytes) = 66 09 06
00bfh jmp short 00d5h               ; JMP(Jmp_rel8_64) [D5h:jmp64]                         encoding(2 bytes) = eb 14
00c1h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
00c6h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
00c8h shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
00cah movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
00cdh not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
00cfh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
00d2h and [rsi],ax                  ; AND(And_rm16_r16) [mem(16u,RSI:br,DS:sr),AX]         encoding(3 bytes) = 66 21 06
00d5h inc ebp                       ; INC(Inc_rm32) [EBP]                                  encoding(2 bytes) = ff c5
00d7h cmp ebp,r14d                  ; CMP(Cmp_r32_rm32) [EBP,R14D]                         encoding(3 bytes) = 41 3b ee
00dah jl near ptr 0039h             ; JL(Jl_rel32_64) [39h:jmp64]                          encoding(6 bytes) = 0f 8c 59 ff ff ff
00e0h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
00e3h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
00e7h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00e8h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
00e9h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00eah pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00ebh pop r12                       ; POP(Pop_r64) [R12]                                   encoding(2 bytes) = 41 5c
00edh pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
00efh pop r15                       ; POP(Pop_r64) [R15]                                   encoding(2 bytes) = 41 5f
00f1h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00f2h call 7FFE3948EF00h            ; CALL(Call_rel32_64) [5F5A6800h:jmp64]                encoding(5 bytes) = e8 09 67 5a 5f
00f7h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> maskBytes => new byte[248]{0x41,0x57,0x41,0x56,0x41,0x54,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x30,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0x66,0xC7,0x06,0x00,0x00,0x8B,0x5F,0x08,0x8B,0xEB,0x83,0xFD,0x10,0x7C,0x08,0x41,0xBE,0x10,0x00,0x00,0x00,0xEB,0x03,0x44,0x8B,0xF5,0x33,0xED,0x45,0x85,0xF6,0x0F,0x8E,0xA7,0x00,0x00,0x00,0x3B,0xEB,0x0F,0x83,0xB1,0x00,0x00,0x00,0x48,0x63,0xCD,0x8B,0x4C,0x8F,0x10,0x44,0x0F,0xB6,0xF9,0x85,0xED,0x74,0x28,0x48,0xB9,0xC8,0x40,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x05,0x00,0x00,0x00,0xE8,0x4C,0xC1,0x47,0x5F,0x48,0xB9,0x28,0x6C,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x09,0x4C,0x0F,0xBE,0x61,0x08,0xEB,0x26,0x48,0xB9,0xC8,0x40,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x05,0x00,0x00,0x00,0xE8,0x24,0xC1,0x47,0x5F,0x48,0xB9,0x20,0x6C,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x09,0x4C,0x0F,0xBE,0x61,0x08,0x44,0x88,0x64,0x24,0x28,0x0F,0xB6,0x4C,0x24,0x28,0x41,0x0F,0xB6,0xC7,0x84,0xC9,0x74,0x11,0xBA,0x01,0x00,0x00,0x00,0x8B,0xC8,0xD3,0xE2,0x0F,0xB7,0xC2,0x66,0x09,0x06,0xEB,0x14,0xBA,0x01,0x00,0x00,0x00,0x8B,0xC8,0xD3,0xE2,0x0F,0xB7,0xC2,0xF7,0xD0,0x0F,0xB7,0xC0,0x66,0x21,0x06,0xFF,0xC5,0x41,0x3B,0xEE,0x0F,0x8C,0x59,0xFF,0xFF,0xFF,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x30,0x5B,0x5D,0x5E,0x5F,0x41,0x5C,0x41,0x5E,0x41,0x5F,0xC3,0xE8,0x09,0x67,0x5A,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector32 mask(Perm spec, out BitVector32 mask)
; location: [7FFDD9EE8820h, 7FFDD9EE892Ch]
0000h push r15                      ; PUSH(Push_r64) [R15]                                 encoding(2 bytes) = 41 57
0002h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0004h push r12                      ; PUSH(Push_r64) [R12]                                 encoding(2 bytes) = 41 54
0006h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0007h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0008h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0009h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
000ah sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
000eh mov rdi,rcx                   ; MOV(Mov_r64_rm64) [RDI,RCX]                          encoding(3 bytes) = 48 8b f9
0011h mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0014h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0016h mov [rsi],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),ECX]        encoding(2 bytes) = 89 0e
0018h mov ebx,[rdi+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,RDI:br,DS:sr)]        encoding(3 bytes) = 8b 5f 08
001bh mov ebp,ebx                   ; MOV(Mov_r32_rm32) [EBP,EBX]                          encoding(2 bytes) = 8b eb
001dh mov rcx,7FFDD9997800h         ; MOV(Mov_r64_imm64) [RCX,7ffdd9997800h:imm64]         encoding(10 bytes) = 48 b9 00 78 99 d9 fd 7f 00 00
0027h mov edx,21h                   ; MOV(Mov_r32_imm32) [EDX,21h:imm32]                   encoding(5 bytes) = ba 21 00 00 00
002ch call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47C090h:jmp64]                encoding(5 bytes) = e8 5f c0 47 5f
0031h mov rcx,18720056E28h          ; MOV(Mov_r64_imm64) [RCX,18720056e28h:imm64]          encoding(10 bytes) = 48 b9 28 6e 05 20 87 01 00 00
003bh mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
003eh mov r14,[rcx+8]               ; MOV(Mov_r64_rm64) [R14,mem(64u,RCX:br,DS:sr)]        encoding(4 bytes) = 4c 8b 71 08
0042h cmp ebp,r14d                  ; CMP(Cmp_r32_rm32) [EBP,R14D]                         encoding(3 bytes) = 41 3b ee
0045h jl short 0049h                ; JL(Jl_rel8_64) [49h:jmp64]                           encoding(2 bytes) = 7c 02
0047h jmp short 004ch               ; JMP(Jmp_rel8_64) [4Ch:jmp64]                         encoding(2 bytes) = eb 03
0049h mov r14d,ebp                  ; MOV(Mov_r32_rm32) [R14D,EBP]                         encoding(3 bytes) = 44 8b f5
004ch xor ebp,ebp                   ; XOR(Xor_r32_rm32) [EBP,EBP]                          encoding(2 bytes) = 33 ed
004eh test r14d,r14d                ; TEST(Test_rm32_r32) [R14D,R14D]                      encoding(3 bytes) = 45 85 f6
0051h jle near ptr 00f5h            ; JLE(Jle_rel32_64) [F5h:jmp64]                        encoding(6 bytes) = 0f 8e 9e 00 00 00
0057h cmp ebp,ebx                   ; CMP(Cmp_r32_rm32) [EBP,EBX]                          encoding(2 bytes) = 3b eb
0059h jae near ptr 0107h            ; JAE(Jae_rel32_64) [107h:jmp64]                       encoding(6 bytes) = 0f 83 a8 00 00 00
005fh movsxd rcx,ebp                ; MOVSXD(Movsxd_r64_rm32) [RCX,EBP]                    encoding(3 bytes) = 48 63 cd
0062h mov ecx,[rdi+rcx*4+10h]       ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDI:br,DS:sr)]        encoding(4 bytes) = 8b 4c 8f 10
0066h movzx r15d,cl                 ; MOVZX(Movzx_r32_rm8) [R15D,CL]                       encoding(4 bytes) = 44 0f b6 f9
006ah test ebp,ebp                  ; TEST(Test_rm32_r32) [EBP,EBP]                        encoding(2 bytes) = 85 ed
006ch je short 0096h                ; JE(Je_rel8_64) [96h:jmp64]                           encoding(2 bytes) = 74 28
006eh mov rcx,7FFDD99940C8h         ; MOV(Mov_r64_imm64) [RCX,7ffdd99940c8h:imm64]         encoding(10 bytes) = 48 b9 c8 40 99 d9 fd 7f 00 00
0078h mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
007dh call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47C090h:jmp64]                encoding(5 bytes) = e8 0e c0 47 5f
0082h mov rcx,18720056C28h          ; MOV(Mov_r64_imm64) [RCX,18720056c28h:imm64]          encoding(10 bytes) = 48 b9 28 6c 05 20 87 01 00 00
008ch mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
008fh movsx r12,byte ptr [rcx+8]    ; MOVSX(Movsx_r64_rm8) [R12,mem(8i,RCX:br,DS:sr)]      encoding(5 bytes) = 4c 0f be 61 08
0094h jmp short 00bch               ; JMP(Jmp_rel8_64) [BCh:jmp64]                         encoding(2 bytes) = eb 26
0096h mov rcx,7FFDD99940C8h         ; MOV(Mov_r64_imm64) [RCX,7ffdd99940c8h:imm64]         encoding(10 bytes) = 48 b9 c8 40 99 d9 fd 7f 00 00
00a0h mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
00a5h call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47C090h:jmp64]                encoding(5 bytes) = e8 e6 bf 47 5f
00aah mov rcx,18720056C20h          ; MOV(Mov_r64_imm64) [RCX,18720056c20h:imm64]          encoding(10 bytes) = 48 b9 20 6c 05 20 87 01 00 00
00b4h mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
00b7h movsx r12,byte ptr [rcx+8]    ; MOVSX(Movsx_r64_rm8) [R12,mem(8i,RCX:br,DS:sr)]      encoding(5 bytes) = 4c 0f be 61 08
00bch mov [rsp+28h],r12b            ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),R12L]          encoding(5 bytes) = 44 88 64 24 28
00c1h movzx ecx,byte ptr [rsp+28h]  ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 4c 24 28
00c6h movzx eax,r15b                ; MOVZX(Movzx_r32_rm8) [EAX,R15L]                      encoding(4 bytes) = 41 0f b6 c7
00cah test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
00cch je short 00dbh                ; JE(Je_rel8_64) [DBh:jmp64]                           encoding(2 bytes) = 74 0d
00ceh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
00d3h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
00d5h shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
00d7h or [rsi],edx                  ; OR(Or_rm32_r32) [mem(32u,RSI:br,DS:sr),EDX]          encoding(2 bytes) = 09 16
00d9h jmp short 00eah               ; JMP(Jmp_rel8_64) [EAh:jmp64]                         encoding(2 bytes) = eb 0f
00dbh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
00e0h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
00e2h shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
00e4h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
00e6h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
00e8h and [rsi],eax                 ; AND(And_rm32_r32) [mem(32u,RSI:br,DS:sr),EAX]        encoding(2 bytes) = 21 06
00eah inc ebp                       ; INC(Inc_rm32) [EBP]                                  encoding(2 bytes) = ff c5
00ech cmp ebp,r14d                  ; CMP(Cmp_r32_rm32) [EBP,R14D]                         encoding(3 bytes) = 41 3b ee
00efh jl near ptr 0057h             ; JL(Jl_rel32_64) [57h:jmp64]                          encoding(6 bytes) = 0f 8c 62 ff ff ff
00f5h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
00f8h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
00fch pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00fdh pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
00feh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00ffh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0100h pop r12                       ; POP(Pop_r64) [R12]                                   encoding(2 bytes) = 41 5c
0102h pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
0104h pop r15                       ; POP(Pop_r64) [R15]                                   encoding(2 bytes) = 41 5f
0106h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0107h call 7FFE3948EF00h            ; CALL(Call_rel32_64) [5F5A66E0h:jmp64]                encoding(5 bytes) = e8 d4 65 5a 5f
010ch int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> maskBytes => new byte[269]{0x41,0x57,0x41,0x56,0x41,0x54,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x30,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0x33,0xC9,0x89,0x0E,0x8B,0x5F,0x08,0x8B,0xEB,0x48,0xB9,0x00,0x78,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x21,0x00,0x00,0x00,0xE8,0x5F,0xC0,0x47,0x5F,0x48,0xB9,0x28,0x6E,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x09,0x4C,0x8B,0x71,0x08,0x41,0x3B,0xEE,0x7C,0x02,0xEB,0x03,0x44,0x8B,0xF5,0x33,0xED,0x45,0x85,0xF6,0x0F,0x8E,0x9E,0x00,0x00,0x00,0x3B,0xEB,0x0F,0x83,0xA8,0x00,0x00,0x00,0x48,0x63,0xCD,0x8B,0x4C,0x8F,0x10,0x44,0x0F,0xB6,0xF9,0x85,0xED,0x74,0x28,0x48,0xB9,0xC8,0x40,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x05,0x00,0x00,0x00,0xE8,0x0E,0xC0,0x47,0x5F,0x48,0xB9,0x28,0x6C,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x09,0x4C,0x0F,0xBE,0x61,0x08,0xEB,0x26,0x48,0xB9,0xC8,0x40,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x05,0x00,0x00,0x00,0xE8,0xE6,0xBF,0x47,0x5F,0x48,0xB9,0x20,0x6C,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x09,0x4C,0x0F,0xBE,0x61,0x08,0x44,0x88,0x64,0x24,0x28,0x0F,0xB6,0x4C,0x24,0x28,0x41,0x0F,0xB6,0xC7,0x84,0xC9,0x74,0x0D,0xBA,0x01,0x00,0x00,0x00,0x8B,0xC8,0xD3,0xE2,0x09,0x16,0xEB,0x0F,0xBA,0x01,0x00,0x00,0x00,0x8B,0xC8,0xD3,0xE2,0x8B,0xC2,0xF7,0xD0,0x21,0x06,0xFF,0xC5,0x41,0x3B,0xEE,0x0F,0x8C,0x62,0xFF,0xFF,0xFF,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x30,0x5B,0x5D,0x5E,0x5F,0x41,0x5C,0x41,0x5E,0x41,0x5F,0xC3,0xE8,0xD4,0x65,0x5A,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector64 mask(Perm spec, out BitVector64 mask)
; location: [7FFDD9EE8950h, 7FFDD9EE8A66h]
0000h push r15                      ; PUSH(Push_r64) [R15]                                 encoding(2 bytes) = 41 57
0002h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0004h push r12                      ; PUSH(Push_r64) [R12]                                 encoding(2 bytes) = 41 54
0006h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0007h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0008h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0009h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
000ah sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
000eh mov rdi,rcx                   ; MOV(Mov_r64_rm64) [RDI,RCX]                          encoding(3 bytes) = 48 8b f9
0011h mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0014h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0016h mov [rsi],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RCX]        encoding(3 bytes) = 48 89 0e
0019h mov ebx,[rdi+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,RDI:br,DS:sr)]        encoding(3 bytes) = 8b 5f 08
001ch mov ebp,ebx                   ; MOV(Mov_r32_rm32) [EBP,EBX]                          encoding(2 bytes) = 8b eb
001eh mov rcx,7FFDD9997800h         ; MOV(Mov_r64_imm64) [RCX,7ffdd9997800h:imm64]         encoding(10 bytes) = 48 b9 00 78 99 d9 fd 7f 00 00
0028h mov edx,23h                   ; MOV(Mov_r32_imm32) [EDX,23h:imm32]                   encoding(5 bytes) = ba 23 00 00 00
002dh call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47BF60h:jmp64]                encoding(5 bytes) = e8 2e bf 47 5f
0032h mov rcx,18720056E78h          ; MOV(Mov_r64_imm64) [RCX,18720056e78h:imm64]          encoding(10 bytes) = 48 b9 78 6e 05 20 87 01 00 00
003ch mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
003fh mov r14,[rcx+8]               ; MOV(Mov_r64_rm64) [R14,mem(64u,RCX:br,DS:sr)]        encoding(4 bytes) = 4c 8b 71 08
0043h cmp ebp,r14d                  ; CMP(Cmp_r32_rm32) [EBP,R14D]                         encoding(3 bytes) = 41 3b ee
0046h jl short 004ah                ; JL(Jl_rel8_64) [4Ah:jmp64]                           encoding(2 bytes) = 7c 02
0048h jmp short 004dh               ; JMP(Jmp_rel8_64) [4Dh:jmp64]                         encoding(2 bytes) = eb 03
004ah mov r14d,ebp                  ; MOV(Mov_r32_rm32) [R14D,EBP]                         encoding(3 bytes) = 44 8b f5
004dh xor ebp,ebp                   ; XOR(Xor_r32_rm32) [EBP,EBP]                          encoding(2 bytes) = 33 ed
004fh test r14d,r14d                ; TEST(Test_rm32_r32) [R14D,R14D]                      encoding(3 bytes) = 45 85 f6
0052h jle near ptr 00ffh            ; JLE(Jle_rel32_64) [FFh:jmp64]                        encoding(6 bytes) = 0f 8e a7 00 00 00
0058h cmp ebp,ebx                   ; CMP(Cmp_r32_rm32) [EBP,EBX]                          encoding(2 bytes) = 3b eb
005ah jae near ptr 0111h            ; JAE(Jae_rel32_64) [111h:jmp64]                       encoding(6 bytes) = 0f 83 b1 00 00 00
0060h movsxd rcx,ebp                ; MOVSXD(Movsxd_r64_rm32) [RCX,EBP]                    encoding(3 bytes) = 48 63 cd
0063h lea rcx,[rdi+rcx*4+10h]       ; LEA(Lea_r64_m) [RCX,mem(Unknown,RDI:br,DS:sr)]       encoding(5 bytes) = 48 8d 4c 8f 10
0068h mov ecx,[rcx]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 09
006ah movzx r15d,cl                 ; MOVZX(Movzx_r32_rm8) [R15D,CL]                       encoding(4 bytes) = 44 0f b6 f9
006eh test ebp,ebp                  ; TEST(Test_rm32_r32) [EBP,EBP]                        encoding(2 bytes) = 85 ed
0070h je short 009ah                ; JE(Je_rel8_64) [9Ah:jmp64]                           encoding(2 bytes) = 74 28
0072h mov rcx,7FFDD99940C8h         ; MOV(Mov_r64_imm64) [RCX,7ffdd99940c8h:imm64]         encoding(10 bytes) = 48 b9 c8 40 99 d9 fd 7f 00 00
007ch mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
0081h call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47BF60h:jmp64]                encoding(5 bytes) = e8 da be 47 5f
0086h mov rcx,18720056C28h          ; MOV(Mov_r64_imm64) [RCX,18720056c28h:imm64]          encoding(10 bytes) = 48 b9 28 6c 05 20 87 01 00 00
0090h mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
0093h movsx r12,byte ptr [rcx+8]    ; MOVSX(Movsx_r64_rm8) [R12,mem(8i,RCX:br,DS:sr)]      encoding(5 bytes) = 4c 0f be 61 08
0098h jmp short 00c0h               ; JMP(Jmp_rel8_64) [C0h:jmp64]                         encoding(2 bytes) = eb 26
009ah mov rcx,7FFDD99940C8h         ; MOV(Mov_r64_imm64) [RCX,7ffdd99940c8h:imm64]         encoding(10 bytes) = 48 b9 c8 40 99 d9 fd 7f 00 00
00a4h mov edx,5                     ; MOV(Mov_r32_imm32) [EDX,5h:imm32]                    encoding(5 bytes) = ba 05 00 00 00
00a9h call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47BF60h:jmp64]                encoding(5 bytes) = e8 b2 be 47 5f
00aeh mov rcx,18720056C20h          ; MOV(Mov_r64_imm64) [RCX,18720056c20h:imm64]          encoding(10 bytes) = 48 b9 20 6c 05 20 87 01 00 00
00b8h mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
00bbh movsx r12,byte ptr [rcx+8]    ; MOVSX(Movsx_r64_rm8) [R12,mem(8i,RCX:br,DS:sr)]      encoding(5 bytes) = 4c 0f be 61 08
00c0h mov [rsp+28h],r12b            ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),R12L]          encoding(5 bytes) = 44 88 64 24 28
00c5h movzx ecx,byte ptr [rsp+28h]  ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 4c 24 28
00cah movzx eax,r15b                ; MOVZX(Movzx_r32_rm8) [EAX,R15L]                      encoding(4 bytes) = 41 0f b6 c7
00ceh test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
00d0h je short 00e1h                ; JE(Je_rel8_64) [E1h:jmp64]                           encoding(2 bytes) = 74 0f
00d2h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
00d7h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
00d9h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
00dch or [rsi],rdx                  ; OR(Or_rm64_r64) [mem(64u,RSI:br,DS:sr),RDX]          encoding(3 bytes) = 48 09 16
00dfh jmp short 00f4h               ; JMP(Jmp_rel8_64) [F4h:jmp64]                         encoding(2 bytes) = eb 13
00e1h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
00e6h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
00e8h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
00ebh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
00eeh not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
00f1h and [rsi],rax                 ; AND(And_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 21 06
00f4h inc ebp                       ; INC(Inc_rm32) [EBP]                                  encoding(2 bytes) = ff c5
00f6h cmp ebp,r14d                  ; CMP(Cmp_r32_rm32) [EBP,R14D]                         encoding(3 bytes) = 41 3b ee
00f9h jl near ptr 0058h             ; JL(Jl_rel32_64) [58h:jmp64]                          encoding(6 bytes) = 0f 8c 59 ff ff ff
00ffh mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0102h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0106h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0107h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
0108h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0109h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
010ah pop r12                       ; POP(Pop_r64) [R12]                                   encoding(2 bytes) = 41 5c
010ch pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
010eh pop r15                       ; POP(Pop_r64) [R15]                                   encoding(2 bytes) = 41 5f
0110h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0111h call 7FFE3948EF00h            ; CALL(Call_rel32_64) [5F5A65B0h:jmp64]                encoding(5 bytes) = e8 9a 64 5a 5f
0116h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> maskBytes => new byte[279]{0x41,0x57,0x41,0x56,0x41,0x54,0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x30,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0x33,0xC9,0x48,0x89,0x0E,0x8B,0x5F,0x08,0x8B,0xEB,0x48,0xB9,0x00,0x78,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x23,0x00,0x00,0x00,0xE8,0x2E,0xBF,0x47,0x5F,0x48,0xB9,0x78,0x6E,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x09,0x4C,0x8B,0x71,0x08,0x41,0x3B,0xEE,0x7C,0x02,0xEB,0x03,0x44,0x8B,0xF5,0x33,0xED,0x45,0x85,0xF6,0x0F,0x8E,0xA7,0x00,0x00,0x00,0x3B,0xEB,0x0F,0x83,0xB1,0x00,0x00,0x00,0x48,0x63,0xCD,0x48,0x8D,0x4C,0x8F,0x10,0x8B,0x09,0x44,0x0F,0xB6,0xF9,0x85,0xED,0x74,0x28,0x48,0xB9,0xC8,0x40,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x05,0x00,0x00,0x00,0xE8,0xDA,0xBE,0x47,0x5F,0x48,0xB9,0x28,0x6C,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x09,0x4C,0x0F,0xBE,0x61,0x08,0xEB,0x26,0x48,0xB9,0xC8,0x40,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x05,0x00,0x00,0x00,0xE8,0xB2,0xBE,0x47,0x5F,0x48,0xB9,0x20,0x6C,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x09,0x4C,0x0F,0xBE,0x61,0x08,0x44,0x88,0x64,0x24,0x28,0x0F,0xB6,0x4C,0x24,0x28,0x41,0x0F,0xB6,0xC7,0x84,0xC9,0x74,0x0F,0xBA,0x01,0x00,0x00,0x00,0x8B,0xC8,0x48,0xD3,0xE2,0x48,0x09,0x16,0xEB,0x13,0xBA,0x01,0x00,0x00,0x00,0x8B,0xC8,0x48,0xD3,0xE2,0x48,0x8B,0xC2,0x48,0xF7,0xD0,0x48,0x21,0x06,0xFF,0xC5,0x41,0x3B,0xEE,0x0F,0x8C,0x59,0xFF,0xFF,0xFF,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x30,0x5B,0x5D,0x5E,0x5F,0x41,0x5C,0x41,0x5E,0x41,0x5F,0xC3,0xE8,0x9A,0x64,0x5A,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 mul(BitVector8 x, BitVector8 y)
; location: [7FFDD9EE8A90h, 7FFDD9EE8CC3h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,140h                  ; SUB(Sub_rm64_imm32) [RSP,140h:imm64]                 encoding(7 bytes) = 48 81 ec 40 01 00 00
000ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000dh mov esi,edx                   ; MOV(Mov_r32_rm32) [ESI,EDX]                          encoding(2 bytes) = 8b f2
000fh movzx edi,cl                  ; MOVZX(Movzx_r32_rm8) [EDI,CL]                        encoding(4 bytes) = 40 0f b6 f9
0013h mov rcx,7FFDD9997800h         ; MOV(Mov_r64_imm64) [RCX,7ffdd9997800h:imm64]         encoding(10 bytes) = 48 b9 00 78 99 d9 fd 7f 00 00
001dh mov edx,2Fh                   ; MOV(Mov_r32_imm32) [EDX,2fh:imm32]                   encoding(5 bytes) = ba 2f 00 00 00
0022h call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47BE20h:jmp64]                encoding(5 bytes) = e8 f9 bd 47 5f
0027h movzx ebx,word ptr [7FFDD9997A38h]; MOVZX(Movzx_r32_rm16) [EBX,mem(16u,RIP:br,DS:sr)] encoding(7 bytes) = 0f b7 1d 7a ef aa ff
002eh movzx ecx,dil                 ; MOVZX(Movzx_r32_rm8) [ECX,DIL]                       encoding(4 bytes) = 40 0f b6 cf
0032h mov [rsp+120h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 20 01 00 00
003ah movzx ecx,sil                 ; MOVZX(Movzx_r32_rm8) [ECX,SIL]                       encoding(4 bytes) = 40 0f b6 ce
003eh mov [rsp+108h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 08 01 00 00
0046h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
004ah vmovapd [rsp+110h],xmm0       ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 29 84 24 10 01 00 00
0053h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0057h vmovupd [rsp+0F8h],xmm0       ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 11 84 24 f8 00 00 00
0060h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0064h vmovapd [rsp+0E0h],xmm0       ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 29 84 24 e0 00 00 00
006dh lea rcx,[rsp+110h]            ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 10 01 00 00
0075h lea rdx,[rsp+120h]            ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 94 24 20 01 00 00
007dh call 7FFDD9ED8EC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFF0430h:jmp64]        encoding(5 bytes) = e8 ae 03 ff ff
0082h lea rcx,[rsp+0F8h]            ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 f8 00 00 00
008ah lea rdx,[rsp+108h]            ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 94 24 08 01 00 00
0092h call 7FFDD9ED8EC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFF0430h:jmp64]        encoding(5 bytes) = e8 99 03 ff ff
0097h vmovapd xmm0,[rsp+110h]       ; VMOVAPD(VEX_Vmovapd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 f9 28 84 24 10 01 00 00
00a0h vmovupd xmm1,[rsp+0F8h]       ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 f9 10 8c 24 f8 00 00 00
00a9h vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
00afh vmovapd [rsp+0E0h],xmm0       ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 29 84 24 e0 00 00 00
00b8h vmovdqu xmm0,xmmword ptr [rsp+0E0h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 e0 00 00 00
00c1h vmovdqu xmmword ptr [rsp+128h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 28 01 00 00
00cah mov rcx,[rsp+0F0h]            ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 8c 24 f0 00 00 00
00d2h mov [rsp+138h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 38 01 00 00
00dah movzx esi,word ptr [rsp+128h] ; MOVZX(Movzx_r32_rm16) [ESI,mem(16u,RSP:br,SS:sr)]    encoding(8 bytes) = 0f b7 b4 24 28 01 00 00
00e2h mov ecx,esi                   ; MOV(Mov_r32_rm32) [ECX,ESI]                          encoding(2 bytes) = 8b ce
00e4h sar ecx,8                     ; SAR(Sar_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 f9 08
00e7h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
00eah mov [rsp+0C0h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 c0 00 00 00
00f2h mov ecx,ebx                   ; MOV(Mov_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 8b cb
00f4h mov [rsp+0A8h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 a8 00 00 00
00fch vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0100h vmovapd [rsp+0B0h],xmm0       ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 29 84 24 b0 00 00 00
0109h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
010dh vmovupd [rsp+98h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 11 84 24 98 00 00 00
0116h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
011ah vmovapd [rsp+80h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 29 84 24 80 00 00 00
0123h lea rcx,[rsp+0B0h]            ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 b0 00 00 00
012bh lea rdx,[rsp+0C0h]            ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 94 24 c0 00 00 00
0133h call 7FFDD9ED8EC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFF0430h:jmp64]        encoding(5 bytes) = e8 f8 02 ff ff
0138h lea rcx,[rsp+98h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 98 00 00 00
0140h lea rdx,[rsp+0A8h]            ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 94 24 a8 00 00 00
0148h call 7FFDD9ED8EC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFF0430h:jmp64]        encoding(5 bytes) = e8 e3 02 ff ff
014dh vmovapd xmm0,[rsp+0B0h]       ; VMOVAPD(VEX_Vmovapd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 f9 28 84 24 b0 00 00 00
0156h vmovupd xmm1,[rsp+98h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 f9 10 8c 24 98 00 00 00
015fh vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
0165h vmovapd [rsp+80h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 29 84 24 80 00 00 00
016eh vmovdqu xmm0,xmmword ptr [rsp+80h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 80 00 00 00
0177h vmovdqu xmmword ptr [rsp+0C8h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 c8 00 00 00
0180h mov rcx,[rsp+90h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 8c 24 90 00 00 00
0188h mov [rsp+0D8h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 d8 00 00 00
0190h movzx ecx,word ptr [rsp+0C8h] ; MOVZX(Movzx_r32_rm16) [ECX,mem(16u,RSP:br,SS:sr)]    encoding(8 bytes) = 0f b7 8c 24 c8 00 00 00
0198h xor ecx,esi                   ; XOR(Xor_r32_rm32) [ECX,ESI]                          encoding(2 bytes) = 33 ce
019ah movzx esi,cx                  ; MOVZX(Movzx_r32_rm16) [ESI,CX]                       encoding(3 bytes) = 0f b7 f1
019dh mov ecx,esi                   ; MOV(Mov_r32_rm32) [ECX,ESI]                          encoding(2 bytes) = 8b ce
019fh sar ecx,8                     ; SAR(Sar_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 f9 08
01a2h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
01a5h mov [rsp+60h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 60
01aah mov ecx,ebx                   ; MOV(Mov_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 8b cb
01ach mov [rsp+48h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 48
01b1h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
01b5h vmovapd [rsp+50h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 50
01bbh vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
01bfh vmovupd [rsp+38h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 38
01c5h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
01c9h vmovapd [rsp+20h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 20
01cfh lea rcx,[rsp+50h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 50
01d4h lea rdx,[rsp+60h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 60
01d9h call 7FFDD9ED8EC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFF0430h:jmp64]        encoding(5 bytes) = e8 52 02 ff ff
01deh lea rcx,[rsp+38h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 38
01e3h lea rdx,[rsp+48h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 48
01e8h call 7FFDD9ED8EC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFF0430h:jmp64]        encoding(5 bytes) = e8 43 02 ff ff
01edh vmovapd xmm0,[rsp+50h]        ; VMOVAPD(VEX_Vmovapd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 28 44 24 50
01f3h vmovupd xmm1,[rsp+38h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 38
01f9h vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
01ffh vmovapd [rsp+20h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 20
0205h vmovdqu xmm0,xmmword ptr [rsp+20h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 20
020bh vmovdqu xmmword ptr [rsp+68h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 68
0211h mov rax,[rsp+30h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 30
0216h mov [rsp+78h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 78
021bh movzx eax,word ptr [rsp+68h]  ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RSP:br,SS:sr)]    encoding(5 bytes) = 0f b7 44 24 68
0220h xor eax,esi                   ; XOR(Xor_r32_rm32) [EAX,ESI]                          encoding(2 bytes) = 33 c6
0222h movzx esi,ax                  ; MOVZX(Movzx_r32_rm16) [ESI,AX]                       encoding(3 bytes) = 0f b7 f0
0225h movzx eax,sil                 ; MOVZX(Movzx_r32_rm8) [EAX,SIL]                       encoding(4 bytes) = 40 0f b6 c6
0229h add rsp,140h                  ; ADD(Add_rm64_imm32) [RSP,140h:imm64]                 encoding(7 bytes) = 48 81 c4 40 01 00 00
0230h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0231h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0232h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0233h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[564]{0x57,0x56,0x53,0x48,0x81,0xEC,0x40,0x01,0x00,0x00,0xC5,0xF8,0x77,0x8B,0xF2,0x40,0x0F,0xB6,0xF9,0x48,0xB9,0x00,0x78,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x2F,0x00,0x00,0x00,0xE8,0xF9,0xBD,0x47,0x5F,0x0F,0xB7,0x1D,0x7A,0xEF,0xAA,0xFF,0x40,0x0F,0xB6,0xCF,0x48,0x89,0x8C,0x24,0x20,0x01,0x00,0x00,0x40,0x0F,0xB6,0xCE,0x48,0x89,0x8C,0x24,0x08,0x01,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x84,0x24,0x10,0x01,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x11,0x84,0x24,0xF8,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x84,0x24,0xE0,0x00,0x00,0x00,0x48,0x8D,0x8C,0x24,0x10,0x01,0x00,0x00,0x48,0x8D,0x94,0x24,0x20,0x01,0x00,0x00,0xE8,0xAE,0x03,0xFF,0xFF,0x48,0x8D,0x8C,0x24,0xF8,0x00,0x00,0x00,0x48,0x8D,0x94,0x24,0x08,0x01,0x00,0x00,0xE8,0x99,0x03,0xFF,0xFF,0xC5,0xF9,0x28,0x84,0x24,0x10,0x01,0x00,0x00,0xC5,0xF9,0x10,0x8C,0x24,0xF8,0x00,0x00,0x00,0xC4,0xE3,0x79,0x44,0xC1,0x00,0xC5,0xF9,0x29,0x84,0x24,0xE0,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0xE0,0x00,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0x28,0x01,0x00,0x00,0x48,0x8B,0x8C,0x24,0xF0,0x00,0x00,0x00,0x48,0x89,0x8C,0x24,0x38,0x01,0x00,0x00,0x0F,0xB7,0xB4,0x24,0x28,0x01,0x00,0x00,0x8B,0xCE,0xC1,0xF9,0x08,0x0F,0xB7,0xC9,0x48,0x89,0x8C,0x24,0xC0,0x00,0x00,0x00,0x8B,0xCB,0x48,0x89,0x8C,0x24,0xA8,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x84,0x24,0xB0,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x11,0x84,0x24,0x98,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x84,0x24,0x80,0x00,0x00,0x00,0x48,0x8D,0x8C,0x24,0xB0,0x00,0x00,0x00,0x48,0x8D,0x94,0x24,0xC0,0x00,0x00,0x00,0xE8,0xF8,0x02,0xFF,0xFF,0x48,0x8D,0x8C,0x24,0x98,0x00,0x00,0x00,0x48,0x8D,0x94,0x24,0xA8,0x00,0x00,0x00,0xE8,0xE3,0x02,0xFF,0xFF,0xC5,0xF9,0x28,0x84,0x24,0xB0,0x00,0x00,0x00,0xC5,0xF9,0x10,0x8C,0x24,0x98,0x00,0x00,0x00,0xC4,0xE3,0x79,0x44,0xC1,0x00,0xC5,0xF9,0x29,0x84,0x24,0x80,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0x80,0x00,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0xC8,0x00,0x00,0x00,0x48,0x8B,0x8C,0x24,0x90,0x00,0x00,0x00,0x48,0x89,0x8C,0x24,0xD8,0x00,0x00,0x00,0x0F,0xB7,0x8C,0x24,0xC8,0x00,0x00,0x00,0x33,0xCE,0x0F,0xB7,0xF1,0x8B,0xCE,0xC1,0xF9,0x08,0x0F,0xB7,0xC9,0x48,0x89,0x4C,0x24,0x60,0x8B,0xCB,0x48,0x89,0x4C,0x24,0x48,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x44,0x24,0x50,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x11,0x44,0x24,0x38,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x44,0x24,0x20,0x48,0x8D,0x4C,0x24,0x50,0x48,0x8D,0x54,0x24,0x60,0xE8,0x52,0x02,0xFF,0xFF,0x48,0x8D,0x4C,0x24,0x38,0x48,0x8D,0x54,0x24,0x48,0xE8,0x43,0x02,0xFF,0xFF,0xC5,0xF9,0x28,0x44,0x24,0x50,0xC5,0xF9,0x10,0x4C,0x24,0x38,0xC4,0xE3,0x79,0x44,0xC1,0x00,0xC5,0xF9,0x29,0x44,0x24,0x20,0xC5,0xFA,0x6F,0x44,0x24,0x20,0xC5,0xFA,0x7F,0x44,0x24,0x68,0x48,0x8B,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x78,0x0F,0xB7,0x44,0x24,0x68,0x33,0xC6,0x0F,0xB7,0xF0,0x40,0x0F,0xB6,0xC6,0x48,0x81,0xC4,0x40,0x01,0x00,0x00,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector8 mul(ref BitVector8 x, BitVector8 y)
; location: [7FFDD9EE8D10h, 7FFDD9EE8F4Bh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0003h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0004h sub rsp,138h                  ; SUB(Sub_rm64_imm32) [RSP,138h:imm64]                 encoding(7 bytes) = 48 81 ec 38 01 00 00
000bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000eh mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0011h mov edi,edx                   ; MOV(Mov_r32_rm32) [EDI,EDX]                          encoding(2 bytes) = 8b fa
0013h movzx ebx,byte ptr [rsi]      ; MOVZX(Movzx_r32_rm8) [EBX,mem(8u,RSI:br,DS:sr)]      encoding(3 bytes) = 0f b6 1e
0016h mov rcx,7FFDD9997800h         ; MOV(Mov_r64_imm64) [RCX,7ffdd9997800h:imm64]         encoding(10 bytes) = 48 b9 00 78 99 d9 fd 7f 00 00
0020h mov edx,2Fh                   ; MOV(Mov_r32_imm32) [EDX,2fh:imm32]                   encoding(5 bytes) = ba 2f 00 00 00
0025h call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47BBA0h:jmp64]                encoding(5 bytes) = e8 76 bb 47 5f
002ah movzx ebp,word ptr [7FFDD9997A38h]; MOVZX(Movzx_r32_rm16) [EBP,mem(16u,RIP:br,DS:sr)] encoding(7 bytes) = 0f b7 2d f7 ec aa ff
0031h movzx ecx,bl                  ; MOVZX(Movzx_r32_rm8) [ECX,BL]                        encoding(3 bytes) = 0f b6 cb
0034h mov [rsp+118h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 18 01 00 00
003ch movzx ecx,dil                 ; MOVZX(Movzx_r32_rm8) [ECX,DIL]                       encoding(4 bytes) = 40 0f b6 cf
0040h mov [rsp+100h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 00 01 00 00
0048h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
004ch vmovupd [rsp+108h],xmm0       ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 11 84 24 08 01 00 00
0055h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0059h vmovapd [rsp+0F0h],xmm0       ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 29 84 24 f0 00 00 00
0062h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0066h vmovapd [rsp+0E0h],xmm0       ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 29 84 24 e0 00 00 00
006fh lea rcx,[rsp+108h]            ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 08 01 00 00
0077h lea rdx,[rsp+118h]            ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 94 24 18 01 00 00
007fh call 7FFDD9ED8EC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFF01B0h:jmp64]        encoding(5 bytes) = e8 2c 01 ff ff
0084h lea rcx,[rsp+0F0h]            ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 f0 00 00 00
008ch lea rdx,[rsp+100h]            ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 94 24 00 01 00 00
0094h call 7FFDD9ED8EC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFF01B0h:jmp64]        encoding(5 bytes) = e8 17 01 ff ff
0099h vmovupd xmm0,[rsp+108h]       ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 f9 10 84 24 08 01 00 00
00a2h vmovapd xmm1,[rsp+0F0h]       ; VMOVAPD(VEX_Vmovapd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 f9 28 8c 24 f0 00 00 00
00abh vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
00b1h vmovapd [rsp+0E0h],xmm0       ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 29 84 24 e0 00 00 00
00bah vmovdqu xmm0,xmmword ptr [rsp+0E0h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 e0 00 00 00
00c3h vmovdqu xmmword ptr [rsp+120h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 20 01 00 00
00cch mov rcx,[rsp+0F0h]            ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 8c 24 f0 00 00 00
00d4h mov [rsp+130h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 30 01 00 00
00dch movzx edi,word ptr [rsp+120h] ; MOVZX(Movzx_r32_rm16) [EDI,mem(16u,RSP:br,SS:sr)]    encoding(8 bytes) = 0f b7 bc 24 20 01 00 00
00e4h mov ecx,edi                   ; MOV(Mov_r32_rm32) [ECX,EDI]                          encoding(2 bytes) = 8b cf
00e6h sar ecx,8                     ; SAR(Sar_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 f9 08
00e9h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
00ech mov [rsp+0C0h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 c0 00 00 00
00f4h mov ecx,ebp                   ; MOV(Mov_r32_rm32) [ECX,EBP]                          encoding(2 bytes) = 8b cd
00f6h mov [rsp+0A8h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 a8 00 00 00
00feh vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0102h vmovapd [rsp+0B0h],xmm0       ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 29 84 24 b0 00 00 00
010bh vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
010fh vmovupd [rsp+98h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 11 84 24 98 00 00 00
0118h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
011ch vmovapd [rsp+80h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 29 84 24 80 00 00 00
0125h lea rcx,[rsp+0B0h]            ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 b0 00 00 00
012dh lea rdx,[rsp+0C0h]            ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 94 24 c0 00 00 00
0135h call 7FFDD9ED8EC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFF01B0h:jmp64]        encoding(5 bytes) = e8 76 00 ff ff
013ah lea rcx,[rsp+98h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 98 00 00 00
0142h lea rdx,[rsp+0A8h]            ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 94 24 a8 00 00 00
014ah call 7FFDD9ED8EC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFF01B0h:jmp64]        encoding(5 bytes) = e8 61 00 ff ff
014fh vmovapd xmm0,[rsp+0B0h]       ; VMOVAPD(VEX_Vmovapd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 f9 28 84 24 b0 00 00 00
0158h vmovupd xmm1,[rsp+98h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 f9 10 8c 24 98 00 00 00
0161h vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
0167h vmovapd [rsp+80h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 29 84 24 80 00 00 00
0170h vmovdqu xmm0,xmmword ptr [rsp+80h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 80 00 00 00
0179h vmovdqu xmmword ptr [rsp+0C8h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 c8 00 00 00
0182h mov rcx,[rsp+90h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 8c 24 90 00 00 00
018ah mov [rsp+0D8h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 d8 00 00 00
0192h movzx ecx,word ptr [rsp+0C8h] ; MOVZX(Movzx_r32_rm16) [ECX,mem(16u,RSP:br,SS:sr)]    encoding(8 bytes) = 0f b7 8c 24 c8 00 00 00
019ah xor ecx,edi                   ; XOR(Xor_r32_rm32) [ECX,EDI]                          encoding(2 bytes) = 33 cf
019ch movzx edi,cx                  ; MOVZX(Movzx_r32_rm16) [EDI,CX]                       encoding(3 bytes) = 0f b7 f9
019fh mov ecx,edi                   ; MOV(Mov_r32_rm32) [ECX,EDI]                          encoding(2 bytes) = 8b cf
01a1h sar ecx,8                     ; SAR(Sar_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 f9 08
01a4h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
01a7h mov [rsp+60h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 60
01ach mov ecx,ebp                   ; MOV(Mov_r32_rm32) [ECX,EBP]                          encoding(2 bytes) = 8b cd
01aeh mov [rsp+48h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 48
01b3h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
01b7h vmovapd [rsp+50h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 50
01bdh vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
01c1h vmovupd [rsp+38h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 38
01c7h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
01cbh vmovapd [rsp+20h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 20
01d1h lea rcx,[rsp+50h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 50
01d6h lea rdx,[rsp+60h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 60
01dbh call 7FFDD9ED8EC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFF01B0h:jmp64]        encoding(5 bytes) = e8 d0 ff fe ff
01e0h lea rcx,[rsp+38h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 38
01e5h lea rdx,[rsp+48h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 48
01eah call 7FFDD9ED8EC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFF01B0h:jmp64]        encoding(5 bytes) = e8 c1 ff fe ff
01efh vmovapd xmm0,[rsp+50h]        ; VMOVAPD(VEX_Vmovapd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 28 44 24 50
01f5h vmovupd xmm1,[rsp+38h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 38
01fbh vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
0201h vmovapd [rsp+20h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 20
0207h vmovdqu xmm0,xmmword ptr [rsp+20h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 20
020dh vmovdqu xmmword ptr [rsp+68h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 68
0213h mov rax,[rsp+30h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 30
0218h mov [rsp+78h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 78
021dh movzx eax,word ptr [rsp+68h]  ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RSP:br,SS:sr)]    encoding(5 bytes) = 0f b7 44 24 68
0222h xor eax,edi                   ; XOR(Xor_r32_rm32) [EAX,EDI]                          encoding(2 bytes) = 33 c7
0224h movzx edi,ax                  ; MOVZX(Movzx_r32_rm16) [EDI,AX]                       encoding(3 bytes) = 0f b7 f8
0227h movzx eax,dil                 ; MOVZX(Movzx_r32_rm8) [EAX,DIL]                       encoding(4 bytes) = 40 0f b6 c7
022bh mov [rsi],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSI:br,DS:sr),AL]            encoding(2 bytes) = 88 06
022dh mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0230h add rsp,138h                  ; ADD(Add_rm64_imm32) [RSP,138h:imm64]                 encoding(7 bytes) = 48 81 c4 38 01 00 00
0237h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0238h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
0239h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
023ah pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
023bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mulBytes => new byte[572]{0x57,0x56,0x55,0x53,0x48,0x81,0xEC,0x38,0x01,0x00,0x00,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0x8B,0xFA,0x0F,0xB6,0x1E,0x48,0xB9,0x00,0x78,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x2F,0x00,0x00,0x00,0xE8,0x76,0xBB,0x47,0x5F,0x0F,0xB7,0x2D,0xF7,0xEC,0xAA,0xFF,0x0F,0xB6,0xCB,0x48,0x89,0x8C,0x24,0x18,0x01,0x00,0x00,0x40,0x0F,0xB6,0xCF,0x48,0x89,0x8C,0x24,0x00,0x01,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x11,0x84,0x24,0x08,0x01,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x84,0x24,0xF0,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x84,0x24,0xE0,0x00,0x00,0x00,0x48,0x8D,0x8C,0x24,0x08,0x01,0x00,0x00,0x48,0x8D,0x94,0x24,0x18,0x01,0x00,0x00,0xE8,0x2C,0x01,0xFF,0xFF,0x48,0x8D,0x8C,0x24,0xF0,0x00,0x00,0x00,0x48,0x8D,0x94,0x24,0x00,0x01,0x00,0x00,0xE8,0x17,0x01,0xFF,0xFF,0xC5,0xF9,0x10,0x84,0x24,0x08,0x01,0x00,0x00,0xC5,0xF9,0x28,0x8C,0x24,0xF0,0x00,0x00,0x00,0xC4,0xE3,0x79,0x44,0xC1,0x00,0xC5,0xF9,0x29,0x84,0x24,0xE0,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0xE0,0x00,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0x20,0x01,0x00,0x00,0x48,0x8B,0x8C,0x24,0xF0,0x00,0x00,0x00,0x48,0x89,0x8C,0x24,0x30,0x01,0x00,0x00,0x0F,0xB7,0xBC,0x24,0x20,0x01,0x00,0x00,0x8B,0xCF,0xC1,0xF9,0x08,0x0F,0xB7,0xC9,0x48,0x89,0x8C,0x24,0xC0,0x00,0x00,0x00,0x8B,0xCD,0x48,0x89,0x8C,0x24,0xA8,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x84,0x24,0xB0,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x11,0x84,0x24,0x98,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x84,0x24,0x80,0x00,0x00,0x00,0x48,0x8D,0x8C,0x24,0xB0,0x00,0x00,0x00,0x48,0x8D,0x94,0x24,0xC0,0x00,0x00,0x00,0xE8,0x76,0x00,0xFF,0xFF,0x48,0x8D,0x8C,0x24,0x98,0x00,0x00,0x00,0x48,0x8D,0x94,0x24,0xA8,0x00,0x00,0x00,0xE8,0x61,0x00,0xFF,0xFF,0xC5,0xF9,0x28,0x84,0x24,0xB0,0x00,0x00,0x00,0xC5,0xF9,0x10,0x8C,0x24,0x98,0x00,0x00,0x00,0xC4,0xE3,0x79,0x44,0xC1,0x00,0xC5,0xF9,0x29,0x84,0x24,0x80,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0x80,0x00,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0xC8,0x00,0x00,0x00,0x48,0x8B,0x8C,0x24,0x90,0x00,0x00,0x00,0x48,0x89,0x8C,0x24,0xD8,0x00,0x00,0x00,0x0F,0xB7,0x8C,0x24,0xC8,0x00,0x00,0x00,0x33,0xCF,0x0F,0xB7,0xF9,0x8B,0xCF,0xC1,0xF9,0x08,0x0F,0xB7,0xC9,0x48,0x89,0x4C,0x24,0x60,0x8B,0xCD,0x48,0x89,0x4C,0x24,0x48,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x44,0x24,0x50,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x11,0x44,0x24,0x38,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x44,0x24,0x20,0x48,0x8D,0x4C,0x24,0x50,0x48,0x8D,0x54,0x24,0x60,0xE8,0xD0,0xFF,0xFE,0xFF,0x48,0x8D,0x4C,0x24,0x38,0x48,0x8D,0x54,0x24,0x48,0xE8,0xC1,0xFF,0xFE,0xFF,0xC5,0xF9,0x28,0x44,0x24,0x50,0xC5,0xF9,0x10,0x4C,0x24,0x38,0xC4,0xE3,0x79,0x44,0xC1,0x00,0xC5,0xF9,0x29,0x44,0x24,0x20,0xC5,0xFA,0x6F,0x44,0x24,0x20,0xC5,0xFA,0x7F,0x44,0x24,0x68,0x48,0x8B,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x78,0x0F,0xB7,0x44,0x24,0x68,0x33,0xC7,0x0F,0xB7,0xF8,0x40,0x0F,0xB6,0xC7,0x88,0x06,0x48,0x8B,0xC6,0x48,0x81,0xC4,0x38,0x01,0x00,0x00,0x5B,0x5D,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 negate(BitVector4 x)
; location: [7FFDD9EE8F90h, 7FFDD9EE8FAEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh shl eax,4                     ; SHL(Shl_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e0 04
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
0018h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
001bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x04,0x0F,0xB6,0xC0,0xC1,0xF8,0x04,0x83,0xE0,0x0F,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 negate(BitVector8 x)
; location: [7FFDD9EE8FC0h, 7FFDD9EE8FD2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 negate(BitVector16 x)
; location: [7FFDD9EE8FF0h, 7FFDD9EE8FFFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF7,0xD0,0xFF,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 negate(BitVector32 x)
; location: [7FFDD9EE9010h, 7FFDD9EE901Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 negate(BitVector64 x)
; location: [7FFDD9EE9030h, 7FFDD9EE903Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xFF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector8 negate(ref BitVector8 x)
; location: [7FFDD9EE9050h, 7FFDD9EE9061h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch mov [rcx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 88 01
000eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0xF7,0xD0,0xFF,0xC0,0x88,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector16 negate(ref BitVector16 x)
; location: [7FFDD9EE9080h, 7FFDD9EE9092h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,DS:sr)]    encoding(3 bytes) = 0f b7 01
0008h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
000ah inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000ch mov [rcx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 01
000fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0xF7,0xD0,0xFF,0xC0,0x66,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector32 negate(ref BitVector32 x)
; location: [7FFDD9EE90B0h, 7FFDD9EE90C0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
000dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0xF7,0xD0,0xFF,0xC0,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector64 negate(ref BitVector64 x)
; location: [7FFDD9EE90E0h, 7FFDD9EE90F4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
000eh mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
0011h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negateBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0xF7,0xD0,0x48,0xFF,0xC0,0x48,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 or(BitVector4 x, BitVector4 y)
; location: [7FFDD9EE9110h, 7FFDD9EE912Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h shl eax,4                     ; SHL(Shl_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e0 04
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
0019h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0xC1,0xE0,0x04,0x0F,0xB6,0xC0,0xC1,0xF8,0x04,0x83,0xE0,0x0F,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 or(BitVector8 x, BitVector8 y)
; location: [7FFDD9EE9140h, 7FFDD9EE9153h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 or(BitVector16 x, BitVector16 y)
; location: [7FFDD9EE9170h, 7FFDD9EE9180h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 or(in BitVector32 x, in BitVector32 y)
; location: [7FFDD9EE91A0h, 7FFDD9EE91ABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h mov edx,[rdx]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 8b 12
0009h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x8B,0x12,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 or(BitVector64 x, BitVector64 y)
; location: [7FFDD9EE91C0h, 7FFDD9EE91CBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int ord(BitVector8 x)
; location: [7FFDD9EE91E0h, 7FFDD9EE9498h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0003h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0004h sub rsp,148h                  ; SUB(Sub_rm64_imm32) [RSP,148h:imm64]                 encoding(7 bytes) = 48 81 ec 48 01 00 00
000bh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000eh mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0011h lea rdi,[rsp+20h]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 7c 24 20
0016h mov ecx,4Ah                   ; MOV(Mov_r32_imm32) [ECX,4ah:imm32]                   encoding(5 bytes) = b9 4a 00 00 00
001bh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
001dh rep stosd                     ; STOSD(Stosd_m32_EAX) [mem(32u),EAX]                  encoding(2 bytes) = f3 ab
001fh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0022h mov esi,ecx                   ; MOV(Mov_r32_rm32) [ESI,ECX]                          encoding(2 bytes) = 8b f1
0024h movzx ecx,sil                 ; MOVZX(Movzx_r32_rm8) [ECX,SIL]                       encoding(4 bytes) = 40 0f b6 ce
0028h mov [rsp+140h],cl             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(7 bytes) = 88 8c 24 40 01 00 00
002fh mov edi,2                     ; MOV(Mov_r32_imm32) [EDI,2h:imm32]                    encoding(5 bytes) = bf 02 00 00 00
0034h mov rcx,7FFDD9997800h         ; MOV(Mov_r64_imm64) [RCX,7ffdd9997800h:imm64]         encoding(10 bytes) = 48 b9 00 78 99 d9 fd 7f 00 00
003eh mov edx,2Fh                   ; MOV(Mov_r32_imm32) [EDX,2fh:imm32]                   encoding(5 bytes) = ba 2f 00 00 00
0043h call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47B6D0h:jmp64]                encoding(5 bytes) = e8 88 b6 47 5f
0048h movzx ecx,sil                 ; MOVZX(Movzx_r32_rm8) [ECX,SIL]                       encoding(4 bytes) = 40 0f b6 ce
004ch mov esi,ecx                   ; MOV(Mov_r32_rm32) [ESI,ECX]                          encoding(2 bytes) = 8b f1
004eh mov ecx,[rsp+140h]            ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 8c 24 40 01 00 00
0055h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0058h movzx ebx,word ptr [7FFDD9997A38h]; MOVZX(Movzx_r32_rm16) [EBX,mem(16u,RIP:br,DS:sr)] encoding(7 bytes) = 0f b7 1d f9 e7 aa ff
005fh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0062h mov [rsp+120h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 20 01 00 00
006ah mov [rsp+108h],rsi            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RSI]        encoding(8 bytes) = 48 89 b4 24 08 01 00 00
0072h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0076h vmovapd [rsp+110h],xmm0       ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 29 84 24 10 01 00 00
007fh vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0083h vmovupd [rsp+0F8h],xmm0       ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 11 84 24 f8 00 00 00
008ch vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0090h vmovapd [rsp+0E0h],xmm0       ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 29 84 24 e0 00 00 00
0099h lea rcx,[rsp+110h]            ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 10 01 00 00
00a1h lea rdx,[rsp+120h]            ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 94 24 20 01 00 00
00a9h call 7FFDD9ED8EC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFEFCE0h:jmp64]        encoding(5 bytes) = e8 32 fc fe ff
00aeh lea rcx,[rsp+0F8h]            ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 f8 00 00 00
00b6h lea rdx,[rsp+108h]            ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 94 24 08 01 00 00
00beh call 7FFDD9ED8EC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFEFCE0h:jmp64]        encoding(5 bytes) = e8 1d fc fe ff
00c3h vmovapd xmm0,[rsp+110h]       ; VMOVAPD(VEX_Vmovapd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 f9 28 84 24 10 01 00 00
00cch vmovupd xmm1,[rsp+0F8h]       ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 f9 10 8c 24 f8 00 00 00
00d5h vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
00dbh vmovapd [rsp+0E0h],xmm0       ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 29 84 24 e0 00 00 00
00e4h vmovdqu xmm0,xmmword ptr [rsp+0E0h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 e0 00 00 00
00edh vmovdqu xmmword ptr [rsp+128h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 28 01 00 00
00f6h mov rcx,[rsp+0F0h]            ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 8c 24 f0 00 00 00
00feh mov [rsp+138h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 38 01 00 00
0106h movzx ebp,word ptr [rsp+128h] ; MOVZX(Movzx_r32_rm16) [EBP,mem(16u,RSP:br,SS:sr)]    encoding(8 bytes) = 0f b7 ac 24 28 01 00 00
010eh mov ecx,ebp                   ; MOV(Mov_r32_rm32) [ECX,EBP]                          encoding(2 bytes) = 8b cd
0110h sar ecx,8                     ; SAR(Sar_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 f9 08
0113h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0116h mov [rsp+0C0h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 c0 00 00 00
011eh mov ecx,ebx                   ; MOV(Mov_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 8b cb
0120h mov [rsp+0A8h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 a8 00 00 00
0128h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
012ch vmovapd [rsp+0B0h],xmm0       ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 29 84 24 b0 00 00 00
0135h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0139h vmovupd [rsp+98h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 11 84 24 98 00 00 00
0142h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0146h vmovapd [rsp+80h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 29 84 24 80 00 00 00
014fh lea rcx,[rsp+0B0h]            ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 b0 00 00 00
0157h lea rdx,[rsp+0C0h]            ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 94 24 c0 00 00 00
015fh call 7FFDD9ED8EC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFEFCE0h:jmp64]        encoding(5 bytes) = e8 7c fb fe ff
0164h lea rcx,[rsp+98h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 98 00 00 00
016ch lea rdx,[rsp+0A8h]            ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 94 24 a8 00 00 00
0174h call 7FFDD9ED8EC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFEFCE0h:jmp64]        encoding(5 bytes) = e8 67 fb fe ff
0179h vmovapd xmm0,[rsp+0B0h]       ; VMOVAPD(VEX_Vmovapd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 f9 28 84 24 b0 00 00 00
0182h vmovupd xmm1,[rsp+98h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 f9 10 8c 24 98 00 00 00
018bh vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
0191h vmovapd [rsp+80h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 29 84 24 80 00 00 00
019ah vmovdqu xmm0,xmmword ptr [rsp+80h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 80 00 00 00
01a3h vmovdqu xmmword ptr [rsp+0C8h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 c8 00 00 00
01ach mov rcx,[rsp+90h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 8c 24 90 00 00 00
01b4h mov [rsp+0D8h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 d8 00 00 00
01bch movzx ecx,word ptr [rsp+0C8h] ; MOVZX(Movzx_r32_rm16) [ECX,mem(16u,RSP:br,SS:sr)]    encoding(8 bytes) = 0f b7 8c 24 c8 00 00 00
01c4h xor ecx,ebp                   ; XOR(Xor_r32_rm32) [ECX,EBP]                          encoding(2 bytes) = 33 cd
01c6h movzx ebp,cx                  ; MOVZX(Movzx_r32_rm16) [EBP,CX]                       encoding(3 bytes) = 0f b7 e9
01c9h mov ecx,ebp                   ; MOV(Mov_r32_rm32) [ECX,EBP]                          encoding(2 bytes) = 8b cd
01cbh sar ecx,8                     ; SAR(Sar_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 f9 08
01ceh movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
01d1h mov [rsp+60h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 60
01d6h mov ecx,ebx                   ; MOV(Mov_r32_rm32) [ECX,EBX]                          encoding(2 bytes) = 8b cb
01d8h mov [rsp+48h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 48
01ddh vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
01e1h vmovapd [rsp+50h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 50
01e7h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
01ebh vmovupd [rsp+38h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 38
01f1h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
01f5h vmovapd [rsp+20h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 20
01fbh lea rcx,[rsp+50h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 50
0200h lea rdx,[rsp+60h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 60
0205h call 7FFDD9ED8EC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFEFCE0h:jmp64]        encoding(5 bytes) = e8 d6 fa fe ff
020ah lea rcx,[rsp+38h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 38
020fh lea rdx,[rsp+48h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 48
0214h call 7FFDD9ED8EC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFEFCE0h:jmp64]        encoding(5 bytes) = e8 c7 fa fe ff
0219h vmovapd xmm0,[rsp+50h]        ; VMOVAPD(VEX_Vmovapd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 28 44 24 50
021fh vmovupd xmm1,[rsp+38h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 38
0225h vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
022bh vmovapd [rsp+20h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 20
0231h vmovdqu xmm0,xmmword ptr [rsp+20h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 20
0237h vmovdqu xmmword ptr [rsp+68h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 68
023dh mov rcx,[rsp+30h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 4c 24 30
0242h mov [rsp+78h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 78
0247h movzx ecx,word ptr [rsp+68h]  ; MOVZX(Movzx_r32_rm16) [ECX,mem(16u,RSP:br,SS:sr)]    encoding(5 bytes) = 0f b7 4c 24 68
024ch xor ecx,ebp                   ; XOR(Xor_r32_rm32) [ECX,EBP]                          encoding(2 bytes) = 33 cd
024eh movzx ebp,cx                  ; MOVZX(Movzx_r32_rm16) [EBP,CX]                       encoding(3 bytes) = 0f b7 e9
0251h movzx ecx,bpl                 ; MOVZX(Movzx_r32_rm8) [ECX,BPL]                       encoding(4 bytes) = 40 0f b6 cd
0255h mov [rsp+140h],cl             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(7 bytes) = 88 8c 24 40 01 00 00
025ch mov rcx,7FFDD9997800h         ; MOV(Mov_r64_imm64) [RCX,7ffdd9997800h:imm64]         encoding(10 bytes) = 48 b9 00 78 99 d9 fd 7f 00 00
0266h mov edx,24h                   ; MOV(Mov_r32_imm32) [EDX,24h:imm32]                   encoding(5 bytes) = ba 24 00 00 00
026bh call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47B6D0h:jmp64]                encoding(5 bytes) = e8 60 b4 47 5f
0270h mov rax,18720056E90h          ; MOV(Mov_r64_imm64) [RAX,18720056e90h:imm64]          encoding(10 bytes) = 48 b8 90 6e 05 20 87 01 00 00
027ah mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
027dh movzx eax,byte ptr [rax+8]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,DS:sr)]      encoding(4 bytes) = 0f b6 40 08
0281h mov edx,[rsp+140h]            ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 94 24 40 01 00 00
0288h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
028bh cmp edx,eax                   ; CMP(Cmp_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 3b d0
028dh je short 02abh                ; JE(Je_rel8_64) [2ABh:jmp64]                          encoding(2 bytes) = 74 1c
028fh inc edi                       ; INC(Inc_rm32) [EDI]                                  encoding(2 bytes) = ff c7
0291h cmp edi,100h                  ; CMP(Cmp_rm32_imm32) [EDI,100h:imm32]                 encoding(6 bytes) = 81 ff 00 01 00 00
0297h jl near ptr 004eh             ; JL(Jl_rel32_64) [4Eh:jmp64]                          encoding(6 bytes) = 0f 8c b1 fd ff ff
029dh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
029fh add rsp,148h                  ; ADD(Add_rm64_imm32) [RSP,148h:imm64]                 encoding(7 bytes) = 48 81 c4 48 01 00 00
02a6h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
02a7h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
02a8h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
02a9h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
02aah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
02abh mov eax,edi                   ; MOV(Mov_r32_rm32) [EAX,EDI]                          encoding(2 bytes) = 8b c7
02adh add rsp,148h                  ; ADD(Add_rm64_imm32) [RSP,148h:imm64]                 encoding(7 bytes) = 48 81 c4 48 01 00 00
02b4h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
02b5h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
02b6h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
02b7h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
02b8h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ordBytes => new byte[697]{0x57,0x56,0x55,0x53,0x48,0x81,0xEC,0x48,0x01,0x00,0x00,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0x48,0x8D,0x7C,0x24,0x20,0xB9,0x4A,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0x8B,0xF1,0x40,0x0F,0xB6,0xCE,0x88,0x8C,0x24,0x40,0x01,0x00,0x00,0xBF,0x02,0x00,0x00,0x00,0x48,0xB9,0x00,0x78,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x2F,0x00,0x00,0x00,0xE8,0x88,0xB6,0x47,0x5F,0x40,0x0F,0xB6,0xCE,0x8B,0xF1,0x8B,0x8C,0x24,0x40,0x01,0x00,0x00,0x0F,0xB6,0xC9,0x0F,0xB7,0x1D,0xF9,0xE7,0xAA,0xFF,0x0F,0xB6,0xC9,0x48,0x89,0x8C,0x24,0x20,0x01,0x00,0x00,0x48,0x89,0xB4,0x24,0x08,0x01,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x84,0x24,0x10,0x01,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x11,0x84,0x24,0xF8,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x84,0x24,0xE0,0x00,0x00,0x00,0x48,0x8D,0x8C,0x24,0x10,0x01,0x00,0x00,0x48,0x8D,0x94,0x24,0x20,0x01,0x00,0x00,0xE8,0x32,0xFC,0xFE,0xFF,0x48,0x8D,0x8C,0x24,0xF8,0x00,0x00,0x00,0x48,0x8D,0x94,0x24,0x08,0x01,0x00,0x00,0xE8,0x1D,0xFC,0xFE,0xFF,0xC5,0xF9,0x28,0x84,0x24,0x10,0x01,0x00,0x00,0xC5,0xF9,0x10,0x8C,0x24,0xF8,0x00,0x00,0x00,0xC4,0xE3,0x79,0x44,0xC1,0x00,0xC5,0xF9,0x29,0x84,0x24,0xE0,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0xE0,0x00,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0x28,0x01,0x00,0x00,0x48,0x8B,0x8C,0x24,0xF0,0x00,0x00,0x00,0x48,0x89,0x8C,0x24,0x38,0x01,0x00,0x00,0x0F,0xB7,0xAC,0x24,0x28,0x01,0x00,0x00,0x8B,0xCD,0xC1,0xF9,0x08,0x0F,0xB7,0xC9,0x48,0x89,0x8C,0x24,0xC0,0x00,0x00,0x00,0x8B,0xCB,0x48,0x89,0x8C,0x24,0xA8,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x84,0x24,0xB0,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x11,0x84,0x24,0x98,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x84,0x24,0x80,0x00,0x00,0x00,0x48,0x8D,0x8C,0x24,0xB0,0x00,0x00,0x00,0x48,0x8D,0x94,0x24,0xC0,0x00,0x00,0x00,0xE8,0x7C,0xFB,0xFE,0xFF,0x48,0x8D,0x8C,0x24,0x98,0x00,0x00,0x00,0x48,0x8D,0x94,0x24,0xA8,0x00,0x00,0x00,0xE8,0x67,0xFB,0xFE,0xFF,0xC5,0xF9,0x28,0x84,0x24,0xB0,0x00,0x00,0x00,0xC5,0xF9,0x10,0x8C,0x24,0x98,0x00,0x00,0x00,0xC4,0xE3,0x79,0x44,0xC1,0x00,0xC5,0xF9,0x29,0x84,0x24,0x80,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0x80,0x00,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0xC8,0x00,0x00,0x00,0x48,0x8B,0x8C,0x24,0x90,0x00,0x00,0x00,0x48,0x89,0x8C,0x24,0xD8,0x00,0x00,0x00,0x0F,0xB7,0x8C,0x24,0xC8,0x00,0x00,0x00,0x33,0xCD,0x0F,0xB7,0xE9,0x8B,0xCD,0xC1,0xF9,0x08,0x0F,0xB7,0xC9,0x48,0x89,0x4C,0x24,0x60,0x8B,0xCB,0x48,0x89,0x4C,0x24,0x48,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x44,0x24,0x50,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x11,0x44,0x24,0x38,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x44,0x24,0x20,0x48,0x8D,0x4C,0x24,0x50,0x48,0x8D,0x54,0x24,0x60,0xE8,0xD6,0xFA,0xFE,0xFF,0x48,0x8D,0x4C,0x24,0x38,0x48,0x8D,0x54,0x24,0x48,0xE8,0xC7,0xFA,0xFE,0xFF,0xC5,0xF9,0x28,0x44,0x24,0x50,0xC5,0xF9,0x10,0x4C,0x24,0x38,0xC4,0xE3,0x79,0x44,0xC1,0x00,0xC5,0xF9,0x29,0x44,0x24,0x20,0xC5,0xFA,0x6F,0x44,0x24,0x20,0xC5,0xFA,0x7F,0x44,0x24,0x68,0x48,0x8B,0x4C,0x24,0x30,0x48,0x89,0x4C,0x24,0x78,0x0F,0xB7,0x4C,0x24,0x68,0x33,0xCD,0x0F,0xB7,0xE9,0x40,0x0F,0xB6,0xCD,0x88,0x8C,0x24,0x40,0x01,0x00,0x00,0x48,0xB9,0x00,0x78,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x24,0x00,0x00,0x00,0xE8,0x60,0xB4,0x47,0x5F,0x48,0xB8,0x90,0x6E,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x00,0x0F,0xB6,0x40,0x08,0x8B,0x94,0x24,0x40,0x01,0x00,0x00,0x0F,0xB6,0xD2,0x3B,0xD0,0x74,0x1C,0xFF,0xC7,0x81,0xFF,0x00,0x01,0x00,0x00,0x0F,0x8C,0xB1,0xFD,0xFF,0xFF,0x33,0xC0,0x48,0x81,0xC4,0x48,0x01,0x00,0x00,0x5B,0x5D,0x5E,0x5F,0xC3,0x8B,0xC7,0x48,0x81,0xC4,0x48,0x01,0x00,0x00,0x5B,0x5D,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit parity(BitVector4 src)
; location: [7FFDD9EE94E0h, 7FFDD9EE94F7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
000ch test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000eh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> parityBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF3,0x0F,0xB8,0xC0,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit parity(BitVector8 src)
; location: [7FFDD9EE9510h, 7FFDD9EE9527h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
000ch test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000eh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> parityBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF3,0x0F,0xB8,0xC0,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit parity(BitVector16 src)
; location: [7FFDD9EE9540h, 7FFDD9EE9557h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
000ch test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000eh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> parityBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF3,0x0F,0xB8,0xC0,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit parity(BitVector32 src)
; location: [7FFDD9EE9570h, 7FFDD9EE9586h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt eax,ecx                ; POPCNT(Popcnt_r32_rm32) [EAX,ECX]                    encoding(4 bytes) = f3 0f b8 c1
000bh test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000dh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> parityBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x0F,0xB8,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Bit parity(BitVector64 src)
; location: [7FFDD9EE95A0h, 7FFDD9EE95B7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt rax,rcx                ; POPCNT(Popcnt_r64_rm64) [RAX,RCX]                    encoding(5 bytes) = f3 48 0f b8 c1
000ch test al,1                     ; TEST(Test_AL_imm8) [AL,1h:imm8]                      encoding(2 bytes) = a8 01
000eh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0011h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0014h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> parityBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xB8,0xC1,0xA8,0x01,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<BitVector4> partition(BitVector16 src, Span<BitVector4> dst)
; location: [7FFDD9EE99D0h, 7FFDD9EE9A1Eh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000eh mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
0013h mov rbx,rcx                   ; MOV(Mov_r64_rm64) [RBX,RCX]                          encoding(3 bytes) = 48 8b d9
0016h mov rsi,r8                    ; MOV(Mov_r64_rm64) [RSI,R8]                           encoding(3 bytes) = 49 8b f0
0019h mov rcx,[rsi]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSI:br,DS:sr)]        encoding(3 bytes) = 48 8b 0e
001ch mov eax,[rsi+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSI:br,DS:sr)]        encoding(3 bytes) = 8b 46 08
001fh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0022h lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 20
0027h mov [r8],rcx                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RCX]         encoding(3 bytes) = 49 89 08
002ah mov [r8+8],eax                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(4 bytes) = 41 89 40 08
002eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0030h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 20
0035h call 7FFDD984ADA8h            ; CALL(Call_rel32_64) [FFFFFFFFFF9613D8h:jmp64]        encoding(5 bytes) = e8 9e 13 96 ff
003ah mov rdi,rbx                   ; MOV(Mov_r64_rm64) [RDI,RBX]                          encoding(3 bytes) = 48 8b fb
003dh call 7FFE39363690h            ; CALL(Call_rel32_64) [5F479CC0h:jmp64]                encoding(5 bytes) = e8 7e 9c 47 5f
0042h movsq                         ; MOVSQ(Movsq_m64_m64) [mem(64u),mem(64u,DS:sr)]       encoding(2 bytes) = 48 a5
0044h mov rax,rbx                   ; MOV(Mov_r64_rm64) [RAX,RBX]                          encoding(3 bytes) = 48 8b c3
0047h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
004bh pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
004ch pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
004dh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
004eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> partitionBytes => new byte[79]{0x57,0x56,0x53,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xD9,0x49,0x8B,0xF0,0x48,0x8B,0x0E,0x8B,0x46,0x08,0x0F,0xB7,0xD2,0x4C,0x8D,0x44,0x24,0x20,0x49,0x89,0x08,0x41,0x89,0x40,0x08,0x8B,0xCA,0x48,0x8D,0x54,0x24,0x20,0xE8,0x9E,0x13,0x96,0xFF,0x48,0x8B,0xFB,0xE8,0x7E,0x9C,0x47,0x5F,0x48,0xA5,0x48,0x8B,0xC3,0x48,0x83,0xC4,0x30,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<BitVector8> partition(BitVector16 src, Span<BitVector8> dst)
; location: [7FFDD9EE9E40h, 7FFDD9EE9E8Eh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000eh mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
0013h mov rbx,rcx                   ; MOV(Mov_r64_rm64) [RBX,RCX]                          encoding(3 bytes) = 48 8b d9
0016h mov rsi,r8                    ; MOV(Mov_r64_rm64) [RSI,R8]                           encoding(3 bytes) = 49 8b f0
0019h mov rcx,[rsi]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSI:br,DS:sr)]        encoding(3 bytes) = 48 8b 0e
001ch mov eax,[rsi+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSI:br,DS:sr)]        encoding(3 bytes) = 8b 46 08
001fh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0022h lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 20
0027h mov [r8],rcx                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RCX]         encoding(3 bytes) = 49 89 08
002ah mov [r8+8],eax                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(4 bytes) = 41 89 40 08
002eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0030h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 20
0035h call 7FFDD984AE70h            ; CALL(Call_rel32_64) [FFFFFFFFFF961030h:jmp64]        encoding(5 bytes) = e8 f6 0f 96 ff
003ah mov rdi,rbx                   ; MOV(Mov_r64_rm64) [RDI,RBX]                          encoding(3 bytes) = 48 8b fb
003dh call 7FFE39363690h            ; CALL(Call_rel32_64) [5F479850h:jmp64]                encoding(5 bytes) = e8 0e 98 47 5f
0042h movsq                         ; MOVSQ(Movsq_m64_m64) [mem(64u),mem(64u,DS:sr)]       encoding(2 bytes) = 48 a5
0044h mov rax,rbx                   ; MOV(Mov_r64_rm64) [RAX,RBX]                          encoding(3 bytes) = 48 8b c3
0047h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
004bh pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
004ch pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
004dh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
004eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> partitionBytes => new byte[79]{0x57,0x56,0x53,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xD9,0x49,0x8B,0xF0,0x48,0x8B,0x0E,0x8B,0x46,0x08,0x0F,0xB7,0xD2,0x4C,0x8D,0x44,0x24,0x20,0x49,0x89,0x08,0x41,0x89,0x40,0x08,0x8B,0xCA,0x48,0x8D,0x54,0x24,0x20,0xE8,0xF6,0x0F,0x96,0xFF,0x48,0x8B,0xFB,0xE8,0x0E,0x98,0x47,0x5F,0x48,0xA5,0x48,0x8B,0xC3,0x48,0x83,0xC4,0x30,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<BitVector4> partition(BitVector32 src, Span<BitVector4> dst)
; location: [7FFDD9EE9EB0h, 7FFDD9EE9EFBh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000eh mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
0013h mov rbx,rcx                   ; MOV(Mov_r64_rm64) [RBX,RCX]                          encoding(3 bytes) = 48 8b d9
0016h mov rsi,r8                    ; MOV(Mov_r64_rm64) [RSI,R8]                           encoding(3 bytes) = 49 8b f0
0019h mov rcx,[rsi]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSI:br,DS:sr)]        encoding(3 bytes) = 48 8b 0e
001ch mov eax,[rsi+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSI:br,DS:sr)]        encoding(3 bytes) = 8b 46 08
001fh lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 20
0024h mov [r8],rcx                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RCX]         encoding(3 bytes) = 49 89 08
0027h mov [r8+8],eax                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(4 bytes) = 41 89 40 08
002bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
002dh lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 20
0032h call 7FFDD984ADB0h            ; CALL(Call_rel32_64) [FFFFFFFFFF960F00h:jmp64]        encoding(5 bytes) = e8 c9 0e 96 ff
0037h mov rdi,rbx                   ; MOV(Mov_r64_rm64) [RDI,RBX]                          encoding(3 bytes) = 48 8b fb
003ah call 7FFE39363690h            ; CALL(Call_rel32_64) [5F4797E0h:jmp64]                encoding(5 bytes) = e8 a1 97 47 5f
003fh movsq                         ; MOVSQ(Movsq_m64_m64) [mem(64u),mem(64u,DS:sr)]       encoding(2 bytes) = 48 a5
0041h mov rax,rbx                   ; MOV(Mov_r64_rm64) [RAX,RBX]                          encoding(3 bytes) = 48 8b c3
0044h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0048h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0049h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
004ah pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
004bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> partitionBytes => new byte[76]{0x57,0x56,0x53,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xD9,0x49,0x8B,0xF0,0x48,0x8B,0x0E,0x8B,0x46,0x08,0x4C,0x8D,0x44,0x24,0x20,0x49,0x89,0x08,0x41,0x89,0x40,0x08,0x8B,0xCA,0x48,0x8D,0x54,0x24,0x20,0xE8,0xC9,0x0E,0x96,0xFF,0x48,0x8B,0xFB,0xE8,0xA1,0x97,0x47,0x5F,0x48,0xA5,0x48,0x8B,0xC3,0x48,0x83,0xC4,0x30,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<BitVector8> partition(BitVector32 src, Span<BitVector8> dst)
; location: [7FFDD9EE9F20h, 7FFDD9EE9F6Bh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000eh mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
0013h mov rbx,rcx                   ; MOV(Mov_r64_rm64) [RBX,RCX]                          encoding(3 bytes) = 48 8b d9
0016h mov rsi,r8                    ; MOV(Mov_r64_rm64) [RSI,R8]                           encoding(3 bytes) = 49 8b f0
0019h mov rcx,[rsi]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSI:br,DS:sr)]        encoding(3 bytes) = 48 8b 0e
001ch mov eax,[rsi+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSI:br,DS:sr)]        encoding(3 bytes) = 8b 46 08
001fh lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 20
0024h mov [r8],rcx                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RCX]         encoding(3 bytes) = 49 89 08
0027h mov [r8+8],eax                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(4 bytes) = 41 89 40 08
002bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
002dh lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 20
0032h call 7FFDD984AE78h            ; CALL(Call_rel32_64) [FFFFFFFFFF960F58h:jmp64]        encoding(5 bytes) = e8 21 0f 96 ff
0037h mov rdi,rbx                   ; MOV(Mov_r64_rm64) [RDI,RBX]                          encoding(3 bytes) = 48 8b fb
003ah call 7FFE39363690h            ; CALL(Call_rel32_64) [5F479770h:jmp64]                encoding(5 bytes) = e8 31 97 47 5f
003fh movsq                         ; MOVSQ(Movsq_m64_m64) [mem(64u),mem(64u,DS:sr)]       encoding(2 bytes) = 48 a5
0041h mov rax,rbx                   ; MOV(Mov_r64_rm64) [RAX,RBX]                          encoding(3 bytes) = 48 8b c3
0044h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0048h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0049h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
004ah pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
004bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> partitionBytes => new byte[76]{0x57,0x56,0x53,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xD9,0x49,0x8B,0xF0,0x48,0x8B,0x0E,0x8B,0x46,0x08,0x4C,0x8D,0x44,0x24,0x20,0x49,0x89,0x08,0x41,0x89,0x40,0x08,0x8B,0xCA,0x48,0x8D,0x54,0x24,0x20,0xE8,0x21,0x0F,0x96,0xFF,0x48,0x8B,0xFB,0xE8,0x31,0x97,0x47,0x5F,0x48,0xA5,0x48,0x8B,0xC3,0x48,0x83,0xC4,0x30,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<BitVector16> partition(BitVector32 src, Span<BitVector16> dst)
; location: [7FFDD9EEA390h, 7FFDD9EEA3E1h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
000eh mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
0013h mov rbx,rcx                   ; MOV(Mov_r64_rm64) [RBX,RCX]                          encoding(3 bytes) = 48 8b d9
0016h mov rsi,r8                    ; MOV(Mov_r64_rm64) [RSI,R8]                           encoding(3 bytes) = 49 8b f0
0019h mov rcx,[rsi]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSI:br,DS:sr)]        encoding(3 bytes) = 48 8b 0e
001ch mov eax,[rsi+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSI:br,DS:sr)]        encoding(3 bytes) = 8b 46 08
001fh lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 20
0024h mov [r8],rcx                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RCX]         encoding(3 bytes) = 49 89 08
0027h mov [r8+8],eax                ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(4 bytes) = 41 89 40 08
002bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
002dh lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 20
0032h call 7FFDD984AEF0h            ; CALL(Call_rel32_64) [FFFFFFFFFF960B60h:jmp64]        encoding(5 bytes) = e8 29 0b 96 ff
0037h mov rdi,rbx                   ; MOV(Mov_r64_rm64) [RDI,RBX]                          encoding(3 bytes) = 48 8b fb
003ah call 7FFE39363690h            ; CALL(Call_rel32_64) [5F479300h:jmp64]                encoding(5 bytes) = e8 c1 92 47 5f
003fh movsq                         ; MOVSQ(Movsq_m64_m64) [mem(64u),mem(64u,DS:sr)]       encoding(2 bytes) = 48 a5
0041h mov rax,rbx                   ; MOV(Mov_r64_rm64) [RAX,RBX]                          encoding(3 bytes) = 48 8b c3
0044h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
0048h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0049h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
004ah pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
004bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
004ch call 7FFE3948ED50h            ; CALL(Call_rel32_64) [5F5A49C0h:jmp64]                encoding(5 bytes) = e8 6f 49 5a 5f
0051h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> partitionBytes => new byte[82]{0x57,0x56,0x53,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xD9,0x49,0x8B,0xF0,0x48,0x8B,0x0E,0x8B,0x46,0x08,0x4C,0x8D,0x44,0x24,0x20,0x49,0x89,0x08,0x41,0x89,0x40,0x08,0x8B,0xCA,0x48,0x8D,0x54,0x24,0x20,0xE8,0x29,0x0B,0x96,0xFF,0x48,0x8B,0xFB,0xE8,0xC1,0x92,0x47,0x5F,0x48,0xA5,0x48,0x8B,0xC3,0x48,0x83,0xC4,0x30,0x5B,0x5E,0x5F,0xC3,0xE8,0x6F,0x49,0x5A,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector16 perm(ref BitVector16 x, in Perm spec)
; location: [7FFDD9EEA400h, 7FFDD9EEA4AAh]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 30
000bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000eh movzx ecx,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [ECX,mem(16u,RAX:br,DS:sr)]    encoding(3 bytes) = 0f b7 08
0011h mov [rsp+30h],cx              ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,SS:sr),CX]         encoding(5 bytes) = 66 89 4c 24 30
0016h xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0019h jmp short 0096h               ; JMP(Jmp_rel8_64) [96h:jmp64]                         encoding(2 bytes) = eb 7b
001bh mov rcx,[rdx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 0a
001eh cmp r8d,[rcx+8]               ; CMP(Cmp_r32_rm32) [R8D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 3b 41 08
0022h jae near ptr 00a5h            ; JAE(Jae_rel32_64) [A5h:jmp64]                        encoding(6 bytes) = 0f 83 7d 00 00 00
0028h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
002bh lea rcx,[rcx+r9*4+10h]        ; LEA(Lea_r64_m) [RCX,mem(Unknown,RCX:br,DS:sr)]       encoding(5 bytes) = 4a 8d 4c 89 10
0030h mov ecx,[rcx]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 09
0032h cmp ecx,r8d                   ; CMP(Cmp_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 3b c8
0035h je short 0093h                ; JE(Je_rel8_64) [93h:jmp64]                           encoding(2 bytes) = 74 5c
0037h movzx r9d,r8b                 ; MOVZX(Movzx_r32_rm8) [R9D,R8L]                       encoding(4 bytes) = 45 0f b6 c8
003bh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
003eh mov r10d,[rsp+30h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RSP:br,SS:sr)]       encoding(5 bytes) = 44 8b 54 24 30
0043h movzx r10d,r10w               ; MOVZX(Movzx_r32_rm16) [R10D,R10W]                    encoding(4 bytes) = 45 0f b7 d2
0047h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
004ah bt r10d,ecx                   ; BT(Bt_rm32_r32) [R10D,ECX]                           encoding(4 bytes) = 41 0f a3 ca
004eh setb cl                       ; SETB(Setb_rm8) [CL]                                  encoding(3 bytes) = 0f 92 c1
0051h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0054h mov [rsp+28h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(4 bytes) = 88 4c 24 28
0058h movzx ecx,byte ptr [rsp+28h]  ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 4c 24 28
005dh movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0061h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0063h je short 007bh                ; JE(Je_rel8_64) [7Bh:jmp64]                           encoding(2 bytes) = 74 16
0065h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
006bh mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
006eh shl r10d,cl                   ; SHL(Shl_rm32_CL) [R10D,CL]                           encoding(3 bytes) = 41 d3 e2
0071h movzx r9d,r10w                ; MOVZX(Movzx_r32_rm16) [R9D,R10W]                     encoding(4 bytes) = 45 0f b7 ca
0075h or [rax],r9w                  ; OR(Or_rm16_r16) [mem(16u,RAX:br,DS:sr),R9W]          encoding(4 bytes) = 66 44 09 08
0079h jmp short 0093h               ; JMP(Jmp_rel8_64) [93h:jmp64]                         encoding(2 bytes) = eb 18
007bh mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0081h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0084h shl r10d,cl                   ; SHL(Shl_rm32_CL) [R10D,CL]                           encoding(3 bytes) = 41 d3 e2
0087h movzx ecx,r10w                ; MOVZX(Movzx_r32_rm16) [ECX,R10W]                     encoding(4 bytes) = 41 0f b7 ca
008bh not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
008dh movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0090h and [rax],cx                  ; AND(And_rm16_r16) [mem(16u,RAX:br,DS:sr),CX]         encoding(3 bytes) = 66 21 08
0093h inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
0096h cmp r8d,10h                   ; CMP(Cmp_rm32_imm8) [R8D,10h:imm32]                   encoding(4 bytes) = 41 83 f8 10
009ah jl near ptr 001bh             ; JL(Jl_rel32_64) [1Bh:jmp64]                          encoding(6 bytes) = 0f 8c 7b ff ff ff
00a0h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
00a4h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00a5h call 7FFE3948EF00h            ; CALL(Call_rel32_64) [5F5A4B00h:jmp64]                encoding(5 bytes) = e8 56 4a 5a 5f
00aah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> permBytes => new byte[171]{0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x30,0x48,0x8B,0xC1,0x0F,0xB7,0x08,0x66,0x89,0x4C,0x24,0x30,0x45,0x33,0xC0,0xEB,0x7B,0x48,0x8B,0x0A,0x44,0x3B,0x41,0x08,0x0F,0x83,0x7D,0x00,0x00,0x00,0x4D,0x63,0xC8,0x4A,0x8D,0x4C,0x89,0x10,0x8B,0x09,0x41,0x3B,0xC8,0x74,0x5C,0x45,0x0F,0xB6,0xC8,0x0F,0xB6,0xC9,0x44,0x8B,0x54,0x24,0x30,0x45,0x0F,0xB7,0xD2,0x0F,0xB6,0xC9,0x41,0x0F,0xA3,0xCA,0x0F,0x92,0xC1,0x0F,0xB6,0xC9,0x88,0x4C,0x24,0x28,0x0F,0xB6,0x4C,0x24,0x28,0x45,0x0F,0xB6,0xC9,0x84,0xC9,0x74,0x16,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x41,0xD3,0xE2,0x45,0x0F,0xB7,0xCA,0x66,0x44,0x09,0x08,0xEB,0x18,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x41,0xD3,0xE2,0x41,0x0F,0xB7,0xCA,0xF7,0xD1,0x0F,0xB7,0xC9,0x66,0x21,0x08,0x41,0xFF,0xC0,0x41,0x83,0xF8,0x10,0x0F,0x8C,0x7B,0xFF,0xFF,0xFF,0x48,0x83,0xC4,0x38,0xC3,0xE8,0x56,0x4A,0x5A,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 perm(BitVector16 x, Perm spec)
; location: [7FFDD9EEA4C0h, 7FFDD9EEA585h]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 30
000bh mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
0010h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0013h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0016h mov [rsp+30h],cx              ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,SS:sr),CX]         encoding(5 bytes) = 66 89 4c 24 30
001bh mov ecx,[rsp+30h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 30
001fh movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0022h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0025h mov [rsp+28h],cx              ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,SS:sr),CX]         encoding(5 bytes) = 66 89 4c 24 28
002ah lea rax,[rsp+30h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 30
002fh xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0032h jmp short 00ach               ; JMP(Jmp_rel8_64) [ACh:jmp64]                         encoding(2 bytes) = eb 78
0034h cmp r8d,[rdx+8]               ; CMP(Cmp_r32_rm32) [R8D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 3b 42 08
0038h jae near ptr 00c0h            ; JAE(Jae_rel32_64) [C0h:jmp64]                        encoding(6 bytes) = 0f 83 82 00 00 00
003eh movsxd rcx,r8d                ; MOVSXD(Movsxd_r64_rm32) [RCX,R8D]                    encoding(3 bytes) = 49 63 c8
0041h lea rcx,[rdx+rcx*4+10h]       ; LEA(Lea_r64_m) [RCX,mem(Unknown,RDX:br,DS:sr)]       encoding(5 bytes) = 48 8d 4c 8a 10
0046h mov ecx,[rcx]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 09
0048h cmp ecx,r8d                   ; CMP(Cmp_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 3b c8
004bh je short 00a9h                ; JE(Je_rel8_64) [A9h:jmp64]                           encoding(2 bytes) = 74 5c
004dh movzx r9d,r8b                 ; MOVZX(Movzx_r32_rm8) [R9D,R8L]                       encoding(4 bytes) = 45 0f b6 c8
0051h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0054h mov r10d,[rsp+28h]            ; MOV(Mov_r32_rm32) [R10D,mem(32u,RSP:br,SS:sr)]       encoding(5 bytes) = 44 8b 54 24 28
0059h movzx r10d,r10w               ; MOVZX(Movzx_r32_rm16) [R10D,R10W]                    encoding(4 bytes) = 45 0f b7 d2
005dh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0060h bt r10d,ecx                   ; BT(Bt_rm32_r32) [R10D,ECX]                           encoding(4 bytes) = 41 0f a3 ca
0064h setb cl                       ; SETB(Setb_rm8) [CL]                                  encoding(3 bytes) = 0f 92 c1
0067h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
006ah mov [rsp+20h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(4 bytes) = 88 4c 24 20
006eh movzx ecx,byte ptr [rsp+20h]  ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 4c 24 20
0073h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
0077h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0079h je short 0091h                ; JE(Je_rel8_64) [91h:jmp64]                           encoding(2 bytes) = 74 16
007bh mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0081h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0084h shl r10d,cl                   ; SHL(Shl_rm32_CL) [R10D,CL]                           encoding(3 bytes) = 41 d3 e2
0087h movzx r9d,r10w                ; MOVZX(Movzx_r32_rm16) [R9D,R10W]                     encoding(4 bytes) = 45 0f b7 ca
008bh or [rax],r9w                  ; OR(Or_rm16_r16) [mem(16u,RAX:br,DS:sr),R9W]          encoding(4 bytes) = 66 44 09 08
008fh jmp short 00a9h               ; JMP(Jmp_rel8_64) [A9h:jmp64]                         encoding(2 bytes) = eb 18
0091h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0097h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
009ah shl r10d,cl                   ; SHL(Shl_rm32_CL) [R10D,CL]                           encoding(3 bytes) = 41 d3 e2
009dh movzx ecx,r10w                ; MOVZX(Movzx_r32_rm16) [ECX,R10W]                     encoding(4 bytes) = 41 0f b7 ca
00a1h not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
00a3h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
00a6h and [rax],cx                  ; AND(And_rm16_r16) [mem(16u,RAX:br,DS:sr),CX]         encoding(3 bytes) = 66 21 08
00a9h inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
00ach cmp r8d,10h                   ; CMP(Cmp_rm32_imm8) [R8D,10h:imm32]                   encoding(4 bytes) = 41 83 f8 10
00b0h jl short 0034h                ; JL(Jl_rel8_64) [34h:jmp64]                           encoding(2 bytes) = 7c 82
00b2h lea rax,[rsp+30h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 30
00b7h movsx rax,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RAX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 00
00bbh add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
00bfh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00c0h call 7FFE3948EF00h            ; CALL(Call_rel32_64) [5F5A4A40h:jmp64]                encoding(5 bytes) = e8 7b 49 5a 5f
00c5h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> permBytes => new byte[198]{0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x28,0x0F,0xB7,0xC9,0x0F,0xB7,0xC9,0x66,0x89,0x4C,0x24,0x30,0x8B,0x4C,0x24,0x30,0x0F,0xB7,0xC9,0x0F,0xB7,0xC9,0x66,0x89,0x4C,0x24,0x28,0x48,0x8D,0x44,0x24,0x30,0x45,0x33,0xC0,0xEB,0x78,0x44,0x3B,0x42,0x08,0x0F,0x83,0x82,0x00,0x00,0x00,0x49,0x63,0xC8,0x48,0x8D,0x4C,0x8A,0x10,0x8B,0x09,0x41,0x3B,0xC8,0x74,0x5C,0x45,0x0F,0xB6,0xC8,0x0F,0xB6,0xC9,0x44,0x8B,0x54,0x24,0x28,0x45,0x0F,0xB7,0xD2,0x0F,0xB6,0xC9,0x41,0x0F,0xA3,0xCA,0x0F,0x92,0xC1,0x0F,0xB6,0xC9,0x88,0x4C,0x24,0x20,0x0F,0xB6,0x4C,0x24,0x20,0x45,0x0F,0xB6,0xC9,0x84,0xC9,0x74,0x16,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x41,0xD3,0xE2,0x45,0x0F,0xB7,0xCA,0x66,0x44,0x09,0x08,0xEB,0x18,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x41,0xD3,0xE2,0x41,0x0F,0xB7,0xCA,0xF7,0xD1,0x0F,0xB7,0xC9,0x66,0x21,0x08,0x41,0xFF,0xC0,0x41,0x83,0xF8,0x10,0x7C,0x82,0x48,0x8D,0x44,0x24,0x30,0x48,0x0F,0xBF,0x00,0x48,0x83,0xC4,0x38,0xC3,0xE8,0x7B,0x49,0x5A,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector32 perm(ref BitVector32 x, in Perm spec)
; location: [7FFDD9EEA5A0h, 7FFDD9EEA64Ch]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0007h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000ah mov rdi,rdx                   ; MOV(Mov_r64_rm64) [RDI,RDX]                          encoding(3 bytes) = 48 8b fa
000dh mov ebx,[rsi]                 ; MOV(Mov_r32_rm32) [EBX,mem(32u,RSI:br,DS:sr)]        encoding(2 bytes) = 8b 1e
000fh mov rcx,7FFDD9997800h         ; MOV(Mov_r64_imm64) [RCX,7ffdd9997800h:imm64]         encoding(10 bytes) = 48 b9 00 78 99 d9 fd 7f 00 00
0019h mov edx,21h                   ; MOV(Mov_r32_imm32) [EDX,21h:imm32]                   encoding(5 bytes) = ba 21 00 00 00
001eh call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47A310h:jmp64]                encoding(5 bytes) = e8 ed a2 47 5f
0023h mov rcx,18720056E28h          ; MOV(Mov_r64_imm64) [RCX,18720056e28h:imm64]          encoding(10 bytes) = 48 b9 28 6e 05 20 87 01 00 00
002dh mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
0030h mov rax,[rcx+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(4 bytes) = 48 8b 41 08
0034h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0036h jmp short 0098h               ; JMP(Jmp_rel8_64) [98h:jmp64]                         encoding(2 bytes) = eb 60
0038h mov rcx,[rdi]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RDI:br,DS:sr)]        encoding(3 bytes) = 48 8b 0f
003bh cmp edx,[rcx+8]               ; CMP(Cmp_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 3b 51 08
003eh jae short 00a7h               ; JAE(Jae_rel8_64) [A7h:jmp64]                         encoding(2 bytes) = 73 67
0040h movsxd r8,edx                 ; MOVSXD(Movsxd_r64_rm32) [R8,EDX]                     encoding(3 bytes) = 4c 63 c2
0043h lea rcx,[rcx+r8*4+10h]        ; LEA(Lea_r64_m) [RCX,mem(Unknown,RCX:br,DS:sr)]       encoding(5 bytes) = 4a 8d 4c 81 10
0048h mov ecx,[rcx]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 09
004ah cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
004ch je short 0096h                ; JE(Je_rel8_64) [96h:jmp64]                           encoding(2 bytes) = 74 48
004eh movzx r8d,dl                  ; MOVZX(Movzx_r32_rm8) [R8D,DL]                        encoding(4 bytes) = 44 0f b6 c2
0052h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0055h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0058h bt ebx,ecx                    ; BT(Bt_rm32_r32) [EBX,ECX]                            encoding(3 bytes) = 0f a3 cb
005bh setb cl                       ; SETB(Setb_rm8) [CL]                                  encoding(3 bytes) = 0f 92 c1
005eh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0061h mov [rsp+28h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(4 bytes) = 88 4c 24 28
0065h movzx ecx,byte ptr [rsp+28h]  ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 4c 24 28
006ah movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
006eh test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0070h je short 0083h                ; JE(Je_rel8_64) [83h:jmp64]                           encoding(2 bytes) = 74 11
0072h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
0078h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
007bh shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
007eh or [rsi],r9d                  ; OR(Or_rm32_r32) [mem(32u,RSI:br,DS:sr),R9D]          encoding(3 bytes) = 44 09 0e
0081h jmp short 0096h               ; JMP(Jmp_rel8_64) [96h:jmp64]                         encoding(2 bytes) = eb 13
0083h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
0089h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
008ch shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
008fh mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
0092h not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
0094h and [rsi],ecx                 ; AND(And_rm32_r32) [mem(32u,RSI:br,DS:sr),ECX]        encoding(2 bytes) = 21 0e
0096h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0098h cmp edx,eax                   ; CMP(Cmp_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 3b d0
009ah jl short 0038h                ; JL(Jl_rel8_64) [38h:jmp64]                           encoding(2 bytes) = 7c 9c
009ch mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
009fh add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
00a3h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00a4h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00a5h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00a6h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00a7h call 7FFE3948EF00h            ; CALL(Call_rel32_64) [5F5A4960h:jmp64]                encoding(5 bytes) = e8 b4 48 5a 5f
00ach int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> permBytes => new byte[173]{0x57,0x56,0x53,0x48,0x83,0xEC,0x30,0x48,0x8B,0xF1,0x48,0x8B,0xFA,0x8B,0x1E,0x48,0xB9,0x00,0x78,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x21,0x00,0x00,0x00,0xE8,0xED,0xA2,0x47,0x5F,0x48,0xB9,0x28,0x6E,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x09,0x48,0x8B,0x41,0x08,0x33,0xD2,0xEB,0x60,0x48,0x8B,0x0F,0x3B,0x51,0x08,0x73,0x67,0x4C,0x63,0xC2,0x4A,0x8D,0x4C,0x81,0x10,0x8B,0x09,0x3B,0xCA,0x74,0x48,0x44,0x0F,0xB6,0xC2,0x0F,0xB6,0xC9,0x0F,0xB6,0xC9,0x0F,0xA3,0xCB,0x0F,0x92,0xC1,0x0F,0xB6,0xC9,0x88,0x4C,0x24,0x28,0x0F,0xB6,0x4C,0x24,0x28,0x45,0x0F,0xB6,0xC0,0x84,0xC9,0x74,0x11,0x41,0xB9,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x41,0xD3,0xE1,0x44,0x09,0x0E,0xEB,0x13,0x41,0xB9,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x41,0xD3,0xE1,0x41,0x8B,0xC9,0xF7,0xD1,0x21,0x0E,0xFF,0xC2,0x3B,0xD0,0x7C,0x9C,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x30,0x5B,0x5E,0x5F,0xC3,0xE8,0xB4,0x48,0x5A,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 perm(BitVector32 x, Perm spec)
; location: [7FFDD9EEA670h, 7FFDD9EEA72Ch]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
000eh mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0011h mov [rsp+28h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 28
0015h mov edi,[rsp+28h]             ; MOV(Mov_r32_rm32) [EDI,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 7c 24 28
0019h lea rbx,[rsp+28h]             ; LEA(Lea_r64_m) [RBX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 5c 24 28
001eh mov rcx,7FFDD9997800h         ; MOV(Mov_r64_imm64) [RCX,7ffdd9997800h:imm64]         encoding(10 bytes) = 48 b9 00 78 99 d9 fd 7f 00 00
0028h mov edx,21h                   ; MOV(Mov_r32_imm32) [EDX,21h:imm32]                   encoding(5 bytes) = ba 21 00 00 00
002dh call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47A240h:jmp64]                encoding(5 bytes) = e8 0e a2 47 5f
0032h mov rcx,18720056E28h          ; MOV(Mov_r64_imm64) [RCX,18720056e28h:imm64]          encoding(10 bytes) = 48 b9 28 6e 05 20 87 01 00 00
003ch mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
003fh mov rax,[rcx+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(4 bytes) = 48 8b 41 08
0043h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0045h jmp short 00a4h               ; JMP(Jmp_rel8_64) [A4h:jmp64]                         encoding(2 bytes) = eb 5d
0047h cmp edx,[rsi+8]               ; CMP(Cmp_r32_rm32) [EDX,mem(32u,RSI:br,DS:sr)]        encoding(3 bytes) = 3b 56 08
004ah jae short 00b7h               ; JAE(Jae_rel8_64) [B7h:jmp64]                         encoding(2 bytes) = 73 6b
004ch movsxd rcx,edx                ; MOVSXD(Movsxd_r64_rm32) [RCX,EDX]                    encoding(3 bytes) = 48 63 ca
004fh lea rcx,[rsi+rcx*4+10h]       ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(5 bytes) = 48 8d 4c 8e 10
0054h mov ecx,[rcx]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 09
0056h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
0058h je short 00a2h                ; JE(Je_rel8_64) [A2h:jmp64]                           encoding(2 bytes) = 74 48
005ah movzx r8d,dl                  ; MOVZX(Movzx_r32_rm8) [R8D,DL]                        encoding(4 bytes) = 44 0f b6 c2
005eh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0061h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0064h bt edi,ecx                    ; BT(Bt_rm32_r32) [EDI,ECX]                            encoding(3 bytes) = 0f a3 cf
0067h setb cl                       ; SETB(Setb_rm8) [CL]                                  encoding(3 bytes) = 0f 92 c1
006ah movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
006dh mov [rsp+20h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(4 bytes) = 88 4c 24 20
0071h movzx ecx,byte ptr [rsp+20h]  ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 4c 24 20
0076h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
007ah test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
007ch je short 008fh                ; JE(Je_rel8_64) [8Fh:jmp64]                           encoding(2 bytes) = 74 11
007eh mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
0084h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0087h shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
008ah or [rbx],r9d                  ; OR(Or_rm32_r32) [mem(32u,RBX:br,DS:sr),R9D]          encoding(3 bytes) = 44 09 0b
008dh jmp short 00a2h               ; JMP(Jmp_rel8_64) [A2h:jmp64]                         encoding(2 bytes) = eb 13
008fh mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
0095h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0098h shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
009bh mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
009eh not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
00a0h and [rbx],ecx                 ; AND(And_rm32_r32) [mem(32u,RBX:br,DS:sr),ECX]        encoding(2 bytes) = 21 0b
00a2h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
00a4h cmp edx,eax                   ; CMP(Cmp_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 3b d0
00a6h jl short 0047h                ; JL(Jl_rel8_64) [47h:jmp64]                           encoding(2 bytes) = 7c 9f
00a8h lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
00adh mov eax,[rax]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 00
00afh add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
00b3h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00b4h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00b5h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00b6h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00b7h call 7FFE3948EF00h            ; CALL(Call_rel32_64) [5F5A4890h:jmp64]                encoding(5 bytes) = e8 d4 47 5a 5f
00bch int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> permBytes => new byte[189]{0x57,0x56,0x53,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x89,0x4C,0x24,0x28,0x8B,0x7C,0x24,0x28,0x48,0x8D,0x5C,0x24,0x28,0x48,0xB9,0x00,0x78,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x21,0x00,0x00,0x00,0xE8,0x0E,0xA2,0x47,0x5F,0x48,0xB9,0x28,0x6E,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x09,0x48,0x8B,0x41,0x08,0x33,0xD2,0xEB,0x5D,0x3B,0x56,0x08,0x73,0x6B,0x48,0x63,0xCA,0x48,0x8D,0x4C,0x8E,0x10,0x8B,0x09,0x3B,0xCA,0x74,0x48,0x44,0x0F,0xB6,0xC2,0x0F,0xB6,0xC9,0x0F,0xB6,0xC9,0x0F,0xA3,0xCF,0x0F,0x92,0xC1,0x0F,0xB6,0xC9,0x88,0x4C,0x24,0x20,0x0F,0xB6,0x4C,0x24,0x20,0x45,0x0F,0xB6,0xC0,0x84,0xC9,0x74,0x11,0x41,0xB9,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x41,0xD3,0xE1,0x44,0x09,0x0B,0xEB,0x13,0x41,0xB9,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x41,0xD3,0xE1,0x41,0x8B,0xC9,0xF7,0xD1,0x21,0x0B,0xFF,0xC2,0x3B,0xD0,0x7C,0x9F,0x48,0x8D,0x44,0x24,0x28,0x8B,0x00,0x48,0x83,0xC4,0x30,0x5B,0x5E,0x5F,0xC3,0xE8,0xD4,0x47,0x5A,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector64 perm(ref BitVector64 x, in Perm spec)
; location: [7FFDD9EEA750h, 7FFDD9EEA800h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0007h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000ah mov rdi,rdx                   ; MOV(Mov_r64_rm64) [RDI,RDX]                          encoding(3 bytes) = 48 8b fa
000dh mov rbx,[rsi]                 ; MOV(Mov_r64_rm64) [RBX,mem(64u,RSI:br,DS:sr)]        encoding(3 bytes) = 48 8b 1e
0010h mov rcx,7FFDD9997800h         ; MOV(Mov_r64_imm64) [RCX,7ffdd9997800h:imm64]         encoding(10 bytes) = 48 b9 00 78 99 d9 fd 7f 00 00
001ah mov edx,23h                   ; MOV(Mov_r32_imm32) [EDX,23h:imm32]                   encoding(5 bytes) = ba 23 00 00 00
001fh call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47A160h:jmp64]                encoding(5 bytes) = e8 3c a1 47 5f
0024h mov rcx,18720056E78h          ; MOV(Mov_r64_imm64) [RCX,18720056e78h:imm64]          encoding(10 bytes) = 48 b9 78 6e 05 20 87 01 00 00
002eh mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
0031h mov rax,[rcx+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(4 bytes) = 48 8b 41 08
0035h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0037h jmp short 009ch               ; JMP(Jmp_rel8_64) [9Ch:jmp64]                         encoding(2 bytes) = eb 63
0039h mov rcx,[rdi]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RDI:br,DS:sr)]        encoding(3 bytes) = 48 8b 0f
003ch cmp edx,[rcx+8]               ; CMP(Cmp_r32_rm32) [EDX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 3b 51 08
003fh jae short 00abh               ; JAE(Jae_rel8_64) [ABh:jmp64]                         encoding(2 bytes) = 73 6a
0041h movsxd r8,edx                 ; MOVSXD(Movsxd_r64_rm32) [R8,EDX]                     encoding(3 bytes) = 4c 63 c2
0044h lea rcx,[rcx+r8*4+10h]        ; LEA(Lea_r64_m) [RCX,mem(Unknown,RCX:br,DS:sr)]       encoding(5 bytes) = 4a 8d 4c 81 10
0049h mov ecx,[rcx]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 09
004bh cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
004dh je short 009ah                ; JE(Je_rel8_64) [9Ah:jmp64]                           encoding(2 bytes) = 74 4b
004fh movzx r8d,dl                  ; MOVZX(Movzx_r32_rm8) [R8D,DL]                        encoding(4 bytes) = 44 0f b6 c2
0053h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0056h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0059h bt rbx,rcx                    ; BT(Bt_rm64_r64) [RBX,RCX]                            encoding(4 bytes) = 48 0f a3 cb
005dh setb cl                       ; SETB(Setb_rm8) [CL]                                  encoding(3 bytes) = 0f 92 c1
0060h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0063h mov [rsp+28h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(4 bytes) = 88 4c 24 28
0067h movzx ecx,byte ptr [rsp+28h]  ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 4c 24 28
006ch movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0070h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0072h je short 0085h                ; JE(Je_rel8_64) [85h:jmp64]                           encoding(2 bytes) = 74 11
0074h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
007ah mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
007dh shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
0080h or [rsi],r9                   ; OR(Or_rm64_r64) [mem(64u,RSI:br,DS:sr),R9]           encoding(3 bytes) = 4c 09 0e
0083h jmp short 009ah               ; JMP(Jmp_rel8_64) [9Ah:jmp64]                         encoding(2 bytes) = eb 15
0085h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
008bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
008eh shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
0091h mov rcx,r9                    ; MOV(Mov_r64_rm64) [RCX,R9]                           encoding(3 bytes) = 49 8b c9
0094h not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
0097h and [rsi],rcx                 ; AND(And_rm64_r64) [mem(64u,RSI:br,DS:sr),RCX]        encoding(3 bytes) = 48 21 0e
009ah inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
009ch cmp edx,eax                   ; CMP(Cmp_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 3b d0
009eh jl short 0039h                ; JL(Jl_rel8_64) [39h:jmp64]                           encoding(2 bytes) = 7c 99
00a0h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
00a3h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
00a7h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00a8h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00a9h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00aah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00abh call 7FFE3948EF00h            ; CALL(Call_rel32_64) [5F5A47B0h:jmp64]                encoding(5 bytes) = e8 00 47 5a 5f
00b0h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> permBytes => new byte[177]{0x57,0x56,0x53,0x48,0x83,0xEC,0x30,0x48,0x8B,0xF1,0x48,0x8B,0xFA,0x48,0x8B,0x1E,0x48,0xB9,0x00,0x78,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x23,0x00,0x00,0x00,0xE8,0x3C,0xA1,0x47,0x5F,0x48,0xB9,0x78,0x6E,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x09,0x48,0x8B,0x41,0x08,0x33,0xD2,0xEB,0x63,0x48,0x8B,0x0F,0x3B,0x51,0x08,0x73,0x6A,0x4C,0x63,0xC2,0x4A,0x8D,0x4C,0x81,0x10,0x8B,0x09,0x3B,0xCA,0x74,0x4B,0x44,0x0F,0xB6,0xC2,0x0F,0xB6,0xC9,0x0F,0xB6,0xC9,0x48,0x0F,0xA3,0xCB,0x0F,0x92,0xC1,0x0F,0xB6,0xC9,0x88,0x4C,0x24,0x28,0x0F,0xB6,0x4C,0x24,0x28,0x45,0x0F,0xB6,0xC0,0x84,0xC9,0x74,0x11,0x41,0xB9,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x49,0xD3,0xE1,0x4C,0x09,0x0E,0xEB,0x15,0x41,0xB9,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x49,0xD3,0xE1,0x49,0x8B,0xC9,0x48,0xF7,0xD1,0x48,0x21,0x0E,0xFF,0xC2,0x3B,0xD0,0x7C,0x99,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x30,0x5B,0x5E,0x5F,0xC3,0xE8,0x00,0x47,0x5A,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 perm(BitVector64 x, Perm spec)
; location: [7FFDD9EEA820h, 7FFDD9EEA8E2h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
000eh mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0011h mov [rsp+28h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 28
0016h mov rdi,[rsp+28h]             ; MOV(Mov_r64_rm64) [RDI,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 7c 24 28
001bh lea rbx,[rsp+28h]             ; LEA(Lea_r64_m) [RBX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 5c 24 28
0020h mov rcx,7FFDD9997800h         ; MOV(Mov_r64_imm64) [RCX,7ffdd9997800h:imm64]         encoding(10 bytes) = 48 b9 00 78 99 d9 fd 7f 00 00
002ah mov edx,23h                   ; MOV(Mov_r32_imm32) [EDX,23h:imm32]                   encoding(5 bytes) = ba 23 00 00 00
002fh call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F47A090h:jmp64]                encoding(5 bytes) = e8 5c a0 47 5f
0034h mov rcx,18720056E78h          ; MOV(Mov_r64_imm64) [RCX,18720056e78h:imm64]          encoding(10 bytes) = 48 b9 78 6e 05 20 87 01 00 00
003eh mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
0041h mov rax,[rcx+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(4 bytes) = 48 8b 41 08
0045h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0047h jmp short 00a9h               ; JMP(Jmp_rel8_64) [A9h:jmp64]                         encoding(2 bytes) = eb 60
0049h cmp edx,[rsi+8]               ; CMP(Cmp_r32_rm32) [EDX,mem(32u,RSI:br,DS:sr)]        encoding(3 bytes) = 3b 56 08
004ch jae short 00bdh               ; JAE(Jae_rel8_64) [BDh:jmp64]                         encoding(2 bytes) = 73 6f
004eh movsxd rcx,edx                ; MOVSXD(Movsxd_r64_rm32) [RCX,EDX]                    encoding(3 bytes) = 48 63 ca
0051h lea rcx,[rsi+rcx*4+10h]       ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSI:br,DS:sr)]       encoding(5 bytes) = 48 8d 4c 8e 10
0056h mov ecx,[rcx]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 09
0058h cmp ecx,edx                   ; CMP(Cmp_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 3b ca
005ah je short 00a7h                ; JE(Je_rel8_64) [A7h:jmp64]                           encoding(2 bytes) = 74 4b
005ch movzx r8d,dl                  ; MOVZX(Movzx_r32_rm8) [R8D,DL]                        encoding(4 bytes) = 44 0f b6 c2
0060h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0063h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0066h bt rdi,rcx                    ; BT(Bt_rm64_r64) [RDI,RCX]                            encoding(4 bytes) = 48 0f a3 cf
006ah setb cl                       ; SETB(Setb_rm8) [CL]                                  encoding(3 bytes) = 0f 92 c1
006dh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0070h mov [rsp+20h],cl              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(4 bytes) = 88 4c 24 20
0074h movzx ecx,byte ptr [rsp+20h]  ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 4c 24 20
0079h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
007dh test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
007fh je short 0092h                ; JE(Je_rel8_64) [92h:jmp64]                           encoding(2 bytes) = 74 11
0081h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
0087h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
008ah shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
008dh or [rbx],r9                   ; OR(Or_rm64_r64) [mem(64u,RBX:br,DS:sr),R9]           encoding(3 bytes) = 4c 09 0b
0090h jmp short 00a7h               ; JMP(Jmp_rel8_64) [A7h:jmp64]                         encoding(2 bytes) = eb 15
0092h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
0098h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
009bh shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
009eh mov rcx,r9                    ; MOV(Mov_r64_rm64) [RCX,R9]                           encoding(3 bytes) = 49 8b c9
00a1h not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
00a4h and [rbx],rcx                 ; AND(And_rm64_r64) [mem(64u,RBX:br,DS:sr),RCX]        encoding(3 bytes) = 48 21 0b
00a7h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
00a9h cmp edx,eax                   ; CMP(Cmp_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 3b d0
00abh jl short 0049h                ; JL(Jl_rel8_64) [49h:jmp64]                           encoding(2 bytes) = 7c 9c
00adh lea rax,[rsp+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 28
00b2h mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
00b5h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
00b9h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00bah pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00bbh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00bch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00bdh call 7FFE3948EF00h            ; CALL(Call_rel32_64) [5F5A46E0h:jmp64]                encoding(5 bytes) = e8 1e 46 5a 5f
00c2h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> permBytes => new byte[195]{0x57,0x56,0x53,0x48,0x83,0xEC,0x30,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF2,0x48,0x89,0x4C,0x24,0x28,0x48,0x8B,0x7C,0x24,0x28,0x48,0x8D,0x5C,0x24,0x28,0x48,0xB9,0x00,0x78,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x23,0x00,0x00,0x00,0xE8,0x5C,0xA0,0x47,0x5F,0x48,0xB9,0x78,0x6E,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x09,0x48,0x8B,0x41,0x08,0x33,0xD2,0xEB,0x60,0x3B,0x56,0x08,0x73,0x6F,0x48,0x63,0xCA,0x48,0x8D,0x4C,0x8E,0x10,0x8B,0x09,0x3B,0xCA,0x74,0x4B,0x44,0x0F,0xB6,0xC2,0x0F,0xB6,0xC9,0x0F,0xB6,0xC9,0x48,0x0F,0xA3,0xCF,0x0F,0x92,0xC1,0x0F,0xB6,0xC9,0x88,0x4C,0x24,0x20,0x0F,0xB6,0x4C,0x24,0x20,0x45,0x0F,0xB6,0xC0,0x84,0xC9,0x74,0x11,0x41,0xB9,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x49,0xD3,0xE1,0x4C,0x09,0x0B,0xEB,0x15,0x41,0xB9,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x49,0xD3,0xE1,0x49,0x8B,0xC9,0x48,0xF7,0xD1,0x48,0x21,0x0B,0xFF,0xC2,0x3B,0xD0,0x7C,0x9C,0x48,0x8D,0x44,0x24,0x28,0x48,0x8B,0x00,0x48,0x83,0xC4,0x30,0x5B,0x5E,0x5F,0xC3,0xE8,0x1E,0x46,0x5A,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(BitVector4 x)
; location: [7FFDD9EEA900h, 7FFDD9EEA90Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(BitVector8 x)
; location: [7FFDD9EEA920h, 7FFDD9EEA92Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(BitVector16 x)
; location: [7FFDD9EEA940h, 7FFDD9EEA94Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(BitVector32 x)
; location: [7FFDD9EEA960h, 7FFDD9EEA96Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt eax,ecx                ; POPCNT(Popcnt_r32_rm32) [EAX,ECX]                    encoding(4 bytes) = f3 0f b8 c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x0F,0xB8,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(BitVector64 x)
; location: [7FFDD9EEA980h, 7FFDD9EEA98Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt rax,rcx                ; POPCNT(Popcnt_r64_rm64) [RAX,RCX]                    encoding(5 bytes) = f3 48 0f b8 c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xB8,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 pow(BitVector8 x, int n)
; location: [7FFDD9EEA9A0h, 7FFDD9EEAC80h]
0000h push r14                      ; PUSH(Push_r64) [R14]                                 encoding(2 bytes) = 41 56
0002h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0003h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0004h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0005h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0006h sub rsp,140h                  ; SUB(Sub_rm64_imm32) [RSP,140h:imm64]                 encoding(7 bytes) = 48 81 ec 40 01 00 00
000dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0010h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0013h lea rdi,[rsp+20h]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 7c 24 20
0018h mov ecx,48h                   ; MOV(Mov_r32_imm32) [ECX,48h:imm32]                   encoding(5 bytes) = b9 48 00 00 00
001dh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
001fh rep stosd                     ; STOSD(Stosd_m32_EAX) [mem(32u),EAX]                  encoding(2 bytes) = f3 ab
0021h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0024h mov edi,ecx                   ; MOV(Mov_r32_rm32) [EDI,ECX]                          encoding(2 bytes) = 8b f9
0026h mov esi,edx                   ; MOV(Mov_r32_rm32) [ESI,EDX]                          encoding(2 bytes) = 8b f2
0028h test esi,esi                  ; TEST(Test_rm32_r32) [ESI,ESI]                        encoding(2 bytes) = 85 f6
002ah jne short 0060h               ; JNE(Jne_rel8_64) [60h:jmp64]                         encoding(2 bytes) = 75 34
002ch mov rcx,7FFDD9997800h         ; MOV(Mov_r64_imm64) [RCX,7ffdd9997800h:imm64]         encoding(10 bytes) = 48 b9 00 78 99 d9 fd 7f 00 00
0036h mov edx,24h                   ; MOV(Mov_r32_imm32) [EDX,24h:imm32]                   encoding(5 bytes) = ba 24 00 00 00
003bh call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F479F10h:jmp64]                encoding(5 bytes) = e8 d0 9e 47 5f
0040h mov rax,18720056E88h          ; MOV(Mov_r64_imm64) [RAX,18720056e88h:imm64]          encoding(10 bytes) = 48 b8 88 6e 05 20 87 01 00 00
004ah mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 00
004dh movsx rax,byte ptr [rax+8]    ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RAX:br,DS:sr)]      encoding(5 bytes) = 48 0f be 40 08
0052h add rsp,140h                  ; ADD(Add_rm64_imm32) [RSP,140h:imm64]                 encoding(7 bytes) = 48 81 c4 40 01 00 00
0059h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
005ah pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
005bh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
005ch pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
005dh pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
005fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0060h cmp esi,1                     ; CMP(Cmp_rm32_imm8) [ESI,1h:imm32]                    encoding(3 bytes) = 83 fe 01
0063h jne short 0077h               ; JNE(Jne_rel8_64) [77h:jmp64]                         encoding(2 bytes) = 75 12
0065h movzx eax,dil                 ; MOVZX(Movzx_r32_rm8) [EAX,DIL]                       encoding(4 bytes) = 40 0f b6 c7
0069h add rsp,140h                  ; ADD(Add_rm64_imm32) [RSP,140h:imm64]                 encoding(7 bytes) = 48 81 c4 40 01 00 00
0070h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0071h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
0072h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0073h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0074h pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
0076h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0077h movzx eax,dil                 ; MOVZX(Movzx_r32_rm8) [EAX,DIL]                       encoding(4 bytes) = 40 0f b6 c7
007bh mov [rsp+138h],al             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(7 bytes) = 88 84 24 38 01 00 00
0082h mov ebx,2                     ; MOV(Mov_r32_imm32) [EBX,2h:imm32]                    encoding(5 bytes) = bb 02 00 00 00
0087h cmp esi,2                     ; CMP(Cmp_rm32_imm8) [ESI,2h:imm32]                    encoding(3 bytes) = 83 fe 02
008ah jl near ptr 02c9h             ; JL(Jl_rel32_64) [2C9h:jmp64]                         encoding(6 bytes) = 0f 8c 39 02 00 00
0090h mov rcx,7FFDD9997800h         ; MOV(Mov_r64_imm64) [RCX,7ffdd9997800h:imm64]         encoding(10 bytes) = 48 b9 00 78 99 d9 fd 7f 00 00
009ah mov edx,2Fh                   ; MOV(Mov_r32_imm32) [EDX,2fh:imm32]                   encoding(5 bytes) = ba 2f 00 00 00
009fh call 7FFE393648B0h            ; CALL(Call_rel32_64) [5F479F10h:jmp64]                encoding(5 bytes) = e8 6c 9e 47 5f
00a4h movzx ecx,dil                 ; MOVZX(Movzx_r32_rm8) [ECX,DIL]                       encoding(4 bytes) = 40 0f b6 cf
00a8h mov edi,ecx                   ; MOV(Mov_r32_rm32) [EDI,ECX]                          encoding(2 bytes) = 8b f9
00aah mov ecx,[rsp+138h]            ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 8c 24 38 01 00 00
00b1h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
00b4h movzx ebp,word ptr [7FFDD9997A38h]; MOVZX(Movzx_r32_rm16) [EBP,mem(16u,RIP:br,DS:sr)] encoding(7 bytes) = 0f b7 2d dd cf aa ff
00bbh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
00beh mov [rsp+118h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 18 01 00 00
00c6h mov [rsp+100h],rdi            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDI]        encoding(8 bytes) = 48 89 bc 24 00 01 00 00
00ceh vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
00d2h vmovupd [rsp+108h],xmm0       ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 11 84 24 08 01 00 00
00dbh vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
00dfh vmovapd [rsp+0F0h],xmm0       ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 29 84 24 f0 00 00 00
00e8h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
00ech vmovapd [rsp+0E0h],xmm0       ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 29 84 24 e0 00 00 00
00f5h lea rcx,[rsp+108h]            ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 08 01 00 00
00fdh lea rdx,[rsp+118h]            ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 94 24 18 01 00 00
0105h call 7FFDD9ED8EC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFEE520h:jmp64]        encoding(5 bytes) = e8 16 e4 fe ff
010ah lea rcx,[rsp+0F0h]            ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 f0 00 00 00
0112h lea rdx,[rsp+100h]            ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 94 24 00 01 00 00
011ah call 7FFDD9ED8EC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFEE520h:jmp64]        encoding(5 bytes) = e8 01 e4 fe ff
011fh vmovupd xmm0,[rsp+108h]       ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 f9 10 84 24 08 01 00 00
0128h vmovapd xmm1,[rsp+0F0h]       ; VMOVAPD(VEX_Vmovapd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 f9 28 8c 24 f0 00 00 00
0131h vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
0137h vmovapd [rsp+0E0h],xmm0       ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 29 84 24 e0 00 00 00
0140h vmovdqu xmm0,xmmword ptr [rsp+0E0h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 e0 00 00 00
0149h vmovdqu xmmword ptr [rsp+120h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 20 01 00 00
0152h mov rcx,[rsp+0F0h]            ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 8c 24 f0 00 00 00
015ah mov [rsp+130h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 30 01 00 00
0162h movzx r14d,word ptr [rsp+120h]; MOVZX(Movzx_r32_rm16) [R14D,mem(16u,RSP:br,SS:sr)]   encoding(9 bytes) = 44 0f b7 b4 24 20 01 00 00
016bh mov ecx,r14d                  ; MOV(Mov_r32_rm32) [ECX,R14D]                         encoding(3 bytes) = 41 8b ce
016eh sar ecx,8                     ; SAR(Sar_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 f9 08
0171h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0174h mov [rsp+0C0h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 c0 00 00 00
017ch mov ecx,ebp                   ; MOV(Mov_r32_rm32) [ECX,EBP]                          encoding(2 bytes) = 8b cd
017eh mov [rsp+0A8h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 a8 00 00 00
0186h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
018ah vmovapd [rsp+0B0h],xmm0       ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 29 84 24 b0 00 00 00
0193h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0197h vmovupd [rsp+98h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 11 84 24 98 00 00 00
01a0h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
01a4h vmovapd [rsp+80h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 29 84 24 80 00 00 00
01adh lea rcx,[rsp+0B0h]            ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 b0 00 00 00
01b5h lea rdx,[rsp+0C0h]            ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 94 24 c0 00 00 00
01bdh call 7FFDD9ED8EC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFEE520h:jmp64]        encoding(5 bytes) = e8 5e e3 fe ff
01c2h lea rcx,[rsp+98h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 98 00 00 00
01cah lea rdx,[rsp+0A8h]            ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 94 24 a8 00 00 00
01d2h call 7FFDD9ED8EC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFEE520h:jmp64]        encoding(5 bytes) = e8 49 e3 fe ff
01d7h vmovapd xmm0,[rsp+0B0h]       ; VMOVAPD(VEX_Vmovapd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 f9 28 84 24 b0 00 00 00
01e0h vmovupd xmm1,[rsp+98h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 f9 10 8c 24 98 00 00 00
01e9h vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
01efh vmovapd [rsp+80h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 f9 29 84 24 80 00 00 00
01f8h vmovdqu xmm0,xmmword ptr [rsp+80h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 9 bytes) = c5 fa 6f 84 24 80 00 00 00
0201h vmovdqu xmmword ptr [rsp+0C8h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 9 bytes) = c5 fa 7f 84 24 c8 00 00 00
020ah mov rcx,[rsp+90h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 8c 24 90 00 00 00
0212h mov [rsp+0D8h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 d8 00 00 00
021ah movzx ecx,word ptr [rsp+0C8h] ; MOVZX(Movzx_r32_rm16) [ECX,mem(16u,RSP:br,SS:sr)]    encoding(8 bytes) = 0f b7 8c 24 c8 00 00 00
0222h xor ecx,r14d                  ; XOR(Xor_r32_rm32) [ECX,R14D]                         encoding(3 bytes) = 41 33 ce
0225h movzx r14d,cx                 ; MOVZX(Movzx_r32_rm16) [R14D,CX]                      encoding(4 bytes) = 44 0f b7 f1
0229h mov ecx,r14d                  ; MOV(Mov_r32_rm32) [ECX,R14D]                         encoding(3 bytes) = 41 8b ce
022ch sar ecx,8                     ; SAR(Sar_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 f9 08
022fh movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0232h mov [rsp+60h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 60
0237h mov ecx,ebp                   ; MOV(Mov_r32_rm32) [ECX,EBP]                          encoding(2 bytes) = 8b cd
0239h mov [rsp+48h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(5 bytes) = 48 89 4c 24 48
023eh vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0242h vmovapd [rsp+50h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 50
0248h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
024ch vmovupd [rsp+38h],xmm0        ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 11 44 24 38
0252h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
0256h vmovapd [rsp+20h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 20
025ch lea rcx,[rsp+50h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 50
0261h lea rdx,[rsp+60h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 60
0266h call 7FFDD9ED8EC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFEE520h:jmp64]        encoding(5 bytes) = e8 b5 e2 fe ff
026bh lea rcx,[rsp+38h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 38
0270h lea rdx,[rsp+48h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 48
0275h call 7FFDD9ED8EC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFEE520h:jmp64]        encoding(5 bytes) = e8 a6 e2 fe ff
027ah vmovapd xmm0,[rsp+50h]        ; VMOVAPD(VEX_Vmovapd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 28 44 24 50
0280h vmovupd xmm1,[rsp+38h]        ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 f9 10 4c 24 38
0286h vpclmullqlqdq xmm0,xmm0,xmm1  ; VPCLMULQDQ(VEX_Vpclmulqdq_xmm_xmm_xmmm128_imm8) [XMM0,XMM0,XMM1,0h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 44 c1 00
028ch vmovapd [rsp+20h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 20
0292h vmovdqu xmm0,xmmword ptr [rsp+20h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 20
0298h vmovdqu xmmword ptr [rsp+68h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 7f 44 24 68
029eh mov rax,[rsp+30h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 30
02a3h mov [rsp+78h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 78
02a8h movzx eax,word ptr [rsp+68h]  ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RSP:br,SS:sr)]    encoding(5 bytes) = 0f b7 44 24 68
02adh xor eax,r14d                  ; XOR(Xor_r32_rm32) [EAX,R14D]                         encoding(3 bytes) = 41 33 c6
02b0h movzx r14d,ax                 ; MOVZX(Movzx_r32_rm16) [R14D,AX]                      encoding(4 bytes) = 44 0f b7 f0
02b4h movzx eax,r14b                ; MOVZX(Movzx_r32_rm8) [EAX,R14L]                      encoding(4 bytes) = 41 0f b6 c6
02b8h mov [rsp+138h],al             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(7 bytes) = 88 84 24 38 01 00 00
02bfh inc ebx                       ; INC(Inc_rm32) [EBX]                                  encoding(2 bytes) = ff c3
02c1h cmp ebx,esi                   ; CMP(Cmp_r32_rm32) [EBX,ESI]                          encoding(2 bytes) = 3b de
02c3h jle near ptr 00aah            ; JLE(Jle_rel32_64) [AAh:jmp64]                        encoding(6 bytes) = 0f 8e e1 fd ff ff
02c9h mov eax,[rsp+138h]            ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 84 24 38 01 00 00
02d0h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
02d3h add rsp,140h                  ; ADD(Add_rm64_imm32) [RSP,140h:imm64]                 encoding(7 bytes) = 48 81 c4 40 01 00 00
02dah pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
02dbh pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
02dch pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
02ddh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
02deh pop r14                       ; POP(Pop_r64) [R14]                                   encoding(2 bytes) = 41 5e
02e0h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> powBytes => new byte[737]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x81,0xEC,0x40,0x01,0x00,0x00,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0x48,0x8D,0x7C,0x24,0x20,0xB9,0x48,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0x8B,0xF9,0x8B,0xF2,0x85,0xF6,0x75,0x34,0x48,0xB9,0x00,0x78,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x24,0x00,0x00,0x00,0xE8,0xD0,0x9E,0x47,0x5F,0x48,0xB8,0x88,0x6E,0x05,0x20,0x87,0x01,0x00,0x00,0x48,0x8B,0x00,0x48,0x0F,0xBE,0x40,0x08,0x48,0x81,0xC4,0x40,0x01,0x00,0x00,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0xC3,0x83,0xFE,0x01,0x75,0x12,0x40,0x0F,0xB6,0xC7,0x48,0x81,0xC4,0x40,0x01,0x00,0x00,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0xC3,0x40,0x0F,0xB6,0xC7,0x88,0x84,0x24,0x38,0x01,0x00,0x00,0xBB,0x02,0x00,0x00,0x00,0x83,0xFE,0x02,0x0F,0x8C,0x39,0x02,0x00,0x00,0x48,0xB9,0x00,0x78,0x99,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x2F,0x00,0x00,0x00,0xE8,0x6C,0x9E,0x47,0x5F,0x40,0x0F,0xB6,0xCF,0x8B,0xF9,0x8B,0x8C,0x24,0x38,0x01,0x00,0x00,0x0F,0xB6,0xC9,0x0F,0xB7,0x2D,0xDD,0xCF,0xAA,0xFF,0x0F,0xB6,0xC9,0x48,0x89,0x8C,0x24,0x18,0x01,0x00,0x00,0x48,0x89,0xBC,0x24,0x00,0x01,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x11,0x84,0x24,0x08,0x01,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x84,0x24,0xF0,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x84,0x24,0xE0,0x00,0x00,0x00,0x48,0x8D,0x8C,0x24,0x08,0x01,0x00,0x00,0x48,0x8D,0x94,0x24,0x18,0x01,0x00,0x00,0xE8,0x16,0xE4,0xFE,0xFF,0x48,0x8D,0x8C,0x24,0xF0,0x00,0x00,0x00,0x48,0x8D,0x94,0x24,0x00,0x01,0x00,0x00,0xE8,0x01,0xE4,0xFE,0xFF,0xC5,0xF9,0x10,0x84,0x24,0x08,0x01,0x00,0x00,0xC5,0xF9,0x28,0x8C,0x24,0xF0,0x00,0x00,0x00,0xC4,0xE3,0x79,0x44,0xC1,0x00,0xC5,0xF9,0x29,0x84,0x24,0xE0,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0xE0,0x00,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0x20,0x01,0x00,0x00,0x48,0x8B,0x8C,0x24,0xF0,0x00,0x00,0x00,0x48,0x89,0x8C,0x24,0x30,0x01,0x00,0x00,0x44,0x0F,0xB7,0xB4,0x24,0x20,0x01,0x00,0x00,0x41,0x8B,0xCE,0xC1,0xF9,0x08,0x0F,0xB7,0xC9,0x48,0x89,0x8C,0x24,0xC0,0x00,0x00,0x00,0x8B,0xCD,0x48,0x89,0x8C,0x24,0xA8,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x84,0x24,0xB0,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x11,0x84,0x24,0x98,0x00,0x00,0x00,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x84,0x24,0x80,0x00,0x00,0x00,0x48,0x8D,0x8C,0x24,0xB0,0x00,0x00,0x00,0x48,0x8D,0x94,0x24,0xC0,0x00,0x00,0x00,0xE8,0x5E,0xE3,0xFE,0xFF,0x48,0x8D,0x8C,0x24,0x98,0x00,0x00,0x00,0x48,0x8D,0x94,0x24,0xA8,0x00,0x00,0x00,0xE8,0x49,0xE3,0xFE,0xFF,0xC5,0xF9,0x28,0x84,0x24,0xB0,0x00,0x00,0x00,0xC5,0xF9,0x10,0x8C,0x24,0x98,0x00,0x00,0x00,0xC4,0xE3,0x79,0x44,0xC1,0x00,0xC5,0xF9,0x29,0x84,0x24,0x80,0x00,0x00,0x00,0xC5,0xFA,0x6F,0x84,0x24,0x80,0x00,0x00,0x00,0xC5,0xFA,0x7F,0x84,0x24,0xC8,0x00,0x00,0x00,0x48,0x8B,0x8C,0x24,0x90,0x00,0x00,0x00,0x48,0x89,0x8C,0x24,0xD8,0x00,0x00,0x00,0x0F,0xB7,0x8C,0x24,0xC8,0x00,0x00,0x00,0x41,0x33,0xCE,0x44,0x0F,0xB7,0xF1,0x41,0x8B,0xCE,0xC1,0xF9,0x08,0x0F,0xB7,0xC9,0x48,0x89,0x4C,0x24,0x60,0x8B,0xCD,0x48,0x89,0x4C,0x24,0x48,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x44,0x24,0x50,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x11,0x44,0x24,0x38,0xC5,0xF8,0x57,0xC0,0xC5,0xF9,0x29,0x44,0x24,0x20,0x48,0x8D,0x4C,0x24,0x50,0x48,0x8D,0x54,0x24,0x60,0xE8,0xB5,0xE2,0xFE,0xFF,0x48,0x8D,0x4C,0x24,0x38,0x48,0x8D,0x54,0x24,0x48,0xE8,0xA6,0xE2,0xFE,0xFF,0xC5,0xF9,0x28,0x44,0x24,0x50,0xC5,0xF9,0x10,0x4C,0x24,0x38,0xC4,0xE3,0x79,0x44,0xC1,0x00,0xC5,0xF9,0x29,0x44,0x24,0x20,0xC5,0xFA,0x6F,0x44,0x24,0x20,0xC5,0xFA,0x7F,0x44,0x24,0x68,0x48,0x8B,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x78,0x0F,0xB7,0x44,0x24,0x68,0x41,0x33,0xC6,0x44,0x0F,0xB7,0xF0,0x41,0x0F,0xB6,0xC6,0x88,0x84,0x24,0x38,0x01,0x00,0x00,0xFF,0xC3,0x3B,0xDE,0x0F,0x8E,0xE1,0xFD,0xFF,0xFF,0x8B,0x84,0x24,0x38,0x01,0x00,0x00,0x0F,0xB6,0xC0,0x48,0x81,0xC4,0x40,0x01,0x00,0x00,0x5B,0x5D,0x5E,0x5F,0x41,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 sll(BitVector4 x, int offset)
; location: [7FFDD9EEACD0h, 7FFDD9EEACEEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh shl eax,4                     ; SHL(Shl_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e0 04
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
0018h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
001bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xE0,0x0F,0xB6,0xC0,0xC1,0xE0,0x04,0x0F,0xB6,0xC0,0xC1,0xF8,0x04,0x83,0xE0,0x0F,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 sll(BitVector8 x, int offset)
; location: [7FFDD9EEAD00h, 7FFDD9EEAD12h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xE0,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 sll(BitVector16 x, int offset)
; location: [7FFDD9EEAD30h, 7FFDD9EEAD3Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0xD3,0xE0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 sll(BitVector32 x, int offset)
; location: [7FFDD9EEAD50h, 7FFDD9EEAD5Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 sll(BitVector64 x, int offset)
; location: [7FFDD9EEAD70h, 7FFDD9EEAD7Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector8 sll(ref BitVector8 x, int offset)
; location: [7FFDD9EEAD90h, 7FFDD9EEADA4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movzx r8d,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,DS:sr)]      encoding(4 bytes) = 44 0f b6 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0011h mov [rax],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R8L]           encoding(3 bytes) = 44 88 00
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x0F,0xB6,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x88,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector16 sll(ref BitVector16 x, int offset)
; location: [7FFDD9EEADC0h, 7FFDD9EEADD5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movzx r8d,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [R8D,mem(16u,RAX:br,DS:sr)]    encoding(4 bytes) = 44 0f b7 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0011h mov [rax],r8w                 ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R8W]        encoding(4 bytes) = 66 44 89 00
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x0F,0xB7,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x66,0x44,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector32 sll(ref BitVector32 x, int offset)
; location: [7FFDD9EEADF0h, 7FFDD9EEAE03h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,[rax]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 44 8b 00
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0010h mov [rax],r8d                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),R8D]        encoding(3 bytes) = 44 89 00
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x8B,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref BitVector64 sll(ref BitVector64 x, int offset)
; location: [7FFDD9EEAE20h, 7FFDD9EEAE33h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8,[rax]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RAX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 00
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0010h mov [rax],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),R8]         encoding(3 bytes) = 4c 89 00
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sllBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x8B,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x4C,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector4 srl(BitVector4 x, int offset)
; location: [7FFDD9EEAE50h, 7FFDD9EEAE6Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh shl eax,4                     ; SHL(Shl_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e0 04
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
0018h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
001bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xE8,0x0F,0xB6,0xC0,0xC1,0xE0,0x04,0x0F,0xB6,0xC0,0xC1,0xF8,0x04,0x83,0xE0,0x0F,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector8 srl(BitVector8 x, int offset)
; location: [7FFDD9EEAE80h, 7FFDD9EEAE8Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0xD3,0xE8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector16 srl(BitVector16 x, int offset)
; location: [7FFDD9EEAEA0h, 7FFDD9EEAEAFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0xD3,0xE8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector32 srl(BitVector32 x, int offset)
; location: [7FFDD9EEAEC0h, 7FFDD9EEAECBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h shr eax,cl                    ; SHR(Shr_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector64 srl(BitVector64 x, int offset)
; location: [7FFDD9EEAEE0h, 7FFDD9EEAEEDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah shr rax,cl                    ; SHR(Shr_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srlBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
