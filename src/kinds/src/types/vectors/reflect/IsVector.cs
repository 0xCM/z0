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
        /// Determines whether a type is a 128-bit intrinsic vector closed over a specified type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this Type t, W128 w, Type tCell)
            => t.IsVector(w)
            && t.IsClosedGeneric()
            && t.GenericParameters().Single() == tCell;

        /// <summary>
        /// Determines whether a type is a 256-bit intrinsic vector closed over a specified type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this Type t, W256 w, Type tCell)
            => t.IsVector(w)
            && t.IsClosedGeneric()
            && t.GenericParameters().Single() == tCell;

        /// <summary>
        /// Determines whether a type is a 512-bit intrinsic vector closed over a specified type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this Type t, W512 w, Type tCell)
            => t.IsVector(w)
            && t.IsClosedGeneric()
            && t.GenericParameters().Single() == tCell;


        /// <summary>
        /// Returns true if a method parameter is a 128-bit intrinsic vector closed over a specified argument type
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        /// <param name="arg">The argument type to match</param>
        public static bool IsVector(this ParameterInfo param, W128 w, Type arg)
            => param.ParameterType.IsVector(w,arg);

        /// <summary>
        /// Returns true if a method parameter is a 256-bit intrinsic vector closed over a specified argument type
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        /// <param name="arg">The argument type to match</param>
        public static bool IsVector(this ParameterInfo param, W256 w, Type arg)
            => param.ParameterType.IsVector(w,arg);

        /// <summary>
        /// Returns true if a method parameter is a 512-bit intrinsic vector closed over a specified argument type
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        /// <param name="arg">The argument type to match</param>
        public static bool IsVector(this ParameterInfo param, W512 w, Type arg)
            => param.ParameterType.IsVector(w,arg);

        /// <summary>
        /// Determines whether a type is a 128-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this Type t, W128 w)
            => VectorType.width(t) == TypeWidth.W128;

        /// <summary>
        /// Determines whether a type is a 256-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this Type t, W256 w)
            => VectorType.width(t) == TypeWidth.W256;

        /// <summary>
        /// Determines whether a type is a 512-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this Type t, W512 w)
            => VectorType.width(t) == TypeWidth.W512;

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
            => VectorType.width(t.ParameterType) == TypeWidth.W128;

        /// <summary>
        /// Determines whether a parameter is of type 256-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this ParameterInfo t, W256 w)
            => VectorType.width(t.ParameterType) == TypeWidth.W256;

        /// <summary>
        /// Determines whether a parameter is of type 512-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVector(this ParameterInfo t, W512 w)
            => VectorType.width(t.ParameterType) == TypeWidth.W512;
    }
}