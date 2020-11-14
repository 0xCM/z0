//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IToolDb
    {
        FS.FolderPath Storage {get;}
    }

    [Free]
    public interface IToolDb<H> : IToolDb
        where H : struct, IToolDb<H>
    {

    }
}