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
        public static unsafe bool testz<T>(T* pA)
            where T : unmanaged
                => testz(pA, pA);

        [MethodImpl(Inline)]
        public static unsafe bool testz<T>(T* pA, T* pB)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return testz((byte*)pA, (byte*)pB);
            else if(typeof(T) == typeof(ushort))
                return testz((ushort*)pA, (ushort*)pB);
            else if(typeof(T) == typeof(uint))
                return testz((uint*)pA, (uint*)pB);
            else if(typeof(T) == typeof(ulong))
                return testz((ulong*)pA, (ulong*)pB);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static unsafe bool testz<T>(T* pA, T* pB, T* pDst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return testz((byte*)pA, (byte*)pB, (byte*)pDst);
            else if(typeof(T) == typeof(ushort))
                return testz((ushort*)pA, (ushort*)pB, (ushort*)pDst);
            else if(typeof(T) == typeof(uint))
                return testz((uint*)pA, (uint*)pB, (uint*)pDst);
            else if(typeof(T) == typeof(ulong))
                return testz((ulong*)pA, (ulong*)pB, (ulong*)pDst);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static unsafe bool testz(byte* pA, byte* pB)
        {
            var a = content(pA);
            var b = content(pB);
            var x = dinx.vbroadcast(n128,a);
            var y = dinx.vbroadcast(n128,b);
            return dinx.vtestz(x,y);
        }

        [MethodImpl(Inline)]
        static unsafe bool testz(ushort* pA, ushort* pB)
            => ginx.vtestz(n, pA, pB);


        [MethodImpl(Inline)]
        static unsafe bool testz(uint* pA, uint* pB)
        {
            const int step = 8;
            var result = ginx.vtestz(n, pA,pB);
            result &= ginx.vtestz(n, pA+=step,pB+=step);
            result &= ginx.vtestz(n, pA+=step,pB+=step);
            result &= ginx.vtestz(n, pA+=step,pB+=step);
            return result;
        }

        [MethodImpl(Inline)]
        static unsafe bool testz(ulong* pA, ulong* pB)
        {
            const int step = 4;
            const int offset = step*8;     
            var result = true;                   
            result &= testz8(pA, pB);
            result &= testz8(pA + offset, pB + offset);
            return result;
        }

        [MethodImpl(Inline)]
        static unsafe bool testz8(ulong* pA, ulong* pB)
        {            
            const int step = 4;
            var result = ginx.vtestz(n, pA, pB);
            result &= ginx.vtestz(n,pA+=step, pB+=step);
            result &= ginx.vtestz(n,pA+=step, pB+=step);
            result &= ginx.vtestz(n,pA+=step, pB+=step);

            result &= ginx.vtestz(n,pA+=step, pB+=step);
            result &= ginx.vtestz(n,pA+=step, pB+=step);
            result &= ginx.vtestz(n,pA+=step, pB+=step);
            result &= ginx.vtestz(n,pA+=step, pB+=step);
            return result;
        }        
    }
}