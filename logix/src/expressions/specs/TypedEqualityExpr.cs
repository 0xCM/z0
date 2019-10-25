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

    public sealed class TypedEqualityExpr<T> : ITypedEqualityExpr<T>
        where T : unmanaged
    {

        [MethodImpl(Inline)]
        public TypedEqualityExpr(ITypedExpr<T> lhs, ITypedExpr<T> rhs, params VariableExpr<T>[] vars)
        {
            this.Lhs = lhs;
            this.Rhs = rhs;
            this.Vars = vars;
        }

        /// <summary>
        /// The expression classifier
        /// </summary>
        public TypedExprKind ExprKind 
            => TypedExprKind.Equality;

        /// <summary>
        /// The left expression
        /// </summary>
        public ITypedExpr<T> Lhs {get;}
        
        /// <summary>
        /// The right expression
        /// </summary>
        public ITypedExpr<T> Rhs {get;}

        public VariableExpr<T>[] Vars {get;}


        public void SetVars(params ITypedExpr<T>[] values)
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
            => Lhs.Format() + " == " + Rhs.Format();
        
        public override string ToString()
            => Format();
    }
}