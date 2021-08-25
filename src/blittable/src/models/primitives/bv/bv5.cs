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
        /// Defines a 5-bit bitvector
        /// </summary>
        public struct bv5 : IScalarBits<byte>
        {
            public const uint Width = 5;

            public byte Storage;

            [MethodImpl(Inline)]
            public bv5(byte src)
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
            public static implicit operator bv<byte>(bv5 src)
                => new bv<byte>(Width, src.Storage);
        }
    }
}