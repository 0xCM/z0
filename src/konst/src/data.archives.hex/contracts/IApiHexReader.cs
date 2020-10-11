//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IApiHexReader : IArchiveReader
    {
        ApiCodeBlock[] Read(FilePath src);

        ApiCodeBlock[] Read(FS.FilePath src)
            => Read(FilePath.Define(src.Name));

    }

    public interface IApiHexReader<H> : IApiHexReader, IArchiveReader<H>
        where H : struct, IApiHexReader<H>
    {

    }
}