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
    using static ginx;
    using static As;

    partial class CpuVector
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
                => vblend(vbroadcast(n,a), vbroadcast(n,b), VData.blendspec<T>(n,false));

        /// <summary>
        /// Creates a shuffle mask that clears ever-other vector component
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vclearalt<T>(N256 n)
            where T : unmanaged
                => VData.clearalt<T>(n);

        /// <summary>
        /// Creates a vector that decribes a lo/hi lane merge permutation
        /// For example, if X = [A E B F | C G D H] then the lane merge pattern P will
        /// describe a permutation that has the following effect: permute(X,P) = [A B C D | E F G H]
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vlanemerge<T>()
            where T : unmanaged
                => VData.lanemerge<T>();
                
        /// <summary>
        /// Defines a vector of 32 or 64-bit floating point values where each component has been intialized to the value -0.0
        /// </summary>
        /// <typeparam name="T">The floating point type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vfpsign<T>(N256 n)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vbroadcast(n256,-0.0f));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vbroadcast(n256,-0.0));
            else 
                return default;
        }
    }
}