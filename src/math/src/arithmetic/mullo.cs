//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Bmi2;
    using static System.Runtime.Intrinsics.X86.Bmi2.X64;

    using static Konst;
    using static core;

    partial class math
    {
        [MethodImpl(Inline), Op]
        public static unsafe uint mullo(uint x, uint y)
        {
            var lo = 0u;
            MultiplyNoFlags(x,y, gptr(lo));
            return lo;
        }

        [MethodImpl(Inline), Op]
        public static unsafe ulong mullo(ulong x, ulong y)
        {
            var lo = 0ul;            
            MultiplyNoFlags(x,y, &lo);
            return lo;
        }
    }
}