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

    public interface IlogicVariable : ILogicExpr, IVariable
    {
        void Set(ILogicExpr value);

        new ILogicExpr Value {get;}

    }

    public interface IVariedLogicExpr : ILogicExpr, IVariedExpr<IExpr,IlogicVariable>
    {

    }

    public interface IVariedLogicExpr<N> : ILogicExpr, IVariedExpr<N,IExpr,IVariable>
        where N : unmanaged, ITypeNat
    {

    }


}