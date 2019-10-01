//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;

    partial class BitMatrix
    {
        [MethodImpl(Inline)]
        public static BitMatrix8 negate(in BitMatrix8 A)
            => flip(A);

        [MethodImpl(Inline)]
        public static BitMatrix16 negate(in BitMatrix16 A)
            => flip(A);

        [MethodImpl(Inline)]
        public static BitMatrix32 negate(in BitMatrix32 A)
            => flip(A);

        [MethodImpl(Inline)]
        public static BitMatrix64 negate(in BitMatrix64 A)
            => flip(A);

    }

}