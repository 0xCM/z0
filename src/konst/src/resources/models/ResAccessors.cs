//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ResAccessors
    {
        readonly ApiMemberRes[] Accessors;

        [MethodImpl(Inline)]
        public ResAccessors(ApiMemberRes[] accessors)
            => Accessors = accessors;

        public ApiMemberRes[] Storage
        {
            [MethodImpl(Inline)]
            get => Accessors;
        }

        public Span<ApiMemberRes> Edit
        {
            [MethodImpl(Inline)]
            get => Accessors;
        }

        public ReadOnlySpan<ApiMemberRes> View
        {
            [MethodImpl(Inline)]
            get => Accessors;
        }

        [MethodImpl(Inline)]
        public static implicit operator ResAccessors(ApiMemberRes[] src)
            => new ResAccessors(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<ApiMemberRes>(ResAccessors src)
            => src.Accessors;
    }
}