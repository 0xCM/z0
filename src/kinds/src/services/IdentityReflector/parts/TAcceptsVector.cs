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
 
    partial interface TIdentityReflector
    {
        /// <summary>
        /// Determines whether a method accepts an intrinsic vector in some parameter slot
        /// </summary>
        /// <param name="src">The method to test</param>
        bool AcceptsVector(MethodInfo src)
            => src.Parameters(p => p.IsVector()).Any();

        /// <summary>
        /// Determines whether a method accepts an intrinsic vector at an index-identified parameter
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="index">THe parameter index to match</param>
        bool AcceptsVector(MethodInfo src, int index)
            => src.Parameters(p => p.Position == index && p.IsVector()).Any();

        /// <summary>
        /// Determines whether a method accepts a 128-bit intrinsic vector at an index-identified parameter
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="index">THe parameter index to match</param>
        /// <param name="w">The width to match</param>
        bool AcceptsVector(MethodInfo src, int index, W128 w)
            => src.Parameters(p => p.Position == index && p.IsVector(w)).Any();

        /// <summary>
        /// Determines whether a method accepts a 128-bit intrinsic vector at an index-identified parameter
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="index">THe parameter index to match</param>
        /// <param name="w">The width to match</param>
        bool AcceptsVector(MethodInfo src, int index, W256 w)
            => src.Parameters(p => p.Position == index && p.IsVector(w)).Any();

        /// <summary>
        /// Determines whether a method accepts a 128-bit intrinsic vector at an index-identified parameter
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="index">THe parameter index to match</param>
        /// <param name="w">The width to match</param>
        bool AcceptsVector(MethodInfo src, int index, W512 w)
            => src.Parameters(p => p.Position == index && p.IsVector(w)).Any();

        /// <summary>
        /// Determines whether a method accepts a 128-bit intrinsic vector at an index-identified parameter of specified cell type
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="index">THe parameter index to match</param>
        /// <param name="w">The width to match</param>
        /// <param name="tCell">The cell type to match</param>
        bool AcceptsVector(MethodInfo src, int index, W128 w, Type tCell)
            => src.Parameters(p => p.Position == index && p.IsVector(w,tCell)).Any();

        /// <summary>
        /// Determines whether a method accepts a 256-bit intrinsic vector at an index-identified parameter of specified cell type
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="index">THe parameter index to match</param>
        /// <param name="w">The width to match</param>
        /// <param name="tCell">The cell type to match</param>
        bool AcceptsVector(MethodInfo src, int index, W256 w, Type tCell)
            => src.Parameters(p => p.Position == index && p.IsVector(w,tCell)).Any();

        /// <summary>
        /// Determines whether a method accepts a 512-bit intrinsic vector at an index-identified parameter of specified cell type
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="index">The parameter index to match</param>
        /// <param name="w">The width to match</param>
        /// <param name="tCell">The cell type to match</param>
        bool AcceptsVector(MethodInfo src, int index, W512 w, Type tCell)
            => src.Parameters(p => p.Position == index && p.IsVector(w,tCell)).Any();
    }
}