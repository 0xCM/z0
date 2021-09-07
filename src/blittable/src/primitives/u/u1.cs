//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Blit
    {
        /// <summary>
        /// Defines an unsigned 1-bit integer over parametric storage
        /// </summary>
        public struct u1<T> : IUnsigned<T>
            where T : unmanaged
        {
            public const ulong Width = 1;

            public T Storage;

            [MethodImpl(Inline)]
            public u1(T src)
            {
                Storage = src;
            }

            BitWidth IPrimitive.ContentWidth
                => Width;
        }
    }
}