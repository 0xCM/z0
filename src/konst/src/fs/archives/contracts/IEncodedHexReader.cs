//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Collections.Generic;
    using System;

    public interface IEncodedHexReader : IArchiveReader
    {
        IdentifiedCode[] Read(FilePath src);
    }

    public interface IEncodedHexReader<H> : IEncodedHexReader, IArchiveReader<H>
        where H : struct, IEncodedHexReader<H>
    {

    }

    public interface IEncodedHexReader<H,T> : IEncodedHexReader<H>, IArchiveReader<H>
        where T : struct, IEncoded<T>
        where H : struct, IEncodedHexReader<H,T>
    {

    }
}