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

    public sealed class VariedExpr<T> : IVariedExpr<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        internal VariedExpr(IExpr<T> baseExpr, params VariableExpr<T>[] variables)
        {
            this.BaseExpr = baseExpr;
            this.Vars = variables;
        }

        public IExpr<T> BaseExpr {get;}

        public IVarExpr<T>[] Vars {get;}


        [MethodImpl(Inline)]
        public void SetVars(params T[] values)
            => OpHelpers.Set(this,values.Map(v => new LiteralExpr<T>(v)));

        [MethodImpl(Inline)]
        public void SetVars(params IExpr<T>[] values)
            => OpHelpers.Set(this,values);
        
        public string Format()
            => string.Empty;

        public void SetVars(params IVarExpr<T>[] values)
        {
            throw new NotImplementedException();
        }
    }

   public sealed class VariedExpr<N,T>  : IVariedExpr<T>
        where T : unmanaged
        where N : unmanaged, ITypeNat
    {        
        [MethodImpl(Inline)]
        internal VariedExpr(IExpr<T> baseExpr, params IVarExpr<T>[] variables)
        {
            this.BaseExpr = baseExpr;
            this.Vars = variables;
        }


        public IExpr<T> BaseExpr {get;}

        public IVarExpr<T>[] Vars {get;}

        [MethodImpl(Inline)]
        public void SetVars(params T[] values)
            => OpHelpers.Set(this,values.Map(v => new LiteralExpr<T>(v)));

        [MethodImpl(Inline)]
        public void SetVars(params IExpr<T>[] values)
            => OpHelpers.Set(this,values);

        public string Format()
            => string.Empty;
   }

}