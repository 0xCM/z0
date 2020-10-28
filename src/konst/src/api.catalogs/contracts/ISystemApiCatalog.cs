//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;

    using static Konst;

    public interface ISystemApiCatalog
    {
        IPart[] Parts {get;}

        PartId[] PartIdentities {get;}

        Assembly[] Components {get;}

        ApiPartCatalogs Catalogs {get;}

        IApiHost[] ApiHosts {get;}

        IApiHost[] OperationHosts {get;}

        Option<IApiHost> FindHost(ApiHostUri uri);

        IEnumerable<IApiPartCatalog> PartCatalogs(params PartId[] parts);

        IEnumerable<IApiHost> PartHosts(params PartId[] parts);

        /// <summary>
        /// The host-defined operations
        /// </summary>
        MethodInfo[] Operations {get;}
    }
}