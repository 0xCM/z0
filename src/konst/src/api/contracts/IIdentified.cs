//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public interface IIdentifiedOp : IIdentification
    {
        IdentityTargetKind IIdentification.TargetKind
            => IdentityTargetKind.Method;
    }

    public interface IIdentifiedOp<T> : IIdentifiedOp, IIdentification<T>
        where T : IIdentifiedOp<T>, new()
    {
        Func<string,T> Factory  => s => new T();
    }

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