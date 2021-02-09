//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class LogicSquare
    {
        [MethodImpl(Inline), TestC, Closures(Closure)]
        public static bit vtestc<T>(W128 w, in T a)
            where T : unmanaged
                => gcpu.vtestc(gcpu.vload(w, a));

        [MethodImpl(Inline), TestC, Closures(Closure)]
        public static bit vtestc<T>(W128 w, in T a, in T b)
            where T : unmanaged
                => gcpu.vtestc(gcpu.vload(w, a), gcpu.vload(w, b));

        [MethodImpl(Inline), TestC, Closures(Closure)]
        public static bit vtestc<T>(W256 w, in T a)
            where T : unmanaged
                => gcpu.vtestc(gcpu.vload(w, a));

        [MethodImpl(Inline), TestC, Closures(Closure)]
        public static bit vtestc<T>(W256 w, in T a, in T b)
            where T : unmanaged
                => gcpu.vtestc(gcpu.vload(w, a), gcpu.vload(w, b));

        [MethodImpl(Inline), TestC, Closures(Closure)]
        public static bit testc<T>(W128 n, int vcount, int blocklen, in T a)
            where T : unmanaged
        {
            var result = bit.On;
            for(int i=0, offset = 0; i<vcount; i++, offset+=blocklen)
                result &= vtestc(n, skip(a, offset));
            return result;
        }

        [MethodImpl(Inline), TestC, Closures(Closure)]
        public static bit testc<T>(W128 n, int vcount, int blocklen, in T a, in T b)
            where T : unmanaged
        {
            var result = bit.On;
            for(int i=0, offset = 0; i<vcount; i++, offset+=blocklen)
                result &= vtestc(n, skip(a, offset), skip(b, offset));
            return result;
        }

        [MethodImpl(Inline), TestC, Closures(Closure)]
        public static bit testc<T>(W256 n, int vcount, int blocklen, in T a)
            where T : unmanaged
        {
            var result = bit.On;
            for(int i=0, offset = 0; i<vcount; i++, offset+=blocklen)
                result &= vtestc(n, skip(a, offset));
            return result;
        }

        [MethodImpl(Inline), TestC, Closures(Closure)]
        public static bit testc<T>(W256 n, int vcount, int blocklen, in T a, in T b)
            where T : unmanaged
        {
            var result = bit.On;
            for(int i=0, offset = 0; i<vcount; i++, offset+=blocklen)
                result &= vtestc(n, skip(a, offset), skip(b, offset));
            return result;
        }
    }
}