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

    public readonly struct ApiParts : IApiSet
    {
        /// <summary>
        /// The members of the compostion
        /// </summary>
        public readonly IPart[] Storage;

        public static implicit operator ApiParts(IPart[] src)
            => new ApiParts(src);

        public static implicit operator IPart[](ApiParts src)
            => src.Storage;

        [MethodImpl(Inline)]
        public ApiParts(params IPart[] parts)
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

        public ApiParts Parts
            => this;

        public PartId[] PartIdentities
            => Storage.Select(x => x.Id);

        public ResolvedApi Composition
            => this;

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