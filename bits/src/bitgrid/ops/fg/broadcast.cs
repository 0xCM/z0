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

    using static zfunc;

    partial class BitGrid
    {
        [MethodImpl(Inline)]
        public static ref readonly BitGrid64<T> broadcast<T>(bit state, out BitGrid64<T> dst)    
            where T : unmanaged
        {
            dst = state ? maxval<ulong>() : 0ul;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly BitGrid128<T> broadcast<T>(T cell, out BitGrid128<T> dst)    
            where T : unmanaged
        {
            dst = ginx.vbroadcast(n128,cell);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly BitGrid256<T> broadcast<T>(T cell, out BitGrid256<T> dst)    
            where T : unmanaged
        {
            dst = ginx.vbroadcast(n256,cell);
            return ref dst;
        }



    }

}