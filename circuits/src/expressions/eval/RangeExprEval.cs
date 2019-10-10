//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    partial class Bitwise
    {

        readonly struct RangeExprEval<T> : IExprEval<T,RangeExpr<T>>
            where T : unmanaged
        {
            public static RangeExprEval<T> TheOnly = new RangeExprEval<T>();

            public IEnumerable<T> Eval(RangeExpr<T> expr)
                => range(expr.Min, expr.Max);
        }

    }

}