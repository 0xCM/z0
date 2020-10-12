//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    /// <summary>
    /// stateless actor proxy
    /// </summary>
    public struct ActorProxy<H,K,C,R> : IStatelessActor<H,K,C,R>
        where H : struct, IStatelessActor<H,K,C,R>
        where C : struct, IDirective<K,C,R>
        where K : unmanaged, IDirectiveKind<K>
        where R : struct
   {
        H Host;

        public ActorProxy(H host)
            => Host = host;

        [MethodImpl(Inline)]
        public R Run(C command)
            => Host.Run(command);

        [MethodImpl(Inline)]
        public Task<R> RunAsync(C command)
            => Host.RunAsync(command);
     }

    /// <summary>
    /// Stateful actor proxy
    /// </summary>
    public struct ActorProxy<H,S,K,C,R> : IStatefulActor<H,S,K,C,R>
        where H : struct, IStatefulActor<H,S,K,C,R>
        where S : struct
        where C : struct, IDirective<K,C,R>
        where K : unmanaged, IDirectiveKind<K>
        where R : struct
   {
        H Host;

        public ActorProxy(H host)
            => Host = host;

        public S State
        {
            [MethodImpl(Inline)]
            get => Host.State;

            [MethodImpl(Inline)]
            set => Host.State = value;
        }

        [MethodImpl(Inline)]
        public R Run(C command)
            => Host.Run(command);

        [MethodImpl(Inline)]
        public Task<R> RunAsync(C command)
            => Host.RunAsync(command);
     }
}