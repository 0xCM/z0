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
        /// Defines an unsigned 8-bit integer over parametric storage
        /// </summary>
        public struct u8<T> : IUnsigned<T>
            where T : unmanaged
        {
            public const ulong Width = 8;

            public T Storage;

            [MethodImpl(Inline)]
            public u8(T src)
            {
                Storage = src;
            }

            BitWidth IPrimitive.ContentWidth
                => Width;
        }
    }
}