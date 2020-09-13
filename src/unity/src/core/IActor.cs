//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;

    using static Konst;
    using static z;

    using api = Director;

    public interface IActor
    {
        Type KindType {get;}

        Type CommandType {get;}

        Type ResponseType {get;}

        Type HostType {get;}

        ActorIdentity Id
            => api.actor(HostType, KindType, CommandType, ResponseType);
    }

    public interface IActor<K,C,R> : IActor
        where C : struct, IDirective<K,C,R>
        where K : unmanaged, IDirectiveKind<K>
        where R : struct
    {

        Type IActor.KindType
            => typeof(K);

        Type IActor.CommandType
            => typeof(C);

        Type IActor.ResponseType
            => typeof(R);

        R Run(C command);

        Task<R> RunAsync(C command);
    }

    public interface IActor<H,K,C,R> : IActor<K,C,R>
        where H : struct, IActor<H,K,C,R>
        where C : struct, IDirective<K,C,R>
        where K : unmanaged, IDirectiveKind<K>
        where R : struct
    {
        Type IActor.HostType => typeof(H);
    }

    public interface IStatelessActor<K,C,R> : IActor<K,C,R>
        where C : struct, IDirective<K,C,R>
        where K : unmanaged, IDirectiveKind<K>
        where R : struct
    {

    }

    public interface IStatelessActor<H,K,C,R> : IStatelessActor<K,C,R>, IActor<H,K,C,R>
        where H : struct, IStatelessActor<H,K,C,R>
        where C : struct, IDirective<K,C,R>
        where K : unmanaged, IDirectiveKind<K>
        where R : struct
    {

    }

    public interface IStatefulActor<S,K,C,R> : IActor<K,C,R>
        where S : struct
        where C : struct, IDirective<K,C,R>
        where K : unmanaged, IDirectiveKind<K>
        where R : struct
    {
        S State {get; set;}
    }


    public interface IStatefulActor<H,S,K,C,R> : IStatefulActor<S,K,C,R>, IActor<H,K,C,R>
        where H : struct, IStatefulActor<H,S,K,C,R>
        where S : struct
        where C : struct, IDirective<K,C,R>
        where K : unmanaged, IDirectiveKind<K>
        where R : struct
    {

    }
}