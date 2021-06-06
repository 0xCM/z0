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
        [MethodImpl(Inline)]
        public static unsafe T* ptr<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => (T*)AsPointer(ref edit(first(src)));

        [MethodImpl(Inline)]
        public static unsafe T* ptr<T>(Span<T> src)
            where T : unmanaged
                => (T*)AsPointer(ref edit(first(src)));

    }
}