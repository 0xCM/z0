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
        public AndNodeExpr(params ILogicOpExpr[] terms)
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
            => BinaryLogic.And;        
    }

    /// <summary>
    /// Represents a bitwise expression sequence conjunction
    /// </summary>
    public sealed class AndNodeExpr<T> : IBitNodeExpr<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public AndNodeExpr(params IBitOpExpr<T>[] terms)
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
            => BitOpKind.And;
    }


}