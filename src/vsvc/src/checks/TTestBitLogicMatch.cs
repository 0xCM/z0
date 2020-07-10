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

    using K = Kinds;


    [ApiHost("checks")]
    public class VSvcChecks : IApiHost<VSvcChecks>
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bit match<T>(Vector128<T> x, Vector128<T> y, K.And f)
            where T : unmanaged
                => TestBitLogicMatch.Checker.match(x,y,f);


        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bit match<T>(Vector256<T> x, Vector256<T> y, K.And f)
            where T : unmanaged
                => TestBitLogicMatch.Checker.match(x,y,f);
    }

    public interface TTestBitLogicMatch : TCheckVectors
    {        
        [MethodImpl(Inline)]
        bit match<K,T>(Vector128<T> x, Vector128<T> y, K k = default, W128 w = default)
            where T : unmanaged
            where K : unmanaged, IBitLogicKind
                => TestBitLogic128<T>.Checker.match(x, y, k);

        [MethodImpl(Inline)]
        bit match<K,T>(Vector256<T> x, Vector256<T> y, K k = default, W256 w = default)
            where T : unmanaged
            where K : unmanaged, IBitLogicKind
                =>  TestBitLogic256<T>.Checker.match(x, y, k);
    }    
}