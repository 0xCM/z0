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
        public static unsafe void not<T>(T* pA, T* pDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               not((byte*)pA, (byte*)pDst);
            else if(typeof(T) == typeof(ushort))
                not((ushort*)pA, (ushort*)pDst);
            else if(typeof(T) == typeof(uint))
                not((uint*)pA, (uint*)pDst);
            else if(typeof(T) == typeof(ulong))
                not((ulong*)pA, (ulong*)pDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void not(byte* pA, byte* pDst)
            => content(math.not(content(pA)), pDst);

        [MethodImpl(Inline)]
        static unsafe void not(ushort* pA, ushort* pDst)
            => ginx.vstore(ginx.vnot(n256, pA),pDst);

        [MethodImpl(Inline)]
        static unsafe void not(uint* pA, uint* pDst)
        {
            const int step = 8;
            ginx.vnot(n256, pA, pDst);
            ginx.vnot(n256, pA+=step, pDst+=step);
            ginx.vnot(n256, pA+=step, pDst+=step);
            ginx.vnot(n256, pA+=step, pDst+=step);
        }

        [MethodImpl(Inline)]
        static unsafe void not(ulong* pA, ulong* pDst)
        {
            const int step = 4;
            const int offset = step*8;            
            not8(pA, pDst);
            not8(pA + offset, pDst + offset);
        }

        [MethodImpl(Inline)]
        static unsafe void not8(ulong* pA, ulong* pDst)
        {            
            const int step = 4;
            ginx.vnot(n256, pA, pDst);
            ginx.vnot(n256, pA+=step, pDst+=step);
            ginx.vnot(n256, pA+=step, pDst+=step);
            ginx.vnot(n256, pA+=step, pDst+=step);

            ginx.vnot(n256, pA+=step, pDst+=step);
            ginx.vnot(n256, pA+=step, pDst+=step);
            ginx.vnot(n256, pA+=step, pDst+=step);
            ginx.vnot(n256, pA+=step, pDst+=step);
        }        


    }

}