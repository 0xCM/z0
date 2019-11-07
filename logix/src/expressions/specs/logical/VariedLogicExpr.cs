//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
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
        public static VariedLogicExpr<T> Define<T>(ILogicExpr<T> baseExpr, params LogicVariable<T>[] variables)
            where T : unmanaged             
                => new VariedLogicExpr<T>(baseExpr, variables);

        [MethodImpl(Inline)]
        public static VariedLogicExpr Define(ILogicExpr baseExpr, params LogicVariable[] variables)
            => new VariedLogicExpr(baseExpr, variables);

        [MethodImpl(Inline)]
        public VariedLogicExpr(ILogicExpr baseExpr, params LogicVariable[] variables)
        {
            this.BaseExpr = baseExpr;
            this.Vars = variables;
        }

        public ILogicExpr BaseExpr {get;}

        public ILogicVarExpr[] Vars {get;}

        public void SetVars(params ILogicExpr[] values)
        {
            var n = Math.Min(Vars.Length, values.Length);
            for(var i=0; i<n; i++)
                Vars[i].Set(values[i]);
        }

        public void SetVars(params bit[] values)
        {
            var n = Math.Min(Vars.Length, values.Length);
            for(var i=0; i<n; i++)
                Vars[i].Set(values[i]);
        }

        public void SetVars(LiteralLogicSeq values)
        {
            var n = Math.Min(Vars.Length, values.Length);
            for(var i=0; i<n; i++)
                Vars[i].Set(values[i]);
        }

        public string Format()
            => BaseExpr.Format();
    }

}