//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Pclmulqdq;
 
    using static zfunc;
    using static dinx;        

    //https://github.com/lemire/
    public static class AvxBitpack
    {
        [MethodImpl(Inline)]
        static Vector256<uint> step(Vector256<uint> w0, ref uint src, int offset)
            => vor(w0, vsll(ginx.vload(n256, seek(ref src, offset)), (byte)offset));

        [MethodImpl(Inline)]
        static Vector256<uint> pack(int count, ref uint src, int offset)
        {
            var y = ginx.vload(n256, in src);;
            for(var i=0; i<count; i++)
                y = step(y, ref src, offset + i);
            return y;        
        }

        [MethodImpl(Inline)]
        public static Vector256<uint> pack(Span<N8,uint> src, int offset)
            => pack(8, ref src.Head, offset);

        [MethodImpl(Inline)]
        public static Vector256<uint> pack(Span<N32,uint> src, int offset)
            => pack(32, ref src.Head, offset);

        [MethodImpl(Inline)]
        public static void pack(N32 count, ref uint src, ref uint dst)
        {            
            var x = ginx.vload(n256, in src);
            for(var i = 0; i<32; i++)
                x = step(x, ref src, i);            
            ginx.vstore(x, ref dst);

        }

    }

}




