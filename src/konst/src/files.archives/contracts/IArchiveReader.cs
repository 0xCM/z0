//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IArchiveReader
    {

    }

    [Free]
    public interface IArchiveReader<H> : IArchiveReader
        where H : struct, IArchiveReader<H>
    {

    }
}