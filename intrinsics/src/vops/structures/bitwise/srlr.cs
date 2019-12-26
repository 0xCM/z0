//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class VOpTypes
    {
        public readonly struct Srlr128<T> : IVBinOp128D<T>
            where T : unmanaged
        {
            public static Srlr128<T> Op => default;

            public string Moniker => moniker<N128,T>("vsrlr");

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> offsets) => ginx.vsrlr(x,offsets);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T offset) => gmath.srl(a,convert<T,byte>(offset));            
        }

        public readonly struct Srlr256<T> : IVBinOp256<T>
            where T : unmanaged
        {
            public static Srlr256<T> Op => default;

            public string Moniker => moniker<N256,T>("vsrlr");

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> offset) => ginx.vsrlr(x,offset);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T offset) => gmath.srl(a,convert<T,byte>(offset));
        }
    }
}