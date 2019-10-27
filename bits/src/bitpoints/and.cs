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
        public static unsafe void and<T>(T* pA, T* pB, T* pDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               and((byte*)pA, (byte*)pB, (byte*)pDst);
            else if(typeof(T) == typeof(ushort))
                and((ushort*)pA, (ushort*)pB, (ushort*)pDst);
            else if(typeof(T) == typeof(uint))
                and((uint*)pA, (uint*)pB, (uint*)pDst);
            else if(typeof(T) == typeof(ulong))
                and((ulong*)pA, (ulong*)pB, (ulong*)pDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void and(byte* pA, byte* pB, byte* pDst)
            => content(math.and(content(pA), content(pB)), pDst);

        [MethodImpl(Inline)]
        static unsafe void and(ushort* pA, ushort* pB, ushort* pDst)
            => ginx.vstore(ginx.vand(n, pA, pB),pDst);

        [MethodImpl(Inline)]
        static unsafe void and(uint* pA, uint* pB, uint* pDst)
        {
            const int step = 8;
            ginx.vand(n, pA,pB,pDst);
            ginx.vand(n, pA+=step,pB+=step,pDst+=step);
            ginx.vand(n, pA+=step,pB+=step,pDst+=step);
            ginx.vand(n, pA+=step,pB+=step,pDst+=step);
        }

        [MethodImpl(Inline)]
        static unsafe void and(ulong* pA, ulong* pB, ulong* pDst)
        {
            const int step = 4;
            const int offset = step*8;            
            and8(pA, pB, pDst);
            and8(pA + offset, pB + offset, pDst + offset);
        }

        [MethodImpl(Inline)]
        static unsafe void and8(ulong* pA, ulong* pB, ulong* pDst)
        {            
            const int step = 4;
            ginx.vand(n, pA, pB, pDst);
            ginx.vand(n, pA+=step, pB+=step,pDst+=step);
            ginx.vand(n, pA+=step, pB+=step,pDst+=step);
            ginx.vand(n, pA+=step, pB+=step,pDst+=step);

            ginx.vand(n, pA+=step, pB+=step,pDst+=step);
            ginx.vand(n, pA+=step, pB+=step,pDst+=step);
            ginx.vand(n, pA+=step, pB+=step,pDst+=step);
            ginx.vand(n, pA+=step, pB+=step,pDst+=step);
        }        


    }

}