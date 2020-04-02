//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Core;

    partial class VSvcHosts
    {
        public readonly struct Concat2x128<T> : ISVMergeOp2x128x256Api<T>
            where T : unmanaged
        {
            public const string Name = "vconcat";

            public static Concat2x128<T> Op => default;

            public OpIdentity Id 
                => Identify.Op($"{Name}_2x128x{Identify.NumericType<T>()}");

            [MethodImpl(Inline)]
            public Vector256<T> Invoke(Vector128<T> x, Vector128<T> y) 
                => VCore.vconcat(x,y);           
        }
    }
}