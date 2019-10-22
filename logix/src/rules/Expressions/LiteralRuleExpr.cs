//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
        
    using static zfunc;

    /// <summary>
    /// Defines a literal expression
    /// </summary>
    public readonly struct LiteralRuleExpr<T> : IRuleExpr<T>
    {
        [MethodImpl(Inline)]
        public LiteralRuleExpr(T Value)
            => this.Value = Value;
        
        /// <summary>
        /// The literal value lifted to an expression
        /// </summary>
        public T Value {get;}
        
        public override string ToString()
            => Value.ToString();
    }


}