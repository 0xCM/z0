
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
    using static z;
    using static SBlock;

    partial class BSvcHosts
    {
        [NumericClosures(AllNumeric), Negate]
        public readonly struct Negate128<T> : IBlockedUnaryOp128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly Block128<T> Invoke(in Block128<T> a, in Block128<T> c)            
                => ref map(a, c, VSvc.vnegate<T>(w128));
        }

        [NumericClosures(AllNumeric), Negate]
        public readonly struct Negate256<T> : IBlockedUnaryOp256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly Block256<T> Invoke(in Block256<T> a, in Block256<T> c)            
                => ref map(a, c, VSvc.vnegate<T>(w256));
        }
    }
}