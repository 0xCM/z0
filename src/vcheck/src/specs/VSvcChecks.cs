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

    [ApiHost("checks")]
    public class VSvcChecks
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bit match<T>(Vector128<T> x, Vector128<T> y, BitLogicKinds.And f)
            where T : unmanaged
                => CheckBitLogicMatch.Checker.match(x,y,f);


        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bit match<T>(Vector256<T> x, Vector256<T> y, BitLogicKinds.And f)
            where T : unmanaged
                => CheckBitLogicMatch.Checker.match(x,y,f);
    }
}