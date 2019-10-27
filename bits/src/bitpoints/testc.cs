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
        public static unsafe bool testc<T>(T* pA)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return testc((byte*)pA);
            else if(typeof(T) == typeof(ushort))
                return testc((ushort*)pA);
            else if(typeof(T) == typeof(uint))
                return testc((uint*)pA);
            else if(typeof(T) == typeof(ulong))
                return testc((ulong*)pA);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static unsafe bool testc<T>(T* pA, T* pB)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return testc((byte*)pA, (byte*)pB);
            else if(typeof(T) == typeof(ushort))
                return testc((ushort*)pA, (ushort*)pB);
            else if(typeof(T) == typeof(uint))
                return testc((uint*)pA, (uint*)pB);
            else if(typeof(T) == typeof(ulong))
                return testc((ulong*)pA, (ulong*)pB);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static unsafe bool testc<T>(T* pA, T* pB, T* pDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return testc((byte*)pA, (byte*)pB, (byte*)pDst);
            else if(typeof(T) == typeof(ushort))
                return testc((ushort*)pA, (ushort*)pB, (ushort*)pDst);
            else if(typeof(T) == typeof(uint))
                return testc((uint*)pA, (uint*)pB, (uint*)pDst);
            else if(typeof(T) == typeof(ulong))
                return testc((ulong*)pA, (ulong*)pB, (ulong*)pDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static unsafe bool testc(byte* pA, byte* pB)
        {
            var a = content(pA);
            var b = content(pB);
            var x = ginx.vbroadcast(n128,a);
            var y = ginx.vbroadcast(n128,b);
            return ginx.vtestc(x,y);
        }

        [MethodImpl(Inline)]
        static unsafe bool testc(byte* pA)
        {
            var a = content(pA);
            var x = ginx.vbroadcast(n128,a);
            return ginx.vtestc(x);
        }

        [MethodImpl(Inline)]
        static unsafe bool testc(ushort* pA)
            => ginx.vtestc(n, pA);

        [MethodImpl(Inline)]
        static unsafe bool testc(ushort* pA, ushort* pB)
            => ginx.vtestc(n, pA, pB);

        [MethodImpl(Inline)]
        static unsafe bool testc(uint* pA)
        {
            const int step = 8;
            var result = ginx.vtestc(n, pA);
            result &= ginx.vtestc(n, pA+=step);
            result &= ginx.vtestc(n, pA+=step);
            result &= ginx.vtestc(n, pA+=step);
            return result;
        }

        [MethodImpl(Inline)]
        static unsafe bool testc(uint* pA, uint* pB)
        {
            const int step = 8;
            var result = ginx.vtestc(n, pA,pB);
            result &= ginx.vtestc(n, pA+=step,pB+=step);
            result &= ginx.vtestc(n, pA+=step,pB+=step);
            result &= ginx.vtestc(n, pA+=step,pB+=step);
            return result;
        }

        [MethodImpl(Inline)]
        static unsafe bool testc(ulong* pA)
        {
            const int step = 4;
            const int offset = step*8;     
            var result = true;                   
            result &= testc8(pA);
            result &= testc8(pA + offset);
            return result;
        }

        [MethodImpl(Inline)]
        static unsafe bool testc(ulong* pA, ulong* pB)
        {
            const int step = 4;
            const int offset = step*8;     
            var result = true;                   
            result &= testc8(pA, pB);
            result &= testc8(pA + offset, pB + offset);
            return result;
        }

        [MethodImpl(Inline)]
        static unsafe bool testc8(ulong* pA)
        {            
            const int step = 4;
            var result = ginx.vtestc(n, pA);
            result &= ginx.vtestc(n,pA+=step);
            result &= ginx.vtestc(n,pA+=step);
            result &= ginx.vtestc(n,pA+=step);

            result &= ginx.vtestc(n,pA+=step);
            result &= ginx.vtestc(n,pA+=step);
            result &= ginx.vtestc(n,pA+=step);
            result &= ginx.vtestc(n,pA+=step);
            return result;
        }        

        [MethodImpl(Inline)]
        static unsafe bool testc8(ulong* pA, ulong* pB)
        {            
            const int step = 4;
            var result = ginx.vtestc(n, pA, pB);
            result &= ginx.vtestc(n,pA+=step, pB+=step);
            result &= ginx.vtestc(n,pA+=step, pB+=step);
            result &= ginx.vtestc(n,pA+=step, pB+=step);

            result &= ginx.vtestc(n,pA+=step, pB+=step);
            result &= ginx.vtestc(n,pA+=step, pB+=step);
            result &= ginx.vtestc(n,pA+=step, pB+=step);
            result &= ginx.vtestc(n,pA+=step, pB+=step);
            return result;
        }        
    }
}