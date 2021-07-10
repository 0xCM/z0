//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static core;

    using BL = ByteLogic;

    partial class vlogic
    {
        [MethodImpl(Inline), CNonImpl, Closures(Closure)]
        public static void cnonimpl<T>(in T a, in T b, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
               BL.cnonimpl(in u8(a), in u8(b), ref u8(dst));
            else if(typeof(T) == typeof(ushort))
                cnonimpl(w, in a, in b, ref dst);
            else if(typeof(T) == typeof(uint))
                cnonimpl(w, 4, 8, in a, in b, ref dst);
            else if(typeof(T) == typeof(ulong))
                cnonimpl(w, 16, 4, in a, in b, ref dst);
            else
                throw no<T>();
        }

        [MethodImpl(Inline), CNonImpl, Closures(Closure)]
        public static Vector128<T> vcnonimpl<T>(W128 w, in T a, in T b)
            where T : unmanaged
                => gcpu.vcnonimpl(gcpu.vload(w, in a), gcpu.vload(w, in b));

        [MethodImpl(Inline), CNonImpl, Closures(Closure)]
        public static Vector256<T> vcnonimpl<T>(W256 w, in T a, in T b)
            where T : unmanaged
                => gcpu.vcnonimpl(gcpu.vload(w, a),gcpu.vload(w, b));

        [MethodImpl(Inline), CNonImpl, Closures(Closure)]
        public static void cnonimpl<T>(W128 w, in T a, in T b, ref T dst)
            where T : unmanaged
                => gcpu.vstore(vcnonimpl(w, a, b), ref dst);

        [MethodImpl(Inline), CNonImpl, Closures(Closure)]
        public static void cnonimpl<T>(W256 w, in T a, in T b, ref T dst)
            where T : unmanaged
                => gcpu.vstore(vcnonimpl(w, a, b), ref dst);

        [MethodImpl(Inline), CNonImpl, Closures(Closure)]
        public static void cnonimpl<T>(W128 w, int vcount, int blocklen, in T a, in T b, ref T dst)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                cnonimpl(w, skip(a, offset), in skip(in b, offset), ref seek(dst, offset));
        }

        [MethodImpl(Inline), CNonImpl, Closures(Closure)]
        public static void cnonimpl<T>(W256 w, int vcount, int blocklen, in T a, in T b, ref T dst)
            where T : unmanaged
        {
            for(int i=0, offset = 0; i < vcount; i++, offset += blocklen)
                cnonimpl(w, skip(a, offset), in skip(in b, offset), ref seek(dst, offset));
        }
    }
}