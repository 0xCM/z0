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
        /// Represents a comparison between a control expression and the result of applying a unary binary operator to specified operands
        /// </summary>
        public sealed class UnaryTestExpr<T> : TestExpr<T, UnaryBitsExpr<T>>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public UnaryTestExpr(LogicOpKind testop, Expr<T> control, UnaryBitsExpr<T> expr)
                : base(testop, ExprArity.Unary, control,expr)
            {
                  
            }        

        }
    }
}