; 2019-11-14 19:49:16:783
; function: void part12x4(uint src, Span<byte> dst)
; location: [7FFDDB239A80h, 7FFDDB239AA3h]
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
; location: [7FFDDB239AC0h, 7FFDDB239AEBh]
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
; location: [7FFDDB239B00h, 7FFDDB239B2Eh]
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
; location: [7FFDDB239B40h, 7FFDDB239B9Ah]
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
; location: [7FFDDB239BB0h, 7FFDDB239C0Dh]
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
; location: [7FFDDB239C20h, 7FFDDB239C2Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part15x5:uint part)
; location: [7FFDDB239C40h, 7FFDDB239C4Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part20x5:uint part)
; location: [7FFDDB239C60h, 7FFDDB239C6Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part25x5:uint part)
; location: [7FFDDB239C80h, 7FFDDB239C8Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part30x5:uint part)
; location: [7FFDDB239CA0h, 7FFDDB239CAAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select(ulong src, Part60x5:ulong part)
; location: [7FFDDB239CC0h, 7FFDDB239CCAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part10x5:uint part)
; location: [7FFDDB239CE0h, 7FFDDB239CEAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part15x5:uint part)
; location: [7FFDDB239D00h, 7FFDDB239D0Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part20x5:uint part)
; location: [7FFDDB239D20h, 7FFDDB239D2Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part25x5:uint part)
; location: [7FFDDB239D40h, 7FFDDB239D4Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part30x5:uint part)
; location: [7FFDDB239D60h, 7FFDDB239D6Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong project(ulong src, Part60x5:ulong part)
; location: [7FFDDB239D80h, 7FFDDB239D8Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep rax,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF3,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part12x6:uint part)
; location: [7FFDDB239DA0h, 7FFDDB239DAAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part18x6:uint part)
; location: [7FFDDB239DC0h, 7FFDDB239DCAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part24x6:uint part)
; location: [7FFDDB239DE0h, 7FFDDB239DEAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part30x6:uint part)
; location: [7FFDDB239E00h, 7FFDDB239E0Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select(ulong src, Part36x6:ulong part)
; location: [7FFDDB239E20h, 7FFDDB239E2Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part12x6:uint part)
; location: [7FFDDB239E40h, 7FFDDB239E4Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part18x6:uint part)
; location: [7FFDDB239E60h, 7FFDDB239E6Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part24x6:uint part)
; location: [7FFDDB239E80h, 7FFDDB239E8Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part30x6:uint part)
; location: [7FFDDB239EA0h, 7FFDDB239EAAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong project(ulong src, Part36x6:ulong part)
; location: [7FFDDB239EC0h, 7FFDDB239ECAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep rax,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF3,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part16x8:uint part)
; location: [7FFDDB239EE0h, 7FFDDB239EEAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part24x8:uint part)
; location: [7FFDDB239F00h, 7FFDDB239F0Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part32x8:uint part)
; location: [7FFDDB239F20h, 7FFDDB239F2Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select(ulong src, Part64x8:ulong part)
; location: [7FFDDB239F40h, 7FFDDB239F4Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part16x8:uint part)
; location: [7FFDDB239F60h, 7FFDDB239F6Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part32x8:uint part)
; location: [7FFDDB239F80h, 7FFDDB239F8Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong project(ulong src, Part64x8:ulong part)
; location: [7FFDDB239FA0h, 7FFDDB239FAAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep rax,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF3,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part16x8(uint src, ref byte dst)
; location: [7FFDDB239FC0h, 7FFDDB239FCDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(2 bytes) = 88 0a
0007h shr ecx,8                     ; SHR(Shr_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e9 08
000ah mov [rdx+1],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 01
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part16x8Bytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x88,0x0A,0xC1,0xE9,0x08,0x88,0x4A,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part16x8(uint src, Span<byte> dst)
; location: [7FFDDB239FE0h, 7FFDDB239FF2h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 12
0008h call 7FFDDB239FC0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFFE0h:jmp64]        encoding(5 bytes) = e8 d3 ff ff ff
000dh nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000eh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part16x8Bytes => new byte[19]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x12,0xE8,0xD3,0xFF,0xFF,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part32x8(uint src, ref byte dst)
; location: [7FFDDB23A010h, 7FFDDB23A02Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(2 bytes) = 88 0a
0007h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0009h shr eax,8                     ; SHR(Shr_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e8 08
000ch mov [rdx+1],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 01
000fh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0011h shr eax,10h                   ; SHR(Shr_rm32_imm8) [EAX,10h:imm8]                    encoding(3 bytes) = c1 e8 10
0014h mov [rdx+2],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 02
0017h shr ecx,18h                   ; SHR(Shr_rm32_imm8) [ECX,18h:imm8]                    encoding(3 bytes) = c1 e9 18
001ah mov [rdx+3],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 03
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part32x8Bytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x88,0x0A,0x8B,0xC1,0xC1,0xE8,0x08,0x88,0x42,0x01,0x8B,0xC1,0xC1,0xE8,0x10,0x88,0x42,0x02,0xC1,0xE9,0x18,0x88,0x4A,0x03,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part32x8(uint src, Span<byte> dst)
; location: [7FFDDB23A040h, 7FFDDB23A052h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rdx,[rdx]                 ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 12
0008h call 7FFDDB23A010h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFFD0h:jmp64]        encoding(5 bytes) = e8 c3 ff ff ff
000dh nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
000eh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0012h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part32x8Bytes => new byte[19]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x12,0xE8,0xC3,0xFF,0xFF,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte select(byte src, Odd8:byte parts)
; location: [7FFDDB23A070h, 7FFDDB23A083h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort select(ushort src, Odd16:ushort parts)
; location: [7FFDDB23A0A0h, 7FFDDB23A0B3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Odd32:uint parts)
; location: [7FFDDB23A0D0h, 7FFDDB23A0DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select(ulong src, Odd64:ulong parts)
; location: [7FFDDB23A0F0h, 7FFDDB23A0FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void unpack8x1(uint src, Span<byte> dst)
; location: [7FFDDB23A110h, 7FFDDB23A136h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
000ah mov rcx,101010101010101h      ; MOV(Mov_r64_imm64) [RCX,101010101010101h:imm64]      encoding(10 bytes) = 48 b9 01 01 01 01 01 01 01 01
0014h pdep rdx,rdx,rcx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RDX,RCX]            encoding(VEX, 5 bytes) = c4 e2 eb f5 d1
0019h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
001ch add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0020h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0021h call 7FFE3A78ED50h            ; CALL(Call_rel32_64) [5F554C40h:jmp64]                encoding(5 bytes) = e8 1a 4c 55 5f
0026h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack8x1Bytes => new byte[39]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0xD1,0x48,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xEB,0xF5,0xD1,0x48,0x89,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x1A,0x4C,0x55,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void pack16x1(ReadOnlySpan<byte> src, Span<byte> dst)
; location: [7FFDDB23A150h, 7FFDDB23A18Ah]
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
0035h call 7FFE3A78ED50h            ; CALL(Call_rel32_64) [5F554C00h:jmp64]                encoding(5 bytes) = e8 c6 4b 55 5f
003ah int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> pack16x1Bytes => new byte[59]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x48,0x8B,0x12,0x0F,0xB6,0x08,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xC2,0xF2,0xF5,0xC8,0x48,0x89,0x0A,0x48,0x83,0xC2,0x08,0x0F,0xB6,0x40,0x08,0xC4,0xC2,0xFA,0xF5,0xC0,0x48,0x89,0x02,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xC6,0x4B,0x55,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void unpack16x1(uint src, Span<byte> dst)
; location: [7FFDDB23A1A0h, 7FFDDB23A1D7h]
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
0032h call 7FFE3A78ED50h            ; CALL(Call_rel32_64) [5F554BB0h:jmp64]                encoding(5 bytes) = e8 79 4b 55 5f
0037h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack16x1Bytes => new byte[56]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0xD1,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xC2,0xEB,0xF5,0xD0,0x48,0x89,0x10,0x48,0x83,0xC0,0x08,0xC1,0xE9,0x08,0x8B,0xD1,0xC4,0xC2,0xEB,0xF5,0xD0,0x48,0x89,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x79,0x4B,0x55,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void pack32x1(ReadOnlySpan<byte> src, Span<byte> dst)
; location: [7FFDDB23A1F0h, 7FFDDB23A256h]
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
0061h call 7FFE3A78ED50h            ; CALL(Call_rel32_64) [5F554B60h:jmp64]                encoding(5 bytes) = e8 fa 4a 55 5f
0066h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> pack32x1Bytes => new byte[103]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x48,0x8B,0x12,0x0F,0xB6,0x08,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xC2,0xF2,0xF5,0xC8,0x48,0x89,0x0A,0x48,0x8D,0x4A,0x08,0x44,0x0F,0xB6,0x40,0x08,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBA,0xF5,0xC1,0x4C,0x89,0x01,0x48,0x8D,0x4A,0x10,0x44,0x0F,0xB6,0x40,0x10,0xC4,0x42,0xBA,0xF5,0xC1,0x4C,0x89,0x01,0x48,0x83,0xC2,0x18,0x0F,0xB6,0x40,0x18,0xC4,0xC2,0xFA,0xF5,0xC1,0x48,0x89,0x02,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xFA,0x4A,0x55,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void unpack32x1(uint src, Span<byte> dst)
; location: [7FFDDB23A270h, 7FFDDB23A2D5h]
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
0060h call 7FFE3A78ED50h            ; CALL(Call_rel32_64) [5F554AE0h:jmp64]                encoding(5 bytes) = e8 7b 4a 55 5f
0065h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack32x1Bytes => new byte[102]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0xD1,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xC2,0xEB,0xF5,0xD0,0x48,0x89,0x10,0x48,0x8D,0x50,0x08,0x44,0x8B,0xC1,0x41,0xC1,0xE8,0x08,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0xC1,0xE9,0x10,0x48,0x83,0xC0,0x10,0x8B,0xD1,0xC4,0xC2,0xEB,0xF5,0xD1,0x48,0x89,0x10,0x48,0x83,0xC0,0x08,0xC1,0xE9,0x08,0x8B,0xD1,0xC4,0xC2,0xEB,0xF5,0xD1,0x48,0x89,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x7B,0x4A,0x55,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void pack64x1(ReadOnlySpan<byte> src, Span<byte> dst)
; location: [7FFDDB23A2F0h, 7FFDDB23A39Ch]
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
00a7h call 7FFE3A78ED50h            ; CALL(Call_rel32_64) [5F554A60h:jmp64]                encoding(5 bytes) = e8 b4 49 55 5f
00ach int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> pack64x1Bytes => new byte[173]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x01,0x48,0x8B,0x12,0x0F,0xB6,0x08,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xC2,0xF2,0xF5,0xC8,0x48,0x89,0x0A,0x48,0x8D,0x4A,0x08,0x44,0x0F,0xB6,0x40,0x08,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBA,0xF5,0xC1,0x4C,0x89,0x01,0x48,0x8D,0x4A,0x10,0x44,0x0F,0xB6,0x40,0x10,0xC4,0x42,0xBA,0xF5,0xC1,0x4C,0x89,0x01,0x48,0x8D,0x4A,0x18,0x44,0x0F,0xB6,0x40,0x18,0xC4,0x42,0xBA,0xF5,0xC1,0x4C,0x89,0x01,0x48,0x83,0xC0,0x04,0x48,0x83,0xC2,0x04,0x0F,0xB6,0x08,0xC4,0xC2,0xF2,0xF5,0xC9,0x48,0x89,0x0A,0x48,0x8D,0x4A,0x08,0x44,0x0F,0xB6,0x40,0x08,0xC4,0x42,0xBA,0xF5,0xC1,0x4C,0x89,0x01,0x48,0x8D,0x4A,0x10,0x44,0x0F,0xB6,0x40,0x10,0xC4,0x42,0xBA,0xF5,0xC1,0x4C,0x89,0x01,0x48,0x83,0xC2,0x18,0x0F,0xB6,0x40,0x18,0xC4,0xC2,0xFA,0xF5,0xC1,0x48,0x89,0x02,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xB4,0x49,0x55,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void unpack64x1(ulong src, Span<byte> dst)
; location: [7FFDDB23A3C0h, 7FFDDB23A46Eh]
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
00a9h call 7FFE3A78ED50h            ; CALL(Call_rel32_64) [5F554990h:jmp64]                encoding(5 bytes) = e8 e2 48 55 5f
00aeh int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> unpack64x1Bytes => new byte[175]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x8B,0xD1,0x44,0x8B,0xC2,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x00,0x4C,0x8D,0x40,0x08,0x44,0x8B,0xCA,0x41,0xC1,0xE9,0x08,0x49,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xB3,0xF5,0xCA,0x4D,0x89,0x08,0xC1,0xEA,0x10,0x4C,0x8D,0x40,0x10,0x44,0x8B,0xCA,0xC4,0x42,0xB3,0xF5,0xCA,0x4D,0x89,0x08,0x49,0x83,0xC0,0x08,0xC1,0xEA,0x08,0xC4,0xC2,0xEB,0xF5,0xD2,0x49,0x89,0x10,0x48,0xC1,0xE9,0x20,0x8B,0xD1,0x48,0x83,0xC0,0x20,0x8B,0xCA,0xC4,0xC2,0xF3,0xF5,0xCA,0x48,0x89,0x08,0x48,0x8D,0x48,0x08,0x44,0x8B,0xC2,0x41,0xC1,0xE8,0x08,0xC4,0x42,0xBB,0xF5,0xC2,0x4C,0x89,0x01,0xC1,0xEA,0x10,0x48,0x83,0xC0,0x10,0x8B,0xCA,0xC4,0xC2,0xF3,0xF5,0xCA,0x48,0x89,0x08,0x48,0x83,0xC0,0x08,0xC1,0xEA,0x08,0xC4,0xC2,0xEB,0xF5,0xD2,0x48,0x89,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xE2,0x48,0x55,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong project(ulong src, ulong mask)
; location: [7FFDDB23A490h, 7FFDDB23A49Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep rax,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF3,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, uint mask)
; location: [7FFDDB23A4B0h, 7FFDDB23A4BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort project(ushort src, ushort mask)
; location: [7FFDDB23A4D0h, 7FFDDB23A4E3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh pdep eax,eax,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7b f5 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC4,0xE2,0x7B,0xF5,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte select(byte src, byte mask)
; location: [7FFDDB23A500h, 7FFDDB23A513h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0x0F,0xB6,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ushort select(ushort src, ushort mask)
; location: [7FFDDB23A530h, 7FFDDB23A543h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cx                  ; MOVZX(Movzx_r32_rm16) [EAX,CX]                       encoding(3 bytes) = 0f b7 c1
0008h movzx edx,dx                  ; MOVZX(Movzx_r32_rm16) [EDX,DX]                       encoding(3 bytes) = 0f b7 d2
000bh pext eax,eax,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7a f5 c2
0010h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC1,0x0F,0xB7,0xD2,0xC4,0xE2,0x7A,0xF5,0xC2,0x0F,0xB7,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, uint mask)
; location: [7FFDDB23A560h, 7FFDDB23A56Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select(ulong src, ulong mask)
; location: [7FFDDB23A580h, 7FFDDB23A58Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Even8:byte parts)
; location: [7FFDDB23A5A0h, 7FFDDB23A5ADh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dl                  ; MOVZX(Movzx_r32_rm8) [EAX,DL]                        encoding(3 bytes) = 0f b6 c2
0008h pext eax,ecx,eax              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EAX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC2,0xC4,0xE2,0x72,0xF5,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Even16:ushort parts)
; location: [7FFDDB23A5C0h, 7FFDDB23A5CDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,dx                  ; MOVZX(Movzx_r32_rm16) [EAX,DX]                       encoding(3 bytes) = 0f b7 c2
0008h pext eax,ecx,eax              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EAX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c0
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0xC2,0xC4,0xE2,0x72,0xF5,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Even32:uint parts)
; location: [7FFDDB23A5E0h, 7FFDDB23A5EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select(ulong src, Even64:ulong parts)
; location: [7FFDDB23A600h, 7FFDDB23A60Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part32x16:uint part)
; location: [7FFDDB23A620h, 7FFDDB23A62Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select(ulong src, Part48x16:ulong part)
; location: [7FFDDB23A640h, 7FFDDB23A64Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select(ulong src, Part64x16:ulong part)
; location: [7FFDDB23A660h, 7FFDDB23A66Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part32x16:uint part)
; location: [7FFDDB23A680h, 7FFDDB23A68Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part32x16(uint src, Span<ushort> dst)
; location: [7FFDDB23A6A0h, 7FFDDB23A6B5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov [rax],cx                  ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,:sr),CX]           encoding(3 bytes) = 66 89 08
000bh mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
000eh shr ecx,10h                   ; SHR(Shr_rm32_imm8) [ECX,10h:imm8]                    encoding(3 bytes) = c1 e9 10
0011h mov [rax+2],cx                ; MOV(Mov_rm16_r16) [mem(16u,RAX:br,:sr),CX]           encoding(4 bytes) = 66 89 48 02
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part32x16Bytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x66,0x89,0x08,0x48,0x8B,0x02,0xC1,0xE9,0x10,0x66,0x89,0x48,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part32x16(uint src, out ushort x0, out ushort x1)
; location: [7FFDDB23A6D0h, 7FFDDB23A6DFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],cx                  ; MOV(Mov_rm16_r16) [mem(16u,RDX:br,:sr),CX]           encoding(3 bytes) = 66 89 0a
0008h shr ecx,10h                   ; SHR(Shr_rm32_imm8) [ECX,10h:imm8]                    encoding(3 bytes) = c1 e9 10
000bh mov [r8],cx                   ; MOV(Mov_rm16_r16) [mem(16u,R8:br,:sr),CX]            encoding(4 bytes) = 66 41 89 08
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part32x16Bytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x66,0x89,0x0A,0xC1,0xE9,0x10,0x66,0x41,0x89,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part2x1:uint part)
; location: [7FFDDB23A6F0h, 7FFDDB23A6FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part3x1:uint part)
; location: [7FFDDB23A710h, 7FFDDB23A71Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part4x1:uint part)
; location: [7FFDDB23A730h, 7FFDDB23A73Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part5x1:uint part)
; location: [7FFDDB23A750h, 7FFDDB23A75Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part6x1:uint part)
; location: [7FFDDB23A770h, 7FFDDB23A77Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part7x1:uint part)
; location: [7FFDDB23A790h, 7FFDDB23A79Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part8x1:uint part)
; location: [7FFDDB23A7B0h, 7FFDDB23A7BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part9x1:uint part)
; location: [7FFDDB23A7D0h, 7FFDDB23A7DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part10x1:uint part)
; location: [7FFDDB23A7F0h, 7FFDDB23A7FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part11x1:uint part)
; location: [7FFDDB23A810h, 7FFDDB23A81Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part12x1:uint part)
; location: [7FFDDB23A830h, 7FFDDB23A83Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part13x1:uint part)
; location: [7FFDDB23A850h, 7FFDDB23A85Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part16x1:uint part)
; location: [7FFDDB23A870h, 7FFDDB23A87Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part32x1:uint part)
; location: [7FFDDB23A890h, 7FFDDB23A89Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select(ulong src, Part64x1:ulong part)
; location: [7FFDDB23A8B0h, 7FFDDB23A8BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part2x1:uint part)
; location: [7FFDDB23A8D0h, 7FFDDB23A8DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part3x1:uint part)
; location: [7FFDDB23A8F0h, 7FFDDB23A8FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part4x1:uint part)
; location: [7FFDDB23A910h, 7FFDDB23A91Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part8x1:uint part)
; location: [7FFDDB23A930h, 7FFDDB23A93Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part10x1:uint part)
; location: [7FFDDB23A950h, 7FFDDB23A95Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part5x1:uint part)
; location: [7FFDDB23A970h, 7FFDDB23A97Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part6x1:uint part)
; location: [7FFDDB23A990h, 7FFDDB23A99Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part9x1:uint part)
; location: [7FFDDB23A9B0h, 7FFDDB23A9BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part7x1:uint part)
; location: [7FFDDB23A9D0h, 7FFDDB23A9DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part11x1:uint part)
; location: [7FFDDB23A9F0h, 7FFDDB23A9FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part12x1:uint part)
; location: [7FFDDB23AA10h, 7FFDDB23AA1Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part13x1:uint part)
; location: [7FFDDB23AA30h, 7FFDDB23AA3Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part16x1:uint part)
; location: [7FFDDB23AA50h, 7FFDDB23AA5Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part32x1:uint part)
; location: [7FFDDB23AA70h, 7FFDDB23AA7Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong project(ulong src, Part64x1:ulong part)
; location: [7FFDDB23AA90h, 7FFDDB23AA9Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep rax,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF3,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part4x1(uint src, ref byte dst)
; location: [7FFDDB23AAB0h, 7FFDDB23AADAh]
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
; location: [7FFDDB23AAF0h, 7FFDDB23AB25h]
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
; location: [7FFDDB23AB40h, 7FFDDB23AB80h]
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
; location: [7FFDDB23ABA0h, 7FFDDB23ABEBh]
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
; location: [7FFDDB23AC00h, 7FFDDB23AC58h]
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
; location: [7FFDDB23AC70h, 7FFDDB23ACDFh]
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
; location: [7FFDDB23ACF0h, 7FFDDB23AD6Ah]
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
; location: [7FFDDB23AD80h, 7FFDDB23ADFDh]
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
; location: [7FFDDB23AE10h, 7FFDDB23AE96h]
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
0081h call 7FFE3A78ED50h            ; CALL(Call_rel32_64) [5F553F40h:jmp64]                encoding(5 bytes) = e8 ba 3e 55 5f
0086h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part32x1Bytes => new byte[135]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0xBA,0xFF,0x00,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xD2,0x8B,0xD2,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xC2,0xEB,0xF5,0xD0,0x48,0x89,0x10,0x48,0x8D,0x50,0x08,0x41,0xB8,0x00,0xFF,0x00,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x45,0x8B,0xC0,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x10,0x41,0xB8,0x00,0x00,0xFF,0x00,0xC4,0x42,0x72,0xF5,0xC0,0x45,0x8B,0xC0,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x83,0xC0,0x18,0xBA,0x00,0x00,0x00,0xFF,0xC4,0xE2,0x72,0xF5,0xD2,0x8B,0xD2,0xC4,0xC2,0xEB,0xF5,0xD1,0x48,0x89,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xBA,0x3E,0x55,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part64x1(ulong src, Span<byte> dst)
; location: [7FFDDB23AEB0h, 7FFDDB23AF99h]
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
00e4h call 7FFE3A78ED50h            ; CALL(Call_rel32_64) [5F553EA0h:jmp64]                encoding(5 bytes) = e8 b7 3d 55 5f
00e9h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part64x1Bytes => new byte[234]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0xBA,0xFF,0x00,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xD2,0x49,0xB8,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xC2,0xEB,0xF5,0xD0,0x48,0x89,0x10,0x48,0x8D,0x50,0x08,0x41,0xB8,0x00,0xFF,0x00,0x00,0xC4,0x42,0xF2,0xF5,0xC0,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x10,0x41,0xB8,0x00,0x00,0xFF,0x00,0xC4,0x42,0xF2,0xF5,0xC0,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x18,0x41,0xB8,0x00,0x00,0x00,0xFF,0xC4,0x42,0xF2,0xF5,0xC0,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x20,0x49,0xB8,0x00,0x00,0x00,0x00,0xFF,0x00,0x00,0x00,0xC4,0x42,0xF2,0xF5,0xC0,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x28,0x49,0xB8,0x00,0x00,0x00,0x00,0x00,0xFF,0x00,0x00,0xC4,0x42,0xF2,0xF5,0xC0,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x30,0x49,0xB8,0x00,0x00,0x00,0x00,0x00,0x00,0xFF,0x00,0xC4,0x42,0xF2,0xF5,0xC0,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x83,0xC0,0x38,0x48,0xBA,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0xFF,0xC4,0xE2,0xF2,0xF5,0xD2,0xC4,0xC2,0xEB,0xF5,0xD1,0x48,0x89,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xB7,0x3D,0x55,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part64x1(ulong src, Span<bit> dst)
; location: [7FFDDB23AFB0h, 7FFDDB23AFD7h]
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
; location: [7FFDDB23AFF0h, 7FFDDB23B069h]
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
; location: [7FFDDB23B080h, 7FFDDB23B15Ch]
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
; location: [7FFDDB23B170h, 7FFDDB23B17Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part6x2:uint part)
; location: [7FFDDB23B190h, 7FFDDB23B19Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part8x2:uint part)
; location: [7FFDDB23B1B0h, 7FFDDB23B1BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part10x2:uint part)
; location: [7FFDDB23B1D0h, 7FFDDB23B1DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part12x2:uint part)
; location: [7FFDDB23B1F0h, 7FFDDB23B1FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part16x2:uint part)
; location: [7FFDDB23B210h, 7FFDDB23B21Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part32x2:uint part)
; location: [7FFDDB23B230h, 7FFDDB23B23Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select(ulong src, Part64x2:uint part)
; location: [7FFDDB23B250h, 7FFDDB23B25Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h pext rax,rcx,rax              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xC4,0xE2,0xF2,0xF5,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part4x2:uint part)
; location: [7FFDDB23B270h, 7FFDDB23B27Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(byte src, Part6x2:uint part)
; location: [7FFDDB23B290h, 7FFDDB23B29Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,cl                  ; MOVZX(Movzx_r32_rm8) [EAX,CL]                        encoding(3 bytes) = 0f b6 c1
0008h pdep eax,eax,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,EAX,EDX]            encoding(VEX, 5 bytes) = c4 e2 7b f5 c2
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB6,0xC1,0xC4,0xE2,0x7B,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part8x2:uint part)
; location: [7FFDDB23B2B0h, 7FFDDB23B2BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part10x2:uint part)
; location: [7FFDDB23B2D0h, 7FFDDB23B2DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part12x2:uint part)
; location: [7FFDDB23B2F0h, 7FFDDB23B2FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part16x2:uint part)
; location: [7FFDDB23B310h, 7FFDDB23B31Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part32x2:uint part)
; location: [7FFDDB23B330h, 7FFDDB23B33Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong project(ulong src, Part64x2:uint part)
; location: [7FFDDB23B350h, 7FFDDB23B35Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0007h pdep rax,rcx,rax              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RAX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c0
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC2,0xC4,0xE2,0xF3,0xF5,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part8x2(uint src, ref byte dst)
; location: [7FFDDB23B370h, 7FFDDB23B39Bh]
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
; function: void part16x2(uint src, ref byte dst)
; location: [7FFDDB23B3B0h, 7FFDDB23B40Ah]
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
0022h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0024h shr eax,6                     ; SHR(Shr_rm32_imm8) [EAX,6h:imm8]                     encoding(3 bytes) = c1 e8 06
0027h and eax,3                     ; AND(And_rm32_imm8) [EAX,3h:imm32]                    encoding(3 bytes) = 83 e0 03
002ah mov [rdx+3],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 03
002dh shr ecx,8                     ; SHR(Shr_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e9 08
0030h add rdx,4                     ; ADD(Add_rm64_imm8) [RDX,4h:imm64]                    encoding(4 bytes) = 48 83 c2 04
0034h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0036h and eax,3                     ; AND(And_rm32_imm8) [EAX,3h:imm32]                    encoding(3 bytes) = 83 e0 03
0039h mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
003bh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
003dh shr eax,2                     ; SHR(Shr_rm32_imm8) [EAX,2h:imm8]                     encoding(3 bytes) = c1 e8 02
0040h and eax,3                     ; AND(And_rm32_imm8) [EAX,3h:imm32]                    encoding(3 bytes) = 83 e0 03
0043h mov [rdx+1],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 01
0046h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0048h shr eax,4                     ; SHR(Shr_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e8 04
004bh and eax,3                     ; AND(And_rm32_imm8) [EAX,3h:imm32]                    encoding(3 bytes) = 83 e0 03
004eh mov [rdx+2],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 02
0051h shr ecx,6                     ; SHR(Shr_rm32_imm8) [ECX,6h:imm8]                     encoding(3 bytes) = c1 e9 06
0054h and ecx,3                     ; AND(And_rm32_imm8) [ECX,3h:imm32]                    encoding(3 bytes) = 83 e1 03
0057h mov [rdx+3],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 03
005ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part16x2Bytes => new byte[91]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x83,0xE0,0x03,0x88,0x02,0x8B,0xC1,0xC1,0xE8,0x02,0x83,0xE0,0x03,0x88,0x42,0x01,0x8B,0xC1,0xC1,0xE8,0x04,0x83,0xE0,0x03,0x88,0x42,0x02,0x8B,0xC1,0xC1,0xE8,0x06,0x83,0xE0,0x03,0x88,0x42,0x03,0xC1,0xE9,0x08,0x48,0x83,0xC2,0x04,0x8B,0xC1,0x83,0xE0,0x03,0x88,0x02,0x8B,0xC1,0xC1,0xE8,0x02,0x83,0xE0,0x03,0x88,0x42,0x01,0x8B,0xC1,0xC1,0xE8,0x04,0x83,0xE0,0x03,0x88,0x42,0x02,0xC1,0xE9,0x06,0x83,0xE1,0x03,0x88,0x4A,0x03,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part32x2(uint src, ref byte dst)
; location: [7FFDDB23B420h, 7FFDDB23B4E4h]
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
0022h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0024h shr eax,6                     ; SHR(Shr_rm32_imm8) [EAX,6h:imm8]                     encoding(3 bytes) = c1 e8 06
0027h and eax,3                     ; AND(And_rm32_imm8) [EAX,3h:imm32]                    encoding(3 bytes) = 83 e0 03
002ah mov [rdx+3],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 03
002dh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
002fh shr eax,8                     ; SHR(Shr_rm32_imm8) [EAX,8h:imm8]                     encoding(3 bytes) = c1 e8 08
0032h lea r8,[rdx+4]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RDX:br,:sr)]          encoding(4 bytes) = 4c 8d 42 04
0036h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
0039h and r9d,3                     ; AND(And_rm32_imm8) [R9D,3h:imm32]                    encoding(4 bytes) = 41 83 e1 03
003dh mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R9L]              encoding(3 bytes) = 45 88 08
0040h mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
0043h shr r9d,2                     ; SHR(Shr_rm32_imm8) [R9D,2h:imm8]                     encoding(4 bytes) = 41 c1 e9 02
0047h and r9d,3                     ; AND(And_rm32_imm8) [R9D,3h:imm32]                    encoding(4 bytes) = 41 83 e1 03
004bh mov [r8+1],r9b                ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R9L]              encoding(4 bytes) = 45 88 48 01
004fh mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
0052h shr r9d,4                     ; SHR(Shr_rm32_imm8) [R9D,4h:imm8]                     encoding(4 bytes) = 41 c1 e9 04
0056h and r9d,3                     ; AND(And_rm32_imm8) [R9D,3h:imm32]                    encoding(4 bytes) = 41 83 e1 03
005ah mov [r8+2],r9b                ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R9L]              encoding(4 bytes) = 45 88 48 02
005eh shr eax,6                     ; SHR(Shr_rm32_imm8) [EAX,6h:imm8]                     encoding(3 bytes) = c1 e8 06
0061h and eax,3                     ; AND(And_rm32_imm8) [EAX,3h:imm32]                    encoding(3 bytes) = 83 e0 03
0064h mov [r8+3],al                 ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),AL]               encoding(4 bytes) = 41 88 40 03
0068h shr ecx,10h                   ; SHR(Shr_rm32_imm8) [ECX,10h:imm8]                    encoding(3 bytes) = c1 e9 10
006bh add rdx,8                     ; ADD(Add_rm64_imm8) [RDX,8h:imm64]                    encoding(4 bytes) = 48 83 c2 08
006fh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0071h and eax,3                     ; AND(And_rm32_imm8) [EAX,3h:imm32]                    encoding(3 bytes) = 83 e0 03
0074h mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
0076h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0078h shr eax,2                     ; SHR(Shr_rm32_imm8) [EAX,2h:imm8]                     encoding(3 bytes) = c1 e8 02
007bh and eax,3                     ; AND(And_rm32_imm8) [EAX,3h:imm32]                    encoding(3 bytes) = 83 e0 03
007eh mov [rdx+1],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 01
0081h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0083h shr eax,4                     ; SHR(Shr_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e8 04
0086h and eax,3                     ; AND(And_rm32_imm8) [EAX,3h:imm32]                    encoding(3 bytes) = 83 e0 03
0089h mov [rdx+2],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 02
008ch mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
008eh shr eax,6                     ; SHR(Shr_rm32_imm8) [EAX,6h:imm8]                     encoding(3 bytes) = c1 e8 06
0091h and eax,3                     ; AND(And_rm32_imm8) [EAX,3h:imm32]                    encoding(3 bytes) = 83 e0 03
0094h mov [rdx+3],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 03
0097h shr ecx,8                     ; SHR(Shr_rm32_imm8) [ECX,8h:imm8]                     encoding(3 bytes) = c1 e9 08
009ah add rdx,4                     ; ADD(Add_rm64_imm8) [RDX,4h:imm64]                    encoding(4 bytes) = 48 83 c2 04
009eh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
00a0h and eax,3                     ; AND(And_rm32_imm8) [EAX,3h:imm32]                    encoding(3 bytes) = 83 e0 03
00a3h mov [rdx],al                  ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(2 bytes) = 88 02
00a5h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
00a7h shr eax,2                     ; SHR(Shr_rm32_imm8) [EAX,2h:imm8]                     encoding(3 bytes) = c1 e8 02
00aah and eax,3                     ; AND(And_rm32_imm8) [EAX,3h:imm32]                    encoding(3 bytes) = 83 e0 03
00adh mov [rdx+1],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 01
00b0h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
00b2h shr eax,4                     ; SHR(Shr_rm32_imm8) [EAX,4h:imm8]                     encoding(3 bytes) = c1 e8 04
00b5h and eax,3                     ; AND(And_rm32_imm8) [EAX,3h:imm32]                    encoding(3 bytes) = 83 e0 03
00b8h mov [rdx+2],al                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),AL]              encoding(3 bytes) = 88 42 02
00bbh shr ecx,6                     ; SHR(Shr_rm32_imm8) [ECX,6h:imm8]                     encoding(3 bytes) = c1 e9 06
00beh and ecx,3                     ; AND(And_rm32_imm8) [ECX,3h:imm32]                    encoding(3 bytes) = 83 e1 03
00c1h mov [rdx+3],cl                ; MOV(Mov_rm8_r8) [mem(8u,RDX:br,:sr),CL]              encoding(3 bytes) = 88 4a 03
00c4h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> part32x2Bytes => new byte[197]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x83,0xE0,0x03,0x88,0x02,0x8B,0xC1,0xC1,0xE8,0x02,0x83,0xE0,0x03,0x88,0x42,0x01,0x8B,0xC1,0xC1,0xE8,0x04,0x83,0xE0,0x03,0x88,0x42,0x02,0x8B,0xC1,0xC1,0xE8,0x06,0x83,0xE0,0x03,0x88,0x42,0x03,0x8B,0xC1,0xC1,0xE8,0x08,0x4C,0x8D,0x42,0x04,0x44,0x8B,0xC8,0x41,0x83,0xE1,0x03,0x45,0x88,0x08,0x44,0x8B,0xC8,0x41,0xC1,0xE9,0x02,0x41,0x83,0xE1,0x03,0x45,0x88,0x48,0x01,0x44,0x8B,0xC8,0x41,0xC1,0xE9,0x04,0x41,0x83,0xE1,0x03,0x45,0x88,0x48,0x02,0xC1,0xE8,0x06,0x83,0xE0,0x03,0x41,0x88,0x40,0x03,0xC1,0xE9,0x10,0x48,0x83,0xC2,0x08,0x8B,0xC1,0x83,0xE0,0x03,0x88,0x02,0x8B,0xC1,0xC1,0xE8,0x02,0x83,0xE0,0x03,0x88,0x42,0x01,0x8B,0xC1,0xC1,0xE8,0x04,0x83,0xE0,0x03,0x88,0x42,0x02,0x8B,0xC1,0xC1,0xE8,0x06,0x83,0xE0,0x03,0x88,0x42,0x03,0xC1,0xE9,0x08,0x48,0x83,0xC2,0x04,0x8B,0xC1,0x83,0xE0,0x03,0x88,0x02,0x8B,0xC1,0xC1,0xE8,0x02,0x83,0xE0,0x03,0x88,0x42,0x01,0x8B,0xC1,0xC1,0xE8,0x04,0x83,0xE0,0x03,0x88,0x42,0x02,0xC1,0xE9,0x06,0x83,0xE1,0x03,0x88,0x4A,0x03,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part6x3:uint part)
; location: [7FFDDB23B500h, 7FFDDB23B50Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part9x3:uint part)
; location: [7FFDDB23B520h, 7FFDDB23B52Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part12x3:uint part)
; location: [7FFDDB23B540h, 7FFDDB23B54Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part15x3:uint part)
; location: [7FFDDB23B560h, 7FFDDB23B56Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part18x3:uint part)
; location: [7FFDDB23B580h, 7FFDDB23B58Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part21x3:uint part)
; location: [7FFDDB23B5A0h, 7FFDDB23B5AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part24x3:uint part)
; location: [7FFDDB23B5C0h, 7FFDDB23B5CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part27x3:uint part)
; location: [7FFDDB23B5E0h, 7FFDDB23B5EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part30x3:uint part)
; location: [7FFDDB23B600h, 7FFDDB23B60Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part12x3:uint part)
; location: [7FFDDB23B620h, 7FFDDB23B62Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part6x3:uint part)
; location: [7FFDDB23B640h, 7FFDDB23B64Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part9x3:uint part)
; location: [7FFDDB23B660h, 7FFDDB23B66Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part15x3:uint part)
; location: [7FFDDB23B680h, 7FFDDB23B68Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part18x3:uint part)
; location: [7FFDDB23B6A0h, 7FFDDB23B6AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part21x3:uint part)
; location: [7FFDDB23B6C0h, 7FFDDB23B6CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part24x3:uint part)
; location: [7FFDDB23B6E0h, 7FFDDB23B6EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part27x3:uint part)
; location: [7FFDDB23B700h, 7FFDDB23B70Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part30x3:uint part)
; location: [7FFDDB23B720h, 7FFDDB23B72Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part6x3(uint src, ref byte dst)
; location: [7FFDDB23B740h, 7FFDDB23B755h]
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
; location: [7FFDDB23B770h, 7FFDDB23B790h]
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
; location: [7FFDDB23B7B0h, 7FFDDB23B7DBh]
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
; location: [7FFDDB23B7F0h, 7FFDDB23B81Eh]
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
; location: [7FFDDB23B830h, 7FFDDB23B866h]
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
; location: [7FFDDB23B880h, 7FFDDB23B8B9h]
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
; location: [7FFDDB23B8D0h, 7FFDDB23B911h]
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
; location: [7FFDDB23B930h, 7FFDDB23B974h]
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
; location: [7FFDDB23B990h, 7FFDDB23B9DCh]
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
; location: [7FFDDB23B9F0h, 7FFDDB23BA3Fh]
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
; location: [7FFDDB23BA50h, 7FFDDB23BAA7h]
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
; location: [7FFDDB23BAC0h, 7FFDDB23BB1Ah]
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
; location: [7FFDDB23BB30h, 7FFDDB23BB92h]
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
; location: [7FFDDB23BBB0h, 7FFDDB23BC15h]
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
; location: [7FFDDB23BC30h, 7FFDDB23BC9Dh]
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
; location: [7FFDDB23BCB0h, 7FFDDB23BD20h]
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
; location: [7FFDDB23BD40h, 7FFDDB23BD4Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part12x4:uint part)
; location: [7FFDDB23BD60h, 7FFDDB23BD6Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part16x4:uint part)
; location: [7FFDDB23BD80h, 7FFDDB23BD8Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part20x4:uint part)
; location: [7FFDDB23BDA0h, 7FFDDB23BDAAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part24x4:uint part)
; location: [7FFDDB23BDC0h, 7FFDDB23BDCAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint select(uint src, Part32x4:uint part)
; location: [7FFDDB23BDE0h, 7FFDDB23BDEAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext eax,ecx,edx              ; PEXT(VEX_Pext_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 72 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x72,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong select(ulong src, Part64x4:ulong part)
; location: [7FFDDB23BE00h, 7FFDDB23BE0Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pext rax,rcx,rdx              ; PEXT(VEX_Pext_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f2 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> selectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF2,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part8x4:uint part)
; location: [7FFDDB23BE20h, 7FFDDB23BE2Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part12x4:uint part)
; location: [7FFDDB23BE40h, 7FFDDB23BE4Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part16x4:uint part)
; location: [7FFDDB23BE60h, 7FFDDB23BE6Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint project(uint src, Part32x4:uint part)
; location: [7FFDDB23BE80h, 7FFDDB23BE8Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep eax,ecx,edx              ; PDEP(VEX_Pdep_r32_r32_rm32) [EAX,ECX,EDX]            encoding(VEX, 5 bytes) = c4 e2 73 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0x73,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong project(ulong src, Part64x4:ulong part)
; location: [7FFDDB23BEA0h, 7FFDDB23BEAAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h pdep rax,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RAX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 c2
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> projectBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xC4,0xE2,0xF3,0xF5,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part8x4(uint src, ref byte dst)
; location: [7FFDDB23BEC0h, 7FFDDB23BED5h]
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
; location: [7FFDDB23BEF0h, 7FFDDB23BF08h]
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
; location: [7FFDDB23BF20h, 7FFDDB23BF40h]
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
