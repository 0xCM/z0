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
        
    using static Seed;
       
    partial class Numeric
    {
        [MethodImpl(Inline)]
        public static ulong mulhi(ulong x, ulong y)
            => Bmi2.X64.MultiplyNoFlags(x,y);
    }

    partial class Scalar
    {
        [MethodImpl(Inline)]
        public static ulong mulhi(ulong x, ulong y)
            => Bmi2.X64.MultiplyNoFlags(x,y);

    }
}