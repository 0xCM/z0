//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class Cells
    {
        [MethodImpl(Inline)]
        internal static ref F from<T,F>(in T src)
            where F : unmanaged, IDataCell
            where T : struct
                => ref Unsafe.As<T,F>(ref edit(src));
    }
}