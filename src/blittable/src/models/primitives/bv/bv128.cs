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
        /// Defines a 128-bit bitvector
        /// </summary>
        public struct bv128 : IScalarBits<ByteBlock16>
        {
            public const uint Width = 128;

            public ByteBlock16 Storage;

            [MethodImpl(Inline)]
            public bv128(ByteBlock16 src)
            {
                Storage = src;
            }

            BitWidth IPrimitive.ContentWidth
                => Width;

            public bit this[byte i]
            {
                [MethodImpl(Inline)]
                get => throw Unsupported.define<bv128>();

                [MethodImpl(Inline)]
                set => throw Unsupported.define<bv128>();
            }

            [MethodImpl(Inline)]
            public static implicit operator bv<ByteBlock16>(bv128 src)
                => new bv<ByteBlock16>(Width, src.Storage);
        }
    }
}