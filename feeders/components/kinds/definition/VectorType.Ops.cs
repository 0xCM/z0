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
 
    public static class VectorTypesOps
    {
        /// <summary>
        /// Determines whether a type is an intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this Type t)
            => VectorType.test(t);

        /// <summary>
        /// Determines whether a method returns an intrinsic vector
        /// </summary>
        /// <param name="src">The method to test</param>
        public static bool ReturnsVector(this MethodInfo src)
            => src.ReturnType.IsVector();

        public static FixedWidth NumericWidth(this Type t)
        {
            var k = NumericTypes.kind(t);
            if(k != 0)
                return (FixedWidth)(ushort)k;
            else
                return FixedWidth.None;            
        }         

        /// <summary>
        /// Determines whether a type is a 128-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this Type t, W128 w)
            => VectorType.width(t) == FixedWidth.W128;

        /// <summary>
        /// Determines whether a type is a 256-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this Type t, W256 w)
            => VectorType.width(t) == FixedWidth.W256;

        /// <summary>
        /// Determines whether a type is a 512-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this Type t, W512 w)
            => VectorType.width(t) == FixedWidth.W512;

        /// <summary>
        /// Determines whether a parameter is of intrinsic vector type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this ParameterInfo t)
            => VectorType.test(t.ParameterType);

        /// <summary>
        /// Determines whether a parameter is of type 128-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this ParameterInfo t, W128 w)
            => VectorType.width(t.ParameterType) == FixedWidth.W128;

        /// <summary>
        /// Determines whether a parameter is of type 256-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this ParameterInfo t, W256 w)
            => VectorType.width(t.ParameterType) == FixedWidth.W256;

        /// <summary>
        /// Determines whether a parameter is of type 512-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this ParameterInfo t, W512 w)
            => VectorType.width(t.ParameterType) == FixedWidth.W512;

        /// <summary>
        /// Determines whether a method has intrinsic paremeters or return type of specified width
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsVectorized(this MethodInfo src, int? width, bool total)        
            => total ? (VectorType.test(src.ReturnType,width) && src.ParameterTypes().All(t => VectorType.test(t,width))) 
                     : (VectorType.test(src.ReturnType,width) || src.ParameterTypes().Any(t => VectorType.test(t,width)));

        /// <summary>
        /// Determines whether a method has intrinsic paremeters or return type of specified width
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsKind(this MethodInfo m, Vec128Kind hk, bool total)        
            => m.IsVectorized(128,total);

        /// <summary>
        /// Determines whether a method has intrinsic paremeters or return type of specified width
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsKind(this MethodInfo m, Vec256Kind hk, bool total)        
            => m.IsVectorized(256, total);

        /// <summary>
        /// Selects methods from a stream that accept and/or return intrinsic vectors
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> OfKind(this IEnumerable<MethodInfo> src, Vec128Kind hk, bool total = false)
            => src.Where(m => m.IsKind(hk,total));

        /// <summary>
        /// Selects methods from a stream that accept and/or return intrinsic vectors
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> OfKind(this IEnumerable<MethodInfo> src, Vec256Kind hk, bool total = false)
            => src.Where(m => m.IsKind(hk,total));

        /// <summary>
        /// Determines whether a method returns a 128-bit intrinsic vector
        /// </summary>
        /// <param name="src">The method to test</param>
        public static bool ReturnsVector(this MethodInfo src, W128 w)
            => src.ReturnType.IsVector(w);

        /// <summary>
        /// Determines whether a method returns a 256-bit intrinsic vector
        /// </summary>
        /// <param name="src">The method to test</param>
        public static bool ReturnsVector(this MethodInfo src, W256 w)
            => src.ReturnType.IsVector(w);

        /// <summary>
        /// Determines whether a method returns a 256-bit intrinsic vector
        /// </summary>
        /// <param name="src">The method to test</param>
        public static bool ReturnsVector(this MethodInfo src, W512 w)
            => src.ReturnType.IsVector(w);
    }
}