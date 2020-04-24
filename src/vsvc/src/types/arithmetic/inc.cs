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
        [NumericClosures(Integers)]
        public readonly struct Inc128<T> : ISVUnaryOp128D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x) 
                => gvec.vinc(x);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a) 
                => gmath.inc(a);
        }

        [NumericClosures(Integers)]
        public readonly struct Inc256<T> : ISVUnaryOp256D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x)
                => gvec.vinc(x);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a) 
                => gmath.inc(a);
        }            
    }
}