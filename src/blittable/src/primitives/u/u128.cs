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
        /// Defines an unsigned 128-bit integer over parametric storage
        /// </summary>
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

            BitWidth IBlittable.ContentWidth
                => Width;
        }
    }
}