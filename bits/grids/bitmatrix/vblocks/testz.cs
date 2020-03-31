//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static Core;
    
    partial class vblock
    {     
        [MethodImpl(Inline)]
        public static bit vtestz<T>(N128 n, in T a, in T b)
            where T : unmanaged
        {                    
            vgeneric.vload(a, out Vector128<T> vA);
            vgeneric.vload(b, out Vector128<T> vB);
            return gvec.vtestz(vA,vB);
        }

        [MethodImpl(Inline)]
        public static bit vtestz<T>(N256 n, in T a, in T b)
            where T : unmanaged
        {                    
            vgeneric.vload(a, out Vector256<T> vA);
            vgeneric.vload(b, out Vector256<T> vB);
            return gvec.vtestz(vA,vB);
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
        public static bit testz<T>(N128 n, int vcount, int blocklen, in T a)
            where T : unmanaged
        {
            var result = bit.On;
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                result &= testz(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bit testz<T>(N128 n, int vcount, int blocklen, in T a, in T b)
            where T : unmanaged
        {
            var result = bit.On;
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                result &= vtestz(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bit testz<T>(N256 n, int vcount, int blocklen, in T a)
            where T : unmanaged
        {
            var result = bit.On;
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                result &= testz(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline)]
        public static bit testz<T>(N256 n, int vcount, int blocklen, in T a, in T b)
            where T : unmanaged
        {
            var result = bit.On;
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                result &= vtestz(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }
    }
}