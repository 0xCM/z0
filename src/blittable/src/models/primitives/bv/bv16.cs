//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Blit
    {
        /// <summary>
        /// Defines a 16-bit bitvector
        /// </summary>
        public struct bv16 : IScalarBits<ushort>
        {
            public const uint Width = 16;

            public ushort Storage;

            [MethodImpl(Inline)]
            public bv16(ushort src)
            {
                Storage = src;
            }

            BitWidth IPrimitive.ContentWidth
                => Width;

            public bit this[byte i]
            {
                [MethodImpl(Inline)]
                get => bit.test(Storage,i);

                [MethodImpl(Inline)]
                set => Storage = bit.set(Storage, i, value);
            }

            [MethodImpl(Inline)]
            public static implicit operator bv<ushort>(bv16 src)
                => new bv<ushort>(Width, src.Storage);
        }
    }
}