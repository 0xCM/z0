//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Root
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe void copy<T>(SegRef src, Span<T> dst)
            where T : unmanaged
        {
            var reader = PointedReader.create<T>(src);
            reader.ReadAll(dst);
        }
    }
}