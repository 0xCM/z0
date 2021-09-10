//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct BitFlow
    {
        public struct u8 : IUnsigned<byte>
        {
            public const ulong Width = 8;

            public byte Storage;

            [MethodImpl(Inline)]
            public u8(byte src)
            {
                Storage = src;
            }

            BitWidth IPrimitive.ContentWidth
                => Width;

            [MethodImpl(Inline)]
            public static implicit operator u8(u8<byte> src)
                => new u8(src.Storage);

            [MethodImpl(Inline)]
            public static implicit operator u8<byte>(u8 src)
                => new u8<byte>(src.Storage);

            [MethodImpl(Inline)]
            public static implicit operator u8(byte src)
                => new u8(src);

            [MethodImpl(Inline)]
            public static implicit operator byte(u8 src)
                => src.Storage;
        }
    }
}