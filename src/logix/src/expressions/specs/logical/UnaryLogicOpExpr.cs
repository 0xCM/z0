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
    /// Defines an untyped unary logic operator expression
    /// </summary>
    public readonly struct UnaryLogicOpExpr : IUnaryLogicOpExpr
    {
        /// <summary>
        /// The operator kind
        /// </summary>
        public UnaryBitLogic OpKind {get;}

        /// <summary>
        /// The operand
        /// </summary>
        public ILogicExpr Arg {get;}

        [MethodImpl(Inline)]
        public UnaryLogicOpExpr(UnaryBitLogic op, ILogicExpr arg)
        {
            this.OpKind = op;
            this.Arg = arg;
        }

        public string Format()
            => OpKind.Format(Arg);        
    }

}