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


    public interface IVariedExpr : IExpr
    {

    }


    public interface IVariedLogicExpr : IVariedExpr, ILogicExpr
    {
        ILogicExpr BaseExpr {get;}        

        ILogicVarExpr[] Vars {get;}        

        void SetVars(params ILogicExpr[] values);        

        void SetVars(params bit[] values);        

    }

    public interface IVariedExpr<T> : IVariedExpr, IExpr<T>
        where T : unmanaged
    {
        IExpr<T> BaseExpr {get;}

        VariableExpr<T>[] Vars {get;}

        void SetVars(params IExpr<T>[] values);        

        void SetVars(params T[] values);

    }
}