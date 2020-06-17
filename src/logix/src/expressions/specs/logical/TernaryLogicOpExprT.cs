//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    /// <summary>
    /// Defines a typed ternary logic operator expression
    /// </summary>
    public sealed class TernaryLogicOpExpr<T> : ITernaryLogicOpExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The operator kind
        /// </summary>
        public TernaryBitLogic OpKind {get;}

        /// <summary>
        /// The first operand
        /// </summary>
        public ILogicExpr<T> FirstArg {get;}

        /// <summary>
        /// The second operand
        /// </summary>
        public ILogicExpr<T> SecondArg {get;}

        /// <summary>
        /// The third operand
        /// </summary>
        public ILogicExpr<T> ThirdArg {get;}

        [MethodImpl(Inline)]
        public TernaryLogicOpExpr(TernaryBitLogic op, ILogicExpr<T> arg1, ILogicExpr<T> arg2, ILogicExpr<T> arg3)
        {
            this.OpKind = op;
            this.FirstArg = arg1;
            this.SecondArg = arg2;
            this.ThirdArg = arg3;
        }

        ILogicExpr ITernaryOpExpr<ILogicExpr>.FirstArg 
            => FirstArg;

        ILogicExpr ITernaryOpExpr<ILogicExpr>.SecondArg 
            => SecondArg;

        ILogicExpr ITernaryOpExpr<ILogicExpr>.ThirdArg 
            => ThirdArg;

        public string Format()
            => OpKind.Format(FirstArg,SecondArg,ThirdArg);        
        
        public override string ToString()
            => Format();
    }
}