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
        public readonly struct Concat2x128<T> : IVMergeOp2x128x256<T>
            where T : unmanaged
        {
            public static Concat2x128<T> Op => default;

            public const string Name = "vconcat";

            public string Moniker => $"{Name}_2x128x{primalsig<T>()}";

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector128<T> x, Vector128<T> y) => ginx.vconcat(x,y);
            
        }
    }
}