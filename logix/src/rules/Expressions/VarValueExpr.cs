//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;       
    
    using static zfunc;

    /// <summary>
    /// A variable value assignment
    /// </summary>
    public readonly struct VarValueExpr<T> : IRuleExpr<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public VarValueExpr(VarRuleExpr<T> variable, T value)
        {
            this.Variable = variable;
            this.Value = value;
        }

        /// <summary>
        /// The variable to which a value is assigned
        /// </summary>
        public VarRuleExpr<T> Variable {get;}

        /// <summary>
        /// The assigned value
        /// </summary>
        public T Value {get;}

        /// <summary>
        /// The variable name
        /// </summary>
        public string Name 
            => Variable.Name;
         
        [MethodImpl(Inline)]
        public string Format()
            => $"{Name} := {Value}";
        
        public override string ToString()
            => Format();

    }

}