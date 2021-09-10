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
        /// Defines an unsigned 256-bit integer over parametric storage
        /// </summary>
        public struct u256<T> : IUnsigned<T>
            where T : unmanaged
        {
            public const ulong Width = 256;

            public T Storage;

            [MethodImpl(Inline)]
            public u256(T src)
            {
                Storage = src;
            }

            BitWidth IPrimitive.ContentWidth
                => Width;
        }
    }
}