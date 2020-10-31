//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    using api = ApiCatalogs;

    public readonly struct MemberLocator : IApiMemberLocator
    {
        public static MemberLocator Service
            => default;

        public static ApiHostCatalog locate(IApiHost src)
            => api.members(src);

        public ApiHostCatalog Locate(IApiHost src)
            => api.members(src);
    }
}