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
        /// Defines a 2-bit bitvector
        /// </summary>
        public struct bv2 : IScalarBits<byte>
        {
            public const uint Width = 2;

            public byte Storage;

            [MethodImpl(Inline)]
            public bv2(byte src)
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
            public static implicit operator bv<byte>(bv2 src)
                => new bv<byte>(Width, src.Storage);

            [MethodImpl(Inline)]
            public static implicit operator bv2(bv<byte> src)
                => new bv2(src.Storage);
        }
    }
}