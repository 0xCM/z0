//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IX86UriHexReader : IArchiveReader
    {
        X86UriHex[] Read(FilePath src);
    }

    public interface IX86UriHexReader<H> : IX86UriHexReader, IArchiveReader<H>
        where H : struct, IX86UriHexReader<H>
    {

    }

    public interface IX86UriHexReader<H,T> : IX86UriHexReader<H>, IArchiveReader<H>
        where T : struct, IEncoded<T>
        where H : struct, IX86UriHexReader<H,T>
    {

    }
}