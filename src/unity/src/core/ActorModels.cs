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

    /// <summary>
    /// State-agnostic actor archetype
    /// </summary>
    public struct Actor<K,C,R> : IActor<Actor<K,C,R>, K, C, R>
        where C : struct, IDirective<K, C, R>
        where K : unmanaged, IDirectiveKind<K>
        where R : struct
    {
        public R Run(C command)
            => throw new NotImplementedException();

        public Task<R> RunAsync(C command)
            => throw new NotImplementedException();
    }

    /// <summary>
    /// Stateless actor archetype
    /// </summary>
    public struct StatelessActor<K,C,R> : IStatelessActor<StatelessActor<K,C,R>,K,C,R>
        where C : struct, IDirective<K,C,R>
        where K : unmanaged, IDirectiveKind<K>
        where R : struct
     {
        public R Run(C command)
            => throw new NotImplementedException();

         public Task<R> RunAsync(C command)
            => throw new NotImplementedException();
     }

    /// <summary>
    /// Stateful actor archetype
    /// </summary>
    public struct StatefulActor<S,K,C,R> : IStatefulActor<StatefulActor<S,K,C,R>,S, K,C,R>
        where S : struct
        where C : struct, IDirective<K,C,R>
        where K : unmanaged, IDirectiveKind<K>
        where R : struct
    {
         public S State {get;set;}

         public R Run(C command)
            => throw new NotImplementedException();

         public Task<R> RunAsync(C command)
            => throw new NotImplementedException();
     }
}