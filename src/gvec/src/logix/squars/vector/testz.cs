//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static memory;

    partial class LogicSquare
    {
        [MethodImpl(Inline), TestZ, Closures(Closure)]
        public static bit vtestz<T>(W128 w, in T a, in T b)
            where T : unmanaged
        {
            gcpu.vload(a, out Vector128<T> vA);
            gcpu.vload(b, out Vector128<T> vB);
            return gcpu.vtestz(vA,vB);
        }

        [MethodImpl(Inline), TestZ, Closures(Closure)]
        public static bit vtestz<T>(W256 w, in T a, in T b)
            where T : unmanaged
        {
            gcpu.vload(a, out Vector256<T> vA);
            gcpu.vload(b, out Vector256<T> vB);
            return gcpu.vtestz(vA,vB);
        }

        [MethodImpl(Inline), TestZ, Closures(Closure)]
        public static bit testz<T>(W128 n, in T a)
            where T : unmanaged
                => vtestz(n, a,a);

        [MethodImpl(Inline), TestZ, Closures(Closure)]
        public static bit testz<T>(W128 n, in T a, in T b)
            where T : unmanaged
                => vtestz(n, a, b);

        [MethodImpl(Inline), TestZ, Closures(Closure)]
        public static bit testz<T>(W256 n, in T a)
            where T : unmanaged
            => vtestz(n, a,a);

        [MethodImpl(Inline), TestZ, Closures(Closure)]
        public static bit testz<T>(W256 n, in T a, in T b)
            where T : unmanaged
            => vtestz(n, a, b);

        [MethodImpl(Inline), TestZ, Closures(Closure)]
        public static bit testz<T>(W128 n, int vcount, int blocklen, in T a)
            where T : unmanaged
        {
            var result = bit.On;
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                result &= testz(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline), TestZ, Closures(Closure)]
        public static bit testz<T>(W128 n, int vcount, int blocklen, in T a, in T b)
            where T : unmanaged
        {
            var result = bit.On;
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                result &= vtestz(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }

        [MethodImpl(Inline), TestZ, Closures(Closure)]
        public static bit testz<T>(W256 n, int vcount, int blocklen, in T a)
            where T : unmanaged
        {
            var result = bit.On;
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                result &= testz(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline), TestZ, Closures(Closure)]
        public static bit testz<T>(W256 n, int vcount, int blocklen, in T a, in T b)
            where T : unmanaged
        {
            var result = bit.On;
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                result &= vtestz(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }
    }
}