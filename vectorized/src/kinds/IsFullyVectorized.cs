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

    partial class VectorClassOps
    {
        /// <summary>
        /// Determines whether a method has intrinsic parameters or return type
        /// </summary>
        /// <param name="src">The method to test</param>
        public static bool IsFullyVectorized(this MethodInfo src)        
            => VectorType.test(src.ReturnType) && src.ParameterTypes().All(VectorType.test);                     

        /// <summary>
        /// Determines whether a method is a vectorized operator which, by definition, is an operator 
        /// (which, by definition, is an homogenous function) with a vectorized operand which, by definition, 
        /// is an operand of intrinsic vector type (which, by definition, is one of the system-defined intrinsic vector types
        /// or a custom instrinsic vector type)
        /// </summary>
        /// <param name="src">The method to test</param>
        public static bool IsVectorizedOperator(this MethodInfo src)
            => src.IsOperator() && src.ReturnType.IsVector();

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