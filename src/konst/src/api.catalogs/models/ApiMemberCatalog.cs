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

    public interface  IApiMemberCatalog
    {

    }

    public readonly struct ApiMemberCatalog : IApiMemberCatalog
    {
        readonly TableSpan<ApiMember> _Members;

        [MethodImpl(Inline)]
        public ApiMemberCatalog(ApiMember[] src)
        {
            _Members = src;
        }

        public ReadOnlySpan<ApiMember> Members
        {
            [MethodImpl(Inline)]
            get => _Members.View;
        }
    }
}