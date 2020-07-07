//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IApiIndexBuilder
    {
        ApiCodeIndex IndexCode(ApiHostUri uri, FilePath src);

        ApiCodeIndex CreateIndex(ApiIndex members, OpIndex<IdentifiedCode> code);
    }
}