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

    using static Memories;

    partial class XTend
    {
        /// <summary>
        /// Determines whether a method has intrinsic parameters or return type of specified width
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsKind(this MethodInfo m, Vec128Type hk, bool total)        
            => m.IsVectorized(128,total);

        /// <summary>
        /// Determines whether a method has intrinsic parameters or return type of specified width
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsKind(this MethodInfo m, Vec256Type hk, bool total)        
            => m.IsVectorized(256, total);

        /// <summary>
        /// Determines whether a method has intrinsic parameters or return type of specified width
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsKind<T>(this MethodInfo m, Vec128Kind<T> vk)        
            where T : unmanaged
                => m.IsVectorized(w128,typeof(T));

        /// <summary>
        /// Determines whether a method has intrinsic parameters or return type of specified width
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsKind<T>(this MethodInfo m, Vec256Kind<T> hk)        
            where T : unmanaged
                => m.IsVectorized(w256, typeof(T));
    }
}