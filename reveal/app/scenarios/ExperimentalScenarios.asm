; 2020-01-05 20:14:01:565
; function: Vector256<uint> add_test()
; static ReadOnlySpan<byte> add_testBytes => new byte[270]{0x56,0x48,0x81,0xEC,0x90,0x00,0x00,0x00,0xC5,0xF8,0x77,0x33,0xC0,0x48,0x89,0x44,0x24,0x60,0x48,0x89,0x44,0x24,0x68,0x48,0x89,0x44,0x24,0x70,0x48,0x89,0x44,0x24,0x78,0x48,0x8B,0xF2,0x33,0xD2,0xC5,0xF9,0x6E,0xC2,0xBA,0x01,0x00,0x00,0x00,0xC4,0xE3,0x79,0x22,0xC2,0x01,0xBA,0x02,0x00,0x00,0x00,0xC4,0xE3,0x79,0x22,0xC2,0x02,0xBA,0x03,0x00,0x00,0x00,0xC4,0xE3,0x79,0x22,0xC2,0x03,0xBA,0x04,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xCA,0xBA,0x05,0x00,0x00,0x00,0xC4,0xE3,0x71,0x22,0xCA,0x01,0xBA,0x06,0x00,0x00,0x00,0xC4,0xE3,0x71,0x22,0xCA,0x02,0xBA,0x07,0x00,0x00,0x00,0xC4,0xE3,0x71,0x22,0xCA,0x03,0xC4,0xE3,0x7D,0x38,0xC1,0x01,0xBA,0x08,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xCA,0xBA,0x09,0x00,0x00,0x00,0xC4,0xE3,0x71,0x22,0xCA,0x01,0xBA,0x0A,0x00,0x00,0x00,0xC4,0xE3,0x71,0x22,0xCA,0x02,0xBA,0x0B,0x00,0x00,0x00,0xC4,0xE3,0x71,0x22,0xCA,0x03,0xBA,0x0C,0x00,0x00,0x00,0xC5,0xF9,0x6E,0xD2,0xBA,0x0D,0x00,0x00,0x00,0xC4,0xE3,0x69,0x22,0xD2,0x01,0xBA,0x0E,0x00,0x00,0x00,0xC4,0xE3,0x69,0x22,0xD2,0x02,0xBA,0x0F,0x00,0x00,0x00,0xC4,0xE3,0x69,0x22,0xD2,0x03,0xC4,0xE3,0x75,0x38,0xCA,0x01,0x48,0x8D,0x54,0x24,0x60,0xC5,0xFD,0x11,0x44,0x24,0x40,0xC5,0xFD,0x11,0x4C,0x24,0x20,0x4C,0x8D,0x44,0x24,0x40,0x4C,0x8D,0x4C,0x24,0x20,0xE8,0x03,0x2A,0x94,0xFF,0xC5,0xFD,0x10,0x44,0x24,0x60,0xC5,0xFD,0x11,0x06,0x48,0x8B,0xC6,0xC5,0xF8,0x77,0x48,0x81,0xC4,0x90,0x00,0x00,0x00,0x5E,0xC3};
0000h push rsi                                ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0001h sub rsp,90h                             ; SUB(Sub_rm64_imm32) [RSP,90h:imm64]        encoding(7 bytes) = 48 81 ec 90 00 00 00
0008h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
000bh xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
000dh mov [rsp+60h],rax                       ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(5 bytes) = 48 89 44 24 60
0012h mov [rsp+68h],rax                       ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(5 bytes) = 48 89 44 24 68
0017h mov [rsp+70h],rax                       ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(5 bytes) = 48 89 44 24 70
001ch mov [rsp+78h],rax                       ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(5 bytes) = 48 89 44 24 78
0021h mov rsi,rdx                             ; MOV(Mov_r64_rm64) [RSI,RDX]                encoding(3 bytes) = 48 8b f2
0024h xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
0026h vmovd xmm0,edx                          ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM0,EDX]       encoding(VEX, 4 bytes) = c5 f9 6e c2
002ah mov edx,1                               ; MOV(Mov_r32_imm32) [EDX,1h:imm32]          encoding(5 bytes) = ba 01 00 00 00
002fh vpinsrd xmm0,xmm0,edx,1                 ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM0,XMM0,EDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 22 c2 01
0035h mov edx,2                               ; MOV(Mov_r32_imm32) [EDX,2h:imm32]          encoding(5 bytes) = ba 02 00 00 00
003ah vpinsrd xmm0,xmm0,edx,2                 ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM0,XMM0,EDX,2h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 22 c2 02
0040h mov edx,3                               ; MOV(Mov_r32_imm32) [EDX,3h:imm32]          encoding(5 bytes) = ba 03 00 00 00
0045h vpinsrd xmm0,xmm0,edx,3                 ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM0,XMM0,EDX,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 22 c2 03
004bh mov edx,4                               ; MOV(Mov_r32_imm32) [EDX,4h:imm32]          encoding(5 bytes) = ba 04 00 00 00
0050h vmovd xmm1,edx                          ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EDX]       encoding(VEX, 4 bytes) = c5 f9 6e ca
0054h mov edx,5                               ; MOV(Mov_r32_imm32) [EDX,5h:imm32]          encoding(5 bytes) = ba 05 00 00 00
0059h vpinsrd xmm1,xmm1,edx,1                 ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM1,XMM1,EDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 71 22 ca 01
005fh mov edx,6                               ; MOV(Mov_r32_imm32) [EDX,6h:imm32]          encoding(5 bytes) = ba 06 00 00 00
0064h vpinsrd xmm1,xmm1,edx,2                 ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM1,XMM1,EDX,2h:imm8] encoding(VEX, 6 bytes) = c4 e3 71 22 ca 02
006ah mov edx,7                               ; MOV(Mov_r32_imm32) [EDX,7h:imm32]          encoding(5 bytes) = ba 07 00 00 00
006fh vpinsrd xmm1,xmm1,edx,3                 ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM1,XMM1,EDX,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 71 22 ca 03
0075h vinserti128 ymm0,ymm0,xmm1,1            ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM0,YMM0,XMM1,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 7d 38 c1 01
007bh mov edx,8                               ; MOV(Mov_r32_imm32) [EDX,8h:imm32]          encoding(5 bytes) = ba 08 00 00 00
0080h vmovd xmm1,edx                          ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EDX]       encoding(VEX, 4 bytes) = c5 f9 6e ca
0084h mov edx,9                               ; MOV(Mov_r32_imm32) [EDX,9h:imm32]          encoding(5 bytes) = ba 09 00 00 00
0089h vpinsrd xmm1,xmm1,edx,1                 ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM1,XMM1,EDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 71 22 ca 01
008fh mov edx,0Ah                             ; MOV(Mov_r32_imm32) [EDX,ah:imm32]          encoding(5 bytes) = ba 0a 00 00 00
0094h vpinsrd xmm1,xmm1,edx,2                 ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM1,XMM1,EDX,2h:imm8] encoding(VEX, 6 bytes) = c4 e3 71 22 ca 02
009ah mov edx,0Bh                             ; MOV(Mov_r32_imm32) [EDX,bh:imm32]          encoding(5 bytes) = ba 0b 00 00 00
009fh vpinsrd xmm1,xmm1,edx,3                 ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM1,XMM1,EDX,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 71 22 ca 03
00a5h mov edx,0Ch                             ; MOV(Mov_r32_imm32) [EDX,ch:imm32]          encoding(5 bytes) = ba 0c 00 00 00
00aah vmovd xmm2,edx                          ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM2,EDX]       encoding(VEX, 4 bytes) = c5 f9 6e d2
00aeh mov edx,0Dh                             ; MOV(Mov_r32_imm32) [EDX,dh:imm32]          encoding(5 bytes) = ba 0d 00 00 00
00b3h vpinsrd xmm2,xmm2,edx,1                 ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM2,XMM2,EDX,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 69 22 d2 01
00b9h mov edx,0Eh                             ; MOV(Mov_r32_imm32) [EDX,eh:imm32]          encoding(5 bytes) = ba 0e 00 00 00
00beh vpinsrd xmm2,xmm2,edx,2                 ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM2,XMM2,EDX,2h:imm8] encoding(VEX, 6 bytes) = c4 e3 69 22 d2 02
00c4h mov edx,0Fh                             ; MOV(Mov_r32_imm32) [EDX,fh:imm32]          encoding(5 bytes) = ba 0f 00 00 00
00c9h vpinsrd xmm2,xmm2,edx,3                 ; VPINSRD(VEX_Vpinsrd_xmm_xmm_rm32_imm8) [XMM2,XMM2,EDX,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 69 22 d2 03
00cfh vinserti128 ymm1,ymm1,xmm2,1            ; VINSERTI128(VEX_Vinserti128_ymm_ymm_xmmm128_imm8) [YMM1,YMM1,XMM2,1h:imm8] encoding(VEX, 6 bytes) = c4 e3 75 38 ca 01
00d5h lea rdx,[rsp+60h]                       ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 54 24 60
00dah vmovupd [rsp+40h],ymm0                  ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM0] encoding(VEX, 6 bytes) = c5 fd 11 44 24 40
00e0h vmovupd [rsp+20h],ymm1                  ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSP:br,:sr),YMM1] encoding(VEX, 6 bytes) = c5 fd 11 4c 24 20
00e6h lea r8,[rsp+40h]                        ; LEA(Lea_r64_m) [R8,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 4c 8d 44 24 40
00ebh lea r9,[rsp+20h]                        ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 4c 8d 4c 24 20
00f0h call 7FF7B4D87178h                      ; CALL(Call_rel32_64) [FFFFFFFFFF942AF8h:jmp64] encoding(5 bytes) = e8 03 2a 94 ff
00f5h vmovupd ymm0,[rsp+60h]                  ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RSP:br,:sr)] encoding(VEX, 6 bytes) = c5 fd 10 44 24 60
00fbh vmovupd [rsi],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSI:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 06
00ffh mov rax,rsi                             ; MOV(Mov_r64_rm64) [RAX,RSI]                encoding(3 bytes) = 48 8b c6
0102h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0105h add rsp,90h                             ; ADD(Add_rm64_imm32) [RSP,90h:imm64]        encoding(7 bytes) = 48 81 c4 90 00 00 00
010ch pop rsi                                 ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
010dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> add(Vector256<uint> x, Vector256<uint> y)
; static ReadOnlySpan<byte> addBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC4,0xC1,0x7D,0x10,0x00,0xC4,0xC1,0x7D,0xFE,0x01,0xC5,0xFD,0x11,0x02,0x48,0x8B,0xC2,0xC5,0xF8,0x77,0xC3};
0000h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                              ; NOP(Nopw)                                  encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[r8]                       ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d 10 00
000ah vpaddd ymm0,ymm0,[r9]                   ; VPADDD(VEX_Vpaddd_ymm_ymm_ymmm256) [YMM0,YMM0,mem(Packed256_Int32,R9:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 7d fe 01
000fh vmovupd [rdx],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RDX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 02
0013h mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0016h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
0019h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> GetBytes(in int src)
; static ReadOnlySpan<byte> GetBytesBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x89,0x02,0xC7,0x42,0x08,0x04,0x00,0x00,0x00,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],r8                            ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8] encoding(3 bytes) = 4c 89 02
0008h mov dword ptr [rdx+8],4                 ; MOV(Mov_rm32_imm32) [mem(32u,RDX:br,:sr),4h:imm32] encoding(7 bytes) = c7 42 08 04 00 00 00
000fh mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> GetBytes(in ulong src)
; static ReadOnlySpan<byte> GetBytesBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x89,0x02,0xC7,0x42,0x08,0x08,0x00,0x00,0x00,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],r8                            ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8] encoding(3 bytes) = 4c 89 02
0008h mov dword ptr [rdx+8],8                 ; MOV(Mov_rm32_imm32) [mem(32u,RDX:br,:sr),8h:imm32] encoding(7 bytes) = c7 42 08 08 00 00 00
000fh mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Span<byte> GetBytes(in double src)
; static ReadOnlySpan<byte> GetBytesBytes => new byte[19]{0x0F,0x1F,0x44,0x00,0x00,0x4C,0x89,0x02,0xC7,0x42,0x08,0x08,0x00,0x00,0x00,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rdx],r8                            ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8] encoding(3 bytes) = 4c 89 02
0008h mov dword ptr [rdx+8],8                 ; MOV(Mov_rm32_imm32) [mem(32u,RDX:br,:sr),8h:imm32] encoding(7 bytes) = c7 42 08 08 00 00 00
000fh mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: N3 nat3()
; static ReadOnlySpan<byte> nat3Bytes => new byte[19]{0x50,0x0F,0x1F,0x40,0x00,0xC6,0x04,0x24,0x00,0x48,0x0F,0xBE,0x04,0x24,0x48,0x83,0xC4,0x08,0xC3};
0000h push rax                                ; PUSH(Push_r64) [RAX]                       encoding(1 byte ) = 50
0001h nop dword ptr [rax]                     ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(4 bytes) = 0f 1f 40 00
0005h mov byte ptr [rsp],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RSP:br,:sr),0h:imm8] encoding(4 bytes) = c6 04 24 00
0009h movsx rax,byte ptr [rsp]                ; MOVSX(Movsx_r64_rm8) [RAX,mem(8i,RSP:br,:sr)] encoding(5 bytes) = 48 0f be 04 24
000eh add rsp,8                               ; ADD(Add_rm64_imm8) [RSP,8h:imm64]          encoding(4 bytes) = 48 83 c4 08
0012h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong nat3val()
; static ReadOnlySpan<byte> nat3valBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x03,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,3                               ; MOV(Mov_r32_imm32) [EAX,3h:imm32]          encoding(5 bytes) = b8 03 00 00 00
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int natval()
; static ReadOnlySpan<byte> natvalBytes => new byte[24]{0x50,0x33,0xC0,0x48,0x89,0x04,0x24,0x48,0x8D,0x04,0x24,0xC6,0x00,0x00,0xB8,0x1E,0x00,0x00,0x00,0x48,0x83,0xC4,0x08,0xC3};
0000h push rax                                ; PUSH(Push_r64) [RAX]                       encoding(1 byte ) = 50
0001h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0003h mov [rsp],rax                           ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(4 bytes) = 48 89 04 24
0007h lea rax,[rsp]                           ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(4 bytes) = 48 8d 04 24
000bh mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
000eh mov eax,1Eh                             ; MOV(Mov_r32_imm32) [EAX,1eh:imm32]         encoding(5 bytes) = b8 1e 00 00 00
0013h add rsp,8                               ; ADD(Add_rm64_imm8) [RSP,8h:imm64]          encoding(4 bytes) = 48 83 c4 08
0017h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int natseq2()
; static ReadOnlySpan<byte> natseq2Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x25,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,25h                             ; MOV(Mov_r32_imm32) [EAX,25h:imm32]         encoding(5 bytes) = b8 25 00 00 00
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int natseq3()
; static ReadOnlySpan<byte> natseq3Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x73,0x01,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,173h                            ; MOV(Mov_r32_imm32) [EAX,173h:imm32]        encoding(5 bytes) = b8 73 01 00 00
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int natseq4()
; static ReadOnlySpan<byte> natseq4Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x04,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,400h                            ; MOV(Mov_r32_imm32) [EAX,400h:imm32]        encoding(5 bytes) = b8 00 04 00 00
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int add()
; static ReadOnlySpan<byte> addBytes => new byte[42]{0x48,0x83,0xEC,0x18,0x33,0xC0,0x48,0x89,0x44,0x24,0x10,0x48,0x89,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x10,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x08,0xC6,0x00,0x00,0xB8,0x24,0x00,0x00,0x00,0x48,0x83,0xC4,0x18,0xC3};
0000h sub rsp,18h                             ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 ec 18
0004h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0006h mov [rsp+10h],rax                       ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(5 bytes) = 48 89 44 24 10
000bh mov [rsp+8],rax                         ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(5 bytes) = 48 89 44 24 08
0010h lea rax,[rsp+10h]                       ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 10
0015h mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0018h lea rax,[rsp+8]                         ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 08
001dh mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0020h mov eax,24h                             ; MOV(Mov_r32_imm32) [EAX,24h:imm32]         encoding(5 bytes) = b8 24 00 00 00
0025h add rsp,18h                             ; ADD(Add_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 c4 18
0029h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int sub()
; static ReadOnlySpan<byte> subBytes => new byte[42]{0x48,0x83,0xEC,0x18,0x33,0xC0,0x48,0x89,0x44,0x24,0x10,0x48,0x89,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x10,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x08,0xC6,0x00,0x00,0xB8,0x00,0x06,0x00,0x00,0x48,0x83,0xC4,0x18,0xC3};
0000h sub rsp,18h                             ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 ec 18
0004h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0006h mov [rsp+10h],rax                       ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(5 bytes) = 48 89 44 24 10
000bh mov [rsp+8],rax                         ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(5 bytes) = 48 89 44 24 08
0010h lea rax,[rsp+10h]                       ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 10
0015h mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0018h lea rax,[rsp+8]                         ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 08
001dh mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0020h mov eax,600h                            ; MOV(Mov_r32_imm32) [EAX,600h:imm32]        encoding(5 bytes) = b8 00 06 00 00
0025h add rsp,18h                             ; ADD(Add_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 c4 18
0029h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int mul()
; static ReadOnlySpan<byte> mulBytes => new byte[42]{0x48,0x83,0xEC,0x18,0x33,0xC0,0x48,0x89,0x44,0x24,0x10,0x48,0x89,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x10,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x08,0xC6,0x00,0x00,0xB8,0x00,0x04,0x00,0x00,0x48,0x83,0xC4,0x18,0xC3};
0000h sub rsp,18h                             ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 ec 18
0004h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0006h mov [rsp+10h],rax                       ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(5 bytes) = 48 89 44 24 10
000bh mov [rsp+8],rax                         ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(5 bytes) = 48 89 44 24 08
0010h lea rax,[rsp+10h]                       ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 10
0015h mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0018h lea rax,[rsp+8]                         ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 08
001dh mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0020h mov eax,400h                            ; MOV(Mov_r32_imm32) [EAX,400h:imm32]        encoding(5 bytes) = b8 00 04 00 00
0025h add rsp,18h                             ; ADD(Add_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 c4 18
0029h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int div()
; static ReadOnlySpan<byte> divBytes => new byte[42]{0x48,0x83,0xEC,0x18,0x33,0xC0,0x48,0x89,0x44,0x24,0x10,0x48,0x89,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x10,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x08,0xC6,0x00,0x00,0xB8,0x08,0x00,0x00,0x00,0x48,0x83,0xC4,0x18,0xC3};
0000h sub rsp,18h                             ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 ec 18
0004h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0006h mov [rsp+10h],rax                       ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(5 bytes) = 48 89 44 24 10
000bh mov [rsp+8],rax                         ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(5 bytes) = 48 89 44 24 08
0010h lea rax,[rsp+10h]                       ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 10
0015h mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0018h lea rax,[rsp+8]                         ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 08
001dh mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0020h mov eax,8                               ; MOV(Mov_r32_imm32) [EAX,8h:imm32]          encoding(5 bytes) = b8 08 00 00 00
0025h add rsp,18h                             ; ADD(Add_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 c4 18
0029h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int mod()
; static ReadOnlySpan<byte> modBytes => new byte[39]{0x48,0x83,0xEC,0x18,0x33,0xC0,0x48,0x89,0x44,0x24,0x10,0x48,0x89,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x10,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x08,0xC6,0x00,0x00,0x33,0xC0,0x48,0x83,0xC4,0x18,0xC3};
0000h sub rsp,18h                             ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 ec 18
0004h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0006h mov [rsp+10h],rax                       ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(5 bytes) = 48 89 44 24 10
000bh mov [rsp+8],rax                         ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(5 bytes) = 48 89 44 24 08
0010h lea rax,[rsp+10h]                       ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 10
0015h mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0018h lea rax,[rsp+8]                         ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 08
001dh mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0020h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0022h add rsp,18h                             ; ADD(Add_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 c4 18
0026h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong pow2()
; static ReadOnlySpan<byte> pow2Bytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x00,0x00,0x01,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,10000h                          ; MOV(Mov_r32_imm32) [EAX,10000h:imm32]      encoding(5 bytes) = b8 00 00 01 00
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong sll()
; static ReadOnlySpan<byte> sllBytes => new byte[42]{0x48,0x83,0xEC,0x18,0x33,0xC0,0x48,0x89,0x44,0x24,0x10,0x48,0x89,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x10,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x08,0xC6,0x00,0x00,0xB8,0x20,0x00,0x00,0x00,0x48,0x83,0xC4,0x18,0xC3};
0000h sub rsp,18h                             ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 ec 18
0004h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0006h mov [rsp+10h],rax                       ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(5 bytes) = 48 89 44 24 10
000bh mov [rsp+8],rax                         ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(5 bytes) = 48 89 44 24 08
0010h lea rax,[rsp+10h]                       ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 10
0015h mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0018h lea rax,[rsp+8]                         ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 08
001dh mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0020h mov eax,20h                             ; MOV(Mov_r32_imm32) [EAX,20h:imm32]         encoding(5 bytes) = b8 20 00 00 00
0025h add rsp,18h                             ; ADD(Add_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 c4 18
0029h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong srl()
; static ReadOnlySpan<byte> srlBytes => new byte[42]{0x48,0x83,0xEC,0x18,0x33,0xC0,0x48,0x89,0x44,0x24,0x10,0x48,0x89,0x44,0x24,0x08,0x48,0x8D,0x44,0x24,0x10,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x08,0xC6,0x00,0x00,0xB8,0x00,0x00,0x04,0x00,0x48,0x83,0xC4,0x18,0xC3};
0000h sub rsp,18h                             ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 ec 18
0004h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0006h mov [rsp+10h],rax                       ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(5 bytes) = 48 89 44 24 10
000bh mov [rsp+8],rax                         ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(5 bytes) = 48 89 44 24 08
0010h lea rax,[rsp+10h]                       ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 10
0015h mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0018h lea rax,[rsp+8]                         ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 08
001dh mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0020h mov eax,40000h                          ; MOV(Mov_r32_imm32) [EAX,40000h:imm32]      encoding(5 bytes) = b8 00 00 04 00
0025h add rsp,18h                             ; ADD(Add_rm64_imm8) [RSP,18h:imm64]         encoding(4 bytes) = 48 83 c4 18
0029h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong rotr64u()
; static ReadOnlySpan<byte> rotr64uBytes => new byte[76]{0x57,0x56,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF1,0x48,0x8D,0x3C,0x24,0xB9,0x0A,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0x48,0x8D,0x44,0x24,0x20,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x18,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x10,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x08,0xC6,0x00,0x00,0x48,0x8D,0x04,0x24,0xC6,0x00,0x00,0xB8,0x04,0x00,0x04,0x00,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
0000h push rdi                                ; PUSH(Push_r64) [RDI]                       encoding(1 byte ) = 57
0001h push rsi                                ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0002h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0006h mov rsi,rcx                             ; MOV(Mov_r64_rm64) [RSI,RCX]                encoding(3 bytes) = 48 8b f1
0009h lea rdi,[rsp]                           ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,:sr)] encoding(4 bytes) = 48 8d 3c 24
000dh mov ecx,0Ah                             ; MOV(Mov_r32_imm32) [ECX,ah:imm32]          encoding(5 bytes) = b9 0a 00 00 00
0012h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0014h rep stosd                               ; STOSD(Stosd_m32_EAX) [mem(32u),EAX]        encoding(2 bytes) = f3 ab
0016h mov rcx,rsi                             ; MOV(Mov_r64_rm64) [RCX,RSI]                encoding(3 bytes) = 48 8b ce
0019h lea rax,[rsp+20h]                       ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 20
001eh mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0021h lea rax,[rsp+18h]                       ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 18
0026h mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0029h lea rax,[rsp+10h]                       ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 10
002eh mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0031h lea rax,[rsp+8]                         ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 08
0036h mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0039h lea rax,[rsp]                           ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(4 bytes) = 48 8d 04 24
003dh mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0040h mov eax,40004h                          ; MOV(Mov_r32_imm32) [EAX,40004h:imm32]      encoding(5 bytes) = b8 04 00 04 00
0045h add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
0049h pop rsi                                 ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
004ah pop rdi                                 ; POP(Pop_r64) [RDI]                         encoding(1 byte ) = 5f
004bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte rotr8u_1()
; static ReadOnlySpan<byte> rotr8u_1Bytes => new byte[76]{0x57,0x56,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF1,0x48,0x8D,0x3C,0x24,0xB9,0x0A,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0x48,0x8D,0x44,0x24,0x20,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x18,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x10,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x08,0xC6,0x00,0x00,0x48,0x8D,0x04,0x24,0xC6,0x00,0x00,0xB8,0x40,0x00,0x00,0x00,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
0000h push rdi                                ; PUSH(Push_r64) [RDI]                       encoding(1 byte ) = 57
0001h push rsi                                ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0002h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0006h mov rsi,rcx                             ; MOV(Mov_r64_rm64) [RSI,RCX]                encoding(3 bytes) = 48 8b f1
0009h lea rdi,[rsp]                           ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,:sr)] encoding(4 bytes) = 48 8d 3c 24
000dh mov ecx,0Ah                             ; MOV(Mov_r32_imm32) [ECX,ah:imm32]          encoding(5 bytes) = b9 0a 00 00 00
0012h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0014h rep stosd                               ; STOSD(Stosd_m32_EAX) [mem(32u),EAX]        encoding(2 bytes) = f3 ab
0016h mov rcx,rsi                             ; MOV(Mov_r64_rm64) [RCX,RSI]                encoding(3 bytes) = 48 8b ce
0019h lea rax,[rsp+20h]                       ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 20
001eh mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0021h lea rax,[rsp+18h]                       ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 18
0026h mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0029h lea rax,[rsp+10h]                       ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 10
002eh mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0031h lea rax,[rsp+8]                         ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 08
0036h mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0039h lea rax,[rsp]                           ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(4 bytes) = 48 8d 04 24
003dh mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0040h mov eax,40h                             ; MOV(Mov_r32_imm32) [EAX,40h:imm32]         encoding(5 bytes) = b8 40 00 00 00
0045h add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
0049h pop rsi                                 ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
004ah pop rdi                                 ; POP(Pop_r64) [RDI]                         encoding(1 byte ) = 5f
004bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte rotr8u_2()
; static ReadOnlySpan<byte> rotr8u_2Bytes => new byte[76]{0x57,0x56,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF1,0x48,0x8D,0x3C,0x24,0xB9,0x0A,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0x48,0x8D,0x44,0x24,0x20,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x18,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x10,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x08,0xC6,0x00,0x00,0x48,0x8D,0x04,0x24,0xC6,0x00,0x00,0xB8,0x20,0x00,0x00,0x00,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
0000h push rdi                                ; PUSH(Push_r64) [RDI]                       encoding(1 byte ) = 57
0001h push rsi                                ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0002h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0006h mov rsi,rcx                             ; MOV(Mov_r64_rm64) [RSI,RCX]                encoding(3 bytes) = 48 8b f1
0009h lea rdi,[rsp]                           ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,:sr)] encoding(4 bytes) = 48 8d 3c 24
000dh mov ecx,0Ah                             ; MOV(Mov_r32_imm32) [ECX,ah:imm32]          encoding(5 bytes) = b9 0a 00 00 00
0012h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0014h rep stosd                               ; STOSD(Stosd_m32_EAX) [mem(32u),EAX]        encoding(2 bytes) = f3 ab
0016h mov rcx,rsi                             ; MOV(Mov_r64_rm64) [RCX,RSI]                encoding(3 bytes) = 48 8b ce
0019h lea rax,[rsp+20h]                       ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 20
001eh mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0021h lea rax,[rsp+18h]                       ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 18
0026h mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0029h lea rax,[rsp+10h]                       ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 10
002eh mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0031h lea rax,[rsp+8]                         ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 08
0036h mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0039h lea rax,[rsp]                           ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(4 bytes) = 48 8d 04 24
003dh mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0040h mov eax,20h                             ; MOV(Mov_r32_imm32) [EAX,20h:imm32]         encoding(5 bytes) = b8 20 00 00 00
0045h add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
0049h pop rsi                                 ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
004ah pop rdi                                 ; POP(Pop_r64) [RDI]                         encoding(1 byte ) = 5f
004bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: byte rotr8u_3()
; static ReadOnlySpan<byte> rotr8u_3Bytes => new byte[76]{0x57,0x56,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF1,0x48,0x8D,0x3C,0x24,0xB9,0x0A,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0x48,0x8D,0x44,0x24,0x20,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x18,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x10,0xC6,0x00,0x00,0x48,0x8D,0x44,0x24,0x08,0xC6,0x00,0x00,0x48,0x8D,0x04,0x24,0xC6,0x00,0x00,0xB8,0x10,0x00,0x00,0x00,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
0000h push rdi                                ; PUSH(Push_r64) [RDI]                       encoding(1 byte ) = 57
0001h push rsi                                ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0002h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0006h mov rsi,rcx                             ; MOV(Mov_r64_rm64) [RSI,RCX]                encoding(3 bytes) = 48 8b f1
0009h lea rdi,[rsp]                           ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,:sr)] encoding(4 bytes) = 48 8d 3c 24
000dh mov ecx,0Ah                             ; MOV(Mov_r32_imm32) [ECX,ah:imm32]          encoding(5 bytes) = b9 0a 00 00 00
0012h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0014h rep stosd                               ; STOSD(Stosd_m32_EAX) [mem(32u),EAX]        encoding(2 bytes) = f3 ab
0016h mov rcx,rsi                             ; MOV(Mov_r64_rm64) [RCX,RSI]                encoding(3 bytes) = 48 8b ce
0019h lea rax,[rsp+20h]                       ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 20
001eh mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0021h lea rax,[rsp+18h]                       ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 18
0026h mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0029h lea rax,[rsp+10h]                       ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 10
002eh mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0031h lea rax,[rsp+8]                         ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 44 24 08
0036h mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0039h lea rax,[rsp]                           ; LEA(Lea_r64_m) [RAX,mem(Unknown,RSP:br,:sr)] encoding(4 bytes) = 48 8d 04 24
003dh mov byte ptr [rax],0                    ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),0h:imm8] encoding(3 bytes) = c6 00 00
0040h mov eax,10h                             ; MOV(Mov_r32_imm32) [EAX,10h:imm32]         encoding(5 bytes) = b8 10 00 00 00
0045h add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
0049h pop rsi                                 ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
004ah pop rdi                                 ; POP(Pop_r64) [RDI]                         encoding(1 byte ) = 5f
004bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> ShuffleWithDelegate(Vector256<uint> x)
; static ReadOnlySpan<byte> ShuffleWithDelegateBytes => new byte[109]{0x57,0x56,0x53,0x48,0x83,0xEC,0x20,0x48,0x8B,0xFA,0x49,0x8B,0xF0,0x48,0xB9,0x20,0xA7,0x5C,0xB5,0xF7,0x7F,0x00,0x00,0xE8,0x84,0x13,0x43,0x5F,0x48,0x8B,0xD8,0x48,0x8D,0x4B,0x08,0x48,0x8B,0xD3,0xE8,0xB5,0x04,0x43,0x5F,0x48,0xB9,0x10,0xDD,0xC4,0xB4,0xF7,0x7F,0x00,0x00,0x48,0x89,0x4B,0x18,0x48,0xB9,0x58,0xA3,0xD7,0xB4,0xF7,0x7F,0x00,0x00,0x48,0x89,0x4B,0x20,0x48,0x8B,0xCB,0xE8,0xB9,0x5C,0x94,0xFF,0x48,0x8B,0x4B,0x08,0x48,0x8B,0xD7,0x4C,0x8B,0xC6,0x41,0xB9,0x01,0x00,0x00,0x00,0xFF,0x53,0x18,0x48,0x8B,0xC7,0x48,0x83,0xC4,0x20,0x5B,0x5E,0x5F,0xC3};
0000h push rdi                                ; PUSH(Push_r64) [RDI]                       encoding(1 byte ) = 57
0001h push rsi                                ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0002h push rbx                                ; PUSH(Push_r64) [RBX]                       encoding(1 byte ) = 53
0003h sub rsp,20h                             ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]         encoding(4 bytes) = 48 83 ec 20
0007h mov rdi,rdx                             ; MOV(Mov_r64_rm64) [RDI,RDX]                encoding(3 bytes) = 48 8b fa
000ah mov rsi,r8                              ; MOV(Mov_r64_rm64) [RSI,R8]                 encoding(3 bytes) = 49 8b f0
000dh mov rcx,7FF7B55CA720h                   ; MOV(Mov_r64_imm64) [RCX,7ff7b55ca720h:imm64] encoding(10 bytes) = 48 b9 20 a7 5c b5 f7 7f 00 00
0017h call 7FF814876CB0h                      ; CALL(Call_rel32_64) [5F4313A0h:jmp64]      encoding(5 bytes) = e8 84 13 43 5f
001ch mov rbx,rax                             ; MOV(Mov_r64_rm64) [RBX,RAX]                encoding(3 bytes) = 48 8b d8
001fh lea rcx,[rbx+8]                         ; LEA(Lea_r64_m) [RCX,mem(Unknown,RBX:br,:sr)] encoding(4 bytes) = 48 8d 4b 08
0023h mov rdx,rbx                             ; MOV(Mov_r64_rm64) [RDX,RBX]                encoding(3 bytes) = 48 8b d3
0026h call 7FF814875DF0h                      ; CALL(Call_rel32_64) [5F4304E0h:jmp64]      encoding(5 bytes) = e8 b5 04 43 5f
002bh mov rcx,7FF7B4C4DD10h                   ; MOV(Mov_r64_imm64) [RCX,7ff7b4c4dd10h:imm64] encoding(10 bytes) = 48 b9 10 dd c4 b4 f7 7f 00 00
0035h mov [rbx+18h],rcx                       ; MOV(Mov_rm64_r64) [mem(64u,RBX:br,:sr),RCX] encoding(4 bytes) = 48 89 4b 18
0039h mov rcx,7FF7B4D7A358h                   ; MOV(Mov_r64_imm64) [RCX,7ff7b4d7a358h:imm64] encoding(10 bytes) = 48 b9 58 a3 d7 b4 f7 7f 00 00
0043h mov [rbx+20h],rcx                       ; MOV(Mov_rm64_r64) [mem(64u,RBX:br,:sr),RCX] encoding(4 bytes) = 48 89 4b 20
0047h mov rcx,rbx                             ; MOV(Mov_r64_rm64) [RCX,RBX]                encoding(3 bytes) = 48 8b cb
004ah call 7FF7B4D8B618h                      ; CALL(Call_rel32_64) [FFFFFFFFFF945D08h:jmp64] encoding(5 bytes) = e8 b9 5c 94 ff
004fh mov rcx,[rbx+8]                         ; MOV(Mov_r64_rm64) [RCX,mem(64u,RBX:br,:sr)] encoding(4 bytes) = 48 8b 4b 08
0053h mov rdx,rdi                             ; MOV(Mov_r64_rm64) [RDX,RDI]                encoding(3 bytes) = 48 8b d7
0056h mov r8,rsi                              ; MOV(Mov_r64_rm64) [R8,RSI]                 encoding(3 bytes) = 4c 8b c6
0059h mov r9d,1                               ; MOV(Mov_r32_imm32) [R9D,1h:imm32]          encoding(6 bytes) = 41 b9 01 00 00 00
005fh call qword ptr [rbx+18h]                ; CALL(Call_rm64) [mem(QwordOffset,RBX:br,:sr)] encoding(3 bytes) = ff 53 18
0062h mov rax,rdi                             ; MOV(Mov_r64_rm64) [RAX,RDI]                encoding(3 bytes) = 48 8b c7
0065h add rsp,20h                             ; ADD(Add_rm64_imm8) [RSP,20h:imm64]         encoding(4 bytes) = 48 83 c4 20
0069h pop rbx                                 ; POP(Pop_r64) [RBX]                         encoding(1 byte ) = 5b
006ah pop rsi                                 ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
006bh pop rdi                                 ; POP(Pop_r64) [RDI]                         encoding(1 byte ) = 5f
006ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> ShuffleWithReflection()
; static ReadOnlySpan<byte> ShuffleWithReflectionBytes => new byte[491]{0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x68,0xC5,0xF8,0x77,0x48,0x8B,0xF1,0x48,0x8D,0x7C,0x24,0x40,0xB9,0x0A,0x00,0x00,0x00,0x33,0xC0,0xF3,0xAB,0x48,0x8B,0xCE,0x48,0xB8,0x28,0x10,0x1C,0x73,0x5C,0xDF,0x00,0x00,0x48,0x89,0x44,0x24,0x60,0x48,0x8B,0xF2,0x48,0x8D,0x7C,0x24,0x40,0x33,0xC9,0x89,0x0F,0xC7,0x47,0x04,0x01,0x00,0x00,0x00,0xC7,0x47,0x08,0x02,0x00,0x00,0x00,0xC7,0x47,0x0C,0x03,0x00,0x00,0x00,0xC7,0x47,0x10,0x04,0x00,0x00,0x00,0xC7,0x47,0x14,0x05,0x00,0x00,0x00,0xC7,0x47,0x18,0x06,0x00,0x00,0x00,0xC7,0x47,0x1C,0x07,0x00,0x00,0x00,0xB9,0x08,0x00,0x00,0x00,0x83,0xF9,0x00,0x0F,0x86,0x6C,0x01,0x00,0x00,0x48,0xB9,0x98,0x27,0xE1,0xB4,0xF7,0x7F,0x00,0x00,0xE8,0xC8,0x95,0x3D,0x5F,0x48,0x8B,0xD8,0x48,0xB9,0x88,0x77,0xE0,0xB4,0xF7,0x7F,0x00,0x00,0xBA,0x02,0x00,0x00,0x00,0xE8,0x01,0x14,0x43,0x5F,0x48,0x8B,0xE8,0x48,0xB9,0xE0,0xFB,0x4A,0xB5,0xF7,0x7F,0x00,0x00,0xE8,0x9F,0x95,0x3D,0x5F,0x4C,0x8B,0xC0,0x48,0x8B,0xCD,0x33,0xD2,0xE8,0xB2,0x04,0x43,0x5F,0x48,0xB9,0x58,0x77,0xD4,0xB4,0xF7,0x7F,0x00,0x00,0xE8,0x83,0x95,0x3D,0x5F,0x4C,0x8B,0xC0,0x48,0x8B,0xCD,0xBA,0x01,0x00,0x00,0x00,0xE8,0x93,0x04,0x43,0x5F,0xC7,0x44,0x24,0x20,0x03,0x00,0x00,0x00,0x48,0x89,0x6C,0x24,0x28,0x33,0xD2,0x48,0x89,0x54,0x24,0x30,0x48,0xBA,0x00,0x43,0x01,0x10,0x3C,0x01,0x00,0x00,0x48,0x8B,0x12,0x48,0x8B,0xCB,0x41,0xB8,0x1C,0x00,0x00,0x00,0x45,0x33,0xC9,0xE8,0x01,0x74,0xDC,0x5E,0x48,0x8B,0xD8,0x48,0xB9,0xC0,0x52,0xD4,0xB4,0xF7,0x7F,0x00,0x00,0xBA,0x02,0x00,0x00,0x00,0xE8,0x7A,0x13,0x43,0x5F,0x48,0x8B,0xE8,0x48,0xB9,0xE0,0xFB,0x4A,0xB5,0xF7,0x7F,0x00,0x00,0xE8,0xD8,0x11,0x43,0x5F,0xC5,0xFE,0x6F,0x07,0xC5,0xFD,0x11,0x40,0x08,0x4C,0x8B,0xC0,0x48,0x8B,0xCD,0x33,0xD2,0xE8,0x22,0x04,0x43,0x5F,0x48,0xB9,0x58,0x77,0xD4,0xB4,0xF7,0x7F,0x00,0x00,0xE8,0xB3,0x11,0x43,0x5F,0xC6,0x40,0x08,0x01,0x4C,0x8B,0xC0,0x48,0x8B,0xCD,0xBA,0x01,0x00,0x00,0x00,0xE8,0xFF,0x03,0x43,0x5F,0x48,0x89,0x6C,0x24,0x20,0x33,0xC9,0x48,0x89,0x4C,0x24,0x28,0x48,0x8B,0xCB,0x33,0xD2,0x45,0x33,0xC0,0x45,0x33,0xC9,0x48,0x8B,0x03,0x48,0x8B,0x40,0x58,0xFF,0x50,0x38,0x48,0x8B,0xF8,0x48,0xBA,0xE0,0xFB,0x4A,0xB5,0xF7,0x7F,0x00,0x00,0x48,0x39,0x17,0x74,0x12,0x48,0x8B,0xD7,0x48,0xB9,0xE0,0xFB,0x4A,0xB5,0xF7,0x7F,0x00,0x00,0xE8,0x0A,0xD8,0x3F,0x5F,0xC5,0xFD,0x10,0x47,0x08,0xC5,0xFD,0x11,0x06,0x48,0x8B,0xC6,0x48,0xB9,0x28,0x10,0x1C,0x73,0x5C,0xDF,0x00,0x00,0x48,0x39,0x4C,0x24,0x60,0x74,0x05,0xE8,0xD8,0xBA,0x55,0x5F,0x90,0xC5,0xF8,0x77,0x48,0x83,0xC4,0x68,0x5B,0x5D,0x5E,0x5F,0xC3,0xE8,0x46,0xA2,0x55,0x5F,0xCC};
0000h push rdi                                ; PUSH(Push_r64) [RDI]                       encoding(1 byte ) = 57
0001h push rsi                                ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0002h push rbp                                ; PUSH(Push_r64) [RBP]                       encoding(1 byte ) = 55
0003h push rbx                                ; PUSH(Push_r64) [RBX]                       encoding(1 byte ) = 53
0004h sub rsp,68h                             ; SUB(Sub_rm64_imm8) [RSP,68h:imm64]         encoding(4 bytes) = 48 83 ec 68
0008h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
000bh mov rsi,rcx                             ; MOV(Mov_r64_rm64) [RSI,RCX]                encoding(3 bytes) = 48 8b f1
000eh lea rdi,[rsp+40h]                       ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 7c 24 40
0013h mov ecx,0Ah                             ; MOV(Mov_r32_imm32) [ECX,ah:imm32]          encoding(5 bytes) = b9 0a 00 00 00
0018h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
001ah rep stosd                               ; STOSD(Stosd_m32_EAX) [mem(32u),EAX]        encoding(2 bytes) = f3 ab
001ch mov rcx,rsi                             ; MOV(Mov_r64_rm64) [RCX,RSI]                encoding(3 bytes) = 48 8b ce
001fh mov rax,0DF5C731C1028h                  ; MOV(Mov_r64_imm64) [RAX,df5c731c1028h:imm64] encoding(10 bytes) = 48 b8 28 10 1c 73 5c df 00 00
0029h mov [rsp+60h],rax                       ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RAX] encoding(5 bytes) = 48 89 44 24 60
002eh mov rsi,rdx                             ; MOV(Mov_r64_rm64) [RSI,RDX]                encoding(3 bytes) = 48 8b f2
0031h lea rdi,[rsp+40h]                       ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,:sr)] encoding(5 bytes) = 48 8d 7c 24 40
0036h xor ecx,ecx                             ; XOR(Xor_r32_rm32) [ECX,ECX]                encoding(2 bytes) = 33 c9
0038h mov [rdi],ecx                           ; MOV(Mov_rm32_r32) [mem(32u,RDI:br,:sr),ECX] encoding(2 bytes) = 89 0f
003ah mov dword ptr [rdi+4],1                 ; MOV(Mov_rm32_imm32) [mem(32u,RDI:br,:sr),1h:imm32] encoding(7 bytes) = c7 47 04 01 00 00 00
0041h mov dword ptr [rdi+8],2                 ; MOV(Mov_rm32_imm32) [mem(32u,RDI:br,:sr),2h:imm32] encoding(7 bytes) = c7 47 08 02 00 00 00
0048h mov dword ptr [rdi+0Ch],3               ; MOV(Mov_rm32_imm32) [mem(32u,RDI:br,:sr),3h:imm32] encoding(7 bytes) = c7 47 0c 03 00 00 00
004fh mov dword ptr [rdi+10h],4               ; MOV(Mov_rm32_imm32) [mem(32u,RDI:br,:sr),4h:imm32] encoding(7 bytes) = c7 47 10 04 00 00 00
0056h mov dword ptr [rdi+14h],5               ; MOV(Mov_rm32_imm32) [mem(32u,RDI:br,:sr),5h:imm32] encoding(7 bytes) = c7 47 14 05 00 00 00
005dh mov dword ptr [rdi+18h],6               ; MOV(Mov_rm32_imm32) [mem(32u,RDI:br,:sr),6h:imm32] encoding(7 bytes) = c7 47 18 06 00 00 00
0064h mov dword ptr [rdi+1Ch],7               ; MOV(Mov_rm32_imm32) [mem(32u,RDI:br,:sr),7h:imm32] encoding(7 bytes) = c7 47 1c 07 00 00 00
006bh mov ecx,8                               ; MOV(Mov_r32_imm32) [ECX,8h:imm32]          encoding(5 bytes) = b9 08 00 00 00
0070h cmp ecx,0                               ; CMP(Cmp_rm32_imm8) [ECX,0h:imm32]          encoding(3 bytes) = 83 f9 00
0073h jbe near ptr 01e5h                      ; JBE(Jbe_rel32_64) [1E5h:jmp64]             encoding(6 bytes) = 0f 86 6c 01 00 00
0079h mov rcx,7FF7B4E12798h                   ; MOV(Mov_r64_imm64) [RCX,7ff7b4e12798h:imm64] encoding(10 bytes) = 48 b9 98 27 e1 b4 f7 7f 00 00
0083h call 7FF81481EFF0h                      ; CALL(Call_rel32_64) [5F3D9650h:jmp64]      encoding(5 bytes) = e8 c8 95 3d 5f
0088h mov rbx,rax                             ; MOV(Mov_r64_rm64) [RBX,RAX]                encoding(3 bytes) = 48 8b d8
008bh mov rcx,7FF7B4E07788h                   ; MOV(Mov_r64_imm64) [RCX,7ff7b4e07788h:imm64] encoding(10 bytes) = 48 b9 88 77 e0 b4 f7 7f 00 00
0095h mov edx,2                               ; MOV(Mov_r32_imm32) [EDX,2h:imm32]          encoding(5 bytes) = ba 02 00 00 00
009ah call 7FF814876E40h                      ; CALL(Call_rel32_64) [5F4314A0h:jmp64]      encoding(5 bytes) = e8 01 14 43 5f
009fh mov rbp,rax                             ; MOV(Mov_r64_rm64) [RBP,RAX]                encoding(3 bytes) = 48 8b e8
00a2h mov rcx,7FF7B54AFBE0h                   ; MOV(Mov_r64_imm64) [RCX,7ff7b54afbe0h:imm64] encoding(10 bytes) = 48 b9 e0 fb 4a b5 f7 7f 00 00
00ach call 7FF81481EFF0h                      ; CALL(Call_rel32_64) [5F3D9650h:jmp64]      encoding(5 bytes) = e8 9f 95 3d 5f
00b1h mov r8,rax                              ; MOV(Mov_r64_rm64) [R8,RAX]                 encoding(3 bytes) = 4c 8b c0
00b4h mov rcx,rbp                             ; MOV(Mov_r64_rm64) [RCX,RBP]                encoding(3 bytes) = 48 8b cd
00b7h xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
00b9h call 7FF814875F10h                      ; CALL(Call_rel32_64) [5F430570h:jmp64]      encoding(5 bytes) = e8 b2 04 43 5f
00beh mov rcx,7FF7B4D47758h                   ; MOV(Mov_r64_imm64) [RCX,7ff7b4d47758h:imm64] encoding(10 bytes) = 48 b9 58 77 d4 b4 f7 7f 00 00
00c8h call 7FF81481EFF0h                      ; CALL(Call_rel32_64) [5F3D9650h:jmp64]      encoding(5 bytes) = e8 83 95 3d 5f
00cdh mov r8,rax                              ; MOV(Mov_r64_rm64) [R8,RAX]                 encoding(3 bytes) = 4c 8b c0
00d0h mov rcx,rbp                             ; MOV(Mov_r64_rm64) [RCX,RBP]                encoding(3 bytes) = 48 8b cd
00d3h mov edx,1                               ; MOV(Mov_r32_imm32) [EDX,1h:imm32]          encoding(5 bytes) = ba 01 00 00 00
00d8h call 7FF814875F10h                      ; CALL(Call_rel32_64) [5F430570h:jmp64]      encoding(5 bytes) = e8 93 04 43 5f
00ddh mov dword ptr [rsp+20h],3               ; MOV(Mov_rm32_imm32) [mem(32u,RSP:br,:sr),3h:imm32] encoding(8 bytes) = c7 44 24 20 03 00 00 00
00e5h mov [rsp+28h],rbp                       ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RBP] encoding(5 bytes) = 48 89 6c 24 28
00eah xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
00ech mov [rsp+30h],rdx                       ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RDX] encoding(5 bytes) = 48 89 54 24 30
00f1h mov rdx,13C10014300h                    ; MOV(Mov_r64_imm64) [RDX,13c10014300h:imm64] encoding(10 bytes) = 48 ba 00 43 01 10 3c 01 00 00
00fbh mov rdx,[rdx]                           ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)] encoding(3 bytes) = 48 8b 12
00feh mov rcx,rbx                             ; MOV(Mov_r64_rm64) [RCX,RBX]                encoding(3 bytes) = 48 8b cb
0101h mov r8d,1Ch                             ; MOV(Mov_r32_imm32) [R8D,1ch:imm32]         encoding(6 bytes) = 41 b8 1c 00 00 00
0107h xor r9d,r9d                             ; XOR(Xor_r32_rm32) [R9D,R9D]                encoding(3 bytes) = 45 33 c9
010ah call 7FF81420CEB0h                      ; CALL(Call_rel32_64) [5EDC7510h:jmp64]      encoding(5 bytes) = e8 01 74 dc 5e
010fh mov rbx,rax                             ; MOV(Mov_r64_rm64) [RBX,RAX]                encoding(3 bytes) = 48 8b d8
0112h mov rcx,7FF7B4D452C0h                   ; MOV(Mov_r64_imm64) [RCX,7ff7b4d452c0h:imm64] encoding(10 bytes) = 48 b9 c0 52 d4 b4 f7 7f 00 00
011ch mov edx,2                               ; MOV(Mov_r32_imm32) [EDX,2h:imm32]          encoding(5 bytes) = ba 02 00 00 00
0121h call 7FF814876E40h                      ; CALL(Call_rel32_64) [5F4314A0h:jmp64]      encoding(5 bytes) = e8 7a 13 43 5f
0126h mov rbp,rax                             ; MOV(Mov_r64_rm64) [RBP,RAX]                encoding(3 bytes) = 48 8b e8
0129h mov rcx,7FF7B54AFBE0h                   ; MOV(Mov_r64_imm64) [RCX,7ff7b54afbe0h:imm64] encoding(10 bytes) = 48 b9 e0 fb 4a b5 f7 7f 00 00
0133h call 7FF814876CB0h                      ; CALL(Call_rel32_64) [5F431310h:jmp64]      encoding(5 bytes) = e8 d8 11 43 5f
0138h vmovdqu ymm0,ymmword ptr [rdi]          ; VMOVDQU(VEX_Vmovdqu_ymm_ymmm256) [YMM0,mem(Packed256_Int32,RDI:br,:sr)] encoding(VEX, 4 bytes) = c5 fe 6f 07
013ch vmovupd [rax+8],ymm0                    ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RAX:br,:sr),YMM0] encoding(VEX, 5 bytes) = c5 fd 11 40 08
0141h mov r8,rax                              ; MOV(Mov_r64_rm64) [R8,RAX]                 encoding(3 bytes) = 4c 8b c0
0144h mov rcx,rbp                             ; MOV(Mov_r64_rm64) [RCX,RBP]                encoding(3 bytes) = 48 8b cd
0147h xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
0149h call 7FF814875F10h                      ; CALL(Call_rel32_64) [5F430570h:jmp64]      encoding(5 bytes) = e8 22 04 43 5f
014eh mov rcx,7FF7B4D47758h                   ; MOV(Mov_r64_imm64) [RCX,7ff7b4d47758h:imm64] encoding(10 bytes) = 48 b9 58 77 d4 b4 f7 7f 00 00
0158h call 7FF814876CB0h                      ; CALL(Call_rel32_64) [5F431310h:jmp64]      encoding(5 bytes) = e8 b3 11 43 5f
015dh mov byte ptr [rax+8],1                  ; MOV(Mov_rm8_imm8) [mem(8u,RAX:br,:sr),1h:imm8] encoding(4 bytes) = c6 40 08 01
0161h mov r8,rax                              ; MOV(Mov_r64_rm64) [R8,RAX]                 encoding(3 bytes) = 4c 8b c0
0164h mov rcx,rbp                             ; MOV(Mov_r64_rm64) [RCX,RBP]                encoding(3 bytes) = 48 8b cd
0167h mov edx,1                               ; MOV(Mov_r32_imm32) [EDX,1h:imm32]          encoding(5 bytes) = ba 01 00 00 00
016ch call 7FF814875F10h                      ; CALL(Call_rel32_64) [5F430570h:jmp64]      encoding(5 bytes) = e8 ff 03 43 5f
0171h mov [rsp+20h],rbp                       ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RBP] encoding(5 bytes) = 48 89 6c 24 20
0176h xor ecx,ecx                             ; XOR(Xor_r32_rm32) [ECX,ECX]                encoding(2 bytes) = 33 c9
0178h mov [rsp+28h],rcx                       ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RCX] encoding(5 bytes) = 48 89 4c 24 28
017dh mov rcx,rbx                             ; MOV(Mov_r64_rm64) [RCX,RBX]                encoding(3 bytes) = 48 8b cb
0180h xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
0182h xor r8d,r8d                             ; XOR(Xor_r32_rm32) [R8D,R8D]                encoding(3 bytes) = 45 33 c0
0185h xor r9d,r9d                             ; XOR(Xor_r32_rm32) [R9D,R9D]                encoding(3 bytes) = 45 33 c9
0188h mov rax,[rbx]                           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RBX:br,:sr)] encoding(3 bytes) = 48 8b 03
018bh mov rax,[rax+58h]                       ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)] encoding(4 bytes) = 48 8b 40 58
018fh call qword ptr [rax+38h]                ; CALL(Call_rm64) [mem(QwordOffset,RAX:br,:sr)] encoding(3 bytes) = ff 50 38
0192h mov rdi,rax                             ; MOV(Mov_r64_rm64) [RDI,RAX]                encoding(3 bytes) = 48 8b f8
0195h mov rdx,7FF7B54AFBE0h                   ; MOV(Mov_r64_imm64) [RDX,7ff7b54afbe0h:imm64] encoding(10 bytes) = 48 ba e0 fb 4a b5 f7 7f 00 00
019fh cmp [rdi],rdx                           ; CMP(Cmp_rm64_r64) [mem(64u,RDI:br,:sr),RDX] encoding(3 bytes) = 48 39 17
01a2h je short 01b6h                          ; JE(Je_rel8_64) [1B6h:jmp64]                encoding(2 bytes) = 74 12
01a4h mov rdx,rdi                             ; MOV(Mov_r64_rm64) [RDX,RDI]                encoding(3 bytes) = 48 8b d7
01a7h mov rcx,7FF7B54AFBE0h                   ; MOV(Mov_r64_imm64) [RCX,7ff7b54afbe0h:imm64] encoding(10 bytes) = 48 b9 e0 fb 4a b5 f7 7f 00 00
01b1h call 7FF814843360h                      ; CALL(Call_rel32_64) [5F3FD9C0h:jmp64]      encoding(5 bytes) = e8 0a d8 3f 5f
01b6h vmovupd ymm0,[rdi+8]                    ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDI:br,:sr)] encoding(VEX, 5 bytes) = c5 fd 10 47 08
01bbh vmovupd [rsi],ymm0                      ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RSI:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 06
01bfh mov rax,rsi                             ; MOV(Mov_r64_rm64) [RAX,RSI]                encoding(3 bytes) = 48 8b c6
01c2h mov rcx,0DF5C731C1028h                  ; MOV(Mov_r64_imm64) [RCX,df5c731c1028h:imm64] encoding(10 bytes) = 48 b9 28 10 1c 73 5c df 00 00
01cch cmp [rsp+60h],rcx                       ; CMP(Cmp_rm64_r64) [mem(64u,RSP:br,:sr),RCX] encoding(5 bytes) = 48 39 4c 24 60
01d1h je short 01d8h                          ; JE(Je_rel8_64) [1D8h:jmp64]                encoding(2 bytes) = 74 05
01d3h call 7FF8149A1650h                      ; CALL(Call_rel32_64) [5F55BCB0h:jmp64]      encoding(5 bytes) = e8 d8 ba 55 5f
01d8h nop                                     ; NOP(Nopd)                                  encoding(1 byte ) = 90
01d9h vzeroupper                              ; VZEROUPPER(VEX_Vzeroupper)                 encoding(VEX, 3 bytes) = c5 f8 77
01dch add rsp,68h                             ; ADD(Add_rm64_imm8) [RSP,68h:imm64]         encoding(4 bytes) = 48 83 c4 68
01e0h pop rbx                                 ; POP(Pop_r64) [RBX]                         encoding(1 byte ) = 5b
01e1h pop rbp                                 ; POP(Pop_r64) [RBP]                         encoding(1 byte ) = 5d
01e2h pop rsi                                 ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
01e3h pop rdi                                 ; POP(Pop_r64) [RDI]                         encoding(1 byte ) = 5f
01e4h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
01e5h call 7FF81499FDD0h                      ; CALL(Call_rel32_64) [5F55A430h:jmp64]      encoding(5 bytes) = e8 46 a2 55 5f
01eah int 3                                   ; INT(Int3)                                  encoding(1 byte ) = cc
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int Switch14(int x)
; static ReadOnlySpan<byte> Switch14Bytes => new byte[209]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x4A,0xFF,0x83,0xF9,0x0D,0x77,0x18,0x8B,0xC1,0x48,0x8D,0x15,0xC2,0x00,0x00,0x00,0x8B,0x14,0x82,0x48,0x8D,0x0D,0xE5,0xFF,0xFF,0xFF,0x48,0x03,0xD1,0xFF,0xE2,0x81,0xC2,0xA8,0xE4,0xFF,0xFF,0x83,0xFA,0x04,0x0F,0x87,0x9A,0x00,0x00,0x00,0x8B,0xC2,0x48,0x8D,0x15,0xD3,0x00,0x00,0x00,0x8B,0x14,0x82,0x48,0x8D,0x0D,0xBE,0xFF,0xFF,0xFF,0x48,0x03,0xD1,0xFF,0xE2,0xB8,0x01,0x00,0x00,0x00,0xC3,0xB8,0x04,0x00,0x00,0x00,0xC3,0xB8,0x08,0x00,0x00,0x00,0xC3,0xB8,0x10,0x00,0x00,0x00,0xEB,0x6B,0xB8,0x20,0x00,0x00,0x00,0xEB,0x64,0xB8,0x40,0x00,0x00,0x00,0xEB,0x5D,0xB8,0x80,0x00,0x00,0x00,0xEB,0x56,0xB8,0x00,0x01,0x00,0x00,0xEB,0x4F,0xB8,0x00,0x02,0x00,0x00,0xEB,0x48,0xB8,0x00,0x04,0x00,0x00,0xEB,0x41,0xB8,0xEC,0x07,0x00,0x00,0xEB,0x3A,0xB8,0x0A,0x00,0x00,0x00,0xEB,0x33,0xB8,0x14,0x00,0x00,0x00,0xEB,0x2C,0xB8,0x1E,0x00,0x00,0x00,0xEB,0x25,0xB8,0x00,0x04,0x00,0x00,0xEB,0x1E,0xB8,0xEC,0x07,0x00,0x00,0xEB,0x17,0xB8,0x0A,0x00,0x00,0x00,0xEB,0x10,0xB8,0x14,0x00,0x00,0x00,0xEB,0x09,0xB8,0x1E,0x00,0x00,0x00,0xEB,0x02,0x33,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h lea ecx,[rdx-1]                         ; LEA(Lea_r32_m) [ECX,mem(Unknown,RDX:br,:sr)] encoding(3 bytes) = 8d 4a ff
0008h cmp ecx,0Dh                             ; CMP(Cmp_rm32_imm8) [ECX,dh:imm32]          encoding(3 bytes) = 83 f9 0d
000bh ja short 0025h                          ; JA(Ja_rel8_64) [25h:jmp64]                 encoding(2 bytes) = 77 18
000dh mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
000fh lea rdx,[7FF7B5445C88h]                 ; LEA(Lea_r64_m) [RDX,mem(Unknown,RIP:br,:sr)] encoding(7 bytes) = 48 8d 15 c2 00 00 00
0016h mov edx,[rdx+rax*4]                     ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,:sr)] encoding(3 bytes) = 8b 14 82
0019h lea rcx,[7FF7B5445BB5h]                 ; LEA(Lea_r64_m) [RCX,mem(Unknown,RIP:br,:sr)] encoding(7 bytes) = 48 8d 0d e5 ff ff ff
0020h add rdx,rcx                             ; ADD(Add_r64_rm64) [RDX,RCX]                encoding(3 bytes) = 48 03 d1
0023h jmp rdx                                 ; JMP(Jmp_rm64) [RDX]                        encoding(2 bytes) = ff e2
0025h add edx,0FFFFE4A8h                      ; ADD(Add_rm32_imm32) [EDX,ffffe4a8h:imm32]  encoding(6 bytes) = 81 c2 a8 e4 ff ff
002bh cmp edx,4                               ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]          encoding(3 bytes) = 83 fa 04
002eh ja near ptr 00ceh                       ; JA(Ja_rel32_64) [CEh:jmp64]                encoding(6 bytes) = 0f 87 9a 00 00 00
0034h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0036h lea rdx,[7FF7B5445CC0h]                 ; LEA(Lea_r64_m) [RDX,mem(Unknown,RIP:br,:sr)] encoding(7 bytes) = 48 8d 15 d3 00 00 00
003dh mov edx,[rdx+rax*4]                     ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,:sr)] encoding(3 bytes) = 8b 14 82
0040h lea rcx,[7FF7B5445BB5h]                 ; LEA(Lea_r64_m) [RCX,mem(Unknown,RIP:br,:sr)] encoding(7 bytes) = 48 8d 0d be ff ff ff
0047h add rdx,rcx                             ; ADD(Add_r64_rm64) [RDX,RCX]                encoding(3 bytes) = 48 03 d1
004ah jmp rdx                                 ; JMP(Jmp_rm64) [RDX]                        encoding(2 bytes) = ff e2
004ch mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
0051h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
0052h mov eax,4                               ; MOV(Mov_r32_imm32) [EAX,4h:imm32]          encoding(5 bytes) = b8 04 00 00 00
0057h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
0058h mov eax,8                               ; MOV(Mov_r32_imm32) [EAX,8h:imm32]          encoding(5 bytes) = b8 08 00 00 00
005dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
005eh mov eax,10h                             ; MOV(Mov_r32_imm32) [EAX,10h:imm32]         encoding(5 bytes) = b8 10 00 00 00
0063h jmp short 00d0h                         ; JMP(Jmp_rel8_64) [D0h:jmp64]               encoding(2 bytes) = eb 6b
0065h mov eax,20h                             ; MOV(Mov_r32_imm32) [EAX,20h:imm32]         encoding(5 bytes) = b8 20 00 00 00
006ah jmp short 00d0h                         ; JMP(Jmp_rel8_64) [D0h:jmp64]               encoding(2 bytes) = eb 64
006ch mov eax,40h                             ; MOV(Mov_r32_imm32) [EAX,40h:imm32]         encoding(5 bytes) = b8 40 00 00 00
0071h jmp short 00d0h                         ; JMP(Jmp_rel8_64) [D0h:jmp64]               encoding(2 bytes) = eb 5d
0073h mov eax,80h                             ; MOV(Mov_r32_imm32) [EAX,80h:imm32]         encoding(5 bytes) = b8 80 00 00 00
0078h jmp short 00d0h                         ; JMP(Jmp_rel8_64) [D0h:jmp64]               encoding(2 bytes) = eb 56
007ah mov eax,100h                            ; MOV(Mov_r32_imm32) [EAX,100h:imm32]        encoding(5 bytes) = b8 00 01 00 00
007fh jmp short 00d0h                         ; JMP(Jmp_rel8_64) [D0h:jmp64]               encoding(2 bytes) = eb 4f
0081h mov eax,200h                            ; MOV(Mov_r32_imm32) [EAX,200h:imm32]        encoding(5 bytes) = b8 00 02 00 00
0086h jmp short 00d0h                         ; JMP(Jmp_rel8_64) [D0h:jmp64]               encoding(2 bytes) = eb 48
0088h mov eax,400h                            ; MOV(Mov_r32_imm32) [EAX,400h:imm32]        encoding(5 bytes) = b8 00 04 00 00
008dh jmp short 00d0h                         ; JMP(Jmp_rel8_64) [D0h:jmp64]               encoding(2 bytes) = eb 41
008fh mov eax,7ECh                            ; MOV(Mov_r32_imm32) [EAX,7ech:imm32]        encoding(5 bytes) = b8 ec 07 00 00
0094h jmp short 00d0h                         ; JMP(Jmp_rel8_64) [D0h:jmp64]               encoding(2 bytes) = eb 3a
0096h mov eax,0Ah                             ; MOV(Mov_r32_imm32) [EAX,ah:imm32]          encoding(5 bytes) = b8 0a 00 00 00
009bh jmp short 00d0h                         ; JMP(Jmp_rel8_64) [D0h:jmp64]               encoding(2 bytes) = eb 33
009dh mov eax,14h                             ; MOV(Mov_r32_imm32) [EAX,14h:imm32]         encoding(5 bytes) = b8 14 00 00 00
00a2h jmp short 00d0h                         ; JMP(Jmp_rel8_64) [D0h:jmp64]               encoding(2 bytes) = eb 2c
00a4h mov eax,1Eh                             ; MOV(Mov_r32_imm32) [EAX,1eh:imm32]         encoding(5 bytes) = b8 1e 00 00 00
00a9h jmp short 00d0h                         ; JMP(Jmp_rel8_64) [D0h:jmp64]               encoding(2 bytes) = eb 25
00abh mov eax,400h                            ; MOV(Mov_r32_imm32) [EAX,400h:imm32]        encoding(5 bytes) = b8 00 04 00 00
00b0h jmp short 00d0h                         ; JMP(Jmp_rel8_64) [D0h:jmp64]               encoding(2 bytes) = eb 1e
00b2h mov eax,7ECh                            ; MOV(Mov_r32_imm32) [EAX,7ech:imm32]        encoding(5 bytes) = b8 ec 07 00 00
00b7h jmp short 00d0h                         ; JMP(Jmp_rel8_64) [D0h:jmp64]               encoding(2 bytes) = eb 17
00b9h mov eax,0Ah                             ; MOV(Mov_r32_imm32) [EAX,ah:imm32]          encoding(5 bytes) = b8 0a 00 00 00
00beh jmp short 00d0h                         ; JMP(Jmp_rel8_64) [D0h:jmp64]               encoding(2 bytes) = eb 10
00c0h mov eax,14h                             ; MOV(Mov_r32_imm32) [EAX,14h:imm32]         encoding(5 bytes) = b8 14 00 00 00
00c5h jmp short 00d0h                         ; JMP(Jmp_rel8_64) [D0h:jmp64]               encoding(2 bytes) = eb 09
00c7h mov eax,1Eh                             ; MOV(Mov_r32_imm32) [EAX,1eh:imm32]         encoding(5 bytes) = b8 1e 00 00 00
00cch jmp short 00d0h                         ; JMP(Jmp_rel8_64) [D0h:jmp64]               encoding(2 bytes) = eb 02
00ceh xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
00d0h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int IfElse10(int x)
; static ReadOnlySpan<byte> IfElse10Bytes => new byte[125]{0x0F,0x1F,0x44,0x00,0x00,0x83,0xFA,0x01,0x75,0x06,0xB8,0x01,0x00,0x00,0x00,0xC3,0x83,0xFA,0x02,0x75,0x06,0xB8,0x04,0x00,0x00,0x00,0xC3,0x83,0xFA,0x03,0x75,0x06,0xB8,0x08,0x00,0x00,0x00,0xC3,0x83,0xFA,0x04,0x75,0x07,0xB8,0x10,0x00,0x00,0x00,0xEB,0x4A,0x83,0xFA,0x05,0x75,0x07,0xB8,0x20,0x00,0x00,0x00,0xEB,0x3E,0x83,0xFA,0x06,0x75,0x07,0xB8,0x40,0x00,0x00,0x00,0xEB,0x32,0x83,0xFA,0x07,0x75,0x07,0xB8,0x80,0x00,0x00,0x00,0xEB,0x26,0x83,0xFA,0x08,0x75,0x07,0xB8,0x00,0x01,0x00,0x00,0xEB,0x1A,0x83,0xFA,0x09,0x75,0x07,0xB8,0x00,0x02,0x00,0x00,0xEB,0x0E,0x83,0xFA,0x0A,0x75,0x07,0xB8,0x00,0x04,0x00,0x00,0xEB,0x02,0x33,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp edx,1                               ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]          encoding(3 bytes) = 83 fa 01
0008h jne short 0010h                         ; JNE(Jne_rel8_64) [10h:jmp64]               encoding(2 bytes) = 75 06
000ah mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
0010h cmp edx,2                               ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]          encoding(3 bytes) = 83 fa 02
0013h jne short 001bh                         ; JNE(Jne_rel8_64) [1Bh:jmp64]               encoding(2 bytes) = 75 06
0015h mov eax,4                               ; MOV(Mov_r32_imm32) [EAX,4h:imm32]          encoding(5 bytes) = b8 04 00 00 00
001ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
001bh cmp edx,3                               ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]          encoding(3 bytes) = 83 fa 03
001eh jne short 0026h                         ; JNE(Jne_rel8_64) [26h:jmp64]               encoding(2 bytes) = 75 06
0020h mov eax,8                               ; MOV(Mov_r32_imm32) [EAX,8h:imm32]          encoding(5 bytes) = b8 08 00 00 00
0025h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
0026h cmp edx,4                               ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]          encoding(3 bytes) = 83 fa 04
0029h jne short 0032h                         ; JNE(Jne_rel8_64) [32h:jmp64]               encoding(2 bytes) = 75 07
002bh mov eax,10h                             ; MOV(Mov_r32_imm32) [EAX,10h:imm32]         encoding(5 bytes) = b8 10 00 00 00
0030h jmp short 007ch                         ; JMP(Jmp_rel8_64) [7Ch:jmp64]               encoding(2 bytes) = eb 4a
0032h cmp edx,5                               ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]          encoding(3 bytes) = 83 fa 05
0035h jne short 003eh                         ; JNE(Jne_rel8_64) [3Eh:jmp64]               encoding(2 bytes) = 75 07
0037h mov eax,20h                             ; MOV(Mov_r32_imm32) [EAX,20h:imm32]         encoding(5 bytes) = b8 20 00 00 00
003ch jmp short 007ch                         ; JMP(Jmp_rel8_64) [7Ch:jmp64]               encoding(2 bytes) = eb 3e
003eh cmp edx,6                               ; CMP(Cmp_rm32_imm8) [EDX,6h:imm32]          encoding(3 bytes) = 83 fa 06
0041h jne short 004ah                         ; JNE(Jne_rel8_64) [4Ah:jmp64]               encoding(2 bytes) = 75 07
0043h mov eax,40h                             ; MOV(Mov_r32_imm32) [EAX,40h:imm32]         encoding(5 bytes) = b8 40 00 00 00
0048h jmp short 007ch                         ; JMP(Jmp_rel8_64) [7Ch:jmp64]               encoding(2 bytes) = eb 32
004ah cmp edx,7                               ; CMP(Cmp_rm32_imm8) [EDX,7h:imm32]          encoding(3 bytes) = 83 fa 07
004dh jne short 0056h                         ; JNE(Jne_rel8_64) [56h:jmp64]               encoding(2 bytes) = 75 07
004fh mov eax,80h                             ; MOV(Mov_r32_imm32) [EAX,80h:imm32]         encoding(5 bytes) = b8 80 00 00 00
0054h jmp short 007ch                         ; JMP(Jmp_rel8_64) [7Ch:jmp64]               encoding(2 bytes) = eb 26
0056h cmp edx,8                               ; CMP(Cmp_rm32_imm8) [EDX,8h:imm32]          encoding(3 bytes) = 83 fa 08
0059h jne short 0062h                         ; JNE(Jne_rel8_64) [62h:jmp64]               encoding(2 bytes) = 75 07
005bh mov eax,100h                            ; MOV(Mov_r32_imm32) [EAX,100h:imm32]        encoding(5 bytes) = b8 00 01 00 00
0060h jmp short 007ch                         ; JMP(Jmp_rel8_64) [7Ch:jmp64]               encoding(2 bytes) = eb 1a
0062h cmp edx,9                               ; CMP(Cmp_rm32_imm8) [EDX,9h:imm32]          encoding(3 bytes) = 83 fa 09
0065h jne short 006eh                         ; JNE(Jne_rel8_64) [6Eh:jmp64]               encoding(2 bytes) = 75 07
0067h mov eax,200h                            ; MOV(Mov_r32_imm32) [EAX,200h:imm32]        encoding(5 bytes) = b8 00 02 00 00
006ch jmp short 007ch                         ; JMP(Jmp_rel8_64) [7Ch:jmp64]               encoding(2 bytes) = eb 0e
006eh cmp edx,0Ah                             ; CMP(Cmp_rm32_imm8) [EDX,ah:imm32]          encoding(3 bytes) = 83 fa 0a
0071h jne short 007ah                         ; JNE(Jne_rel8_64) [7Ah:jmp64]               encoding(2 bytes) = 75 07
0073h mov eax,400h                            ; MOV(Mov_r32_imm32) [EAX,400h:imm32]        encoding(5 bytes) = b8 00 04 00 00
0078h jmp short 007ch                         ; JMP(Jmp_rel8_64) [7Ch:jmp64]               encoding(2 bytes) = eb 02
007ah xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
007ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint Or8Inline(uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7)
; static ReadOnlySpan<byte> Or8InlineBytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x0B,0xD1,0x41,0x0B,0xD0,0x41,0x0B,0xD1,0x0B,0x54,0x24,0x28,0x0B,0x54,0x24,0x30,0x8B,0xC2,0x0B,0x44,0x24,0x38,0x0B,0x44,0x24,0x40,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h or edx,ecx                              ; OR(Or_r32_rm32) [EDX,ECX]                  encoding(2 bytes) = 0b d1
0007h or edx,r8d                              ; OR(Or_r32_rm32) [EDX,R8D]                  encoding(3 bytes) = 41 0b d0
000ah or edx,r9d                              ; OR(Or_r32_rm32) [EDX,R9D]                  encoding(3 bytes) = 41 0b d1
000dh or edx,[rsp+28h]                        ; OR(Or_r32_rm32) [EDX,mem(32u,RSP:br,:sr)]  encoding(4 bytes) = 0b 54 24 28
0011h or edx,[rsp+30h]                        ; OR(Or_r32_rm32) [EDX,mem(32u,RSP:br,:sr)]  encoding(4 bytes) = 0b 54 24 30
0015h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0017h or eax,[rsp+38h]                        ; OR(Or_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]  encoding(4 bytes) = 0b 44 24 38
001bh or eax,[rsp+40h]                        ; OR(Or_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]  encoding(4 bytes) = 0b 44 24 40
001fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint RotLU32Inline(uint x, int offset)
; static ReadOnlySpan<byte> RotLU32InlineBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x8B,0xCA,0xD3,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h mov ecx,edx                             ; MOV(Mov_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 8b ca
0009h rol eax,cl                              ; ROL(Rol_rm32_CL) [EAX,CL]                  encoding(2 bytes) = d3 c0
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int ChoiceIfElse5Inline(int x)
; static ReadOnlySpan<byte> ChoiceIfElse5InlineBytes => new byte[65]{0x0F,0x1F,0x44,0x00,0x00,0x83,0xFA,0x01,0x75,0x06,0xB8,0x01,0x00,0x00,0x00,0xC3,0x83,0xFA,0x02,0x75,0x06,0xB8,0x04,0x00,0x00,0x00,0xC3,0x83,0xFA,0x03,0x75,0x06,0xB8,0x08,0x00,0x00,0x00,0xC3,0x83,0xFA,0x04,0x75,0x07,0xB8,0x10,0x00,0x00,0x00,0xEB,0x0E,0x83,0xFA,0x05,0x75,0x07,0xB8,0x20,0x00,0x00,0x00,0xEB,0x02,0x33,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp edx,1                               ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]          encoding(3 bytes) = 83 fa 01
0008h jne short 0010h                         ; JNE(Jne_rel8_64) [10h:jmp64]               encoding(2 bytes) = 75 06
000ah mov eax,1                               ; MOV(Mov_r32_imm32) [EAX,1h:imm32]          encoding(5 bytes) = b8 01 00 00 00
000fh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
0010h cmp edx,2                               ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]          encoding(3 bytes) = 83 fa 02
0013h jne short 001bh                         ; JNE(Jne_rel8_64) [1Bh:jmp64]               encoding(2 bytes) = 75 06
0015h mov eax,4                               ; MOV(Mov_r32_imm32) [EAX,4h:imm32]          encoding(5 bytes) = b8 04 00 00 00
001ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
001bh cmp edx,3                               ; CMP(Cmp_rm32_imm8) [EDX,3h:imm32]          encoding(3 bytes) = 83 fa 03
001eh jne short 0026h                         ; JNE(Jne_rel8_64) [26h:jmp64]               encoding(2 bytes) = 75 06
0020h mov eax,8                               ; MOV(Mov_r32_imm32) [EAX,8h:imm32]          encoding(5 bytes) = b8 08 00 00 00
0025h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
0026h cmp edx,4                               ; CMP(Cmp_rm32_imm8) [EDX,4h:imm32]          encoding(3 bytes) = 83 fa 04
0029h jne short 0032h                         ; JNE(Jne_rel8_64) [32h:jmp64]               encoding(2 bytes) = 75 07
002bh mov eax,10h                             ; MOV(Mov_r32_imm32) [EAX,10h:imm32]         encoding(5 bytes) = b8 10 00 00 00
0030h jmp short 0040h                         ; JMP(Jmp_rel8_64) [40h:jmp64]               encoding(2 bytes) = eb 0e
0032h cmp edx,5                               ; CMP(Cmp_rm32_imm8) [EDX,5h:imm32]          encoding(3 bytes) = 83 fa 05
0035h jne short 003eh                         ; JNE(Jne_rel8_64) [3Eh:jmp64]               encoding(2 bytes) = 75 07
0037h mov eax,20h                             ; MOV(Mov_r32_imm32) [EAX,20h:imm32]         encoding(5 bytes) = b8 20 00 00 00
003ch jmp short 0040h                         ; JMP(Jmp_rel8_64) [40h:jmp64]               encoding(2 bytes) = eb 02
003eh xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0040h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int CheckMatches()
; static ReadOnlySpan<byte> CheckMatchesBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0xFF,0x03,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,3FFh                            ; MOV(Mov_r32_imm32) [EAX,3ffh:imm32]        encoding(5 bytes) = b8 ff 03 00 00
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<byte> ReadU8Data(int count)
; static ReadOnlySpan<byte> ReadU8DataBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xFD,0xF2,0x78,0x7E,0x3C,0x01,0x00,0x00,0x48,0x89,0x02,0xC7,0x42,0x08,0x40,0x00,0x00,0x00,0x48,0x8B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,13C7E78F2FDh                    ; MOV(Mov_r64_imm64) [RAX,13c7e78f2fdh:imm64] encoding(10 bytes) = 48 b8 fd f2 78 7e 3c 01 00 00
000fh mov [rdx],rax                           ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX] encoding(3 bytes) = 48 89 02
0012h mov dword ptr [rdx+8],40h               ; MOV(Mov_rm32_imm32) [mem(32u,RDX:br,:sr),40h:imm32] encoding(7 bytes) = c7 42 08 40 00 00 00
0019h mov rax,rdx                             ; MOV(Mov_r64_rm64) [RAX,RDX]                encoding(3 bytes) = 48 8b c2
001ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ReadOnlySpan<uint> ReadU32Data(int count)
; static ReadOnlySpan<byte> ReadU32DataBytes => new byte[21]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xCA,0x48,0xB8,0x50,0x72,0xD8,0xB4,0xF7,0x7F,0x00,0x00,0x48,0xFF,0xE0};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rcx,rdx                             ; MOV(Mov_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 8b ca
0008h mov rax,7FF7B4D87250h                   ; MOV(Mov_r64_imm64) [RAX,7ff7b4d87250h:imm64] encoding(10 bytes) = 48 b8 50 72 d8 b4 f7 7f 00 00
0012h jmp rax                                 ; JMP(Jmp_rm64) [RAX]                        encoding(3 bytes) = 48 ff e0
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void VoidReturn()
; static ReadOnlySpan<byte> VoidReturnBytes => new byte[29]{0x48,0x83,0xEC,0x28,0x90,0x48,0xB9,0x60,0x30,0x00,0x10,0x3C,0x01,0x00,0x00,0x48,0x8B,0x09,0xE8,0x89,0xAE,0xFF,0xFF,0x90,0x48,0x83,0xC4,0x28,0xC3};
0000h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0004h nop                                     ; NOP(Nopd)                                  encoding(1 byte ) = 90
0005h mov rcx,13C10003060h                    ; MOV(Mov_r64_imm64) [RCX,13c10003060h:imm64] encoding(10 bytes) = 48 b9 60 30 00 10 3c 01 00 00
000fh mov rcx,[rcx]                           ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,:sr)] encoding(3 bytes) = 48 8b 09
0012h call 7FF7B5441560h                      ; CALL(Call_rel32_64) [FFFFFFFFFFFFAEA0h:jmp64] encoding(5 bytes) = e8 89 ae ff ff
0017h nop                                     ; NOP(Nopd)                                  encoding(1 byte ) = 90
0018h add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
001ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int SizeTest()
; static ReadOnlySpan<byte> SizeTestBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x07,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,7                               ; MOV(Mov_r32_imm32) [EAX,7h:imm32]          encoding(5 bytes) = b8 07 00 00 00
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void VoidCalls1()
; static ReadOnlySpan<byte> VoidCalls1Bytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0x48,0xB8,0xC0,0x66,0x44,0xB5,0xF7,0x7F,0x00,0x00,0x48,0xFF,0xE0};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,7FF7B54466C0h                   ; MOV(Mov_r64_imm64) [RAX,7ff7b54466c0h:imm64] encoding(10 bytes) = 48 b8 c0 66 44 b5 f7 7f 00 00
000fh jmp rax                                 ; JMP(Jmp_rm64) [RAX]                        encoding(3 bytes) = 48 ff e0
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void VoidCalls2()
; static ReadOnlySpan<byte> VoidCalls2Bytes => new byte[37]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0xCE,0xE8,0x60,0xFF,0xFF,0xFF,0x48,0x8B,0xCE,0x48,0xB8,0xC0,0x66,0x44,0xB5,0xF7,0x7F,0x00,0x00,0x48,0x83,0xC4,0x20,0x5E,0x48,0xFF,0xE0};
0000h push rsi                                ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0001h sub rsp,20h                             ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]         encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                             ; MOV(Mov_r64_rm64) [RSI,RCX]                encoding(3 bytes) = 48 8b f1
0008h mov rcx,rsi                             ; MOV(Mov_r64_rm64) [RCX,RSI]                encoding(3 bytes) = 48 8b ce
000bh call 7FF7B54466C0h                      ; CALL(Call_rel32_64) [FFFFFFFFFFFFFF70h:jmp64] encoding(5 bytes) = e8 60 ff ff ff
0010h mov rcx,rsi                             ; MOV(Mov_r64_rm64) [RCX,RSI]                encoding(3 bytes) = 48 8b ce
0013h mov rax,7FF7B54466C0h                   ; MOV(Mov_r64_imm64) [RAX,7ff7b54466c0h:imm64] encoding(10 bytes) = 48 b8 c0 66 44 b5 f7 7f 00 00
001dh add rsp,20h                             ; ADD(Add_rm64_imm8) [RSP,20h:imm64]         encoding(4 bytes) = 48 83 c4 20
0021h pop rsi                                 ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
0022h jmp rax                                 ; JMP(Jmp_rm64) [RAX]                        encoding(3 bytes) = 48 ff e0
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void VoidCalls3()
; static ReadOnlySpan<byte> VoidCalls3Bytes => new byte[45]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0xCE,0xE8,0x20,0xFF,0xFF,0xFF,0x48,0x8B,0xCE,0xE8,0x18,0xFF,0xFF,0xFF,0x48,0x8B,0xCE,0x48,0xB8,0xC0,0x66,0x44,0xB5,0xF7,0x7F,0x00,0x00,0x48,0x83,0xC4,0x20,0x5E,0x48,0xFF,0xE0};
0000h push rsi                                ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0001h sub rsp,20h                             ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]         encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                             ; MOV(Mov_r64_rm64) [RSI,RCX]                encoding(3 bytes) = 48 8b f1
0008h mov rcx,rsi                             ; MOV(Mov_r64_rm64) [RCX,RSI]                encoding(3 bytes) = 48 8b ce
000bh call 7FF7B54466C0h                      ; CALL(Call_rel32_64) [FFFFFFFFFFFFFF30h:jmp64] encoding(5 bytes) = e8 20 ff ff ff
0010h mov rcx,rsi                             ; MOV(Mov_r64_rm64) [RCX,RSI]                encoding(3 bytes) = 48 8b ce
0013h call 7FF7B54466C0h                      ; CALL(Call_rel32_64) [FFFFFFFFFFFFFF30h:jmp64] encoding(5 bytes) = e8 18 ff ff ff
0018h mov rcx,rsi                             ; MOV(Mov_r64_rm64) [RCX,RSI]                encoding(3 bytes) = 48 8b ce
001bh mov rax,7FF7B54466C0h                   ; MOV(Mov_r64_imm64) [RAX,7ff7b54466c0h:imm64] encoding(10 bytes) = 48 b8 c0 66 44 b5 f7 7f 00 00
0025h add rsp,20h                             ; ADD(Add_rm64_imm8) [RSP,20h:imm64]         encoding(4 bytes) = 48 83 c4 20
0029h pop rsi                                 ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
002ah jmp rax                                 ; JMP(Jmp_rm64) [RAX]                        encoding(3 bytes) = 48 ff e0
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void VoidCalls4()
; static ReadOnlySpan<byte> VoidCalls4Bytes => new byte[53]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0xCE,0xE8,0xD0,0xFE,0xFF,0xFF,0x48,0x8B,0xCE,0xE8,0xC8,0xFE,0xFF,0xFF,0x48,0x8B,0xCE,0xE8,0xC0,0xFE,0xFF,0xFF,0x48,0x8B,0xCE,0x48,0xB8,0xC0,0x66,0x44,0xB5,0xF7,0x7F,0x00,0x00,0x48,0x83,0xC4,0x20,0x5E,0x48,0xFF,0xE0};
0000h push rsi                                ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0001h sub rsp,20h                             ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]         encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                             ; MOV(Mov_r64_rm64) [RSI,RCX]                encoding(3 bytes) = 48 8b f1
0008h mov rcx,rsi                             ; MOV(Mov_r64_rm64) [RCX,RSI]                encoding(3 bytes) = 48 8b ce
000bh call 7FF7B54466C0h                      ; CALL(Call_rel32_64) [FFFFFFFFFFFFFEE0h:jmp64] encoding(5 bytes) = e8 d0 fe ff ff
0010h mov rcx,rsi                             ; MOV(Mov_r64_rm64) [RCX,RSI]                encoding(3 bytes) = 48 8b ce
0013h call 7FF7B54466C0h                      ; CALL(Call_rel32_64) [FFFFFFFFFFFFFEE0h:jmp64] encoding(5 bytes) = e8 c8 fe ff ff
0018h mov rcx,rsi                             ; MOV(Mov_r64_rm64) [RCX,RSI]                encoding(3 bytes) = 48 8b ce
001bh call 7FF7B54466C0h                      ; CALL(Call_rel32_64) [FFFFFFFFFFFFFEE0h:jmp64] encoding(5 bytes) = e8 c0 fe ff ff
0020h mov rcx,rsi                             ; MOV(Mov_r64_rm64) [RCX,RSI]                encoding(3 bytes) = 48 8b ce
0023h mov rax,7FF7B54466C0h                   ; MOV(Mov_r64_imm64) [RAX,7ff7b54466c0h:imm64] encoding(10 bytes) = 48 b8 c0 66 44 b5 f7 7f 00 00
002dh add rsp,20h                             ; ADD(Add_rm64_imm8) [RSP,20h:imm64]         encoding(4 bytes) = 48 83 c4 20
0031h pop rsi                                 ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
0032h jmp rax                                 ; JMP(Jmp_rm64) [RAX]                        encoding(3 bytes) = 48 ff e0
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int InvokeBinOp(Func<int,int,int> f, int x, int y)
; static ReadOnlySpan<byte> InvokeBinOpBytes => new byte[34]{0x50,0x0F,0x1F,0x40,0x00,0x48,0x89,0x14,0x24,0x48,0x8B,0x4A,0x08,0x41,0x8B,0xD0,0x45,0x8B,0xC1,0x48,0x8B,0x04,0x24,0x48,0x8B,0x40,0x18,0x48,0x83,0xC4,0x08,0x48,0xFF,0xE0};
0000h push rax                                ; PUSH(Push_r64) [RAX]                       encoding(1 byte ) = 50
0001h nop dword ptr [rax]                     ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(4 bytes) = 0f 1f 40 00
0005h mov [rsp],rdx                           ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RDX] encoding(4 bytes) = 48 89 14 24
0009h mov rcx,[rdx+8]                         ; MOV(Mov_r64_rm64) [RCX,mem(64u,RDX:br,:sr)] encoding(4 bytes) = 48 8b 4a 08
000dh mov edx,r8d                             ; MOV(Mov_r32_rm32) [EDX,R8D]                encoding(3 bytes) = 41 8b d0
0010h mov r8d,r9d                             ; MOV(Mov_r32_rm32) [R8D,R9D]                encoding(3 bytes) = 45 8b c1
0013h mov rax,[rsp]                           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,:sr)] encoding(4 bytes) = 48 8b 04 24
0017h mov rax,[rax+18h]                       ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)] encoding(4 bytes) = 48 8b 40 18
001bh add rsp,8                               ; ADD(Add_rm64_imm8) [RSP,8h:imm64]          encoding(4 bytes) = 48 83 c4 08
001fh jmp rax                                 ; JMP(Jmp_rm64) [RAX]                        encoding(3 bytes) = 48 ff e0
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int AddMulInline(int x, int y)
; static ReadOnlySpan<byte> AddMulInlineBytes => new byte[17]{0x0F,0x1F,0x44,0x00,0x00,0x8D,0x04,0x11,0x0F,0xAF,0xC8,0x0F,0xAF,0xC2,0x03,0xC1,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h lea eax,[rcx+rdx]                       ; LEA(Lea_r32_m) [EAX,mem(Unknown,RCX:br,:sr)] encoding(3 bytes) = 8d 04 11
0008h imul ecx,eax                            ; IMUL(Imul_r32_rm32) [ECX,EAX]              encoding(3 bytes) = 0f af c8
000bh imul eax,edx                            ; IMUL(Imul_r32_rm32) [EAX,EDX]              encoding(3 bytes) = 0f af c2
000eh add eax,ecx                             ; ADD(Add_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 03 c1
0010h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int CallInvokeBinOp(int x, int y)
; static ReadOnlySpan<byte> CallInvokeBinOpBytes => new byte[107]{0x57,0x56,0x55,0x53,0x48,0x83,0xEC,0x28,0x48,0x8B,0xF1,0x8B,0xFA,0x41,0x8B,0xD8,0x48,0xB9,0x98,0xD9,0x5C,0xB5,0xF7,0x7F,0x00,0x00,0xE8,0xF1,0x03,0x43,0x5F,0x48,0x8B,0xE8,0x48,0x8D,0x4D,0x08,0x48,0x8B,0xD5,0xE8,0x22,0xF5,0x42,0x5F,0x48,0xB9,0x50,0xDD,0xC4,0xB4,0xF7,0x7F,0x00,0x00,0x48,0x89,0x4D,0x18,0x48,0xB9,0x70,0x68,0x44,0xB5,0xF7,0x7F,0x00,0x00,0x48,0x89,0x4D,0x20,0x48,0x8B,0xCE,0x48,0x8B,0xD5,0x44,0x8B,0xC7,0x44,0x8B,0xCB,0x48,0xB8,0x30,0x68,0x44,0xB5,0xF7,0x7F,0x00,0x00,0x48,0x83,0xC4,0x28,0x5B,0x5D,0x5E,0x5F,0x48,0xFF,0xE0};
0000h push rdi                                ; PUSH(Push_r64) [RDI]                       encoding(1 byte ) = 57
0001h push rsi                                ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0002h push rbp                                ; PUSH(Push_r64) [RBP]                       encoding(1 byte ) = 55
0003h push rbx                                ; PUSH(Push_r64) [RBX]                       encoding(1 byte ) = 53
0004h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0008h mov rsi,rcx                             ; MOV(Mov_r64_rm64) [RSI,RCX]                encoding(3 bytes) = 48 8b f1
000bh mov edi,edx                             ; MOV(Mov_r32_rm32) [EDI,EDX]                encoding(2 bytes) = 8b fa
000dh mov ebx,r8d                             ; MOV(Mov_r32_rm32) [EBX,R8D]                encoding(3 bytes) = 41 8b d8
0010h mov rcx,7FF7B55CD998h                   ; MOV(Mov_r64_imm64) [RCX,7ff7b55cd998h:imm64] encoding(10 bytes) = 48 b9 98 d9 5c b5 f7 7f 00 00
001ah call 7FF814876CB0h                      ; CALL(Call_rel32_64) [5F430410h:jmp64]      encoding(5 bytes) = e8 f1 03 43 5f
001fh mov rbp,rax                             ; MOV(Mov_r64_rm64) [RBP,RAX]                encoding(3 bytes) = 48 8b e8
0022h lea rcx,[rbp+8]                         ; LEA(Lea_r64_m) [RCX,mem(Unknown,RBP:br,:sr)] encoding(4 bytes) = 48 8d 4d 08
0026h mov rdx,rbp                             ; MOV(Mov_r64_rm64) [RDX,RBP]                encoding(3 bytes) = 48 8b d5
0029h call 7FF814875DF0h                      ; CALL(Call_rel32_64) [5F42F550h:jmp64]      encoding(5 bytes) = e8 22 f5 42 5f
002eh mov rcx,7FF7B4C4DD50h                   ; MOV(Mov_r64_imm64) [RCX,7ff7b4c4dd50h:imm64] encoding(10 bytes) = 48 b9 50 dd c4 b4 f7 7f 00 00
0038h mov [rbp+18h],rcx                       ; MOV(Mov_rm64_r64) [mem(64u,RBP:br,:sr),RCX] encoding(4 bytes) = 48 89 4d 18
003ch mov rcx,7FF7B5446870h                   ; MOV(Mov_r64_imm64) [RCX,7ff7b5446870h:imm64] encoding(10 bytes) = 48 b9 70 68 44 b5 f7 7f 00 00
0046h mov [rbp+20h],rcx                       ; MOV(Mov_rm64_r64) [mem(64u,RBP:br,:sr),RCX] encoding(4 bytes) = 48 89 4d 20
004ah mov rcx,rsi                             ; MOV(Mov_r64_rm64) [RCX,RSI]                encoding(3 bytes) = 48 8b ce
004dh mov rdx,rbp                             ; MOV(Mov_r64_rm64) [RDX,RBP]                encoding(3 bytes) = 48 8b d5
0050h mov r8d,edi                             ; MOV(Mov_r32_rm32) [R8D,EDI]                encoding(3 bytes) = 44 8b c7
0053h mov r9d,ebx                             ; MOV(Mov_r32_rm32) [R9D,EBX]                encoding(3 bytes) = 44 8b cb
0056h mov rax,7FF7B5446830h                   ; MOV(Mov_r64_imm64) [RAX,7ff7b5446830h:imm64] encoding(10 bytes) = 48 b8 30 68 44 b5 f7 7f 00 00
0060h add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
0064h pop rbx                                 ; POP(Pop_r64) [RBX]                         encoding(1 byte ) = 5b
0065h pop rbp                                 ; POP(Pop_r64) [RBP]                         encoding(1 byte ) = 5d
0066h pop rsi                                 ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
0067h pop rdi                                 ; POP(Pop_r64) [RDI]                         encoding(1 byte ) = 5f
0068h jmp rax                                 ; JMP(Jmp_rm64) [RAX]                        encoding(3 bytes) = 48 ff e0
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int And(int a, int b)
; static ReadOnlySpan<byte> AndBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x23,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h and eax,edx                             ; AND(And_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 23 c2
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int Or(int a, int b)
; static ReadOnlySpan<byte> OrBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h or eax,edx                              ; OR(Or_r32_rm32) [EAX,EDX]                  encoding(2 bytes) = 0b c2
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int Xor(int a, int b)
; static ReadOnlySpan<byte> XorBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x33,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                             ; MOV(Mov_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 8b c1
0007h xor eax,edx                             ; XOR(Xor_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 33 c2
0009h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int Nand(int a, int b)
; static ReadOnlySpan<byte> NandBytes => new byte[12]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xF7,0xD0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                             ; AND(And_r32_rm32) [EDX,ECX]                encoding(2 bytes) = 23 d1
0007h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0009h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
000bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int Jump(int target, int a, int b)
; static ReadOnlySpan<byte> JumpBytes => new byte[46]{0x0F,0x1F,0x44,0x00,0x00,0x83,0xF9,0x01,0x74,0x1E,0x83,0xF9,0x02,0x74,0x13,0x83,0xF9,0x03,0x74,0x08,0x41,0x23,0xD0,0x8B,0xC2,0xF7,0xD0,0xC3,0x8B,0xC2,0x41,0x33,0xC0,0xC3,0x8B,0xC2,0x41,0x0B,0xC0,0xC3,0x8B,0xC2,0x41,0x23,0xC0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h cmp ecx,1                               ; CMP(Cmp_rm32_imm8) [ECX,1h:imm32]          encoding(3 bytes) = 83 f9 01
0008h je short 0028h                          ; JE(Je_rel8_64) [28h:jmp64]                 encoding(2 bytes) = 74 1e
000ah cmp ecx,2                               ; CMP(Cmp_rm32_imm8) [ECX,2h:imm32]          encoding(3 bytes) = 83 f9 02
000dh je short 0022h                          ; JE(Je_rel8_64) [22h:jmp64]                 encoding(2 bytes) = 74 13
000fh cmp ecx,3                               ; CMP(Cmp_rm32_imm8) [ECX,3h:imm32]          encoding(3 bytes) = 83 f9 03
0012h je short 001ch                          ; JE(Je_rel8_64) [1Ch:jmp64]                 encoding(2 bytes) = 74 08
0014h and edx,r8d                             ; AND(And_r32_rm32) [EDX,R8D]                encoding(3 bytes) = 41 23 d0
0017h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0019h not eax                                 ; NOT(Not_rm32) [EAX]                        encoding(2 bytes) = f7 d0
001bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
001ch mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
001eh xor eax,r8d                             ; XOR(Xor_r32_rm32) [EAX,R8D]                encoding(3 bytes) = 41 33 c0
0021h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
0022h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
0024h or eax,r8d                              ; OR(Or_r32_rm32) [EAX,R8D]                  encoding(3 bytes) = 41 0b c0
0027h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
0028h mov eax,edx                             ; MOV(Mov_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 8b c2
002ah and eax,r8d                             ; AND(And_r32_rm32) [EAX,R8D]                encoding(3 bytes) = 41 23 c0
002dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int Jump()
; static ReadOnlySpan<byte> JumpBytes => new byte[11]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x07,0x00,0x00,0x00,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,7                               ; MOV(Mov_r32_imm32) [EAX,7h:imm32]          encoding(5 bytes) = b8 07 00 00 00
000ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int Mul(int a, int b)
; static ReadOnlySpan<byte> MulBytes => new byte[54]{0x57,0x56,0x48,0x83,0xEC,0x28,0x8B,0xF1,0x8B,0xFA,0x48,0xB9,0x60,0x6C,0xE1,0xB4,0xF7,0x7F,0x00,0x00,0x33,0xD2,0xE8,0x75,0xB1,0x3F,0x5F,0x48,0xB8,0xF8,0x2E,0x00,0x10,0x3C,0x01,0x00,0x00,0x48,0x8B,0x00,0x8B,0x00,0x0F,0xAF,0xF7,0x8B,0xC6,0x48,0x83,0xC4,0x28,0x5E,0x5F,0xC3};
0000h push rdi                                ; PUSH(Push_r64) [RDI]                       encoding(1 byte ) = 57
0001h push rsi                                ; PUSH(Push_r64) [RSI]                       encoding(1 byte ) = 56
0002h sub rsp,28h                             ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 ec 28
0006h mov esi,ecx                             ; MOV(Mov_r32_rm32) [ESI,ECX]                encoding(2 bytes) = 8b f1
0008h mov edi,edx                             ; MOV(Mov_r32_rm32) [EDI,EDX]                encoding(2 bytes) = 8b fa
000ah mov rcx,7FF7B4E16C60h                   ; MOV(Mov_r64_imm64) [RCX,7ff7b4e16c60h:imm64] encoding(10 bytes) = 48 b9 60 6c e1 b4 f7 7f 00 00
0014h xor edx,edx                             ; XOR(Xor_r32_rm32) [EDX,EDX]                encoding(2 bytes) = 33 d2
0016h call 7FF814841BA0h                      ; CALL(Call_rel32_64) [5F3FB190h:jmp64]      encoding(5 bytes) = e8 75 b1 3f 5f
001bh mov rax,13C10002EF8h                    ; MOV(Mov_r64_imm64) [RAX,13c10002ef8h:imm64] encoding(10 bytes) = 48 b8 f8 2e 00 10 3c 01 00 00
0025h mov rax,[rax]                           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)] encoding(3 bytes) = 48 8b 00
0028h mov eax,[rax]                           ; MOV(Mov_r32_rm32) [EAX,mem(32u,RAX:br,:sr)] encoding(2 bytes) = 8b 00
002ah imul esi,edi                            ; IMUL(Imul_r32_rm32) [ESI,EDI]              encoding(3 bytes) = 0f af f7
002dh mov eax,esi                             ; MOV(Mov_r32_rm32) [EAX,ESI]                encoding(2 bytes) = 8b c6
002fh add rsp,28h                             ; ADD(Add_rm64_imm8) [RSP,28h:imm64]         encoding(4 bytes) = 48 83 c4 28
0033h pop rsi                                 ; POP(Pop_r64) [RSI]                         encoding(1 byte ) = 5e
0034h pop rdi                                 ; POP(Pop_r64) [RDI]                         encoding(1 byte ) = 5f
0035h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
