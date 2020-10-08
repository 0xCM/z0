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

    public readonly struct ApiMemberIdentifier : IIdentifier<ApiMemberIdentifier, StringRef>
    {
        public StringRef Identifier {get;}

        [MethodImpl(Inline)]
        public ApiMemberIdentifier(string src)
            => Identifier = string.Intern(src ?? EmptyString);

        [MethodImpl(Inline)]
        public string Format()
            => Identifier;

        [MethodImpl(Inline)]
        public static implicit operator ApiMemberIdentifier(string src)
            => new ApiMemberIdentifier(src);
    }
}