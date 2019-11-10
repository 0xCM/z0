; 2019-11-09 14:57:10:098
; function: bit read_bit_from_vector(BitVector<N23,byte> src)
; location: [7FFDDBAA4970h, 7FFDDBAA498Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h movzx eax,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,:sr)]        encoding(3 bytes) = 0f b6 00
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h and eax,8                     ; AND(And_rm32_imm8) [EAX,8h:imm32]                    encoding(3 bytes) = 83 e0 08
0014h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0016h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0019h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> read_bit_from_vectorBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x0F,0xB6,0x00,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x83,0xE0,0x08,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit read_bit_from_vector_2(BitVector<N23,byte> src)
; location: [7FFDDBAA4DB0h, 7FFDDBAA4DCCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h movzx eax,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [EAX,mem(8u,RAX:br,:sr)]        encoding(3 bytes) = 0f b6 00
000bh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000eh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0011h and eax,8                     ; AND(And_rm32_imm8) [EAX,8h:imm32]                    encoding(3 bytes) = 83 e0 08
0014h test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
0016h setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0019h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> read_bit_from_vector_2Bytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x0F,0xB6,0x00,0x0F,0xB6,0xC0,0x0F,0xB6,0xC0,0x83,0xE0,0x08,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void set_bit_in_vector(BitVector<N23,byte> src)
; location: [7FFDDBAA4DE0h, 7FFDDBAA4DF6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h movzx edx,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RAX:br,:sr)]        encoding(3 bytes) = 0f b6 10
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
000fh and ecx,8                     ; AND(And_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 e1 08
0012h xor ecx,edx                   ; XOR(Xor_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 33 ca
0014h mov [rax],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),CL]              encoding(2 bytes) = 88 08
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> set_bit_in_vectorBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x0F,0xB6,0x10,0x8B,0xCA,0xF7,0xD1,0x83,0xE1,0x08,0x33,0xCA,0x88,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void set_bit_in_grid(BitGrid<N23,N1,byte> src)
; location: [7FFDDBAA5210h, 7FFDDBAA5226h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h movzx edx,byte ptr [rax]      ; MOVZX(Movzx_r32_rm8) [EDX,mem(8u,RAX:br,:sr)]        encoding(3 bytes) = 0f b6 10
000bh mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
000dh not ecx                       ; NOT(Not_rm32) [ECX]                                  encoding(2 bytes) = f7 d1
000fh and ecx,8                     ; AND(And_rm32_imm8) [ECX,8h:imm32]                    encoding(3 bytes) = 83 e1 08
0012h xor ecx,edx                   ; XOR(Xor_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 33 ca
0014h mov [rax],cl                  ; MOV(Mov_rm8_r8) [mem(8u,RAX:br,:sr),CL]              encoding(2 bytes) = 88 08
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> set_bit_in_gridBytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x0F,0xB6,0x10,0x8B,0xCA,0xF7,0xD1,0x83,0xE1,0x08,0x33,0xCA,0x88,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int segments()
; location: [7FFDDBAA5240h, 7FFDDBAA5251h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
000ah add eax,2                     ; ADD(Add_rm32_imm8) [EAX,2h:imm32]                    encoding(3 bytes) = 83 c0 02
000dh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
000fh add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0011h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> segmentsBytes => new byte[18]{0x0F,0x1F,0x44,0x00,0x00,0xB8,0x01,0x00,0x00,0x00,0x83,0xC0,0x02,0x33,0xD2,0x03,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: GridSpec calc_spec_1()
; location: [7FFDDBAA5270h, 7FFDDBAA52FFh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h add eax,4Bh                   ; ADD(Add_rm32_imm8) [EAX,4bh:imm32]                   encoding(3 bytes) = 83 c0 4b
000ch mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000eh sar edx,1Fh                   ; SAR(Sar_rm32_imm8) [EDX,1fh:imm8]                    encoding(3 bytes) = c1 fa 1f
0011h and edx,3                     ; AND(And_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 e2 03
0014h add edx,eax                   ; ADD(Add_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 03 d0
0016h sar edx,2                     ; SAR(Sar_rm32_imm8) [EDX,2h:imm8]                     encoding(3 bytes) = c1 fa 02
0019h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
001ch sar r8d,1Fh                   ; SAR(Sar_rm32_imm8) [R8D,1fh:imm8]                    encoding(4 bytes) = 41 c1 f8 1f
0020h and r8d,3                     ; AND(And_rm32_imm8) [R8D,3h:imm32]                    encoding(4 bytes) = 41 83 e0 03
0024h add r8d,eax                   ; ADD(Add_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 03 c0
0027h and r8d,0FFFFFFFCh            ; AND(And_rm32_imm8) [R8D,fffffffffffffffch:imm32]     encoding(4 bytes) = 41 83 e0 fc
002bh mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
002eh sub r9d,r8d                   ; SUB(Sub_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 2b c8
0031h jne short 0038h               ; JNE(Jne_rel8_64) [38h:jmp64]                         encoding(2 bytes) = 75 05
0033h xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0036h jmp short 003eh               ; JMP(Jmp_rel8_64) [3Eh:jmp64]                         encoding(2 bytes) = eb 06
0038h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
003eh add edx,r8d                   ; ADD(Add_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 03 d0
0041h xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0044h lea r9,[rsp]                  ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,:sr)]          encoding(4 bytes) = 4c 8d 0c 24
0048h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
004ch vmovdqu xmmword ptr [r9],xmm0 ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R9:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 01
0051h mov [r9+10h],r8d              ; MOV(Mov_rm32_r32) [mem(32u,R9:br,:sr),R8D]           encoding(4 bytes) = 45 89 41 10
0055h mov word ptr [rsp],14h        ; MOV(Mov_rm16_imm16) [mem(16u,RSP:br,:sr),14h:imm16]  encoding(6 bytes) = 66 c7 04 24 14 00
005bh mov word ptr [rsp+2],1Eh      ; MOV(Mov_rm16_imm16) [mem(16u,RSP:br,:sr),1eh:imm16]  encoding(7 bytes) = 66 c7 44 24 02 1e 00
0062h mov word ptr [rsp+4],20h      ; MOV(Mov_rm16_imm16) [mem(16u,RSP:br,:sr),20h:imm16]  encoding(7 bytes) = 66 c7 44 24 04 20 00
0069h mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX]          encoding(4 bytes) = 89 44 24 0c
006dh shl eax,3                     ; SHL(Shl_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e0 03
0070h mov [rsp+8],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX]          encoding(4 bytes) = 89 44 24 08
0074h mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EDX]          encoding(4 bytes) = 89 54 24 10
0078h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
007dh vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
0081h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 10
0085h mov [rcx+10h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EAX]          encoding(3 bytes) = 89 41 10
0088h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
008bh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
008fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> calc_spec_1Bytes => new byte[144]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x33,0xC0,0x83,0xC0,0x4B,0x8B,0xD0,0xC1,0xFA,0x1F,0x83,0xE2,0x03,0x03,0xD0,0xC1,0xFA,0x02,0x44,0x8B,0xC0,0x41,0xC1,0xF8,0x1F,0x41,0x83,0xE0,0x03,0x44,0x03,0xC0,0x41,0x83,0xE0,0xFC,0x44,0x8B,0xC8,0x45,0x2B,0xC8,0x75,0x05,0x45,0x33,0xC0,0xEB,0x06,0x41,0xB8,0x01,0x00,0x00,0x00,0x41,0x03,0xD0,0x45,0x33,0xC0,0x4C,0x8D,0x0C,0x24,0xC5,0xF8,0x57,0xC0,0xC4,0xC1,0x7A,0x7F,0x01,0x45,0x89,0x41,0x10,0x66,0xC7,0x04,0x24,0x14,0x00,0x66,0xC7,0x44,0x24,0x02,0x1E,0x00,0x66,0xC7,0x44,0x24,0x04,0x20,0x00,0x89,0x44,0x24,0x0C,0xC1,0xE0,0x03,0x89,0x44,0x24,0x08,0x89,0x54,0x24,0x10,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0x8B,0x44,0x24,0x10,0x89,0x41,0x10,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: GridSpec calc_spec_3()
; location: [7FFDDBAA5320h, 7FFDDBAA53AFh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h add eax,4Bh                   ; ADD(Add_rm32_imm8) [EAX,4bh:imm32]                   encoding(3 bytes) = 83 c0 4b
000ch mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000eh sar edx,1Fh                   ; SAR(Sar_rm32_imm8) [EDX,1fh:imm8]                    encoding(3 bytes) = c1 fa 1f
0011h and edx,3                     ; AND(And_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 e2 03
0014h add edx,eax                   ; ADD(Add_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 03 d0
0016h sar edx,2                     ; SAR(Sar_rm32_imm8) [EDX,2h:imm8]                     encoding(3 bytes) = c1 fa 02
0019h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
001ch sar r8d,1Fh                   ; SAR(Sar_rm32_imm8) [R8D,1fh:imm8]                    encoding(4 bytes) = 41 c1 f8 1f
0020h and r8d,3                     ; AND(And_rm32_imm8) [R8D,3h:imm32]                    encoding(4 bytes) = 41 83 e0 03
0024h add r8d,eax                   ; ADD(Add_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 03 c0
0027h and r8d,0FFFFFFFCh            ; AND(And_rm32_imm8) [R8D,fffffffffffffffch:imm32]     encoding(4 bytes) = 41 83 e0 fc
002bh mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
002eh sub r9d,r8d                   ; SUB(Sub_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 2b c8
0031h jne short 0038h               ; JNE(Jne_rel8_64) [38h:jmp64]                         encoding(2 bytes) = 75 05
0033h xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0036h jmp short 003eh               ; JMP(Jmp_rel8_64) [3Eh:jmp64]                         encoding(2 bytes) = eb 06
0038h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
003eh add edx,r8d                   ; ADD(Add_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 03 d0
0041h xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0044h lea r9,[rsp]                  ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,:sr)]          encoding(4 bytes) = 4c 8d 0c 24
0048h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
004ch vmovdqu xmmword ptr [r9],xmm0 ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R9:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 01
0051h mov [r9+10h],r8d              ; MOV(Mov_rm32_r32) [mem(32u,R9:br,:sr),R8D]           encoding(4 bytes) = 45 89 41 10
0055h mov word ptr [rsp],14h        ; MOV(Mov_rm16_imm16) [mem(16u,RSP:br,:sr),14h:imm16]  encoding(6 bytes) = 66 c7 04 24 14 00
005bh mov word ptr [rsp+2],1Eh      ; MOV(Mov_rm16_imm16) [mem(16u,RSP:br,:sr),1eh:imm16]  encoding(7 bytes) = 66 c7 44 24 02 1e 00
0062h mov word ptr [rsp+4],20h      ; MOV(Mov_rm16_imm16) [mem(16u,RSP:br,:sr),20h:imm16]  encoding(7 bytes) = 66 c7 44 24 04 20 00
0069h mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX]          encoding(4 bytes) = 89 44 24 0c
006dh shl eax,3                     ; SHL(Shl_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e0 03
0070h mov [rsp+8],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX]          encoding(4 bytes) = 89 44 24 08
0074h mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EDX]          encoding(4 bytes) = 89 54 24 10
0078h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
007dh vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
0081h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 10
0085h mov [rcx+10h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EAX]          encoding(3 bytes) = 89 41 10
0088h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
008bh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
008fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> calc_spec_3Bytes => new byte[144]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x33,0xC0,0x83,0xC0,0x4B,0x8B,0xD0,0xC1,0xFA,0x1F,0x83,0xE2,0x03,0x03,0xD0,0xC1,0xFA,0x02,0x44,0x8B,0xC0,0x41,0xC1,0xF8,0x1F,0x41,0x83,0xE0,0x03,0x44,0x03,0xC0,0x41,0x83,0xE0,0xFC,0x44,0x8B,0xC8,0x45,0x2B,0xC8,0x75,0x05,0x45,0x33,0xC0,0xEB,0x06,0x41,0xB8,0x01,0x00,0x00,0x00,0x41,0x03,0xD0,0x45,0x33,0xC0,0x4C,0x8D,0x0C,0x24,0xC5,0xF8,0x57,0xC0,0xC4,0xC1,0x7A,0x7F,0x01,0x45,0x89,0x41,0x10,0x66,0xC7,0x04,0x24,0x14,0x00,0x66,0xC7,0x44,0x24,0x02,0x1E,0x00,0x66,0xC7,0x44,0x24,0x04,0x20,0x00,0x89,0x44,0x24,0x0C,0xC1,0xE0,0x03,0x89,0x44,0x24,0x08,0x89,0x54,0x24,0x10,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0x8B,0x44,0x24,0x10,0x89,0x41,0x10,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: GridSpec calc_spec_2()
; location: [7FFDDBAA53D0h, 7FFDDBAA545Fh]
0000h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0009h add eax,4Bh                   ; ADD(Add_rm32_imm8) [EAX,4bh:imm32]                   encoding(3 bytes) = 83 c0 4b
000ch mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000eh sar edx,1Fh                   ; SAR(Sar_rm32_imm8) [EDX,1fh:imm8]                    encoding(3 bytes) = c1 fa 1f
0011h and edx,3                     ; AND(And_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 e2 03
0014h add edx,eax                   ; ADD(Add_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 03 d0
0016h sar edx,2                     ; SAR(Sar_rm32_imm8) [EDX,2h:imm8]                     encoding(3 bytes) = c1 fa 02
0019h mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
001ch sar r8d,1Fh                   ; SAR(Sar_rm32_imm8) [R8D,1fh:imm8]                    encoding(4 bytes) = 41 c1 f8 1f
0020h and r8d,3                     ; AND(And_rm32_imm8) [R8D,3h:imm32]                    encoding(4 bytes) = 41 83 e0 03
0024h add r8d,eax                   ; ADD(Add_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 03 c0
0027h and r8d,0FFFFFFFCh            ; AND(And_rm32_imm8) [R8D,fffffffffffffffch:imm32]     encoding(4 bytes) = 41 83 e0 fc
002bh mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
002eh sub r9d,r8d                   ; SUB(Sub_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 2b c8
0031h jne short 0038h               ; JNE(Jne_rel8_64) [38h:jmp64]                         encoding(2 bytes) = 75 05
0033h xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0036h jmp short 003eh               ; JMP(Jmp_rel8_64) [3Eh:jmp64]                         encoding(2 bytes) = eb 06
0038h mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
003eh add edx,r8d                   ; ADD(Add_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 03 d0
0041h xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0044h lea r9,[rsp]                  ; LEA(Lea_r64_m) [R9,mem(Unknown,RSP:br,:sr)]          encoding(4 bytes) = 4c 8d 0c 24
0048h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
004ch vmovdqu xmmword ptr [r9],xmm0 ; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,R9:br,:sr),XMM0] encoding(VEX, 5 bytes) = c4 c1 7a 7f 01
0051h mov [r9+10h],r8d              ; MOV(Mov_rm32_r32) [mem(32u,R9:br,:sr),R8D]           encoding(4 bytes) = 45 89 41 10
0055h mov word ptr [rsp],14h        ; MOV(Mov_rm16_imm16) [mem(16u,RSP:br,:sr),14h:imm16]  encoding(6 bytes) = 66 c7 04 24 14 00
005bh mov word ptr [rsp+2],1Eh      ; MOV(Mov_rm16_imm16) [mem(16u,RSP:br,:sr),1eh:imm16]  encoding(7 bytes) = 66 c7 44 24 02 1e 00
0062h mov word ptr [rsp+4],20h      ; MOV(Mov_rm16_imm16) [mem(16u,RSP:br,:sr),20h:imm16]  encoding(7 bytes) = 66 c7 44 24 04 20 00
0069h mov [rsp+0Ch],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX]          encoding(4 bytes) = 89 44 24 0c
006dh shl eax,3                     ; SHL(Shl_rm32_imm8) [EAX,3h:imm8]                     encoding(3 bytes) = c1 e0 03
0070h mov [rsp+8],eax               ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX]          encoding(4 bytes) = 89 44 24 08
0074h mov [rsp+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EDX]          encoding(4 bytes) = 89 54 24 10
0078h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
007dh vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
0081h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 10
0085h mov [rcx+10h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EAX]          encoding(3 bytes) = 89 41 10
0088h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
008bh add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
008fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> calc_spec_2Bytes => new byte[144]{0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x33,0xC0,0x83,0xC0,0x4B,0x8B,0xD0,0xC1,0xFA,0x1F,0x83,0xE2,0x03,0x03,0xD0,0xC1,0xFA,0x02,0x44,0x8B,0xC0,0x41,0xC1,0xF8,0x1F,0x41,0x83,0xE0,0x03,0x44,0x03,0xC0,0x41,0x83,0xE0,0xFC,0x44,0x8B,0xC8,0x45,0x2B,0xC8,0x75,0x05,0x45,0x33,0xC0,0xEB,0x06,0x41,0xB8,0x01,0x00,0x00,0x00,0x41,0x03,0xD0,0x45,0x33,0xC0,0x4C,0x8D,0x0C,0x24,0xC5,0xF8,0x57,0xC0,0xC4,0xC1,0x7A,0x7F,0x01,0x45,0x89,0x41,0x10,0x66,0xC7,0x04,0x24,0x14,0x00,0x66,0xC7,0x44,0x24,0x02,0x1E,0x00,0x66,0xC7,0x44,0x24,0x04,0x20,0x00,0x89,0x44,0x24,0x0C,0xC1,0xE0,0x03,0x89,0x44,0x24,0x08,0x89,0x54,0x24,0x10,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0x8B,0x44,0x24,0x10,0x89,0x41,0x10,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int count_segs()
; location: [7FFDDBAA5480h, 7FFDDBAA54B3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0007h add eax,4Bh                   ; ADD(Add_rm32_imm8) [EAX,4bh:imm32]                   encoding(3 bytes) = 83 c0 4b
000ah mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
000ch sar edx,1Fh                   ; SAR(Sar_rm32_imm8) [EDX,1fh:imm8]                    encoding(3 bytes) = c1 fa 1f
000fh and edx,3                     ; AND(And_rm32_imm8) [EDX,3h:imm32]                    encoding(3 bytes) = 83 e2 03
0012h add edx,eax                   ; ADD(Add_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 03 d0
0014h sar edx,2                     ; SAR(Sar_rm32_imm8) [EDX,2h:imm8]                     encoding(3 bytes) = c1 fa 02
0017h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0019h sar ecx,1Fh                   ; SAR(Sar_rm32_imm8) [ECX,1fh:imm8]                    encoding(3 bytes) = c1 f9 1f
001ch and ecx,3                     ; AND(And_rm32_imm8) [ECX,3h:imm32]                    encoding(3 bytes) = 83 e1 03
001fh add ecx,eax                   ; ADD(Add_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 03 c8
0021h and ecx,0FFFFFFFCh            ; AND(And_rm32_imm8) [ECX,fffffffffffffffch:imm32]     encoding(3 bytes) = 83 e1 fc
0024h sub eax,ecx                   ; SUB(Sub_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 2b c1
0026h jne short 002ch               ; JNE(Jne_rel8_64) [2Ch:jmp64]                         encoding(2 bytes) = 75 04
0028h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
002ah jmp short 0031h               ; JMP(Jmp_rel8_64) [31h:jmp64]                         encoding(2 bytes) = eb 05
002ch mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0031h add eax,edx                   ; ADD(Add_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 03 c2
0033h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> count_segsBytes => new byte[52]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0x83,0xC0,0x4B,0x8B,0xD0,0xC1,0xFA,0x1F,0x83,0xE2,0x03,0x03,0xD0,0xC1,0xFA,0x02,0x8B,0xC8,0xC1,0xF9,0x1F,0x83,0xE1,0x03,0x03,0xC8,0x83,0xE1,0xFC,0x2B,0xC1,0x75,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x03,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit readbit_row_col_many(in GridMoniker moniker, in ulong src)
; location: [7FFDDBAA54D0h, 7FFDDBAA5596h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx+2]    ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,:sr)]      encoding(4 bytes) = 0f b7 41 02
0009h lea ecx,[rax+2]               ; LEA(Lea_r32_m) [ECX,mem(Unknown,RAX:br,:sr)]         encoding(3 bytes) = 8d 48 02
000ch mov r8d,ecx                   ; MOV(Mov_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 8b c1
000fh sar r8d,1Fh                   ; SAR(Sar_rm32_imm8) [R8D,1fh:imm8]                    encoding(4 bytes) = 41 c1 f8 1f
0013h and r8d,3Fh                   ; AND(And_rm32_imm8) [R8D,3fh:imm32]                   encoding(4 bytes) = 41 83 e0 3f
0017h add r8d,ecx                   ; ADD(Add_r32_rm32) [R8D,ECX]                          encoding(3 bytes) = 44 03 c1
001ah sar r8d,6                     ; SAR(Sar_rm32_imm8) [R8D,6h:imm8]                     encoding(4 bytes) = 41 c1 f8 06
001eh mov r9d,ecx                   ; MOV(Mov_r32_rm32) [R9D,ECX]                          encoding(3 bytes) = 44 8b c9
0021h sar r9d,1Fh                   ; SAR(Sar_rm32_imm8) [R9D,1fh:imm8]                    encoding(4 bytes) = 41 c1 f9 1f
0025h and r9d,3Fh                   ; AND(And_rm32_imm8) [R9D,3fh:imm32]                   encoding(4 bytes) = 41 83 e1 3f
0029h add r9d,ecx                   ; ADD(Add_r32_rm32) [R9D,ECX]                          encoding(3 bytes) = 44 03 c9
002ch and r9d,0FFFFFFC0h            ; AND(And_rm32_imm8) [R9D,ffffffffffffffc0h:imm32]     encoding(4 bytes) = 41 83 e1 c0
0030h sub ecx,r9d                   ; SUB(Sub_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 2b c9
0033h movsxd r8,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R8,R8D]                     encoding(3 bytes) = 4d 63 c0
0036h mov r8,[rdx+r8*8]             ; MOV(Mov_r64_rm64) [R8,mem(64u,RDX:br,:sr)]           encoding(4 bytes) = 4e 8b 04 c2
003ah bt r8,rcx                     ; BT(Bt_rm64_r64) [R8,RCX]                             encoding(4 bytes) = 49 0f a3 c8
003eh setb cl                       ; SETB(Setb_rm8) [CL]                                  encoding(3 bytes) = 0f 92 c1
0041h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0044h lea r8d,[rax+3]               ; LEA(Lea_r32_m) [R8D,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 44 8d 40 03
0048h mov r9d,r8d                   ; MOV(Mov_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 8b c8
004bh sar r9d,1Fh                   ; SAR(Sar_rm32_imm8) [R9D,1fh:imm8]                    encoding(4 bytes) = 41 c1 f9 1f
004fh and r9d,3Fh                   ; AND(And_rm32_imm8) [R9D,3fh:imm32]                   encoding(4 bytes) = 41 83 e1 3f
0053h add r9d,r8d                   ; ADD(Add_r32_rm32) [R9D,R8D]                          encoding(3 bytes) = 45 03 c8
0056h sar r9d,6                     ; SAR(Sar_rm32_imm8) [R9D,6h:imm8]                     encoding(4 bytes) = 41 c1 f9 06
005ah mov r10d,r8d                  ; MOV(Mov_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 8b d0
005dh sar r10d,1Fh                  ; SAR(Sar_rm32_imm8) [R10D,1fh:imm8]                   encoding(4 bytes) = 41 c1 fa 1f
0061h and r10d,3Fh                  ; AND(And_rm32_imm8) [R10D,3fh:imm32]                  encoding(4 bytes) = 41 83 e2 3f
0065h add r10d,r8d                  ; ADD(Add_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 03 d0
0068h and r10d,0FFFFFFC0h           ; AND(And_rm32_imm8) [R10D,ffffffffffffffc0h:imm32]    encoding(4 bytes) = 41 83 e2 c0
006ch sub r8d,r10d                  ; SUB(Sub_r32_rm32) [R8D,R10D]                         encoding(3 bytes) = 45 2b c2
006fh movsxd r9,r9d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R9D]                     encoding(3 bytes) = 4d 63 c9
0072h mov r9,[rdx+r9*8]             ; MOV(Mov_r64_rm64) [R9,mem(64u,RDX:br,:sr)]           encoding(4 bytes) = 4e 8b 0c ca
0076h bt r9,r8                      ; BT(Bt_rm64_r64) [R9,R8]                              encoding(4 bytes) = 4d 0f a3 c1
007ah setb r8b                      ; SETB(Setb_rm8) [R8L]                                 encoding(4 bytes) = 41 0f 92 c0
007eh movzx r8d,r8b                 ; MOVZX(Movzx_r32_rm8) [R8D,R8L]                       encoding(4 bytes) = 45 0f b6 c0
0082h and ecx,r8d                   ; AND(And_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 23 c8
0085h lea eax,[rax*4+5]             ; LEA(Lea_r32_m) [EAX,mem(Unknown,None:br,:sr)]        encoding(7 bytes) = 8d 04 85 05 00 00 00
008ch mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
008fh sar r8d,1Fh                   ; SAR(Sar_rm32_imm8) [R8D,1fh:imm8]                    encoding(4 bytes) = 41 c1 f8 1f
0093h and r8d,3Fh                   ; AND(And_rm32_imm8) [R8D,3fh:imm32]                   encoding(4 bytes) = 41 83 e0 3f
0097h add r8d,eax                   ; ADD(Add_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 03 c0
009ah sar r8d,6                     ; SAR(Sar_rm32_imm8) [R8D,6h:imm8]                     encoding(4 bytes) = 41 c1 f8 06
009eh mov r9d,eax                   ; MOV(Mov_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 8b c8
00a1h sar r9d,1Fh                   ; SAR(Sar_rm32_imm8) [R9D,1fh:imm8]                    encoding(4 bytes) = 41 c1 f9 1f
00a5h and r9d,3Fh                   ; AND(And_rm32_imm8) [R9D,3fh:imm32]                   encoding(4 bytes) = 41 83 e1 3f
00a9h add r9d,eax                   ; ADD(Add_r32_rm32) [R9D,EAX]                          encoding(3 bytes) = 44 03 c8
00ach and r9d,0FFFFFFC0h            ; AND(And_rm32_imm8) [R9D,ffffffffffffffc0h:imm32]     encoding(4 bytes) = 41 83 e1 c0
00b0h sub eax,r9d                   ; SUB(Sub_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 2b c1
00b3h movsxd r8,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R8,R8D]                     encoding(3 bytes) = 4d 63 c0
00b6h mov rdx,[rdx+r8*8]            ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 4a 8b 14 c2
00bah bt rdx,rax                    ; BT(Bt_rm64_r64) [RDX,RAX]                            encoding(4 bytes) = 48 0f a3 c2
00beh setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
00c1h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
00c4h and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
00c6h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> readbit_row_col_manyBytes => new byte[199]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x41,0x02,0x8D,0x48,0x02,0x44,0x8B,0xC1,0x41,0xC1,0xF8,0x1F,0x41,0x83,0xE0,0x3F,0x44,0x03,0xC1,0x41,0xC1,0xF8,0x06,0x44,0x8B,0xC9,0x41,0xC1,0xF9,0x1F,0x41,0x83,0xE1,0x3F,0x44,0x03,0xC9,0x41,0x83,0xE1,0xC0,0x41,0x2B,0xC9,0x4D,0x63,0xC0,0x4E,0x8B,0x04,0xC2,0x49,0x0F,0xA3,0xC8,0x0F,0x92,0xC1,0x0F,0xB6,0xC9,0x44,0x8D,0x40,0x03,0x45,0x8B,0xC8,0x41,0xC1,0xF9,0x1F,0x41,0x83,0xE1,0x3F,0x45,0x03,0xC8,0x41,0xC1,0xF9,0x06,0x45,0x8B,0xD0,0x41,0xC1,0xFA,0x1F,0x41,0x83,0xE2,0x3F,0x45,0x03,0xD0,0x41,0x83,0xE2,0xC0,0x45,0x2B,0xC2,0x4D,0x63,0xC9,0x4E,0x8B,0x0C,0xCA,0x4D,0x0F,0xA3,0xC1,0x41,0x0F,0x92,0xC0,0x45,0x0F,0xB6,0xC0,0x41,0x23,0xC8,0x8D,0x04,0x85,0x05,0x00,0x00,0x00,0x44,0x8B,0xC0,0x41,0xC1,0xF8,0x1F,0x41,0x83,0xE0,0x3F,0x44,0x03,0xC0,0x41,0xC1,0xF8,0x06,0x44,0x8B,0xC8,0x41,0xC1,0xF9,0x1F,0x41,0x83,0xE1,0x3F,0x44,0x03,0xC8,0x41,0x83,0xE1,0xC0,0x41,0x2B,0xC1,0x4D,0x63,0xC0,0x4A,0x8B,0x14,0xC2,0x48,0x0F,0xA3,0xC2,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit readbit_row_col(in GridMoniker moniker, in ulong src, int row, int col)
; location: [7FFDDBAA55B0h, 7FFDDBAA55F3h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx eax,word ptr [rcx+2]    ; MOVZX(Movzx_r32_rm16) [EAX,mem(16u,RCX:br,:sr)]      encoding(4 bytes) = 0f b7 41 02
0009h imul eax,r8d                  ; IMUL(Imul_r32_rm32) [EAX,R8D]                        encoding(4 bytes) = 41 0f af c0
000dh add eax,r9d                   ; ADD(Add_r32_rm32) [EAX,R9D]                          encoding(3 bytes) = 41 03 c1
0010h mov ecx,eax                   ; MOV(Mov_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 8b c8
0012h sar ecx,1Fh                   ; SAR(Sar_rm32_imm8) [ECX,1fh:imm8]                    encoding(3 bytes) = c1 f9 1f
0015h and ecx,3Fh                   ; AND(And_rm32_imm8) [ECX,3fh:imm32]                   encoding(3 bytes) = 83 e1 3f
0018h add ecx,eax                   ; ADD(Add_r32_rm32) [ECX,EAX]                          encoding(2 bytes) = 03 c8
001ah sar ecx,6                     ; SAR(Sar_rm32_imm8) [ECX,6h:imm8]                     encoding(3 bytes) = c1 f9 06
001dh mov r8d,eax                   ; MOV(Mov_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 8b c0
0020h sar r8d,1Fh                   ; SAR(Sar_rm32_imm8) [R8D,1fh:imm8]                    encoding(4 bytes) = 41 c1 f8 1f
0024h and r8d,3Fh                   ; AND(And_rm32_imm8) [R8D,3fh:imm32]                   encoding(4 bytes) = 41 83 e0 3f
0028h add r8d,eax                   ; ADD(Add_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 03 c0
002bh and r8d,0FFFFFFC0h            ; AND(And_rm32_imm8) [R8D,ffffffffffffffc0h:imm32]     encoding(4 bytes) = 41 83 e0 c0
002fh sub eax,r8d                   ; SUB(Sub_r32_rm32) [EAX,R8D]                          encoding(3 bytes) = 41 2b c0
0032h movsxd rcx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RCX,ECX]                    encoding(3 bytes) = 48 63 c9
0035h mov rdx,[rdx+rcx*8]           ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 8b 14 ca
0039h bt rdx,rax                    ; BT(Bt_rm64_r64) [RDX,RAX]                            encoding(4 bytes) = 48 0f a3 c2
003dh setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0040h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0043h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> readbit_row_colBytes => new byte[68]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x41,0x02,0x41,0x0F,0xAF,0xC0,0x41,0x03,0xC1,0x8B,0xC8,0xC1,0xF9,0x1F,0x83,0xE1,0x3F,0x03,0xC8,0xC1,0xF9,0x06,0x44,0x8B,0xC0,0x41,0xC1,0xF8,0x1F,0x41,0x83,0xE0,0x3F,0x44,0x03,0xC0,0x41,0x83,0xE0,0xC0,0x41,0x2B,0xC0,0x48,0x63,0xC9,0x48,0x8B,0x14,0xCA,0x48,0x0F,0xA3,0xC2,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit readbit_row_col_2(int n, ulong src, int row, int col)
; location: [7FFDDBAA5A10h, 7FFDDBAA5A52h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+10h],rdx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RDX]          encoding(5 bytes) = 48 89 54 24 10
000ah imul ecx,r8d                  ; IMUL(Imul_r32_rm32) [ECX,R8D]                        encoding(4 bytes) = 41 0f af c8
000eh add ecx,r9d                   ; ADD(Add_r32_rm32) [ECX,R9D]                          encoding(3 bytes) = 41 03 c9
0011h movsxd rax,ecx                ; MOVSXD(Movsxd_r64_rm32) [RAX,ECX]                    encoding(3 bytes) = 48 63 c1
0014h shr rax,6                     ; SHR(Shr_rm64_imm8) [RAX,6h:imm8]                     encoding(4 bytes) = 48 c1 e8 06
0018h movsxd rcx,ecx                ; MOVSXD(Movsxd_r64_rm32) [RCX,ECX]                    encoding(3 bytes) = 48 63 c9
001bh and rcx,3Fh                   ; AND(And_rm64_imm8) [RCX,3fh:imm64]                   encoding(4 bytes) = 48 83 e1 3f
001fh lea rdx,[rsp+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RSP:br,:sr)]         encoding(5 bytes) = 48 8d 54 24 10
0024h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
0027h lea rax,[rdx+rax*8]           ; LEA(Lea_r64_m) [RAX,mem(Unknown,RDX:br,:sr)]         encoding(4 bytes) = 48 8d 04 c2
002bh mov rax,[rax]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RAX:br,:sr)]          encoding(3 bytes) = 48 8b 00
002eh mov edx,1                     ; MOV(Mov_r32_imm32) [EDX,1h:imm32]                    encoding(5 bytes) = ba 01 00 00 00
0033h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0036h and rax,rdx                   ; AND(And_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 23 c2
0039h test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
003ch setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
003fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0042h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> readbit_row_col_2Bytes => new byte[67]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x89,0x54,0x24,0x10,0x41,0x0F,0xAF,0xC8,0x41,0x03,0xC9,0x48,0x63,0xC1,0x48,0xC1,0xE8,0x06,0x48,0x63,0xC9,0x48,0x83,0xE1,0x3F,0x48,0x8D,0x54,0x24,0x10,0x48,0x63,0xC0,0x48,0x8D,0x04,0xC2,0x48,0x8B,0x00,0xBA,0x01,0x00,0x00,0x00,0x48,0xD3,0xE2,0x48,0x23,0xC2,0x48,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit readbit_g_position(in ulong src, int pos)
; location: [7FFDDBAA5A70h, 7FFDDBAA5AA4h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movsxd rax,edx                ; MOVSXD(Movsxd_r64_rm32) [RAX,EDX]                    encoding(3 bytes) = 48 63 c2
0008h shr rax,6                     ; SHR(Shr_rm64_imm8) [RAX,6h:imm8]                     encoding(4 bytes) = 48 c1 e8 06
000ch movsxd rdx,edx                ; MOVSXD(Movsxd_r64_rm32) [RDX,EDX]                    encoding(3 bytes) = 48 63 d2
000fh and rdx,3Fh                   ; AND(And_rm64_imm8) [RDX,3fh:imm64]                   encoding(4 bytes) = 48 83 e2 3f
0013h movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
0016h lea rcx,[rcx+rax*8]           ; LEA(Lea_r64_m) [RCX,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 0c c1
001ah mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
001dh mov r8d,1                     ; MOV(Mov_r32_imm32) [R8D,1h:imm32]                    encoding(6 bytes) = 41 b8 01 00 00 00
0023h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0025h shl r8,cl                     ; SHL(Shl_rm64_CL) [R8,CL]                             encoding(3 bytes) = 49 d3 e0
0028h and rax,r8                    ; AND(And_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 23 c0
002bh test rax,rax                  ; TEST(Test_rm64_r64) [RAX,RAX]                        encoding(3 bytes) = 48 85 c0
002eh setne al                      ; SETNE(Setne_rm8) [AL]                                encoding(3 bytes) = 0f 95 c0
0031h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0034h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> readbit_g_positionBytes => new byte[53]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x63,0xC2,0x48,0xC1,0xE8,0x06,0x48,0x63,0xD2,0x48,0x83,0xE2,0x3F,0x48,0x63,0xC0,0x48,0x8D,0x0C,0xC1,0x48,0x8B,0x01,0x41,0xB8,0x01,0x00,0x00,0x00,0x8B,0xCA,0x49,0xD3,0xE0,0x49,0x23,0xC0,0x48,0x85,0xC0,0x0F,0x95,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void setbit(in GridMoniker moniker, int row, int col, bit state, ref ulong dst)
; location: [7FFDDBAA5AC0h, 7FFDDBAA5B1Bh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h movzx ecx,word ptr [rcx+2]    ; MOVZX(Movzx_r32_rm16) [ECX,mem(16u,RCX:br,:sr)]      encoding(4 bytes) = 0f b7 49 02
0009h imul ecx,edx                  ; IMUL(Imul_r32_rm32) [ECX,EDX]                        encoding(3 bytes) = 0f af ca
000ch add ecx,r8d                   ; ADD(Add_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 03 c8
000fh mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0011h sar eax,1Fh                   ; SAR(Sar_rm32_imm8) [EAX,1fh:imm8]                    encoding(3 bytes) = c1 f8 1f
0014h and eax,3Fh                   ; AND(And_rm32_imm8) [EAX,3fh:imm32]                   encoding(3 bytes) = 83 e0 3f
0017h add eax,ecx                   ; ADD(Add_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 03 c1
0019h sar eax,6                     ; SAR(Sar_rm32_imm8) [EAX,6h:imm8]                     encoding(3 bytes) = c1 f8 06
001ch mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
001eh sar edx,1Fh                   ; SAR(Sar_rm32_imm8) [EDX,1fh:imm8]                    encoding(3 bytes) = c1 fa 1f
0021h and edx,3Fh                   ; AND(And_rm32_imm8) [EDX,3fh:imm32]                   encoding(3 bytes) = 83 e2 3f
0024h add edx,ecx                   ; ADD(Add_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 03 d1
0026h and edx,0FFFFFFC0h            ; AND(And_rm32_imm8) [EDX,ffffffffffffffc0h:imm32]     encoding(3 bytes) = 83 e2 c0
0029h sub ecx,edx                   ; SUB(Sub_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 2b ca
002bh movsxd rax,eax                ; MOVSXD(Movsxd_r64_rm32) [RAX,EAX]                    encoding(3 bytes) = 48 63 c0
002eh mov rdx,[rsp+28h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 54 24 28
0033h lea rax,[rdx+rax*8]           ; LEA(Lea_r64_m) [RAX,mem(Unknown,RDX:br,:sr)]         encoding(4 bytes) = 48 8d 04 c2
0037h mov edx,r9d                   ; MOV(Mov_r32_rm32) [EDX,R9D]                          encoding(3 bytes) = 41 8b d1
003ah not rdx                       ; NOT(Not_rm64) [RDX]                                  encoding(3 bytes) = 48 f7 d2
003dh inc rdx                       ; INC(Inc_rm64) [RDX]                                  encoding(3 bytes) = 48 ff c2
0040h mov r8,[rax]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RAX:br,:sr)]           encoding(3 bytes) = 4c 8b 00
0043h xor rdx,r8                    ; XOR(Xor_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 33 d0
0046h movzx ecx,cl                  ; MOVZX(Movzx_r32_rm8) [ECX,CL]                        encoding(3 bytes) = 0f b6 c9
0049h mov r9d,1                     ; MOV(Mov_r32_imm32) [R9D,1h:imm32]                    encoding(6 bytes) = 41 b9 01 00 00 00
004fh shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
0052h and rdx,r9                    ; AND(And_r64_rm64) [RDX,R9]                           encoding(3 bytes) = 49 23 d1
0055h xor rdx,r8                    ; XOR(Xor_r64_rm64) [RDX,R8]                           encoding(3 bytes) = 49 33 d0
0058h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
005bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> setbitBytes => new byte[92]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xB7,0x49,0x02,0x0F,0xAF,0xCA,0x41,0x03,0xC8,0x8B,0xC1,0xC1,0xF8,0x1F,0x83,0xE0,0x3F,0x03,0xC1,0xC1,0xF8,0x06,0x8B,0xD1,0xC1,0xFA,0x1F,0x83,0xE2,0x3F,0x03,0xD1,0x83,0xE2,0xC0,0x2B,0xCA,0x48,0x63,0xC0,0x48,0x8B,0x54,0x24,0x28,0x48,0x8D,0x04,0xC2,0x41,0x8B,0xD1,0x48,0xF7,0xD2,0x48,0xFF,0xC2,0x4C,0x8B,0x00,0x49,0x33,0xD0,0x0F,0xB6,0xC9,0x41,0xB9,0x01,0x00,0x00,0x00,0x49,0xD3,0xE1,0x49,0x23,0xD1,0x49,0x33,0xD0,0x48,0x89,0x10,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: BitGrid<uint> bg_load_32x32x32(Span<uint> src)
; location: [7FFDDBAA5F40h, 7FFDDBAA5F64h]
0000h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0001h sub rsp,20h                   ; SUB(Sub_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 ec 20
0005h mov rsi,rcx                   ; MOV(Mov_r64_rm64) [RSI,RCX]                          encoding(3 bytes) = 48 8b f1
0008h mov rcx,rsi                   ; MOV(Mov_r64_rm64) [RCX,RSI]                          encoding(3 bytes) = 48 8b ce
000bh mov r8d,20h                   ; MOV(Mov_r32_imm32) [R8D,20h:imm32]                   encoding(6 bytes) = 41 b8 20 00 00 00
0011h mov r9d,20h                   ; MOV(Mov_r32_imm32) [R9D,20h:imm32]                   encoding(6 bytes) = 41 b9 20 00 00 00
0017h call 7FFDDBAA59C0h            ; CALL(Call_rel32_64) [FFFFFFFFFFFFFA80h:jmp64]        encoding(5 bytes) = e8 64 fa ff ff
001ch mov rax,rsi                   ; MOV(Mov_r64_rm64) [RAX,RSI]                          encoding(3 bytes) = 48 8b c6
001fh add rsp,20h                   ; ADD(Add_rm64_imm8) [RSP,20h:imm64]                   encoding(4 bytes) = 48 83 c4 20
0023h pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
0024h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bg_load_32x32x32Bytes => new byte[37]{0x56,0x48,0x83,0xEC,0x20,0x48,0x8B,0xF1,0x48,0x8B,0xCE,0x41,0xB8,0x20,0x00,0x00,0x00,0x41,0xB9,0x20,0x00,0x00,0x00,0xE8,0x64,0xFA,0xFF,0xFF,0x48,0x8B,0xC6,0x48,0x83,0xC4,0x20,0x5E,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: GridSpec bg_specify(ushort rows, ushort cols, ushort segwidth)
; location: [7FFDDBAA5F80h, 7FFDDBAA6030h]
0000h push rdi                      ; PUSH(Push_r64) [RDI]                                 encoding(1 byte ) = 57
0001h push rsi                      ; PUSH(Push_r64) [RSI]                                 encoding(1 byte ) = 56
0002h sub rsp,18h                   ; SUB(Sub_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 ec 18
0006h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0009h movzx r10d,dx                 ; MOVZX(Movzx_r32_rm16) [R10D,DX]                      encoding(4 bytes) = 44 0f b7 d2
000dh movzx r8d,r8w                 ; MOVZX(Movzx_r32_rm16) [R8D,R8W]                      encoding(4 bytes) = 45 0f b7 c0
0011h mov eax,r10d                  ; MOV(Mov_r32_rm32) [EAX,R10D]                         encoding(3 bytes) = 41 8b c2
0014h imul eax,r8d                  ; IMUL(Imul_r32_rm32) [EAX,R8D]                        encoding(4 bytes) = 41 0f af c0
0018h mov r11d,eax                  ; MOV(Mov_r32_rm32) [R11D,EAX]                         encoding(3 bytes) = 44 8b d8
001bh sar r11d,3                    ; SAR(Sar_rm32_imm8) [R11D,3h:imm8]                    encoding(4 bytes) = 41 c1 fb 03
001fh mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
0021h sar edx,1Fh                   ; SAR(Sar_rm32_imm8) [EDX,1fh:imm8]                    encoding(3 bytes) = c1 fa 1f
0024h and edx,7                     ; AND(And_rm32_imm8) [EDX,7h:imm32]                    encoding(3 bytes) = 83 e2 07
0027h add edx,eax                   ; ADD(Add_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 03 d0
0029h and edx,0FFFFFFF8h            ; AND(And_rm32_imm8) [EDX,fffffffffffffff8h:imm32]     encoding(3 bytes) = 83 e2 f8
002ch sub eax,edx                   ; SUB(Sub_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 2b c2
002eh jne short 0034h               ; JNE(Jne_rel8_64) [34h:jmp64]                         encoding(2 bytes) = 75 04
0030h xor esi,esi                   ; XOR(Xor_r32_rm32) [ESI,ESI]                          encoding(2 bytes) = 33 f6
0032h jmp short 0039h               ; JMP(Jmp_rel8_64) [39h:jmp64]                         encoding(2 bytes) = eb 05
0034h mov esi,1                     ; MOV(Mov_r32_imm32) [ESI,1h:imm32]                    encoding(5 bytes) = be 01 00 00 00
0039h add r11d,esi                  ; ADD(Add_r32_rm32) [R11D,ESI]                         encoding(3 bytes) = 44 03 de
003ch movzx r9d,r9w                 ; MOVZX(Movzx_r32_rm16) [R9D,R9W]                      encoding(4 bytes) = 45 0f b7 c9
0040h mov esi,r9d                   ; MOV(Mov_r32_rm32) [ESI,R9D]                          encoding(3 bytes) = 41 8b f1
0043h sar esi,3                     ; SAR(Sar_rm32_imm8) [ESI,3h:imm8]                     encoding(3 bytes) = c1 fe 03
0046h mov eax,r11d                  ; MOV(Mov_r32_rm32) [EAX,R11D]                         encoding(3 bytes) = 41 8b c3
0049h cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
004ah idiv esi                      ; IDIV(Idiv_rm32) [ESI]                                encoding(2 bytes) = f7 fe
004ch mov edi,eax                   ; MOV(Mov_r32_rm32) [EDI,EAX]                          encoding(2 bytes) = 8b f8
004eh mov eax,r11d                  ; MOV(Mov_r32_rm32) [EAX,R11D]                         encoding(3 bytes) = 41 8b c3
0051h cdq                           ; CDQ(Cdq)                                             encoding(1 byte ) = 99
0052h idiv esi                      ; IDIV(Idiv_rm32) [ESI]                                encoding(2 bytes) = f7 fe
0054h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0056h jne short 005ch               ; JNE(Jne_rel8_64) [5Ch:jmp64]                         encoding(2 bytes) = 75 04
0058h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
005ah jmp short 0061h               ; JMP(Jmp_rel8_64) [61h:jmp64]                         encoding(2 bytes) = eb 05
005ch mov eax,1                     ; MOV(Mov_r32_imm32) [EAX,1h:imm32]                    encoding(5 bytes) = b8 01 00 00 00
0061h add eax,edi                   ; ADD(Add_r32_rm32) [EAX,EDI]                          encoding(2 bytes) = 03 c7
0063h xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0065h lea rsi,[rsp]                 ; LEA(Lea_r64_m) [RSI,mem(Unknown,RSP:br,:sr)]         encoding(4 bytes) = 48 8d 34 24
0069h vxorps xmm0,xmm0,xmm0         ; VXORPS(VEX_Vxorps_xmm_xmm_xmmm128) [XMM0,XMM0,XMM0]  encoding(VEX, 4 bytes) = c5 f8 57 c0
006dh vmovdqu xmmword ptr [rsi],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RSI:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 06
0071h mov [rsi+10h],edx             ; MOV(Mov_rm32_r32) [mem(32u,RSI:br,:sr),EDX]          encoding(3 bytes) = 89 56 10
0074h mov [rsp],r10w                ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,:sr),R10W]         encoding(5 bytes) = 66 44 89 14 24
0079h mov [rsp+2],r8w               ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,:sr),R8W]          encoding(6 bytes) = 66 44 89 44 24 02
007fh mov [rsp+4],r9w               ; MOV(Mov_rm16_r16) [mem(16u,RSP:br,:sr),R9W]          encoding(6 bytes) = 66 44 89 4c 24 04
0085h mov [rsp+0Ch],r11d            ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),R11D]         encoding(5 bytes) = 44 89 5c 24 0c
008ah shl r11d,3                    ; SHL(Shl_rm32_imm8) [R11D,3h:imm8]                    encoding(4 bytes) = 41 c1 e3 03
008eh mov [rsp+8],r11d              ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),R11D]         encoding(5 bytes) = 44 89 5c 24 08
0093h mov [rsp+10h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RSP:br,:sr),EAX]          encoding(4 bytes) = 89 44 24 10
0097h vmovdqu xmm0,xmmword ptr [rsp]; VMOVDQU(VEX_Vmovdqu_xmm_xmmm128) [XMM0,mem(Packed128_Int32,RSP:br,:sr)] encoding(VEX, 5 bytes) = c5 fa 6f 04 24
009ch vmovdqu xmmword ptr [rcx],xmm0; VMOVDQU(VEX_Vmovdqu_xmmm128_xmm) [mem(Packed128_Int32,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 fa 7f 01
00a0h mov eax,[rsp+10h]             ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 10
00a4h mov [rcx+10h],eax             ; MOV(Mov_rm32_r32) [mem(32u,RCX:br,:sr),EAX]          encoding(3 bytes) = 89 41 10
00a7h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
00aah add rsp,18h                   ; ADD(Add_rm64_imm8) [RSP,18h:imm64]                   encoding(4 bytes) = 48 83 c4 18
00aeh pop rsi                       ; POP(Pop_r64) [RSI]                                   encoding(1 byte ) = 5e
00afh pop rdi                       ; POP(Pop_r64) [RDI]                                   encoding(1 byte ) = 5f
00b0h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> bg_specifyBytes => new byte[177]{0x57,0x56,0x48,0x83,0xEC,0x18,0xC5,0xF8,0x77,0x44,0x0F,0xB7,0xD2,0x45,0x0F,0xB7,0xC0,0x41,0x8B,0xC2,0x41,0x0F,0xAF,0xC0,0x44,0x8B,0xD8,0x41,0xC1,0xFB,0x03,0x8B,0xD0,0xC1,0xFA,0x1F,0x83,0xE2,0x07,0x03,0xD0,0x83,0xE2,0xF8,0x2B,0xC2,0x75,0x04,0x33,0xF6,0xEB,0x05,0xBE,0x01,0x00,0x00,0x00,0x44,0x03,0xDE,0x45,0x0F,0xB7,0xC9,0x41,0x8B,0xF1,0xC1,0xFE,0x03,0x41,0x8B,0xC3,0x99,0xF7,0xFE,0x8B,0xF8,0x41,0x8B,0xC3,0x99,0xF7,0xFE,0x85,0xD2,0x75,0x04,0x33,0xC0,0xEB,0x05,0xB8,0x01,0x00,0x00,0x00,0x03,0xC7,0x33,0xD2,0x48,0x8D,0x34,0x24,0xC5,0xF8,0x57,0xC0,0xC5,0xFA,0x7F,0x06,0x89,0x56,0x10,0x66,0x44,0x89,0x14,0x24,0x66,0x44,0x89,0x44,0x24,0x02,0x66,0x44,0x89,0x4C,0x24,0x04,0x44,0x89,0x5C,0x24,0x0C,0x41,0xC1,0xE3,0x03,0x44,0x89,0x5C,0x24,0x08,0x89,0x44,0x24,0x10,0xC5,0xFA,0x6F,0x04,0x24,0xC5,0xFA,0x7F,0x01,0x8B,0x44,0x24,0x10,0x89,0x41,0x10,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x18,0x5E,0x5F,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
