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

    public readonly struct ResourceAccessors : IConstSpan<ResourceAccessors,ApiResource>
    {
        public readonly ApiResource[] Accessors;

        [MethodImpl(Inline)]
        public static implicit operator ResourceAccessors(ApiResource[] src)
            => new ResourceAccessors(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<ApiResource>(ResourceAccessors src)
            => src.Accessors;

        [MethodImpl(Inline)]
        public ResourceAccessors(ApiResource[] accessors)
            => Accessors = accessors;

        public ReadOnlySpan<ApiResource> Data
        {
            [MethodImpl(Inline)]
            get => Accessors;
        }
    }
}