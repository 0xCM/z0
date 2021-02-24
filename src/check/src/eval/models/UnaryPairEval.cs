//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct UnaryPairEval<K,T,R>
    {
        public UnaryEval<K,T> A;

        public UnaryEval<K,T> B;

        public R Result;
    }
}