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
    using static SFx;

    [ApiHost("checks")]
    public class VSvcChecks
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Bit32 match<T>(Vector128<T> x, Vector128<T> y, BitLogicKinds.And f)
            where T : unmanaged
                => CheckMatch(x, y, f);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Bit32 match<T>(Vector256<T> x, Vector256<T> y, BitLogicKinds.And f)
            where T : unmanaged
                => CheckMatch(x, y, f);

        [MethodImpl(Inline)]
        public static Bit32 CheckMatch<K,T>(Vector128<T> x, Vector128<T> y, K f = default)
            where K : unmanaged, IBitLogicKind
            where T : unmanaged
        {
            var w = w128;
            var mSvc = MSvc.bitlogic<T>();
            var vSvc = VSvc.vbitlogic<T>(w);
            var buffer = Cells.alloc(w);
            ref var dst = ref Cells.first<T>(buffer);
            var count = vcount<T>(w);
            for(byte i=0; i<count; i++)
                seek(dst, i) = mSvc.eval(vcell(x,i), vcell(y,i), f);
            var v1 = z.vload(w, dst);
            var v2 = vSvc.eval(x,y,f);
            return gvec.vsame(v2,v1);
        }

        [MethodImpl(Inline)]
        public static Bit32 CheckMatch<K,T>(Vector256<T> x, Vector256<T> y, K f = default)
            where K : unmanaged, IBitLogicKind
            where T : unmanaged
        {
            var w = w256;
            var mSvc = MSvc.bitlogic<T>();
            var vSvc = VSvc.vbitlogic<T>(w);
            var buffer = Cells.alloc(w);
            ref var dst = ref Cells.first<T>(buffer);
            var count = vcount<T>(w);
            for(byte i=0; i<count; i++)
                seek(dst, i) = mSvc.eval(vcell(x,i), vcell(y,i), f);
            var v1 = z.vload(w, dst);
            var v2 = vSvc.eval(x,y,f);
            return gvec.vsame(v2,v1);
        }
    }
}