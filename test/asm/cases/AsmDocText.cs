namespace Z0
{
    public readonly struct AsmDocText
    {
        public static string Doc1 => @"
            ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            ; void iter<byte>(Iteratee<byte> target, byte m, byte n, byte p), located://dynamic/dynamic.algorithms?iter#iter_g[8u](Iteratee[byte],8u,8u,8u)
            ; public static ReadOnlySpan<byte> iter_gᐸ8uᐳᐤIterateeᐸbyteᐳㆍ8uㆍ8uㆍ8uᐤ => new byte[285]{0x41,0x57,0x41,0x56,0x41,0x54,0x57,0x56,0x55,0x53,0x48,0x81,0xec,0xb0,0x00,0x00,0x00,0x33,0xc0,0x48,0x89,0x84,0x24,0x90,0x00,0x00,0x00,0x48,0x89,0x44,0x24,0x70,0x48,0x89,0x44,0x24,0x50,0x48,0x89,0x44,0x24,0x20,0x48,0x8b,0xf2,0x41,0x0f,0xb6,0xd0,0x88,0x94,0x24,0xac,0x00,0x00,0x00,0x41,0x0f,0xb6,0xd1,0x88,0x94,0x24,0xa8,0x00,0x00,0x00,0x8b,0x94,0x24,0x10,0x01,0x00,0x00,0x0f,0xb6,0xd2,0x88,0x94,0x24,0xa4,0x00,0x00,0x00,0x48,0x8d,0xbc,0x24,0xac,0x00,0x00,0x00,0x48,0x8d,0x9c,0x24,0xa8,0x00,0x00,0x00,0x48,0x8d,0xac,0x24,0xa4,0x00,0x00,0x00,0x45,0x33,0xf6,0x80,0x3f,0x00,0x0f,0x86,0x93,0x00,0x00,0x00,0x45,0x33,0xff,0x80,0x3b,0x00,0x76,0x78,0x45,0x33,0xe4,0x80,0x7d,0x00,0x00,0x76,0x60,0x48,0x89,0xb4,0x24,0x90,0x00,0x00,0x00,0x44,0x88,0xb4,0x24,0xa0,0x00,0x00,0x00,0x44,0x88,0xbc,0x24,0x9c,0x00,0x00,0x00,0x44,0x88,0xa4,0x24,0x98,0x00,0x00,0x00,0x48,0x8d,0x94,0x24,0xa0,0x00,0x00,0x00,0x4c,0x8d,0x84,0x24,0x9c,0x00,0x00,0x00,0x4c,0x8d,0x8c,0x24,0x98,0x00,0x00,0x00,0x0f,0xb6,0x12,0x45,0x0f,0xb6,0x00,0x45,0x0f,0xb6,0x09,0x48,0x8d,0x8c,0x24,0x90,0x00,0x00,0x00,0xe8,0xd7,0xe6,0xff,0xff,0x41,0xff,0xc4,0x45,0x0f,0xb6,0xe4,0x0f,0xb6,0x45,0x00,0x44,0x3b,0xe0,0x7c,0xa0,0x41,0xff,0xc7,0x45,0x0f,0xb6,0xff,0x0f,0xb6,0x03,0x44,0x3b,0xf8,0x7c,0x88,0x41,0xff,0xc6,0x45,0x0f,0xb6,0xf6,0x0f,0xb6,0x07,0x44,0x3b,0xf0,0x0f,0x8c,0x6d,0xff,0xff,0xff,0x48,0x81,0xc4,0xb0,0x00,0x00,0x00,0x5b,0x5d,0x5e,0x5f,0x41,0x5c,0x41,0x5e,0x41,0x5f,0xc3};
            ; Base = 7ff97ccfb020h
            ; TermCode = CTC_RET_Zx3
            0000h push r15                                ; PUSH r64                         | 50+ro                            | 2   | 41 57
            0002h push r14                                ; PUSH r64                         | 50+ro                            | 2   | 41 56
            0004h push r12                                ; PUSH r64                         | 50+ro                            | 2   | 41 54
            0006h push rdi                                ; PUSH r64                         | 50+ro                            | 1   | 57
            0007h push rsi                                ; PUSH r64                         | 50+ro                            | 1   | 56
            0008h push rbp                                ; PUSH r64                         | 50+ro                            | 1   | 55
            0009h push rbx                                ; PUSH r64                         | 50+ro                            | 1   | 53
            000ah sub rsp,0b0h                            ; SUB r/m64, imm32                 | REX.W 81 /5 id                   | 7   | 48 81 ec b0 00 00 00
            0011h xor eax,eax                             ; XOR r32, r/m32                   | 33 /r                            | 2   | 33 c0
            0013h mov [rsp+90h],rax                       ; MOV r/m64, r64                   | REX.W 89 /r                      | 8   | 48 89 84 24 90 00 00 00
            001bh mov [rsp+70h],rax                       ; MOV r/m64, r64                   | REX.W 89 /r                      | 5   | 48 89 44 24 70
            0020h mov [rsp+50h],rax                       ; MOV r/m64, r64                   | REX.W 89 /r                      | 5   | 48 89 44 24 50
            0025h mov [rsp+20h],rax                       ; MOV r/m64, r64                   | REX.W 89 /r                      | 5   | 48 89 44 24 20
            002ah mov rsi,rdx                             ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b f2
            002dh movzx edx,r8b                           ; MOVZX r32, r/m8                  | 0F B6 /r                         | 4   | 41 0f b6 d0
            0031h mov [rsp+0ach],dl                       ; MOV r/m8, r8                     | 88 /r                            | 7   | 88 94 24 ac 00 00 00
            0038h movzx edx,r9b                           ; MOVZX r32, r/m8                  | 0F B6 /r                         | 4   | 41 0f b6 d1
            003ch mov [rsp+0a8h],dl                       ; MOV r/m8, r8                     | 88 /r                            | 7   | 88 94 24 a8 00 00 00
            0043h mov edx,[rsp+110h]                      ; MOV r32, r/m32                   | 8B /r                            | 7   | 8b 94 24 10 01 00 00
            004ah movzx edx,dl                            ; MOVZX r32, r/m8                  | 0F B6 /r                         | 3   | 0f b6 d2
            004dh mov [rsp+0a4h],dl                       ; MOV r/m8, r8                     | 88 /r                            | 7   | 88 94 24 a4 00 00 00
            0054h lea rdi,[rsp+0ach]                      ; LEA r64, m                       | REX.W 8D /r                      | 8   | 48 8d bc 24 ac 00 00 00
            005ch lea rbx,[rsp+0a8h]                      ; LEA r64, m                       | REX.W 8D /r                      | 8   | 48 8d 9c 24 a8 00 00 00
            0064h lea rbp,[rsp+0a4h]                      ; LEA r64, m                       | REX.W 8D /r                      | 8   | 48 8d ac 24 a4 00 00 00
            006ch xor r14d,r14d                           ; XOR r32, r/m32                   | 33 /r                            | 3   | 45 33 f6
            006fh cmp byte ptr [rdi],0                    ; CMP r/m8, imm8                   | 80 /7 ib                         | 3   | 80 3f 00
            0072h jbe near ptr 010bh                      ; JBE rel32                        | 0F 86 cd                         | 6   | 0f 86 93 00 00 00
            0078h xor r15d,r15d                           ; XOR r32, r/m32                   | 33 /r                            | 3   | 45 33 ff
            007bh cmp byte ptr [rbx],0                    ; CMP r/m8, imm8                   | 80 /7 ib                         | 3   | 80 3b 00
            007eh jbe short 00f8h                         ; JBE rel8                         | 76 cb                            | 2   | 76 78
            0080h xor r12d,r12d                           ; XOR r32, r/m32                   | 33 /r                            | 3   | 45 33 e4
            0083h cmp byte ptr [rbp],0                    ; CMP r/m8, imm8                   | 80 /7 ib                         | 4   | 80 7d 00 00
            0087h jbe short 00e9h                         ; JBE rel8                         | 76 cb                            | 2   | 76 60
            0089h mov [rsp+90h],rsi                       ; MOV r/m64, r64                   | REX.W 89 /r                      | 8   | 48 89 b4 24 90 00 00 00
            0091h mov [rsp+0a0h],r14b                     ; MOV r/m8, r8                     | 88 /r                            | 8   | 44 88 b4 24 a0 00 00 00
            0099h mov [rsp+9ch],r15b                      ; MOV r/m8, r8                     | 88 /r                            | 8   | 44 88 bc 24 9c 00 00 00
            00a1h mov [rsp+98h],r12b                      ; MOV r/m8, r8                     | 88 /r                            | 8   | 44 88 a4 24 98 00 00 00
            00a9h lea rdx,[rsp+0a0h]                      ; LEA r64, m                       | REX.W 8D /r                      | 8   | 48 8d 94 24 a0 00 00 00
            00b1h lea r8,[rsp+9ch]                        ; LEA r64, m                       | REX.W 8D /r                      | 8   | 4c 8d 84 24 9c 00 00 00
            00b9h lea r9,[rsp+98h]                        ; LEA r64, m                       | REX.W 8D /r                      | 8   | 4c 8d 8c 24 98 00 00 00
            00c1h movzx edx,byte ptr [rdx]                ; MOVZX r32, r/m8                  | 0F B6 /r                         | 3   | 0f b6 12
            00c4h movzx r8d,byte ptr [r8]                 ; MOVZX r32, r/m8                  | 0F B6 /r                         | 4   | 45 0f b6 00
            00c8h movzx r9d,byte ptr [r9]                 ; MOVZX r32, r/m8                  | 0F B6 /r                         | 4   | 45 0f b6 09
            00cch lea rcx,[rsp+90h]                       ; LEA r64, m                       | REX.W 8D /r                      | 8   | 48 8d 8c 24 90 00 00 00
            00d4h call 7ff97ccf97d0h                      ; CALL rel32                       | E8 cd                            | 5   | e8 d7 e6 ff ff
            00d9h inc r12d                                ; INC r/m32                        | FF /0                            | 3   | 41 ff c4
            00dch movzx r12d,r12b                         ; MOVZX r32, r/m8                  | 0F B6 /r                         | 4   | 45 0f b6 e4
            00e0h movzx eax,byte ptr [rbp]                ; MOVZX r32, r/m8                  | 0F B6 /r                         | 4   | 0f b6 45 00
            00e4h cmp r12d,eax                            ; CMP r32, r/m32                   | 3B /r                            | 3   | 44 3b e0
            00e7h jl short 0089h                          ; JL rel8                          | 7C cb                            | 2   | 7c a0
            00e9h inc r15d                                ; INC r/m32                        | FF /0                            | 3   | 41 ff c7
            00ech movzx r15d,r15b                         ; MOVZX r32, r/m8                  | 0F B6 /r                         | 4   | 45 0f b6 ff
            00f0h movzx eax,byte ptr [rbx]                ; MOVZX r32, r/m8                  | 0F B6 /r                         | 3   | 0f b6 03
            00f3h cmp r15d,eax                            ; CMP r32, r/m32                   | 3B /r                            | 3   | 44 3b f8
            00f6h jl short 0080h                          ; JL rel8                          | 7C cb                            | 2   | 7c 88
            00f8h inc r14d                                ; INC r/m32                        | FF /0                            | 3   | 41 ff c6
            00fbh movzx r14d,r14b                         ; MOVZX r32, r/m8                  | 0F B6 /r                         | 4   | 45 0f b6 f6
            00ffh movzx eax,byte ptr [rdi]                ; MOVZX r32, r/m8                  | 0F B6 /r                         | 3   | 0f b6 07
            0102h cmp r14d,eax                            ; CMP r32, r/m32                   | 3B /r                            | 3   | 44 3b f0
            0105h jl near ptr 0078h                       ; JL rel32                         | 0F 8C cd                         | 6   | 0f 8c 6d ff ff ff
            010bh add rsp,0b0h                            ; ADD r/m64, imm32                 | REX.W 81 /0 id                   | 7   | 48 81 c4 b0 00 00 00
            0112h pop rbx                                 ; POP r64                          | 58+ro                            | 1   | 5b
            0113h pop rbp                                 ; POP r64                          | 58+ro                            | 1   | 5d
            0114h pop rsi                                 ; POP r64                          | 58+ro                            | 1   | 5e
            0115h pop rdi                                 ; POP r64                          | 58+ro                            | 1   | 5f
            0116h pop r12                                 ; POP r64                          | 58+ro                            | 2   | 41 5c
            0118h pop r14                                 ; POP r64                          | 58+ro                            | 2   | 41 5e
            011ah pop r15                                 ; POP r64                          | 58+ro                            | 2   | 41 5f
            011ch ret                                     ; RET                              | C3                               | 1   | c3
            ";

    }
}