//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IIdentifiedType : IIdentification
    {
        IdentityTargetKind IIdentification.TargetKind 
            => IdentityTargetKind.Type;
    }

   public interface IIdentifiedType<T> : IIdentifiedType, IIdentification<T>
        where T : IIdentifiedType<T>, new()    
    {
        Func<string,T> Factory  => s => new T();
    }
}