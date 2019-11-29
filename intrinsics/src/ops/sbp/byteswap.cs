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

    partial class dinx
    {        
        [MethodImpl(Inline)]
        public static Vector128<ushort> vbyteswap(Vector128<ushort> x)
        {
            var spec = PatternData.byteswap(n128,n16);
            return v16u(vshuf16x8(v8u(x), spec));
        }

        [MethodImpl(Inline)]
        public static Vector128<uint> vbyteswap(Vector128<uint> x)
        {
            var spec = PatternData.byteswap(n128,n32);
            return v32u(vshuf16x8(v8u(x), spec));
        }

        [MethodImpl(Inline)]
        public static Vector128<ulong> vbyteswap(Vector128<ulong> x)
        {
            var spec = PatternData.byteswap(n128,n64);
            return v64u(vshuf16x8(v8u(x), spec));
        }

        [MethodImpl(Inline)]
        public static Vector256<ushort> vbyteswap(Vector256<ushort> x)
        {
            var spec = PatternData.byteswap(n256,n16);
            return v16u(vshuf16x8(v8u(x), spec));
        }

        [MethodImpl(Inline)]
        public static Vector256<uint> vbyteswap(Vector256<uint> x)
        {
            var spec = PatternData.byteswap(n256,n32);
            return v32u(vshuf16x8(v8u(x), spec));
        }

        [MethodImpl(Inline)]
        public static Vector256<ulong> vbyteswap(Vector256<ulong> x)
        {
            var spec = PatternData.byteswap(n256,n64);
            return v64u(vshuf16x8(v8u(x), spec));
        }
    }
}