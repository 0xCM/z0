//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = EvalResults;

    public struct CmpEval<T>
    {
        public ComparisonKind Kind;

        public T A;

        public T B;

        public bit Result;

        [MethodImpl(Inline)]
        public static implicit operator BinaryEval<ComparisonKind,T,bit>(CmpEval<T> src)
            => api.binary(src.Kind, src.A, src.B, src.Result);
    }
}