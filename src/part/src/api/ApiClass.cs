//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiClass
    {
        readonly ApiClassKind Kind;

        [MethodImpl(Inline)]
        public ApiClass(ApiClassKind kind)
        {
            Kind = kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator ApiClass(ApiClassKind kind)
            => new ApiClass(kind);

        [MethodImpl(Inline)]
        public static implicit operator ApiClassKind(ApiClass src)
            => src.Kind;

        public string Format()
            => Kind.Format();
    }
}