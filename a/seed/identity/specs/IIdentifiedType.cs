//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Seed;

    public interface IIdentifiedType : IIdentifiedTarget
    {
        IdentityTargetKind IIdentifiedTarget.TargetKind => IdentityTargetKind.Type;
    }

   public interface IIdentifiedType<T> : IIdentifiedType, IIdentifiedTarget<T>
        where T : IIdentifiedType<T>, new()    
    {
        Func<string,T> Factory  => s => new T();
    }
}