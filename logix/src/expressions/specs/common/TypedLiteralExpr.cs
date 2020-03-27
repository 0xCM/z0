//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    /// <summary>    
    /// Lifts a literal value to an expression
    /// </summary>
    public sealed class LiteralExpr<T> : ILiteralExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The literal value
        /// </summary>
        public T Value {get;}

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
        public static bool operator ==(LiteralExpr<T> a, LiteralExpr<T> b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(LiteralExpr<T> a, LiteralExpr<T> b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public LiteralExpr(T value)
        {                
            this.Value= value;
        }            

        [MethodImpl(Inline)]
        public bool Equals(T other)
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong))
                return gmath.eq(Value,other);
            else
                throw Unsupported.define<T>();            
        }

        public override int GetHashCode()
            => Value.GetHashCode();

        public override bool Equals(object obj)
            => obj is LiteralExpr<T> x && Equals(x);
        
        public string Format()
            => Value.ToString();

        public override string ToString() 
            => Format();
    }
}