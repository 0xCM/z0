//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly struct JmpRel32
    {
        public const byte InstructionSize = 5;

        public const byte OpCode = 0xE9;

        [MethodImpl(Inline), Op]
        public static bool test(ReadOnlySpan<byte> src)
            => first(src) == OpCode;

        [MethodImpl(Inline), Op]
        public static Address32 dx(ReadOnlySpan<byte> src)
            => first(recover<uint>(slice(src,1, 4)));

        public static bool test(AsmHexCode src)
            => src[0] == OpCode;

        [MethodImpl(Inline), Op]
        public static uint dx(MemoryAddress ip, MemoryAddress target)
        {
            var @base = ip + InstructionSize;
            var dx = (uint)(@base - target);
            return dx;
        }

        [MethodImpl(Inline), Op]
        public static MemoryAddress target(MemoryAddress ip, ReadOnlySpan<byte> src)
        {
            var @base = ip + InstructionSize;
            return @base + dx(src);
        }

        [MethodImpl(Inline), Op]
        public static Address32 offset(MemoryAddress block, MemoryAddress ip, ReadOnlySpan<byte> src)
            => (Address32)(target(ip,src) - block);

        [MethodImpl(Inline), Op]
        public static AsmHexCode encode(MemoryAddress ip, MemoryAddress target)
        {
            var encoding = AsmHexCode.Empty;
            var dst = encoding.Bytes;
            seek(dst,0) = OpCode;
            first(recover<Address32>(slice(dst,1, 4))) = dx(ip,target);
            return encoding;
        }
    }


    /*
; BaseAddress = 7ffaa0427f00h
0000h sub rsp,28h                                   ; SUB r/m64, imm8                  | REX.W 83 /5 ib                   | 4   | 48 83 ec 28
0004h nop                                           ; NOP                              | 90                               | 1   | 90
0005h test ecx,20000h                               ; TEST r/m32, imm32                | F7 /0 id                         | 6   | f7 c1 00 00 02 00
000bh je short 0021h                                ; JE rel8                          | 74 cb                            | 2   | 74 14
000dh mov rcx,7ffa9b2e6f70h                         ; MOV r64, imm64                   | REX.W B8 +ro io                  | 10  | 48 b9 70 6f 2e 9b fa 7f 00 00
0017h call 7ffafadbb5b0h                            ; CALL rel32                       | E8 cd                            | 5   | e8 94 36 99 5a
001ch jmp near ptr 011dh                            ; JMP rel32                        | E9 cd                            | 5   | e9 fc 00 00 00

    */
}