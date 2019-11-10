//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static As;    

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
        [MethodImpl(Inline)]
        public static Vector128<T> vselect<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z)
            where T : unmanaged
                => vor(vand(x,y), vnotimply(x,z));

        /// <summary>
        /// Defines the ternary bitwise select operator over three vectors,
        /// select(x, y, z) := or(and(x, y), and(not(x), z)) = or(and(x,y), notimply(x,z));
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <param name="z">The third vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vselect<T>(Vector256<T> x, Vector256<T> y, Vector256<T> z)
            where T : unmanaged
                => vor(vand(x,y), vnotimply(x,z));

        [MethodImpl(Inline)]
        public static unsafe Vector128<T> vselect<T>(N128 n, in T rX, in T rY, in T rZ)
            where T : unmanaged
        {                    
            vload(rX, out Vector128<T> vA);
            vload(rY, out Vector128<T> vB);
            vload(rZ, out Vector128<T> vC);
            return vselect(vA,vB,vC);
        }

        [MethodImpl(Inline)]
        public static unsafe void vselect<T>(N128 n, in T rX, in T rY, in T rZ, ref T rDst)
            where T : unmanaged
                => vstore(vselect(n, in rX, in rY, in rZ), ref rDst);

        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vselect<T>(N256 n, in T rX, in T rY, in T rZ)
            where T : unmanaged
        {                    
            vload(rX, out Vector256<T> vA);
            vload(rY, out Vector256<T> vB);
            vload(rZ, out Vector256<T> vC);
            return vselect(vA,vB,vC);
        }

        [MethodImpl(Inline)]
        public static unsafe void vselect<T>(N256 n, in T rX, in T rY, in T rZ, ref T rDst)
            where T : unmanaged
                => vstore(vselect(n, in rX, in rY, in rZ), ref rDst);

    }

}
