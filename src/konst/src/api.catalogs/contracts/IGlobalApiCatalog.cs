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
    using static memory;

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

        Index<IApiPartCatalog> PartCatalogs(params PartId[] parts);

        Index<IApiHost> PartHosts(params PartId[] parts);

        MethodInfo[] Operations {get;}

        Index<IApiHost> FindHosts(ReadOnlySpan<ApiHostUri> src)
        {
            var dst = root.list<IApiHost>();
            var search = ApiHosts;
            var kSrc = src.Length;
            var kSearch = search.Length;
            for(var i=0; i<kSrc; i++)
            {
                var match = skip(src,i);
                if(match.IsEmpty)
                    root.@throw("I can't deal with empty uri's");

                for(var j=0; j<kSearch; j++)
                {
                    var candidate = skip(search,j);
                    if(candidate.Uri == match)
                    {
                        dst.Add(candidate);
                        break;
                    }
                }
            }
            return dst.ToArray();
        }
    }
}