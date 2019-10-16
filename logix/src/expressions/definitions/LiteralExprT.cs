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
    public sealed class LiteralExpr<T> : ILiteral<T>
        where T : unmanaged
    {
        /// <summary>
        /// Implicitly converts a literal expression to the underlying value 
        /// </summary>
        /// <param name="src">The source epxression</param>
        [MethodImpl(Inline)]
        public static implicit operator T(LiteralExpr<T> src)
            => src.Value;

        /// <summary>
        /// Implicitly converts a value to a literal expression
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator LiteralExpr<T>(T src)
            => new LiteralExpr<T>(src);

        [MethodImpl(Inline)]
        public LiteralExpr(T value)
        {                
            this.Value= value;
        }            

        /// <summary>
        /// The literal value
        /// </summary>
        public T Value {get;}

        public ArityKind Arity => ArityKind.Literal;

        public string Format()
            => Value.ToString();

        public override string ToString() 
            => Format();
    }


}