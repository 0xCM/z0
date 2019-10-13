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
    public sealed class LogicLitExpr : ILogicLitExpr
    {
        /// <summary>
        /// Implicitly converts a literal expression to the underlying value 
        /// </summary>
        /// <param name="src">The source epxression</param>
        [MethodImpl(Inline)]
        public static implicit operator Bit(LogicLitExpr src)
            => src.Value;

        /// <summary>
        /// Implicitly converts a value to a literal expression
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator LogicLitExpr(Bit src)
            => new LogicLitExpr(src);

        [MethodImpl(Inline)]
        public LogicLitExpr(Bit value)
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


}