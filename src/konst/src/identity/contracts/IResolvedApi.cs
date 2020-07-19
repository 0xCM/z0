//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Characterizes, in dependency injection vernacular, composition roots
    /// </summary>
    public interface IResolvedApi : TApiReflected
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
        IPartCatalog[] Catalogs 
            => Resolved.Select(x => Catalog(x)).Where(c => c.IsIdentified);
    }
}