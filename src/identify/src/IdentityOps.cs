//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static Seed;

    public readonly struct Operational : IOperational
    {
        public static IOperational Service => default(Operational);
    }

    public interface IOperational : IOperationalBits
    {
        /// <summary>
        /// Creates a (possibly empy) api catalog for a specified part
        /// </summary>
        /// <param name="src">The source part</param>
        IApiCatalog Catalog(IPart src)
            => new ApiCatalogProvider(src.Id, src.Owner, new ApiCatalog(src.Owner, src.Id, src.ResourceProvider));

        /// <summary>
        /// Instantiates the api hosts found in a specified assembly
        /// </summary>
        /// <param name="src">The assembly to search</param>
        IEnumerable<IApiHost> ApiHosts(Assembly src)
            => ApiHost.Hosts(src); 

        /// <summary>
        /// Searches an assembly for api host types
        /// </summary>
        /// <param name="src">The assembly to search</param>
        IEnumerable<Type> ApiHostTypes(Assembly src)
            => ApiHost.HostTypes(src);

        /// <summary>
        /// Creates an operation index from a uri bitstream
        /// </summary>
        /// <param name="src">The source bits</param>
        OpIndex<UriBits> CreateIndex(IEnumerable<UriBits> src)
            => Identify.index(src.Select(x => (x.Op.OpId, x)));

        /// <summary>
        /// Creates an operation index from an api member stream
        /// </summary>
        /// <param name="src">The members to index</param>
        /// <typeparam name="M">The member type</typeparam>
        OpIndex<M> CreateIndex<M>(IEnumerable<M> src)
            where M : struct, IApiMember
                => Identify.index(src.Select(h => (h.Id, h)));

        /// <summary>
        /// Creates an operation index from an api member span, readonly that is
        /// </summary>
        /// <param name="src">The members to index</param>
        /// <typeparam name="M">The member type</typeparam>
        OpIndex<M> CreateIndex<M>(ReadOnlySpan<M> src)
            where M : struct, IApiMember
                => Identify.index(src.MapArray(h => (h.Id, h)));               

        /// <summary>
        /// Creates an operation index from an api member span
        /// </summary>
        /// <param name="src">The members to index</param>
        /// <typeparam name="M">The member type</typeparam>
        OpIndex<M> CreateIndex<M>(Span<M> src)
            where M : struct, IApiMember            
               => CreateIndex(src.ReadOnly());
    }
}