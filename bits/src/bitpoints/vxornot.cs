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
        public static unsafe void xornot<T>(T* pA, T* pB, T* pDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               vxornot((byte*)pA, (byte*)pB, (byte*)pDst);
            else if(typeof(T) == typeof(ushort))
                vxornot((ushort*)pA, (ushort*)pB, (ushort*)pDst);
            else if(typeof(T) == typeof(uint))
                vxornot((uint*)pA, (uint*)pB, (uint*)pDst);
            else if(typeof(T) == typeof(ulong))
                vxornot((ulong*)pA, (ulong*)pB, (ulong*)pDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void vxornot(byte* pA, byte* pB, byte* pDst)
            => content(math.xor(content(pA), math.not(content(pB))), pDst);

        [MethodImpl(Inline)]
        static unsafe void vxornot(ushort* pA, ushort* pB, ushort* pDst)
            => ginx.vstore(ginx.vxornot(n, pA, pB),pDst);

        [MethodImpl(Inline)]
        static unsafe void vxornot(uint* pA, uint* pB, uint* pDst)
        {
            const int step = 8;
            ginx.vxornot(n, pA,pB,pDst);
            ginx.vxornot(n, pA+=step,pB+=step,pDst+=step);
            ginx.vxornot(n, pA+=step,pB+=step,pDst+=step);
            ginx.vxornot(n, pA+=step,pB+=step,pDst+=step);
        }

        [MethodImpl(Inline)]
        static unsafe void vxornot(ulong* pA, ulong* pB, ulong* pDst)
        {
            const int step = 4;
            const int offset = step*8;            
            vxornot8(pA, pB, pDst);
            vxornot8(pA + offset, pB + offset, pDst + offset);
        }

        [MethodImpl(Inline)]
        static unsafe void vxornot8(ulong* pA, ulong* pB, ulong* pDst)
        {            
            const int step = 4;
            ginx.vxornot(n, pA, pB, pDst);
            ginx.vxornot(n, pA+=step, pB+=step,pDst+=step);
            ginx.vxornot(n, pA+=step, pB+=step,pDst+=step);
            ginx.vxornot(n, pA+=step, pB+=step,pDst+=step);

            ginx.vxornot(n, pA+=step, pB+=step,pDst+=step);
            ginx.vxornot(n, pA+=step, pB+=step,pDst+=step);
            ginx.vxornot(n, pA+=step, pB+=step,pDst+=step);
            ginx.vxornot(n, pA+=step, pB+=step,pDst+=step);
        }        


    }

}