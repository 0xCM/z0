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
        public static bv32 bv(N32 n, uint src)
            => new bv32(src);

        /// <summary>
        /// Defines a 32-bit bitvector
        /// </summary>
        public struct bv32 : IScalarBits<uint>
        {
            public const uint Width = 32;

            public uint Storage;

            [MethodImpl(Inline)]
            public bv32(uint src)
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
            public static implicit operator gbv<uint>(bv32 src)
                => new gbv<uint>(Width, src.Storage);
        }
    }
}