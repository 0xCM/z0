; 2019-11-06 08:55:38:355
; function: bit bitread(in ulong src, int N, int row, int col)
; location: [7FFDD9F22040h, 7FFDD9F22062h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,r8d                  ; IMUL(Imul_r32_rm32) [EDX,R8D]                        encoding(4 bytes) = 41 0f af d0
0009h add edx,r9d                   ; ADD(Add_r32_rm32) [EDX,R9D]                          encoding(3 bytes) = 41 03 d1
000ch mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000eh sar eax,6                     ; SAR(Sar_rm32_imm8) [EAX,6h:imm8]                     encoding(3 bytes) = c1 f8 06
0011h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
0014h mov rax,[rcx+rax*8]           ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,DS:sr)]        encoding(4 bytes) = 48 8b 04 c1
0018h bt rax,rdx                    ; BT(Bt_rm64_r64) [RAX,RDX]                            encoding(4 bytes) = 48 0f a3 d0
001ch setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
001fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitreadBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xAF,0xD0,0x41,0x03,0xD1,0x8B,0xC2,0xC1,0xF8,0x06,0x48,0x63,0xC0,0x48,0x8B,0x04,0xC1,0x48,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void bitset(ref ulong src, int M, int N, int row, int col, bit state)
; location: [7FFDD9F22080h, 7FFDD9F220DBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rsp+30h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,SS:sr)]        encoding(4 bytes) = 8b 44 24 30
0009h imul r8d,r9d                  ; IMUL(Imul_r32_rm32) [R8D,R9D]                        encoding(4 bytes) = 45 0f af c1
000dh add r8d,[rsp+28h]             ; ADD(Add_r32_rm32) [R8D,mem(32u,RSP:br,SS:sr)]        encoding(5 bytes) = 44 03 44 24 28
0012h mov edx,r8d                   ; MOV(Mov_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 8b d0
0015h sar edx,6                     ; SAR(Sar_rm32_imm8) [EDX,6h:imm8]                     encoding(3 bytes) = c1 fa 06
0018h mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
001bh sar r9d,1Fh                   ; SAR(Sar_rm32_imm8) [R9D,1fh:imm8]                    encoding(4 bytes) = 41 c1 f9 1f
001fh and r9d,3Fh                   ; AND(And_rm32_imm8) [R9D,3fh:imm32]                   encoding(4 bytes) = 41 83 e1 3f
0023h add r9d,r8d                   ; ADD(Add_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 03 c8
0026h and r9d,0FFFFFFC0h            ; AND(And_rm32_imm8) [R9D,ffffffffffffffc0h:imm32]     encoding(4 bytes) = 41 83 e1 c0
002ah sub r8d,r9d                   ; SUB(Sub_r32_rm32) [R8D,R9D]                          encoding(3 bytes) = 45 2b c1
002dh movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
0030h lea rdx,[rcx+rdx*8]           ; LEA(Lea_r64_m) [RDX,mem(Unknown,RCX:br,DS:sr)]       encoding(4 bytes) = 48 8d 14 d1
0034h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0036h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0039h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
003ch inc rax                       ; INC(Inc_rm64) [RAX]                                  encoding(3 bytes) = 48 ff c0
003fh mov r9,[rdx]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,RDX:br,DS:sr)]         encoding(3 bytes) = 4c 8b 0a
0042h xor rax,r9                    ; XOR(Xor_r64_rm64) [RAX,R9]                           encoding(3 bytes) = 49 33 c1
0045h movzx ecx,r8b                 ; MOVZX(Movzx_r32_rm8) [ECX,R8L]                       encoding(4 bytes) = 41 0f b6 c8
0049h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
004fh shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0052h and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
0055h xor rax,r9                    ; XOR(Xor_r64_rm64) [RAX,R9]                           encoding(3 bytes) = 49 33 c1
0058h mov [rdx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,DS:sr),RAX]        encoding(3 bytes) = 48 89 02
005bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitsetBytes => new byte[92]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x44,0x24,0x30,0x45,0x0F,0xAF,0xC1,0x44,0x03,0x44,0x24,0x28,0x41,0x8B,0xD0,0xC1,0xFA,0x06,0x45,0x8B,0xC8,0x41,0xC1,0xF9,0x1F,0x41,0x83,0xE1,0x3F,0x45,0x03,0xC8,0x41,0x83,0xE1,0xC0,0x45,0x2B,0xC1,0x48,0x63,0xD2,0x48,0x8D,0x14,0xD1,0x8B,0xC8,0x48,0x8B,0xC1,0x48,0xF7,0xD0,0x48,0xFF,0xC0,0x4C,0x8B,0x0A,0x49,0x33,0xC1,0x41,0x0F,0xB6,0xC8,0x41,0xB8,0x01,0x00,0x00,0x00,0x49,0xD3,0xE0,0x49,0x23,0xC0,0x49,0x33,0xC1,0x48,0x89,0x02,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit bitread(in byte src, int N, int row, int col)
; location: [7FFDD9F220F0h, 7FFDD9F22111h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,DS:sr)]                encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,r8d                  ; IMUL(Imul_r32_rm32) [EDX,R8D]                        encoding(4 bytes) = 41 0f af d0
0009h add edx,r9d                   ; ADD(Add_r32_rm32) [EDX,R9D]                          encoding(3 bytes) = 41 03 d1
000ch mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000eh sar eax,3                     ; SAR(Sar_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 f8 03
0011h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
0014h movzx eax,byte ptr [rcx+rax]  ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RCX:br,DS:sr)]      encoding(4 bytes) = 0f b6 04 01
0018h bt eax,edx                    ; BT(Bt_rm32_r32) [EAX,EDX]                            encoding(3 bytes) = 0f a3 d0
001bh setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
001eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0021h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bitreadBytes => new byte[34]{0x0F,0x1F,0x44,0x00,0x00,0x41,0x0F,0xAF,0xD0,0x41,0x03,0xD1,0x8B,0xC2,0xC1,0xF8,0x03,0x48,0x63,0xC0,0x0F,0xB6,0x04,0x01,0x0F,0xA3,0xD0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitGrid<uint> bg_load_32x32x32(Span<uint> src)
; location: [7FFDD9F22530h, 7FFDD9F22554h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
000bh mov r8d,20h                   ; MOV(Mov_r32_imm32) [R8D,20h:imm32]                   encoding(6 bytes) = 41 b8 20 00 00 00
0011h mov r9d,20h                   ; MOV(Mov_r32_imm32) [R9D,20h:imm32]                   encoding(6 bytes) = 41 b9 20 00 00 00
0017h call 7FFDD9F21ED8h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFF9A8h:jmp64]        encoding(5 bytes) = e8 8c f9 ff ff
001ch mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
001fh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0023h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bg_load_32x32x32Bytes => new byte[37]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0xCE,0x41,0xB8,0x20,0x00,0x00,0x00,0x41,0xB9,0x20,0x00,0x00,0x00,0xE8,0x8C,0xF9,0xFF,0xFF,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: GridSpec bg_specify(int rows, int cols, int segwidth)
; location: [7FFDD9F22570h, 7FFDD9F2261Dh]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h push rbx                      ; PUSH(Push_r64) [RBX]                                 encoding(1 byte ) = 53
0003h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0007h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
000ah mov r10d,edx                  ; MOV(Mov_r32_rm32) [R10D,EDX]                         encoding(3 bytes) = 44 8b d2
000dh mov eax,r10d                  ; MOV(Mov_r32_rm32) [EAX,R10D]                         encoding(3 bytes) = 41 8b c2
0010h imul eax,r8d                  ; IMUL(Imul_r32_rm32) [EAX,R8D]                        encoding(4 bytes) = 41 0f af c0
0014h mov r11d,eax                  ; MOV(Mov_r32_rm32) [R11D,EAX]                         encoding(3 bytes) = 44 8b d8
0017h sar r11d,3                    ; SAR(Sar_rm32_imm8) [R11D,3h:imm8]                    encoding(4 bytes) = 41 c1 fb 03
001bh mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
001dh sar edx,1Fh                   ; SAR(Sar_rm32_imm8) [EDX,1fh:imm8]                    encoding(3 bytes) = c1 fa 1f
0020h and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0023h add edx,eax                   ; ADD(Add_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 03 d0
0025h and edx,0FFFFFFF8h            ; AND(And_rm32_imm8) [EDX,fffffffffffffff8h:imm32]     encoding(3 bytes) = 83 e2 f8
0028h sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
002ah jne short 0030h               ; JNE(Jne_rel8_64) [30h:jmp64]                         encoding(2 bytes) = 75 04
002ch xor esi,esi                   ; XOR(Xor_r32_rm32) [ESI,ESI]                          encoding(2 bytes) = 33 f6
002eh jmp short 0035h               ; JMP(Jmp_rel8_64) [35h:jmp64]                         encoding(2 bytes) = eb 05
0030h mov esi,1                     ; MOV(Mov_r32_imm32) [ESI,1h:imm32]                    encoding(5 bytes) = be 01 00 00 00
0035h add r11d,esi                  ; ADD(Add_r32_rm32) [R11D,ESI]                         encoding(3 bytes) = 44 03 de
0038h mov esi,r11d                  ; MOV(Mov_r32_rm32) [ESI,R11D]                         encoding(3 bytes) = 41 8b f3
003bh shl esi,3                     ; SHL(Shl_rm32_imm8) [ESI,3h:imm8]                     encoding(3 bytes) = c1 e6 03
003eh mov edi,r9d                   ; MOV(Mov_r32_rm32) [EDI,R9D]                          encoding(3 bytes) = 41 8b f9
0041h sar edi,3                     ; SAR(Sar_rm32_imm8) [EDI,3h:imm8]                     encoding(3 bytes) = c1 ff 03
0044h mov eax,r11d                  ; MOV(Mov_r32_rm32) [EAX,R11D]                         encoding(3 bytes) = 41 8b c3
0047h cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
0048h idiv edi                      ; IDIV(Idiv_rm32) [EDI]                                encoding(2 bytes) = f7 ff
004ah mov ebx,eax                   ; MOV(Mov_r32_rm32) [EBX,EAX]                          encoding(2 bytes) = 8b d8
004ch mov eax,r11d                  ; MOV(Mov_r32_rm32) [EAX,R11D]                         encoding(3 bytes) = 41 8b c3
004fh cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
0050h idiv edi                      ; IDIV(Idiv_rm32) [EDI]                                encoding(2 bytes) = f7 ff
0052h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0054h jne short 005ah               ; JNE(Jne_rel8_64) [5Ah:jmp64]                         encoding(2 bytes) = 75 04
0056h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0058h jmp short 005fh               ; JMP(Jmp_rel8_64) [5Fh:jmp64]                         encoding(2 bytes) = eb 05
005ah mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
005fh add eax,ebx                   ; ADD(Add_r32_rm32) [EAX,EBX]                          encoding(2 bytes) = 03 c3
0061h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0063h lea rdi,[rsp+8]               ; LEA(Lea_r64_m) [RDI,mem(Unknown,RSP:br,SS:sr)]       encoding(5 bytes) = 48 8d 7c 24 08
0068h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
006ch vmovdqu xmmword ptr [rdi],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RDI:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 07
0070h mov [rdi+10h],rdx             ; MOV(Mov_rm64_r64) [mem(64u,RDI:br,DS:sr),RDX]        encoding(4 bytes) = 48 89 57 10
0074h mov [rsp+8],r10d              ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R10D]       encoding(5 bytes) = 44 89 54 24 08
0079h mov [rsp+0Ch],r8d             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R8D]        encoding(5 bytes) = 44 89 44 24 0c
007eh mov [rsp+10h],r9d             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R9D]        encoding(5 bytes) = 44 89 4c 24 10
0083h mov [rsp+18h],r11d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),R11D]       encoding(5 bytes) = 44 89 5c 24 18
0088h mov [rsp+14h],esi             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),ESI]        encoding(4 bytes) = 89 74 24 14
008ch mov [rsp+1Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,SS:sr),EAX]        encoding(4 bytes) = 89 44 24 1c
0090h vmovdqu xmm0,xmmword ptr [rsp+8]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,SS:sr)] encoding(VEX, 6 bytes) = c5 fa 6f 44 24 08
0096h vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,DS:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
009ah mov rax,[rsp+18h]             ; MOV(Mov_r64_rm64) [RAX,mem(64u,RSP:br,SS:sr)]        encoding(5 bytes) = 48 8b 44 24 18
009fh mov [rcx+10h],rax             ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,DS:sr),RAX]        encoding(4 bytes) = 48 89 41 10
00a3h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
00a6h add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
00aah pop rbx                       ; POP(Pop_r64) [RBX]                                   encoding(1 byte ) = 5b
00abh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00ach pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00adh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bg_specifyBytes => new byte[174]{0x57,0x56,0x53,0x48,0x83,0xEC,0x20,0xC5,0xF8,0x77,0x44,0x8B,0xD2,0x41,0x8B,0xC2,0x41,0x0F,0xAF,0xC0,0x44,0x8B,0xD8,0x41,0xC1,0xFB,0x03,0x8B,0xD0,0xC1,0xFA,0x1F,0x83,0xE2,0x07,0x03,0xD0,0x83,0xE2,0xF8,0x2B,0xC2,0x75,0x04,0x33,0xF6,0xEB,0x05,0xBE,0x01,0x00,0x00,0x00,0x44,0x03,0xDE,0x41,0x8B,0xF3,0xC1,0xE6,0x03,0x41,0x8B,0xF9,0xC1,0xFF,0x03,0x41,0x8B,0xC3,0x99,0xF7,0xFF,0x8B,0xD8,0x41,0x8B,0xC3,0x99,0xF7,0xFF,0x85,0xD2,0x75,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x03,0xC3,0x33,0xD2,0x48,0x8D,0x7C,0x24,0x08,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x07,0x48,0x89,0x57,0x10,0x44,0x89,0x54,0x24,0x08,0x44,0x89,0x44,0x24,0x0C,0x44,0x89,0x4C,0x24,0x10,0x44,0x89,0x5C,0x24,0x18,0x89,0x74,0x24,0x14,0x89,0x44,0x24,0x1C,0xC5,0xFA,0x6F,0x44,0x24,0x08,0xC5,0xFA,0x7F,0x01,0x48,0x8B,0x44,0x24,0x18,0x48,0x89,0x41,0x10,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x20,0x5B,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
