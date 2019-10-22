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


    public interface IVariedExpr : IExpr
    {

    }


    public interface IVariedLogicExpr : IVariedExpr, ILogicExpr
    {
        IExpr BaseExpr {get;}        

        ILogicVariable[] Vars {get;}        

        void SetVars(params IExpr[] values);        

    }

    public interface IVariedExpr<T> : IVariedExpr
        where T : unmanaged
    {
        IExpr<T> BaseExpr {get;}

        VariableExpr<T>[] Vars {get;}

        void SetVars(params IExpr<T>[] values);        

        void SetVars(params T[] values);

    }
}