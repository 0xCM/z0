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

    partial class Fixed    
    {
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> vector<T>(in Fixed256V src)
            where T : unmanaged
                => src.data.As<ulong,T>();

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector128<T> vector<T>(in Fixed128V src)
            where T : unmanaged
                => src.data.As<ulong,T>();

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Fixed128V fix<T>(Vector128<T> x)
            where T : unmanaged
                => Fixed128V.From(x);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Fixed256V fix<T>(Vector256<T> x)
            where T : unmanaged
                => Fixed256V.From(x);
    }
}