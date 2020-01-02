//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    /// <summary>
    /// Definesan untyped binary logical operator expression
    /// </summary>
    public class BinaryLogicOp : IBinaryLogicOp
    {
        /// <summary>
        /// The operator kind
        /// </summary>
        public BinaryLogicOpKind OpKind {get;}

        /// <summary>
        /// The left operand
        /// </summary>
        public ILogicExpr LeftArg {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        public ILogicExpr RightArg {get;}

        [MethodImpl(Inline)]
        public BinaryLogicOp(BinaryLogicOpKind op, ILogicExpr lhs, ILogicExpr rhs)
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