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
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static As;

    partial class BitMatrix
    {
        [MethodImpl(Inline)]
        public static BitMatrix8 sub(BitMatrix8 A, BitMatrix8 B)
            => A ^(- B);

        [MethodImpl(Inline)]
        public static BitMatrix16 sub(BitMatrix16 A, BitMatrix16 B)
            => A ^(- B);

        [MethodImpl(Inline)]
        public static BitMatrix32 sub(BitMatrix32 A, BitMatrix32 B)
            => A ^(- B);

        [MethodImpl(Inline)]
        public static BitMatrix64 sub(BitMatrix64 A, BitMatrix64 B)
            => A ^(- B);


    }

}