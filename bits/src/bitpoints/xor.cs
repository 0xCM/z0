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
        public static unsafe void xor<T>(T* pA, T* pB, T* pDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               xor((byte*)pA, (byte*)pB, (byte*)pDst);
            else if(typeof(T) == typeof(ushort))
                xor((ushort*)pA, (ushort*)pB, (ushort*)pDst);
            else if(typeof(T) == typeof(uint))
                xor((uint*)pA, (uint*)pB, (uint*)pDst);
            else if(typeof(T) == typeof(ulong))
                xor((ulong*)pA, (ulong*)pB, (ulong*)pDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void xor(byte* pA, byte* pB, byte* pDst)
            => content(math.xor(content(pA), content(pB)), pDst);

        [MethodImpl(Inline)]
        static unsafe void xor(ushort* pA, ushort* pB, ushort* pDst)
            => ginx.vstore(ginx.vxor(n, pA, pB),pDst);

        [MethodImpl(Inline)]
        static unsafe void xor(uint* pA, uint* pB, uint* pDst)
        {
            const int step = 8;
            ginx.vxor(n, pA,pB,pDst);
            ginx.vxor(n, pA+=step,pB+=step,pDst+=step);
            ginx.vxor(n, pA+=step,pB+=step,pDst+=step);
            ginx.vxor(n, pA+=step,pB+=step,pDst+=step);
        }

        [MethodImpl(Inline)]
        static unsafe void xor(ulong* pA, ulong* pB, ulong* pDst)
        {
            const int step = 4;
            const int offset = step*8;            
            xor8(pA, pB, pDst);
            xor8(pA + offset, pB + offset, pDst + offset);
        }

        [MethodImpl(Inline)]
        static unsafe void xor8(ulong* pA, ulong* pB, ulong* pDst)
        {            
            const int step = 4;
            ginx.vxor(n, pA, pB, pDst);
            ginx.vxor(n, pA+=step, pB+=step,pDst+=step);
            ginx.vxor(n, pA+=step, pB+=step,pDst+=step);
            ginx.vxor(n, pA+=step, pB+=step,pDst+=step);

            ginx.vxor(n, pA+=step, pB+=step,pDst+=step);
            ginx.vxor(n, pA+=step, pB+=step,pDst+=step);
            ginx.vxor(n, pA+=step, pB+=step,pDst+=step);
            ginx.vxor(n, pA+=step, pB+=step,pDst+=step);
        }        
    }

}