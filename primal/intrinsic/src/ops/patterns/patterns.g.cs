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
        [MethodImpl(Inline)]
        public static Vector128<T> vzero<T>(N128 n)
            where T : unmanaged
               => default;

        [MethodImpl(Inline)]
        public static Vector256<T> vzero<T>(N256 n)
            where T : unmanaged
               => default;

        [MethodImpl(Inline)]
        public static Vector128<T> vones<T>(N128 n)
            where T : unmanaged
               => Vec128Pattern.ones<T>();

        [MethodImpl(Inline)]
        public static Vector256<T> vones<T>(N256 n)
            where T : unmanaged
                => Vec256Pattern.ones<T>();

        [MethodImpl(Inline)]
        public static Vector128<T> vunits<T>(N128 n)
            where T : unmanaged
                => Vec128Pattern.units<T>();

        [MethodImpl(Inline)]
        public static Vector256<T> vunits<T>(N256 n)
            where T : unmanaged
                => Vec256Pattern.units<T>();

        [MethodImpl(Inline)]
        public static Vector128<T> vincrements<T>(N128 n,T first = default, params Swap[] swaps)
            where T : unmanaged
                => Vec128Pattern.increments<T>(first,swaps);

        [MethodImpl(Inline)]
        public static Vector256<T> vincrements<T>(N256 n,T first = default, params Swap[] swaps)
            where T : unmanaged
                => Vec256Pattern.increments<T>(first,swaps);        

        [MethodImpl(Inline)]
        public static Vector128<T> vdecrements<T>(N128 n, T first, params Swap[] swaps)
            where T : unmanaged
                => Vec128Pattern.decrements<T>(first,swaps);

        [MethodImpl(Inline)]
        public static Vector256<T> vdecrements<T>(N256 n, T first, params Swap[] swaps)
            where T : unmanaged
                => Vec256Pattern.decrements<T>(first,swaps);        

        /// <summary>
        /// Returns a vector that decribes a lo/hi lane merge permutation
        /// For example, if X = [A E B F | C G D H] then the lane merge pattern P will
        /// describe a permutation that has the following effect: permute(X,P) = [A B C D | E F G H]
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vpLaneMerge<T>()
            where T : unmanaged
                => Vec256Pattern.LaneMerge<T>();


    }

}