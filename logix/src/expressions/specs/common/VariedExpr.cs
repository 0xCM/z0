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
    /// Defines a variable-dependent typed expression
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public sealed class VariedExpr<T> : IVariedExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// A variable-dependent expression
        /// </summary>
        public IExpr<T> BaseExpr {get;}

        /// <summary>
        /// The variables upon which the expression depends
        /// </summary>
        public IVarExpr<T>[] Vars {get;}

        [MethodImpl(Inline)]
        internal VariedExpr(IExpr<T> baseExpr, params VariableExpr<T>[] variables)
        {
            this.BaseExpr = baseExpr;
            this.Vars = variables;
        }

        [MethodImpl(Inline)]
        public void SetVars(params T[] values)
            => OpHelpers.Set(this,values.Map(v => new LiteralExpr<T>(v)));

        [MethodImpl(Inline)]
        public void SetVars(params IExpr<T>[] values)
            => OpHelpers.Set(this,values);
        
        public string Format()
            => string.Empty;

        [MethodImpl(Inline)]
        public void SetVars(params IVarExpr<T>[] values)
            => OpHelpers.Set(this,values);
    }

    /// <summary>
    ///  Defines a typed expression over a variable sequence of natural length
    /// </summary>
    /// <typeparam name="N">The sequence length type</typeparam>
    /// <typeparam name="T">The operand type</typeparam>
    public sealed class VariedExpr<N,T>  : IVariedExpr<T>
        where T : unmanaged
        where N : unmanaged, ITypeNat
    {        
        public IExpr<T> BaseExpr {get;}

        public IVarExpr<T>[] Vars {get;}

        [MethodImpl(Inline)]
        internal VariedExpr(IExpr<T> baseExpr, params IVarExpr<T>[] variables)
        {
            this.BaseExpr = baseExpr;
            this.Vars = variables;
        }

        [MethodImpl(Inline)]
        public void SetVars(params T[] values)
            => OpHelpers.Set(this,values.Map(v => new LiteralExpr<T>(v)));

        [MethodImpl(Inline)]
        public void SetVars(params IExpr<T>[] values)
            => OpHelpers.Set(this,values);

        public string Format()
            => string.Empty;
   }
}