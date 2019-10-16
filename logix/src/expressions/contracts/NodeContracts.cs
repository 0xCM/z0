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

    public interface INodeExpr : IExpr
    {

    }

    public interface INodeExpr<T> : IExpr<T>, INodeExpr
        where T : unmanaged
    {

    }

    public interface INodeExpr<T,E> : INodeExpr<T>
        where T : unmanaged
    {
        E[] Terms {get;}
    }

    public interface ILogicNodeExpr : ILogicOp, INodeExpr<Bit,ILogicOp>
    {
        
    }

    public interface ILogicNodeExpr<T> : IOpExpr<T>, INodeExpr<T, IOpExpr<T>>
        where T : unmanaged
    {
        

    }

}