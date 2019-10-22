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

    public sealed class EqualityExpr : IEqualityExpr
    {
        public static EqualityExpr Define(ILogicExpr lhs, ILogicExpr rhs, params VariableExpr[] vars)
            => new EqualityExpr(lhs,rhs,vars);
            
        public EqualityExpr(ILogicExpr lhs, ILogicExpr rhs, params VariableExpr[] vars)
        {
            this.Lhs = lhs;
            this.Rhs = rhs;
            this.Vars = vars;
        }

        /// <summary>
        /// The left expression
        /// </summary>
        public ILogicExpr Lhs {get;}
        
        /// <summary>
        /// The right expression
        /// </summary>
        public ILogicExpr Rhs {get;}

        public VariableExpr[] Vars {get;}

        public void SetVars(params ILogicExpr[] values)
        {
            var count = Math.Min(Vars.Length, values.Length);
            for(var i=0; i<count; i++)
                Vars[i].Set(values[i]);
        }

        public void SetVars(IBitLiteralSeq values)
        {
            var count = Math.Min(Vars.Length, values.Length);
            for(var i=0; i<count; i++)
                Vars[i].Set(values[i]);
        }

        public void SetVars(params bit[] values)
        {
            var count = Math.Min(Vars.Length, values.Length);
            for(var i=0; i<count; i++)
                Vars[i].Set(values[i]);
        }


        public string Format()
            => Lhs.Format() + " == " + Rhs.Format();
    }
}