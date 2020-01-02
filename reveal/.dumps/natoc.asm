; 2020-01-01 21:58:46:048
; function: ulong nat_add()
; location: [7FF7C7BB4E80h, 7FF7C7BB4E8Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1Ch                   ; MOV(Mov_r32_imm32) [EAX,1ch:imm32]                   encoding(5 bytes) = b8 1c 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nat_addBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x1C,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong nat_sub()
; location: [7FF7C7BB5AC0h, 7FF7C7BB5ACAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,100h                  ; MOV(Mov_r32_imm32) [EAX,100h:imm32]                  encoding(5 bytes) = b8 00 01 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nat_subBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x01,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong nat_mul()
; location: [7FF7C7BB5AE0h, 7FF7C7BB5AEAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0C0h                  ; MOV(Mov_r32_imm32) [EAX,c0h:imm32]                   encoding(5 bytes) = b8 c0 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nat_mulBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xC0,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong nat_div()
; location: [7FF7C7BB5F10h, 7FF7C7BB5F1Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,0Ah                   ; MOV(Mov_r32_imm32) [EAX,ah:imm32]                    encoding(5 bytes) = b8 0a 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nat_divBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x0A,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong nat_mod()
; location: [7FF7C7BB5F30h, 7FF7C7BB5F3Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,2                     ; MOV(Mov_r32_imm32) [EAX,2h:imm32]                    encoding(5 bytes) = b8 02 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> nat_modBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x02,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong digits_encode_1_0()
; location: [7FF7C7BB5F50h, 7FF7C7BB5F57h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digits_encode_1_0Bytes => new byte[8]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong digits_encode_1()
; location: [7FF7C7BB5F70h, 7FF7C7BB5F7Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digits_encode_1Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong digits_encode_2()
; location: [7FF7C7BB5F90h, 7FF7C7BB5F9Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,2                     ; MOV(Mov_r32_imm32) [EAX,2h:imm32]                    encoding(5 bytes) = b8 02 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digits_encode_2Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x02,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong digits_encode_3()
; location: [7FF7C7BB5FB0h, 7FF7C7BB5FBAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,3                     ; MOV(Mov_r32_imm32) [EAX,3h:imm32]                    encoding(5 bytes) = b8 03 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digits_encode_3Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong digits_encode_10()
; location: [7FF7C7BB5FD0h, 7FF7C7BB5FDAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digits_encode_10Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x10,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong digits_encode_210()
; location: [7FF7C7BB5FF0h, 7FF7C7BB5FFAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,210h                  ; MOV(Mov_r32_imm32) [EAX,210h:imm32]                  encoding(5 bytes) = b8 10 02 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digits_encode_210Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x10,0x02,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong digits_encode_3210()
; location: [7FF7C7BB6010h, 7FF7C7BB601Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,3210h                 ; MOV(Mov_r32_imm32) [EAX,3210h:imm32]                 encoding(5 bytes) = b8 10 32 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digits_encode_3210Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x10,0x32,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong digits_encode_43210()
; location: [7FF7C7BB6030h, 7FF7C7BB603Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,43210h                ; MOV(Mov_r32_imm32) [EAX,43210h:imm32]                encoding(5 bytes) = b8 10 32 04 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digits_encode_43210Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x10,0x32,0x04,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong digits_encode_76543210()
; location: [7FF7C7BB6050h, 7FF7C7BB605Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,76543210h             ; MOV(Mov_r32_imm32) [EAX,76543210h:imm32]             encoding(5 bytes) = b8 10 32 54 76
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digits_encode_76543210Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x10,0x32,0x54,0x76,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong digit_extract_9()
; location: [7FF7C7BB6070h, 7FF7C7BB607Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,9                     ; MOV(Mov_r32_imm32) [EAX,9h:imm32]                    encoding(5 bytes) = b8 09 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digit_extract_9Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x09,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong digit_extract_4()
; location: [7FF7C7BB6090h, 7FF7C7BB609Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,4                     ; MOV(Mov_r32_imm32) [EAX,4h:imm32]                    encoding(5 bytes) = b8 04 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digit_extract_4Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x04,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong digit_extract_8()
; location: [7FF7C7BB60B0h, 7FF7C7BB60BAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,8                     ; MOV(Mov_r32_imm32) [EAX,8h:imm32]                    encoding(5 bytes) = b8 08 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digit_extract_8Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x08,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong digit_extract_5()
; location: [7FF7C7BB60D0h, 7FF7C7BB60DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,5                     ; MOV(Mov_r32_imm32) [EAX,5h:imm32]                    encoding(5 bytes) = b8 05 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digit_extract_5Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x05,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void digits_extract_5849(out byte d3, out byte d2, out byte d1, out byte d0)
; location: [7FF7C7BB60F0h, 7FF7C7BB6103h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov byte ptr [rcx],5          ; MOV(Mov_rm8_imm8) [mem(8u,RCX:br,:sr),5h:imm8]       encoding(3 bytes) = c6 01 05
0008h mov byte ptr [rdx],8          ; MOV(Mov_rm8_imm8) [mem(8u,RDX:br,:sr),8h:imm8]       encoding(3 bytes) = c6 02 08
000bh mov byte ptr [r8],4           ; MOV(Mov_rm8_imm8) [mem(8u,R8:br,:sr),4h:imm8]        encoding(4 bytes) = 41 c6 00 04
000fh mov byte ptr [r9],9           ; MOV(Mov_rm8_imm8) [mem(8u,R9:br,:sr),9h:imm8]        encoding(4 bytes) = 41 c6 01 09
0013h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digits_extract_5849Bytes => new byte[20]{0x0F,0x1F,0x44,0x00,0x00,0xC6,0x01,0x05,0xC6,0x02,0x08,0x41,0xC6,0x00,0x04,0x41,0xC6,0x01,0x09,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void digits_extract_5489_ref(ref byte dst)
; location: [7FF7C7BB6120h, 7FF7C7BB613Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h lea rax,[rcx+3]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 41 03
0009h mov byte ptr [rax],5          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),5h:imm8]       encoding(3 bytes) = c6 00 05
000ch lea rax,[rcx+2]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 41 02
0010h mov byte ptr [rax],8          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),8h:imm8]       encoding(3 bytes) = c6 00 08
0013h lea rax,[rcx+1]               ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 41 01
0017h mov byte ptr [rax],4          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),4h:imm8]       encoding(3 bytes) = c6 00 04
001ah mov byte ptr [rcx],9          ; MOV(Mov_rm8_imm8) [mem(8u,RCX:br,:sr),9h:imm8]       encoding(3 bytes) = c6 01 09
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digits_extract_5489_refBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8D,0x41,0x03,0xC6,0x00,0x05,0x48,0x8D,0x41,0x02,0xC6,0x00,0x08,0x48,0x8D,0x41,0x01,0xC6,0x00,0x04,0xC6,0x01,0x09,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void digits_extract_80352178(out byte d7, out byte d6, out byte d5, out byte d4, out byte d3, out byte d2, out byte d1, out byte d0)
; location: [7FF7C7BB6150h, 7FF7C7BB6183h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
000ah mov byte ptr [rax],2          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),2h:imm8]       encoding(3 bytes) = c6 00 02
000dh mov rax,[rsp+30h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 30
0012h mov byte ptr [rax],1          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),1h:imm8]       encoding(3 bytes) = c6 00 01
0015h mov rax,[rsp+38h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 38
001ah mov byte ptr [rax],7          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),7h:imm8]       encoding(3 bytes) = c6 00 07
001dh mov rax,[rsp+40h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 40
0022h mov byte ptr [rax],8          ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),8h:imm8]       encoding(3 bytes) = c6 00 08
0025h mov byte ptr [rcx],8          ; MOV(Mov_rm8_imm8) [mem(8u,RCX:br,:sr),8h:imm8]       encoding(3 bytes) = c6 01 08
0028h mov byte ptr [rdx],0          ; MOV(Mov_rm8_imm8) [mem(8u,RDX:br,:sr),0h:imm8]       encoding(3 bytes) = c6 02 00
002bh mov byte ptr [r8],3           ; MOV(Mov_rm8_imm8) [mem(8u,R8:br,:sr),3h:imm8]        encoding(4 bytes) = 41 c6 00 03
002fh mov byte ptr [r9],5           ; MOV(Mov_rm8_imm8) [mem(8u,R9:br,:sr),5h:imm8]        encoding(4 bytes) = 41 c6 01 05
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digits_extract_80352178Bytes => new byte[52]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x44,0x24,0x28,0xC6,0x00,0x02,0x48,0x8B,0x44,0x24,0x30,0xC6,0x00,0x01,0x48,0x8B,0x44,0x24,0x38,0xC6,0x00,0x07,0x48,0x8B,0x44,0x24,0x40,0xC6,0x00,0x08,0xC6,0x01,0x08,0xC6,0x02,0x00,0x41,0xC6,0x00,0x03,0x41,0xC6,0x01,0x05,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void chars_5489(out Char c3, out Char c2, out Char c1, out Char c0)
; location: [7FF7C7BB61A0h, 7FF7C7BB61BBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov word ptr [rcx],35h        ; MOV(Mov_rm16_imm16) [mem(16u,RCX:br,:sr),35h:imm16]  encoding(5 bytes) = 66 c7 01 35 00
000ah mov word ptr [rdx],34h        ; MOV(Mov_rm16_imm16) [mem(16u,RDX:br,:sr),34h:imm16]  encoding(5 bytes) = 66 c7 02 34 00
000fh mov word ptr [r8],38h         ; MOV(Mov_rm16_imm16) [mem(16u,R8:br,:sr),38h:imm16]   encoding(6 bytes) = 66 41 c7 00 38 00
0015h mov word ptr [r9],39h         ; MOV(Mov_rm16_imm16) [mem(16u,R9:br,:sr),39h:imm16]   encoding(6 bytes) = 66 41 c7 01 39 00
001bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> chars_5489Bytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x66,0xC7,0x01,0x35,0x00,0x66,0xC7,0x02,0x34,0x00,0x66,0x41,0xC7,0x00,0x38,0x00,0x66,0x41,0xC7,0x01,0x39,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void chars_80352178(out Char c7, out Char c6, out Char c5, out Char c4, out Char c3, out Char c2, out Char c1, out Char c0)
; location: [7FF7C7BB61D0h, 7FF7C7BB6213h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov word ptr [rcx],38h        ; MOV(Mov_rm16_imm16) [mem(16u,RCX:br,:sr),38h:imm16]  encoding(5 bytes) = 66 c7 01 38 00
000ah mov word ptr [rdx],30h        ; MOV(Mov_rm16_imm16) [mem(16u,RDX:br,:sr),30h:imm16]  encoding(5 bytes) = 66 c7 02 30 00
000fh mov word ptr [r8],33h         ; MOV(Mov_rm16_imm16) [mem(16u,R8:br,:sr),33h:imm16]   encoding(6 bytes) = 66 41 c7 00 33 00
0015h mov word ptr [r9],35h         ; MOV(Mov_rm16_imm16) [mem(16u,R9:br,:sr),35h:imm16]   encoding(6 bytes) = 66 41 c7 01 35 00
001bh mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 28
0020h mov word ptr [rax],32h        ; MOV(Mov_rm16_imm16) [mem(16u,RAX:br,:sr),32h:imm16]  encoding(5 bytes) = 66 c7 00 32 00
0025h mov rax,[rsp+30h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 30
002ah mov word ptr [rax],31h        ; MOV(Mov_rm16_imm16) [mem(16u,RAX:br,:sr),31h:imm16]  encoding(5 bytes) = 66 c7 00 31 00
002fh mov rax,[rsp+38h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 38
0034h mov word ptr [rax],37h        ; MOV(Mov_rm16_imm16) [mem(16u,RAX:br,:sr),37h:imm16]  encoding(5 bytes) = 66 c7 00 37 00
0039h mov rax,[rsp+40h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 44 24 40
003eh mov word ptr [rax],38h        ; MOV(Mov_rm16_imm16) [mem(16u,RAX:br,:sr),38h:imm16]  encoding(5 bytes) = 66 c7 00 38 00
0043h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> chars_80352178Bytes => new byte[68]{0x0F,0x1F,0x44,0x00,0x00,0x66,0xC7,0x01,0x38,0x00,0x66,0xC7,0x02,0x30,0x00,0x66,0x41,0xC7,0x00,0x33,0x00,0x66,0x41,0xC7,0x01,0x35,0x00,0x48,0x8B,0x44,0x24,0x28,0x66,0xC7,0x00,0x32,0x00,0x48,0x8B,0x44,0x24,0x30,0x66,0xC7,0x00,0x31,0x00,0x48,0x8B,0x44,0x24,0x38,0x66,0xC7,0x00,0x37,0x00,0x48,0x8B,0x44,0x24,0x40,0x66,0xC7,0x00,0x38,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<Char> charspan_5489()
; location: [7FF7C7BB6230h, 7FF7C7BB6285h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,7FF7C7729290h         ; MOV(Mov_r64_imm64) [RCX,7ff7c7729290h:imm64]         encoding(10 bytes) = 48 b9 90 92 72 c7 f7 7f 00 00
0012h mov edx,4                     ; MOV(Mov_r32_imm32) [EDX,4h:imm32]                    encoding(5 bytes) = ba 04 00 00 00
0017h call 7FF826FA6DE0h            ; CALL(Call_rel32_64) [5F3F0BB0h:jmp64]                encoding(5 bytes) = e8 94 0b 3f 5f
001ch add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
0020h mov edx,4                     ; MOV(Mov_r32_imm32) [EDX,4h:imm32]                    encoding(5 bytes) = ba 04 00 00 00
0025h lea rcx,[rax+6]               ; LEA(Lea_r64_m) [RCX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 48 06
0029h lea r8,[rax+4]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 04
002dh lea r9,[rax+2]                ; LEA(Lea_r64_m) [R9,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 48 02
0031h mov word ptr [rcx],35h        ; MOV(Mov_rm16_imm16) [mem(16u,RCX:br,:sr),35h:imm16]  encoding(5 bytes) = 66 c7 01 35 00
0036h mov word ptr [r8],34h         ; MOV(Mov_rm16_imm16) [mem(16u,R8:br,:sr),34h:imm16]   encoding(6 bytes) = 66 41 c7 00 34 00
003ch mov word ptr [r9],38h         ; MOV(Mov_rm16_imm16) [mem(16u,R9:br,:sr),38h:imm16]   encoding(6 bytes) = 66 41 c7 01 38 00
0042h mov word ptr [rax],39h        ; MOV(Mov_rm16_imm16) [mem(16u,RAX:br,:sr),39h:imm16]  encoding(5 bytes) = 66 c7 00 39 00
0047h mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,:sr),RAX]          encoding(3 bytes) = 48 89 06
004ah mov [rsi+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,:sr),EDX]          encoding(3 bytes) = 89 56 08
004dh mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0050h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0054h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0055h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> charspan_5489Bytes => new byte[86]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0xB9,0x90,0x92,0x72,0xC7,0xF7,0x7F,0x00,0x00,0xBA,0x04,0x00,0x00,0x00,0xE8,0x94,0x0B,0x3F,0x5F,0x48,0x83,0xC0,0x10,0xBA,0x04,0x00,0x00,0x00,0x48,0x8D,0x48,0x06,0x4C,0x8D,0x40,0x04,0x4C,0x8D,0x48,0x02,0x66,0xC7,0x01,0x35,0x00,0x66,0x41,0xC7,0x00,0x34,0x00,0x66,0x41,0xC7,0x01,0x38,0x00,0x66,0xC7,0x00,0x39,0x00,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char digit_decode_0()
; location: [7FF7C7BB62A0h, 7FF7C7BB62AAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,30h                   ; MOV(Mov_r32_imm32) [EAX,30h:imm32]                   encoding(5 bytes) = b8 30 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digit_decode_0Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x30,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char digit_decode_1()
; location: [7FF7C7BB62C0h, 7FF7C7BB62CAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,31h                   ; MOV(Mov_r32_imm32) [EAX,31h:imm32]                   encoding(5 bytes) = b8 31 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digit_decode_1Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x31,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char digit_decode_2()
; location: [7FF7C7BB62E0h, 7FF7C7BB62EAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,32h                   ; MOV(Mov_r32_imm32) [EAX,32h:imm32]                   encoding(5 bytes) = b8 32 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digit_decode_2Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x32,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char digit_decode_3()
; location: [7FF7C7BB6300h, 7FF7C7BB630Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,33h                   ; MOV(Mov_r32_imm32) [EAX,33h:imm32]                   encoding(5 bytes) = b8 33 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digit_decode_3Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x33,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char digit_decode_4()
; location: [7FF7C7BB6320h, 7FF7C7BB632Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,34h                   ; MOV(Mov_r32_imm32) [EAX,34h:imm32]                   encoding(5 bytes) = b8 34 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digit_decode_4Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x34,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char digit_decode_n4()
; location: [7FF7C7BB6340h, 7FF7C7BB634Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,34h                   ; MOV(Mov_r32_imm32) [EAX,34h:imm32]                   encoding(5 bytes) = b8 34 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digit_decode_n4Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x34,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char digit_decode_5()
; location: [7FF7C7BB6360h, 7FF7C7BB636Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,35h                   ; MOV(Mov_r32_imm32) [EAX,35h:imm32]                   encoding(5 bytes) = b8 35 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digit_decode_5Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x35,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Char digit_decode_n5()
; location: [7FF7C7BB6380h, 7FF7C7BB638Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,35h                   ; MOV(Mov_r32_imm32) [EAX,35h:imm32]                   encoding(5 bytes) = b8 35 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> digit_decode_n5Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x35,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
