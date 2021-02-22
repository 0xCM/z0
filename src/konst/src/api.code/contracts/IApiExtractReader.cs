//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IApiExtractReader : IArchiveReader
    {
        ApiExtractBlock[] Read(FS.FilePath src);
    }

    public interface IApiHexReader : IArchiveReader
    {
        Index<ApiCodeBlock> Read(FS.FilePath src);
    }
}