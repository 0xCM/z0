//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using Z0;
    using static zfunc;

    /// <summary>
    /// Defines a logic expression that is parametrized by one or more variables
    /// </summary>
    public sealed class VariedLogicExpr<T> : IVariedLogicExpr<T> 
        where T : unmanaged
    {        
    
        [MethodImpl(Inline)]
        public VariedLogicExpr(ILogicExpr<T> baseExpr, params ILogicVarExpr<T>[] variables)
        {
            this.BaseExpr = baseExpr;
            this.Vars = variables;
        }

        public ILogicExpr<T> BaseExpr {get;}

        public ILogicVarExpr<T>[] Vars {get;}

        ILogicExpr IVariedLogicExpr.BaseExpr 
            => BaseExpr;

        ILogicVarExpr[] IVariedLogicExpr.Vars 
            => Vars.Map(v => v);

        public void SetVars(params ILogicExpr<T>[] values)
        {
            var n = Math.Min(Vars.Length, values.Length);
            for(var i=0; i<n; i++)
                Vars[i].Set(values[i]);
        }



        public string Format()
            => BaseExpr.Format();

        public void SetVars(params ILogicExpr[] values)
        {
            throw new NotImplementedException();
        }

        public void SetVars(params bit[] values)
        {
            throw new NotImplementedException();
        }
    }

}