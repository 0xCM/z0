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

    partial class XVexKinds
    {
        /// <summary>
        /// Determines whether a parameter is of intrinsic vector type
        /// </summary>
        /// <param name="p">The parameter to examine</param>
        public static bool IsVector(this ParameterInfo p)
            => VexKinds.test(p);

        /// <summary>
        /// Determines whether a parameter is of type 128-bit intrinsic vector
        /// </summary>
        /// <param name="p">The parameter to examine</param>
        public static bool IsVector(this ParameterInfo p, W128 w)
            => VexKinds.test(p,w);

        /// <summary>
        /// Determines whether a parameter is of type 256-bit intrinsic vector
        /// </summary>
        /// <param name="p">The parameter to examine</param>
        public static bool IsVector(this ParameterInfo p, W256 w)
            => VexKinds.test(p,w);

        /// <summary>
        /// Determines whether a parameter is of type 512-bit intrinsic vector
        /// </summary>
        /// <param name="p">The parameter to examine</param>
        public static bool IsVector(this ParameterInfo p, W512 w)
            => VexKinds.test(p,w);


        /// <summary>
        /// Returns true if a method parameter is a 128-bit intrinsic vector closed over a specified argument type
        /// </summary>
        /// <param name="p">The source parameter</param>
        /// <param name="w">The vector width</param>
        /// <param name="tCell">The argument type to match</param>
        public static bool IsVector(this ParameterInfo p, W128 w, Type tCell)
            => VexKinds.test(p,w,tCell);

        /// <summary>
        /// Returns true if a method parameter is a 256-bit intrinsic vector closed over a specified argument type
        /// </summary>
        /// <param name="p">The source parameter</param>
        /// <param name="w">The vector width</param>
        /// <param name="tCell">The argument type to match</param>
        public static bool IsVector(this ParameterInfo p, W256 w, Type tCell)
            => VexKinds.test(p,w,tCell);

        /// <summary>
        /// Returns true if a method parameter is a 512-bit intrinsic vector closed over a specified argument type
        /// </summary>
        /// <param name="p">The source parameter</param>
        /// <param name="w">The vector width</param>
        /// <param name="tCell">The argument type to match</param>
        public static bool IsVector(this ParameterInfo p, W512 w, Type tCell)
            => VexKinds.test(p,w,tCell);
    }
}