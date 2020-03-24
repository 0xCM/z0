//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;

    using static Components;

    public static class VectorTypesOps
    {
        /// <summary>
        /// Determines whether a type is an intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this Type t)
            => VectorTypes.test(t);

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
            => VectorTypes.width(t) == FixedWidth.W128;

        /// <summary>
        /// Determines whether a type is a 256-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this Type t, W256 w)
            => VectorTypes.width(t) == FixedWidth.W256;

        /// <summary>
        /// Determines whether a type is a 512-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this Type t, W512 w)
            => VectorTypes.width(t) == FixedWidth.W512;

        /// <summary>
        /// Determines whether a parameter is of intrinsic vector type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this ParameterInfo t)
            => VectorTypes.test(t.ParameterType);

        /// <summary>
        /// Determines whether a parameter is of type 128-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this ParameterInfo t, W128 w)
            => VectorTypes.width(t.ParameterType) == FixedWidth.W128;

        /// <summary>
        /// Determines whether a parameter is of type 256-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this ParameterInfo t, W256 w)
            => VectorTypes.width(t.ParameterType) == FixedWidth.W256;

        /// <summary>
        /// Determines whether a parameter is of type 512-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this ParameterInfo t, W512 w)
            => VectorTypes.width(t.ParameterType) == FixedWidth.W512;
    }
}