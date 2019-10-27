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

    partial class BitPoints
    {

        [MethodImpl(Inline)]
        public static unsafe void andnot<T>(T* pA, T* pB, T* pDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               andnot((byte*)pA, (byte*)pB, (byte*)pDst);
            else if(typeof(T) == typeof(ushort))
                andnot((ushort*)pA, (ushort*)pB, (ushort*)pDst);
            else if(typeof(T) == typeof(uint))
                andnot((uint*)pA, (uint*)pB, (uint*)pDst);
            else if(typeof(T) == typeof(ulong))
                andnot((ulong*)pA, (ulong*)pB, (ulong*)pDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void andnot(byte* pA, byte* pB, byte* pDst)
            => content(math.andnot(content(pA), content(pB)), pDst);

        [MethodImpl(Inline)]
        static unsafe void andnot(ushort* pA, ushort* pB, ushort* pDst)
            => ginx.vstore(ginx.vandnot(n, pA, pB),pDst);

        [MethodImpl(Inline)]
        static unsafe void andnot(uint* pA, uint* pB, uint* pDst)
        {
            const int step = 8;
            ginx.vandnot(n, pA,pB,pDst);
            ginx.vandnot(n, pA+=step,pB+=step,pDst+=step);
            ginx.vandnot(n, pA+=step,pB+=step,pDst+=step);
            ginx.vandnot(n, pA+=step,pB+=step,pDst+=step);
        }

        [MethodImpl(Inline)]
        static unsafe void andnot(ulong* pA, ulong* pB, ulong* pDst)
        {
            const int step = 4;
            const int offset = step*8;            
            andnot8(pA, pB, pDst);
            andnot8(pA + offset, pB + offset, pDst + offset);
        }

        [MethodImpl(Inline)]
        static unsafe void andnot8(ulong* pA, ulong* pB, ulong* pDst)
        {            
            const int step = 4;
            ginx.vandnot(n, pA, pB, pDst);
            ginx.vandnot(n, pA+=step, pB+=step,pDst+=step);
            ginx.vandnot(n, pA+=step, pB+=step,pDst+=step);
            ginx.vandnot(n, pA+=step, pB+=step,pDst+=step);

            ginx.vandnot(n, pA+=step, pB+=step,pDst+=step);
            ginx.vandnot(n, pA+=step, pB+=step,pDst+=step);
            ginx.vandnot(n, pA+=step, pB+=step,pDst+=step);
            ginx.vandnot(n, pA+=step, pB+=step,pDst+=step);
        }        
    }
}