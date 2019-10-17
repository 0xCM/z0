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

    /// <summary>
    /// Represents a logical expression sequence conjunction
    /// </summary>
    public sealed class AndNodeExpr : ILogicNodeExpr
    {
        [MethodImpl(Inline)]
        public AndNodeExpr(params ILogicOp[] terms)
        {
            this.Terms = terms;
        }
        
        /// <summary>
        /// Specifies the number of parameters accepted by the expression
        /// </summary>
        public OpArityKind Arity => OpArityKind.Sequence;

        /// <summary>
        /// The left operand
        /// </summary>
        public ILogicOp[] Terms {get;}

        public BinaryLogicOpKind Operator 
            => BinaryLogicOpKind.And;        
    }

    /// <summary>
    /// Represents a bitwise expression sequence conjunction
    /// </summary>
    public sealed class AndNodeExpr<T> : ILogicNodeExpr<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public AndNodeExpr(params IOpExpr<T>[] terms)
        {
            this.Terms = terms;
        }
        
        /// <summary>
        /// Specifies the number of parameters accepted by the expression
        /// </summary>
        public OpArityKind Arity => OpArityKind.Sequence;

        /// <summary>
        /// The left operand
        /// </summary>
        public IOpExpr<T>[] Terms {get;}

    }


}