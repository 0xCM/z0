//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    

    partial class ginx
    {
        /// <summary>
        /// Defines the ternary bitwise select operator over three vectors,
        /// select(x, y, z) := or(and(x, y), and(not(x), z)) = or(and(x,y), notimply(x,z));
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <param name="z">The third vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Integers)]
        public static Vector128<T> vselect<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z)
            where T : unmanaged
                => vor(vand(x,y), vnonimpl(x,z));

        /// <summary>
        /// Defines the ternary bitwise select operator over three vectors,
        /// select(x, y, z) := or(and(x, y), and(not(x), z)) = or(and(x,y), notimply(x,z));
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <param name="z">The third vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Integers)]
        public static Vector256<T> vselect<T>(Vector256<T> x, Vector256<T> y, Vector256<T> z)
            where T : unmanaged
                => vor(vand(x,y), vnonimpl(x,z));
    }
}
