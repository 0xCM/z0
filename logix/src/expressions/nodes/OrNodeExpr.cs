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
        public OrNodeExpr(params ILogicOpExpr[] terms)
        {
            this.Terms = terms;
        }
        
        /// <summary>
        /// Specifies the number of parameters accepted by the expression
        /// </summary>
        public ExprArity Arity => ExprArity.Sequence;

        /// <summary>
        /// The left operand
        /// </summary>
        public ILogicOpExpr[] Terms {get;}

        public BinaryLogic Operator 
            => BinaryLogic.Or;        
    }


    /// <summary>
    /// Represents a bitwise expression sequence disjunction
    /// </summary>
    public sealed class OrNodeExpr<T> : IBitNodeExpr<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public OrNodeExpr(params IBitOpExpr<T>[] terms)
        {
            this.Terms = terms;
        }
        
        /// <summary>
        /// Specifies the number of parameters accepted by the expression
        /// </summary>
        public ExprArity Arity => ExprArity.Sequence;

        /// <summary>
        /// The left operand
        /// </summary>
        public IBitOpExpr<T>[] Terms {get;}

        public BitOpKind Operator 
            => BitOpKind.Or;
    }



}