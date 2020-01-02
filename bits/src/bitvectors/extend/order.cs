//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitVectorX
    {

        /// <summary>
        /// Computes the smallest integer n > 1 such that v^n = identity
        /// </summary>
        [MethodImpl(Inline)]
        public static int Order(this BitVector8 src)
            => BitVector.ord(src);


    }
}