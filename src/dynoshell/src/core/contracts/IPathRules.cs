//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free =System.Security.SuppressUnmanagedCodeSecurityAttribute;


    [Free]
    public interface IFsPathRules<H>
        where H : struct, IFsPathRules<H>
    {
        FS.FolderPath Root {get;}

        H Update(FS.FolderPath root);
    }
}