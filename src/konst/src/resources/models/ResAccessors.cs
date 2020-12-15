//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ResAccessors : IConstSpan<ResAccessors,ApiMemberRes>
    {
        public readonly ApiMemberRes[] Accessors;

        [MethodImpl(Inline)]
        public static implicit operator ResAccessors(ApiMemberRes[] src)
            => new ResAccessors(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<ApiMemberRes>(ResAccessors src)
            => src.Accessors;

        [MethodImpl(Inline)]
        public ResAccessors(ApiMemberRes[] accessors)
            => Accessors = accessors;

        public ReadOnlySpan<ApiMemberRes> Data
        {
            [MethodImpl(Inline)]
            get => Accessors;
        }
    }
}