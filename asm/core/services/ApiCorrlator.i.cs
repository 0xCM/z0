//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface IApiCorrelator : IAsmService
    {
        IEnumerable<ApiStatelessMember> FindHostedMembers(in ApiHostUri host);

        ApiCodeIndex CreateApiIndex(ApiHostUri host, FilePath src);

        ApiCodeIndex CreateApiIndex(OpIndex<ApiStatelessMember> members, OpIndex<AsmOpBits> code);        
    }
}