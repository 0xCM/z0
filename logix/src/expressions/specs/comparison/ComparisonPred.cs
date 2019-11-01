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
    /// Captures a comparison expression along with with its operands
    /// </summary>
    public sealed class ComparisonPred<T> : IComparisonPred<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public ComparisonPred(ComparisonKind op, IExpr<T> left, IExpr<T> right, params VariableExpr<T>[] vars)
        {
            this.ComparisonKind = op;
            this.LeftArg = left;
            this.RightArg = right;
            this.Vars = vars;
        }
        

        /// <summary>
        /// The operator
        /// </summary>
        public ComparisonKind ComparisonKind {get;}

        /// <summary>
        /// The left operand
        /// </summary>
        public IExpr<T> LeftArg {get;}

        /// <summary>
        /// The right operand
        /// </summary>
        public IExpr<T> RightArg {get;}

        public VariableExpr<T>[] Vars {get;}


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