//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;

    public static class Evaluations
    {

        [MethodImpl(Inline)]
        public static BinaryEval<T> binary<T>(in Pairs<T> src, PairEval<T> dst)
            where T : unmanaged
                => new BinaryEval<T>(src,  dst);

    }

}