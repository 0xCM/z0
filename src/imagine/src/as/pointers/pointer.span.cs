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

    partial struct As
    {
        [MethodImpl(Inline)]
        public unsafe static T* pointer<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            ref readonly var rHead = ref first(src);
            return (T*)AsPointer(ref edit(rHead));
        }
    }
}