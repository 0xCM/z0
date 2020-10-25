//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class XVexKinds
    {
        /// <summary>
        /// Determines whether a type is classified as an intrinsic vector
        /// </summary>
        /// <param name="t">The type to test</param>
        [Op]
        public static bool IsVector(this Type t)
            => VexReflex.IsVector(t);

        /// <summary>
        /// Determines whether a type is a 128-bit intrinsic vector closed over a specified type
        /// </summary>
        /// <param name="t">The type to examine</param>
        [Op]
        public static bool IsVector(this Type t, W128 w, Type tCell)
            => VexKinds.test(t,w,tCell);

        /// <summary>
        /// Determines whether a type is a 256-bit intrinsic vector closed over a specified type
        /// </summary>
        /// <param name="t">The type to examine</param>
        [Op]
        public static bool IsVector(this Type t, W256 w, Type tCell)
            => VexKinds.test(t,w,tCell);

        /// <summary>
        /// Determines whether a type is a 512-bit intrinsic vector closed over a specified type
        /// </summary>
        /// <param name="t">The type to examine</param>
        [Op]
        public static bool IsVector(this Type t, W512 w, Type tCell)
            => VexKinds.test(t,w,tCell);

        /// <summary>
        /// Determines whether a type is a 128-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [Op]
        public static bool IsVector(this Type t, W128 w)
            => VexKinds.test(t,w);

        /// <summary>
        /// Determines whether a type is a 256-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [Op]
        public static bool IsVector(this Type t, W256 w)
            => VexKinds.test(t,w);

        /// <summary>
        /// Determines whether a type is a 512-bit intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [Op]
        public static bool IsVector(this Type t, W512 w)
            => VexKinds.test(t,w);
    }
}