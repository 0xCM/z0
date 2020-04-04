//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IIdentfiedOp : IIdentifiedTarget
    {
        IdentityTargetKind IIdentifiedTarget.TargetKind => IdentityTargetKind.Method;
    }
    
    public interface IIdentifedOp<T> : IIdentfiedOp, IIdentifiedTarget<T>
        where T : IIdentifedOp<T>, new()    
    {
        Func<string,T> Factory  => s => new T();
    }
}