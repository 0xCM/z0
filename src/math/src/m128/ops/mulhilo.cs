//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.Intrinsics.X86.Bmi2;
    using static System.Runtime.Intrinsics.X86.Bmi2.X64;
    using static Root;
    using static memory;

    partial struct Math128
    {
        [MethodImpl(Inline), MulHi]
        public static ulong mulhi(uint x, uint y)
            => MultiplyNoFlags(x,y);

        [MethodImpl(Inline), MulHi]
        public static ulong mulhi(ulong x, ulong y)
            => MultiplyNoFlags(x,y);

        [MethodImpl(Inline), MulLo]
        public static unsafe uint mullo(uint x, uint y)
        {
            var lo = 0u;
            MultiplyNoFlags(x, y, gptr(lo));
            return lo;
        }

        [MethodImpl(Inline), MulLo]
        public static unsafe ulong mullo(ulong x, ulong y)
        {
            var lo = 0ul;
            MultiplyNoFlags(x, y, &lo);
            return lo;
        }
    }
}