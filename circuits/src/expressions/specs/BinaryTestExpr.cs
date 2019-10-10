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
        /// Represents a comparison between a control expression and the result of applying a bitwise binary operator to specified operands
        /// </summary>
        public sealed class BinaryTestExpr<T> : TestExpr<T, BinaryBitsExpr<T>>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public BinaryTestExpr(LogicOpKind testop, Expr<T> control, BinaryBitsExpr<T> expr)
                : base(testop, ExprArity.Binary, control,expr)
            {
                  
            }        

        }
    }
}