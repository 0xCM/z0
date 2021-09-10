//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct BitFlow
    {
        [MethodImpl(Inline), Op]
        public static bv7 bv(N7 n,byte src)
            => new bv7(src);

        /// <summary>
        /// Defines a 7-bit bitvector
        /// </summary>
        public struct bv7 : IScalarBits<byte>
        {
            public const uint Width = 7;

            public byte Storage;

            [MethodImpl(Inline)]
            public bv7(byte src)
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
            public static implicit operator gbv<byte>(bv7 src)
                => new gbv<byte>(Width, src.Storage);
        }
    }
}