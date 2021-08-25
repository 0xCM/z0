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
        /// Defines a 256-bit bitvector
        /// </summary>
        public struct bv256 : IScalarBits<ByteBlock16>
        {
            public const uint Width = 256;

            public ByteBlock32 Storage;

            [MethodImpl(Inline)]
            public bv256(ByteBlock32 src)
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
            public static implicit operator bv<ByteBlock32>(bv256 src)
                => new bv<ByteBlock32>(Width, src.Storage);
        }
    }
}