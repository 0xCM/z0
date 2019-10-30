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
        public static unsafe void notimply<T>(T* pA, T* pB, T* pDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               notimply((byte*)pA, (byte*)pB, (byte*)pDst);
            else if(typeof(T) == typeof(ushort))
                notimply((ushort*)pA, (ushort*)pB, (ushort*)pDst);
            else if(typeof(T) == typeof(uint))
                notimply((uint*)pA, (uint*)pB, (uint*)pDst);
            else if(typeof(T) == typeof(ulong))
                notimply((ulong*)pA, (ulong*)pB, (ulong*)pDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void notimply(byte* pA, byte* pB, byte* pDst)
            => content(math.notimply(content(pA), content(pB)), pDst);

        [MethodImpl(Inline)]
        static unsafe void notimply(ushort* pA, ushort* pB, ushort* pDst)
            => ginx.vstore(ginx.vnotimply(n, pA, pB),pDst);

        [MethodImpl(Inline)]
        static unsafe void notimply(uint* pA, uint* pB, uint* pDst)
        {
            const int step = 8;
            ginx.vnotimply(n, pA,pB,pDst);
            ginx.vnotimply(n, pA+=step,pB+=step,pDst+=step);
            ginx.vnotimply(n, pA+=step,pB+=step,pDst+=step);
            ginx.vnotimply(n, pA+=step,pB+=step,pDst+=step);
        }

        [MethodImpl(Inline)]
        static unsafe void notimply(ulong* pA, ulong* pB, ulong* pDst)
        {
            const int step = 4;
            const int offset = step*8;            
            notimply8(pA, pB, pDst);
            notimply8(pA + offset, pB + offset, pDst + offset);
        }

        [MethodImpl(Inline)]
        static unsafe void notimply8(ulong* pA, ulong* pB, ulong* pDst)
        {            
            const int step = 4;
            ginx.vnotimply(n, pA, pB, pDst);
            ginx.vnotimply(n, pA+=step, pB+=step,pDst+=step);
            ginx.vnotimply(n, pA+=step, pB+=step,pDst+=step);
            ginx.vnotimply(n, pA+=step, pB+=step,pDst+=step);

            ginx.vnotimply(n, pA+=step, pB+=step,pDst+=step);
            ginx.vnotimply(n, pA+=step, pB+=step,pDst+=step);
            ginx.vnotimply(n, pA+=step, pB+=step,pDst+=step);
            ginx.vnotimply(n, pA+=step, pB+=step,pDst+=step);
        }        
    }
}