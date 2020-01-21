//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    /// <summary>
    /// Defines the application of an untyped ternary logic operator
    /// </summary>
    public class TernaryLogicOp : ITernaryLogicOp
    {
        /// <summary>
        /// The operator kind
        /// </summary>
        public TernaryBitLogicKind OpKind {get;}

        /// <summary>
        /// The first operand
        /// </summary>
        public ILogicExpr FirstArg {get;}

        /// <summary>
        /// The second operand
        /// </summary>
        public ILogicExpr SecondArg {get;}

        /// <summary>
        /// The third operand
        /// </summary>
        public ILogicExpr ThirdArg {get;}

        [MethodImpl(Inline)]
        public TernaryLogicOp(TernaryBitLogicKind op, ILogicExpr arg1, ILogicExpr arg2, ILogicExpr arg3)
        {
            this.OpKind = op;
            this.FirstArg = arg1;
            this.SecondArg = arg2;
            this.ThirdArg = arg3;
        }

        public string Format()
            => OpKind.Format(FirstArg,SecondArg,ThirdArg);        
        
        public override string ToString()
            => Format();
    }
}