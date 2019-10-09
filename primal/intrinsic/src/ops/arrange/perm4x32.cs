//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
        
    using static zfunc;

    partial class dinx    
    {        
       /// <summary>
        /// Rearranges the components of the source vector according to an identified permutation
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The permutation identifier</param>
        [MethodImpl(Inline)]
        public static Vec128<int> vperm4x32(in Vec128<int> src, Perm4 spec)
            => Shuffle(src.xmm, (byte)spec);

        [MethodImpl(Inline)]
        public static Vec128<uint> vperm4x32(in Vec128<uint> src, Perm4 spec)
            => Shuffle(src.xmm, (byte)spec);


    }

}