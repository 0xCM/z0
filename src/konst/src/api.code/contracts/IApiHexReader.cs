//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IApiHexReader
    {
        Index<ApiCodeBlock> Read(FS.FilePath src);
    }
}