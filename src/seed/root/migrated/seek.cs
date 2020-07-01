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
        [MethodImpl(Inline)]
        public static ref T seek<T>(ref T src, int count)
            => ref As.seek(src, count);

        [MethodImpl(Inline)]
        public static ref T seek<T>(Span<T> src, int count)
            => ref As.seek(src, (uint)count);
    }
}