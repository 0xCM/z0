//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    partial struct vex
    {


    }

    partial struct z
    {
        /// <summary>
        /// Presents a generic cpu vector as a cpu vector with components of type uint32
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<uint> v32u<T>(Vector128<T> x)
            where T : unmanaged
                => x.AsUInt32();

        /// <summary>
        /// Presents a generic cpu vector as a cpu vector with components of type uint32
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The source vector primal component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<uint> v32u<T>(Vector256<T> x)
            where T : unmanaged
                => x.AsUInt32();
    }
}