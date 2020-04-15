//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    /// <summary>
    /// Defines a typed binary logical operator expression
    /// </summary>
    public readonly struct BinaryLogicOpExpr<T> : IBinaryLogicOpExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The left operand
        /// </summary>
        public ILogicExpr<T> LeftArg {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        public ILogicExpr<T> RightArg {get;}

        /// <summary>
        /// The operator kind
        /// </summary>
        public BinaryLogicKind OpKind {get;}

        [MethodImpl(Inline)]
        public BinaryLogicOpExpr(BinaryLogicKind op, ILogicExpr<T> left, ILogicExpr<T> right)
        {
            this.OpKind = op;
            this.LeftArg = left;
            this.RightArg = right;
        }

        ILogicExpr IBinaryOpExpr<ILogicExpr>.LeftArg 
            => LeftArg;

        ILogicExpr IBinaryOpExpr<ILogicExpr>.RightArg 
            => RightArg;

        public string Format()
            => OpKind.Format(LeftArg,RightArg);        

        public override string ToString()
            => Format();
    }
}