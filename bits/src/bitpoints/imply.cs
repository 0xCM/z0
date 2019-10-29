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
        public static unsafe void imply<T>(T* pA, T* pB, T* pDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               imply((byte*)pA, (byte*)pB, (byte*)pDst);
            else if(typeof(T) == typeof(ushort))
                imply((ushort*)pA, (ushort*)pB, (ushort*)pDst);
            else if(typeof(T) == typeof(uint))
                imply((uint*)pA, (uint*)pB, (uint*)pDst);
            else if(typeof(T) == typeof(ulong))
                imply((ulong*)pA, (ulong*)pB, (ulong*)pDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void imply(byte* pA, byte* pB, byte* pDst)
            => content(math.imply(content(pA), content(pB)), pDst);

        [MethodImpl(Inline)]
        static unsafe void imply(ushort* pA, ushort* pB, ushort* pDst)
            => ginx.vstore(ginx.vimply(n, pA, pB),pDst);

        [MethodImpl(Inline)]
        static unsafe void imply(uint* pA, uint* pB, uint* pDst)
        {
            const int step = 8;
            ginx.vimply(n, pA,pB,pDst);
            ginx.vimply(n, pA+=step,pB+=step,pDst+=step);
            ginx.vimply(n, pA+=step,pB+=step,pDst+=step);
            ginx.vimply(n, pA+=step,pB+=step,pDst+=step);
        }

        [MethodImpl(Inline)]
        static unsafe void imply(ulong* pA, ulong* pB, ulong* pDst)
        {
            const int step = 4;
            const int offset = step*8;            
            imply8(pA, pB, pDst);
            imply8(pA + offset, pB + offset, pDst + offset);
        }

        [MethodImpl(Inline)]
        static unsafe void imply8(ulong* pA, ulong* pB, ulong* pDst)
        {            
            const int step = 4;
            ginx.vimply(n, pA, pB, pDst);
            ginx.vimply(n, pA+=step, pB+=step,pDst+=step);
            ginx.vimply(n, pA+=step, pB+=step,pDst+=step);
            ginx.vimply(n, pA+=step, pB+=step,pDst+=step);

            ginx.vimply(n, pA+=step, pB+=step,pDst+=step);
            ginx.vimply(n, pA+=step, pB+=step,pDst+=step);
            ginx.vimply(n, pA+=step, pB+=step,pDst+=step);
            ginx.vimply(n, pA+=step, pB+=step,pDst+=step);
        }        
    }
}