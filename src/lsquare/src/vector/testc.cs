//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Seed;
    using static Memories;
    using static Vectors;
    
    partial class LogicSquare
    {     
        [MethodImpl(Inline), TestC, Closures(UnsignedInts)]
        public static bit vtestc<T>(W128 w, in T a)
            where T : unmanaged
                => gvec.vtestc(vload(w, in a));

        [MethodImpl(Inline), TestC, Closures(UnsignedInts)]
        public static bit vtestc<T>(W128 w, in T a, in T b)
            where T : unmanaged
                => gvec.vtestc(vload(w, in a), vload(w, in b));

        [MethodImpl(Inline), TestC, Closures(UnsignedInts)]
        public static bit vtestc<T>(W256 w, in T a)
            where T : unmanaged
                => gvec.vtestc(vload(w, in a));

        [MethodImpl(Inline), TestC, Closures(UnsignedInts)]
        public static bit vtestc<T>(W256 w, in T a, in T b)
            where T : unmanaged
                => gvec.vtestc(vload(w, in a), vload(w, in b));

        [MethodImpl(Inline), TestC, Closures(UnsignedInts)]
        public static bit testc<T>(W128 n, int vcount, int blocklen, in T a)
            where T : unmanaged
        {
            var result = bit.On;
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                result &= vtestc(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline), TestC, Closures(UnsignedInts)]
        public static bit testc<T>(W128 n, int vcount, int blocklen, in T a, in T b)
            where T : unmanaged
        {
            var result = bit.On;
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                result &= vtestc(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }

        [MethodImpl(Inline), TestC, Closures(UnsignedInts)]
        public static bit testc<T>(W256 n, int vcount, int blocklen, in T a)
            where T : unmanaged
        {
            var result = bit.On;
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                result &= vtestc(n, in skip(in a, offset));
            return result;
        }

        [MethodImpl(Inline), TestC, Closures(UnsignedInts)]
        public static bit testc<T>(W256 n, int vcount, int blocklen, in T a, in T b)
            where T : unmanaged
        {
            var result = bit.On;
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                result &= vtestc(n, in skip(in a, offset), in skip(in b, offset));
            return result;
        }
    }
}