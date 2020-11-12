//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    partial class LogicSquare
    {
        [MethodImpl(Inline), TestZ, Closures(Closure)]
        public static Bit32 vtestz<T>(W128 w, in T a, in T b)
            where T : unmanaged
        {
            vload(a, out Vector128<T> vA);
            vload(b, out Vector128<T> vB);
            return gvec.vtestz(vA,vB);
        }

        [MethodImpl(Inline), TestZ, Closures(Closure)]
        public static Bit32 vtestz<T>(W256 w, in T a, in T b)
            where T : unmanaged
        {
            vload(a, out Vector256<T> vA);
            vload(b, out Vector256<T> vB);
            return gvec.vtestz(vA,vB);
        }

        [MethodImpl(Inline), TestZ, Closures(Closure)]
        public static Bit32 testz<T>(W128 n, in T a)
            where T : unmanaged
                => vtestz(n, a,a);

        [MethodImpl(Inline), TestZ, Closures(Closure)]
        public static Bit32 testz<T>(W128 n, in T a, in T b)
            where T : unmanaged
                => vtestz(n, a, b);

        [MethodImpl(Inline), TestZ, Closures(Closure)]
        public static Bit32 testz<T>(W256 n, in T a)
            where T : unmanaged
            => vtestz(n, a,a);

        [MethodImpl(Inline), TestZ, Closures(Closure)]
        public static Bit32 testz<T>(W256 n, in T a, in T b)
            where T : unmanaged
            => vtestz(n, a, b);

        [MethodImpl(Inline), TestZ, Closures(Closure)]
        public static Bit32 testz<T>(W128 n, int vcount, int blocklen, in T a)
            where T : unmanaged
        {
            var result = Bit32.On;
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                result &= testz(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline), TestZ, Closures(Closure)]
        public static Bit32 testz<T>(W128 n, int vcount, int blocklen, in T a, in T b)
            where T : unmanaged
        {
            var result = Bit32.On;
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                result &= vtestz(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }

        [MethodImpl(Inline), TestZ, Closures(Closure)]
        public static Bit32 testz<T>(W256 n, int vcount, int blocklen, in T a)
            where T : unmanaged
        {
            var result = Bit32.On;
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                result &= testz(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline), TestZ, Closures(Closure)]
        public static Bit32 testz<T>(W256 n, int vcount, int blocklen, in T a, in T b)
            where T : unmanaged
        {
            var result = Bit32.On;
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                result &= vtestz(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }
    }
}