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
        public static unsafe void cimply<T>(T* pA, T* pB, T* pDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               cimply((byte*)pA, (byte*)pB, (byte*)pDst);
            else if(typeof(T) == typeof(ushort))
                cimply((ushort*)pA, (ushort*)pB, (ushort*)pDst);
            else if(typeof(T) == typeof(uint))
                cimply((uint*)pA, (uint*)pB, (uint*)pDst);
            else if(typeof(T) == typeof(ulong))
                cimply((ulong*)pA, (ulong*)pB, (ulong*)pDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void cimply(byte* pA, byte* pB, byte* pDst)
            => content(math.cimply(content(pA), content(pB)), pDst);

        [MethodImpl(Inline)]
        static unsafe void cimply(ushort* pA, ushort* pB, ushort* pDst)
            => ginx.vstore(ginx.vcimply(n, pA, pB),pDst);

        [MethodImpl(Inline)]
        static unsafe void cimply(uint* pA, uint* pB, uint* pDst)
        {
            const int step = 8;
            ginx.vcimply(n, pA,pB,pDst);
            ginx.vcimply(n, pA+=step,pB+=step,pDst+=step);
            ginx.vcimply(n, pA+=step,pB+=step,pDst+=step);
            ginx.vcimply(n, pA+=step,pB+=step,pDst+=step);
        }

        [MethodImpl(Inline)]
        static unsafe void cimply(ulong* pA, ulong* pB, ulong* pDst)
        {
            const int step = 4;
            const int offset = step*8;            
            cimply8(pA, pB, pDst);
            cimply8(pA + offset, pB + offset, pDst + offset);
        }

        [MethodImpl(Inline)]
        static unsafe void cimply8(ulong* pA, ulong* pB, ulong* pDst)
        {            
            const int step = 4;
            ginx.vcimply(n, pA, pB, pDst);
            ginx.vcimply(n, pA+=step, pB+=step,pDst+=step);
            ginx.vcimply(n, pA+=step, pB+=step,pDst+=step);
            ginx.vcimply(n, pA+=step, pB+=step,pDst+=step);

            ginx.vcimply(n, pA+=step, pB+=step,pDst+=step);
            ginx.vcimply(n, pA+=step, pB+=step,pDst+=step);
            ginx.vcimply(n, pA+=step, pB+=step,pDst+=step);
            ginx.vcimply(n, pA+=step, pB+=step,pDst+=step);
        }        
    }
}