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
        public static VariedLogicExpr Define(ILogicExpr baseExpr, params IlogicVariable[] variables)
            => new VariedLogicExpr(baseExpr, variables);

        [MethodImpl(Inline)]
        public static VariedLogicExpr<N> Define<N>(N n, ILogicExpr baseExpr, params IlogicVariable[] variables)
            where N : ITypeNat, new()
        {
            Nat.require<N>(variables.Length);
            return new VariedLogicExpr<N>(baseExpr, variables);
        }

        [MethodImpl(Inline)]
        public VariedLogicExpr(ILogicExpr baseExpr, params IlogicVariable[] variables)
        {
            this.BaseExpr = baseExpr;
            this.Vars = variables;
        }

        public ILogicExpr BaseExpr {get;}

        public IlogicVariable[] Vars {get;}

        IExpr IVaried<IExpr, IlogicVariable>.BaseExpr 
            => BaseExpr;

        public void SetVarValues(params IExpr[] values)
        {
            var n = Math.Min(Vars.Length, values.Length);
            for(var i=0; i<n; i++)
                Vars[i].Set(values[i]);
        }

    }

    public sealed class VariedLogicExpr<N>  : IVariedLogicExpr<N>
        where N : ITypeNat,new()
    {
        [MethodImpl(Inline)]
        internal VariedLogicExpr(ILogicExpr baseExpr, params IVariable[] variables)
        {
            this.BaseExpr = baseExpr;
            this.Vars = variables;
        }

        public ILogicExpr BaseExpr {get;}


        public IVariable[] Vars {get;}

        IExpr IVaried<IExpr, IVariable>.BaseExpr 
            => BaseExpr;

        public void SetVarValues(params IExpr[] values)
        {
            var n = Math.Min(Vars.Length, values.Length);
            for(var i=0; i<n; i++)
                Vars[i].Set(values[i]);
        }

    }

}