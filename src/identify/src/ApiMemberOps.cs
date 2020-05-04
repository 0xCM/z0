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

    public readonly struct ApiMemberOps : IApiMemberOps
    {
        public static IApiMemberOps Service => default(ApiMemberOps);
    }

    public interface IApiMemberOps
    {
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