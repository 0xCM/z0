//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    public static class FastOpX
    {
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
        public static IEnumerable<FastDirectInfo> FastOpDirect(this Type host)
            => FastOps.direct(host);

        public static IEnumerable<FastDirectInfo> FastOpDirect(this IEnumerable<Type> hosts)
            => FastOps.direct(hosts);
                
        /// <summary>
        /// Extracts fastop metadata from a host type for generic operations
        /// </summary>
        /// <param name="host">The source type</param>
        public static IEnumerable<FastGenericInfo> FastOpGenericMethods(this Type host) 
            => FastOps.generics(host);
                        
        public static IEnumerable<FastGenericInfo> FastOpGenericMethods(this IEnumerable<Type> hosts)
            => FastOps.generics(hosts);

        /// <summary>
        /// Closes generic operations over the set of primal types that each operation supports
        /// </summary>
        /// <param name="generics">Metadata for generic operations</param>
        public static IEnumerable<FastOpClosure> Closures(this FastGenericInfo op)
            => FastOps.closures(op);

        /// <summary>
        /// Determines whether a method is classified as a span op
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsSpanOp(this MethodInfo m)
            => FastOps.spanned(m);

        /// <summary>
        /// Determines whether a method is classified as a nat op
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsNatOp(this MethodInfo m)
            => FastOps.natural(m);
        
        /// <summary>
        /// Determines whether a method accepts and/or returns at least one memory block parameter
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBlocked(this MethodInfo m)
            => FastOps.blocked(m);        

    }
}
