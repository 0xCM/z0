//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ApiClass : ITextual
    {
        readonly ApiClassKind Kind;

        [MethodImpl(Inline)]
        public ApiClass(ApiClassKind kind)
            => Kind = kind;

        public string Format()
            => Kind.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ApiClass(ApiClassKind kind)
            => new ApiClass(kind);

        [MethodImpl(Inline)]
        public static implicit operator ApiClassKind(ApiClass src)
            => src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator ushort(ApiClass src)
            => (ushort)src.Kind;
    }
}