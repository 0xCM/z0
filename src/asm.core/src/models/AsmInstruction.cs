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

    public readonly struct AsmInstruction
    {
        public AsmHexCode Encoded {get;}

        [MethodImpl(Inline)]
        public AsmInstruction(AsmHexCode encoded)
            => Encoded = encoded;

        public uint4 Size
        {
            [MethodImpl(Inline)]
            get => Encoded.Size;
        }

        public ReadOnlySpan<byte> Data
        {
            [MethodImpl(Inline)]
            get => Encoded.Bytes;
        }

        public ReadOnlySpan<AsmByte> Bytes
        {
            [MethodImpl(Inline)]
            get => recover<AsmByte>(Data);
        }

        [MethodImpl(Inline)]
        public static explicit operator ulong(AsmInstruction src)
            => src.Encoded.ToUInt64();

        [MethodImpl(Inline)]
        public static explicit operator uint(AsmInstruction src)
            => src.Encoded.ToUInt32();

        [MethodImpl(Inline)]
        public static explicit operator ushort(AsmInstruction src)
            => src.Encoded.ToUInt16();

        [MethodImpl(Inline)]
        public static explicit operator byte(AsmInstruction src)
            => src.Encoded.ToUInt8();
    }
}