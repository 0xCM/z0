//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    public readonly struct ApiProvider : IApiProvider
    {
        public ApiParts Api {get;}

        public ApiParts Parts {get;}

        public PartId[] PartIdentities {get;}

        public Assembly[] Components {get;}

        [MethodImpl(Inline)]
        internal ApiProvider(ApiParts api)
        {
            Api = api;
            Parts = api;
            PartIdentities = Parts.Identifiers;
            Components = Parts.Components;
        }
    }
}