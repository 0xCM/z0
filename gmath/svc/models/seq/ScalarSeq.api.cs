//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;    

    public static class ScalarSeq
    {
        [MethodImpl(Inline)]
        public static ScalarSeq<T> Empty<T>()
            where T : unmanaged
                => ScalarSeq<T>.Empty;
        
        [MethodImpl(Inline)]
        public static ScalarSeq<T> From<T>(params T[] src)
            where T : unmanaged
                => new ScalarSeq<T>(src);

        [MethodImpl(Inline)]
        public static ScalarSeq<T> From<T>(Span<T> src)
            where T : unmanaged
                => new ScalarSeq<T>(src);

        [MethodImpl(Inline)]
        public static ScalarSeq<T> From<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => new ScalarSeq<T>(src.ToArray());

        [MethodImpl(Inline)]
        public static ScalarSeq<T> From<T>(params ScalarSeqTerm<T>[] src)
            where T : unmanaged
                => new ScalarSeq<T>(src);
    }
}