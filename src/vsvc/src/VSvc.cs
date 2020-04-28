//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;    

    using K = Kinds;

    public partial class VSvcHosts
    {

    }
    
    [FunctionalService]
    public partial class VSvc : IFunctional<VSvc,VSvcHosts>
    {

    }

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
}