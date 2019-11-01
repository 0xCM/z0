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

    public sealed class ComparisonExpr : IComparisonExpr
    {
        
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> Define<T>(ComparisonKind kind, IExpr<T> lhs, IExpr<T> rhs, params VariableExpr<T>[] vars)
            where T : unmanaged
                => new ComparisonExpr<T>(kind,lhs,rhs,vars);
        
        [MethodImpl(Inline)]
        public static ComparisonExpr Define(ComparisonKind kind, ILogicExpr lhs, ILogicExpr rhs, params LogicVariable[] vars)
            => new ComparisonExpr(kind,lhs,rhs,vars);
            
        ComparisonExpr(ComparisonKind kind, ILogicExpr lhs, ILogicExpr rhs, params LogicVariable[] vars)
        {
            this.ComparisonKind = kind;
            this.Lhs = lhs;
            this.Rhs = rhs;
            this.Vars = vars;
        }


        public ComparisonKind ComparisonKind {get;}

        /// <summary>
        /// The left expression
        /// </summary>
        public ILogicExpr Lhs {get;}
        
        /// <summary>
        /// The right expression
        /// </summary>
        public ILogicExpr Rhs {get;}

        public LogicVariable[] Vars {get;}

        public void SetVars(params ILogicExpr[] values)
        {
            var count = Math.Min(Vars.Length, values.Length);
            for(var i=0; i<count; i++)
                Vars[i].Set(values[i]);
        }

        public void SetVars(ILiteralLogicSeq values)
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

        [MethodImpl(Inline)]
        public void SetVar(bit a)
        {
            Vars[0].Set(a);
        }

        [MethodImpl(Inline)]
        public void SetVars(bit a, bit b)
        {
            Vars[0].Set(a);
            Vars[1].Set(b);
        }

        [MethodImpl(Inline)]
        public void SetVars(bit a, bit b, bit c)
        {
            Vars[0].Set(a);
            Vars[1].Set(b);
            Vars[2].Set(c);
        }


        public string Format()
            => Lhs.Format() + " == " + Rhs.Format();
    }
}