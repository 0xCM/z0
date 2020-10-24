//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;

    partial struct AsDeprecated
    {
        /// <summary>
        /// Presents a readonly reference to an unmanaged value as a pointer
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <param name="offset">The number of elements to skip</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe T* gptr<T>(in T src)
            where T : unmanaged
                => refptr(ref edit(src));

    }
}