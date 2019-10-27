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
        public static unsafe void or<T>(T* pA, T* pB, T* pDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               or((byte*)pA, (byte*)pB, (byte*)pDst);
            else if(typeof(T) == typeof(ushort))
                or((ushort*)pA, (ushort*)pB, (ushort*)pDst);
            else if(typeof(T) == typeof(uint))
                or((uint*)pA, (uint*)pB, (uint*)pDst);
            else if(typeof(T) == typeof(ulong))
                or((ulong*)pA, (ulong*)pB, (ulong*)pDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void or(byte* pA, byte* pB, byte* pDst)
            => content(math.or(content(pA), content(pB)), pDst);

        [MethodImpl(Inline)]
        static unsafe void or(ushort* pA, ushort* pB, ushort* pDst)
            => ginx.vstore(ginx.vor(n256, pA, pB),pDst);

        [MethodImpl(Inline)]
        static unsafe void or(uint* pA, uint* pB, uint* pDst)
        {
            const int step = 8;
            ginx.vor(n256, pA,pB,pDst);
            ginx.vor(n256, pA+=step,pB+=step,pDst+=step);
            ginx.vor(n256, pA+=step,pB+=step,pDst+=step);
            ginx.vor(n256, pA+=step,pB+=step,pDst+=step);
        }

        [MethodImpl(Inline)]
        static unsafe void or(ulong* pA, ulong* pB, ulong* pDst)
        {
            const int step = 4;
            const int offset = step*8;            
            or8(pA, pB, pDst);
            or8(pA + offset, pB + offset, pDst + offset);
        }

        [MethodImpl(Inline)]
        static unsafe void or8(ulong* pA, ulong* pB, ulong* pDst)
        {            
            const int step = 4;
            ginx.vor(n256, pA, pB, pDst);
            ginx.vor(n256, pA+=step, pB+=step,pDst+=step);
            ginx.vor(n256, pA+=step, pB+=step,pDst+=step);
            ginx.vor(n256, pA+=step, pB+=step,pDst+=step);

            ginx.vor(n256, pA+=step, pB+=step,pDst+=step);
            ginx.vor(n256, pA+=step, pB+=step,pDst+=step);
            ginx.vor(n256, pA+=step, pB+=step,pDst+=step);
            ginx.vor(n256, pA+=step, pB+=step,pDst+=step);
        }        


    }

}