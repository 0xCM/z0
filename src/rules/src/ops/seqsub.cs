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
        public static SeqSub<S,T> seqsub<S,T>(S src, Index<T> dst)
            where S : IEquatable<S>
                => new SeqSub<S,T>(src,dst);
    }
}