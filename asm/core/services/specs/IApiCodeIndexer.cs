//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Collections.Generic;

    public interface IApiCodeIndexer : IService
    {
        ApiCodeIndex CreateIndex(ApiHostUri host, FilePath src);

        ApiCodeIndex CreateIndex(OpIndex<ApiMember> members, OpIndex<AsmOpBits> code);        
    }
}