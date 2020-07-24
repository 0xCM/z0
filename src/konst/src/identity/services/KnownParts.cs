//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static Konst;
    using static PartId;
    
    public readonly struct KnownParts : IKnownParts
    {
        public static KnownParts Service => default;
        
        IPartResolver Resolver 
            => PartResolver.Service;

        public IPart[] Known
            => PartResolver.Service.Resolve(ComponentPaths);

        public FilePath[] ComponentPaths
            => SearchLocation.Files(FileExtensions.Dll)
                              .Include(nameof(Z0))                              
                              .Exclude(nameof(Test))
                              .Exclude(External.Select(x => x.Format()));

        public bool DefinesPart(FilePath src)
            => Resolver.DefinesPart(src);

        public Assembly[] Parts(FilePath[] src)
            => Resolver.Parts(src);

        public bool IsPart(Assembly src)
            => Resolver.IsPart(src);

        public Assembly[] Parts(Assembly[] src)
            => src.Where(IsPart);
        
        public PartDescription[] Descriptions
            => ComponentPaths.Select(p => new PartDescription(p));
        
        /// <summary>
        /// The location of potentially knowable parts
        /// </summary>
        public FolderPath SearchLocation 
            => FilePath.Define(Z0.Parts.Konst.Resolved.Owner.Location).FolderPath;

        /// <summary>
        /// External dependencies that don' participate in the componentization framework
        /// </summary>
        static ExternId[] External
            => z.type<ExternId>().LiteralValues<ExternId>().Where(x => x != 0);
    }
}