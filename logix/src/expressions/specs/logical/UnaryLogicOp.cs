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
    /// Defines an untyped unary logic operator expression
    /// </summary>
    public class UnaryLogicOp : IUnaryLogicOp
    {
        /// <summary>
        /// The operator kind
        /// </summary>
        public UnaryBitLogicKind OpKind {get;}

        /// <summary>
        /// The operand
        /// </summary>
        public ILogicExpr Arg {get;}

        [MethodImpl(Inline)]
        public UnaryLogicOp(UnaryBitLogicKind op, ILogicExpr arg)
        {
            this.OpKind = op;
            this.Arg = arg;
        }

        public string Format()
            => OpKind.Format(Arg);        
    }

}