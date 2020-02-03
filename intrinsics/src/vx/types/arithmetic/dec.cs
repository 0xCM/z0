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
        [NumericClosures(NumericKind.Integers)]
        public readonly struct Dec128<T> : IVUnaryOp128D<T>, IUnaryBlockedOp128<T>
            where T : unmanaged
        {
            public const string Name = "vdec";

            public static HK.Vec128<T> hk => default;

            public static Dec128<T> Op => default;

            public Moniker Moniker => identify(Name,hk);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x) 
                => ginx.vdec(x);
            
            [MethodImpl(Inline)]
            public T InvokeScalar(T a) 
                => gmath.dec(a);

            [MethodImpl(Inline)]
            public ref readonly Block128<T> Invoke(in Block128<T> a, in Block128<T> c)            
                => ref vblocks.vdec(a,c);
        }

        [NumericClosures(NumericKind.Integers)]
        public readonly struct Dec256<T> : IVUnaryOp256D<T>, IUnaryBlockedOp256<T>
            where T : unmanaged
        {
            public const string Name = "vdec";

            public static HK.Vec256<T> hk => default;

            public static Dec256<T> Op => default;

            public Moniker Moniker => identify(Name,hk);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x) 
                => ginx.vdec(x);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a) 
                => gmath.dec(a);

            [MethodImpl(Inline)]
            public ref readonly Block256<T> Invoke(in Block256<T> a, in Block256<T> c)            
                => ref vblocks.vdec(a,c);
        }
    }
}