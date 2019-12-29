; 2019-12-28 14:08:12:487
; function: void part64x1_byte(ulong src, Span<byte> dst)
; location: [7FF7C7B7D480h, 7FF7C7B7D530h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h nop                           ; NOP(Nopd)                                            encoding(1 byte ) = 90
0005h mov rax,[rdx]                 ; MOV(Mov_r64_rm64) [RAX,mem(64u,RDX:br,:sr)]          encoding(3 bytes) = 48 8b 02
0008h mov rdx,101010101010101h      ; MOV(Mov_r64_imm64) [RDX,101010101010101h:imm64]      encoding(10 bytes) = 48 ba 01 01 01 01 01 01 01 01
0012h pdep rdx,rcx,rdx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RCX,RDX]            encoding(VEX, 5 bytes) = c4 e2 f3 f5 d2
0017h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
001ah lea rdx,[rax+8]               ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 08
001eh mov r8,rcx                    ; MOV(Mov_r64_rm64) [R8,RCX]                           encoding(3 bytes) = 4c 8b c1
0021h shr r8,8                      ; SHR(Shr_rm64_imm8) [R8,8h:imm8]                      encoding(4 bytes) = 49 c1 e8 08
0025h mov r9,101010101010101h       ; MOV(Mov_r64_imm64) [R9,101010101010101h:imm64]       encoding(10 bytes) = 49 b9 01 01 01 01 01 01 01 01
002fh pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
0034h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
0037h lea rdx,[rax+10h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 10
003bh mov r8,rcx                    ; MOV(Mov_r64_rm64) [R8,RCX]                           encoding(3 bytes) = 4c 8b c1
003eh shr r8,10h                    ; SHR(Shr_rm64_imm8) [R8,10h:imm8]                     encoding(4 bytes) = 49 c1 e8 10
0042h pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
0047h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
004ah lea rdx,[rax+18h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 18
004eh mov r8,rcx                    ; MOV(Mov_r64_rm64) [R8,RCX]                           encoding(3 bytes) = 4c 8b c1
0051h shr r8,18h                    ; SHR(Shr_rm64_imm8) [R8,18h:imm8]                     encoding(4 bytes) = 49 c1 e8 18
0055h pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
005ah mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
005dh lea rdx,[rax+20h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 20
0061h mov r8,rcx                    ; MOV(Mov_r64_rm64) [R8,RCX]                           encoding(3 bytes) = 4c 8b c1
0064h shr r8,20h                    ; SHR(Shr_rm64_imm8) [R8,20h:imm8]                     encoding(4 bytes) = 49 c1 e8 20
0068h pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
006dh mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
0070h lea rdx,[rax+28h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 28
0074h mov r8,rcx                    ; MOV(Mov_r64_rm64) [R8,RCX]                           encoding(3 bytes) = 4c 8b c1
0077h shr r8,28h                    ; SHR(Shr_rm64_imm8) [R8,28h:imm8]                     encoding(4 bytes) = 49 c1 e8 28
007bh pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
0080h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
0083h lea rdx,[rax+30h]             ; LEA(Lea_r64_m) [RDX,mem(Unknown,RAX:br,:sr)]         encoding(4 bytes) = 48 8d 50 30
0087h mov r8,rcx                    ; MOV(Mov_r64_rm64) [R8,RCX]                           encoding(3 bytes) = 4c 8b c1
008ah shr r8,30h                    ; SHR(Shr_rm64_imm8) [R8,30h:imm8]                     encoding(4 bytes) = 49 c1 e8 30
008eh pdep r8,r8,r9                 ; PDEP(VEX_Pdep_r64_r64_rm64) [R8,R8,R9]               encoding(VEX, 5 bytes) = c4 42 bb f5 c1
0093h mov [rdx],r8                  ; MOV(Mov_rm64_r64) [mem(64u,RDX:br,:sr),R8]           encoding(3 bytes) = 4c 89 02
0096h add rax,38h                   ; ADD(Add_rm64_imm8) [RAX,38h:imm64]                   encoding(4 bytes) = 48 83 c0 38
009ah shr rcx,38h                   ; SHR(Shr_rm64_imm8) [RCX,38h:imm8]                    encoding(4 bytes) = 48 c1 e9 38
009eh pdep rdx,rcx,r9               ; PDEP(VEX_Pdep_r64_r64_rm64) [RDX,RCX,R9]             encoding(VEX, 5 bytes) = c4 c2 f3 f5 d1
00a3h mov [rax],rdx                 ; MOV(Mov_rm64_r64) [mem(64u,RAX:br,:sr),RDX]          encoding(3 bytes) = 48 89 10
00a6h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
00aah ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
00abh call 7FF8270CFC20h            ; CALL(Call_rel32_64) [5F5527A0h:jmp64]                encoding(5 bytes) = e8 f0 26 55 5f
00b0h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part64x1_byteBytes => new byte[177]{0x48,0x83,0xEC,0x28,0x90,0x48,0x8B,0x02,0x48,0xBA,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0xE2,0xF3,0xF5,0xD2,0x48,0x89,0x10,0x48,0x8D,0x50,0x08,0x4C,0x8B,0xC1,0x49,0xC1,0xE8,0x08,0x49,0xB9,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0x01,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x10,0x4C,0x8B,0xC1,0x49,0xC1,0xE8,0x10,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x18,0x4C,0x8B,0xC1,0x49,0xC1,0xE8,0x18,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x20,0x4C,0x8B,0xC1,0x49,0xC1,0xE8,0x20,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x28,0x4C,0x8B,0xC1,0x49,0xC1,0xE8,0x28,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x8D,0x50,0x30,0x4C,0x8B,0xC1,0x49,0xC1,0xE8,0x30,0xC4,0x42,0xBB,0xF5,0xC1,0x4C,0x89,0x02,0x48,0x83,0xC0,0x38,0x48,0xC1,0xE9,0x38,0xC4,0xC2,0xF3,0xF5,0xD1,0x48,0x89,0x10,0x48,0x83,0xC4,0x28,0xC3,0xE8,0xF0,0x26,0x55,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
; function: void part64x1_bit(ulong src, Span<bit> dst)
; location: [7FF7C7B7D550h, 7FF7C7B7D5A2h]
0000h sub rsp,28h                   ; SUB(Sub_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 ec 28
0004h mov rax,rcx                   ; MOV(Mov_r64_rm64) [RAX,RCX]                          encoding(3 bytes) = 48 8b c1
0007h mov r8,[rdx]                  ; MOV(Mov_r64_rm64) [R8,mem(64u,RDX:br,:sr)]           encoding(3 bytes) = 4c 8b 02
000ah mov ecx,[rdx+8]               ; MOV(Mov_r32_rm32) [ECX,mem(32u,RDX:br,:sr)]          encoding(3 bytes) = 8b 4a 08
000dh shl rcx,2                     ; SHL(Shl_rm64_imm8) [RCX,2h:imm8]                     encoding(4 bytes) = 48 c1 e1 02
0011h shr rcx,3                     ; SHR(Shr_rm64_imm8) [RCX,3h:imm8]                     encoding(4 bytes) = 48 c1 e9 03
0015h cmp rcx,7FFFFFFFh             ; CMP(Cmp_rm64_imm32) [RCX,7fffffffh:imm64]            encoding(7 bytes) = 48 81 f9 ff ff ff 7f
001ch ja short 004dh                ; JA(Ja_rel8_64) [4Dh:jmp64]                           encoding(2 bytes) = 77 2f
001eh xor edx,edx                   ; XOR(Xor_r32_rm32) [EDX,EDX]                          encoding(2 bytes) = 33 d2
0020h movsxd rcx,edx                ; MOVSXD(Movsxd_r64_rm32) [RCX,EDX]                    encoding(3 bytes) = 48 63 ca
0023h lea r9,[r8+rcx*8]             ; LEA(Lea_r64_m) [R9,mem(Unknown,R8:br,:sr)]           encoding(4 bytes) = 4d 8d 0c c8
0027h mov ecx,edx                   ; MOV(Mov_r32_rm32) [ECX,EDX]                          encoding(2 bytes) = 8b ca
0029h mov r10,rax                   ; MOV(Mov_r64_rm64) [R10,RAX]                          encoding(3 bytes) = 4c 8b d0
002ch shr r10,cl                    ; SHR(Shr_rm64_CL) [R10,CL]                            encoding(3 bytes) = 49 d3 ea
002fh mov rcx,100000001h            ; MOV(Mov_r64_imm64) [RCX,100000001h:imm64]            encoding(10 bytes) = 48 b9 01 00 00 00 01 00 00 00
0039h pdep rcx,r10,rcx              ; PDEP(VEX_Pdep_r64_r64_rm64) [RCX,R10,RCX]            encoding(VEX, 5 bytes) = c4 e2 ab f5 c9
003eh mov [r9],rcx                  ; MOV(Mov_rm64_r64) [mem(64u,R9:br,:sr),RCX]           encoding(3 bytes) = 49 89 09
0041h inc edx                       ; INC(Inc_rm32) [EDX]                                  encoding(2 bytes) = ff c2
0043h cmp edx,20h                   ; CMP(Cmp_rm32_imm8) [EDX,20h:imm32]                   encoding(3 bytes) = 83 fa 20
0046h jl short 0020h                ; JL(Jl_rel8_64) [20h:jmp64]                           encoding(2 bytes) = 7c d8
0048h add rsp,28h                   ; ADD(Add_rm64_imm8) [RSP,28h:imm64]                   encoding(4 bytes) = 48 83 c4 28
004ch ret                           ; RET(Retnq)                                           encoding(1 byte ) = c3
004dh call 7FF8270CFC20h            ; CALL(Call_rel32_64) [5F5526D0h:jmp64]                encoding(5 bytes) = e8 7e 26 55 5f
0052h int 3                         ; INT(Int3)                                            encoding(1 byte ) = cc
; static ReadOnlySpan<byte> part64x1_bitBytes => new byte[83]{0x48,0x83,0xEC,0x28,0x48,0x8B,0xC1,0x4C,0x8B,0x02,0x8B,0x4A,0x08,0x48,0xC1,0xE1,0x02,0x48,0xC1,0xE9,0x03,0x48,0x81,0xF9,0xFF,0xFF,0xFF,0x7F,0x77,0x2F,0x33,0xD2,0x48,0x63,0xCA,0x4D,0x8D,0x0C,0xC8,0x8B,0xCA,0x4C,0x8B,0xD0,0x49,0xD3,0xEA,0x48,0xB9,0x01,0x00,0x00,0x00,0x01,0x00,0x00,0x00,0xC4,0xE2,0xAB,0xF5,0xC9,0x49,0x89,0x09,0xFF,0xC2,0x83,0xFA,0x20,0x7C,0xD8,0x48,0x83,0xC4,0x28,0xC3,0xE8,0x7E,0x26,0x55,0x5F,0xCC};
----------------------------------------------------------------------------------------------------------------------------------------------------------------
