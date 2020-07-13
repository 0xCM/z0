//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    /// <summary>
    /// Characterizes, in dependency injection vernacular, composition roots
    /// </summary>
    public interface IResolvedApi : IApiReflected
    {
        /// <summary>
        /// The resolved assemblies that comprise the composition
        /// </summary>
        IPart[] Resolved {get;}   

        Assembly[] Assemblies
            => Resolved.Select(x => x.Owner);
        
        /// <summary>
        /// The catalogs defined by the composed parts
        /// </summary>
        IEnumerable<IPartCatalog> Catalogs 
            => from part in Resolved
                let c = Catalog(part)
                where c.IsIdentified 
                select c;

        /// <summary>
        /// Searches for a part-identified, and returns a valued option if found
        /// </summary>
        /// <param name="id">The part id</param>
        Option<IPartCatalog> FindCatalog(PartId id)
        {
            var c = Catalogs.Where(c => c.PartId == id).FirstOrDefault();
            if(c != null)
                return Option.some(c);
            else
                return Option.none<IPartCatalog>();
        }
    }
}