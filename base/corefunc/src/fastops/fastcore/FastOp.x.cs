//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;

    using static zfunc;

    public static class FastOpX
    {
        public static Moniker DefaultIdentity(this MethodInfo m)
            => OpIdentity.Provider.Define(m);
                
        /// <summary>
        /// Determines whether a method defines a formalized operation
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsFastOp(this MethodInfo m)
            => FastOps.test(m);

        /// <summary>
        /// Selects the public members of a type that are identified as formalized operations
        /// </summary>
        /// <param name="host">The source type</param>
        public static IEnumerable<MethodInfo> FastOpMethods(this Type host)
            => FastOps.methods(host);
               
        /// <summary>
        /// Gets the name of a method to which to Op attribute is applied
        /// </summary>
        /// <param name="m">The source method</param>
        public static string FastOpName(this MethodInfo m)
            => FastOps.opname(m);

        /// <summary>
        /// Extracts fastop metadata from a host type for non-generic operations
        /// </summary>
        /// <param name="host">The source type</param>
        public static IEnumerable<DirectOpInfo> FastOpDirect(this Type host)
            => FastOps.direct(host);

        public static IEnumerable<DirectOpInfo> FastDirectOps(this IEnumerable<Type> hosts)
            => FastOps.direct(hosts);
                
        /// <summary>
        /// Extracts fastop metadata from a host type for generic operations
        /// </summary>
        /// <param name="host">The source type</param>
        public static IEnumerable<GenericOpInfo> FastOpGenericMethods(this Type host) 
            => FastOps.generics(host);
                        
        public static IEnumerable<GenericOpInfo> FastGenericOps(this IEnumerable<Type> hosts)
            => FastOps.generics(hosts);

        /// <summary>
        /// Closes generic operations over the set of primal types that each operation supports
        /// </summary>
        /// <param name="generics">Metadata for generic operations</param>
        public static IEnumerable<OpClosure> Closures(this GenericOpInfo op)
            => FastOps.closures(op);

        public static bool RequiresImmediate(this OpInfo src)
            => src.Method.RequiresImmediate();

        public static IEnumerable<GenericOpInfo> FindGenericOps(this IOperationCatalog src)
            => src.GenericApiHosts.FastGenericOps();

        public static IEnumerable<DirectOpInfo> FindDirectOps(this IOperationCatalog src)
            => src.GenericApiHosts.FastDirectOps();
    }
}
