//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

    public readonly struct ApiMemberQuery : IApiMemberQuery
    {
        [MethodImpl(Inline)]
        public static IApiMemberQuery Create(ApiMembers members)
            => new ApiMemberQuery(members);

        [MethodImpl(Inline)]
        ApiMemberQuery(ApiMembers members)
        {
            this.Members = members;
        }
        
        public ApiMembers Members {get;}
    }

    partial class XTend
    {
        public static IApiMemberQuery Query(this ApiMembers src)        
            => ApiMemberQuery.Create(src);

        public static IApiMemberQuery Query(this IEnumerable<ApiMember> src)
            => ApiMemberQuery.Create(src.ToArray());
    }
}