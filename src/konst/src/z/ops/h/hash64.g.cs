//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Creates a 64-bit hashcode over two primal values by combining 2 32-bit hash codes in the obvious way
        /// </summary>
        /// <param name="x">The first primitive value</param>
        /// <param name="y">The second primitive value</param>
        /// <typeparam name="X"></typeparam>
        /// <typeparam name="Y"></typeparam>
        [MethodImpl(Inline)]
        public static ulong hash64<X,Y>(X x, Y y)
            where X : unmanaged
            where Y : unmanaged
                => hash(x) | (hash(y) << 32);
    }
}