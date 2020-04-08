//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    public static class VRand
    {
        /// <summary>
        /// Creates a 128-bit vectorized emitter predicated an a specified random source
        /// </summary>
        /// <param name="w">The vector bit width</param>
        /// <param name="random">The random source</param>
        /// <param name="t">A vector component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static VRandom128<T> emitter<T>(N128 w, IPolyrand random, T t = default)  
            where T : unmanaged
                => new VRandom128<T>(random);

        /// <summary>
        /// Creates a 256-bit vectorized emitter predicated an a specified random source
        /// </summary>
        /// <param name="w">The vector bit width</param>
        /// <param name="random">The random source</param>
        /// <param name="t">A vector component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static VRandom256<T> emitter<T>(N256 w, IPolyrand random, T t = default)  
            where T : unmanaged
                => new VRandom256<T>(random);
    }

}