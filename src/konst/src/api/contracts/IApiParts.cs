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

    public interface IApiParts
    {
        PartId[] PartIdentities {get;}

        Assembly[] Components {get;}

        IPartCatalog[] Catalogs {get;}

        IApiHost[] Hosts {get;}

        IApiHost[] OpHosts {get;}

        Option<IApiHost> FindHost(ApiHostUri uri);

        IEnumerable<IPartCatalog> MatchingCatalogs(params PartId[] parts);

        IEnumerable<IApiHost> DefinedHosts(params PartId[] parts);

    }
}