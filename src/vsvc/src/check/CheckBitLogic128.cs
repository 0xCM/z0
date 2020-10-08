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
    using static Memories;

    public readonly struct CheckBitLogic128<T> : ITestBitLogicMatch<Vector128<T>, W128>
        where T : unmanaged
    {
        public static CheckBitLogic128<T> Checker => default(CheckBitLogic128<T>);

        W128 w => default;

        [MethodImpl(Inline)]
        public Bit32 match<K>(Vector128<T> x, Vector128<T> y, K k = default)
            where K : unmanaged, IBitLogicKind
        {
            var mSvc = MSvc.bitlogic<T>();
            var vSvc = VSvc.vbitlogic<T>(w);

            var buffer = Cells.alloc(w);
            ref var dst = ref Cells.first<T>(ref buffer);

            var count = vcount<T>(w);
            for(var i=0; i<count; i++)
                seek(ref dst, i) = mSvc.eval(vcell(x,i), vcell(y,i), k);

            var v1 = z.vload(w, dst);
            var v2 = vSvc.eval(x,y,k);
            return gvec.vsame(v2,v1);
        }
    }
}