//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static memory;

    partial struct ApiQuery
    {
        public static ApiGroupNG[] ImmDirect(IApiHost host, RefinementClass kind)
            => from g in direct(host)
                let imm = ImmGroup(host, g, kind)
                where !imm.IsEmpty
                select g;

    }
}