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
        /// Determines whether a method has at least one 128-bit intrinsic vector parameter 
        /// </summary>
        /// <param name="src">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsVectorized(this MethodInfo src, W128 w)        
            => RC.IsVectorized(src,w);

        /// <summary>
        /// Determines whether a method has at least one 128-bit intrinsic vector parameter 
        /// </summary>
        /// <param name="src">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsVectorized(this MethodInfo src, W256 w)        
            => RC.IsVectorized(src,w);

        /// <summary>
        /// Determines whether a method has intrinsic parameters or return type
        /// </summary>
        /// <param name="src">The method to test</param>
        public static bool IsVectorized(this MethodInfo src)        
            => RC.IsVectorized(src);

        /// <summary>
        /// Determines whether a method has at least one 128-bit intrinsic vector parameter 
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsVectorized(this MethodInfo src, W512 w)        
            => RC.IsVectorized(src,w);

        /// <summary>
        /// Determines whether a method has at least one 128-bit intrinsic vector parameter closed over a specified type
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsVectorized(this MethodInfo src, W128 w, Type tCell)        
            => RC.IsVectorized(src, w, tCell);

        /// <summary>
        /// Determines whether a method has at least one 256-bit intrinsic vector parameter closed over a specified type
        /// </summary>
        /// <param name="src">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsVectorized(this MethodInfo src, W256 w, Type tCell)        
            => RC.IsVectorized(src, w, tCell);

        /// <summary>
        /// Determines whether a method has at least one 512-bit intrinsic vector parameter closed over a specified type
        /// </summary>
        /// <param name="src">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsVectorized(this MethodInfo src, W512 w, Type tCell)        
            => RC.IsVectorized(src, w, tCell);

        /// <summary>
        /// Selcts vectorized methods from a source stream
        /// </summary>
        /// <param name="src">The source strean</param>
        /// <param name="w">The vector width</param>
        /// <param name="g">The generic partition from which methods should be selected</param>
        public static bool IsVectorized(this MethodInfo src, W128 w, GenericState g = default)
            => RC.IsVectorized(src, w, g);

        /// <summary>
        /// Selcts vectorized methods from a source stream
        /// </summary>
        /// <param name="src">The source strean</param>
        /// <param name="w">The vector width</param>
        /// <param name="g">The generic partition from which methods should be selected</param>
        public static bool IsVectorized(this MethodInfo src, W256 w, GenericState g = default)
            => RC.IsVectorized(src, w, g);

        /// <summary>
        /// Selcts vectorized methods from a source stream
        /// </summary>
        /// <param name="src">The source strean</param>
        /// <param name="w">The vector width</param>
        /// <param name="g">The generic partition from which methods should be selected</param>
        public static bool IsVectorized(this MethodInfo src, W512 w, GenericState g = default)
            => RC.IsVectorized(src, w, g);
   }
}