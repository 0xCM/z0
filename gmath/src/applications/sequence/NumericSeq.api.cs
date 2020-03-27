//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static gmath;    

    public static class NumericSeq
    {
        [MethodImpl(Inline)]
        public static NumericSeq<T> Empty<T>()
            where T : unmanaged
                => NumericSeq<T>.Empty;
        
        [MethodImpl(Inline)]
        public static NumericSeq<T> From<T>(params T[] src)
            where T : unmanaged
                => new NumericSeq<T>(src);

        [MethodImpl(Inline)]
        public static NumericSeq<T> From<T>(Span<T> src)
            where T : unmanaged
                => new NumericSeq<T>(src);

        [MethodImpl(Inline)]
        public static NumericSeq<T> From<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => new NumericSeq<T>(src.ToArray());

        [MethodImpl(Inline)]
        public static NumericSeq<T> From<T>(params NumericSeqTerm<T>[] src)
            where T : unmanaged
                => new NumericSeq<T>(src);
    }
}