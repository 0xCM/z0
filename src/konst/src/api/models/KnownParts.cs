//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Konst;
    using static PartId;

    public readonly struct KnownParts
    {
        public static KnownParts Service
            => new KnownParts(FilePath.Define(Z0.Parts.Konst.Resolved.Owner.Location).FolderPath);

        public FolderPath SearchLocation {get;}

        public readonly FilePath[] ComponentPaths;

        public readonly IPart[] Known;

        public readonly Assembly[] Assemblies;

        KnownParts(FolderPath root)
        {
            var resolver = PartResolver.Service;
            SearchLocation = root;
            ComponentPaths = SearchLocation.Files(FileExtensions.Dll)
                              .Include(nameof(Z0))
                              .Exclude(nameof(Test))
                              .Exclude(External.Select(x => x.Format()));
            Known = resolver.Resolve(ComponentPaths);
            Assemblies = resolver.Parts(ComponentPaths);
        }

        /// <summary>
        /// External dependencies
        /// </summary>
        static ExternId[] External
            => z.type<ExternId>().LiteralValues<ExternId>().Where(x => x != 0);
    }
}