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

    partial class BitPoints256
    {

        [MethodImpl(Inline)]
        public static unsafe void and<T>(T* pA, T* pB, T* pC)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               and((byte*)pA, (byte*)pB, (byte*)pC);
            if(typeof(T) == typeof(ushort))
                and((ushort*)pA, (ushort*)pB, (ushort*)pC);
            else if(typeof(T) == typeof(uint))
                and((uint*)pA, (uint*)pB, (uint*)pC);
            else if(typeof(T) == typeof(ulong))
                and((ulong*)pA, (ulong*)pB, (ulong*)pC);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static unsafe void and(byte* pA, byte* pB, byte* pC)
            =>*((ulong*)pC) = *((ulong*)pA) & *((ulong*)pB);

        [MethodImpl(Inline)]
        public static unsafe void and(ushort* pA, ushort* pB, ushort* pC)
            => ginx.vstore(ginx.vand(n256, pA, pB),pC);

        [MethodImpl(Inline)]
        public static unsafe void and(uint* pA, uint* pB, uint* pC)
        {
            const int step = 8;
            ginx.vand(n256, pA,pB,pC);
            ginx.vand(n256, pA+=step,pB+=step,pC+=step);
            ginx.vand(n256, pA+=step,pB+=step,pC+=step);
            ginx.vand(n256, pA+=step,pB+=step,pC+=step);
        }

        [MethodImpl(Inline)]
        public static unsafe void and(ulong* pA, ulong* pB, ulong* pC)
        {
            const int step = 4;
            const int offset = step*8;            
            and8(pA, pB, pC);
            and8(pA + offset, pB + offset, pC + offset);
        }

        [MethodImpl(Inline)]
        static unsafe void and8(ulong* pA, ulong* pB, ulong* pC)
        {            
            const int step = 4;
            ginx.vand(n256, pA, pB, pC);
            ginx.vand(n256, pA+=step, pB+=step,pC+=step);
            ginx.vand(n256, pA+=step, pB+=step,pC+=step);
            ginx.vand(n256, pA+=step, pB+=step,pC+=step);

            ginx.vand(n256, pA+=step, pB+=step,pC+=step);
            ginx.vand(n256, pA+=step, pB+=step,pC+=step);
            ginx.vand(n256, pA+=step, pB+=step,pC+=step);
            ginx.vand(n256, pA+=step, pB+=step,pC+=step);
        }        


    }

}