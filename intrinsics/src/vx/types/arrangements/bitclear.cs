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
        [PrimalClosures(PrimalKind.Integers)]
        public readonly struct BitClear128<T> : IVUnaryOp128Imm8x2D<T>
            where T : unmanaged
        {
            public const string Name = "vbitclear";

            public static BitClear128<T> Op => default;

            static N128 w => default;

            public Moniker Moniker => moniker<T>(Name,w);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte offset, byte count) => ginx.vbitclear(x,offset,count);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte b, byte c) => gbits.bitclear(a, b, c);
        }

        [PrimalClosures(PrimalKind.Integers)]
        public readonly struct BitClear256<T> : IVUnaryOp256Imm8x2D<T>
            where T : unmanaged
        {
            public const string Name = "vbitclear";
             
            public static BitClear256<T> Op => default;

            static N256 w => default;

            public Moniker Moniker => moniker<T>(Name,w);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte offset, byte count) => ginx.vbitclear(x,offset, count);

            [MethodImpl(Inline)]
            public T InvokeScalar(T a, byte b, byte c) => gbits.bitclear(a, b, c);


        }
    }
}