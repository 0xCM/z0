//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;


    partial class zfoc
    {
        public static void mul_full_64u(in Pair<ulong> src, ref Pair<ulong> dst)
            => BmiMul.full(in src, ref dst);

        public static void mul_full_32u(in Pair<uint> src, ref Pair<uint> dst)
            => BmiMul.full(in src, ref dst);

    }


}