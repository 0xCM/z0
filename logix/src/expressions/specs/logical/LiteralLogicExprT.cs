//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    /// <summary>    
    /// Defines a typed literal logic expression
    /// </summary>
    public sealed class LiteralLogicExpr<T> : ILogicLiteralExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The literal value
        /// </summary>
        public bit Value {get;}

        [MethodImpl(Inline)]
        public LiteralLogicExpr(bit value)
            => this.Value= value;
         
        public string Format()
            => $"{Value}";

        public override string ToString() 
            => Format();
    }
}