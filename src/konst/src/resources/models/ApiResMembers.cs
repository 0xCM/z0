//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiResMembers
    {
        public Type DeclaringType {get;}

        readonly Index<ApiMemberRes> Accessors;

        [MethodImpl(Inline)]
        public ApiResMembers(Type declaring, ApiMemberRes[] accessors)
        {
            DeclaringType = declaring;
            Accessors = accessors;
        }

        public ReadOnlySpan<ApiMemberRes> View
        {
            [MethodImpl(Inline)]
            get => Accessors;
        }
    }
}