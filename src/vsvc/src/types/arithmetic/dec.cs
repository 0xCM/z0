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
        [NumericClosures(Integers), Dec]
        public readonly struct Dec128<T> : IUnaryOp128D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x) 
                => gvec.vdec(x);
            
            [MethodImpl(Inline)]
            public T Invoke(T a) 
                => gmath.dec(a);
        }

        [NumericClosures(Integers), Dec]
        public readonly struct Dec256<T> : IUnaryOp256D<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x) 
                => gvec.vdec(x);

            [MethodImpl(Inline)]
            public T Invoke(T a) 
                => gmath.dec(a);
        }
    }
}