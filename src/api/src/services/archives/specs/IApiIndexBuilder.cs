//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Collections.Generic;

    public interface IApiIndexBuilder : IService
    {
        ApiCodeIndex CreateIndex(ApiHostUri host, FilePath src);

        ApiCodeIndex CreateIndex(ApiIndex members, OpIndex<UriBits> code);        
    }
}