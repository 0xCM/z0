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

    public static class SegmentedTypeOps
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
        /// Returns true if a type is an open generic 128-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsOpenVector(this Type t, W128 w)
            => t.IsOpenGeneric() && t.IsVector(w);

        /// <summary>
        /// Returns true if a type is an open generic 256-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsOpenVector(this Type t, W256 w)
            => t.IsOpenGeneric() && t.IsVector(w);

        /// <summary>
        /// Returns true if a type is an open generic 512-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsOpenVector(this Type t, W512 w)
            => t.IsOpenGeneric() && t.IsVector(w);

        /// <summary>
        /// Returns true if a type is a closed 128-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this Type t, W128 w)
            => t.IsClosedGeneric() && t.IsVector(w);

        /// <summary>
        /// Returns true if a type is a closed 256-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this Type t, W256 w)
            => t.IsClosedGeneric() && t.IsVector(w);

        /// <summary>
        /// Returns true if a type is a closed 512-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this Type t, W512 w)
            => t.IsClosedGeneric() && t.IsVector(w);

        /// <summary>
        /// Returns true if a method parameter is a closed 128-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this ParameterInfo param, W128 w)
            => param.ParameterType.IsClosedGeneric() && param.ParameterType.IsVector(w);

        /// <summary>
        /// Returns true if a method parameter is a closed 256-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this ParameterInfo param, W256 w)
            => param.ParameterType.IsClosedGeneric() && param.ParameterType.IsVector(w);

        /// <summary>
        /// Returns true if a method parameter is a closed 512-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this ParameterInfo param, W512 w)
            => param.ParameterType.IsClosedGeneric() && param.ParameterType.IsVector(w); 
    }
}