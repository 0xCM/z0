//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public sealed class VariedExpr<T> : IVariedExpr<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        internal VariedExpr(IExpr<T> baseExpr, params Variable<T>[] variables)
        {
            this.BaseExpr = baseExpr;
            this.Vars = variables;
        }

        public IExpr<T> BaseExpr {get;}

        public Variable<T>[] Vars {get;}

        [MethodImpl(Inline)]
        public void SetVarValues(params T[] values)
            => VariedExpr.Set(this,values.Map(v => new Literal<T>(v)));

        [MethodImpl(Inline)]
        public void SetVarValues(params IExpr<T>[] values)
            => VariedExpr.Set(this,values);
        
        public string Format()
            => string.Empty;
    }

   public sealed class VariedExpr<N,T>  : IVariedExpr<T>
        where T : unmanaged
        where N : unmanaged, ITypeNat
    {        
        [MethodImpl(Inline)]
        internal VariedExpr(IExpr<T> baseExpr, params Variable<T>[] variables)
        {
            this.BaseExpr = baseExpr;
            this.Vars = variables;
        }

        public IExpr<T> BaseExpr {get;}

        public Variable<T>[] Vars {get;}

        [MethodImpl(Inline)]
        public void SetVarValues(params T[] values)
            => VariedExpr.Set(this,values.Map(v => new Literal<T>(v)));

        [MethodImpl(Inline)]
        public void SetVarValues(params IExpr<T>[] values)
            => VariedExpr.Set(this,values);

        public string Format()
            => string.Empty;
   }

}