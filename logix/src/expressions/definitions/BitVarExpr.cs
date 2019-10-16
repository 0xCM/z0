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

    public sealed class BitVarExpr<T> : IBitVarExpr<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public BitVarExpr(string name, IBitExpr<T> value)
        {
            this.Value = value;
            this.Name = name;
        }

        /// <summary>
        /// The name of the variable
        /// </summary>
        public string Name {get;}            

        /// <summary>
        /// The value of the variable
        /// </summary>
        public IBitExpr<T> Value {get; private set;}
        
        public ExprArity Arity 
            => ExprArity.Unary;
        
        /// <summary>
        /// Updates the variable's value
        /// </summary>
        /// <param name="value">The new value</param>
        [MethodImpl(Inline)]
        public void Set(IBitExpr<T> value)
        {
            Value = value;
        }

        /// <summary>
        /// Updates the variable's value with a literal exxpression
        /// </summary>
        /// <param name="value">The new value</param>
        [MethodImpl(Inline)]
        public void Set(BitLitExpr<T> value)
        {
            this.Value = value;
        }

        public override string ToString()
            => $"{Name} := {Value}";
    }



}