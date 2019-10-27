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
        static N256 n => n256;

        [MethodImpl(Inline)]
        public static unsafe void nor<T>(T* pA, T* pB, T* pDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               nor((byte*)pA, (byte*)pB, (byte*)pDst);
            else if(typeof(T) == typeof(ushort))
                nor((ushort*)pA, (ushort*)pB, (ushort*)pDst);
            else if(typeof(T) == typeof(uint))
                nor((uint*)pA, (uint*)pB, (uint*)pDst);
            else if(typeof(T) == typeof(ulong))
                nor((ulong*)pA, (ulong*)pB, (ulong*)pDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void nor(byte* pA, byte* pB, byte* pDst)
            => content(math.nor(content(pA), content(pB)), pDst);

        [MethodImpl(Inline)]
        static unsafe void nor(ushort* pA, ushort* pB, ushort* pDst)
            => ginx.vstore(ginx.vnor(n256, pA, pB),pDst);

        [MethodImpl(Inline)]
        static unsafe void nor(uint* pA, uint* pB, uint* pDst)
        {
            const int step = 8;
            ginx.vnor(n, pA,pB,pDst);
            ginx.vnor(n, pA+=step,pB+=step,pDst+=step);
            ginx.vnor(n, pA+=step,pB+=step,pDst+=step);
            ginx.vnor(n, pA+=step,pB+=step,pDst+=step);
        }

        [MethodImpl(Inline)]
        static unsafe void nor(ulong* pA, ulong* pB, ulong* pDst)
        {
            const int step = 4;
            const int offset = step*8;            
            nor8(pA, pB, pDst);
            nor8(pA + offset, pB + offset, pDst + offset);
        }

        [MethodImpl(Inline)]
        static unsafe void nor8(ulong* pA, ulong* pB, ulong* pDst)
        {            
            const int step = 4;
            ginx.vnor(n256, pA, pB, pDst);
            ginx.vnor(n256, pA+=step, pB+=step,pDst+=step);
            ginx.vnor(n256, pA+=step, pB+=step,pDst+=step);
            ginx.vnor(n256, pA+=step, pB+=step,pDst+=step);

            ginx.vnor(n256, pA+=step, pB+=step,pDst+=step);
            ginx.vnor(n256, pA+=step, pB+=step,pDst+=step);
            ginx.vnor(n256, pA+=step, pB+=step,pDst+=step);
            ginx.vnor(n256, pA+=step, pB+=step,pDst+=step);
        }        


    }

}