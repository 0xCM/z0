//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Concurrent;

    using static Konst;
    using static z;

    [ApiHost]
    public ref struct Director
    {
        IWfShell Wf;

        WfStepId Id;

        readonly ConcurrentDictionary<ulong, object> StatelessActors;

        readonly ConcurrentDictionary<ulong, object> StatefulActors;

        public Director(IWfShell wf)
        {
            Wf = wf;
            Id = typeof(Director);
            StatelessActors = new ConcurrentDictionary<ulong, object>();
            StatefulActors = new ConcurrentDictionary<ulong, object>();
            Wf.Created(Id);
        }

        public void Dispose()
        {
            Wf.Disposed(Id);
        }

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        static ClrArtifactKey identify<T>()
            => typeof(T).MetadataToken;

        [MethodImpl(Inline), Op]
        static ClrArtifactKey identify(Type t)
            => t.MetadataToken;

        [MethodImpl(Inline), Op]
        public static DirectiveIdentity directive(Type host, Type kind, Type command, Type response)
            => quad(identify(host), identify(kind), identify(command), identify(response));

        [MethodImpl(Inline), Op]
        public static ActorIdentity actor(Type host, Type kind, Type command, Type response)
            => quad(identify(host), identify(kind), identify(command), identify(response));

        [MethodImpl(Inline), Op]
        public static KindIdentity kind(Type host, Type kind)
            => pair(identify(host), identify(kind));

        [MethodImpl(Inline)]
        public static KindIdentity kind<H,K>()
            => pair(identify<H>(),identify<K>());

        [MethodImpl(Inline)]
        public static DirectiveIdentity directive<H,K,C,R>()
            => quad(identify<H>(),identify<K>(),identify<C>(),identify<R>());

        [MethodImpl(Inline)]
        public static ActorIdentity actor<H,K,C,R>()
            => quad(identify<H>(),identify<K>(),identify<C>(),identify<R>());

        [MethodImpl(Inline)]
        public static ActorProxy<H,K,C,R> actor<H,K,C,R>(H host, K k = default, C c = default, R r = default)
            where H : struct, IStatelessActor<H,K,C,R>
            where C : struct, IDirective<K,C,R>
            where K : unmanaged, IDirectiveKind<K>
            where R : struct
                => new ActorProxy<H, K, C, R>(host);

        [MethodImpl(Inline)]
        public static ActorProxy<H,S,K,C,R> actor<H,S,K,C,R>(H host, K k = default, S s = default, C c = default, R r = default)
            where H : struct, IStatefulActor<H,S,K,C,R>
            where S : struct
            where C : struct, IDirective<K,C,R>
            where K : unmanaged, IDirectiveKind<K>
            where R : struct
                => new ActorProxy<H,S,K,C,R>(host);

        public R Dispatch<H,C,K,R>(H command)
            where H : struct, IStatelessActor<H,K,C,R>
            where C : struct, IDirective<K,C,R>
            where K : unmanaged, IDirectiveKind<K>
            where R : struct
        {

            return default;
        }

        public R Dispatch<H,S,C,K,R>(H command, S state)
            where H : struct, IStatefulActor<H,S,K,C,R>
            where S : struct
            where C : struct, IDirective<K,C,R>
            where K : unmanaged, IDirectiveKind<K>
            where R : struct
        {

            return default;
        }
    }
}