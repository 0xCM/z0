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
        [MethodImpl(Inline), Op]
        public static bv3 bv(N3 n,byte src)
            => new bv3(src);


        /// <summary>
        /// Defines a 3-bit bitvector
        /// </summary>
        public struct bv3 : IScalarBits<byte>
        {
            public const uint Width = 3;

            public byte Storage;

            [MethodImpl(Inline)]
            public bv3(byte src)
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
            public static implicit operator gbv<byte>(bv3 src)
                => new gbv<byte>(Width, src.Storage);

            [MethodImpl(Inline)]
            public static implicit operator bv3(gbv<byte> src)
                => new bv3(src.Storage);
        }
    }
}