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
        /// Determines whether a method returns an intrinsic vector
        /// </summary>
        /// <param name="src">The method to test</param>
        public static bool ReturnsVector(this MethodInfo src)
            => src.ReturnType.IsVector();

        /// <summary>
        /// Determines whether a method returns a 128-bit intrinsic vector
        /// </summary>
        /// <param name="src">The method to test</param>
        public static bool ReturnsVector(this MethodInfo src, W128 w)
            => src.ReturnType.IsVector(w);

        /// <summary>
        /// Determines whether a method returns a 256-bit intrinsic vector
        /// </summary>
        /// <param name="src">The method to test</param>
        public static bool ReturnsVector(this MethodInfo src, W256 w)
            => src.ReturnType.IsVector(w);

        /// <summary>
        /// Determines whether a method returns a 256-bit intrinsic vector
        /// </summary>
        /// <param name="src">The method to test</param>
        public static bool ReturnsVector(this MethodInfo src, W512 w)
            => src.ReturnType.IsVector(w);

        /// <summary>
        /// Determines whether a method returns a 128-bit intrinsic vector of specified cell type
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="w">The width to match</param>
        /// <param name="tCell">The cell type to match</param>
        public static bool ReturnsVector(this MethodInfo src, W128 w, Type tCell)
            => src.ReturnType.IsVector(w, tCell);

        /// <summary>
        /// Determines whether a method returns a 256-bit intrinsic vector of specified cell type
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="w">The width to match</param>
        /// <param name="tCell">The cell type to match</param>
        public static bool ReturnsVector(this MethodInfo src, W256 w, Type tCell)
            => src.ReturnType.IsVector(w, tCell);

        /// <summary>
        /// Determines whether a method returns a 512-bit intrinsic vector with of specified cell type
        /// </summary>
        /// <param name="src">The method to test</param>
        /// <param name="w">The width to match</param>
        /// <param name="tCell">The cell type to match</param>
        public static bool ReturnsVector(this MethodInfo src, W512 w, Type tCell)
            => src.ReturnType.IsVector(w, tCell);
    }
}