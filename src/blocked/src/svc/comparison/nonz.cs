
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;
    using static SBlock;

    partial class BSvcHosts
    {
        [Closures(AllNumeric), Nonz]
        public readonly struct NonZ128<T> : IBlockedUnaryPred128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Span<bit> Invoke(in Block128<T> src, Span<bit> dst) 
                => map(src, dst, VSvc.vnonz<T>(w128));
        }

        [Closures(AllNumeric), Nonz]
        public readonly struct NonZ256<T> : IBlockedUnaryPred256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Span<bit> Invoke(in Block256<T> src, Span<bit> dst) 
                => map(src, dst, VSvc.vnonz<T>(w256));
        }
    }
}