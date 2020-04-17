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

    using static Seed;

    partial class XTend
    {
        public static OpIndex<UriBits> ToOpIndex(this IEnumerable<UriBits> src)
            => Identify.index(src.Select(x => (x.Op.OpId, x)));

        /// <summary>
        /// Creates an operation index
        /// </summary>
        /// <param name="src">The members to index</param>
        /// <typeparam name="M">The member type</typeparam>
        public static OpIndex<M> ToOpIndex<M>(this IEnumerable<M> src)
            where M : struct, IApiMember
                => Identify.index(src.Select(h => (h.Id, h)));

        /// <summary>
        /// Creates an operation index
        /// </summary>
        /// <param name="src">The members to index</param>
        /// <typeparam name="M">The member type</typeparam>
        public static OpIndex<M> ToOpIndex<M>(this ReadOnlySpan<M> src)
            where M : struct, IApiMember
                => Identify.index(src.MapArray(h => (h.Id, h)));

        /// <summary>
        /// Creates an operation index
        /// </summary>
        /// <param name="src">The members to index</param>
        /// <typeparam name="M">The member type</typeparam>
        public static OpIndex<M> ToOpIndex<M>(this Span<M> src)
            where M : struct, IApiMember            
               => src.ReadOnly().ToOpIndex();
    }
}