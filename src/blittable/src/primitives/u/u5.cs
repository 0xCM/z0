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
        /// Defines an unsigned 5-bit integer over parametric storage
        /// </summary>
        public struct u5<T> : IUnsigned<T>
            where T : unmanaged
        {
            public static ByteSize SZ = size<u5<T>>();
            public const ulong Width = 5;

            public T Storage;

            [MethodImpl(Inline)]
            public u5(T src)
            {
                Storage = src;
            }

            BitWidth IPrimitive.ContentWidth
                => Width;
        }
    }
}