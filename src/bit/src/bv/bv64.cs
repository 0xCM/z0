//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct BV
    {
        /// <summary>
        /// Defines a 64-bit bitvector
        /// </summary>
        public struct bv64 : IIndexedBits<ulong>
        {
            public const uint Width = 64;

            public ulong Storage;

            [MethodImpl(Inline)]
            public bv64(ulong src)
            {
                Storage = src;
            }

            BitWidth IBlittable.ContentWidth
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