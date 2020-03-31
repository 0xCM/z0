//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    
    using static Core;
 
    partial class Data
    {
        /// <summary>
        /// Creates a vector that decribes a lo/hi lane merge permutation
        /// For example, if X = [A E B F | C G D H] then the lane merge pattern P will
        /// describe a permutation that has the following effect: permute(X,P) = [A B C D | E F G H]
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> lanemerge<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vload<T>(n256,LaneMerge256x8u);
            else if(typeof(T) == typeof(ushort))
                return vload<T>(n256,LaneMerge256x16u);
            else 
                return default;
        }

        static ReadOnlySpan<byte> LaneMerge256x8u 
            => new byte[32]{
                00,02,04,06,08,10,12,14,
                16,18,20,22,24,26,28,30,
                01,03,05,07,09,11,13,15,
                17,19,21,23,25,27,29,31};
        
        static ReadOnlySpan<byte> LaneMerge256x16u 
            => new byte[32]{
                0x00,0x00,0x02,0x00,0x04,0x00,0x06,0x00,
                0x08,0x00,0x0A,0x00,0x0C,0x00,0x0E,0x00,
                0x01,0x00,0x03,0x00,0x05,0x00,0x07,0x00,
                0x09,0x00,0x0B,0x00,0x0D,0x00,0x0F,0x00};        
    }
}