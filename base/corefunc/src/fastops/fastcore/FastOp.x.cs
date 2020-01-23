//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;

    public static class FastOpX
    {
        /// <summary>
        /// Extracts fastop metadata from a host type for non-generic operations
        /// </summary>
        /// <param name="host">The source type</param>
        public static IEnumerable<DirectOpSpec> FastDirectOps(this Type host)
            => FastOps.direct(host);

        /// <summary>
        /// Extracts fastop metadata from an arbitrary number of host types for non-generic operations
        /// </summary>
        /// <param name="host">The source type</param>
        public static IEnumerable<DirectOpSpec> FastDirectOps(this IEnumerable<Type> hosts)
            => FastOps.direct(hosts);
                
        /// <summary>
        /// Extracts fastop metadata from a host type for generic operations
        /// </summary>
        /// <param name="host">The source type</param>
        public static IEnumerable<GenericOpSpec> FastGenericOps(this Type host) 
            => FastOps.generics(host);
                        
        /// <summary>
        /// Extracts fastop metadata from an arbitrary number of host types for generic operations
        /// </summary>
        /// <param name="host">The source type</param>
        public static IEnumerable<GenericOpSpec> FastGenericOps(this IEnumerable<Type> hosts)
            => FastOps.generics(hosts);

        /// <summary>
        /// Closes generic operations over the set of primal types that each operation supports
        /// </summary>
        /// <param name="generics">Metadata for generic operations</param>
        public static IEnumerable<OpClosureSpec> Closures(this GenericOpSpec op)
            => FastOps.closures(op);

        public static bool RequiresImmediate(this OpSpec src)
            => FunctionType.immrequired(src.Method);

    }


}
