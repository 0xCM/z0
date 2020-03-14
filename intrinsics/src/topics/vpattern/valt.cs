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
    
    using static Root;    
 
    partial class vpattern
    {
        /// <summary>
        /// Creates a vector populated with component values that alternate between the first operand and the second
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> valt<T>(N256 n, T a, T b)
            where T : unmanaged
                => gvec.vblend(vgeneric.vbroadcast(n,a), vgeneric.vbroadcast(n,b), VectorData.blendspec<T>(n,false));

        /// <summary>
        /// Creates a shuffle mask that clears ever-other vector component
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vclearalt<T>(N256 n)
            where T : unmanaged
                => VectorData.clearalt<T>(n);
    }
}