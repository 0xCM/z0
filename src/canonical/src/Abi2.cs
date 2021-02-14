//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Canonical
    {
        [ApiDeep]
        public readonly ref struct Abi2
        {
            readonly ReadOnlySpan<byte> A;

            readonly ReadOnlySpan<ushort> B;

            readonly ReadOnlySpan<uint> C;

            readonly ReadOnlySpan<ulong> D;

            readonly Span<ulong> R;

            /*
                ; void Run(int i)::located://canonical/abi2?Run#Run_(32i)
                ; public static ReadOnlySpan<byte> Run_ᐤ32iᐤ => new byte[141]{0x41,0x56,0x57,0x56,0x55,0x53,0x48,0x83,0xec,0x20,0x48,0x8b,0xf1,0x48,0x8d,0x4e,0x40,0x48,0x8b,0x01,0x8b,0x49,0x08,0x48,0x63,0xfa,0x48,0x8d,0x1c,0xf8,0x48,0x8b,0x16,0x0f,0xb6,0x14,0x3a,0x48,0x8b,0xce,0xe8,0x53,0xb1,0xfa,0xfc,0x8b,0xe8,0x48,0x8d,0x56,0x10,0x48,0x8b,0x0a,0x8b,0x52,0x08,0x0f,0xb7,0x14,0x79,0x48,0x8b,0xce,0xe8,0x43,0xb1,0xfa,0xfc,0x44,0x8b,0xf0,0x49,0x23,0xee,0x48,0x8d,0x56,0x20,0x48,0x8b,0x0a,0x8b,0x52,0x08,0x8b,0x14,0xb9,0x48,0x8b,0xce,0xe8,0x30,0xb1,0xfa,0xfc,0x44,0x8b,0xf0,0x48,0x8d,0x56,0x30,0x48,0x8b,0x0a,0x8b,0x52,0x08,0x48,0x8b,0x14,0xf9,0x48,0x8b,0xce,0xe8,0x1f,0xb1,0xfa,0xfc,0x49,0x33,0xc6,0x48,0x0b,0xc5,0x48,0x89,0x03,0x48,0x83,0xc4,0x20,0x5b,0x5d,0x5e,0x5f,0x41,0x5e,0xc3};
                ; BaseAddress = 7ffe6818a0e0h
                ; TermCode = CTC_RET_Zx3
                7ffe6818a0e0h 0000h push r14                                ; PUSH r64                         | 50+ro                            | 2   | 41 56
                7ffe6818a0e2h 0002h push rdi                                ; PUSH r64                         | 50+ro                            | 1   | 57
                7ffe6818a0e3h 0003h push rsi                                ; PUSH r64                         | 50+ro                            | 1   | 56
                7ffe6818a0e4h 0004h push rbp                                ; PUSH r64                         | 50+ro                            | 1   | 55
                7ffe6818a0e5h 0005h push rbx                                ; PUSH r64                         | 50+ro                            | 1   | 53
                7ffe6818a0e6h 0006h sub rsp,20h                             ; SUB r/m64, imm8                  | REX.W 83 /5 ib                   | 4   | 48 83 ec 20
                7ffe6818a0eah 000ah mov rsi,rcx                             ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b f1
                7ffe6818a0edh 000dh lea rcx,[rsi+40h]                       ; LEA r64, m                       | REX.W 8D /r                      | 4   | 48 8d 4e 40
                7ffe6818a0f1h 0011h mov rax,[rcx]                           ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b 01
                7ffe6818a0f4h 0014h mov ecx,[rcx+8]                         ; MOV r32, r/m32                   | 8B /r                            | 3   | 8b 49 08
                7ffe6818a0f7h 0017h movsxd rdi,edx                          ; MOVSXD r64, r/m32                | REX.W 63 /r                      | 3   | 48 63 fa
                7ffe6818a0fah 001ah lea rbx,[rax+rdi*8]                     ; LEA r64, m                       | REX.W 8D /r                      | 4   | 48 8d 1c f8
                7ffe6818a0feh 001eh mov rdx,[rsi]                           ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b 16
                7ffe6818a101h 0021h movzx edx,byte ptr [rdx+rdi]            ; MOVZX r32, r/m8                  | 0F B6 /r                         | 4   | 0f b6 14 3a
                7ffe6818a105h 0025h mov rcx,rsi                             ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b ce
                7ffe6818a108h 0028h call 7ffe65135260h                      ; CALL rel32                       | E8 cd                            | 5   | e8 53 b1 fa fc
                7ffe6818a10dh 002dh mov ebp,eax                             ; MOV r32, r/m32                   | 8B /r                            | 2   | 8b e8
                7ffe6818a10fh 002fh lea rdx,[rsi+10h]                       ; LEA r64, m                       | REX.W 8D /r                      | 4   | 48 8d 56 10
                7ffe6818a113h 0033h mov rcx,[rdx]                           ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b 0a
                7ffe6818a116h 0036h mov edx,[rdx+8]                         ; MOV r32, r/m32                   | 8B /r                            | 3   | 8b 52 08
                7ffe6818a119h 0039h movzx edx,word ptr [rcx+rdi*2]          ; MOVZX r32, r/m16                 | 0F B7 /r                         | 4   | 0f b7 14 79
                7ffe6818a11dh 003dh mov rcx,rsi                             ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b ce
                7ffe6818a120h 0040h call 7ffe65135268h                      ; CALL rel32                       | E8 cd                            | 5   | e8 43 b1 fa fc
                7ffe6818a125h 0045h mov r14d,eax                            ; MOV r32, r/m32                   | 8B /r                            | 3   | 44 8b f0
                7ffe6818a128h 0048h and rbp,r14                             ; AND r64, r/m64                   | REX.W 23 /r                      | 3   | 49 23 ee
                7ffe6818a12bh 004bh lea rdx,[rsi+20h]                       ; LEA r64, m                       | REX.W 8D /r                      | 4   | 48 8d 56 20
                7ffe6818a12fh 004fh mov rcx,[rdx]                           ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b 0a
                7ffe6818a132h 0052h mov edx,[rdx+8]                         ; MOV r32, r/m32                   | 8B /r                            | 3   | 8b 52 08
                7ffe6818a135h 0055h mov edx,[rcx+rdi*4]                     ; MOV r32, r/m32                   | 8B /r                            | 3   | 8b 14 b9
                7ffe6818a138h 0058h mov rcx,rsi                             ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b ce
                7ffe6818a13bh 005bh call 7ffe65135270h                      ; CALL rel32                       | E8 cd                            | 5   | e8 30 b1 fa fc
                7ffe6818a140h 0060h mov r14d,eax                            ; MOV r32, r/m32                   | 8B /r                            | 3   | 44 8b f0
                7ffe6818a143h 0063h lea rdx,[rsi+30h]                       ; LEA r64, m                       | REX.W 8D /r                      | 4   | 48 8d 56 30
                7ffe6818a147h 0067h mov rcx,[rdx]                           ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b 0a
                7ffe6818a14ah 006ah mov edx,[rdx+8]                         ; MOV r32, r/m32                   | 8B /r                            | 3   | 8b 52 08
                7ffe6818a14dh 006dh mov rdx,[rcx+rdi*8]                     ; MOV r64, r/m64                   | REX.W 8B /r                      | 4   | 48 8b 14 f9
                7ffe6818a151h 0071h mov rcx,rsi                             ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b ce
                7ffe6818a154h 0074h call 7ffe65135278h                      ; CALL rel32                       | E8 cd                            | 5   | e8 1f b1 fa fc
                7ffe6818a159h 0079h xor rax,r14                             ; XOR r64, r/m64                   | REX.W 33 /r                      | 3   | 49 33 c6
                7ffe6818a15ch 007ch or rax,rbp                              ; OR r64, r/m64                    | REX.W 0B /r                      | 3   | 48 0b c5
                7ffe6818a15fh 007fh mov [rbx],rax                           ; MOV r/m64, r64                   | REX.W 89 /r                      | 3   | 48 89 03
                7ffe6818a162h 0082h add rsp,20h                             ; ADD r/m64, imm8                  | REX.W 83 /0 ib                   | 4   | 48 83 c4 20
                7ffe6818a166h 0086h pop rbx                                 ; POP r64                          | 58+ro                            | 1   | 5b
                7ffe6818a167h 0087h pop rbp                                 ; POP r64                          | 58+ro                            | 1   | 5d
                7ffe6818a168h 0088h pop rsi                                 ; POP r64                          | 58+ro                            | 1   | 5e
                7ffe6818a169h 0089h pop rdi                                 ; POP r64                          | 58+ro                            | 1   | 5f
                7ffe6818a16ah 008ah pop r14                                 ; POP r64                          | 58+ro                            | 2   | 41 5e
                7ffe6818a16ch 008ch ret                                     ; RET                              | C3                               | 1   | c3
            */
            /// <summary>
            /// 7ffe6818a0e0h
            /// store r14 rdi rsi rbp rbx -> stack[4 3 2 1 0]
            /// sub     rsp -> rsp - 20h
            /// mov     rcx -> rsi
            /// lea     [rsi + 40h] -> rcx
            /// mov     [rcx] -> rax
            /// mov     [rcx + 8] -> ecx
            /// movsxd  edx -> rdi
            /// lea     [rax + rdi*8] -> rbx
            /// mov     [rsi] -> rdx
            /// movzx   byte ptr [rdx + rdi] -> edx
            /// mov     rsi -> rcx
            /// call    7ffe65135260h
            /// </summary>
            /// <param name="i"></param>
            public void Run(int i)
            {
                seek(R,i) = (ulong)f0(skip(A,i)) & f1(skip(B,i)) | f2(skip(C,i)) ^ f3(skip(D,i)) ;
            }


            /// <summary>
            /// 7ffe66d36840h | precode: 7ffe650dc480h
            /// </summary>
            /// <param name="a"></param>
            [MethodImpl(NotInline)]
            public byte f0(byte a)
                => (byte)(a & 0xF0);

            /// <summary>
            /// 7ffe66d36860h | precode: 7ffe650dc488h
            /// </summary>
            /// <param name="b"></param>
            [MethodImpl(NotInline)]
            public ushort f1(ushort b)
                => (ushort)(b & 0xF0F0);

            /// <summary>
            /// 7ffe66d36880h | precode: 7ffe650dc490h
            /// </summary>
            /// <param name="c"></param>
            [MethodImpl(NotInline)]
            public uint f2(uint c)
                => (uint)(c & 0xF0F0F0F0);

            /// <summary>
            /// 7ffe66d368a0h | precode: 7ffe650dc498h
            /// </summary>
            /// <param name="d"></param>
            [MethodImpl(NotInline)]
            public ulong f3(ulong d)
                => (ulong)(d & 0xF0F0F0F0F0F0F0F0);

        }
    }
}