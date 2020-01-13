; 2020-01-12 17:49:14:502
; function: long loop_inc(int start, int max, long count)
; static ReadOnlySpan<byte> loop_incBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x8B,0xC0,0x3B,0xCA,0x7D,0x0C,0x4C,0x63,0xC1,0x49,0x03,0xC0,0xFF,0xC1,0x3B,0xCA,0x7C,0xF4,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,r8                              ; MOV(Mov_r64_rm64) [RAX,R8]                 encoding(3 bytes) = 49 8b c0
0008h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
000ah jge short 0018h                         ; JGE(Jge_rel8_64) [18h:jmp64]               encoding(2 bytes) = 7d 0c
000ch movsxd r8,ecx                           ; MOVSXD(Movsxd_r64_rm32) [R8,ECX]           encoding(3 bytes) = 4c 63 c1
000fh add rax,r8                              ; ADD(Add_r64_rm64) [RAX,R8]                 encoding(3 bytes) = 49 03 c0
0012h inc ecx                                 ; INC(Inc_rm32) [ECX]                        encoding(2 bytes) = ff c1
0014h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0016h jl short 000ch                          ; JL(Jl_rel8_64) [Ch:jmp64]                  encoding(2 bytes) = 7c f4
0018h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long loop_inc_test_neq(int start, int test, long count)
; static ReadOnlySpan<byte> loop_inc_test_neqBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x8B,0xC0,0x3B,0xCA,0x74,0x0C,0x4C,0x63,0xC1,0x49,0x03,0xC0,0xFF,0xC1,0x3B,0xCA,0x75,0xF4,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,r8                              ; MOV(Mov_r64_rm64) [RAX,R8]                 encoding(3 bytes) = 49 8b c0
0008h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
000ah je short 0018h                          ; JE(Je_rel8_64) [18h:jmp64]                 encoding(2 bytes) = 74 0c
000ch movsxd r8,ecx                           ; MOVSXD(Movsxd_r64_rm32) [R8,ECX]           encoding(3 bytes) = 4c 63 c1
000fh add rax,r8                              ; ADD(Add_r64_rm64) [RAX,R8]                 encoding(3 bytes) = 49 03 c0
0012h inc ecx                                 ; INC(Inc_rm32) [ECX]                        encoding(2 bytes) = ff c1
0014h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0016h jne short 000ch                         ; JNE(Jne_rel8_64) [Ch:jmp64]                encoding(2 bytes) = 75 f4
0018h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long loop_dec(int start, int min, long count)
; static ReadOnlySpan<byte> loop_decBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x8B,0xC0,0x3B,0xCA,0x7C,0x0C,0x4C,0x63,0xC1,0x49,0x03,0xC0,0xFF,0xC9,0x3B,0xCA,0x7D,0xF4,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,r8                              ; MOV(Mov_r64_rm64) [RAX,R8]                 encoding(3 bytes) = 49 8b c0
0008h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
000ah jl short 0018h                          ; JL(Jl_rel8_64) [18h:jmp64]                 encoding(2 bytes) = 7c 0c
000ch movsxd r8,ecx                           ; MOVSXD(Movsxd_r64_rm32) [R8,ECX]           encoding(3 bytes) = 4c 63 c1
000fh add rax,r8                              ; ADD(Add_r64_rm64) [RAX,R8]                 encoding(3 bytes) = 49 03 c0
0012h dec ecx                                 ; DEC(Dec_rm32) [ECX]                        encoding(2 bytes) = ff c9
0014h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0016h jge short 000ch                         ; JGE(Jge_rel8_64) [Ch:jmp64]                encoding(2 bytes) = 7d f4
0018h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long loop_inc_step(int start, int max, int step, long count)
; static ReadOnlySpan<byte> loop_inc_stepBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x8B,0xC1,0x3B,0xCA,0x7D,0x0D,0x4C,0x63,0xC9,0x49,0x03,0xC1,0x41,0x03,0xC8,0x3B,0xCA,0x7C,0xF3,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,r9                              ; MOV(Mov_r64_rm64) [RAX,R9]                 encoding(3 bytes) = 49 8b c1
0008h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
000ah jge short 0019h                         ; JGE(Jge_rel8_64) [19h:jmp64]               encoding(2 bytes) = 7d 0d
000ch movsxd r9,ecx                           ; MOVSXD(Movsxd_r64_rm32) [R9,ECX]           encoding(3 bytes) = 4c 63 c9
000fh add rax,r9                              ; ADD(Add_r64_rm64) [RAX,R9]                 encoding(3 bytes) = 49 03 c1
0012h add ecx,r8d                             ; ADD(Add_r32_rm32) [ECX,R8D]                encoding(3 bytes) = 41 03 c8
0015h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0017h jl short 000ch                          ; JL(Jl_rel8_64) [Ch:jmp64]                  encoding(2 bytes) = 7c f3
0019h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long loop_dec_step(int start, int min, int step, long count)
; static ReadOnlySpan<byte> loop_dec_stepBytes => new byte[26]{0x0F,0x1F,0x44,0x00,0x00,0x49,0x8B,0xC1,0x3B,0xCA,0x7C,0x0D,0x4C,0x63,0xC9,0x49,0x03,0xC1,0x41,0x2B,0xC8,0x3B,0xCA,0x7D,0xF3,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,r9                              ; MOV(Mov_r64_rm64) [RAX,R9]                 encoding(3 bytes) = 49 8b c1
0008h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
000ah jl short 0019h                          ; JL(Jl_rel8_64) [19h:jmp64]                 encoding(2 bytes) = 7c 0d
000ch movsxd r9,ecx                           ; MOVSXD(Movsxd_r64_rm32) [R9,ECX]           encoding(3 bytes) = 4c 63 c9
000fh add rax,r9                              ; ADD(Add_r64_rm64) [RAX,R9]                 encoding(3 bytes) = 49 03 c1
0012h sub ecx,r8d                             ; SUB(Sub_r32_rm32) [ECX,R8D]                encoding(3 bytes) = 41 2b c8
0015h cmp ecx,edx                             ; CMP(Cmp_r32_rm32) [ECX,EDX]                encoding(2 bytes) = 3b ca
0017h jge short 000ch                         ; JGE(Jge_rel8_64) [Ch:jmp64]                encoding(2 bytes) = 7d f3
0019h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long loop_inc_call(long count)
; static ReadOnlySpan<byte> loop_inc_callBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0xBA,0x66,0x00,0x00,0x00,0x48,0x63,0xCA,0x48,0x03,0xC1,0xFF,0xC2,0x81,0xFA,0x66,0x06,0x00,0x00,0x7C,0xF0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h mov edx,66h                             ; MOV(Mov_r32_imm32) [EDX,66h:imm32]         encoding(5 bytes) = ba 66 00 00 00
000dh movsxd rcx,edx                          ; MOVSXD(Movsxd_r64_rm32) [RCX,EDX]          encoding(3 bytes) = 48 63 ca
0010h add rax,rcx                             ; ADD(Add_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 03 c1
0013h inc edx                                 ; INC(Inc_rm32) [EDX]                        encoding(2 bytes) = ff c2
0015h cmp edx,666h                            ; CMP(Cmp_rm32_imm32) [EDX,666h:imm32]       encoding(6 bytes) = 81 fa 66 06 00 00
001bh jl short 000dh                          ; JL(Jl_rel8_64) [Dh:jmp64]                  encoding(2 bytes) = 7c f0
001dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long loop_inc_test_neq_call(long count)
; static ReadOnlySpan<byte> loop_inc_test_neq_callBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0xBA,0x66,0x00,0x00,0x00,0x48,0x63,0xCA,0x48,0x03,0xC1,0xFF,0xC2,0x81,0xFA,0x66,0x06,0x00,0x00,0x75,0xF0,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h mov edx,66h                             ; MOV(Mov_r32_imm32) [EDX,66h:imm32]         encoding(5 bytes) = ba 66 00 00 00
000dh movsxd rcx,edx                          ; MOVSXD(Movsxd_r64_rm32) [RCX,EDX]          encoding(3 bytes) = 48 63 ca
0010h add rax,rcx                             ; ADD(Add_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 03 c1
0013h inc edx                                 ; INC(Inc_rm32) [EDX]                        encoding(2 bytes) = ff c2
0015h cmp edx,666h                            ; CMP(Cmp_rm32_imm32) [EDX,666h:imm32]       encoding(6 bytes) = 81 fa 66 06 00 00
001bh jne short 000dh                         ; JNE(Jne_rel8_64) [Dh:jmp64]                encoding(2 bytes) = 75 f0
001dh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long loop_inc_step_call(long count)
; static ReadOnlySpan<byte> loop_inc_step_callBytes => new byte[31]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0xBA,0x66,0x00,0x00,0x00,0x48,0x63,0xCA,0x48,0x03,0xC1,0x83,0xC2,0x06,0x81,0xFA,0x66,0x06,0x00,0x00,0x7C,0xEF,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h mov edx,66h                             ; MOV(Mov_r32_imm32) [EDX,66h:imm32]         encoding(5 bytes) = ba 66 00 00 00
000dh movsxd rcx,edx                          ; MOVSXD(Movsxd_r64_rm32) [RCX,EDX]          encoding(3 bytes) = 48 63 ca
0010h add rax,rcx                             ; ADD(Add_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 03 c1
0013h add edx,6                               ; ADD(Add_rm32_imm8) [EDX,6h:imm32]          encoding(3 bytes) = 83 c2 06
0016h cmp edx,666h                            ; CMP(Cmp_rm32_imm32) [EDX,666h:imm32]       encoding(6 bytes) = 81 fa 66 06 00 00
001ch jl short 000dh                          ; JL(Jl_rel8_64) [Dh:jmp64]                  encoding(2 bytes) = 7c ef
001eh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long loop_dec_call(long count)
; static ReadOnlySpan<byte> loop_dec_callBytes => new byte[27]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0xBA,0x66,0x06,0x00,0x00,0x48,0x63,0xCA,0x48,0x03,0xC1,0xFF,0xCA,0x83,0xFA,0x66,0x7D,0xF3,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h mov edx,666h                            ; MOV(Mov_r32_imm32) [EDX,666h:imm32]        encoding(5 bytes) = ba 66 06 00 00
000dh movsxd rcx,edx                          ; MOVSXD(Movsxd_r64_rm32) [RCX,EDX]          encoding(3 bytes) = 48 63 ca
0010h add rax,rcx                             ; ADD(Add_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 03 c1
0013h dec edx                                 ; DEC(Dec_rm32) [EDX]                        encoding(2 bytes) = ff ca
0015h cmp edx,66h                             ; CMP(Cmp_rm32_imm8) [EDX,66h:imm32]         encoding(3 bytes) = 83 fa 66
0018h jge short 000dh                         ; JGE(Jge_rel8_64) [Dh:jmp64]                encoding(2 bytes) = 7d f3
001ah ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: long loop_dec_step_call(long count)
; static ReadOnlySpan<byte> loop_dec_step_callBytes => new byte[28]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0xBA,0x66,0x06,0x00,0x00,0x48,0x63,0xCA,0x48,0x03,0xC1,0x83,0xC2,0xFA,0x83,0xFA,0x66,0x7D,0xF2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h mov edx,666h                            ; MOV(Mov_r32_imm32) [EDX,666h:imm32]        encoding(5 bytes) = ba 66 06 00 00
000dh movsxd rcx,edx                          ; MOVSXD(Movsxd_r64_rm32) [RCX,EDX]          encoding(3 bytes) = 48 63 ca
0010h add rax,rcx                             ; ADD(Add_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 03 c1
0013h add edx,0FFFFFFFAh                      ; ADD(Add_rm32_imm8) [EDX,fffffffffffffffah:imm32] encoding(3 bytes) = 83 c2 fa
0016h cmp edx,66h                             ; CMP(Cmp_rm32_imm8) [EDX,66h:imm32]         encoding(3 bytes) = 83 fa 66
0019h jge short 000dh                         ; JGE(Jge_rel8_64) [Dh:jmp64]                encoding(2 bytes) = 7d f2
001bh ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int FindByte(ulong src)
; static ReadOnlySpan<byte> FindByteBytes => new byte[40]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xF7,0xD8,0x48,0x23,0xC1,0x48,0xC1,0xE8,0x08,0x48,0xBA,0x80,0x03,0x83,0x02,0x82,0x01,0x81,0x00,0x48,0x0F,0xAF,0xC2,0x48,0xC1,0xE8,0x37,0x83,0xE0,0x07,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                             ; MOV(Mov_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 8b c1
0008h neg rax                                 ; NEG(Neg_rm64) [RAX]                        encoding(3 bytes) = 48 f7 d8
000bh and rax,rcx                             ; AND(And_r64_rm64) [RAX,RCX]                encoding(3 bytes) = 48 23 c1
000eh shr rax,8                               ; SHR(Shr_rm64_imm8) [RAX,8h:imm8]           encoding(4 bytes) = 48 c1 e8 08
0012h mov rdx,81018202830380h                 ; MOV(Mov_r64_imm64) [RDX,81018202830380h:imm64] encoding(10 bytes) = 48 ba 80 03 83 02 82 01 81 00
001ch imul rax,rdx                            ; IMUL(Imul_r64_rm64) [RAX,RDX]              encoding(4 bytes) = 48 0f af c2
0020h shr rax,37h                             ; SHR(Shr_rm64_imm8) [RAX,37h:imm8]          encoding(4 bytes) = 48 c1 e8 37
0024h and eax,7                               ; AND(And_rm32_imm8) [EAX,7h:imm32]          encoding(3 bytes) = 83 e0 07
0027h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int FindByte(in Block256<byte> src)
; static ReadOnlySpan<byte> FindByteBytes => new byte[71]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0x48,0x8B,0x11,0x48,0x8B,0xCA,0x4C,0x63,0xC0,0x42,0x0F,0xB6,0x0C,0x01,0x48,0x85,0xC9,0x75,0x07,0xFF,0xC0,0x83,0xF8,0x21,0x7C,0xE9,0x48,0x8B,0xD1,0x48,0xF7,0xDA,0x48,0x23,0xD1,0x48,0xC1,0xEA,0x08,0x48,0xB9,0x80,0x03,0x83,0x02,0x82,0x01,0x81,0x00,0x48,0x0F,0xAF,0xD1,0x48,0xC1,0xEA,0x37,0x83,0xE2,0x07,0x8D,0x04,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h mov rdx,[rcx]                           ; MOV(Mov_r64_rm64) [RDX,mem(64u,RCX:br,:sr)] encoding(3 bytes) = 48 8b 11
000ah mov rcx,rdx                             ; MOV(Mov_r64_rm64) [RCX,RDX]                encoding(3 bytes) = 48 8b ca
000dh movsxd r8,eax                           ; MOVSXD(Movsxd_r64_rm32) [R8,EAX]           encoding(3 bytes) = 4c 63 c0
0010h movzx ecx,byte ptr [rcx+r8]             ; MOVZX(Movzx_r32_rm8) [ECX,mem(8u,RCX:br,:sr)] encoding(5 bytes) = 42 0f b6 0c 01
0015h test rcx,rcx                            ; TEST(Test_rm64_r64) [RCX,RCX]              encoding(3 bytes) = 48 85 c9
0018h jne short 0021h                         ; JNE(Jne_rel8_64) [21h:jmp64]               encoding(2 bytes) = 75 07
001ah inc eax                                 ; INC(Inc_rm32) [EAX]                        encoding(2 bytes) = ff c0
001ch cmp eax,21h                             ; CMP(Cmp_rm32_imm8) [EAX,21h:imm32]         encoding(3 bytes) = 83 f8 21
001fh jl short 000ah                          ; JL(Jl_rel8_64) [Ah:jmp64]                  encoding(2 bytes) = 7c e9
0021h mov rdx,rcx                             ; MOV(Mov_r64_rm64) [RDX,RCX]                encoding(3 bytes) = 48 8b d1
0024h neg rdx                                 ; NEG(Neg_rm64) [RDX]                        encoding(3 bytes) = 48 f7 da
0027h and rdx,rcx                             ; AND(And_r64_rm64) [RDX,RCX]                encoding(3 bytes) = 48 23 d1
002ah shr rdx,8                               ; SHR(Shr_rm64_imm8) [RDX,8h:imm8]           encoding(4 bytes) = 48 c1 ea 08
002eh mov rcx,81018202830380h                 ; MOV(Mov_r64_imm64) [RCX,81018202830380h:imm64] encoding(10 bytes) = 48 b9 80 03 83 02 82 01 81 00
0038h imul rdx,rcx                            ; IMUL(Imul_r64_rm64) [RDX,RCX]              encoding(4 bytes) = 48 0f af d1
003ch shr rdx,37h                             ; SHR(Shr_rm64_imm8) [RDX,37h:imm8]          encoding(4 bytes) = 48 c1 ea 37
0040h and edx,7                               ; AND(And_rm32_imm8) [EDX,7h:imm32]          encoding(3 bytes) = 83 e2 07
0043h lea eax,[rdx+rax*8]                     ; LEA(Lea_r32_m) [EAX,mem(Unknown,RDX:br,:sr)] encoding(3 bytes) = 8d 04 c2
0046h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int downBy2ne(int amount)
; static ReadOnlySpan<byte> downBy2neBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xBA,0x09,0x00,0x00,0x00,0x03,0xC1,0x83,0xC2,0xFE,0x83,0xFA,0x01,0x75,0xF6,0x03,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h mov edx,9                               ; MOV(Mov_r32_imm32) [EDX,9h:imm32]          encoding(5 bytes) = ba 09 00 00 00
000ch add eax,ecx                             ; ADD(Add_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 03 c1
000eh add edx,0FFFFFFFEh                      ; ADD(Add_rm32_imm8) [EDX,fffffffffffffffeh:imm32] encoding(3 bytes) = 83 c2 fe
0011h cmp edx,1                               ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]          encoding(3 bytes) = 83 fa 01
0014h jne short 000ch                         ; JNE(Jne_rel8_64) [Ch:jmp64]                encoding(2 bytes) = 75 f6
0016h add eax,edx                             ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
0018h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int upBy1ne(int amount)
; static ReadOnlySpan<byte> upBy1neBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xBA,0x01,0x00,0x00,0x00,0x03,0xC1,0xFF,0xC2,0x83,0xFA,0x08,0x75,0xF7,0x03,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h mov edx,1                               ; MOV(Mov_r32_imm32) [EDX,1h:imm32]          encoding(5 bytes) = ba 01 00 00 00
000ch add eax,ecx                             ; ADD(Add_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 03 c1
000eh inc edx                                 ; INC(Inc_rm32) [EDX]                        encoding(2 bytes) = ff c2
0010h cmp edx,8                               ; CMP(Cmp_rm32_imm8) [EDX,8h:imm32]          encoding(3 bytes) = 83 fa 08
0013h jne short 000ch                         ; JNE(Jne_rel8_64) [Ch:jmp64]                encoding(2 bytes) = 75 f7
0015h add eax,edx                             ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
0017h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int downBy1ne(int amount)
; static ReadOnlySpan<byte> downBy1neBytes => new byte[24]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xBA,0x09,0x00,0x00,0x00,0x03,0xC1,0xFF,0xCA,0x83,0xFA,0x02,0x75,0xF7,0x03,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h mov edx,9                               ; MOV(Mov_r32_imm32) [EDX,9h:imm32]          encoding(5 bytes) = ba 09 00 00 00
000ch add eax,ecx                             ; ADD(Add_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 03 c1
000eh dec edx                                 ; DEC(Dec_rm32) [EDX]                        encoding(2 bytes) = ff ca
0010h cmp edx,2                               ; CMP(Cmp_rm32_imm8) [EDX,2h:imm32]          encoding(3 bytes) = 83 fa 02
0013h jne short 000ch                         ; JNE(Jne_rel8_64) [Ch:jmp64]                encoding(2 bytes) = 75 f7
0015h add eax,edx                             ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
0017h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int upBy2ne(int amount)
; static ReadOnlySpan<byte> upBy2neBytes => new byte[25]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xBA,0x01,0x00,0x00,0x00,0x03,0xC1,0x83,0xC2,0x02,0x83,0xFA,0x09,0x75,0xF6,0x03,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h mov edx,1                               ; MOV(Mov_r32_imm32) [EDX,1h:imm32]          encoding(5 bytes) = ba 01 00 00 00
000ch add eax,ecx                             ; ADD(Add_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 03 c1
000eh add edx,2                               ; ADD(Add_rm32_imm8) [EDX,2h:imm32]          encoding(3 bytes) = 83 c2 02
0011h cmp edx,9                               ; CMP(Cmp_rm32_imm8) [EDX,9h:imm32]          encoding(3 bytes) = 83 fa 09
0014h jne short 000ch                         ; JNE(Jne_rel8_64) [Ch:jmp64]                encoding(2 bytes) = 75 f6
0016h add eax,edx                             ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
0018h ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int upBy3neWrap(int amount)
; static ReadOnlySpan<byte> upBy3neWrapBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xBA,0x01,0x00,0x00,0x00,0x03,0xC1,0x83,0xC2,0x03,0x48,0x0F,0xBF,0xD2,0x83,0xFA,0x08,0x75,0xF2,0x03,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h mov edx,1                               ; MOV(Mov_r32_imm32) [EDX,1h:imm32]          encoding(5 bytes) = ba 01 00 00 00
000ch add eax,ecx                             ; ADD(Add_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 03 c1
000eh add edx,3                               ; ADD(Add_rm32_imm8) [EDX,3h:imm32]          encoding(3 bytes) = 83 c2 03
0011h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
0015h cmp edx,8                               ; CMP(Cmp_rm32_imm8) [EDX,8h:imm32]          encoding(3 bytes) = 83 fa 08
0018h jne short 000ch                         ; JNE(Jne_rel8_64) [Ch:jmp64]                encoding(2 bytes) = 75 f2
001ah add eax,edx                             ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
001ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: int downBy3neWrap(int amount)
; static ReadOnlySpan<byte> downBy3neWrapBytes => new byte[29]{0x0F,0x1F,0x44,0x00,0x00,0x33,0xC0,0xBA,0x08,0x00,0x00,0x00,0x03,0xC1,0x83,0xC2,0xFD,0x48,0x0F,0xBF,0xD2,0x83,0xFA,0x01,0x75,0xF2,0x03,0xC2,0xC3};
0000h nop dword ptr [rax+rax]                 ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]        encoding(5 bytes) = 0f 1f 44 00 00
0005h xor eax,eax                             ; XOR(Xor_r32_rm32) [EAX,EAX]                encoding(2 bytes) = 33 c0
0007h mov edx,8                               ; MOV(Mov_r32_imm32) [EDX,8h:imm32]          encoding(5 bytes) = ba 08 00 00 00
000ch add eax,ecx                             ; ADD(Add_r32_rm32) [EAX,ECX]                encoding(2 bytes) = 03 c1
000eh add edx,0FFFFFFFDh                      ; ADD(Add_rm32_imm8) [EDX,fffffffffffffffdh:imm32] encoding(3 bytes) = 83 c2 fd
0011h movsx rdx,dx                            ; MOVSX(Movsx_r64_rm16) [RDX,DX]             encoding(4 bytes) = 48 0f bf d2
0015h cmp edx,1                               ; CMP(Cmp_rm32_imm8) [EDX,1h:imm32]          encoding(3 bytes) = 83 fa 01
0018h jne short 000ch                         ; JNE(Jne_rel8_64) [Ch:jmp64]                encoding(2 bytes) = 75 f2
001ah add eax,edx                             ; ADD(Add_r32_rm32) [EAX,EDX]                encoding(2 bytes) = 03 c2
001ch ret                                     ; RET(Retnq)                                 encoding(1 byte ) = c3
----------------------------------------------------------------------------------------------------------------------------------------------------------------
