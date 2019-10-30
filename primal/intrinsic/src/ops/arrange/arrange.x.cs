//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;
    using static As;

    public static class ArrangeX
    {

        /// <summary>
        /// Defines a shuffle spec from a permutation
        /// </summary>
        /// <param name="src">The defining permutation</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> ToShuffleSpec(this Perm<N16> src)
        {
            var data = src.Terms.Convert<byte>();
            return ginx.vload(n128,in head(data));
        }


        [MethodImpl(Inline)]
        public static Perm<N16> ToPerm(this Vector128<byte> src)
        {
            Span<byte> dst = new byte[16];
            vstore(src, ref head(dst));
            return Perm.Define(n16, dst.Convert<int>());
        }

        /// <summary>
        /// Defines a shuffle spec from a permutation spec
        /// </summary>
        /// <param name="src">The defining permutation</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> ToShuffleSpec(this Perm16 src)
            => src.ToPerm().ToShuffleSpec();
    }

}
