//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    


    public static class inxsoc
    {


        public static ulong broadcast_8x64(byte pattern)
            => ginxs.broadcast(pattern, out ulong _);

        public static ulong broadcast_8x64_const()
            => ginxs.broadcast((byte)0b11001100, out ulong _);

    }

}