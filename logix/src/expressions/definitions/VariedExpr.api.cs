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

    public static class VariedExpr
    {
        [MethodImpl(Inline)]
        public static VariedExpr<T> Define<T>(IExpr<T> baseExpr, params Variable<T>[] variables)
            where T : unmanaged             
                => new VariedExpr<T>(baseExpr, variables);

        [MethodImpl(Inline)]
        public static VariedExpr<N,T> Define<N,T>(N n, IExpr<T> baseExpr, params Variable<T>[] variables)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            Nat.require<N>(variables.Length);
            return new VariedExpr<N,T>(baseExpr, variables);
        }

        internal static void Set<T>(IVariedExpr<T> expr, params IExpr<T>[] values)
            where T : unmanaged
        {
            var n = Math.Min(expr.Vars.Length, values.Length);
            for(var i=0; i<n; i++)
                expr.Vars[i].Set(values[i]);
        }
    }
}