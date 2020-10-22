//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IFileArchive : IFileArchiveQueries
    {

    }

    [Free]
    public interface IFileArchive<H> : IFileArchive
        where H : IFileArchive<H>
    {

    }
}