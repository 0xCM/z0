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

    public readonly struct ApiSet : IApiSet
    {
        /// <summary>
        /// The members of the compostion
        /// </summary>
        public readonly IPart[] Storage;

        public static implicit operator ApiSet(IPart[] src)
            => new ApiSet(src);

        public static implicit operator IPart[](ApiSet src)
            => src.Storage;

        [MethodImpl(Inline)]
        public ApiSet(params IPart[] parts)
            => Storage = parts;

        public Count32 Count
        {
            [MethodImpl(Inline)]
            get => Storage.Length;
        }

        public ReadOnlySpan<IPart> View
        {
            [MethodImpl(Inline)]
            get => Storage;
        }

        public Assembly[] Components
        {
            [MethodImpl(Inline)]
            get => Storage.Select(p => p.Owner);
        }

        public PartId[] Identifiers
        {
            [MethodImpl(Inline)]
            get => Storage.Select(p =>p.Id);
        }

        public IPartCatalog[] Catalogs
        {
            [MethodImpl(Inline)]
            get => Storage.Select(x => ApiQuery.catalog(x) as IPartCatalog).Where(c => c.IsIdentified);
        }

        public IApiHost[] Hosts
        {
            [MethodImpl(Inline)]
            get => Catalogs.SelectMany(c => c.ApiHosts);
        }

        public IApiHost[] DataTypes
        {
            [MethodImpl(Inline)]
            get => Catalogs.SelectMany(c => c.ApiDataTypes).Cast<IApiHost>().Array();
        }

        public IApiHost[] OpHosts
        {
            [MethodImpl(Inline)]
            get => Catalogs.SelectMany(c => c.Operations).Cast<IApiHost>().Array();
        }

        public ApiSet Parts
            => this;

        public PartId[] PartIdentities
            => Storage.Select(x => x.Id);

        public ResolvedApi Composition
            => this;

        public ApiSet Api
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