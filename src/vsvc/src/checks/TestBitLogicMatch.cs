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
    
    using static Seed;
    using static Memories;

    using C = TestBitLogicMatch;
    using K = Kinds;

    public interface ITestBitLogicMatch : ICheckVectors
    {        
        [MethodImpl(Inline)]
        bit match<K,T>(Vector128<T> x, Vector128<T> y, K k = default, W128 w = default)
            where T : unmanaged
            where K : unmanaged, IBitLogicKind
                => C.Checker.match(x, y, k, w);
    }

    public readonly struct TestBitLogicMatch : ITestBitLogicMatch
    {
        public static TestBitLogicMatch Checker => default(TestBitLogicMatch);

        [MethodImpl(Inline)]
        public bit match<K,T>(Vector128<T> x, Vector128<T> y, K k = default, W128 w = default)
            where T : unmanaged
            where K : unmanaged, IBitLogicKind
        {
            var mSvc = MSvc.bitlogic<T>();
            var vSvc = VSvc.vbitlogic<T>(w);
            
            var buffer = Fixed.alloc<Fixed128>();
            ref var dst = ref Fixed.head<Fixed128,T>(ref buffer);
            
            var count = vcount<T>(w);  
            for(var i=0; i< count; i++)
                seek(ref dst, i) = mSvc.eval(vcell(x,i), vcell(y,i), k);
            var v1 = Vectors.vload(w, in dst);
            
            var v2 = vSvc.eval(x,y,k);
            
            return gvec.vsame(v2,v1);
        }

        [MethodImpl(Inline)]
        public bit match<K,T>(Vector256<T> x, Vector256<T> y, K k = default, W256 w = default)
            where T : unmanaged
            where K : unmanaged, IBitLogicKind
        {
            var mSvc = MSvc.bitlogic<T>();
            var vSvc = VSvc.vbitlogic<T>(w);
            
            var buffer = Fixed.alloc<Fixed256>();
            ref var dst = ref Fixed.head<Fixed256,T>(ref buffer);
            
            var count = vcount<T>(w);  
            for(var i=0; i< count; i++)
                seek(ref dst, i) = mSvc.eval(vcell(x,i), vcell(y,i), k);
            var v1 = Vectors.vload(w, in dst);
            
            var v2 = vSvc.eval(x,y,k);
            
            return gvec.vsame(v2,v1);
        }        
    }
}