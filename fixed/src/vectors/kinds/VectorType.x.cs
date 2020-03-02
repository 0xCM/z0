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
        /// Determines whether a type is an intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsVector(this Type t)
            => VectorType.test(t);

        /// <summary>
        /// Determines whether a type is a 128-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsVector(this Type t, N128 w)
            => VectorType.width(t) == FixedWidth.W128;

        /// <summary>
        /// Determines whether a type is a 256-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsVector(this Type t, N256 w)
            => VectorType.width(t) == FixedWidth.W256;

        /// <summary>
        /// Determines whether a type is a 512-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsVector(this Type t, N512 w)
            => VectorType.width(t) == FixedWidth.W512;

        /// <summary>
        /// Determines whether a type is a 128-bit intrinsic vector closed over a specified type
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsVector(this Type t, N128 w, Type celltype)
            => t.IsVector(w)
            && t.IsClosedGeneric()
            && t.GenericParameters().Single() == celltype;

        /// <summary>
        /// Determines whether a type is a 256-bit intrinsic vector closed over a specified type
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsVector(this Type t, N256 w, Type celltype)
            => t.IsVector(w)
            && t.IsClosedGeneric()
            && t.GenericParameters().Single() == celltype;

        /// <summary>
        /// Determines whether a type is a 512-bit intrinsic vector closed over a specified type
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsVector(this Type t, N512 w, Type celltype)
            => t.IsVector(w)
            && t.IsClosedGeneric()
            && t.GenericParameters().Single() == celltype;

        /// <summary>
        /// Determines whether a parameer type is a 128-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsVector(this ParameterInfo t, N128 w)
            => VectorType.width(t.ParameterType) == FixedWidth.W128;

        /// <summary>
        /// Determines whether a parameer type is a 256-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsVector(this ParameterInfo t, N256 w)
            => VectorType.width(t.ParameterType) == FixedWidth.W256;

        /// <summary>
        /// Determines whether a parameer type is a 256-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsVector(this ParameterInfo t, N512 w)
            => VectorType.width(t.ParameterType) == FixedWidth.W512;

        /// <summary>
        /// Returns true if a type is a closed 128-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        [MethodImpl(Inline)]
        public static bool IsClosedVector(this Type t, N128 w)
            => t.IsClosedGeneric()
            && t.IsVector(w);

        /// <summary>
        /// Returns true if a type is a closed 256-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        [MethodImpl(Inline)]
        public static bool IsClosedVector(this Type t, N256 w)
            => t.IsClosedGeneric()
            && t.IsVector(w);

        /// <summary>
        /// Returns true if a type is a closed 512-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        [MethodImpl(Inline)]
        public static bool IsClosedVector(this Type t, N512 w)
            => t.IsClosedGeneric()
            && t.IsVector(w);

        /// <summary>
        /// Returns true if a type is an open generic 128-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        [MethodImpl(Inline)]
        public static bool IsOpenVector(this Type t, N128 w)
            => t.IsOpenGeneric()
            && t.IsVector(w);

        /// <summary>
        /// Returns true if a type is an open generic 256-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        [MethodImpl(Inline)]
        public static bool IsOpenVector(this Type t, N256 w)
            => t.IsOpenGeneric()
            && t.IsVector(w);

        /// <summary>
        /// Returns true if a type is an open generic 512-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        [MethodImpl(Inline)]
        public static bool IsOpenVector(this Type t, N512 w)
            => t.IsOpenGeneric()
            && t.IsVector(w);

        /// <summary>
        /// Determines whether a method has intrinsic paremeters or return type of specified width
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsVectorized(this MethodInfo m, int? width, bool total)        
            => total ? (VectorType.vector(m.ReturnType,width) && m.ParameterTypes().All(t => VectorType.vector(t,width))) 
                     : (VectorType.vector(m.ReturnType,width) || m.ParameterTypes().Any(t => VectorType.vector(t,width)));

        /// <summary>
        /// Determines whether a method has intrinsic parameters or return type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsVectorized(this MethodInfo m, bool total = false)        
            => total ? (VectorType.test(m.ReturnType) && m.ParameterTypes().All(VectorType.test)) 
                     : (VectorType.test(m.ReturnType) || m.ParameterTypes().Any(VectorType.test));


        /// <summary>
        /// Determines whether a method has at least one 128-bit intrinsic vector parameter 
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsVectorized(this MethodInfo m, N128 w)        
            => m.IsVectorized() && m.Parameters(p => p.ParameterType.IsVector(w)).Count() != 0;

        /// <summary>
        /// Determines whether a method has at least one 128-bit intrinsic vector parameter 
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsVectorized(this MethodInfo m, N256 w)        
            => m.IsVectorized() && m.Parameters(p => p.ParameterType.IsVector(w)).Count() != 0;

        /// <summary>
        /// Determines whether a method has at least one 128-bit intrinsic vector parameter 
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsVectorized(this MethodInfo m, N512 w)        
            => m.IsVectorized() && m.Parameters(p => p.ParameterType.IsVector(w)).Count() != 0;

        /// <summary>
        /// Determines whether a method has at least one 128-bit intrinsic vector parameter closed over a specified type
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsVectorized(this MethodInfo m, N128 w, Type celltype)        
            => m.IsVectorized() && m.Parameters(p => p.ParameterType.IsVector(w,celltype)).Count() != 0;

        /// <summary>
        /// Determines whether a method has at least one 256-bit intrinsic vector parameter closed over a specified type
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsVectorized(this MethodInfo m, N256 w, Type celltype)        
            => m.IsVectorized() && m.Parameters(p => p.ParameterType.IsVector(w,celltype)).Count() != 0;

        /// <summary>
        /// Determines whether a method has at least one 512-bit intrinsic vector parameter closed over a specified type
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsVectorized(this MethodInfo m, N512 w, Type celltype)        
            => m.IsVectorized() && m.Parameters(p => p.ParameterType.IsVector(w,celltype)).Count() != 0;

        /// <summary>
        /// Determines whether a method produces, but does not accept, vector values
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsVectorFactory(this MethodInfo m)        
            => m.ParameterTypes(true).Where(t => t.IsVector()).Count() == 0 && m.ReturnType.IsVector();

        /// <summary>
        /// Determines whether a method defines a vectorized operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsVectorOp(this MethodInfo m)        
            => m.IsVectorized() && m.IsOperator();

        /// <summary>
        /// Returns true if a method parameter is a closed 128-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this ParameterInfo param, N128 w)
            => param.ParameterType.IsClosedGeneric() && param.ParameterType.IsVector(w);

        /// <summary>
        /// Returns true if a method parameter is a closed 256-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this ParameterInfo param, N256 w)
            => param.ParameterType.IsClosedGeneric() && param.ParameterType.IsVector(w);

        /// <summary>
        /// Returns true if a method parameter is a closed 512-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this ParameterInfo param, N512 w)
            => param.ParameterType.IsClosedGeneric() && param.ParameterType.IsVector(w);

        /// <summary>
        /// Returns true if a method parameter is a 128-bit intrinsic vector closed over a specified argument type
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        /// <param name="arg">The argument type to match</param>
        public static bool IsVector(this ParameterInfo param, N128 w, Type arg)
            => param.ParameterType.IsVector(w,arg);

        /// <summary>
        /// Returns true if a method parameter is a 256-bit intrinsic vector closed over a specified argument type
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        /// <param name="arg">The argument type to match</param>
        public static bool IsVector(this ParameterInfo param, N256 w, Type arg)
            => param.ParameterType.IsVector(w,arg);

        /// <summary>
        /// Returns true if a method parameter is a 512-bit intrinsic vector closed over a specified argument type
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        /// <param name="arg">The argument type to match</param>
        public static bool IsVector(this ParameterInfo param, N512 w, Type arg)
            => param.ParameterType.IsVector(w,arg);

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
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, N128 w, Type celltype)
            => src.NonGeneric().WithParameter(p => p.IsVector(w,celltype));

        /// <summary>
        /// Selects nongeneric source methods that have at least one 256-bit vector parameter closed over a specified type
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, N256 w, Type celltype)
            => src.NonGeneric().WithParameter(p => p.IsVector(w,celltype));

        /// <summary>
        /// Selects nongeneric source methods that have at least one 512-bit vector parameter closed over a specified type
        /// </summary>
        /// <param name="src">The source methods</param>
        /// <param name="w">The vector width</param>
        public static IEnumerable<MethodInfo> VectorizedDirect(this IEnumerable<MethodInfo> src, N512 w, Type celltype)
            => src.NonGeneric().WithParameter(p => p.IsVector(w,celltype));

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
        /// Determines whether a method has intrinsic parameters or return type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsKind(this MethodInfo m, VKT.Vec hk, bool total = false)        
            => m.IsVectorized(total);

        /// <summary>
        /// Determines whether a method has intrinsic paremeters or return type of specified width
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsKind(this MethodInfo m, VKT.Vec128 hk, bool total)        
            => m.IsVectorized(128,total);

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
        /// Determines whether a method has intrinsic paremeters or return type of specified width
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsKind(this MethodInfo m, VKT.Vec256 hk, bool total)        
            => m.IsVectorized(256,total);

    }
}
