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

    partial class VXTypes
    {
        public readonly struct Sllv128<T> : IVBinOp128D<T>
            where T : unmanaged
        {
            public static Sllv128<T> Op => default;

            public string Moniker => moniker<N128,T>("vsllv");

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> offsets) => ginx.vsllv(x,offsets);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T offset) => gmath.sll(a,convert<T,byte>(offset));

        }

        public readonly struct Sllv256<T> : IVBinOp256D<T>
            where T : unmanaged
        {
            public static Sllv256<T> Op => default;

            public string Moniker => moniker<N256,T>("vsllv");

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> offsets) => ginx.vsllv(x,offsets);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T offset) => gmath.sll(a,convert<T,byte>(offset));
        }
    }
}