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


    public sealed class EqualityExpr<T> : IEqualityExpr<T>
        where T : unmanaged
    {

        public EqualityExpr(IExpr<T> lhs, IExpr<T> rhs, params VariableExpr<T>[] vars)
        {
            this.Lhs = lhs;
            this.Rhs = rhs;
            this.Vars = vars;
        }

        /// <summary>
        /// The left expression
        /// </summary>
        public IExpr<T> Lhs {get;}
        
        /// <summary>
        /// The right expression
        /// </summary>
        public IExpr<T> Rhs {get;}

        public VariableExpr<T>[] Vars {get;}


        public void SetVars(params ILogicExpr<T>[] values)
        {
            var count = Math.Min(Vars.Length, values.Length);
            for(var i=0; i<count; i++)
                Vars[i].Set(values[i]);
        }

        public void SetVars(params T[] values)
        {
            var count = Math.Min(Vars.Length, values.Length);
            for(var i=0; i<count; i++)
                Vars[i].Set(values[i]);
        }

        public string Format()
            => Lhs.Format() + " == " + Rhs.Format();
    }
}