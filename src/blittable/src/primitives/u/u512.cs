//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct BitFlow
    {
        /// <summary>
        /// Defines an unsigned 512-bit integer over parametric storage
        /// </summary>
        public struct u512<T> : IUnsigned<T>
            where T : unmanaged
        {
            public const ulong Width = 512;

            public T Storage;

            [MethodImpl(Inline)]
            public u512(T src)
            {
                Storage = src;
            }

            BitWidth IPrimitive.ContentWidth
                => Width;
        }
    }
}