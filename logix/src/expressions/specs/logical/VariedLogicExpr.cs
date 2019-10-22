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
        public static VariedLogicExpr Define(ILogicExpr baseExpr, params ILogicVariable[] variables)
            => new VariedLogicExpr(baseExpr, variables);


        [MethodImpl(Inline)]
        public VariedLogicExpr(ILogicExpr baseExpr, params ILogicVariable[] variables)
        {
            this.BaseExpr = baseExpr;
            this.Vars = variables;
        }

        /// <summary>
        /// The expression classifier
        /// </summary>
        public LogicExprKind ExprKind
            => LogicExprKind.Varied;

        public ILogicExpr BaseExpr {get;}

        public ILogicVariable[] Vars {get;}

        IExpr IVariedLogicExpr.BaseExpr 
            => BaseExpr;

        public void SetVars(params IExpr[] values)
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