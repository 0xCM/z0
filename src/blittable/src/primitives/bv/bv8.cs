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
        public static bv8 bv(N8 n,byte src)
            => new bv8(src);

        /// <summary>
        /// Defines an 8-bit bitvector
        /// </summary>
        public struct bv8 : IScalarBits<byte>
        {
            public const uint Width = 8;

            public byte Storage;

            [MethodImpl(Inline)]
            public bv8(byte src)
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
            public static implicit operator gbv<byte>(bv8 src)
                => new gbv<byte>(Width, src.Storage);
        }
    }
}