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

    partial class CpuVecX
    {
        /// <summary>
        /// Defines a shuffle spec from a permutation
        /// </summary>
        /// <param name="src">The defining permutation</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> ToShuffleSpec(this NatPerm<N16> src)
        {
            var data = src.Terms.Convert<byte>();
            return ginx.vload(n128,in head(data));
        }

        [MethodImpl(Inline)]
        public static NatPerm<N16> ToPerm(this Vector128<byte> src)
        {
            Span<byte> dst = new byte[16];
            vstore(src, ref head(dst));
            return Perm.natural(n16, dst.Convert<int>());
        }

    }

}
