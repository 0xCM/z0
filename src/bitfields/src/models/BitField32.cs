//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines a minimalistic 32-bit bitfield
    /// </summary>
    public readonly ref struct BitField32
    {
        public const byte BitCount = 32;

        readonly Span<uint1> Data;

        [MethodImpl(Inline)]
        public BitField32(Span<uint1> data)
            => Data = data;

        [MethodImpl(Inline)]
        public BitField32(Span<byte> data)
            => Data = recover<byte,uint1>(data);

        [MethodImpl(Inline)]
        ref uint1 Bit(uint5 index)
            => ref seek(Data, index);

        public uint1 this[uint5 index]
        {
            [MethodImpl(Inline)]
            get => Bit(index) == 1;

            [MethodImpl(Inline)]
            set => Bit(index) = (byte)value;
        }

        [MethodImpl(Inline)]
        public string Format()
        {
            Span<char> dst = stackalloc char[BitCount];
            for(var i=0u; i<BitCount; i++)
                seek(dst,i) = skip(Data,i).ToChar();
            return new string(dst);
        }
    }
}