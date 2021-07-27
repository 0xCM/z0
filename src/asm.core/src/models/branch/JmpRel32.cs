//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

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
}