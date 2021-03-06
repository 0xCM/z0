//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.CompilerServices.Unsafe;
    using static Root;

    partial struct memory
    {
       [MethodImpl(Inline), Op]
        public static unsafe void* pointer(IntPtr src)
            => src.ToPointer();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe T* pointer<T>(ref T src)
            where T : unmanaged
                => (T*)AsPointer(ref src);
    }
}