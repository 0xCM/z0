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

    partial class VectorTypeOps
    {
        /// <summary>
        /// Determines whether a method has intrinsic parameters or return type
        /// </summary>
        /// <param name="src">The method to test</param>
        public static bool IsVectorized(this MethodInfo src)        
            => src.ReturnsVector() || src.ParameterTypes().Any(VectorType.test);

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
        public static bool IsVectorized(this MethodInfo m, N128 w, Type tCell)        
            => m.IsVectorized() && m.Parameters(p => p.ParameterType.IsVector(w,tCell)).Count() != 0;

        /// <summary>
        /// Determines whether a method has at least one 256-bit intrinsic vector parameter closed over a specified type
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsVectorized(this MethodInfo m, N256 w, Type tCell)        
            => m.IsVectorized() && m.Parameters(p => p.ParameterType.IsVector(w,tCell)).Count() != 0;

        /// <summary>
        /// Determines whether a method has at least one 512-bit intrinsic vector parameter closed over a specified type
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsVectorized(this MethodInfo m, N512 w, Type tCell)        
            => m.IsVectorized() && m.Parameters(p => p.ParameterType.IsVector(w,tCell)).Count() != 0;
    }
}