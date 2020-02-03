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
        public readonly struct BitClear128<T> : IVUnaryOp128Imm8x2D<T>
            where T : unmanaged
        {
            public const string Name = "vbitclear";

            public static HK.Vec128<T> hk => default;

            public static BitClear128<T> Op => default;

            public OpIdentity Moniker => Identity.operation(Name,hk);


            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte offset, byte count) 
                => ginx.vbitclear(x,offset,count);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte b, byte c) 
                => gbits.bitclear(a, b, c);
        }

        [NumericClosures(NumericKind.Integers)]
        public readonly struct BitClear256<T> : IVUnaryOp256Imm8x2D<T>
            where T : unmanaged
        {
            public const string Name = "vbitclear";
             
            public static HK.Vec256<T> hk => default;

            public static BitClear256<T> Op => default;

            public OpIdentity Moniker => Identity.operation(Name,hk);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte offset, byte count) 
                => ginx.vbitclear(x,offset, count);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte b, byte c) 
                => gbits.bitclear(a, b, c);


        }
    }
}