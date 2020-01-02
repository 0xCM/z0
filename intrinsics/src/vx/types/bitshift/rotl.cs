//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        public readonly struct Rotl128<T> : IVShiftOp128D<T>
            where T : unmanaged
        {
            public static Rotl128<T> Op => default;

            public const string Name = "vrotl";

            public string Moniker => moniker<N128,T>(Name);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte offset) => ginx.vrotl(x,offset);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte offset) => gbits.rotl(a,offset);

        }

        public readonly struct Rotl256<T> : IVShiftOp256D<T>
            where T : unmanaged
        {
            public static Rotl256<T> Op => default;

            public const string Name = "vrotl";

            public string Moniker => moniker<N256,T>(Name);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte offset) => ginx.vrotl(x,offset);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte offset) => gbits.rotl(a,offset);
        }

                
    }

}