//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class XTend
    {        
        /// <summary>
        /// Instantiates the api hosts found in a specified assembly
        /// </summary>
        /// <param name="src">The assembly to search</param>
        public static IEnumerable<IApiHost> ApiHosts(this Assembly src)
            => ApiHost.Hosts(src); 

        /// <summary>
        /// Searches an assembly for api host types
        /// </summary>
        /// <param name="src">The assembly to search</param>
        public static IEnumerable<Type> ApiHostTypes(this Assembly src)
            => ApiHost.HostTypes(src);

        public static OpIndex<UriBits> ToOpIndex(this IEnumerable<UriBits> src)
            => Identities.index(src.Select(x => (x.Op.OpId, x)));

        /// <summary>
        /// Creates an operation index
        /// </summary>
        /// <param name="src">The members to index</param>
        /// <typeparam name="M">The member type</typeparam>
        public static OpIndex<M> ToOpIndex<M>(this IEnumerable<M> src)
            where M : struct, IApiMember
                => Identities.index(src.Select(h => (h.Id, h)));

        /// <summary>
        /// Creates an operation index
        /// </summary>
        /// <param name="src">The members to index</param>
        /// <typeparam name="M">The member type</typeparam>
        public static OpIndex<M> ToOpIndex<M>(this ReadOnlySpan<M> src)
            where M : struct, IApiMember
                => Identities.index(src.MapArray(h => (h.Id, h)));

        /// <summary>
        /// Creates an operation index
        /// </summary>
        /// <param name="src">The members to index</param>
        /// <typeparam name="M">The member type</typeparam>
        public static OpIndex<M> ToOpIndex<M>(this Span<M> src)
            where M : struct, IApiMember            
               => src.ReadOnly().ToOpIndex();           


        /// <summary>
        /// Creates a (possibly empy) api catalog for the source part
        /// </summary>
        /// <param name="src">The part to catalog</param>
        public static IApiCatalog ApiCatalog(this IPart src)
            => ApiCatalogProvider.Catalog(src);

        /// <summary>
        /// Streams the catalogs defined by a composition
        /// </summary>
        /// <param name="src">The composition</param>
        public static IEnumerable<IApiCatalog> ApiCatalogs(this IApiComposition src)
            => src.Resolved.Select( r => r.ApiCatalog());    

        /// <summary>
        /// Searches the resolutions for an identified nonempy catalog
        /// </summary>
        /// <param name="id">The defining assembly</param>
        public static Option<IApiCatalog> FindCatalog(this IApiComposition src, PartId id)
        {
            var c = src.ApiCatalogs().Where(c => c.PartId == id).FirstOrDefault();
            if(c != null)
                return Option.some(c);
            else
                return Option.none<IApiCatalog>();
        }

        /// <summary>
        /// Defines a query service over a catalog
        /// </summary>
        /// <param name="src">The source catalog</param>
        [MethodImpl(Inline)]
        public static ApiQuery Query(this IApiCatalog src)
            => ApiQuery.Over(src);

        /// <summary>
        /// Creates an api set that includes the source composition
        /// </summary>
        /// <param name="src">The source composition</param>
        [MethodImpl(Inline)]
        public static IApiSet ApiSet(this IApiComposition src)
            => Z0.ApiSet.Create(src);                
    }
}