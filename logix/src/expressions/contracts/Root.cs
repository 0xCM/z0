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

    public interface IExpr
    {
        ArityKind Arity {get;}
    }


    public interface IExpr<T> : IExpr
        where T : unmanaged
    {

    }

    public interface IOpExpr<T> : IExpr<T>, IExpr
        where T : unmanaged
    {

    }

    public interface IOpExpr<T,K> : IOpExpr<T>
        where T : unmanaged
        where K : Enum
    {
        K Operator {get;}
    }

    public interface ILogicExpr : ILogicExpr<Bit>
    {
        
    }

    public interface ILogicExpr<T> : IExpr<T>
        where T : unmanaged
    {

    }

    public interface ILogicOp : ILogicExpr
    {

    }

    public interface ILogicOp<K> : ILogicOp
        where K : Enum
    {
        K Operator {get;}
    }




}