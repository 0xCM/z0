//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static zfunc;        

    partial class math
    {
        [MethodImpl(Inline)]
        public static ulong pow2(int exp)
            => 1ul << exp;

        [MethodImpl(Inline)]
        public static ulong pow2m1(int exp)
            => pow2(exp) - 1;
    }
}