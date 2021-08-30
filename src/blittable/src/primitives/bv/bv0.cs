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
        public struct bv0 : IScalarBits<byte>
        {
            public const uint Width = 0;

            BitWidth IPrimitive.ContentWidth
                => Width;

            public bit this[byte i]
            {
                [MethodImpl(Inline)]
                get => 0;

                [MethodImpl(Inline)]
                set{}
            }
        }
    }
}