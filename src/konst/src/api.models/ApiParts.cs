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
    using System.Collections.Generic;

    using static Konst;

    /// <summary>
    /// Covers a collection of parts and related api metadata
    /// </summary>
    public readonly struct ApiParts : IApiParts
    {
        /// <summary>
        /// The members of the compostion
        /// </summary>
        public IPart[] Storage {get;}

        public Assembly[] Components {get;}

        public PartId[] Identifiers {get;}

        public IPartCatalog[] Catalogs {get;}

        public IApiHost[] Hosts {get;}

        public IApiHost[] OpHosts {get;}

        public PartId[] PartIdentities {get;}

        public static implicit operator ApiParts(IPart[] src)
            => new ApiParts(src);

        public static implicit operator IPart[](ApiParts src)
            => src.Storage;

        [MethodImpl(Inline)]
        public ApiParts(params IPart[] parts)
        {
            Storage = parts;
            Identifiers = Storage.Select(p => p.Id);
            Components = Storage.Select(p => p.Owner);
            Catalogs = Storage.Select(x => ApiQuery.catalog(x) as IPartCatalog).Where(c => c.IsIdentified);
            Hosts = Catalogs.SelectMany(c => c.ApiHosts);
            OpHosts = Catalogs.SelectMany(c => c.Operations).Cast<IApiHost>().Array();
            PartIdentities = Storage.Select(x => x.Id);
        }

        public Count32 Count
        {
            [MethodImpl(Inline)]
            get => Storage.Length;
        }


        public ApiParts Parts
            => this;

        public Option<IApiHost> FindHost(ApiHostUri uri)
            => z.option(Hosts.Where(h => h.Uri == uri).FirstOrDefault());

        public IEnumerable<IPartCatalog> MatchingCatalogs(params PartId[] parts)
        {
            if(parts.Length == 0)
                return Catalogs;
            else
                return from c in Catalogs
                       where parts.Contains(c.PartId)
                       select c;
        }

        public IEnumerable<IApiHost> DefinedHosts(params PartId[] parts)
        {
            if(parts.Length == 0)
                return Hosts;
            else
                return  from h in Hosts
                        where parts.Contains(h.PartId)
                        select h;
        }
    }
}