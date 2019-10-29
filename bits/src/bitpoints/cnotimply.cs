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
        public static unsafe void cnotimply<T>(T* pA, T* pB, T* pDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               cnotimply((byte*)pA, (byte*)pB, (byte*)pDst);
            else if(typeof(T) == typeof(ushort))
                cnotimply((ushort*)pA, (ushort*)pB, (ushort*)pDst);
            else if(typeof(T) == typeof(uint))
                cnotimply((uint*)pA, (uint*)pB, (uint*)pDst);
            else if(typeof(T) == typeof(ulong))
                cnotimply((ulong*)pA, (ulong*)pB, (ulong*)pDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void cnotimply(byte* pA, byte* pB, byte* pDst)
            => content(math.cnotimply(content(pA), content(pB)), pDst);

        [MethodImpl(Inline)]
        static unsafe void cnotimply(ushort* pA, ushort* pB, ushort* pDst)
            => ginx.vstore(ginx.vcnotimply(n, pA, pB),pDst);

        [MethodImpl(Inline)]
        static unsafe void cnotimply(uint* pA, uint* pB, uint* pDst)
        {
            const int step = 8;
            ginx.vcnotimply(n, pA,pB,pDst);
            ginx.vcnotimply(n, pA+=step,pB+=step,pDst+=step);
            ginx.vcnotimply(n, pA+=step,pB+=step,pDst+=step);
            ginx.vcnotimply(n, pA+=step,pB+=step,pDst+=step);
        }

        [MethodImpl(Inline)]
        static unsafe void cnotimply(ulong* pA, ulong* pB, ulong* pDst)
        {
            const int step = 4;
            const int offset = step*8;            
            cnotimply8(pA, pB, pDst);
            cnotimply8(pA + offset, pB + offset, pDst + offset);
        }

        [MethodImpl(Inline)]
        static unsafe void cnotimply8(ulong* pA, ulong* pB, ulong* pDst)
        {            
            const int step = 4;
            ginx.vcnotimply(n, pA, pB, pDst);
            ginx.vcnotimply(n, pA+=step, pB+=step,pDst+=step);
            ginx.vcnotimply(n, pA+=step, pB+=step,pDst+=step);
            ginx.vcnotimply(n, pA+=step, pB+=step,pDst+=step);

            ginx.vcnotimply(n, pA+=step, pB+=step,pDst+=step);
            ginx.vcnotimply(n, pA+=step, pB+=step,pDst+=step);
            ginx.vcnotimply(n, pA+=step, pB+=step,pDst+=step);
            ginx.vcnotimply(n, pA+=step, pB+=step,pDst+=step);
        }        
    }
}