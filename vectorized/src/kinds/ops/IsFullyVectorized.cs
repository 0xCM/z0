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
        /// Determines whether all parameters of a method are 128-bit intrinsic vectors
        /// </summary>
        /// <param name="src">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsFullyVectorized(this MethodInfo src, N128 w)        
            => src.IsFullyVectorized() && src.EffectiveParameterTypes().All(t => t.IsVector(w));

        /// <summary>
        /// Determines whether all parameters of a method are 256-bit intrinsic vectors
        /// </summary>
        /// <param name="src">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsFullyVectorized(this MethodInfo src, N256 w)        
            => src.IsFullyVectorized() && src.EffectiveParameterTypes().All(t => t.IsVector(w));

        /// <summary>
        /// Determines whether all parameters of a method are 256-bit intrinsic vectors
        /// </summary>
        /// <param name="src">The method to examine</param>
        /// <param name="w">The width to match</param>
        public static bool IsFullyVectorized(this MethodInfo src, N512 w)        
            => src.IsFullyVectorized() && src.EffectiveParameterTypes().All(t => t.IsVector(w));

        /// <summary>
        /// Determines whether all parameters of a method are 128-bit intrinsic vectors with a specified cell type
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="w">The width to match</param>
        /// <param name="tCell">The cell type to match</param>
        public static bool IsFullyVectorized(this MethodInfo src, N128 w, Type tCell)        
            => src.IsFullyVectorized(w) && src.ReturnType.IsVector(w,tCell);

        /// <summary>
        /// Determines whether all parameters of a method are 256-bit intrinsic vectors with a specified cell type
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="w">The width to match</param>
        /// <param name="tCell">The cell type to match</param>
        public static bool IsFullyVectorized(this MethodInfo src, N256 w, Type tCell)        
            => src.IsFullyVectorized(w) && src.ReturnType.IsVector(w,tCell);

        /// <summary>
        /// Determines whether all parameters of a method are 512-bit intrinsic vectors with a specified cell type
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="w">The width to match</param>
        /// <param name="tCell">The cell type to match</param>
        public static bool IsFullyVectorized(this MethodInfo src, N512 w, Type tCell)        
            => src.IsFullyVectorized(w) && src.ReturnType.IsVector(w,tCell);
    }
}