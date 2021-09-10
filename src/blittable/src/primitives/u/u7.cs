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
        /// Defines an unsigned 7-bit integer over parametric storage
        /// </summary>
        public struct u7<T> : IUnsigned<T>
            where T : unmanaged
        {
            public static ByteSize SZ = size<u7<T>>();
            public const ulong Width = 7;

            public T Storage;

            [MethodImpl(Inline)]
            public u7(T src)
            {
                Storage = src;
            }

            BitWidth IPrimitive.ContentWidth
                => Width;
        }
    }
}