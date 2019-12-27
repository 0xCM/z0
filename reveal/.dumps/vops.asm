; 2019-12-27 03:44:54:383
; function: void loop_1(ReadOnlySpan<uint> src, Span<uint> dst)
; location: [7FF7C80255A0h, 7FF7C80255D1h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h mov rcx,[rdx]                 ; MOV(Mov_r64_rm64) [RCX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 0a
000bh mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 52 08
000eh xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
0011h test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
0013h jle short 0031h               ; JLE(Jle_rel8_64) [31h:jmp64]                         encoding(2 bytes) = 7e 1c
0015h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0018h lea r10,[rcx+r9*4]            ; LEA(Lea_r64_m) [R10,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 4e 8d 14 89
001ch mov r9d,[rax+r9*4]            ; MOV(Mov_r32_rm32) [R9D,mem(32u,RAX:br,:sr)]          encoding(4 bytes) = 46 8b 0c 88
0020h not r9d                       ; NOT(Not_rm32) [R9D]                                  encoding(3 bytes) = 41 f7 d1
0023h inc r9d                       ; INC(Inc_rm32) [R9D]                                  encoding(3 bytes) = 41 ff c1
0026h mov [r10],r9d                 ; MOV(Mov_rm32_r32) [mem(32u,R10:br,:sr),R9D]          encoding(3 bytes) = 45 89 0a
0029h inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
002ch cmp r8d,edx                   ; CMP(Cmp_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 3b c2
002fh jl short 0015h                ; JL(Jl_rel8_64) [15h:jmp64]                           encoding(2 bytes) = 7c e4
0031h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loop_1Bytes => new byte[50]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x8B,0x0A,0x8B,0x52,0x08,0x45,0x33,0xC0,0x85,0xD2,0x7E,0x1C,0x4D,0x63,0xC8,0x4E,0x8D,0x14,0x89,0x46,0x8B,0x0C,0x88,0x41,0xF7,0xD1,0x41,0xFF,0xC1,0x45,0x89,0x0A,0x41,0xFF,0xC0,0x44,0x3B,0xC2,0x7C,0xE4,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void loop_2(ArrayExchange<uint> src, ArrayExchange<uint> dst)
; location: [7FF7C80259F0h, 7FF7C8025A3Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h test rcx,rcx                  ; TEST(Test_rm64_r64) [RCX,RCX]                        encoding(3 bytes) = 48 85 c9
0008h jne short 000eh               ; JNE(Jne_rel8_64) [Eh:jmp64]                          encoding(2 bytes) = 75 04
000ah xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000ch jmp short 0015h               ; JMP(Jmp_rel8_64) [15h:jmp64]                         encoding(2 bytes) = eb 07
000eh lea rax,[rcx+10h]             ; LEA(Lea_r64_m) [RAX,mem(Unknown,RCX:br,:sr)]         encoding(4 bytes) = 48 8d 41 10
0012h mov ecx,[rcx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RCX:br,:sr)]          encoding(3 bytes) = 8b 49 08
0015h test rdx,rdx                  ; TEST(Test_rm64_r64) [RDX,RDX]                        encoding(3 bytes) = 48 85 d2
0018h jne short 001eh               ; JNE(Jne_rel8_64) [1Eh:jmp64]                         encoding(2 bytes) = 75 04
001ah xor ecx,ecx                   ; XOR(Xor_r32_rm32) [ECX,ECX]                          encoding(2 bytes) = 33 c9
001ch jmp short 0026h               ; JMP(Jmp_rel8_64) [26h:jmp64]                         encoding(2 bytes) = eb 08
001eh lea rcx,[rdx+10h]             ; LEA(Lea_r64_m) [RCX,mem(Unknown,RDX:br,:sr)]         encoding(4 bytes) = 48 8d 4a 10
0022h mov r8d,[rdx+8]               ; MOV(Mov_r32_rm32) [R8D,mem(32u,RDX:br,:sr)]          encoding(4 bytes) = 44 8b 42 08
0026h mov edx,[rdx+8]               ; MOV(Mov_r32_rm32) [EDX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 52 08
0029h xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
002ch test edx,edx                  ; TEST(Test_rm32_r32) [EDX,EDX]                        encoding(2 bytes) = 85 d2
002eh jle short 004fh               ; JLE(Jle_rel8_64) [4Fh:jmp64]                         encoding(2 bytes) = 7e 1f
0030h movsxd r9,r8d                 ; MOVSXD(Movsxd_r64_rm32) [R9,R8D]                     encoding(3 bytes) = 4d 63 c8
0033h lea r9,[rcx+r9*4]             ; LEA(Lea_r64_m) [R9,mem(Unknown,RCX:br,:sr)]          encoding(4 bytes) = 4e 8d 0c 89
0037h movsxd r10,r8d                ; MOVSXD(Movsxd_r64_rm32) [R10,R8D]                    encoding(3 bytes) = 4d 63 d0
003ah mov r10d,[rax+r10*4]          ; MOV(Mov_r32_rm32) [R10D,mem(32u,RAX:br,:sr)]         encoding(4 bytes) = 46 8b 14 90
003eh not r10d                      ; NOT(Not_rm32) [R10D]                                 encoding(3 bytes) = 41 f7 d2
0041h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
0044h mov [r9],r10d                 ; MOV(Mov_rm32_r32) [mem(32u,R9:br,:sr),R10D]          encoding(3 bytes) = 45 89 11
0047h inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
004ah cmp r8d,edx                   ; CMP(Cmp_r32_rm32) [R8D,EDX]                          encoding(3 bytes) = 44 3b c2
004dh jl short 0030h                ; JL(Jl_rel8_64) [30h:jmp64]                           encoding(2 bytes) = 7c e1
004fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> loop_2Bytes => new byte[80]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x85,0xC9,0x75,0x04,0x33,0xC0,0xEB,0x07,0x48,0x8D,0x41,0x10,0x8B,0x49,0x08,0x48,0x85,0xD2,0x75,0x04,0x33,0xC9,0xEB,0x08,0x48,0x8D,0x4A,0x10,0x44,0x8B,0x42,0x08,0x8B,0x52,0x08,0x45,0x33,0xC0,0x85,0xD2,0x7E,0x1F,0x4D,0x63,0xC8,0x4E,0x8D,0x0C,0x89,0x4D,0x63,0xD0,0x46,0x8B,0x14,0x90,0x41,0xF7,0xD2,0x41,0xFF,0xC2,0x45,0x89,0x11,0x41,0xFF,0xC0,0x44,0x3B,0xC2,0x7C,0xE1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void pipeline_1(ReadOnlySpan<uint> src, Span<uint> dst)
; location: [7FF7C8025A50h, 7FF7C8025A87h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rdx+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 42 08
0008h xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
000bh test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000dh jle short 0037h               ; JLE(Jle_rel8_64) [37h:jmp64]                         encoding(2 bytes) = 7e 28
000fh mov r9,[rdx]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,RDX:br,:sr)]           encoding(3 bytes) = 4c 8b 0a
0012h movsxd r10,r8d                ; MOVSXD(Movsxd_r64_rm32) [R10,R8D]                    encoding(3 bytes) = 4d 63 d0
0015h lea r9,[r9+r10*4]             ; LEA(Lea_r64_m) [R9,mem(Unknown,R9:br,:sr)]           encoding(4 bytes) = 4f 8d 0c 91
0019h mov r10,[rcx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 4c 8b 11
001ch movsxd r11,r8d                ; MOVSXD(Movsxd_r64_rm32) [R11,R8D]                    encoding(3 bytes) = 4d 63 d8
001fh mov r10d,[r10+r11*4]          ; MOV(Mov_r32_rm32) [R10D,mem(32u,R10:br,:sr)]         encoding(4 bytes) = 47 8b 14 9a
0023h not r10d                      ; NOT(Not_rm32) [R10D]                                 encoding(3 bytes) = 41 f7 d2
0026h inc r10d                      ; INC(Inc_rm32) [R10D]                                 encoding(3 bytes) = 41 ff c2
0029h not r10d                      ; NOT(Not_rm32) [R10D]                                 encoding(3 bytes) = 41 f7 d2
002ch mov [r9],r10d                 ; MOV(Mov_rm32_r32) [mem(32u,R9:br,:sr),R10D]          encoding(3 bytes) = 45 89 11
002fh inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
0032h cmp r8d,eax                   ; CMP(Cmp_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 3b c0
0035h jl short 000fh                ; JL(Jl_rel8_64) [Fh:jmp64]                            encoding(2 bytes) = 7c d8
0037h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pipeline_1Bytes => new byte[56]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x42,0x08,0x45,0x33,0xC0,0x85,0xC0,0x7E,0x28,0x4C,0x8B,0x0A,0x4D,0x63,0xD0,0x4F,0x8D,0x0C,0x91,0x4C,0x8B,0x11,0x4D,0x63,0xD8,0x47,0x8B,0x14,0x9A,0x41,0xF7,0xD2,0x41,0xFF,0xC2,0x41,0xF7,0xD2,0x45,0x89,0x11,0x41,0xFF,0xC0,0x44,0x3B,0xC0,0x7C,0xD8,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void pipeline_2(ReadOnlySpan<uint> src, Span<uint> dst)
; location: [7FF7C8025AA0h, 7FF7C8025ADAh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rdx+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 42 08
0008h xor r8d,r8d                   ; XOR(Xor_r32_rm32) [R8D,R8D]                          encoding(3 bytes) = 45 33 c0
000bh test eax,eax                  ; TEST(Test_rm32_r32) [EAX,EAX]                        encoding(2 bytes) = 85 c0
000dh jle short 003ah               ; JLE(Jle_rel8_64) [3Ah:jmp64]                         encoding(2 bytes) = 7e 2b
000fh mov r9,[rdx]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,RDX:br,:sr)]           encoding(3 bytes) = 4c 8b 0a
0012h movsxd r10,r8d                ; MOVSXD(Movsxd_r64_rm32) [R10,R8D]                    encoding(3 bytes) = 4d 63 d0
0015h lea r9,[r9+r10*4]             ; LEA(Lea_r64_m) [R9,mem(Unknown,R9:br,:sr)]           encoding(4 bytes) = 4f 8d 0c 91
0019h mov r10,[rcx]                 ; MOV(Mov_r64_rm64) [R10,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 4c 8b 11
001ch movsxd r11,r8d                ; MOVSXD(Movsxd_r64_rm32) [R11,R8D]                    encoding(3 bytes) = 4d 63 d8
001fh mov r10d,[r10+r11*4]          ; MOV(Mov_r32_rm32) [R10D,mem(32u,R10:br,:sr)]         encoding(4 bytes) = 47 8b 14 9a
0023h mov r11d,r10d                 ; MOV(Mov_r32_rm32) [R11D,R10D]                        encoding(3 bytes) = 45 8b da
0026h not r11d                      ; NOT(Not_rm32) [R11D]                                 encoding(3 bytes) = 41 f7 d3
0029h inc r11d                      ; INC(Inc_rm32) [R11D]                                 encoding(3 bytes) = 41 ff c3
002ch and r10d,r11d                 ; AND(And_r32_rm32) [R10D,R11D]                        encoding(3 bytes) = 45 23 d3
002fh mov [r9],r10d                 ; MOV(Mov_rm32_r32) [mem(32u,R9:br,:sr),R10D]          encoding(3 bytes) = 45 89 11
0032h inc r8d                       ; INC(Inc_rm32) [R8D]                                  encoding(3 bytes) = 41 ff c0
0035h cmp r8d,eax                   ; CMP(Cmp_r32_rm32) [R8D,EAX]                          encoding(3 bytes) = 44 3b c0
0038h jl short 000fh                ; JL(Jl_rel8_64) [Fh:jmp64]                            encoding(2 bytes) = 7c d5
003ah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> pipeline_2Bytes => new byte[59]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x42,0x08,0x45,0x33,0xC0,0x85,0xC0,0x7E,0x2B,0x4C,0x8B,0x0A,0x4D,0x63,0xD0,0x4F,0x8D,0x0C,0x91,0x4C,0x8B,0x11,0x4D,0x63,0xD8,0x47,0x8B,0x14,0x9A,0x45,0x8B,0xDA,0x41,0xF7,0xD3,0x41,0xFF,0xC3,0x45,0x23,0xD3,0x45,0x89,0x11,0x41,0xFF,0xC0,0x44,0x3B,0xC0,0x7C,0xD5,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint and_negate(uint x)
; location: [7FF7C8025AF0h, 7FF7C8025AFDh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_negateBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint and_negate_ops(uint x)
; location: [7FF7C8025B10h, 7FF7C8025B1Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_negate_opsBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint vxor_128x32u(Vector128<uint> x, Vector128<uint> y)
; location: [7FF7C8025F40h, 7FF7C8025F5Fh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[rcx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RCX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 01
000bh vmovd eax,xmm0                ; VMOVD(VEX_Vmovd_rm32_xmm) [EAX,XMM0]                 encoding(VEX, 4 bytes) = c5 f9 7e c0
000fh vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0013h vpextrd edx,xmm0,3            ; VPEXTRD(VEX_Vpextrd_rm32_xmm_imm8) [EDX,XMM0,3h:imm8] encoding(VEX, 6 bytes) = c4 e3 79 16 c2 03
0019h xor eax,edx                   ; XOR(Xor_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 33 c2
001bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> vxor_128x32uBytes => new byte[32]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x01,0xC5,0xF9,0x7E,0xC0,0xC5,0xF9,0x10,0x02,0xC4,0xE3,0x79,0x16,0xC2,0x03,0x33,0xC2,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> op_shift_specific(Vector256<uint> src)
; location: [7FF7C8026380h, 7FF7C80263A6h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000bh vpslld ymm0,ymm0,3            ; VPSLLD(VEX_Vpslld_ymm_ymm_imm8) [YMM0,YMM0,3h:imm8]  encoding(VEX, 5 bytes) = c5 fd 72 f0 03
0010h vpsrld ymm0,ymm0,3            ; VPSRLD(VEX_Vpsrld_ymm_ymm_imm8) [YMM0,YMM0,3h:imm8]  encoding(VEX, 5 bytes) = c5 fd 72 d0 03
0015h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0017h cmp eax,14h                   ; CMP(Cmp_rm32_imm8) [EAX,14h:imm32]                   encoding(3 bytes) = 83 f8 14
001ah jl short 000bh                ; JL(Jl_rel8_64) [Bh:jmp64]                            encoding(2 bytes) = 7c ef
001ch vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
0020h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0023h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0026h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> op_shift_specificBytes => new byte[39]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0x33,0xC0,0xC5,0xFD,0x72,0xF0,0x03,0xC5,0xFD,0x72,0xD0,0x03,0xFF,0xC0,0x83,0xF8,0x14,0x7C,0xEF,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector256<uint> op_shift(Vector256<uint> src, byte amount)
; location: [7FF7C80263C0h, 7FF7C80263F0h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd ymm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_ymm_ymmm256) [YMM0,mem(Packed256_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 fd 10 02
0009h xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
000bh movzx edx,r8b                 ; MOVZX(Movzx_r32_rm8) [EDX,R8L]                       encoding(4 bytes) = 41 0f b6 d0
000fh vmovd xmm1,edx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EDX]                 encoding(VEX, 4 bytes) = c5 f9 6e ca
0013h vpslld ymm0,ymm0,xmm1         ; VPSLLD(VEX_Vpslld_ymm_ymm_xmmm128) [YMM0,YMM0,XMM1]  encoding(VEX, 4 bytes) = c5 fd f2 c1
0017h vmovd xmm1,edx                ; VMOVD(VEX_Vmovd_xmm_rm32) [XMM1,EDX]                 encoding(VEX, 4 bytes) = c5 f9 6e ca
001bh vpsrld ymm0,ymm0,xmm1         ; VPSRLD(VEX_Vpsrld_ymm_ymm_xmmm128) [YMM0,YMM0,XMM1]  encoding(VEX, 4 bytes) = c5 fd d2 c1
001fh inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
0021h cmp eax,14h                   ; CMP(Cmp_rm32_imm8) [EAX,14h:imm32]                   encoding(3 bytes) = 83 f8 14
0024h jl short 000fh                ; JL(Jl_rel8_64) [Fh:jmp64]                            encoding(2 bytes) = 7c e9
0026h vmovupd [rcx],ymm0            ; VMOVUPD(VEX_Vmovupd_ymmm256_ymm) [mem(Packed256_Float64,RCX:br,:sr),YMM0] encoding(VEX, 4 bytes) = c5 fd 11 01
002ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002dh vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0030h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> op_shiftBytes => new byte[49]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xFD,0x10,0x02,0x33,0xC0,0x41,0x0F,0xB6,0xD0,0xC5,0xF9,0x6E,0xCA,0xC5,0xFD,0xF2,0xC1,0xC5,0xF9,0x6E,0xCA,0xC5,0xFD,0xD2,0xC1,0xFF,0xC0,0x83,0xF8,0x14,0x7C,0xE9,0xC5,0xFD,0x11,0x01,0x48,0x8B,0xC1,0xC5,0xF8,0x77,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
