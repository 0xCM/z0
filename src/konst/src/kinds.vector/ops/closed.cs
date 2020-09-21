//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    partial class VectorKinds
    {
        /// <summary>
        /// Returns true if a type is a closed 128-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        [MethodImpl(Inline), Op]
        public static bool closed(Type t, W128 w)
            => t.IsClosedGeneric() && VectorKinds.test(t,w);

        /// <summary>
        /// Returns true if a type is a closed 256-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        [MethodImpl(Inline), Op]
        public static bool closed(Type t, W256 w)
            => t.IsClosedGeneric() && VectorKinds.test(t,w);

        /// <summary>
        /// Returns true if a type is a closed 512-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        [MethodImpl(Inline), Op]
        public static bool closed(Type t, W512 w)
            => t.IsClosedGeneric() && VectorKinds.test(t,w);

        /// <summary>
        /// Returns true if a method parameter is a closed 128-bit intrinsic vector
        /// </summary>
        /// <param name="p">The source parameter</param>
        /// <param name="w">The vector width</param>
        [MethodImpl(Inline), Op]
        public static bool closed(ParameterInfo p, W128 w)
            => p.ParameterType.IsClosedGeneric()
            && VectorKinds.test(p,w);

        /// <summary>
        /// Returns true if a method parameter is a closed 256-bit intrinsic vector
        /// </summary>
        /// <param name="p">The source parameter</param>
        /// <param name="w">The vector width</param>
        [MethodImpl(Inline), Op]
        public static bool closed(ParameterInfo p, W256 w)
            => p.ParameterType.IsClosedGeneric()
            && VectorKinds.test(p,w);

        /// <summary>
        /// Returns true if a method parameter is a closed 512-bit intrinsic vector
        /// </summary>
        /// <param name="p">The source parameter</param>
        /// <param name="w">The vector width</param>
        [MethodImpl(Inline), Op]
        public static bool closed(ParameterInfo p, W512 w)
            => p.ParameterType.IsClosedGeneric()
            && VectorKinds.test(p,w);
    }
}