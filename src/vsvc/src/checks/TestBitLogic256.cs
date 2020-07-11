//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Runtime.Intrinsics;
    
    using static Konst;
    using static Memories;

    public readonly struct TestBitLogic256<T> : ITestBitLogicMatch<Vector256<T>,W256>
        where T : unmanaged
    {
        public static TestBitLogic256<T> Checker => default(TestBitLogic256<T>);

        W256 w => default;

        [MethodImpl(Inline)]
        public bit match<K>(Vector256<T> x, Vector256<T> y, K k = default)
            where K : unmanaged, IBitLogicKind
        {
            var mSvc = MSvc.bitlogic<T>();
            var vSvc = VSvc.vbitlogic<T>(w);
            
            var buffer = Fixed.alloc(w);
            ref var dst = ref Fixed.head<T>(ref buffer);
            
            var count = vcount<T>(w);  
            for(var i=0; i<count; i++)
                seek(ref dst, i) = mSvc.eval(vcell(x,i), vcell(y,i), k);
            var v1 = Vectors.vload(w, dst);
            
            var v2 = vSvc.eval(x,y,k);
            
            return gvec.vsame(v2,v1);
        }        
    }
}