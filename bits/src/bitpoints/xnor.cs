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
        public static unsafe void xnor<T>(T* pA, T* pB, T* pDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               xnor((byte*)pA, (byte*)pB, (byte*)pDst);
            else if(typeof(T) == typeof(ushort))
                xnor((ushort*)pA, (ushort*)pB, (ushort*)pDst);
            else if(typeof(T) == typeof(uint))
                xnor((uint*)pA, (uint*)pB, (uint*)pDst);
            else if(typeof(T) == typeof(ulong))
                xnor((ulong*)pA, (ulong*)pB, (ulong*)pDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void xnor(byte* pA, byte* pB, byte* pDst)
            => content(math.xnor(content(pA), content(pB)), pDst);

        [MethodImpl(Inline)]
        static unsafe void xnor(ushort* pA, ushort* pB, ushort* pDst)
            => ginx.vstore(ginx.vxnor(n, pA, pB),pDst);

        [MethodImpl(Inline)]
        static unsafe void xnor(uint* pA, uint* pB, uint* pDst)
        {
            const int step = 8;
            ginx.vxnor(n, pA,pB,pDst);
            ginx.vxnor(n, pA+=step,pB+=step,pDst+=step);
            ginx.vxnor(n, pA+=step,pB+=step,pDst+=step);
            ginx.vxnor(n, pA+=step,pB+=step,pDst+=step);
        }

        [MethodImpl(Inline)]
        static unsafe void xnor(ulong* pA, ulong* pB, ulong* pDst)
        {
            const int step = 4;
            const int offset = step*8;            
            xnor8(pA, pB, pDst);
            xnor8(pA + offset, pB + offset, pDst + offset);
        }

        [MethodImpl(Inline)]
        static unsafe void xnor8(ulong* pA, ulong* pB, ulong* pDst)
        {            
            const int step = 4;
            ginx.vxnor(n, pA, pB, pDst);
            ginx.vxnor(n, pA+=step, pB+=step,pDst+=step);
            ginx.vxnor(n, pA+=step, pB+=step,pDst+=step);
            ginx.vxnor(n, pA+=step, pB+=step,pDst+=step);

            ginx.vxnor(n, pA+=step, pB+=step,pDst+=step);
            ginx.vxnor(n, pA+=step, pB+=step,pDst+=step);
            ginx.vxnor(n, pA+=step, pB+=step,pDst+=step);
            ginx.vxnor(n, pA+=step, pB+=step,pDst+=step);
        }        
    }
}