; 2019-12-14 22:09:15:150
; function: Pair<ulong> sub_128u_a(Pair<ulong> a, Pair<ulong> b)
; location: [7FF7F0E7A650h, 7FF7F0E7A67Eh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 8b 52 08
000ch mov r9,rax                    ; MOV(Mov_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 8b c8
000fh sub r9,[r8]                   ; SUB(Sub_r64_rm64) [R9,mem(64u,R8:br,:sr)]            encoding(3 bytes) = 4d 2b 08
0012h cmp rax,r9                    ; CMP(Cmp_r64_rm64) [RAX,R9]                           encoding(3 bytes) = 49 3b c1
0015h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh sub rdx,[r8+8]                ; SUB(Sub_r64_rm64) [RDX,mem(64u,R8:br,:sr)]           encoding(4 bytes) = 49 2b 50 08
001fh mov eax,eax                   ; MOV(Mov_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 8b c0
0021h sub rdx,rax                   ; SUB(Sub_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 2b d0
0024h mov [rcx],r9                  ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),R9]           encoding(3 bytes) = 4c 89 09
0027h mov [rcx+8],rdx               ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RDX]          encoding(4 bytes) = 48 89 51 08
002bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_128u_aBytes => new byte[47]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x48,0x8B,0x52,0x08,0x4C,0x8B,0xC8,0x4D,0x2B,0x08,0x49,0x3B,0xC1,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x49,0x2B,0x50,0x08,0x8B,0xC0,0x48,0x2B,0xD0,0x4C,0x89,0x09,0x48,0x89,0x51,0x08,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void sub_128u_b(in ulong a, in ulong b, ref ulong c)
; location: [7FF7F0E7A690h, 7FF7F0E7A6BEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h sub rax,[rdx]                 ; SUB(Sub_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 2b 02
000bh mov [r8],rax                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RAX]           encoding(3 bytes) = 49 89 00
000eh mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0011h cmp rax,[r8]                  ; CMP(Cmp_r64_rm64) [RAX,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 49 3b 00
0014h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0017h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001ah add r8,8                      ; ADD(Add_rm64_imm8) [R8,8h:imm64]                     encoding(4 bytes) = 49 83 c0 08
001eh mov rcx,[rcx+8]               ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,:sr)]          encoding(4 bytes) = 48 8b 49 08
0022h sub rcx,[rdx+8]               ; SUB(Sub_r64_rm64) [RCX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 2b 4a 08
0026h mov eax,eax                   ; MOV(Mov_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 8b c0
0028h sub rcx,rax                   ; SUB(Sub_r64_rm64) [RCX,RAX]                          encoding(3 bytes) = 48 2b c8
002bh mov [r8],rcx                  ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),RCX]           encoding(3 bytes) = 49 89 08
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sub_128u_bBytes => new byte[47]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x2B,0x02,0x49,0x89,0x00,0x48,0x8B,0x01,0x49,0x3B,0x00,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0x49,0x83,0xC0,0x08,0x48,0x8B,0x49,0x08,0x48,0x2B,0x4A,0x08,0x8B,0xC0,0x48,0x2B,0xC8,0x49,0x89,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ulong byteswap64(ulong src)
; location: [7FF7F0E7A6D0h, 7FF7F0E7A74Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h shr rax,38h                   ; SHR(Shr_rm64_imm8) [RAX,38h:imm8]                    encoding(4 bytes) = 48 c1 e8 38
000ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
000fh mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
0012h shr rdx,30h                   ; SHR(Shr_rm64_imm8) [RDX,30h:imm8]                    encoding(4 bytes) = 48 c1 ea 30
0016h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
0019h shl rdx,8                     ; SHL(Shl_rm64_imm8) [RDX,8h:imm8]                     encoding(4 bytes) = 48 c1 e2 08
001dh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0020h mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
0023h shr rdx,28h                   ; SHR(Shr_rm64_imm8) [RDX,28h:imm8]                    encoding(4 bytes) = 48 c1 ea 28
0027h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
002ah shl rdx,10h                   ; SHL(Shl_rm64_imm8) [RDX,10h:imm8]                    encoding(4 bytes) = 48 c1 e2 10
002eh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0031h mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
0034h shr rdx,20h                   ; SHR(Shr_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 ea 20
0038h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
003bh shl rdx,18h                   ; SHL(Shl_rm64_imm8) [RDX,18h:imm8]                    encoding(4 bytes) = 48 c1 e2 18
003fh or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0042h mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
0045h shr rdx,18h                   ; SHR(Shr_rm64_imm8) [RDX,18h:imm8]                    encoding(4 bytes) = 48 c1 ea 18
0049h movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
004ch shl rdx,20h                   ; SHL(Shl_rm64_imm8) [RDX,20h:imm8]                    encoding(4 bytes) = 48 c1 e2 20
0050h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0053h mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
0056h shr rdx,10h                   ; SHR(Shr_rm64_imm8) [RDX,10h:imm8]                    encoding(4 bytes) = 48 c1 ea 10
005ah movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
005dh shl rdx,28h                   ; SHL(Shl_rm64_imm8) [RDX,28h:imm8]                    encoding(4 bytes) = 48 c1 e2 28
0061h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0064h mov rdx,rcx                   ; MOV(Mov_r64_rm64) [RDX,RCX]                          encoding(3 bytes) = 48 8b d1
0067h shr rdx,8                     ; SHR(Shr_rm64_imm8) [RDX,8h:imm8]                     encoding(4 bytes) = 48 c1 ea 08
006bh movzx edx,dl                  ; MOVZX(Movzx_r32_rm8) [EDX,DL]                        encoding(3 bytes) = 0f b6 d2
006eh shl rdx,30h                   ; SHL(Shl_rm64_imm8) [RDX,30h:imm8]                    encoding(4 bytes) = 48 c1 e2 30
0072h or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
0075h movzx edx,cl                  ; MOVZX(Movzx_r32_rm8) [EDX,CL]                        encoding(3 bytes) = 0f b6 d1
0078h shl rdx,38h                   ; SHL(Shl_rm64_imm8) [RDX,38h:imm8]                    encoding(4 bytes) = 48 c1 e2 38
007ch or rax,rdx                    ; OR(Or_r64_rm64) [RAX,RDX]                            encoding(3 bytes) = 48 0b c2
007fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> byteswap64Bytes => new byte[128]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x48,0xC1,0xE8,0x38,0x0F,0xB6,0xC0,0x48,0x8B,0xD1,0x48,0xC1,0xEA,0x30,0x0F,0xB6,0xD2,0x48,0xC1,0xE2,0x08,0x48,0x0B,0xC2,0x48,0x8B,0xD1,0x48,0xC1,0xEA,0x28,0x0F,0xB6,0xD2,0x48,0xC1,0xE2,0x10,0x48,0x0B,0xC2,0x48,0x8B,0xD1,0x48,0xC1,0xEA,0x20,0x0F,0xB6,0xD2,0x48,0xC1,0xE2,0x18,0x48,0x0B,0xC2,0x48,0x8B,0xD1,0x48,0xC1,0xEA,0x18,0x0F,0xB6,0xD2,0x48,0xC1,0xE2,0x20,0x48,0x0B,0xC2,0x48,0x8B,0xD1,0x48,0xC1,0xEA,0x10,0x0F,0xB6,0xD2,0x48,0xC1,0xE2,0x28,0x48,0x0B,0xC2,0x48,0x8B,0xD1,0x48,0xC1,0xEA,0x08,0x0F,0xB6,0xD2,0x48,0xC1,0xE2,0x30,0x48,0x0B,0xC2,0x0F,0xB6,0xD1,0x48,0xC1,0xE2,0x38,0x48,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt8 mul_8u(UInt8 a, UInt8 b)
; location: [7FF7F0E7A760h, 7FF7F0E7A76Fh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h imul edx,ecx                  ; IMUL(Imul_r32_rm32) [EDX,ECX]                        encoding(3 bytes) = 0f af d1
0008h mov eax,edx                   ; MOV(Mov_r32_rm32) [EAX,EDX]                          encoding(2 bytes) = 8b c2
000ah and eax,0FFh                  ; AND(And_EAX_imm32) [EAX,ffh:imm32]                   encoding(5 bytes) = 25 ff 00 00 00
000fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_8uBytes => new byte[16]{0x0F,0x1F,0x44,0x00,0x00,0x0F,0xAF,0xD1,0x8B,0xC2,0x25,0xFF,0x00,0x00,0x00,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void mul_128u(Pair<ulong> src, ref Pair<ulong> dst)
; location: [7FF7F0E7A780h, 7FF7F0E7A7A8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h mov rcx,[rcx+8]               ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,:sr)]          encoding(4 bytes) = 48 8b 49 08
000ch mov [rsp+10h],rdx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RDX]          encoding(5 bytes) = 48 89 54 24 10
0011h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
0014h mov rdx,rax                   ; MOV(Mov_r64_rm64) [RDX,RAX]                          encoding(3 bytes) = 48 8b d0
0017h mulx rax,r9,rcx               ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,R9,RCX]             encoding(VEX, 5 bytes) = c4 e2 b3 f6 c1
001ch mov [r8],r9                   ; MOV(Mov_rm64_r64) [mem(64u,R8:br,:sr),R9]            encoding(3 bytes) = 4d 89 08
001fh mov rdx,[rsp+10h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 54 24 10
0024h mov [rdx+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),RAX]          encoding(4 bytes) = 48 89 42 08
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_128uBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x8B,0x49,0x08,0x48,0x89,0x54,0x24,0x10,0x4C,0x8B,0xC2,0x48,0x8B,0xD0,0xC4,0xE2,0xB3,0xF6,0xC1,0x4D,0x89,0x08,0x48,0x8B,0x54,0x24,0x10,0x48,0x89,0x42,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Pair<ulong> add_128u(Pair<ulong> a, Pair<ulong> b)
; location: [7FF7F0E7A7C0h, 7FF7F0E7A7EEh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 8b 52 08
000ch mov r9,rax                    ; MOV(Mov_r64_rm64) [R9,RAX]                           encoding(3 bytes) = 4c 8b c8
000fh add r9,[r8]                   ; ADD(Add_r64_rm64) [R9,mem(64u,R8:br,:sr)]            encoding(3 bytes) = 4d 03 08
0012h cmp rax,r9                    ; CMP(Cmp_r64_rm64) [RAX,R9]                           encoding(3 bytes) = 49 3b c1
0015h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh add rdx,[r8+8]                ; ADD(Add_r64_rm64) [RDX,mem(64u,R8:br,:sr)]           encoding(4 bytes) = 49 03 50 08
001fh mov eax,eax                   ; MOV(Mov_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 8b c0
0021h add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
0024h mov [rcx],r9                  ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),R9]           encoding(3 bytes) = 4c 89 09
0027h mov [rcx+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(4 bytes) = 48 89 41 08
002bh mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002eh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> add_128uBytes => new byte[47]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x48,0x8B,0x52,0x08,0x4C,0x8B,0xC8,0x4D,0x03,0x08,0x49,0x3B,0xC1,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0x49,0x03,0x50,0x08,0x8B,0xC0,0x48,0x03,0xC2,0x4C,0x89,0x09,0x48,0x89,0x41,0x08,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Pair<ulong> xor_128u(Pair<ulong> a, Pair<ulong> b)
; location: [7FF7F0E7A800h, 7FF7F0E7A81Dh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h xor rax,[r8]                  ; XOR(Xor_r64_rm64) [RAX,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 49 33 00
000bh mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 8b 52 08
000fh xor rdx,[r8+8]                ; XOR(Xor_r64_rm64) [RDX,mem(64u,R8:br,:sr)]           encoding(4 bytes) = 49 33 50 08
0013h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
0016h mov [rcx+8],rdx               ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RDX]          encoding(4 bytes) = 48 89 51 08
001ah mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
001dh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xor_128uBytes => new byte[30]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x49,0x33,0x00,0x48,0x8B,0x52,0x08,0x49,0x33,0x50,0x08,0x48,0x89,0x01,0x48,0x89,0x51,0x08,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Pair<ulong> xnor_128u(Pair<ulong> a, Pair<ulong> b)
; location: [7FF7F0E7A830h, 7FF7F0E7A853h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h xor rax,[r8]                  ; XOR(Xor_r64_rm64) [RAX,mem(64u,R8:br,:sr)]           encoding(3 bytes) = 49 33 00
000bh mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 8b 52 08
000fh xor rdx,[r8+8]                ; XOR(Xor_r64_rm64) [RDX,mem(64u,R8:br,:sr)]           encoding(4 bytes) = 49 33 50 08
0013h not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
0016h not rdx                       ; NOT(Not_rm64) [RDX]                                  encoding(3 bytes) = 48 f7 d2
0019h mov [rcx],rax                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(3 bytes) = 48 89 01
001ch mov [rcx+8],rdx               ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RDX]          encoding(4 bytes) = 48 89 51 08
0020h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0023h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> xnor_128uBytes => new byte[36]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x49,0x33,0x00,0x48,0x8B,0x52,0x08,0x49,0x33,0x50,0x08,0x48,0xF7,0xD0,0x48,0xF7,0xD2,0x48,0x89,0x01,0x48,0x89,0x51,0x08,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Pair<ulong> negate_128u(Pair<ulong> a)
; location: [7FF7F0E7A870h, 7FF7F0E7A89Ch]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 8b 52 08
000ch not rax                       ; NOT(Not_rm64) [RAX]                                  encoding(3 bytes) = 48 f7 d0
000fh not rdx                       ; NOT(Not_rm64) [RDX]                                  encoding(3 bytes) = 48 f7 d2
0012h lea r8,[rax+1]                ; LEA(Lea_r64_m) [R8,mem(Unknown,RAX:br,:sr)]          encoding(4 bytes) = 4c 8d 40 01
0016h cmp rax,r8                    ; CMP(Cmp_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 3b c0
0019h seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
001ch movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001fh add rax,rdx                   ; ADD(Add_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 03 c2
0022h mov [rcx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),R8]           encoding(3 bytes) = 4c 89 01
0025h mov [rcx+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(4 bytes) = 48 89 41 08
0029h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
002ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> negate_128uBytes => new byte[45]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x48,0x8B,0x52,0x08,0x48,0xF7,0xD0,0x48,0xF7,0xD2,0x4C,0x8D,0x40,0x01,0x49,0x3B,0xC0,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0x48,0x03,0xC2,0x4C,0x89,0x01,0x48,0x89,0x41,0x08,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: ref Pair<ulong> inc_128u(ref Pair<ulong> a)
; location: [7FF7F0E7A8B0h, 7FF7F0E7A8D8h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h lea rdx,[rax+1]               ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 01
000ch cmp rax,rdx                   ; CMP(Cmp_r64_rm64) [RAX,RDX]                          encoding(3 bytes) = 48 3b c2
000fh seta al                       ; SETA(Seta_rm8) [AL]                                  encoding(3 bytes) = 0f 97 c0
0012h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0015h mov r8,[rcx+8]                ; MOV(Mov_r64_rm64) [R8,mem(64u,RCX:br,:sr)]           encoding(4 bytes) = 4c 8b 41 08
0019h mov eax,eax                   ; MOV(Mov_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 8b c0
001bh add rax,r8                    ; ADD(Add_r64_rm64) [RAX,R8]                           encoding(3 bytes) = 49 03 c0
001eh mov [rcx],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RDX]          encoding(3 bytes) = 48 89 11
0021h mov [rcx+8],rax               ; MOV(Mov_rm64_r64) [mem(64u,RCX:br,:sr),RAX]          encoding(4 bytes) = 48 89 41 08
0025h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0028h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> inc_128uBytes => new byte[41]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x8D,0x50,0x01,0x48,0x3B,0xC2,0x0F,0x97,0xC0,0x0F,0xB6,0xC0,0x4C,0x8B,0x41,0x08,0x8B,0xC0,0x49,0x03,0xC0,0x48,0x89,0x11,0x48,0x89,0x41,0x08,0x48,0x8B,0xC1,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Pair<ulong> srl_128u(Pair<ulong> a, int offset)
; location: [7FF7F0E7A8F0h, 7FF7F0E7A959h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r9,[rdx]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,RDX:br,:sr)]           encoding(3 bytes) = 4c 8b 0a
000bh mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 8b 52 08
000fh cmp r8d,40h                   ; CMP(Cmp_rm32_imm8) [R8D,40h:imm32]                   encoding(4 bytes) = 41 83 f8 40
0013h jl short 0035h                ; JL(Jl_rel8_64) [35h:jmp64]                           encoding(2 bytes) = 7c 20
0015h cmp r8d,80h                   ; CMP(Cmp_rm32_imm32) [R8D,80h:imm32]                  encoding(7 bytes) = 41 81 f8 80 00 00 00
001ch jl short 0026h                ; JL(Jl_rel8_64) [26h:jmp64]                           encoding(2 bytes) = 7c 08
001eh xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0021h xor r11d,r11d                 ; XOR(Xor_r32_rm32) [R11D,R11D]                        encoding(3 bytes) = 45 33 db
0024h jmp short 0062h               ; JMP(Jmp_rel8_64) [62h:jmp64]                         encoding(2 bytes) = eb 3c
0026h lea ecx,[r8-40h]              ; LEA(Lea_r32_m) [ECX,mem(Unknown,R8:br,:sr)]          encoding(4 bytes) = 41 8d 48 c0
002ah shr r9,cl                     ; SHR(Shr_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e9
002dh mov r11,r9                    ; MOV(Mov_r64_rm64) [R11,R9]                           encoding(3 bytes) = 4d 8b d9
0030h xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0033h jmp short 0062h               ; JMP(Jmp_rel8_64) [62h:jmp64]                         encoding(2 bytes) = eb 2d
0035h mov r10d,r8d                  ; MOV(Mov_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 8b d0
0038h and r10d,3Fh                  ; AND(And_rm32_imm8) [R10D,3fh:imm32]                  encoding(4 bytes) = 41 83 e2 3f
003ch mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
003fh mov r11,rdx                   ; MOV(Mov_r64_rm64) [R11,RDX]                          encoding(3 bytes) = 4c 8b da
0042h shr r11,cl                    ; SHR(Shr_rm64_CL) [R11,CL]                            encoding(3 bytes) = 49 d3 eb
0045h mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
0048h shr r9,cl                     ; SHR(Shr_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e9
004bh mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
004eh neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0050h add ecx,3Fh                   ; ADD(Add_rm32_imm8) [ECX,3fh:imm32]                   encoding(3 bytes) = 83 c1 3f
0053h shl rdx,1                     ; SHL(Shl_rm64_1) [RDX,1h:imm8]                        encoding(3 bytes) = 48 d1 e2
0056h shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0059h or rdx,r9                     ; OR(Or_r64_rm64) [RDX,R9]                             encoding(3 bytes) = 49 0b d1
005ch mov r10,r11                   ; MOV(Mov_r64_rm64) [R10,R11]                          encoding(3 bytes) = 4d 8b d3
005fh mov r11,rdx                   ; MOV(Mov_r64_rm64) [R11,RDX]                          encoding(3 bytes) = 4c 8b da
0062h mov [rax],r10                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),R10]          encoding(3 bytes) = 4c 89 10
0065h mov [rax+8],r11               ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),R11]          encoding(4 bytes) = 4c 89 58 08
0069h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> srl_128uBytes => new byte[106]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x8B,0x0A,0x48,0x8B,0x52,0x08,0x41,0x83,0xF8,0x40,0x7C,0x20,0x41,0x81,0xF8,0x80,0x00,0x00,0x00,0x7C,0x08,0x45,0x33,0xD2,0x45,0x33,0xDB,0xEB,0x3C,0x41,0x8D,0x48,0xC0,0x49,0xD3,0xE9,0x4D,0x8B,0xD9,0x45,0x33,0xD2,0xEB,0x2D,0x45,0x8B,0xD0,0x41,0x83,0xE2,0x3F,0x41,0x8B,0xCA,0x4C,0x8B,0xDA,0x49,0xD3,0xEB,0x41,0x8B,0xCA,0x49,0xD3,0xE9,0x41,0x8B,0xC8,0xF7,0xD9,0x83,0xC1,0x3F,0x48,0xD1,0xE2,0x48,0xD3,0xE2,0x49,0x0B,0xD1,0x4D,0x8B,0xD3,0x4C,0x8B,0xDA,0x4C,0x89,0x10,0x4C,0x89,0x58,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: Pair<ulong> sll_128u(Pair<ulong> a, int offset)
; location: [7FF7F0E7A970h, 7FF7F0E7A9D9h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0008h mov r9,[rdx]                  ; MOV(Mov_r64_rm64) [R9,mem(64u,RDX:br,:sr)]           encoding(3 bytes) = 4c 8b 0a
000bh mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 8b 52 08
000fh cmp r8d,40h                   ; CMP(Cmp_rm32_imm8) [R8D,40h:imm32]                   encoding(4 bytes) = 41 83 f8 40
0013h jl short 0035h                ; JL(Jl_rel8_64) [35h:jmp64]                           encoding(2 bytes) = 7c 20
0015h cmp r8d,80h                   ; CMP(Cmp_rm32_imm32) [R8D,80h:imm32]                  encoding(7 bytes) = 41 81 f8 80 00 00 00
001ch jl short 0026h                ; JL(Jl_rel8_64) [26h:jmp64]                           encoding(2 bytes) = 7c 08
001eh xor r10d,r10d                 ; XOR(Xor_r32_rm32) [R10D,R10D]                        encoding(3 bytes) = 45 33 d2
0021h xor r11d,r11d                 ; XOR(Xor_r32_rm32) [R11D,R11D]                        encoding(3 bytes) = 45 33 db
0024h jmp short 0062h               ; JMP(Jmp_rel8_64) [62h:jmp64]                         encoding(2 bytes) = eb 3c
0026h lea ecx,[r8-40h]              ; LEA(Lea_r32_m) [ECX,mem(Unknown,R8:br,:sr)]          encoding(4 bytes) = 41 8d 48 c0
002ah shl r9,cl                     ; SHL(Shl_rm64_CL) [R9,CL]                             encoding(3 bytes) = 49 d3 e1
002dh mov r10,r9                    ; MOV(Mov_r64_rm64) [R10,R9]                           encoding(3 bytes) = 4d 8b d1
0030h xor r11d,r11d                 ; XOR(Xor_r32_rm32) [R11D,R11D]                        encoding(3 bytes) = 45 33 db
0033h jmp short 0062h               ; JMP(Jmp_rel8_64) [62h:jmp64]                         encoding(2 bytes) = eb 2d
0035h mov r10d,r8d                  ; MOV(Mov_r32_rm32) [R10D,R8D]                         encoding(3 bytes) = 45 8b d0
0038h and r10d,3Fh                  ; AND(And_rm32_imm8) [R10D,3fh:imm32]                  encoding(4 bytes) = 41 83 e2 3f
003ch mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
003fh shl rdx,cl                    ; SHL(Shl_rm64_CL) [RDX,CL]                            encoding(3 bytes) = 48 d3 e2
0042h mov ecx,r8d                   ; MOV(Mov_r32_rm32) [ECX,R8D]                          encoding(3 bytes) = 41 8b c8
0045h neg ecx                       ; NEG(Neg_rm32) [ECX]                                  encoding(2 bytes) = f7 d9
0047h add ecx,3Fh                   ; ADD(Add_rm32_imm8) [ECX,3fh:imm32]                   encoding(3 bytes) = 83 c1 3f
004ah mov r11,r9                    ; MOV(Mov_r64_rm64) [R11,R9]                           encoding(3 bytes) = 4d 8b d9
004dh shr r11,1                     ; SHR(Shr_rm64_1) [R11,1h:imm8]                        encoding(3 bytes) = 49 d1 eb
0050h shr r11,cl                    ; SHR(Shr_rm64_CL) [R11,CL]                            encoding(3 bytes) = 49 d3 eb
0053h or rdx,r11                    ; OR(Or_r64_rm64) [RDX,R11]                            encoding(3 bytes) = 49 0b d3
0056h mov ecx,r10d                  ; MOV(Mov_r32_rm32) [ECX,R10D]                         encoding(3 bytes) = 41 8b ca
0059h mov r11,r9                    ; MOV(Mov_r64_rm64) [R11,R9]                           encoding(3 bytes) = 4d 8b d9
005ch shl r11,cl                    ; SHL(Shl_rm64_CL) [R11,CL]                            encoding(3 bytes) = 49 d3 e3
005fh mov r10,rdx                   ; MOV(Mov_r64_rm64) [R10,RDX]                          encoding(3 bytes) = 4c 8b d2
0062h mov [rax],r10                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),R10]          encoding(3 bytes) = 4c 89 10
0065h mov [rax+8],r11               ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),R11]          encoding(4 bytes) = 4c 89 58 08
0069h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> sll_128uBytes => new byte[106]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0xC1,0x4C,0x8B,0x0A,0x48,0x8B,0x52,0x08,0x41,0x83,0xF8,0x40,0x7C,0x20,0x41,0x81,0xF8,0x80,0x00,0x00,0x00,0x7C,0x08,0x45,0x33,0xD2,0x45,0x33,0xDB,0xEB,0x3C,0x41,0x8D,0x48,0xC0,0x49,0xD3,0xE1,0x4D,0x8B,0xD1,0x45,0x33,0xDB,0xEB,0x2D,0x45,0x8B,0xD0,0x41,0x83,0xE2,0x3F,0x41,0x8B,0xCA,0x48,0xD3,0xE2,0x41,0x8B,0xC8,0xF7,0xD9,0x83,0xC1,0x3F,0x4D,0x8B,0xD9,0x49,0xD1,0xEB,0x49,0xD3,0xEB,0x49,0x0B,0xD3,0x41,0x8B,0xCA,0x4D,0x8B,0xD9,0x49,0xD3,0xE3,0x4C,0x8B,0xD2,0x4C,0x89,0x10,0x4C,0x89,0x58,0x08,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit same_128u(Pair<ulong> a, Pair<ulong> b)
; location: [7FF7F0E7A9F0h, 7FF7F0E7AA12h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rcx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(3 bytes) = 48 8b 01
0008h cmp rax,[rdx]                 ; CMP(Cmp_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 3b 02
000bh jne short 001dh               ; JNE(Jne_rel8_64) [1Dh:jmp64]                         encoding(2 bytes) = 75 10
000dh mov rax,[rcx+8]               ; MOV(Mov_r64_rm64) [RAX,mem(64u,RCX:br,:sr)]          encoding(4 bytes) = 48 8b 41 08
0011h cmp rax,[rdx+8]               ; CMP(Cmp_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 3b 42 08
0015h sete al                       ; SETE(Sete_rm8) [AL]                                  encoding(3 bytes) = 0f 94 c0
0018h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
001bh jmp short 001fh               ; JMP(Jmp_rel8_64) [1Fh:jmp64]                         encoding(2 bytes) = eb 02
001dh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
001fh movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0022h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> same_128uBytes => new byte[35]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x01,0x48,0x3B,0x02,0x75,0x10,0x48,0x8B,0x41,0x08,0x48,0x3B,0x42,0x08,0x0F,0x94,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit lt_128u(Pair<ulong> a, Pair<ulong> b)
; location: [7FF7F0E7AA30h, 7FF7F0E7AA66h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 8b 52 08
000ch mov r8,[rcx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RCX:br,:sr)]           encoding(3 bytes) = 4c 8b 01
000fh mov rcx,[rcx+8]               ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,:sr)]          encoding(4 bytes) = 48 8b 49 08
0013h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0016h setb r9b                      ; SETB(Setb_rm8) [R9L]                                 encoding(4 bytes) = 41 0f 92 c1
001ah movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
001eh cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0021h jne short 002eh               ; JNE(Jne_rel8_64) [2Eh:jmp64]                         encoding(2 bytes) = 75 0b
0023h cmp r8,rax                    ; CMP(Cmp_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 3b c0
0026h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0029h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002ch jmp short 0030h               ; JMP(Jmp_rel8_64) [30h:jmp64]                         encoding(2 bytes) = eb 02
002eh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0030h or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
0033h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0036h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> lt_128uBytes => new byte[55]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x48,0x8B,0x52,0x08,0x4C,0x8B,0x01,0x48,0x8B,0x49,0x08,0x48,0x3B,0xCA,0x41,0x0F,0x92,0xC1,0x45,0x0F,0xB6,0xC9,0x48,0x3B,0xCA,0x75,0x0B,0x4C,0x3B,0xC0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x41,0x0B,0xC1,0x0F,0xB6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: bit gteq_128u(Pair<ulong> a, Pair<ulong> b)
; location: [7FF7F0E7AA80h, 7FF7F0E7AABBh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov rdx,[rdx+8]               ; MOV(Mov_r64_rm64) [RDX,mem(64u,RDX:br,:sr)]          encoding(4 bytes) = 48 8b 52 08
000ch mov r8,[rcx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RCX:br,:sr)]           encoding(3 bytes) = 4c 8b 01
000fh mov rcx,[rcx+8]               ; MOV(Mov_r64_rm64) [RCX,mem(64u,RCX:br,:sr)]          encoding(4 bytes) = 48 8b 49 08
0013h cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0016h setb r9b                      ; SETB(Setb_rm8) [R9L]                                 encoding(4 bytes) = 41 0f 92 c1
001ah movzx r9d,r9b                 ; MOVZX(Movzx_r32_rm8) [R9D,R9L]                       encoding(4 bytes) = 45 0f b6 c9
001eh cmp rcx,rdx                   ; CMP(Cmp_r64_rm64) [RCX,RDX]                          encoding(3 bytes) = 48 3b ca
0021h jne short 002eh               ; JNE(Jne_rel8_64) [2Eh:jmp64]                         encoding(2 bytes) = 75 0b
0023h cmp r8,rax                    ; CMP(Cmp_r64_rm64) [R8,RAX]                           encoding(3 bytes) = 4c 3b c0
0026h setb al                       ; SETB(Setb_rm8) [AL]                                  encoding(3 bytes) = 0f 92 c0
0029h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
002ch jmp short 0030h               ; JMP(Jmp_rel8_64) [30h:jmp64]                         encoding(2 bytes) = eb 02
002eh xor eax,eax                   ; XOR(Xor_r32_rm32) [EAX,EAX]                          encoding(2 bytes) = 33 c0
0030h or eax,r9d                    ; OR(Or_r32_rm32) [EAX,R9D]                            encoding(3 bytes) = 41 0b c1
0033h movzx eax,al                  ; MOVZX(Movzx_r32_rm8) [EAX,AL]                        encoding(3 bytes) = 0f b6 c0
0036h not eax                       ; NOT(Not_rm32) [EAX]                                  encoding(2 bytes) = f7 d0
0038h and eax,1                     ; AND(And_rm32_imm8) [EAX,1h:imm32]                    encoding(3 bytes) = 83 e0 01
003bh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> gteq_128uBytes => new byte[60]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x8B,0x02,0x48,0x8B,0x52,0x08,0x4C,0x8B,0x01,0x48,0x8B,0x49,0x08,0x48,0x3B,0xCA,0x41,0x0F,0x92,0xC1,0x45,0x0F,0xB6,0xC9,0x48,0x3B,0xCA,0x75,0x0B,0x4C,0x3B,0xC0,0x0F,0x92,0xC0,0x0F,0xB6,0xC0,0xEB,0x02,0x33,0xC0,0x41,0x0B,0xC1,0x0F,0xB6,0xC0,0xF7,0xD0,0x83,0xE0,0x01,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void mul_32u(Pair<uint> src, ref Pair<uint> dst)
; location: [7FF7F0E7AAD0h, 7FF7F0E7AAFCh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov [rsp+8],rcx               ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RCX]          encoding(5 bytes) = 48 89 4c 24 08
000ah mov eax,[rsp+8]               ; MOV(Mov_r32_rm32) [EAX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 44 24 08
000eh mov ecx,[rsp+0Ch]             ; MOV(Mov_r32_rm32) [ECX,mem(32u,RSP:br,:sr)]          encoding(4 bytes) = 8b 4c 24 0c
0012h mov [rsp+10h],rdx             ; MOV(Mov_rm64_r64) [mem(64u,RSP:br,:sr),RDX]          encoding(5 bytes) = 48 89 54 24 10
0017h mov r8,rdx                    ; MOV(Mov_r64_rm64) [R8,RDX]                           encoding(3 bytes) = 4c 8b c2
001ah mov edx,eax                   ; MOV(Mov_r32_rm32) [EDX,EAX]                          encoding(2 bytes) = 8b d0
001ch mulx eax,r9d,ecx              ; MULX(VEX_Mulx_r32_r32_rm32) [EAX,R9D,ECX]            encoding(VEX, 5 bytes) = c4 e2 33 f6 c1
0021h mov [r8],r9d                  ; MOV(Mov_rm32_r32) [mem(32u,R8:br,:sr),R9D]           encoding(3 bytes) = 45 89 08
0024h mov rdx,[rsp+10h]             ; MOV(Mov_r64_rm64) [RDX,mem(64u,RSP:br,:sr)]          encoding(5 bytes) = 48 8b 54 24 10
0029h mov [rdx+4],eax               ; MOV(Mov_rm32_r32) [mem(32u,RDX:br,:sr),EAX]          encoding(3 bytes) = 89 42 04
002ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mul_32uBytes => new byte[45]{0x0F,0x1F,0x44,0x00,0x00,0x48,0x89,0x4C,0x24,0x08,0x8B,0x44,0x24,0x08,0x8B,0x4C,0x24,0x0C,0x48,0x89,0x54,0x24,0x10,0x4C,0x8B,0xC2,0x8B,0xD0,0xC4,0xE2,0x33,0xF6,0xC1,0x45,0x89,0x08,0x48,0x8B,0x54,0x24,0x10,0x89,0x42,0x04,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: UInt8 or_8u(UInt8 a, UInt8 b)
; location: [7FF7F0E7AB10h, 7FF7F0E7AB19h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h or eax,edx                    ; OR(Or_r32_rm32) [EAX,EDX]                            encoding(2 bytes) = 0b c2
0009h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> or_8uBytes => new byte[10]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x0B,0xC2,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mod_const_16(uint a)
; location: [7FF7F0E7AB30h, 7FF7F0E7AB45h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0007h shl rdx,3Ch                   ; SHL(Shl_rm64_imm8) [RDX,3ch:imm8]                    encoding(4 bytes) = 48 c1 e2 3c
000bh mov eax,10h                   ; MOV(Mov_r32_imm32) [EAX,10h:imm32]                   encoding(5 bytes) = b8 10 00 00 00
0010h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_const_16Bytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xD1,0x48,0xC1,0xE2,0x3C,0xB8,0x10,0x00,0x00,0x00,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint div_const_16(uint a)
; location: [7FF7F0E7AB60h, 7FF7F0E7AB76h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov rdx,1000000000000000h     ; MOV(Mov_r64_imm64) [RDX,1000000000000000h:imm64]     encoding(10 bytes) = 48 ba 00 00 00 00 00 00 00 10
0011h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_const_16Bytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x48,0xBA,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x10,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mod_const_25(uint a)
; location: [7FF7F0E7AB90h, 7FF7F0E7ABAFh]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0007h mov rax,0A3D70A3D70A3D71h     ; MOV(Mov_r64_imm64) [RAX,a3d70a3d70a3d71h:imm64]      encoding(10 bytes) = 48 b8 71 3d 0a d7 a3 70 3d 0a
0011h imul rdx,rax                  ; IMUL(Imul_r64_rm64) [RDX,RAX]                        encoding(4 bytes) = 48 0f af d0
0015h mov eax,19h                   ; MOV(Mov_r32_imm32) [EAX,19h:imm32]                   encoding(5 bytes) = b8 19 00 00 00
001ah mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
001fh ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_const_25Bytes => new byte[32]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xD1,0x48,0xB8,0x71,0x3D,0x0A,0xD7,0xA3,0x70,0x3D,0x0A,0x48,0x0F,0xAF,0xD0,0xB8,0x19,0x00,0x00,0x00,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint div_const_25(uint a)
; location: [7FF7F0E7ABC0h, 7FF7F0E7ABD6h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov rdx,0A3D70A3D70A3D71h     ; MOV(Mov_r64_imm64) [RDX,a3d70a3d70a3d71h:imm64]      encoding(10 bytes) = 48 ba 71 3d 0a d7 a3 70 3d 0a
0011h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_const_25Bytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x48,0xBA,0x71,0x3D,0x0A,0xD7,0xA3,0x70,0x3D,0x0A,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint mod_const_32(uint a)
; location: [7FF7F0E7ABF0h, 7FF7F0E7AC05h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov edx,ecx                   ; MOV(Mov_r32_rm32) [EDX,ECX]                          encoding(2 bytes) = 8b d1
0007h shl rdx,3Bh                   ; SHL(Shl_rm64_imm8) [RDX,3bh:imm8]                    encoding(4 bytes) = 48 c1 e2 3b
000bh mov eax,20h                   ; MOV(Mov_r32_imm32) [EAX,20h:imm32]                   encoding(5 bytes) = b8 20 00 00 00
0010h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
0015h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> mod_const_32Bytes => new byte[22]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xD1,0x48,0xC1,0xE2,0x3B,0xB8,0x20,0x00,0x00,0x00,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: uint div_const_32(uint a)
; location: [7FF7F0E7AC20h, 7FF7F0E7AC36h]
0000h nop dword ptr [rax+rax]       ; NOP(Nop_rm32) [mem(32u,RAX:br,:sr)]                  encoding(5 bytes) = 0f 1f 44 00 00
0005h mov eax,ecx                   ; MOV(Mov_r32_rm32) [EAX,ECX]                          encoding(2 bytes) = 8b c1
0007h mov rdx,800000000000000h      ; MOV(Mov_r64_imm64) [RDX,800000000000000h:imm64]      encoding(10 bytes) = 48 ba 00 00 00 00 00 00 00 08
0011h mulx rax,rax,rax              ; MULX(VEX_Mulx_r64_r64_rm64) [RAX,RAX,RAX]            encoding(VEX, 5 bytes) = c4 e2 fb f6 c0
0016h ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
; static ReadOnlySpan<byte> div_const_32Bytes => new byte[23]{0x0F,0x1F,0x44,0x00,0x00,0x8B,0xC1,0x48,0xBA,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x08,0xC4,0xE2,0xFB,0xF6,0xC0,0xC3};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
