//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;

    using static AsInternal;
    
    partial struct As
    {
        /// <summary>
        /// Presents a generic reference as a byte pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe byte* pbyte<T>(in T r)
            where T : unmanaged
                => ptr<T,byte>(ref edit(r));
    }
}