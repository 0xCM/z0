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

    partial class VServices
    {
        [Closures(Integers), Srl]
        public readonly struct Srl128<T> : IShiftOp128D<T>, IShiftOp128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte count)
                => gvec.vsrl(x,count);

            [MethodImpl(Inline)]
            public T Invoke(T a, byte count)
                => gmath.srl(a,count);
        }

        [Closures(Integers), Srl]
        public readonly struct Srl256<T> : IShiftOp256D<T>, IShiftOp256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte count)
                => gvec.vsrl(x,count);

            [MethodImpl(Inline)]
            public T Invoke(T a, byte count)
                => gmath.srl(a,count);
        }
    }
}