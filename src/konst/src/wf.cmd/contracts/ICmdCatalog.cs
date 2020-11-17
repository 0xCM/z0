//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdCatalog
    {
        IWfShell Wf {get;}

        IFileDb Db => Wf.Db();
    }

    [Free]
    public interface ICmdCatalog<H> : ICmdCatalog
        where H : ICmdCatalog<H>, new()
    {

    }
}