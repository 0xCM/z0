//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct As
    {
        [MethodImpl(Inline), Op]
        public static unsafe IntPtr safe(void* p)
            => new IntPtr(p);

        [MethodImpl(Inline), Op]
        public static IntPtr safe(long i)
            => new IntPtr(i);
    }
}