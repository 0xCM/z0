//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Composes the data needed to identify and launch an actor
    /// </summary>
    public readonly struct Directive<K,C,R> : IDirective<Directive<K,C,R>,K,C,R>
        where C : struct, IDirective<K,C,R>
        where K : unmanaged, IDirectiveKind<K>
        where R : struct
    {
        public K Kind {get;}

        public C Spec {get;}

        public DirectiveIdentity Id {get;}

        [MethodImpl(Inline)]
        public Directive(DirectiveIdentity id, K kind, C spec)
        {
            Kind = kind;
            Spec = spec;
            Id = id;
        }
    }
}