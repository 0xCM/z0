//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static SFx;

    partial class VSvcHosts
    {
        [Closures(Integers), Pop]
        public readonly struct Pop128<T> : ISVTernaryScalar128D<T,uint>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public uint Invoke(Vector128<T> x,Vector128<T> y,Vector128<T> z)
                => gcpu.vpop(x,y,z);

            [MethodImpl(Inline)]
            public uint Invoke(T a, T b, T c)
                => gbits.pop(a,b,c);
        }

        [Closures(Integers), Pop]
        public readonly struct Pop256<T> : ISVTernaryScalarFunc256D<T,uint>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public uint Invoke(Vector256<T> x, Vector256<T> y, Vector256<T> z)
                => gcpu.vpop(x,y,z);

            [MethodImpl(Inline)]
            public uint Invoke(T a, T b, T c)
                => gbits.pop(a,b,c);
        }
    }
}