
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
    using static SBlock;

    partial class VBlockHosts
    {
        [Closures(AllNumeric), TestC]
        public readonly struct TestC128<T> : IBlockedBinaryPred128<T>
            where T : unmanaged
        {

            [MethodImpl(Inline)]
            public Span<bit> Invoke(in Block128<T> a, in Block128<T> b, Span<bit> dst) 
                => zip(a, b, dst, VSvc.vtestc<T>(w128));
        }

        [Closures(AllNumeric), TestC]
        public readonly struct TestC256<T> : IBlockedBinaryPred256<T>
            where T : unmanaged
        {

            [MethodImpl(Inline)]
            public Span<bit> Invoke(in Block256<T> a, in Block256<T> b, Span<bit> dst) 
                => zip(a, b, dst, VSvc.vtestc<T>(w256));
        }
    }
}