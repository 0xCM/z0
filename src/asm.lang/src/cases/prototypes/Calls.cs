//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;


    public struct CallContext
    {

    }

    partial struct Prototypes
    {
        [ApiHost(prototypes + calls)]
        public readonly struct Calls
        {
            [Op, Size(18)]
            public static unsafe ulong call(CallContext* pCtx)
                => receive(pCtx);


            [Op, MethodImpl(NotInline)]
            public static unsafe ulong receive(CallContext* pCtx)
            {
                MemoryAddress target = pCtx;
                return target;
            }
        }
    }

    /*

    ; ----------------------------------------------------------------------------------------------------------------------------------------------------------------
    ; ulong call(CallContext* pCtx)::located://asmlang/prototypes.calls?call#call_(CallContext~ptr)
    ; public static ReadOnlySpan<byte> call_ᐤCallContextᕀptrᐤ => new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x48,0xb8,0x68,0x5c,0xc2,0xc2,0xfa,0x7f,0x00,0x00,0x48,0xff,0xe0};
    ; BaseAddress = 7ffac49aa710h
    ; TermCode = CTC_JMP_RAX
    0000h nop dword ptr [rax+rax]                       ; NOP r/m32                        | 0F 1F /0                         | 5   | 0f 1f 44 00 00
    0005h mov rax,7ffac2c25c68h                         ; MOV r64, imm64                   | REX.W B8 +ro io                  | 10  | 48 b8 68 5c c2 c2 fa 7f 00 00
    000fh jmp rax                                       ; JMP r/m64                        | FF /4                            | 3   | 48 ff e0
    ; ----------------------------------------------------------------------------------------------------------------------------------------------------------------
    ; ulong receive(CallContext* pCtx)::located://asmlang/prototypes.calls?receive#receive_(CallContext~ptr)
    ; public static ReadOnlySpan<byte> receive_ᐤCallContextᕀptrᐤ => new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0xc3};
    ; BaseAddress = 7ffac49aa740h
    ; TermCode = CTC_RET_Zx3
    0000h nop dword ptr [rax+rax]                       ; NOP r/m32                        | 0F 1F /0                         | 5   | 0f 1f 44 00 00
    0005h mov rax,rcx                                   ; MOV r64, r/m64                   | REX.W 8B /r                      | 3   | 48 8b c1
    0008h ret                                           ; RET                              | C3                               | 1   | c3

    */
}