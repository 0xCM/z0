//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    /// <summary>    
    /// Defines an untyped literal expression
    /// </summary>
    public sealed class LiteralLogicExpr : ILogicLiteral
    {
        /// <summary>
        /// Implicitly converts a literal expression to the underlying value 
        /// </summary>
        /// <param name="src">The source epxression</param>
        [MethodImpl(Inline)]
        public static implicit operator bit(LiteralLogicExpr src)
            => src.Value;

        /// <summary>
        /// Implicitly converts a value to a literal expression
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator LiteralLogicExpr(bit src)
            => new LiteralLogicExpr(src);

        [MethodImpl(Inline)]
        public LiteralLogicExpr(bit value)
        {                
            this.Value= value;
        }            

        /// <summary>
        /// The expression classifier
        /// </summary>
        public LogicExprKind ExprKind
            => LogicExprKind.Literal;

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