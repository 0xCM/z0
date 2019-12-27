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
        public readonly struct Bsll128<T> : IVShiftOp128<T>
            where T : unmanaged
        {
            public static Bsll128<T> Op => default;

            public const string Name = "vbsll";

            public string Moniker => moniker<N128,T>(Name);

            [MethodImpl(Inline)]
            public Vector128<T> Invoke(Vector128<T> x, byte offset) => ginx.vbsll(x,offset);
            
        }

        public readonly struct Bsll256<T> : IVShiftOp256<T>
            where T : unmanaged
        {
            public static Bsll256<T> Op => default;

            public const string Name = "vbsll";

            public string Moniker => moniker<N256,T>(Name);

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector256<T> x, byte offset) => ginx.vbsll(x,offset);
        }    
    }
}