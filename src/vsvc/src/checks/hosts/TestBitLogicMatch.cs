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


    public readonly struct TestBitLogicMatch : TTestBitLogicMatch
    {
        public static TestBitLogicMatch Checker => default(TestBitLogicMatch);

        [MethodImpl(Inline)]
        public bit match<K,T>(Vector128<T> x, Vector128<T> y, K k = default, W128 w = default)
            where T : unmanaged
            where K : unmanaged, IBitLogicKind
                => TestBitLogic128<T>.Checker.match(x, y, k);

        [MethodImpl(Inline)]
        public bit match<K,T>(Vector256<T> x, Vector256<T> y, K k = default, W256 w = default)
            where T : unmanaged
            where K : unmanaged, IBitLogicKind
                =>  TestBitLogic256<T>.Checker.match(x, y, k);
    }
}