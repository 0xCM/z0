//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        [MethodImpl(Inline)]
        public static SubSeq<S,T> subseq<S,T>(S src, Index<T> dst)
            where S : IEquatable<S>
                => new SubSeq<S,T>(src,dst);
    }
}