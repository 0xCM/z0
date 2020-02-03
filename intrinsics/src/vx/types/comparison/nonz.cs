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
        [NumericClosures(NumericKind.All)]
        public readonly struct NonZ128<T> : IVUnaryPred128D<T>, IUnaryBlockedPred128<T>
            where T : unmanaged
        {
            public static NonZ128<T> Op => default;

            public const string Name = "vnonz";

            static N128 w => default;

            public Moniker Moniker => identify<T>(Name,w);

            [MethodImpl(Inline)]
            public bit Invoke(Vector128<T> x) => ginx.vnonz(x);

            [MethodImpl(Inline)]
            public bit InvokeScalar(T a) => gmath.nonz(a);

            [MethodImpl(Inline)]
            public Span<bit> Invoke(in Block128<T> x, Span<bit> dst) 
                => vblocks.vnonz(x,dst);

        }

        [NumericClosures(NumericKind.All)]
        public readonly struct NonZ256<T> : IVUnaryPred256D<T>, IUnaryBlockedPred256<T>
            where T : unmanaged
        {
            public const string Name = "vnonz";

            static N256 w => default;

            public static NonZ256<T> Op => default;

            public Moniker Moniker => identify<T>(Name,w);

            [MethodImpl(Inline)]
            public bit Invoke(Vector256<T> x) => ginx.vnonz(x);

            [MethodImpl(Inline)]
            public bit InvokeScalar(T a) => gmath.nonz(a);

            [MethodImpl(Inline)]
            public Span<bit> Invoke(in Block256<T> x, Span<bit> dst) 
                => vblocks.vnonz(x,dst);

        }
    }
}