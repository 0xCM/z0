//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public static partial class XSvc
    {
        public static ApiMemberExtractor MemberExtractor(this IWfRuntime wf)
            => new ApiMemberExtractor(Pow2.T14 + Pow2.T08);
    }
}