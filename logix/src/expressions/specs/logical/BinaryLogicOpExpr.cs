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
    /// Definesan untyped binary logical operator expression
    /// </summary>
    public readonly struct BinaryLogicOpExpr : IBinaryLogicOpExpr
    {
        /// <summary>
        /// The operator kind
        /// </summary>
        public BinaryLogicKind OpKind {get;}

        /// <summary>
        /// The left operand
        /// </summary>
        public ILogicExpr LeftArg {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        public ILogicExpr RightArg {get;}

        [MethodImpl(Inline)]
        public BinaryLogicOpExpr(BinaryLogicKind op, ILogicExpr lhs, ILogicExpr rhs)
        {
            this.OpKind = op;
            this.LeftArg = lhs;
            this.RightArg = rhs;
        }

        public string Format()
            => OpKind.Format(LeftArg,RightArg);        

        public override string ToString()
            => Format();
    } 
}