//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public interface IApiCatalogQueries
    {
    }

    [Free]
    public interface IApiRuntimeCatalog
    {
        Option<IApiHost> FindHost(ApiHostUri uri);

        Option<Assembly> FindComponent(PartId id);

        bool FindMethod(OpUri uri, out MethodInfo method);

        Index<IApiPartCatalog> PartCatalogs(params PartId[] parts);

        Index<IApiHost> PartHosts(params PartId[] parts);

        Index<IApiHost> FindHosts(ReadOnlySpan<ApiHostUri> src);

        IPart[] Parts {get;}

        PartId[] PartIdentities {get;}

        Index<Assembly> Components {get;}

        ApiPartCatalogs Catalogs {get;}

        IApiHost[] ApiHosts {get;}

        ReadOnlySpan<MethodInfo> Methods {get;}
    }
}