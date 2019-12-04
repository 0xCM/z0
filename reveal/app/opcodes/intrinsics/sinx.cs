//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static zfunc;


    public static class sinxoc
    {

        public static ulong sbroadcast_8x64(byte pattern)
            => gsinx.sbroadcast(pattern, out ulong _);

        public static ulong sbroadcast_8x64_const()
            => gsinx.sbroadcast((byte)0b11001100, out ulong _);

    }
}