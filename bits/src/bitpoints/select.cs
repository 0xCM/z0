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
        public static unsafe void select<T>(T* pA, T* pB, T* pC, T* pDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                select((byte*)pA, (byte*)pB, (byte*)pC, (byte*)pDst);
            else if(typeof(T) == typeof(ushort))
                select((ushort*)pA, (ushort*)pB, (ushort*)pC, (ushort*)pDst);
            else if(typeof(T) == typeof(uint))
                select((uint*)pA, (uint*)pB, (uint*)pC, (uint*)pDst);
            else if(typeof(T) == typeof(ulong))
                select((ulong*)pA, (ulong*)pB, (ulong*)pC, (ulong*)pDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void select(byte* pA, byte* pB, byte* pC, byte* pDst)
            => content(gmath.select(content(pA), content(pB), content(pC)), pDst);

        [MethodImpl(Inline)]
        static unsafe void select(ushort* pA, ushort* pB, ushort* pC, ushort* pDst)
            => ginx.vstore(ginx.vselect(n, pA, pB, pC),pDst);

        [MethodImpl(Inline)]
        static unsafe void select(uint* pA, uint* pB, uint* pC, uint* pDst)
        {
            const int step = 8;
            ginx.vselect(n, pA, pB, pC, pDst);
            ginx.vselect(n, pA+=step, pB+=step, pC+=step, pDst+=step);
            ginx.vselect(n, pA+=step, pB+=step, pC+=step, pDst+=step);
            ginx.vselect(n, pA+=step, pB+=step, pC+=step, pDst+=step);
        }

        [MethodImpl(Inline)]
        static unsafe void select(ulong* pA, ulong* pB, ulong* pC, ulong* pDst)
        {
            const int step = 4;
            const int offset = step*8;            
            select8(pA, pB, pC, pDst);
            select8(pA + offset, pB + offset, pC + offset, pDst + offset);
        }


        [MethodImpl(Inline)]
        static unsafe void select8(ulong* pA, ulong* pB, ulong* pC, ulong* pDst)
        {
            const int step = 4;
            ginx.vselect(n, pA, pB, pC, pDst);
            ginx.vselect(n, pA+=step, pB+=step, pC+=step, pDst+=step);
            ginx.vselect(n, pA+=step, pB+=step, pC+=step, pDst+=step);
            ginx.vselect(n, pA+=step, pB+=step, pC+=step, pDst+=step);

            ginx.vselect(n, pA+=step, pB+=step, pC+=step, pDst+=step);
            ginx.vselect(n, pA+=step, pB+=step, pC+=step, pDst+=step);
            ginx.vselect(n, pA+=step, pB+=step, pC+=step, pDst+=step);
            ginx.vselect(n, pA+=step, pB+=step, pC+=step, pDst+=step);
        }
    }
}