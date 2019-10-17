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
    public sealed class Literal<T> : ILiteral<T>
        where T : unmanaged
    {
        /// <summary>
        /// Implicitly converts a literal expression to the underlying value 
        /// </summary>
        /// <param name="src">The source epxression</param>
        [MethodImpl(Inline)]
        public static implicit operator T(Literal<T> src)
            => src.Value;

        /// <summary>
        /// Implicitly converts a value to a literal expression
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Literal<T>(T src)
            => new Literal<T>(src);

        [MethodImpl(Inline)]
        public Literal(T value)
        {                
            this.Value= value;
        }            

        /// <summary>
        /// The literal value
        /// </summary>
        public T Value {get;}

        public OpArityKind Arity => OpArityKind.Literal;

        public string Format()
            => Value.ToString();

        public override string ToString() 
            => Format();
    }


}