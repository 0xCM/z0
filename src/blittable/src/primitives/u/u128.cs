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
        public struct u128<T> : IUnsigned<T>
            where T : unmanaged
        {
            public const ulong Width = 128;

            public T Storage;

            [MethodImpl(Inline)]
            public u128(T src)
            {
                Storage = src;
            }

            BitWidth IPrimitive.ContentWidth
                => Width;
        }
    }
}