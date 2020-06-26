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
    using static Root;
    using static V0;

    partial class LogicSquare
    {     
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector128<T> vnot<T>(W128 w, in T src)
            where T : unmanaged
        {                    
            vload(src, out Vector128<T> dst);
            return gvec.vnot(dst);
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Vector256<T> vnot<T>(W256 w, in T src)
            where T : unmanaged
        {                    
            vload(src, out Vector256<T> dst);
            return gvec.vnot(dst);
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void not<T>(W128 w, in T src, ref T dst)
            where T : unmanaged
                => vsave(vnot(w, src), ref dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void not<T>(W128 w, int count, int step, in T src, ref T dst)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i<count; i++, offset += step)
                not(w, skip(src, offset), ref seek(ref dst, offset));
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void not<T>(W256 w, in T src, ref T dst)
            where T : unmanaged
                => vsave(vnot(w, src), ref dst);
        
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void not<T>(W256 w, int count, int step, in T src, ref T dst)
            where T : unmanaged
        {
            for(int i=0, offset=0; i<count; i++, offset+=step)
                not(w, skip(src, offset), ref seek(ref dst, offset));
        }
    }
}