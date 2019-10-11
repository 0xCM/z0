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
    /// Lifts a literal bit value to an expression
    /// </summary>
    public sealed class BitLitExpr : ILogicLiteralExpr
    {
        /// <summary>
        /// Implicitly converts a literal expression to the underlying value 
        /// </summary>
        /// <param name="src">The source epxression</param>
        [MethodImpl(Inline)]
        public static implicit operator Bit(BitLitExpr src)
            => src.Value;

        /// <summary>
        /// Implicitly converts a value to a literal expression
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator BitLitExpr(Bit src)
            => new BitLitExpr(src);

        [MethodImpl(Inline)]
        public BitLitExpr(Bit value)
        {                
            this.Value= value;
        }            

        /// <summary>
        /// The literal value
        /// </summary>
        public Bit Value {get;}

        public ExprArity Arity => ExprArity.Literal;

        public string Format(bool digit = false)
            => digit ? Value.ToString() 
                : Value ? "T" : "F";

        public override string ToString() 
            => Format();
    }

    /// <summary>
    /// Lifts a literal value to an expression
    /// </summary>
    public sealed class BitLitExpr<T> : IBitLiteralExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// Implicitly converts a literal expression to the underlying value 
        /// </summary>
        /// <param name="src">The source epxression</param>
        [MethodImpl(Inline)]
        public static implicit operator T(BitLitExpr<T> src)
            => src.Value;

        /// <summary>
        /// Implicitly converts a value to a literal expression
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator BitLitExpr<T>(T src)
            => new BitLitExpr<T>(src);

        [MethodImpl(Inline)]
        public BitLitExpr(T value)
        {                
            this.Value= value;
        }
        
        public BitOpKind Operator => BitOpKind.Literal;

        public ExprArity Arity => ExprArity.Literal;            

        /// <summary>
        /// The literal value
        /// </summary>
        public T Value {get;}

    }

 
}