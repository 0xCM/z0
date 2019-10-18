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

    public interface ILogicNodeExpr : ILogicOp, INodeExpr<Bit,ILogicOp>
    {
        
    }

    public interface ILogicNodeExpr<T> : IOpExpr<T>, INodeExpr<T, IOpExpr<T>>
        where T : unmanaged
    {
        

    }

}