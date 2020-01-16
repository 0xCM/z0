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
        [PrimalClosures(PrimalKind.All)]
        public readonly struct Negate128<T> : IVUnaryOp128D<T>, IUnaryBlockedOp128<T>
            where T : unmanaged
        {
            public const string Name = "vnegate";

            public static Negate128<T> Op => default;

            static N128 w => default;

            public Moniker Moniker => moniker<T>(Name,w);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x) => ginx.vnegate(x);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a) => gmath.negate(a);

            [MethodImpl(Inline)]
            public ref readonly Block128<T> Invoke(in Block128<T> a, in Block128<T> c)            
                => ref vblocks.vnegate(a,c);

        }

        [PrimalClosures(PrimalKind.All)]
        public readonly struct Negate256<T> : IVUnaryOp256D<T>, IUnaryBlockedOp256<T>
            where T : unmanaged
        {
            public const string Name = "vnegate";

            public static Negate256<T> Op => default;

            static N256 w => default;

            public Moniker Moniker => moniker<T>(Name,w);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x) => ginx.vnegate(x);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a) => gmath.negate(a);

            [MethodImpl(Inline)]
            public ref readonly Block256<T> Invoke(in Block256<T> a, in Block256<T> c)            
                => ref vblocks.vnegate(a,c);

        }
    }
}