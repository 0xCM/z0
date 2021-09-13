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
        /// Defines an unsigned 4-bit integer over an 8-bit cell
        /// </summary>
        public struct u4 : IUnsigned<u4>
        {
            public const ulong Width = 4;

            public static N4 N => default;

            public Cell8 Storage;

            [MethodImpl(Inline)]
            public u4(Cell8 src)
            {
                Storage = Cells.trim(src,N);
            }

            BitWidth IPrimitive.ContentWidth
                => Width;
        }

        /// <summary>
        /// Defines an unsigned 4-bit integer over parametric storage
        /// </summary>
        public struct u4<T> : IUnsigned<T>
            where T : unmanaged
        {
            public const ulong Width = 4;

            public static N4 N => default;

            public T Storage;

            [MethodImpl(Inline)]
            public u4(T src)
            {
                Storage = src;
            }

            BitWidth IPrimitive.ContentWidth
                => Width;
        }
    }
}