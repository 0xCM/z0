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
        /// Selects nongeneric source methods that have at least one 256-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, W256 w)
            => src.NonGeneric().Where(m => m.IsVectorized(w));

        /// <summary>
        /// Selects nongeneric source methods that have at least one 512-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, W512 w)
            => src.NonGeneric().Where(m => m.IsVectorized(w));

        /// <summary>
        /// Selects nongeneric source methods with a specified name that have at least one 128-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, W128 w, string name)
            => src.NonGeneric().WithName(name).WithParameter(p => p.IsClosedVector(w));

        /// <summary>
        /// Selects nongeneric source methods with a specified name that have at least one 256-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, W256 w, string name)
            => src.NonGeneric().WithName(name).WithParameter(p => p.IsClosedVector(w));


        /// <summary>
        /// Selects nongeneric source methods with a specified name that have at least one 512-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, W512 w, string name)
            => src.NonGeneric().WithName(name).WithParameter(p => p.IsClosedVector(w));

        /// <summary>
        /// Selects nongeneric source methods that have at least one 128-bit vector parameter closed over a specified type
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, W128 w, Type tCell)
            => src.NonGeneric().WithParameter(p => p.IsVector(w,tCell));

        /// <summary>
        /// Selects nongeneric source methods that have at least one 256-bit vector parameter closed over a specified type
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, W256 w, Type tCell)
            => src.NonGeneric().WithParameter(p => p.IsVector(w,tCell));

        /// <summary>
        /// Selects nongeneric source methods that have at least one 512-bit vector parameter closed over a specified type
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, W512 w, Type tCell)
            => src.NonGeneric().WithParameter(p => p.IsVector(w,tCell));

        /// <summary>
        /// Selects nongeneric source methods that have at least one 128-bit vector parameter closed over a specified parametric type
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        /// <typeparam name="T">The type to match</typeparam>
        public static IEnumerable<MethodInfo> VectorizedDirect<T>(this IEnumerable<MethodInfo> src, W128 w)
            where T : unmanaged
                => src.VectorizedDirect(w,typeof(T));

        /// <summary>
        /// Selects nongeneric source methods that have at least one 256-bit vector parameter closed over a specified parametric type
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        /// <typeparam name="T">The type to match</typeparam>
        public static IEnumerable<MethodInfo> VectorizedDirect<T>(this IEnumerable<MethodInfo> src, W256 w)
            where T : unmanaged
                => src.VectorizedDirect(w,typeof(T));

        /// <summary>
        /// Selects nongeneric source methods that have at least one 512-bit vector parameter closed over a specified parametric type
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        /// <typeparam name="T">The type to match</typeparam>
        public static IEnumerable<MethodInfo> VectorizedDirect<T>(this IEnumerable<MethodInfo> src, W512 w)
            where T : unmanaged
                => src.VectorizedDirect(w,typeof(T));
    }

}