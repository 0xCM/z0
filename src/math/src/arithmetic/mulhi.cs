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

    using static Konst;

    partial class math
    {
        [MethodImpl(Inline), Op]
        public static ulong mulhi(uint x, uint y)
            => MultiplyNoFlags(x,y);

        [MethodImpl(Inline), Op]
        public static ulong mulhi(ulong x, ulong y)
            => MultiplyNoFlags(x,y);
    }
}