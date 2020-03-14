//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static Root;

    public static class VectorTypeX
    {
        /// <summary>
        /// Determines whether a method produces, but does not accept, vector values
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsVectorFactory(this MethodInfo m)        
            => m.ParameterTypes(true).Where(t => t.IsVector()).Count() == 0 && m.ReturnType.IsVector();

        /// <summary>
        /// Determines whether a method represents a vectorized unary operation that requires an immediate value
        /// </summary>
        /// <param name="method">The method to examine</param>
        public static bool IsVectorizedUnaryImm(this MethodInfo method)
        {
            var parameters = method.GetParameters().ToArray();
            return parameters.Length == 2 
                && parameters[0].ParameterType.IsVector() 
                && parameters[1].IsImmediate();
        }

        /// <summary>
        /// Determines whether a method represents a vectorized binary operation that requires an immediate value
        /// </summary>
        /// <param name="method">The method to examine</param>
        public static bool IsVectorizedBinaryImm(this MethodInfo method)
        {
            var parameters = method.GetParameters().ToArray();
            return parameters.Length == 3 
                && parameters[0].ParameterType.IsVector() 
                && parameters[1].ParameterType.IsVector() 
                && parameters[2].IsImmediate();
        }

        /// <summary>
        /// Selects open generic source methods that have at least one 128-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedGeneric(this IEnumerable<MethodInfo> src, N128 w)
            => src.OpenGeneric().Where(m => m.IsVectorized(w));

        /// <summary>
        /// Selects open generic source methods that have at least one 256-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedGeneric(this IEnumerable<MethodInfo> src, N256 w)
            => src.OpenGeneric().Where(m => m.IsVectorized(w));

        /// <summary>
        /// Selects open generic source methods that have at least one 512-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedGeneric(this IEnumerable<MethodInfo> src, N512 w)
            => src.OpenGeneric().Where(m => m.IsVectorized(w));

        /// <summary>
        /// Selects open generic source methods with a specified name that have at least one 128-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedGeneric(this IEnumerable<MethodInfo> src, N128 w, string name)
            => src.OpenGeneric().WithName(name).Where(m => m.IsVectorized(w));

        /// <summary>
        /// Selects open generic source methods with a specified name that have at least one 256-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedGeneric(this IEnumerable<MethodInfo> src, N256 w, string name)
            => src.OpenGeneric().WithName(name).Where(m => m.IsVectorized(w));

        /// <summary>
        /// Selects open generic source methods with a specified name that have at least one 512-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedGeneric(this IEnumerable<MethodInfo> src, N512 w, string name)
            => src.OpenGeneric().WithName(name).Where(m => m.IsVectorized(w));

        /// <summary>
        /// Selects nongeneric source methods that have at least one 128-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, N128 w)
            => src.NonGeneric().Where(m => m.IsVectorized(w));

        /// <summary>
        /// Selects nongeneric source methods that have at least one 256-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, N256 w)
            => src.NonGeneric().Where(m => m.IsVectorized(w));

        /// <summary>
        /// Selects nongeneric source methods that have at least one 512-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, N512 w)
            => src.NonGeneric().Where(m => m.IsVectorized(w));

        /// <summary>
        /// Selects nongeneric source methods that have at least one 128-bit vector parameter closed over a specified type
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, N128 w, Type tCell)
            => src.NonGeneric().WithParameter(p => p.IsVector(w,tCell));

        /// <summary>
        /// Selects nongeneric source methods that have at least one 256-bit vector parameter closed over a specified type
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, N256 w, Type tCell)
            => src.NonGeneric().WithParameter(p => p.IsVector(w,tCell));

        /// <summary>
        /// Selects nongeneric source methods that have at least one 512-bit vector parameter closed over a specified type
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, N512 w, Type tCell)
            => src.NonGeneric().WithParameter(p => p.IsVector(w,tCell));

        /// <summary>
        /// Selects nongeneric source methods that have at least one 128-bit vector parameter closed over a specified parametric type
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        /// <typeparam name="T">The type to match</typeparam>
        public static IEnumerable<MethodInfo> VectorizedDirect<T>(this IEnumerable<MethodInfo> src, N128 w)
            where T : unmanaged
                => src.VectorizedDirect(w,typeof(T));

        /// <summary>
        /// Selects nongeneric source methods that have at least one 256-bit vector parameter closed over a specified parametric type
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        /// <typeparam name="T">The type to match</typeparam>
        public static IEnumerable<MethodInfo> VectorizedDirect<T>(this IEnumerable<MethodInfo> src, N256 w)
            where T : unmanaged
                => src.VectorizedDirect(w,typeof(T));

        /// <summary>
        /// Selects nongeneric source methods that have at least one 512-bit vector parameter closed over a specified parametric type
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        /// <typeparam name="T">The type to match</typeparam>
        public static IEnumerable<MethodInfo> VectorizedDirect<T>(this IEnumerable<MethodInfo> src, N512 w)
            where T : unmanaged
                => src.VectorizedDirect(w,typeof(T));

        /// <summary>
        /// Selects nongeneric source methods with a specified name that have at least one 128-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, N128 w, string name)
            => src.NonGeneric().WithName(name).WithParameter(p => p.IsClosedVector(w));

        /// <summary>
        /// Selects nongeneric source methods with a specified name that have at least one 256-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, N256 w, string name)
            => src.NonGeneric().WithName(name).WithParameter(p => p.IsClosedVector(w));

        /// <summary>
        /// Selects nongeneric source methods with a specified name that have at least one 512-bit vector parameter
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, N512 w, string name)
            => src.NonGeneric().WithName(name).WithParameter(p => p.IsClosedVector(w));

        /// <summary>
        /// Selects methods from a stream that accept and/or return intrinsic vectors
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> OfKind(this IEnumerable<MethodInfo> src, VKT.Vec128 hk, bool total = false)
            => src.Where(m => m.IsKind(hk,total));

        /// <summary>
        /// Selects methods from a stream that accept and/or return intrinsic vectors
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> OfKind(this IEnumerable<MethodInfo> src, VKT.Vec256 hk, bool total = false)
            => src.Where(m => m.IsKind(hk,total));

        /// <summary>
        /// Returns true if the source type is intrinsic or blocked
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSegmented(this Type t)
            => t.IsBlocked() || t.IsVector();

        /// <summary>
        /// If type is intrinsic or blocked, returns the primal type over which the segmentation is defined; otherwise, returns none
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static Type SegmentType(this Type t)
            => t.IsSegmented() && t.IsClosedGeneric() ? t.SuppliedTypeArgs().Single() : typeof(void); 

        /// <summary>
        /// Divines the bit-width of a specified type, if possible
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static FixedWidth Width(this Type t)
        {
            if(VectorType.test(t))
                return VectorType.width(t);
            else if(t.IsBlocked())
                return BK.width(t);
            if(t.IsNumeric())
                return Numeric.width(t);
            else if(t == typeof(bit))
                return FixedWidth.W1;
            else
                return FixedWidth.None;
        }
    }
}