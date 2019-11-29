//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static ginx;
    
    partial class vblock
    {     
        [MethodImpl(Inline)]
        public static bit vtestz<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            vload(b, out Vector128<T> vB);
            return ginx.vtestz(vA,vB);
        }

        [MethodImpl(Inline)]
        public static bit vtestz<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vload(a, out Vector256<T> vA);
            vload(b, out Vector256<T> vB);
            return ginx.vtestz(vA,vB);
        }

        [MethodImpl(Inline)]
        public static bit testz<T>(N128 n, in T a)
            where T : unmanaged
                => vtestz(n, a,a);

        [MethodImpl(Inline)]
        public static bit testz<T>(N128 n, in T a, in T b)
            where T : unmanaged
                => vtestz(n, a, b);

        [MethodImpl(Inline)]
        public static bit testz<T>(N256 n, in T a)
            where T : unmanaged
            => vtestz(n, a,a);

        [MethodImpl(Inline)]
        public static bit testz<T>(N256 n, in T a, in T b)
            where T : unmanaged
            => vtestz(n, a, b);

        [MethodImpl(Inline)]
        public static bit testz<T>(N128 n, int vcount, int step, in T a)
            where T : unmanaged
        {
            var result = bit.On;
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                result &= testz(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bit testz<T>(N128 n, int vcount, int step, in T a, in T b)
            where T : unmanaged
        {
            var result = bit.On;
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                result &= vtestz(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bit testz<T>(N256 n, int vcount, int step, in T a)
            where T : unmanaged
        {
            var result = bit.On;
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                result &= testz(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bit testz<T>(N256 n, int vcount, int step, in T a, in T b)
            where T : unmanaged
        {
            var result = bit.On;
            for(int i=0, offset = 0; i < vcount; i++, offset += step)
                result &= vtestz(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }
    }
}