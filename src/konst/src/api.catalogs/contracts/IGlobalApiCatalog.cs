//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IGlobalApiCatalog
    {
        IPart[] Parts {get;}

        PartId[] PartIdentities {get;}

        Index<Assembly> PartComponents {get;}

        ApiPartCatalogs Catalogs {get;}

        IApiHost[] ApiHosts {get;}

        IApiHost[] OperationHosts {get;}

        Option<IApiHost> FindHost(ApiHostUri uri);

        Option<Assembly> FindComponent(PartId id);

        bool FindMethod(OpUri uri, out MethodInfo method);

        IEnumerable<IApiPartCatalog> PartCatalogs(params PartId[] parts);

        IEnumerable<IApiHost> PartHosts(params PartId[] parts);

        MethodInfo[] Operations {get;}
    }
}