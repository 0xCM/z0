//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    /// <summary>
    /// Defines a typed comparison expression
    /// </summary>
    public sealed class ComparisonExpr<T> : IComparisonExpr<T>
        where T : unmanaged
    {
        /// <summary>
        /// The operator kind
        /// </summary>
        public BinaryComparisonKind ComparisonKind {get;}

        /// <summary>
        /// The left expression
        /// </summary>
        public IExpr<T> LeftArg {get;}
        
        /// <summary>
        /// The right expression
        /// </summary>
        public IExpr<T> RightArg {get;}

        /// <summary>
        /// The variables upon which the operands depend
        /// </summary>
        public IVarExpr<T>[] Vars {get;}


        [MethodImpl(Inline)]
        public ComparisonExpr(BinaryComparisonKind kind, IExpr<T> lhs, IExpr<T> rhs, params IVarExpr<T>[] vars)
        {
            this.ComparisonKind = kind;
            this.LeftArg = lhs;
            this.RightArg = rhs;
            this.Vars = vars;
        }

        public void SetVars(params IExpr<T>[] values)
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

        [MethodImpl(Inline)]
        public void SetVar(int index, T value)
            => Vars[index].Set(value);
         
        public string Format()
            => ComparisonKind.Format(LeftArg,RightArg);
       
        public override string ToString()
            => Format();
    }
}