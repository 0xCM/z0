; 2020-01-01 21:58:46:377
; function: Vector128<uint> and_class(Vector128<uint> x, Vector128<uint> y)
; location: [7FF7C7BC9D20h, 7FF7C7BC9D3Fh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0007h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
000bh vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
0010h vpand xmm0,xmm0,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 db c1
0014h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0018h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001bh add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_classBytes => new byte[32]{0x48,0x83,0xEC,0x28,0xC5,0xF8,0x77,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xDB,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint and_class_scalar(uint x, uint y)
; location: [7FF7C7BC9D60h, 7FF7C7BC9D6Dh]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_class_scalarBytes => new byte[14]{0x48,0x83,0xEC,0x28,0x90,0x23,0xD1,0x8B,0xC2,0x48,0x83,0xC4,0x28,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint and_class_scalar(CAnd128<uint> f, uint x, uint y)
; location: [7FF7C7BC9D90h, 7FF7C7BC9D9Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,[rcx]                 ; MOV(Mov_r32_rm32) [EAX,mem(32u,RCX:br,:sr)]          encoding(2 bytes) = 8b 01
0007h and edx,r8d                   ; AND(And_r32_rm32) [EDX,R8D]                          encoding(3 bytes) = 41 23 d0
000ah mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_class_scalarBytes => new byte[13]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0x01,0x41,0x23,0xD0,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Vector128<uint> and_struct(Vector128<uint> x, Vector128<uint> y)
; location: [7FF7C7BCA1C0h, 7FF7C7BCA1D9h]
0000h vzeroupper                    ; VZEROUPPER(VEX_Vzeroupper)                           encoding(VEX, 3 bytes) = c5 f8 77
0003h xchg ax,ax                    ; NOP(Nopw)                                            encoding(2 bytes) = 66 90
0005h vmovupd xmm0,[rdx]            ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM0,mem(Packed128_Float64,RDX:br,:sr)] encoding(VEX, 4 bytes) = c5 f9 10 02
0009h vmovupd xmm1,[r8]             ; VMOVUPD(VEX_Vmovupd_xmm_xmmm128) [XMM1,mem(Packed128_Float64,R8:br,:sr)] encoding(VEX, 5 bytes) = c4 c1 79 10 08
000eh vpand xmm0,xmm0,xmm1          ; VPAND(VEX_Vpand_xmm_xmm_xmmm128) [XMM0,XMM0,XMM1]    encoding(VEX, 4 bytes) = c5 f9 db c1
0012h vmovupd [rcx],xmm0            ; VMOVUPD(VEX_Vmovupd_xmmm128_xmm) [mem(Packed128_Float64,RCX:br,:sr),XMM0] encoding(VEX, 4 bytes) = c5 f9 11 01
0016h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0019h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_structBytes => new byte[26]{0xC5,0xF8,0x77,0x66,0x90,0xC5,0xF9,0x10,0x02,0xC4,0xC1,0x79,0x10,0x08,0xC5,0xF9,0xDB,0xC1,0xC5,0xF9,0x11,0x01,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint and_struct_scalar(uint x, uint y)
; location: [7FF7C7BCA1F0h, 7FF7C7BCA1F9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h and edx,ecx                   ; AND(And_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 23 d1
0007h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_struct_scalarBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x23,0xD1,0x8B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void loop_1(ReadOnlySpan<uint> src, Span<uint> dst)
; location: [7FF7C7BCA620h, 7FF7C7BCA651h]
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
; location: [7FF7C7BCAA70h, 7FF7C7BCAABFh]
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
; location: [7FF7C7BCAAD0h, 7FF7C7BCAB07h]
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
; location: [7FF7C7BCAB20h, 7FF7C7BCAB5Ah]
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
; location: [7FF7C7BCAB70h, 7FF7C7BCAB7Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_negateBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint and_negate_ops(uint x)
; location: [7FF7C7BCAB90h, 7FF7C7BCAB9Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0009h inc eax                       ; INC(Inc_rm32) [EAX]                                  encoding(2 bytes) = ff c0
000bh and eax,ecx                   ; AND(And_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 23 c1
000dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> and_negate_opsBytes => new byte[14]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0xF7,0xD0,0xFF,0xC0,0x23,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint vxor_128x32u(Vector128<uint> x, Vector128<uint> y)
; location: [7FF7C7BCAFC0h, 7FF7C7BCAFDFh]
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
