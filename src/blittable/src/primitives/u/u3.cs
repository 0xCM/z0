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
        public struct u3<T> : IUnsigned<T>
            where T : unmanaged
        {
            public const ulong Width = 3;

            public T Storage;

            [MethodImpl(Inline)]
            public u3(T src)
            {
                Storage = src;
            }

            BitWidth IPrimitive.ContentWidth
                => Width;
        }
    }
}