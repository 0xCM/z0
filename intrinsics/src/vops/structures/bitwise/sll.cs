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
        public readonly struct VsllOp128<T> : IVShiftOp128<T>
            where T : unmanaged
        {
            public static VsllOp128<T> Op => default;

            public string Moniker => moniker<N128,T>("vsll");

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte offset)
                => ginx.vsll(x,offset);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte offset)
                => gmath.sll(a,offset);

        }

        public readonly struct VsllOp256<T> : IVShiftOp256<T>
            where T : unmanaged
        {
            public static VsllOp256<T> Op => default;

            public string Moniker => moniker<N256,T>("vsll");

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte offset)
                => ginx.vsll(x,offset);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte offset)
                => gmath.sll(a,offset);
        }

    }
}