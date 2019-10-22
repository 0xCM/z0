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
    /// Defines an untyped literal expression
    /// </summary>
    public sealed class LiteralExpr : IBitLiteralExpr
    {
        /// <summary>
        /// Implicitly converts a literal expression to the underlying value 
        /// </summary>
        /// <param name="src">The source epxression</param>
        [MethodImpl(Inline)]
        public static implicit operator bit(LiteralExpr src)
            => src.Value;

        /// <summary>
        /// Implicitly converts a value to a literal expression
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator LiteralExpr(bit src)
            => new LiteralExpr(src);

        [MethodImpl(Inline)]
        public LiteralExpr(bit value)
        {                
            this.Value= value;
        }            

        /// <summary>
        /// The literal value
        /// </summary>
        public bit Value {get;}

        public string Format()
            =>Format(false);
         
        public string Format(bool digit)
            => digit ? Value.ToString() 
                : Value ? "T" : "F";

        public override string ToString() 
            => Format();
    }

}