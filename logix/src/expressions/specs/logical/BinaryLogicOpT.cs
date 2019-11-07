//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    /// <summary>
    /// Represents a logical operator over two typed logical expressions
    /// </summary>
    public sealed class BinaryLogicOp<T> : BinaryLogicOp, IBinaryLogicOp<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public BinaryLogicOp(BinaryLogicOpKind op, ILogicExpr<T> left, ILogicExpr<T> right)
            : base(op,left,right)
        {
            this.LeftArg = left;
            this.RightArg = right;
        }

        public new ILogicExpr<T> LeftArg {get;}

        public new ILogicExpr<T> RightArg {get;}
    }



}