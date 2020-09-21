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

    public readonly struct CheckBitLogicMatch : ICheckBitLogicMatch
    {
        public static CheckBitLogicMatch Checker => default(CheckBitLogicMatch);

        [MethodImpl(Inline)]
        public bit match<K,T>(Vector128<T> x, Vector128<T> y, K k = default, W128 w = default)
            where T : unmanaged
            where K : unmanaged, IBitLogicApiKey
                => CheckBitLogic128<T>.Checker.match(x, y, k);

        [MethodImpl(Inline)]
        public bit match<K,T>(Vector256<T> x, Vector256<T> y, K k = default, W256 w = default)
            where T : unmanaged
            where K : unmanaged, IBitLogicApiKey
                => CheckBitLogic256<T>.Checker.match(x, y, k);
    }
}