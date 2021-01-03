//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    using api = BitFields;

    /// <summary>
    /// Defines a minimalistic 32-bit bitfield
    /// </summary>
    public readonly ref struct BitField32
    {
        public const byte BitCount = 32;

        readonly NatSpan<N32,uint1> Data;

        [MethodImpl(Inline)]
        public BitField32(Span<uint1> data)
            => Data = data;

        [MethodImpl(Inline)]
        public BitField32(Span<byte> data)
            => Data = recover<byte,uint1>(data);

        [MethodImpl(Inline)]
        ref uint1 Bit(uint5 index)
            => ref Data[index];

        public ReadOnlySpan<uint1> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public uint1 this[uint5 index]
        {
            [MethodImpl(Inline)]
            get => Bit(index) == 1;

            [MethodImpl(Inline)]
            set => Bit(index) = (byte)value;
        }

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);
    }
}