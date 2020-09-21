//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Eval
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static PairEvalResults<T> pairs<T>(in Pair<string> labels, in Pairs<T> dst)
            where T : unmanaged
                => new PairEvalResults<T>(labels, dst);
    }
}