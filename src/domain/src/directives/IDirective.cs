//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    using api = Director;


    public interface IDirectiveKind
    {
        Type HostType {get;}

        Type KindType {get;}
    }

    public interface IDirectiveKind<K> : IDirectiveKind
        where K : unmanaged, IDirectiveKind<K>
    {
        K Kind {get;}

        Type IDirectiveKind.HostType
            => typeof(K);
    }

    public interface IDirectiveKind<H,K> : IDirectiveKind<K>
        where H : struct, IDirectiveKind<H,K>
        where K : unmanaged, IDirectiveKind<K>
    {
        Type IDirectiveKind.KindType
            => typeof(H);
    }

    public interface IDirective
    {
        Type KindType {get;}

        Type CommandType {get;}

        Type ResponseType {get;}

        Type HostType {get;}

        DirectiveIdentity Id
            => api.directive(HostType, KindType, CommandType, ResponseType);
    }

    public interface IDirective<C> : IDirective
        where C : struct
    {
        Type IDirective.CommandType => typeof(C);

        C Spec {get;}
    }

   public interface IDirective<K,C> : IDirective<C>
        where C : struct, IDirective<C>
        where K : unmanaged, IDirectiveKind<K>
    {
        Type IDirective.KindType => typeof(K);

    }

   public interface IDirective<K,C,R> : IDirective<K,C>
        where K : unmanaged, IDirectiveKind<K>
        where C : struct, IDirective<C>
        where R : struct
    {
        Type IDirective.ResponseType => typeof(R);

    }

   public interface IDirective<H,K,C,R> : IDirective<K,C,R>
        where H : struct, IDirective<H,K,C,R>
        where C : struct, IDirective<C>
        where K : unmanaged, IDirectiveKind<K>
        where R : struct
    {
        Type IDirective.HostType => typeof(R);
    }

}