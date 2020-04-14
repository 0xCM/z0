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
        /// Selects nongeneric source methods that have at least one 128-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, W128 w)
            => src.NonGeneric().Where(m => m.IsVectorized(w));

        /// <summary>
        /// Selects open generic source methods that have at least one 128-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedGeneric(this IEnumerable<MethodInfo> src, W128 w)
            => src.OpenGeneric().Where(m => m.IsVectorized(w));

        /// <summary>
        /// Selects nongeneric source methods that have at least one 256-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, W256 w)
            => src.NonGeneric().Where(m => m.IsVectorized(w));

        /// <summary>
        /// Selects open generic source methods that have at least one 256-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedGeneric(this IEnumerable<MethodInfo> src, W256 w)
            => src.OpenGeneric().Where(m => m.IsVectorized(w));

        /// <summary>
        /// Selects nongeneric source methods that have at least one 512-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, W512 w)
            => src.NonGeneric().Where(m => m.IsVectorized(w));

        /// <summary>
        /// Selects open generic source methods that have at least one 512-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedGeneric(this IEnumerable<MethodInfo> src, W512 w)
            => src.OpenGeneric().Where(m => m.IsVectorized(w));

        /// <summary>
        /// Selcts vectorized methods from a source stream
        /// </summary>
        /// <param name="src">The source strean</param>
        /// <param name="w">The vector width</param>
        /// <param name="g">The generic partition from which methods should be selected</param>
        public static IEnumerable<MethodInfo> Vectorized(this IEnumerable<MethodInfo> src, W128 w, 
            GenericPartition g = GenericPartition.NonGeneric)
                => g.IsGeneric() ? src.VectorizedGeneric(w) : src.VectorizedDirect(w);

        /// <summary>
        /// Selcts vectorized methods from a source stream
        /// </summary>
        /// <param name="src">The source strean</param>
        /// <param name="w">The vector width</param>
        /// <param name="g">The generic partition from which methods should be selected</param>
        public static IEnumerable<MethodInfo> Vectorized(this IEnumerable<MethodInfo> src, W256 w, 
             GenericPartition g = GenericPartition.NonGeneric)
                => g.IsGeneric() ? src.VectorizedGeneric(w) : src.VectorizedDirect(w);

        /// <summary>
        /// Selcts vectorized methods from a source stream
        /// </summary>
        /// <param name="src">The source strean</param>
        /// <param name="w">The vector width</param>
        /// <param name="g">The generic partition from which methods should be selected</param>
        public static IEnumerable<MethodInfo> Vectorized(this IEnumerable<MethodInfo> src, W512 w, 
            GenericPartition g = GenericPartition.Generic)
                => g.IsGeneric() ? src.VectorizedGeneric(w) : src.VectorizedDirect(w);
    }
}