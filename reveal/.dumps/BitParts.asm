; 2019-12-02 13:14:43:747
; function: uint project(uint src, Part12x4:uint part)
; location: [7FFDDB0041A0h, 7FFDDB0041AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part16x4:uint part)
; location: [7FFDDB0041C0h, 7FFDDB0041CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part32x4:uint part)
; location: [7FFDDB0041E0h, 7FFDDB0041EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong project(ulong src, Part64x4:ulong part)
; location: [7FFDDB004200h, 7FFDDB00420Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep rax,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF3,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part8x4(uint src, ref byte dst)
; location: [7FFDDB004220h, 7FFDDB004235h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
000ah mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
000ch shr ecx,4                     ; SHR(Shr_rm32_imm8) [ECX,4h:imm8]                     encoding(3 bytes) = c1 e9 04
000fh and ecx,0Fh                   ; AND(And_rm32_imm8) [ECX,fh:imm32]                    encoding(3 bytes) = 83 e1 0f
0012h mov [rdx+1],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 01
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part8x4Bytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x83,0xE0,0x0F,0x88,0x02,0xC1,0xE9,0x04,0x83,0xE1,0x0F,0x88,0x4A,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part8x4(uint src, Span<byte> dst)
; location: [7FFDDB004250h, 7FFDDB004268h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000ah and edx,0Fh                   ; AND(And_rm32_imm8) [EDX,fh:imm32]                    encoding(3 bytes) = 83 e2 0f
000dh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
000fh shr ecx,4                     ; SHR(Shr_rm32_imm8) [ECX,4h:imm8]                     encoding(3 bytes) = c1 e9 04
0012h and ecx,0Fh                   ; AND(And_rm32_imm8) [ECX,fh:imm32]                    encoding(3 bytes) = 83 e1 0f
0015h mov [rax+1],cl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),CL]              encoding(3 bytes) = 88 48 01
0018h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part8x4Bytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x8B,0xD1,0x83,0xE2,0x0F,0x88,0x10,0xC1,0xE9,0x04,0x83,0xE1,0x0F,0x88,0x48,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part12x4(uint src, ref byte dst)
; location: [7FFDDB004280h, 7FFDDB0042A0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
000ah mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
000ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000eh shr eax,4                     ; SHR(Shr_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e8 04
0011h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
0014h mov [rdx+1],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 01
0017h shr ecx,8                     ; SHR(Shr_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e9 08
001ah and ecx,0Fh                   ; AND(And_rm32_imm8) [ECX,fh:imm32]                    encoding(3 bytes) = 83 e1 0f
001dh mov [rdx+2],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 02
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part12x4Bytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x83,0xE0,0x0F,0x88,0x02,0x8B,0xC1,0xC1,0xE8,0x04,0x83,0xE0,0x0F,0x88,0x42,0x01,0xC1,0xE9,0x08,0x83,0xE1,0x0F,0x88,0x4A,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part12x4(uint src, Span<byte> dst)
; location: [7FFDDB0042C0h, 7FFDDB0042E3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000ah and edx,0Fh                   ; AND(And_rm32_imm8) [EDX,fh:imm32]                    encoding(3 bytes) = 83 e2 0f
000dh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
000fh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0011h shr edx,4                     ; SHR(Shr_rm32_imm8) [EDX,4h:imm8]                     encoding(3 bytes) = c1 ea 04
0014h and edx,0Fh                   ; AND(And_rm32_imm8) [EDX,fh:imm32]                    encoding(3 bytes) = 83 e2 0f
0017h mov [rax+1],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 01
001ah shr ecx,8                     ; SHR(Shr_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e9 08
001dh and ecx,0Fh                   ; AND(And_rm32_imm8) [ECX,fh:imm32]                    encoding(3 bytes) = 83 e1 0f
0020h mov [rax+2],cl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),CL]              encoding(3 bytes) = 88 48 02
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part12x4Bytes => new byte[36]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x8B,0xD1,0x83,0xE2,0x0F,0x88,0x10,0x8B,0xD1,0xC1,0xEA,0x04,0x83,0xE2,0x0F,0x88,0x50,0x01,0xC1,0xE9,0x08,0x83,0xE1,0x0F,0x88,0x48,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part16x4(uint src, ref byte dst)
; location: [7FFDDB004300h, 7FFDDB00432Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
000ah mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
000ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000eh shr eax,4                     ; SHR(Shr_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e8 04
0011h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
0014h mov [rdx+1],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 01
0017h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0019h shr eax,8                     ; SHR(Shr_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e8 08
001ch and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
001fh mov [rdx+2],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 02
0022h shr ecx,0Ch                   ; SHR(Shr_rm32_imm8) [ECX,ch:imm8]                     encoding(3 bytes) = c1 e9 0c
0025h and ecx,0Fh                   ; AND(And_rm32_imm8) [ECX,fh:imm32]                    encoding(3 bytes) = 83 e1 0f
0028h mov [rdx+3],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 03
002bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part16x4Bytes => new byte[44]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x83,0xE0,0x0F,0x88,0x02,0x8B,0xC1,0xC1,0xE8,0x04,0x83,0xE0,0x0F,0x88,0x42,0x01,0x8B,0xC1,0xC1,0xE8,0x08,0x83,0xE0,0x0F,0x88,0x42,0x02,0xC1,0xE9,0x0C,0x83,0xE1,0x0F,0x88,0x4A,0x03,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part16x4(uint src, Span<byte> dst)
; location: [7FFDDB004340h, 7FFDDB00436Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000ah and edx,0Fh                   ; AND(And_rm32_imm8) [EDX,fh:imm32]                    encoding(3 bytes) = 83 e2 0f
000dh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
000fh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0011h shr edx,4                     ; SHR(Shr_rm32_imm8) [EDX,4h:imm8]                     encoding(3 bytes) = c1 ea 04
0014h and edx,0Fh                   ; AND(And_rm32_imm8) [EDX,fh:imm32]                    encoding(3 bytes) = 83 e2 0f
0017h mov [rax+1],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 01
001ah mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
001ch shr edx,8                     ; SHR(Shr_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 ea 08
001fh and edx,0Fh                   ; AND(And_rm32_imm8) [EDX,fh:imm32]                    encoding(3 bytes) = 83 e2 0f
0022h mov [rax+2],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 02
0025h shr ecx,0Ch                   ; SHR(Shr_rm32_imm8) [ECX,ch:imm8]                     encoding(3 bytes) = c1 e9 0c
0028h and ecx,0Fh                   ; AND(And_rm32_imm8) [ECX,fh:imm32]                    encoding(3 bytes) = 83 e1 0f
002bh mov [rax+3],cl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),CL]              encoding(3 bytes) = 88 48 03
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part16x4Bytes => new byte[47]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x8B,0xD1,0x83,0xE2,0x0F,0x88,0x10,0x8B,0xD1,0xC1,0xEA,0x04,0x83,0xE2,0x0F,0x88,0x50,0x01,0x8B,0xD1,0xC1,0xEA,0x08,0x83,0xE2,0x0F,0x88,0x50,0x02,0xC1,0xE9,0x0C,0x83,0xE1,0x0F,0x88,0x48,0x03,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part32x4(uint src, ref byte dst)
; location: [7FFDDB004380h, 7FFDDB0043DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
000ah mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
000ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000eh shr eax,4                     ; SHR(Shr_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e8 04
0011h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
0014h mov [rdx+1],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 01
0017h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0019h shr eax,8                     ; SHR(Shr_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e8 08
001ch and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
001fh mov [rdx+2],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 02
0022h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0024h shr eax,0Ch                   ; SHR(Shr_rm32_imm8) [EAX,ch:imm8]                     encoding(3 bytes) = c1 e8 0c
0027h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
002ah mov [rdx+3],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 03
002dh shr ecx,10h                   ; SHR(Shr_rm32_imm8) [ECX,10h:imm8]                    encoding(3 bytes) = c1 e9 10
0030h add rdx,4                     ; ADD(Add_rm64_imm8) [RDX,4h:imm64]                    encoding(4 bytes) = 48 83 c2 04
0034h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0036h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
0039h mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
003bh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
003dh shr eax,4                     ; SHR(Shr_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e8 04
0040h and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
0043h mov [rdx+1],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 01
0046h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0048h shr eax,8                     ; SHR(Shr_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e8 08
004bh and eax,0Fh                   ; AND(And_rm32_imm8) [EAX,fh:imm32]                    encoding(3 bytes) = 83 e0 0f
004eh mov [rdx+2],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 02
0051h shr ecx,0Ch                   ; SHR(Shr_rm32_imm8) [ECX,ch:imm8]                     encoding(3 bytes) = c1 e9 0c
0054h and ecx,0Fh                   ; AND(And_rm32_imm8) [ECX,fh:imm32]                    encoding(3 bytes) = 83 e1 0f
0057h mov [rdx+3],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 03
005ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part32x4Bytes => new byte[91]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x83,0xE0,0x0F,0x88,0x02,0x8B,0xC1,0xC1,0xE8,0x04,0x83,0xE0,0x0F,0x88,0x42,0x01,0x8B,0xC1,0xC1,0xE8,0x08,0x83,0xE0,0x0F,0x88,0x42,0x02,0x8B,0xC1,0xC1,0xE8,0x0C,0x83,0xE0,0x0F,0x88,0x42,0x03,0xC1,0xE9,0x10,0x48,0x83,0xC2,0x04,0x8B,0xC1,0x83,0xE0,0x0F,0x88,0x02,0x8B,0xC1,0xC1,0xE8,0x04,0x83,0xE0,0x0F,0x88,0x42,0x01,0x8B,0xC1,0xC1,0xE8,0x08,0x83,0xE0,0x0F,0x88,0x42,0x02,0xC1,0xE9,0x0C,0x83,0xE1,0x0F,0x88,0x4A,0x03,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part32x4(uint src, Span<byte> dst)
; location: [7FFDDB0043F0h, 7FFDDB00444Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000ah and edx,0Fh                   ; AND(And_rm32_imm8) [EDX,fh:imm32]                    encoding(3 bytes) = 83 e2 0f
000dh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
000fh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0011h shr edx,4                     ; SHR(Shr_rm32_imm8) [EDX,4h:imm8]                     encoding(3 bytes) = c1 ea 04
0014h and edx,0Fh                   ; AND(And_rm32_imm8) [EDX,fh:imm32]                    encoding(3 bytes) = 83 e2 0f
0017h mov [rax+1],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 01
001ah mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
001ch shr edx,8                     ; SHR(Shr_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 ea 08
001fh and edx,0Fh                   ; AND(And_rm32_imm8) [EDX,fh:imm32]                    encoding(3 bytes) = 83 e2 0f
0022h mov [rax+2],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 02
0025h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0027h shr edx,0Ch                   ; SHR(Shr_rm32_imm8) [EDX,ch:imm8]                     encoding(3 bytes) = c1 ea 0c
002ah and edx,0Fh                   ; AND(And_rm32_imm8) [EDX,fh:imm32]                    encoding(3 bytes) = 83 e2 0f
002dh mov [rax+3],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 03
0030h shr ecx,10h                   ; SHR(Shr_rm32_imm8) [ECX,10h:imm8]                    encoding(3 bytes) = c1 e9 10
0033h add rax,4                     ; ADD(Add_rm64_imm8) [RAX,4h:imm64]                    encoding(4 bytes) = 48 83 c0 04
0037h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0039h and edx,0Fh                   ; AND(And_rm32_imm8) [EDX,fh:imm32]                    encoding(3 bytes) = 83 e2 0f
003ch mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
003eh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0040h shr edx,4                     ; SHR(Shr_rm32_imm8) [EDX,4h:imm8]                     encoding(3 bytes) = c1 ea 04
0043h and edx,0Fh                   ; AND(And_rm32_imm8) [EDX,fh:imm32]                    encoding(3 bytes) = 83 e2 0f
0046h mov [rax+1],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 01
0049h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
004bh shr edx,8                     ; SHR(Shr_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 ea 08
004eh and edx,0Fh                   ; AND(And_rm32_imm8) [EDX,fh:imm32]                    encoding(3 bytes) = 83 e2 0f
0051h mov [rax+2],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 02
0054h shr ecx,0Ch                   ; SHR(Shr_rm32_imm8) [ECX,ch:imm8]                     encoding(3 bytes) = c1 e9 0c
0057h and ecx,0Fh                   ; AND(And_rm32_imm8) [ECX,fh:imm32]                    encoding(3 bytes) = 83 e1 0f
005ah mov [rax+3],cl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),CL]              encoding(3 bytes) = 88 48 03
005dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part32x4Bytes => new byte[94]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x8B,0xD1,0x83,0xE2,0x0F,0x88,0x10,0x8B,0xD1,0xC1,0xEA,0x04,0x83,0xE2,0x0F,0x88,0x50,0x01,0x8B,0xD1,0xC1,0xEA,0x08,0x83,0xE2,0x0F,0x88,0x50,0x02,0x8B,0xD1,0xC1,0xEA,0x0C,0x83,0xE2,0x0F,0x88,0x50,0x03,0xC1,0xE9,0x10,0x48,0x83,0xC0,0x04,0x8B,0xD1,0x83,0xE2,0x0F,0x88,0x10,0x8B,0xD1,0xC1,0xEA,0x04,0x83,0xE2,0x0F,0x88,0x50,0x01,0x8B,0xD1,0xC1,0xEA,0x08,0x83,0xE2,0x0F,0x88,0x50,0x02,0xC1,0xE9,0x0C,0x83,0xE1,0x0F,0x88,0x48,0x03,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part10x5:uint part)
; location: [7FFDDB004460h, 7FFDDB00446Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part15x5:uint part)
; location: [7FFDDB004480h, 7FFDDB00448Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part20x5:uint part)
; location: [7FFDDB0044A0h, 7FFDDB0044AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part25x5:uint part)
; location: [7FFDDB0044C0h, 7FFDDB0044CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part30x5:uint part)
; location: [7FFDDB0044E0h, 7FFDDB0044EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select(ulong src, Part60x5:ulong part)
; location: [7FFDDB004500h, 7FFDDB00450Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part10x5:uint part)
; location: [7FFDDB004520h, 7FFDDB00452Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part15x5:uint part)
; location: [7FFDDB004540h, 7FFDDB00454Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part20x5:uint part)
; location: [7FFDDB004560h, 7FFDDB00456Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part25x5:uint part)
; location: [7FFDDB004580h, 7FFDDB00458Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part30x5:uint part)
; location: [7FFDDB0045A0h, 7FFDDB0045AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong project(ulong src, Part60x5:ulong part)
; location: [7FFDDB0045C0h, 7FFDDB0045CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep rax,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF3,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part12x6:uint part)
; location: [7FFDDB0045E0h, 7FFDDB0045EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part18x6:uint part)
; location: [7FFDDB004600h, 7FFDDB00460Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part24x6:uint part)
; location: [7FFDDB004620h, 7FFDDB00462Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part30x6:uint part)
; location: [7FFDDB004640h, 7FFDDB00464Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select(ulong src, Part36x6:ulong part)
; location: [7FFDDB004660h, 7FFDDB00466Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part12x6:uint part)
; location: [7FFDDB004680h, 7FFDDB00468Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part18x6:uint part)
; location: [7FFDDB0046A0h, 7FFDDB0046AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part24x6:uint part)
; location: [7FFDDB0046C0h, 7FFDDB0046CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part30x6:uint part)
; location: [7FFDDB0046E0h, 7FFDDB0046EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong project(ulong src, Part36x6:ulong part)
; location: [7FFDDB004700h, 7FFDDB00470Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep rax,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF3,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part16x8:uint part)
; location: [7FFDDB004720h, 7FFDDB00472Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part24x8:uint part)
; location: [7FFDDB004740h, 7FFDDB00474Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part32x8:uint part)
; location: [7FFDDB004760h, 7FFDDB00476Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select(ulong src, Part64x8:ulong part)
; location: [7FFDDB004780h, 7FFDDB00478Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part16x8:uint part)
; location: [7FFDDB0047A0h, 7FFDDB0047AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part32x8:uint part)
; location: [7FFDDB0047C0h, 7FFDDB0047CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong project(ulong src, Part64x8:ulong part)
; location: [7FFDDB0047E0h, 7FFDDB0047EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep rax,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF3,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part16x8(ushort src, ref byte dst)
; location: [7FFDDB004800h, 7FFDDB004808h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],cx                  ; MOV(Mov_rm16_r16) [mem(16u,RDX:br,:sr),CX]           encoding(3 bytes) = 66 89 0a
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part16x8Bytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x66,0x89,0x0A,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part16x8(ushort src, Span<byte> dst)
; location: [7FFDDB004820h, 7FFDDB004835h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov [rax],cx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,:sr),CX]           encoding(3 bytes) = 66 89 08
000bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0010h call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F54A530h:jmp64]                encoding(5 bytes) = e8 1b a5 54 5f
0015h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part16x8Bytes => new byte[22]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x66,0x89,0x08,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x1B,0xA5,0x54,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part32x8(uint src, ref byte dst)
; location: [7FFDDB004850h, 7FFDDB004857h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,:sr),ECX]          encoding(2 bytes) = 89 0a
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part32x8Bytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x89,0x0A,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part32x8(uint src, Span<byte> dst)
; location: [7FFDDB004870h, 7FFDDB004884h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),ECX]          encoding(2 bytes) = 89 08
000ah add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
000eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
000fh call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F54A4E0h:jmp64]                encoding(5 bytes) = e8 cc a4 54 5f
0014h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part32x8Bytes => new byte[21]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x89,0x08,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xCC,0xA4,0x54,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part64x8(ulong src, ref byte dst)
; location: [7FFDDB0048A0h, 7FFDDB0048A8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RCX]          encoding(3 bytes) = 48 89 0a
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part64x8Bytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x89,0x0A,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part64x8(ulong src, Span<byte> dst)
; location: [7FFDDB0048C0h, 7FFDDB0048D5h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov [rax],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RCX]          encoding(3 bytes) = 48 89 08
000bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0010h call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F54A490h:jmp64]                encoding(5 bytes) = e8 7b a4 54 5f
0015h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part64x8Bytes => new byte[22]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x48,0x89,0x08,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x7B,0xA4,0x54,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte select(byte src, Odd8:byte spec)
; location: [7FFDDB0048F0h, 7FFDDB004903h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort select(ushort src, Odd16:ushort spec)
; location: [7FFDDB004920h, 7FFDDB004933h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Odd32:uint spec)
; location: [7FFDDB004950h, 7FFDDB00495Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select(ulong src, Odd64:ulong spec)
; location: [7FFDDB004970h, 7FFDDB00497Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Odd8:byte spec)
; location: [7FFDDB004990h, 7FFDDB00499Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h pdep eax,ecx,eax              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EAX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0xC4,0xE2,0x73,0xF5,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Odd16:ushort spec)
; location: [7FFDDB0049B0h, 7FFDDB0049BDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h pdep eax,ecx,eax              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EAX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0xC4,0xE2,0x73,0xF5,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Odd32:uint spec)
; location: [7FFDDB0049D0h, 7FFDDB0049DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong project(ulong src, Odd64:ulong spec)
; location: [7FFDDB0049F0h, 7FFDDB0049FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep rax,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF3,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void unpack8x1(uint src, Span<byte> dst)
; location: [7FFDDB004A10h, 7FFDDB004A36h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000ah mov rcx,101010101010101h      ; MOV(Mov_r64_imm64) [RCX,101010101010101h:imm64]      encoding(10 bytes) = 48 b9 01 01 01 01 01 01 01 01
0014h pdep rdx,rdx,rcx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,RCX]            encoding(VEX, 5 bytes) = c4 e2 eb f5 d1
0019h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
001ch add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0021h call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F54A340h:jmp64]                encoding(5 bytes) = e8 1a a3 54 5f
0026h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack8x1Bytes => new byte[39]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0xD1,0x48,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xEB,0xF5,0xD1,0x48,0x89,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x1A,0xA3,0x54,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void pack16x1(ReadOnlySpan<byte> src, Span<byte> dst)
; location: [7FFDDB004A50h, 7FFDDB004A8Ah]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 12
000bh movzx ecx,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RAX:br,:sr)]        encoding(3 bytes) = 0f b6 08
000eh mov r8,101010101010101h       ; MOV(Mov_r64_imm64) [R8,101010101010101h:imm64]       encoding(10 bytes) = 49 b8 01 01 01 01 01 01 01 01
0018h pext rcx,rcx,r8               ; PEXT(VEX_Pext_r64_r64_rm64) [RCX,RCX,R8]             encoding(VEX, 5 bytes) = c4 c2 f2 f5 c8
001dh mov [rdx],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RCX]          encoding(3 bytes) = 48 89 0a
0020h add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
0024h movzx eax,byte ptr [rax+8]    ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,:sr)]        encoding(4 bytes) = 0f b6 40 08
0028h pext rax,rax,r8               ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RAX,R8]             encoding(VEX, 5 bytes) = c4 c2 fa f5 c0
002dh mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
0030h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0034h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0035h call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F54A300h:jmp64]                encoding(5 bytes) = e8 c6 a2 54 5f
003ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> pack16x1Bytes => new byte[59]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x48,0x8B,0x12,0x0F,0xB6,0x08,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xC2,0xF2,0xF5,0xC8,0x48,0x89,0x0A,0x48,0x83,0xC2,0x08,0x0F,0xB6,0x40,0x08,0xC4,0xC2,0xFA,0xF5,0xC0,0x48,0x89,0x02,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xC6,0xA2,0x54,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void unpack16x1(uint src, Span<byte> dst)
; location: [7FFDDB004AA0h, 7FFDDB004AD7h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000ah mov r8,101010101010101h       ; MOV(Mov_r64_imm64) [R8,101010101010101h:imm64]       encoding(10 bytes) = 49 b8 01 01 01 01 01 01 01 01
0014h pdep rdx,rdx,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R8]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d0
0019h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
001ch add rax,8                     ; ADD(Add_rm64_imm8) [RAX,8h:imm64]                    encoding(4 bytes) = 48 83 c0 08
0020h shr ecx,8                     ; SHR(Shr_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e9 08
0023h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0025h pdep rdx,rdx,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R8]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d0
002ah mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
002dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0031h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0032h call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F54A2B0h:jmp64]                encoding(5 bytes) = e8 79 a2 54 5f
0037h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack16x1Bytes => new byte[56]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0xD1,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xC2,0xEB,0xF5,0xD0,0x48,0x89,0x10,0x48,0x83,0xC0,0x08,0xC1,0xE9,0x08,0x8B,0xD1,0xC4,0xC2,0xEB,0xF5,0xD0,0x48,0x89,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x79,0xA2,0x54,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void pack32x1(ReadOnlySpan<byte> src, Span<byte> dst)
; location: [7FFDDB004AF0h, 7FFDDB004B56h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 12
000bh movzx ecx,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RAX:br,:sr)]        encoding(3 bytes) = 0f b6 08
000eh mov r8,101010101010101h       ; MOV(Mov_r64_imm64) [R8,101010101010101h:imm64]       encoding(10 bytes) = 49 b8 01 01 01 01 01 01 01 01
0018h pext rcx,rcx,r8               ; PEXT(VEX_Pext_r64_r64_rm64) [RCX,RCX,R8]             encoding(VEX, 5 bytes) = c4 c2 f2 f5 c8
001dh mov [rdx],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RCX]          encoding(3 bytes) = 48 89 0a
0020h lea rcx,[rdx+8]               ; LEA(Lea_r64_m) [RCX,mem(Unknown,RDX:br,:sr)]         encoding(4 bytes) = 48 8d 4a 08
0024h movzx r8d,byte ptr [rax+8]    ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,:sr)]        encoding(5 bytes) = 44 0f b6 40 08
0029h mov r9,101010101010101h       ; MOV(Mov_r64_imm64) [R9,101010101010101h:imm64]       encoding(10 bytes) = 49 b9 01 01 01 01 01 01 01 01
0033h pext r8,r8,r9                 ; PEXT(VEX_Pext_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 ba f5 c1
0038h mov [rcx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),R8]           encoding(3 bytes) = 4c 89 01
003bh lea rcx,[rdx+10h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RDX:br,:sr)]         encoding(4 bytes) = 48 8d 4a 10
003fh movzx r8d,byte ptr [rax+10h]  ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,:sr)]        encoding(5 bytes) = 44 0f b6 40 10
0044h pext r8,r8,r9                 ; PEXT(VEX_Pext_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 ba f5 c1
0049h mov [rcx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),R8]           encoding(3 bytes) = 4c 89 01
004ch add rdx,18h                   ; ADD(Add_rm64_imm8) [RDX,18h:imm64]                   encoding(4 bytes) = 48 83 c2 18
0050h movzx eax,byte ptr [rax+18h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,:sr)]        encoding(4 bytes) = 0f b6 40 18
0054h pext rax,rax,r9               ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RAX,R9]             encoding(VEX, 5 bytes) = c4 c2 fa f5 c1
0059h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
005ch add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0060h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0061h call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F54A260h:jmp64]                encoding(5 bytes) = e8 fa a1 54 5f
0066h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> pack32x1Bytes => new byte[103]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x48,0x8B,0x12,0x0F,0xB6,0x08,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xC2,0xF2,0xF5,0xC8,0x48,0x89,0x0A,0x48,0x8D,0x4A,0x08,0x44,0x0F,0xB6,0x40,0x08,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBA,0xF5,0xC1,0x4C,0x89,0x01,0x48,0x8D,0x4A,0x10,0x44,0x0F,0xB6,0x40,0x10,0xC4,0x42,0xBA,0xF5,0xC1,0x4C,0x89,0x01,0x48,0x83,0xC2,0x18,0x0F,0xB6,0x40,0x18,0xC4,0xC2,0xFA,0xF5,0xC1,0x48,0x89,0x02,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xFA,0xA1,0x54,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void unpack32x1(uint src, Span<byte> dst)
; location: [7FFDDB004B70h, 7FFDDB004BD5h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000ah mov r8,101010101010101h       ; MOV(Mov_r64_imm64) [R8,101010101010101h:imm64]       encoding(10 bytes) = 49 b8 01 01 01 01 01 01 01 01
0014h pdep rdx,rdx,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R8]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d0
0019h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
001ch lea rdx,[rax+8]               ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 08
0020h mov r8d,ecx                   ; MOV(Mov_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 8b c1
0023h shr r8d,8                     ; SHR(Shr_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e8 08
0027h mov r9,101010101010101h       ; MOV(Mov_r64_imm64) [R9,101010101010101h:imm64]       encoding(10 bytes) = 49 b9 01 01 01 01 01 01 01 01
0031h pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
0036h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
0039h shr ecx,10h                   ; SHR(Shr_rm32_imm8) [ECX,10h:imm8]                    encoding(3 bytes) = c1 e9 10
003ch add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
0040h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0042h pdep rdx,rdx,r9               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R9]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d1
0047h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
004ah add rax,8                     ; ADD(Add_rm64_imm8) [RAX,8h:imm64]                    encoding(4 bytes) = 48 83 c0 08
004eh shr ecx,8                     ; SHR(Shr_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e9 08
0051h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0053h pdep rdx,rdx,r9               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R9]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d1
0058h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
005bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
005fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0060h call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F54A1E0h:jmp64]                encoding(5 bytes) = e8 7b a1 54 5f
0065h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack32x1Bytes => new byte[102]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0xD1,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xC2,0xEB,0xF5,0xD0,0x48,0x89,0x10,0x48,0x8D,0x50,0x08,0x44,0x8B,0xC1,0x41,0xC1,0xE8,0x08,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0xC1,0xE9,0x10,0x48,0x83,0xC0,0x10,0x8B,0xD1,0xC4,0xC2,0xEB,0xF5,0xD1,0x48,0x89,0x10,0x48,0x83,0xC0,0x08,0xC1,0xE9,0x08,0x8B,0xD1,0xC4,0xC2,0xEB,0xF5,0xD1,0x48,0x89,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x7B,0xA1,0x54,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void pack64x1(ReadOnlySpan<byte> src, Span<byte> dst)
; location: [7FFDDB004BF0h, 7FFDDB004C9Ch]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 12
000bh movzx ecx,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RAX:br,:sr)]        encoding(3 bytes) = 0f b6 08
000eh mov r8,101010101010101h       ; MOV(Mov_r64_imm64) [R8,101010101010101h:imm64]       encoding(10 bytes) = 49 b8 01 01 01 01 01 01 01 01
0018h pext rcx,rcx,r8               ; PEXT(VEX_Pext_r64_r64_rm64) [RCX,RCX,R8]             encoding(VEX, 5 bytes) = c4 c2 f2 f5 c8
001dh mov [rdx],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RCX]          encoding(3 bytes) = 48 89 0a
0020h lea rcx,[rdx+8]               ; LEA(Lea_r64_m) [RCX,mem(Unknown,RDX:br,:sr)]         encoding(4 bytes) = 48 8d 4a 08
0024h movzx r8d,byte ptr [rax+8]    ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,:sr)]        encoding(5 bytes) = 44 0f b6 40 08
0029h mov r9,101010101010101h       ; MOV(Mov_r64_imm64) [R9,101010101010101h:imm64]       encoding(10 bytes) = 49 b9 01 01 01 01 01 01 01 01
0033h pext r8,r8,r9                 ; PEXT(VEX_Pext_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 ba f5 c1
0038h mov [rcx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),R8]           encoding(3 bytes) = 4c 89 01
003bh lea rcx,[rdx+10h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RDX:br,:sr)]         encoding(4 bytes) = 48 8d 4a 10
003fh movzx r8d,byte ptr [rax+10h]  ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,:sr)]        encoding(5 bytes) = 44 0f b6 40 10
0044h pext r8,r8,r9                 ; PEXT(VEX_Pext_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 ba f5 c1
0049h mov [rcx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),R8]           encoding(3 bytes) = 4c 89 01
004ch lea rcx,[rdx+18h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RDX:br,:sr)]         encoding(4 bytes) = 48 8d 4a 18
0050h movzx r8d,byte ptr [rax+18h]  ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,:sr)]        encoding(5 bytes) = 44 0f b6 40 18
0055h pext r8,r8,r9                 ; PEXT(VEX_Pext_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 ba f5 c1
005ah mov [rcx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),R8]           encoding(3 bytes) = 4c 89 01
005dh add rax,4                     ; ADD(Add_rm64_imm8) [RAX,4h:imm64]                    encoding(4 bytes) = 48 83 c0 04
0061h add rdx,4                     ; ADD(Add_rm64_imm8) [RDX,4h:imm64]                    encoding(4 bytes) = 48 83 c2 04
0065h movzx ecx,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RAX:br,:sr)]        encoding(3 bytes) = 0f b6 08
0068h pext rcx,rcx,r9               ; PEXT(VEX_Pext_r64_r64_rm64) [RCX,RCX,R9]             encoding(VEX, 5 bytes) = c4 c2 f2 f5 c9
006dh mov [rdx],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RCX]          encoding(3 bytes) = 48 89 0a
0070h lea rcx,[rdx+8]               ; LEA(Lea_r64_m) [RCX,mem(Unknown,RDX:br,:sr)]         encoding(4 bytes) = 48 8d 4a 08
0074h movzx r8d,byte ptr [rax+8]    ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,:sr)]        encoding(5 bytes) = 44 0f b6 40 08
0079h pext r8,r8,r9                 ; PEXT(VEX_Pext_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 ba f5 c1
007eh mov [rcx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),R8]           encoding(3 bytes) = 4c 89 01
0081h lea rcx,[rdx+10h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RDX:br,:sr)]         encoding(4 bytes) = 48 8d 4a 10
0085h movzx r8d,byte ptr [rax+10h]  ; MOVZX(Movzx_r32_rm8) [R8D,mem(8u,RAX:br,:sr)]        encoding(5 bytes) = 44 0f b6 40 10
008ah pext r8,r8,r9                 ; PEXT(VEX_Pext_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 ba f5 c1
008fh mov [rcx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),R8]           encoding(3 bytes) = 4c 89 01
0092h add rdx,18h                   ; ADD(Add_rm64_imm8) [RDX,18h:imm64]                   encoding(4 bytes) = 48 83 c2 18
0096h movzx eax,byte ptr [rax+18h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,:sr)]        encoding(4 bytes) = 0f b6 40 18
009ah pext rax,rax,r9               ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RAX,R9]             encoding(VEX, 5 bytes) = c4 c2 fa f5 c1
009fh mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
00a2h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
00a6h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00a7h call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F54A160h:jmp64]                encoding(5 bytes) = e8 b4 a0 54 5f
00ach int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> pack64x1Bytes => new byte[173]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x48,0x8B,0x12,0x0F,0xB6,0x08,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xC2,0xF2,0xF5,0xC8,0x48,0x89,0x0A,0x48,0x8D,0x4A,0x08,0x44,0x0F,0xB6,0x40,0x08,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBA,0xF5,0xC1,0x4C,0x89,0x01,0x48,0x8D,0x4A,0x10,0x44,0x0F,0xB6,0x40,0x10,0xC4,0x42,0xBA,0xF5,0xC1,0x4C,0x89,0x01,0x48,0x8D,0x4A,0x18,0x44,0x0F,0xB6,0x40,0x18,0xC4,0x42,0xBA,0xF5,0xC1,0x4C,0x89,0x01,0x48,0x83,0xC0,0x04,0x48,0x83,0xC2,0x04,0x0F,0xB6,0x08,0xC4,0xC2,0xF2,0xF5,0xC9,0x48,0x89,0x0A,0x48,0x8D,0x4A,0x08,0x44,0x0F,0xB6,0x40,0x08,0xC4,0x42,0xBA,0xF5,0xC1,0x4C,0x89,0x01,0x48,0x8D,0x4A,0x10,0x44,0x0F,0xB6,0x40,0x10,0xC4,0x42,0xBA,0xF5,0xC1,0x4C,0x89,0x01,0x48,0x83,0xC2,0x18,0x0F,0xB6,0x40,0x18,0xC4,0xC2,0xFA,0xF5,0xC1,0x48,0x89,0x02,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xB4,0xA0,0x54,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void unpack64x1(ulong src, Span<byte> dst)
; location: [7FFDDB004CC0h, 7FFDDB004D6Eh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000ah mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
000dh mov r9,101010101010101h       ; MOV(Mov_r64_imm64) [R9,101010101010101h:imm64]       encoding(10 bytes) = 49 b9 01 01 01 01 01 01 01 01
0017h pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
001ch mov [rax],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),R8]           encoding(3 bytes) = 4c 89 00
001fh lea r8,[rax+8]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 08
0023h mov r9d,edx                   ; MOV(Mov_r32_rm32) [R9D,EDX]                          encoding(3 bytes) = 44 8b ca
0026h shr r9d,8                     ; SHR(Shr_rm32_imm8) [R9D,8h:imm8]                     encoding(4 bytes) = 41 c1 e9 08
002ah mov r10,101010101010101h      ; MOV(Mov_r64_imm64) [R10,101010101010101h:imm64]      encoding(10 bytes) = 49 ba 01 01 01 01 01 01 01 01
0034h pdep r9,r9,r10                ; PDEP(VEX_Pdep_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b3 f5 ca
0039h mov [r8],r9                   ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),R9]            encoding(3 bytes) = 4d 89 08
003ch shr edx,10h                   ; SHR(Shr_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 ea 10
003fh lea r8,[rax+10h]              ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 10
0043h mov r9d,edx                   ; MOV(Mov_r32_rm32) [R9D,EDX]                          encoding(3 bytes) = 44 8b ca
0046h pdep r9,r9,r10                ; PDEP(VEX_Pdep_r64_r64_rm64) [R9,R9,R10]              encoding(VEX, 5 bytes) = c4 42 b3 f5 ca
004bh mov [r8],r9                   ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),R9]            encoding(3 bytes) = 4d 89 08
004eh add r8,8                      ; ADD(Add_rm64_imm8) [R8,8h:imm64]                     encoding(4 bytes) = 49 83 c0 08
0052h shr edx,8                     ; SHR(Shr_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 ea 08
0055h pdep rdx,rdx,r10              ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R10]            encoding(VEX, 5 bytes) = c4 c2 eb f5 d2
005ah mov [r8],rdx                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RDX]           encoding(3 bytes) = 49 89 10
005dh shr rcx,20h                   ; SHR(Shr_rm64_imm8) [RCX,20h:imm8]                    encoding(4 bytes) = 48 c1 e9 20
0061h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0063h add rax,20h                   ; ADD(Add_rm64_imm8) [RAX,20h:imm64]                   encoding(4 bytes) = 48 83 c0 20
0067h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0069h pdep rcx,rcx,r10              ; PDEP(VEX_Pdep_r64_r64_rm64) [RCX,RCX,R10]            encoding(VEX, 5 bytes) = c4 c2 f3 f5 ca
006eh mov [rax],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RCX]          encoding(3 bytes) = 48 89 08
0071h lea rcx,[rax+8]               ; LEA(Lea_r64_m) [RCX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 48 08
0075h mov r8d,edx                   ; MOV(Mov_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 8b c2
0078h shr r8d,8                     ; SHR(Shr_rm32_imm8) [R8D,8h:imm8]                     encoding(4 bytes) = 41 c1 e8 08
007ch pdep r8,r8,r10                ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R10]              encoding(VEX, 5 bytes) = c4 42 bb f5 c2
0081h mov [rcx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),R8]           encoding(3 bytes) = 4c 89 01
0084h shr edx,10h                   ; SHR(Shr_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 ea 10
0087h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
008bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
008dh pdep rcx,rcx,r10              ; PDEP(VEX_Pdep_r64_r64_rm64) [RCX,RCX,R10]            encoding(VEX, 5 bytes) = c4 c2 f3 f5 ca
0092h mov [rax],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RCX]          encoding(3 bytes) = 48 89 08
0095h add rax,8                     ; ADD(Add_rm64_imm8) [RAX,8h:imm64]                    encoding(4 bytes) = 48 83 c0 08
0099h shr edx,8                     ; SHR(Shr_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 ea 08
009ch pdep rdx,rdx,r10              ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R10]            encoding(VEX, 5 bytes) = c4 c2 eb f5 d2
00a1h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
00a4h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
00a8h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00a9h call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F54A090h:jmp64]                encoding(5 bytes) = e8 e2 9f 54 5f
00aeh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack64x1Bytes => new byte[175]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0xD1,0x44,0x8B,0xC2,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x00,0x4C,0x8D,0x40,0x08,0x44,0x8B,0xCA,0x41,0xC1,0xE9,0x08,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB3,0xF5,0xCA,0x4D,0x89,0x08,0xC1,0xEA,0x10,0x4C,0x8D,0x40,0x10,0x44,0x8B,0xCA,0xC4,0x42,0xB3,0xF5,0xCA,0x4D,0x89,0x08,0x49,0x83,0xC0,0x08,0xC1,0xEA,0x08,0xC4,0xC2,0xEB,0xF5,0xD2,0x49,0x89,0x10,0x48,0xC1,0xE9,0x20,0x8B,0xD1,0x48,0x83,0xC0,0x20,0x8B,0xCA,0xC4,0xC2,0xF3,0xF5,0xCA,0x48,0x89,0x08,0x48,0x8D,0x48,0x08,0x44,0x8B,0xC2,0x41,0xC1,0xE8,0x08,0xC4,0x42,0xBB,0xF5,0xC2,0x4C,0x89,0x01,0xC1,0xEA,0x10,0x48,0x83,0xC0,0x10,0x8B,0xCA,0xC4,0xC2,0xF3,0xF5,0xCA,0x48,0x89,0x08,0x48,0x83,0xC0,0x08,0xC1,0xEA,0x08,0xC4,0xC2,0xEB,0xF5,0xD2,0x48,0x89,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xE2,0x9F,0x54,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong project(ulong src, ulong mask)
; location: [7FFDDB004D90h, 7FFDDB004D9Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep rax,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF3,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, uint mask)
; location: [7FFDDB004DB0h, 7FFDDB004DBAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort project(ushort src, ushort mask)
; location: [7FFDDB004DD0h, 7FFDDB004DE3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh pdep eax,eax,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7b f5 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC4,0xE2,0x7B,0xF5,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte select(byte src, byte mask)
; location: [7FFDDB004E00h, 7FFDDB004E13h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort select(ushort src, ushort mask)
; location: [7FFDDB004E30h, 7FFDDB004E43h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, uint mask)
; location: [7FFDDB004E60h, 7FFDDB004E6Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select(ulong src, ulong mask)
; location: [7FFDDB004E80h, 7FFDDB004E8Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Even8:byte spec)
; location: [7FFDDB004EA0h, 7FFDDB004EADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h pext eax,ecx,eax              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EAX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0xC4,0xE2,0x72,0xF5,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Even16:ushort spec)
; location: [7FFDDB004EC0h, 7FFDDB004ECDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h pext eax,ecx,eax              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EAX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0xC4,0xE2,0x72,0xF5,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Even32:uint spec)
; location: [7FFDDB004EE0h, 7FFDDB004EEAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select(ulong src, Even64:ulong spec)
; location: [7FFDDB004F00h, 7FFDDB004F0Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Even8:byte spec)
; location: [7FFDDB004F20h, 7FFDDB004F2Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h pdep eax,ecx,eax              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EAX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0xC4,0xE2,0x73,0xF5,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Even16:ushort spec)
; location: [7FFDDB004F40h, 7FFDDB004F4Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h pdep eax,ecx,eax              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EAX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0xC4,0xE2,0x73,0xF5,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Even32:uint spec)
; location: [7FFDDB004F60h, 7FFDDB004F6Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong project(ulong src, Even64:ulong spec)
; location: [7FFDDB004F80h, 7FFDDB004F8Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep rax,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF3,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part32x16:uint part)
; location: [7FFDDB004FA0h, 7FFDDB004FAAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select(ulong src, Part48x16:ulong part)
; location: [7FFDDB004FC0h, 7FFDDB004FCAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select(ulong src, Part64x16:ulong part)
; location: [7FFDDB004FE0h, 7FFDDB004FEAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part32x16:uint part)
; location: [7FFDDB005000h, 7FFDDB00500Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part32x16(uint src, Span<ushort> dst)
; location: [7FFDDB005020h, 7FFDDB005047h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 52 08
000bh shl rdx,1                     ; SHL(Shl_rm64_1) [RDX,1h:imm8]                        encoding(3 bytes) = 48 d1 e2
000eh shr rdx,2                     ; SHR(Shr_rm64_imm8) [RDX,2h:imm8]                     encoding(4 bytes) = 48 c1 ea 02
0012h cmp rdx,7FFFFFFFh             ; CMP(Cmp_rm64_imm32) [RDX,7fffffffh:imm64]            encoding(7 bytes) = 48 81 fa ff ff ff 7f
0019h ja short 0022h                ; JA(Ja_rel8_64) [22h:jmp64]                           encoding(2 bytes) = 77 07
001bh mov [rax],ecx                 ; MOV(Mov_rm32_r32) [mem(32u,RAX:br,:sr),ECX]          encoding(2 bytes) = 89 08
001dh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0022h call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F549D30h:jmp64]                encoding(5 bytes) = e8 09 9d 54 5f
0027h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part32x16Bytes => new byte[40]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x48,0xD1,0xE2,0x48,0xC1,0xEA,0x02,0x48,0x81,0xFA,0xFF,0xFF,0xFF,0x7F,0x77,0x07,0x89,0x08,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x09,0x9D,0x54,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part64x16(ulong src, Span<ushort> dst)
; location: [7FFDDB005060h, 7FFDDB005088h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 52 08
000bh shl rdx,1                     ; SHL(Shl_rm64_1) [RDX,1h:imm8]                        encoding(3 bytes) = 48 d1 e2
000eh shr rdx,3                     ; SHR(Shr_rm64_imm8) [RDX,3h:imm8]                     encoding(4 bytes) = 48 c1 ea 03
0012h cmp rdx,7FFFFFFFh             ; CMP(Cmp_rm64_imm32) [RDX,7fffffffh:imm64]            encoding(7 bytes) = 48 81 fa ff ff ff 7f
0019h ja short 0023h                ; JA(Ja_rel8_64) [23h:jmp64]                           encoding(2 bytes) = 77 08
001bh mov [rax],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RCX]          encoding(3 bytes) = 48 89 08
001eh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0023h call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F549CF0h:jmp64]                encoding(5 bytes) = e8 c8 9c 54 5f
0028h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part64x16Bytes => new byte[41]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x48,0xD1,0xE2,0x48,0xC1,0xEA,0x03,0x48,0x81,0xFA,0xFF,0xFF,0xFF,0x7F,0x77,0x08,0x48,0x89,0x08,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xC8,0x9C,0x54,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part2x1:uint spec)
; location: [7FFDDB0050A0h, 7FFDDB0050AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part3x1:uint spec)
; location: [7FFDDB0050C0h, 7FFDDB0050CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part4x1:uint spec)
; location: [7FFDDB0050E0h, 7FFDDB0050EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part5x1:uint spec)
; location: [7FFDDB005100h, 7FFDDB00510Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part6x1:uint spec)
; location: [7FFDDB005120h, 7FFDDB00512Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part7x1:uint spec)
; location: [7FFDDB005140h, 7FFDDB00514Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part8x1:uint spec)
; location: [7FFDDB005160h, 7FFDDB00516Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part9x1:uint spec)
; location: [7FFDDB005180h, 7FFDDB00518Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part10x1:uint spec)
; location: [7FFDDB0051A0h, 7FFDDB0051AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part11x1:uint spec)
; location: [7FFDDB0051C0h, 7FFDDB0051CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part12x1:uint spec)
; location: [7FFDDB0051E0h, 7FFDDB0051EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part13x1:uint spec)
; location: [7FFDDB005200h, 7FFDDB00520Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part16x1:uint spec)
; location: [7FFDDB005220h, 7FFDDB00522Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part32x1:uint spec)
; location: [7FFDDB005240h, 7FFDDB00524Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select(ulong src, Part64x1:ulong spec)
; location: [7FFDDB005260h, 7FFDDB00526Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part2x1:uint spec)
; location: [7FFDDB005280h, 7FFDDB00528Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part3x1:uint spec)
; location: [7FFDDB0052A0h, 7FFDDB0052AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part4x1:uint spec)
; location: [7FFDDB0052C0h, 7FFDDB0052CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part8x1:uint spec)
; location: [7FFDDB0052E0h, 7FFDDB0052EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part10x1:uint spec)
; location: [7FFDDB005300h, 7FFDDB00530Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part5x1:uint spec)
; location: [7FFDDB005320h, 7FFDDB00532Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part6x1:uint spec)
; location: [7FFDDB005340h, 7FFDDB00534Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part9x1:uint spec)
; location: [7FFDDB005360h, 7FFDDB00536Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part7x1:uint spec)
; location: [7FFDDB005380h, 7FFDDB00538Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part11x1:uint spec)
; location: [7FFDDB0053A0h, 7FFDDB0053AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part12x1:uint spec)
; location: [7FFDDB0053C0h, 7FFDDB0053CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part13x1:uint spec)
; location: [7FFDDB0053E0h, 7FFDDB0053EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part16x1:uint spec)
; location: [7FFDDB005400h, 7FFDDB00540Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part32x1:uint spec)
; location: [7FFDDB005420h, 7FFDDB00542Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong project(ulong src, Part64x1:ulong spec)
; location: [7FFDDB005440h, 7FFDDB00544Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep rax,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF3,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part4x1(uint src, ref byte dst)
; location: [7FFDDB005460h, 7FFDDB00548Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ah mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
000ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000eh shr eax,1                     ; SHR(Shr_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 e8
0010h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0013h mov [rdx+1],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 01
0016h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0018h shr eax,2                     ; SHR(Shr_rm32_imm8) [EAX,2h:imm8]                     encoding(3 bytes) = c1 e8 02
001bh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
001eh mov [rdx+2],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 02
0021h shr ecx,3                     ; SHR(Shr_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 e9 03
0024h and ecx,1                     ; AND(And_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 e1 01
0027h mov [rdx+3],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 03
002ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part4x1Bytes => new byte[43]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x83,0xE0,0x01,0x88,0x02,0x8B,0xC1,0xD1,0xE8,0x83,0xE0,0x01,0x88,0x42,0x01,0x8B,0xC1,0xC1,0xE8,0x02,0x83,0xE0,0x01,0x88,0x42,0x02,0xC1,0xE9,0x03,0x83,0xE1,0x01,0x88,0x4A,0x03,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part5x1(uint src, ref byte dst)
; location: [7FFDDB0054A0h, 7FFDDB0054D5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ah mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
000ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000eh shr eax,1                     ; SHR(Shr_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 e8
0010h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0013h mov [rdx+1],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 01
0016h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0018h shr eax,2                     ; SHR(Shr_rm32_imm8) [EAX,2h:imm8]                     encoding(3 bytes) = c1 e8 02
001bh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
001eh mov [rdx+2],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 02
0021h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0023h shr eax,3                     ; SHR(Shr_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e8 03
0026h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0029h mov [rdx+3],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 03
002ch shr ecx,4                     ; SHR(Shr_rm32_imm8) [ECX,4h:imm8]                     encoding(3 bytes) = c1 e9 04
002fh and ecx,1                     ; AND(And_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 e1 01
0032h mov [rdx+4],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 04
0035h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part5x1Bytes => new byte[54]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x83,0xE0,0x01,0x88,0x02,0x8B,0xC1,0xD1,0xE8,0x83,0xE0,0x01,0x88,0x42,0x01,0x8B,0xC1,0xC1,0xE8,0x02,0x83,0xE0,0x01,0x88,0x42,0x02,0x8B,0xC1,0xC1,0xE8,0x03,0x83,0xE0,0x01,0x88,0x42,0x03,0xC1,0xE9,0x04,0x83,0xE1,0x01,0x88,0x4A,0x04,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part6x1(uint src, ref byte dst)
; location: [7FFDDB0054F0h, 7FFDDB005530h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ah mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
000ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000eh shr eax,1                     ; SHR(Shr_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 e8
0010h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0013h mov [rdx+1],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 01
0016h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0018h shr eax,2                     ; SHR(Shr_rm32_imm8) [EAX,2h:imm8]                     encoding(3 bytes) = c1 e8 02
001bh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
001eh mov [rdx+2],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 02
0021h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0023h shr eax,3                     ; SHR(Shr_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e8 03
0026h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0029h mov [rdx+3],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 03
002ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
002eh shr eax,4                     ; SHR(Shr_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e8 04
0031h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0034h mov [rdx+4],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 04
0037h shr ecx,5                     ; SHR(Shr_rm32_imm8) [ECX,5h:imm8]                     encoding(3 bytes) = c1 e9 05
003ah and ecx,1                     ; AND(And_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 e1 01
003dh mov [rdx+5],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 05
0040h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part6x1Bytes => new byte[65]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x83,0xE0,0x01,0x88,0x02,0x8B,0xC1,0xD1,0xE8,0x83,0xE0,0x01,0x88,0x42,0x01,0x8B,0xC1,0xC1,0xE8,0x02,0x83,0xE0,0x01,0x88,0x42,0x02,0x8B,0xC1,0xC1,0xE8,0x03,0x83,0xE0,0x01,0x88,0x42,0x03,0x8B,0xC1,0xC1,0xE8,0x04,0x83,0xE0,0x01,0x88,0x42,0x04,0xC1,0xE9,0x05,0x83,0xE1,0x01,0x88,0x4A,0x05,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part7x1(uint src, ref byte dst)
; location: [7FFDDB005550h, 7FFDDB00559Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ah mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
000ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000eh shr eax,1                     ; SHR(Shr_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 e8
0010h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0013h mov [rdx+1],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 01
0016h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0018h shr eax,2                     ; SHR(Shr_rm32_imm8) [EAX,2h:imm8]                     encoding(3 bytes) = c1 e8 02
001bh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
001eh mov [rdx+2],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 02
0021h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0023h shr eax,3                     ; SHR(Shr_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e8 03
0026h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0029h mov [rdx+3],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 03
002ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
002eh shr eax,4                     ; SHR(Shr_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e8 04
0031h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0034h mov [rdx+4],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 04
0037h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0039h shr eax,5                     ; SHR(Shr_rm32_imm8) [EAX,5h:imm8]                     encoding(3 bytes) = c1 e8 05
003ch and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
003fh mov [rdx+5],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 05
0042h shr ecx,6                     ; SHR(Shr_rm32_imm8) [ECX,6h:imm8]                     encoding(3 bytes) = c1 e9 06
0045h and ecx,1                     ; AND(And_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 e1 01
0048h mov [rdx+6],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 06
004bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part7x1Bytes => new byte[76]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x83,0xE0,0x01,0x88,0x02,0x8B,0xC1,0xD1,0xE8,0x83,0xE0,0x01,0x88,0x42,0x01,0x8B,0xC1,0xC1,0xE8,0x02,0x83,0xE0,0x01,0x88,0x42,0x02,0x8B,0xC1,0xC1,0xE8,0x03,0x83,0xE0,0x01,0x88,0x42,0x03,0x8B,0xC1,0xC1,0xE8,0x04,0x83,0xE0,0x01,0x88,0x42,0x04,0x8B,0xC1,0xC1,0xE8,0x05,0x83,0xE0,0x01,0x88,0x42,0x05,0xC1,0xE9,0x06,0x83,0xE1,0x01,0x88,0x4A,0x06,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part8x1(uint src, ref byte dst)
; location: [7FFDDB0055B0h, 7FFDDB005608h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ah mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
000ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000eh shr eax,1                     ; SHR(Shr_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 e8
0010h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0013h mov [rdx+1],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 01
0016h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0018h shr eax,2                     ; SHR(Shr_rm32_imm8) [EAX,2h:imm8]                     encoding(3 bytes) = c1 e8 02
001bh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
001eh mov [rdx+2],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 02
0021h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0023h shr eax,3                     ; SHR(Shr_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e8 03
0026h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0029h mov [rdx+3],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 03
002ch shr ecx,4                     ; SHR(Shr_rm32_imm8) [ECX,4h:imm8]                     encoding(3 bytes) = c1 e9 04
002fh add rdx,4                     ; ADD(Add_rm64_imm8) [RDX,4h:imm64]                    encoding(4 bytes) = 48 83 c2 04
0033h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0035h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0038h mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
003ah mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
003ch shr eax,1                     ; SHR(Shr_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 e8
003eh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0041h mov [rdx+1],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 01
0044h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0046h shr eax,2                     ; SHR(Shr_rm32_imm8) [EAX,2h:imm8]                     encoding(3 bytes) = c1 e8 02
0049h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
004ch mov [rdx+2],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 02
004fh shr ecx,3                     ; SHR(Shr_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 e9 03
0052h and ecx,1                     ; AND(And_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 e1 01
0055h mov [rdx+3],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 03
0058h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part8x1Bytes => new byte[89]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x83,0xE0,0x01,0x88,0x02,0x8B,0xC1,0xD1,0xE8,0x83,0xE0,0x01,0x88,0x42,0x01,0x8B,0xC1,0xC1,0xE8,0x02,0x83,0xE0,0x01,0x88,0x42,0x02,0x8B,0xC1,0xC1,0xE8,0x03,0x83,0xE0,0x01,0x88,0x42,0x03,0xC1,0xE9,0x04,0x48,0x83,0xC2,0x04,0x8B,0xC1,0x83,0xE0,0x01,0x88,0x02,0x8B,0xC1,0xD1,0xE8,0x83,0xE0,0x01,0x88,0x42,0x01,0x8B,0xC1,0xC1,0xE8,0x02,0x83,0xE0,0x01,0x88,0x42,0x02,0xC1,0xE9,0x03,0x83,0xE1,0x01,0x88,0x4A,0x03,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part9x1(uint src, ref byte dst)
; location: [7FFDDB005620h, 7FFDDB00568Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ah mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
000ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000eh shr eax,1                     ; SHR(Shr_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 e8
0010h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0013h mov [rdx+1],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 01
0016h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0018h shr eax,2                     ; SHR(Shr_rm32_imm8) [EAX,2h:imm8]                     encoding(3 bytes) = c1 e8 02
001bh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
001eh mov [rdx+2],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 02
0021h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0023h shr eax,3                     ; SHR(Shr_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e8 03
0026h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0029h mov [rdx+3],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 03
002ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
002eh shr eax,4                     ; SHR(Shr_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e8 04
0031h lea r8,[rdx+4]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RDX:br,:sr)]          encoding(4 bytes) = 4c 8d 42 04
0035h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
0038h and r9d,1                     ; AND(And_rm32_imm8) [R9D,1h:imm32]                    encoding(4 bytes) = 41 83 e1 01
003ch mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R9L]              encoding(3 bytes) = 45 88 08
003fh mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
0042h shr r9d,1                     ; SHR(Shr_rm32_1) [R9D,1h:imm8]                        encoding(3 bytes) = 41 d1 e9
0045h and r9d,1                     ; AND(And_rm32_imm8) [R9D,1h:imm32]                    encoding(4 bytes) = 41 83 e1 01
0049h mov [r8+1],r9b                ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R9L]              encoding(4 bytes) = 45 88 48 01
004dh mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
0050h shr r9d,2                     ; SHR(Shr_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e9 02
0054h and r9d,1                     ; AND(And_rm32_imm8) [R9D,1h:imm32]                    encoding(4 bytes) = 41 83 e1 01
0058h mov [r8+2],r9b                ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R9L]              encoding(4 bytes) = 45 88 48 02
005ch shr eax,3                     ; SHR(Shr_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e8 03
005fh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0062h mov [r8+3],al                 ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),AL]               encoding(4 bytes) = 41 88 40 03
0066h shr ecx,8                     ; SHR(Shr_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e9 08
0069h and ecx,1                     ; AND(And_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 e1 01
006ch mov [rdx+8],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 08
006fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part9x1Bytes => new byte[112]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x83,0xE0,0x01,0x88,0x02,0x8B,0xC1,0xD1,0xE8,0x83,0xE0,0x01,0x88,0x42,0x01,0x8B,0xC1,0xC1,0xE8,0x02,0x83,0xE0,0x01,0x88,0x42,0x02,0x8B,0xC1,0xC1,0xE8,0x03,0x83,0xE0,0x01,0x88,0x42,0x03,0x8B,0xC1,0xC1,0xE8,0x04,0x4C,0x8D,0x42,0x04,0x44,0x8B,0xC8,0x41,0x83,0xE1,0x01,0x45,0x88,0x08,0x44,0x8B,0xC8,0x41,0xD1,0xE9,0x41,0x83,0xE1,0x01,0x45,0x88,0x48,0x01,0x44,0x8B,0xC8,0x41,0xC1,0xE9,0x02,0x41,0x83,0xE1,0x01,0x45,0x88,0x48,0x02,0xC1,0xE8,0x03,0x83,0xE0,0x01,0x41,0x88,0x40,0x03,0xC1,0xE9,0x08,0x83,0xE1,0x01,0x88,0x4A,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part10x1(uint src, ref byte dst)
; location: [7FFDDB0056A0h, 7FFDDB00571Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
000ah mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
000ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000eh shr eax,1                     ; SHR(Shr_rm32_1) [EAX,1h:imm8]                        encoding(2 bytes) = d1 e8
0010h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0013h mov [rdx+1],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 01
0016h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0018h shr eax,2                     ; SHR(Shr_rm32_imm8) [EAX,2h:imm8]                     encoding(3 bytes) = c1 e8 02
001bh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
001eh mov [rdx+2],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 02
0021h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0023h shr eax,3                     ; SHR(Shr_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e8 03
0026h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0029h mov [rdx+3],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 03
002ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
002eh shr eax,4                     ; SHR(Shr_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e8 04
0031h lea r8,[rdx+4]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RDX:br,:sr)]          encoding(4 bytes) = 4c 8d 42 04
0035h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
0038h and r9d,1                     ; AND(And_rm32_imm8) [R9D,1h:imm32]                    encoding(4 bytes) = 41 83 e1 01
003ch mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R9L]              encoding(3 bytes) = 45 88 08
003fh mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
0042h shr r9d,1                     ; SHR(Shr_rm32_1) [R9D,1h:imm8]                        encoding(3 bytes) = 41 d1 e9
0045h and r9d,1                     ; AND(And_rm32_imm8) [R9D,1h:imm32]                    encoding(4 bytes) = 41 83 e1 01
0049h mov [r8+1],r9b                ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R9L]              encoding(4 bytes) = 45 88 48 01
004dh mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
0050h shr r9d,2                     ; SHR(Shr_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e9 02
0054h and r9d,1                     ; AND(And_rm32_imm8) [R9D,1h:imm32]                    encoding(4 bytes) = 41 83 e1 01
0058h mov [r8+2],r9b                ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R9L]              encoding(4 bytes) = 45 88 48 02
005ch shr eax,3                     ; SHR(Shr_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e8 03
005fh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
0062h mov [r8+3],al                 ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),AL]               encoding(4 bytes) = 41 88 40 03
0066h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0068h shr eax,8                     ; SHR(Shr_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e8 08
006bh and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
006eh mov [rdx+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 08
0071h shr ecx,9                     ; SHR(Shr_rm32_imm8) [ECX,9h:imm8]                     encoding(3 bytes) = c1 e9 09
0074h and ecx,1                     ; AND(And_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 e1 01
0077h mov [rdx+9],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 09
007ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part10x1Bytes => new byte[123]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x83,0xE0,0x01,0x88,0x02,0x8B,0xC1,0xD1,0xE8,0x83,0xE0,0x01,0x88,0x42,0x01,0x8B,0xC1,0xC1,0xE8,0x02,0x83,0xE0,0x01,0x88,0x42,0x02,0x8B,0xC1,0xC1,0xE8,0x03,0x83,0xE0,0x01,0x88,0x42,0x03,0x8B,0xC1,0xC1,0xE8,0x04,0x4C,0x8D,0x42,0x04,0x44,0x8B,0xC8,0x41,0x83,0xE1,0x01,0x45,0x88,0x08,0x44,0x8B,0xC8,0x41,0xD1,0xE9,0x41,0x83,0xE1,0x01,0x45,0x88,0x48,0x01,0x44,0x8B,0xC8,0x41,0xC1,0xE9,0x02,0x41,0x83,0xE1,0x01,0x45,0x88,0x48,0x02,0xC1,0xE8,0x03,0x83,0xE0,0x01,0x41,0x88,0x40,0x03,0x8B,0xC1,0xC1,0xE8,0x08,0x83,0xE0,0x01,0x88,0x42,0x08,0xC1,0xE9,0x09,0x83,0xE1,0x01,0x88,0x4A,0x09,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part10x1(uint src, Span<byte> dst)
; location: [7FFDDB005730h, 7FFDDB0057ADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000ah and edx,1                     ; AND(And_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 e2 01
000dh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
000fh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0011h shr edx,1                     ; SHR(Shr_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 ea
0013h and edx,1                     ; AND(And_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 e2 01
0016h mov [rax+1],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 01
0019h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
001bh shr edx,2                     ; SHR(Shr_rm32_imm8) [EDX,2h:imm8]                     encoding(3 bytes) = c1 ea 02
001eh and edx,1                     ; AND(And_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 e2 01
0021h mov [rax+2],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 02
0024h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0026h shr edx,3                     ; SHR(Shr_rm32_imm8) [EDX,3h:imm8]                     encoding(3 bytes) = c1 ea 03
0029h and edx,1                     ; AND(And_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 e2 01
002ch mov [rax+3],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 03
002fh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0031h shr edx,4                     ; SHR(Shr_rm32_imm8) [EDX,4h:imm8]                     encoding(3 bytes) = c1 ea 04
0034h lea r8,[rax+4]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 04
0038h mov r9d,edx                   ; MOV(Mov_r32_rm32) [R9D,EDX]                          encoding(3 bytes) = 44 8b ca
003bh and r9d,1                     ; AND(And_rm32_imm8) [R9D,1h:imm32]                    encoding(4 bytes) = 41 83 e1 01
003fh mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R9L]              encoding(3 bytes) = 45 88 08
0042h mov r9d,edx                   ; MOV(Mov_r32_rm32) [R9D,EDX]                          encoding(3 bytes) = 44 8b ca
0045h shr r9d,1                     ; SHR(Shr_rm32_1) [R9D,1h:imm8]                        encoding(3 bytes) = 41 d1 e9
0048h and r9d,1                     ; AND(And_rm32_imm8) [R9D,1h:imm32]                    encoding(4 bytes) = 41 83 e1 01
004ch mov [r8+1],r9b                ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R9L]              encoding(4 bytes) = 45 88 48 01
0050h mov r9d,edx                   ; MOV(Mov_r32_rm32) [R9D,EDX]                          encoding(3 bytes) = 44 8b ca
0053h shr r9d,2                     ; SHR(Shr_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e9 02
0057h and r9d,1                     ; AND(And_rm32_imm8) [R9D,1h:imm32]                    encoding(4 bytes) = 41 83 e1 01
005bh mov [r8+2],r9b                ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R9L]              encoding(4 bytes) = 45 88 48 02
005fh shr edx,3                     ; SHR(Shr_rm32_imm8) [EDX,3h:imm8]                     encoding(3 bytes) = c1 ea 03
0062h and edx,1                     ; AND(And_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 e2 01
0065h mov [r8+3],dl                 ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),DL]               encoding(4 bytes) = 41 88 50 03
0069h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
006bh shr edx,8                     ; SHR(Shr_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 ea 08
006eh and edx,1                     ; AND(And_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 e2 01
0071h mov [rax+8],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 08
0074h shr ecx,9                     ; SHR(Shr_rm32_imm8) [ECX,9h:imm8]                     encoding(3 bytes) = c1 e9 09
0077h and ecx,1                     ; AND(And_rm32_imm8) [ECX,1h:imm32]                    encoding(3 bytes) = 83 e1 01
007ah mov [rax+9],cl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),CL]              encoding(3 bytes) = 88 48 09
007dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part10x1Bytes => new byte[126]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x8B,0xD1,0x83,0xE2,0x01,0x88,0x10,0x8B,0xD1,0xD1,0xEA,0x83,0xE2,0x01,0x88,0x50,0x01,0x8B,0xD1,0xC1,0xEA,0x02,0x83,0xE2,0x01,0x88,0x50,0x02,0x8B,0xD1,0xC1,0xEA,0x03,0x83,0xE2,0x01,0x88,0x50,0x03,0x8B,0xD1,0xC1,0xEA,0x04,0x4C,0x8D,0x40,0x04,0x44,0x8B,0xCA,0x41,0x83,0xE1,0x01,0x45,0x88,0x08,0x44,0x8B,0xCA,0x41,0xD1,0xE9,0x41,0x83,0xE1,0x01,0x45,0x88,0x48,0x01,0x44,0x8B,0xCA,0x41,0xC1,0xE9,0x02,0x41,0x83,0xE1,0x01,0x45,0x88,0x48,0x02,0xC1,0xEA,0x03,0x83,0xE2,0x01,0x41,0x88,0x50,0x03,0x8B,0xD1,0xC1,0xEA,0x08,0x83,0xE2,0x01,0x88,0x50,0x08,0xC1,0xE9,0x09,0x83,0xE1,0x01,0x88,0x48,0x09,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part32x1(uint src, Span<byte> dst)
; location: [7FFDDB0057C0h, 7FFDDB005846h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov edx,0FFh                  ; MOV(Mov_r32_imm32) [EDX,ffh:imm32]                   encoding(5 bytes) = ba ff 00 00 00
000dh pext edx,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 d2
0012h mov edx,edx                   ; MOV(Mov_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 8b d2
0014h mov r8,101010101010101h       ; MOV(Mov_r64_imm64) [R8,101010101010101h:imm64]       encoding(10 bytes) = 49 b8 01 01 01 01 01 01 01 01
001eh pdep rdx,rdx,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R8]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d0
0023h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
0026h lea rdx,[rax+8]               ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 08
002ah mov r8d,0FF00h                ; MOV(Mov_r32_imm32) [R8D,ff00h:imm32]                 encoding(6 bytes) = 41 b8 00 ff 00 00
0030h pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
0035h mov r8d,r8d                   ; MOV(Mov_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 8b c0
0038h mov r9,101010101010101h       ; MOV(Mov_r64_imm64) [R9,101010101010101h:imm64]       encoding(10 bytes) = 49 b9 01 01 01 01 01 01 01 01
0042h pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
0047h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
004ah lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 10
004eh mov r8d,0FF0000h              ; MOV(Mov_r32_imm32) [R8D,ff0000h:imm32]               encoding(6 bytes) = 41 b8 00 00 ff 00
0054h pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
0059h mov r8d,r8d                   ; MOV(Mov_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 8b c0
005ch pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
0061h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
0064h add rax,18h                   ; ADD(Add_rm64_imm8) [RAX,18h:imm64]                   encoding(4 bytes) = 48 83 c0 18
0068h mov edx,0FF000000h            ; MOV(Mov_r32_imm32) [EDX,ff000000h:imm32]             encoding(5 bytes) = ba 00 00 00 ff
006dh pext edx,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EDX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 d2
0072h mov edx,edx                   ; MOV(Mov_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 8b d2
0074h pdep rdx,rdx,r9               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R9]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d1
0079h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
007ch add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0080h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0081h call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F549590h:jmp64]                encoding(5 bytes) = e8 0a 95 54 5f
0086h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part32x1Bytes => new byte[135]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0xBA,0xFF,0x00,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0x8B,0xD2,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xC2,0xEB,0xF5,0xD0,0x48,0x89,0x10,0x48,0x8D,0x50,0x08,0x41,0xB8,0x00,0xFF,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x45,0x8B,0xC0,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x10,0x41,0xB8,0x00,0x00,0xFF,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x45,0x8B,0xC0,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x83,0xC0,0x18,0xBA,0x00,0x00,0x00,0xFF,0xC4,0xE2,0x72,0xF5,0xD2,0x8B,0xD2,0xC4,0xC2,0xEB,0xF5,0xD1,0x48,0x89,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x0A,0x95,0x54,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part64x1(ulong src, Span<byte> dst)
; location: [7FFDDB005860h, 7FFDDB005949h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov edx,0FFh                  ; MOV(Mov_r32_imm32) [EDX,ffh:imm32]                   encoding(5 bytes) = ba ff 00 00 00
000dh pext rdx,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RDX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 d2
0012h mov r8,101010101010101h       ; MOV(Mov_r64_imm64) [R8,101010101010101h:imm64]       encoding(10 bytes) = 49 b8 01 01 01 01 01 01 01 01
001ch pdep rdx,rdx,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R8]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d0
0021h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
0024h lea rdx,[rax+8]               ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 08
0028h mov r8d,0FF00h                ; MOV(Mov_r32_imm32) [R8D,ff00h:imm32]                 encoding(6 bytes) = 41 b8 00 ff 00 00
002eh pext r8,rcx,r8                ; PEXT(VEX_Pext_r64_r64_rm64) [R8,RCX,R8]              encoding(VEX, 5 bytes) = c4 42 f2 f5 c0
0033h mov r9,101010101010101h       ; MOV(Mov_r64_imm64) [R9,101010101010101h:imm64]       encoding(10 bytes) = 49 b9 01 01 01 01 01 01 01 01
003dh pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
0042h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
0045h lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 10
0049h mov r8d,0FF0000h              ; MOV(Mov_r32_imm32) [R8D,ff0000h:imm32]               encoding(6 bytes) = 41 b8 00 00 ff 00
004fh pext r8,rcx,r8                ; PEXT(VEX_Pext_r64_r64_rm64) [R8,RCX,R8]              encoding(VEX, 5 bytes) = c4 42 f2 f5 c0
0054h pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
0059h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
005ch lea rdx,[rax+18h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 18
0060h mov r8d,0FF000000h            ; MOV(Mov_r32_imm32) [R8D,ff000000h:imm32]             encoding(6 bytes) = 41 b8 00 00 00 ff
0066h pext r8,rcx,r8                ; PEXT(VEX_Pext_r64_r64_rm64) [R8,RCX,R8]              encoding(VEX, 5 bytes) = c4 42 f2 f5 c0
006bh pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
0070h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
0073h lea rdx,[rax+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 20
0077h mov r8,0FF00000000h           ; MOV(Mov_r64_imm64) [R8,ff00000000h:imm64]            encoding(10 bytes) = 49 b8 00 00 00 00 ff 00 00 00
0081h pext r8,rcx,r8                ; PEXT(VEX_Pext_r64_r64_rm64) [R8,RCX,R8]              encoding(VEX, 5 bytes) = c4 42 f2 f5 c0
0086h pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
008bh mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
008eh lea rdx,[rax+28h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 28
0092h mov r8,0FF0000000000h         ; MOV(Mov_r64_imm64) [R8,ff0000000000h:imm64]          encoding(10 bytes) = 49 b8 00 00 00 00 00 ff 00 00
009ch pext r8,rcx,r8                ; PEXT(VEX_Pext_r64_r64_rm64) [R8,RCX,R8]              encoding(VEX, 5 bytes) = c4 42 f2 f5 c0
00a1h pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
00a6h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
00a9h lea rdx,[rax+30h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 30
00adh mov r8,0FF000000000000h       ; MOV(Mov_r64_imm64) [R8,ff000000000000h:imm64]        encoding(10 bytes) = 49 b8 00 00 00 00 00 00 ff 00
00b7h pext r8,rcx,r8                ; PEXT(VEX_Pext_r64_r64_rm64) [R8,RCX,R8]              encoding(VEX, 5 bytes) = c4 42 f2 f5 c0
00bch pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
00c1h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
00c4h add rax,38h                   ; ADD(Add_rm64_imm8) [RAX,38h:imm64]                   encoding(4 bytes) = 48 83 c0 38
00c8h mov rdx,0FF00000000000000h    ; MOV(Mov_r64_imm64) [RDX,ff00000000000000h:imm64]     encoding(10 bytes) = 48 ba 00 00 00 00 00 00 00 ff
00d2h pext rdx,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RDX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 d2
00d7h pdep rdx,rdx,r9               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,R9]             encoding(VEX, 5 bytes) = c4 c2 eb f5 d1
00dch mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
00dfh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
00e3h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00e4h call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F5494F0h:jmp64]                encoding(5 bytes) = e8 07 94 54 5f
00e9h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part64x1Bytes => new byte[234]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0xBA,0xFF,0x00,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xD2,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xC2,0xEB,0xF5,0xD0,0x48,0x89,0x10,0x48,0x8D,0x50,0x08,0x41,0xB8,0x00,0xFF,0x00,0x00,0xC4,0x42,0xF2,0xF5,0xC0,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x10,0x41,0xB8,0x00,0x00,0xFF,0x00,0xC4,0x42,0xF2,0xF5,0xC0,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x18,0x41,0xB8,0x00,0x00,0x00,0xFF,0xC4,0x42,0xF2,0xF5,0xC0,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x20,0x49,0xB8,0x00,0x00,0x00,0x00,0xFF,0x00,0x00,0x00,0xC4,0x42,0xF2,0xF5,0xC0,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x28,0x49,0xB8,0x00,0x00,0x00,0x00,0x00,0xFF,0x00,0x00,0xC4,0x42,0xF2,0xF5,0xC0,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x30,0x49,0xB8,0x00,0x00,0x00,0x00,0x00,0x00,0xFF,0x00,0xC4,0x42,0xF2,0xF5,0xC0,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x83,0xC0,0x38,0x48,0xBA,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0xFF,0xC4,0xE2,0xF2,0xF5,0xD2,0xC4,0xC2,0xEB,0xF5,0xD1,0x48,0x89,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x07,0x94,0x54,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part64x1(ulong src, Span<bit> dst)
; location: [7FFDDB005960h, 7FFDDB005987h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000ah movsxd r8,edx                 ; MOVSXD(Movsxd_r64_rm32) [R8,EDX]                     encoding(3 bytes) = 4c 63 c2
000dh lea r8,[rax+r8*4]             ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4e 8d 04 80
0011h bt rcx,rdx                    ; BT(Bt_rm64_r64) [RCX,RDX]                            encoding(4 bytes) = 48 0f a3 d1
0015h setb r9b                      ; SETB(Setb_rm8) [R9L]                                 encoding(4 bytes) = 41 0f 92 c1
0019h movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
001dh mov [r8],r9d                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),R9D]           encoding(3 bytes) = 45 89 08
0020h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0022h cmp edx,40h                   ; CMP(Cmp_rm32_imm8) [EDX,40h:imm32]                   encoding(3 bytes) = 83 fa 40
0025h jl short 000ah                ; JL(Jl_rel8_64) [Ah:jmp64]                            encoding(2 bytes) = 7c e3
0027h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part64x1Bytes => new byte[40]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x33,0xD2,0x4C,0x63,0xC2,0x4E,0x8D,0x04,0x80,0x48,0x0F,0xA3,0xD1,0x41,0x0F,0x92,0xC1,0x45,0x0F,0xB6,0xC9,0x45,0x89,0x08,0xFF,0xC2,0x83,0xFA,0x40,0x7C,0xE3,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part32x1(uint src, ref ulong dst)
; location: [7FFDDB0059A0h, 7FFDDB005A19h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFh                  ; MOV(Mov_r32_imm32) [EAX,ffh:imm32]                   encoding(5 bytes) = b8 ff 00 00 00
000ah pext eax,ecx,eax              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EAX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c0
000fh mov eax,eax                   ; MOV(Mov_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 8b c0
0011h mov r8,101010101010101h       ; MOV(Mov_r64_imm64) [R8,101010101010101h:imm64]       encoding(10 bytes) = 49 b8 01 01 01 01 01 01 01 01
001bh pdep rax,rax,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R8]             encoding(VEX, 5 bytes) = c4 c2 fb f5 c0
0020h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
0023h lea rax,[rdx+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RDX:br,:sr)]         encoding(4 bytes) = 48 8d 42 08
0027h mov r8d,0FF00h                ; MOV(Mov_r32_imm32) [R8D,ff00h:imm32]                 encoding(6 bytes) = 41 b8 00 ff 00 00
002dh pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
0032h mov r8d,r8d                   ; MOV(Mov_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 8b c0
0035h mov r9,101010101010101h       ; MOV(Mov_r64_imm64) [R9,101010101010101h:imm64]       encoding(10 bytes) = 49 b9 01 01 01 01 01 01 01 01
003fh pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
0044h mov [rax],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),R8]           encoding(3 bytes) = 4c 89 00
0047h lea rax,[rdx+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RDX:br,:sr)]         encoding(4 bytes) = 48 8d 42 10
004bh mov r8d,0FF0000h              ; MOV(Mov_r32_imm32) [R8D,ff0000h:imm32]               encoding(6 bytes) = 41 b8 00 00 ff 00
0051h pext r8d,ecx,r8d              ; PEXT(VEX_Pext_r32_r32_rm32) [R8D,ECX,R8D]            encoding(VEX, 5 bytes) = c4 42 72 f5 c0
0056h mov r8d,r8d                   ; MOV(Mov_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 8b c0
0059h pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
005eh mov [rax],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),R8]           encoding(3 bytes) = 4c 89 00
0061h add rdx,18h                   ; ADD(Add_rm64_imm8) [RDX,18h:imm64]                   encoding(4 bytes) = 48 83 c2 18
0065h mov eax,0FF000000h            ; MOV(Mov_r32_imm32) [EAX,ff000000h:imm32]             encoding(5 bytes) = b8 00 00 00 ff
006ah pext eax,ecx,eax              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EAX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c0
006fh mov eax,eax                   ; MOV(Mov_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 8b c0
0071h pdep rax,rax,r9               ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R9]             encoding(VEX, 5 bytes) = c4 c2 fb f5 c1
0076h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
0079h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part32x1Bytes => new byte[122]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0x00,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC0,0x8B,0xC0,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xC2,0xFB,0xF5,0xC0,0x48,0x89,0x02,0x48,0x8D,0x42,0x08,0x41,0xB8,0x00,0xFF,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x45,0x8B,0xC0,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x00,0x48,0x8D,0x42,0x10,0x41,0xB8,0x00,0x00,0xFF,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x45,0x8B,0xC0,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x00,0x48,0x83,0xC2,0x18,0xB8,0x00,0x00,0x00,0xFF,0xC4,0xE2,0x72,0xF5,0xC0,0x8B,0xC0,0xC4,0xC2,0xFB,0xF5,0xC1,0x48,0x89,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part64x1(ulong src, ref ulong dst)
; location: [7FFDDB005A30h, 7FFDDB005B0Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0FFh                  ; MOV(Mov_r32_imm32) [EAX,ffh:imm32]                   encoding(5 bytes) = b8 ff 00 00 00
000ah pext rax,rcx,rax              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c0
000fh mov r8,101010101010101h       ; MOV(Mov_r64_imm64) [R8,101010101010101h:imm64]       encoding(10 bytes) = 49 b8 01 01 01 01 01 01 01 01
0019h pdep rax,rax,r8               ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R8]             encoding(VEX, 5 bytes) = c4 c2 fb f5 c0
001eh mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
0021h lea rax,[rdx+8]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RDX:br,:sr)]         encoding(4 bytes) = 48 8d 42 08
0025h mov r8d,0FF00h                ; MOV(Mov_r32_imm32) [R8D,ff00h:imm32]                 encoding(6 bytes) = 41 b8 00 ff 00 00
002bh pext r8,rcx,r8                ; PEXT(VEX_Pext_r64_r64_rm64) [R8,RCX,R8]              encoding(VEX, 5 bytes) = c4 42 f2 f5 c0
0030h mov r9,101010101010101h       ; MOV(Mov_r64_imm64) [R9,101010101010101h:imm64]       encoding(10 bytes) = 49 b9 01 01 01 01 01 01 01 01
003ah pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
003fh mov [rax],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),R8]           encoding(3 bytes) = 4c 89 00
0042h lea rax,[rdx+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RDX:br,:sr)]         encoding(4 bytes) = 48 8d 42 10
0046h mov r8d,0FF0000h              ; MOV(Mov_r32_imm32) [R8D,ff0000h:imm32]               encoding(6 bytes) = 41 b8 00 00 ff 00
004ch pext r8,rcx,r8                ; PEXT(VEX_Pext_r64_r64_rm64) [R8,RCX,R8]              encoding(VEX, 5 bytes) = c4 42 f2 f5 c0
0051h pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
0056h mov [rax],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),R8]           encoding(3 bytes) = 4c 89 00
0059h lea rax,[rdx+18h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RDX:br,:sr)]         encoding(4 bytes) = 48 8d 42 18
005dh mov r8d,0FF000000h            ; MOV(Mov_r32_imm32) [R8D,ff000000h:imm32]             encoding(6 bytes) = 41 b8 00 00 00 ff
0063h pext r8,rcx,r8                ; PEXT(VEX_Pext_r64_r64_rm64) [R8,RCX,R8]              encoding(VEX, 5 bytes) = c4 42 f2 f5 c0
0068h pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
006dh mov [rax],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),R8]           encoding(3 bytes) = 4c 89 00
0070h lea rax,[rdx+20h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RDX:br,:sr)]         encoding(4 bytes) = 48 8d 42 20
0074h mov r8,0FF00000000h           ; MOV(Mov_r64_imm64) [R8,ff00000000h:imm64]            encoding(10 bytes) = 49 b8 00 00 00 00 ff 00 00 00
007eh pext r8,rcx,r8                ; PEXT(VEX_Pext_r64_r64_rm64) [R8,RCX,R8]              encoding(VEX, 5 bytes) = c4 42 f2 f5 c0
0083h pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
0088h mov [rax],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),R8]           encoding(3 bytes) = 4c 89 00
008bh lea rax,[rdx+28h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RDX:br,:sr)]         encoding(4 bytes) = 48 8d 42 28
008fh mov r8,0FF0000000000h         ; MOV(Mov_r64_imm64) [R8,ff0000000000h:imm64]          encoding(10 bytes) = 49 b8 00 00 00 00 00 ff 00 00
0099h pext r8,rcx,r8                ; PEXT(VEX_Pext_r64_r64_rm64) [R8,RCX,R8]              encoding(VEX, 5 bytes) = c4 42 f2 f5 c0
009eh pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
00a3h mov [rax],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),R8]           encoding(3 bytes) = 4c 89 00
00a6h lea rax,[rdx+30h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RDX:br,:sr)]         encoding(4 bytes) = 48 8d 42 30
00aah mov r8,0FF000000000000h       ; MOV(Mov_r64_imm64) [R8,ff000000000000h:imm64]        encoding(10 bytes) = 49 b8 00 00 00 00 00 00 ff 00
00b4h pext r8,rcx,r8                ; PEXT(VEX_Pext_r64_r64_rm64) [R8,RCX,R8]              encoding(VEX, 5 bytes) = c4 42 f2 f5 c0
00b9h pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
00beh mov [rax],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),R8]           encoding(3 bytes) = 4c 89 00
00c1h add rdx,38h                   ; ADD(Add_rm64_imm8) [RDX,38h:imm64]                   encoding(4 bytes) = 48 83 c2 38
00c5h mov rax,0FF00000000000000h    ; MOV(Mov_r64_imm64) [RAX,ff00000000000000h:imm64]     encoding(10 bytes) = 48 b8 00 00 00 00 00 00 00 ff
00cfh pext rax,rcx,rax              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c0
00d4h pdep rax,rax,r9               ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RAX,R9]             encoding(VEX, 5 bytes) = c4 c2 fb f5 c1
00d9h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(3 bytes) = 48 89 02
00dch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part64x1Bytes => new byte[221]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0x00,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC0,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xC2,0xFB,0xF5,0xC0,0x48,0x89,0x02,0x48,0x8D,0x42,0x08,0x41,0xB8,0x00,0xFF,0x00,0x00,0xC4,0x42,0xF2,0xF5,0xC0,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x00,0x48,0x8D,0x42,0x10,0x41,0xB8,0x00,0x00,0xFF,0x00,0xC4,0x42,0xF2,0xF5,0xC0,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x00,0x48,0x8D,0x42,0x18,0x41,0xB8,0x00,0x00,0x00,0xFF,0xC4,0x42,0xF2,0xF5,0xC0,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x00,0x48,0x8D,0x42,0x20,0x49,0xB8,0x00,0x00,0x00,0x00,0xFF,0x00,0x00,0x00,0xC4,0x42,0xF2,0xF5,0xC0,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x00,0x48,0x8D,0x42,0x28,0x49,0xB8,0x00,0x00,0x00,0x00,0x00,0xFF,0x00,0x00,0xC4,0x42,0xF2,0xF5,0xC0,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x00,0x48,0x8D,0x42,0x30,0x49,0xB8,0x00,0x00,0x00,0x00,0x00,0x00,0xFF,0x00,0xC4,0x42,0xF2,0xF5,0xC0,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x00,0x48,0x83,0xC2,0x38,0x48,0xB8,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0xFF,0xC4,0xE2,0xF2,0xF5,0xC0,0xC4,0xC2,0xFB,0xF5,0xC1,0x48,0x89,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part4x2:uint part)
; location: [7FFDDB005B20h, 7FFDDB005B2Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part6x2:uint part)
; location: [7FFDDB005B40h, 7FFDDB005B4Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part8x2:uint part)
; location: [7FFDDB005B60h, 7FFDDB005B6Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part10x2:uint part)
; location: [7FFDDB005B80h, 7FFDDB005B8Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part12x2:uint part)
; location: [7FFDDB005BA0h, 7FFDDB005BAAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part16x2:uint part)
; location: [7FFDDB005BC0h, 7FFDDB005BCAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part32x2:uint part)
; location: [7FFDDB005BE0h, 7FFDDB005BEAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select(ulong src, Part64x2:uint part)
; location: [7FFDDB005C00h, 7FFDDB005C0Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h pext rax,rcx,rax              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xC4,0xE2,0xF2,0xF5,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part4x2:uint part)
; location: [7FFDDB005C20h, 7FFDDB005C2Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(byte src, Part6x2:uint part)
; location: [7FFDDB005C40h, 7FFDDB005C4Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h pdep eax,eax,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7b f5 c2
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x7B,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part8x2:uint part)
; location: [7FFDDB005C60h, 7FFDDB005C6Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part10x2:uint part)
; location: [7FFDDB005C80h, 7FFDDB005C8Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part12x2:uint part)
; location: [7FFDDB005CA0h, 7FFDDB005CAAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part16x2:uint part)
; location: [7FFDDB005CC0h, 7FFDDB005CCAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part32x2:uint part)
; location: [7FFDDB005CE0h, 7FFDDB005CEAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong project(ulong src, Part64x2:uint part)
; location: [7FFDDB005D00h, 7FFDDB005D0Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h pdep rax,rcx,rax              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xC4,0xE2,0xF3,0xF5,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part8x2(uint src, ref byte dst)
; location: [7FFDDB005D20h, 7FFDDB005D4Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,3                     ; AND(And_rm32_imm8) [EAX,3h:imm32]                    encoding(3 bytes) = 83 e0 03
000ah mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
000ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000eh shr eax,2                     ; SHR(Shr_rm32_imm8) [EAX,2h:imm8]                     encoding(3 bytes) = c1 e8 02
0011h and eax,3                     ; AND(And_rm32_imm8) [EAX,3h:imm32]                    encoding(3 bytes) = 83 e0 03
0014h mov [rdx+1],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 01
0017h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0019h shr eax,4                     ; SHR(Shr_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e8 04
001ch and eax,3                     ; AND(And_rm32_imm8) [EAX,3h:imm32]                    encoding(3 bytes) = 83 e0 03
001fh mov [rdx+2],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 02
0022h shr ecx,6                     ; SHR(Shr_rm32_imm8) [ECX,6h:imm8]                     encoding(3 bytes) = c1 e9 06
0025h and ecx,3                     ; AND(And_rm32_imm8) [ECX,3h:imm32]                    encoding(3 bytes) = 83 e1 03
0028h mov [rdx+3],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 03
002bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part8x2Bytes => new byte[44]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x83,0xE0,0x03,0x88,0x02,0x8B,0xC1,0xC1,0xE8,0x02,0x83,0xE0,0x03,0x88,0x42,0x01,0x8B,0xC1,0xC1,0xE8,0x04,0x83,0xE0,0x03,0x88,0x42,0x02,0xC1,0xE9,0x06,0x83,0xE1,0x03,0x88,0x4A,0x03,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part8x2(byte src, ref byte dst)
; location: [7FFDDB005D60h, 7FFDDB005D8Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
000ah and ecx,3                     ; AND(And_rm32_imm8) [ECX,3h:imm32]                    encoding(3 bytes) = 83 e1 03
000dh mov [rdx],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(2 bytes) = 88 0a
000fh mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0011h shr ecx,2                     ; SHR(Shr_rm32_imm8) [ECX,2h:imm8]                     encoding(3 bytes) = c1 e9 02
0014h and ecx,3                     ; AND(And_rm32_imm8) [ECX,3h:imm32]                    encoding(3 bytes) = 83 e1 03
0017h mov [rdx+1],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 01
001ah mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
001ch shr ecx,4                     ; SHR(Shr_rm32_imm8) [ECX,4h:imm8]                     encoding(3 bytes) = c1 e9 04
001fh and ecx,3                     ; AND(And_rm32_imm8) [ECX,3h:imm32]                    encoding(3 bytes) = 83 e1 03
0022h mov [rdx+2],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 02
0025h shr eax,6                     ; SHR(Shr_rm32_imm8) [EAX,6h:imm8]                     encoding(3 bytes) = c1 e8 06
0028h and eax,3                     ; AND(And_rm32_imm8) [EAX,3h:imm32]                    encoding(3 bytes) = 83 e0 03
002bh mov [rdx+3],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 03
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part8x2Bytes => new byte[47]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x8B,0xC8,0x83,0xE1,0x03,0x88,0x0A,0x8B,0xC8,0xC1,0xE9,0x02,0x83,0xE1,0x03,0x88,0x4A,0x01,0x8B,0xC8,0xC1,0xE9,0x04,0x83,0xE1,0x03,0x88,0x4A,0x02,0xC1,0xE8,0x06,0x83,0xE0,0x03,0x88,0x42,0x03,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part16x2(ushort src, ref byte dst)
; location: [7FFDDB005DA0h, 7FFDDB005E0Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx ecx,al                  ; MOVZX(Movzx_r32_rm8) [ECX,AL]                        encoding(3 bytes) = 0f b6 c8
000bh mov r8d,ecx                   ; MOV(Mov_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 8b c1
000eh and r8d,3                     ; AND(And_rm32_imm8) [R8D,3h:imm32]                    encoding(4 bytes) = 41 83 e0 03
0012h mov [rdx],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),R8L]             encoding(3 bytes) = 44 88 02
0015h mov r8d,ecx                   ; MOV(Mov_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 8b c1
0018h shr r8d,2                     ; SHR(Shr_rm32_imm8) [R8D,2h:imm8]                     encoding(4 bytes) = 41 c1 e8 02
001ch and r8d,3                     ; AND(And_rm32_imm8) [R8D,3h:imm32]                    encoding(4 bytes) = 41 83 e0 03
0020h mov [rdx+1],r8b               ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),R8L]             encoding(4 bytes) = 44 88 42 01
0024h mov r8d,ecx                   ; MOV(Mov_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 8b c1
0027h shr r8d,4                     ; SHR(Shr_rm32_imm8) [R8D,4h:imm8]                     encoding(4 bytes) = 41 c1 e8 04
002bh and r8d,3                     ; AND(And_rm32_imm8) [R8D,3h:imm32]                    encoding(4 bytes) = 41 83 e0 03
002fh mov [rdx+2],r8b               ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),R8L]             encoding(4 bytes) = 44 88 42 02
0033h shr ecx,6                     ; SHR(Shr_rm32_imm8) [ECX,6h:imm8]                     encoding(3 bytes) = c1 e9 06
0036h and ecx,3                     ; AND(And_rm32_imm8) [ECX,3h:imm32]                    encoding(3 bytes) = 83 e1 03
0039h mov [rdx+3],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 03
003ch sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
003fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0042h add rdx,4                     ; ADD(Add_rm64_imm8) [RDX,4h:imm64]                    encoding(4 bytes) = 48 83 c2 04
0046h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0048h and ecx,3                     ; AND(And_rm32_imm8) [ECX,3h:imm32]                    encoding(3 bytes) = 83 e1 03
004bh mov [rdx],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(2 bytes) = 88 0a
004dh mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
004fh shr ecx,2                     ; SHR(Shr_rm32_imm8) [ECX,2h:imm8]                     encoding(3 bytes) = c1 e9 02
0052h and ecx,3                     ; AND(And_rm32_imm8) [ECX,3h:imm32]                    encoding(3 bytes) = 83 e1 03
0055h mov [rdx+1],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 01
0058h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
005ah shr ecx,4                     ; SHR(Shr_rm32_imm8) [ECX,4h:imm8]                     encoding(3 bytes) = c1 e9 04
005dh and ecx,3                     ; AND(And_rm32_imm8) [ECX,3h:imm32]                    encoding(3 bytes) = 83 e1 03
0060h mov [rdx+2],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 02
0063h shr eax,6                     ; SHR(Shr_rm32_imm8) [EAX,6h:imm8]                     encoding(3 bytes) = c1 e8 06
0066h and eax,3                     ; AND(And_rm32_imm8) [EAX,3h:imm32]                    encoding(3 bytes) = 83 e0 03
0069h mov [rdx+3],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 03
006ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part16x2Bytes => new byte[109]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB6,0xC8,0x44,0x8B,0xC1,0x41,0x83,0xE0,0x03,0x44,0x88,0x02,0x44,0x8B,0xC1,0x41,0xC1,0xE8,0x02,0x41,0x83,0xE0,0x03,0x44,0x88,0x42,0x01,0x44,0x8B,0xC1,0x41,0xC1,0xE8,0x04,0x41,0x83,0xE0,0x03,0x44,0x88,0x42,0x02,0xC1,0xE9,0x06,0x83,0xE1,0x03,0x88,0x4A,0x03,0xC1,0xF8,0x08,0x0F,0xB6,0xC0,0x48,0x83,0xC2,0x04,0x8B,0xC8,0x83,0xE1,0x03,0x88,0x0A,0x8B,0xC8,0xC1,0xE9,0x02,0x83,0xE1,0x03,0x88,0x4A,0x01,0x8B,0xC8,0xC1,0xE9,0x04,0x83,0xE1,0x03,0x88,0x4A,0x02,0xC1,0xE8,0x06,0x83,0xE0,0x03,0x88,0x42,0x03,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part32x2(uint src, ref byte dst)
; location: [7FFDDB005E20h, 7FFDDB005F0Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx r8d,al                  ; MOVZX(Movzx_r32_rm8) [R8D,AL]                        encoding(4 bytes) = 44 0f b6 c0
000ch mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
000fh and r9d,3                     ; AND(And_rm32_imm8) [R9D,3h:imm32]                    encoding(4 bytes) = 41 83 e1 03
0013h mov [rdx],r9b                 ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),R9L]             encoding(3 bytes) = 44 88 0a
0016h mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0019h shr r9d,2                     ; SHR(Shr_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e9 02
001dh and r9d,3                     ; AND(And_rm32_imm8) [R9D,3h:imm32]                    encoding(4 bytes) = 41 83 e1 03
0021h mov [rdx+1],r9b               ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),R9L]             encoding(4 bytes) = 44 88 4a 01
0025h mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
0028h shr r9d,4                     ; SHR(Shr_rm32_imm8) [R9D,4h:imm8]                     encoding(4 bytes) = 41 c1 e9 04
002ch and r9d,3                     ; AND(And_rm32_imm8) [R9D,3h:imm32]                    encoding(4 bytes) = 41 83 e1 03
0030h mov [rdx+2],r9b               ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),R9L]             encoding(4 bytes) = 44 88 4a 02
0034h shr r8d,6                     ; SHR(Shr_rm32_imm8) [R8D,6h:imm8]                     encoding(4 bytes) = 41 c1 e8 06
0038h and r8d,3                     ; AND(And_rm32_imm8) [R8D,3h:imm32]                    encoding(4 bytes) = 41 83 e0 03
003ch mov [rdx+3],r8b               ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),R8L]             encoding(4 bytes) = 44 88 42 03
0040h sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
0043h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0046h lea r8,[rdx+4]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RDX:br,:sr)]          encoding(4 bytes) = 4c 8d 42 04
004ah mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
004dh and r9d,3                     ; AND(And_rm32_imm8) [R9D,3h:imm32]                    encoding(4 bytes) = 41 83 e1 03
0051h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R9L]              encoding(3 bytes) = 45 88 08
0054h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
0057h shr r9d,2                     ; SHR(Shr_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e9 02
005bh and r9d,3                     ; AND(And_rm32_imm8) [R9D,3h:imm32]                    encoding(4 bytes) = 41 83 e1 03
005fh mov [r8+1],r9b                ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R9L]              encoding(4 bytes) = 45 88 48 01
0063h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
0066h shr r9d,4                     ; SHR(Shr_rm32_imm8) [R9D,4h:imm8]                     encoding(4 bytes) = 41 c1 e9 04
006ah and r9d,3                     ; AND(And_rm32_imm8) [R9D,3h:imm32]                    encoding(4 bytes) = 41 83 e1 03
006eh mov [r8+2],r9b                ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R9L]              encoding(4 bytes) = 45 88 48 02
0072h shr eax,6                     ; SHR(Shr_rm32_imm8) [EAX,6h:imm8]                     encoding(3 bytes) = c1 e8 06
0075h and eax,3                     ; AND(And_rm32_imm8) [EAX,3h:imm32]                    encoding(3 bytes) = 83 e0 03
0078h mov [r8+3],al                 ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),AL]               encoding(4 bytes) = 41 88 40 03
007ch shr ecx,10h                   ; SHR(Shr_rm32_imm8) [ECX,10h:imm8]                    encoding(3 bytes) = c1 e9 10
007fh movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0082h add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
0086h movzx ecx,al                  ; MOVZX(Movzx_r32_rm8) [ECX,AL]                        encoding(3 bytes) = 0f b6 c8
0089h mov r8d,ecx                   ; MOV(Mov_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 8b c1
008ch and r8d,3                     ; AND(And_rm32_imm8) [R8D,3h:imm32]                    encoding(4 bytes) = 41 83 e0 03
0090h mov [rdx],r8b                 ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),R8L]             encoding(3 bytes) = 44 88 02
0093h mov r8d,ecx                   ; MOV(Mov_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 8b c1
0096h shr r8d,2                     ; SHR(Shr_rm32_imm8) [R8D,2h:imm8]                     encoding(4 bytes) = 41 c1 e8 02
009ah and r8d,3                     ; AND(And_rm32_imm8) [R8D,3h:imm32]                    encoding(4 bytes) = 41 83 e0 03
009eh mov [rdx+1],r8b               ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),R8L]             encoding(4 bytes) = 44 88 42 01
00a2h mov r8d,ecx                   ; MOV(Mov_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 8b c1
00a5h shr r8d,4                     ; SHR(Shr_rm32_imm8) [R8D,4h:imm8]                     encoding(4 bytes) = 41 c1 e8 04
00a9h and r8d,3                     ; AND(And_rm32_imm8) [R8D,3h:imm32]                    encoding(4 bytes) = 41 83 e0 03
00adh mov [rdx+2],r8b               ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),R8L]             encoding(4 bytes) = 44 88 42 02
00b1h shr ecx,6                     ; SHR(Shr_rm32_imm8) [ECX,6h:imm8]                     encoding(3 bytes) = c1 e9 06
00b4h and ecx,3                     ; AND(And_rm32_imm8) [ECX,3h:imm32]                    encoding(3 bytes) = 83 e1 03
00b7h mov [rdx+3],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 03
00bah sar eax,8                     ; SAR(Sar_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 f8 08
00bdh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00c0h add rdx,4                     ; ADD(Add_rm64_imm8) [RDX,4h:imm64]                    encoding(4 bytes) = 48 83 c2 04
00c4h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
00c6h and ecx,3                     ; AND(And_rm32_imm8) [ECX,3h:imm32]                    encoding(3 bytes) = 83 e1 03
00c9h mov [rdx],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(2 bytes) = 88 0a
00cbh mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
00cdh shr ecx,2                     ; SHR(Shr_rm32_imm8) [ECX,2h:imm8]                     encoding(3 bytes) = c1 e9 02
00d0h and ecx,3                     ; AND(And_rm32_imm8) [ECX,3h:imm32]                    encoding(3 bytes) = 83 e1 03
00d3h mov [rdx+1],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 01
00d6h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
00d8h shr ecx,4                     ; SHR(Shr_rm32_imm8) [ECX,4h:imm8]                     encoding(3 bytes) = c1 e9 04
00dbh and ecx,3                     ; AND(And_rm32_imm8) [ECX,3h:imm32]                    encoding(3 bytes) = 83 e1 03
00deh mov [rdx+2],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 02
00e1h shr eax,6                     ; SHR(Shr_rm32_imm8) [EAX,6h:imm8]                     encoding(3 bytes) = c1 e8 06
00e4h and eax,3                     ; AND(And_rm32_imm8) [EAX,3h:imm32]                    encoding(3 bytes) = 83 e0 03
00e7h mov [rdx+3],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 03
00eah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part32x2Bytes => new byte[235]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x44,0x0F,0xB6,0xC0,0x45,0x8B,0xC8,0x41,0x83,0xE1,0x03,0x44,0x88,0x0A,0x45,0x8B,0xC8,0x41,0xC1,0xE9,0x02,0x41,0x83,0xE1,0x03,0x44,0x88,0x4A,0x01,0x45,0x8B,0xC8,0x41,0xC1,0xE9,0x04,0x41,0x83,0xE1,0x03,0x44,0x88,0x4A,0x02,0x41,0xC1,0xE8,0x06,0x41,0x83,0xE0,0x03,0x44,0x88,0x42,0x03,0xC1,0xF8,0x08,0x0F,0xB6,0xC0,0x4C,0x8D,0x42,0x04,0x44,0x8B,0xC8,0x41,0x83,0xE1,0x03,0x45,0x88,0x08,0x44,0x8B,0xC8,0x41,0xC1,0xE9,0x02,0x41,0x83,0xE1,0x03,0x45,0x88,0x48,0x01,0x44,0x8B,0xC8,0x41,0xC1,0xE9,0x04,0x41,0x83,0xE1,0x03,0x45,0x88,0x48,0x02,0xC1,0xE8,0x06,0x83,0xE0,0x03,0x41,0x88,0x40,0x03,0xC1,0xE9,0x10,0x0F,0xB7,0xC1,0x48,0x83,0xC2,0x08,0x0F,0xB6,0xC8,0x44,0x8B,0xC1,0x41,0x83,0xE0,0x03,0x44,0x88,0x02,0x44,0x8B,0xC1,0x41,0xC1,0xE8,0x02,0x41,0x83,0xE0,0x03,0x44,0x88,0x42,0x01,0x44,0x8B,0xC1,0x41,0xC1,0xE8,0x04,0x41,0x83,0xE0,0x03,0x44,0x88,0x42,0x02,0xC1,0xE9,0x06,0x83,0xE1,0x03,0x88,0x4A,0x03,0xC1,0xF8,0x08,0x0F,0xB6,0xC0,0x48,0x83,0xC2,0x04,0x8B,0xC8,0x83,0xE1,0x03,0x88,0x0A,0x8B,0xC8,0xC1,0xE9,0x02,0x83,0xE1,0x03,0x88,0x4A,0x01,0x8B,0xC8,0xC1,0xE9,0x04,0x83,0xE1,0x03,0x88,0x4A,0x02,0xC1,0xE8,0x06,0x83,0xE0,0x03,0x88,0x42,0x03,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part64x32(ulong src, Span<uint> dst)
; location: [7FFDDB005F20h, 7FFDDB005F49h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 52 08
000bh shl rdx,2                     ; SHL(Shl_rm64_imm8) [RDX,2h:imm8]                     encoding(4 bytes) = 48 c1 e2 02
000fh shr rdx,3                     ; SHR(Shr_rm64_imm8) [RDX,3h:imm8]                     encoding(4 bytes) = 48 c1 ea 03
0013h cmp rdx,7FFFFFFFh             ; CMP(Cmp_rm64_imm32) [RDX,7fffffffh:imm64]            encoding(7 bytes) = 48 81 fa ff ff ff 7f
001ah ja short 0024h                ; JA(Ja_rel8_64) [24h:jmp64]                           encoding(2 bytes) = 77 08
001ch mov [rax],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RCX]          encoding(3 bytes) = 48 89 08
001fh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0024h call 7FFE3A54ED50h            ; CALL(Call_rel32_64) [5F548E30h:jmp64]                encoding(5 bytes) = e8 07 8e 54 5f
0029h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part64x32Bytes => new byte[42]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0x52,0x08,0x48,0xC1,0xE2,0x02,0x48,0xC1,0xEA,0x03,0x48,0x81,0xFA,0xFF,0xFF,0xFF,0x7F,0x77,0x08,0x48,0x89,0x08,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x07,0x8E,0x54,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part64x32(ulong src, ref uint dst)
; location: [7FFDDB005F60h, 7FFDDB005F68h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],rcx                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RCX]          encoding(3 bytes) = 48 89 0a
0008h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part64x32Bytes => new byte[9]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x89,0x0A,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part6x3:uint part)
; location: [7FFDDB005F80h, 7FFDDB005F8Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part9x3:uint part)
; location: [7FFDDB005FA0h, 7FFDDB005FAAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part12x3:uint part)
; location: [7FFDDB005FC0h, 7FFDDB005FCAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part15x3:uint part)
; location: [7FFDDB005FE0h, 7FFDDB005FEAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part18x3:uint part)
; location: [7FFDDB006000h, 7FFDDB00600Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part21x3:uint part)
; location: [7FFDDB006020h, 7FFDDB00602Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part24x3:uint part)
; location: [7FFDDB006040h, 7FFDDB00604Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part27x3:uint part)
; location: [7FFDDB006060h, 7FFDDB00606Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part30x3:uint part)
; location: [7FFDDB006080h, 7FFDDB00608Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part12x3:uint part)
; location: [7FFDDB0060A0h, 7FFDDB0060AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part6x3:uint part)
; location: [7FFDDB0060C0h, 7FFDDB0060CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part9x3:uint part)
; location: [7FFDDB0060E0h, 7FFDDB0060EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part15x3:uint part)
; location: [7FFDDB006100h, 7FFDDB00610Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part18x3:uint part)
; location: [7FFDDB006120h, 7FFDDB00612Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part21x3:uint part)
; location: [7FFDDB006140h, 7FFDDB00614Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part24x3:uint part)
; location: [7FFDDB006160h, 7FFDDB00616Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part27x3:uint part)
; location: [7FFDDB006180h, 7FFDDB00618Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part30x3:uint part)
; location: [7FFDDB0061A0h, 7FFDDB0061AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part6x3(uint src, ref byte dst)
; location: [7FFDDB0061C0h, 7FFDDB0061D5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
000ah mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
000ch shr ecx,3                     ; SHR(Shr_rm32_imm8) [ECX,3h:imm8]                     encoding(3 bytes) = c1 e9 03
000fh and ecx,7                     ; AND(And_rm32_imm8) [ECX,7h:imm32]                    encoding(3 bytes) = 83 e1 07
0012h mov [rdx+1],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 01
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part6x3Bytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x83,0xE0,0x07,0x88,0x02,0xC1,0xE9,0x03,0x83,0xE1,0x07,0x88,0x4A,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part9x3(uint src, ref byte dst)
; location: [7FFDDB0061F0h, 7FFDDB006210h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
000ah mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
000ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000eh shr eax,3                     ; SHR(Shr_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e8 03
0011h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
0014h mov [rdx+1],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 01
0017h shr ecx,6                     ; SHR(Shr_rm32_imm8) [ECX,6h:imm8]                     encoding(3 bytes) = c1 e9 06
001ah and ecx,7                     ; AND(And_rm32_imm8) [ECX,7h:imm32]                    encoding(3 bytes) = 83 e1 07
001dh mov [rdx+2],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 02
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part9x3Bytes => new byte[33]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x83,0xE0,0x07,0x88,0x02,0x8B,0xC1,0xC1,0xE8,0x03,0x83,0xE0,0x07,0x88,0x42,0x01,0xC1,0xE9,0x06,0x83,0xE1,0x07,0x88,0x4A,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part12x3(uint src, ref byte dst)
; location: [7FFDDB006230h, 7FFDDB00625Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
000ah mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
000ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000eh shr eax,3                     ; SHR(Shr_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e8 03
0011h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
0014h mov [rdx+1],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 01
0017h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0019h shr eax,6                     ; SHR(Shr_rm32_imm8) [EAX,6h:imm8]                     encoding(3 bytes) = c1 e8 06
001ch and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
001fh mov [rdx+2],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 02
0022h shr ecx,9                     ; SHR(Shr_rm32_imm8) [ECX,9h:imm8]                     encoding(3 bytes) = c1 e9 09
0025h and ecx,7                     ; AND(And_rm32_imm8) [ECX,7h:imm32]                    encoding(3 bytes) = 83 e1 07
0028h mov [rdx+3],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 03
002bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part12x3Bytes => new byte[44]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x83,0xE0,0x07,0x88,0x02,0x8B,0xC1,0xC1,0xE8,0x03,0x83,0xE0,0x07,0x88,0x42,0x01,0x8B,0xC1,0xC1,0xE8,0x06,0x83,0xE0,0x07,0x88,0x42,0x02,0xC1,0xE9,0x09,0x83,0xE1,0x07,0x88,0x4A,0x03,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part12x3(uint src, Span<byte> dst)
; location: [7FFDDB006270h, 7FFDDB00629Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000ah and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
000dh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
000fh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0011h shr edx,3                     ; SHR(Shr_rm32_imm8) [EDX,3h:imm8]                     encoding(3 bytes) = c1 ea 03
0014h and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0017h mov [rax+1],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 01
001ah mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
001ch shr edx,6                     ; SHR(Shr_rm32_imm8) [EDX,6h:imm8]                     encoding(3 bytes) = c1 ea 06
001fh and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0022h mov [rax+2],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 02
0025h shr ecx,9                     ; SHR(Shr_rm32_imm8) [ECX,9h:imm8]                     encoding(3 bytes) = c1 e9 09
0028h and ecx,7                     ; AND(And_rm32_imm8) [ECX,7h:imm32]                    encoding(3 bytes) = 83 e1 07
002bh mov [rax+3],cl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),CL]              encoding(3 bytes) = 88 48 03
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part12x3Bytes => new byte[47]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x8B,0xD1,0x83,0xE2,0x07,0x88,0x10,0x8B,0xD1,0xC1,0xEA,0x03,0x83,0xE2,0x07,0x88,0x50,0x01,0x8B,0xD1,0xC1,0xEA,0x06,0x83,0xE2,0x07,0x88,0x50,0x02,0xC1,0xE9,0x09,0x83,0xE1,0x07,0x88,0x48,0x03,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part15x3(uint src, ref byte dst)
; location: [7FFDDB0062B0h, 7FFDDB0062E6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
000ah mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
000ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000eh shr eax,3                     ; SHR(Shr_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e8 03
0011h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
0014h mov [rdx+1],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 01
0017h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0019h shr eax,6                     ; SHR(Shr_rm32_imm8) [EAX,6h:imm8]                     encoding(3 bytes) = c1 e8 06
001ch and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
001fh mov [rdx+2],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 02
0022h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0024h shr eax,9                     ; SHR(Shr_rm32_imm8) [EAX,9h:imm8]                     encoding(3 bytes) = c1 e8 09
0027h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
002ah mov [rdx+3],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 03
002dh shr ecx,0Ch                   ; SHR(Shr_rm32_imm8) [ECX,ch:imm8]                     encoding(3 bytes) = c1 e9 0c
0030h and ecx,7                     ; AND(And_rm32_imm8) [ECX,7h:imm32]                    encoding(3 bytes) = 83 e1 07
0033h mov [rdx+4],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 04
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part15x3Bytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x83,0xE0,0x07,0x88,0x02,0x8B,0xC1,0xC1,0xE8,0x03,0x83,0xE0,0x07,0x88,0x42,0x01,0x8B,0xC1,0xC1,0xE8,0x06,0x83,0xE0,0x07,0x88,0x42,0x02,0x8B,0xC1,0xC1,0xE8,0x09,0x83,0xE0,0x07,0x88,0x42,0x03,0xC1,0xE9,0x0C,0x83,0xE1,0x07,0x88,0x4A,0x04,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part15x3(uint src, Span<byte> dst)
; location: [7FFDDB006300h, 7FFDDB006339h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000ah and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
000dh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
000fh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0011h shr edx,3                     ; SHR(Shr_rm32_imm8) [EDX,3h:imm8]                     encoding(3 bytes) = c1 ea 03
0014h and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0017h mov [rax+1],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 01
001ah mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
001ch shr edx,6                     ; SHR(Shr_rm32_imm8) [EDX,6h:imm8]                     encoding(3 bytes) = c1 ea 06
001fh and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0022h mov [rax+2],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 02
0025h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0027h shr edx,9                     ; SHR(Shr_rm32_imm8) [EDX,9h:imm8]                     encoding(3 bytes) = c1 ea 09
002ah and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
002dh mov [rax+3],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 03
0030h shr ecx,0Ch                   ; SHR(Shr_rm32_imm8) [ECX,ch:imm8]                     encoding(3 bytes) = c1 e9 0c
0033h and ecx,7                     ; AND(And_rm32_imm8) [ECX,7h:imm32]                    encoding(3 bytes) = 83 e1 07
0036h mov [rax+4],cl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),CL]              encoding(3 bytes) = 88 48 04
0039h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part15x3Bytes => new byte[58]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x8B,0xD1,0x83,0xE2,0x07,0x88,0x10,0x8B,0xD1,0xC1,0xEA,0x03,0x83,0xE2,0x07,0x88,0x50,0x01,0x8B,0xD1,0xC1,0xEA,0x06,0x83,0xE2,0x07,0x88,0x50,0x02,0x8B,0xD1,0xC1,0xEA,0x09,0x83,0xE2,0x07,0x88,0x50,0x03,0xC1,0xE9,0x0C,0x83,0xE1,0x07,0x88,0x48,0x04,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part18x3(uint src, ref byte dst)
; location: [7FFDDB006350h, 7FFDDB006391h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
000ah mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
000ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000eh shr eax,3                     ; SHR(Shr_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e8 03
0011h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
0014h mov [rdx+1],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 01
0017h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0019h shr eax,6                     ; SHR(Shr_rm32_imm8) [EAX,6h:imm8]                     encoding(3 bytes) = c1 e8 06
001ch and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
001fh mov [rdx+2],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 02
0022h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0024h shr eax,9                     ; SHR(Shr_rm32_imm8) [EAX,9h:imm8]                     encoding(3 bytes) = c1 e8 09
0027h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
002ah mov [rdx+3],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 03
002dh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
002fh shr eax,0Ch                   ; SHR(Shr_rm32_imm8) [EAX,ch:imm8]                     encoding(3 bytes) = c1 e8 0c
0032h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
0035h mov [rdx+4],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 04
0038h shr ecx,0Fh                   ; SHR(Shr_rm32_imm8) [ECX,fh:imm8]                     encoding(3 bytes) = c1 e9 0f
003bh and ecx,7                     ; AND(And_rm32_imm8) [ECX,7h:imm32]                    encoding(3 bytes) = 83 e1 07
003eh mov [rdx+5],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 05
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part18x3Bytes => new byte[66]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x83,0xE0,0x07,0x88,0x02,0x8B,0xC1,0xC1,0xE8,0x03,0x83,0xE0,0x07,0x88,0x42,0x01,0x8B,0xC1,0xC1,0xE8,0x06,0x83,0xE0,0x07,0x88,0x42,0x02,0x8B,0xC1,0xC1,0xE8,0x09,0x83,0xE0,0x07,0x88,0x42,0x03,0x8B,0xC1,0xC1,0xE8,0x0C,0x83,0xE0,0x07,0x88,0x42,0x04,0xC1,0xE9,0x0F,0x83,0xE1,0x07,0x88,0x4A,0x05,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part18x3(uint src, Span<byte> dst)
; location: [7FFDDB0063B0h, 7FFDDB0063F4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000ah and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
000dh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
000fh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0011h shr edx,3                     ; SHR(Shr_rm32_imm8) [EDX,3h:imm8]                     encoding(3 bytes) = c1 ea 03
0014h and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0017h mov [rax+1],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 01
001ah mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
001ch shr edx,6                     ; SHR(Shr_rm32_imm8) [EDX,6h:imm8]                     encoding(3 bytes) = c1 ea 06
001fh and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0022h mov [rax+2],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 02
0025h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0027h shr edx,9                     ; SHR(Shr_rm32_imm8) [EDX,9h:imm8]                     encoding(3 bytes) = c1 ea 09
002ah and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
002dh mov [rax+3],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 03
0030h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0032h shr edx,0Ch                   ; SHR(Shr_rm32_imm8) [EDX,ch:imm8]                     encoding(3 bytes) = c1 ea 0c
0035h and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0038h mov [rax+4],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 04
003bh shr ecx,0Fh                   ; SHR(Shr_rm32_imm8) [ECX,fh:imm8]                     encoding(3 bytes) = c1 e9 0f
003eh and ecx,7                     ; AND(And_rm32_imm8) [ECX,7h:imm32]                    encoding(3 bytes) = 83 e1 07
0041h mov [rax+5],cl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),CL]              encoding(3 bytes) = 88 48 05
0044h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part18x3Bytes => new byte[69]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x8B,0xD1,0x83,0xE2,0x07,0x88,0x10,0x8B,0xD1,0xC1,0xEA,0x03,0x83,0xE2,0x07,0x88,0x50,0x01,0x8B,0xD1,0xC1,0xEA,0x06,0x83,0xE2,0x07,0x88,0x50,0x02,0x8B,0xD1,0xC1,0xEA,0x09,0x83,0xE2,0x07,0x88,0x50,0x03,0x8B,0xD1,0xC1,0xEA,0x0C,0x83,0xE2,0x07,0x88,0x50,0x04,0xC1,0xE9,0x0F,0x83,0xE1,0x07,0x88,0x48,0x05,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part21x3(uint src, ref byte dst)
; location: [7FFDDB006410h, 7FFDDB00645Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
000ah mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
000ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000eh shr eax,3                     ; SHR(Shr_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e8 03
0011h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
0014h mov [rdx+1],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 01
0017h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0019h shr eax,6                     ; SHR(Shr_rm32_imm8) [EAX,6h:imm8]                     encoding(3 bytes) = c1 e8 06
001ch and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
001fh mov [rdx+2],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 02
0022h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0024h shr eax,9                     ; SHR(Shr_rm32_imm8) [EAX,9h:imm8]                     encoding(3 bytes) = c1 e8 09
0027h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
002ah mov [rdx+3],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 03
002dh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
002fh shr eax,0Ch                   ; SHR(Shr_rm32_imm8) [EAX,ch:imm8]                     encoding(3 bytes) = c1 e8 0c
0032h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
0035h mov [rdx+4],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 04
0038h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
003ah shr eax,0Fh                   ; SHR(Shr_rm32_imm8) [EAX,fh:imm8]                     encoding(3 bytes) = c1 e8 0f
003dh and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
0040h mov [rdx+5],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 05
0043h shr ecx,12h                   ; SHR(Shr_rm32_imm8) [ECX,12h:imm8]                    encoding(3 bytes) = c1 e9 12
0046h and ecx,7                     ; AND(And_rm32_imm8) [ECX,7h:imm32]                    encoding(3 bytes) = 83 e1 07
0049h mov [rdx+6],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 06
004ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part21x3Bytes => new byte[77]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x83,0xE0,0x07,0x88,0x02,0x8B,0xC1,0xC1,0xE8,0x03,0x83,0xE0,0x07,0x88,0x42,0x01,0x8B,0xC1,0xC1,0xE8,0x06,0x83,0xE0,0x07,0x88,0x42,0x02,0x8B,0xC1,0xC1,0xE8,0x09,0x83,0xE0,0x07,0x88,0x42,0x03,0x8B,0xC1,0xC1,0xE8,0x0C,0x83,0xE0,0x07,0x88,0x42,0x04,0x8B,0xC1,0xC1,0xE8,0x0F,0x83,0xE0,0x07,0x88,0x42,0x05,0xC1,0xE9,0x12,0x83,0xE1,0x07,0x88,0x4A,0x06,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part21x3(uint src, Span<byte> dst)
; location: [7FFDDB006470h, 7FFDDB0064BFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000ah and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
000dh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
000fh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0011h shr edx,3                     ; SHR(Shr_rm32_imm8) [EDX,3h:imm8]                     encoding(3 bytes) = c1 ea 03
0014h and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0017h mov [rax+1],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 01
001ah mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
001ch shr edx,6                     ; SHR(Shr_rm32_imm8) [EDX,6h:imm8]                     encoding(3 bytes) = c1 ea 06
001fh and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0022h mov [rax+2],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 02
0025h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0027h shr edx,9                     ; SHR(Shr_rm32_imm8) [EDX,9h:imm8]                     encoding(3 bytes) = c1 ea 09
002ah and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
002dh mov [rax+3],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 03
0030h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0032h shr edx,0Ch                   ; SHR(Shr_rm32_imm8) [EDX,ch:imm8]                     encoding(3 bytes) = c1 ea 0c
0035h and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0038h mov [rax+4],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 04
003bh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
003dh shr edx,0Fh                   ; SHR(Shr_rm32_imm8) [EDX,fh:imm8]                     encoding(3 bytes) = c1 ea 0f
0040h and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0043h mov [rax+5],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 05
0046h shr ecx,12h                   ; SHR(Shr_rm32_imm8) [ECX,12h:imm8]                    encoding(3 bytes) = c1 e9 12
0049h and ecx,7                     ; AND(And_rm32_imm8) [ECX,7h:imm32]                    encoding(3 bytes) = 83 e1 07
004ch mov [rax+6],cl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),CL]              encoding(3 bytes) = 88 48 06
004fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part21x3Bytes => new byte[80]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x8B,0xD1,0x83,0xE2,0x07,0x88,0x10,0x8B,0xD1,0xC1,0xEA,0x03,0x83,0xE2,0x07,0x88,0x50,0x01,0x8B,0xD1,0xC1,0xEA,0x06,0x83,0xE2,0x07,0x88,0x50,0x02,0x8B,0xD1,0xC1,0xEA,0x09,0x83,0xE2,0x07,0x88,0x50,0x03,0x8B,0xD1,0xC1,0xEA,0x0C,0x83,0xE2,0x07,0x88,0x50,0x04,0x8B,0xD1,0xC1,0xEA,0x0F,0x83,0xE2,0x07,0x88,0x50,0x05,0xC1,0xE9,0x12,0x83,0xE1,0x07,0x88,0x48,0x06,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part24x3(uint src, ref byte dst)
; location: [7FFDDB0064D0h, 7FFDDB006527h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
000ah mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
000ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000eh shr eax,3                     ; SHR(Shr_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e8 03
0011h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
0014h mov [rdx+1],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 01
0017h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0019h shr eax,6                     ; SHR(Shr_rm32_imm8) [EAX,6h:imm8]                     encoding(3 bytes) = c1 e8 06
001ch and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
001fh mov [rdx+2],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 02
0022h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0024h shr eax,9                     ; SHR(Shr_rm32_imm8) [EAX,9h:imm8]                     encoding(3 bytes) = c1 e8 09
0027h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
002ah mov [rdx+3],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 03
002dh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
002fh shr eax,0Ch                   ; SHR(Shr_rm32_imm8) [EAX,ch:imm8]                     encoding(3 bytes) = c1 e8 0c
0032h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
0035h mov [rdx+4],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 04
0038h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
003ah shr eax,0Fh                   ; SHR(Shr_rm32_imm8) [EAX,fh:imm8]                     encoding(3 bytes) = c1 e8 0f
003dh and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
0040h mov [rdx+5],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 05
0043h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0045h shr eax,12h                   ; SHR(Shr_rm32_imm8) [EAX,12h:imm8]                    encoding(3 bytes) = c1 e8 12
0048h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
004bh mov [rdx+6],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 06
004eh shr ecx,15h                   ; SHR(Shr_rm32_imm8) [ECX,15h:imm8]                    encoding(3 bytes) = c1 e9 15
0051h and ecx,7                     ; AND(And_rm32_imm8) [ECX,7h:imm32]                    encoding(3 bytes) = 83 e1 07
0054h mov [rdx+7],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 07
0057h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part24x3Bytes => new byte[88]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x83,0xE0,0x07,0x88,0x02,0x8B,0xC1,0xC1,0xE8,0x03,0x83,0xE0,0x07,0x88,0x42,0x01,0x8B,0xC1,0xC1,0xE8,0x06,0x83,0xE0,0x07,0x88,0x42,0x02,0x8B,0xC1,0xC1,0xE8,0x09,0x83,0xE0,0x07,0x88,0x42,0x03,0x8B,0xC1,0xC1,0xE8,0x0C,0x83,0xE0,0x07,0x88,0x42,0x04,0x8B,0xC1,0xC1,0xE8,0x0F,0x83,0xE0,0x07,0x88,0x42,0x05,0x8B,0xC1,0xC1,0xE8,0x12,0x83,0xE0,0x07,0x88,0x42,0x06,0xC1,0xE9,0x15,0x83,0xE1,0x07,0x88,0x4A,0x07,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part24x3(uint src, Span<byte> dst)
; location: [7FFDDB006540h, 7FFDDB00659Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000ah and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
000dh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
000fh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0011h shr edx,3                     ; SHR(Shr_rm32_imm8) [EDX,3h:imm8]                     encoding(3 bytes) = c1 ea 03
0014h and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0017h mov [rax+1],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 01
001ah mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
001ch shr edx,6                     ; SHR(Shr_rm32_imm8) [EDX,6h:imm8]                     encoding(3 bytes) = c1 ea 06
001fh and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0022h mov [rax+2],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 02
0025h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0027h shr edx,9                     ; SHR(Shr_rm32_imm8) [EDX,9h:imm8]                     encoding(3 bytes) = c1 ea 09
002ah and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
002dh mov [rax+3],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 03
0030h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0032h shr edx,0Ch                   ; SHR(Shr_rm32_imm8) [EDX,ch:imm8]                     encoding(3 bytes) = c1 ea 0c
0035h and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0038h mov [rax+4],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 04
003bh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
003dh shr edx,0Fh                   ; SHR(Shr_rm32_imm8) [EDX,fh:imm8]                     encoding(3 bytes) = c1 ea 0f
0040h and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0043h mov [rax+5],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 05
0046h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0048h shr edx,12h                   ; SHR(Shr_rm32_imm8) [EDX,12h:imm8]                    encoding(3 bytes) = c1 ea 12
004bh and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
004eh mov [rax+6],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 06
0051h shr ecx,15h                   ; SHR(Shr_rm32_imm8) [ECX,15h:imm8]                    encoding(3 bytes) = c1 e9 15
0054h and ecx,7                     ; AND(And_rm32_imm8) [ECX,7h:imm32]                    encoding(3 bytes) = 83 e1 07
0057h mov [rax+7],cl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),CL]              encoding(3 bytes) = 88 48 07
005ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part24x3Bytes => new byte[91]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x8B,0xD1,0x83,0xE2,0x07,0x88,0x10,0x8B,0xD1,0xC1,0xEA,0x03,0x83,0xE2,0x07,0x88,0x50,0x01,0x8B,0xD1,0xC1,0xEA,0x06,0x83,0xE2,0x07,0x88,0x50,0x02,0x8B,0xD1,0xC1,0xEA,0x09,0x83,0xE2,0x07,0x88,0x50,0x03,0x8B,0xD1,0xC1,0xEA,0x0C,0x83,0xE2,0x07,0x88,0x50,0x04,0x8B,0xD1,0xC1,0xEA,0x0F,0x83,0xE2,0x07,0x88,0x50,0x05,0x8B,0xD1,0xC1,0xEA,0x12,0x83,0xE2,0x07,0x88,0x50,0x06,0xC1,0xE9,0x15,0x83,0xE1,0x07,0x88,0x48,0x07,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part27x3(uint src, ref byte dst)
; location: [7FFDDB0065B0h, 7FFDDB006612h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
000ah mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
000ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000eh shr eax,3                     ; SHR(Shr_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e8 03
0011h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
0014h mov [rdx+1],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 01
0017h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0019h shr eax,6                     ; SHR(Shr_rm32_imm8) [EAX,6h:imm8]                     encoding(3 bytes) = c1 e8 06
001ch and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
001fh mov [rdx+2],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 02
0022h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0024h shr eax,9                     ; SHR(Shr_rm32_imm8) [EAX,9h:imm8]                     encoding(3 bytes) = c1 e8 09
0027h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
002ah mov [rdx+3],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 03
002dh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
002fh shr eax,0Ch                   ; SHR(Shr_rm32_imm8) [EAX,ch:imm8]                     encoding(3 bytes) = c1 e8 0c
0032h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
0035h mov [rdx+4],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 04
0038h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
003ah shr eax,0Fh                   ; SHR(Shr_rm32_imm8) [EAX,fh:imm8]                     encoding(3 bytes) = c1 e8 0f
003dh and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
0040h mov [rdx+5],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 05
0043h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0045h shr eax,12h                   ; SHR(Shr_rm32_imm8) [EAX,12h:imm8]                    encoding(3 bytes) = c1 e8 12
0048h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
004bh mov [rdx+6],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 06
004eh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0050h shr eax,15h                   ; SHR(Shr_rm32_imm8) [EAX,15h:imm8]                    encoding(3 bytes) = c1 e8 15
0053h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
0056h mov [rdx+7],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 07
0059h shr ecx,18h                   ; SHR(Shr_rm32_imm8) [ECX,18h:imm8]                    encoding(3 bytes) = c1 e9 18
005ch and ecx,7                     ; AND(And_rm32_imm8) [ECX,7h:imm32]                    encoding(3 bytes) = 83 e1 07
005fh mov [rdx+8],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 08
0062h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part27x3Bytes => new byte[99]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x83,0xE0,0x07,0x88,0x02,0x8B,0xC1,0xC1,0xE8,0x03,0x83,0xE0,0x07,0x88,0x42,0x01,0x8B,0xC1,0xC1,0xE8,0x06,0x83,0xE0,0x07,0x88,0x42,0x02,0x8B,0xC1,0xC1,0xE8,0x09,0x83,0xE0,0x07,0x88,0x42,0x03,0x8B,0xC1,0xC1,0xE8,0x0C,0x83,0xE0,0x07,0x88,0x42,0x04,0x8B,0xC1,0xC1,0xE8,0x0F,0x83,0xE0,0x07,0x88,0x42,0x05,0x8B,0xC1,0xC1,0xE8,0x12,0x83,0xE0,0x07,0x88,0x42,0x06,0x8B,0xC1,0xC1,0xE8,0x15,0x83,0xE0,0x07,0x88,0x42,0x07,0xC1,0xE9,0x18,0x83,0xE1,0x07,0x88,0x4A,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part27x3(uint src, Span<byte> dst)
; location: [7FFDDB006630h, 7FFDDB006695h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000ah and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
000dh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
000fh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0011h shr edx,3                     ; SHR(Shr_rm32_imm8) [EDX,3h:imm8]                     encoding(3 bytes) = c1 ea 03
0014h and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0017h mov [rax+1],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 01
001ah mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
001ch shr edx,6                     ; SHR(Shr_rm32_imm8) [EDX,6h:imm8]                     encoding(3 bytes) = c1 ea 06
001fh and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0022h mov [rax+2],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 02
0025h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0027h shr edx,9                     ; SHR(Shr_rm32_imm8) [EDX,9h:imm8]                     encoding(3 bytes) = c1 ea 09
002ah and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
002dh mov [rax+3],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 03
0030h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0032h shr edx,0Ch                   ; SHR(Shr_rm32_imm8) [EDX,ch:imm8]                     encoding(3 bytes) = c1 ea 0c
0035h and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0038h mov [rax+4],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 04
003bh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
003dh shr edx,0Fh                   ; SHR(Shr_rm32_imm8) [EDX,fh:imm8]                     encoding(3 bytes) = c1 ea 0f
0040h and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0043h mov [rax+5],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 05
0046h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0048h shr edx,12h                   ; SHR(Shr_rm32_imm8) [EDX,12h:imm8]                    encoding(3 bytes) = c1 ea 12
004bh and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
004eh mov [rax+6],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 06
0051h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0053h shr edx,15h                   ; SHR(Shr_rm32_imm8) [EDX,15h:imm8]                    encoding(3 bytes) = c1 ea 15
0056h and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0059h mov [rax+7],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 07
005ch shr ecx,18h                   ; SHR(Shr_rm32_imm8) [ECX,18h:imm8]                    encoding(3 bytes) = c1 e9 18
005fh and ecx,7                     ; AND(And_rm32_imm8) [ECX,7h:imm32]                    encoding(3 bytes) = 83 e1 07
0062h mov [rax+8],cl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),CL]              encoding(3 bytes) = 88 48 08
0065h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part27x3Bytes => new byte[102]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x8B,0xD1,0x83,0xE2,0x07,0x88,0x10,0x8B,0xD1,0xC1,0xEA,0x03,0x83,0xE2,0x07,0x88,0x50,0x01,0x8B,0xD1,0xC1,0xEA,0x06,0x83,0xE2,0x07,0x88,0x50,0x02,0x8B,0xD1,0xC1,0xEA,0x09,0x83,0xE2,0x07,0x88,0x50,0x03,0x8B,0xD1,0xC1,0xEA,0x0C,0x83,0xE2,0x07,0x88,0x50,0x04,0x8B,0xD1,0xC1,0xEA,0x0F,0x83,0xE2,0x07,0x88,0x50,0x05,0x8B,0xD1,0xC1,0xEA,0x12,0x83,0xE2,0x07,0x88,0x50,0x06,0x8B,0xD1,0xC1,0xEA,0x15,0x83,0xE2,0x07,0x88,0x50,0x07,0xC1,0xE9,0x18,0x83,0xE1,0x07,0x88,0x48,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part30x3(uint src, ref byte dst)
; location: [7FFDDB0066B0h, 7FFDDB00671Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
000ah mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
000ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000eh shr eax,3                     ; SHR(Shr_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e8 03
0011h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
0014h mov [rdx+1],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 01
0017h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0019h shr eax,6                     ; SHR(Shr_rm32_imm8) [EAX,6h:imm8]                     encoding(3 bytes) = c1 e8 06
001ch and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
001fh mov [rdx+2],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 02
0022h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0024h shr eax,9                     ; SHR(Shr_rm32_imm8) [EAX,9h:imm8]                     encoding(3 bytes) = c1 e8 09
0027h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
002ah mov [rdx+3],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 03
002dh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
002fh shr eax,0Ch                   ; SHR(Shr_rm32_imm8) [EAX,ch:imm8]                     encoding(3 bytes) = c1 e8 0c
0032h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
0035h mov [rdx+4],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 04
0038h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
003ah shr eax,0Fh                   ; SHR(Shr_rm32_imm8) [EAX,fh:imm8]                     encoding(3 bytes) = c1 e8 0f
003dh and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
0040h mov [rdx+5],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 05
0043h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0045h shr eax,12h                   ; SHR(Shr_rm32_imm8) [EAX,12h:imm8]                    encoding(3 bytes) = c1 e8 12
0048h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
004bh mov [rdx+6],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 06
004eh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0050h shr eax,15h                   ; SHR(Shr_rm32_imm8) [EAX,15h:imm8]                    encoding(3 bytes) = c1 e8 15
0053h and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
0056h mov [rdx+7],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 07
0059h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
005bh shr eax,18h                   ; SHR(Shr_rm32_imm8) [EAX,18h:imm8]                    encoding(3 bytes) = c1 e8 18
005eh and eax,7                     ; AND(And_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 e0 07
0061h mov [rdx+8],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 08
0064h shr ecx,1Bh                   ; SHR(Shr_rm32_imm8) [ECX,1bh:imm8]                    encoding(3 bytes) = c1 e9 1b
0067h and ecx,7                     ; AND(And_rm32_imm8) [ECX,7h:imm32]                    encoding(3 bytes) = 83 e1 07
006ah mov [rdx+9],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 09
006dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part30x3Bytes => new byte[110]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x83,0xE0,0x07,0x88,0x02,0x8B,0xC1,0xC1,0xE8,0x03,0x83,0xE0,0x07,0x88,0x42,0x01,0x8B,0xC1,0xC1,0xE8,0x06,0x83,0xE0,0x07,0x88,0x42,0x02,0x8B,0xC1,0xC1,0xE8,0x09,0x83,0xE0,0x07,0x88,0x42,0x03,0x8B,0xC1,0xC1,0xE8,0x0C,0x83,0xE0,0x07,0x88,0x42,0x04,0x8B,0xC1,0xC1,0xE8,0x0F,0x83,0xE0,0x07,0x88,0x42,0x05,0x8B,0xC1,0xC1,0xE8,0x12,0x83,0xE0,0x07,0x88,0x42,0x06,0x8B,0xC1,0xC1,0xE8,0x15,0x83,0xE0,0x07,0x88,0x42,0x07,0x8B,0xC1,0xC1,0xE8,0x18,0x83,0xE0,0x07,0x88,0x42,0x08,0xC1,0xE9,0x1B,0x83,0xE1,0x07,0x88,0x4A,0x09,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part30x3(uint src, Span<byte> dst)
; location: [7FFDDB006730h, 7FFDDB0067A0h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000ah and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
000dh mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
000fh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0011h shr edx,3                     ; SHR(Shr_rm32_imm8) [EDX,3h:imm8]                     encoding(3 bytes) = c1 ea 03
0014h and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0017h mov [rax+1],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 01
001ah mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
001ch shr edx,6                     ; SHR(Shr_rm32_imm8) [EDX,6h:imm8]                     encoding(3 bytes) = c1 ea 06
001fh and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0022h mov [rax+2],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 02
0025h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0027h shr edx,9                     ; SHR(Shr_rm32_imm8) [EDX,9h:imm8]                     encoding(3 bytes) = c1 ea 09
002ah and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
002dh mov [rax+3],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 03
0030h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0032h shr edx,0Ch                   ; SHR(Shr_rm32_imm8) [EDX,ch:imm8]                     encoding(3 bytes) = c1 ea 0c
0035h and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0038h mov [rax+4],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 04
003bh mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
003dh shr edx,0Fh                   ; SHR(Shr_rm32_imm8) [EDX,fh:imm8]                     encoding(3 bytes) = c1 ea 0f
0040h and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0043h mov [rax+5],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 05
0046h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0048h shr edx,12h                   ; SHR(Shr_rm32_imm8) [EDX,12h:imm8]                    encoding(3 bytes) = c1 ea 12
004bh and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
004eh mov [rax+6],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 06
0051h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0053h shr edx,15h                   ; SHR(Shr_rm32_imm8) [EDX,15h:imm8]                    encoding(3 bytes) = c1 ea 15
0056h and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0059h mov [rax+7],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 07
005ch mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
005eh shr edx,18h                   ; SHR(Shr_rm32_imm8) [EDX,18h:imm8]                    encoding(3 bytes) = c1 ea 18
0061h and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0064h mov [rax+8],dl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(3 bytes) = 88 50 08
0067h shr ecx,1Bh                   ; SHR(Shr_rm32_imm8) [ECX,1bh:imm8]                    encoding(3 bytes) = c1 e9 1b
006ah and ecx,7                     ; AND(And_rm32_imm8) [ECX,7h:imm32]                    encoding(3 bytes) = 83 e1 07
006dh mov [rax+9],cl                ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),CL]              encoding(3 bytes) = 88 48 09
0070h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part30x3Bytes => new byte[113]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x8B,0xD1,0x83,0xE2,0x07,0x88,0x10,0x8B,0xD1,0xC1,0xEA,0x03,0x83,0xE2,0x07,0x88,0x50,0x01,0x8B,0xD1,0xC1,0xEA,0x06,0x83,0xE2,0x07,0x88,0x50,0x02,0x8B,0xD1,0xC1,0xEA,0x09,0x83,0xE2,0x07,0x88,0x50,0x03,0x8B,0xD1,0xC1,0xEA,0x0C,0x83,0xE2,0x07,0x88,0x50,0x04,0x8B,0xD1,0xC1,0xEA,0x0F,0x83,0xE2,0x07,0x88,0x50,0x05,0x8B,0xD1,0xC1,0xEA,0x12,0x83,0xE2,0x07,0x88,0x50,0x06,0x8B,0xD1,0xC1,0xEA,0x15,0x83,0xE2,0x07,0x88,0x50,0x07,0x8B,0xD1,0xC1,0xEA,0x18,0x83,0xE2,0x07,0x88,0x50,0x08,0xC1,0xE9,0x1B,0x83,0xE1,0x07,0x88,0x48,0x09,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part8x4:uint part)
; location: [7FFDDB0067C0h, 7FFDDB0067CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part12x4:uint part)
; location: [7FFDDB0067E0h, 7FFDDB0067EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part16x4:uint part)
; location: [7FFDDB006800h, 7FFDDB00680Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part20x4:uint part)
; location: [7FFDDB006820h, 7FFDDB00682Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part24x4:uint part)
; location: [7FFDDB006840h, 7FFDDB00684Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part32x4:uint part)
; location: [7FFDDB006860h, 7FFDDB00686Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select(ulong src, Part64x4:ulong part)
; location: [7FFDDB006880h, 7FFDDB00688Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part8x4:uint part)
; location: [7FFDDB0068A0h, 7FFDDB0068AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
