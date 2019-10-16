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
    /// Represents a logical expression sequence disjunction
    /// </summary>
    public sealed class OrNodeExpr : ILogicNodeExpr
    {
        [MethodImpl(Inline)]
        public OrNodeExpr(params ILogicOp[] terms)
        {
            this.Terms = terms;
        }
        
        /// <summary>
        /// Specifies the number of parameters accepted by the expression
        /// </summary>
        public ArityKind Arity => ArityKind.Sequence;

        /// <summary>
        /// The left operand
        /// </summary>
        public ILogicOp[] Terms {get;}

        public BinaryLogicKind Operator 
            => BinaryLogicKind.Or;        
    }


    /// <summary>
    /// Represents a bitwise expression sequence disjunction
    /// </summary>
    public sealed class OrNodeExpr<T> : ILogicNodeExpr<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public OrNodeExpr(params IOpExpr<T>[] terms)
        {
            this.Terms = terms;
        }
        
        /// <summary>
        /// Specifies the number of parameters accepted by the expression
        /// </summary>
        public ArityKind Arity => ArityKind.Sequence;

        /// <summary>
        /// The left operand
        /// </summary>
        public IOpExpr<T>[] Terms {get;}

    }



}