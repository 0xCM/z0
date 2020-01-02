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
        public abstract class CAnd<W,V,T> : VBinOpD<W,V,T>
            where W : unmanaged, ITypeNat
            where V : struct
            where T : unmanaged
        {
            public const string Name = "vand";

            [MethodImpl(Inline)]
            public override T InvokeScalar(T a, T b) => gmath.and(a,b);

            [MethodImpl(Inline)]
            protected override string GetOpName() => Name;
        }

        public sealed class CAnd128<T> : CAnd<N128,Vector128<T>,T>
            where T : unmanaged
        {
            public static CAnd128<T> Op => new CAnd128<T>();

            [MethodImpl(Inline)]
            public override Vector128<T> Invoke(Vector128<T> x, Vector128<T> y) => ginx.vand(x,y);
        }

        public sealed class CAnd256<T> : CAnd<N256,Vector256<T>,T>
            where T : unmanaged
        {
            public static CAnd256<T> Op => new CAnd256<T>();

            [MethodImpl(Inline)]
            public override Vector256<T> Invoke(Vector256<T> x, Vector256<T> y) => ginx.vand(x,y);

        }

        public readonly struct And128<T> : IVBinOp128D<T>
            where T : unmanaged
        {
            public static And128<T> Op => default;

            public const string Name = "vand";

            public string Moniker => moniker<N128,T>(Name);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, Vector128<T> y) => ginx.vand(x,y);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.and(a,b);
        }

        public readonly struct And256<T> : IVBinOp256D<T>
            where T : unmanaged
        {
            public static And256<T> Op => default;

            public const string Name = "vand";

            public string Moniker => moniker<N256,T>(Name);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, Vector256<T> y) => ginx.vand(x,y);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, T b) => gmath.and(a,b);
        }

    }
}