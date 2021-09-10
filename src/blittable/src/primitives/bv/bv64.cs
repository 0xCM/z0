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
        public static bv64 bv(N64 n, ulong src)
            => new bv64(src);

        /// <summary>
        /// Defines a 64-bit bitvector
        /// </summary>
        public struct bv64 : IScalarBits<ulong>
        {
            public const uint Width = 64;

            public ulong Storage;

            [MethodImpl(Inline)]
            public bv64(ulong src)
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
            public static implicit operator gbv<ulong>(bv64 src)
                => new gbv<ulong>(Width, src.Storage);
        }
    }
}