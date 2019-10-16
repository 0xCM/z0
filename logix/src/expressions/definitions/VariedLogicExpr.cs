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
    /// Defines a logic expression that is parametrized by one or more variables
    /// </summary>
    public sealed class VariedLogicExpr : IVariedLogicExpr
    {        
        [MethodImpl(Inline)]
        public static VariedLogicExpr Define(IExpr baseExpr, params ILogicVar[] variables)
            => new VariedLogicExpr(baseExpr, variables);

        [MethodImpl(Inline)]
        public static VariedExpr<N> Define<N>(N n, IExpr baseExpr, params ILogicVar[] variables)
            where N : ITypeNat, new()
        {
            Nat.require<N>(variables.Length);
            return new VariedExpr<N>(baseExpr, variables);
        }

        [MethodImpl(Inline)]
        public VariedLogicExpr(IExpr baseExpr, params ILogicVar[] variables)
        {
            this.BaseExpr = baseExpr;
            this.Vars = variables;
        }

        public IExpr BaseExpr {get;}

        public ArityKind Arity 
            => BaseExpr.Arity;

        public ILogicVar[] Vars {get;}

        public void SetVarValues(params IExpr[] values)
        {
            var n = Math.Min(Vars.Length, values.Length);
            for(var i=0; i<n; i++)
                Vars[i].Set(values[i]);
        }

    }

    public sealed class VariedExpr<N>  : IVariedLogicExpr<N>
        where N : ITypeNat,new()
    {
        [MethodImpl(Inline)]
        internal VariedExpr(IExpr baseExpr, params IVarExpr[] variables)
        {
            this.BaseExpr = baseExpr;
            this.Vars = variables;
        }

        public IExpr BaseExpr {get;}

        public ArityKind Arity 
            => BaseExpr.Arity;

        public IVarExpr[] Vars {get;}

        public void SetVarValues(params IExpr[] values)
        {
            var n = Math.Min(Vars.Length, values.Length);
            for(var i=0; i<n; i++)
                Vars[i].Set(values[i]);
        }

    }

}