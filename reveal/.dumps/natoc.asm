; 2019-11-27 21:54:08:661
; function: ulong digits_encode_1_0()
; location: [7FFDDAF37350h, 7FFDDAF37357h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digits_encode_1_0Bytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong digits_encode_1_1()
; location: [7FFDDAF37370h, 7FFDDAF3737Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digits_encode_1_1Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong digits_encode_1_2()
; location: [7FFDDAF37390h, 7FFDDAF3739Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,2                     ; MOV(Mov_r32_imm32) [EAX,2h:imm32]                    encoding(5 bytes) = b8 02 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digits_encode_1_2Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x02,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong digits_encode_1_3()
; location: [7FFDDAF373B0h, 7FFDDAF373BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,3                     ; MOV(Mov_r32_imm32) [EAX,3h:imm32]                    encoding(5 bytes) = b8 03 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digits_encode_1_3Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong digits_encode_2_10()
; location: [7FFDDAF373D0h, 7FFDDAF373DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digits_encode_2_10Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x10,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong digits_encode_3_210()
; location: [7FFDDAF373F0h, 7FFDDAF373FAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,210h                  ; MOV(Mov_r32_imm32) [EAX,210h:imm32]                  encoding(5 bytes) = b8 10 02 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digits_encode_3_210Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x10,0x02,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong digits_encode_4_3210()
; location: [7FFDDAF37410h, 7FFDDAF3741Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,3210h                 ; MOV(Mov_r32_imm32) [EAX,3210h:imm32]                 encoding(5 bytes) = b8 10 32 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digits_encode_4_3210Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x10,0x32,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong digits_encode_5_43210()
; location: [7FFDDAF37430h, 7FFDDAF3743Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,43210h                ; MOV(Mov_r32_imm32) [EAX,43210h:imm32]                encoding(5 bytes) = b8 10 32 04 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digits_encode_5_43210Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x10,0x32,0x04,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong digits_encode_8_76543210()
; location: [7FFDDAF37450h, 7FFDDAF3745Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,76543210h             ; MOV(Mov_r32_imm32) [EAX,76543210h:imm32]             encoding(5 bytes) = b8 10 32 54 76
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digits_encode_8_76543210Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x10,0x32,0x54,0x76,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong digit_extract_1_0_9()
; location: [7FFDDAF37470h, 7FFDDAF3747Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,9                     ; MOV(Mov_r32_imm32) [EAX,9h:imm32]                    encoding(5 bytes) = b8 09 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digit_extract_1_0_9Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x09,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong digit_extract_1_1_4()
; location: [7FFDDAF37490h, 7FFDDAF3749Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,4                     ; MOV(Mov_r32_imm32) [EAX,4h:imm32]                    encoding(5 bytes) = b8 04 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digit_extract_1_1_4Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x04,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong digit_extract_1_2_8()
; location: [7FFDDAF374B0h, 7FFDDAF374BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,8                     ; MOV(Mov_r32_imm32) [EAX,8h:imm32]                    encoding(5 bytes) = b8 08 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digit_extract_1_2_8Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x08,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong digit_extract_1_3_5()
; location: [7FFDDAF374D0h, 7FFDDAF374DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,5                     ; MOV(Mov_r32_imm32) [EAX,5h:imm32]                    encoding(5 bytes) = b8 05 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digit_extract_1_3_5Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x05,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void digits_extract_4_5849(out byte d3, out byte d2, out byte d1, out byte d0)
; location: [7FFDDAF374F0h, 7FFDDAF37503h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov byte ptr [rcx],5          ; MOV(Mov_rm8_imm8) [mem(8u,RCX:br,:sr),5h:imm8]       encoding(3 bytes) = c6 01 05
0008h mov byte ptr [rdx],8          ; MOV(Mov_rm8_imm8) [mem(8u,RDX:br,:sr),8h:imm8]       encoding(3 bytes) = c6 02 08
000bh mov byte ptr [r8],4           ; MOV(Mov_rm8_imm8) [mem(8u,R8:br,:sr),4h:imm8]        encoding(4 bytes) = 41 c6 00 04
000fh mov byte ptr [r9],9           ; MOV(Mov_rm8_imm8) [mem(8u,R9:br,:sr),9h:imm8]        encoding(4 bytes) = 41 c6 01 09
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digits_extract_4_5849Bytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0xC6,0x01,0x05,0xC6,0x02,0x08,0x41,0xC6,0x00,0x04,0x41,0xC6,0x01,0x09,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> digits_extract_lo(ulong src)
; location: [7FFDDAF37520h, 7FFDDAF37599h]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0003h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
000dh lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0011h lea r8,[rax+7]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 07
0015h mov r9,rdx                    ; MOV(Mov_r64_rm64) [R9,RDX]                           encoding(3 bytes) = 4c 8b ca
0018h shr r9,0Ch                    ; SHR(Shr_rm64_imm8) [R9,ch:imm8]                      encoding(4 bytes) = 49 c1 e9 0c
001ch and r9d,0Fh                   ; AND(And_rm32_imm8) [R9D,fh:imm32]                    encoding(4 bytes) = 41 83 e1 0f
0020h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R9L]              encoding(3 bytes) = 45 88 08
0023h lea r8,[rax+6]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 06
0027h mov r10,rdx                   ; MOV(Mov_r64_rm64) [R10,RDX]                          encoding(3 bytes) = 4c 8b d2
002ah shr r10,8                     ; SHR(Shr_rm64_imm8) [R10,8h:imm8]                     encoding(4 bytes) = 49 c1 ea 08
002eh and r10d,0Fh                  ; AND(And_rm32_imm8) [R10D,fh:imm32]                   encoding(4 bytes) = 41 83 e2 0f
0032h mov [r8],r10b                 ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R10L]             encoding(3 bytes) = 45 88 10
0035h lea r8,[rax+5]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 05
0039h mov r11,rdx                   ; MOV(Mov_r64_rm64) [R11,RDX]                          encoding(3 bytes) = 4c 8b da
003ch shr r11,4                     ; SHR(Shr_rm64_imm8) [R11,4h:imm8]                     encoding(4 bytes) = 49 c1 eb 04
0040h and r11d,0Fh                  ; AND(And_rm32_imm8) [R11D,fh:imm32]                   encoding(4 bytes) = 41 83 e3 0f
0044h mov [r8],r11b                 ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R11L]             encoding(3 bytes) = 45 88 18
0047h lea r8,[rax+4]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 04
004bh and edx,0Fh                   ; AND(And_rm32_imm8) [EDX,fh:imm32]                    encoding(3 bytes) = 83 e2 0f
004eh mov [r8],dl                   ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),DL]               encoding(3 bytes) = 41 88 10
0051h lea r8,[rax+3]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 03
0055h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R9L]              encoding(3 bytes) = 45 88 08
0058h lea r8,[rax+2]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 02
005ch mov [r8],r10b                 ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R10L]             encoding(3 bytes) = 45 88 10
005fh lea r8,[rax+1]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 01
0063h mov [r8],r11b                 ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R11L]             encoding(3 bytes) = 45 88 18
0066h mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
0068h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
006bh mov dword ptr [rcx+8],8       ; MOV(Mov_rm32_imm32) [mem(32u,RCX:br,:sr),8h:imm32]   encoding(7 bytes) = c7 41 08 08 00 00 00
0072h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0075h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
0079h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digits_extract_loBytes => new byte[122]{0x50,0x33,0xC0,0x48,0x89,0x04,0x24,0x33,0xC0,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0x4C,0x8D,0x40,0x07,0x4C,0x8B,0xCA,0x49,0xC1,0xE9,0x0C,0x41,0x83,0xE1,0x0F,0x45,0x88,0x08,0x4C,0x8D,0x40,0x06,0x4C,0x8B,0xD2,0x49,0xC1,0xEA,0x08,0x41,0x83,0xE2,0x0F,0x45,0x88,0x10,0x4C,0x8D,0x40,0x05,0x4C,0x8B,0xDA,0x49,0xC1,0xEB,0x04,0x41,0x83,0xE3,0x0F,0x45,0x88,0x18,0x4C,0x8D,0x40,0x04,0x83,0xE2,0x0F,0x41,0x88,0x10,0x4C,0x8D,0x40,0x03,0x45,0x88,0x08,0x4C,0x8D,0x40,0x02,0x45,0x88,0x10,0x4C,0x8D,0x40,0x01,0x45,0x88,0x18,0x88,0x10,0x48,0x89,0x01,0xC7,0x41,0x08,0x08,0x00,0x00,0x00,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> digits_extract_hi(ulong src)
; location: [7FFDDAF375B0h, 7FFDDAF3762Dh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0003h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX]          encoding(4 bytes) = 48 89 04 24
000dh lea rax,[rsp]                 ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 04 24
0011h shr rdx,20h                   ; SHR(Shr_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 ea 20
0015h lea r8,[rax+7]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 07
0019h mov r9,rdx                    ; MOV(Mov_r64_rm64) [R9,RDX]                           encoding(3 bytes) = 4c 8b ca
001ch shr r9,0Ch                    ; SHR(Shr_rm64_imm8) [R9,ch:imm8]                      encoding(4 bytes) = 49 c1 e9 0c
0020h and r9d,0Fh                   ; AND(And_rm32_imm8) [R9D,fh:imm32]                    encoding(4 bytes) = 41 83 e1 0f
0024h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R9L]              encoding(3 bytes) = 45 88 08
0027h lea r8,[rax+6]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 06
002bh mov r10,rdx                   ; MOV(Mov_r64_rm64) [R10,RDX]                          encoding(3 bytes) = 4c 8b d2
002eh shr r10,8                     ; SHR(Shr_rm64_imm8) [R10,8h:imm8]                     encoding(4 bytes) = 49 c1 ea 08
0032h and r10d,0Fh                  ; AND(And_rm32_imm8) [R10D,fh:imm32]                   encoding(4 bytes) = 41 83 e2 0f
0036h mov [r8],r10b                 ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R10L]             encoding(3 bytes) = 45 88 10
0039h lea r8,[rax+5]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 05
003dh mov r11,rdx                   ; MOV(Mov_r64_rm64) [R11,RDX]                          encoding(3 bytes) = 4c 8b da
0040h shr r11,4                     ; SHR(Shr_rm64_imm8) [R11,4h:imm8]                     encoding(4 bytes) = 49 c1 eb 04
0044h and r11d,0Fh                  ; AND(And_rm32_imm8) [R11D,fh:imm32]                   encoding(4 bytes) = 41 83 e3 0f
0048h mov [r8],r11b                 ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R11L]             encoding(3 bytes) = 45 88 18
004bh lea r8,[rax+4]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 04
004fh and edx,0Fh                   ; AND(And_rm32_imm8) [EDX,fh:imm32]                    encoding(3 bytes) = 83 e2 0f
0052h mov [r8],dl                   ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),DL]               encoding(3 bytes) = 41 88 10
0055h lea r8,[rax+3]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 03
0059h mov [r8],r9b                  ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R9L]              encoding(3 bytes) = 45 88 08
005ch lea r8,[rax+2]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 02
0060h mov [r8],r10b                 ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R10L]             encoding(3 bytes) = 45 88 10
0063h lea r8,[rax+1]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 01
0067h mov [r8],r11b                 ; MOV(Mov_rm8_r8) [mem(8u,R8:br,:sr),R11L]             encoding(3 bytes) = 45 88 18
006ah mov [rax],dl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),DL]              encoding(2 bytes) = 88 10
006ch mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
006fh mov dword ptr [rcx+8],8       ; MOV(Mov_rm32_imm32) [mem(32u,RCX:br,:sr),8h:imm32]   encoding(7 bytes) = c7 41 08 08 00 00 00
0076h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0079h add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
007dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digits_extract_hiBytes => new byte[126]{0x50,0x33,0xC0,0x48,0x89,0x04,0x24,0x33,0xC0,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0x48,0xC1,0xEA,0x20,0x4C,0x8D,0x40,0x07,0x4C,0x8B,0xCA,0x49,0xC1,0xE9,0x0C,0x41,0x83,0xE1,0x0F,0x45,0x88,0x08,0x4C,0x8D,0x40,0x06,0x4C,0x8B,0xD2,0x49,0xC1,0xEA,0x08,0x41,0x83,0xE2,0x0F,0x45,0x88,0x10,0x4C,0x8D,0x40,0x05,0x4C,0x8B,0xDA,0x49,0xC1,0xEB,0x04,0x41,0x83,0xE3,0x0F,0x45,0x88,0x18,0x4C,0x8D,0x40,0x04,0x83,0xE2,0x0F,0x41,0x88,0x10,0x4C,0x8D,0x40,0x03,0x45,0x88,0x08,0x4C,0x8D,0x40,0x02,0x45,0x88,0x10,0x4C,0x8D,0x40,0x01,0x45,0x88,0x18,0x88,0x10,0x48,0x89,0x01,0xC7,0x41,0x08,0x08,0x00,0x00,0x00,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char digit_decode_1_0()
; location: [7FFDDAF37650h, 7FFDDAF3765Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,30h                   ; MOV(Mov_r32_imm32) [EAX,30h:imm32]                   encoding(5 bytes) = b8 30 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digit_decode_1_0Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x30,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char digit_decode_1_1()
; location: [7FFDDAF37670h, 7FFDDAF3767Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,31h                   ; MOV(Mov_r32_imm32) [EAX,31h:imm32]                   encoding(5 bytes) = b8 31 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digit_decode_1_1Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x31,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char digit_decode_1_2()
; location: [7FFDDAF37690h, 7FFDDAF3769Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,32h                   ; MOV(Mov_r32_imm32) [EAX,32h:imm32]                   encoding(5 bytes) = b8 32 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digit_decode_1_2Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x32,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char digit_decode_1_3()
; location: [7FFDDAF376B0h, 7FFDDAF376BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,33h                   ; MOV(Mov_r32_imm32) [EAX,33h:imm32]                   encoding(5 bytes) = b8 33 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digit_decode_1_3Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x33,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
