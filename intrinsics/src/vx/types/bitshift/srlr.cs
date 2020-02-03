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
        public readonly struct Srlr128<T> : IVBinOp128D<T>
            where T : unmanaged
        {
            public const string Name = "vsrlr";

            public static HK.Vec128<T> hk => default;

            public static Srlr128<T> Op => default;

            public OpIdentity Moniker => identify(Name,hk);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> count) 
                => ginx.vsrlr(x,count);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T count) 
                => gmath.srl(a,convert<T,byte>(count));            
        }

        public readonly struct Srlr256<T> : IVBinOp256<T>
            where T : unmanaged
        {
            public const string Name = "vsrlr";

            public static HK.Vec256<T> hk => default;

            public static Srlr256<T> Op => default;

            public OpIdentity Moniker => identify(Name,hk);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> count) 
                => ginx.vsrlr(x,count);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T offset) 
                => gmath.srl(a,convert<T,byte>(offset));
        }
    }
}