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
        public static Vector256<uint> pack8(Vector256<uint> w0, ref uint src, int offset)
        {
            w0 = step(w0, ref src, offset + 0);
            w0 = step(w0, ref src, offset + 1);
            w0 = step(w0, ref src, offset + 2);
            w0 = step(w0, ref src, offset + 3);
            w0 = step(w0, ref src, offset + 4);
            w0 = step(w0, ref src, offset + 5);
            w0 = step(w0, ref src, offset + 6);
            w0 = step(w0, ref src, offset + 7);
            return w0;
        
        }

        [MethodImpl(Inline)]
        public static void pack(N1 _, ref uint src, ref uint dst)
        {
            var n = n256;
            var w0 = ginx.vload(n, in src);
            w0 = step(w0, ref src, 1);
            w0 = step(w0, ref src, 2);
            w0 = step(w0, ref src, 3);
            w0 = step(w0, ref src, 4);
            w0 = step(w0, ref src, 5);
            w0 = step(w0, ref src, 6);
            w0 = step(w0, ref src, 7);
            w0 = step(w0, ref src, 8);
            w0 = step(w0, ref src, 9);
            w0 = step(w0, ref src, 10);
            w0 = step(w0, ref src, 11);
            w0 = step(w0, ref src, 12);
            w0 = step(w0, ref src, 13);
            w0 = step(w0, ref src, 14);
            w0 = step(w0, ref src, 15);
            w0 = step(w0, ref src, 16);
            w0 = step(w0, ref src, 17);
            w0 = step(w0, ref src, 18);
            w0 = step(w0, ref src, 19);
            w0 = step(w0, ref src, 20);
            w0 = step(w0, ref src, 21);
            w0 = step(w0, ref src, 22);
            w0 = step(w0, ref src, 23);
            w0 = step(w0, ref src, 24);
            w0 = step(w0, ref src, 25);                        
            w0 = step(w0, ref src, 26);
            w0 = step(w0, ref src, 27);
            w0 = step(w0, ref src, 28);
            w0 = step(w0, ref src, 29);
            w0 = step(w0, ref src, 30);
            w0 = step(w0, ref src, 31);
            ginx.vstore(w0, ref dst);
        }
    }

}




