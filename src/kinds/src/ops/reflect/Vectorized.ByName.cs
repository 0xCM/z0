//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;
 
    partial class XTend
    {
       /// <summary>
        /// Selects nongeneric source methods with a specified name that have at least one 128-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, W128 w, string name)
            => src.NonGeneric().WithName(name).WithParameter(p => p.IsClosedVector(w));

        /// <summary>
        /// Selects open generic source methods with a specified name that have at least one 128-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedGeneric(this IEnumerable<MethodInfo> src, W128 w, string name)
            => src.OpenGeneric().WithName(name).Where(m => m.IsVectorized(w));


        /// <summary>
        /// Selects nongeneric source methods with a specified name that have at least one 256-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, W256 w, string name)
            => src.NonGeneric().WithName(name).WithParameter(p => p.IsClosedVector(w));

        /// <summary>
        /// Selects open generic source methods with a specified name that have at least one 256-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedGeneric(this IEnumerable<MethodInfo> src, W256 w, string name)
            => src.OpenGeneric().WithName(name).Where(m => m.IsVectorized(w));

        /// <summary>
        /// Selects nongeneric source methods with a specified name that have at least one 512-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, W512 w, string name)
            => src.NonGeneric().WithName(name).WithParameter(p => p.IsClosedVector(w));

        /// <summary>
        /// Selects open generic source methods with a specified name that have at least one 512-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedGeneric(this IEnumerable<MethodInfo> src, W512 w, string name)
            => src.OpenGeneric().WithName(name).Where(m => m.IsVectorized(w));

        /// <summary>
        /// Selects vectorized methods from a stream predicated on width, name and generic partition membership
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="w">The vector width</param>
        /// <param name="name">The name to match</param>
        /// <param name="g">The generic partition to which the considered members belong</param>
        public static IEnumerable<MethodInfo> Vectorized(this IEnumerable<MethodInfo> src, W128 w, string name, bool generic = false)
            => src.Vectorized(w,generic).WithName(name);

        /// <summary>
        /// Selects vectorized methods from a stream predicated on width, name and generic partition membership
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="w">The vector width</param>
        /// <param name="name">The name to match</param>
        /// <param name="g">The generic partition to which the considered members belong</param>
        public static IEnumerable<MethodInfo> Vectorized(this IEnumerable<MethodInfo> src, W256 w, string name, bool generic = false)
                => src.Vectorized(w,generic).WithName(name);

        /// <summary>
        /// Selects vectorized methods from a stream predicated on width, name and generic partition membership
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="w">The vector width</param>
        /// <param name="name">The name to match</param>
        /// <param name="generic">The generic partition to which the considered members belong</param>
        public static IEnumerable<MethodInfo> Vectorized(this IEnumerable<MethodInfo> src, W512 w, string name, bool generic = false)
            => src.Vectorized(w,generic).WithName(name);
    }
}