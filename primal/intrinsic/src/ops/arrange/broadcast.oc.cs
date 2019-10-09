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
    
    
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;
    using static As;

    partial class inxvoc
    {
        public static Vec128<byte> vbroadcast_d128x8u(byte src)        
            => dinx.vbroadcast128(src);

        public static Vec128<byte> vbroadcast_g128x8u(byte src)        
            => ginx.vbroadcast128(src);

        public static Vec256<byte> vbroadcast_d256x8u(byte src)        
            => dinx.vbroadcast256(src);

        public static Vec256<byte> vbroadcast_g256x8u(byte src)        
            => ginx.vbroadcast256(src);

        public static Vec256<ulong> vbroadcast_d256x64u(ulong src)        
            => dinx.vbroadcast256(src);

        public static Vec256<ulong> vbroadcast_g256x64u(ulong src)        
            => ginx.vbroadcast256(src);

    }

}