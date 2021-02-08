//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IApiHexReader : IArchiveReader
    {
        ApiCodeBlock[] Read(FS.FilePath src);
    }
}