//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IIdentfiedOp : IIdentification
    {
        IdentityTargetKind IIdentification.TargetKind 
            => IdentityTargetKind.Method;
    }
    
    public interface IIdentifedOp<T> : IIdentfiedOp, IIdentification<T>
        where T : IIdentifedOp<T>, new()    
    {
        Func<string,T> Factory  => s => new T();
    }
}