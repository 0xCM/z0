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
    public sealed class VariedExpr : IVariedLogicExpr
    {        
        [MethodImpl(Inline)]
        public static VariedExpr Define(ILogicExpr baseExpr, params ILogicVarExpr[] variables)
            => new VariedExpr(baseExpr, variables);

        [MethodImpl(Inline)]
        public static VariedExpr<N> Define<N>(N n, ILogicExpr baseExpr, params ILogicVarExpr[] variables)
            where N : ITypeNat, new()
        {
            Nat.require<N>(variables.Length);
            return new VariedExpr<N>(baseExpr, variables);
        }

        [MethodImpl(Inline)]
        public VariedExpr(ILogicExpr baseExpr, params ILogicVarExpr[] variables)
        {
            this.BaseExpr = baseExpr;
            this.Vars = variables;
        }

        public ILogicExpr BaseExpr {get;}

        public ExprArity Arity 
            => BaseExpr.Arity;

        public ILogicVarExpr[] Vars {get;}

        public void SetVarValues(params ILogicExpr[] values)
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
        internal VariedExpr(ILogicExpr baseExpr, params ILogicVarExpr[] variables)
        {
            this.BaseExpr = baseExpr;
            this.Vars = variables;
        }

        public ILogicExpr BaseExpr {get;}

        public ExprArity Arity 
            => BaseExpr.Arity;

        public ILogicVarExpr[] Vars {get;}

        public void SetVarValues(params ILogicExpr[] values)
        {
            var n = Math.Min(Vars.Length, values.Length);
            for(var i=0; i<n; i++)
                Vars[i].Set(values[i]);
        }

    }

}