//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    using static zfunc;    
    
    using OP = OperationProvider;

    /// <summary>
    /// Characterizes, in dependency injection vernacular, composition roots
    /// </summary>
    public interface IAssemblyComposition
    {
        /// <summary>
        /// Specifies the collection of assemblies that reified contexts provide for consumption
        /// </summary>
        IAssemblyDesignator[] Resolved {get;}   

        /// <summary>
        /// Searches the resolutions for an identified assembly
        /// </summary>
        /// <param name="id">The defining assembly</param>
        Option<IAssemblyDesignator> FindAssembly(AssemblyId id)
            => Resolved.TryFind(r => r.Id == id);

        /// <summary>
        /// Searches the resolutions for an identified nonempy catalog
        /// </summary>
        /// <param name="id">The defining assembly</param>
        Option<IOperationCatalog> FindCatalog(AssemblyId id)
            => from a in FindAssembly(id)
                where !a.Catalog.IsEmpty
                select a.Catalog;
        
        IEnumerable<IOperationCatalog> Catalogs
            => from a in Resolved
                where !a.Catalog.IsEmpty
                select a.Catalog;
    }


    public readonly struct AssemblyComposition : IAssemblyComposition
    {
        public static IAssemblyComposition Empty => Define();

        public static AssemblyComposition Define(params IAssemblyDesignator[] resolved)
            => new AssemblyComposition(resolved);

        AssemblyComposition(IAssemblyDesignator[] resolved)
            => Resolved = resolved;

        public IAssemblyDesignator[] Resolved {get;}   

        public bool IsEmpty
            => Resolved.Length == 0;
    }


    partial class xfunc
    {
        /// <summary>
        /// Queries a composition for a specified operation provider
        /// </summary>
        /// <param name="src">The source composition</param>
        public static Option<IOperationProvider> OperationProvider(this IAssemblyComposition src, AssemblyId id)
            => from r in  src.Resolved.TryFind(x => x.Id == id)
                where !r.Catalog.IsEmpty
                select OP.Define(r.Id, r.DeclaringAssembly, r.Catalog);

        /// <summary>
        /// Queries a composition for supported operation providers
        /// </summary>
        /// <param name="src">The source composition</param>
        public static IEnumerable<IOperationProvider> OperationProviders(this IAssemblyComposition src)
            =>  from r in src.Resolved                
                where !r.Catalog.IsEmpty
                select OP.Define(r.Id, r.DeclaringAssembly, r.Catalog);

        /// <summary>
        /// Queries a composition for supported operation providers that are identified by a filter
        /// </summary>
        /// <param name="src">The source composition</param>
        /// <param name="filter">The filter criteria</param>
        public static IEnumerable<IOperationProvider> OperationProviders(this IAssemblyComposition src, IEnumerable<AssemblyId> filter)
            =>  from r in src.Resolved                
                where filter.Contains(r.Id) && !r.Catalog.IsEmpty
                select OP.Define(r.Id, r.DeclaringAssembly, r.Catalog);

    }
}