//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IApiHexReader : IArchiveReader
    {
        ApiHex[] Read(FilePath src);
    }

    public interface IApiHexReader<H> : IApiHexReader, IArchiveReader<H>
        where H : struct, IApiHexReader<H>
    {

    }

    public interface IApiHexReader<H,T> : IApiHexReader<H>, IArchiveReader<H>
        where T : struct, IEncoded<T>
        where H : struct, IApiHexReader<H,T>
    {

    }
}