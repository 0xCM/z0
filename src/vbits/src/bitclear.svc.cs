//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;
    using static VBitSvcTypes;

    partial class VBitSvc
    {
        [MethodImpl(Inline)]
        public static BitClear128<T> vbitclear<T>(N128 w, T t = default)
            where T : unmanaged
                => BitClear128<T>.Op;

        [MethodImpl(Inline)]
        public static BitClear256<T> vbitclear<T>(N256 w, T t = default)
            where T : unmanaged
                => BitClear256<T>.Op;
    }

    partial class VBitSvcTypes
    {
        [NumericClosures(NumericKind.Integers)]
        public readonly struct BitClear128<T> : ISVImm8x2UnaryOp128DApi<T>
            where T : unmanaged
        {
            public const string Name = "vbitclear";

            public Vec128Kind<T> VKind => default;

            public static BitClear128<T> Op => default;

            public OpIdentity Id => Identify.sfunc(Name,VKind);


            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte offset, byte count) 
                => vgbits.vbitclear(x,offset,count);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte b, byte c) 
                => gbits.bitclear(a, b, c);
        }

        [NumericClosures(NumericKind.Integers)]
        public readonly struct BitClear256<T> : ISVImm8x2UnaryOp256DApi<T>
            where T : unmanaged
        {
            public const string Name = "vbitclear";
             
            public Vec256Kind<T> VKind => default;

            public static BitClear256<T> Op => default;

            public OpIdentity Id => Identify.sfunc(Name,VKind);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte offset, byte count) 
                => vgbits.vbitclear(x,offset, count);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte b, byte c) 
                => gbits.bitclear(a, b, c);
        }
    }
}