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
    /// Defines a typed logic expression over one or more variables
    /// </summary>
    public sealed class VariedLogicExpr<T> : IVariedLogicExpr<T> 
        where T : unmanaged
    {        
        /// <summary>
        /// The variable-dependent expression
        /// </summary>
        public ILogicExpr<T> BaseExpr {get;}

        /// <summary>
        /// The variables that parametrize the base expression
        /// </summary>
        public ILogicVarExpr<T>[] Vars {get;}

    
        [MethodImpl(Inline)]
        public VariedLogicExpr(ILogicExpr<T> baseExpr, params ILogicVarExpr<T>[] variables)
        {
            this.BaseExpr = baseExpr;
            this.Vars = variables;
        }

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