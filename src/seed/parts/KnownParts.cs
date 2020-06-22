//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static PartId;
    
    public readonly struct KnownParts : IKnownParts
    {
        public static KnownParts Service => default;
        
        public IEnumerable<IPart> Known
            => PartResolver.Service.Resolve(ComponentPaths);

        public IEnumerable<FilePath> ComponentPaths
            => SearchLocation.Files(FileExtensions.Dll)
                              .Include(nameof(Z0))                              
                              .Exclude(nameof(Test))
                              .Exclude(External.Select(x => x.Format()).ToArray());

        public IEnumerable<PartDescription> Descriptions
            => ComponentPaths.Select(p => new PartDescription(p));
        
        /// <summary>
        /// The location of potentially knowable parts
        /// </summary>
        public FolderPath SearchLocation 
            => FilePath.Define(Parts.Seed.Resolved.Owner.Location).FolderPath;

        /// <summary>
        /// External dependencies that don' participate in the componentization framework
        /// </summary>
        static ExternId[] External
            => Root.type<ExternId>().LiteralValues<ExternId>().Where(x => x != 0);
    }
}