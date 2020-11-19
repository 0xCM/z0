//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

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
            BaseExpr = baseExpr;
            Vars = variables;
        }

        [MethodImpl(Inline)]
        public void SetVars(params T[] values)
            => VariedExpr.Set(this, values.Map(v => (new LiteralExpr<T>(v) as ILiteralExpr<T>)));

        [MethodImpl(Inline)]
        public void SetVars(params IExpr<T>[] values)
            => VariedExpr.Set(this,values);

        public string Format()
            => string.Empty;
   }
}