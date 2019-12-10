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
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;
    
    using static zfunc;
    
    partial class dinx
    {           


        [MethodImpl(Inline)]
        static Vector128<byte> vsll8(Vector128<byte> x, byte shift)
        {            
            var y = v8u(dinx.vsll(v64u(x), shift));
            var m = vmask.msb<byte>(n128, n8, (byte)(8 - shift));
            return dinx.vand(y,m);
        }

        [MethodImpl(Inline)]
        static Vector256<byte> vsll8(Vector256<byte> x, byte shift)
        {            
            var y = v8u(dinx.vsll(v64u(x), shift));
            var m = vmask.msb<byte>(n256, n8, (byte)(8 - shift));
            return dinx.vand(y,m);
        }

        [MethodImpl(Inline)]
        public static Vector128<byte> vsrl8(Vector128<byte> x, byte shift)
        {            
            var y = v8u(dinx.vsrl(v64u(x), shift));
            var m = vmask.lsb<byte>(n128, n8, (byte)(8 - shift));
            return dinx.vand(y,m);
        }

        [MethodImpl(Inline)]
        public static Vector256<byte> vsrl8(Vector256<byte> x, byte shift)
        {            
            var y = v8u(dinx.vsrl(v64u(x), shift));
            var m = vmask.lsb<byte>(n256, n8, (byte)(8 - shift));
            return dinx.vand(y,m);
        }

    }

}