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

        public readonly struct Sllr128<T> : IVBinOp128D<T>
            where T : unmanaged
        {
            public static Sllr128<T> Op => default;

            public string Moniker => moniker<N128,T>("vsllr");

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> offsets) => ginx.vsllr(x,offsets);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T offset) => gmath.sll(a,convert<T,byte>(offset));            
        }

        public readonly struct Sllr256<T> : IVBinOp256D<T>
            where T : unmanaged
        {
            public static Sllr256<T> Op => default;

            public string Moniker => moniker<N256,T>("vsllr");

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> offset) => ginx.vsllr(x,offset);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T offset) => gmath.sll(a,convert<T,byte>(offset));

        }
    }
}