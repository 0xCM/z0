//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IApiIndexService : IService
    {
        ApiCodeBlockIndex CreateIndex();
    }
}