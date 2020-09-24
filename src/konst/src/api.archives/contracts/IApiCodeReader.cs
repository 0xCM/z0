//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IApiCodeReader : IArchiveReader
    {
        ApiCodeBlock[] Read(FilePath src);
    }

    public interface IApiCodeReader<H> : IApiCodeReader, IArchiveReader<H>
        where H : struct, IApiCodeReader<H>
    {

    }
}