//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IApiIndexBuilder
    {
        ApiCodeIndex CreateIndex(ApiHostUri uri, FilePath src);

        ApiCodeIndex CreateIndex(ApiIndex members, OpIndex<UriHex> code);
    }
}