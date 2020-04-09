//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Collections.Generic;

    public interface IApiCorrelator : IService
    {
        IEnumerable<ApiMember> FindHostedMembers(in ApiHostUri host);

        ApiCodeIndex CreateApiIndex(ApiHostUri host, FilePath src);

        ApiCodeIndex CreateApiIndex(OpIndex<ApiMember> members, OpIndex<AsmOpBits> code);        
    }
}