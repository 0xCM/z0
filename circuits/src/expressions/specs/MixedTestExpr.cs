//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    partial class Bitwise
    {
        /// <summary>
        /// Represents a comparison between a control expression and the result of applying a mixed bitwise operator to specified operands
        /// </summary>
        public sealed class MixedTestExpr<T> : TestExpr<T, MixedBitsExpr<T>>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public MixedTestExpr(LogicOpKind testop, Expr<T> control, MixedBitsExpr<T> expr)
                : base(testop, ExprArity.Binary, control,expr)
            {
                  
            }        

        }
    }
}