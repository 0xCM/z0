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
    /// Represents a logical operator over two operands
    /// </summary>
    public class BinaryLogicOp : IBinaryLogicOp
    {
        [MethodImpl(Inline)]
        public BinaryLogicOp(BinaryLogicOpKind op, ILogicExpr lhs, ILogicExpr rhs)
        {
            this.OpKind = op;
            this.LeftArg = lhs;
            this.RightArg = rhs;
        }

        public ILogicExpr LeftArg {get;}

        public ILogicExpr RightArg {get;}

        public BinaryLogicOpKind OpKind {get;}

        public string Format()
            => OpKind.Format(LeftArg,RightArg);        

        public override string ToString()
            => Format();

    } 

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