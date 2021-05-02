//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using static Part;
    using static memory;

    public class ApiRuntimeCatalog : IApiCatalog
    {
        /// <summary>
        /// The parts included in the datset
        /// </summary>
        IPart[] _Parts;

        /// <summary>
        /// The dataset part identities
        /// </summary>
        PartId[] _PartIdentities;

        /// <summary>
        /// The part components included in the datset
        /// </summary>
        Index<Assembly> _PartComponents;

        /// <summary>
        /// The catalogs corresponding to each datset part
        /// </summary>
        ApiPartCatalogs _Catalogs;

        /// <summary>
        /// The hosts provided by the dataset parts
        /// </summary>
        IApiHost[] _ApiHosts;

        /// <summary>
        /// The operations provided by the datset hosts
        /// </summary>
        MethodInfo[] _Operations;

        public ReadOnlySpan<IPart> Parts
        {
            [MethodImpl(Inline)]
            get => _Parts;
        }

        public Index<Assembly> Components
        {
            [MethodImpl(Inline)]
            get => _PartComponents;
        }

        public ReadOnlySpan<PartId> PartIdentites
        {
            [MethodImpl(Inline)]
            get => _PartIdentities;
        }

        public ReadOnlySpan<IApiHost> ApiHosts
        {
            [MethodImpl(Inline)]
            get => _ApiHosts;
        }

        public ReadOnlySpan<MethodInfo> Methods
        {
            [MethodImpl(Inline)]
            get => _Operations;
        }

        IPart[] IApiCatalog.Parts
            => _Parts;

        PartId[] IApiCatalog.PartIdentities
            => _PartIdentities;

        ApiPartCatalogs IApiCatalog.Catalogs
            => _Catalogs;

        IApiHost[] IApiCatalog.ApiHosts
            => _ApiHosts;


        public ApiRuntimeCatalog(Index<IPart> parts, Index<Assembly> components, ApiPartCatalogs catalogs, Index<IApiHost> hosts, Index<PartId> partIds, Index<MethodInfo> ops)
        {
            _Parts = parts;
            _PartComponents = components;
            _Catalogs = catalogs;
            _ApiHosts = hosts;
            _PartIdentities = partIds;
            _Operations = ops;
        }

        public Index<IApiHost> FindHosts(ReadOnlySpan<ApiHostUri> src)
        {
            var dst = root.list<IApiHost>();
            var search = _ApiHosts;
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
                    if(candidate.HostUri == match)
                    {
                        dst.Add(candidate);
                        break;
                    }
                }
            }
            return dst.ToArray();
        }

        public Option<Assembly> FindComponent(PartId id)
            => _PartComponents.Where(c => c.Id() == id).FirstOrDefault();

        public Option<IApiHost> FindHost(ApiHostUri uri)
            => root.option(_ApiHosts.Where(h => h.HostUri == uri).FirstOrDefault());

        bool FindHost(ApiHostUri uri, out IApiHost host)
        {
            host = _ApiHosts.Where(h => h.HostUri == uri).FirstOrDefault();
            return host != null;
        }

        public bool FindMethod(OpUri uri, out MethodInfo method)
        {
            if(FindHost(uri.Host, out var host))
                return host.FindMethod(uri, out method);
            method = default;
            return false;
        }

        public Index<IApiPartCatalog> PartCatalogs(params PartId[] parts)
        {
            if(parts.Length == 0)
                return _Catalogs.Storage;
            else
                return from c in _Catalogs.Storage
                       where parts.Contains(c.PartId)
                       select c;
        }

        public Index<IApiHost> PartHosts(params PartId[] parts)
        {
            if(parts.Length == 0)
                return _ApiHosts;
            else
                return  from h in _ApiHosts
                        where parts.Contains(h.PartId)
                        select h;
        }
    }
}