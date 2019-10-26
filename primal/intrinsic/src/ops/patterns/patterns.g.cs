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
        public static Vector128<T> vpOnes<T>(N128 n)
            where T : unmanaged
               => Vec128Pattern.Ones<T>();

        [MethodImpl(Inline)]
        public static Vector128<T> vpUnits<T>(N128 n)
            where T : unmanaged
                => Vec128Pattern.Units<T>();

        [MethodImpl(Inline)]
        public static Vector128<T> vpIncrements<T>(N128 n)
            where T : unmanaged
                => Vec128Pattern.Increments<T>();

        
        [MethodImpl(Inline)]
        public static Vector256<T> vpOnes<T>(N256 n)
            where T : unmanaged
                => Vec256Pattern.Ones<T>();


        [MethodImpl(Inline)]
        public static Vector256<T> vpUnits<T>(N256 n)
            where T : unmanaged
                => Vec256Pattern.Units<T>();


        /// <summary>
        /// Returns a vector that decribes a lo/hi lane merge permutation
        /// For example, if X = [A E B F | C G D H] then the lane merge pattern P will
        /// describe a permutation that has the following effect: permute(X,P) = [A B C D | E F G H]
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vpLaneMerge<T>()
            where T : unmanaged
                => Vec256Pattern.LaneMergeVector<T>();


    }

}