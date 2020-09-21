//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static z;
    using static Konst;


    public readonly struct ApiOpSig : IApiOpSig<ApiOpSig>
    {
        public ArtifactIdentifier Host {get;}
    }

    public readonly struct ApiOpSig<S> : IApiOpSig<ApiOpSig<S>>
    {
        public ArtifactIdentifier Host {get;}
    }

    public readonly struct ApiOpSig<K,T0>
    {

    }

    public readonly struct ApiOpSig<K,T0,T1>
    {

    }

}