; 2019-10-03 12:22:08:532
; function: uint bb_pack23(in BitBlock23 src)
; location: [7FFDDABF2110h, 7FFDDABF2251h]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h mov [rsp],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(4 bytes) = 48 89 04 24
000dh mov [rsp+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 08
0012h mov [rsp+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 10
0017h vmovdqu xmm0,xmmword ptr [rcx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RCX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 01
001bh vmovdqu xmmword ptr [rsp],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSP:br,SS:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 04 24
0020h mov eax,[rcx+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,DS:sr)]        encoding(3 bytes) = 8b 41 10
0023h mov [rsp+10h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 10
0027h mov ax,[rcx+14h]              ; MOV(Mov_r16_rm16) [AX,mem(16u,RCX:br,DS:sr)]         encoding(4 bytes) = 66 8b 41 14
002bh mov [rsp+14h],ax              ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,SS:sr),AX]         encoding(5 bytes) = 66 89 44 24 14
0030h mov al,[rcx+16h]              ; MOV(Mov_r8_rm8) [AL,mem(8u,RCX:br,DS:sr)]            encoding(3 bytes) = 8a 41 16
0033h mov [rsp+16h],al              ; MOV(Mov_rm8_r8) [mem(8u,RSP:br,SS:sr),AL]            encoding(4 bytes) = 88 44 24 16
0037h movzx eax,byte ptr [rsp]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(4 bytes) = 0f b6 04 24
003bh movzx edx,byte ptr [rsp+1]    ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 01
0040h shl edx,1                     ; SHL(Shl_rm32_1) [EDX,1h:imm8]                        encoding(2 bytes) = d1 e2
0042h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0044h movzx edx,byte ptr [rsp+2]    ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 02
0049h shl edx,2                     ; SHL(Shl_rm32_imm8) [EDX,2h:imm8]                     encoding(3 bytes) = c1 e2 02
004ch or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
004eh movzx edx,byte ptr [rsp+3]    ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 03
0053h shl edx,3                     ; SHL(Shl_rm32_imm8) [EDX,3h:imm8]                     encoding(3 bytes) = c1 e2 03
0056h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0058h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
005bh movzx edx,byte ptr [rsp+4]    ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 04
0060h shl edx,4                     ; SHL(Shl_rm32_imm8) [EDX,4h:imm8]                     encoding(3 bytes) = c1 e2 04
0063h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0065h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0068h movzx edx,byte ptr [rsp+5]    ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 05
006dh shl edx,5                     ; SHL(Shl_rm32_imm8) [EDX,5h:imm8]                     encoding(3 bytes) = c1 e2 05
0070h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0072h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0075h movzx edx,byte ptr [rsp+6]    ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 06
007ah shl edx,6                     ; SHL(Shl_rm32_imm8) [EDX,6h:imm8]                     encoding(3 bytes) = c1 e2 06
007dh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
007fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0082h movzx edx,byte ptr [rsp+7]    ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 07
0087h shl edx,7                     ; SHL(Shl_rm32_imm8) [EDX,7h:imm8]                     encoding(3 bytes) = c1 e2 07
008ah or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
008ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
008fh movzx edx,byte ptr [rsp+8]    ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 08
0094h shl edx,8                     ; SHL(Shl_rm32_imm8) [EDX,8h:imm8]                     encoding(3 bytes) = c1 e2 08
0097h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0099h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
009ch movzx edx,byte ptr [rsp+9]    ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 09
00a1h shl edx,9                     ; SHL(Shl_rm32_imm8) [EDX,9h:imm8]                     encoding(3 bytes) = c1 e2 09
00a4h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
00a6h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
00a9h movzx edx,byte ptr [rsp+0Ah]  ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 0a
00aeh shl edx,0Ah                   ; SHL(Shl_rm32_imm8) [EDX,ah:imm8]                     encoding(3 bytes) = c1 e2 0a
00b1h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
00b3h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
00b6h movzx edx,byte ptr [rsp+0Bh]  ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 0b
00bbh shl edx,0Bh                   ; SHL(Shl_rm32_imm8) [EDX,bh:imm8]                     encoding(3 bytes) = c1 e2 0b
00beh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
00c0h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
00c3h movzx edx,byte ptr [rsp+0Ch]  ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 0c
00c8h shl edx,0Ch                   ; SHL(Shl_rm32_imm8) [EDX,ch:imm8]                     encoding(3 bytes) = c1 e2 0c
00cbh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
00cdh movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
00d0h movzx edx,byte ptr [rsp+0Dh]  ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 0d
00d5h shl edx,0Dh                   ; SHL(Shl_rm32_imm8) [EDX,dh:imm8]                     encoding(3 bytes) = c1 e2 0d
00d8h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
00dah movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
00ddh movzx edx,byte ptr [rsp+0Eh]  ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 0e
00e2h shl edx,0Eh                   ; SHL(Shl_rm32_imm8) [EDX,eh:imm8]                     encoding(3 bytes) = c1 e2 0e
00e5h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
00e7h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
00eah movzx edx,byte ptr [rsp+0Fh]  ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 0f
00efh shl edx,0Fh                   ; SHL(Shl_rm32_imm8) [EDX,fh:imm8]                     encoding(3 bytes) = c1 e2 0f
00f2h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
00f4h movzx eax,ax                  ; MOVZX(Movzx_r32_rm16) [EAX,AX]                       encoding(3 bytes) = 0f b7 c0
00f7h movzx edx,byte ptr [rsp+10h]  ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 10
00fch shl edx,10h                   ; SHL(Shl_rm32_imm8) [EDX,10h:imm8]                    encoding(3 bytes) = c1 e2 10
00ffh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0101h movzx edx,byte ptr [rsp+11h]  ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 11
0106h shl edx,11h                   ; SHL(Shl_rm32_imm8) [EDX,11h:imm8]                    encoding(3 bytes) = c1 e2 11
0109h or edx,eax                    ; OR(Or_r32_rm32) [EDX,EAX]                            encoding(2 bytes) = 0b d0
010bh movzx eax,byte ptr [rsp+12h]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 44 24 12
0110h shl eax,12h                   ; SHL(Shl_rm32_imm8) [EAX,12h:imm8]                    encoding(3 bytes) = c1 e0 12
0113h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0115h movzx edx,byte ptr [rsp+13h]  ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 13
011ah shl edx,13h                   ; SHL(Shl_rm32_imm8) [EDX,13h:imm8]                    encoding(3 bytes) = c1 e2 13
011dh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
011fh movzx edx,byte ptr [rsp+14h]  ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 14
0124h shl edx,14h                   ; SHL(Shl_rm32_imm8) [EDX,14h:imm8]                    encoding(3 bytes) = c1 e2 14
0127h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0129h movzx edx,byte ptr [rsp+15h]  ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 15
012eh shl edx,15h                   ; SHL(Shl_rm32_imm8) [EDX,15h:imm8]                    encoding(3 bytes) = c1 e2 15
0131h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0133h movzx edx,byte ptr [rsp+16h]  ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RSP:br,SS:sr)]      encoding(5 bytes) = 0f b6 54 24 16
0138h shl edx,16h                   ; SHL(Shl_rm32_imm8) [EDX,16h:imm8]                    encoding(3 bytes) = c1 e2 16
013bh or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
013dh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
0141h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bb_pack23Bytes => new byte[322]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x04,0x24,0x48,0x89,0x44,0x24,0x08,0x48,0x89,0x44,0x24,0x10,0xC5,0xFA,0x6F,0x01,0xC5,0xFA,0x7F,0x04,0x24,0x8B,0x41,0x10,0x89,0x44,0x24,0x10,0x66,0x8B,0x41,0x14,0x66,0x89,0x44,0x24,0x14,0x8A,0x41,0x16,0x88,0x44,0x24,0x16,0x0F,0xB6,0x04,0x24,0x0F,0xB6,0x54,0x24,0x01,0xD1,0xE2,0x0B,0xC2,0x0F,0xB6,0x54,0x24,0x02,0xC1,0xE2,0x02,0x0B,0xC2,0x0F,0xB6,0x54,0x24,0x03,0xC1,0xE2,0x03,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0x54,0x24,0x04,0xC1,0xE2,0x04,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0x54,0x24,0x05,0xC1,0xE2,0x05,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0x54,0x24,0x06,0xC1,0xE2,0x06,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0x54,0x24,0x07,0xC1,0xE2,0x07,0x0B,0xC2,0x0F,0xB6,0xC0,0x0F,0xB6,0x54,0x24,0x08,0xC1,0xE2,0x08,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB6,0x54,0x24,0x09,0xC1,0xE2,0x09,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB6,0x54,0x24,0x0A,0xC1,0xE2,0x0A,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB6,0x54,0x24,0x0B,0xC1,0xE2,0x0B,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB6,0x54,0x24,0x0C,0xC1,0xE2,0x0C,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB6,0x54,0x24,0x0D,0xC1,0xE2,0x0D,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB6,0x54,0x24,0x0E,0xC1,0xE2,0x0E,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB6,0x54,0x24,0x0F,0xC1,0xE2,0x0F,0x0B,0xC2,0x0F,0xB7,0xC0,0x0F,0xB6,0x54,0x24,0x10,0xC1,0xE2,0x10,0x0B,0xC2,0x0F,0xB6,0x54,0x24,0x11,0xC1,0xE2,0x11,0x0B,0xD0,0x0F,0xB6,0x44,0x24,0x12,0xC1,0xE0,0x12,0x0B,0xC2,0x0F,0xB6,0x54,0x24,0x13,0xC1,0xE2,0x13,0x0B,0xC2,0x0F,0xB6,0x54,0x24,0x14,0xC1,0xE2,0x14,0x0B,0xC2,0x0F,0xB6,0x54,0x24,0x15,0xC1,0xE2,0x15,0x0B,0xC2,0x0F,0xB6,0x54,0x24,0x16,0xC1,0xE2,0x16,0x0B,0xC2,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> get_U8Data()
; location: [7FFDDABF2470h, 7FFDDABF248Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,12804D6895Ch          ; MOV(Mov_r64_imm64) [RAX,12804d6895ch:imm64]          encoding(10 bytes) = 48 b8 5c 89 d6 04 28 01 00 00
000fh mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 01
0012h mov dword ptr [rcx+8],40h     ; MOV(Mov_rm32_imm32) [mem(32u,RCX:br,DS:sr),40h:imm32] encoding(7 bytes) = c7 41 08 40 00 00 00
0019h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> get_U8DataBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x5C,0x89,0xD6,0x04,0x28,0x01,0x00,0x00,0x48,0x89,0x01,0xC7,0x41,0x08,0x40,0x00,0x00,0x00,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<uint> get_U32Data()
; location: [7FFDDABF28B0h, 7FFDDABF291Ah]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000bh mov rcx,7FFDDADBA4B8h         ; MOV(Mov_r64_imm64) [RCX,7ffddadba4b8h:imm64]         encoding(10 bytes) = 48 b9 b8 a4 db da fd 7f 00 00
0015h mov edx,10h                   ; MOV(Mov_r32_imm32) [EDX,10h:imm32]                   encoding(5 bytes) = ba 10 00 00 00
001ah call 7FFE3A6F45E0h            ; CALL(Call_rel32_64) [5FB01D30h:jmp64]                encoding(5 bytes) = e8 11 1d b0 5f
001fh mov rdx,12804D6891Ch          ; MOV(Mov_r64_imm64) [RDX,12804d6891ch:imm64]          encoding(10 bytes) = 48 ba 1c 89 d6 04 28 01 00 00
0029h lea rcx,[rax+10h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RAX:br,DS:sr)]       encoding(4 bytes) = 48 8d 48 10
002dh vmovdqu xmm0,xmmword ptr [rdx]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,DS:sr)] encoding(VEX, 4 bytes) = c5 fa 6f 02
0031h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
0035h vmovdqu xmm0,xmmword ptr [rdx+10h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,DS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 42 10
003ah vmovdqu xmmword ptr [rcx+10h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 10
003fh vmovdqu xmm0,xmmword ptr [rdx+20h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,DS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 42 20
0044h vmovdqu xmmword ptr [rcx+20h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 20
0049h vmovdqu xmm0,xmmword ptr [rdx+30h]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RDX:br,DS:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 42 30
004eh vmovdqu xmmword ptr [rcx+30h],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 5 bytes) = c5 fa 7f 41 30
0053h add rax,10h                   ; ADD(Add_rm64_imm8) [RAX,10h:imm64]                   encoding(4 bytes) = 48 83 c0 10
0057h mov edx,10h                   ; MOV(Mov_r32_imm32) [EDX,10h:imm32]                   encoding(5 bytes) = ba 10 00 00 00
005ch mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 06
005fh mov [rsi+8],edx               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EDX]        encoding(3 bytes) = 89 56 08
0062h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
0065h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0069h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
006ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> get_U32DataBytes => new byte[107]{0x56,0x48,0x83,0xEC,0x20,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0x48,0xB9,0xB8,0xA4,0xDB,0xDA,0xFD,0x7F,0x00,0x00,0xBA,0x10,0x00,0x00,0x00,0xE8,0x11,0x1D,0xB0,0x5F,0x48,0xBA,0x1C,0x89,0xD6,0x04,0x28,0x01,0x00,0x00,0x48,0x8D,0x48,0x10,0xC5,0xFA,0x6F,0x02,0xC5,0xFA,0x7F,0x01,0xC5,0xFA,0x6F,0x42,0x10,0xC5,0xFA,0x7F,0x41,0x10,0xC5,0xFA,0x6F,0x42,0x20,0xC5,0xFA,0x7F,0x41,0x20,0xC5,0xFA,0x6F,0x42,0x30,0xC5,0xFA,0x7F,0x41,0x30,0x48,0x83,0xC0,0x10,0xBA,0x10,0x00,0x00,0x00,0x48,0x89,0x06,0x89,0x56,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint Or8Inline(uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7)
; location: [7FFDDABF2940h, 7FFDDABF295Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,ecx                    ; OR(Or_r32_rm32) [EDX,ECX]                            encoding(2 bytes) = 0b d1
0007h or edx,r8d                    ; OR(Or_r32_rm32) [EDX,R8D]                            encoding(3 bytes) = 41 0b d0
000ah or edx,r9d                    ; OR(Or_r32_rm32) [EDX,R9D]                            encoding(3 bytes) = 41 0b d1
000dh or edx,[rsp+28h]              ; OR(Or_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]          encoding(4 bytes) = 0b 54 24 28
0011h or edx,[rsp+30h]              ; OR(Or_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]          encoding(4 bytes) = 0b 54 24 30
0015h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0017h or eax,[rsp+38h]              ; OR(Or_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]          encoding(4 bytes) = 0b 44 24 38
001bh or eax,[rsp+40h]              ; OR(Or_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]          encoding(4 bytes) = 0b 44 24 40
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> Or8InlineBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0B,0xD1,0x41,0x0B,0xD0,0x41,0x0B,0xD1,0x0B,0x54,0x24,0x28,0x0B,0x54,0x24,0x30,0x8B,0xC2,0x0B,0x44,0x24,0x38,0x0B,0x44,0x24,0x40,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint RotLU32Inline(uint x, int offset)
; location: [7FFDDABF2970h, 7FFDDABF297Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0009h rol eax,cl                    ; ROL(Rol_rm32_CL) [EAX,CL]                            encoding(2 bytes) = d3 c0
000bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> RotLU32InlineBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int ChoiceSwitchInline(int x)
; location: [7FFDDABF2990h, 7FFDDABF29D6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h dec edx                       ; DEC(Dec_rm32) [EDX]                                  encoding(2 bytes) = ff ca
0007h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
000ah ja short 0044h                ; JA(Ja_rel8_64) [44h:jmp64]                           encoding(2 bytes) = 77 38
000ch mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000eh lea rdx,[7FFDDABF29D8h]       ; LEA(Lea_r64_m) [RDX,mem(Unknown,RIP:br,DS:sr)]       encoding(7 bytes) = 48 8d 15 33 00 00 00
0015h mov edx,[rdx+rax*4]           ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,DS:sr)]        encoding(3 bytes) = 8b 14 82
0018h lea rcx,[7FFDDABF2995h]       ; LEA(Lea_r64_m) [RCX,mem(Unknown,RIP:br,DS:sr)]       encoding(7 bytes) = 48 8d 0d e6 ff ff ff
001fh add rdx,rcx                   ; ADD(Add_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 03 d1
0022h jmp rdx                       ; JMP(Jmp_rm64) [RDX]                                  encoding(2 bytes) = ff e2
0024h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0029h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
002ah mov eax,4                     ; MOV(Mov_r32_imm32) [EAX,4h:imm32]                    encoding(5 bytes) = b8 04 00 00 00
002fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0030h mov eax,8                     ; MOV(Mov_r32_imm32) [EAX,8h:imm32]                    encoding(5 bytes) = b8 08 00 00 00
0035h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0036h mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
003bh jmp short 0046h               ; JMP(Jmp_rel8_64) [46h:jmp64]                         encoding(2 bytes) = eb 09
003dh mov eax,20h                   ; MOV(Mov_r32_imm32) [EAX,20h:imm32]                   encoding(5 bytes) = b8 20 00 00 00
0042h jmp short 0046h               ; JMP(Jmp_rel8_64) [46h:jmp64]                         encoding(2 bytes) = eb 02
0044h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0046h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> ChoiceSwitchInlineBytes => new byte[71]{0x0F,0x1F,0x44,0x00,0x00,0xFF,0xCA,0x83,0xFA,0x04,0x77,0x38,0x8B,0xC2,0x48,0x8D,0x15,0x33,0x00,0x00,0x00,0x8B,0x14,0x82,0x48,0x8D,0x0D,0xE6,0xFF,0xFF,0xFF,0x48,0x03,0xD1,0xFF,0xE2,0xB8,0x01,0x00,0x00,0x00,0xC3,0xB8,0x04,0x00,0x00,0x00,0xC3,0xB8,0x08,0x00,0x00,0x00,0xC3,0xB8,0x10,0x00,0x00,0x00,0xEB,0x09,0xB8,0x20,0x00,0x00,0x00,0xEB,0x02,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int ChoiceIfElse5Inline(int x)
; location: [7FFDDABF2A00h, 7FFDDABF2A40h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
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
; function: TypeCode:int GetTypeCodeInt32()
; location: [7FFDDABF2A60h, 7FFDDABF2B91h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0007h mov rcx,7FFDDABA8F08h         ; MOV(Mov_r64_imm64) [RCX,7ffddaba8f08h:imm64]         encoding(10 bytes) = 48 b9 08 8f ba da fd 7f 00 00
0011h call 7FFE3A69B730h            ; CALL(Call_rel32_64) [5FAA8CD0h:jmp64]                encoding(5 bytes) = e8 ba 8c aa 5f
0016h mov rsi,rax                   ; MOV(Mov_r64_rm64) [RSI,RAX]                          encoding(3 bytes) = 48 8b f0
0019h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
001ch call 7FFDDABD0F50h            ; CALL(Call_rel32_64) [FFFFFFFFFFFDE4F0h:jmp64]        encoding(5 bytes) = e8 cf e4 fd ff
0021h cmp eax,7                     ; CMP(Cmp_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 f8 07
0024h jne short 0030h               ; JNE(Jne_rel8_64) [30h:jmp64]                         encoding(2 bytes) = 75 0a
0026h mov eax,7                     ; MOV(Mov_r32_imm32) [EAX,7h:imm32]                    encoding(5 bytes) = b8 07 00 00 00
002bh jmp near ptr 00d1h            ; JMP(Jmp_rel32_64) [D1h:jmp64]                        encoding(5 bytes) = e9 a1 00 00 00
0030h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0033h call 7FFDDABD0F50h            ; CALL(Call_rel32_64) [FFFFFFFFFFFDE4F0h:jmp64]        encoding(5 bytes) = e8 b8 e4 fd ff
0038h cmp eax,9                     ; CMP(Cmp_rm32_imm8) [EAX,9h:imm32]                    encoding(3 bytes) = 83 f8 09
003bh jne short 0047h               ; JNE(Jne_rel8_64) [47h:jmp64]                         encoding(2 bytes) = 75 0a
003dh mov eax,9                     ; MOV(Mov_r32_imm32) [EAX,9h:imm32]                    encoding(5 bytes) = b8 09 00 00 00
0042h jmp near ptr 00d1h            ; JMP(Jmp_rel32_64) [D1h:jmp64]                        encoding(5 bytes) = e9 8a 00 00 00
0047h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
004ah call 7FFDDABD0F50h            ; CALL(Call_rel32_64) [FFFFFFFFFFFDE4F0h:jmp64]        encoding(5 bytes) = e8 a1 e4 fd ff
004fh cmp eax,0Bh                   ; CMP(Cmp_rm32_imm8) [EAX,bh:imm32]                    encoding(3 bytes) = 83 f8 0b
0052h jne short 005bh               ; JNE(Jne_rel8_64) [5Bh:jmp64]                         encoding(2 bytes) = 75 07
0054h mov eax,0Bh                   ; MOV(Mov_r32_imm32) [EAX,bh:imm32]                    encoding(5 bytes) = b8 0b 00 00 00
0059h jmp short 00d1h               ; JMP(Jmp_rel8_64) [D1h:jmp64]                         encoding(2 bytes) = eb 76
005bh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
005eh call 7FFDDABD0F50h            ; CALL(Call_rel32_64) [FFFFFFFFFFFDE4F0h:jmp64]        encoding(5 bytes) = e8 8d e4 fd ff
0063h cmp eax,0Ch                   ; CMP(Cmp_rm32_imm8) [EAX,ch:imm32]                    encoding(3 bytes) = 83 f8 0c
0066h jne short 006fh               ; JNE(Jne_rel8_64) [6Fh:jmp64]                         encoding(2 bytes) = 75 07
0068h mov eax,0Ch                   ; MOV(Mov_r32_imm32) [EAX,ch:imm32]                    encoding(5 bytes) = b8 0c 00 00 00
006dh jmp short 00d1h               ; JMP(Jmp_rel8_64) [D1h:jmp64]                         encoding(2 bytes) = eb 62
006fh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0072h call 7FFDDABD0F50h            ; CALL(Call_rel32_64) [FFFFFFFFFFFDE4F0h:jmp64]        encoding(5 bytes) = e8 79 e4 fd ff
0077h cmp eax,0Ah                   ; CMP(Cmp_rm32_imm8) [EAX,ah:imm32]                    encoding(3 bytes) = 83 f8 0a
007ah jne short 0083h               ; JNE(Jne_rel8_64) [83h:jmp64]                         encoding(2 bytes) = 75 07
007ch mov eax,0Ah                   ; MOV(Mov_r32_imm32) [EAX,ah:imm32]                    encoding(5 bytes) = b8 0a 00 00 00
0081h jmp short 00d1h               ; JMP(Jmp_rel8_64) [D1h:jmp64]                         encoding(2 bytes) = eb 4e
0083h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0086h call 7FFDDABD0F50h            ; CALL(Call_rel32_64) [FFFFFFFFFFFDE4F0h:jmp64]        encoding(5 bytes) = e8 65 e4 fd ff
008bh cmp eax,8                     ; CMP(Cmp_rm32_imm8) [EAX,8h:imm32]                    encoding(3 bytes) = 83 f8 08
008eh jne short 0097h               ; JNE(Jne_rel8_64) [97h:jmp64]                         encoding(2 bytes) = 75 07
0090h mov eax,8                     ; MOV(Mov_r32_imm32) [EAX,8h:imm32]                    encoding(5 bytes) = b8 08 00 00 00
0095h jmp short 00d1h               ; JMP(Jmp_rel8_64) [D1h:jmp64]                         encoding(2 bytes) = eb 3a
0097h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
009ah call 7FFDDABD0F50h            ; CALL(Call_rel32_64) [FFFFFFFFFFFDE4F0h:jmp64]        encoding(5 bytes) = e8 51 e4 fd ff
009fh cmp eax,0Dh                   ; CMP(Cmp_rm32_imm8) [EAX,dh:imm32]                    encoding(3 bytes) = 83 f8 0d
00a2h jne short 00abh               ; JNE(Jne_rel8_64) [ABh:jmp64]                         encoding(2 bytes) = 75 07
00a4h mov eax,0Dh                   ; MOV(Mov_r32_imm32) [EAX,dh:imm32]                    encoding(5 bytes) = b8 0d 00 00 00
00a9h jmp short 00d1h               ; JMP(Jmp_rel8_64) [D1h:jmp64]                         encoding(2 bytes) = eb 26
00abh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
00aeh call 7FFDDABD0F50h            ; CALL(Call_rel32_64) [FFFFFFFFFFFDE4F0h:jmp64]        encoding(5 bytes) = e8 3d e4 fd ff
00b3h cmp eax,6                     ; CMP(Cmp_rm32_imm8) [EAX,6h:imm32]                    encoding(3 bytes) = 83 f8 06
00b6h jne short 00bfh               ; JNE(Jne_rel8_64) [BFh:jmp64]                         encoding(2 bytes) = 75 07
00b8h mov eax,6                     ; MOV(Mov_r32_imm32) [EAX,6h:imm32]                    encoding(5 bytes) = b8 06 00 00 00
00bdh jmp short 00d1h               ; JMP(Jmp_rel8_64) [D1h:jmp64]                         encoding(2 bytes) = eb 12
00bfh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
00c2h call 7FFDDABD0F50h            ; CALL(Call_rel32_64) [FFFFFFFFFFFDE4F0h:jmp64]        encoding(5 bytes) = e8 29 e4 fd ff
00c7h cmp eax,5                     ; CMP(Cmp_rm32_imm8) [EAX,5h:imm32]                    encoding(3 bytes) = 83 f8 05
00cah jne short 00d9h               ; JNE(Jne_rel8_64) [D9h:jmp64]                         encoding(2 bytes) = 75 0d
00cch mov eax,5                     ; MOV(Mov_r32_imm32) [EAX,5h:imm32]                    encoding(5 bytes) = b8 05 00 00 00
00d1h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
00d5h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00d6h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00d7h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00d8h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00d9h mov esi,98h                   ; MOV(Mov_r32_imm32) [ESI,98h:imm32]                   encoding(5 bytes) = be 98 00 00 00
00deh mov edi,1                     ; MOV(Mov_r32_imm32) [EDI,1h:imm32]                    encoding(5 bytes) = bf 01 00 00 00
00e3h mov ecx,288h                  ; MOV(Mov_r32_imm32) [ECX,288h:imm32]                  encoding(5 bytes) = b9 88 02 00 00
00e8h mov rdx,7FFDDAC76680h         ; MOV(Mov_r64_imm64) [RDX,7ffddac76680h:imm64]         encoding(10 bytes) = 48 ba 80 66 c7 da fd 7f 00 00
00f2h call 7FFE3A81F6E0h            ; CALL(Call_rel32_64) [5FC2CC80h:jmp64]                encoding(5 bytes) = e8 89 cb c2 5f
00f7h mov rbx,rax                   ; MOV(Mov_r64_rm64) [RBX,RAX]                          encoding(3 bytes) = 48 8b d8
00fah mov ecx,288h                  ; MOV(Mov_r32_imm32) [ECX,288h:imm32]                  encoding(5 bytes) = b9 88 02 00 00
00ffh mov rdx,7FFDDAC76680h         ; MOV(Mov_r64_imm64) [RDX,7ffddac76680h:imm64]         encoding(10 bytes) = 48 ba 80 66 c7 da fd 7f 00 00
0109h call 7FFE3A81F6E0h            ; CALL(Call_rel32_64) [5FC2CC80h:jmp64]                encoding(5 bytes) = e8 72 cb c2 5f
010eh mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0111h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0116h mov [rcx],dil                 ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),DIL]           encoding(3 bytes) = 40 88 39
0119h mov [rcx+4],esi               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),ESI]        encoding(3 bytes) = 89 71 04
011ch mov rcx,rbx                   ; MOV(Mov_r64_rm64) [RCX,RBX]                          encoding(3 bytes) = 48 8b cb
011fh mov r8,[rsp+28h]              ; MOV(Mov_r64_rm64) [R8,mem(64u,RSP:br,SS:sr)]         encoding(5 bytes) = 4c 8b 44 24 28
0124h call 7FFDDABF2068h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF608h:jmp64]        encoding(5 bytes) = e8 df f4 ff ff
0129h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
012ch call 7FFE3A6AA4F0h            ; CALL(Call_rel32_64) [5FAB7A90h:jmp64]                encoding(5 bytes) = e8 5f 79 ab 5f
0131h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> GetTypeCodeInt32Bytes => new byte[306]{0x57,0x56,0x53,0x48,0x83,0xEC,0x30,0x48,0xB9,0x08,0x8F,0xBA,0xDA,0xFD,0x7F,0x00,0x00,0xE8,0xBA,0x8C,0xAA,0x5F,0x48,0x8B,0xF0,0x48,0x8B,0xCE,0xE8,0xCF,0xE4,0xFD,0xFF,0x83,0xF8,0x07,0x75,0x0A,0xB8,0x07,0x00,0x00,0x00,0xE9,0xA1,0x00,0x00,0x00,0x48,0x8B,0xCE,0xE8,0xB8,0xE4,0xFD,0xFF,0x83,0xF8,0x09,0x75,0x0A,0xB8,0x09,0x00,0x00,0x00,0xE9,0x8A,0x00,0x00,0x00,0x48,0x8B,0xCE,0xE8,0xA1,0xE4,0xFD,0xFF,0x83,0xF8,0x0B,0x75,0x07,0xB8,0x0B,0x00,0x00,0x00,0xEB,0x76,0x48,0x8B,0xCE,0xE8,0x8D,0xE4,0xFD,0xFF,0x83,0xF8,0x0C,0x75,0x07,0xB8,0x0C,0x00,0x00,0x00,0xEB,0x62,0x48,0x8B,0xCE,0xE8,0x79,0xE4,0xFD,0xFF,0x83,0xF8,0x0A,0x75,0x07,0xB8,0x0A,0x00,0x00,0x00,0xEB,0x4E,0x48,0x8B,0xCE,0xE8,0x65,0xE4,0xFD,0xFF,0x83,0xF8,0x08,0x75,0x07,0xB8,0x08,0x00,0x00,0x00,0xEB,0x3A,0x48,0x8B,0xCE,0xE8,0x51,0xE4,0xFD,0xFF,0x83,0xF8,0x0D,0x75,0x07,0xB8,0x0D,0x00,0x00,0x00,0xEB,0x26,0x48,0x8B,0xCE,0xE8,0x3D,0xE4,0xFD,0xFF,0x83,0xF8,0x06,0x75,0x07,0xB8,0x06,0x00,0x00,0x00,0xEB,0x12,0x48,0x8B,0xCE,0xE8,0x29,0xE4,0xFD,0xFF,0x83,0xF8,0x05,0x75,0x0D,0xB8,0x05,0x00,0x00,0x00,0x48,0x83,0xC4,0x30,0x5B,0x5E,0x5F,0xC3,0xBE,0x98,0x00,0x00,0x00,0xBF,0x01,0x00,0x00,0x00,0xB9,0x88,0x02,0x00,0x00,0x48,0xBA,0x80,0x66,0xC7,0xDA,0xFD,0x7F,0x00,0x00,0xE8,0x89,0xCB,0xC2,0x5F,0x48,0x8B,0xD8,0xB9,0x88,0x02,0x00,0x00,0x48,0xBA,0x80,0x66,0xC7,0xDA,0xFD,0x7F,0x00,0x00,0xE8,0x72,0xCB,0xC2,0x5F,0x48,0x8B,0xD0,0x48,0x8D,0x4C,0x24,0x28,0x40,0x88,0x39,0x89,0x71,0x04,0x48,0x8B,0xCB,0x4C,0x8B,0x44,0x24,0x28,0xE8,0xDF,0xF4,0xFF,0xFF,0x48,0x8B,0xC8,0xE8,0x5F,0x79,0xAB,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: TypeCode:int GetTypeCodeUInt32()
; location: [7FFDDABF2BB0h, 7FFDDABF2CE1h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,30h                   ; SUB(Sub_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 ec 30
0007h mov rcx,7FFDDABA96D8h         ; MOV(Mov_r64_imm64) [RCX,7ffddaba96d8h:imm64]         encoding(10 bytes) = 48 b9 d8 96 ba da fd 7f 00 00
0011h call 7FFE3A69B730h            ; CALL(Call_rel32_64) [5FAA8B80h:jmp64]                encoding(5 bytes) = e8 6a 8b aa 5f
0016h mov rsi,rax                   ; MOV(Mov_r64_rm64) [RSI,RAX]                          encoding(3 bytes) = 48 8b f0
0019h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
001ch call 7FFDDABD0F50h            ; CALL(Call_rel32_64) [FFFFFFFFFFFDE3A0h:jmp64]        encoding(5 bytes) = e8 7f e3 fd ff
0021h cmp eax,7                     ; CMP(Cmp_rm32_imm8) [EAX,7h:imm32]                    encoding(3 bytes) = 83 f8 07
0024h jne short 0030h               ; JNE(Jne_rel8_64) [30h:jmp64]                         encoding(2 bytes) = 75 0a
0026h mov eax,7                     ; MOV(Mov_r32_imm32) [EAX,7h:imm32]                    encoding(5 bytes) = b8 07 00 00 00
002bh jmp near ptr 00d1h            ; JMP(Jmp_rel32_64) [D1h:jmp64]                        encoding(5 bytes) = e9 a1 00 00 00
0030h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0033h call 7FFDDABD0F50h            ; CALL(Call_rel32_64) [FFFFFFFFFFFDE3A0h:jmp64]        encoding(5 bytes) = e8 68 e3 fd ff
0038h cmp eax,9                     ; CMP(Cmp_rm32_imm8) [EAX,9h:imm32]                    encoding(3 bytes) = 83 f8 09
003bh jne short 0047h               ; JNE(Jne_rel8_64) [47h:jmp64]                         encoding(2 bytes) = 75 0a
003dh mov eax,9                     ; MOV(Mov_r32_imm32) [EAX,9h:imm32]                    encoding(5 bytes) = b8 09 00 00 00
0042h jmp near ptr 00d1h            ; JMP(Jmp_rel32_64) [D1h:jmp64]                        encoding(5 bytes) = e9 8a 00 00 00
0047h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
004ah call 7FFDDABD0F50h            ; CALL(Call_rel32_64) [FFFFFFFFFFFDE3A0h:jmp64]        encoding(5 bytes) = e8 51 e3 fd ff
004fh cmp eax,0Bh                   ; CMP(Cmp_rm32_imm8) [EAX,bh:imm32]                    encoding(3 bytes) = 83 f8 0b
0052h jne short 005bh               ; JNE(Jne_rel8_64) [5Bh:jmp64]                         encoding(2 bytes) = 75 07
0054h mov eax,0Bh                   ; MOV(Mov_r32_imm32) [EAX,bh:imm32]                    encoding(5 bytes) = b8 0b 00 00 00
0059h jmp short 00d1h               ; JMP(Jmp_rel8_64) [D1h:jmp64]                         encoding(2 bytes) = eb 76
005bh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
005eh call 7FFDDABD0F50h            ; CALL(Call_rel32_64) [FFFFFFFFFFFDE3A0h:jmp64]        encoding(5 bytes) = e8 3d e3 fd ff
0063h cmp eax,0Ch                   ; CMP(Cmp_rm32_imm8) [EAX,ch:imm32]                    encoding(3 bytes) = 83 f8 0c
0066h jne short 006fh               ; JNE(Jne_rel8_64) [6Fh:jmp64]                         encoding(2 bytes) = 75 07
0068h mov eax,0Ch                   ; MOV(Mov_r32_imm32) [EAX,ch:imm32]                    encoding(5 bytes) = b8 0c 00 00 00
006dh jmp short 00d1h               ; JMP(Jmp_rel8_64) [D1h:jmp64]                         encoding(2 bytes) = eb 62
006fh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0072h call 7FFDDABD0F50h            ; CALL(Call_rel32_64) [FFFFFFFFFFFDE3A0h:jmp64]        encoding(5 bytes) = e8 29 e3 fd ff
0077h cmp eax,0Ah                   ; CMP(Cmp_rm32_imm8) [EAX,ah:imm32]                    encoding(3 bytes) = 83 f8 0a
007ah jne short 0083h               ; JNE(Jne_rel8_64) [83h:jmp64]                         encoding(2 bytes) = 75 07
007ch mov eax,0Ah                   ; MOV(Mov_r32_imm32) [EAX,ah:imm32]                    encoding(5 bytes) = b8 0a 00 00 00
0081h jmp short 00d1h               ; JMP(Jmp_rel8_64) [D1h:jmp64]                         encoding(2 bytes) = eb 4e
0083h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0086h call 7FFDDABD0F50h            ; CALL(Call_rel32_64) [FFFFFFFFFFFDE3A0h:jmp64]        encoding(5 bytes) = e8 15 e3 fd ff
008bh cmp eax,8                     ; CMP(Cmp_rm32_imm8) [EAX,8h:imm32]                    encoding(3 bytes) = 83 f8 08
008eh jne short 0097h               ; JNE(Jne_rel8_64) [97h:jmp64]                         encoding(2 bytes) = 75 07
0090h mov eax,8                     ; MOV(Mov_r32_imm32) [EAX,8h:imm32]                    encoding(5 bytes) = b8 08 00 00 00
0095h jmp short 00d1h               ; JMP(Jmp_rel8_64) [D1h:jmp64]                         encoding(2 bytes) = eb 3a
0097h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
009ah call 7FFDDABD0F50h            ; CALL(Call_rel32_64) [FFFFFFFFFFFDE3A0h:jmp64]        encoding(5 bytes) = e8 01 e3 fd ff
009fh cmp eax,0Dh                   ; CMP(Cmp_rm32_imm8) [EAX,dh:imm32]                    encoding(3 bytes) = 83 f8 0d
00a2h jne short 00abh               ; JNE(Jne_rel8_64) [ABh:jmp64]                         encoding(2 bytes) = 75 07
00a4h mov eax,0Dh                   ; MOV(Mov_r32_imm32) [EAX,dh:imm32]                    encoding(5 bytes) = b8 0d 00 00 00
00a9h jmp short 00d1h               ; JMP(Jmp_rel8_64) [D1h:jmp64]                         encoding(2 bytes) = eb 26
00abh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
00aeh call 7FFDDABD0F50h            ; CALL(Call_rel32_64) [FFFFFFFFFFFDE3A0h:jmp64]        encoding(5 bytes) = e8 ed e2 fd ff
00b3h cmp eax,6                     ; CMP(Cmp_rm32_imm8) [EAX,6h:imm32]                    encoding(3 bytes) = 83 f8 06
00b6h jne short 00bfh               ; JNE(Jne_rel8_64) [BFh:jmp64]                         encoding(2 bytes) = 75 07
00b8h mov eax,6                     ; MOV(Mov_r32_imm32) [EAX,6h:imm32]                    encoding(5 bytes) = b8 06 00 00 00
00bdh jmp short 00d1h               ; JMP(Jmp_rel8_64) [D1h:jmp64]                         encoding(2 bytes) = eb 12
00bfh mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
00c2h call 7FFDDABD0F50h            ; CALL(Call_rel32_64) [FFFFFFFFFFFDE3A0h:jmp64]        encoding(5 bytes) = e8 d9 e2 fd ff
00c7h cmp eax,5                     ; CMP(Cmp_rm32_imm8) [EAX,5h:imm32]                    encoding(3 bytes) = 83 f8 05
00cah jne short 00d9h               ; JNE(Jne_rel8_64) [D9h:jmp64]                         encoding(2 bytes) = 75 0d
00cch mov eax,5                     ; MOV(Mov_r32_imm32) [EAX,5h:imm32]                    encoding(5 bytes) = b8 05 00 00 00
00d1h add rsp,30h                   ; ADD(Add_rm64_imm8) [RSP,30h:imm64]                   encoding(4 bytes) = 48 83 c4 30
00d5h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00d6h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00d7h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00d8h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00d9h mov esi,98h                   ; MOV(Mov_r32_imm32) [ESI,98h:imm32]                   encoding(5 bytes) = be 98 00 00 00
00deh mov edi,1                     ; MOV(Mov_r32_imm32) [EDI,1h:imm32]                    encoding(5 bytes) = bf 01 00 00 00
00e3h mov ecx,288h                  ; MOV(Mov_r32_imm32) [ECX,288h:imm32]                  encoding(5 bytes) = b9 88 02 00 00
00e8h mov rdx,7FFDDAC76680h         ; MOV(Mov_r64_imm64) [RDX,7ffddac76680h:imm64]         encoding(10 bytes) = 48 ba 80 66 c7 da fd 7f 00 00
00f2h call 7FFE3A81F6E0h            ; CALL(Call_rel32_64) [5FC2CB30h:jmp64]                encoding(5 bytes) = e8 39 ca c2 5f
00f7h mov rbx,rax                   ; MOV(Mov_r64_rm64) [RBX,RAX]                          encoding(3 bytes) = 48 8b d8
00fah mov ecx,288h                  ; MOV(Mov_r32_imm32) [ECX,288h:imm32]                  encoding(5 bytes) = b9 88 02 00 00
00ffh mov rdx,7FFDDAC76680h         ; MOV(Mov_r64_imm64) [RDX,7ffddac76680h:imm64]         encoding(10 bytes) = 48 ba 80 66 c7 da fd 7f 00 00
0109h call 7FFE3A81F6E0h            ; CALL(Call_rel32_64) [5FC2CB30h:jmp64]                encoding(5 bytes) = e8 22 ca c2 5f
010eh mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0111h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
0116h mov [rcx],dil                 ; MOV(Mov_rm8_r8) [mem(8u,RCX:br,DS:sr),DIL]           encoding(3 bytes) = 40 88 39
0119h mov [rcx+4],esi               ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,DS:sr),ESI]        encoding(3 bytes) = 89 71 04
011ch mov rcx,rbx                   ; MOV(Mov_r64_rm64) [RCX,RBX]                          encoding(3 bytes) = 48 8b cb
011fh mov r8,[rsp+28h]              ; MOV(Mov_r64_rm64) [R8,mem(64u,RSP:br,SS:sr)]         encoding(5 bytes) = 4c 8b 44 24 28
0124h call 7FFDDABF2580h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF9D0h:jmp64]        encoding(5 bytes) = e8 a7 f8 ff ff
0129h mov rcx,rax                   ; MOV(Mov_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 8b c8
012ch call 7FFE3A6AA4F0h            ; CALL(Call_rel32_64) [5FAB7940h:jmp64]                encoding(5 bytes) = e8 0f 78 ab 5f
0131h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> GetTypeCodeUInt32Bytes => new byte[306]{0x57,0x56,0x53,0x48,0x83,0xEC,0x30,0x48,0xB9,0xD8,0x96,0xBA,0xDA,0xFD,0x7F,0x00,0x00,0xE8,0x6A,0x8B,0xAA,0x5F,0x48,0x8B,0xF0,0x48,0x8B,0xCE,0xE8,0x7F,0xE3,0xFD,0xFF,0x83,0xF8,0x07,0x75,0x0A,0xB8,0x07,0x00,0x00,0x00,0xE9,0xA1,0x00,0x00,0x00,0x48,0x8B,0xCE,0xE8,0x68,0xE3,0xFD,0xFF,0x83,0xF8,0x09,0x75,0x0A,0xB8,0x09,0x00,0x00,0x00,0xE9,0x8A,0x00,0x00,0x00,0x48,0x8B,0xCE,0xE8,0x51,0xE3,0xFD,0xFF,0x83,0xF8,0x0B,0x75,0x07,0xB8,0x0B,0x00,0x00,0x00,0xEB,0x76,0x48,0x8B,0xCE,0xE8,0x3D,0xE3,0xFD,0xFF,0x83,0xF8,0x0C,0x75,0x07,0xB8,0x0C,0x00,0x00,0x00,0xEB,0x62,0x48,0x8B,0xCE,0xE8,0x29,0xE3,0xFD,0xFF,0x83,0xF8,0x0A,0x75,0x07,0xB8,0x0A,0x00,0x00,0x00,0xEB,0x4E,0x48,0x8B,0xCE,0xE8,0x15,0xE3,0xFD,0xFF,0x83,0xF8,0x08,0x75,0x07,0xB8,0x08,0x00,0x00,0x00,0xEB,0x3A,0x48,0x8B,0xCE,0xE8,0x01,0xE3,0xFD,0xFF,0x83,0xF8,0x0D,0x75,0x07,0xB8,0x0D,0x00,0x00,0x00,0xEB,0x26,0x48,0x8B,0xCE,0xE8,0xED,0xE2,0xFD,0xFF,0x83,0xF8,0x06,0x75,0x07,0xB8,0x06,0x00,0x00,0x00,0xEB,0x12,0x48,0x8B,0xCE,0xE8,0xD9,0xE2,0xFD,0xFF,0x83,0xF8,0x05,0x75,0x0D,0xB8,0x05,0x00,0x00,0x00,0x48,0x83,0xC4,0x30,0x5B,0x5E,0x5F,0xC3,0xBE,0x98,0x00,0x00,0x00,0xBF,0x01,0x00,0x00,0x00,0xB9,0x88,0x02,0x00,0x00,0x48,0xBA,0x80,0x66,0xC7,0xDA,0xFD,0x7F,0x00,0x00,0xE8,0x39,0xCA,0xC2,0x5F,0x48,0x8B,0xD8,0xB9,0x88,0x02,0x00,0x00,0x48,0xBA,0x80,0x66,0xC7,0xDA,0xFD,0x7F,0x00,0x00,0xE8,0x22,0xCA,0xC2,0x5F,0x48,0x8B,0xD0,0x48,0x8D,0x4C,0x24,0x28,0x40,0x88,0x39,0x89,0x71,0x04,0x48,0x8B,0xCB,0x4C,0x8B,0x44,0x24,0x28,0xE8,0xA7,0xF8,0xFF,0xFF,0x48,0x8B,0xC8,0xE8,0x0F,0x78,0xAB,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int CheckMatches()
; location: [7FFDDABF3510h, 7FFDDABF351Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,3FFh                  ; MOV(Mov_r32_imm32) [EAX,3ffh:imm32]                  encoding(5 bytes) = b8 ff 03 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> CheckMatchesBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0x03,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int ChoiceIfElse10Inline(int x)
; location: [7FFDDABF3530h, 7FFDDABF35ACh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
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
; static ReadOnlySpan<byte> ChoiceIfElse10InlineBytes => new byte[125]{0x0F,0x1F,0x44,0x00,0x00,0x83,0xFA,0x01,0x75,0x06,0xB8,0x01,0x00,0x00,0x00,0xC3,0x83,0xFA,0x02,0x75,0x06,0xB8,0x04,0x00,0x00,0x00,0xC3,0x83,0xFA,0x03,0x75,0x06,0xB8,0x08,0x00,0x00,0x00,0xC3,0x83,0xFA,0x04,0x75,0x07,0xB8,0x10,0x00,0x00,0x00,0xEB,0x4A,0x83,0xFA,0x05,0x75,0x07,0xB8,0x20,0x00,0x00,0x00,0xEB,0x3E,0x83,0xFA,0x06,0x75,0x07,0xB8,0x40,0x00,0x00,0x00,0xEB,0x32,0x83,0xFA,0x07,0x75,0x07,0xB8,0x80,0x00,0x00,0x00,0xEB,0x26,0x83,0xFA,0x08,0x75,0x07,0xB8,0x00,0x01,0x00,0x00,0xEB,0x1A,0x83,0xFA,0x09,0x75,0x07,0xB8,0x00,0x02,0x00,0x00,0xEB,0x0E,0x83,0xFA,0x0A,0x75,0x07,0xB8,0x00,0x04,0x00,0x00,0xEB,0x02,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int CallChoiceSwitchInline(int x)
; location: [7FFDDABF35C0h, 7FFDDABF35CFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FFDDABF2990h         ; MOV(Mov_r64_imm64) [RAX,7ffddabf2990h:imm64]         encoding(10 bytes) = 48 b8 90 29 bf da fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> CallChoiceSwitchInlineBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x90,0x29,0xBF,0xDA,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int CallChoiceIfElse5Inline(int x)
; location: [7FFDDABF35F0h, 7FFDDABF3633h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0008h jne short 0011h               ; JNE(Jne_rel8_64) [11h:jmp64]                         encoding(2 bytes) = 75 07
000ah mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000fh jmp short 0043h               ; JMP(Jmp_rel8_64) [43h:jmp64]                         encoding(2 bytes) = eb 32
0011h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
0014h jne short 001dh               ; JNE(Jne_rel8_64) [1Dh:jmp64]                         encoding(2 bytes) = 75 07
0016h mov eax,4                     ; MOV(Mov_r32_imm32) [EAX,4h:imm32]                    encoding(5 bytes) = b8 04 00 00 00
001bh jmp short 0043h               ; JMP(Jmp_rel8_64) [43h:jmp64]                         encoding(2 bytes) = eb 26
001dh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0020h jne short 0029h               ; JNE(Jne_rel8_64) [29h:jmp64]                         encoding(2 bytes) = 75 07
0022h mov eax,8                     ; MOV(Mov_r32_imm32) [EAX,8h:imm32]                    encoding(5 bytes) = b8 08 00 00 00
0027h jmp short 0043h               ; JMP(Jmp_rel8_64) [43h:jmp64]                         encoding(2 bytes) = eb 1a
0029h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
002ch jne short 0035h               ; JNE(Jne_rel8_64) [35h:jmp64]                         encoding(2 bytes) = 75 07
002eh mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
0033h jmp short 0043h               ; JMP(Jmp_rel8_64) [43h:jmp64]                         encoding(2 bytes) = eb 0e
0035h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
0038h jne short 0041h               ; JNE(Jne_rel8_64) [41h:jmp64]                         encoding(2 bytes) = 75 07
003ah mov eax,20h                   ; MOV(Mov_r32_imm32) [EAX,20h:imm32]                   encoding(5 bytes) = b8 20 00 00 00
003fh jmp short 0043h               ; JMP(Jmp_rel8_64) [43h:jmp64]                         encoding(2 bytes) = eb 02
0041h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0043h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> CallChoiceIfElse5InlineBytes => new byte[68]{0x0F,0x1F,0x44,0x00,0x00,0x83,0xFA,0x01,0x75,0x07,0xB8,0x01,0x00,0x00,0x00,0xEB,0x32,0x83,0xFA,0x02,0x75,0x07,0xB8,0x04,0x00,0x00,0x00,0xEB,0x26,0x83,0xFA,0x03,0x75,0x07,0xB8,0x08,0x00,0x00,0x00,0xEB,0x1A,0x83,0xFA,0x04,0x75,0x07,0xB8,0x10,0x00,0x00,0x00,0xEB,0x0E,0x83,0xFA,0x05,0x75,0x07,0xB8,0x20,0x00,0x00,0x00,0xEB,0x02,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int CallChoiceIfElse10Inline(int x)
; location: [7FFDDABF3650h, 7FFDDABF36CFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0008h jne short 0011h               ; JNE(Jne_rel8_64) [11h:jmp64]                         encoding(2 bytes) = 75 07
000ah mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000fh jmp short 007fh               ; JMP(Jmp_rel8_64) [7Fh:jmp64]                         encoding(2 bytes) = eb 6e
0011h cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
0014h jne short 001dh               ; JNE(Jne_rel8_64) [1Dh:jmp64]                         encoding(2 bytes) = 75 07
0016h mov eax,4                     ; MOV(Mov_r32_imm32) [EAX,4h:imm32]                    encoding(5 bytes) = b8 04 00 00 00
001bh jmp short 007fh               ; JMP(Jmp_rel8_64) [7Fh:jmp64]                         encoding(2 bytes) = eb 62
001dh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0020h jne short 0029h               ; JNE(Jne_rel8_64) [29h:jmp64]                         encoding(2 bytes) = 75 07
0022h mov eax,8                     ; MOV(Mov_r32_imm32) [EAX,8h:imm32]                    encoding(5 bytes) = b8 08 00 00 00
0027h jmp short 007fh               ; JMP(Jmp_rel8_64) [7Fh:jmp64]                         encoding(2 bytes) = eb 56
0029h cmp edx,4                     ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]                    encoding(3 bytes) = 83 fa 04
002ch jne short 0035h               ; JNE(Jne_rel8_64) [35h:jmp64]                         encoding(2 bytes) = 75 07
002eh mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
0033h jmp short 007fh               ; JMP(Jmp_rel8_64) [7Fh:jmp64]                         encoding(2 bytes) = eb 4a
0035h cmp edx,5                     ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]                    encoding(3 bytes) = 83 fa 05
0038h jne short 0041h               ; JNE(Jne_rel8_64) [41h:jmp64]                         encoding(2 bytes) = 75 07
003ah mov eax,20h                   ; MOV(Mov_r32_imm32) [EAX,20h:imm32]                   encoding(5 bytes) = b8 20 00 00 00
003fh jmp short 007fh               ; JMP(Jmp_rel8_64) [7Fh:jmp64]                         encoding(2 bytes) = eb 3e
0041h cmp edx,6                     ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]                    encoding(3 bytes) = 83 fa 06
0044h jne short 004dh               ; JNE(Jne_rel8_64) [4Dh:jmp64]                         encoding(2 bytes) = 75 07
0046h mov eax,40h                   ; MOV(Mov_r32_imm32) [EAX,40h:imm32]                   encoding(5 bytes) = b8 40 00 00 00
004bh jmp short 007fh               ; JMP(Jmp_rel8_64) [7Fh:jmp64]                         encoding(2 bytes) = eb 32
004dh cmp edx,7                     ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 fa 07
0050h jne short 0059h               ; JNE(Jne_rel8_64) [59h:jmp64]                         encoding(2 bytes) = 75 07
0052h mov eax,80h                   ; MOV(Mov_r32_imm32) [EAX,80h:imm32]                   encoding(5 bytes) = b8 80 00 00 00
0057h jmp short 007fh               ; JMP(Jmp_rel8_64) [7Fh:jmp64]                         encoding(2 bytes) = eb 26
0059h cmp edx,8                     ; CMP(Cmp_rm32_imm8) [EDX,8h:imm32]                    encoding(3 bytes) = 83 fa 08
005ch jne short 0065h               ; JNE(Jne_rel8_64) [65h:jmp64]                         encoding(2 bytes) = 75 07
005eh mov eax,100h                  ; MOV(Mov_r32_imm32) [EAX,100h:imm32]                  encoding(5 bytes) = b8 00 01 00 00
0063h jmp short 007fh               ; JMP(Jmp_rel8_64) [7Fh:jmp64]                         encoding(2 bytes) = eb 1a
0065h cmp edx,9                     ; CMP(Cmp_rm32_imm8) [EDX,9h:imm32]                    encoding(3 bytes) = 83 fa 09
0068h jne short 0071h               ; JNE(Jne_rel8_64) [71h:jmp64]                         encoding(2 bytes) = 75 07
006ah mov eax,200h                  ; MOV(Mov_r32_imm32) [EAX,200h:imm32]                  encoding(5 bytes) = b8 00 02 00 00
006fh jmp short 007fh               ; JMP(Jmp_rel8_64) [7Fh:jmp64]                         encoding(2 bytes) = eb 0e
0071h cmp edx,0Ah                   ; CMP(Cmp_rm32_imm8) [EDX,ah:imm32]                    encoding(3 bytes) = 83 fa 0a
0074h jne short 007dh               ; JNE(Jne_rel8_64) [7Dh:jmp64]                         encoding(2 bytes) = 75 07
0076h mov eax,400h                  ; MOV(Mov_r32_imm32) [EAX,400h:imm32]                  encoding(5 bytes) = b8 00 04 00 00
007bh jmp short 007fh               ; JMP(Jmp_rel8_64) [7Fh:jmp64]                         encoding(2 bytes) = eb 02
007dh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
007fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> CallChoiceIfElse10InlineBytes => new byte[128]{0x0F,0x1F,0x44,0x00,0x00,0x83,0xFA,0x01,0x75,0x07,0xB8,0x01,0x00,0x00,0x00,0xEB,0x6E,0x83,0xFA,0x02,0x75,0x07,0xB8,0x04,0x00,0x00,0x00,0xEB,0x62,0x83,0xFA,0x03,0x75,0x07,0xB8,0x08,0x00,0x00,0x00,0xEB,0x56,0x83,0xFA,0x04,0x75,0x07,0xB8,0x10,0x00,0x00,0x00,0xEB,0x4A,0x83,0xFA,0x05,0x75,0x07,0xB8,0x20,0x00,0x00,0x00,0xEB,0x3E,0x83,0xFA,0x06,0x75,0x07,0xB8,0x40,0x00,0x00,0x00,0xEB,0x32,0x83,0xFA,0x07,0x75,0x07,0xB8,0x80,0x00,0x00,0x00,0xEB,0x26,0x83,0xFA,0x08,0x75,0x07,0xB8,0x00,0x01,0x00,0x00,0xEB,0x1A,0x83,0xFA,0x09,0x75,0x07,0xB8,0x00,0x02,0x00,0x00,0xEB,0x0E,0x83,0xFA,0x0A,0x75,0x07,0xB8,0x00,0x04,0x00,0x00,0xEB,0x02,0x33,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> ReadU8Data(int count)
; location: [7FFDDABF36E0h, 7FFDDABF370Ch]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov eax,r8d                   ; MOV(Mov_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 8b c0
0008h cmp rax,40h                   ; CMP(Cmp_rm64_imm8) [RAX,40h:imm64]                   encoding(4 bytes) = 48 83 f8 40
000ch ja short 0027h                ; JA(Ja_rel8_64) [27h:jmp64]                           encoding(2 bytes) = 77 19
000eh mov rax,12804D6895Ch          ; MOV(Mov_r64_imm64) [RAX,12804d6895ch:imm64]          encoding(10 bytes) = 48 b8 5c 89 d6 04 28 01 00 00
0018h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 02
001bh mov [rdx+8],r8d               ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,DS:sr),R8D]        encoding(4 bytes) = 44 89 42 08
001fh mov rax,rdx                   ; MOV(Mov_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 8b c2
0022h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0027h call 7FFDDABF2280h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFEBA0h:jmp64]        encoding(5 bytes) = e8 74 eb ff ff
002ch int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> ReadU8DataBytes => new byte[45]{0x48,0x83,0xEC,0x28,0x90,0x41,0x8B,0xC0,0x48,0x83,0xF8,0x40,0x77,0x19,0x48,0xB8,0x5C,0x89,0xD6,0x04,0x28,0x01,0x00,0x00,0x48,0x89,0x02,0x44,0x89,0x42,0x08,0x48,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x74,0xEB,0xFF,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<uint> ReadU32Data(int count)
; location: [7FFDDABF3730h, 7FFDDABF3777h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,38h                   ; SUB(Sub_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 ec 38
0006h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0008h mov [rsp+28h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 28
000dh mov [rsp+30h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RAX]        encoding(5 bytes) = 48 89 44 24 30
0012h mov rsi,rdx                   ; MOV(Mov_r64_rm64) [RSI,RDX]                          encoding(3 bytes) = 48 8b f2
0015h mov edi,r8d                   ; MOV(Mov_r32_rm32) [EDI,R8D]                          encoding(3 bytes) = 41 8b f8
0018h lea rcx,[rsp+28h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 4c 24 28
001dh call 7FFDDABF28B0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF180h:jmp64]        encoding(5 bytes) = e8 5e f1 ff ff
0022h mov eax,edi                   ; MOV(Mov_r32_rm32) [EAX,EDI]                          encoding(2 bytes) = 8b c7
0024h mov edx,[rsp+30h]             ; MOV(Mov_r32_rm32) [EDX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 54 24 30
0028h cmp rax,rdx                   ; CMP(Cmp_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 3b c2
002bh ja short 0042h                ; JA(Ja_rel8_64) [42h:jmp64]                           encoding(2 bytes) = 77 15
002dh mov rax,[rsp+28h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 28
0032h mov [rsi],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RSI:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 06
0035h mov [rsi+8],edi               ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,DS:sr),EDI]        encoding(3 bytes) = 89 7e 08
0038h mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
003bh add rsp,38h                   ; ADD(Add_rm64_imm8) [RSP,38h:imm64]                   encoding(4 bytes) = 48 83 c4 38
003fh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0040h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0041h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
0042h call 7FFDDABF2280h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFEB50h:jmp64]        encoding(5 bytes) = e8 09 eb ff ff
0047h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> ReadU32DataBytes => new byte[72]{0x57,0x56,0x48,0x83,0xEC,0x38,0x33,0xC0,0x48,0x89,0x44,0x24,0x28,0x48,0x89,0x44,0x24,0x30,0x48,0x8B,0xF2,0x41,0x8B,0xF8,0x48,0x8D,0x4C,0x24,0x28,0xE8,0x5E,0xF1,0xFF,0xFF,0x8B,0xC7,0x8B,0x54,0x24,0x30,0x48,0x3B,0xC2,0x77,0x15,0x48,0x8B,0x44,0x24,0x28,0x48,0x89,0x06,0x89,0x7E,0x08,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x38,0x5E,0x5F,0xC3,0xE8,0x09,0xEB,0xFF,0xFF,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void VoidReturn()
; location: [7FFDDABF3790h, 7FFDDABF37ACh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rcx,12814F43060h          ; MOV(Mov_r64_imm64) [RCX,12814f43060h:imm64]          encoding(10 bytes) = 48 b9 60 30 f4 14 28 01 00 00
000fh mov rcx,[rcx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,DS:sr)]        encoding(3 bytes) = 48 8b 09
0012h call 7FFDDABF34E0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFD50h:jmp64]        encoding(5 bytes) = e8 39 fd ff ff
0017h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0018h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> VoidReturnBytes => new byte[29]{0x48,0x83,0xEC,0x28,0x90,0x48,0xB9,0x60,0x30,0xF4,0x14,0x28,0x01,0x00,0x00,0x48,0x8B,0x09,0xE8,0x39,0xFD,0xFF,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int SizeTest()
; location: [7FFDDABF37D0h, 7FFDDABF37DAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,7                     ; MOV(Mov_r32_imm32) [EAX,7h:imm32]                    encoding(5 bytes) = b8 07 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> SizeTestBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x07,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void VoidCalls1()
; location: [7FFDDABF37F0h, 7FFDDABF37FFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FFDDABF3790h         ; MOV(Mov_r64_imm64) [RAX,7ffddabf3790h:imm64]         encoding(10 bytes) = 48 b8 90 37 bf da fd 7f 00 00
000fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> VoidCalls1Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0x90,0x37,0xBF,0xDA,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void VoidCalls2()
; location: [7FFDDABF3820h, 7FFDDABF3842h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
000bh call 7FFDDABF3790h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFF70h:jmp64]        encoding(5 bytes) = e8 60 ff ff ff
0010h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0013h mov rax,7FFDDABF3790h         ; MOV(Mov_r64_imm64) [RAX,7ffddabf3790h:imm64]         encoding(10 bytes) = 48 b8 90 37 bf da fd 7f 00 00
001dh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0021h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0022h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> VoidCalls2Bytes => new byte[37]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0xCE,0xE8,0x60,0xFF,0xFF,0xFF,0x48,0x8B,0xCE,0x48,0xB8,0x90,0x37,0xBF,0xDA,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x20,0x5E,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void VoidCalls3()
; location: [7FFDDABF3860h, 7FFDDABF388Ah]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
000bh call 7FFDDABF3790h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFF30h:jmp64]        encoding(5 bytes) = e8 20 ff ff ff
0010h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0013h call 7FFDDABF3790h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFF30h:jmp64]        encoding(5 bytes) = e8 18 ff ff ff
0018h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
001bh mov rax,7FFDDABF3790h         ; MOV(Mov_r64_imm64) [RAX,7ffddabf3790h:imm64]         encoding(10 bytes) = 48 b8 90 37 bf da fd 7f 00 00
0025h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0029h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
002ah jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> VoidCalls3Bytes => new byte[45]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0xCE,0xE8,0x20,0xFF,0xFF,0xFF,0x48,0x8B,0xCE,0xE8,0x18,0xFF,0xFF,0xFF,0x48,0x8B,0xCE,0x48,0xB8,0x90,0x37,0xBF,0xDA,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x20,0x5E,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void VoidCalls4()
; location: [7FFDDABF38B0h, 7FFDDABF38E2h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
000bh call 7FFDDABF3790h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFEE0h:jmp64]        encoding(5 bytes) = e8 d0 fe ff ff
0010h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0013h call 7FFDDABF3790h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFEE0h:jmp64]        encoding(5 bytes) = e8 c8 fe ff ff
0018h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
001bh call 7FFDDABF3790h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFEE0h:jmp64]        encoding(5 bytes) = e8 c0 fe ff ff
0020h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
0023h mov rax,7FFDDABF3790h         ; MOV(Mov_r64_imm64) [RAX,7ffddabf3790h:imm64]         encoding(10 bytes) = 48 b8 90 37 bf da fd 7f 00 00
002dh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0031h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0032h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> VoidCalls4Bytes => new byte[53]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0xCE,0xE8,0xD0,0xFE,0xFF,0xFF,0x48,0x8B,0xCE,0xE8,0xC8,0xFE,0xFF,0xFF,0x48,0x8B,0xCE,0xE8,0xC0,0xFE,0xFF,0xFF,0x48,0x8B,0xCE,0x48,0xB8,0x90,0x37,0xBF,0xDA,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x20,0x5E,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int InvokeBinOp(Func<int,int,int> f, int x, int y)
; location: [7FFDDABF3D10h, 7FFDDABF3D2Fh]
0000h push rax                      ; PUSH(Push_r64) [RAX]                                 encoding(1 byte ) = 50
0001h nop dword ptr [rax]           ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(4 bytes) = 0f 1f 40 00
0005h mov [rsp],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,SS:sr),RDX]        encoding(4 bytes) = 48 89 14 24
0009h mov rcx,[rdx+8]               ; MOV(Mov_r64_rm64) [RCX,mem(64u,RDX:br,DS:sr)]        encoding(4 bytes) = 48 8b 4a 08
000dh mov edx,r8d                   ; MOV(Mov_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 8b d0
0010h mov r8d,r9d                   ; MOV(Mov_r32_rm32) [R8D,R9D]                          encoding(3 bytes) = 45 8b c1
0013h mov rax,[rsp]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(4 bytes) = 48 8b 04 24
0017h mov rax,[rax+18h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,DS:sr)]        encoding(4 bytes) = 48 8b 40 18
001bh add rsp,8                     ; ADD(Add_rm64_imm8) [RSP,8h:imm64]                    encoding(4 bytes) = 48 83 c4 08
001fh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> InvokeBinOpBytes => new byte[34]{0x50,0x0F,0x1F,0x40,0x00,0x48,0x89,0x14,0x24,0x48,0x8B,0x4A,0x08,0x41,0x8B,0xD0,0x45,0x8B,0xC1,0x48,0x8B,0x04,0x24,0x48,0x8B,0x40,0x18,0x48,0x83,0xC4,0x08,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int AddMulInline(int x, int y)
; location: [7FFDDABF3D50h, 7FFDDABF3D60h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+rdx]             ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,DS:sr)]       encoding(3 bytes) = 8d 04 11
0008h imul ecx,eax                  ; IMUL(Imul_r32_rm32) [ECX,EAX]                        encoding(3 bytes) = 0f af c8
000bh imul eax,edx                  ; IMUL(Imul_r32_rm32) [EAX,EDX]                        encoding(3 bytes) = 0f af c2
000eh add eax,ecx                   ; ADD(Add_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 03 c1
0010h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> AddMulInlineBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x04,0x11,0x0F,0xAF,0xC8,0x0F,0xAF,0xC2,0x03,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int CallInvokeBinOp(int x, int y)
; location: [7FFDDABF3D80h, 7FFDDABF3DE8h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbp                      ; PUSH(Push_r64) [RBP]                                 encoding(1 byte ) = 55
0003h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0004h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0008h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
000bh mov edi,edx                   ; MOV(Mov_r32_rm32) [EDI,EDX]                          encoding(2 bytes) = 8b fa
000dh mov ebx,r8d                   ; MOV(Mov_r32_rm32) [EBX,R8D]                          encoding(3 bytes) = 41 8b d8
0010h mov rcx,7FFDDADBEE60h         ; MOV(Mov_r64_imm64) [RCX,7ffddadbee60h:imm64]         encoding(10 bytes) = 48 b9 60 ee db da fd 7f 00 00
001ah call 7FFE3A6F44B0h            ; CALL(Call_rel32_64) [5FB00730h:jmp64]                encoding(5 bytes) = e8 11 07 b0 5f
001fh mov rbp,rax                   ; MOV(Mov_r64_rm64) [RBP,RAX]                          encoding(3 bytes) = 48 8b e8
0022h lea rcx,[rbp+8]               ; LEA(Lea_r64_m) [RCX,mem(Unknown,RBP:br,SS:sr)]       encoding(4 bytes) = 48 8d 4d 08
0026h mov rdx,rbp                   ; MOV(Mov_r64_rm64) [RDX,RBP]                          encoding(3 bytes) = 48 8b d5
0029h call 7FFE3A6F35F0h            ; CALL(Call_rel32_64) [5FAFF870h:jmp64]                encoding(5 bytes) = e8 42 f8 af 5f
002eh mov rcx,7FFDDAAAD0A0h         ; MOV(Mov_r64_imm64) [RCX,7ffddaaad0a0h:imm64]         encoding(10 bytes) = 48 b9 a0 d0 aa da fd 7f 00 00
0038h mov [rbp+18h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RBP:br,SS:sr),RCX]        encoding(4 bytes) = 48 89 4d 18
003ch mov rcx,7FFDDABF3D50h         ; MOV(Mov_r64_imm64) [RCX,7ffddabf3d50h:imm64]         encoding(10 bytes) = 48 b9 50 3d bf da fd 7f 00 00
0046h mov [rbp+20h],rcx             ; MOV(Mov_rm64_r64) [mem(64u,RBP:br,SS:sr),RCX]        encoding(4 bytes) = 48 89 4d 20
004ah mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
004dh mov rdx,rbp                   ; MOV(Mov_r64_rm64) [RDX,RBP]                          encoding(3 bytes) = 48 8b d5
0050h mov r8d,edi                   ; MOV(Mov_r32_rm32) [R8D,EDI]                          encoding(3 bytes) = 44 8b c7
0053h mov r9d,ebx                   ; MOV(Mov_r32_rm32) [R9D,EBX]                          encoding(3 bytes) = 44 8b cb
0056h mov rax,7FFDDABF3D10h         ; MOV(Mov_r64_imm64) [RAX,7ffddabf3d10h:imm64]         encoding(10 bytes) = 48 b8 10 3d bf da fd 7f 00 00
0060h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
0064h pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
0065h pop rbp                       ; POP(Pop_r64) [RBP]                                   encoding(1 byte ) = 5d
0066h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0067h pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
0068h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> CallInvokeBinOpBytes => new byte[107]{0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF1,0x8B,0xFA,0x41,0x8B,0xD8,0x48,0xB9,0x60,0xEE,0xDB,0xDA,0xFD,0x7F,0x00,0x00,0xE8,0x11,0x07,0xB0,0x5F,0x48,0x8B,0xE8,0x48,0x8D,0x4D,0x08,0x48,0x8B,0xD5,0xE8,0x42,0xF8,0xAF,0x5F,0x48,0xB9,0xA0,0xD0,0xAA,0xDA,0xFD,0x7F,0x00,0x00,0x48,0x89,0x4D,0x18,0x48,0xB9,0x50,0x3D,0xBF,0xDA,0xFD,0x7F,0x00,0x00,0x48,0x89,0x4D,0x20,0x48,0x8B,0xCE,0x48,0x8B,0xD5,0x44,0x8B,0xC7,0x44,0x8B,0xCB,0x48,0xB8,0x10,0x3D,0xBF,0xDA,0xFD,0x7F,0x00,0x00,0x48,0x83,0xC4,0x28,0x5B,0x5D,0x5E,0x5F,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int JumpTarget1()
; location: [7FFDDABF3E10h, 7FFDDABF3E1Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> JumpTarget1Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int JumpTarget2()
; location: [7FFDDABF3E30h, 7FFDDABF3E3Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,2                     ; MOV(Mov_r32_imm32) [EAX,2h:imm32]                    encoding(5 bytes) = b8 02 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> JumpTarget2Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x02,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int JumpTarget3()
; location: [7FFDDABF3E50h, 7FFDDABF3E5Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,3                     ; MOV(Mov_r32_imm32) [EAX,3h:imm32]                    encoding(5 bytes) = b8 03 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> JumpTarget3Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x03,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int JumpTarget4()
; location: [7FFDDABF3E70h, 7FFDDABF3E7Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,4                     ; MOV(Mov_r32_imm32) [EAX,4h:imm32]                    encoding(5 bytes) = b8 04 00 00 00
000ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> JumpTarget4Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x04,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int Jump(int target)
; location: [7FFDDABF3E90h, 7FFDDABF3ED5h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp edx,1                     ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]                    encoding(3 bytes) = 83 fa 01
0008h je short 003bh                ; JE(Je_rel8_64) [3Bh:jmp64]                           encoding(2 bytes) = 74 31
000ah cmp edx,2                     ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]                    encoding(3 bytes) = 83 fa 02
000dh je short 002eh                ; JE(Je_rel8_64) [2Eh:jmp64]                           encoding(2 bytes) = 74 1f
000fh cmp edx,3                     ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 fa 03
0012h je short 0021h                ; JE(Je_rel8_64) [21h:jmp64]                           encoding(2 bytes) = 74 0d
0014h mov rax,7FFDDABF3E70h         ; MOV(Mov_r64_imm64) [RAX,7ffddabf3e70h:imm64]         encoding(10 bytes) = 48 b8 70 3e bf da fd 7f 00 00
001eh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
0021h mov rax,7FFDDABF3E50h         ; MOV(Mov_r64_imm64) [RAX,7ffddabf3e50h:imm64]         encoding(10 bytes) = 48 b8 50 3e bf da fd 7f 00 00
002bh jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
002eh mov rax,7FFDDABF3E30h         ; MOV(Mov_r64_imm64) [RAX,7ffddabf3e30h:imm64]         encoding(10 bytes) = 48 b8 30 3e bf da fd 7f 00 00
0038h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
003bh mov rax,7FFDDABF3E10h         ; MOV(Mov_r64_imm64) [RAX,7ffddabf3e10h:imm64]         encoding(10 bytes) = 48 b8 10 3e bf da fd 7f 00 00
0045h jmp rax                       ; JMP(Jmp_rm64) [RAX]                                  encoding(3 bytes) = 48 ff e0
; static ReadOnlySpan<byte> JumpBytes => new byte[72]{0x0F,0x1F,0x44,0x00,0x00,0x83,0xFA,0x01,0x74,0x31,0x83,0xFA,0x02,0x74,0x1F,0x83,0xFA,0x03,0x74,0x0D,0x48,0xB8,0x70,0x3E,0xBF,0xDA,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0,0x48,0xB8,0x50,0x3E,0xBF,0xDA,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0,0x48,0xB8,0x30,0x3E,0xBF,0xDA,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0,0x48,0xB8,0x10,0x3E,0xBF,0xDA,0xFD,0x7F,0x00,0x00,0x48,0xFF,0xE0};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void divrem32i(int x, int y, out int q, out int r)
; location: [7FFDDABF3EF0h, 7FFDDABF3F0Ah]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10d,edx                  ; MOV(Mov_r32_rm32) [R10D,EDX]                         encoding(3 bytes) = 44 8b d2
0008h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
000ah cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
000bh idiv r10d                     ; IDIV(Idiv_rm32) [R10D]                               encoding(3 bytes) = 41 f7 fa
000eh mov [r8],eax                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,DS:sr),EAX]         encoding(3 bytes) = 41 89 00
0011h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0013h cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
0014h idiv r10d                     ; IDIV(Idiv_rm32) [R10D]                               encoding(3 bytes) = 41 f7 fa
0017h mov [r9],edx                  ; MOV(Mov_rm32_r32) [mem(32u,R9:br,DS:sr),EDX]         encoding(3 bytes) = 41 89 11
001ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divrem32iBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x44,0x8B,0xD2,0x8B,0xC1,0x99,0x41,0xF7,0xFA,0x41,0x89,0x00,0x8B,0xC1,0x99,0x41,0xF7,0xFA,0x41,0x89,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void divrem64i(long x, long y, out long q, out long r)
; location: [7FFDDABF3F20h, 7FFDDABF3F3Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r10,rdx                   ; MOV(Mov_r64_rm64) [R10,RDX]                          encoding(3 bytes) = 4c 8b d2
0008h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
000bh cqo                           ; CQO(Cqo)                                             encoding(2 bytes) = 48 99
000dh idiv r10                      ; IDIV(Idiv_rm64) [R10]                                encoding(3 bytes) = 49 f7 fa
0010h mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,DS:sr),RAX]         encoding(3 bytes) = 49 89 00
0013h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0016h cqo                           ; CQO(Cqo)                                             encoding(2 bytes) = 48 99
0018h idiv r10                      ; IDIV(Idiv_rm64) [R10]                                encoding(3 bytes) = 49 f7 fa
001bh mov [r9],rdx                  ; MOV(Mov_rm64_r64) [mem(64u,R9:br,DS:sr),RDX]         encoding(3 bytes) = 49 89 11
001eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divrem64iBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xD2,0x48,0x8B,0xC1,0x48,0x99,0x49,0xF7,0xFA,0x49,0x89,0x00,0x48,0x8B,0xC1,0x48,0x99,0x49,0xF7,0xFA,0x49,0x89,0x11,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ValueTuple<ulong,ulong> divrem64u(ulong x, ulong y)
; location: [7FFDDABF3F50h, 7FFDDABF3F75h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov r9,rdx                    ; MOV(Mov_r64_rm64) [R9,RDX]                           encoding(3 bytes) = 4c 8b ca
0008h mov rax,r9                    ; MOV(Mov_r64_rm64) [RAX,R9]                           encoding(3 bytes) = 49 8b c1
000bh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000dh div r8                        ; DIV(Div_rm64) [R8]                                   encoding(3 bytes) = 49 f7 f0
0010h mov r10,rax                   ; MOV(Mov_r64_rm64) [R10,RAX]                          encoding(3 bytes) = 4c 8b d0
0013h mov rax,r9                    ; MOV(Mov_r64_rm64) [RAX,R9]                           encoding(3 bytes) = 49 8b c1
0016h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0018h div r8                        ; DIV(Div_rm64) [R8]                                   encoding(3 bytes) = 49 f7 f0
001bh mov [rcx],r10                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),R10]        encoding(3 bytes) = 4c 89 11
001eh mov [rcx+8],rdx               ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RDX]        encoding(4 bytes) = 48 89 51 08
0022h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0025h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> divrem64uBytes => new byte[38]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x8B,0xCA,0x49,0x8B,0xC1,0x33,0xD2,0x49,0xF7,0xF0,0x4C,0x8B,0xD0,0x49,0x8B,0xC1,0x33,0xD2,0x49,0xF7,0xF0,0x4C,0x89,0x11,0x48,0x89,0x51,0x08,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
