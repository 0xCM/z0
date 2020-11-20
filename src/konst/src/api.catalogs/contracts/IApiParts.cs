//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IApiParts
    {
        FS.FolderPath Source {get;}

        FS.Files ManagedSources {get;}

        Assembly[] Components {get;}

        ISystemApiCatalog Api {get;}
    }
}