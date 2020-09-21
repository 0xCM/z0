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

    public partial interface TIdentityReflector
    {
        /// <summary>
        /// Determines whether a method has intrinsic paremeters or return type of specified width
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        bool IsVectorized(MethodInfo src, int? width, bool total)
            => total ? (VectorKinds.test(src.ReturnType,width) && src.ParameterTypes().All(t => VectorKinds.test(t,width)))
                     : (VectorKinds.test(src.ReturnType,width) || src.ParameterTypes().Any(t => VectorKinds.test(t,width)));

        /// <summary>
        /// Determines whether a method has intrinsic parameters or return type
        /// </summary>
        /// <param name="src">The method to test</param>
        bool IsVectorized(MethodInfo src)
            => src.ReturnType.IsVector() || src.ParameterTypes().Any(VectorKinds.test);

        /// <summary>
        /// Determines whether a method has at least one 128-bit intrinsic vector parameter
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="w">The width to match</param>
        bool IsVectorized(MethodInfo m, W128 w)
            => IsVectorized(m) && m.Parameters(p => p.ParameterType.IsVector(w)).Count() != 0;

        /// <summary>
        /// Determines whether a method has at least one 128-bit intrinsic vector parameter
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="w">The width to match</param>
        bool IsVectorized(MethodInfo m, W256 w)
            => IsVectorized(m) && m.Parameters(p => p.ParameterType.IsVector(w)).Count() != 0;

        /// <summary>
        /// Determines whether a method has at least one 128-bit intrinsic vector parameter
        /// </summary>
        /// <param name="src">The method to examine</param>
        /// <param name="w">The width to match</param>
        bool IsVectorized(MethodInfo src, W512 w)
            => IsVectorized(src) && src.Parameters(p => p.ParameterType.IsVector(w)).Count() != 0;

        /// <summary>
        /// Determines whether a method has at least one 128-bit intrinsic vector parameter closed over a specified type
        /// </summary>
        /// <param name="src">The method to examine</param>
        /// <param name="w">The width to match</param>
        bool IsVectorized(MethodInfo src, W128 w, Type tCell)
            => IsVectorized(src) && src.Parameters(p => p.ParameterType.IsVector(w,tCell)).Count() != 0;

        /// <summary>
        /// Determines whether a method has at least one 256-bit intrinsic vector parameter closed over a specified type
        /// </summary>
        /// <param name="src">The method to examine</param>
        /// <param name="w">The width to match</param>
        bool IsVectorized(MethodInfo src, W256 w, Type tCell)
            => IsVectorized(src) && src.Parameters(p => p.ParameterType.IsVector(w,tCell)).Count() != 0;

        /// <summary>
        /// Determines whether a method has at least one 512-bit intrinsic vector parameter closed over a specified type
        /// </summary>
        /// <param name="src">The method to examine</param>
        /// <param name="w">The width to match</param>
        bool IsVectorized(MethodInfo src, W512 w, Type tCell)
            => IsVectorized(src,w) && src.Parameters(p => p.ParameterType.IsVector(w,tCell)).Count() != 0;

        /// <summary>
        /// Selcts vectorized methods from a source stream
        /// </summary>
        /// <param name="src">The source strean</param>
        /// <param name="w">The vector width</param>
        /// <param name="g">The generic partition from which methods should be selected</param>
        bool IsVectorized(MethodInfo src, W128 w, GenericState g = default)
            => IsVectorized(src,w) && src.IsMemberOf(g);

        /// <summary>
        /// Selcts vectorized methods from a source stream
        /// </summary>
        /// <param name="src">The source strean</param>
        /// <param name="w">The vector width</param>
        /// <param name="g">The generic partition from which methods should be selected</param>
        bool IsVectorized(MethodInfo src, W256 w, GenericState g = default)
            => IsVectorized(src, w) && src.IsMemberOf(g);

        /// <summary>
        /// Selcts vectorized methods from a source stream
        /// </summary>
        /// <param name="src">The source strean</param>
        /// <param name="w">The vector width</param>
        /// <param name="g">The generic partition from which methods should be selected</param>
        bool IsVectorized(MethodInfo src, W512 w, GenericState g = default)
            => src.IsVectorized(w) && src.IsMemberOf(g);
    }
}