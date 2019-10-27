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
        public static unsafe void nand<T>(T* pA, T* pB, T* pDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               nand((byte*)pA, (byte*)pB, (byte*)pDst);
            else if(typeof(T) == typeof(ushort))
                nand((ushort*)pA, (ushort*)pB, (ushort*)pDst);
            else if(typeof(T) == typeof(uint))
                nand((uint*)pA, (uint*)pB, (uint*)pDst);
            else if(typeof(T) == typeof(ulong))
                nand((ulong*)pA, (ulong*)pB, (ulong*)pDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void nand(byte* pA, byte* pB, byte* pDst)
            => content(math.nand(content(pA), content(pB)), pDst);

        [MethodImpl(Inline)]
        static unsafe void nand(ushort* pA, ushort* pB, ushort* pDst)
            => ginx.vstore(ginx.vnand(n, pA, pB),pDst);

        [MethodImpl(Inline)]
        static unsafe void nand(uint* pA, uint* pB, uint* pDst)
        {
            const int step = 8;
            ginx.vnand(n, pA,pB,pDst);
            ginx.vnand(n, pA+=step,pB+=step,pDst+=step);
            ginx.vnand(n, pA+=step,pB+=step,pDst+=step);
            ginx.vnand(n, pA+=step,pB+=step,pDst+=step);
        }

        [MethodImpl(Inline)]
        static unsafe void nand(ulong* pA, ulong* pB, ulong* pDst)
        {
            const int step = 4;
            const int offset = step*8;            
            nand8(pA, pB, pDst);
            nand8(pA + offset, pB + offset, pDst + offset);
        }

        [MethodImpl(Inline)]
        static unsafe void nand8(ulong* pA, ulong* pB, ulong* pDst)
        {            
            const int step = 4;
            ginx.vnand(n, pA, pB, pDst);
            ginx.vnand(n, pA+=step, pB+=step,pDst+=step);
            ginx.vnand(n, pA+=step, pB+=step,pDst+=step);
            ginx.vnand(n, pA+=step, pB+=step,pDst+=step);

            ginx.vnand(n, pA+=step, pB+=step,pDst+=step);
            ginx.vnand(n, pA+=step, pB+=step,pDst+=step);
            ginx.vnand(n, pA+=step, pB+=step,pDst+=step);
            ginx.vnand(n, pA+=step, pB+=step,pDst+=step);
        }        
    }
}