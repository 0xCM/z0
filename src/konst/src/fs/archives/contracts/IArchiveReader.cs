//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IArchiveReader
    {

    }

    public interface IArchiveReader<H> : IArchiveReader
        where H : struct, IArchiveReader<H>
    {

    }

    public interface IArchiveReader<H,T> : IArchiveReader<H>
        where H : struct, IArchiveReader<H,T>
    {

    }
}