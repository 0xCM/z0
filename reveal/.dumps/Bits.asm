; 2019-10-22 17:23:21:943
; function: void split(uint src, out ushort x0, out ushort x1)
; location: [7FFDD9B5A270h, 7FFDD9B5A27Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],cx                  ; MOV(Mov_rm16_r16) [mem(16u,RDX:br,DS:sr),CX]         encoding(3 bytes) = 66 89 0a
0008h shr ecx,10h                   ; SHR(Shr_rm32_imm8) [ECX,10h:imm8]                    encoding(3 bytes) = c1 e9 10
000bh mov [r8],cx                   ; MOV(Mov_rm16_r16) [mem(16u,R8:br,DS:sr),CX]          encoding(4 bytes) = 66 41 89 08
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x66,0x89,0x0A,0xC1,0xE9,0x10,0x66,0x41,0x89,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split(long src, out int x0, out int x1)
; location: [7FFDD9B5A290h, 7FFDD9B5A2A0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),ECX]        encoding(2 bytes) = 89 0a
0007h sar rcx,20h                   ; SAR(Sar_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 f9 20
000bh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000dh mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x0A,0x48,0xC1,0xF9,0x20,0x8B,0xC1,0x41,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split(ulong src, out uint x0, out uint x1)
; location: [7FFDD9B5A2C0h, 7FFDD9B5A2D0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),ECX]        encoding(2 bytes) = 89 0a
0007h shr rcx,20h                   ; SHR(Shr_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 e9 20
000bh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000dh mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x0A,0x48,0xC1,0xE9,0x20,0x8B,0xC1,0x41,0x89,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split(uint src, out byte x0, out byte x1, out byte x2, out byte x3)
; location: [7FFDD9B5A2F0h, 7FFDD9B5A311h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),CL]            encoding(2 bytes) = 88 0a
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h shr eax,8                     ; SHR(Shr_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e8 08
000ch mov [r8],al                   ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),AL]             encoding(3 bytes) = 41 88 00
000fh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0011h shr eax,10h                   ; SHR(Shr_rm32_imm8) [EAX,10h:imm8]                    encoding(3 bytes) = c1 e8 10
0014h mov [r9],al                   ; MOV(Mov_rm8_r8) [mem(8u,R9:br,DS:sr),AL]             encoding(3 bytes) = 41 88 01
0017h shr ecx,18h                   ; SHR(Shr_rm32_imm8) [ECX,18h:imm8]                    encoding(3 bytes) = c1 e9 18
001ah mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
001fh mov [rax],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),CL]            encoding(2 bytes) = 88 08
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x88,0x0A,0x8B,0xC1,0xC1,0xE8,0x08,0x41,0x88,0x00,0x8B,0xC1,0xC1,0xE8,0x10,0x41,0x88,0x01,0xC1,0xE9,0x18,0x48,0x8B,0x44,0x24,0x28,0x88,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split(ulong src, out byte x0, out byte x1, out byte x2, out byte x3, out byte x4, out byte x5, out byte x6, out byte x7)
; location: [7FFDD9B5A330h, 7FFDD9B5A38Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),CL]            encoding(2 bytes) = 88 0a
0007h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000ah shr rax,8                     ; SHR(Shr_rm64_imm8) [RAX,8h:imm8]                     encoding(4 bytes) = 48 c1 e8 08
000eh mov [r8],al                   ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),AL]             encoding(3 bytes) = 41 88 00
0011h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0014h shr rax,10h                   ; SHR(Shr_rm64_imm8) [RAX,10h:imm8]                    encoding(4 bytes) = 48 c1 e8 10
0018h mov [r9],al                   ; MOV(Mov_rm8_r8) [mem(8u,R9:br,DS:sr),AL]             encoding(3 bytes) = 41 88 01
001bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001eh shr rax,18h                   ; SHR(Shr_rm64_imm8) [RAX,18h:imm8]                    encoding(4 bytes) = 48 c1 e8 18
0022h mov rdx,[rsp+28h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 54 24 28
0027h mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),AL]            encoding(2 bytes) = 88 02
0029h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002ch shr rax,20h                   ; SHR(Shr_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e8 20
0030h mov rdx,[rsp+30h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 54 24 30
0035h mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),AL]            encoding(2 bytes) = 88 02
0037h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
003ah shr rax,28h                   ; SHR(Shr_rm64_imm8) [RAX,28h:imm8]                    encoding(4 bytes) = 48 c1 e8 28
003eh mov rdx,[rsp+38h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 54 24 38
0043h mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),AL]            encoding(2 bytes) = 88 02
0045h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0048h shr rax,30h                   ; SHR(Shr_rm64_imm8) [RAX,30h:imm8]                    encoding(4 bytes) = 48 c1 e8 30
004ch mov rdx,[rsp+40h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 54 24 40
0051h mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),AL]            encoding(2 bytes) = 88 02
0053h shr rcx,38h                   ; SHR(Shr_rm64_imm8) [RCX,38h:imm8]                    encoding(4 bytes) = 48 c1 e9 38
0057h mov rax,[rsp+48h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 48
005ch mov [rax],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),CL]            encoding(2 bytes) = 88 08
005eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[95]{0x0F,0x1F,0x44,0x00,0x00,0x88,0x0A,0x48,0x8B,0xC1,0x48,0xC1,0xE8,0x08,0x41,0x88,0x00,0x48,0x8B,0xC1,0x48,0xC1,0xE8,0x10,0x41,0x88,0x01,0x48,0x8B,0xC1,0x48,0xC1,0xE8,0x18,0x48,0x8B,0x54,0x24,0x28,0x88,0x02,0x48,0x8B,0xC1,0x48,0xC1,0xE8,0x20,0x48,0x8B,0x54,0x24,0x30,0x88,0x02,0x48,0x8B,0xC1,0x48,0xC1,0xE8,0x28,0x48,0x8B,0x54,0x24,0x38,0x88,0x02,0x48,0x8B,0xC1,0x48,0xC1,0xE8,0x30,0x48,0x8B,0x54,0x24,0x40,0x88,0x02,0x48,0xC1,0xE9,0x38,0x48,0x8B,0x44,0x24,0x48,0x88,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split(uint src, int index, out uint x0, out uint x1)
; location: [7FFDD9B5A3A0h, 7FFDD9B5A3D6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rdx-1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RDX:br,DS:sr)]       encoding(3 bytes) = 8d 42 ff
0008h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000bh shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000eh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0011h bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
0016h mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
0019h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
001bh neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
001dh add eax,1Fh                   ; ADD(Add_rm32_imm8) [EAX,1fh:imm32]                   encoding(3 bytes) = 83 c0 1f
0020h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0023h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0026h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0029h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
002bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
002eh bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
0033h mov [r9],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R9:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 01
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x42,0xFF,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0x41,0x89,0x00,0x8B,0xC2,0xF7,0xD8,0x83,0xC0,0x1F,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0x41,0x89,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split(ulong src, int index, out ulong x0, out ulong x1)
; location: [7FFDD9B5A3F0h, 7FFDD9B5A426h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rdx-1]               ; LEA(Lea_r32_m) [EAX,mem(Unknown,RDX:br,DS:sr)]       encoding(3 bytes) = 8d 42 ff
0008h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000bh shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000eh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0011h bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
0016h mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 00
0019h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
001bh neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
001dh add eax,3Fh                   ; ADD(Add_rm32_imm8) [EAX,3fh:imm32]                   encoding(3 bytes) = 83 c0 3f
0020h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0023h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0026h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0029h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
002bh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
002eh bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
0033h mov [r9],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R9:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 01
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x42,0xFF,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0x49,0x89,0x00,0x8B,0xC2,0xF7,0xD8,0x83,0xC0,0x3F,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0x49,0x89,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(sbyte src, int pos)
; location: [7FFDD9B5A440h, 7FFDD9B5A452h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000ch setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(byte src, int pos)
; location: [7FFDD9B5A470h, 7FFDD9B5A481h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000bh setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(short src, int pos)
; location: [7FFDD9B5A4A0h, 7FFDD9B5A4B2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000ch setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(ushort src, int pos)
; location: [7FFDD9B5A4D0h, 7FFDD9B5A4E1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
000bh setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(int src, int pos)
; location: [7FFDD9B5A500h, 7FFDD9B5A50Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0008h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(uint src, int pos)
; location: [7FFDD9B5A520h, 7FFDD9B5A52Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bt ecx,edx                    ; BT(Bt_rm32_r32) [ECX,EDX]                            encoding(3 bytes) = 0f a3 d1
0008h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(long src, int pos)
; location: [7FFDD9B5A540h, 7FFDD9B5A54Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bt rcx,rdx                    ; BT(Bt_rm64_r64) [RCX,RDX]                            encoding(4 bytes) = 48 0f a3 d1
0009h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(ulong src, int pos)
; location: [7FFDD9B5A560h, 7FFDD9B5A56Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bt rcx,rdx                    ; BT(Bt_rm64_r64) [RCX,RDX]                            encoding(4 bytes) = 48 0f a3 d1
0009h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xA3,0xD1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(float src, int pos)
; location: [7FFDD9B5A580h, 7FFDD9B5A59Ch]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
000bh mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 04
000fh bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
0012h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[29]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFA,0x11,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bool test(double src, int pos)
; location: [7FFDD9B5A5C0h, 7FFDD9B5A5DCh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovsd qword ptr [rsp],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 04 24
000ah mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 04 24
000eh bt rax,rdx                    ; BT(Bt_rm64_r64) [RAX,RDX]                            encoding(4 bytes) = 48 0f a3 d0
0012h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0015h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0018h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> testBytes => new byte[29]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFB,0x11,0x04,0x24,0x48,0x8B,0x04,0x24,0x48,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte toggle(sbyte src, int pos)
; location: [7FFDD9B5A600h, 7FFDD9B5A622h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000fh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0011h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0014h movsx rdx,r8b                 ; MOVSX(Movsx_r64_rm8) [RDX,R8L]                       encoding(4 bytes) = 49 0f be d0
0018h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
001ah movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
001eh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x49,0x0F,0xBE,0xD0,0x33,0xC2,0x48,0x0F,0xBE,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte toggle(byte src, int pos)
; location: [7FFDD9B5A640h, 7FFDD9B5A65Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0017h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0019h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x0F,0xB6,0xD0,0x33,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short toggle(short src, int pos)
; location: [7FFDD9B5A670h, 7FFDD9B5A692h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000fh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0011h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0014h movsx rdx,r8w                 ; MOVSX(Movsx_r64_rm16) [RDX,R8W]                      encoding(4 bytes) = 49 0f bf d0
0018h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
001ah movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
001eh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x49,0x0F,0xBF,0xD0,0x33,0xC2,0x48,0x0F,0xBF,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort toggle(ushort src, int pos)
; location: [7FFDD9B5A6B0h, 7FFDD9B5A6CFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movzx edx,r8w                 ; MOVZX(Movzx_r32_rm16) [EDX,R8W]                      encoding(4 bytes) = 41 0f b7 d0
0017h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0019h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x0F,0xB7,0xD0,0x33,0xC2,0x0F,0xB7,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int toggle(int src, int pos)
; location: [7FFDD9B5A6E0h, 7FFDD9B5A6F5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000dh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000fh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0012h xor eax,r8d                   ; XOR(Xor_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 33 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint toggle(uint src, int pos)
; location: [7FFDD9B5A710h, 7FFDD9B5A725h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000dh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000fh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0012h xor eax,r8d                   ; XOR(Xor_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 33 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long toggle(long src, int pos)
; location: [7FFDD9B5A740h, 7FFDD9B5A756h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h xor rax,r8                    ; XOR(Xor_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 33 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x49,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong toggle(ulong src, int pos)
; location: [7FFDD9B5A770h, 7FFDD9B5A786h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h xor rax,r8                    ; XOR(Xor_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 33 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x49,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float toggle(float src, int pos)
; location: [7FFDD9B5A7A0h, 7FFDD9B5A7C4h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovss dword ptr [rsp+8],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 08
000bh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
0010h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
0016h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0018h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
001bh xor [rax],r8d                 ; XOR(Xor_rm32_r32) [mem(32u,RAX:br,DS:sr),R8D]        encoding(3 bytes) = 44 31 00
001eh vmovss xmm0,dword ptr [rsp+8] ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 08
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[37]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFA,0x11,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x08,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x31,0x00,0xC5,0xFA,0x10,0x44,0x24,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double toggle(double src, int pos)
; location: [7FFDD9B5A7E0h, 7FFDD9B5A804h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovsd qword ptr [rsp+8],xmm0 ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 08
000bh lea rax,[rsp+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 08
0010h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
0016h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0018h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
001bh xor [rax],r8                  ; XOR(Xor_rm64_r64) [mem(64u,RAX:br,DS:sr),R8]         encoding(3 bytes) = 4c 31 00
001eh vmovsd xmm0,qword ptr [rsp+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 08
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[37]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFB,0x11,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x08,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x4C,0x31,0x00,0xC5,0xFB,0x10,0x44,0x24,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte toggle(ref sbyte src, int pos)
; location: [7FFDD9B5A820h, 7FFDD9B5A839h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movsx rdx,r8b                 ; MOVSX(Movsx_r64_rm8) [RDX,R8L]                       encoding(4 bytes) = 49 0f be d0
0017h xor [rax],dl                  ; XOR(Xor_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 30 10
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x49,0x0F,0xBE,0xD0,0x30,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte toggle(ref byte src, int pos)
; location: [7FFDD9B5A850h, 7FFDD9B5A869h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0017h xor [rax],dl                  ; XOR(Xor_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 30 10
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x0F,0xB6,0xD0,0x30,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short toggle(ref short src, int pos)
; location: [7FFDD9B5A880h, 7FFDD9B5A89Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movsx rdx,r8w                 ; MOVSX(Movsx_r64_rm16) [RDX,R8W]                      encoding(4 bytes) = 49 0f bf d0
0017h xor [rax],dx                  ; XOR(Xor_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 31 10
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x49,0x0F,0xBF,0xD0,0x66,0x31,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort toggle(ref ushort src, int pos)
; location: [7FFDD9B5A8B0h, 7FFDD9B5A8CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h movzx edx,r8w                 ; MOVZX(Movzx_r32_rm16) [EDX,R8W]                      encoding(4 bytes) = 41 0f b7 d0
0017h xor [rax],dx                  ; XOR(Xor_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 31 10
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x41,0x0F,0xB7,0xD0,0x66,0x31,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int toggle(ref int src, int pos)
; location: [7FFDD9B5A8E0h, 7FFDD9B5A8F6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h xor [rax],r8d                 ; XOR(Xor_rm32_r32) [mem(32u,RAX:br,DS:sr),R8D]        encoding(3 bytes) = 44 31 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x31,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint toggle(ref uint src, int pos)
; location: [7FFDD9B5A910h, 7FFDD9B5A926h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h xor [rax],r8d                 ; XOR(Xor_rm32_r32) [mem(32u,RAX:br,DS:sr),R8D]        encoding(3 bytes) = 44 31 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x31,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long toggle(ref long src, int pos)
; location: [7FFDD9B5A940h, 7FFDD9B5A956h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h xor [rax],r8                  ; XOR(Xor_rm64_r64) [mem(64u,RAX:br,DS:sr),R8]         encoding(3 bytes) = 4c 31 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x4C,0x31,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong toggle(ref ulong src, int pos)
; location: [7FFDD9B5A970h, 7FFDD9B5A986h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h xor [rax],r8                  ; XOR(Xor_rm64_r64) [mem(64u,RAX:br,DS:sr),R8]         encoding(3 bytes) = 4c 31 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x4C,0x31,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float toggle(ref float src, int pos)
; location: [7FFDD9B5A9A0h, 7FFDD9B5A9B6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h xor [rax],r8d                 ; XOR(Xor_rm32_r32) [mem(32u,RAX:br,DS:sr),R8D]        encoding(3 bytes) = 44 31 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x41,0xD3,0xE0,0x44,0x31,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref double toggle(ref double src, int pos)
; location: [7FFDD9B5A9D0h, 7FFDD9B5A9E6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h xor [rax],r8                  ; XOR(Xor_rm64_r64) [mem(64u,RAX:br,DS:sr),R8]         encoding(3 bytes) = 4c 31 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> toggleBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x4C,0x31,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitSize width(in byte src)
; location: [7FFDD9B5AA00h, 7FFDD9B5AA14h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
000ch add eax,0FFFFFFE8h            ; ADD(Add_rm32_imm8) [EAX,ffffffffffffffe8h:imm32]     encoding(3 bytes) = 83 c0 e8
000fh neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0011h add eax,8                     ; ADD(Add_rm32_imm8) [EAX,8h:imm32]                    encoding(3 bytes) = 83 c0 08
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> widthBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0xF3,0x0F,0xBD,0xC0,0x83,0xC0,0xE8,0xF7,0xD8,0x83,0xC0,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitSize width(in ushort src)
; location: [7FFDD9B5AA30h, 7FFDD9B5AA44h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,DS:sr)]    encoding(3 bytes) = 0f b7 01
0008h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
000ch add eax,0FFFFFFF0h            ; ADD(Add_rm32_imm8) [EAX,fffffffffffffff0h:imm32]     encoding(3 bytes) = 83 c0 f0
000fh neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0011h add eax,10h                   ; ADD(Add_rm32_imm8) [EAX,10h:imm32]                   encoding(3 bytes) = 83 c0 10
0014h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> widthBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0xF3,0x0F,0xBD,0xC0,0x83,0xC0,0xF0,0xF7,0xD8,0x83,0xC0,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitSize width(in uint src)
; location: [7FFDD9B5AA60h, 7FFDD9B5AA70h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h lzcnt eax,[rcx]               ; LZCNT(Lzcnt_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]    encoding(4 bytes) = f3 0f bd 01
000bh neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000dh add eax,20h                   ; ADD(Add_rm32_imm8) [EAX,20h:imm32]                   encoding(3 bytes) = 83 c0 20
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> widthBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x0F,0xBD,0x01,0xF7,0xD8,0x83,0xC0,0x20,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitSize width(in ulong src)
; location: [7FFDD9B5AA90h, 7FFDD9B5AAA1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h lzcnt rax,[rcx]               ; LZCNT(Lzcnt_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]    encoding(5 bytes) = f3 48 0f bd 01
000ch neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000eh add eax,40h                   ; ADD(Add_rm32_imm8) [EAX,40h:imm32]                   encoding(3 bytes) = 83 c0 40
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> widthBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xBD,0x01,0xF7,0xD8,0x83,0xC0,0x40,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte xorsl(sbyte src, int offset)
; location: [7FFDD9B5AAC0h, 7FFDD9B5AADBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000eh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0011h movsx rdx,r8b                 ; MOVSX(Movsx_r64_rm8) [RDX,R8L]                       encoding(4 bytes) = 49 0f be d0
0015h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0017h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE0,0x49,0x0F,0xBE,0xD0,0x33,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte xorsl(byte src, int offset)
; location: [7FFDD9B5AAF0h, 7FFDD9B5AB09h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000dh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0010h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0014h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE0,0x41,0x0F,0xB6,0xD0,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short xorsl(short src, int offset)
; location: [7FFDD9B5AB20h, 7FFDD9B5AB3Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000eh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0011h movsx rdx,r8w                 ; MOVSX(Movsx_r64_rm16) [RDX,R8W]                      encoding(4 bytes) = 49 0f bf d0
0015h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0017h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE0,0x49,0x0F,0xBF,0xD0,0x33,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort xorsl(ushort src, int offset)
; location: [7FFDD9B5AB50h, 7FFDD9B5AB69h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000dh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0010h movzx edx,r8w                 ; MOVZX(Movzx_r32_rm16) [EDX,R8W]                      encoding(4 bytes) = 41 0f b7 d0
0014h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0016h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE0,0x41,0x0F,0xB7,0xD0,0x33,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int xorsl(int src, int offset)
; location: [7FFDD9B5AB80h, 7FFDD9B5AB92h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000ch shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
000fh xor eax,r8d                   ; XOR(Xor_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 33 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE0,0x41,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint xorsl(uint src, int offset)
; location: [7FFDD9B5ABB0h, 7FFDD9B5ABC2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000ch shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
000fh xor eax,r8d                   ; XOR(Xor_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 33 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE0,0x41,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long xorsl(long src, int offset)
; location: [7FFDD9B5ABE0h, 7FFDD9B5ABF3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
000dh shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0010h xor rax,r8                    ; XOR(Xor_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 33 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x4C,0x8B,0xC0,0x49,0xD3,0xE0,0x49,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong xorsl(ulong src, int offset)
; location: [7FFDD9B5AC10h, 7FFDD9B5AC23h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
000dh shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0010h xor rax,r8                    ; XOR(Xor_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 33 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x4C,0x8B,0xC0,0x49,0xD3,0xE0,0x49,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte xorsl(ref sbyte src, int offset)
; location: [7FFDD9B5AC40h, 7FFDD9B5AC5Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movsx r8,byte ptr [rax]       ; MOVSX(Movsx_r64_rm8) [R8,mem(8i,RAX:br,DS:sr)]       encoding(4 bytes) = 4c 0f be 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0011h shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
0014h movsx rdx,r9b                 ; MOVSX(Movsx_r64_rm8) [RDX,R9L]                       encoding(4 bytes) = 49 0f be d1
0018h xor edx,r8d                   ; XOR(Xor_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 33 d0
001bh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x0F,0xBE,0x00,0x8B,0xCA,0x45,0x8B,0xC8,0x41,0xD3,0xE1,0x49,0x0F,0xBE,0xD1,0x41,0x33,0xD0,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte xorsl(ref byte src, int offset)
; location: [7FFDD9B5AC70h, 7FFDD9B5AC8Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movzx r8d,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,DS:sr)]      encoding(4 bytes) = 44 0f b6 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0011h shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
0014h movzx edx,r9b                 ; MOVZX(Movzx_r32_rm8) [EDX,R9L]                       encoding(4 bytes) = 41 0f b6 d1
0018h xor edx,r8d                   ; XOR(Xor_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 33 d0
001bh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x0F,0xB6,0x00,0x8B,0xCA,0x45,0x8B,0xC8,0x41,0xD3,0xE1,0x41,0x0F,0xB6,0xD1,0x41,0x33,0xD0,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short xorsl(ref short src, int offset)
; location: [7FFDD9B5ACA0h, 7FFDD9B5ACBEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movsx r8,word ptr [rax]       ; MOVSX(Movsx_r64_rm16) [R8,mem(16i,RAX:br,DS:sr)]     encoding(4 bytes) = 4c 0f bf 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0011h shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
0014h movsx rdx,r9w                 ; MOVSX(Movsx_r64_rm16) [RDX,R9W]                      encoding(4 bytes) = 49 0f bf d1
0018h xor edx,r8d                   ; XOR(Xor_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 33 d0
001bh mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 10
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x0F,0xBF,0x00,0x8B,0xCA,0x45,0x8B,0xC8,0x41,0xD3,0xE1,0x49,0x0F,0xBF,0xD1,0x41,0x33,0xD0,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort xorsl(ref ushort src, int offset)
; location: [7FFDD9B5ACD0h, 7FFDD9B5ACEEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movzx r8d,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [R8D,mem(16u,RAX:br,DS:sr)]    encoding(4 bytes) = 44 0f b7 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0011h shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
0014h movzx edx,r9w                 ; MOVZX(Movzx_r32_rm16) [EDX,R9W]                      encoding(4 bytes) = 41 0f b7 d1
0018h xor edx,r8d                   ; XOR(Xor_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 33 d0
001bh mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 10
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x0F,0xB7,0x00,0x8B,0xCA,0x45,0x8B,0xC8,0x41,0xD3,0xE1,0x41,0x0F,0xB7,0xD1,0x41,0x33,0xD0,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int xorsl(ref int src, int offset)
; location: [7FFDD9B5AD00h, 7FFDD9B5AD19h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,[rax]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 44 8b 00
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0010h shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
0013h xor r9d,r8d                   ; XOR(Xor_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 33 c8
0016h mov [rax],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),R9D]        encoding(3 bytes) = 44 89 08
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x8B,0x00,0x8B,0xCA,0x45,0x8B,0xC8,0x41,0xD3,0xE1,0x45,0x33,0xC8,0x44,0x89,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint xorsl(ref uint src, int offset)
; location: [7FFDD9B5AD30h, 7FFDD9B5AD49h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,[rax]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 44 8b 00
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0010h shl r9d,cl                    ; SHL(Shl_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e1
0013h xor r9d,r8d                   ; XOR(Xor_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 33 c8
0016h mov [rax],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),R9D]        encoding(3 bytes) = 44 89 08
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x8B,0x00,0x8B,0xCA,0x45,0x8B,0xC8,0x41,0xD3,0xE1,0x45,0x33,0xC8,0x44,0x89,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long xorsl(ref long src, int offset)
; location: [7FFDD9B5AD60h, 7FFDD9B5AD79h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8,[rax]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RAX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 00
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh mov r9,r8                     ; MOV(Mov_r64_rm64) [R9,R8]                            encoding(3 bytes) = 4d 8b c8
0010h shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
0013h xor r9,r8                     ; XOR(Xor_r64_rm64) [R9,R8]                            encoding(3 bytes) = 4d 33 c8
0016h mov [rax],r9                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),R9]         encoding(3 bytes) = 4c 89 08
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x8B,0x00,0x8B,0xCA,0x4D,0x8B,0xC8,0x49,0xD3,0xE1,0x4D,0x33,0xC8,0x4C,0x89,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong xorsl(ref ulong src, int offset)
; location: [7FFDD9B5AD90h, 7FFDD9B5ADA9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8,[rax]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RAX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 00
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh mov r9,r8                     ; MOV(Mov_r64_rm64) [R9,R8]                            encoding(3 bytes) = 4d 8b c8
0010h shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
0013h xor r9,r8                     ; XOR(Xor_r64_rm64) [R9,R8]                            encoding(3 bytes) = 4d 33 c8
0016h mov [rax],r9                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),R9]         encoding(3 bytes) = 4c 89 08
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorslBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x8B,0x00,0x8B,0xCA,0x4D,0x8B,0xC8,0x49,0xD3,0xE1,0x4D,0x33,0xC8,0x4C,0x89,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte xorsr(sbyte src, int offset)
; location: [7FFDD9B5ADC0h, 7FFDD9B5ADDBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000eh sar r8d,cl                    ; SAR(Sar_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 f8
0011h movsx rdx,r8b                 ; MOVSX(Movsx_r64_rm8) [RDX,R8L]                       encoding(4 bytes) = 49 0f be d0
0015h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0017h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xF8,0x49,0x0F,0xBE,0xD0,0x33,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte xorsr(byte src, int offset)
; location: [7FFDD9B5ADF0h, 7FFDD9B5AE09h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000dh sar r8d,cl                    ; SAR(Sar_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 f8
0010h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0014h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0016h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xF8,0x41,0x0F,0xB6,0xD0,0x33,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short xorsr(short src, int offset)
; location: [7FFDD9B5AE20h, 7FFDD9B5AE3Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000bh mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000eh sar r8d,cl                    ; SAR(Sar_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 f8
0011h movsx rdx,r8w                 ; MOVSX(Movsx_r64_rm16) [RDX,R8W]                      encoding(4 bytes) = 49 0f bf d0
0015h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0017h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xF8,0x49,0x0F,0xBF,0xD0,0x33,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort xorsr(ushort src, int offset)
; location: [7FFDD9B5AE50h, 7FFDD9B5AE69h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000dh sar r8d,cl                    ; SAR(Sar_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 f8
0010h movzx edx,r8w                 ; MOVZX(Movzx_r32_rm16) [EDX,R8W]                      encoding(4 bytes) = 41 0f b7 d0
0014h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
0016h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xF8,0x41,0x0F,0xB7,0xD0,0x33,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int xorsr(int src, int offset)
; location: [7FFDD9B5AE80h, 7FFDD9B5AE92h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000ch sar r8d,cl                    ; SAR(Sar_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 f8
000fh xor eax,r8d                   ; XOR(Xor_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 33 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xF8,0x41,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint xorsr(uint src, int offset)
; location: [7FFDD9B5AEB0h, 7FFDD9B5AEC2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000ch shr r8d,cl                    ; SHR(Shr_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e8
000fh xor eax,r8d                   ; XOR(Xor_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 33 c0
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE8,0x41,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long xorsr(long src, int offset)
; location: [7FFDD9B5AEE0h, 7FFDD9B5AEF3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
000dh sar r8,cl                     ; SAR(Sar_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 f8
0010h xor rax,r8                    ; XOR(Xor_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 33 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x4C,0x8B,0xC0,0x49,0xD3,0xF8,0x49,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong xorsr(ulong src, int offset)
; location: [7FFDD9B5AF10h, 7FFDD9B5AF23h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8,rax                    ; MOV(Mov_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 8b c0
000dh shr r8,cl                     ; SHR(Shr_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e8
0010h xor rax,r8                    ; XOR(Xor_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 33 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x4C,0x8B,0xC0,0x49,0xD3,0xE8,0x49,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte xorsr(ref sbyte src, int offset)
; location: [7FFDD9B5AF40h, 7FFDD9B5AF5Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movsx r8,byte ptr [rax]       ; MOVSX(Movsx_r64_rm8) [R8,mem(8i,RAX:br,DS:sr)]       encoding(4 bytes) = 4c 0f be 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0011h sar r9d,cl                    ; SAR(Sar_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 f9
0014h movsx rdx,r9b                 ; MOVSX(Movsx_r64_rm8) [RDX,R9L]                       encoding(4 bytes) = 49 0f be d1
0018h xor edx,r8d                   ; XOR(Xor_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 33 d0
001bh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x0F,0xBE,0x00,0x8B,0xCA,0x45,0x8B,0xC8,0x41,0xD3,0xF9,0x49,0x0F,0xBE,0xD1,0x41,0x33,0xD0,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte xorsr(ref byte src, int offset)
; location: [7FFDD9B5AF70h, 7FFDD9B5AF8Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movzx r8d,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,DS:sr)]      encoding(4 bytes) = 44 0f b6 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0011h sar r9d,cl                    ; SAR(Sar_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 f9
0014h movzx edx,r9b                 ; MOVZX(Movzx_r32_rm8) [EDX,R9L]                       encoding(4 bytes) = 41 0f b6 d1
0018h xor edx,r8d                   ; XOR(Xor_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 33 d0
001bh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x0F,0xB6,0x00,0x8B,0xCA,0x45,0x8B,0xC8,0x41,0xD3,0xF9,0x41,0x0F,0xB6,0xD1,0x41,0x33,0xD0,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short xorsr(ref short src, int offset)
; location: [7FFDD9B5AFA0h, 7FFDD9B5AFBEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movsx r8,word ptr [rax]       ; MOVSX(Movsx_r64_rm16) [R8,mem(16i,RAX:br,DS:sr)]     encoding(4 bytes) = 4c 0f bf 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0011h sar r9d,cl                    ; SAR(Sar_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 f9
0014h movsx rdx,r9w                 ; MOVSX(Movsx_r64_rm16) [RDX,R9W]                      encoding(4 bytes) = 49 0f bf d1
0018h xor edx,r8d                   ; XOR(Xor_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 33 d0
001bh mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 10
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x0F,0xBF,0x00,0x8B,0xCA,0x45,0x8B,0xC8,0x41,0xD3,0xF9,0x49,0x0F,0xBF,0xD1,0x41,0x33,0xD0,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort xorsr(ref ushort src, int offset)
; location: [7FFDD9B5AFD0h, 7FFDD9B5AFEEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h movzx r8d,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [R8D,mem(16u,RAX:br,DS:sr)]    encoding(4 bytes) = 44 0f b7 00
000ch mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000eh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0011h sar r9d,cl                    ; SAR(Sar_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 f9
0014h movzx edx,r9w                 ; MOVZX(Movzx_r32_rm16) [EDX,R9W]                      encoding(4 bytes) = 41 0f b7 d1
0018h xor edx,r8d                   ; XOR(Xor_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 33 d0
001bh mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 10
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x0F,0xB7,0x00,0x8B,0xCA,0x45,0x8B,0xC8,0x41,0xD3,0xF9,0x41,0x0F,0xB7,0xD1,0x41,0x33,0xD0,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int xorsr(ref int src, int offset)
; location: [7FFDD9B5B000h, 7FFDD9B5B019h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,[rax]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 44 8b 00
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0010h sar r9d,cl                    ; SAR(Sar_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 f9
0013h xor r9d,r8d                   ; XOR(Xor_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 33 c8
0016h mov [rax],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),R9D]        encoding(3 bytes) = 44 89 08
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x8B,0x00,0x8B,0xCA,0x45,0x8B,0xC8,0x41,0xD3,0xF9,0x45,0x33,0xC8,0x44,0x89,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint xorsr(ref uint src, int offset)
; location: [7FFDD9B5B030h, 7FFDD9B5B049h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,[rax]                 ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 44 8b 00
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0010h shr r9d,cl                    ; SHR(Shr_rm32_CL) [R9D,CL]                            encoding(3 bytes) = 41 d3 e9
0013h xor r9d,r8d                   ; XOR(Xor_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 33 c8
0016h mov [rax],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),R9D]        encoding(3 bytes) = 44 89 08
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x44,0x8B,0x00,0x8B,0xCA,0x45,0x8B,0xC8,0x41,0xD3,0xE9,0x45,0x33,0xC8,0x44,0x89,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long xorsr(ref long src, int offset)
; location: [7FFDD9B5B060h, 7FFDD9B5B079h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8,[rax]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RAX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 00
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh mov r9,r8                     ; MOV(Mov_r64_rm64) [R9,R8]                            encoding(3 bytes) = 4d 8b c8
0010h sar r9,cl                     ; SAR(Sar_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 f9
0013h xor r9,r8                     ; XOR(Xor_r64_rm64) [R9,R8]                            encoding(3 bytes) = 4d 33 c8
0016h mov [rax],r9                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),R9]         encoding(3 bytes) = 4c 89 08
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x8B,0x00,0x8B,0xCA,0x4D,0x8B,0xC8,0x49,0xD3,0xF9,0x4D,0x33,0xC8,0x4C,0x89,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong xorsr(ref ulong src, int offset)
; location: [7FFDD9B5B090h, 7FFDD9B5B0A9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8,[rax]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RAX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 00
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh mov r9,r8                     ; MOV(Mov_r64_rm64) [R9,R8]                            encoding(3 bytes) = 4d 8b c8
0010h shr r9,cl                     ; SHR(Shr_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e9
0013h xor r9,r8                     ; XOR(Xor_r64_rm64) [R9,R8]                            encoding(3 bytes) = 4d 33 c8
0016h mov [rax],r9                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),R9]         encoding(3 bytes) = 4c 89 08
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorsrBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x8B,0x00,0x8B,0xCA,0x4D,0x8B,0xC8,0x49,0xD3,0xE9,0x4D,0x33,0xC8,0x4C,0x89,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int lo(long src)
; location: [7FFDD9B5B0C0h, 7FFDD9B5B0C7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint lo(ulong src)
; location: [7FFDD9B5B0E0h, 7FFDD9B5B0E7h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte loff(ref sbyte src)
; location: [7FFDD9B5B100h, 7FFDD9B5B117h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,byte ptr [rcx]      ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RCX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 01
0009h lea edx,[rax-1]               ; LEA(Lea_r32_m) [EDX,mem(Unknown,RAX:br,DS:sr)]       encoding(3 bytes) = 8d 50 ff
000ch movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
0010h and edx,eax                   ; AND(And_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 23 d0
0012h mov [rcx],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),DL]            encoding(2 bytes) = 88 11
0014h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loffBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0x01,0x8D,0x50,0xFF,0x48,0x0F,0xBE,0xD2,0x23,0xD0,0x88,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte loff(ref byte src)
; location: [7FFDD9B5B130h, 7FFDD9B5B145h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h lea edx,[rax-1]               ; LEA(Lea_r32_m) [EDX,mem(Unknown,RAX:br,DS:sr)]       encoding(3 bytes) = 8d 50 ff
000bh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000eh and edx,eax                   ; AND(And_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 23 d0
0010h mov [rcx],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),DL]            encoding(2 bytes) = 88 11
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loffBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0x8D,0x50,0xFF,0x0F,0xB6,0xD2,0x23,0xD0,0x88,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short loff(ref short src)
; location: [7FFDD9B5B160h, 7FFDD9B5B178h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,word ptr [rcx]      ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RCX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 01
0009h lea edx,[rax-1]               ; LEA(Lea_r32_m) [EDX,mem(Unknown,RAX:br,DS:sr)]       encoding(3 bytes) = 8d 50 ff
000ch movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
0010h and edx,eax                   ; AND(And_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 23 d0
0012h mov [rcx],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 11
0015h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loffBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0x01,0x8D,0x50,0xFF,0x48,0x0F,0xBF,0xD2,0x23,0xD0,0x66,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort loff(ref ushort src)
; location: [7FFDD9B5B190h, 7FFDD9B5B1A6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,DS:sr)]    encoding(3 bytes) = 0f b7 01
0008h lea edx,[rax-1]               ; LEA(Lea_r32_m) [EDX,mem(Unknown,RAX:br,DS:sr)]       encoding(3 bytes) = 8d 50 ff
000bh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000eh and edx,eax                   ; AND(And_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 23 d0
0010h mov [rcx],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 11
0013h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loffBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0x8D,0x50,0xFF,0x0F,0xB7,0xD2,0x23,0xD0,0x66,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int loff(ref int src)
; location: [7FFDD9B5B1C0h, 7FFDD9B5B1D1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h lea edx,[rax-1]               ; LEA(Lea_r32_m) [EDX,mem(Unknown,RAX:br,DS:sr)]       encoding(3 bytes) = 8d 50 ff
000ah and edx,eax                   ; AND(And_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 23 d0
000ch mov [rcx],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 89 11
000eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loffBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x8D,0x50,0xFF,0x23,0xD0,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint loff(ref uint src)
; location: [7FFDD9B5B1F0h, 7FFDD9B5B201h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h lea edx,[rax-1]               ; LEA(Lea_r32_m) [EDX,mem(Unknown,RAX:br,DS:sr)]       encoding(3 bytes) = 8d 50 ff
000ah and edx,eax                   ; AND(And_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 23 d0
000ch mov [rcx],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EDX]        encoding(2 bytes) = 89 11
000eh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loffBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x8D,0x50,0xFF,0x23,0xD0,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long loff(ref long src)
; location: [7FFDD9B5B220h, 7FFDD9B5B235h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h lea rdx,[rax-1]               ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 50 ff
000ch and rdx,rax                   ; AND(And_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 23 d0
000fh mov [rcx],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 11
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loffBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x8D,0x50,0xFF,0x48,0x23,0xD0,0x48,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong loff(ref ulong src)
; location: [7FFDD9B5B250h, 7FFDD9B5B265h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h lea rdx,[rax-1]               ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 50 ff
000ch and rdx,rax                   ; AND(And_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 23 d0
000fh mov [rcx],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 11
0012h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loffBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x8D,0x50,0xFF,0x48,0x23,0xD0,0x48,0x89,0x11,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint log2(byte src)
; location: [7FFDD9B5B280h, 7FFDD9B5B299h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah jne short 0010h               ; JNE(Jne_rel8_64) [10h:jmp64]                         encoding(2 bytes) = 75 04
000ch xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000eh jmp short 0019h               ; JMP(Jmp_rel8_64) [19h:jmp64]                         encoding(2 bytes) = eb 09
0010h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
0014h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0016h add eax,1Fh                   ; ADD(Add_rm32_imm8) [EAX,1fh:imm32]                   encoding(3 bytes) = 83 c0 1f
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> log2Bytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x85,0xC0,0x75,0x04,0x33,0xC0,0xEB,0x09,0xF3,0x0F,0xBD,0xC0,0xF7,0xD8,0x83,0xC0,0x1F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint log2(ushort src)
; location: [7FFDD9B5B2B0h, 7FFDD9B5B2C9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ah jne short 0010h               ; JNE(Jne_rel8_64) [10h:jmp64]                         encoding(2 bytes) = 75 04
000ch xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000eh jmp short 0019h               ; JMP(Jmp_rel8_64) [19h:jmp64]                         encoding(2 bytes) = eb 09
0010h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
0014h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0016h add eax,1Fh                   ; ADD(Add_rm32_imm8) [EAX,1fh:imm32]                   encoding(3 bytes) = 83 c0 1f
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> log2Bytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x85,0xC0,0x75,0x04,0x33,0xC0,0xEB,0x09,0xF3,0x0F,0xBD,0xC0,0xF7,0xD8,0x83,0xC0,0x1F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint log2(uint src)
; location: [7FFDD9B5B2E0h, 7FFDD9B5B2F8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test ecx,ecx                  ; TEST(Test_rm32_r32) [ECX,ECX]                        encoding(2 bytes) = 85 c9
0007h jne short 000dh               ; JNE(Jne_rel8_64) [Dh:jmp64]                          encoding(2 bytes) = 75 04
0009h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000bh jmp short 0018h               ; JMP(Jmp_rel8_64) [18h:jmp64]                         encoding(2 bytes) = eb 0b
000dh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000fh lzcnt eax,ecx                 ; LZCNT(Lzcnt_r32_rm32) [EAX,ECX]                      encoding(4 bytes) = f3 0f bd c1
0013h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0015h add eax,1Fh                   ; ADD(Add_rm32_imm8) [EAX,1fh:imm32]                   encoding(3 bytes) = 83 c0 1f
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> log2Bytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x85,0xC9,0x75,0x04,0x33,0xC0,0xEB,0x0B,0x33,0xC0,0xF3,0x0F,0xBD,0xC1,0xF7,0xD8,0x83,0xC0,0x1F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint log2(ulong src)
; location: [7FFDD9B5B310h, 7FFDD9B5B32Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h jne short 000eh               ; JNE(Jne_rel8_64) [Eh:jmp64]                          encoding(2 bytes) = 75 04
000ah xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000ch jmp short 001ah               ; JMP(Jmp_rel8_64) [1Ah:jmp64]                         encoding(2 bytes) = eb 0c
000eh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0010h lzcnt rax,rcx                 ; LZCNT(Lzcnt_r64_rm64) [RAX,RCX]                      encoding(5 bytes) = f3 48 0f bd c1
0015h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0017h add eax,3Fh                   ; ADD(Add_rm32_imm8) [EAX,3fh:imm32]                   encoding(3 bytes) = 83 c0 3f
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> log2Bytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x75,0x04,0x33,0xC0,0xEB,0x0C,0x33,0xC0,0xF3,0x48,0x0F,0xBD,0xC1,0xF7,0xD8,0x83,0xC0,0x3F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong mask(ref ulong dst, int exp0)
; location: [7FFDD9B5B340h, 7FFDD9B5B356h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0013h or [rax],r8                   ; OR(Or_rm64_r64) [mem(64u,RAX:br,DS:sr),R8]           encoding(3 bytes) = 4c 09 00
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maskBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x4C,0x09,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong mask(ref ulong dst, int exp0, int exp1)
; location: [7FFDD9B5B370h, 7FFDD9B5B397h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
0013h or r9,[rax]                   ; OR(Or_r64_rm64) [R9,mem(64u,RAX:br,DS:sr)]           encoding(3 bytes) = 4c 0b 08
0016h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
001eh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0021h or rdx,r9                     ; OR(Or_r64_rm64) [RDX,R9]                             encoding(3 bytes) = 49 0b d1
0024h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maskBytes => new byte[40]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xB9,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE1,0x4C,0x0B,0x08,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE2,0x49,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong mask(ref ulong dst, int exp0, int exp1, int exp2)
; location: [7FFDD9B5B3B0h, 7FFDD9B5B3E6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0013h or r10,[rax]                  ; OR(Or_r64_rm64) [R10,mem(64u,RAX:br,DS:sr)]          encoding(3 bytes) = 4c 0b 10
0016h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
001eh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0021h or rdx,r10                    ; OR(Or_r64_rm64) [RDX,R10]                            encoding(3 bytes) = 49 0b d2
0024h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
002ah mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
002dh shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0030h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0033h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maskBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xBA,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE2,0x4C,0x0B,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE2,0x49,0x0B,0xD2,0x41,0xB8,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x49,0xD3,0xE0,0x49,0x0B,0xD0,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong mask(ulong src, int exp0, int exp1, int exp2)
; location: [7FFDD9B5B400h, 7FFDD9B5B432h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0013h or rax,r10                    ; OR(Or_r64_rm64) [RAX,R10]                            encoding(3 bytes) = 49 0b c2
0016h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
001eh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0021h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0024h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0029h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
002ch shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
002fh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maskBytes => new byte[51]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xBA,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE2,0x49,0x0B,0xC2,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE2,0x48,0x0B,0xC2,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x48,0xD3,0xE2,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong mask(ref ulong dst, int exp0, int exp1, int exp2, int exp3)
; location: [7FFDD9B5B450h, 7FFDD9B5B496h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
000eh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0010h shl r10,cl                    ; SHL(Shl_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 e2
0013h or r10,[rax]                  ; OR(Or_r64_rm64) [R10,mem(64u,RAX:br,DS:sr)]          encoding(3 bytes) = 4c 0b 10
0016h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
001bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
001eh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0021h or rdx,r10                    ; OR(Or_r64_rm64) [RDX,R10]                            encoding(3 bytes) = 49 0b d2
0024h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
002ah mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
002dh shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0030h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0033h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
0039h mov ecx,[rsp+28h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 28
003dh shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0040h or rdx,r8                     ; OR(Or_r64_rm64) [RDX,R8]                             encoding(3 bytes) = 49 0b d0
0043h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
0046h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> maskBytes => new byte[71]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x41,0xBA,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE2,0x4C,0x0B,0x10,0xBA,0x01,0x00,0x00,0x00,0x41,0x8B,0xC8,0x48,0xD3,0xE2,0x49,0x0B,0xD2,0x41,0xB8,0x01,0x00,0x00,0x00,0x41,0x8B,0xC9,0x49,0xD3,0xE0,0x49,0x0B,0xD0,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0x4C,0x24,0x28,0x49,0xD3,0xE0,0x49,0x0B,0xD0,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint nlz(in byte src)
; location: [7FFDD9B5B4B0h, 7FFDD9B5B4BFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
000ch add eax,0FFFFFFE8h            ; ADD(Add_rm32_imm8) [EAX,ffffffffffffffe8h:imm32]     encoding(3 bytes) = 83 c0 e8
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nlzBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0xF3,0x0F,0xBD,0xC0,0x83,0xC0,0xE8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint nlz(in ushort src)
; location: [7FFDD9B5B4D0h, 7FFDD9B5B4DFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,DS:sr)]    encoding(3 bytes) = 0f b7 01
0008h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
000ch add eax,0FFFFFFF0h            ; ADD(Add_rm32_imm8) [EAX,fffffffffffffff0h:imm32]     encoding(3 bytes) = 83 c0 f0
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nlzBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0xF3,0x0F,0xBD,0xC0,0x83,0xC0,0xF0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint nlz(in uint src)
; location: [7FFDD9B5B4F0h, 7FFDD9B5B4FBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h lzcnt eax,[rcx]               ; LZCNT(Lzcnt_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]    encoding(4 bytes) = f3 0f bd 01
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nlzBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x0F,0xBD,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint nlz(in ulong src)
; location: [7FFDD9B5B510h, 7FFDD9B5B51Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h lzcnt rax,[rcx]               ; LZCNT(Lzcnt_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]    encoding(5 bytes) = f3 48 0f bd 01
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nlzBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xBD,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint ntz(sbyte src)
; location: [7FFDD9B5B530h, 7FFDD9B5B53Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h tzcnt eax,eax                 ; TZCNT(Tzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bc c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF3,0x0F,0xBC,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint ntz(byte src)
; location: [7FFDD9B5B550h, 7FFDD9B5B55Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h tzcnt eax,eax                 ; TZCNT(Tzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bc c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF3,0x0F,0xBC,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint ntz(short src)
; location: [7FFDD9B5B570h, 7FFDD9B5B57Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h tzcnt eax,eax                 ; TZCNT(Tzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bc c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF3,0x0F,0xBC,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint ntz(ushort src)
; location: [7FFDD9B5B590h, 7FFDD9B5B59Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h tzcnt eax,eax                 ; TZCNT(Tzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bc c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF3,0x0F,0xBC,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint ntz(int src)
; location: [7FFDD9B5B5B0h, 7FFDD9B5B5BBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h tzcnt eax,ecx                 ; TZCNT(Tzcnt_r32_rm32) [EAX,ECX]                      encoding(4 bytes) = f3 0f bc c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x0F,0xBC,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint ntz(uint src)
; location: [7FFDD9B5B5D0h, 7FFDD9B5B5DBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h tzcnt eax,ecx                 ; TZCNT(Tzcnt_r32_rm32) [EAX,ECX]                      encoding(4 bytes) = f3 0f bc c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x0F,0xBC,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint ntz(long src)
; location: [7FFDD9B5B5F0h, 7FFDD9B5B5FCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h tzcnt rax,rcx                 ; TZCNT(Tzcnt_r64_rm64) [RAX,RCX]                      encoding(5 bytes) = f3 48 0f bc c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xBC,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint ntz(ulong src)
; location: [7FFDD9B5B610h, 7FFDD9B5B61Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h tzcnt rax,rcx                 ; TZCNT(Tzcnt_r64_rm64) [RAX,RCX]                      encoding(5 bytes) = f3 48 0f bc c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ntzBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xBC,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort pack(byte x0, byte x1)
; location: [7FFDD9B5B630h, 7FFDD9B5B643h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000eh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pack(ushort x0, ushort x1)
; location: [7FFDD9B5B660h, 7FFDD9B5B670h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh shl edx,10h                   ; SHL(Shl_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 e2 10
000eh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC1,0xE2,0x10,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pack(in uint x0, in uint x1)
; location: [7FFDD9B5B690h, 7FFDD9B5B6A0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(2 bytes) = 8b 01
0007h mov edx,[rdx]                 ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(2 bytes) = 8b 12
0009h shl rdx,20h                   ; SHL(Shl_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 e2 20
000dh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x8B,0x12,0x48,0xC1,0xE2,0x20,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pack(byte x0, byte x1, byte x2, byte x3)
; location: [7FFDD9B5B6C0h, 7FFDD9B5B6E2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000eh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0010h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0014h shl edx,10h                   ; SHL(Shl_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 e2 10
0017h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0019h movzx edx,r9b                 ; MOVZX(Movzx_r32_rm8) [EDX,R9L]                       encoding(4 bytes) = 41 0f b6 d1
001dh shl edx,18h                   ; SHL(Shl_rm32_imm8) [EDX,18h:imm8]                    encoding(3 bytes) = c1 e2 18
0020h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x10,0x0B,0xC2,0x41,0x0F,0xB6,0xD1,0xC1,0xE2,0x18,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pack(ushort x0, ushort x1, ushort x2, ushort x3)
; location: [7FFDD9B5B700h, 7FFDD9B5B726h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
000eh shl rcx,10h                   ; SHL(Shl_rm64_imm8) [RCX,10h:imm8]                    encoding(4 bytes) = 48 c1 e1 10
0012h or rax,rcx                    ; OR(Or_r64_rm64) [RAX,RCX]                            encoding(3 bytes) = 48 0b c1
0015h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
0018h shl rcx,20h                   ; SHL(Shl_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 e1 20
001ch or rax,rcx                    ; OR(Or_r64_rm64) [RAX,RCX]                            encoding(3 bytes) = 48 0b c1
001fh shl rdx,30h                   ; SHL(Shl_rm64_imm8) [RDX,30h:imm8]                    encoding(4 bytes) = 48 c1 e2 30
0023h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[39]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x48,0x8B,0xCA,0x48,0xC1,0xE1,0x10,0x48,0x0B,0xC1,0x48,0x8B,0xCA,0x48,0xC1,0xE1,0x20,0x48,0x0B,0xC1,0x48,0xC1,0xE2,0x30,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pack(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7)
; location: [7FFDD9B5B740h, 7FFDD9B5B7A0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh shl rdx,8                     ; SHL(Shl_rm64_imm8) [RDX,8h:imm8]                     encoding(4 bytes) = 48 c1 e2 08
000fh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0012h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0016h shl rdx,10h                   ; SHL(Shl_rm64_imm8) [RDX,10h:imm8]                    encoding(4 bytes) = 48 c1 e2 10
001ah or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
001dh movzx edx,r9b                 ; MOVZX(Movzx_r32_rm8) [EDX,R9L]                       encoding(4 bytes) = 41 0f b6 d1
0021h shl rdx,18h                   ; SHL(Shl_rm64_imm8) [RDX,18h:imm8]                    encoding(4 bytes) = 48 c1 e2 18
0025h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0028h mov edx,[rsp+28h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 28
002ch movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
002fh shl rdx,20h                   ; SHL(Shl_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 e2 20
0033h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0036h mov edx,[rsp+30h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 30
003ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
003dh shl rdx,28h                   ; SHL(Shl_rm64_imm8) [RDX,28h:imm8]                    encoding(4 bytes) = 48 c1 e2 28
0041h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0044h mov edx,[rsp+38h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 38
0048h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
004bh shl rdx,30h                   ; SHL(Shl_rm64_imm8) [RDX,30h:imm8]                    encoding(4 bytes) = 48 c1 e2 30
004fh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0052h mov edx,[rsp+40h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 40
0056h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0059h shl rdx,38h                   ; SHL(Shl_rm64_imm8) [RDX,38h:imm8]                    encoding(4 bytes) = 48 c1 e2 38
005dh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0060h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[97]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x48,0xC1,0xE2,0x08,0x48,0x0B,0xC2,0x41,0x0F,0xB6,0xD0,0x48,0xC1,0xE2,0x10,0x48,0x0B,0xC2,0x41,0x0F,0xB6,0xD1,0x48,0xC1,0xE2,0x18,0x48,0x0B,0xC2,0x8B,0x54,0x24,0x28,0x0F,0xB6,0xD2,0x48,0xC1,0xE2,0x20,0x48,0x0B,0xC2,0x8B,0x54,0x24,0x30,0x0F,0xB6,0xD2,0x48,0xC1,0xE2,0x28,0x48,0x0B,0xC2,0x8B,0x54,0x24,0x38,0x0F,0xB6,0xD2,0x48,0xC1,0xE2,0x30,0x48,0x0B,0xC2,0x8B,0x54,0x24,0x40,0x0F,0xB6,0xD2,0x48,0xC1,0xE2,0x38,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte pack(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7, byte pos, ref byte dst)
; location: [7FFDD9B5B7C0h, 7FFDD9B5B845h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rsp+50h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 50
000ah movzx r10d,cl                 ; MOVZX(Movzx_r32_rm8) [R10D,CL]                       encoding(4 bytes) = 44 0f b6 d1
000eh mov ecx,[rsp+48h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 48
0012h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0015h mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
001bh shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
001eh test r10d,r11d                ; TEST(Test_rm32_r32) [R11D,R10D]                      encoding(3 bytes) = 45 85 d3
0021h je short 0026h                ; JE(Je_rel8_64) [26h:jmp64]                           encoding(2 bytes) = 74 03
0023h or byte ptr [rax],1           ; OR(Or_rm8_imm8) [mem(8u,RAX:br,DS:sr),1h:imm8]       encoding(3 bytes) = 80 08 01
0026h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0029h test edx,r11d                 ; TEST(Test_rm32_r32) [R11D,EDX]                       encoding(3 bytes) = 41 85 d3
002ch je short 0031h                ; JE(Je_rel8_64) [31h:jmp64]                           encoding(2 bytes) = 74 03
002eh or byte ptr [rax],2           ; OR(Or_rm8_imm8) [mem(8u,RAX:br,DS:sr),2h:imm8]       encoding(3 bytes) = 80 08 02
0031h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
0035h test edx,r11d                 ; TEST(Test_rm32_r32) [R11D,EDX]                       encoding(3 bytes) = 41 85 d3
0038h je short 003dh                ; JE(Je_rel8_64) [3Dh:jmp64]                           encoding(2 bytes) = 74 03
003ah or byte ptr [rax],4           ; OR(Or_rm8_imm8) [mem(8u,RAX:br,DS:sr),4h:imm8]       encoding(3 bytes) = 80 08 04
003dh movzx edx,r9b                 ; MOVZX(Movzx_r32_rm8) [EDX,R9L]                       encoding(4 bytes) = 41 0f b6 d1
0041h test edx,r11d                 ; TEST(Test_rm32_r32) [R11D,EDX]                       encoding(3 bytes) = 41 85 d3
0044h je short 0049h                ; JE(Je_rel8_64) [49h:jmp64]                           encoding(2 bytes) = 74 03
0046h or byte ptr [rax],8           ; OR(Or_rm8_imm8) [mem(8u,RAX:br,DS:sr),8h:imm8]       encoding(3 bytes) = 80 08 08
0049h mov edx,[rsp+28h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 28
004dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0050h test edx,r11d                 ; TEST(Test_rm32_r32) [R11D,EDX]                       encoding(3 bytes) = 41 85 d3
0053h je short 0058h                ; JE(Je_rel8_64) [58h:jmp64]                           encoding(2 bytes) = 74 03
0055h or byte ptr [rax],10h         ; OR(Or_rm8_imm8) [mem(8u,RAX:br,DS:sr),10h:imm8]      encoding(3 bytes) = 80 08 10
0058h mov edx,[rsp+30h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 30
005ch movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
005fh test edx,r11d                 ; TEST(Test_rm32_r32) [R11D,EDX]                       encoding(3 bytes) = 41 85 d3
0062h je short 0067h                ; JE(Je_rel8_64) [67h:jmp64]                           encoding(2 bytes) = 74 03
0064h or byte ptr [rax],20h         ; OR(Or_rm8_imm8) [mem(8u,RAX:br,DS:sr),20h:imm8]      encoding(3 bytes) = 80 08 20
0067h mov edx,[rsp+38h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 38
006bh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
006eh test edx,r11d                 ; TEST(Test_rm32_r32) [R11D,EDX]                       encoding(3 bytes) = 41 85 d3
0071h je short 0076h                ; JE(Je_rel8_64) [76h:jmp64]                           encoding(2 bytes) = 74 03
0073h or byte ptr [rax],40h         ; OR(Or_rm8_imm8) [mem(8u,RAX:br,DS:sr),40h:imm8]      encoding(3 bytes) = 80 08 40
0076h mov edx,[rsp+40h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 40
007ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
007dh test edx,r11d                 ; TEST(Test_rm32_r32) [R11D,EDX]                       encoding(3 bytes) = 41 85 d3
0080h je short 0085h                ; JE(Je_rel8_64) [85h:jmp64]                           encoding(2 bytes) = 74 03
0082h or byte ptr [rax],80h         ; OR(Or_rm8_imm8) [mem(8u,RAX:br,DS:sr),80h:imm8]      encoding(3 bytes) = 80 08 80
0085h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[134]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x44,0x24,0x50,0x44,0x0F,0xB6,0xD1,0x8B,0x4C,0x24,0x48,0x0F,0xB6,0xC9,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0xD3,0xE3,0x45,0x85,0xD3,0x74,0x03,0x80,0x08,0x01,0x0F,0xB6,0xD2,0x41,0x85,0xD3,0x74,0x03,0x80,0x08,0x02,0x41,0x0F,0xB6,0xD0,0x41,0x85,0xD3,0x74,0x03,0x80,0x08,0x04,0x41,0x0F,0xB6,0xD1,0x41,0x85,0xD3,0x74,0x03,0x80,0x08,0x08,0x8B,0x54,0x24,0x28,0x0F,0xB6,0xD2,0x41,0x85,0xD3,0x74,0x03,0x80,0x08,0x10,0x8B,0x54,0x24,0x30,0x0F,0xB6,0xD2,0x41,0x85,0xD3,0x74,0x03,0x80,0x08,0x20,0x8B,0x54,0x24,0x38,0x0F,0xB6,0xD2,0x41,0x85,0xD3,0x74,0x03,0x80,0x08,0x40,0x8B,0x54,0x24,0x40,0x0F,0xB6,0xD2,0x41,0x85,0xD3,0x74,0x03,0x80,0x08,0x80,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte pack2(bool b0, bool b1)
; location: [7FFDD9B5B860h, 7FFDD9B5B898h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0003h mov [rsp+4],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 04
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+4],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 04
000dh test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
000fh je short 001dh                ; JE(Je_rel8_64) [1Dh:jmp64]                           encoding(2 bytes) = 74 0c
0011h movzx eax,byte ptr [rsp+4]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 04
0016h or eax,1                      ; OR(Or_rm32_imm8) [EAX,1h:imm32]                      encoding(3 bytes) = 83 c8 01
0019h mov [rsp+4],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 04
001dh test dl,dl                    ; TEST(Test_rm8_r8) [DL,DL]                            encoding(2 bytes) = 84 d2
001fh je short 002dh                ; JE(Je_rel8_64) [2Dh:jmp64]                           encoding(2 bytes) = 74 0c
0021h movzx eax,byte ptr [rsp+4]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 04
0026h or eax,2                      ; OR(Or_rm32_imm8) [EAX,2h:imm32]                      encoding(3 bytes) = 83 c8 02
0029h mov [rsp+4],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 04
002dh mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 04
0031h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0034h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0038h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pack2Bytes => new byte[57]{0x50,0x33,0xC0,0x89,0x44,0x24,0x04,0x33,0xC0,0x89,0x44,0x24,0x04,0x84,0xC9,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x04,0x83,0xC8,0x01,0x88,0x44,0x24,0x04,0x84,0xD2,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x04,0x83,0xC8,0x02,0x88,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte pack3(bool b0, bool b1, bool b2)
; location: [7FFDD9B5B8B0h, 7FFDD9B5B904h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0003h mov [rsp+4],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 04
0007h mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
000ah xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000ch mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
000fh mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
0012h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0014h je short 0020h                ; JE(Je_rel8_64) [20h:jmp64]                           encoding(2 bytes) = 74 0a
0016h movzx eax,byte ptr [rsp]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(4 bytes) = 0f b6 04 24
001ah or eax,1                      ; OR(Or_rm32_imm8) [EAX,1h:imm32]                      encoding(3 bytes) = 83 c8 01
001dh mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
0020h test dl,dl                    ; TEST(Test_rm8_r8) [DL,DL]                            encoding(2 bytes) = 84 d2
0022h je short 002eh                ; JE(Je_rel8_64) [2Eh:jmp64]                           encoding(2 bytes) = 74 0a
0024h movzx eax,byte ptr [rsp]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(4 bytes) = 0f b6 04 24
0028h or eax,2                      ; OR(Or_rm32_imm8) [EAX,2h:imm32]                      encoding(3 bytes) = 83 c8 02
002bh mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
002eh mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0031h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0034h mov [rsp+4],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 04
0038h test r8b,r8b                  ; TEST(Test_rm8_r8) [R8L,R8L]                          encoding(3 bytes) = 45 84 c0
003bh je short 0049h                ; JE(Je_rel8_64) [49h:jmp64]                           encoding(2 bytes) = 74 0c
003dh movzx eax,byte ptr [rsp+4]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 04
0042h or eax,4                      ; OR(Or_rm32_imm8) [EAX,4h:imm32]                      encoding(3 bytes) = 83 c8 04
0045h mov [rsp+4],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 04
0049h mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 04
004dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0050h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0054h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pack3Bytes => new byte[85]{0x50,0x33,0xC0,0x89,0x44,0x24,0x04,0x89,0x04,0x24,0x33,0xC0,0x89,0x04,0x24,0x89,0x04,0x24,0x84,0xC9,0x74,0x0A,0x0F,0xB6,0x04,0x24,0x83,0xC8,0x01,0x88,0x04,0x24,0x84,0xD2,0x74,0x0A,0x0F,0xB6,0x04,0x24,0x83,0xC8,0x02,0x88,0x04,0x24,0x8B,0x04,0x24,0x0F,0xB6,0xC0,0x89,0x44,0x24,0x04,0x45,0x84,0xC0,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x04,0x83,0xC8,0x04,0x88,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte pack4(bool b0, bool b1, bool b2, bool b3)
; location: [7FFDD9B5B920h, 7FFDD9B5B9A3h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+14h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 14
000ah mov [rsp+10h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 10
000eh mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
0012h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0014h mov [rsp+10h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 10
0018h mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
001ch mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
0020h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0022h je short 0030h                ; JE(Je_rel8_64) [30h:jmp64]                           encoding(2 bytes) = 74 0c
0024h movzx eax,byte ptr [rsp+0Ch]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 0c
0029h or eax,1                      ; OR(Or_rm32_imm8) [EAX,1h:imm32]                      encoding(3 bytes) = 83 c8 01
002ch mov [rsp+0Ch],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 0c
0030h test dl,dl                    ; TEST(Test_rm8_r8) [DL,DL]                            encoding(2 bytes) = 84 d2
0032h je short 0040h                ; JE(Je_rel8_64) [40h:jmp64]                           encoding(2 bytes) = 74 0c
0034h movzx eax,byte ptr [rsp+0Ch]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 0c
0039h or eax,2                      ; OR(Or_rm32_imm8) [EAX,2h:imm32]                      encoding(3 bytes) = 83 c8 02
003ch mov [rsp+0Ch],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 0c
0040h mov eax,[rsp+0Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 0c
0044h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0047h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
004bh test r8b,r8b                  ; TEST(Test_rm8_r8) [R8L,R8L]                          encoding(3 bytes) = 45 84 c0
004eh je short 005ch                ; JE(Je_rel8_64) [5Ch:jmp64]                           encoding(2 bytes) = 74 0c
0050h movzx eax,byte ptr [rsp+10h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 10
0055h or eax,4                      ; OR(Or_rm32_imm8) [EAX,4h:imm32]                      encoding(3 bytes) = 83 c8 04
0058h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
005ch mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 10
0060h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0063h mov [rsp+14h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 14
0067h test r9b,r9b                  ; TEST(Test_rm8_r8) [R9L,R9L]                          encoding(3 bytes) = 45 84 c9
006ah je short 0078h                ; JE(Je_rel8_64) [78h:jmp64]                           encoding(2 bytes) = 74 0c
006ch movzx eax,byte ptr [rsp+14h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 14
0071h or eax,8                      ; OR(Or_rm32_imm8) [EAX,8h:imm32]                      encoding(3 bytes) = 83 c8 08
0074h mov [rsp+14h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 14
0078h mov eax,[rsp+14h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 14
007ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
007fh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0083h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pack4Bytes => new byte[132]{0x48,0x83,0xEC,0x18,0x33,0xC0,0x89,0x44,0x24,0x14,0x89,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0x33,0xC0,0x89,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0x89,0x44,0x24,0x0C,0x84,0xC9,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x0C,0x83,0xC8,0x01,0x88,0x44,0x24,0x0C,0x84,0xD2,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x0C,0x83,0xC8,0x02,0x88,0x44,0x24,0x0C,0x8B,0x44,0x24,0x0C,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x45,0x84,0xC0,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x10,0x83,0xC8,0x04,0x88,0x44,0x24,0x10,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0x89,0x44,0x24,0x14,0x45,0x84,0xC9,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x14,0x83,0xC8,0x08,0x88,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte pack5(bool b0, bool b1, bool b2, bool b3, bool b4)
; location: [7FFDD9B5B9C0h, 7FFDD9B5BA69h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0006h mov [rsp+14h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 14
000ah mov [rsp+10h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 10
000eh mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
0012h mov [rsp+8],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 08
0016h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0018h mov [rsp+10h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 10
001ch mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
0020h mov [rsp+8],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 08
0024h mov [rsp+8],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 08
0028h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
002ah je short 0038h                ; JE(Je_rel8_64) [38h:jmp64]                           encoding(2 bytes) = 74 0c
002ch movzx eax,byte ptr [rsp+8]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 08
0031h or eax,1                      ; OR(Or_rm32_imm8) [EAX,1h:imm32]                      encoding(3 bytes) = 83 c8 01
0034h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
0038h test dl,dl                    ; TEST(Test_rm8_r8) [DL,DL]                            encoding(2 bytes) = 84 d2
003ah je short 0048h                ; JE(Je_rel8_64) [48h:jmp64]                           encoding(2 bytes) = 74 0c
003ch movzx eax,byte ptr [rsp+8]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 08
0041h or eax,2                      ; OR(Or_rm32_imm8) [EAX,2h:imm32]                      encoding(3 bytes) = 83 c8 02
0044h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
0048h mov eax,[rsp+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 08
004ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
004fh mov [rsp+0Ch],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 0c
0053h test r8b,r8b                  ; TEST(Test_rm8_r8) [R8L,R8L]                          encoding(3 bytes) = 45 84 c0
0056h je short 0064h                ; JE(Je_rel8_64) [64h:jmp64]                           encoding(2 bytes) = 74 0c
0058h movzx eax,byte ptr [rsp+0Ch]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 0c
005dh or eax,4                      ; OR(Or_rm32_imm8) [EAX,4h:imm32]                      encoding(3 bytes) = 83 c8 04
0060h mov [rsp+0Ch],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 0c
0064h mov eax,[rsp+0Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 0c
0068h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
006bh mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
006fh test r9b,r9b                  ; TEST(Test_rm8_r8) [R9L,R9L]                          encoding(3 bytes) = 45 84 c9
0072h je short 0080h                ; JE(Je_rel8_64) [80h:jmp64]                           encoding(2 bytes) = 74 0c
0074h movzx eax,byte ptr [rsp+10h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 10
0079h or eax,8                      ; OR(Or_rm32_imm8) [EAX,8h:imm32]                      encoding(3 bytes) = 83 c8 08
007ch mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
0080h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 10
0084h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0087h mov [rsp+14h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 14
008bh cmp byte ptr [rsp+40h],0      ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 40 00
0090h je short 009eh                ; JE(Je_rel8_64) [9Eh:jmp64]                           encoding(2 bytes) = 74 0c
0092h movzx eax,byte ptr [rsp+14h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 14
0097h or eax,10h                    ; OR(Or_rm32_imm8) [EAX,10h:imm32]                     encoding(3 bytes) = 83 c8 10
009ah mov [rsp+14h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 14
009eh mov eax,[rsp+14h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 14
00a2h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00a5h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
00a9h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pack5Bytes => new byte[170]{0x48,0x83,0xEC,0x18,0x33,0xC0,0x89,0x44,0x24,0x14,0x89,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0x89,0x44,0x24,0x08,0x33,0xC0,0x89,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0x89,0x44,0x24,0x08,0x89,0x44,0x24,0x08,0x84,0xC9,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x08,0x83,0xC8,0x01,0x88,0x44,0x24,0x08,0x84,0xD2,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x08,0x83,0xC8,0x02,0x88,0x44,0x24,0x08,0x8B,0x44,0x24,0x08,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x0C,0x45,0x84,0xC0,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x0C,0x83,0xC8,0x04,0x88,0x44,0x24,0x0C,0x8B,0x44,0x24,0x0C,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x45,0x84,0xC9,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x10,0x83,0xC8,0x08,0x88,0x44,0x24,0x10,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0x89,0x44,0x24,0x14,0x80,0x7C,0x24,0x40,0x00,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x14,0x83,0xC8,0x10,0x88,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte pack6(bool b0, bool b1, bool b2, bool b3, bool b4, bool b5)
; location: [7FFDD9B5BA80h, 7FFDD9B5BB51h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0006h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0009h lea rdi,[rsp+4]               ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 7c 24 04
000eh mov ecx,5                     ; MOV(Mov_r32_imm32) [ECX,5h:imm32]                    encoding(5 bytes) = b9 05 00 00 00
0013h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0015h rep stosd                     ; STOSD(Stosd_m32_EAX) [mem(32u),EAX]                  encoding(2 bytes) = f3 ab
0017h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
001ah xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
001ch mov [rsp+10h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 10
0020h mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
0024h mov [rsp+8],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 08
0028h mov [rsp+4],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 04
002ch mov [rsp+4],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 04
0030h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0032h je short 0040h                ; JE(Je_rel8_64) [40h:jmp64]                           encoding(2 bytes) = 74 0c
0034h movzx eax,byte ptr [rsp+4]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 04
0039h or eax,1                      ; OR(Or_rm32_imm8) [EAX,1h:imm32]                      encoding(3 bytes) = 83 c8 01
003ch mov [rsp+4],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 04
0040h test dl,dl                    ; TEST(Test_rm8_r8) [DL,DL]                            encoding(2 bytes) = 84 d2
0042h je short 0050h                ; JE(Je_rel8_64) [50h:jmp64]                           encoding(2 bytes) = 74 0c
0044h movzx eax,byte ptr [rsp+4]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 04
0049h or eax,2                      ; OR(Or_rm32_imm8) [EAX,2h:imm32]                      encoding(3 bytes) = 83 c8 02
004ch mov [rsp+4],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 04
0050h mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 04
0054h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0057h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
005bh test r8b,r8b                  ; TEST(Test_rm8_r8) [R8L,R8L]                          encoding(3 bytes) = 45 84 c0
005eh je short 006ch                ; JE(Je_rel8_64) [6Ch:jmp64]                           encoding(2 bytes) = 74 0c
0060h movzx eax,byte ptr [rsp+8]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 08
0065h or eax,4                      ; OR(Or_rm32_imm8) [EAX,4h:imm32]                      encoding(3 bytes) = 83 c8 04
0068h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
006ch mov eax,[rsp+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 08
0070h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0073h mov [rsp+0Ch],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 0c
0077h test r9b,r9b                  ; TEST(Test_rm8_r8) [R9L,R9L]                          encoding(3 bytes) = 45 84 c9
007ah je short 0088h                ; JE(Je_rel8_64) [88h:jmp64]                           encoding(2 bytes) = 74 0c
007ch movzx eax,byte ptr [rsp+0Ch]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 0c
0081h or eax,8                      ; OR(Or_rm32_imm8) [EAX,8h:imm32]                      encoding(3 bytes) = 83 c8 08
0084h mov [rsp+0Ch],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 0c
0088h mov eax,[rsp+0Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 0c
008ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
008fh mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
0093h cmp byte ptr [rsp+50h],0      ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 50 00
0098h je short 00a6h                ; JE(Je_rel8_64) [A6h:jmp64]                           encoding(2 bytes) = 74 0c
009ah movzx eax,byte ptr [rsp+10h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 10
009fh or eax,10h                    ; OR(Or_rm32_imm8) [EAX,10h:imm32]                     encoding(3 bytes) = 83 c8 10
00a2h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
00a6h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 10
00aah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00adh mov [rsp+14h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 14
00b1h cmp byte ptr [rsp+58h],0      ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 58 00
00b6h je short 00c4h                ; JE(Je_rel8_64) [C4h:jmp64]                           encoding(2 bytes) = 74 0c
00b8h movzx eax,byte ptr [rsp+14h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 14
00bdh or eax,20h                    ; OR(Or_rm32_imm8) [EAX,20h:imm32]                     encoding(3 bytes) = 83 c8 20
00c0h mov [rsp+14h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 14
00c4h mov eax,[rsp+14h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 14
00c8h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00cbh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
00cfh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00d0h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00d1h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pack6Bytes => new byte[210]{0x57,0x56,0x48,0x83,0xEC,0x18,0x48,0x8B,0xF1,0x48,0x8D,0x7C,0x24,0x04,0xB9,0x05,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0x33,0xC0,0x89,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0x89,0x44,0x24,0x08,0x89,0x44,0x24,0x04,0x89,0x44,0x24,0x04,0x84,0xC9,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x04,0x83,0xC8,0x01,0x88,0x44,0x24,0x04,0x84,0xD2,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x04,0x83,0xC8,0x02,0x88,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x45,0x84,0xC0,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x08,0x83,0xC8,0x04,0x88,0x44,0x24,0x08,0x8B,0x44,0x24,0x08,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x0C,0x45,0x84,0xC9,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x0C,0x83,0xC8,0x08,0x88,0x44,0x24,0x0C,0x8B,0x44,0x24,0x0C,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x80,0x7C,0x24,0x50,0x00,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x10,0x83,0xC8,0x10,0x88,0x44,0x24,0x10,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0x89,0x44,0x24,0x14,0x80,0x7C,0x24,0x58,0x00,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x14,0x83,0xC8,0x20,0x88,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte pack7(bool b0, bool b1, bool b2, bool b3, bool b4, bool b5, bool b6)
; location: [7FFDD9B5BB70h, 7FFDD9B5BC5Bh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0006h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0009h lea rdi,[rsp]                 ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,SS:sr)]       encoding(4 bytes) = 48 8d 3c 24
000dh mov ecx,6                     ; MOV(Mov_r32_imm32) [ECX,6h:imm32]                    encoding(5 bytes) = b9 06 00 00 00
0012h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0014h rep stosd                     ; STOSD(Stosd_m32_EAX) [mem(32u),EAX]                  encoding(2 bytes) = f3 ab
0016h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0019h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
001bh mov [rsp+10h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 10
001fh mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
0023h mov [rsp+8],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 08
0027h mov [rsp+4],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 04
002bh mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
002eh mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
0031h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0033h je short 003fh                ; JE(Je_rel8_64) [3Fh:jmp64]                           encoding(2 bytes) = 74 0a
0035h movzx eax,byte ptr [rsp]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(4 bytes) = 0f b6 04 24
0039h or eax,1                      ; OR(Or_rm32_imm8) [EAX,1h:imm32]                      encoding(3 bytes) = 83 c8 01
003ch mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
003fh test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0041h je short 004dh                ; JE(Je_rel8_64) [4Dh:jmp64]                           encoding(2 bytes) = 74 0a
0043h movzx eax,byte ptr [rsp]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(4 bytes) = 0f b6 04 24
0047h or eax,2                      ; OR(Or_rm32_imm8) [EAX,2h:imm32]                      encoding(3 bytes) = 83 c8 02
004ah mov [rsp],al                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(3 bytes) = 88 04 24
004dh mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0050h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0053h mov [rsp+4],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 04
0057h test r8b,r8b                  ; TEST(Test_rm8_r8) [R8L,R8L]                          encoding(3 bytes) = 45 84 c0
005ah je short 0068h                ; JE(Je_rel8_64) [68h:jmp64]                           encoding(2 bytes) = 74 0c
005ch movzx eax,byte ptr [rsp+4]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 04
0061h or eax,4                      ; OR(Or_rm32_imm8) [EAX,4h:imm32]                      encoding(3 bytes) = 83 c8 04
0064h mov [rsp+4],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 04
0068h mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 04
006ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
006fh mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
0073h test r9b,r9b                  ; TEST(Test_rm8_r8) [R9L,R9L]                          encoding(3 bytes) = 45 84 c9
0076h je short 0084h                ; JE(Je_rel8_64) [84h:jmp64]                           encoding(2 bytes) = 74 0c
0078h movzx eax,byte ptr [rsp+8]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 08
007dh or eax,8                      ; OR(Or_rm32_imm8) [EAX,8h:imm32]                      encoding(3 bytes) = 83 c8 08
0080h mov [rsp+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 08
0084h mov eax,[rsp+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 08
0088h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
008bh mov [rsp+0Ch],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 0c
008fh cmp byte ptr [rsp+50h],0      ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 50 00
0094h je short 00a2h                ; JE(Je_rel8_64) [A2h:jmp64]                           encoding(2 bytes) = 74 0c
0096h movzx eax,byte ptr [rsp+0Ch]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 0c
009bh or eax,10h                    ; OR(Or_rm32_imm8) [EAX,10h:imm32]                     encoding(3 bytes) = 83 c8 10
009eh mov [rsp+0Ch],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 0c
00a2h mov eax,[rsp+0Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 0c
00a6h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00a9h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
00adh cmp byte ptr [rsp+58h],0      ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 58 00
00b2h je short 00c0h                ; JE(Je_rel8_64) [C0h:jmp64]                           encoding(2 bytes) = 74 0c
00b4h movzx eax,byte ptr [rsp+10h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 10
00b9h or eax,20h                    ; OR(Or_rm32_imm8) [EAX,20h:imm32]                     encoding(3 bytes) = 83 c8 20
00bch mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
00c0h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 10
00c4h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00c7h mov [rsp+14h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 14
00cbh cmp byte ptr [rsp+60h],0      ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 60 00
00d0h je short 00deh                ; JE(Je_rel8_64) [DEh:jmp64]                           encoding(2 bytes) = 74 0c
00d2h movzx eax,byte ptr [rsp+14h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 14
00d7h or eax,40h                    ; OR(Or_rm32_imm8) [EAX,40h:imm32]                     encoding(3 bytes) = 83 c8 40
00dah mov [rsp+14h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 14
00deh mov eax,[rsp+14h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 14
00e2h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00e5h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
00e9h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00eah pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00ebh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pack7Bytes => new byte[236]{0x57,0x56,0x48,0x83,0xEC,0x18,0x48,0x8B,0xF1,0x48,0x8D,0x3C,0x24,0xB9,0x06,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0x33,0xC0,0x89,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0x89,0x44,0x24,0x08,0x89,0x44,0x24,0x04,0x89,0x04,0x24,0x89,0x04,0x24,0x84,0xC9,0x74,0x0A,0x0F,0xB6,0x04,0x24,0x83,0xC8,0x01,0x88,0x04,0x24,0x84,0xC9,0x74,0x0A,0x0F,0xB6,0x04,0x24,0x83,0xC8,0x02,0x88,0x04,0x24,0x8B,0x04,0x24,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x04,0x45,0x84,0xC0,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x04,0x83,0xC8,0x04,0x88,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x08,0x45,0x84,0xC9,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x08,0x83,0xC8,0x08,0x88,0x44,0x24,0x08,0x8B,0x44,0x24,0x08,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x0C,0x80,0x7C,0x24,0x50,0x00,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x0C,0x83,0xC8,0x10,0x88,0x44,0x24,0x0C,0x8B,0x44,0x24,0x0C,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x80,0x7C,0x24,0x58,0x00,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x10,0x83,0xC8,0x20,0x88,0x44,0x24,0x10,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0x89,0x44,0x24,0x14,0x80,0x7C,0x24,0x60,0x00,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x14,0x83,0xC8,0x40,0x88,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x18,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte pack8(bool b0, bool b1, bool b2, bool b3, bool b4, bool b5, bool b6, bool b7)
; location: [7FFDD9B5BC80h, 7FFDD9B5BD97h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0009h lea rdi,[rsp+0Ch]             ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 7c 24 0c
000eh mov ecx,7                     ; MOV(Mov_r32_imm32) [ECX,7h:imm32]                    encoding(5 bytes) = b9 07 00 00 00
0013h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0015h rep stosd                     ; STOSD(Stosd_m32_EAX) [mem(32u),EAX]                  encoding(2 bytes) = f3 ab
0017h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
001ah xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
001ch mov [rsp+20h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 20
0020h mov [rsp+1Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 1c
0024h mov [rsp+18h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 18
0028h mov [rsp+14h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 14
002ch mov [rsp+10h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 10
0030h mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
0034h mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 0c
0038h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
003ah je short 0048h                ; JE(Je_rel8_64) [48h:jmp64]                           encoding(2 bytes) = 74 0c
003ch movzx eax,byte ptr [rsp+0Ch]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 0c
0041h or eax,1                      ; OR(Or_rm32_imm8) [EAX,1h:imm32]                      encoding(3 bytes) = 83 c8 01
0044h mov [rsp+0Ch],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 0c
0048h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
004ah je short 0058h                ; JE(Je_rel8_64) [58h:jmp64]                           encoding(2 bytes) = 74 0c
004ch movzx eax,byte ptr [rsp+0Ch]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 0c
0051h or eax,2                      ; OR(Or_rm32_imm8) [EAX,2h:imm32]                      encoding(3 bytes) = 83 c8 02
0054h mov [rsp+0Ch],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 0c
0058h mov eax,[rsp+0Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 0c
005ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
005fh mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
0063h test r8b,r8b                  ; TEST(Test_rm8_r8) [R8L,R8L]                          encoding(3 bytes) = 45 84 c0
0066h je short 0074h                ; JE(Je_rel8_64) [74h:jmp64]                           encoding(2 bytes) = 74 0c
0068h movzx eax,byte ptr [rsp+10h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 10
006dh or eax,4                      ; OR(Or_rm32_imm8) [EAX,4h:imm32]                      encoding(3 bytes) = 83 c8 04
0070h mov [rsp+10h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 10
0074h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 10
0078h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
007bh mov [rsp+14h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 14
007fh test r9b,r9b                  ; TEST(Test_rm8_r8) [R9L,R9L]                          encoding(3 bytes) = 45 84 c9
0082h je short 0090h                ; JE(Je_rel8_64) [90h:jmp64]                           encoding(2 bytes) = 74 0c
0084h movzx eax,byte ptr [rsp+14h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 14
0089h or eax,8                      ; OR(Or_rm32_imm8) [EAX,8h:imm32]                      encoding(3 bytes) = 83 c8 08
008ch mov [rsp+14h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 14
0090h mov eax,[rsp+14h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 14
0094h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0097h mov [rsp+18h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 18
009bh cmp byte ptr [rsp+60h],0      ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 60 00
00a0h je short 00aeh                ; JE(Je_rel8_64) [AEh:jmp64]                           encoding(2 bytes) = 74 0c
00a2h movzx eax,byte ptr [rsp+18h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 18
00a7h or eax,10h                    ; OR(Or_rm32_imm8) [EAX,10h:imm32]                     encoding(3 bytes) = 83 c8 10
00aah mov [rsp+18h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 18
00aeh mov eax,[rsp+18h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 18
00b2h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00b5h mov [rsp+1Ch],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 1c
00b9h cmp byte ptr [rsp+68h],0      ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 68 00
00beh je short 00cch                ; JE(Je_rel8_64) [CCh:jmp64]                           encoding(2 bytes) = 74 0c
00c0h movzx eax,byte ptr [rsp+1Ch]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 1c
00c5h or eax,20h                    ; OR(Or_rm32_imm8) [EAX,20h:imm32]                     encoding(3 bytes) = 83 c8 20
00c8h mov [rsp+1Ch],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 1c
00cch mov eax,[rsp+1Ch]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 1c
00d0h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00d3h mov [rsp+20h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 20
00d7h cmp byte ptr [rsp+70h],0      ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 70 00
00dch je short 00eah                ; JE(Je_rel8_64) [EAh:jmp64]                           encoding(2 bytes) = 74 0c
00deh movzx eax,byte ptr [rsp+20h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 20
00e3h or eax,40h                    ; OR(Or_rm32_imm8) [EAX,40h:imm32]                     encoding(3 bytes) = 83 c8 40
00e6h mov [rsp+20h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 20
00eah mov eax,[rsp+20h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 20
00eeh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00f1h mov [rsp+24h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 24
00f5h cmp byte ptr [rsp+78h],0      ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 78 00
00fah je short 010ah                ; JE(Je_rel8_64) [10Ah:jmp64]                          encoding(2 bytes) = 74 0e
00fch movzx eax,byte ptr [rsp+24h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 24
0101h or eax,80h                    ; OR(Or_EAX_imm32) [EAX,80h:imm32]                     encoding(5 bytes) = 0d 80 00 00 00
0106h mov [rsp+24h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 24
010ah mov eax,[rsp+24h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 24
010eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0111h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0115h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0116h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0117h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pack8Bytes => new byte[280]{0x57,0x56,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF1,0x48,0x8D,0x7C,0x24,0x0C,0xB9,0x07,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0x33,0xC0,0x89,0x44,0x24,0x20,0x89,0x44,0x24,0x1C,0x89,0x44,0x24,0x18,0x89,0x44,0x24,0x14,0x89,0x44,0x24,0x10,0x89,0x44,0x24,0x0C,0x89,0x44,0x24,0x0C,0x84,0xC9,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x0C,0x83,0xC8,0x01,0x88,0x44,0x24,0x0C,0x84,0xC9,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x0C,0x83,0xC8,0x02,0x88,0x44,0x24,0x0C,0x8B,0x44,0x24,0x0C,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x10,0x45,0x84,0xC0,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x10,0x83,0xC8,0x04,0x88,0x44,0x24,0x10,0x8B,0x44,0x24,0x10,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x14,0x45,0x84,0xC9,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x14,0x83,0xC8,0x08,0x88,0x44,0x24,0x14,0x8B,0x44,0x24,0x14,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x18,0x80,0x7C,0x24,0x60,0x00,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x18,0x83,0xC8,0x10,0x88,0x44,0x24,0x18,0x8B,0x44,0x24,0x18,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x1C,0x80,0x7C,0x24,0x68,0x00,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x1C,0x83,0xC8,0x20,0x88,0x44,0x24,0x1C,0x8B,0x44,0x24,0x1C,0x0F,0xB6,0xC0,0x88,0x44,0x24,0x20,0x80,0x7C,0x24,0x70,0x00,0x74,0x0C,0x0F,0xB6,0x44,0x24,0x20,0x83,0xC8,0x40,0x88,0x44,0x24,0x20,0x8B,0x44,0x24,0x20,0x0F,0xB6,0xC0,0x89,0x44,0x24,0x24,0x80,0x7C,0x24,0x78,0x00,0x74,0x0E,0x0F,0xB6,0x44,0x24,0x24,0x0D,0x80,0x00,0x00,0x00,0x88,0x44,0x24,0x24,0x8B,0x44,0x24,0x24,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> pack(ReadOnlySpan<Bit> src)
; location: [7FFDD9B5BDB0h, 7FFDD9B5BE32h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 30
000eh mov [rsp+38h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 38
0013h mov [rsp+20h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 20
0018h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
001dh mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0020h mov edi,[rdx+8]               ; MOV(Mov_r32_rm32) [EDI,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 7a 08
0023h mov ecx,edi                   ; MOV(Mov_r32_rm32) [ECX,EDI]                          encoding(2 bytes) = 8b cf
0025h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0027h sar eax,3                     ; SAR(Sar_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 f8 03
002ah test cl,7                     ; TEST(Test_rm8_imm8) [CL,7h:imm8]                     encoding(3 bytes) = f6 c1 07
002dh je short 0031h                ; JE(Je_rel8_64) [31h:jmp64]                           encoding(2 bytes) = 74 02
002fh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0031h mov rbx,[rdx]                 ; MOV(Mov_r64_rm64) [RBX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 1a
0034h movsxd rdx,eax                ; MOVSXD(Movsxd_r64_rm32) [RDX,EAX]                    encoding(3 bytes) = 48 63 d0
0037h mov rcx,7FFDD946EA10h         ; MOV(Mov_r64_imm64) [RCX,7ffdd946ea10h:imm64]         encoding(10 bytes) = 48 b9 10 ea 46 d9 fd 7f 00 00
0041h call 7FFE38FC45E0h            ; CALL(Call_rel32_64) [5F468830h:jmp64]                encoding(5 bytes) = e8 ea 87 46 5f
0046h lea rcx,[rax+10h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 48 10
004ah mov edx,[rax+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RAX:br,DS:sr)]        encoding(3 bytes) = 8b 50 08
004dh mov r8,rsi                    ; MOV(Mov_r64_rm64) [R8,RSI]                           encoding(3 bytes) = 4c 8b c6
0050h lea rax,[rsp+30h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 30
0055h mov [rax],rbx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RBX]        encoding(3 bytes) = 48 89 18
0058h mov [rax+8],edi               ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDI]        encoding(3 bytes) = 89 78 08
005bh lea rax,[rsp+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 44 24 20
0060h mov [rax],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RCX]        encoding(3 bytes) = 48 89 08
0063h mov [rax+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(3 bytes) = 89 50 08
0066h mov rcx,r8                    ; MOV(Mov_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 8b c8
0069h lea rdx,[rsp+30h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 30
006eh lea r8,[rsp+20h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(5 bytes) = 4c 8d 44 24 20
0073h call 7FFDD94A9220h            ; CALL(Call_rel32_64) [FFFFFFFFFF94D470h:jmp64]        encoding(5 bytes) = e8 f8 d3 94 ff
0078h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
007bh add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
007fh pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0080h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0081h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0082h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> packBytes => new byte[131]{0x57,0x56,0x53,0x48,0x83,0xEC,0x40,0x33,0xC0,0x48,0x89,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x38,0x48,0x89,0x44,0x24,0x20,0x48,0x89,0x44,0x24,0x28,0x48,0x8B,0xF1,0x8B,0x7A,0x08,0x8B,0xCF,0x8B,0xC1,0xC1,0xF8,0x03,0xF6,0xC1,0x07,0x74,0x02,0xFF,0xC0,0x48,0x8B,0x1A,0x48,0x63,0xD0,0x48,0xB9,0x10,0xEA,0x46,0xD9,0xFD,0x7F,0x00,0x00,0xE8,0xEA,0x87,0x46,0x5F,0x48,0x8D,0x48,0x10,0x8B,0x50,0x08,0x4C,0x8B,0xC6,0x48,0x8D,0x44,0x24,0x30,0x48,0x89,0x18,0x89,0x78,0x08,0x48,0x8D,0x44,0x24,0x20,0x48,0x89,0x08,0x89,0x50,0x08,0x49,0x8B,0xC8,0x48,0x8D,0x54,0x24,0x30,0x4C,0x8D,0x44,0x24,0x20,0xE8,0xF8,0xD3,0x94,0xFF,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x40,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> pack(ReadOnlySpan<Bit> src, Span<byte> dst)
; location: [7FFDD9B5BE50h, 7FFDD9B5BEB8h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0009h mov r9,[r8]                   ; MOV(Mov_r64_rm64) [R9,mem(64u,R8:br,DS:sr)]          encoding(3 bytes) = 4d 8b 08
000ch mov r8d,[r8+8]                ; MOV(Mov_r32_rm32) [R8D,mem(32u,R8:br,DS:sr)]         encoding(4 bytes) = 45 8b 40 08
0010h mov r10,[rdx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 4c 8b 12
0013h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
0016h xor r11d,r11d                 ; XOR(Xor_r32_rm32) [R11D,R11D]                        encoding(3 bytes) = 45 33 db
0019h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
001bh jle short 0055h               ; JLE(Jle_rel8_64) [55h:jmp64]                         encoding(2 bytes) = 7e 38
001dh movsxd rcx,r11d               ; MOVSXD(Movsxd_r64_rm32) [RCX,R11D]                   encoding(3 bytes) = 49 63 cb
0020h movzx ecx,byte ptr [r10+rcx]  ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,R10:br,DS:sr)]      encoding(5 bytes) = 41 0f b6 0c 0a
0025h test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0027h je short 004dh                ; JE(Je_rel8_64) [4Dh:jmp64]                           encoding(2 bytes) = 74 24
0029h mov ecx,r11d                  ; MOV(Mov_r32_rm32) [ECX,R11D]                         encoding(3 bytes) = 41 8b cb
002ch sar ecx,3                     ; SAR(Sar_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 f9 03
002fh cmp ecx,r8d                   ; CMP(Cmp_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 3b c8
0032h jae short 0063h               ; JAE(Jae_rel8_64) [63h:jmp64]                         encoding(2 bytes) = 73 2f
0034h movsxd rsi,ecx                ; MOVSXD(Movsxd_r64_rm32) [RSI,ECX]                    encoding(3 bytes) = 48 63 f1
0037h add rsi,r9                    ; ADD(Add_r64_rm64) [RSI,R9]                           encoding(3 bytes) = 49 03 f1
003ah mov ecx,r11d                  ; MOV(Mov_r32_rm32) [ECX,R11D]                         encoding(3 bytes) = 41 8b cb
003dh and ecx,7                     ; AND(And_rm32_imm8) [ECX,7h:imm32]                    encoding(3 bytes) = 83 e1 07
0040h mov edi,1                     ; MOV(Mov_r32_imm32) [EDI,1h:imm32]                    encoding(5 bytes) = bf 01 00 00 00
0045h shl edi,cl                    ; SHL(Shl_rm32_CL) [EDI,CL]                            encoding(2 bytes) = d3 e7
0047h movzx ecx,dil                 ; MOVZX(Movzx_r32_rm8) [ECX,DIL]                       encoding(4 bytes) = 40 0f b6 cf
004bh or [rsi],cl                   ; OR(Or_rm8_r8) [mem(8u,RSI:br,DS:sr),CL]              encoding(2 bytes) = 08 0e
004dh inc r11d                      ; INC(Inc_rm32) [R11D]                                 encoding(3 bytes) = 41 ff c3
0050h cmp r11d,edx                  ; CMP(Cmp_r32_rm32) [R11D,EDX]                         encoding(3 bytes) = 44 3b da
0053h jl short 001dh                ; JL(Jl_rel8_64) [1Dh:jmp64]                           encoding(2 bytes) = 7c c8
0055h mov [rax],r9                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),R9]         encoding(3 bytes) = 4c 89 08
0058h mov [rax+8],r8d               ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),R8D]        encoding(4 bytes) = 44 89 40 08
005ch add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0060h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0061h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0062h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0063h call 7FFE390EEF00h            ; CALL(Call_rel32_64) [5F5930B0h:jmp64]                encoding(5 bytes) = e8 48 30 59 5f
0068h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packBytes => new byte[105]{0x57,0x56,0x48,0x83,0xEC,0x28,0x48,0x8B,0xC1,0x4D,0x8B,0x08,0x45,0x8B,0x40,0x08,0x4C,0x8B,0x12,0x8B,0x52,0x08,0x45,0x33,0xDB,0x85,0xD2,0x7E,0x38,0x49,0x63,0xCB,0x41,0x0F,0xB6,0x0C,0x0A,0x84,0xC9,0x74,0x24,0x41,0x8B,0xCB,0xC1,0xF9,0x03,0x41,0x3B,0xC8,0x73,0x2F,0x48,0x63,0xF1,0x49,0x03,0xF1,0x41,0x8B,0xCB,0x83,0xE1,0x07,0xBF,0x01,0x00,0x00,0x00,0xD3,0xE7,0x40,0x0F,0xB6,0xCF,0x08,0x0E,0x41,0xFF,0xC3,0x44,0x3B,0xDA,0x7C,0xC8,0x4C,0x89,0x08,0x44,0x89,0x40,0x08,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3,0xE8,0x48,0x30,0x59,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> pack(ReadOnlySpan<byte> src, Span<byte> dst)
; location: [7FFDD9B5BEE0h, 7FFDD9B5BF46h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0006h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0009h mov r9,[r8]                   ; MOV(Mov_r64_rm64) [R9,mem(64u,R8:br,DS:sr)]          encoding(3 bytes) = 4d 8b 08
000ch mov r8d,[r8+8]                ; MOV(Mov_r32_rm32) [R8D,mem(32u,R8:br,DS:sr)]         encoding(4 bytes) = 45 8b 40 08
0010h mov r10,[rdx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 4c 8b 12
0013h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 52 08
0016h xor r11d,r11d                 ; XOR(Xor_r32_rm32) [R11D,R11D]                        encoding(3 bytes) = 45 33 db
0019h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
001bh jle short 0053h               ; JLE(Jle_rel8_64) [53h:jmp64]                         encoding(2 bytes) = 7e 36
001dh movsxd rcx,r11d               ; MOVSXD(Movsxd_r64_rm32) [RCX,R11D]                   encoding(3 bytes) = 49 63 cb
0020h cmp byte ptr [r10+rcx],1      ; CMP(Cmp_rm8_imm8) [mem(8u,R10:br,DS:sr),1h:imm8]     encoding(5 bytes) = 41 80 3c 0a 01
0025h jne short 004bh               ; JNE(Jne_rel8_64) [4Bh:jmp64]                         encoding(2 bytes) = 75 24
0027h mov ecx,r11d                  ; MOV(Mov_r32_rm32) [ECX,R11D]                         encoding(3 bytes) = 41 8b cb
002ah sar ecx,3                     ; SAR(Sar_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 f9 03
002dh cmp ecx,r8d                   ; CMP(Cmp_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 3b c8
0030h jae short 0061h               ; JAE(Jae_rel8_64) [61h:jmp64]                         encoding(2 bytes) = 73 2f
0032h movsxd rsi,ecx                ; MOVSXD(Movsxd_r64_rm32) [RSI,ECX]                    encoding(3 bytes) = 48 63 f1
0035h add rsi,r9                    ; ADD(Add_r64_rm64) [RSI,R9]                           encoding(3 bytes) = 49 03 f1
0038h mov ecx,r11d                  ; MOV(Mov_r32_rm32) [ECX,R11D]                         encoding(3 bytes) = 41 8b cb
003bh and ecx,7                     ; AND(And_rm32_imm8) [ECX,7h:imm32]                    encoding(3 bytes) = 83 e1 07
003eh mov edi,1                     ; MOV(Mov_r32_imm32) [EDI,1h:imm32]                    encoding(5 bytes) = bf 01 00 00 00
0043h shl edi,cl                    ; SHL(Shl_rm32_CL) [EDI,CL]                            encoding(2 bytes) = d3 e7
0045h movzx ecx,dil                 ; MOVZX(Movzx_r32_rm8) [ECX,DIL]                       encoding(4 bytes) = 40 0f b6 cf
0049h or [rsi],cl                   ; OR(Or_rm8_r8) [mem(8u,RSI:br,DS:sr),CL]              encoding(2 bytes) = 08 0e
004bh inc r11d                      ; INC(Inc_rm32) [R11D]                                 encoding(3 bytes) = 41 ff c3
004eh cmp r11d,edx                  ; CMP(Cmp_r32_rm32) [R11D,EDX]                         encoding(3 bytes) = 44 3b da
0051h jl short 001dh                ; JL(Jl_rel8_64) [1Dh:jmp64]                           encoding(2 bytes) = 7c ca
0053h mov [rax],r9                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),R9]         encoding(3 bytes) = 4c 89 08
0056h mov [rax+8],r8d               ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),R8D]        encoding(4 bytes) = 44 89 40 08
005ah add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
005eh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
005fh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0060h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0061h call 7FFE390EEF00h            ; CALL(Call_rel32_64) [5F593020h:jmp64]                encoding(5 bytes) = e8 ba 2f 59 5f
0066h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packBytes => new byte[103]{0x57,0x56,0x48,0x83,0xEC,0x28,0x48,0x8B,0xC1,0x4D,0x8B,0x08,0x45,0x8B,0x40,0x08,0x4C,0x8B,0x12,0x8B,0x52,0x08,0x45,0x33,0xDB,0x85,0xD2,0x7E,0x36,0x49,0x63,0xCB,0x41,0x80,0x3C,0x0A,0x01,0x75,0x24,0x41,0x8B,0xCB,0xC1,0xF9,0x03,0x41,0x3B,0xC8,0x73,0x2F,0x48,0x63,0xF1,0x49,0x03,0xF1,0x41,0x8B,0xCB,0x83,0xE1,0x07,0xBF,0x01,0x00,0x00,0x00,0xD3,0xE7,0x40,0x0F,0xB6,0xCF,0x08,0x0E,0x41,0xFF,0xC3,0x44,0x3B,0xDA,0x7C,0xCA,0x4C,0x89,0x08,0x44,0x89,0x40,0x08,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3,0xE8,0xBA,0x2F,0x59,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> pack(Boolean[] src)
; location: [7FFDD9B5BF60h, 7FFDD9B5BFECh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0007h mov rdi,rcx                   ; MOV(Mov_r64_rm64) [RDI,RCX]                          encoding(3 bytes) = 48 8b f9
000ah mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
000dh mov ebx,[rsi+8]               ; MOV(Mov_r32_rm32) [EBX,mem(32u,RSI:br,DS:sr)]        encoding(3 bytes) = 8b 5e 08
0010h mov edx,ebx                   ; MOV(Mov_r32_rm32) [EDX,EBX]                          encoding(2 bytes) = 8b d3
0012h sar edx,3                     ; SAR(Sar_rm32_imm8) [EDX,3h:imm8]                     encoding(3 bytes) = c1 fa 03
0015h test bl,7                     ; TEST(Test_rm8_imm8) [BL,7h:imm8]                     encoding(3 bytes) = f6 c3 07
0018h je short 001ch                ; JE(Je_rel8_64) [1Ch:jmp64]                           encoding(2 bytes) = 74 02
001ah inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
001ch movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
001fh mov rcx,7FFDD946EA10h         ; MOV(Mov_r64_imm64) [RCX,7ffdd946ea10h:imm64]         encoding(10 bytes) = 48 b9 10 ea 46 d9 fd 7f 00 00
0029h call 7FFE38FC45E0h            ; CALL(Call_rel32_64) [5F468680h:jmp64]                encoding(5 bytes) = e8 52 86 46 5f
002eh lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 50 10
0032h mov r8d,[rax+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RAX:br,DS:sr)]        encoding(4 bytes) = 44 8b 40 08
0036h xor r9d,r9d                   ; XOR(Xor_r32_rm32) [R9D,R9D]                          encoding(3 bytes) = 45 33 c9
0039h test ebx,ebx                  ; TEST(Test_rm32_r32) [EBX,EBX]                        encoding(2 bytes) = 85 db
003bh jle short 0075h               ; JLE(Jle_rel8_64) [75h:jmp64]                         encoding(2 bytes) = 7e 38
003dh movsxd rcx,r9d                ; MOVSXD(Movsxd_r64_rm32) [RCX,R9D]                    encoding(3 bytes) = 49 63 c9
0040h cmp byte ptr [rsi+rcx+10h],0  ; CMP(Cmp_rm8_imm8) [mem(8u,RSI:br,DS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 0e 10 00
0045h je short 006dh                ; JE(Je_rel8_64) [6Dh:jmp64]                           encoding(2 bytes) = 74 26
0047h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
004ah sar ecx,3                     ; SAR(Sar_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 f9 03
004dh cmp ecx,r8d                   ; CMP(Cmp_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 3b c8
0050h jae short 0087h               ; JAE(Jae_rel8_64) [87h:jmp64]                         encoding(2 bytes) = 73 35
0052h movsxd rax,ecx                ; MOVSXD(Movsxd_r64_rm32) [RAX,ECX]                    encoding(3 bytes) = 48 63 c1
0055h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
0058h mov ecx,r9d                   ; MOV(Mov_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 8b c9
005bh and ecx,7                     ; AND(And_rm32_imm8) [ECX,7h:imm32]                    encoding(3 bytes) = 83 e1 07
005eh mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
0064h shl r10d,cl                   ; SHL(Shl_rm32_CL) [R10D,CL]                           encoding(3 bytes) = 41 d3 e2
0067h movzx ecx,r10b                ; MOVZX(Movzx_r32_rm8) [ECX,R10L]                      encoding(4 bytes) = 41 0f b6 ca
006bh or [rax],cl                   ; OR(Or_rm8_r8) [mem(8u,RAX:br,DS:sr),CL]              encoding(2 bytes) = 08 08
006dh inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
0070h cmp r9d,ebx                   ; CMP(Cmp_r32_rm32) [R9D,EBX]                          encoding(3 bytes) = 44 3b cb
0073h jl short 003dh                ; JL(Jl_rel8_64) [3Dh:jmp64]                           encoding(2 bytes) = 7c c8
0075h mov [rdi],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RDI:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 17
0078h mov [rdi+8],r8d               ; MOV(Mov_rm32_r32) [mem(32u,RDI:br,DS:sr),R8D]        encoding(4 bytes) = 44 89 47 08
007ch mov rax,rdi                   ; MOV(Mov_r64_rm64) [RAX,RDI]                          encoding(3 bytes) = 48 8b c7
007fh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0083h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0084h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0085h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0086h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0087h call 7FFE390EEF00h            ; CALL(Call_rel32_64) [5F592FA0h:jmp64]                encoding(5 bytes) = e8 14 2f 59 5f
008ch int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packBytes => new byte[141]{0x57,0x56,0x53,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF9,0x48,0x8B,0xF2,0x8B,0x5E,0x08,0x8B,0xD3,0xC1,0xFA,0x03,0xF6,0xC3,0x07,0x74,0x02,0xFF,0xC2,0x48,0x63,0xD2,0x48,0xB9,0x10,0xEA,0x46,0xD9,0xFD,0x7F,0x00,0x00,0xE8,0x52,0x86,0x46,0x5F,0x48,0x8D,0x50,0x10,0x44,0x8B,0x40,0x08,0x45,0x33,0xC9,0x85,0xDB,0x7E,0x38,0x49,0x63,0xC9,0x80,0x7C,0x0E,0x10,0x00,0x74,0x26,0x41,0x8B,0xC9,0xC1,0xF9,0x03,0x41,0x3B,0xC8,0x73,0x35,0x48,0x63,0xC1,0x48,0x03,0xC2,0x41,0x8B,0xC9,0x83,0xE1,0x07,0x41,0xBA,0x01,0x00,0x00,0x00,0x41,0xD3,0xE2,0x41,0x0F,0xB6,0xCA,0x08,0x08,0x41,0xFF,0xC1,0x44,0x3B,0xCB,0x7C,0xC8,0x48,0x89,0x17,0x44,0x89,0x47,0x08,0x48,0x8B,0xC7,0x48,0x83,0xC4,0x20,0x5B,0x5E,0x5F,0xC3,0xE8,0x14,0x2F,0x59,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte packseq(ReadOnlySpan<byte> src, out byte dst)
; location: [7FFDD9B5C010h, 7FFDD9B5C06Dh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov r8d,[rcx+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 8b 41 08
000ch mov byte ptr [rdx],0          ; MOV(Mov_rm8_imm8) [mem(8u,RDX:br,DS:sr),0h:imm8]     encoding(3 bytes) = c6 02 00
000fh cmp r8d,8                     ; CMP(Cmp_rm32_imm8) [R8D,8h:imm32]                    encoding(4 bytes) = 41 83 f8 08
0013h jge short 001ah               ; JGE(Jge_rel8_64) [1Ah:jmp64]                         encoding(2 bytes) = 7d 05
0015h mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0018h jmp short 0020h               ; JMP(Jmp_rel8_64) [20h:jmp64]                         encoding(2 bytes) = eb 06
001ah mov r9d,8                     ; MOV(Mov_r32_imm32) [R9D,8h:imm32]                    encoding(6 bytes) = 41 b9 08 00 00 00
0020h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0023h test r9d,r9d                  ; TEST(Test_rm32_r32) [R9D,R9D]                        encoding(3 bytes) = 45 85 c9
0026h jle short 0050h               ; JLE(Jle_rel8_64) [50h:jmp64]                         encoding(2 bytes) = 7e 28
0028h cmp r10d,r8d                  ; CMP(Cmp_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 3b d0
002bh jae short 0058h               ; JAE(Jae_rel8_64) [58h:jmp64]                         encoding(2 bytes) = 73 2b
002dh movsxd rcx,r10d               ; MOVSXD(Movsxd_r64_rm32) [RCX,R10D]                   encoding(3 bytes) = 49 63 ca
0030h cmp byte ptr [rax+rcx],1      ; CMP(Cmp_rm8_imm8) [mem(8u,RAX:br,DS:sr),1h:imm8]     encoding(4 bytes) = 80 3c 08 01
0034h jne short 0048h               ; JNE(Jne_rel8_64) [48h:jmp64]                         encoding(2 bytes) = 75 12
0036h mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
003ch mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
003fh shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0042h movzx ecx,r11b                ; MOVZX(Movzx_r32_rm8) [ECX,R11L]                      encoding(4 bytes) = 41 0f b6 cb
0046h or [rdx],cl                   ; OR(Or_rm8_r8) [mem(8u,RDX:br,DS:sr),CL]              encoding(2 bytes) = 08 0a
0048h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
004bh cmp r10d,r9d                  ; CMP(Cmp_r32_rm32) [R10D,R9D]                         encoding(3 bytes) = 45 3b d1
004eh jl short 0028h                ; JL(Jl_rel8_64) [28h:jmp64]                           encoding(2 bytes) = 7c d8
0050h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0053h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0057h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0058h call 7FFE390EEF00h            ; CALL(Call_rel32_64) [5F592EF0h:jmp64]                encoding(5 bytes) = e8 93 2e 59 5f
005dh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packseqBytes => new byte[94]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x44,0x8B,0x41,0x08,0xC6,0x02,0x00,0x41,0x83,0xF8,0x08,0x7D,0x05,0x45,0x8B,0xC8,0xEB,0x06,0x41,0xB9,0x08,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x85,0xC9,0x7E,0x28,0x45,0x3B,0xD0,0x73,0x2B,0x49,0x63,0xCA,0x80,0x3C,0x08,0x01,0x75,0x12,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x41,0xD3,0xE3,0x41,0x0F,0xB6,0xCB,0x08,0x0A,0x41,0xFF,0xC2,0x45,0x3B,0xD1,0x7C,0xD8,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x93,0x2E,0x59,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte packseq(out byte dst, Byte[] src)
; location: [7FFDD9B5C090h, 7FFDD9B5C0EAh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0007h mov byte ptr [rax],0          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,DS:sr),0h:imm8]     encoding(3 bytes) = c6 00 00
000ah mov r8d,[rdx+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 8b 42 08
000eh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0011h cmp r9d,8                     ; CMP(Cmp_rm32_imm8) [R9D,8h:imm32]                    encoding(4 bytes) = 41 83 f9 08
0015h jge short 0019h               ; JGE(Jge_rel8_64) [19h:jmp64]                         encoding(2 bytes) = 7d 02
0017h jmp short 001fh               ; JMP(Jmp_rel8_64) [1Fh:jmp64]                         encoding(2 bytes) = eb 06
0019h mov r9d,8                     ; MOV(Mov_r32_imm32) [R9D,8h:imm32]                    encoding(6 bytes) = 41 b9 08 00 00 00
001fh xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0022h test r9d,r9d                  ; TEST(Test_rm32_r32) [R9D,R9D]                        encoding(3 bytes) = 45 85 c9
0025h jle short 0050h               ; JLE(Jle_rel8_64) [50h:jmp64]                         encoding(2 bytes) = 7e 29
0027h cmp r10d,r8d                  ; CMP(Cmp_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 3b d0
002ah jae short 0055h               ; JAE(Jae_rel8_64) [55h:jmp64]                         encoding(2 bytes) = 73 29
002ch movsxd rcx,r10d               ; MOVSXD(Movsxd_r64_rm32) [RCX,R10D]                   encoding(3 bytes) = 49 63 ca
002fh cmp byte ptr [rdx+rcx+10h],1  ; CMP(Cmp_rm8_imm8) [mem(8u,RDX:br,DS:sr),1h:imm8]     encoding(5 bytes) = 80 7c 0a 10 01
0034h jne short 0048h               ; JNE(Jne_rel8_64) [48h:jmp64]                         encoding(2 bytes) = 75 12
0036h mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
003ch mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
003fh shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0042h movzx ecx,r11b                ; MOVZX(Movzx_r32_rm8) [ECX,R11L]                      encoding(4 bytes) = 41 0f b6 cb
0046h or [rax],cl                   ; OR(Or_rm8_r8) [mem(8u,RAX:br,DS:sr),CL]              encoding(2 bytes) = 08 08
0048h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
004bh cmp r10d,r9d                  ; CMP(Cmp_r32_rm32) [R10D,R9D]                         encoding(3 bytes) = 45 3b d1
004eh jl short 0027h                ; JL(Jl_rel8_64) [27h:jmp64]                           encoding(2 bytes) = 7c d7
0050h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0054h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0055h call 7FFE390EEF00h            ; CALL(Call_rel32_64) [5F592E70h:jmp64]                encoding(5 bytes) = e8 16 2e 59 5f
005ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packseqBytes => new byte[91]{0x48,0x83,0xEC,0x28,0x48,0x8B,0xC1,0xC6,0x00,0x00,0x44,0x8B,0x42,0x08,0x45,0x8B,0xC8,0x41,0x83,0xF9,0x08,0x7D,0x02,0xEB,0x06,0x41,0xB9,0x08,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x85,0xC9,0x7E,0x29,0x45,0x3B,0xD0,0x73,0x29,0x49,0x63,0xCA,0x80,0x7C,0x0A,0x10,0x01,0x75,0x12,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x41,0xD3,0xE3,0x41,0x0F,0xB6,0xCB,0x08,0x08,0x41,0xFF,0xC2,0x45,0x3B,0xD1,0x7C,0xD7,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x16,0x2E,0x59,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint packseq(out uint dst, Byte[] src)
; location: [7FFDD9B5C100h, 7FFDD9B5C15Bh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0007h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0009h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),ECX]        encoding(2 bytes) = 89 08
000bh mov r8d,[rdx+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RDX:br,DS:sr)]        encoding(4 bytes) = 44 8b 42 08
000fh mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0012h cmp r9d,20h                   ; CMP(Cmp_rm32_imm8) [R9D,20h:imm32]                   encoding(4 bytes) = 41 83 f9 20
0016h jge short 001ah               ; JGE(Jge_rel8_64) [1Ah:jmp64]                         encoding(2 bytes) = 7d 02
0018h jmp short 0020h               ; JMP(Jmp_rel8_64) [20h:jmp64]                         encoding(2 bytes) = eb 06
001ah mov r9d,20h                   ; MOV(Mov_r32_imm32) [R9D,20h:imm32]                   encoding(6 bytes) = 41 b9 20 00 00 00
0020h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0023h test r9d,r9d                  ; TEST(Test_rm32_r32) [R9D,R9D]                        encoding(3 bytes) = 45 85 c9
0026h jle short 0051h               ; JLE(Jle_rel8_64) [51h:jmp64]                         encoding(2 bytes) = 7e 29
0028h cmp r10d,r8d                  ; CMP(Cmp_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 3b d0
002bh jae short 0056h               ; JAE(Jae_rel8_64) [56h:jmp64]                         encoding(2 bytes) = 73 29
002dh movsxd rcx,r10d               ; MOVSXD(Movsxd_r64_rm32) [RCX,R10D]                   encoding(3 bytes) = 49 63 ca
0030h cmp byte ptr [rdx+rcx+10h],1  ; CMP(Cmp_rm8_imm8) [mem(8u,RDX:br,DS:sr),1h:imm8]     encoding(5 bytes) = 80 7c 0a 10 01
0035h jne short 0049h               ; JNE(Jne_rel8_64) [49h:jmp64]                         encoding(2 bytes) = 75 12
0037h mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
003dh mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
0040h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0043h movzx ecx,r11b                ; MOVZX(Movzx_r32_rm8) [ECX,R11L]                      encoding(4 bytes) = 41 0f b6 cb
0047h or [rax],ecx                  ; OR(Or_rm32_r32) [mem(32u,RAX:br,DS:sr),ECX]          encoding(2 bytes) = 09 08
0049h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
004ch cmp r10d,r9d                  ; CMP(Cmp_r32_rm32) [R10D,R9D]                         encoding(3 bytes) = 45 3b d1
004fh jl short 0028h                ; JL(Jl_rel8_64) [28h:jmp64]                           encoding(2 bytes) = 7c d7
0051h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0055h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0056h call 7FFE390EEF00h            ; CALL(Call_rel32_64) [5F592E00h:jmp64]                encoding(5 bytes) = e8 a5 2d 59 5f
005bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packseqBytes => new byte[92]{0x48,0x83,0xEC,0x28,0x48,0x8B,0xC1,0x33,0xC9,0x89,0x08,0x44,0x8B,0x42,0x08,0x45,0x8B,0xC8,0x41,0x83,0xF9,0x20,0x7D,0x02,0xEB,0x06,0x41,0xB9,0x20,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x85,0xC9,0x7E,0x29,0x45,0x3B,0xD0,0x73,0x29,0x49,0x63,0xCA,0x80,0x7C,0x0A,0x10,0x01,0x75,0x12,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x41,0xD3,0xE3,0x41,0x0F,0xB6,0xCB,0x09,0x08,0x41,0xFF,0xC2,0x45,0x3B,0xD1,0x7C,0xD7,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xA5,0x2D,0x59,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort packseq(ReadOnlySpan<byte> src, out ushort dst)
; location: [7FFDD9B5C170h, 7FFDD9B5C1D0h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov r8d,[rcx+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 8b 41 08
000ch mov word ptr [rdx],0          ; MOV(Mov_rm16_imm16) [mem(16u,RDX:br,DS:sr),0h:imm16] encoding(5 bytes) = 66 c7 02 00 00
0011h cmp r8d,10h                   ; CMP(Cmp_rm32_imm8) [R8D,10h:imm32]                   encoding(4 bytes) = 41 83 f8 10
0015h jge short 001ch               ; JGE(Jge_rel8_64) [1Ch:jmp64]                         encoding(2 bytes) = 7d 05
0017h mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
001ah jmp short 0022h               ; JMP(Jmp_rel8_64) [22h:jmp64]                         encoding(2 bytes) = eb 06
001ch mov r9d,10h                   ; MOV(Mov_r32_imm32) [R9D,10h:imm32]                   encoding(6 bytes) = 41 b9 10 00 00 00
0022h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0025h test r9d,r9d                  ; TEST(Test_rm32_r32) [R9D,R9D]                        encoding(3 bytes) = 45 85 c9
0028h jle short 0053h               ; JLE(Jle_rel8_64) [53h:jmp64]                         encoding(2 bytes) = 7e 29
002ah cmp r10d,r8d                  ; CMP(Cmp_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 3b d0
002dh jae short 005bh               ; JAE(Jae_rel8_64) [5Bh:jmp64]                         encoding(2 bytes) = 73 2c
002fh movsxd rcx,r10d               ; MOVSXD(Movsxd_r64_rm32) [RCX,R10D]                   encoding(3 bytes) = 49 63 ca
0032h cmp byte ptr [rax+rcx],1      ; CMP(Cmp_rm8_imm8) [mem(8u,RAX:br,DS:sr),1h:imm8]     encoding(4 bytes) = 80 3c 08 01
0036h jne short 004bh               ; JNE(Jne_rel8_64) [4Bh:jmp64]                         encoding(2 bytes) = 75 13
0038h mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
003eh mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
0041h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0044h movzx ecx,r11w                ; MOVZX(Movzx_r32_rm16) [ECX,R11W]                     encoding(4 bytes) = 41 0f b7 cb
0048h or [rdx],cx                   ; OR(Or_rm16_r16) [mem(16u,RDX:br,DS:sr),CX]           encoding(3 bytes) = 66 09 0a
004bh inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
004eh cmp r10d,r9d                  ; CMP(Cmp_r32_rm32) [R10D,R9D]                         encoding(3 bytes) = 45 3b d1
0051h jl short 002ah                ; JL(Jl_rel8_64) [2Ah:jmp64]                           encoding(2 bytes) = 7c d7
0053h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0056h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
005ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
005bh call 7FFE390EEF00h            ; CALL(Call_rel32_64) [5F592D90h:jmp64]                encoding(5 bytes) = e8 30 2d 59 5f
0060h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packseqBytes => new byte[97]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x44,0x8B,0x41,0x08,0x66,0xC7,0x02,0x00,0x00,0x41,0x83,0xF8,0x10,0x7D,0x05,0x45,0x8B,0xC8,0xEB,0x06,0x41,0xB9,0x10,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x85,0xC9,0x7E,0x29,0x45,0x3B,0xD0,0x73,0x2C,0x49,0x63,0xCA,0x80,0x3C,0x08,0x01,0x75,0x13,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x41,0xD3,0xE3,0x41,0x0F,0xB7,0xCB,0x66,0x09,0x0A,0x41,0xFF,0xC2,0x45,0x3B,0xD1,0x7C,0xD7,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x30,0x2D,0x59,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint packseq(ReadOnlySpan<byte> src, out uint dst)
; location: [7FFDD9B5C1F0h, 7FFDD9B5C24Bh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov r8d,[rcx+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 8b 41 08
000ch xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
000eh mov [rdx],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),ECX]        encoding(2 bytes) = 89 0a
0010h cmp r8d,20h                   ; CMP(Cmp_rm32_imm8) [R8D,20h:imm32]                   encoding(4 bytes) = 41 83 f8 20
0014h jge short 001bh               ; JGE(Jge_rel8_64) [1Bh:jmp64]                         encoding(2 bytes) = 7d 05
0016h mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0019h jmp short 0021h               ; JMP(Jmp_rel8_64) [21h:jmp64]                         encoding(2 bytes) = eb 06
001bh mov r9d,20h                   ; MOV(Mov_r32_imm32) [R9D,20h:imm32]                   encoding(6 bytes) = 41 b9 20 00 00 00
0021h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0024h test r9d,r9d                  ; TEST(Test_rm32_r32) [R9D,R9D]                        encoding(3 bytes) = 45 85 c9
0027h jle short 004eh               ; JLE(Jle_rel8_64) [4Eh:jmp64]                         encoding(2 bytes) = 7e 25
0029h cmp r10d,r8d                  ; CMP(Cmp_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 3b d0
002ch jae short 0056h               ; JAE(Jae_rel8_64) [56h:jmp64]                         encoding(2 bytes) = 73 28
002eh movsxd rcx,r10d               ; MOVSXD(Movsxd_r64_rm32) [RCX,R10D]                   encoding(3 bytes) = 49 63 ca
0031h cmp byte ptr [rax+rcx],1      ; CMP(Cmp_rm8_imm8) [mem(8u,RAX:br,DS:sr),1h:imm8]     encoding(4 bytes) = 80 3c 08 01
0035h jne short 0046h               ; JNE(Jne_rel8_64) [46h:jmp64]                         encoding(2 bytes) = 75 0f
0037h mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
003dh mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
0040h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0043h or [rdx],r11d                 ; OR(Or_rm32_r32) [mem(32u,RDX:br,DS:sr),R11D]         encoding(3 bytes) = 44 09 1a
0046h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
0049h cmp r10d,r9d                  ; CMP(Cmp_r32_rm32) [R10D,R9D]                         encoding(3 bytes) = 45 3b d1
004ch jl short 0029h                ; JL(Jl_rel8_64) [29h:jmp64]                           encoding(2 bytes) = 7c db
004eh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0051h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0055h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0056h call 7FFE390EEF00h            ; CALL(Call_rel32_64) [5F592D10h:jmp64]                encoding(5 bytes) = e8 b5 2c 59 5f
005bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packseqBytes => new byte[92]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x44,0x8B,0x41,0x08,0x33,0xC9,0x89,0x0A,0x41,0x83,0xF8,0x20,0x7D,0x05,0x45,0x8B,0xC8,0xEB,0x06,0x41,0xB9,0x20,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x85,0xC9,0x7E,0x25,0x45,0x3B,0xD0,0x73,0x28,0x49,0x63,0xCA,0x80,0x3C,0x08,0x01,0x75,0x0F,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x41,0xD3,0xE3,0x44,0x09,0x1A,0x41,0xFF,0xC2,0x45,0x3B,0xD1,0x7C,0xDB,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xB5,0x2C,0x59,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong packseq(ReadOnlySpan<byte> src, out ulong dst)
; location: [7FFDD9B5C260h, 7FFDD9B5C2BCh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0008h mov r8d,[rcx+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RCX:br,DS:sr)]        encoding(4 bytes) = 44 8b 41 08
000ch xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
000eh mov [rdx],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RCX]        encoding(3 bytes) = 48 89 0a
0011h cmp r8d,40h                   ; CMP(Cmp_rm32_imm8) [R8D,40h:imm32]                   encoding(4 bytes) = 41 83 f8 40
0015h jge short 001ch               ; JGE(Jge_rel8_64) [1Ch:jmp64]                         encoding(2 bytes) = 7d 05
0017h mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
001ah jmp short 0022h               ; JMP(Jmp_rel8_64) [22h:jmp64]                         encoding(2 bytes) = eb 06
001ch mov r9d,40h                   ; MOV(Mov_r32_imm32) [R9D,40h:imm32]                   encoding(6 bytes) = 41 b9 40 00 00 00
0022h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0025h test r9d,r9d                  ; TEST(Test_rm32_r32) [R9D,R9D]                        encoding(3 bytes) = 45 85 c9
0028h jle short 004fh               ; JLE(Jle_rel8_64) [4Fh:jmp64]                         encoding(2 bytes) = 7e 25
002ah cmp r10d,r8d                  ; CMP(Cmp_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 3b d0
002dh jae short 0057h               ; JAE(Jae_rel8_64) [57h:jmp64]                         encoding(2 bytes) = 73 28
002fh movsxd rcx,r10d               ; MOVSXD(Movsxd_r64_rm32) [RCX,R10D]                   encoding(3 bytes) = 49 63 ca
0032h cmp byte ptr [rax+rcx],1      ; CMP(Cmp_rm8_imm8) [mem(8u,RAX:br,DS:sr),1h:imm8]     encoding(4 bytes) = 80 3c 08 01
0036h jne short 0047h               ; JNE(Jne_rel8_64) [47h:jmp64]                         encoding(2 bytes) = 75 0f
0038h mov r11d,1                    ; MOV(Mov_r32_imm32) [R11D,1h:imm32]                   encoding(6 bytes) = 41 bb 01 00 00 00
003eh mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
0041h shl r11,cl                    ; SHL(Shl_rm64_CL) [R11,CL]                            encoding(3 bytes) = 49 d3 e3
0044h or [rdx],r11                  ; OR(Or_rm64_r64) [mem(64u,RDX:br,DS:sr),R11]          encoding(3 bytes) = 4c 09 1a
0047h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
004ah cmp r10d,r9d                  ; CMP(Cmp_r32_rm32) [R10D,R9D]                         encoding(3 bytes) = 45 3b d1
004dh jl short 002ah                ; JL(Jl_rel8_64) [2Ah:jmp64]                           encoding(2 bytes) = 7c db
004fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0052h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0056h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0057h call 7FFE390EEF00h            ; CALL(Call_rel32_64) [5F592CA0h:jmp64]                encoding(5 bytes) = e8 44 2c 59 5f
005ch int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> packseqBytes => new byte[93]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x44,0x8B,0x41,0x08,0x33,0xC9,0x48,0x89,0x0A,0x41,0x83,0xF8,0x40,0x7D,0x05,0x45,0x8B,0xC8,0xEB,0x06,0x41,0xB9,0x40,0x00,0x00,0x00,0x45,0x33,0xD2,0x45,0x85,0xC9,0x7E,0x25,0x45,0x3B,0xD0,0x73,0x28,0x49,0x63,0xCA,0x80,0x3C,0x08,0x01,0x75,0x0F,0x41,0xBB,0x01,0x00,0x00,0x00,0x41,0x8B,0xCA,0x49,0xD3,0xE3,0x4C,0x09,0x1A,0x41,0xFF,0xC2,0x45,0x3B,0xD1,0x7C,0xDB,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x44,0x2C,0x59,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(sbyte src)
; location: [7FFDD9B5C2E0h, 7FFDD9B5C2EDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(byte src)
; location: [7FFDD9B5C300h, 7FFDD9B5C30Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(short src)
; location: [7FFDD9B5C320h, 7FFDD9B5C32Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(ushort src)
; location: [7FFDD9B5C340h, 7FFDD9B5C34Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xF3,0x0F,0xB8,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(int src)
; location: [7FFDD9B5C360h, 7FFDD9B5C36Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt eax,ecx                ; POPCNT(Popcnt_r32_rm32) [EAX,ECX]                    encoding(4 bytes) = f3 0f b8 c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x0F,0xB8,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(uint src)
; location: [7FFDD9B5C380h, 7FFDD9B5C38Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt eax,ecx                ; POPCNT(Popcnt_r32_rm32) [EAX,ECX]                    encoding(4 bytes) = f3 0f b8 c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x0F,0xB8,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(long src)
; location: [7FFDD9B5C3A0h, 7FFDD9B5C3ACh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt rax,rcx                ; POPCNT(Popcnt_r64_rm64) [RAX,RCX]                    encoding(5 bytes) = f3 48 0f b8 c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xB8,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint pop(ulong src)
; location: [7FFDD9B5C3C0h, 7FFDD9B5C3CCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h popcnt rax,rcx                ; POPCNT(Popcnt_r64_rm64) [RAX,RCX]                    encoding(5 bytes) = f3 48 0f b8 c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> popBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xF3,0x48,0x0F,0xB8,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint posl(byte src)
; location: [7FFDD9B5C3E0h, 7FFDD9B5C401h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h blsi eax,eax                  ; BLSI(VEX_Blsi_r32_rm32) [EAX,EAX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 d8
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0012h jne short 0018h               ; JNE(Jne_rel8_64) [18h:jmp64]                         encoding(2 bytes) = 75 04
0014h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0016h jmp short 0021h               ; JMP(Jmp_rel8_64) [21h:jmp64]                         encoding(2 bytes) = eb 09
0018h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
001ch neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
001eh add eax,1Fh                   ; ADD(Add_rm32_imm8) [EAX,1fh:imm32]                   encoding(3 bytes) = 83 c0 1f
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> poslBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x78,0xF3,0xD8,0x0F,0xB6,0xC0,0x85,0xC0,0x75,0x04,0x33,0xC0,0xEB,0x09,0xF3,0x0F,0xBD,0xC0,0xF7,0xD8,0x83,0xC0,0x1F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint posl(ushort src)
; location: [7FFDD9B5C420h, 7FFDD9B5C441h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h blsi eax,eax                  ; BLSI(VEX_Blsi_r32_rm32) [EAX,EAX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 d8
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0012h jne short 0018h               ; JNE(Jne_rel8_64) [18h:jmp64]                         encoding(2 bytes) = 75 04
0014h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0016h jmp short 0021h               ; JMP(Jmp_rel8_64) [21h:jmp64]                         encoding(2 bytes) = eb 09
0018h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
001ch neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
001eh add eax,1Fh                   ; ADD(Add_rm32_imm8) [EAX,1fh:imm32]                   encoding(3 bytes) = 83 c0 1f
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> poslBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC4,0xE2,0x78,0xF3,0xD8,0x0F,0xB7,0xC0,0x85,0xC0,0x75,0x04,0x33,0xC0,0xEB,0x09,0xF3,0x0F,0xBD,0xC0,0xF7,0xD8,0x83,0xC0,0x1F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint posl(uint src)
; location: [7FFDD9B5C460h, 7FFDD9B5C47Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsi eax,ecx                  ; BLSI(VEX_Blsi_r32_rm32) [EAX,ECX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 d9
000ah test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ch jne short 0012h               ; JNE(Jne_rel8_64) [12h:jmp64]                         encoding(2 bytes) = 75 04
000eh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0010h jmp short 001bh               ; JMP(Jmp_rel8_64) [1Bh:jmp64]                         encoding(2 bytes) = eb 09
0012h lzcnt eax,eax                 ; LZCNT(Lzcnt_r32_rm32) [EAX,EAX]                      encoding(4 bytes) = f3 0f bd c0
0016h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0018h add eax,1Fh                   ; ADD(Add_rm32_imm8) [EAX,1fh:imm32]                   encoding(3 bytes) = 83 c0 1f
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> poslBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x78,0xF3,0xD9,0x85,0xC0,0x75,0x04,0x33,0xC0,0xEB,0x09,0xF3,0x0F,0xBD,0xC0,0xF7,0xD8,0x83,0xC0,0x1F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint posl(ulong src)
; location: [7FFDD9B5C490h, 7FFDD9B5C4ADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsi rax,rcx                  ; BLSI(VEX_Blsi_r64_rm64) [RAX,RCX]                    encoding(VEX, 5 bytes) = c4 e2 f8 f3 d9
000ah test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
000dh jne short 0013h               ; JNE(Jne_rel8_64) [13h:jmp64]                         encoding(2 bytes) = 75 04
000fh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0011h jmp short 001dh               ; JMP(Jmp_rel8_64) [1Dh:jmp64]                         encoding(2 bytes) = eb 0a
0013h lzcnt rax,rax                 ; LZCNT(Lzcnt_r64_rm64) [RAX,RAX]                      encoding(5 bytes) = f3 48 0f bd c0
0018h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
001ah add eax,3Fh                   ; ADD(Add_rm32_imm8) [EAX,3fh:imm32]                   encoding(3 bytes) = 83 c0 3f
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> poslBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF8,0xF3,0xD9,0x48,0x85,0xC0,0x75,0x04,0x33,0xC0,0xEB,0x0A,0xF3,0x48,0x0F,0xBD,0xC0,0xF7,0xD8,0x83,0xC0,0x3F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte range(sbyte src, BitPos i0, BitPos i1)
; location: [7FFDD9B5C4C0h, 7FFDD9B5C505h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
000bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000dh jge short 0015h               ; JGE(Jge_rel8_64) [15h:jmp64]                         encoding(2 bytes) = 7d 06
000fh neg edx                       ; NEG(Neg_rm32) [EDX]                                  encoding(2 bytes) = f7 da
0011h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0013h jl short 0040h                ; JL(Jl_rel8_64) [40h:jmp64]                           encoding(2 bytes) = 7c 2b
0015h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0017h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0023h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0025h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0028h movsx rdx,cl                  ; MOVSX(Movsx_r64_rm8) [RDX,CL]                        encoding(4 bytes) = 48 0f be d1
002ch movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
002fh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0034h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0037h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
003bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
003fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0040h call 7FFDD9791CE8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC35828h:jmp64]        encoding(5 bytes) = e8 e3 57 c3 ff
0045h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> rangeBytes => new byte[70]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0x41,0x2B,0xD0,0x85,0xD2,0x7D,0x06,0xF7,0xDA,0x85,0xD2,0x7C,0x2B,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBE,0xD1,0x0F,0xB6,0xD2,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB6,0xC0,0x48,0x0F,0xBE,0xC0,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xE3,0x57,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte range(byte src, BitPos i0, BitPos i1)
; location: [7FFDD9B5C520h, 7FFDD9B5C55Dh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
000bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000dh jge short 0015h               ; JGE(Jge_rel8_64) [15h:jmp64]                         encoding(2 bytes) = 7d 06
000fh neg edx                       ; NEG(Neg_rm32) [EDX]                                  encoding(2 bytes) = f7 da
0011h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0013h jl short 0038h                ; JL(Jl_rel8_64) [38h:jmp64]                           encoding(2 bytes) = 7c 23
0015h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0017h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0023h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0025h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0028h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
002bh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0030h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0033h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0037h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0038h call 7FFDD9791CE8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC357C8h:jmp64]        encoding(5 bytes) = e8 8b 57 c3 ff
003dh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> rangeBytes => new byte[62]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0x41,0x2B,0xD0,0x85,0xD2,0x7D,0x06,0xF7,0xDA,0x85,0xD2,0x7C,0x23,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB6,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB6,0xC0,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x8B,0x57,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort range(ushort src, BitPos i0, BitPos i1)
; location: [7FFDD9B5C580h, 7FFDD9B5C5BDh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
000bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000dh jge short 0015h               ; JGE(Jge_rel8_64) [15h:jmp64]                         encoding(2 bytes) = 7d 06
000fh neg edx                       ; NEG(Neg_rm32) [EDX]                                  encoding(2 bytes) = f7 da
0011h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0013h jl short 0038h                ; JL(Jl_rel8_64) [38h:jmp64]                           encoding(2 bytes) = 7c 23
0015h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0017h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0023h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0025h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0028h movzx edx,cx                  ; MOVZX(Movzx_r32_rm16) [EDX,CX]                       encoding(3 bytes) = 0f b7 d1
002bh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0030h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0033h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0037h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0038h call 7FFDD9791CE8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC35768h:jmp64]        encoding(5 bytes) = e8 2b 57 c3 ff
003dh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> rangeBytes => new byte[62]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0x41,0x2B,0xD0,0x85,0xD2,0x7D,0x06,0xF7,0xDA,0x85,0xD2,0x7C,0x23,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB7,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB7,0xC0,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x2B,0x57,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short range(short src, BitPos i0, BitPos i1)
; location: [7FFDD9B5C5E0h, 7FFDD9B5C625h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
000bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000dh jge short 0015h               ; JGE(Jge_rel8_64) [15h:jmp64]                         encoding(2 bytes) = 7d 06
000fh neg edx                       ; NEG(Neg_rm32) [EDX]                                  encoding(2 bytes) = f7 da
0011h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0013h jl short 0040h                ; JL(Jl_rel8_64) [40h:jmp64]                           encoding(2 bytes) = 7c 2b
0015h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0017h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0023h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0025h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0028h movsx rdx,cx                  ; MOVSX(Movsx_r64_rm16) [RDX,CX]                       encoding(4 bytes) = 48 0f bf d1
002ch movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002fh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0034h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0037h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
003bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
003fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0040h call 7FFDD9791CE8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC35708h:jmp64]        encoding(5 bytes) = e8 c3 56 c3 ff
0045h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> rangeBytes => new byte[70]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0x41,0x2B,0xD0,0x85,0xD2,0x7D,0x06,0xF7,0xDA,0x85,0xD2,0x7C,0x2B,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBF,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBF,0xC0,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xC3,0x56,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint range(uint src, BitPos i0, BitPos i1)
; location: [7FFDD9B5C640h, 7FFDD9B5C677h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
000bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000dh jge short 0015h               ; JGE(Jge_rel8_64) [15h:jmp64]                         encoding(2 bytes) = 7d 06
000fh neg edx                       ; NEG(Neg_rm32) [EDX]                                  encoding(2 bytes) = f7 da
0011h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0013h jl short 0032h                ; JL(Jl_rel8_64) [32h:jmp64]                           encoding(2 bytes) = 7c 1d
0015h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0017h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0023h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0025h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0028h bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
002dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0031h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0032h call 7FFDD9791CE8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC356A8h:jmp64]        encoding(5 bytes) = e8 71 56 c3 ff
0037h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> rangeBytes => new byte[56]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0x41,0x2B,0xD0,0x85,0xD2,0x7D,0x06,0xF7,0xDA,0x85,0xD2,0x7C,0x1D,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x71,0x56,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int range(int src, BitPos i0, BitPos i1)
; location: [7FFDD9B5C690h, 7FFDD9B5C6C7h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
000bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000dh jge short 0015h               ; JGE(Jge_rel8_64) [15h:jmp64]                         encoding(2 bytes) = 7d 06
000fh neg edx                       ; NEG(Neg_rm32) [EDX]                                  encoding(2 bytes) = f7 da
0011h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0013h jl short 0032h                ; JL(Jl_rel8_64) [32h:jmp64]                           encoding(2 bytes) = 7c 1d
0015h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0017h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0023h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0025h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0028h bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
002dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0031h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0032h call 7FFDD9791CE8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC35658h:jmp64]        encoding(5 bytes) = e8 21 56 c3 ff
0037h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> rangeBytes => new byte[56]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0x41,0x2B,0xD0,0x85,0xD2,0x7D,0x06,0xF7,0xDA,0x85,0xD2,0x7C,0x1D,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x21,0x56,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long range(long src, BitPos i0, BitPos i1)
; location: [7FFDD9B5C6E0h, 7FFDD9B5C717h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
000bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000dh jge short 0015h               ; JGE(Jge_rel8_64) [15h:jmp64]                         encoding(2 bytes) = 7d 06
000fh neg edx                       ; NEG(Neg_rm32) [EDX]                                  encoding(2 bytes) = f7 da
0011h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0013h jl short 0032h                ; JL(Jl_rel8_64) [32h:jmp64]                           encoding(2 bytes) = 7c 1d
0015h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0017h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0023h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0025h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0028h bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
002dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0031h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0032h call 7FFDD9791CE8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC35608h:jmp64]        encoding(5 bytes) = e8 d1 55 c3 ff
0037h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> rangeBytes => new byte[56]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0x41,0x2B,0xD0,0x85,0xD2,0x7D,0x06,0xF7,0xDA,0x85,0xD2,0x7C,0x1D,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xD1,0x55,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong range(ulong src, BitPos i0, BitPos i1)
; location: [7FFDD9B5C730h, 7FFDD9B5C767h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
000bh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
000dh jge short 0015h               ; JGE(Jge_rel8_64) [15h:jmp64]                         encoding(2 bytes) = 7d 06
000fh neg edx                       ; NEG(Neg_rm32) [EDX]                                  encoding(2 bytes) = f7 da
0011h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0013h jl short 0032h                ; JL(Jl_rel8_64) [32h:jmp64]                           encoding(2 bytes) = 7c 1d
0015h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0017h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
001ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0020h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0023h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0025h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0028h bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
002dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0031h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0032h call 7FFDD9791CE8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC355B8h:jmp64]        encoding(5 bytes) = e8 81 55 c3 ff
0037h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> rangeBytes => new byte[56]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0x41,0x2B,0xD0,0x85,0xD2,0x7D,0x06,0xF7,0xDA,0x85,0xD2,0x7C,0x1D,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x81,0x55,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float range(float src, BitPos i0, BitPos i1)
; location: [7FFDD9B5C780h, 7FFDD9B5C7CDh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovss dword ptr [rsp+24h],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 24
000dh mov eax,[rsp+24h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 24
0011h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
0014h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
0017h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0019h jge short 0021h               ; JGE(Jge_rel8_64) [21h:jmp64]                         encoding(2 bytes) = 7d 06
001bh neg edx                       ; NEG(Neg_rm32) [EDX]                                  encoding(2 bytes) = f7 da
001dh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
001fh jl short 0048h                ; JL(Jl_rel8_64) [48h:jmp64]                           encoding(2 bytes) = 7c 27
0021h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0023h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
0026h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0029h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
002ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
002fh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0031h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0034h bextr eax,eax,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EAX,EDX]          encoding(VEX, 5 bytes) = c4 e2 68 f7 c0
0039h mov [rsp+20h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 20
003dh vmovss xmm0,dword ptr [rsp+20h]; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 20
0043h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0047h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0048h call 7FFDD9791CE8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC35568h:jmp64]        encoding(5 bytes) = e8 1b 55 c3 ff
004dh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> rangeBytes => new byte[78]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xFA,0x11,0x44,0x24,0x24,0x8B,0x44,0x24,0x24,0x0F,0xB6,0xCA,0x41,0x2B,0xD0,0x85,0xD2,0x7D,0x06,0xF7,0xDA,0x85,0xD2,0x7C,0x27,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xC9,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0x68,0xF7,0xC0,0x89,0x44,0x24,0x20,0xC5,0xFA,0x10,0x44,0x24,0x20,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x1B,0x55,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double range(double src, BitPos i0, BitPos i1)
; location: [7FFDD9B5C7F0h, 7FFDD9B5C83Fh]
0000h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+30h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 30
000dh mov rax,[rsp+30h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 30
0012h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
0015h sub edx,r8d                   ; SUB(Sub_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 2b d0
0018h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
001ah jge short 0022h               ; JGE(Jge_rel8_64) [22h:jmp64]                         encoding(2 bytes) = 7d 06
001ch neg edx                       ; NEG(Neg_rm32) [EDX]                                  encoding(2 bytes) = f7 da
001eh test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0020h jl short 004ah                ; JL(Jl_rel8_64) [4Ah:jmp64]                           encoding(2 bytes) = 7c 28
0022h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0024h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
0027h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
002ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
002dh shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0030h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0032h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0035h bextr rax,rax,rdx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RAX,RDX]          encoding(VEX, 5 bytes) = c4 e2 e8 f7 c0
003ah mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
003fh vmovsd xmm0,qword ptr [rsp+28h]; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 28
0045h add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
0049h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
004ah call 7FFDD9791CE8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC354F8h:jmp64]        encoding(5 bytes) = e8 a9 54 c3 ff
004fh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> rangeBytes => new byte[80]{0x48,0x83,0xEC,0x38,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x30,0x48,0x8B,0x44,0x24,0x30,0x0F,0xB6,0xCA,0x41,0x2B,0xD0,0x85,0xD2,0x7D,0x06,0xF7,0xDA,0x85,0xD2,0x7C,0x28,0xFF,0xC2,0x48,0x63,0xD2,0x0F,0xB6,0xC9,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0xE8,0xF7,0xC0,0x48,0x89,0x44,0x24,0x28,0xC5,0xFB,0x10,0x44,0x24,0x28,0x48,0x83,0xC4,0x38,0xC3,0xE8,0xA9,0x54,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rank(byte src, int pos)
; location: [7FFDD9B5C860h, 7FFDD9B5C89Bh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000ah test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ch jge short 0014h               ; JGE(Jge_rel8_64) [14h:jmp64]                         encoding(2 bytes) = 7d 06
000eh neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0010h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0012h jl short 0036h                ; JL(Jl_rel8_64) [36h:jmp64]                           encoding(2 bytes) = 7c 22
0014h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0016h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
0019h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ch shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
001fh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0022h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
0025h bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
002ah movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002dh popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
0031h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0035h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0036h call 7FFDD9791CE8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC35488h:jmp64]        encoding(5 bytes) = e8 4d 54 c3 ff
003bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> rankBytes => new byte[60]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0xF7,0xD8,0x85,0xC0,0x7D,0x06,0xF7,0xD8,0x85,0xC0,0x7C,0x22,0xFF,0xC0,0x48,0x63,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0x0F,0xB6,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB6,0xC0,0xF3,0x0F,0xB8,0xC0,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x4D,0x54,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rank(sbyte src, int pos)
; location: [7FFDD9B5C8B0h, 7FFDD9B5C8F3h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000ah test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ch jge short 0014h               ; JGE(Jge_rel8_64) [14h:jmp64]                         encoding(2 bytes) = 7d 06
000eh neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0010h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0012h jl short 003eh                ; JL(Jl_rel8_64) [3Eh:jmp64]                           encoding(2 bytes) = 7c 2a
0014h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0016h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
0019h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ch shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
001fh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0022h movsx rdx,cl                  ; MOVSX(Movsx_r64_rm8) [RDX,CL]                        encoding(4 bytes) = 48 0f be d1
0026h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0029h bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
002eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0031h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0035h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
0039h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
003dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003eh call 7FFDD9791CE8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC35438h:jmp64]        encoding(5 bytes) = e8 f5 53 c3 ff
0043h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> rankBytes => new byte[68]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0xF7,0xD8,0x85,0xC0,0x7D,0x06,0xF7,0xD8,0x85,0xC0,0x7C,0x2A,0xFF,0xC0,0x48,0x63,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0x48,0x0F,0xBE,0xD1,0x0F,0xB6,0xD2,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB6,0xC0,0x48,0x0F,0xBE,0xC0,0xF3,0x0F,0xB8,0xC0,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xF5,0x53,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rank(short src, int pos)
; location: [7FFDD9B5C910h, 7FFDD9B5C953h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000ah test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ch jge short 0014h               ; JGE(Jge_rel8_64) [14h:jmp64]                         encoding(2 bytes) = 7d 06
000eh neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0010h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0012h jl short 003eh                ; JL(Jl_rel8_64) [3Eh:jmp64]                           encoding(2 bytes) = 7c 2a
0014h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0016h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
0019h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ch shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
001fh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0022h movsx rdx,cx                  ; MOVSX(Movsx_r64_rm16) [RDX,CX]                       encoding(4 bytes) = 48 0f bf d1
0026h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0029h bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
002eh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0031h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0035h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
0039h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
003dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
003eh call 7FFDD9791CE8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC353D8h:jmp64]        encoding(5 bytes) = e8 95 53 c3 ff
0043h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> rankBytes => new byte[68]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0xF7,0xD8,0x85,0xC0,0x7D,0x06,0xF7,0xD8,0x85,0xC0,0x7C,0x2A,0xFF,0xC0,0x48,0x63,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0x48,0x0F,0xBF,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBF,0xC0,0xF3,0x0F,0xB8,0xC0,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x95,0x53,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rank(ushort src, int pos)
; location: [7FFDD9B5C970h, 7FFDD9B5C9ABh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000ah test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ch jge short 0014h               ; JGE(Jge_rel8_64) [14h:jmp64]                         encoding(2 bytes) = 7d 06
000eh neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0010h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0012h jl short 0036h                ; JL(Jl_rel8_64) [36h:jmp64]                           encoding(2 bytes) = 7c 22
0014h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0016h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
0019h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ch shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
001fh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0022h movzx edx,cx                  ; MOVZX(Movzx_r32_rm16) [EDX,CX]                       encoding(3 bytes) = 0f b7 d1
0025h bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
002ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
002dh popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
0031h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0035h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0036h call 7FFDD9791CE8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC35378h:jmp64]        encoding(5 bytes) = e8 3d 53 c3 ff
003bh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> rankBytes => new byte[60]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0xF7,0xD8,0x85,0xC0,0x7D,0x06,0xF7,0xD8,0x85,0xC0,0x7C,0x22,0xFF,0xC0,0x48,0x63,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0x0F,0xB7,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB7,0xC0,0xF3,0x0F,0xB8,0xC0,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x3D,0x53,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rank(int src, int pos)
; location: [7FFDD9B5C9C0h, 7FFDD9B5C9F5h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000ah test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ch jge short 0014h               ; JGE(Jge_rel8_64) [14h:jmp64]                         encoding(2 bytes) = 7d 06
000eh neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0010h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0012h jl short 0030h                ; JL(Jl_rel8_64) [30h:jmp64]                           encoding(2 bytes) = 7c 1c
0014h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0016h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
0019h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ch shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
001fh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0022h bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
0027h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
002bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0030h call 7FFDD9791CE8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC35328h:jmp64]        encoding(5 bytes) = e8 f3 52 c3 ff
0035h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> rankBytes => new byte[54]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0xF7,0xD8,0x85,0xC0,0x7D,0x06,0xF7,0xD8,0x85,0xC0,0x7C,0x1C,0xFF,0xC0,0x48,0x63,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xF3,0x0F,0xB8,0xC0,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xF3,0x52,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rank(uint src, int pos)
; location: [7FFDD9B5CA10h, 7FFDD9B5CA45h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000ah test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ch jge short 0014h               ; JGE(Jge_rel8_64) [14h:jmp64]                         encoding(2 bytes) = 7d 06
000eh neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0010h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0012h jl short 0030h                ; JL(Jl_rel8_64) [30h:jmp64]                           encoding(2 bytes) = 7c 1c
0014h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0016h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
0019h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ch shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
001fh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0022h bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
0027h popcnt eax,eax                ; POPCNT(Popcnt_r32_rm32) [EAX,EAX]                    encoding(4 bytes) = f3 0f b8 c0
002bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0030h call 7FFDD9791CE8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC352D8h:jmp64]        encoding(5 bytes) = e8 a3 52 c3 ff
0035h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> rankBytes => new byte[54]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0xF7,0xD8,0x85,0xC0,0x7D,0x06,0xF7,0xD8,0x85,0xC0,0x7C,0x1C,0xFF,0xC0,0x48,0x63,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xF3,0x0F,0xB8,0xC0,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xA3,0x52,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rank(long src, int pos)
; location: [7FFDD9B5CA60h, 7FFDD9B5CA96h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000ah test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ch jge short 0014h               ; JGE(Jge_rel8_64) [14h:jmp64]                         encoding(2 bytes) = 7d 06
000eh neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0010h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0012h jl short 0031h                ; JL(Jl_rel8_64) [31h:jmp64]                           encoding(2 bytes) = 7c 1d
0014h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0016h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
0019h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ch shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
001fh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0022h bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
0027h popcnt rax,rax                ; POPCNT(Popcnt_r64_rm64) [RAX,RAX]                    encoding(5 bytes) = f3 48 0f b8 c0
002ch add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0030h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0031h call 7FFDD9791CE8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC35288h:jmp64]        encoding(5 bytes) = e8 52 52 c3 ff
0036h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> rankBytes => new byte[55]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0xF7,0xD8,0x85,0xC0,0x7D,0x06,0xF7,0xD8,0x85,0xC0,0x7C,0x1D,0xFF,0xC0,0x48,0x63,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0xF3,0x48,0x0F,0xB8,0xC0,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x52,0x52,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rank(ulong src, int pos)
; location: [7FFDD9B5CAB0h, 7FFDD9B5CAE6h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
000ah test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000ch jge short 0014h               ; JGE(Jge_rel8_64) [14h:jmp64]                         encoding(2 bytes) = 7d 06
000eh neg eax                       ; NEG(Neg_rm32) [EAX]                                  encoding(2 bytes) = f7 d8
0010h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0012h jl short 0031h                ; JL(Jl_rel8_64) [31h:jmp64]                           encoding(2 bytes) = 7c 1d
0014h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0016h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
0019h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ch shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
001fh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0022h bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
0027h popcnt rax,rax                ; POPCNT(Popcnt_r64_rm64) [RAX,RAX]                    encoding(5 bytes) = f3 48 0f b8 c0
002ch add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0030h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0031h call 7FFDD9791CE8h            ; CALL(Call_rel32_64) [FFFFFFFFFFC35238h:jmp64]        encoding(5 bytes) = e8 02 52 c3 ff
0036h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> rankBytes => new byte[55]{0x48,0x83,0xEC,0x28,0x90,0x0F,0xB6,0xC2,0xF7,0xD8,0x85,0xC0,0x7D,0x06,0xF7,0xD8,0x85,0xC0,0x7C,0x1D,0xFF,0xC0,0x48,0x63,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0xF3,0x48,0x0F,0xB8,0xC0,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x02,0x52,0xC3,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte rev(byte src)
; location: [7FFDD9B5CB00h, 7FFDD9B5CB33h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov edx,80200802h             ; MOV(Mov_r32_imm32) [EDX,80200802h:imm32]             encoding(5 bytes) = ba 02 08 20 80
000dh imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
0011h mov rdx,884422110h            ; MOV(Mov_r64_imm64) [RDX,884422110h:imm64]            encoding(10 bytes) = 48 ba 10 21 42 84 08 00 00 00
001bh and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
001eh mov rdx,101010101h            ; MOV(Mov_r64_imm64) [RDX,101010101h:imm64]            encoding(10 bytes) = 48 ba 01 01 01 01 01 00 00 00
0028h imul rax,rdx                  ; IMUL(Imul_r64_rm64) [RAX,RDX]                        encoding(4 bytes) = 48 0f af c2
002ch shr rax,20h                   ; SHR(Shr_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e8 20
0030h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> revBytes => new byte[52]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xBA,0x02,0x08,0x20,0x80,0x48,0x0F,0xAF,0xC2,0x48,0xBA,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x48,0x23,0xC2,0x48,0xBA,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x48,0x0F,0xAF,0xC2,0x48,0xC1,0xE8,0x20,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort rev(ushort src)
; location: [7FFDD9B5CB50h, 7FFDD9B5CBC1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000ah sar edx,8                     ; SAR(Sar_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 fa 08
000dh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0010h mov ecx,80200802h             ; MOV(Mov_r32_imm32) [ECX,80200802h:imm32]             encoding(5 bytes) = b9 02 08 20 80
0015h imul rdx,rcx                  ; IMUL(Imul_r64_rm64) [RDX,RCX]                        encoding(4 bytes) = 48 0f af d1
0019h mov rcx,884422110h            ; MOV(Mov_r64_imm64) [RCX,884422110h:imm64]            encoding(10 bytes) = 48 b9 10 21 42 84 08 00 00 00
0023h and rdx,rcx                   ; AND(And_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 23 d1
0026h mov rcx,101010101h            ; MOV(Mov_r64_imm64) [RCX,101010101h:imm64]            encoding(10 bytes) = 48 b9 01 01 01 01 01 00 00 00
0030h imul rdx,rcx                  ; IMUL(Imul_r64_rm64) [RDX,RCX]                        encoding(4 bytes) = 48 0f af d1
0034h shr rdx,20h                   ; SHR(Shr_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 ea 20
0038h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
003bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
003eh mov ecx,80200802h             ; MOV(Mov_r32_imm32) [ECX,80200802h:imm32]             encoding(5 bytes) = b9 02 08 20 80
0043h imul rax,rcx                  ; IMUL(Imul_r64_rm64) [RAX,RCX]                        encoding(4 bytes) = 48 0f af c1
0047h mov rcx,884422110h            ; MOV(Mov_r64_imm64) [RCX,884422110h:imm64]            encoding(10 bytes) = 48 b9 10 21 42 84 08 00 00 00
0051h and rax,rcx                   ; AND(And_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 23 c1
0054h mov rcx,101010101h            ; MOV(Mov_r64_imm64) [RCX,101010101h:imm64]            encoding(10 bytes) = 48 b9 01 01 01 01 01 00 00 00
005eh imul rax,rcx                  ; IMUL(Imul_r64_rm64) [RAX,RCX]                        encoding(4 bytes) = 48 0f af c1
0062h shr rax,20h                   ; SHR(Shr_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e8 20
0066h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0069h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
006ch or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
006eh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0071h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> revBytes => new byte[114]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xD0,0xC1,0xFA,0x08,0x0F,0xB6,0xD2,0xB9,0x02,0x08,0x20,0x80,0x48,0x0F,0xAF,0xD1,0x48,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x48,0x23,0xD1,0x48,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x48,0x0F,0xAF,0xD1,0x48,0xC1,0xEA,0x20,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0xB9,0x02,0x08,0x20,0x80,0x48,0x0F,0xAF,0xC1,0x48,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x48,0x23,0xC1,0x48,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x48,0x0F,0xAF,0xC1,0x48,0xC1,0xE8,0x20,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rev(uint src)
; location: [7FFDD9B5CBE0h, 7FFDD9B5CCCBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h shr eax,10h                   ; SHR(Shr_rm32_imm8) [EAX,10h:imm8]                    encoding(3 bytes) = c1 e8 10
000ah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000dh mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000fh sar edx,8                     ; SAR(Sar_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 fa 08
0012h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0015h mov r8d,80200802h             ; MOV(Mov_r32_imm32) [R8D,80200802h:imm32]             encoding(6 bytes) = 41 b8 02 08 20 80
001bh imul rdx,r8                   ; IMUL(Imul_r64_rm64) [RDX,R8]                         encoding(4 bytes) = 49 0f af d0
001fh mov r8,884422110h             ; MOV(Mov_r64_imm64) [R8,884422110h:imm64]             encoding(10 bytes) = 49 b8 10 21 42 84 08 00 00 00
0029h and rdx,r8                    ; AND(And_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 23 d0
002ch mov r8,101010101h             ; MOV(Mov_r64_imm64) [R8,101010101h:imm64]             encoding(10 bytes) = 49 b8 01 01 01 01 01 00 00 00
0036h imul rdx,r8                   ; IMUL(Imul_r64_rm64) [RDX,R8]                         encoding(4 bytes) = 49 0f af d0
003ah shr rdx,20h                   ; SHR(Shr_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 ea 20
003eh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0041h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0044h mov r8d,80200802h             ; MOV(Mov_r32_imm32) [R8D,80200802h:imm32]             encoding(6 bytes) = 41 b8 02 08 20 80
004ah imul rax,r8                   ; IMUL(Imul_r64_rm64) [RAX,R8]                         encoding(4 bytes) = 49 0f af c0
004eh mov r8,884422110h             ; MOV(Mov_r64_imm64) [R8,884422110h:imm64]             encoding(10 bytes) = 49 b8 10 21 42 84 08 00 00 00
0058h and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
005bh mov r8,101010101h             ; MOV(Mov_r64_imm64) [R8,101010101h:imm64]             encoding(10 bytes) = 49 b8 01 01 01 01 01 00 00 00
0065h imul rax,r8                   ; IMUL(Imul_r64_rm64) [RAX,R8]                         encoding(4 bytes) = 49 0f af c0
0069h shr rax,20h                   ; SHR(Shr_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e8 20
006dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0070h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0073h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0075h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0078h movzx edx,cx                  ; MOVZX(Movzx_r32_rm16) [EDX,CX]                       encoding(3 bytes) = 0f b7 d1
007bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
007dh sar ecx,8                     ; SAR(Sar_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 f9 08
0080h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0083h mov r8d,80200802h             ; MOV(Mov_r32_imm32) [R8D,80200802h:imm32]             encoding(6 bytes) = 41 b8 02 08 20 80
0089h imul rcx,r8                   ; IMUL(Imul_r64_rm64) [RCX,R8]                         encoding(4 bytes) = 49 0f af c8
008dh mov r8,884422110h             ; MOV(Mov_r64_imm64) [R8,884422110h:imm64]             encoding(10 bytes) = 49 b8 10 21 42 84 08 00 00 00
0097h and rcx,r8                    ; AND(And_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 23 c8
009ah mov r8,101010101h             ; MOV(Mov_r64_imm64) [R8,101010101h:imm64]             encoding(10 bytes) = 49 b8 01 01 01 01 01 00 00 00
00a4h imul rcx,r8                   ; IMUL(Imul_r64_rm64) [RCX,R8]                         encoding(4 bytes) = 49 0f af c8
00a8h shr rcx,20h                   ; SHR(Shr_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 e9 20
00ach movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
00afh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
00b2h mov r8d,80200802h             ; MOV(Mov_r32_imm32) [R8D,80200802h:imm32]             encoding(6 bytes) = 41 b8 02 08 20 80
00b8h imul rdx,r8                   ; IMUL(Imul_r64_rm64) [RDX,R8]                         encoding(4 bytes) = 49 0f af d0
00bch mov r8,884422110h             ; MOV(Mov_r64_imm64) [R8,884422110h:imm64]             encoding(10 bytes) = 49 b8 10 21 42 84 08 00 00 00
00c6h and rdx,r8                    ; AND(And_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 23 d0
00c9h mov r8,101010101h             ; MOV(Mov_r64_imm64) [R8,101010101h:imm64]             encoding(10 bytes) = 49 b8 01 01 01 01 01 00 00 00
00d3h imul rdx,r8                   ; IMUL(Imul_r64_rm64) [RDX,R8]                         encoding(4 bytes) = 49 0f af d0
00d7h shr rdx,20h                   ; SHR(Shr_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 ea 20
00dbh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
00deh shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
00e1h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
00e3h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
00e6h shl edx,10h                   ; SHL(Shl_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 e2 10
00e9h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
00ebh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> revBytes => new byte[236]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xC1,0xE8,0x10,0x0F,0xB7,0xC0,0x8B,0xD0,0xC1,0xFA,0x08,0x0F,0xB6,0xD2,0x41,0xB8,0x02,0x08,0x20,0x80,0x49,0x0F,0xAF,0xD0,0x49,0xB8,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x49,0x23,0xD0,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x49,0x0F,0xAF,0xD0,0x48,0xC1,0xEA,0x20,0x0F,0xB6,0xD2,0x0F,0xB6,0xC0,0x41,0xB8,0x02,0x08,0x20,0x80,0x49,0x0F,0xAF,0xC0,0x49,0xB8,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x49,0x23,0xC0,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x49,0x0F,0xAF,0xC0,0x48,0xC1,0xE8,0x20,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB7,0xD1,0x8B,0xCA,0xC1,0xF9,0x08,0x0F,0xB6,0xC9,0x41,0xB8,0x02,0x08,0x20,0x80,0x49,0x0F,0xAF,0xC8,0x49,0xB8,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x49,0x23,0xC8,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x49,0x0F,0xAF,0xC8,0x48,0xC1,0xE9,0x20,0x0F,0xB6,0xC9,0x0F,0xB6,0xD2,0x41,0xB8,0x02,0x08,0x20,0x80,0x49,0x0F,0xAF,0xD0,0x49,0xB8,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x49,0x23,0xD0,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x49,0x0F,0xAF,0xD0,0x48,0xC1,0xEA,0x20,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x0B,0xD1,0x0F,0xB7,0xD2,0xC1,0xE2,0x10,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rev2(uint x)
; location: [7FFDD9B5CCE0h, 7FFDD9B5CD3Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,0AAAAAAAAh            ; AND(And_EAX_imm32) [EAX,aaaaaaaah:imm32]             encoding(5 bytes) = 25 aa aa aa aa
000ch shr eax,1                     ; SHR(Shr_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 e8
000eh and ecx,55555555h             ; AND(And_rm32_imm32) [ECX,55555555h:imm32]            encoding(6 bytes) = 81 e1 55 55 55 55
0014h shl ecx,1                     ; SHL(Shl_rm32_1) [ECX,1h:imm8]                        encoding(2 bytes) = d1 e1
0016h or ecx,eax                    ; OR(Or_r32_rm32) [ECX,EAX]                            encoding(2 bytes) = 0b c8
0018h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
001ah and eax,0CCCCCCCCh            ; AND(And_EAX_imm32) [EAX,cccccccch:imm32]             encoding(5 bytes) = 25 cc cc cc cc
001fh shr eax,2                     ; SHR(Shr_rm32_imm8) [EAX,2h:imm8]                     encoding(3 bytes) = c1 e8 02
0022h and ecx,33333333h             ; AND(And_rm32_imm32) [ECX,33333333h:imm32]            encoding(6 bytes) = 81 e1 33 33 33 33
0028h shl ecx,2                     ; SHL(Shl_rm32_imm8) [ECX,2h:imm8]                     encoding(3 bytes) = c1 e1 02
002bh or ecx,eax                    ; OR(Or_r32_rm32) [ECX,EAX]                            encoding(2 bytes) = 0b c8
002dh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
002fh and eax,0F0F0F0F0h            ; AND(And_EAX_imm32) [EAX,f0f0f0f0h:imm32]             encoding(5 bytes) = 25 f0 f0 f0 f0
0034h shr eax,4                     ; SHR(Shr_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e8 04
0037h and ecx,0F0F0F0Fh             ; AND(And_rm32_imm32) [ECX,f0f0f0fh:imm32]             encoding(6 bytes) = 81 e1 0f 0f 0f 0f
003dh shl ecx,4                     ; SHL(Shl_rm32_imm8) [ECX,4h:imm8]                     encoding(3 bytes) = c1 e1 04
0040h or ecx,eax                    ; OR(Or_r32_rm32) [ECX,EAX]                            encoding(2 bytes) = 0b c8
0042h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0044h and eax,0FF00FF00h            ; AND(And_EAX_imm32) [EAX,ff00ff00h:imm32]             encoding(5 bytes) = 25 00 ff 00 ff
0049h shr eax,8                     ; SHR(Shr_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e8 08
004ch and ecx,0FF00FFh              ; AND(And_rm32_imm32) [ECX,ff00ffh:imm32]              encoding(6 bytes) = 81 e1 ff 00 ff 00
0052h shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
0055h or ecx,eax                    ; OR(Or_r32_rm32) [ECX,EAX]                            encoding(2 bytes) = 0b c8
0057h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0059h rol eax,10h                   ; ROL(Rol_rm32_imm8) [EAX,10h:imm8]                    encoding(3 bytes) = c1 c0 10
005ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rev2Bytes => new byte[93]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x25,0xAA,0xAA,0xAA,0xAA,0xD1,0xE8,0x81,0xE1,0x55,0x55,0x55,0x55,0xD1,0xE1,0x0B,0xC8,0x8B,0xC1,0x25,0xCC,0xCC,0xCC,0xCC,0xC1,0xE8,0x02,0x81,0xE1,0x33,0x33,0x33,0x33,0xC1,0xE1,0x02,0x0B,0xC8,0x8B,0xC1,0x25,0xF0,0xF0,0xF0,0xF0,0xC1,0xE8,0x04,0x81,0xE1,0x0F,0x0F,0x0F,0x0F,0xC1,0xE1,0x04,0x0B,0xC8,0x8B,0xC1,0x25,0x00,0xFF,0x00,0xFF,0xC1,0xE8,0x08,0x81,0xE1,0xFF,0x00,0xFF,0x00,0xC1,0xE1,0x08,0x0B,0xC8,0x8B,0xC1,0xC1,0xC0,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong rev(ulong src)
; location: [7FFDD9B5CD50h, 7FFDD9B5CF47h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h shr rax,20h                   ; SHR(Shr_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e8 20
000ch mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000eh shr edx,10h                   ; SHR(Shr_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 ea 10
0011h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0014h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0017h sar r8d,8                     ; SAR(Sar_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 f8 08
001bh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001fh mov r9d,80200802h             ; MOV(Mov_r32_imm32) [R9D,80200802h:imm32]             encoding(6 bytes) = 41 b9 02 08 20 80
0025h imul r8,r9                    ; IMUL(Imul_r64_rm64) [R8,R9]                          encoding(4 bytes) = 4d 0f af c1
0029h mov r9,884422110h             ; MOV(Mov_r64_imm64) [R9,884422110h:imm64]             encoding(10 bytes) = 49 b9 10 21 42 84 08 00 00 00
0033h and r8,r9                     ; AND(And_r64_rm64) [R8,R9]                            encoding(3 bytes) = 4d 23 c1
0036h mov r9,101010101h             ; MOV(Mov_r64_imm64) [R9,101010101h:imm64]             encoding(10 bytes) = 49 b9 01 01 01 01 01 00 00 00
0040h imul r8,r9                    ; IMUL(Imul_r64_rm64) [R8,R9]                          encoding(4 bytes) = 4d 0f af c1
0044h shr r8,20h                    ; SHR(Shr_rm64_imm8) [R8,20h:imm8]                     encoding(4 bytes) = 49 c1 e8 20
0048h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
004ch movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
004fh mov r9d,80200802h             ; MOV(Mov_r32_imm32) [R9D,80200802h:imm32]             encoding(6 bytes) = 41 b9 02 08 20 80
0055h imul rdx,r9                   ; IMUL(Imul_r64_rm64) [RDX,R9]                         encoding(4 bytes) = 49 0f af d1
0059h mov r9,884422110h             ; MOV(Mov_r64_imm64) [R9,884422110h:imm64]             encoding(10 bytes) = 49 b9 10 21 42 84 08 00 00 00
0063h and rdx,r9                    ; AND(And_r64_rm64) [RDX,R9]                           encoding(3 bytes) = 49 23 d1
0066h mov r9,101010101h             ; MOV(Mov_r64_imm64) [R9,101010101h:imm64]             encoding(10 bytes) = 49 b9 01 01 01 01 01 00 00 00
0070h imul rdx,r9                   ; IMUL(Imul_r64_rm64) [RDX,R9]                         encoding(4 bytes) = 49 0f af d1
0074h shr rdx,20h                   ; SHR(Shr_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 ea 20
0078h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
007bh shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
007eh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0081h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0084h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0087h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
008ah sar r8d,8                     ; SAR(Sar_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 f8 08
008eh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0092h mov r9d,80200802h             ; MOV(Mov_r32_imm32) [R9D,80200802h:imm32]             encoding(6 bytes) = 41 b9 02 08 20 80
0098h imul r8,r9                    ; IMUL(Imul_r64_rm64) [R8,R9]                          encoding(4 bytes) = 4d 0f af c1
009ch mov r9,884422110h             ; MOV(Mov_r64_imm64) [R9,884422110h:imm64]             encoding(10 bytes) = 49 b9 10 21 42 84 08 00 00 00
00a6h and r8,r9                     ; AND(And_r64_rm64) [R8,R9]                            encoding(3 bytes) = 4d 23 c1
00a9h mov r9,101010101h             ; MOV(Mov_r64_imm64) [R9,101010101h:imm64]             encoding(10 bytes) = 49 b9 01 01 01 01 01 00 00 00
00b3h imul r8,r9                    ; IMUL(Imul_r64_rm64) [R8,R9]                          encoding(4 bytes) = 4d 0f af c1
00b7h shr r8,20h                    ; SHR(Shr_rm64_imm8) [R8,20h:imm8]                     encoding(4 bytes) = 49 c1 e8 20
00bbh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
00bfh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00c2h mov r9d,80200802h             ; MOV(Mov_r32_imm32) [R9D,80200802h:imm32]             encoding(6 bytes) = 41 b9 02 08 20 80
00c8h imul rax,r9                   ; IMUL(Imul_r64_rm64) [RAX,R9]                         encoding(4 bytes) = 49 0f af c1
00cch mov r9,884422110h             ; MOV(Mov_r64_imm64) [R9,884422110h:imm64]             encoding(10 bytes) = 49 b9 10 21 42 84 08 00 00 00
00d6h and rax,r9                    ; AND(And_r64_rm64) [RAX,R9]                           encoding(3 bytes) = 49 23 c1
00d9h mov r9,101010101h             ; MOV(Mov_r64_imm64) [R9,101010101h:imm64]             encoding(10 bytes) = 49 b9 01 01 01 01 01 00 00 00
00e3h imul rax,r9                   ; IMUL(Imul_r64_rm64) [RAX,R9]                         encoding(4 bytes) = 49 0f af c1
00e7h shr rax,20h                   ; SHR(Shr_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e8 20
00ebh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00eeh shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
00f1h or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
00f4h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
00f7h shl eax,10h                   ; SHL(Shl_rm32_imm8) [EAX,10h:imm8]                    encoding(3 bytes) = c1 e0 10
00fah or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
00fch mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
00feh shr edx,10h                   ; SHR(Shr_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 ea 10
0101h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0104h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0107h sar r8d,8                     ; SAR(Sar_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 f8 08
010bh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
010fh mov r9d,80200802h             ; MOV(Mov_r32_imm32) [R9D,80200802h:imm32]             encoding(6 bytes) = 41 b9 02 08 20 80
0115h imul r8,r9                    ; IMUL(Imul_r64_rm64) [R8,R9]                          encoding(4 bytes) = 4d 0f af c1
0119h mov r9,884422110h             ; MOV(Mov_r64_imm64) [R9,884422110h:imm64]             encoding(10 bytes) = 49 b9 10 21 42 84 08 00 00 00
0123h and r8,r9                     ; AND(And_r64_rm64) [R8,R9]                            encoding(3 bytes) = 4d 23 c1
0126h mov r9,101010101h             ; MOV(Mov_r64_imm64) [R9,101010101h:imm64]             encoding(10 bytes) = 49 b9 01 01 01 01 01 00 00 00
0130h imul r8,r9                    ; IMUL(Imul_r64_rm64) [R8,R9]                          encoding(4 bytes) = 4d 0f af c1
0134h shr r8,20h                    ; SHR(Shr_rm64_imm8) [R8,20h:imm8]                     encoding(4 bytes) = 49 c1 e8 20
0138h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
013ch movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
013fh mov r9d,80200802h             ; MOV(Mov_r32_imm32) [R9D,80200802h:imm32]             encoding(6 bytes) = 41 b9 02 08 20 80
0145h imul rdx,r9                   ; IMUL(Imul_r64_rm64) [RDX,R9]                         encoding(4 bytes) = 49 0f af d1
0149h mov r9,884422110h             ; MOV(Mov_r64_imm64) [R9,884422110h:imm64]             encoding(10 bytes) = 49 b9 10 21 42 84 08 00 00 00
0153h and rdx,r9                    ; AND(And_r64_rm64) [RDX,R9]                           encoding(3 bytes) = 49 23 d1
0156h mov r9,101010101h             ; MOV(Mov_r64_imm64) [R9,101010101h:imm64]             encoding(10 bytes) = 49 b9 01 01 01 01 01 00 00 00
0160h imul rdx,r9                   ; IMUL(Imul_r64_rm64) [RDX,R9]                         encoding(4 bytes) = 49 0f af d1
0164h shr rdx,20h                   ; SHR(Shr_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 ea 20
0168h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
016bh shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
016eh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0171h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0174h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
0177h mov r8d,ecx                   ; MOV(Mov_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 8b c1
017ah sar r8d,8                     ; SAR(Sar_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 f8 08
017eh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0182h mov r9d,80200802h             ; MOV(Mov_r32_imm32) [R9D,80200802h:imm32]             encoding(6 bytes) = 41 b9 02 08 20 80
0188h imul r8,r9                    ; IMUL(Imul_r64_rm64) [R8,R9]                          encoding(4 bytes) = 4d 0f af c1
018ch mov r9,884422110h             ; MOV(Mov_r64_imm64) [R9,884422110h:imm64]             encoding(10 bytes) = 49 b9 10 21 42 84 08 00 00 00
0196h and r8,r9                     ; AND(And_r64_rm64) [R8,R9]                            encoding(3 bytes) = 4d 23 c1
0199h mov r9,101010101h             ; MOV(Mov_r64_imm64) [R9,101010101h:imm64]             encoding(10 bytes) = 49 b9 01 01 01 01 01 00 00 00
01a3h imul r8,r9                    ; IMUL(Imul_r64_rm64) [R8,R9]                          encoding(4 bytes) = 4d 0f af c1
01a7h shr r8,20h                    ; SHR(Shr_rm64_imm8) [R8,20h:imm8]                     encoding(4 bytes) = 49 c1 e8 20
01abh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
01afh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
01b2h mov r9d,80200802h             ; MOV(Mov_r32_imm32) [R9D,80200802h:imm32]             encoding(6 bytes) = 41 b9 02 08 20 80
01b8h imul rcx,r9                   ; IMUL(Imul_r64_rm64) [RCX,R9]                         encoding(4 bytes) = 49 0f af c9
01bch mov r9,884422110h             ; MOV(Mov_r64_imm64) [R9,884422110h:imm64]             encoding(10 bytes) = 49 b9 10 21 42 84 08 00 00 00
01c6h and rcx,r9                    ; AND(And_r64_rm64) [RCX,R9]                           encoding(3 bytes) = 49 23 c9
01c9h mov r9,101010101h             ; MOV(Mov_r64_imm64) [R9,101010101h:imm64]             encoding(10 bytes) = 49 b9 01 01 01 01 01 00 00 00
01d3h imul rcx,r9                   ; IMUL(Imul_r64_rm64) [RCX,R9]                         encoding(4 bytes) = 49 0f af c9
01d7h shr rcx,20h                   ; SHR(Shr_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 e9 20
01dbh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
01deh shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
01e1h or ecx,r8d                    ; OR(Or_r32_rm32) [ECX,R8D]                            encoding(3 bytes) = 41 0b c8
01e4h movzx ecx,cx                  ; MOVZX(Movzx_r32_rm16) [ECX,CX]                       encoding(3 bytes) = 0f b7 c9
01e7h shl ecx,10h                   ; SHL(Shl_rm32_imm8) [ECX,10h:imm8]                    encoding(3 bytes) = c1 e1 10
01eah or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
01ech mov eax,eax                   ; MOV(Mov_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 8b c0
01eeh mov edx,edx                   ; MOV(Mov_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 8b d2
01f0h shl rdx,20h                   ; SHL(Shl_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 e2 20
01f4h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
01f7h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> revBytes => new byte[504]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xC1,0xE8,0x20,0x8B,0xD0,0xC1,0xEA,0x10,0x0F,0xB7,0xD2,0x44,0x8B,0xC2,0x41,0xC1,0xF8,0x08,0x45,0x0F,0xB6,0xC0,0x41,0xB9,0x02,0x08,0x20,0x80,0x4D,0x0F,0xAF,0xC1,0x49,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x4D,0x23,0xC1,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x4D,0x0F,0xAF,0xC1,0x49,0xC1,0xE8,0x20,0x45,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x41,0xB9,0x02,0x08,0x20,0x80,0x49,0x0F,0xAF,0xD1,0x49,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x49,0x23,0xD1,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x49,0x0F,0xAF,0xD1,0x48,0xC1,0xEA,0x20,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0x0F,0xB7,0xC0,0x44,0x8B,0xC0,0x41,0xC1,0xF8,0x08,0x45,0x0F,0xB6,0xC0,0x41,0xB9,0x02,0x08,0x20,0x80,0x4D,0x0F,0xAF,0xC1,0x49,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x4D,0x23,0xC1,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x4D,0x0F,0xAF,0xC1,0x49,0xC1,0xE8,0x20,0x45,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x41,0xB9,0x02,0x08,0x20,0x80,0x49,0x0F,0xAF,0xC1,0x49,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x49,0x23,0xC1,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x49,0x0F,0xAF,0xC1,0x48,0xC1,0xE8,0x20,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x41,0x0B,0xC0,0x0F,0xB7,0xC0,0xC1,0xE0,0x10,0x0B,0xC2,0x8B,0xD1,0xC1,0xEA,0x10,0x0F,0xB7,0xD2,0x44,0x8B,0xC2,0x41,0xC1,0xF8,0x08,0x45,0x0F,0xB6,0xC0,0x41,0xB9,0x02,0x08,0x20,0x80,0x4D,0x0F,0xAF,0xC1,0x49,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x4D,0x23,0xC1,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x4D,0x0F,0xAF,0xC1,0x49,0xC1,0xE8,0x20,0x45,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x41,0xB9,0x02,0x08,0x20,0x80,0x49,0x0F,0xAF,0xD1,0x49,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x49,0x23,0xD1,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x49,0x0F,0xAF,0xD1,0x48,0xC1,0xEA,0x20,0x0F,0xB6,0xD2,0xC1,0xE2,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0x0F,0xB7,0xC9,0x44,0x8B,0xC1,0x41,0xC1,0xF8,0x08,0x45,0x0F,0xB6,0xC0,0x41,0xB9,0x02,0x08,0x20,0x80,0x4D,0x0F,0xAF,0xC1,0x49,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x4D,0x23,0xC1,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x4D,0x0F,0xAF,0xC1,0x49,0xC1,0xE8,0x20,0x45,0x0F,0xB6,0xC0,0x0F,0xB6,0xC9,0x41,0xB9,0x02,0x08,0x20,0x80,0x49,0x0F,0xAF,0xC9,0x49,0xB9,0x10,0x21,0x42,0x84,0x08,0x00,0x00,0x00,0x49,0x23,0xC9,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x00,0x00,0x00,0x49,0x0F,0xAF,0xC9,0x48,0xC1,0xE9,0x20,0x0F,0xB6,0xC9,0xC1,0xE1,0x08,0x41,0x0B,0xC8,0x0F,0xB7,0xC9,0xC1,0xE1,0x10,0x0B,0xD1,0x8B,0xC0,0x8B,0xD2,0x48,0xC1,0xE2,0x20,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte rotl(byte src, byte offset)
; location: [7FFDD9B5CF60h, 7FFDD9B5CF82h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0015h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0017h add ecx,8                     ; ADD(Add_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 c1 08
001ah sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
001ch or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
001fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE0,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x08,0xD3,0xF8,0x41,0x0B,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort rotl(ushort src, ushort offset)
; location: [7FFDD9B5CFA0h, 7FFDD9B5CFC2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
0010h shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0013h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0015h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0017h add ecx,10h                   ; ADD(Add_rm32_imm8) [ECX,10h:imm32]                   encoding(3 bytes) = 83 c1 10
001ah sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
001ch or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
001fh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE0,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x10,0xD3,0xF8,0x41,0x0B,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rotl(uint src, uint offset)
; location: [7FFDD9B5CFE0h, 7FFDD9B5CFEBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h rol eax,cl                    ; ROL(Rol_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong rotl(ulong src, ulong offset)
; location: [7FFDD9B5D000h, 7FFDD9B5D00Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah rol rax,cl                    ; ROL(Rol_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte rotl(byte src, int offset)
; location: [7FFDD9B5D020h, 7FFDD9B5D03Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000dh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0010h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0012h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0014h add ecx,8                     ; ADD(Add_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 c1 08
0017h sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
0019h or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE0,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x08,0xD3,0xF8,0x41,0x0B,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort rotl(ushort src, int offset)
; location: [7FFDD9B5D050h, 7FFDD9B5D06Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000dh shl r8d,cl                    ; SHL(Shl_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 e0
0010h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0012h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0014h add ecx,10h                   ; ADD(Add_rm32_imm8) [ECX,10h:imm32]                   encoding(3 bytes) = 83 c1 10
0017h sar eax,cl                    ; SAR(Sar_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 f8
0019h or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
001ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xE0,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x10,0xD3,0xF8,0x41,0x0B,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rotl(uint src, int offset)
; location: [7FFDD9B5D080h, 7FFDD9B5D08Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h rol eax,cl                    ; ROL(Rol_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong rotl(ulong src, int offset)
; location: [7FFDD9B5D0A0h, 7FFDD9B5D0ADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah rol rax,cl                    ; ROL(Rol_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotlBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte rotr(byte src, byte offset)
; location: [7FFDD9B5D0C0h, 7FFDD9B5D0E2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
0010h sar r8d,cl                    ; SAR(Sar_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 f8
0013h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0015h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0017h add ecx,8                     ; ADD(Add_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 c1 08
001ah shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
001ch or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
001fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xF8,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x08,0xD3,0xE0,0x41,0x0B,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte rotr(byte src, int offset)
; location: [7FFDD9B5D100h, 7FFDD9B5D11Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000dh sar r8d,cl                    ; SAR(Sar_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 f8
0010h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0012h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0014h add ecx,8                     ; ADD(Add_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 c1 08
0017h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
0019h or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xF8,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x08,0xD3,0xE0,0x41,0x0B,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort rotr(ushort src, ushort offset)
; location: [7FFDD9B5D130h, 7FFDD9B5D152h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
0010h sar r8d,cl                    ; SAR(Sar_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 f8
0013h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0015h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0017h add ecx,10h                   ; ADD(Add_rm32_imm8) [ECX,10h:imm32]                   encoding(3 bytes) = 83 c1 10
001ah shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
001ch or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
001fh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xF8,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x10,0xD3,0xE0,0x41,0x0B,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort rotr(ushort src, int offset)
; location: [7FFDD9B5D170h, 7FFDD9B5D18Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
000dh sar r8d,cl                    ; SAR(Sar_rm32_CL) [R8D,CL]                            encoding(3 bytes) = 41 d3 f8
0010h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0012h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0014h add ecx,10h                   ; ADD(Add_rm32_imm8) [ECX,10h:imm32]                   encoding(3 bytes) = 83 c1 10
0017h shl eax,cl                    ; SHL(Shl_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 e0
0019h or eax,r8d                    ; OR(Or_r32_rm32) [EAX,R8D]                            encoding(3 bytes) = 41 0b c0
001ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xCA,0x44,0x8B,0xC0,0x41,0xD3,0xF8,0x8B,0xCA,0xF7,0xD9,0x83,0xC1,0x10,0xD3,0xE0,0x41,0x0B,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rotr(uint src, uint offset)
; location: [7FFDD9B5D1A0h, 7FFDD9B5D1ABh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h ror eax,cl                    ; ROR(Ror_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint rotr(uint src, int offset)
; location: [7FFDD9B5D1C0h, 7FFDD9B5D1CBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h ror eax,cl                    ; ROR(Ror_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c8
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong rotr(ulong src, ulong offset)
; location: [7FFDD9B5D1E0h, 7FFDD9B5D1EDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah ror rax,cl                    ; ROR(Ror_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 c8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xC8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong rotr(ulong src, int offset)
; location: [7FFDD9B5D200h, 7FFDD9B5D20Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000ah ror rax,cl                    ; ROR(Ror_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 c8
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> rotrBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x8B,0xCA,0x48,0xD3,0xC8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte scatter(sbyte src, sbyte mask)
; location: [7FFDD9B5D220h, 7FFDD9B5D23Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000ch movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
0010h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0013h pdep eax,eax,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7b f5 c2
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x0F,0xB6,0xC0,0x48,0x0F,0xBE,0xD2,0x0F,0xB6,0xD2,0xC4,0xE2,0x7B,0xF5,0xC2,0x0F,0xB6,0xC0,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte scatter(byte src, byte mask)
; location: [7FFDD9B5D250h, 7FFDD9B5D263h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh pdep eax,eax,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7b f5 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x7B,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short scatter(short src, short mask)
; location: [7FFDD9B5D280h, 7FFDD9B5D29Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
000ch movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
0010h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0013h pdep eax,eax,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7b f5 c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x0F,0xB7,0xC0,0x48,0x0F,0xBF,0xD2,0x0F,0xB7,0xD2,0xC4,0xE2,0x7B,0xF5,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort scatter(ushort src, ushort mask)
; location: [7FFDD9B5D2B0h, 7FFDD9B5D2C3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh pdep eax,eax,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7b f5 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC4,0xE2,0x7B,0xF5,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int scatter(int src, int mask)
; location: [7FFDD9B5D2E0h, 7FFDD9B5D2EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint scatter(uint src, uint mask)
; location: [7FFDD9B5D300h, 7FFDD9B5D30Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long scatter(long src, long mask)
; location: [7FFDD9B5D320h, 7FFDD9B5D32Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep rax,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF3,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong scatter(ulong src, ulong mask)
; location: [7FFDD9B5D340h, 7FFDD9B5D34Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep rax,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> scatterBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF3,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte segment(sbyte src, int i0, int i1)
; location: [7FFDD9B5D360h, 7FFDD9B5D384h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0008h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000ch shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0012h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0014h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0017h movsx rdx,cl                  ; MOVSX(Movsx_r64_rm8) [RDX,CL]                        encoding(4 bytes) = 48 0f be d1
001bh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0020h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> segmentBytes => new byte[37]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x2B,0xC2,0x41,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBE,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte segment(byte src, int i0, int i1)
; location: [7FFDD9B5D3A0h, 7FFDD9B5D3C2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0008h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000ch shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0012h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0014h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0017h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
001ah bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
001fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> segmentBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x2B,0xC2,0x41,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB6,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort segment(ushort src, int i0, int i1)
; location: [7FFDD9B5D3E0h, 7FFDD9B5D402h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0008h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000ch shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0012h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0014h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0017h movzx edx,cx                  ; MOVZX(Movzx_r32_rm16) [EDX,CX]                       encoding(3 bytes) = 0f b7 d1
001ah bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
001fh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> segmentBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x2B,0xC2,0x41,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB7,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short segment(short src, int i0, int i1)
; location: [7FFDD9B5D420h, 7FFDD9B5D444h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0008h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000ch shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0012h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0014h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0017h movsx rdx,cx                  ; MOVSX(Movsx_r64_rm16) [RDX,CX]                       encoding(4 bytes) = 48 0f bf d1
001bh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0020h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> segmentBytes => new byte[37]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x2B,0xC2,0x41,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBF,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int segment(int src, int i0, int i1)
; location: [7FFDD9B5D460h, 7FFDD9B5D47Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0008h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000ch shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0012h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0014h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0017h bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> segmentBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x2B,0xC2,0x41,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint segment(uint src, int i0, int i1)
; location: [7FFDD9B5D490h, 7FFDD9B5D4ACh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0008h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000ch shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0012h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0014h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0017h bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> segmentBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x2B,0xC2,0x41,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long segment(long src, int i0, int i1)
; location: [7FFDD9B5D4C0h, 7FFDD9B5D4DCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0008h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000ch shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0012h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0014h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0017h bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> segmentBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x2B,0xC2,0x41,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong segment(ulong src, int i0, int i1)
; location: [7FFDD9B5D4F0h, 7FFDD9B5D50Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0008h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
000ch shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
000fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0012h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0014h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0017h bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> segmentBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x2B,0xC2,0x41,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0F,0xB6,0xD2,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float segment(float src, int i0, int i1)
; location: [7FFDD9B5D520h, 7FFDD9B5D552h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
000bh mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 04
000fh sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0012h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0016h shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
0019h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001ch or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
001eh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0021h bextr eax,eax,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EAX,EDX]          encoding(VEX, 5 bytes) = c4 e2 68 f7 c0
0026h mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
0029h vmovss xmm0,dword ptr [rsp]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 10 04 24
002eh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> segmentBytes => new byte[51]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFA,0x11,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0x44,0x2B,0xC2,0x41,0x0F,0xB6,0xC8,0xC1,0xE1,0x08,0x0F,0xB6,0xD2,0x0B,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0x68,0xF7,0xC0,0x89,0x04,0x24,0xC5,0xFA,0x10,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double segment(double src, int i0, int i1)
; location: [7FFDD9B5D570h, 7FFDD9B5D5A8h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
000dh mov rax,[rsp+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 10
0012h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0015h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0019h shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
001ch movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001fh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0021h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0024h bextr rax,rax,rdx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RAX,RDX]          encoding(VEX, 5 bytes) = c4 e2 e8 f7 c0
0029h mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 08
002eh vmovsd xmm0,qword ptr [rsp+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 08
0034h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0038h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> segmentBytes => new byte[57]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0x44,0x2B,0xC2,0x41,0x0F,0xB6,0xC8,0xC1,0xE1,0x08,0x0F,0xB6,0xD2,0x0B,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0xE8,0xF7,0xC0,0x48,0x89,0x44,0x24,0x08,0xC5,0xFB,0x10,0x44,0x24,0x08,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split(byte src, out byte x0, out byte x1)
; location: [7FFDD9B5D5C0h, 7FFDD9B5D5D5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
000ah and ecx,0Fh                   ; AND(And_rm32_imm8) [ECX,fh:imm32]                    encoding(3 bytes) = 83 e1 0f
000dh mov [rdx],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),CL]            encoding(2 bytes) = 88 0a
000fh sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
0012h mov [r8],al                   ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),AL]             encoding(3 bytes) = 41 88 00
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xC8,0x83,0xE1,0x0F,0x88,0x0A,0xC1,0xF8,0x04,0x41,0x88,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ValueTuple<sbyte,sbyte> split(short src, N2 parts)
; location: [7FFDD9B5D9F0h, 7FFDD9B5DA1Dh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,al                  ; MOVSX(Movsx_r64_rm8) [RDX,AL]                        encoding(4 bytes) = 48 0f be d0
000dh mov byte ptr [rsp],0          ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(4 bytes) = c6 04 24 00
0011h mov byte ptr [rsp+1],0        ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = c6 44 24 01 00
0016h mov [rsp],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),DL]            encoding(3 bytes) = 88 14 24
0019h sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
001ch movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0020h mov [rsp+1],al                ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 01
0024h movsx rax,word ptr [rsp]      ; MOVSX(Movsx_r64_rm16) [RAX,mem(16i,RSP:br,SS:sr)]    encoding(5 bytes) = 48 0f bf 04 24
0029h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[46]{0x50,0x0F,0x1F,0x40,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBE,0xD0,0xC6,0x04,0x24,0x00,0xC6,0x44,0x24,0x01,0x00,0x88,0x14,0x24,0xC1,0xF8,0x08,0x48,0x0F,0xBE,0xC0,0x88,0x44,0x24,0x01,0x48,0x0F,0xBF,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void split(ushort src, out byte x0, out byte x1)
; location: [7FFDD9B5DA40h, 7FFDD9B5DA50h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),CL]            encoding(2 bytes) = 88 0a
0007h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
000ah sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
000dh mov [r8],al                   ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),AL]             encoding(3 bytes) = 41 88 00
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x88,0x0A,0x0F,0xB7,0xC1,0xC1,0xF8,0x08,0x41,0x88,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ValueTuple<short,short> split(int src, N2 parts)
; location: [7FFDD9B5DA70h, 7FFDD9B5DA9Dh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h mov word ptr [rsp],0          ; MOV(Mov_rm16_imm16) [mem(16u,RSP:br,SS:sr),0h:imm16] encoding(6 bytes) = 66 c7 04 24 00 00
000fh mov word ptr [rsp+2],0        ; MOV(Mov_rm16_imm16) [mem(16u,RSP:br,SS:sr),0h:imm16] encoding(7 bytes) = 66 c7 44 24 02 00 00
0016h mov [rsp],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,SS:sr),AX]         encoding(4 bytes) = 66 89 04 24
001ah sar ecx,10h                   ; SAR(Sar_rm32_imm8) [ECX,10h:imm8]                    encoding(3 bytes) = c1 f9 10
001dh movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0021h mov [rsp+2],ax                ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,SS:sr),AX]         encoding(5 bytes) = 66 89 44 24 02
0026h mov eax,[rsp]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(3 bytes) = 8b 04 24
0029h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
002dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> splitBytes => new byte[46]{0x50,0x0F,0x1F,0x40,0x00,0x48,0x0F,0xBF,0xC1,0x66,0xC7,0x04,0x24,0x00,0x00,0x66,0xC7,0x44,0x24,0x02,0x00,0x00,0x66,0x89,0x04,0x24,0xC1,0xF9,0x10,0x48,0x0F,0xBF,0xC1,0x66,0x89,0x44,0x24,0x02,0x8B,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitVector128 clmul_ref(BitVector64 x, BitVector64 y)
; location: [7FFDD9B5DD00h, 7FFDD9B5EBD8h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,4B0h                  ; SUB(Sub_rm64_imm32) [RSP,4b0h:imm64]                 encoding(7 bytes) = 48 81 ec b0 04 00 00
000ah xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000ch mov [rsp+4A0h],rax            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(8 bytes) = 48 89 84 24 a0 04 00 00
0014h mov [rsp+4A8h],rax            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(8 bytes) = 48 89 84 24 a8 04 00 00
001ch mov [rsp+490h],rax            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(8 bytes) = 48 89 84 24 90 04 00 00
0024h mov [rsp+498h],rax            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(8 bytes) = 48 89 84 24 98 04 00 00
002ch mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
002fh mov rdi,rdx                   ; MOV(Mov_r64_rm64) [RDI,RDX]                          encoding(3 bytes) = 48 8b fa
0032h mov rbx,r8                    ; MOV(Mov_r64_rm64) [RBX,R8]                           encoding(3 bytes) = 49 8b d8
0035h mov rcx,7FFDD95F93E8h         ; MOV(Mov_r64_imm64) [RCX,7ffdd95f93e8h:imm64]         encoding(10 bytes) = 48 b9 e8 93 5f d9 fd 7f 00 00
003fh mov edx,21h                   ; MOV(Mov_r32_imm32) [EDX,21h:imm32]                   encoding(5 bytes) = ba 21 00 00 00
0044h call 7FFE38FC48B0h            ; CALL(Call_rel32_64) [5F466BB0h:jmp64]                encoding(5 bytes) = e8 67 6b 46 5f
0049h mov rcx,184E1406FA8h          ; MOV(Mov_r64_imm64) [RCX,184e1406fa8h:imm64]          encoding(10 bytes) = 48 b9 a8 6f 40 e1 84 01 00 00
0053h mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
0056h add rcx,8                     ; ADD(Add_rm64_imm8) [RCX,8h:imm64]                    encoding(4 bytes) = 48 83 c1 08
005ah mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
005dh mov [rsp+4A0h],rax            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(8 bytes) = 48 89 84 24 a0 04 00 00
0065h mov rcx,[rcx+8]               ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(4 bytes) = 48 8b 49 08
0069h mov [rsp+4A8h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 a8 04 00 00
0071h mov rcx,184E1406FA8h          ; MOV(Mov_r64_imm64) [RCX,184e1406fa8h:imm64]          encoding(10 bytes) = 48 b9 a8 6f 40 e1 84 01 00 00
007bh mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
007eh add rcx,8                     ; ADD(Add_rm64_imm8) [RCX,8h:imm64]                    encoding(4 bytes) = 48 83 c1 08
0082h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
0085h mov [rsp+490h],rax            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(8 bytes) = 48 89 84 24 90 04 00 00
008dh mov rcx,[rcx+8]               ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(4 bytes) = 48 8b 49 08
0091h mov [rsp+498h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 98 04 00 00
0099h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
009bh test dil,1                    ; TEST(Test_rm8_imm8) [DIL,1h:imm8]                    encoding(4 bytes) = 40 f6 c7 01
009fh setne r8b                     ; SETNE(Setne_rm8) [R8L]                               encoding(4 bytes) = 41 0f 95 c0
00a3h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
00a7h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
00aah mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
00adh mov [rsp+488h],cl             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(7 bytes) = 88 8c 24 88 04 00 00
00b4h movzx ecx,al                  ; MOVZX(Movzx_r32_rm8) [ECX,AL]                        encoding(3 bytes) = 0f b6 c8
00b7h bt rbx,rcx                    ; BT(Bt_rm64_r64) [RBX,RCX]                            encoding(4 bytes) = 48 0f a3 cb
00bbh setb cl                       ; SETB(Setb_rm8) [CL]                                  encoding(3 bytes) = 0f 92 c1
00beh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
00c1h mov [rsp+480h],cl             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(7 bytes) = 88 8c 24 80 04 00 00
00c8h mov ecx,[rsp+488h]            ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 8c 24 88 04 00 00
00cfh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
00d2h mov r9d,[rsp+480h]            ; MOV(Mov_r32_rm32) [R9D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 8c 24 80 04 00 00
00dah movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
00deh and ecx,r9d                   ; AND(And_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 23 c9
00e1h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
00e4h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
00e7h mov [rsp+478h],cl             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(7 bytes) = 88 8c 24 78 04 00 00
00eeh movzx ecx,byte ptr [rsp+478h] ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(8 bytes) = 0f b6 8c 24 78 04 00 00
00f6h cmp eax,40h                   ; CMP(Cmp_rm32_imm8) [EAX,40h:imm32]                   encoding(3 bytes) = 83 f8 40
00f9h jge short 0159h               ; JGE(Jge_rel8_64) [159h:jmp64]                        encoding(2 bytes) = 7d 5e
00fbh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00feh test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
0100h jne short 0106h               ; JNE(Jne_rel8_64) [106h:jmp64]                        encoding(2 bytes) = 75 04
0102h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0104h jmp short 010bh               ; JMP(Jmp_rel8_64) [10Bh:jmp64]                        encoding(2 bytes) = eb 05
0106h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
010bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
010eh cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
0111h jne short 0136h               ; JNE(Jne_rel8_64) [136h:jmp64]                        encoding(2 bytes) = 75 23
0113h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
0119h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
011bh shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
011eh mov rax,r9                    ; MOV(Mov_r64_rm64) [RAX,R9]                           encoding(3 bytes) = 49 8b c1
0121h or rax,[rsp+490h]             ; OR(Or_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]          encoding(8 bytes) = 48 0b 84 24 90 04 00 00
0129h mov [rsp+490h],rax            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(8 bytes) = 48 89 84 24 90 04 00 00
0131h jmp near ptr 01b4h            ; JMP(Jmp_rel32_64) [1B4h:jmp64]                       encoding(5 bytes) = e9 7e 00 00 00
0136h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
013ch mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
013eh shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
0141h mov rcx,r9                    ; MOV(Mov_r64_rm64) [RCX,R9]                           encoding(3 bytes) = 49 8b c9
0144h not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
0147h and rcx,[rsp+490h]            ; AND(And_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 23 8c 24 90 04 00 00
014fh mov [rsp+490h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 90 04 00 00
0157h jmp short 01b4h               ; JMP(Jmp_rel8_64) [1B4h:jmp64]                        encoding(2 bytes) = eb 5b
0159h movzx r9d,al                  ; MOVZX(Movzx_r32_rm8) [R9D,AL]                        encoding(4 bytes) = 44 0f b6 c8
015dh test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
015fh jne short 0165h               ; JNE(Jne_rel8_64) [165h:jmp64]                        encoding(2 bytes) = 75 04
0161h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0163h jmp short 016ah               ; JMP(Jmp_rel8_64) [16Ah:jmp64]                        encoding(2 bytes) = eb 05
0165h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
016ah movzx eax,r9b                 ; MOVZX(Movzx_r32_rm8) [EAX,R9L]                       encoding(4 bytes) = 41 0f b6 c1
016eh cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
0171h jne short 0193h               ; JNE(Jne_rel8_64) [193h:jmp64]                        encoding(2 bytes) = 75 20
0173h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
0179h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
017bh shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
017eh mov rax,r9                    ; MOV(Mov_r64_rm64) [RAX,R9]                           encoding(3 bytes) = 49 8b c1
0181h or rax,[rsp+498h]             ; OR(Or_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]          encoding(8 bytes) = 48 0b 84 24 98 04 00 00
0189h mov [rsp+498h],rax            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(8 bytes) = 48 89 84 24 98 04 00 00
0191h jmp short 01b4h               ; JMP(Jmp_rel8_64) [1B4h:jmp64]                        encoding(2 bytes) = eb 21
0193h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
0199h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
019bh shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
019eh mov rcx,r9                    ; MOV(Mov_r64_rm64) [RCX,R9]                           encoding(3 bytes) = 49 8b c9
01a1h not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
01a4h and rcx,[rsp+498h]            ; AND(And_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 23 8c 24 98 04 00 00
01ach mov [rsp+498h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 98 04 00 00
01b4h mov r10d,1                    ; MOV(Mov_r32_imm32) [R10D,1h:imm32]                   encoding(6 bytes) = 41 ba 01 00 00 00
01bah cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
01bdh jl near ptr 02e6h             ; JL(Jl_rel32_64) [2E6h:jmp64]                         encoding(6 bytes) = 0f 8c 23 01 00 00
01c3h movzx ecx,dl                  ; MOVZX(Movzx_r32_rm8) [ECX,DL]                        encoding(3 bytes) = 0f b6 ca
01c6h mov byte ptr [rsp+470h],0     ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(8 bytes) = c6 84 24 70 04 00 00 00
01ceh movzx eax,r10b                ; MOVZX(Movzx_r32_rm8) [EAX,R10L]                      encoding(4 bytes) = 41 0f b6 c2
01d2h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
01d5h bt rdi,rax                    ; BT(Bt_rm64_r64) [RDI,RAX]                            encoding(4 bytes) = 48 0f a3 c7
01d9h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
01dch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
01dfh mov [rsp+468h],al             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(7 bytes) = 88 84 24 68 04 00 00
01e6h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
01e8h sub eax,r10d                  ; SUB(Sub_r32_rm32) [EAX,R10D]                         encoding(3 bytes) = 41 2b c2
01ebh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
01eeh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
01f1h bt rbx,rax                    ; BT(Bt_rm64_r64) [RBX,RAX]                            encoding(4 bytes) = 48 0f a3 c3
01f5h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
01f8h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
01fbh mov [rsp+460h],al             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(7 bytes) = 88 84 24 60 04 00 00
0202h mov eax,[rsp+468h]            ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 84 24 68 04 00 00
0209h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
020ch mov r11d,[rsp+460h]           ; MOV(Mov_r32_rm32) [R11D,mem(32u,RSP:br,SS:sr)]       encoding(8 bytes) = 44 8b 9c 24 60 04 00 00
0214h movzx r11d,r11b               ; MOVZX(Movzx_r32_rm8) [R11D,R11L]                     encoding(4 bytes) = 45 0f b6 db
0218h and eax,r11d                  ; AND(And_r32_rm32) [EAX,R11D]                         encoding(3 bytes) = 41 23 c3
021bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
021eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0221h mov [rsp+458h],al             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(7 bytes) = 88 84 24 58 04 00 00
0228h mov eax,[rsp+470h]            ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 84 24 70 04 00 00
022fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0232h mov r11d,[rsp+458h]           ; MOV(Mov_r32_rm32) [R11D,mem(32u,RSP:br,SS:sr)]       encoding(8 bytes) = 44 8b 9c 24 58 04 00 00
023ah movzx r11d,r11b               ; MOVZX(Movzx_r32_rm8) [R11D,R11L]                     encoding(4 bytes) = 45 0f b6 db
023eh xor eax,r11d                  ; XOR(Xor_r32_rm32) [EAX,R11D]                         encoding(3 bytes) = 41 33 c3
0241h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0244h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0247h mov [rsp+450h],al             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(7 bytes) = 88 84 24 50 04 00 00
024eh movzx eax,byte ptr [rsp+450h] ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(8 bytes) = 0f b6 84 24 50 04 00 00
0256h cmp ecx,40h                   ; CMP(Cmp_rm32_imm8) [ECX,40h:imm32]                   encoding(3 bytes) = 83 f9 40
0259h jge short 029ah               ; JGE(Jge_rel8_64) [29Ah:jmp64]                        encoding(2 bytes) = 7d 3f
025bh test al,al                    ; TEST(Test_rm8_r8) [AL,AL]                            encoding(2 bytes) = 84 c0
025dh jne short 0263h               ; JNE(Jne_rel8_64) [263h:jmp64]                        encoding(2 bytes) = 75 04
025fh xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
0261h jmp short 0268h               ; JMP(Jmp_rel8_64) [268h:jmp64]                        encoding(2 bytes) = eb 05
0263h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
0268h cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
026bh jne short 0282h               ; JNE(Jne_rel8_64) [282h:jmp64]                        encoding(2 bytes) = 75 15
026dh mov rcx,r9                    ; MOV(Mov_r64_rm64) [RCX,R9]                           encoding(3 bytes) = 49 8b c9
0270h or rcx,[rsp+490h]             ; OR(Or_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]          encoding(8 bytes) = 48 0b 8c 24 90 04 00 00
0278h mov [rsp+490h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 90 04 00 00
0280h jmp short 02dah               ; JMP(Jmp_rel8_64) [2DAh:jmp64]                        encoding(2 bytes) = eb 58
0282h mov rcx,r9                    ; MOV(Mov_r64_rm64) [RCX,R9]                           encoding(3 bytes) = 49 8b c9
0285h not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
0288h and rcx,[rsp+490h]            ; AND(And_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 23 8c 24 90 04 00 00
0290h mov [rsp+490h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 90 04 00 00
0298h jmp short 02dah               ; JMP(Jmp_rel8_64) [2DAh:jmp64]                        encoding(2 bytes) = eb 40
029ah movzx ecx,al                  ; MOVZX(Movzx_r32_rm8) [ECX,AL]                        encoding(3 bytes) = 0f b6 c8
029dh test cl,cl                    ; TEST(Test_rm8_r8) [CL,CL]                            encoding(2 bytes) = 84 c9
029fh jne short 02a5h               ; JNE(Jne_rel8_64) [2A5h:jmp64]                        encoding(2 bytes) = 75 04
02a1h xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
02a3h jmp short 02aah               ; JMP(Jmp_rel8_64) [2AAh:jmp64]                        encoding(2 bytes) = eb 05
02a5h mov ecx,1                     ; MOV(Mov_r32_imm32) [ECX,1h:imm32]                    encoding(5 bytes) = b9 01 00 00 00
02aah cmp ecx,1                     ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 f9 01
02adh jne short 02c4h               ; JNE(Jne_rel8_64) [2C4h:jmp64]                        encoding(2 bytes) = 75 15
02afh mov rcx,r9                    ; MOV(Mov_r64_rm64) [RCX,R9]                           encoding(3 bytes) = 49 8b c9
02b2h or rcx,[rsp+498h]             ; OR(Or_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]          encoding(8 bytes) = 48 0b 8c 24 98 04 00 00
02bah mov [rsp+498h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 98 04 00 00
02c2h jmp short 02dah               ; JMP(Jmp_rel8_64) [2DAh:jmp64]                        encoding(2 bytes) = eb 16
02c4h mov rcx,r9                    ; MOV(Mov_r64_rm64) [RCX,R9]                           encoding(3 bytes) = 49 8b c9
02c7h not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
02cah and rcx,[rsp+498h]            ; AND(And_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 23 8c 24 98 04 00 00
02d2h mov [rsp+498h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 98 04 00 00
02dah inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
02ddh cmp r10d,edx                  ; CMP(Cmp_r32_rm32) [R10D,EDX]                         encoding(3 bytes) = 44 3b d2
02e0h jle near ptr 01c3h            ; JLE(Jle_rel32_64) [1C3h:jmp64]                       encoding(6 bytes) = 0f 8e dd fe ff ff
02e6h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
02e9h mov byte ptr [rsp+448h],0     ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(8 bytes) = c6 84 24 48 04 00 00 00
02f1h movzx r10d,byte ptr [rsp+448h]; MOVZX(Movzx_r32_rm8) [R10D,mem(8u,RSP:br,SS:sr)]     encoding(9 bytes) = 44 0f b6 94 24 48 04 00 00
02fah cmp eax,40h                   ; CMP(Cmp_rm32_imm8) [EAX,40h:imm32]                   encoding(3 bytes) = 83 f8 40
02fdh jge near ptr 03c5h            ; JGE(Jge_rel32_64) [3C5h:jmp64]                       encoding(6 bytes) = 0f 8d c2 00 00 00
0303h lea rcx,[rsp+400h]            ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 00 04 00 00
030bh mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
030dh movzx ecx,byte ptr [rsp+400h] ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(8 bytes) = 0f b6 8c 24 00 04 00 00
0315h lea rax,[rsp+3F8h]            ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 84 24 f8 03 00 00
031dh mov [rax],r10b                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R10L]          encoding(3 bytes) = 44 88 10
0320h movsx r10,byte ptr [rsp+3F8h] ; MOVSX(Movsx_r64_rm8) [R10,mem(8i,RSP:br,SS:sr)]      encoding(9 bytes) = 4c 0f be 94 24 f8 03 00 00
0329h mov [rsp+3F0h],r10b           ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),R10L]          encoding(8 bytes) = 44 88 94 24 f0 03 00 00
0331h cmp byte ptr [rsp+3F0h],0     ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(8 bytes) = 80 bc 24 f0 03 00 00 00
0339h jne short 034dh               ; JNE(Jne_rel8_64) [34Dh:jmp64]                        encoding(2 bytes) = 75 12
033bh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
033dh mov [rsp+3E8h],eax            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(7 bytes) = 89 84 24 e8 03 00 00
0344h mov eax,[rsp+3E8h]            ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 84 24 e8 03 00 00
034bh jmp short 035fh               ; JMP(Jmp_rel8_64) [35Fh:jmp64]                        encoding(2 bytes) = eb 12
034dh mov dword ptr [rsp+3E0h],1    ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,SS:sr),1h:imm32] encoding(11 bytes) = c7 84 24 e0 03 00 00 01 00 00 00
0358h mov eax,[rsp+3E0h]            ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 84 24 e0 03 00 00
035fh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0362h lea r9,[rsp+3D8h]             ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8d 8c 24 d8 03 00 00
036ah mov [r9],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R9:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 01
036dh mov eax,[rsp+3D8h]            ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 84 24 d8 03 00 00
0374h mov [rsp+3D0h],eax            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(7 bytes) = 89 84 24 d0 03 00 00
037bh cmp dword ptr [rsp+3D0h],1    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),1h:imm32]  encoding(8 bytes) = 83 bc 24 d0 03 00 00 01
0383h jne short 03a2h               ; JNE(Jne_rel8_64) [3A2h:jmp64]                        encoding(2 bytes) = 75 1d
0385h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
038ah shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
038dh or rax,[rsp+4A0h]             ; OR(Or_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]          encoding(8 bytes) = 48 0b 84 24 a0 04 00 00
0395h mov [rsp+4A0h],rax            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(8 bytes) = 48 89 84 24 a0 04 00 00
039dh jmp near ptr 047eh            ; JMP(Jmp_rel32_64) [47Eh:jmp64]                       encoding(5 bytes) = e9 dc 00 00 00
03a2h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
03a7h shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
03aah mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
03adh not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
03b0h and rcx,[rsp+4A0h]            ; AND(And_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 23 8c 24 a0 04 00 00
03b8h mov [rsp+4A0h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 a0 04 00 00
03c0h jmp near ptr 047eh            ; JMP(Jmp_rel32_64) [47Eh:jmp64]                       encoding(5 bytes) = e9 b9 00 00 00
03c5h lea rcx,[rsp+3C8h]            ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 8c 24 c8 03 00 00
03cdh mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
03cfh movzx ecx,byte ptr [rsp+3C8h] ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(8 bytes) = 0f b6 8c 24 c8 03 00 00
03d7h lea rax,[rsp+3C0h]            ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 84 24 c0 03 00 00
03dfh mov [rax],r10b                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R10L]          encoding(3 bytes) = 44 88 10
03e2h movsx rax,byte ptr [rsp+3C0h] ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RSP:br,SS:sr)]      encoding(9 bytes) = 48 0f be 84 24 c0 03 00 00
03ebh mov [rsp+3B8h],al             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(7 bytes) = 88 84 24 b8 03 00 00
03f2h cmp byte ptr [rsp+3B8h],0     ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(8 bytes) = 80 bc 24 b8 03 00 00 00
03fah jne short 040eh               ; JNE(Jne_rel8_64) [40Eh:jmp64]                        encoding(2 bytes) = 75 12
03fch xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
03feh mov [rsp+3B0h],eax            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(7 bytes) = 89 84 24 b0 03 00 00
0405h mov eax,[rsp+3B0h]            ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 84 24 b0 03 00 00
040ch jmp short 0420h               ; JMP(Jmp_rel8_64) [420h:jmp64]                        encoding(2 bytes) = eb 12
040eh mov dword ptr [rsp+3A8h],1    ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,SS:sr),1h:imm32] encoding(11 bytes) = c7 84 24 a8 03 00 00 01 00 00 00
0419h mov eax,[rsp+3A8h]            ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 84 24 a8 03 00 00
0420h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0423h lea r9,[rsp+3A0h]             ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8d 8c 24 a0 03 00 00
042bh mov [r9],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R9:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 01
042eh mov eax,[rsp+3A0h]            ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 84 24 a0 03 00 00
0435h mov [rsp+398h],eax            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(7 bytes) = 89 84 24 98 03 00 00
043ch cmp dword ptr [rsp+398h],1    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),1h:imm32]  encoding(8 bytes) = 83 bc 24 98 03 00 00 01
0444h jne short 0460h               ; JNE(Jne_rel8_64) [460h:jmp64]                        encoding(2 bytes) = 75 1a
0446h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
044bh shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
044eh or rax,[rsp+4A8h]             ; OR(Or_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]          encoding(8 bytes) = 48 0b 84 24 a8 04 00 00
0456h mov [rsp+4A8h],rax            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(8 bytes) = 48 89 84 24 a8 04 00 00
045eh jmp short 047eh               ; JMP(Jmp_rel8_64) [47Eh:jmp64]                        encoding(2 bytes) = eb 1e
0460h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0465h shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
0468h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
046bh not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
046eh and rcx,[rsp+4A8h]            ; AND(And_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 23 8c 24 a8 04 00 00
0476h mov [rsp+4A8h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 a8 04 00 00
047eh inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0480h cmp edx,40h                   ; CMP(Cmp_rm32_imm8) [EDX,40h:imm32]                   encoding(3 bytes) = 83 fa 40
0483h jl near ptr 00a7h             ; JL(Jl_rel32_64) [A7h:jmp64]                          encoding(6 bytes) = 0f 8c 1e fc ff ff
0489h mov eax,40h                   ; MOV(Mov_r32_imm32) [EAX,40h:imm32]                   encoding(5 bytes) = b8 40 00 00 00
048eh movzx ecx,al                  ; MOVZX(Movzx_r32_rm8) [ECX,AL]                        encoding(3 bytes) = 0f b6 c8
0491h mov [rsp+390h],ecx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(7 bytes) = 89 8c 24 90 03 00 00
0498h mov ecx,[rsp+390h]            ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 8c 24 90 03 00 00
049fh mov byte ptr [rsp+388h],0     ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(8 bytes) = c6 84 24 88 03 00 00 00
04a7h movsx rdx,byte ptr [rsp+388h] ; MOVSX(Movsx_r64_rm8) [RDX,mem(8i,RSP:br,SS:sr)]      encoding(9 bytes) = 48 0f be 94 24 88 03 00 00
04b0h mov [rsp+440h],dl             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),DL]            encoding(7 bytes) = 88 94 24 40 04 00 00
04b7h lea r8,[rsp+380h]             ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8d 84 24 80 03 00 00
04bfh mov [r8],ecx                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),ECX]         encoding(3 bytes) = 41 89 08
04c2h movzx ecx,byte ptr [rsp+440h] ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(8 bytes) = 0f b6 8c 24 40 04 00 00
04cah lea rdx,[rsp+378h]            ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 94 24 78 03 00 00
04d2h mov [rdx],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),CL]            encoding(2 bytes) = 88 0a
04d4h mov ecx,[rsp+380h]            ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 8c 24 80 03 00 00
04dbh mov [rsp+370h],ecx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(7 bytes) = 89 8c 24 70 03 00 00
04e2h movsx rcx,byte ptr [rsp+378h] ; MOVSX(Movsx_r64_rm8) [RCX,mem(8i,RSP:br,SS:sr)]      encoding(9 bytes) = 48 0f be 8c 24 78 03 00 00
04ebh mov [rsp+368h],cl             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(7 bytes) = 88 8c 24 68 03 00 00
04f2h mov ecx,[rsp+370h]            ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 8c 24 70 03 00 00
04f9h mov [rsp+350h],ecx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(7 bytes) = 89 8c 24 50 03 00 00
0500h cmp dword ptr [rsp+350h],40h  ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),40h:imm32] encoding(8 bytes) = 83 bc 24 50 03 00 00 40
0508h jge near ptr 05e2h            ; JGE(Jge_rel32_64) [5E2h:jmp64]                       encoding(6 bytes) = 0f 8d d4 00 00 00
050eh mov ecx,[rsp+370h]            ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 8c 24 70 03 00 00
0515h mov [rsp+348h],ecx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(7 bytes) = 89 8c 24 48 03 00 00
051ch movzx ecx,byte ptr [rsp+348h] ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(8 bytes) = 0f b6 8c 24 48 03 00 00
0524h movsx rdx,byte ptr [rsp+368h] ; MOVSX(Movsx_r64_rm8) [RDX,mem(8i,RSP:br,SS:sr)]      encoding(9 bytes) = 48 0f be 94 24 68 03 00 00
052dh mov [rsp+340h],dl             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),DL]            encoding(7 bytes) = 88 94 24 40 03 00 00
0534h movsx rdx,byte ptr [rsp+340h] ; MOVSX(Movsx_r64_rm8) [RDX,mem(8i,RSP:br,SS:sr)]      encoding(9 bytes) = 48 0f be 94 24 40 03 00 00
053dh mov [rsp+338h],dl             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),DL]            encoding(7 bytes) = 88 94 24 38 03 00 00
0544h cmp byte ptr [rsp+338h],0     ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(8 bytes) = 80 bc 24 38 03 00 00 00
054ch jne short 0560h               ; JNE(Jne_rel8_64) [560h:jmp64]                        encoding(2 bytes) = 75 12
054eh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0550h mov [rsp+330h],edx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(7 bytes) = 89 94 24 30 03 00 00
0557h mov edx,[rsp+330h]            ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 94 24 30 03 00 00
055eh jmp short 0572h               ; JMP(Jmp_rel8_64) [572h:jmp64]                        encoding(2 bytes) = eb 12
0560h mov dword ptr [rsp+328h],1    ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,SS:sr),1h:imm32] encoding(11 bytes) = c7 84 24 28 03 00 00 01 00 00 00
056bh mov edx,[rsp+328h]            ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 94 24 28 03 00 00
0572h mov [rsp+358h],edx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(7 bytes) = 89 94 24 58 03 00 00
0579h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
057ch mov edx,[rsp+358h]            ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 94 24 58 03 00 00
0583h mov [rsp+320h],edx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(7 bytes) = 89 94 24 20 03 00 00
058ah mov edx,[rsp+320h]            ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 94 24 20 03 00 00
0591h mov [rsp+318h],edx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(7 bytes) = 89 94 24 18 03 00 00
0598h cmp dword ptr [rsp+318h],1    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),1h:imm32]  encoding(8 bytes) = 83 bc 24 18 03 00 00 01
05a0h jne short 05bfh               ; JNE(Jne_rel8_64) [5BFh:jmp64]                        encoding(2 bytes) = 75 1d
05a2h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
05a7h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
05aah or rdx,[rsp+490h]             ; OR(Or_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]          encoding(8 bytes) = 48 0b 94 24 90 04 00 00
05b2h mov [rsp+490h],rdx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(8 bytes) = 48 89 94 24 90 04 00 00
05bah jmp near ptr 06aeh            ; JMP(Jmp_rel32_64) [6AEh:jmp64]                       encoding(5 bytes) = e9 ef 00 00 00
05bfh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
05c4h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
05c7h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
05cah not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
05cdh and rcx,[rsp+490h]            ; AND(And_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 23 8c 24 90 04 00 00
05d5h mov [rsp+490h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 90 04 00 00
05ddh jmp near ptr 06aeh            ; JMP(Jmp_rel32_64) [6AEh:jmp64]                       encoding(5 bytes) = e9 cc 00 00 00
05e2h mov ecx,[rsp+370h]            ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 8c 24 70 03 00 00
05e9h mov [rsp+310h],ecx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(7 bytes) = 89 8c 24 10 03 00 00
05f0h movzx ecx,byte ptr [rsp+310h] ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(8 bytes) = 0f b6 8c 24 10 03 00 00
05f8h movsx rdx,byte ptr [rsp+368h] ; MOVSX(Movsx_r64_rm8) [RDX,mem(8i,RSP:br,SS:sr)]      encoding(9 bytes) = 48 0f be 94 24 68 03 00 00
0601h mov [rsp+308h],dl             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),DL]            encoding(7 bytes) = 88 94 24 08 03 00 00
0608h movsx rdx,byte ptr [rsp+308h] ; MOVSX(Movsx_r64_rm8) [RDX,mem(8i,RSP:br,SS:sr)]      encoding(9 bytes) = 48 0f be 94 24 08 03 00 00
0611h mov [rsp+300h],dl             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),DL]            encoding(7 bytes) = 88 94 24 00 03 00 00
0618h cmp byte ptr [rsp+300h],0     ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(8 bytes) = 80 bc 24 00 03 00 00 00
0620h jne short 0634h               ; JNE(Jne_rel8_64) [634h:jmp64]                        encoding(2 bytes) = 75 12
0622h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0624h mov [rsp+2F8h],edx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(7 bytes) = 89 94 24 f8 02 00 00
062bh mov edx,[rsp+2F8h]            ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 94 24 f8 02 00 00
0632h jmp short 0646h               ; JMP(Jmp_rel8_64) [646h:jmp64]                        encoding(2 bytes) = eb 12
0634h mov dword ptr [rsp+2F0h],1    ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,SS:sr),1h:imm32] encoding(11 bytes) = c7 84 24 f0 02 00 00 01 00 00 00
063fh mov edx,[rsp+2F0h]            ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 94 24 f0 02 00 00
0646h mov [rsp+360h],edx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(7 bytes) = 89 94 24 60 03 00 00
064dh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0650h mov edx,[rsp+360h]            ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 94 24 60 03 00 00
0657h mov [rsp+2E8h],edx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(7 bytes) = 89 94 24 e8 02 00 00
065eh mov edx,[rsp+2E8h]            ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 94 24 e8 02 00 00
0665h mov [rsp+2E0h],edx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(7 bytes) = 89 94 24 e0 02 00 00
066ch cmp dword ptr [rsp+2E0h],1    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),1h:imm32]  encoding(8 bytes) = 83 bc 24 e0 02 00 00 01
0674h jne short 0690h               ; JNE(Jne_rel8_64) [690h:jmp64]                        encoding(2 bytes) = 75 1a
0676h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
067bh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
067eh or rdx,[rsp+498h]             ; OR(Or_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]          encoding(8 bytes) = 48 0b 94 24 98 04 00 00
0686h mov [rsp+498h],rdx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(8 bytes) = 48 89 94 24 98 04 00 00
068eh jmp short 06aeh               ; JMP(Jmp_rel8_64) [6AEh:jmp64]                        encoding(2 bytes) = eb 1e
0690h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0695h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0698h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
069bh not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
069eh and rcx,[rsp+498h]            ; AND(And_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 23 8c 24 98 04 00 00
06a6h mov [rsp+498h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 98 04 00 00
06aeh lea edx,[rax-3Fh]             ; LEA(Lea_r32_m) [EDX,mem(Unknown,RAX:br,DS:sr)]       encoding(3 bytes) = 8d 50 c1
06b1h cmp edx,40h                   ; CMP(Cmp_rm32_imm8) [EDX,40h:imm32]                   encoding(3 bytes) = 83 fa 40
06b4h jge near ptr 0aadh            ; JGE(Jge_rel32_64) [AADh:jmp64]                       encoding(6 bytes) = 0f 8d f3 03 00 00
06bah movzx ecx,al                  ; MOVZX(Movzx_r32_rm8) [ECX,AL]                        encoding(3 bytes) = 0f b6 c8
06bdh mov [rsp+2D8h],ecx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(7 bytes) = 89 8c 24 d8 02 00 00
06c4h mov ecx,[rsp+2D8h]            ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 8c 24 d8 02 00 00
06cbh mov byte ptr [rsp+2D0h],0     ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(8 bytes) = c6 84 24 d0 02 00 00 00
06d3h movsx r8,byte ptr [rsp+2D0h]  ; MOVSX(Movsx_r64_rm8) [R8,mem(8i,RSP:br,SS:sr)]       encoding(9 bytes) = 4c 0f be 84 24 d0 02 00 00
06dch mov [rsp+438h],r8b            ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),R8L]           encoding(8 bytes) = 44 88 84 24 38 04 00 00
06e4h movzx r8d,dl                  ; MOVZX(Movzx_r32_rm8) [R8D,DL]                        encoding(4 bytes) = 44 0f b6 c2
06e8h mov [rsp+2C8h],r8d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(8 bytes) = 44 89 84 24 c8 02 00 00
06f0h mov r8d,[rsp+2C8h]            ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 84 24 c8 02 00 00
06f8h lea r9,[rsp+2C0h]             ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8d 8c 24 c0 02 00 00
0700h mov [r9],r8d                  ; MOV(Mov_rm32_r32) [mem(32u,R9:br,DS:sr),R8D]         encoding(3 bytes) = 45 89 01
0703h mov r8d,[rsp+2C0h]            ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 84 24 c0 02 00 00
070bh mov [rsp+2B8h],r8d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(8 bytes) = 44 89 84 24 b8 02 00 00
0713h mov r8d,[rsp+2B8h]            ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 84 24 b8 02 00 00
071bh mov [rsp+2B0h],r8d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(8 bytes) = 44 89 84 24 b0 02 00 00
0723h mov r8d,[rsp+2B0h]            ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 84 24 b0 02 00 00
072bh mov [rsp+2A8h],r8d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(8 bytes) = 44 89 84 24 a8 02 00 00
0733h movzx r8d,byte ptr [rsp+2A8h] ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RSP:br,SS:sr)]      encoding(9 bytes) = 44 0f b6 84 24 a8 02 00 00
073ch bt rdi,r8                     ; BT(Bt_rm64_r64) [RDI,R8]                             encoding(4 bytes) = 4c 0f a3 c7
0740h setb r8b                      ; SETB(Setb_rm8) [R8L]                                 encoding(4 bytes) = 41 0f 92 c0
0744h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0748h mov [rsp+2A0h],r8b            ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),R8L]           encoding(8 bytes) = 44 88 84 24 a0 02 00 00
0750h movsx r8,byte ptr [rsp+2A0h]  ; MOVSX(Movsx_r64_rm8) [R8,mem(8i,RSP:br,SS:sr)]       encoding(9 bytes) = 4c 0f be 84 24 a0 02 00 00
0759h mov [rsp+430h],r8b            ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),R8L]           encoding(8 bytes) = 44 88 84 24 30 04 00 00
0761h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
0764h sub r8d,edx                   ; SUB(Sub_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 2b c2
0767h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
076bh mov [rsp+298h],r8d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(8 bytes) = 44 89 84 24 98 02 00 00
0773h mov r8d,[rsp+298h]            ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 84 24 98 02 00 00
077bh lea r9,[rsp+290h]             ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8d 8c 24 90 02 00 00
0783h mov [r9],r8d                  ; MOV(Mov_rm32_r32) [mem(32u,R9:br,DS:sr),R8D]         encoding(3 bytes) = 45 89 01
0786h mov r8d,[rsp+290h]            ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 84 24 90 02 00 00
078eh mov [rsp+288h],r8d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(8 bytes) = 44 89 84 24 88 02 00 00
0796h mov r8d,[rsp+288h]            ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 84 24 88 02 00 00
079eh mov [rsp+280h],r8d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(8 bytes) = 44 89 84 24 80 02 00 00
07a6h mov r8d,[rsp+280h]            ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 84 24 80 02 00 00
07aeh mov [rsp+278h],r8d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(8 bytes) = 44 89 84 24 78 02 00 00
07b6h movzx r8d,byte ptr [rsp+278h] ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RSP:br,SS:sr)]      encoding(9 bytes) = 44 0f b6 84 24 78 02 00 00
07bfh bt rbx,r8                     ; BT(Bt_rm64_r64) [RBX,R8]                             encoding(4 bytes) = 4c 0f a3 c3
07c3h setb r8b                      ; SETB(Setb_rm8) [R8L]                                 encoding(4 bytes) = 41 0f 92 c0
07c7h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
07cbh mov [rsp+270h],r8b            ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),R8L]           encoding(8 bytes) = 44 88 84 24 70 02 00 00
07d3h movsx r8,byte ptr [rsp+270h]  ; MOVSX(Movsx_r64_rm8) [R8,mem(8i,RSP:br,SS:sr)]       encoding(9 bytes) = 4c 0f be 84 24 70 02 00 00
07dch mov [rsp+428h],r8b            ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),R8L]           encoding(8 bytes) = 44 88 84 24 28 04 00 00
07e4h movzx r8d,byte ptr [rsp+430h] ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RSP:br,SS:sr)]      encoding(9 bytes) = 44 0f b6 84 24 30 04 00 00
07edh lea r9,[rsp+268h]             ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8d 8c 24 68 02 00 00
07f5h mov [r9],r8b                  ; MOV(Mov_rm8_r8) [mem(8u,R9:br,DS:sr),R8L]            encoding(3 bytes) = 45 88 01
07f8h movzx r8d,byte ptr [rsp+428h] ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RSP:br,SS:sr)]      encoding(9 bytes) = 44 0f b6 84 24 28 04 00 00
0801h lea r9,[rsp+260h]             ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8d 8c 24 60 02 00 00
0809h mov [r9],r8b                  ; MOV(Mov_rm8_r8) [mem(8u,R9:br,DS:sr),R8L]            encoding(3 bytes) = 45 88 01
080ch movzx r8d,byte ptr [rsp+268h] ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RSP:br,SS:sr)]      encoding(9 bytes) = 44 0f b6 84 24 68 02 00 00
0815h movzx r9d,byte ptr [rsp+260h] ; MOVZX(Movzx_r32_rm8) [R9D,mem(8u,RSP:br,SS:sr)]      encoding(9 bytes) = 44 0f b6 8c 24 60 02 00 00
081eh and r8d,r9d                   ; AND(And_r32_rm32) [R8D,R9D]                          encoding(3 bytes) = 45 23 c1
0821h mov [rsp+258h],r8b            ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),R8L]           encoding(8 bytes) = 44 88 84 24 58 02 00 00
0829h movsx r8,byte ptr [rsp+258h]  ; MOVSX(Movsx_r64_rm8) [R8,mem(8i,RSP:br,SS:sr)]       encoding(9 bytes) = 4c 0f be 84 24 58 02 00 00
0832h mov [rsp+420h],r8b            ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),R8L]           encoding(8 bytes) = 44 88 84 24 20 04 00 00
083ah movzx r8d,byte ptr [rsp+438h] ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RSP:br,SS:sr)]      encoding(9 bytes) = 44 0f b6 84 24 38 04 00 00
0843h lea r9,[rsp+250h]             ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8d 8c 24 50 02 00 00
084bh mov [r9],r8b                  ; MOV(Mov_rm8_r8) [mem(8u,R9:br,DS:sr),R8L]            encoding(3 bytes) = 45 88 01
084eh movzx r8d,byte ptr [rsp+420h] ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RSP:br,SS:sr)]      encoding(9 bytes) = 44 0f b6 84 24 20 04 00 00
0857h lea r9,[rsp+248h]             ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8d 8c 24 48 02 00 00
085fh mov [r9],r8b                  ; MOV(Mov_rm8_r8) [mem(8u,R9:br,DS:sr),R8L]            encoding(3 bytes) = 45 88 01
0862h movzx r8d,byte ptr [rsp+250h] ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RSP:br,SS:sr)]      encoding(9 bytes) = 44 0f b6 84 24 50 02 00 00
086bh movzx r9d,byte ptr [rsp+248h] ; MOVZX(Movzx_r32_rm8) [R9D,mem(8u,RSP:br,SS:sr)]      encoding(9 bytes) = 44 0f b6 8c 24 48 02 00 00
0874h xor r8d,r9d                   ; XOR(Xor_r32_rm32) [R8D,R9D]                          encoding(3 bytes) = 45 33 c1
0877h mov [rsp+240h],r8b            ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),R8L]           encoding(8 bytes) = 44 88 84 24 40 02 00 00
087fh movsx r8,byte ptr [rsp+240h]  ; MOVSX(Movsx_r64_rm8) [R8,mem(8i,RSP:br,SS:sr)]       encoding(9 bytes) = 4c 0f be 84 24 40 02 00 00
0888h mov [rsp+418h],r8b            ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),R8L]           encoding(8 bytes) = 44 88 84 24 18 04 00 00
0890h lea r8,[rsp+238h]             ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8d 84 24 38 02 00 00
0898h mov [r8],ecx                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),ECX]         encoding(3 bytes) = 41 89 08
089bh movzx ecx,byte ptr [rsp+418h] ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(8 bytes) = 0f b6 8c 24 18 04 00 00
08a3h lea r8,[rsp+230h]             ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,SS:sr)]        encoding(8 bytes) = 4c 8d 84 24 30 02 00 00
08abh mov [r8],cl                   ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),CL]             encoding(3 bytes) = 41 88 08
08aeh mov ecx,[rsp+238h]            ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 8c 24 38 02 00 00
08b5h mov [rsp+228h],ecx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(7 bytes) = 89 8c 24 28 02 00 00
08bch movsx rcx,byte ptr [rsp+230h] ; MOVSX(Movsx_r64_rm8) [RCX,mem(8i,RSP:br,SS:sr)]      encoding(9 bytes) = 48 0f be 8c 24 30 02 00 00
08c5h mov [rsp+220h],cl             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(7 bytes) = 88 8c 24 20 02 00 00
08cch mov ecx,[rsp+228h]            ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 8c 24 28 02 00 00
08d3h mov [rsp+208h],ecx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(7 bytes) = 89 8c 24 08 02 00 00
08dah cmp dword ptr [rsp+208h],40h  ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),40h:imm32] encoding(8 bytes) = 83 bc 24 08 02 00 00 40
08e2h jge near ptr 09c9h            ; JGE(Jge_rel32_64) [9C9h:jmp64]                       encoding(6 bytes) = 0f 8d e1 00 00 00
08e8h mov ecx,[rsp+228h]            ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 8c 24 28 02 00 00
08efh mov [rsp+200h],ecx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(7 bytes) = 89 8c 24 00 02 00 00
08f6h movzx ecx,byte ptr [rsp+200h] ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(8 bytes) = 0f b6 8c 24 00 02 00 00
08feh movsx r8,byte ptr [rsp+220h]  ; MOVSX(Movsx_r64_rm8) [R8,mem(8i,RSP:br,SS:sr)]       encoding(9 bytes) = 4c 0f be 84 24 20 02 00 00
0907h mov [rsp+1F8h],r8b            ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),R8L]           encoding(8 bytes) = 44 88 84 24 f8 01 00 00
090fh movsx r8,byte ptr [rsp+1F8h]  ; MOVSX(Movsx_r64_rm8) [R8,mem(8i,RSP:br,SS:sr)]       encoding(9 bytes) = 4c 0f be 84 24 f8 01 00 00
0918h mov [rsp+1F0h],r8b            ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),R8L]           encoding(8 bytes) = 44 88 84 24 f0 01 00 00
0920h cmp byte ptr [rsp+1F0h],0     ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(8 bytes) = 80 bc 24 f0 01 00 00 00
0928h jne short 093fh               ; JNE(Jne_rel8_64) [93Fh:jmp64]                        encoding(2 bytes) = 75 15
092ah xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
092dh mov [rsp+1E8h],r8d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(8 bytes) = 44 89 84 24 e8 01 00 00
0935h mov r8d,[rsp+1E8h]            ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 84 24 e8 01 00 00
093dh jmp short 0952h               ; JMP(Jmp_rel8_64) [952h:jmp64]                        encoding(2 bytes) = eb 13
093fh mov dword ptr [rsp+1E0h],1    ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,SS:sr),1h:imm32] encoding(11 bytes) = c7 84 24 e0 01 00 00 01 00 00 00
094ah mov r8d,[rsp+1E0h]            ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 84 24 e0 01 00 00
0952h mov [rsp+210h],r8d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(8 bytes) = 44 89 84 24 10 02 00 00
095ah movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
095dh mov r8d,[rsp+210h]            ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 84 24 10 02 00 00
0965h mov [rsp+1D8h],r8d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(8 bytes) = 44 89 84 24 d8 01 00 00
096dh mov r8d,[rsp+1D8h]            ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 84 24 d8 01 00 00
0975h mov [rsp+1D0h],r8d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(8 bytes) = 44 89 84 24 d0 01 00 00
097dh cmp dword ptr [rsp+1D0h],1    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),1h:imm32]  encoding(8 bytes) = 83 bc 24 d0 01 00 00 01
0985h jne short 09a5h               ; JNE(Jne_rel8_64) [9A5h:jmp64]                        encoding(2 bytes) = 75 1e
0987h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
098dh shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0990h or r8,[rsp+490h]              ; OR(Or_r64_rm64) [R8,mem(64u,RSP:br,SS:sr)]           encoding(8 bytes) = 4c 0b 84 24 90 04 00 00
0998h mov [rsp+490h],r8             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R8]         encoding(8 bytes) = 4c 89 84 24 90 04 00 00
09a0h jmp near ptr 0aa2h            ; JMP(Jmp_rel32_64) [AA2h:jmp64]                       encoding(5 bytes) = e9 fd 00 00 00
09a5h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
09abh shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
09aeh mov rcx,r8                    ; MOV(Mov_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 8b c8
09b1h not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
09b4h and rcx,[rsp+490h]            ; AND(And_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 23 8c 24 90 04 00 00
09bch mov [rsp+490h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 90 04 00 00
09c4h jmp near ptr 0aa2h            ; JMP(Jmp_rel32_64) [AA2h:jmp64]                       encoding(5 bytes) = e9 d9 00 00 00
09c9h mov ecx,[rsp+228h]            ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 8c 24 28 02 00 00
09d0h mov [rsp+1C8h],ecx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(7 bytes) = 89 8c 24 c8 01 00 00
09d7h movzx ecx,byte ptr [rsp+1C8h] ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(8 bytes) = 0f b6 8c 24 c8 01 00 00
09dfh movsx r8,byte ptr [rsp+220h]  ; MOVSX(Movsx_r64_rm8) [R8,mem(8i,RSP:br,SS:sr)]       encoding(9 bytes) = 4c 0f be 84 24 20 02 00 00
09e8h mov [rsp+1C0h],r8b            ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),R8L]           encoding(8 bytes) = 44 88 84 24 c0 01 00 00
09f0h movsx r8,byte ptr [rsp+1C0h]  ; MOVSX(Movsx_r64_rm8) [R8,mem(8i,RSP:br,SS:sr)]       encoding(9 bytes) = 4c 0f be 84 24 c0 01 00 00
09f9h mov [rsp+1B8h],r8b            ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),R8L]           encoding(8 bytes) = 44 88 84 24 b8 01 00 00
0a01h cmp byte ptr [rsp+1B8h],0     ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(8 bytes) = 80 bc 24 b8 01 00 00 00
0a09h jne short 0a20h               ; JNE(Jne_rel8_64) [A20h:jmp64]                        encoding(2 bytes) = 75 15
0a0bh xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0a0eh mov [rsp+1B0h],r8d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(8 bytes) = 44 89 84 24 b0 01 00 00
0a16h mov r8d,[rsp+1B0h]            ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 84 24 b0 01 00 00
0a1eh jmp short 0a33h               ; JMP(Jmp_rel8_64) [A33h:jmp64]                        encoding(2 bytes) = eb 13
0a20h mov dword ptr [rsp+1A8h],1    ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,SS:sr),1h:imm32] encoding(11 bytes) = c7 84 24 a8 01 00 00 01 00 00 00
0a2bh mov r8d,[rsp+1A8h]            ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 84 24 a8 01 00 00
0a33h mov [rsp+218h],r8d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(8 bytes) = 44 89 84 24 18 02 00 00
0a3bh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0a3eh mov r8d,[rsp+218h]            ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 84 24 18 02 00 00
0a46h mov [rsp+1A0h],r8d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(8 bytes) = 44 89 84 24 a0 01 00 00
0a4eh mov r8d,[rsp+1A0h]            ; MOV(Mov_r32_rm32) [R8D,mem(32u,RSP:br,SS:sr)]        encoding(8 bytes) = 44 8b 84 24 a0 01 00 00
0a56h mov [rsp+198h],r8d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(8 bytes) = 44 89 84 24 98 01 00 00
0a5eh cmp dword ptr [rsp+198h],1    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),1h:imm32]  encoding(8 bytes) = 83 bc 24 98 01 00 00 01
0a66h jne short 0a83h               ; JNE(Jne_rel8_64) [A83h:jmp64]                        encoding(2 bytes) = 75 1b
0a68h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
0a6eh shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0a71h or r8,[rsp+498h]              ; OR(Or_r64_rm64) [R8,mem(64u,RSP:br,SS:sr)]           encoding(8 bytes) = 4c 0b 84 24 98 04 00 00
0a79h mov [rsp+498h],r8             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),R8]         encoding(8 bytes) = 4c 89 84 24 98 04 00 00
0a81h jmp short 0aa2h               ; JMP(Jmp_rel8_64) [AA2h:jmp64]                        encoding(2 bytes) = eb 1f
0a83h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
0a89h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0a8ch mov rcx,r8                    ; MOV(Mov_r64_rm64) [RCX,R8]                           encoding(3 bytes) = 49 8b c8
0a8fh not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
0a92h and rcx,[rsp+498h]            ; AND(And_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 23 8c 24 98 04 00 00
0a9ah mov [rsp+498h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 98 04 00 00
0aa2h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0aa4h cmp edx,40h                   ; CMP(Cmp_rm32_imm8) [EDX,40h:imm32]                   encoding(3 bytes) = 83 fa 40
0aa7h jl near ptr 06bah             ; JL(Jl_rel32_64) [6BAh:jmp64]                         encoding(6 bytes) = 0f 8c 0d fc ff ff
0aadh movzx ecx,al                  ; MOVZX(Movzx_r32_rm8) [ECX,AL]                        encoding(3 bytes) = 0f b6 c8
0ab0h mov [rsp+190h],ecx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(7 bytes) = 89 8c 24 90 01 00 00
0ab7h mov ecx,[rsp+190h]            ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 8c 24 90 01 00 00
0abeh mov byte ptr [rsp+188h],0     ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(8 bytes) = c6 84 24 88 01 00 00 00
0ac6h movsx rdx,byte ptr [rsp+188h] ; MOVSX(Movsx_r64_rm8) [RDX,mem(8i,RSP:br,SS:sr)]      encoding(9 bytes) = 48 0f be 94 24 88 01 00 00
0acfh mov [rsp+410h],dl             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),DL]            encoding(7 bytes) = 88 94 24 10 04 00 00
0ad6h lea rdx,[rsp+180h]            ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 94 24 80 01 00 00
0adeh mov [rdx],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),ECX]        encoding(2 bytes) = 89 0a
0ae0h movzx ecx,byte ptr [rsp+410h] ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(8 bytes) = 0f b6 8c 24 10 04 00 00
0ae8h lea rdx,[rsp+178h]            ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 94 24 78 01 00 00
0af0h mov [rdx],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,DS:sr),CL]            encoding(2 bytes) = 88 0a
0af2h mov ecx,[rsp+180h]            ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 8c 24 80 01 00 00
0af9h mov [rsp+170h],ecx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(7 bytes) = 89 8c 24 70 01 00 00
0b00h movsx rcx,byte ptr [rsp+178h] ; MOVSX(Movsx_r64_rm8) [RCX,mem(8i,RSP:br,SS:sr)]      encoding(9 bytes) = 48 0f be 8c 24 78 01 00 00
0b09h mov [rsp+168h],cl             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(7 bytes) = 88 8c 24 68 01 00 00
0b10h mov ecx,[rsp+170h]            ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 8c 24 70 01 00 00
0b17h mov [rsp+150h],ecx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(7 bytes) = 89 8c 24 50 01 00 00
0b1eh cmp dword ptr [rsp+150h],40h  ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),40h:imm32] encoding(8 bytes) = 83 bc 24 50 01 00 00 40
0b26h jge near ptr 0c00h            ; JGE(Jge_rel32_64) [C00h:jmp64]                       encoding(6 bytes) = 0f 8d d4 00 00 00
0b2ch mov ecx,[rsp+170h]            ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 8c 24 70 01 00 00
0b33h mov [rsp+148h],ecx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(7 bytes) = 89 8c 24 48 01 00 00
0b3ah movzx ecx,byte ptr [rsp+148h] ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(8 bytes) = 0f b6 8c 24 48 01 00 00
0b42h movsx rdx,byte ptr [rsp+168h] ; MOVSX(Movsx_r64_rm8) [RDX,mem(8i,RSP:br,SS:sr)]      encoding(9 bytes) = 48 0f be 94 24 68 01 00 00
0b4bh mov [rsp+140h],dl             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),DL]            encoding(7 bytes) = 88 94 24 40 01 00 00
0b52h movsx rdx,byte ptr [rsp+140h] ; MOVSX(Movsx_r64_rm8) [RDX,mem(8i,RSP:br,SS:sr)]      encoding(9 bytes) = 48 0f be 94 24 40 01 00 00
0b5bh mov [rsp+138h],dl             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),DL]            encoding(7 bytes) = 88 94 24 38 01 00 00
0b62h cmp byte ptr [rsp+138h],0     ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(8 bytes) = 80 bc 24 38 01 00 00 00
0b6ah jne short 0b7eh               ; JNE(Jne_rel8_64) [B7Eh:jmp64]                        encoding(2 bytes) = 75 12
0b6ch xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0b6eh mov [rsp+130h],edx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(7 bytes) = 89 94 24 30 01 00 00
0b75h mov edx,[rsp+130h]            ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 94 24 30 01 00 00
0b7ch jmp short 0b90h               ; JMP(Jmp_rel8_64) [B90h:jmp64]                        encoding(2 bytes) = eb 12
0b7eh mov dword ptr [rsp+128h],1    ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,SS:sr),1h:imm32] encoding(11 bytes) = c7 84 24 28 01 00 00 01 00 00 00
0b89h mov edx,[rsp+128h]            ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 94 24 28 01 00 00
0b90h mov [rsp+158h],edx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(7 bytes) = 89 94 24 58 01 00 00
0b97h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0b9ah mov edx,[rsp+158h]            ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 94 24 58 01 00 00
0ba1h mov [rsp+120h],edx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(7 bytes) = 89 94 24 20 01 00 00
0ba8h mov edx,[rsp+120h]            ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 94 24 20 01 00 00
0bafh mov [rsp+118h],edx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(7 bytes) = 89 94 24 18 01 00 00
0bb6h cmp dword ptr [rsp+118h],1    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),1h:imm32]  encoding(8 bytes) = 83 bc 24 18 01 00 00 01
0bbeh jne short 0bddh               ; JNE(Jne_rel8_64) [BDDh:jmp64]                        encoding(2 bytes) = 75 1d
0bc0h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0bc5h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0bc8h or rdx,[rsp+4A0h]             ; OR(Or_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]          encoding(8 bytes) = 48 0b 94 24 a0 04 00 00
0bd0h mov [rsp+4A0h],rdx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(8 bytes) = 48 89 94 24 a0 04 00 00
0bd8h jmp near ptr 0ccch            ; JMP(Jmp_rel32_64) [CCCh:jmp64]                       encoding(5 bytes) = e9 ef 00 00 00
0bddh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0be2h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0be5h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
0be8h not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
0bebh and rcx,[rsp+4A0h]            ; AND(And_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 23 8c 24 a0 04 00 00
0bf3h mov [rsp+4A0h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 a0 04 00 00
0bfbh jmp near ptr 0ccch            ; JMP(Jmp_rel32_64) [CCCh:jmp64]                       encoding(5 bytes) = e9 cc 00 00 00
0c00h mov ecx,[rsp+170h]            ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 8c 24 70 01 00 00
0c07h mov [rsp+110h],ecx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(7 bytes) = 89 8c 24 10 01 00 00
0c0eh movzx ecx,byte ptr [rsp+110h] ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(8 bytes) = 0f b6 8c 24 10 01 00 00
0c16h movsx rdx,byte ptr [rsp+168h] ; MOVSX(Movsx_r64_rm8) [RDX,mem(8i,RSP:br,SS:sr)]      encoding(9 bytes) = 48 0f be 94 24 68 01 00 00
0c1fh mov [rsp+108h],dl             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),DL]            encoding(7 bytes) = 88 94 24 08 01 00 00
0c26h movsx rdx,byte ptr [rsp+108h] ; MOVSX(Movsx_r64_rm8) [RDX,mem(8i,RSP:br,SS:sr)]      encoding(9 bytes) = 48 0f be 94 24 08 01 00 00
0c2fh mov [rsp+100h],dl             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),DL]            encoding(7 bytes) = 88 94 24 00 01 00 00
0c36h cmp byte ptr [rsp+100h],0     ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(8 bytes) = 80 bc 24 00 01 00 00 00
0c3eh jne short 0c52h               ; JNE(Jne_rel8_64) [C52h:jmp64]                        encoding(2 bytes) = 75 12
0c40h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0c42h mov [rsp+0F8h],edx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(7 bytes) = 89 94 24 f8 00 00 00
0c49h mov edx,[rsp+0F8h]            ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 94 24 f8 00 00 00
0c50h jmp short 0c64h               ; JMP(Jmp_rel8_64) [C64h:jmp64]                        encoding(2 bytes) = eb 12
0c52h mov dword ptr [rsp+0F0h],1    ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,SS:sr),1h:imm32] encoding(11 bytes) = c7 84 24 f0 00 00 00 01 00 00 00
0c5dh mov edx,[rsp+0F0h]            ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 94 24 f0 00 00 00
0c64h mov [rsp+160h],edx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(7 bytes) = 89 94 24 60 01 00 00
0c6bh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0c6eh mov edx,[rsp+160h]            ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 94 24 60 01 00 00
0c75h mov [rsp+0E8h],edx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(7 bytes) = 89 94 24 e8 00 00 00
0c7ch mov edx,[rsp+0E8h]            ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 94 24 e8 00 00 00
0c83h mov [rsp+0E0h],edx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(7 bytes) = 89 94 24 e0 00 00 00
0c8ah cmp dword ptr [rsp+0E0h],1    ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),1h:imm32]  encoding(8 bytes) = 83 bc 24 e0 00 00 00 01
0c92h jne short 0caeh               ; JNE(Jne_rel8_64) [CAEh:jmp64]                        encoding(2 bytes) = 75 1a
0c94h mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0c99h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0c9ch or rdx,[rsp+4A8h]             ; OR(Or_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]          encoding(8 bytes) = 48 0b 94 24 a8 04 00 00
0ca4h mov [rsp+4A8h],rdx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(8 bytes) = 48 89 94 24 a8 04 00 00
0cach jmp short 0ccch               ; JMP(Jmp_rel8_64) [CCCh:jmp64]                        encoding(2 bytes) = eb 1e
0caeh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0cb3h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0cb6h mov rcx,rdx                   ; MOV(Mov_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 8b ca
0cb9h not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
0cbch and rcx,[rsp+4A8h]            ; AND(And_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 23 8c 24 a8 04 00 00
0cc4h mov [rsp+4A8h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 a8 04 00 00
0ccch inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0cceh cmp eax,80h                   ; CMP(Cmp_EAX_imm32) [EAX,80h:imm32]                   encoding(5 bytes) = 3d 80 00 00 00
0cd3h jl near ptr 048eh             ; JL(Jl_rel32_64) [48Eh:jmp64]                         encoding(6 bytes) = 0f 8c b5 f7 ff ff
0cd9h mov dword ptr [rsp+0D8h],7Fh  ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,SS:sr),7fh:imm32] encoding(11 bytes) = c7 84 24 d8 00 00 00 7f 00 00 00
0ce4h mov ecx,[rsp+0D8h]            ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 8c 24 d8 00 00 00
0cebh mov byte ptr [rsp+0D0h],0     ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(8 bytes) = c6 84 24 d0 00 00 00 00
0cf3h movsx rax,byte ptr [rsp+0D0h] ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RSP:br,SS:sr)]      encoding(9 bytes) = 48 0f be 84 24 d0 00 00 00
0cfch mov [rsp+408h],al             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(7 bytes) = 88 84 24 08 04 00 00
0d03h lea rax,[rsp+0C8h]            ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 84 24 c8 00 00 00
0d0bh mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),ECX]        encoding(2 bytes) = 89 08
0d0dh movzx ecx,byte ptr [rsp+408h] ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(8 bytes) = 0f b6 8c 24 08 04 00 00
0d15h lea rax,[rsp+0C0h]            ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,SS:sr)]       encoding(8 bytes) = 48 8d 84 24 c0 00 00 00
0d1dh mov [rax],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),CL]            encoding(2 bytes) = 88 08
0d1fh mov ecx,[rsp+0C8h]            ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 8c 24 c8 00 00 00
0d26h mov [rsp+0B8h],ecx            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(7 bytes) = 89 8c 24 b8 00 00 00
0d2dh movsx rcx,byte ptr [rsp+0C0h] ; MOVSX(Movsx_r64_rm8) [RCX,mem(8i,RSP:br,SS:sr)]      encoding(9 bytes) = 48 0f be 8c 24 c0 00 00 00
0d36h mov [rsp+0B0h],cl             ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),CL]            encoding(7 bytes) = 88 8c 24 b0 00 00 00
0d3dh mov ecx,[rsp+0B8h]            ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 8c 24 b8 00 00 00
0d44h mov [rsp+98h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(7 bytes) = 89 8c 24 98 00 00 00
0d4bh cmp dword ptr [rsp+98h],40h   ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),40h:imm32] encoding(8 bytes) = 83 bc 24 98 00 00 00 40
0d53h jge near ptr 0e15h            ; JGE(Jge_rel32_64) [E15h:jmp64]                       encoding(6 bytes) = 0f 8d bc 00 00 00
0d59h mov ecx,[rsp+0B8h]            ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 8c 24 b8 00 00 00
0d60h mov [rsp+90h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(7 bytes) = 89 8c 24 90 00 00 00
0d67h movzx ecx,byte ptr [rsp+90h]  ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(8 bytes) = 0f b6 8c 24 90 00 00 00
0d6fh movsx rax,byte ptr [rsp+0B0h] ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RSP:br,SS:sr)]      encoding(9 bytes) = 48 0f be 84 24 b0 00 00 00
0d78h mov [rsp+88h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(7 bytes) = 88 84 24 88 00 00 00
0d7fh movsx rax,byte ptr [rsp+88h]  ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RSP:br,SS:sr)]      encoding(9 bytes) = 48 0f be 84 24 88 00 00 00
0d88h mov [rsp+80h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(7 bytes) = 88 84 24 80 00 00 00
0d8fh cmp byte ptr [rsp+80h],0      ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(8 bytes) = 80 bc 24 80 00 00 00 00
0d97h jne short 0da5h               ; JNE(Jne_rel8_64) [DA5h:jmp64]                        encoding(2 bytes) = 75 0c
0d99h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0d9bh mov [rsp+78h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 78
0d9fh mov eax,[rsp+78h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 78
0da3h jmp short 0db1h               ; JMP(Jmp_rel8_64) [DB1h:jmp64]                        encoding(2 bytes) = eb 0c
0da5h mov dword ptr [rsp+70h],1     ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,SS:sr),1h:imm32] encoding(8 bytes) = c7 44 24 70 01 00 00 00
0dadh mov eax,[rsp+70h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 70
0db1h mov [rsp+0A0h],eax            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(7 bytes) = 89 84 24 a0 00 00 00
0db8h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0dbbh mov eax,[rsp+0A0h]            ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 84 24 a0 00 00 00
0dc2h mov [rsp+68h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 68
0dc6h mov eax,[rsp+68h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 68
0dcah mov [rsp+60h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 60
0dceh cmp dword ptr [rsp+60h],1     ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),1h:imm32]  encoding(5 bytes) = 83 7c 24 60 01
0dd3h jne short 0df2h               ; JNE(Jne_rel8_64) [DF2h:jmp64]                        encoding(2 bytes) = 75 1d
0dd5h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0ddah shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
0dddh or rax,[rsp+4A0h]             ; OR(Or_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]          encoding(8 bytes) = 48 0b 84 24 a0 04 00 00
0de5h mov [rsp+4A0h],rax            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(8 bytes) = 48 89 84 24 a0 04 00 00
0dedh jmp near ptr 0eb4h            ; JMP(Jmp_rel32_64) [EB4h:jmp64]                       encoding(5 bytes) = e9 c2 00 00 00
0df2h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0df7h shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
0dfah mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
0dfdh not rcx                       ; NOT(Not_rm64) [RCX]                                  encoding(3 bytes) = 48 f7 d1
0e00h and rcx,[rsp+4A0h]            ; AND(And_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 23 8c 24 a0 04 00 00
0e08h mov [rsp+4A0h],rcx            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RCX]        encoding(8 bytes) = 48 89 8c 24 a0 04 00 00
0e10h jmp near ptr 0eb4h            ; JMP(Jmp_rel32_64) [EB4h:jmp64]                       encoding(5 bytes) = e9 9f 00 00 00
0e15h mov ecx,[rsp+0B8h]            ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 8c 24 b8 00 00 00
0e1ch mov [rsp+58h],ecx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ECX]        encoding(4 bytes) = 89 4c 24 58
0e20h movzx ecx,byte ptr [rsp+58h]  ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 4c 24 58
0e25h movsx rax,byte ptr [rsp+0B0h] ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RSP:br,SS:sr)]      encoding(9 bytes) = 48 0f be 84 24 b0 00 00 00
0e2eh mov [rsp+50h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 50
0e32h movsx rax,byte ptr [rsp+50h]  ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RSP:br,SS:sr)]      encoding(6 bytes) = 48 0f be 44 24 50
0e38h mov [rsp+48h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 48
0e3ch cmp byte ptr [rsp+48h],0      ; CMP(Cmp_rm8_imm8) [mem(8u,RSP:br,SS:sr),0h:imm8]     encoding(5 bytes) = 80 7c 24 48 00
0e41h jne short 0e4fh               ; JNE(Jne_rel8_64) [E4Fh:jmp64]                        encoding(2 bytes) = 75 0c
0e43h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0e45h mov [rsp+40h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 40
0e49h mov eax,[rsp+40h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 40
0e4dh jmp short 0e5bh               ; JMP(Jmp_rel8_64) [E5Bh:jmp64]                        encoding(2 bytes) = eb 0c
0e4fh mov dword ptr [rsp+38h],1     ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,SS:sr),1h:imm32] encoding(8 bytes) = c7 44 24 38 01 00 00 00
0e57h mov eax,[rsp+38h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 38
0e5bh mov [rsp+0A8h],eax            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(7 bytes) = 89 84 24 a8 00 00 00
0e62h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0e65h mov eax,[rsp+0A8h]            ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(7 bytes) = 8b 84 24 a8 00 00 00
0e6ch mov [rsp+30h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 30
0e70h mov eax,[rsp+30h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 30
0e74h mov [rsp+28h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 28
0e78h cmp dword ptr [rsp+28h],1     ; CMP(Cmp_rm32_imm8) [mem(32u,RSP:br,SS:sr),1h:imm32]  encoding(5 bytes) = 83 7c 24 28 01
0e7dh jne short 0e99h               ; JNE(Jne_rel8_64) [E99h:jmp64]                        encoding(2 bytes) = 75 1a
0e7fh mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0e84h shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
0e87h or rax,[rsp+4A8h]             ; OR(Or_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]          encoding(8 bytes) = 48 0b 84 24 a8 04 00 00
0e8fh mov [rsp+4A8h],rax            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(8 bytes) = 48 89 84 24 a8 04 00 00
0e97h jmp short 0eb4h               ; JMP(Jmp_rel8_64) [EB4h:jmp64]                        encoding(2 bytes) = eb 1b
0e99h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0e9eh shl rax,cl                    ; SHL(Shl_rm64_CL) [RAX,CL]                            encoding(3 bytes) = 48 d3 e0
0ea1h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0ea4h and rax,[rsp+4A8h]            ; AND(And_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 23 84 24 a8 04 00 00
0each mov [rsp+4A8h],rax            ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(8 bytes) = 48 89 84 24 a8 04 00 00
0eb4h mov rax,[rsp+4A0h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 a0 04 00 00
0ebch mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 06
0ebfh mov rax,[rsp+4A8h]            ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(8 bytes) = 48 8b 84 24 a8 04 00 00
0ec7h mov [rsi+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(4 bytes) = 48 89 46 08
0ecbh mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0eceh add rsp,4B0h                  ; ADD(Add_rm64_imm32) [RSP,4b0h:imm64]                 encoding(7 bytes) = 48 81 c4 b0 04 00 00
0ed5h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0ed6h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0ed7h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0ed8h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> clmul_refBytes => new byte[3801]{0x57,0x56,0x53,0x48,0x81,0xEC,0xB0,0x04,0x00,0x00,0x33,0xC0,0x48,0x89,0x84,0x24,0xA0,0x04,0x00,0x00,0x48,0x89,0x84,0x24,0xA8,0x04,0x00,0x00,0x48,0x89,0x84,0x24,0x90,0x04,0x00,0x00,0x48,0x89,0x84,0x24,0x98,0x04,0x00,0x00,0x48,0x8B,0xF1,0x48,0x8B,0xFA,0x49,0x8B,0xD8,0x48,0xB9,0xE8,0x93,0x5F,0xD9,0xFD,0x7F,0x00,0x00,0xBA,0x21,0x00,0x00,0x00,0xE8,0x67,0x6B,0x46,0x5F,0x48,0xB9,0xA8,0x6F,0x40,0xE1,0x84,0x01,0x00,0x00,0x48,0x8B,0x09,0x48,0x83,0xC1,0x08,0x48,0x8B,0x01,0x48,0x89,0x84,0x24,0xA0,0x04,0x00,0x00,0x48,0x8B,0x49,0x08,0x48,0x89,0x8C,0x24,0xA8,0x04,0x00,0x00,0x48,0xB9,0xA8,0x6F,0x40,0xE1,0x84,0x01,0x00,0x00,0x48,0x8B,0x09,0x48,0x83,0xC1,0x08,0x48,0x8B,0x01,0x48,0x89,0x84,0x24,0x90,0x04,0x00,0x00,0x48,0x8B,0x49,0x08,0x48,0x89,0x8C,0x24,0x98,0x04,0x00,0x00,0x33,0xD2,0x40,0xF6,0xC7,0x01,0x41,0x0F,0x95,0xC0,0x45,0x0F,0xB6,0xC0,0x0F,0xB6,0xC2,0x41,0x8B,0xC8,0x88,0x8C,0x24,0x88,0x04,0x00,0x00,0x0F,0xB6,0xC8,0x48,0x0F,0xA3,0xCB,0x0F,0x92,0xC1,0x0F,0xB6,0xC9,0x88,0x8C,0x24,0x80,0x04,0x00,0x00,0x8B,0x8C,0x24,0x88,0x04,0x00,0x00,0x0F,0xB6,0xC9,0x44,0x8B,0x8C,0x24,0x80,0x04,0x00,0x00,0x45,0x0F,0xB6,0xC9,0x41,0x23,0xC9,0x0F,0xB6,0xC9,0x0F,0xB6,0xC9,0x88,0x8C,0x24,0x78,0x04,0x00,0x00,0x0F,0xB6,0x8C,0x24,0x78,0x04,0x00,0x00,0x83,0xF8,0x40,0x7D,0x5E,0x0F,0xB6,0xC0,0x84,0xC9,0x75,0x04,0x33,0xC9,0xEB,0x05,0xB9,0x01,0x00,0x00,0x00,0x0F,0xB6,0xC0,0x83,0xF9,0x01,0x75,0x23,0x41,0xB9,0x01,0x00,0x00,0x00,0x8B,0xC8,0x49,0xD3,0xE1,0x49,0x8B,0xC1,0x48,0x0B,0x84,0x24,0x90,0x04,0x00,0x00,0x48,0x89,0x84,0x24,0x90,0x04,0x00,0x00,0xE9,0x7E,0x00,0x00,0x00,0x41,0xB9,0x01,0x00,0x00,0x00,0x8B,0xC8,0x49,0xD3,0xE1,0x49,0x8B,0xC9,0x48,0xF7,0xD1,0x48,0x23,0x8C,0x24,0x90,0x04,0x00,0x00,0x48,0x89,0x8C,0x24,0x90,0x04,0x00,0x00,0xEB,0x5B,0x44,0x0F,0xB6,0xC8,0x84,0xC9,0x75,0x04,0x33,0xC9,0xEB,0x05,0xB9,0x01,0x00,0x00,0x00,0x41,0x0F,0xB6,0xC1,0x83,0xF9,0x01,0x75,0x20,0x41,0xB9,0x01,0x00,0x00,0x00,0x8B,0xC8,0x49,0xD3,0xE1,0x49,0x8B,0xC1,0x48,0x0B,0x84,0x24,0x98,0x04,0x00,0x00,0x48,0x89,0x84,0x24,0x98,0x04,0x00,0x00,0xEB,0x21,0x41,0xB9,0x01,0x00,0x00,0x00,0x8B,0xC8,0x49,0xD3,0xE1,0x49,0x8B,0xC9,0x48,0xF7,0xD1,0x48,0x23,0x8C,0x24,0x98,0x04,0x00,0x00,0x48,0x89,0x8C,0x24,0x98,0x04,0x00,0x00,0x41,0xBA,0x01,0x00,0x00,0x00,0x83,0xFA,0x01,0x0F,0x8C,0x23,0x01,0x00,0x00,0x0F,0xB6,0xCA,0xC6,0x84,0x24,0x70,0x04,0x00,0x00,0x00,0x41,0x0F,0xB6,0xC2,0x0F,0xB6,0xC0,0x48,0x0F,0xA3,0xC7,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x88,0x84,0x24,0x68,0x04,0x00,0x00,0x8B,0xC2,0x41,0x2B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x48,0x0F,0xA3,0xC3,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x88,0x84,0x24,0x60,0x04,0x00,0x00,0x8B,0x84,0x24,0x68,0x04,0x00,0x00,0x0F,0xB6,0xC0,0x44,0x8B,0x9C,0x24,0x60,0x04,0x00,0x00,0x45,0x0F,0xB6,0xDB,0x41,0x23,0xC3,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x84,0x24,0x58,0x04,0x00,0x00,0x8B,0x84,0x24,0x70,0x04,0x00,0x00,0x0F,0xB6,0xC0,0x44,0x8B,0x9C,0x24,0x58,0x04,0x00,0x00,0x45,0x0F,0xB6,0xDB,0x41,0x33,0xC3,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x88,0x84,0x24,0x50,0x04,0x00,0x00,0x0F,0xB6,0x84,0x24,0x50,0x04,0x00,0x00,0x83,0xF9,0x40,0x7D,0x3F,0x84,0xC0,0x75,0x04,0x33,0xC9,0xEB,0x05,0xB9,0x01,0x00,0x00,0x00,0x83,0xF9,0x01,0x75,0x15,0x49,0x8B,0xC9,0x48,0x0B,0x8C,0x24,0x90,0x04,0x00,0x00,0x48,0x89,0x8C,0x24,0x90,0x04,0x00,0x00,0xEB,0x58,0x49,0x8B,0xC9,0x48,0xF7,0xD1,0x48,0x23,0x8C,0x24,0x90,0x04,0x00,0x00,0x48,0x89,0x8C,0x24,0x90,0x04,0x00,0x00,0xEB,0x40,0x0F,0xB6,0xC8,0x84,0xC9,0x75,0x04,0x33,0xC9,0xEB,0x05,0xB9,0x01,0x00,0x00,0x00,0x83,0xF9,0x01,0x75,0x15,0x49,0x8B,0xC9,0x48,0x0B,0x8C,0x24,0x98,0x04,0x00,0x00,0x48,0x89,0x8C,0x24,0x98,0x04,0x00,0x00,0xEB,0x16,0x49,0x8B,0xC9,0x48,0xF7,0xD1,0x48,0x23,0x8C,0x24,0x98,0x04,0x00,0x00,0x48,0x89,0x8C,0x24,0x98,0x04,0x00,0x00,0x41,0xFF,0xC2,0x44,0x3B,0xD2,0x0F,0x8E,0xDD,0xFE,0xFF,0xFF,0x0F,0xB6,0xC2,0xC6,0x84,0x24,0x48,0x04,0x00,0x00,0x00,0x44,0x0F,0xB6,0x94,0x24,0x48,0x04,0x00,0x00,0x83,0xF8,0x40,0x0F,0x8D,0xC2,0x00,0x00,0x00,0x48,0x8D,0x8C,0x24,0x00,0x04,0x00,0x00,0x89,0x01,0x0F,0xB6,0x8C,0x24,0x00,0x04,0x00,0x00,0x48,0x8D,0x84,0x24,0xF8,0x03,0x00,0x00,0x44,0x88,0x10,0x4C,0x0F,0xBE,0x94,0x24,0xF8,0x03,0x00,0x00,0x44,0x88,0x94,0x24,0xF0,0x03,0x00,0x00,0x80,0xBC,0x24,0xF0,0x03,0x00,0x00,0x00,0x75,0x12,0x33,0xC0,0x89,0x84,0x24,0xE8,0x03,0x00,0x00,0x8B,0x84,0x24,0xE8,0x03,0x00,0x00,0xEB,0x12,0xC7,0x84,0x24,0xE0,0x03,0x00,0x00,0x01,0x00,0x00,0x00,0x8B,0x84,0x24,0xE0,0x03,0x00,0x00,0x0F,0xB6,0xC9,0x4C,0x8D,0x8C,0x24,0xD8,0x03,0x00,0x00,0x41,0x89,0x01,0x8B,0x84,0x24,0xD8,0x03,0x00,0x00,0x89,0x84,0x24,0xD0,0x03,0x00,0x00,0x83,0xBC,0x24,0xD0,0x03,0x00,0x00,0x01,0x75,0x1D,0xB8,0x01,0x00,0x00,0x00,0x48,0xD3,0xE0,0x48,0x0B,0x84,0x24,0xA0,0x04,0x00,0x00,0x48,0x89,0x84,0x24,0xA0,0x04,0x00,0x00,0xE9,0xDC,0x00,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0x48,0xD3,0xE0,0x48,0x8B,0xC8,0x48,0xF7,0xD1,0x48,0x23,0x8C,0x24,0xA0,0x04,0x00,0x00,0x48,0x89,0x8C,0x24,0xA0,0x04,0x00,0x00,0xE9,0xB9,0x00,0x00,0x00,0x48,0x8D,0x8C,0x24,0xC8,0x03,0x00,0x00,0x89,0x01,0x0F,0xB6,0x8C,0x24,0xC8,0x03,0x00,0x00,0x48,0x8D,0x84,0x24,0xC0,0x03,0x00,0x00,0x44,0x88,0x10,0x48,0x0F,0xBE,0x84,0x24,0xC0,0x03,0x00,0x00,0x88,0x84,0x24,0xB8,0x03,0x00,0x00,0x80,0xBC,0x24,0xB8,0x03,0x00,0x00,0x00,0x75,0x12,0x33,0xC0,0x89,0x84,0x24,0xB0,0x03,0x00,0x00,0x8B,0x84,0x24,0xB0,0x03,0x00,0x00,0xEB,0x12,0xC7,0x84,0x24,0xA8,0x03,0x00,0x00,0x01,0x00,0x00,0x00,0x8B,0x84,0x24,0xA8,0x03,0x00,0x00,0x0F,0xB6,0xC9,0x4C,0x8D,0x8C,0x24,0xA0,0x03,0x00,0x00,0x41,0x89,0x01,0x8B,0x84,0x24,0xA0,0x03,0x00,0x00,0x89,0x84,0x24,0x98,0x03,0x00,0x00,0x83,0xBC,0x24,0x98,0x03,0x00,0x00,0x01,0x75,0x1A,0xB8,0x01,0x00,0x00,0x00,0x48,0xD3,0xE0,0x48,0x0B,0x84,0x24,0xA8,0x04,0x00,0x00,0x48,0x89,0x84,0x24,0xA8,0x04,0x00,0x00,0xEB,0x1E,0xB8,0x01,0x00,0x00,0x00,0x48,0xD3,0xE0,0x48,0x8B,0xC8,0x48,0xF7,0xD1,0x48,0x23,0x8C,0x24,0xA8,0x04,0x00,0x00,0x48,0x89,0x8C,0x24,0xA8,0x04,0x00,0x00,0xFF,0xC2,0x83,0xFA,0x40,0x0F,0x8C,0x1E,0xFC,0xFF,0xFF,0xB8,0x40,0x00,0x00,0x00,0x0F,0xB6,0xC8,0x89,0x8C,0x24,0x90,0x03,0x00,0x00,0x8B,0x8C,0x24,0x90,0x03,0x00,0x00,0xC6,0x84,0x24,0x88,0x03,0x00,0x00,0x00,0x48,0x0F,0xBE,0x94,0x24,0x88,0x03,0x00,0x00,0x88,0x94,0x24,0x40,0x04,0x00,0x00,0x4C,0x8D,0x84,0x24,0x80,0x03,0x00,0x00,0x41,0x89,0x08,0x0F,0xB6,0x8C,0x24,0x40,0x04,0x00,0x00,0x48,0x8D,0x94,0x24,0x78,0x03,0x00,0x00,0x88,0x0A,0x8B,0x8C,0x24,0x80,0x03,0x00,0x00,0x89,0x8C,0x24,0x70,0x03,0x00,0x00,0x48,0x0F,0xBE,0x8C,0x24,0x78,0x03,0x00,0x00,0x88,0x8C,0x24,0x68,0x03,0x00,0x00,0x8B,0x8C,0x24,0x70,0x03,0x00,0x00,0x89,0x8C,0x24,0x50,0x03,0x00,0x00,0x83,0xBC,0x24,0x50,0x03,0x00,0x00,0x40,0x0F,0x8D,0xD4,0x00,0x00,0x00,0x8B,0x8C,0x24,0x70,0x03,0x00,0x00,0x89,0x8C,0x24,0x48,0x03,0x00,0x00,0x0F,0xB6,0x8C,0x24,0x48,0x03,0x00,0x00,0x48,0x0F,0xBE,0x94,0x24,0x68,0x03,0x00,0x00,0x88,0x94,0x24,0x40,0x03,0x00,0x00,0x48,0x0F,0xBE,0x94,0x24,0x40,0x03,0x00,0x00,0x88,0x94,0x24,0x38,0x03,0x00,0x00,0x80,0xBC,0x24,0x38,0x03,0x00,0x00,0x00,0x75,0x12,0x33,0xD2,0x89,0x94,0x24,0x30,0x03,0x00,0x00,0x8B,0x94,0x24,0x30,0x03,0x00,0x00,0xEB,0x12,0xC7,0x84,0x24,0x28,0x03,0x00,0x00,0x01,0x00,0x00,0x00,0x8B,0x94,0x24,0x28,0x03,0x00,0x00,0x89,0x94,0x24,0x58,0x03,0x00,0x00,0x0F,0xB6,0xC9,0x8B,0x94,0x24,0x58,0x03,0x00,0x00,0x89,0x94,0x24,0x20,0x03,0x00,0x00,0x8B,0x94,0x24,0x20,0x03,0x00,0x00,0x89,0x94,0x24,0x18,0x03,0x00,0x00,0x83,0xBC,0x24,0x18,0x03,0x00,0x00,0x01,0x75,0x1D,0xBA,0x01,0x00,0x00,0x00,0x48,0xD3,0xE2,0x48,0x0B,0x94,0x24,0x90,0x04,0x00,0x00,0x48,0x89,0x94,0x24,0x90,0x04,0x00,0x00,0xE9,0xEF,0x00,0x00,0x00,0xBA,0x01,0x00,0x00,0x00,0x48,0xD3,0xE2,0x48,0x8B,0xCA,0x48,0xF7,0xD1,0x48,0x23,0x8C,0x24,0x90,0x04,0x00,0x00,0x48,0x89,0x8C,0x24,0x90,0x04,0x00,0x00,0xE9,0xCC,0x00,0x00,0x00,0x8B,0x8C,0x24,0x70,0x03,0x00,0x00,0x89,0x8C,0x24,0x10,0x03,0x00,0x00,0x0F,0xB6,0x8C,0x24,0x10,0x03,0x00,0x00,0x48,0x0F,0xBE,0x94,0x24,0x68,0x03,0x00,0x00,0x88,0x94,0x24,0x08,0x03,0x00,0x00,0x48,0x0F,0xBE,0x94,0x24,0x08,0x03,0x00,0x00,0x88,0x94,0x24,0x00,0x03,0x00,0x00,0x80,0xBC,0x24,0x00,0x03,0x00,0x00,0x00,0x75,0x12,0x33,0xD2,0x89,0x94,0x24,0xF8,0x02,0x00,0x00,0x8B,0x94,0x24,0xF8,0x02,0x00,0x00,0xEB,0x12,0xC7,0x84,0x24,0xF0,0x02,0x00,0x00,0x01,0x00,0x00,0x00,0x8B,0x94,0x24,0xF0,0x02,0x00,0x00,0x89,0x94,0x24,0x60,0x03,0x00,0x00,0x0F,0xB6,0xC9,0x8B,0x94,0x24,0x60,0x03,0x00,0x00,0x89,0x94,0x24,0xE8,0x02,0x00,0x00,0x8B,0x94,0x24,0xE8,0x02,0x00,0x00,0x89,0x94,0x24,0xE0,0x02,0x00,0x00,0x83,0xBC,0x24,0xE0,0x02,0x00,0x00,0x01,0x75,0x1A,0xBA,0x01,0x00,0x00,0x00,0x48,0xD3,0xE2,0x48,0x0B,0x94,0x24,0x98,0x04,0x00,0x00,0x48,0x89,0x94,0x24,0x98,0x04,0x00,0x00,0xEB,0x1E,0xBA,0x01,0x00,0x00,0x00,0x48,0xD3,0xE2,0x48,0x8B,0xCA,0x48,0xF7,0xD1,0x48,0x23,0x8C,0x24,0x98,0x04,0x00,0x00,0x48,0x89,0x8C,0x24,0x98,0x04,0x00,0x00,0x8D,0x50,0xC1,0x83,0xFA,0x40,0x0F,0x8D,0xF3,0x03,0x00,0x00,0x0F,0xB6,0xC8,0x89,0x8C,0x24,0xD8,0x02,0x00,0x00,0x8B,0x8C,0x24,0xD8,0x02,0x00,0x00,0xC6,0x84,0x24,0xD0,0x02,0x00,0x00,0x00,0x4C,0x0F,0xBE,0x84,0x24,0xD0,0x02,0x00,0x00,0x44,0x88,0x84,0x24,0x38,0x04,0x00,0x00,0x44,0x0F,0xB6,0xC2,0x44,0x89,0x84,0x24,0xC8,0x02,0x00,0x00,0x44,0x8B,0x84,0x24,0xC8,0x02,0x00,0x00,0x4C,0x8D,0x8C,0x24,0xC0,0x02,0x00,0x00,0x45,0x89,0x01,0x44,0x8B,0x84,0x24,0xC0,0x02,0x00,0x00,0x44,0x89,0x84,0x24,0xB8,0x02,0x00,0x00,0x44,0x8B,0x84,0x24,0xB8,0x02,0x00,0x00,0x44,0x89,0x84,0x24,0xB0,0x02,0x00,0x00,0x44,0x8B,0x84,0x24,0xB0,0x02,0x00,0x00,0x44,0x89,0x84,0x24,0xA8,0x02,0x00,0x00,0x44,0x0F,0xB6,0x84,0x24,0xA8,0x02,0x00,0x00,0x4C,0x0F,0xA3,0xC7,0x41,0x0F,0x92,0xC0,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x84,0x24,0xA0,0x02,0x00,0x00,0x4C,0x0F,0xBE,0x84,0x24,0xA0,0x02,0x00,0x00,0x44,0x88,0x84,0x24,0x30,0x04,0x00,0x00,0x44,0x8B,0xC0,0x44,0x2B,0xC2,0x45,0x0F,0xB6,0xC0,0x44,0x89,0x84,0x24,0x98,0x02,0x00,0x00,0x44,0x8B,0x84,0x24,0x98,0x02,0x00,0x00,0x4C,0x8D,0x8C,0x24,0x90,0x02,0x00,0x00,0x45,0x89,0x01,0x44,0x8B,0x84,0x24,0x90,0x02,0x00,0x00,0x44,0x89,0x84,0x24,0x88,0x02,0x00,0x00,0x44,0x8B,0x84,0x24,0x88,0x02,0x00,0x00,0x44,0x89,0x84,0x24,0x80,0x02,0x00,0x00,0x44,0x8B,0x84,0x24,0x80,0x02,0x00,0x00,0x44,0x89,0x84,0x24,0x78,0x02,0x00,0x00,0x44,0x0F,0xB6,0x84,0x24,0x78,0x02,0x00,0x00,0x4C,0x0F,0xA3,0xC3,0x41,0x0F,0x92,0xC0,0x45,0x0F,0xB6,0xC0,0x44,0x88,0x84,0x24,0x70,0x02,0x00,0x00,0x4C,0x0F,0xBE,0x84,0x24,0x70,0x02,0x00,0x00,0x44,0x88,0x84,0x24,0x28,0x04,0x00,0x00,0x44,0x0F,0xB6,0x84,0x24,0x30,0x04,0x00,0x00,0x4C,0x8D,0x8C,0x24,0x68,0x02,0x00,0x00,0x45,0x88,0x01,0x44,0x0F,0xB6,0x84,0x24,0x28,0x04,0x00,0x00,0x4C,0x8D,0x8C,0x24,0x60,0x02,0x00,0x00,0x45,0x88,0x01,0x44,0x0F,0xB6,0x84,0x24,0x68,0x02,0x00,0x00,0x44,0x0F,0xB6,0x8C,0x24,0x60,0x02,0x00,0x00,0x45,0x23,0xC1,0x44,0x88,0x84,0x24,0x58,0x02,0x00,0x00,0x4C,0x0F,0xBE,0x84,0x24,0x58,0x02,0x00,0x00,0x44,0x88,0x84,0x24,0x20,0x04,0x00,0x00,0x44,0x0F,0xB6,0x84,0x24,0x38,0x04,0x00,0x00,0x4C,0x8D,0x8C,0x24,0x50,0x02,0x00,0x00,0x45,0x88,0x01,0x44,0x0F,0xB6,0x84,0x24,0x20,0x04,0x00,0x00,0x4C,0x8D,0x8C,0x24,0x48,0x02,0x00,0x00,0x45,0x88,0x01,0x44,0x0F,0xB6,0x84,0x24,0x50,0x02,0x00,0x00,0x44,0x0F,0xB6,0x8C,0x24,0x48,0x02,0x00,0x00,0x45,0x33,0xC1,0x44,0x88,0x84,0x24,0x40,0x02,0x00,0x00,0x4C,0x0F,0xBE,0x84,0x24,0x40,0x02,0x00,0x00,0x44,0x88,0x84,0x24,0x18,0x04,0x00,0x00,0x4C,0x8D,0x84,0x24,0x38,0x02,0x00,0x00,0x41,0x89,0x08,0x0F,0xB6,0x8C,0x24,0x18,0x04,0x00,0x00,0x4C,0x8D,0x84,0x24,0x30,0x02,0x00,0x00,0x41,0x88,0x08,0x8B,0x8C,0x24,0x38,0x02,0x00,0x00,0x89,0x8C,0x24,0x28,0x02,0x00,0x00,0x48,0x0F,0xBE,0x8C,0x24,0x30,0x02,0x00,0x00,0x88,0x8C,0x24,0x20,0x02,0x00,0x00,0x8B,0x8C,0x24,0x28,0x02,0x00,0x00,0x89,0x8C,0x24,0x08,0x02,0x00,0x00,0x83,0xBC,0x24,0x08,0x02,0x00,0x00,0x40,0x0F,0x8D,0xE1,0x00,0x00,0x00,0x8B,0x8C,0x24,0x28,0x02,0x00,0x00,0x89,0x8C,0x24,0x00,0x02,0x00,0x00,0x0F,0xB6,0x8C,0x24,0x00,0x02,0x00,0x00,0x4C,0x0F,0xBE,0x84,0x24,0x20,0x02,0x00,0x00,0x44,0x88,0x84,0x24,0xF8,0x01,0x00,0x00,0x4C,0x0F,0xBE,0x84,0x24,0xF8,0x01,0x00,0x00,0x44,0x88,0x84,0x24,0xF0,0x01,0x00,0x00,0x80,0xBC,0x24,0xF0,0x01,0x00,0x00,0x00,0x75,0x15,0x45,0x33,0xC0,0x44,0x89,0x84,0x24,0xE8,0x01,0x00,0x00,0x44,0x8B,0x84,0x24,0xE8,0x01,0x00,0x00,0xEB,0x13,0xC7,0x84,0x24,0xE0,0x01,0x00,0x00,0x01,0x00,0x00,0x00,0x44,0x8B,0x84,0x24,0xE0,0x01,0x00,0x00,0x44,0x89,0x84,0x24,0x10,0x02,0x00,0x00,0x0F,0xB6,0xC9,0x44,0x8B,0x84,0x24,0x10,0x02,0x00,0x00,0x44,0x89,0x84,0x24,0xD8,0x01,0x00,0x00,0x44,0x8B,0x84,0x24,0xD8,0x01,0x00,0x00,0x44,0x89,0x84,0x24,0xD0,0x01,0x00,0x00,0x83,0xBC,0x24,0xD0,0x01,0x00,0x00,0x01,0x75,0x1E,0x41,0xB8,0x01,0x00,0x00,0x00,0x49,0xD3,0xE0,0x4C,0x0B,0x84,0x24,0x90,0x04,0x00,0x00,0x4C,0x89,0x84,0x24,0x90,0x04,0x00,0x00,0xE9,0xFD,0x00,0x00,0x00,0x41,0xB8,0x01,0x00,0x00,0x00,0x49,0xD3,0xE0,0x49,0x8B,0xC8,0x48,0xF7,0xD1,0x48,0x23,0x8C,0x24,0x90,0x04,0x00,0x00,0x48,0x89,0x8C,0x24,0x90,0x04,0x00,0x00,0xE9,0xD9,0x00,0x00,0x00,0x8B,0x8C,0x24,0x28,0x02,0x00,0x00,0x89,0x8C,0x24,0xC8,0x01,0x00,0x00,0x0F,0xB6,0x8C,0x24,0xC8,0x01,0x00,0x00,0x4C,0x0F,0xBE,0x84,0x24,0x20,0x02,0x00,0x00,0x44,0x88,0x84,0x24,0xC0,0x01,0x00,0x00,0x4C,0x0F,0xBE,0x84,0x24,0xC0,0x01,0x00,0x00,0x44,0x88,0x84,0x24,0xB8,0x01,0x00,0x00,0x80,0xBC,0x24,0xB8,0x01,0x00,0x00,0x00,0x75,0x15,0x45,0x33,0xC0,0x44,0x89,0x84,0x24,0xB0,0x01,0x00,0x00,0x44,0x8B,0x84,0x24,0xB0,0x01,0x00,0x00,0xEB,0x13,0xC7,0x84,0x24,0xA8,0x01,0x00,0x00,0x01,0x00,0x00,0x00,0x44,0x8B,0x84,0x24,0xA8,0x01,0x00,0x00,0x44,0x89,0x84,0x24,0x18,0x02,0x00,0x00,0x0F,0xB6,0xC9,0x44,0x8B,0x84,0x24,0x18,0x02,0x00,0x00,0x44,0x89,0x84,0x24,0xA0,0x01,0x00,0x00,0x44,0x8B,0x84,0x24,0xA0,0x01,0x00,0x00,0x44,0x89,0x84,0x24,0x98,0x01,0x00,0x00,0x83,0xBC,0x24,0x98,0x01,0x00,0x00,0x01,0x75,0x1B,0x41,0xB8,0x01,0x00,0x00,0x00,0x49,0xD3,0xE0,0x4C,0x0B,0x84,0x24,0x98,0x04,0x00,0x00,0x4C,0x89,0x84,0x24,0x98,0x04,0x00,0x00,0xEB,0x1F,0x41,0xB8,0x01,0x00,0x00,0x00,0x49,0xD3,0xE0,0x49,0x8B,0xC8,0x48,0xF7,0xD1,0x48,0x23,0x8C,0x24,0x98,0x04,0x00,0x00,0x48,0x89,0x8C,0x24,0x98,0x04,0x00,0x00,0xFF,0xC2,0x83,0xFA,0x40,0x0F,0x8C,0x0D,0xFC,0xFF,0xFF,0x0F,0xB6,0xC8,0x89,0x8C,0x24,0x90,0x01,0x00,0x00,0x8B,0x8C,0x24,0x90,0x01,0x00,0x00,0xC6,0x84,0x24,0x88,0x01,0x00,0x00,0x00,0x48,0x0F,0xBE,0x94,0x24,0x88,0x01,0x00,0x00,0x88,0x94,0x24,0x10,0x04,0x00,0x00,0x48,0x8D,0x94,0x24,0x80,0x01,0x00,0x00,0x89,0x0A,0x0F,0xB6,0x8C,0x24,0x10,0x04,0x00,0x00,0x48,0x8D,0x94,0x24,0x78,0x01,0x00,0x00,0x88,0x0A,0x8B,0x8C,0x24,0x80,0x01,0x00,0x00,0x89,0x8C,0x24,0x70,0x01,0x00,0x00,0x48,0x0F,0xBE,0x8C,0x24,0x78,0x01,0x00,0x00,0x88,0x8C,0x24,0x68,0x01,0x00,0x00,0x8B,0x8C,0x24,0x70,0x01,0x00,0x00,0x89,0x8C,0x24,0x50,0x01,0x00,0x00,0x83,0xBC,0x24,0x50,0x01,0x00,0x00,0x40,0x0F,0x8D,0xD4,0x00,0x00,0x00,0x8B,0x8C,0x24,0x70,0x01,0x00,0x00,0x89,0x8C,0x24,0x48,0x01,0x00,0x00,0x0F,0xB6,0x8C,0x24,0x48,0x01,0x00,0x00,0x48,0x0F,0xBE,0x94,0x24,0x68,0x01,0x00,0x00,0x88,0x94,0x24,0x40,0x01,0x00,0x00,0x48,0x0F,0xBE,0x94,0x24,0x40,0x01,0x00,0x00,0x88,0x94,0x24,0x38,0x01,0x00,0x00,0x80,0xBC,0x24,0x38,0x01,0x00,0x00,0x00,0x75,0x12,0x33,0xD2,0x89,0x94,0x24,0x30,0x01,0x00,0x00,0x8B,0x94,0x24,0x30,0x01,0x00,0x00,0xEB,0x12,0xC7,0x84,0x24,0x28,0x01,0x00,0x00,0x01,0x00,0x00,0x00,0x8B,0x94,0x24,0x28,0x01,0x00,0x00,0x89,0x94,0x24,0x58,0x01,0x00,0x00,0x0F,0xB6,0xC9,0x8B,0x94,0x24,0x58,0x01,0x00,0x00,0x89,0x94,0x24,0x20,0x01,0x00,0x00,0x8B,0x94,0x24,0x20,0x01,0x00,0x00,0x89,0x94,0x24,0x18,0x01,0x00,0x00,0x83,0xBC,0x24,0x18,0x01,0x00,0x00,0x01,0x75,0x1D,0xBA,0x01,0x00,0x00,0x00,0x48,0xD3,0xE2,0x48,0x0B,0x94,0x24,0xA0,0x04,0x00,0x00,0x48,0x89,0x94,0x24,0xA0,0x04,0x00,0x00,0xE9,0xEF,0x00,0x00,0x00,0xBA,0x01,0x00,0x00,0x00,0x48,0xD3,0xE2,0x48,0x8B,0xCA,0x48,0xF7,0xD1,0x48,0x23,0x8C,0x24,0xA0,0x04,0x00,0x00,0x48,0x89,0x8C,0x24,0xA0,0x04,0x00,0x00,0xE9,0xCC,0x00,0x00,0x00,0x8B,0x8C,0x24,0x70,0x01,0x00,0x00,0x89,0x8C,0x24,0x10,0x01,0x00,0x00,0x0F,0xB6,0x8C,0x24,0x10,0x01,0x00,0x00,0x48,0x0F,0xBE,0x94,0x24,0x68,0x01,0x00,0x00,0x88,0x94,0x24,0x08,0x01,0x00,0x00,0x48,0x0F,0xBE,0x94,0x24,0x08,0x01,0x00,0x00,0x88,0x94,0x24,0x00,0x01,0x00,0x00,0x80,0xBC,0x24,0x00,0x01,0x00,0x00,0x00,0x75,0x12,0x33,0xD2,0x89,0x94,0x24,0xF8,0x00,0x00,0x00,0x8B,0x94,0x24,0xF8,0x00,0x00,0x00,0xEB,0x12,0xC7,0x84,0x24,0xF0,0x00,0x00,0x00,0x01,0x00,0x00,0x00,0x8B,0x94,0x24,0xF0,0x00,0x00,0x00,0x89,0x94,0x24,0x60,0x01,0x00,0x00,0x0F,0xB6,0xC9,0x8B,0x94,0x24,0x60,0x01,0x00,0x00,0x89,0x94,0x24,0xE8,0x00,0x00,0x00,0x8B,0x94,0x24,0xE8,0x00,0x00,0x00,0x89,0x94,0x24,0xE0,0x00,0x00,0x00,0x83,0xBC,0x24,0xE0,0x00,0x00,0x00,0x01,0x75,0x1A,0xBA,0x01,0x00,0x00,0x00,0x48,0xD3,0xE2,0x48,0x0B,0x94,0x24,0xA8,0x04,0x00,0x00,0x48,0x89,0x94,0x24,0xA8,0x04,0x00,0x00,0xEB,0x1E,0xBA,0x01,0x00,0x00,0x00,0x48,0xD3,0xE2,0x48,0x8B,0xCA,0x48,0xF7,0xD1,0x48,0x23,0x8C,0x24,0xA8,0x04,0x00,0x00,0x48,0x89,0x8C,0x24,0xA8,0x04,0x00,0x00,0xFF,0xC0,0x3D,0x80,0x00,0x00,0x00,0x0F,0x8C,0xB5,0xF7,0xFF,0xFF,0xC7,0x84,0x24,0xD8,0x00,0x00,0x00,0x7F,0x00,0x00,0x00,0x8B,0x8C,0x24,0xD8,0x00,0x00,0x00,0xC6,0x84,0x24,0xD0,0x00,0x00,0x00,0x00,0x48,0x0F,0xBE,0x84,0x24,0xD0,0x00,0x00,0x00,0x88,0x84,0x24,0x08,0x04,0x00,0x00,0x48,0x8D,0x84,0x24,0xC8,0x00,0x00,0x00,0x89,0x08,0x0F,0xB6,0x8C,0x24,0x08,0x04,0x00,0x00,0x48,0x8D,0x84,0x24,0xC0,0x00,0x00,0x00,0x88,0x08,0x8B,0x8C,0x24,0xC8,0x00,0x00,0x00,0x89,0x8C,0x24,0xB8,0x00,0x00,0x00,0x48,0x0F,0xBE,0x8C,0x24,0xC0,0x00,0x00,0x00,0x88,0x8C,0x24,0xB0,0x00,0x00,0x00,0x8B,0x8C,0x24,0xB8,0x00,0x00,0x00,0x89,0x8C,0x24,0x98,0x00,0x00,0x00,0x83,0xBC,0x24,0x98,0x00,0x00,0x00,0x40,0x0F,0x8D,0xBC,0x00,0x00,0x00,0x8B,0x8C,0x24,0xB8,0x00,0x00,0x00,0x89,0x8C,0x24,0x90,0x00,0x00,0x00,0x0F,0xB6,0x8C,0x24,0x90,0x00,0x00,0x00,0x48,0x0F,0xBE,0x84,0x24,0xB0,0x00,0x00,0x00,0x88,0x84,0x24,0x88,0x00,0x00,0x00,0x48,0x0F,0xBE,0x84,0x24,0x88,0x00,0x00,0x00,0x88,0x84,0x24,0x80,0x00,0x00,0x00,0x80,0xBC,0x24,0x80,0x00,0x00,0x00,0x00,0x75,0x0C,0x33,0xC0,0x89,0x44,0x24,0x78,0x8B,0x44,0x24,0x78,0xEB,0x0C,0xC7,0x44,0x24,0x70,0x01,0x00,0x00,0x00,0x8B,0x44,0x24,0x70,0x89,0x84,0x24,0xA0,0x00,0x00,0x00,0x0F,0xB6,0xC9,0x8B,0x84,0x24,0xA0,0x00,0x00,0x00,0x89,0x44,0x24,0x68,0x8B,0x44,0x24,0x68,0x89,0x44,0x24,0x60,0x83,0x7C,0x24,0x60,0x01,0x75,0x1D,0xB8,0x01,0x00,0x00,0x00,0x48,0xD3,0xE0,0x48,0x0B,0x84,0x24,0xA0,0x04,0x00,0x00,0x48,0x89,0x84,0x24,0xA0,0x04,0x00,0x00,0xE9,0xC2,0x00,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0x48,0xD3,0xE0,0x48,0x8B,0xC8,0x48,0xF7,0xD1,0x48,0x23,0x8C,0x24,0xA0,0x04,0x00,0x00,0x48,0x89,0x8C,0x24,0xA0,0x04,0x00,0x00,0xE9,0x9F,0x00,0x00,0x00,0x8B,0x8C,0x24,0xB8,0x00,0x00,0x00,0x89,0x4C,0x24,0x58,0x0F,0xB6,0x4C,0x24,0x58,0x48,0x0F,0xBE,0x84,0x24,0xB0,0x00,0x00,0x00,0x88,0x44,0x24,0x50,0x48,0x0F,0xBE,0x44,0x24,0x50,0x88,0x44,0x24,0x48,0x80,0x7C,0x24,0x48,0x00,0x75,0x0C,0x33,0xC0,0x89,0x44,0x24,0x40,0x8B,0x44,0x24,0x40,0xEB,0x0C,0xC7,0x44,0x24,0x38,0x01,0x00,0x00,0x00,0x8B,0x44,0x24,0x38,0x89,0x84,0x24,0xA8,0x00,0x00,0x00,0x0F,0xB6,0xC9,0x8B,0x84,0x24,0xA8,0x00,0x00,0x00,0x89,0x44,0x24,0x30,0x8B,0x44,0x24,0x30,0x89,0x44,0x24,0x28,0x83,0x7C,0x24,0x28,0x01,0x75,0x1A,0xB8,0x01,0x00,0x00,0x00,0x48,0xD3,0xE0,0x48,0x0B,0x84,0x24,0xA8,0x04,0x00,0x00,0x48,0x89,0x84,0x24,0xA8,0x04,0x00,0x00,0xEB,0x1B,0xB8,0x01,0x00,0x00,0x00,0x48,0xD3,0xE0,0x48,0xF7,0xD0,0x48,0x23,0x84,0x24,0xA8,0x04,0x00,0x00,0x48,0x89,0x84,0x24,0xA8,0x04,0x00,0x00,0x48,0x8B,0x84,0x24,0xA0,0x04,0x00,0x00,0x48,0x89,0x06,0x48,0x8B,0x84,0x24,0xA8,0x04,0x00,0x00,0x48,0x89,0x46,0x08,0x48,0x8B,0xC6,0x48,0x81,0xC4,0xB0,0x04,0x00,0x00,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<sbyte> vpackss(in Vec128<short> lhs, in Vec128<short> rhs)
; location: [7FFDD9B5EC00h, 7FFDD9B5EC19h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpacksswb xmm0,xmm0,xmm1      ; VPACKSSWB(VEX_Vpacksswb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 63 c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpackssBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0x63,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<byte> vpackus(in Vec128<short> lhs, in Vec128<short> rhs)
; location: [7FFDD9B5EC30h, 7FFDD9B5EC49h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpackuswb xmm0,xmm0,xmm1      ; VPACKUSWB(VEX_Vpackuswb_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 67 c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpackusBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0x67,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec128<short> vpackss(in Vec128<int> lhs, in Vec128<int> rhs)
; location: [7FFDD9B5EC60h, 7FFDD9B5EC79h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpackssdw xmm0,xmm0,xmm1      ; VPACKSSDW(VEX_Vpackssdw_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1] encoding(VEX, 4 bytes) = c5 f9 6b c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpackssBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0x6B,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<sbyte> vpackss(in Vec256<short> lhs, in Vec256<short> rhs)
; location: [7FFDD9B5EC90h, 7FFDD9B5ECACh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpacksswb ymm0,ymm0,ymm1      ; VPACKSSWB(VEX_Vpacksswb_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 4 bytes) = c5 fd 63 c1
0012h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpackssBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0x63,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<short> vpackss(in Vec256<int> lhs, in Vec256<int> rhs)
; location: [7FFDD9B5ECC0h, 7FFDD9B5ECDCh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpackssdw ymm0,ymm0,ymm1      ; VPACKSSDW(VEX_Vpackssdw_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 4 bytes) = c5 fd 6b c1
0012h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpackssBytes => new byte[29]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC5,0xFD,0x6B,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vec256<ushort> vpackus(in Vec256<int> lhs, in Vec256<int> rhs)
; location: [7FFDD9B5ECF0h, 7FFDD9B5ED0Dh]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h vmovupd ymm1,[r8]             ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM1,mem(Packed256_Float64,R8:br,DS:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 08
000eh vpackusdw ymm0,ymm0,ymm1      ; VPACKUSDW(VEX_Vpackusdw_ymm_ymm_ymmm256) [YMM0,YMM0,YMM1] encoding(VEX, 5 bytes) = c4 e2 7d 2b c1
0013h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,DS:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0017h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ah vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vpackusBytes => new byte[30]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0xC4,0xC1,0x7D,0x10,0x08,0xC4,0xE2,0x7D,0x2B,0xC1,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt128 and(in UInt128 lhs, in UInt128 rhs)
; location: [7FFDD9B5ED20h, 7FFDD9B5ED64h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
000ah mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(4 bytes) = 48 8b 52 08
000eh vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0013h vpinsrq xmm0,xmm0,rdx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c2 01
0019h mov rax,[r8]                  ; MOV(Mov_r64_rm64) [RAX,mem(64u,R8:br,DS:sr)]         encoding(3 bytes) = 49 8b 00
001ch mov rdx,[r8+8]                ; MOV(Mov_r64_rm64) [RDX,mem(64u,R8:br,DS:sr)]         encoding(4 bytes) = 49 8b 50 08
0020h vmovq xmm1,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c8
0025h vpinsrq xmm1,xmm1,rdx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM1,XMM1,RDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f1 22 ca 01
002bh vpand xmm0,xmm0,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 db c1
002fh vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0034h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0039h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
003dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0040h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0044h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[69]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x8B,0x02,0x48,0x8B,0x52,0x08,0xC4,0xE1,0xF9,0x6E,0xC0,0xC4,0xE3,0xF9,0x22,0xC2,0x01,0x49,0x8B,0x00,0x49,0x8B,0x50,0x08,0xC4,0xE1,0xF9,0x6E,0xC8,0xC4,0xE3,0xF1,0x22,0xCA,0x01,0xC5,0xF9,0xDB,0xC1,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref UInt128 and(in UInt128 lhs, in UInt128 rhs, out UInt128 dst)
; location: [7FFDD9B5ED80h, 7FFDD9B5EDC5h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
000ah mov rcx,[rcx+8]               ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(4 bytes) = 48 8b 49 08
000eh vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0013h vpinsrq xmm0,xmm0,rcx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RCX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c1 01
0019h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
001ch mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(4 bytes) = 48 8b 52 08
0020h vmovq xmm1,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c8
0025h vpinsrq xmm1,xmm1,rdx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM1,XMM1,RDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f1 22 ca 01
002bh vpand xmm0,xmm0,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 db c1
002fh vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0034h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0039h vmovdqu xmmword ptr [r8],xmm0 ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R8:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 00
003eh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0041h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> andBytes => new byte[70]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x8B,0x01,0x48,0x8B,0x49,0x08,0xC4,0xE1,0xF9,0x6E,0xC0,0xC4,0xE3,0xF9,0x22,0xC1,0x01,0x48,0x8B,0x02,0x48,0x8B,0x52,0x08,0xC4,0xE1,0xF9,0x6E,0xC8,0xC4,0xE3,0xF1,0x22,0xCA,0x01,0xC5,0xF9,0xDB,0xC1,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC4,0xC1,0x7A,0x7F,0x00,0x49,0x8B,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt128 or(in UInt128 lhs, in UInt128 rhs)
; location: [7FFDD9B5EDE0h, 7FFDD9B5EE24h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
000ah mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(4 bytes) = 48 8b 52 08
000eh vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0013h vpinsrq xmm0,xmm0,rdx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c2 01
0019h mov rax,[r8]                  ; MOV(Mov_r64_rm64) [RAX,mem(64u,R8:br,DS:sr)]         encoding(3 bytes) = 49 8b 00
001ch mov rdx,[r8+8]                ; MOV(Mov_r64_rm64) [RDX,mem(64u,R8:br,DS:sr)]         encoding(4 bytes) = 49 8b 50 08
0020h vmovq xmm1,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c8
0025h vpinsrq xmm1,xmm1,rdx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM1,XMM1,RDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f1 22 ca 01
002bh vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
002fh vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0034h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0039h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
003dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0040h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0044h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[69]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x8B,0x02,0x48,0x8B,0x52,0x08,0xC4,0xE1,0xF9,0x6E,0xC0,0xC4,0xE3,0xF9,0x22,0xC2,0x01,0x49,0x8B,0x00,0x49,0x8B,0x50,0x08,0xC4,0xE1,0xF9,0x6E,0xC8,0xC4,0xE3,0xF1,0x22,0xCA,0x01,0xC5,0xF9,0xEB,0xC1,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref UInt128 or(in UInt128 lhs, in UInt128 rhs, out UInt128 dst)
; location: [7FFDD9B5EE40h, 7FFDD9B5EE85h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
000ah mov rcx,[rcx+8]               ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(4 bytes) = 48 8b 49 08
000eh vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0013h vpinsrq xmm0,xmm0,rcx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RCX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c1 01
0019h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
001ch mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(4 bytes) = 48 8b 52 08
0020h vmovq xmm1,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c8
0025h vpinsrq xmm1,xmm1,rdx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM1,XMM1,RDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f1 22 ca 01
002bh vpor xmm0,xmm0,xmm1           ; VPOR(VEX_Vpor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]      encoding(VEX, 4 bytes) = c5 f9 eb c1
002fh vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0034h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0039h vmovdqu xmmword ptr [r8],xmm0 ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R8:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 00
003eh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0041h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> orBytes => new byte[70]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x8B,0x01,0x48,0x8B,0x49,0x08,0xC4,0xE1,0xF9,0x6E,0xC0,0xC4,0xE3,0xF9,0x22,0xC1,0x01,0x48,0x8B,0x02,0x48,0x8B,0x52,0x08,0xC4,0xE1,0xF9,0x6E,0xC8,0xC4,0xE3,0xF1,0x22,0xCA,0x01,0xC5,0xF9,0xEB,0xC1,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC4,0xC1,0x7A,0x7F,0x00,0x49,0x8B,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt128 xor(in UInt128 lhs, in UInt128 rhs)
; location: [7FFDD9B5EEA0h, 7FFDD9B5EEE4h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
000ah mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(4 bytes) = 48 8b 52 08
000eh vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0013h vpinsrq xmm0,xmm0,rdx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c2 01
0019h mov rax,[r8]                  ; MOV(Mov_r64_rm64) [RAX,mem(64u,R8:br,DS:sr)]         encoding(3 bytes) = 49 8b 00
001ch mov rdx,[r8+8]                ; MOV(Mov_r64_rm64) [RDX,mem(64u,R8:br,DS:sr)]         encoding(4 bytes) = 49 8b 50 08
0020h vmovq xmm1,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c8
0025h vpinsrq xmm1,xmm1,rdx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM1,XMM1,RDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f1 22 ca 01
002bh vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
002fh vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0034h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0039h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
003dh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0040h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0044h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[69]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x8B,0x02,0x48,0x8B,0x52,0x08,0xC4,0xE1,0xF9,0x6E,0xC0,0xC4,0xE3,0xF9,0x22,0xC2,0x01,0x49,0x8B,0x00,0x49,0x8B,0x50,0x08,0xC4,0xE1,0xF9,0x6E,0xC8,0xC4,0xE3,0xF1,0x22,0xCA,0x01,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref UInt128 xor(in UInt128 lhs, in UInt128 rhs, out UInt128 dst)
; location: [7FFDD9B5EF00h, 7FFDD9B5EF45h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 01
000ah mov rcx,[rcx+8]               ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(4 bytes) = 48 8b 49 08
000eh vmovq xmm0,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c0
0013h vpinsrq xmm0,xmm0,rcx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RCX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c1 01
0019h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 02
001ch mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(4 bytes) = 48 8b 52 08
0020h vmovq xmm1,rax                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM1,RAX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c8
0025h vpinsrq xmm1,xmm1,rdx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM1,XMM1,RDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f1 22 ca 01
002bh vpxor xmm0,xmm0,xmm1          ; VPXOR(VEX_Vpxor_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 ef c1
002fh vmovapd [rsp],xmm0            ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 f9 29 04 24
0034h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
0039h vmovdqu xmmword ptr [r8],xmm0 ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R8:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 00
003eh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0041h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xorBytes => new byte[70]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x8B,0x01,0x48,0x8B,0x49,0x08,0xC4,0xE1,0xF9,0x6E,0xC0,0xC4,0xE3,0xF9,0x22,0xC1,0x01,0x48,0x8B,0x02,0x48,0x8B,0x52,0x08,0xC4,0xE1,0xF9,0x6E,0xC8,0xC4,0xE3,0xF1,0x22,0xCA,0x01,0xC5,0xF9,0xEF,0xC1,0xC5,0xF9,0x29,0x04,0x24,0xC5,0xFA,0x6F,0x04,0x24,0xC4,0xC1,0x7A,0x7F,0x00,0x49,0x8B,0xC0,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt128 bslli(UInt128 src, byte bytes)
; location: [7FFDD9B5EF60h, 7FFDD9B5EFB4h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,40h                   ; SUB(Sub_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 ec 40
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000ah mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 30
000fh mov [rsp+38h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 38
0014h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0017h mov rcx,[rdx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RDX:br,DS:sr)]        encoding(3 bytes) = 48 8b 0a
001ah mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,DS:sr)]        encoding(4 bytes) = 48 8b 52 08
001eh vmovq xmm0,rcx                ; VMOVQ(VEX_Vmovq_xmm_rm64) [XMM0,RCX]                 encoding(VEX, 5 bytes) = c4 e1 f9 6e c1
0023h vpinsrq xmm0,xmm0,rdx,1       ; VPINSRQ(VEX_Vpinsrq_xmm_xmm_rm64_imm8) [XMM0,XMM0,RDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 f9 22 c2 01
0029h lea rcx,[rsp+30h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 30
002eh vmovapd [rsp+20h],xmm0        ; VMOVAPD(VEX_Vmovapd_xmmm128_xmm) [mem(Packed128_Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 f9 29 44 24 20
0034h lea rdx,[rsp+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 54 24 20
0039h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
003dh call 7FFDD9498B50h            ; CALL(Call_rel32_64) [FFFFFFFFFF939BF0h:jmp64]        encoding(5 bytes) = e8 ae 9b 93 ff
0042h vmovdqu xmm0,xmmword ptr [rsp+30h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 30
0048h vmovdqu xmmword ptr [rsi],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSI:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 06
004ch mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
004fh add rsp,40h                   ; ADD(Add_rm64_imm8) [RSP,40h:imm64]                   encoding(4 bytes) = 48 83 c4 40
0053h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0054h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bslliBytes => new byte[85]{0x56,0x48,0x83,0xEC,0x40,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x30,0x48,0x89,0x44,0x24,0x38,0x48,0x8B,0xF1,0x48,0x8B,0x0A,0x48,0x8B,0x52,0x08,0xC4,0xE1,0xF9,0x6E,0xC1,0xC4,0xE3,0xF9,0x22,0xC2,0x01,0x48,0x8D,0x4C,0x24,0x30,0xC5,0xF9,0x29,0x44,0x24,0x20,0x48,0x8D,0x54,0x24,0x20,0x45,0x0F,0xB6,0xC0,0xE8,0xAE,0x9B,0x93,0xFF,0xC5,0xFA,0x6F,0x44,0x24,0x30,0xC5,0xFA,0x7F,0x06,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x40,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte between(sbyte src, byte i0, byte i1)
; location: [7FFDD9B5EFD0h, 7FFDD9B5EFF8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0009h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000ch sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000eh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh movsx rdx,cl                  ; MOVSX(Movsx_r64_rm8) [RDX,CL]                        encoding(4 bytes) = 48 0f be d1
001fh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0024h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x2B,0xC2,0xFF,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBE,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte between(byte src, byte i0, byte i1)
; location: [7FFDD9B5F010h, 7FFDD9B5F036h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0009h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000ch sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000eh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
001eh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0023h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[39]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x2B,0xC2,0xFF,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB6,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short between(short src, byte i0, byte i1)
; location: [7FFDD9B5F050h, 7FFDD9B5F078h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0009h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000ch sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000eh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh movsx rdx,cx                  ; MOVSX(Movsx_r64_rm16) [RDX,CX]                       encoding(4 bytes) = 48 0f bf d1
001fh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0024h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x2B,0xC2,0xFF,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBF,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort between(ushort src, byte i0, byte i1)
; location: [7FFDD9B5F090h, 7FFDD9B5F0B6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0009h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000ch sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000eh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh movzx edx,cx                  ; MOVZX(Movzx_r32_rm16) [EDX,CX]                       encoding(3 bytes) = 0f b7 d1
001eh bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
0023h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[39]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x2B,0xC2,0xFF,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB7,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint between(uint src, byte i0, byte i1)
; location: [7FFDD9B5F0D0h, 7FFDD9B5F0F0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0009h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000ch sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000eh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x2B,0xC2,0xFF,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int between(int src, byte i0, byte i1)
; location: [7FFDD9B5F110h, 7FFDD9B5F130h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0009h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000ch sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000eh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x2B,0xC2,0xFF,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong between(ulong src, byte i0, byte i1)
; location: [7FFDD9B5F150h, 7FFDD9B5F170h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0009h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000ch sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000eh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x2B,0xC2,0xFF,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long between(long src, byte i0, byte i1)
; location: [7FFDD9B5F190h, 7FFDD9B5F1B0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,r8b                 ; MOVZX(Movzx_r32_rm8) [EAX,R8L]                       encoding(4 bytes) = 41 0f b6 c0
0009h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000ch sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
000eh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
0016h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0018h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001bh bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xB6,0xC0,0x0F,0xB6,0xD2,0x2B,0xC2,0xFF,0xC0,0x0F,0xB6,0xC0,0xC1,0xE0,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: float between(float src, byte i0, byte i1)
; location: [7FFDD9B5F1D0h, 7FFDD9B5F206h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
000bh mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 04
000fh movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0013h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0016h sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
0018h inc ecx                       ; INC(Inc_rm32) [ECX]                                  encoding(2 bytes) = ff c1
001ah movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
001dh shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
0020h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0022h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0025h bextr eax,eax,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EAX,EDX]          encoding(VEX, 5 bytes) = c4 e2 68 f7 c0
002ah mov [rsp],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(3 bytes) = 89 04 24
002dh vmovss xmm0,dword ptr [rsp]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 5 bytes) = c5 fa 10 04 24
0032h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[55]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFA,0x11,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0x41,0x0F,0xB6,0xC8,0x0F,0xB6,0xD2,0x2B,0xCA,0xFF,0xC1,0x0F,0xB6,0xC9,0xC1,0xE1,0x08,0x0B,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0x68,0xF7,0xC0,0x89,0x04,0x24,0xC5,0xFA,0x10,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: double between(double src, byte i0, byte i1)
; location: [7FFDD9B5F220h, 7FFDD9B5F25Ch]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
000dh mov rax,[rsp+10h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 10
0012h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0016h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0019h sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
001bh inc ecx                       ; INC(Inc_rm32) [ECX]                                  encoding(2 bytes) = ff c1
001dh movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0020h shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
0023h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0025h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0028h bextr rax,rax,rdx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RAX,RDX]          encoding(VEX, 5 bytes) = c4 e2 e8 f7 c0
002dh mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 08
0032h vmovsd xmm0,qword ptr [rsp+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 08
0038h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
003ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> betweenBytes => new byte[61]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x8B,0x44,0x24,0x10,0x41,0x0F,0xB6,0xC8,0x0F,0xB6,0xD2,0x2B,0xCA,0xFF,0xC1,0x0F,0xB6,0xC9,0xC1,0xE1,0x08,0x0B,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0xE8,0xF7,0xC0,0x48,0x89,0x44,0x24,0x08,0xC5,0xFB,0x10,0x44,0x24,0x08,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte bitmap(in sbyte src, byte srcOffset, byte len, byte dstOffset, ref sbyte dst)
; location: [7FFDD9B5F280h, 7FFDD9B5F2C1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movsx r11,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [R11,mem(8i,RAX:br,DS:sr)]      encoding(4 bytes) = 4c 0f be 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11b                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R11L]          encoding(3 bytes) = 44 88 18
001bh movsx rcx,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [RCX,mem(8i,RAX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 08
001fh movsx r9,byte ptr [r10]       ; MOVSX(Movsx_r64_rm8) [R9,mem(8i,R10:br,DS:sr)]       encoding(4 bytes) = 4d 0f be 0a
0023h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0026h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002ah shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002eh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0031h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0034h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0039h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
003dh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003fh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[66]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x4C,0x0F,0xBE,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x44,0x88,0x18,0x48,0x0F,0xBE,0x08,0x4D,0x0F,0xBE,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x48,0x0F,0xBE,0xD2,0x0B,0xD1,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte bitmap(in byte src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
; location: [7FFDD9B5F2E0h, 7FFDD9B5F31Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx r11d,byte ptr [rax]     ; MOVZX(Movzx_r32_rm8) [R11D,mem(8u,RAX:br,DS:sr)]     encoding(4 bytes) = 44 0f b6 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11b                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R11L]          encoding(3 bytes) = 44 88 18
001bh movzx ecx,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RAX:br,DS:sr)]      encoding(3 bytes) = 0f b6 08
001eh movzx r9d,byte ptr [r10]      ; MOVZX(Movzx_r32_rm8) [R9D,mem(8u,R10:br,DS:sr)]      encoding(4 bytes) = 45 0f b6 0a
0022h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0025h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0029h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002dh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0030h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0033h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0038h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
003bh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003dh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
003fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[64]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x44,0x0F,0xB6,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x44,0x88,0x18,0x0F,0xB6,0x08,0x45,0x0F,0xB6,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0F,0xB6,0xD2,0x0B,0xD1,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short bitmap(in byte src, byte srcOffset, byte len, byte dstOffset, ref short dst)
; location: [7FFDD9B5F330h, 7FFDD9B5F372h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movsx r11,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [R11,mem(16i,RAX:br,DS:sr)]    encoding(4 bytes) = 4c 0f bf 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11w                ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R11W]       encoding(4 bytes) = 66 44 89 18
001ch movsx rcx,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [RCX,mem(16i,RAX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 08
0020h movzx r9d,byte ptr [r10]      ; MOVZX(Movzx_r32_rm8) [R9D,mem(8u,R10:br,DS:sr)]      encoding(4 bytes) = 45 0f b6 0a
0024h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0027h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002bh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002fh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0032h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0035h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
003ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
003dh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003fh mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 10
0042h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[67]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x4C,0x0F,0xBF,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x66,0x44,0x89,0x18,0x48,0x0F,0xBF,0x08,0x45,0x0F,0xB6,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0F,0xB6,0xD2,0x0B,0xD1,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort bitmap(in byte src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
; location: [7FFDD9B5F390h, 7FFDD9B5F3D1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx r11d,word ptr [rax]     ; MOVZX(Movzx_r32_rm16) [R11D,mem(16u,RAX:br,DS:sr)]   encoding(4 bytes) = 44 0f b7 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11w                ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R11W]       encoding(4 bytes) = 66 44 89 18
001ch movzx ecx,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [ECX,mem(16u,RAX:br,DS:sr)]    encoding(3 bytes) = 0f b7 08
001fh movzx r9d,byte ptr [r10]      ; MOVZX(Movzx_r32_rm8) [R9D,mem(8u,R10:br,DS:sr)]      encoding(4 bytes) = 45 0f b6 0a
0023h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0026h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002ah shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002eh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0031h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0034h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0039h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
003ch or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003eh mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 10
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[66]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x44,0x0F,0xB7,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x66,0x44,0x89,0x18,0x0F,0xB7,0x08,0x45,0x0F,0xB6,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0F,0xB6,0xD2,0x0B,0xD1,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int bitmap(in byte src, byte srcOffset, byte len, byte dstOffset, ref int dst)
; location: [7FFDD9B5F3F0h, 7FFDD9B5F426h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,DS:sr),CL]          encoding(2 bytes) = d3 20
0013h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0015h movzx r9d,byte ptr [r10]      ; MOVZX(Movzx_r32_rm8) [R9D,mem(8u,R10:br,DS:sr)]      encoding(4 bytes) = 45 0f b6 0a
0019h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001ch movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0020h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0024h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0027h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002ah bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
002fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0032h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0034h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0xD3,0x20,0x8B,0x08,0x45,0x0F,0xB6,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0F,0xB6,0xD2,0x0B,0xD1,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint bitmap(in byte src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
; location: [7FFDD9B5F440h, 7FFDD9B5F476h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,DS:sr),CL]          encoding(2 bytes) = d3 20
0013h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0015h movzx r9d,byte ptr [r10]      ; MOVZX(Movzx_r32_rm8) [R9D,mem(8u,R10:br,DS:sr)]      encoding(4 bytes) = 45 0f b6 0a
0019h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001ch movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0020h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0024h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0027h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002ah bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
002fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0032h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0034h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0xD3,0x20,0x8B,0x08,0x45,0x0F,0xB6,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0F,0xB6,0xD2,0x0B,0xD1,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long bitmap(in byte src, byte srcOffset, byte len, byte dstOffset, ref long dst)
; location: [7FFDD9B5F490h, 7FFDD9B5F4CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 08
0017h movzx r9d,byte ptr [r10]      ; MOVZX(Movzx_r32_rm8) [R9D,mem(8u,R10:br,DS:sr)]      encoding(4 bytes) = 45 0f b6 0a
001bh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001eh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0022h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0026h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0029h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002ch bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0031h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0034h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0037h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[59]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x45,0x0F,0xB6,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0F,0xB6,0xD2,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong bitmap(in byte src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
; location: [7FFDD9B5F4E0h, 7FFDD9B5F51Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 08
0017h movzx r9d,byte ptr [r10]      ; MOVZX(Movzx_r32_rm8) [R9D,mem(8u,R10:br,DS:sr)]      encoding(4 bytes) = 45 0f b6 0a
001bh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001eh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0022h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0026h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0029h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002ch bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0031h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0034h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0037h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[59]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x45,0x0F,0xB6,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0F,0xB6,0xD2,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte bitmap(in short src, byte srcOffset, byte len, byte dstOffset, ref sbyte dst)
; location: [7FFDD9B5F530h, 7FFDD9B5F575h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movsx r11,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [R11,mem(8i,RAX:br,DS:sr)]      encoding(4 bytes) = 4c 0f be 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11b                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R11L]          encoding(3 bytes) = 44 88 18
001bh movsx rcx,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [RCX,mem(8i,RAX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 08
001fh movsx r9,word ptr [r10]       ; MOVSX(Movsx_r64_rm16) [R9,mem(16i,R10:br,DS:sr)]     encoding(4 bytes) = 4d 0f bf 0a
0023h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0026h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002ah shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002eh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0031h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0034h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0039h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
003dh movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
0041h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0043h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[70]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x4C,0x0F,0xBE,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x44,0x88,0x18,0x48,0x0F,0xBE,0x08,0x4D,0x0F,0xBF,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x48,0x0F,0xBF,0xD2,0x48,0x0F,0xBE,0xD2,0x0B,0xD1,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte bitmap(in short src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
; location: [7FFDD9B5F590h, 7FFDD9B5F5D3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx r11d,byte ptr [rax]     ; MOVZX(Movzx_r32_rm8) [R11D,mem(8u,RAX:br,DS:sr)]     encoding(4 bytes) = 44 0f b6 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11b                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R11L]          encoding(3 bytes) = 44 88 18
001bh movzx ecx,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RAX:br,DS:sr)]      encoding(3 bytes) = 0f b6 08
001eh movsx r9,word ptr [r10]       ; MOVSX(Movsx_r64_rm16) [R9,mem(16i,R10:br,DS:sr)]     encoding(4 bytes) = 4d 0f bf 0a
0022h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0025h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0029h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002dh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0030h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0033h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0038h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
003ch movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
003fh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0041h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
0043h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[68]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x44,0x0F,0xB6,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x44,0x88,0x18,0x0F,0xB6,0x08,0x4D,0x0F,0xBF,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x48,0x0F,0xBF,0xD2,0x0F,0xB6,0xD2,0x0B,0xD1,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short bitmap(in short src, byte srcOffset, byte len, byte dstOffset, ref short dst)
; location: [7FFDD9B5F5F0h, 7FFDD9B5F633h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movsx r11,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [R11,mem(16i,RAX:br,DS:sr)]    encoding(4 bytes) = 4c 0f bf 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11w                ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R11W]       encoding(4 bytes) = 66 44 89 18
001ch movsx rcx,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [RCX,mem(16i,RAX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 08
0020h movsx r9,word ptr [r10]       ; MOVSX(Movsx_r64_rm16) [R9,mem(16i,R10:br,DS:sr)]     encoding(4 bytes) = 4d 0f bf 0a
0024h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0027h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002bh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002fh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0032h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0035h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
003ah movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
003eh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0040h mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 10
0043h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[68]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x4C,0x0F,0xBF,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x66,0x44,0x89,0x18,0x48,0x0F,0xBF,0x08,0x4D,0x0F,0xBF,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x48,0x0F,0xBF,0xD2,0x0B,0xD1,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort bitmap(in short src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
; location: [7FFDD9B5F650h, 7FFDD9B5F695h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx r11d,word ptr [rax]     ; MOVZX(Movzx_r32_rm16) [R11D,mem(16u,RAX:br,DS:sr)]   encoding(4 bytes) = 44 0f b7 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11w                ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R11W]       encoding(4 bytes) = 66 44 89 18
001ch movzx ecx,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [ECX,mem(16u,RAX:br,DS:sr)]    encoding(3 bytes) = 0f b7 08
001fh movsx r9,word ptr [r10]       ; MOVSX(Movsx_r64_rm16) [R9,mem(16i,R10:br,DS:sr)]     encoding(4 bytes) = 4d 0f bf 0a
0023h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0026h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002ah shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002eh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0031h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0034h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0039h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
003dh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0040h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0042h mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 10
0045h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[70]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x44,0x0F,0xB7,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x66,0x44,0x89,0x18,0x0F,0xB7,0x08,0x4D,0x0F,0xBF,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x48,0x0F,0xBF,0xD2,0x0F,0xB7,0xD2,0x0B,0xD1,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort bitmap(in ushort src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
; location: [7FFDD9B5F6B0h, 7FFDD9B5F6F1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx r11d,word ptr [rax]     ; MOVZX(Movzx_r32_rm16) [R11D,mem(16u,RAX:br,DS:sr)]   encoding(4 bytes) = 44 0f b7 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11w                ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R11W]       encoding(4 bytes) = 66 44 89 18
001ch movzx ecx,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [ECX,mem(16u,RAX:br,DS:sr)]    encoding(3 bytes) = 0f b7 08
001fh movzx r9d,word ptr [r10]      ; MOVZX(Movzx_r32_rm16) [R9D,mem(16u,R10:br,DS:sr)]    encoding(4 bytes) = 45 0f b7 0a
0023h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0026h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002ah shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002eh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0031h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0034h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0039h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
003ch or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003eh mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 10
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[66]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x44,0x0F,0xB7,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x66,0x44,0x89,0x18,0x0F,0xB7,0x08,0x45,0x0F,0xB7,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0F,0xB7,0xD2,0x0B,0xD1,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint bitmap(in ushort src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
; location: [7FFDD9B5F710h, 7FFDD9B5F746h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,DS:sr),CL]          encoding(2 bytes) = d3 20
0013h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0015h movzx r9d,word ptr [r10]      ; MOVZX(Movzx_r32_rm16) [R9D,mem(16u,R10:br,DS:sr)]    encoding(4 bytes) = 45 0f b7 0a
0019h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001ch movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0020h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0024h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0027h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002ah bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
002fh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0032h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0034h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0xD3,0x20,0x8B,0x08,0x45,0x0F,0xB7,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0F,0xB7,0xD2,0x0B,0xD1,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong bitmap(in ushort src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
; location: [7FFDD9B5F760h, 7FFDD9B5F79Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 08
0017h movzx r9d,word ptr [r10]      ; MOVZX(Movzx_r32_rm16) [R9D,mem(16u,R10:br,DS:sr)]    encoding(4 bytes) = 45 0f b7 0a
001bh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001eh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0022h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0026h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0029h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002ch bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0031h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0034h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0037h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[59]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x45,0x0F,0xB7,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0F,0xB7,0xD2,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int bitmap(in int src, byte srcOffset, byte len, byte dstOffset, ref int dst)
; location: [7FFDD9B5F7B0h, 7FFDD9B5F7E2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,DS:sr),CL]          encoding(2 bytes) = d3 20
0013h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0015h mov r9d,[r10]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,R10:br,DS:sr)]        encoding(3 bytes) = 45 8b 0a
0018h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001bh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001fh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0023h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0026h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0029h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
002eh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0030h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[51]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0xD3,0x20,0x8B,0x08,0x45,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0B,0xD1,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long bitmap(in int src, byte srcOffset, byte len, byte dstOffset, ref long dst)
; location: [7FFDD9B5F800h, 7FFDD9B5F839h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 08
0017h mov r9d,[r10]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,R10:br,DS:sr)]        encoding(3 bytes) = 45 8b 0a
001ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0021h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0025h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0028h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002bh bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0030h movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
0033h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0036h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
0039h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[58]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x45,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x48,0x63,0xD2,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong bitmap(in int src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
; location: [7FFDD9B5F850h, 7FFDD9B5F888h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 08
0017h mov r9d,[r10]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,R10:br,DS:sr)]        encoding(3 bytes) = 45 8b 0a
001ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0021h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0025h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0028h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002bh bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0030h mov edx,edx                   ; MOV(Mov_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 8b d2
0032h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0035h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
0038h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[57]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x45,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x8B,0xD2,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint bitmap(in uint src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
; location: [7FFDD9B5F8A0h, 7FFDD9B5F8D2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,DS:sr),CL]          encoding(2 bytes) = d3 20
0013h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0015h mov r9d,[r10]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,R10:br,DS:sr)]        encoding(3 bytes) = 45 8b 0a
0018h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001bh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001fh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0023h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0026h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0029h bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
002eh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0030h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[51]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0xD3,0x20,0x8B,0x08,0x45,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x0B,0xD1,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong bitmap(in uint src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
; location: [7FFDD9B5F8F0h, 7FFDD9B5F928h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 08
0017h mov r9d,[r10]                 ; MOV(Mov_r32_rm32) [R9D,mem(32u,R10:br,DS:sr)]        encoding(3 bytes) = 45 8b 0a
001ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0021h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0025h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0028h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002bh bextr edx,r9d,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,R9D,EDX]          encoding(VEX, 5 bytes) = c4 c2 68 f7 d1
0030h mov edx,edx                   ; MOV(Mov_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 8b d2
0032h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0035h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
0038h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[57]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x45,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0x68,0xF7,0xD1,0x8B,0xD2,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long bitmap(in long src, byte srcOffset, byte len, byte dstOffset, ref long dst)
; location: [7FFDD9B5F940h, 7FFDD9B5F976h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 08
0017h mov r9,[r10]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,R10:br,DS:sr)]         encoding(3 bytes) = 4d 8b 0a
001ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0021h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0025h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0028h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002bh bextr rdx,r9,rdx              ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R9,RDX]           encoding(VEX, 5 bytes) = c4 c2 e8 f7 d1
0030h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0033h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x4D,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD1,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte bitmap(in ulong src, byte srcOffset, byte len, byte dstOffset, ref sbyte dst)
; location: [7FFDD9B5F990h, 7FFDD9B5F9D0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movsx r11,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [R11,mem(8i,RAX:br,DS:sr)]      encoding(4 bytes) = 4c 0f be 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11b                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R11L]          encoding(3 bytes) = 44 88 18
001bh movsx rcx,byte ptr [rax]      ; MOVSX(Movsx_r64_rm8) [RCX,mem(8i,RAX:br,DS:sr)]      encoding(4 bytes) = 48 0f be 08
001fh mov r9,[r10]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,R10:br,DS:sr)]         encoding(3 bytes) = 4d 8b 0a
0022h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0025h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0029h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002dh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0030h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0033h bextr rdx,r9,rdx              ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R9,RDX]           encoding(VEX, 5 bytes) = c4 c2 e8 f7 d1
0038h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
003ch or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003eh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
0040h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[65]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x4C,0x0F,0xBE,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x44,0x88,0x18,0x48,0x0F,0xBE,0x08,0x4D,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD1,0x48,0x0F,0xBE,0xD2,0x0B,0xD1,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte bitmap(in ulong src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
; location: [7FFDD9B5F9F0h, 7FFDD9B5FA2Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx r11d,byte ptr [rax]     ; MOVZX(Movzx_r32_rm8) [R11D,mem(8u,RAX:br,DS:sr)]     encoding(4 bytes) = 44 0f b6 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11b                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),R11L]          encoding(3 bytes) = 44 88 18
001bh movzx ecx,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RAX:br,DS:sr)]      encoding(3 bytes) = 0f b6 08
001eh mov r9,[r10]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,R10:br,DS:sr)]         encoding(3 bytes) = 4d 8b 0a
0021h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0024h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0028h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002ch or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
002fh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0032h bextr rdx,r9,rdx              ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R9,RDX]           encoding(VEX, 5 bytes) = c4 c2 e8 f7 d1
0037h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
003ah or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003ch mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,DS:sr),DL]            encoding(2 bytes) = 88 10
003eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[63]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x44,0x0F,0xB6,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x44,0x88,0x18,0x0F,0xB6,0x08,0x4D,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD1,0x0F,0xB6,0xD2,0x0B,0xD1,0x88,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short bitmap(in ulong src, byte srcOffset, byte len, byte dstOffset, ref short dst)
; location: [7FFDD9B5FA40h, 7FFDD9B5FA82h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movsx r11,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [R11,mem(16i,RAX:br,DS:sr)]    encoding(4 bytes) = 4c 0f bf 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11w                ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R11W]       encoding(4 bytes) = 66 44 89 18
001ch movsx rcx,word ptr [rax]      ; MOVSX(Movsx_r64_rm16) [RCX,mem(16i,RAX:br,DS:sr)]    encoding(4 bytes) = 48 0f bf 08
0020h mov r9,[r10]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,R10:br,DS:sr)]         encoding(3 bytes) = 4d 8b 0a
0023h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0026h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
002ah shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002eh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0031h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0034h bextr rdx,r9,rdx              ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R9,RDX]           encoding(VEX, 5 bytes) = c4 c2 e8 f7 d1
0039h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
003dh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003fh mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 10
0042h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[67]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x4C,0x0F,0xBF,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x66,0x44,0x89,0x18,0x48,0x0F,0xBF,0x08,0x4D,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD1,0x48,0x0F,0xBF,0xD2,0x0B,0xD1,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort bitmap(in ulong src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
; location: [7FFDD9B5FAA0h, 7FFDD9B5FAE0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx r11d,word ptr [rax]     ; MOVZX(Movzx_r32_rm16) [R11D,mem(16u,RAX:br,DS:sr)]   encoding(4 bytes) = 44 0f b7 18
0011h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0015h shl r11d,cl                   ; SHL(Shl_rm32_CL) [R11D,CL]                           encoding(3 bytes) = 41 d3 e3
0018h mov [rax],r11w                ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),R11W]       encoding(4 bytes) = 66 44 89 18
001ch movzx ecx,word ptr [rax]      ; MOVZX(Movzx_r32_rm16) [ECX,mem(16u,RAX:br,DS:sr)]    encoding(3 bytes) = 0f b7 08
001fh mov r9,[r10]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,R10:br,DS:sr)]         encoding(3 bytes) = 4d 8b 0a
0022h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0025h movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0029h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
002dh or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0030h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0033h bextr rdx,r9,rdx              ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R9,RDX]           encoding(VEX, 5 bytes) = c4 c2 e8 f7 d1
0038h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
003bh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
003dh mov [rax],dx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,DS:sr),DX]         encoding(3 bytes) = 66 89 10
0040h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[65]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x44,0x0F,0xB7,0x18,0x41,0x0F,0xB6,0xC9,0x41,0xD3,0xE3,0x66,0x44,0x89,0x18,0x0F,0xB7,0x08,0x4D,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD1,0x0F,0xB7,0xD2,0x0B,0xD1,0x66,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int bitmap(in ulong src, byte srcOffset, byte len, byte dstOffset, ref int dst)
; location: [7FFDD9B5FB00h, 7FFDD9B5FB32h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,DS:sr),CL]          encoding(2 bytes) = d3 20
0013h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0015h mov r9,[r10]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,R10:br,DS:sr)]         encoding(3 bytes) = 4d 8b 0a
0018h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001bh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001fh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0023h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0026h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0029h bextr rdx,r9,rdx              ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R9,RDX]           encoding(VEX, 5 bytes) = c4 c2 e8 f7 d1
002eh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0030h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[51]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0xD3,0x20,0x8B,0x08,0x4D,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD1,0x0B,0xD1,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint bitmap(in ulong src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
; location: [7FFDD9B5FB50h, 7FFDD9B5FB82h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl dword ptr [rax],cl        ; SHL(Shl_rm32_CL) [mem(32u,RAX:br,DS:sr),CL]          encoding(2 bytes) = d3 20
0013h mov ecx,[rax]                 ; MOV(Mov_r32_rm32) [ECX,mem(32u,RAX:br,DS:sr)]        encoding(2 bytes) = 8b 08
0015h mov r9,[r10]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,R10:br,DS:sr)]         encoding(3 bytes) = 4d 8b 0a
0018h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001bh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
001fh shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0023h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0026h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
0029h bextr rdx,r9,rdx              ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R9,RDX]           encoding(VEX, 5 bytes) = c4 c2 e8 f7 d1
002eh or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0030h mov [rax],edx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,DS:sr),EDX]        encoding(2 bytes) = 89 10
0032h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[51]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0xD3,0x20,0x8B,0x08,0x4D,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD1,0x0B,0xD1,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long bitmap(in ulong src, byte srcOffset, byte len, byte dstOffset, ref long dst)
; location: [7FFDD9B5FBA0h, 7FFDD9B5FBD6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 08
0017h mov r9,[r10]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,R10:br,DS:sr)]         encoding(3 bytes) = 4d 8b 0a
001ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0021h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0025h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0028h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002bh bextr rdx,r9,rdx              ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R9,RDX]           encoding(VEX, 5 bytes) = c4 c2 e8 f7 d1
0030h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0033h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x4D,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD1,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong bitmap(in ulong src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
; location: [7FFDD9B5FBF0h, 7FFDD9B5FC26h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rcx                   ; MOV(Mov_r64_rm64) [R10,RCX]                          encoding(3 bytes) = 4c 8b d1
0008h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
000dh movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0011h shl qword ptr [rax],cl        ; SHL(Shl_rm64_CL) [mem(64u,RAX:br,DS:sr),CL]          encoding(3 bytes) = 48 d3 20
0014h mov rcx,[rax]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RAX:br,DS:sr)]        encoding(3 bytes) = 48 8b 08
0017h mov r9,[r10]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,R10:br,DS:sr)]         encoding(3 bytes) = 4d 8b 0a
001ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0021h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0025h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0028h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002bh bextr rdx,r9,rdx              ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,R9,RDX]           encoding(VEX, 5 bytes) = c4 c2 e8 f7 d1
0030h or rdx,rcx                    ; OR(Or_r64_rm64) [RDX,RCX]                            encoding(3 bytes) = 48 0b d1
0033h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,DS:sr),RDX]        encoding(3 bytes) = 48 89 10
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD1,0x48,0x8B,0x44,0x24,0x28,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0x20,0x48,0x8B,0x08,0x4D,0x8B,0x0A,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xC2,0xE8,0xF7,0xD1,0x48,0x0B,0xD1,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref float bitmap(in float src, byte srcOffset, byte len, byte dstOffset, ref float dst)
; location: [7FFDD9B5FC40h, 7FFDD9B5FCA8h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rsp+40h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 40
000ch vmovss xmm0,dword ptr [rcx]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 10 01
0010h vmovss dword ptr [rsp+14h],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 14
0016h mov ecx,[rsp+14h]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 4c 24 14
001ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001dh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0021h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0025h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0028h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002bh bextr edx,ecx,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EDX,ECX,EDX]          encoding(VEX, 5 bytes) = c4 e2 68 f7 d1
0030h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0034h shl edx,cl                    ; SHL(Shl_rm32_CL) [EDX,CL]                            encoding(2 bytes) = d3 e2
0036h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
003ah vcvtsi2ss xmm0,xmm0,edx       ; VCVTSI2SS(VEX_Vcvtsi2ss_xmm_xmm_rm32) [XMM0,XMM0,EDX] encoding(VEX, 4 bytes) = c5 fa 2a c2
003eh vmovss xmm1,dword ptr [rax]   ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM1,mem(Float32,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 10 08
0042h vmovss dword ptr [rsp+10h],xmm1; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fa 11 4c 24 10
0048h mov edx,[rsp+10h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 10
004ch vmovss dword ptr [rsp+0Ch],xmm0; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 0c
0052h or edx,[rsp+0Ch]              ; OR(Or_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]          encoding(4 bytes) = 0b 54 24 0c
0056h mov [rsp+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EDX]        encoding(4 bytes) = 89 54 24 08
005ah vmovss xmm0,dword ptr [rsp+8] ; VMOVSS(VEX_Vmovss_xmm_m32) [XMM0,mem(Float32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 10 44 24 08
0060h vmovss dword ptr [rax],xmm0   ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RAX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 11 00
0064h add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0068h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[105]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x48,0x8B,0x44,0x24,0x40,0xC5,0xFA,0x10,0x01,0xC5,0xFA,0x11,0x44,0x24,0x14,0x8B,0x4C,0x24,0x14,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xE2,0x68,0xF7,0xD1,0x41,0x0F,0xB6,0xC9,0xD3,0xE2,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x2A,0xC2,0xC5,0xFA,0x10,0x08,0xC5,0xFA,0x11,0x4C,0x24,0x10,0x8B,0x54,0x24,0x10,0xC5,0xFA,0x11,0x44,0x24,0x0C,0x0B,0x54,0x24,0x0C,0x89,0x54,0x24,0x08,0xC5,0xFA,0x10,0x44,0x24,0x08,0xC5,0xFA,0x11,0x00,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref double bitmap(in double src, byte srcOffset, byte len, byte dstOffset, ref double dst)
; location: [7FFDD9B5FCD0h, 7FFDD9B5FD3Eh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h mov rax,[rsp+50h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 50
000ch vmovsd xmm0,qword ptr [rcx]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb 10 01
0010h vmovsd qword ptr [rsp+20h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 20
0016h mov rcx,[rsp+20h]             ; MOV(Mov_r64_rm64) [RCX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 4c 24 20
001bh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
001eh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0022h shl r8d,8                     ; SHL(Shl_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e0 08
0026h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
0029h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
002ch bextr rdx,rcx,rdx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RDX,RCX,RDX]          encoding(VEX, 5 bytes) = c4 e2 e8 f7 d1
0031h movzx ecx,r9b                 ; MOVZX(Movzx_r32_rm8) [ECX,R9L]                       encoding(4 bytes) = 41 0f b6 c9
0035h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0038h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
003ch vcvtsi2sd xmm0,xmm0,rdx       ; VCVTSI2SD(VEX_Vcvtsi2sd_xmm_xmm_rm64) [XMM0,XMM0,RDX] encoding(VEX, 5 bytes) = c4 e1 fb 2a c2
0041h vmovsd xmm1,qword ptr [rax]   ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM1,mem(Float64,RAX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fb 10 08
0045h vmovsd qword ptr [rsp+18h],xmm1; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM1] encoding(VEX, 6 bytes) = c5 fb 11 4c 24 18
004bh mov rdx,[rsp+18h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 54 24 18
0050h vmovsd qword ptr [rsp+10h],xmm0; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fb 11 44 24 10
0056h or rdx,[rsp+10h]              ; OR(Or_r64_rm64) [RDX,mem(64u,RSP:br,SS:sr)]          encoding(5 bytes) = 48 0b 54 24 10
005bh mov [rsp+8],rdx               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(5 bytes) = 48 89 54 24 08
0060h vmovsd xmm0,qword ptr [rsp+8] ; VMOVSD(VEX_Vmovsd_xmm_m64) [XMM0,mem(Float64,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fb 10 44 24 08
0066h vmovsd qword ptr [rax],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RAX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fb 11 00
006ah add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
006eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitmapBytes => new byte[111]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0x48,0x8B,0x44,0x24,0x50,0xC5,0xFB,0x10,0x01,0xC5,0xFB,0x11,0x44,0x24,0x20,0x48,0x8B,0x4C,0x24,0x20,0x0F,0xB6,0xD2,0x45,0x0F,0xB6,0xC0,0x41,0xC1,0xE0,0x08,0x41,0x0B,0xD0,0x0F,0xB7,0xD2,0xC4,0xE2,0xE8,0xF7,0xD1,0x41,0x0F,0xB6,0xC9,0x48,0xD3,0xE2,0xC5,0xF8,0x57,0xC0,0xC4,0xE1,0xFB,0x2A,0xC2,0xC5,0xFB,0x10,0x08,0xC5,0xFB,0x11,0x4C,0x24,0x18,0x48,0x8B,0x54,0x24,0x18,0xC5,0xFB,0x11,0x44,0x24,0x10,0x48,0x0B,0x54,0x24,0x10,0x48,0x89,0x54,0x24,0x08,0xC5,0xFB,0x10,0x44,0x24,0x08,0xC5,0xFB,0x11,0x00,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte blsi(byte src)
; location: [7FFDD9B5FD60h, 7FFDD9B5FD70h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h blsi eax,eax                  ; BLSI(VEX_Blsi_r32_rm32) [EAX,EAX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 d8
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsiBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x78,0xF3,0xD8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort blsi(ushort src)
; location: [7FFDD9B5FD90h, 7FFDD9B5FDA0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h blsi eax,eax                  ; BLSI(VEX_Blsi_r32_rm32) [EAX,EAX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 d8
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsiBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC4,0xE2,0x78,0xF3,0xD8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint blsi(uint src)
; location: [7FFDD9B5FDC0h, 7FFDD9B5FDCAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsi eax,ecx                  ; BLSI(VEX_Blsi_r32_rm32) [EAX,ECX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 d9
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsiBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x78,0xF3,0xD9,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong blsi(ulong src)
; location: [7FFDD9B5FDE0h, 7FFDD9B5FDEAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsi rax,rcx                  ; BLSI(VEX_Blsi_r64_rm64) [RAX,RCX]                    encoding(VEX, 5 bytes) = c4 e2 f8 f3 d9
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsiBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF8,0xF3,0xD9,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte blsic(byte src)
; location: [7FFDD9B5FE00h, 7FFDD9B5FE13h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000ah not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
000ch dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000eh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsicBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xD0,0xF7,0xD2,0xFF,0xC8,0x0B,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort blsic(ushort src)
; location: [7FFDD9B5FE30h, 7FFDD9B5FE43h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000ah not edx                       ; NOT(Not_rm32) [EDX]                                  encoding(2 bytes) = f7 d2
000ch dec eax                       ; DEC(Dec_rm32) [EAX]                                  encoding(2 bytes) = ff c8
000eh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsicBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x8B,0xD0,0xF7,0xD2,0xFF,0xC8,0x0B,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint blsic(uint src)
; location: [7FFDD9B5FE60h, 7FFDD9B5FE6Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h dec ecx                       ; DEC(Dec_rm32) [ECX]                                  encoding(2 bytes) = ff c9
000bh or eax,ecx                    ; OR(Or_r32_rm32) [EAX,ECX]                            encoding(2 bytes) = 0b c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsicBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC9,0x0B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong blsic(ulong src)
; location: [7FFDD9B5FE80h, 7FFDD9B5FE91h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000bh dec rcx                       ; DEC(Dec_rm64) [RCX]                                  encoding(3 bytes) = 48 ff c9
000eh or rax,rcx                    ; OR(Or_r64_rm64) [RAX,RCX]                            encoding(3 bytes) = 48 0b c1
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsicBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xFF,0xC9,0x48,0x0B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte blsmsk(byte src)
; location: [7FFDD9B5FEB0h, 7FFDD9B5FEC0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h blsmsk eax,eax                ; BLSMSK(VEX_Blsmsk_r32_rm32) [EAX,EAX]                encoding(VEX, 5 bytes) = c4 e2 78 f3 d0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmskBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x78,0xF3,0xD0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort blsmsk(ushort src)
; location: [7FFDD9B5FEE0h, 7FFDD9B5FEF0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h blsmsk eax,eax                ; BLSMSK(VEX_Blsmsk_r32_rm32) [EAX,EAX]                encoding(VEX, 5 bytes) = c4 e2 78 f3 d0
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmskBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC4,0xE2,0x78,0xF3,0xD0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint blsmsk(uint src)
; location: [7FFDD9B5FF10h, 7FFDD9B5FF1Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsmsk eax,ecx                ; BLSMSK(VEX_Blsmsk_r32_rm32) [EAX,ECX]                encoding(VEX, 5 bytes) = c4 e2 78 f3 d1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmskBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x78,0xF3,0xD1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong blsmsk(ulong src)
; location: [7FFDD9B5FF30h, 7FFDD9B5FF3Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsmsk rax,rcx                ; BLSMSK(VEX_Blsmsk_r64_rm64) [RAX,RCX]                encoding(VEX, 5 bytes) = c4 e2 f8 f3 d1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsmskBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF8,0xF3,0xD1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte blsr(byte src)
; location: [7FFDD9B5FF50h, 7FFDD9B5FF60h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h blsr eax,eax                  ; BLSR(VEX_Blsr_r32_rm32) [EAX,EAX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 c8
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsrBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x78,0xF3,0xC8,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort blsr(ushort src)
; location: [7FFDD9B5FF80h, 7FFDD9B5FF90h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h blsr eax,eax                  ; BLSR(VEX_Blsr_r32_rm32) [EAX,EAX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 c8
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsrBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC4,0xE2,0x78,0xF3,0xC8,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint blsr(uint src)
; location: [7FFDD9B5FFB0h, 7FFDD9B5FFBAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsr eax,ecx                  ; BLSR(VEX_Blsr_r32_rm32) [EAX,ECX]                    encoding(VEX, 5 bytes) = c4 e2 78 f3 c9
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsrBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x78,0xF3,0xC9,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong blsr(ulong src)
; location: [7FFDD9B5FFD0h, 7FFDD9B5FFDAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h blsr rax,rcx                  ; BLSR(VEX_Blsr_r64_rm64) [RAX,RCX]                    encoding(VEX, 5 bytes) = c4 e2 f8 f3 c9
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> blsrBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF8,0xF3,0xC9,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte bzhi(byte src, uint index)
; location: [7FFDD9B5FFF0h, 7FFDD9B60000h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h bzhi eax,eax,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c0
000dh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhiBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x68,0xF5,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort bzhi(ushort src, uint index)
; location: [7FFDD9B60020h, 7FFDD9B60030h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h bzhi eax,eax,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c0
000dh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhiBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC4,0xE2,0x68,0xF5,0xC0,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint bzhi(uint src, uint index)
; location: [7FFDD9B60050h, 7FFDD9B6005Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bzhi eax,ecx,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c1
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhiBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x68,0xF5,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong bzhi(ulong src, uint index)
; location: [7FFDD9B60070h, 7FFDD9B6007Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h bzhi rax,rcx,rax              ; BZHI(VEX_Bzhi_r64_rm64_r64) [RAX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f8 f5 c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhiBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xC4,0xE2,0xF8,0xF5,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte bzhi(ref byte src, uint index)
; location: [7FFDD9B60090h, 7FFDD9B600A2h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,byte ptr [rcx]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(3 bytes) = 0f b6 01
0008h bzhi eax,eax,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c0
000dh mov [rcx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),AL]            encoding(2 bytes) = 88 01
000fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhiBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0x01,0xC4,0xE2,0x68,0xF5,0xC0,0x88,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort bzhi(ref ushort src, uint index)
; location: [7FFDD9B600C0h, 7FFDD9B600D3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,DS:sr)]    encoding(3 bytes) = 0f b7 01
0008h bzhi eax,eax,edx              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 68 f5 c0
000dh mov [rcx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RCX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 01
0010h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhiBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x01,0xC4,0xE2,0x68,0xF5,0xC0,0x66,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint bzhi(ref uint src, uint index)
; location: [7FFDD9B600F0h, 7FFDD9B600FFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h bzhi eax,[rcx],edx            ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,mem(32u,RCX:br,DS:sr),EDX] encoding(VEX, 5 bytes) = c4 e2 68 f5 01
000ah mov [rcx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),EAX]        encoding(2 bytes) = 89 01
000ch mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhiBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x68,0xF5,0x01,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong bzhi(ref ulong src, uint index)
; location: [7FFDD9B60110h, 7FFDD9B60122h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h bzhi rax,[rcx],rax            ; BZHI(VEX_Bzhi_r64_rm64_r64) [RAX,mem(64u,RCX:br,DS:sr),RAX] encoding(VEX, 5 bytes) = c4 e2 f8 f5 01
000ch mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
000fh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bzhiBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xC4,0xE2,0xF8,0xF5,0x01,0x48,0x89,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte extract(sbyte src, byte start, byte length)
; location: [7FFDD9B60140h, 7FFDD9B60161h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h movsx rdx,cl                  ; MOVSX(Movsx_r64_rm8) [RDX,CL]                        encoding(4 bytes) = 48 0f be d1
0018h bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
001dh movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBE,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte extract(byte src, byte start, byte length)
; location: [7FFDD9B60180h, 7FFDD9B6019Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
0017h bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB6,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short extract(short src, byte start, byte length)
; location: [7FFDD9B601B0h, 7FFDD9B601D1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h movsx rdx,cx                  ; MOVSX(Movsx_r64_rm16) [RDX,CX]                       encoding(4 bytes) = 48 0f bf d1
0018h bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
001dh movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x48,0x0F,0xBF,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort extract(ushort src, byte start, byte length)
; location: [7FFDD9B601F0h, 7FFDD9B6020Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h movzx edx,cx                  ; MOVZX(Movzx_r32_rm16) [EDX,CX]                       encoding(3 bytes) = 0f b7 d1
0017h bextr eax,edx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EDX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c2
001ch movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB7,0xD1,0xC4,0xE2,0x78,0xF7,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint extract(uint src, byte start, byte length)
; location: [7FFDD9B60220h, 7FFDD9B60239h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int extract(int src, byte start, byte length)
; location: [7FFDD9B60250h, 7FFDD9B60269h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h bextr eax,ecx,eax             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,ECX,EAX]          encoding(VEX, 5 bytes) = c4 e2 78 f7 c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0x78,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long extract(long src, byte start, byte length)
; location: [7FFDD9B60280h, 7FFDD9B60299h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong extract(ulong src, byte start, byte length)
; location: [7FFDD9B602B0h, 7FFDD9B602C9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000ch shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
000fh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0011h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0014h bextr rax,rcx,rax             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RCX,RAX]          encoding(VEX, 5 bytes) = c4 e2 f8 f7 c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0x41,0x0F,0xB6,0xD0,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0xC4,0xE2,0xF8,0xF7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint extract(float src, byte start, byte length)
; location: [7FFDD9B602E0h, 7FFDD9B60307h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
000bh mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 04
000fh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0012h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0016h shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
0019h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
001bh movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
001eh bextr eax,eax,edx             ; BEXTR(VEX_Bextr_r32_rm32_r32) [EAX,EAX,EDX]          encoding(VEX, 5 bytes) = c4 e2 68 f7 c0
0023h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[40]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFA,0x11,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0x0F,0xB6,0xD2,0x41,0x0F,0xB6,0xC8,0xC1,0xE1,0x08,0x0B,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0x68,0xF7,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong extract(double src, byte start, byte length)
; location: [7FFDD9B60320h, 7FFDD9B60346h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovsd qword ptr [rsp],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 04 24
000ah mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 04 24
000eh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0011h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0015h shl ecx,8                     ; SHL(Shl_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e1 08
0018h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
001ah movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
001dh bextr rax,rax,rdx             ; BEXTR(VEX_Bextr_r64_rm64_r64) [RAX,RAX,RDX]          encoding(VEX, 5 bytes) = c4 e2 e8 f7 c0
0022h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> extractBytes => new byte[39]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFB,0x11,0x04,0x24,0x48,0x8B,0x04,0x24,0x0F,0xB6,0xD2,0x41,0x0F,0xB6,0xC8,0xC1,0xE1,0x08,0x0B,0xD1,0x0F,0xB7,0xD2,0xC4,0xE2,0xE8,0xF7,0xC0,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte gather(byte src, byte mask)
; location: [7FFDD9B60360h, 7FFDD9B60373h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte gather(sbyte src, sbyte mask)
; location: [7FFDD9B60390h, 7FFDD9B603A6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0012h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short gather(short src, short mask)
; location: [7FFDD9B603C0h, 7FFDD9B603D6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0012h movsx rax,ax                  ; MOVSX(Movsx_r64_rm16) [RAX,AX]                       encoding(4 bytes) = 48 0f bf c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x48,0x0F,0xBF,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort gather(ushort src, ushort mask)
; location: [7FFDD9B603F0h, 7FFDD9B60403h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int gather(int src, int mask)
; location: [7FFDD9B60420h, 7FFDD9B6042Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint gather(uint src, uint mask)
; location: [7FFDD9B60440h, 7FFDD9B6044Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long gather(long src, long mask)
; location: [7FFDD9B60460h, 7FFDD9B6046Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong gather(ulong src, ulong mask)
; location: [7FFDD9B60480h, 7FFDD9B6048Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint gather(float src, uint mask)
; location: [7FFDD9B604A0h, 7FFDD9B604B8h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovss dword ptr [rsp+4],xmm0 ; VMOVSS(VEX_Vmovss_m32_xmm) [mem(Float32,RSP:br,SS:sr),XMM0] encoding(VEX, 6 bytes) = c5 fa 11 44 24 04
000bh mov eax,[rsp+4]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 04
000fh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0014h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[25]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFA,0x11,0x44,0x24,0x04,0x8B,0x44,0x24,0x04,0xC4,0xE2,0x7A,0xF5,0xC2,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong gather(double src, ulong mask)
; location: [7FFDD9B604D0h, 7FFDD9B604E7h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h vmovsd qword ptr [rsp],xmm0   ; VMOVSD(VEX_Vmovsd_m64_xmm) [mem(Float64,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 fb 11 04 24
000ah mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 04 24
000eh pext rax,rax,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RAX,RDX]            encoding(VEX, 5 bytes) = c4 e2 fa f5 c2
0013h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[24]{0x50,0xC5,0xF8,0x77,0x90,0xC5,0xFB,0x11,0x04,0x24,0x48,0x8B,0x04,0x24,0xC4,0xE2,0xFA,0xF5,0xC2,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte gather(byte src, BitMask8:byte mask)
; location: [7FFDD9B60500h, 7FFDD9B60513h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort gather(ushort src, BitMask16:ushort mask)
; location: [7FFDD9B60530h, 7FFDD9B60543h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint gather(uint src, BitMask32:uint mask)
; location: [7FFDD9B60560h, 7FFDD9B6056Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong gather(ulong src, BitMask64:ulong mask)
; location: [7FFDD9B60580h, 7FFDD9B6058Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref byte gather(byte src, byte mask, ref byte dst)
; location: [7FFDD9B605A0h, 7FFDD9B605B6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h mov [r8],al                   ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),AL]             encoding(3 bytes) = 41 88 00
0013h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x41,0x88,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref sbyte gather(sbyte src, sbyte mask, ref sbyte dst)
; location: [7FFDD9B605D0h, 7FFDD9B605E8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h movsx rdx,dl                  ; MOVSX(Movsx_r64_rm8) [RDX,DL]                        encoding(4 bytes) = 48 0f be d2
000dh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0012h mov [r8],al                   ; MOV(Mov_rm8_r8) [mem(8u,R8:br,DS:sr),AL]             encoding(3 bytes) = 41 88 00
0015h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x48,0x0F,0xBE,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x41,0x88,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref short gather(short src, short mask, ref short dst)
; location: [7FFDD9B60600h, 7FFDD9B60619h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rdx,dx                  ; MOVSX(Movsx_r64_rm16) [RDX,DX]                       encoding(4 bytes) = 48 0f bf d2
000dh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0012h mov [r8],ax                   ; MOV(Mov_rm16_r16) [mem(16u,R8:br,DS:sr),AX]          encoding(4 bytes) = 66 41 89 00
0016h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBF,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x66,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort gather(ushort src, ushort mask, ref ushort dst)
; location: [7FFDD9B60630h, 7FFDD9B60647h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h mov [r8],ax                   ; MOV(Mov_rm16_r16) [mem(16u,R8:br,DS:sr),AX]          encoding(4 bytes) = 66 41 89 00
0014h mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0017h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x66,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref int gather(int src, int mask, ref int dst)
; location: [7FFDD9B60660h, 7FFDD9B60670h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
000dh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint gather(uint src, uint mask, ref uint dst)
; location: [7FFDD9B60690h, 7FFDD9B606A0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
000dh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0x41,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref long gather(long src, long mask, ref long dst)
; location: [7FFDD9B606C0h, 7FFDD9B606D0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 00
000dh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0x49,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong gather(ulong src, ulong mask, ref ulong dst)
; location: [7FFDD9B606F0h, 7FFDD9B60700h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 00
000dh mov rax,r8                    ; MOV(Mov_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 8b c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gatherBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0x49,0x89,0x00,0x49,0x8B,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte hi(sbyte src)
; location: [7FFDD9B60720h, 7FFDD9B60730h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
000ch movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0xC1,0xF8,0x04,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte hi(byte src)
; location: [7FFDD9B60750h, 7FFDD9B6075Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h sar eax,4                     ; SAR(Sar_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 f8 04
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC1,0xF8,0x04,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte hi(short src)
; location: [7FFDD9B60770h, 7FFDD9B60780h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
000ch movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xC1,0xF8,0x08,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte hi(ushort src)
; location: [7FFDD9B607A0h, 7FFDD9B607AEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[15]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC1,0xF8,0x08,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short hi(int src)
; location: [7FFDD9B607C0h, 7FFDD9B607CCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sar ecx,10h                   ; SAR(Sar_rm32_imm8) [ECX,10h:imm8]                    encoding(3 bytes) = c1 f9 10
0008h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0xC1,0xF9,0x10,0x48,0x0F,0xBF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort hi(uint src)
; location: [7FFDD9B607E0h, 7FFDD9B607EBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h shr ecx,10h                   ; SHR(Shr_rm32_imm8) [ECX,10h:imm8]                    encoding(3 bytes) = c1 e9 10
0008h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0xC1,0xE9,0x10,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int hi(long src)
; location: [7FFDD9B60800h, 7FFDD9B6080Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h sar rcx,20h                   ; SAR(Sar_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 f9 20
0009h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xC1,0xF9,0x20,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint hi(ulong src)
; location: [7FFDD9B60820h, 7FFDD9B6082Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h shr rcx,20h                   ; SHR(Shr_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 e9 20
0009h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> hiBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xC1,0xE9,0x20,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ushort puthi(byte src, ref ushort dst)
; location: [7FFDD9B60840h, 7FFDD9B60862h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rdx]      ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RDX:br,DS:sr)]    encoding(3 bytes) = 0f b7 02
0008h mov r8d,8                     ; MOV(Mov_r32_imm32) [R8D,8h:imm32]                    encoding(6 bytes) = 41 b8 08 00 00 00
000eh bzhi eax,eax,r8d              ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,EAX,R8D]            encoding(VEX, 5 bytes) = c4 e2 38 f5 c0
0013h mov [rdx],ax                  ; MOV(Mov_rm16_r16) [mem(16u,RDX:br,DS:sr),AX]         encoding(3 bytes) = 66 89 02
0016h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0019h shl eax,8                     ; SHL(Shl_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e0 08
001ch or [rdx],ax                   ; OR(Or_rm16_r16) [mem(16u,RDX:br,DS:sr),AX]           encoding(3 bytes) = 66 09 02
001fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> puthiBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x02,0x41,0xB8,0x08,0x00,0x00,0x00,0xC4,0xE2,0x38,0xF5,0xC0,0x66,0x89,0x02,0x0F,0xB6,0xC1,0xC1,0xE0,0x08,0x66,0x09,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref uint puthi(ushort src, ref uint dst)
; location: [7FFDD9B60880h, 7FFDD9B6089Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
000ah bzhi eax,[rdx],eax            ; BZHI(VEX_Bzhi_r32_rm32_r32) [EAX,mem(32u,RDX:br,DS:sr),EAX] encoding(VEX, 5 bytes) = c4 e2 78 f5 02
000fh mov [rdx],eax                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),EAX]        encoding(2 bytes) = 89 02
0011h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0014h shl eax,10h                   ; SHL(Shl_rm32_imm8) [EAX,10h:imm8]                    encoding(3 bytes) = c1 e0 10
0017h or [rdx],eax                  ; OR(Or_rm32_r32) [mem(32u,RDX:br,DS:sr),EAX]          encoding(2 bytes) = 09 02
0019h mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> puthiBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x10,0x00,0x00,0x00,0xC4,0xE2,0x78,0xF5,0x02,0x89,0x02,0x0F,0xB7,0xC1,0xC1,0xE0,0x10,0x09,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref ulong puthi(uint src, ref ulong dst)
; location: [7FFDD9B608B0h, 7FFDD9B608CEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,20h                   ; MOV(Mov_r32_imm32) [EAX,20h:imm32]                   encoding(5 bytes) = b8 20 00 00 00
000ah bzhi rax,[rdx],rax            ; BZHI(VEX_Bzhi_r64_rm64_r64) [RAX,mem(64u,RDX:br,DS:sr),RAX] encoding(VEX, 5 bytes) = c4 e2 f8 f5 02
000fh mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 02
0012h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0014h shl rax,20h                   ; SHL(Shl_rm64_imm8) [RAX,20h:imm8]                    encoding(4 bytes) = 48 c1 e0 20
0018h or [rdx],rax                  ; OR(Or_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]          encoding(3 bytes) = 48 09 02
001bh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> puthiBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x20,0x00,0x00,0x00,0xC4,0xE2,0xF8,0xF5,0x02,0x48,0x89,0x02,0x8B,0xC1,0x48,0xC1,0xE0,0x20,0x48,0x09,0x02,0x48,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte lo(sbyte src)
; location: [7FFDD9B608E0h, 7FFDD9B608ECh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cl                  ; MOVSX(Movsx_r64_rm8) [RAX,CL]                        encoding(4 bytes) = 48 0f be c1
0009h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBE,0xC1,0x83,0xE0,0x0F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte lo(byte src)
; location: [7FFDD9B60900h, 7FFDD9B6090Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x83,0xE0,0x0F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: sbyte lo(short src)
; location: [7FFDD9B60920h, 7FFDD9B6092Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h movsx rax,al                  ; MOVSX(Movsx_r64_rm8) [RAX,AL]                        encoding(4 bytes) = 48 0f be c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0x48,0x0F,0xBE,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte lo(ushort src)
; location: [7FFDD9B60940h, 7FFDD9B6094Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: short lo(int src)
; location: [7FFDD9B60960h, 7FFDD9B60969h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movsx rax,cx                  ; MOVSX(Movsx_r64_rm16) [RAX,CX]                       encoding(4 bytes) = 48 0f bf c1
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x0F,0xBF,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort lo(uint src)
; location: [7FFDD9B60980h, 7FFDD9B60988h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loBytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
