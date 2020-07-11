//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    partial class XTend
    {
        static TIdentityReflector RC => IdentityReflector.Service;

        /// <summary>
        /// Determines whether a method has intrinsic parameters or return type of specified width
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsKind(this MethodInfo m, Vec128Type vk, bool total)        
            => RC.IsVectorized(m, vk.BitWidth, total);

        /// <summary>
        /// Determines whether a method is of characterized vector kind
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="vk">The vector kind under test</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsKind(this MethodInfo m, Vec256Type vk, bool total)        
            => RC.IsVectorized(m, vk.BitWidth, total);

        /// <summary>
        /// Determines whether a method is of characterized vector kind
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="vk">The vector kind under test</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsKind(this MethodInfo m, Vec512Type vk, bool total)        
            => RC.IsVectorized(m, vk.BitWidth, total);

        /// <summary>
        /// Determines whether a method is of characterized vector kind
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="vk">The vector kind under test</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsKind<T>(this MethodInfo m, Vec128Kind<T> vk)        
            where T : unmanaged
                => RC.IsVectorized(m, vk.W, typeof(T));

        /// <summary>
        /// Determines whether a method is of characterized vector kind
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="vk">The vector kind under test</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsKind<T>(this MethodInfo m, Vec256Kind<T> vk)        
            where T : unmanaged
                => RC.IsVectorized(m, vk.W, typeof(T));

        /// <summary>
        /// Determines whether a method is of characterized vector kind
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="vk">The vector kind under test</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsKind<T>(this MethodInfo m, Vec512Kind<T> vk)        
            where T : unmanaged
                => RC.IsVectorized(m, vk.W, typeof(T));
    }
}