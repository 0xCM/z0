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
        /// Determines whether a method has intrinsic paremeters or return type of specified width
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsVectorized(this MethodInfo src, int? width, bool total)        
            => total ? (VectorType.test(src.ReturnType,width) && src.ParameterTypes().All(t => VectorType.test(t,width))) 
                     : (VectorType.test(src.ReturnType,width) || src.ParameterTypes().Any(t => VectorType.test(t,width)));

        /// <summary>
        /// Determines whether a method has at least one 128-bit intrinsic vector parameter 
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsVectorized(this MethodInfo m, W128 w)        
            => m.IsVectorized() && m.Parameters(p => p.ParameterType.IsVector(w)).Count() != 0;

        /// <summary>
        /// Determines whether a method has at least one 128-bit intrinsic vector parameter 
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsVectorized(this MethodInfo m, W256 w)        
            => m.IsVectorized() && m.Parameters(p => p.ParameterType.IsVector(w)).Count() != 0;

       /// <summary>
        /// Determines whether a method has intrinsic parameters or return type
        /// </summary>
        /// <param name="src">The method to test</param>
        public static bool IsVectorized(this MethodInfo src)        
            => src.ReturnsVector() || src.ParameterTypes().Any(VectorType.test);

        /// <summary>
        /// Determines whether a method has at least one 128-bit intrinsic vector parameter 
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsVectorized(this MethodInfo m, W512 w)        
            => m.IsVectorized() && m.Parameters(p => p.ParameterType.IsVector(w)).Count() != 0;

        /// <summary>
        /// Determines whether a method has at least one 128-bit intrinsic vector parameter closed over a specified type
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsVectorized(this MethodInfo m, W128 w, Type tCell)        
            => m.IsVectorized() && m.Parameters(p => p.ParameterType.IsVector(w,tCell)).Count() != 0;

        /// <summary>
        /// Determines whether a method has at least one 256-bit intrinsic vector parameter closed over a specified type
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsVectorized(this MethodInfo m, W256 w, Type tCell)        
            => m.IsVectorized() && m.Parameters(p => p.ParameterType.IsVector(w,tCell)).Count() != 0;

        /// <summary>
        /// Determines whether a method has at least one 512-bit intrinsic vector parameter closed over a specified type
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsVectorized(this MethodInfo m, W512 w, Type tCell)        
            => m.IsVectorized() && m.Parameters(p => p.ParameterType.IsVector(w,tCell)).Count() != 0;

        /// <summary>
        /// Selcts vectorized methods from a source stream
        /// </summary>
        /// <param name="src">The source strean</param>
        /// <param name="w">The vector width</param>
        /// <param name="g">The generic partition from which methods should be selected</param>
        public static bool IsVectorized(this MethodInfo src, W128 w, GenericPartition g = default)
            => src.IsVectorized(w) && src.IsMemberOf(g);

        /// <summary>
        /// Selcts vectorized methods from a source stream
        /// </summary>
        /// <param name="src">The source strean</param>
        /// <param name="w">The vector width</param>
        /// <param name="g">The generic partition from which methods should be selected</param>
        public static bool IsVectorized(this MethodInfo src, W256 w, GenericPartition g = default)
            => src.IsVectorized(w) && src.IsMemberOf(g);

        /// <summary>
        /// Selcts vectorized methods from a source stream
        /// </summary>
        /// <param name="src">The source strean</param>
        /// <param name="w">The vector width</param>
        /// <param name="g">The generic partition from which methods should be selected</param>
        public static bool IsVectorized(this MethodInfo src, W512 w, GenericPartition g = default)
            => src.IsVectorized(w) && src.IsMemberOf(g);
    }
}