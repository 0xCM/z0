//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Control
    {
        [MethodImpl(Inline)]
        public static ref T seek<T>(ref T src, int count)
            => ref Unsafe.Add(ref src, count);

        [MethodImpl(Inline)]
        public static ref T seek<T>(Span<T> src, int count)
            => ref seek(ref head(src), count);         
    }
}