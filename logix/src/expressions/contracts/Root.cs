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
        
    }


    public interface IExpr<T> : IExpr
        where T : unmanaged
    {

    }

    public interface IOpExpr : IExpr
    {
        /// <summary>
        /// The operator arity
        /// </summary>
        OpArityKind Arity {get;}
    }

    public interface IOpExpr<T> : IExpr<T>, IOpExpr
        where T : unmanaged
    {

    }

    public interface IOpExpr<T,K> : IOpExpr<T>
        where T : unmanaged
        where K : Enum
    {
        K OpKind {get;}
    }

    public interface ILogicExpr : ILogicExpr<bit>
    {
        
    }

    public interface ILogicExpr<T> : IExpr<T>
        where T : unmanaged
    {

    }

    public interface ILogicOp : ILogicExpr, IOpExpr
    {

    }

    public interface ILogicOp<K> : ILogicOp
        where K : Enum
    {
        K OpKind {get;}
    }


}