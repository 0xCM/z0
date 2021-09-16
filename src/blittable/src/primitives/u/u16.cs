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
        public struct u16<T> : IUnsigned<T>
            where T : unmanaged
        {
            public const ulong Width = 16;

            public T Storage;

            [MethodImpl(Inline)]
            public u16(T src)
            {
                Storage = src;
            }

            BitWidth IPrimitive.ContentWidth
                => Width;
        }
    }
}