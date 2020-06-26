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
    using static Memories;
    using static VectorKonst;

    partial class VData
    {
        /// <summary>
        /// Creates a vector that decribes a lo/hi lane merge permutation
        /// For example, if X = [A E B F | C G D H] then the lane merge pattern P will
        /// describe a permutation that has the following effect: permute(X,P) = [A B C D | E F G H]
        /// </summary>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vlanemerge<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return V0.vload<T>(n256,LaneMerge256x8u);
            else if(typeof(T) == typeof(ushort))
                return V0.vload<T>(n256,LaneMerge256x16u);
            else 
                return default;
        }

    }
}