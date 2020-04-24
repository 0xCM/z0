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

    partial class VSvcHosts
    {
        [Closures(AllNumeric), Nonz]
        public readonly struct NonZ128<T> : ISVUnaryPredicate128D<T>
            where T : unmanaged
        {

            [MethodImpl(Inline)]
            public bit Invoke(Vector128<T> x) => gvec.vnonz(x);

            [MethodImpl(Inline)]
            public bit InvokeScalar(T a) => gmath.nonz(a);
        }

        [Closures(AllNumeric), Nonz]
        public readonly struct NonZ256<T> : ISVUnaryPredicate256D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public bit Invoke(Vector256<T> x) => gvec.vnonz(x);

            [MethodImpl(Inline)]
            public bit InvokeScalar(T a) => gmath.nonz(a);

        }
    }
}