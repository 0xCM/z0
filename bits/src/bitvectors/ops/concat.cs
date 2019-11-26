//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    
    using static nfunc;
    using static As;

    partial class BitVector
    {
        [MethodImpl(Inline)]
        public static BitVector16 concat(BitVector8 lo, BitVector8 hi)
            => from(n16, lo.data, hi.data);

        [MethodImpl(Inline)]
        public static BitVector32 concat(BitVector16 lo, BitVector16 hi)
            => from(n32, lo.data, hi.data);

        [MethodImpl(Inline)]
        public static BitVector32 concat(BitVector8 x0, BitVector8 x1, BitVector8 x2,  BitVector8 x3)
            => from(n32, x0.data, x1.data, x2.data, x3.data);

        [MethodImpl(Inline)]
        public static BitVector64 concat(BitVector16 x0, BitVector16 x1, BitVector16 x2, BitVector16 x3)
            => from(n64, x0.data, x1.data, x2.data, x3.data);

        [MethodImpl(Inline)]
        public static BitVector64 concat(BitVector32 lo, BitVector32 hi)
            => from(n64, lo.data, hi.data);

        [MethodImpl(Inline)]
        public static BitVector128 concat(BitVector64 lo, BitVector64 hi)
            => from(n128, lo.data, hi.data);

        [MethodImpl(Inline)]
        public static BitVector128 concat(BitVector32 x0, BitVector32 x1, BitVector32 x2, BitVector32 x3)
            => from(n128, x0.data, x1.data, x2.data, x3.data);

    }

}